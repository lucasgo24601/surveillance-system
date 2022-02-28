Imports System.IO.Ports
Imports System.Data.OleDb

Imports MySql.Data.MySqlClient

Public Class Operating

    Public mtemp As Integer

    ' --------------------------------RS232屬性和物件----------------------------------------
    Public mRS232 As SerialPort
    Public mParity As Parity = Parity.None
    Public mPortName As String = ""
    Public mBaudRate As Integer = 38400
    Public mDataBit As Integer = 8
    Public mStopbit As StopBits = StopBits.One



    ' --------------------------------儀器解析後的各屬性欄位宣告----------------------------------------
    Public mData_CommandCode As String
    Public mData_PacketNumber As String
    Public mData_LQI As String
    Public mData_ReceiveNode As String
    Public mData_CommandLength As String
    Public mData_CommandEncoding As String
    Public mData_CommandValue As String
    Public mData_Checksum As String

    ' --------------------------------連結網路----------------------------------------
    Private Const DatabaseName As String = "Database"  '主資料表名稱
    Private Const Server As String = "127.0.0.1"       '登入IP
    Private Const UserName As String = "root"          '登入帳號
    Private Const Password As String = "database"      '登入密碼
    Private SQLConnection As MySqlConnection = New MySqlConnection

    Public Sub mSetBtnState(ByVal ComportString As String, ByVal IsRS232Setting As Boolean)

        If IsRS232Setting Then
            btnOpenComport.Text = ComportString
            btnOpenComport.Enabled = Not btnOpenComport.Enabled
            btnCloseComport.Enabled = Not btnCloseComport.Enabled
            btnSettingRS232.Enabled = Not btnSettingRS232.Enabled
        Else
            btnStart.Text = ComportString
            btnStart.Enabled = Not btnStart.Enabled
            btnSettingAutoValue.Enabled = Not btnSettingAutoValue.Enabled
            btnStop.Enabled = Not btnStop.Enabled
        End If

    End Sub

    Public Sub mRefreshValue()

        cboSendCommandCode.Text = mData_CommandCode
        cboSendPacketNumber.Text = mData_PacketNumber
        txtSendLQI.Text = mData_LQI
        cboSendReceiveNode.Text = mData_ReceiveNode
        txtSendCommandLength.Text = mData_CommandLength
        cboSendCommandEncoding.Text = mData_CommandEncoding
        txtSendCommandValue.Text = mData_CommandValue
        txtSendChecksum.Text = mData_Checksum

    End Sub

    Public Sub mConnectDatabase_Server()

        SQLConnection.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", Server, UserName, Password, DatabaseName)
        Try
            If SQLConnection.State = ConnectionState.Closed Then
                SQLConnection.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mDisConnectDatabase_Server()

        Try
            If SQLConnection.State = ConnectionState.Open Then
                SQLConnection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub mSeparationCommand(ByVal SplitString As String)

        mData_CommandCode = Mid(SplitString, 1, 1)
        mData_PacketNumber = Mid(SplitString, 2, 1)
        mData_LQI = Mid(SplitString, 3, 2)              '從str字串的第3個字元開始擷取2個字元
        mData_ReceiveNode = Mid(SplitString, 5, 4)
        mData_CommandLength = Mid(SplitString, 9, 2)
        mData_CommandEncoding = Mid(SplitString, 11, 2)
        mtemp = Convert.ToInt32(mData_CommandLength, 16)   '將字串轉換為16進制，再將資料轉為10進制
        mtemp = mtemp * 2                       '由於ip-link儀器協定表示式 設計為1Byte表示 =8 bits = 2 * 4 bits = 2個16進制表示  
        mData_CommandValue = Mid(SplitString, 13, mtemp - 2)      '減2是因為檢查碼在於指令最後兩個位置
        mData_Checksum = Mid(SplitString, 11 + mtemp, 2)

    End Sub                                                             '解析ip-link協定使其分離

    Public Sub mSave_AllDB(ByVal ReadData As String)

        '-----------------------------------------------------------------------------------------------------
        '因為溫度儀器設計，開機就會一直主動回傳資料，所以一旦通訊口被打開就會湧入溫度資料無須程式控制
        '導致：程式一方面傳送"詢問開關狀態指令"，節點回傳"當前開關狀態指令"時，一方面會與無時無刻湧入的溫度資料產生衝突進行串接
        '解決：判斷資料是否被串接，並進行分割，分割後再進行判斷是否還有被串接.....，直到資料正常即可存入
        '-----------------------------------------------------------------------------------------------------

        Delete.mConnectDatabase_Local() ' 連線本地資料庫

        Dim strSplit As String
        Dim count As Integer = 0

        Dim out As String = ""

        If (mtemp + 12 < Len(ReadData)) Then
            Do
                count += 1
                strSplit = Mid(ReadData, 1 + mtemp + 12, Len(ReadData) - mtemp + 12)                                    'str1=擷取後段指令
                ReadData = Mid(ReadData, 1, mData_CommandLength + 15)
                mSeparationCommand(strSplit)
                If mData_Checksum <> "" Then
                    UpData("beethoven", strSplit, "Split Count = " + count)
                End If
            Loop Until Not mtemp + 12 < Len(strSplit)
        End If

        Delete.mDisConnectDatabase_Local() ' - 儲存str至本地資料庫
    End Sub                                                                   '儲存指令至資料庫

    Private Function GetNumberColumns(ByVal Table As String)
        '相同用法，詳見mSelect函數註解說明
        Delete.mLocalDB_SQL = New OleDbCommand("Select Count(*) from " & Table, Delete.mLocalDB)
        Delete.mLocalDB_ReadBuff = Delete.mLocalDB_SQL.ExecuteReader()
        Dim out As String = ""
        While Delete.mLocalDB_ReadBuff.Read()
            out += Delete.mLocalDB_ReadBuff.Item("Expr1000") & vbCrLf
        End While
        Return out

    End Function                                             '取得當前資料庫的欄數

    Private Sub UpData(ByVal Table As String, ByVal Command As String, ByVal marke As String)

        Dim CountColumns As String = ""
        Dim SendCMD As String = ""
        Dim Data As String = ""

        txtRecvCommandCode.Text = mData_CommandCode
        txtRecvPacketNumber.Text = mData_PacketNumber
        txtRecvLQI.Text = mData_LQI
        txtRecvReceiveNode.Text = mData_ReceiveNode
        txtRecvCommandLength.Text = mData_CommandLength
        txtRecvCommandEncoding.Text = mData_CommandEncoding
        txtRecvCommandValue.Text = mData_CommandValue
        txtRecvChecksum.Text = mData_Checksum

        If Table = "beethoven" Then

            CountColumns = GetNumberColumns(Table)                                                       '獲取當前資料庫欄數以便自動編號
            '--------------------------------------上傳本地資料庫------------------------------------------
            SendCMD = "insert into beethoven values(" + Chr(34) + CountColumns + Chr(34) + "," _
                                        + Chr(34) + Command + Chr(34) + "," _
                                        + Chr(34) + mData_CommandCode + Chr(34) + "," _
                                        + Chr(34) + mData_PacketNumber + Chr(34) + "," _
                                        + Chr(34) + mData_LQI + Chr(34) + "," _
                                        + Chr(34) + mData_ReceiveNode + Chr(34) + "," _
                                        + Chr(34) + mData_CommandLength + Chr(34) + "," _
                                        + Chr(34) + mData_CommandEncoding + Chr(34) + "," _
                                        + Chr(34) + mData_CommandValue + Chr(34) + "," _
                                        + Chr(34) + mData_Checksum & Chr(34) + "," _
                                        + Chr(34) + Now() & Chr(34) + "," _
                                        + Chr(34) + marke + Chr(34) + ");"
            Delete.mProcessCMD_Local(SendCMD)
            '--------------------------------------上傳本地資料庫------------------------------------------

            '--------------------------------------上傳網路資料庫------------------------------------------
            SendCMD = "INSERT INTO command(檔案編號,原始資料,A,B,C,D,E,F,W,X) VALUES(" + Chr(34) + CountColumns + Chr(34) + "," _
                                        + Chr(34) + Command + Chr(34) + "," _
                                        + Chr(34) + mData_CommandCode + Chr(34) + "," _
                                        + Chr(34) + mData_PacketNumber + Chr(34) + "," _
                                        + Chr(34) + mData_LQI + Chr(34) + "," _
                                        + Chr(34) + mData_ReceiveNode + Chr(34) + "," _
                                        + Chr(34) + mData_CommandLength + Chr(34) + "," _
                                        + Chr(34) + mData_CommandEncoding + Chr(34) + "," _
                                        + Chr(34) + mData_CommandValue + Chr(34) + "," _
                                        + Chr(34) + mData_Checksum & Chr(34) + ");"
            ProcessCMD_Server(SendCMD)
            '--------------------------------------上傳網路資料庫------------------------------------------
        End If

    End Sub

    Public Sub ProcessCMD_Server(ByRef Command As String)
        Dim CMDObject As MySqlCommand = New MySqlCommand
        If SQLConnection.State = ConnectionState.Closed Then   '判斷SQLConnection是否關閉
            SQLConnection.Open()
        End If

        With CMDObject
            .CommandText = Command
            .Connection = SQLConnection
            If SQLConnection.State = ConnectionState.Open Then  '判斷SQLConnection是否開啟
                .ExecuteNonQuery()         '使用command物件中的ExecuteNonQuery可以進行OleDb的刪除、新增、修改資料庫資料 
                SQLConnection.Close()
            End If
        End With
        SQLConnection.Dispose()
    End Sub                                                                 '存入網路程式

    Public Function WebCMD()

        ' 檢查網頁區專用的指令資料表是否有內容
        ' 有的話進行剪下，將指令存放於此Return Value
        Dim ServerLinkFormat As String
        Dim ReadCommand As String = "select sam from send"

        ServerLinkFormat = "server=" + Server + ";uid=" + UserName + ";pwd=" + Password + ";database=" + DatabaseName

        Dim DatabaseObject As New MySqlConnection(ServerLinkFormat)
        DatabaseObject.Open()
        Dim SQLResult As New MySqlCommand("select sam from send", DatabaseObject)
        Dim ReadStearm As MySqlDataReader = SQLResult.ExecuteReader()
        Dim ReadResult As String = ""

        While ReadStearm.Read()
            ReadResult += ReadStearm.Item("sam")
        End While

        ReadStearm.Close()

        ProcessCMD_Server("Delete from send;")

        Return ReadResult

    End Function

End Class