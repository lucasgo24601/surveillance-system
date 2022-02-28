<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblRecvTime = New System.Windows.Forms.Label()
        Me.txtRecvTime = New System.Windows.Forms.TextBox()
        Me.lblTransformValue = New System.Windows.Forms.Label()
        Me.txtTransformValue = New System.Windows.Forms.TextBox()
        Me.lblSourceData = New System.Windows.Forms.Label()
        Me.txtSourceData = New System.Windows.Forms.TextBox()
        Me.lblDataNumber = New System.Windows.Forms.Label()
        Me.txtDataNumber = New System.Windows.Forms.TextBox()
        Me.btnDeleteOther = New System.Windows.Forms.Button()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(389, 332)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 37)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "結束"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(260, 332)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 37)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "刪除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblRecvTime
        '
        Me.lblRecvTime.AutoSize = True
        Me.lblRecvTime.Location = New System.Drawing.Point(40, 144)
        Me.lblRecvTime.Name = "lblRecvTime"
        Me.lblRecvTime.Size = New System.Drawing.Size(65, 12)
        Me.lblRecvTime.TabIndex = 30
        Me.lblRecvTime.Text = "接收時間："
        '
        'txtRecvTime
        '
        Me.txtRecvTime.Location = New System.Drawing.Point(111, 141)
        Me.txtRecvTime.Name = "txtRecvTime"
        Me.txtRecvTime.Size = New System.Drawing.Size(163, 22)
        Me.txtRecvTime.TabIndex = 29
        '
        'lblTransformValue
        '
        Me.lblTransformValue.AutoSize = True
        Me.lblTransformValue.Location = New System.Drawing.Point(40, 109)
        Me.lblTransformValue.Name = "lblTransformValue"
        Me.lblTransformValue.Size = New System.Drawing.Size(65, 12)
        Me.lblTransformValue.TabIndex = 28
        Me.lblTransformValue.Text = "轉換結果："
        '
        'txtTransformValue
        '
        Me.txtTransformValue.Location = New System.Drawing.Point(111, 106)
        Me.txtTransformValue.Name = "txtTransformValue"
        Me.txtTransformValue.Size = New System.Drawing.Size(128, 22)
        Me.txtTransformValue.TabIndex = 27
        '
        'lblSourceData
        '
        Me.lblSourceData.AutoSize = True
        Me.lblSourceData.Location = New System.Drawing.Point(40, 74)
        Me.lblSourceData.Name = "lblSourceData"
        Me.lblSourceData.Size = New System.Drawing.Size(65, 12)
        Me.lblSourceData.TabIndex = 26
        Me.lblSourceData.Text = "原始資料："
        '
        'txtSourceData
        '
        Me.txtSourceData.Location = New System.Drawing.Point(111, 71)
        Me.txtSourceData.Name = "txtSourceData"
        Me.txtSourceData.Size = New System.Drawing.Size(128, 22)
        Me.txtSourceData.TabIndex = 25
        '
        'lblDataNumber
        '
        Me.lblDataNumber.AutoSize = True
        Me.lblDataNumber.Location = New System.Drawing.Point(40, 34)
        Me.lblDataNumber.Name = "lblDataNumber"
        Me.lblDataNumber.Size = New System.Drawing.Size(65, 12)
        Me.lblDataNumber.TabIndex = 24
        Me.lblDataNumber.Text = "資料編號："
        '
        'txtDataNumber
        '
        Me.txtDataNumber.Location = New System.Drawing.Point(111, 31)
        Me.txtDataNumber.Name = "txtDataNumber"
        Me.txtDataNumber.Size = New System.Drawing.Size(36, 22)
        Me.txtDataNumber.TabIndex = 23
        '
        'btnDeleteOther
        '
        Me.btnDeleteOther.Location = New System.Drawing.Point(149, 332)
        Me.btnDeleteOther.Name = "btnDeleteOther"
        Me.btnDeleteOther.Size = New System.Drawing.Size(90, 37)
        Me.btnDeleteOther.TabIndex = 31
        Me.btnDeleteOther.Text = "刪除另一筆"
        Me.btnDeleteOther.UseVisualStyleBackColor = True
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(28, 332)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(90, 37)
        Me.btnDeleteAll.TabIndex = 32
        Me.btnDeleteAll.Text = "刪除全部"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 398)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnDeleteOther)
        Me.Controls.Add(Me.lblRecvTime)
        Me.Controls.Add(Me.txtRecvTime)
        Me.Controls.Add(Me.lblTransformValue)
        Me.Controls.Add(Me.txtTransformValue)
        Me.Controls.Add(Me.lblSourceData)
        Me.Controls.Add(Me.txtSourceData)
        Me.Controls.Add(Me.lblDataNumber)
        Me.Controls.Add(Me.txtDataNumber)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Delete"
        Me.Text = "Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblRecvTime As System.Windows.Forms.Label
    Friend WithEvents txtRecvTime As System.Windows.Forms.TextBox
    Friend WithEvents lblTransformValue As System.Windows.Forms.Label
    Friend WithEvents txtTransformValue As System.Windows.Forms.TextBox
    Friend WithEvents lblSourceData As System.Windows.Forms.Label
    Friend WithEvents txtSourceData As System.Windows.Forms.TextBox
    Friend WithEvents lblDataNumber As System.Windows.Forms.Label
    Friend WithEvents txtDataNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteOther As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
End Class
