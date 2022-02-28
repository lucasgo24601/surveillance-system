<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOperating = New System.Windows.Forms.Button()
        Me.btnDatabase = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picMinimized = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.lblNowPage = New System.Windows.Forms.Label()
        Me.lblTipNowPage = New System.Windows.Forms.Label()
        Me.PanelMainControl = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picMinimized, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "數位雲端監控系統"
        '
        'btnOperating
        '
        Me.btnOperating.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOperating.Location = New System.Drawing.Point(0, 0)
        Me.btnOperating.Name = "btnOperating"
        Me.btnOperating.Size = New System.Drawing.Size(200, 83)
        Me.btnOperating.TabIndex = 1
        Me.btnOperating.Text = "操作系統"
        Me.btnOperating.UseVisualStyleBackColor = True
        '
        'btnDatabase
        '
        Me.btnDatabase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDatabase.Location = New System.Drawing.Point(0, 0)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(200, 83)
        Me.btnDatabase.TabIndex = 2
        Me.btnDatabase.Text = "資料庫系統"
        Me.btnDatabase.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Location = New System.Drawing.Point(0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(200, 85)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "離開"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 609)
        Me.Panel1.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 259)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 85)
        Me.Panel6.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnOperating)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 176)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 83)
        Me.Panel5.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDatabase)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 93)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 83)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 93)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.picMinimized)
        Me.Panel2.Controls.Add(Me.picClose)
        Me.Panel2.Controls.Add(Me.lblNowPage)
        Me.Panel2.Controls.Add(Me.lblTipNowPage)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(996, 93)
        Me.Panel2.TabIndex = 5
        '
        'picMinimized
        '
        Me.picMinimized.Image = CType(resources.GetObject("picMinimized.Image"), System.Drawing.Image)
        Me.picMinimized.Location = New System.Drawing.Point(896, 28)
        Me.picMinimized.Name = "picMinimized"
        Me.picMinimized.Size = New System.Drawing.Size(36, 36)
        Me.picMinimized.TabIndex = 5
        Me.picMinimized.TabStop = False
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(948, 28)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(36, 36)
        Me.picClose.TabIndex = 4
        Me.picClose.TabStop = False
        '
        'lblNowPage
        '
        Me.lblNowPage.AutoSize = True
        Me.lblNowPage.Font = New System.Drawing.Font("Consolas", 26.25!)
        Me.lblNowPage.Location = New System.Drawing.Point(267, 28)
        Me.lblNowPage.Name = "lblNowPage"
        Me.lblNowPage.Size = New System.Drawing.Size(189, 41)
        Me.lblNowPage.TabIndex = 3
        Me.lblNowPage.Text = "Temp Page"
        '
        'lblTipNowPage
        '
        Me.lblTipNowPage.AutoSize = True
        Me.lblTipNowPage.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipNowPage.Location = New System.Drawing.Point(34, 28)
        Me.lblTipNowPage.Name = "lblTipNowPage"
        Me.lblTipNowPage.Size = New System.Drawing.Size(227, 41)
        Me.lblTipNowPage.TabIndex = 2
        Me.lblTipNowPage.Text = "Now Page : "
        '
        'PanelMainControl
        '
        Me.PanelMainControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMainControl.Location = New System.Drawing.Point(200, 93)
        Me.PanelMainControl.Name = "PanelMainControl"
        Me.PanelMainControl.Size = New System.Drawing.Size(996, 516)
        Me.PanelMainControl.TabIndex = 6
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1196, 609)
        Me.Controls.Add(Me.PanelMainControl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "Welcom_to_my_world"
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picMinimized, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnOperating As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents Panel1 As Panel
    Private WithEvents Panel6 As Panel
    Private WithEvents Panel5 As Panel
    Private WithEvents Panel4 As Panel
    Private WithEvents Panel3 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents btnDatabase As System.Windows.Forms.Button
    Private WithEvents picMinimized As PictureBox
    Private WithEvents picClose As PictureBox
    Private WithEvents lblNowPage As Label
    Private WithEvents lblTipNowPage As Label
    Friend WithEvents PanelMainControl As Panel
End Class
