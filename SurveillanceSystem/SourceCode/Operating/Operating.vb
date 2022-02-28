'---------------------------------------------------------------------------------
'變數及副程式名稱前面有"m"表示在Module中
'---------------------------------------------------------------------------------
Imports System.IO.Ports
Imports System.Text

Public Class Operating

    Delegate Function DelShowData(ByVal str As String) As String
    Dim Frequency As Integer = 100    ' 設定監控偵測頻率
    Dim Bytes As Integer = 1          ' 設定幾組Byte觸發一次事件
    Dim Alarm As Integer = 0          ' 0 = 未設定過警報狀態 ， 1 = 開啟警報狀態 ， 2 = 關閉警報狀態

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each SingalePortName As String In SerialPort.GetPortNames
            cboComports.Items.Add(SingalePortName)
        Next
        cboComports.Sorted = True
        If (cboComports.Items.Count > 0) Then
            cboComports.SelectedIndex = 0
        End If

        cboParity.Text = "None"
        cboStopBit.Text = "one"
        cboBaudRate.Text = 38400
        cboDataBit.Text = 8
        txtFrequency.Text = Frequency
        txtByte.Text = Bytes


    End Sub

    Private Sub btnOpenComport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenComport.Click

        btnSettingRS232.PerformClick()

        If mRS232 Is Nothing Then
            mConnectDatabase_Server()
            mPortName = cboComports.SelectedItem.ToString
            mRS232 = New SerialPort(mPortName, mBaudRate, mParity, mDataBit, mStopbit)
            mRS232.Encoding = Encoding.Default ' 設定編碼方式
        End If

        If Not mRS232.IsOpen Then   '尚未開啟    
            mRS232.Open() '開啟通訊埠
        Else
            MsgBox("通訊埠開啟錯誤(可能通訊埠已被開啟)")
        End If

        mSetBtnState("開啟中...", True)

    End Sub '開啟通訊埠

    Private Sub btnCloseComport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseComport.Click

        If mRS232 Is Nothing OrElse Not mRS232.IsOpen Then '通訊埠尚未開啟
            MsgBox("通訊埠尚未開啟")
        Else
            mRS232.Close()
        End If

        mSetBtnState("開啟通訊閘", True)

    End Sub '關閉通訊埠

    Private Sub btnSettingRS232_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingRS232.Click

        Select Case cboParity.Text
            Case "None"
                mParity = Parity.None
            Case "Even"
                mParity = Parity.Even
            Case "Odd"
                mParity = Parity.Odd
            Case "Mark"
                mParity = Parity.Mark
            Case "Space"
                mParity = Parity.Space
        End Select
        Select Case cboStopBit.Text
            Case "None"
                mStopbit = StopBits.None
            Case "One"
                mStopbit = StopBits.One
            Case "Two"
                mStopbit = StopBits.Two
            Case "OnePointFive"
                mStopbit = StopBits.OnePointFive
        End Select
        mBaudRate = cboBaudRate.Text
        mDataBit = cboDataBit.Text

        mRS232.Parity = mParity
        mRS232.StopBits = mStopbit
        mRS232.BaudRate = mBaudRate
        mRS232.DataBits = mDataBit

        MsgBox("設定完成")

    End Sub '設定RS232屬性

    Private Sub btnProcessIP_Link_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessIP_Link.Click

        Process.Start(".\IP_Link\IP-Link 2220.exe")

    End Sub '開啟設定IP-LINK程式

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        Timer1.Start()
        mRS232.ReceivedBytesThreshold = Bytes   ' 當接收N個Byte時觸發DataReceived
        AddHandler mRS232.DataReceived, AddressOf mRS232_DataReceived  ' 新增名為：mRS232_DataReceived事件 關聯此事件之條件為RS232.DataReceived此屬性
        mSetBtnState("啟動中..", False)

    End Sub '啟動

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

        Timer1.Stop()
        RemoveHandler mRS232.DataReceived, AddressOf mRS232_DataReceived  '中斷連結mRS232_DataReceived事件
        mSetBtnState("啟動", False)

    End Sub '停止

    Private Sub btnSettingAutoValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingAutoValue.Click

        Frequency = Val(txtFrequency.Text)
        Bytes = Val(txtByte.Text)
        MsgBox("設定成功")

    End Sub '設定自動偵測按鈕

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        Dim SendCommand As String = ""
        If txtSendCMD.Text.Length > 0 Then
            SendCommand = txtSendCMD.Text
        Else
            SendCommand = SendCommand & cboSendCommandCode.Text
            SendCommand = SendCommand & cboSendPacketNumber.Text
            SendCommand = SendCommand & txtSendLQI.Text
            SendCommand = SendCommand & cboSendReceiveNode.Text
            SendCommand = SendCommand & txtSendCommandLength.Text
            SendCommand = SendCommand & cboSendCommandEncoding.Text
            SendCommand = SendCommand & txtSendCommandValue.Text
        End If

        txtSendCMD.Text = SendCommand
        SendCommand = SendCommand & Me.SendCommandToRS232(SendCommand) ' 傳送指令後將原指令串接檢查碼

        mSeparationCommand(SendCommand) ' 解析IP-LINK協定
        cboSendCommandCode.Text = mData_CommandCode
        cboSendPacketNumber.Text = mData_PacketNumber
        txtSendLQI.Text = mData_LQI
        cboSendReceiveNode.Text = mData_ReceiveNode
        txtSendCommandLength.Text = mData_CommandLength
        cboSendCommandEncoding.Text = mData_CommandEncoding
        txtSendCommandValue.Text = mData_CommandValue
        txtSendChecksum.Text = mData_Checksum
        mSave_AllDB(SendCommand)                    '儲存指令至資料庫內的表單

    End Sub '傳送

    Private Sub btnReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceive.Click

        txtRecvCMD.Text = ""                '清空文字方塊
        txtRecvCMD.Text = ReadDataFromRS232()        '取得資料

    End Sub '接收資料

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        cboSendCommandCode.Text = ""
        cboSendPacketNumber.Text = ""
        cboSendReceiveNode.Text = ""
        cboSendCommandEncoding.Text = ""
        txtSendLQI.Text = ""
        txtSendCommandLength.Text = ""
        txtSendCommandValue.Text = ""
        txtSendChecksum.Text = ""
        txtRecvCMD.Text = ""
        txtSendCMD.Text = ""

    End Sub 'Clear

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' 每10秒更新一次溫度，因為溫度數據不需要以毫秒進行偵測
        Dim CMD As String = "INSERT INTO observer(溫度,開關,時間) VALUES(" + Chr(34) + " " + Chr(34) + "," _
                                                     + Chr(34) + Mid(mData_CommandValue, 3, 2) + Chr(34) + "," _
                                                     + Chr(34) + Now + Chr(34) + ");"

        ProcessCMD_Server(CMD)
    End Sub

    Private Sub mRS232_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)

        DisplayData(ReadDataFromRS232()) ' 因為觸發事件於次執行序，需呼叫代理人程式

    End Sub             'DataReceived事件，呼叫代理人

    Private Function ReadDataFromRS232()

        Dim str As String = ""
        Dim daBUF() As Byte
        Dim n As Integer, i As Integer
        mRS232.ReadTimeout = 1000                                  ' 設定最大延遲時間
        n = mRS232.BytesToRead                                     ' n=取得資料的長度並以byte為個數做計算
        If n > 0 Then                   '
            ReDim daBUF(n - 1)                                     ' 定義dabuf(0) ~ dabuf(n-1) 一共有n個位置 0~(n-1)
            n = mRS232.Read(daBUF, 0, mRS232.BytesToRead)          ' 取得資料並置入dabuf陣列中
            For i = 0 To n - 1
                str = str & BinToHex(daBUF(i))                     ' 因為資料以陣列方式存放，故將資料進行串接並進行轉換禁制
            Next                                                   ' str即為資料
        End If

        Return str
    End Function

    Private Function BinToHex(ByVal byteValue As Byte) As String

        BinToHex = Hex(byteValue)
        If Len(BinToHex) = 1 Then
            BinToHex = "0" & BinToHex
        End If

    End Function

    Private Sub DisplayData(ByVal str As String)

        ' 執行代理人程式後，呼叫jacky副程式並將資料丟入，即可使用本執行緒物件
        If Me.txtRecvCMD.InvokeRequired Then
            Dim s As New DelShowData(AddressOf ProcesCommand)
            ' 宣告一個代理人並委派 ShowData程序來顯示資料
            ' ProcesCommand 為真正顯示資料工作程式
            Me.Invoke(s, New Object() {str})
        End If

    End Sub

    Private Function ProcesCommand(ByVal strReadData As String)

        Dim SwitchCMD As String = ""
        Dim ServerCommand As String = ""
        Dim CMD As String = "INSERT INTO observer(溫度,開關,時間) VALUES(" + Chr(34) + " " + Chr(34) + "," _
                                                     + Chr(34) + Mid(mData_CommandValue, 3, 2) + Chr(34) + "," _
                                                     + Chr(34) + Now + Chr(34) + ");"

        mSeparationCommand(strReadData) ' 先將當前接受到的資料解析及更新變數
        mSave_AllDB(strReadData)

        ServerCommand = WebCMD() ' 此處使用者可以由網頁下達指令，此指令會讀取網頁端的指令
        If ServerCommand.Length > 0 Then
            SendCommandToRS232(ServerCommand)
        End If

        SwitchCMD = "807F000102AC05" ' 指令功能：當前磁簧開關狀態為何的指令 (0 or 1)
        SwitchCMD = SwitchCMD & SendCommandToRS232(SwitchCMD) ' 串接檢查碼
        mSeparationCommand(SwitchCMD)
        mRefreshValue()
        mSave_AllDB(SwitchCMD)

        SwitchCMD = ""
        If mData_CommandValue = "0001" Then ' When open 
            If Alarm = 0 Or Alarm = 2 Then
                SwitchCMD = "807F000103AD0401"      '指令功能：令鳥鳴器叫
                SwitchCMD = SwitchCMD & SendCommandToRS232(SwitchCMD)
                mSeparationCommand(SwitchCMD)
                mRefreshValue()
                mSave_AllDB(SwitchCMD)
                ProcessCMD_Server(CMD)
            End If
            Alarm = 1
        ElseIf mData_CommandValue = "0000" Then
            If Alarm = 0 Or Alarm = 1 Then
                SwitchCMD = "807F000103AD0400"      '指令功能：令鳥鳴器不叫
                SwitchCMD = SwitchCMD & SendCommandToRS232(SwitchCMD)
                mSeparationCommand(SwitchCMD)
                mRefreshValue()
                mSave_AllDB(SwitchCMD)
                ProcessCMD_Server(CMD)
            End If
            Alarm = 2
        End If

        delay(543 * Frequency) '經數據處理並將數據取平均值 可得543537約莫1秒 但由於一秒靈敏度太低 故偵測頻率採用0.1秒偵測一次

        Return ""
    End Function

    Private Sub delay(ByVal delay As Integer)
        'Dim nowtime As String
        'Dim nowtime2 As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To delay
            For j = 0 To 800
                ' nowtime = Now()          '此處為判斷時脈程式，因程式碼越多則失真越多，故無法採用傳值給程式計算數據，採用人工計算平均值，可獲取較佳的數據
                ' nowtime2 = Now()
                ' a = a + 1
                ' If nowtime <> nowtime2 Then
                ' MsgBox(a)
                ' a = 0
                ' End If
            Next
        Next
    End Sub

    Private Function SendCommandToRS232(ByVal strCMD As String)

        Dim L As Integer = 0 ' 此處註解參考指令為807F000103AD0401
        Dim i As Integer, si As Integer
        Dim buf() As Byte ' buf()陣列為資料
        L = Len(strCMD) / 2 ' L=16/2=8
        ReDim buf(L - 1) ' buf(0)~buf(7)
        For i = 1 To L ' 1~8  8times
            buf(i - 1) = CByte(Val("&H" + Mid$(strCMD, i * 2 - 1, 2))) ' set buf(0)~buf(7)
        Next
        ReDim Preserve buf(L) ' buf(0) ~ buf(8)
        buf(L) = 0 ' buf(8) = xor檢查碼
        For si = 0 To L - 1 ' 0~7  8times
            buf(L) = buf(L) Xor buf(si) ' buf(8)=buf(8) XOR buf(count)
        Next
        mRS232.Write(buf, 0, L + 1) ' 透過RS232傳送至

        Return buf(L) ' 將指令串接檢查碼並檢查，送出指令
    End Function

End Class