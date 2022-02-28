Public Class Delete

    Private Sub Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DataNumber As String
        DataNumber = InputBox("請輸入欲要刪除的資料編號：", "查詢")
        txtDataNumber.Text = mSelect_Local("Temperature", DataNumber, 1)
        txtSourceData.Text = mSelect_Local("Temperature", DataNumber, 2)
        txtTransformValue.Text = mSelect_Local("Temperature", DataNumber, 3)
        txtRecvTime.Text = mSelect_Local("Temperature", DataNumber, 4)

    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click

        If MsgBox("是否確定刪除全部資料", 4 + 64, "警告") = 6 Then
            MsgBox("刪除成功")
            txtDataNumber.Text = ""
            txtSourceData.Text = ""
            txtRecvTime.Text = ""
            txtTransformValue.Text = ""

            mProcessCMD_Local("DELETE FROM " & "Temperature" & ";")
        Else
            MsgBox("刪除失敗")
        End If

    End Sub

    Private Sub btnDeleteOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOther.Click

        Dim DataNumber As String
        txtDataNumber.Text = ""
        txtSourceData.Text = ""
        txtRecvTime.Text = ""
        txtTransformValue.Text = ""
        DataNumber = InputBox("請輸入欲要刪除的資料編號：", "查詢")
        txtDataNumber.Text = mSelect_Local("Temperature", DataNumber, 1)
        txtSourceData.Text = mSelect_Local("Temperature", DataNumber, 2)
        txtTransformValue.Text = mSelect_Local("Temperature", DataNumber, 3)
        txtRecvTime.Text = mSelect_Local("Temperature", DataNumber, 4)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If MsgBox("是否確定刪除", 4 + 64, "警告")= 6 Then
            MsgBox("刪除成功")
            txtDataNumber.Text = ""
            txtSourceData.Text = ""
            txtRecvTime.Text = ""
            txtTransformValue.Text = ""

            mProcessCMD_Local("DELETE FROM " & "Temperature" & " WHERE 檔案編號 =" & txtDataNumber.Text & ";")
        Else
            MsgBox("刪除失敗")
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

End Class