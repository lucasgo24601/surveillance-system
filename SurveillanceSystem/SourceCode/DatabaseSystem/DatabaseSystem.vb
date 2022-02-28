Imports System.Data.OleDb

Public Class DatabaseSystem

    Private Sub DatabaseSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1_Select.DataSource = Nothing

    End Sub

    Private Sub cboColumn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboColumn.SelectedIndexChanged

        If cboColumn.SelectedIndex = 0 Then
            txtValue.Enabled = False
        Else
            txtValue.Enabled = True
        End If

    End Sub

    Private Sub btnCreateTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateTable.Click

        Delete.mProcessCMD_Local("CREATE TABLE Temperature (檔案編號 int,原始資料 nvarchar(100),轉換結果 nvarchar(100),接收時間  nvarchar(100),PRIMARY KEY (檔案編號) );")

    End Sub

    Private Sub btnDeleteData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteData.Click

        Delete.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Application.Exit()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sql As String = ""

        Delete.mConnectDatabase_Local()

        Select Case (cboColumn.Text)
            Case "全部欄位"
                sql = "select * from Temperature;"
            Case "檔案編號"
                sql = "select * from Temperature where " & cboColumn.Text & cboSelectRange.Text & txtValue.Text & ";"
            Case "原始資料"
                sql = "select * from Temperature where " + cboColumn.Text & cboSelectRange.Text & Chr(34) + txtValue.Text + Chr(34) & ";"
            Case "轉換結果"
                sql = "select * from Temperaturewhere " + cboColumn.Text & cboSelectRange.Text & Chr(34) + txtValue.Text + Chr(34) & ";"
            Case "接收時間"
                sql = "select * from Temperature where " + cboColumn.Text & cboSelectRange.Text & Chr(34) + txtValue.Text + Chr(34) & ";"
        End Select

        Delete.mProcessCMD_Local(sql)

        Dim DataSet_Select As New DataSet
        Dim SelectObject As New OleDbDataAdapter(sql, Delete.mLocalDB)
        SelectObject.Fill(DataSet_Select, "Temperature")
        Dim Tablel As DataTable
        Tablel = DataSet_Select.Tables("Temperature")

        DataGridView1_Select.DataSource = Tablel.DefaultView

        Delete.mDisConnectDatabase_Local()
    End Sub

End Class