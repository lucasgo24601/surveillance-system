Public Class MainForm

    Dim IsDoMove As Boolean = False
    Dim FormPoint As Point = New Point
    Dim MousPoint As Point = New Point

    Private Sub btnDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatabase.Click

        PanelMainControl.Controls.Clear()
        PanelMainControl.Controls.Add(New DatabaseSystem)
        lblNowPage.Text = btnDatabase.Text
    End Sub

    Private Sub btnOperating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperating.Click

        PanelMainControl.Controls.Clear()
        PanelMainControl.Controls.Add(New Operating)
        lblNowPage.Text = btnOperating.Text

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub picMinimized_Click(sender As Object, e As EventArgs) Handles picMinimized.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click

        Me.Close()

    End Sub

    Private Sub FormAllPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMainControl.MouseDown, Panel3.MouseDown, Panel2.MouseDown, Panel1.MouseDown

        IsDoMove = True
        FormPoint = New Point(Me.Location.X, Me.Location.Y)
        MousPoint = New Point(MousePosition.X, MousePosition.Y)

    End Sub

    Private Sub FormAllPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelMainControl.MouseUp, Panel3.MouseUp, Panel2.MouseUp, Panel1.MouseUp

        IsDoMove = False

    End Sub

    Private Sub FormAllPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMainControl.MouseMove, Panel3.MouseMove, Panel2.MouseMove, Panel1.MouseMove

        If IsDoMove = False Then
            Return
            Me.Location = New Point(FormPoint.X + (MousePosition.X - MousPoint.X),
                                    FormPoint.Y + (MousePosition.Y - MousPoint.Y))
        End If

    End Sub

End Class