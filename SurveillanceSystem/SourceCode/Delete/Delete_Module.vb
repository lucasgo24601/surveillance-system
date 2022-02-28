Imports System.Data.OleDb

Public Class Delete
    ' --------------------------------連結本地端Database----------------------------------------

    Public Shared mLocalDB As OleDbConnection
    Public Shared mLocalDB_SQL As OleDbCommand
    Public Shared mLocalDB_ReadBuff As OleDbDataReader

    Public Shared Function mSelect_Local(ByVal Table As String, ByVal Number As String, ByVal Column As Integer)

        mConnectDatabase_Local()

        mLocalDB_SQL = New OleDbCommand("SELECT * FROM " & Table & "where 檔案編號=" & Number & ";", mLocalDB)
        mLocalDB_ReadBuff = mLocalDB_SQL.ExecuteReader()
        Dim out As String = ""
        '---------------------------------------對資料表進行SQL指令查詢，並建立一個虛擬查詢介面--------------------------------------------------------------------------
        '---------------------------------------將虛擬查詢介面的某一欄位整筆資料丟入out變數--------------------------------------------------------------------------
        '等效sql為   Select 檔案編號/原始資料/轉換... From Temperature  , out=sql執行完傳回值
        Select Case (Column)
            Case 1
                While mLocalDB_ReadBuff.Read()
                    out += mLocalDB_ReadBuff.Item("檔案編號") & vbCrLf
                End While
            Case 2
                While mLocalDB_ReadBuff.Read()
                    out += mLocalDB_ReadBuff.Item("原始資料") & vbCrLf
                End While
            Case 3
                While mLocalDB_ReadBuff.Read()
                    out += mLocalDB_ReadBuff.Item("轉換結果") & vbCrLf
                End While
            Case 4
                While mLocalDB_ReadBuff.Read()
                    out += mLocalDB_ReadBuff.Item("接收時間") & vbCrLf
                End While
            Case 5
                While mLocalDB_ReadBuff.Read()
                    out += mLocalDB_ReadBuff.Item("原始資料") & vbCrLf
                End While
        End Select
        '---------------------------------------將虛擬查詢介面的某一欄位整筆資料丟入out變數--------------------------------------------------------------------------
        mLocalDB_ReadBuff.Close()

        mDisConnectDatabase_Local()

        Return out

    End Function            '使用前須注意是否為已開啟模式 (mConnectDatabase_Local Mode)

    Public Shared Function mConnectDatabase_Local()

        mLocalDB = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=data.mdb")
        Try
            If mLocalDB.State = ConnectionState.Closed Then
                mLocalDB.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function                                                                                    '連線本地資料庫

    Public Shared Function mDisConnectDatabase_Local()

        Try
            If mLocalDB.State = ConnectionState.Open Then
                mLocalDB.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function                                                                                   '離線本地資料庫

    Public Shared Function mProcessCMD_Local(ByVal SQLCMD As String)

        mConnectDatabase_Local()
        mLocalDB_SQL = New OleDbCommand(SQLCMD, mLocalDB)
        mLocalDB_SQL.ExecuteNonQuery()
        mDisConnectDatabase_Local()

    End Function

End Class
