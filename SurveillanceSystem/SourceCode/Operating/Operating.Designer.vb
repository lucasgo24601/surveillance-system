<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operating
    Inherits System.Windows.Forms.UserControl

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
        Me.components = New System.ComponentModel.Container()
        Me.btnSettingRS232 = New System.Windows.Forms.Button()
        Me.btnOpenComport = New System.Windows.Forms.Button()
        Me.cboComports = New System.Windows.Forms.ComboBox()
        Me.txtSendCMD = New System.Windows.Forms.TextBox()
        Me.btnCloseComport = New System.Windows.Forms.Button()
        Me.txtRecvCMD = New System.Windows.Forms.TextBox()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnProcessIP_Link = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDataBit = New System.Windows.Forms.ComboBox()
        Me.lblComports = New System.Windows.Forms.Label()
        Me.cboBaudRate = New System.Windows.Forms.ComboBox()
        Me.cboStopBit = New System.Windows.Forms.ComboBox()
        Me.lblParity = New System.Windows.Forms.Label()
        Me.lblBaudRate = New System.Windows.Forms.Label()
        Me.lblDataBit = New System.Windows.Forms.Label()
        Me.lblStopBit = New System.Windows.Forms.Label()
        Me.cboParity = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtByte = New System.Windows.Forms.TextBox()
        Me.lblByte = New System.Windows.Forms.Label()
        Me.txtFrequency = New System.Windows.Forms.TextBox()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.btnSettingAutoValue = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRecvChecksum = New System.Windows.Forms.TextBox()
        Me.lblRecvChecksum = New System.Windows.Forms.Label()
        Me.txtRecvCommandValue = New System.Windows.Forms.TextBox()
        Me.lblRecvCommandValue = New System.Windows.Forms.Label()
        Me.txtRecvCommandEncoding = New System.Windows.Forms.TextBox()
        Me.lblRecvCommandEncoding = New System.Windows.Forms.Label()
        Me.txtRecvLQI = New System.Windows.Forms.TextBox()
        Me.lblRecvSendLQI = New System.Windows.Forms.Label()
        Me.txtRecvCommandLength = New System.Windows.Forms.TextBox()
        Me.lblRecvCommandLength = New System.Windows.Forms.Label()
        Me.txtRecvReceiveNode = New System.Windows.Forms.TextBox()
        Me.lblRecvReceiveNode = New System.Windows.Forms.Label()
        Me.txtRecvPacketNumber = New System.Windows.Forms.TextBox()
        Me.lblRecvPacketNumber = New System.Windows.Forms.Label()
        Me.txtRecvCommandCode = New System.Windows.Forms.TextBox()
        Me.lblRecvCommandCode = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblRecvCMD = New System.Windows.Forms.Label()
        Me.lblSendCMD = New System.Windows.Forms.Label()
        Me.txtSendChecksum = New System.Windows.Forms.TextBox()
        Me.txtSendCommandValue = New System.Windows.Forms.TextBox()
        Me.txtSendCommandLength = New System.Windows.Forms.TextBox()
        Me.txtSendLQI = New System.Windows.Forms.TextBox()
        Me.cboSendPacketNumber = New System.Windows.Forms.ComboBox()
        Me.cboSendCommandEncoding = New System.Windows.Forms.ComboBox()
        Me.cboSendReceiveNode = New System.Windows.Forms.ComboBox()
        Me.cboSendCommandCode = New System.Windows.Forms.ComboBox()
        Me.lblSendChecksum = New System.Windows.Forms.Label()
        Me.lblSendCommandValue = New System.Windows.Forms.Label()
        Me.lblSendCommandEncoding = New System.Windows.Forms.Label()
        Me.lblSendLQI = New System.Windows.Forms.Label()
        Me.lblSendCommandLength = New System.Windows.Forms.Label()
        Me.lblSendReceiveNode = New System.Windows.Forms.Label()
        Me.lblSendPacketNumber = New System.Windows.Forms.Label()
        Me.lblSendCommandCode = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSettingRS232
        '
        Me.btnSettingRS232.Location = New System.Drawing.Point(195, 108)
        Me.btnSettingRS232.Name = "btnSettingRS232"
        Me.btnSettingRS232.Size = New System.Drawing.Size(101, 38)
        Me.btnSettingRS232.TabIndex = 0
        Me.btnSettingRS232.Text = "設定RS232屬性"
        Me.btnSettingRS232.UseVisualStyleBackColor = True
        '
        'btnOpenComport
        '
        Me.btnOpenComport.Location = New System.Drawing.Point(195, 18)
        Me.btnOpenComport.Name = "btnOpenComport"
        Me.btnOpenComport.Size = New System.Drawing.Size(101, 38)
        Me.btnOpenComport.TabIndex = 1
        Me.btnOpenComport.Text = "開啟通訊閘"
        Me.btnOpenComport.UseVisualStyleBackColor = True
        '
        'cboComports
        '
        Me.cboComports.FormattingEnabled = True
        Me.cboComports.Location = New System.Drawing.Point(89, 33)
        Me.cboComports.Name = "cboComports"
        Me.cboComports.Size = New System.Drawing.Size(82, 20)
        Me.cboComports.TabIndex = 2
        '
        'txtSendCMD
        '
        Me.txtSendCMD.Location = New System.Drawing.Point(117, 98)
        Me.txtSendCMD.Multiline = True
        Me.txtSendCMD.Name = "txtSendCMD"
        Me.txtSendCMD.Size = New System.Drawing.Size(763, 28)
        Me.txtSendCMD.TabIndex = 3
        Me.txtSendCMD.Text = "807F000103AD0400"
        '
        'btnCloseComport
        '
        Me.btnCloseComport.Enabled = False
        Me.btnCloseComport.Location = New System.Drawing.Point(195, 62)
        Me.btnCloseComport.Name = "btnCloseComport"
        Me.btnCloseComport.Size = New System.Drawing.Size(101, 38)
        Me.btnCloseComport.TabIndex = 4
        Me.btnCloseComport.Text = "關閉通訊閘"
        Me.btnCloseComport.UseVisualStyleBackColor = True
        '
        'txtRecvCMD
        '
        Me.txtRecvCMD.Location = New System.Drawing.Point(117, 142)
        Me.txtRecvCMD.Multiline = True
        Me.txtRecvCMD.Name = "txtRecvCMD"
        Me.txtRecvCMD.Size = New System.Drawing.Size(763, 26)
        Me.txtRecvCMD.TabIndex = 5
        '
        'btnReceive
        '
        Me.btnReceive.Location = New System.Drawing.Point(356, 194)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(92, 53)
        Me.btnReceive.TabIndex = 7
        Me.btnReceive.Text = "接收"
        Me.btnReceive.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(429, 351)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 38)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "離開"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(117, 194)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(92, 53)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "傳送"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnProcessIP_Link
        '
        Me.btnProcessIP_Link.Location = New System.Drawing.Point(195, 152)
        Me.btnProcessIP_Link.Name = "btnProcessIP_Link"
        Me.btnProcessIP_Link.Size = New System.Drawing.Size(101, 38)
        Me.btnProcessIP_Link.TabIndex = 12
        Me.btnProcessIP_Link.Text = "執行設定IP-LINK 程式"
        Me.btnProcessIP_Link.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.cboDataBit)
        Me.GroupBox1.Controls.Add(Me.btnProcessIP_Link)
        Me.GroupBox1.Controls.Add(Me.lblComports)
        Me.GroupBox1.Controls.Add(Me.btnSettingRS232)
        Me.GroupBox1.Controls.Add(Me.cboBaudRate)
        Me.GroupBox1.Controls.Add(Me.cboComports)
        Me.GroupBox1.Controls.Add(Me.cboStopBit)
        Me.GroupBox1.Controls.Add(Me.lblParity)
        Me.GroupBox1.Controls.Add(Me.lblBaudRate)
        Me.GroupBox1.Controls.Add(Me.lblDataBit)
        Me.GroupBox1.Controls.Add(Me.lblStopBit)
        Me.GroupBox1.Controls.Add(Me.btnOpenComport)
        Me.GroupBox1.Controls.Add(Me.cboParity)
        Me.GroupBox1.Controls.Add(Me.btnCloseComport)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 199)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "設定屬性"
        '
        'cboDataBit
        '
        Me.cboDataBit.FormattingEnabled = True
        Me.cboDataBit.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboDataBit.Location = New System.Drawing.Point(89, 172)
        Me.cboDataBit.Name = "cboDataBit"
        Me.cboDataBit.Size = New System.Drawing.Size(82, 20)
        Me.cboDataBit.TabIndex = 65
        '
        'lblComports
        '
        Me.lblComports.AutoSize = True
        Me.lblComports.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblComports.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblComports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblComports.Location = New System.Drawing.Point(6, 33)
        Me.lblComports.Name = "lblComports"
        Me.lblComports.Size = New System.Drawing.Size(59, 16)
        Me.lblComports.TabIndex = 64
        Me.lblComports.Text = "通訊閘"
        '
        'cboBaudRate
        '
        Me.cboBaudRate.FormattingEnabled = True
        Me.cboBaudRate.Items.AddRange(New Object() {"57600", "38400", "19200", "9600", "4800", "2400", "1200"})
        Me.cboBaudRate.Location = New System.Drawing.Point(89, 141)
        Me.cboBaudRate.Name = "cboBaudRate"
        Me.cboBaudRate.Size = New System.Drawing.Size(82, 20)
        Me.cboBaudRate.TabIndex = 63
        '
        'cboStopBit
        '
        Me.cboStopBit.FormattingEnabled = True
        Me.cboStopBit.Items.AddRange(New Object() {"None", "One", "Two", "OnePointFive"})
        Me.cboStopBit.Location = New System.Drawing.Point(89, 103)
        Me.cboStopBit.Name = "cboStopBit"
        Me.cboStopBit.Size = New System.Drawing.Size(82, 20)
        Me.cboStopBit.TabIndex = 62
        '
        'lblParity
        '
        Me.lblParity.AutoSize = True
        Me.lblParity.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblParity.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblParity.Location = New System.Drawing.Point(6, 68)
        Me.lblParity.Name = "lblParity"
        Me.lblParity.Size = New System.Drawing.Size(50, 16)
        Me.lblParity.TabIndex = 57
        Me.lblParity.Text = "Parity"
        '
        'lblBaudRate
        '
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBaudRate.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblBaudRate.Location = New System.Drawing.Point(6, 141)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(77, 16)
        Me.lblBaudRate.TabIndex = 56
        Me.lblBaudRate.Text = "BaudRate"
        '
        'lblDataBit
        '
        Me.lblDataBit.AutoSize = True
        Me.lblDataBit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDataBit.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblDataBit.Location = New System.Drawing.Point(6, 176)
        Me.lblDataBit.Name = "lblDataBit"
        Me.lblDataBit.Size = New System.Drawing.Size(62, 16)
        Me.lblDataBit.TabIndex = 58
        Me.lblDataBit.Text = "DataBit"
        '
        'lblStopBit
        '
        Me.lblStopBit.AutoSize = True
        Me.lblStopBit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStopBit.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblStopBit.Location = New System.Drawing.Point(6, 107)
        Me.lblStopBit.Name = "lblStopBit"
        Me.lblStopBit.Size = New System.Drawing.Size(61, 16)
        Me.lblStopBit.TabIndex = 59
        Me.lblStopBit.Text = "StopBit"
        '
        'cboParity
        '
        Me.cboParity.AutoCompleteCustomSource.AddRange(New String() {"None", "Odd", "Even", "Mark", "Space"})
        Me.cboParity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
        Me.cboParity.Location = New System.Drawing.Point(89, 64)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(82, 20)
        Me.cboParity.TabIndex = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.Controls.Add(Me.txtByte)
        Me.GroupBox2.Controls.Add(Me.lblByte)
        Me.GroupBox2.Controls.Add(Me.txtFrequency)
        Me.GroupBox2.Controls.Add(Me.lblFrequency)
        Me.GroupBox2.Controls.Add(Me.btnSettingAutoValue)
        Me.GroupBox2.Controls.Add(Me.btnStart)
        Me.GroupBox2.Controls.Add(Me.btnStop)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 199)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "自動偵測設定"
        '
        'txtByte
        '
        Me.txtByte.Location = New System.Drawing.Point(132, 111)
        Me.txtByte.Name = "txtByte"
        Me.txtByte.Size = New System.Drawing.Size(86, 22)
        Me.txtByte.TabIndex = 69
        '
        'lblByte
        '
        Me.lblByte.AutoSize = True
        Me.lblByte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblByte.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblByte.Location = New System.Drawing.Point(22, 113)
        Me.lblByte.Name = "lblByte"
        Me.lblByte.Size = New System.Drawing.Size(104, 16)
        Me.lblByte.TabIndex = 68
        Me.lblByte.Text = "N組Byte觸發"
        '
        'txtFrequency
        '
        Me.txtFrequency.Location = New System.Drawing.Point(132, 78)
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.Size = New System.Drawing.Size(86, 22)
        Me.txtFrequency.TabIndex = 67
        '
        'lblFrequency
        '
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFrequency.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblFrequency.Location = New System.Drawing.Point(18, 78)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(108, 16)
        Me.lblFrequency.TabIndex = 66
        Me.lblFrequency.Text = "偵測頻率(ms)"
        '
        'btnSettingAutoValue
        '
        Me.btnSettingAutoValue.Location = New System.Drawing.Point(16, 141)
        Me.btnSettingAutoValue.Name = "btnSettingAutoValue"
        Me.btnSettingAutoValue.Size = New System.Drawing.Size(202, 38)
        Me.btnSettingAutoValue.TabIndex = 0
        Me.btnSettingAutoValue.Text = "設定自動偵測屬性"
        Me.btnSettingAutoValue.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(16, 23)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(101, 38)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "啟動"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(123, 23)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(101, 38)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "停止"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox3.Controls.Add(Me.txtRecvChecksum)
        Me.GroupBox3.Controls.Add(Me.lblRecvChecksum)
        Me.GroupBox3.Controls.Add(Me.txtRecvCommandValue)
        Me.GroupBox3.Controls.Add(Me.lblRecvCommandValue)
        Me.GroupBox3.Controls.Add(Me.txtRecvCommandEncoding)
        Me.GroupBox3.Controls.Add(Me.lblRecvCommandEncoding)
        Me.GroupBox3.Controls.Add(Me.txtRecvLQI)
        Me.GroupBox3.Controls.Add(Me.lblRecvSendLQI)
        Me.GroupBox3.Controls.Add(Me.txtRecvCommandLength)
        Me.GroupBox3.Controls.Add(Me.lblRecvCommandLength)
        Me.GroupBox3.Controls.Add(Me.txtRecvReceiveNode)
        Me.GroupBox3.Controls.Add(Me.lblRecvReceiveNode)
        Me.GroupBox3.Controls.Add(Me.txtRecvPacketNumber)
        Me.GroupBox3.Controls.Add(Me.lblRecvPacketNumber)
        Me.GroupBox3.Controls.Add(Me.txtRecvCommandCode)
        Me.GroupBox3.Controls.Add(Me.lblRecvCommandCode)
        Me.GroupBox3.Location = New System.Drawing.Point(583, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 199)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "接收欄"
        '
        'txtRecvChecksum
        '
        Me.txtRecvChecksum.Location = New System.Drawing.Point(289, 166)
        Me.txtRecvChecksum.Name = "txtRecvChecksum"
        Me.txtRecvChecksum.Size = New System.Drawing.Size(86, 22)
        Me.txtRecvChecksum.TabIndex = 81
        '
        'lblRecvChecksum
        '
        Me.lblRecvChecksum.AutoSize = True
        Me.lblRecvChecksum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvChecksum.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvChecksum.Location = New System.Drawing.Point(207, 167)
        Me.lblRecvChecksum.Name = "lblRecvChecksum"
        Me.lblRecvChecksum.Size = New System.Drawing.Size(59, 16)
        Me.lblRecvChecksum.TabIndex = 80
        Me.lblRecvChecksum.Text = "檢查碼"
        '
        'txtRecvCommandValue
        '
        Me.txtRecvCommandValue.Location = New System.Drawing.Point(289, 59)
        Me.txtRecvCommandValue.Multiline = True
        Me.txtRecvCommandValue.Name = "txtRecvCommandValue"
        Me.txtRecvCommandValue.Size = New System.Drawing.Size(86, 98)
        Me.txtRecvCommandValue.TabIndex = 79
        '
        'lblRecvCommandValue
        '
        Me.lblRecvCommandValue.AutoSize = True
        Me.lblRecvCommandValue.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvCommandValue.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvCommandValue.Location = New System.Drawing.Point(207, 60)
        Me.lblRecvCommandValue.Name = "lblRecvCommandValue"
        Me.lblRecvCommandValue.Size = New System.Drawing.Size(76, 16)
        Me.lblRecvCommandValue.TabIndex = 78
        Me.lblRecvCommandValue.Text = "指令內容"
        '
        'txtRecvCommandEncoding
        '
        Me.txtRecvCommandEncoding.Location = New System.Drawing.Point(289, 21)
        Me.txtRecvCommandEncoding.Name = "txtRecvCommandEncoding"
        Me.txtRecvCommandEncoding.Size = New System.Drawing.Size(86, 22)
        Me.txtRecvCommandEncoding.TabIndex = 77
        '
        'lblRecvCommandEncoding
        '
        Me.lblRecvCommandEncoding.AutoSize = True
        Me.lblRecvCommandEncoding.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvCommandEncoding.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvCommandEncoding.Location = New System.Drawing.Point(207, 22)
        Me.lblRecvCommandEncoding.Name = "lblRecvCommandEncoding"
        Me.lblRecvCommandEncoding.Size = New System.Drawing.Size(76, 16)
        Me.lblRecvCommandEncoding.TabIndex = 76
        Me.lblRecvCommandEncoding.Text = "指令編碼"
        '
        'txtRecvLQI
        '
        Me.txtRecvLQI.Location = New System.Drawing.Point(104, 93)
        Me.txtRecvLQI.Name = "txtRecvLQI"
        Me.txtRecvLQI.Size = New System.Drawing.Size(86, 22)
        Me.txtRecvLQI.TabIndex = 75
        '
        'lblRecvSendLQI
        '
        Me.lblRecvSendLQI.AutoSize = True
        Me.lblRecvSendLQI.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvSendLQI.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvSendLQI.Location = New System.Drawing.Point(62, 93)
        Me.lblRecvSendLQI.Name = "lblRecvSendLQI"
        Me.lblRecvSendLQI.Size = New System.Drawing.Size(36, 16)
        Me.lblRecvSendLQI.TabIndex = 74
        Me.lblRecvSendLQI.Text = "LQI"
        '
        'txtRecvCommandLength
        '
        Me.txtRecvCommandLength.Location = New System.Drawing.Point(104, 161)
        Me.txtRecvCommandLength.Name = "txtRecvCommandLength"
        Me.txtRecvCommandLength.Size = New System.Drawing.Size(86, 22)
        Me.txtRecvCommandLength.TabIndex = 73
        '
        'lblRecvCommandLength
        '
        Me.lblRecvCommandLength.AutoSize = True
        Me.lblRecvCommandLength.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvCommandLength.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvCommandLength.Location = New System.Drawing.Point(22, 162)
        Me.lblRecvCommandLength.Name = "lblRecvCommandLength"
        Me.lblRecvCommandLength.Size = New System.Drawing.Size(76, 16)
        Me.lblRecvCommandLength.TabIndex = 72
        Me.lblRecvCommandLength.Text = "指令總長"
        '
        'txtRecvReceiveNode
        '
        Me.txtRecvReceiveNode.Location = New System.Drawing.Point(104, 126)
        Me.txtRecvReceiveNode.Name = "txtRecvReceiveNode"
        Me.txtRecvReceiveNode.Size = New System.Drawing.Size(86, 22)
        Me.txtRecvReceiveNode.TabIndex = 71
        '
        'lblRecvReceiveNode
        '
        Me.lblRecvReceiveNode.AutoSize = True
        Me.lblRecvReceiveNode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvReceiveNode.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvReceiveNode.Location = New System.Drawing.Point(22, 126)
        Me.lblRecvReceiveNode.Name = "lblRecvReceiveNode"
        Me.lblRecvReceiveNode.Size = New System.Drawing.Size(76, 16)
        Me.lblRecvReceiveNode.TabIndex = 70
        Me.lblRecvReceiveNode.Text = "出端節點"
        '
        'txtRecvPacketNumber
        '
        Me.txtRecvPacketNumber.Location = New System.Drawing.Point(104, 60)
        Me.txtRecvPacketNumber.Name = "txtRecvPacketNumber"
        Me.txtRecvPacketNumber.Size = New System.Drawing.Size(86, 22)
        Me.txtRecvPacketNumber.TabIndex = 69
        '
        'lblRecvPacketNumber
        '
        Me.lblRecvPacketNumber.AutoSize = True
        Me.lblRecvPacketNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvPacketNumber.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvPacketNumber.Location = New System.Drawing.Point(22, 62)
        Me.lblRecvPacketNumber.Name = "lblRecvPacketNumber"
        Me.lblRecvPacketNumber.Size = New System.Drawing.Size(76, 16)
        Me.lblRecvPacketNumber.TabIndex = 68
        Me.lblRecvPacketNumber.Text = "封包序號"
        '
        'txtRecvCommandCode
        '
        Me.txtRecvCommandCode.Location = New System.Drawing.Point(104, 23)
        Me.txtRecvCommandCode.Multiline = True
        Me.txtRecvCommandCode.Name = "txtRecvCommandCode"
        Me.txtRecvCommandCode.Size = New System.Drawing.Size(86, 22)
        Me.txtRecvCommandCode.TabIndex = 67
        '
        'lblRecvCommandCode
        '
        Me.lblRecvCommandCode.AutoSize = True
        Me.lblRecvCommandCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvCommandCode.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvCommandCode.Location = New System.Drawing.Point(22, 23)
        Me.lblRecvCommandCode.Name = "lblRecvCommandCode"
        Me.lblRecvCommandCode.Size = New System.Drawing.Size(76, 16)
        Me.lblRecvCommandCode.TabIndex = 66
        Me.lblRecvCommandCode.Text = "指令代碼"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Controls.Add(Me.lblRecvCMD)
        Me.GroupBox4.Controls.Add(Me.lblSendCMD)
        Me.GroupBox4.Controls.Add(Me.txtSendChecksum)
        Me.GroupBox4.Controls.Add(Me.txtSendCommandValue)
        Me.GroupBox4.Controls.Add(Me.txtSendCommandLength)
        Me.GroupBox4.Controls.Add(Me.txtSendLQI)
        Me.GroupBox4.Controls.Add(Me.cboSendPacketNumber)
        Me.GroupBox4.Controls.Add(Me.cboSendCommandEncoding)
        Me.GroupBox4.Controls.Add(Me.cboSendReceiveNode)
        Me.GroupBox4.Controls.Add(Me.cboSendCommandCode)
        Me.GroupBox4.Controls.Add(Me.lblSendChecksum)
        Me.GroupBox4.Controls.Add(Me.lblSendCommandValue)
        Me.GroupBox4.Controls.Add(Me.lblSendCommandEncoding)
        Me.GroupBox4.Controls.Add(Me.lblSendLQI)
        Me.GroupBox4.Controls.Add(Me.lblSendCommandLength)
        Me.GroupBox4.Controls.Add(Me.lblSendReceiveNode)
        Me.GroupBox4.Controls.Add(Me.lblSendPacketNumber)
        Me.GroupBox4.Controls.Add(Me.btnReceive)
        Me.GroupBox4.Controls.Add(Me.lblSendCommandCode)
        Me.GroupBox4.Controls.Add(Me.btnSend)
        Me.GroupBox4.Controls.Add(Me.txtSendCMD)
        Me.GroupBox4.Controls.Add(Me.txtRecvCMD)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(967, 280)
        Me.GroupBox4.TabIndex = 82
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "手動傳輸欄"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(619, 194)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 53)
        Me.btnClear.TabIndex = 92
        Me.btnClear.Text = "清除"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblRecvCMD
        '
        Me.lblRecvCMD.AutoSize = True
        Me.lblRecvCMD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecvCMD.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRecvCMD.Location = New System.Drawing.Point(22, 150)
        Me.lblRecvCMD.Name = "lblRecvCMD"
        Me.lblRecvCMD.Size = New System.Drawing.Size(76, 16)
        Me.lblRecvCMD.TabIndex = 90
        Me.lblRecvCMD.Text = "接收指令"
        '
        'lblSendCMD
        '
        Me.lblSendCMD.AutoSize = True
        Me.lblSendCMD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendCMD.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendCMD.Location = New System.Drawing.Point(22, 98)
        Me.lblSendCMD.Name = "lblSendCMD"
        Me.lblSendCMD.Size = New System.Drawing.Size(76, 16)
        Me.lblSendCMD.TabIndex = 89
        Me.lblSendCMD.Text = "傳送指令"
        '
        'txtSendChecksum
        '
        Me.txtSendChecksum.Enabled = False
        Me.txtSendChecksum.Location = New System.Drawing.Point(824, 56)
        Me.txtSendChecksum.Name = "txtSendChecksum"
        Me.txtSendChecksum.Size = New System.Drawing.Size(56, 22)
        Me.txtSendChecksum.TabIndex = 88
        '
        'txtSendCommandValue
        '
        Me.txtSendCommandValue.Location = New System.Drawing.Point(636, 56)
        Me.txtSendCommandValue.Name = "txtSendCommandValue"
        Me.txtSendCommandValue.Size = New System.Drawing.Size(160, 22)
        Me.txtSendCommandValue.TabIndex = 87
        '
        'txtSendCommandLength
        '
        Me.txtSendCommandLength.Location = New System.Drawing.Point(417, 56)
        Me.txtSendCommandLength.Name = "txtSendCommandLength"
        Me.txtSendCommandLength.Size = New System.Drawing.Size(80, 22)
        Me.txtSendCommandLength.TabIndex = 86
        '
        'txtSendLQI
        '
        Me.txtSendLQI.Location = New System.Drawing.Point(231, 58)
        Me.txtSendLQI.Name = "txtSendLQI"
        Me.txtSendLQI.Size = New System.Drawing.Size(34, 22)
        Me.txtSendLQI.TabIndex = 85
        '
        'cboSendPacketNumber
        '
        Me.cboSendPacketNumber.FormattingEnabled = True
        Me.cboSendPacketNumber.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"})
        Me.cboSendPacketNumber.Location = New System.Drawing.Point(117, 58)
        Me.cboSendPacketNumber.Name = "cboSendPacketNumber"
        Me.cboSendPacketNumber.Size = New System.Drawing.Size(81, 20)
        Me.cboSendPacketNumber.TabIndex = 84
        '
        'cboSendCommandEncoding
        '
        Me.cboSendCommandEncoding.FormattingEnabled = True
        Me.cboSendCommandEncoding.Items.AddRange(New Object() {"81", "82", "83", "85", "86", "87", "8B", "8C", "8D", "8F", "90", "95", "97", "99", "9B", "9C", "9D", "AA", "AB", "AC", "AD", "AE", "AF", "B0"})
        Me.cboSendCommandEncoding.Location = New System.Drawing.Point(526, 58)
        Me.cboSendCommandEncoding.Name = "cboSendCommandEncoding"
        Me.cboSendCommandEncoding.Size = New System.Drawing.Size(78, 20)
        Me.cboSendCommandEncoding.TabIndex = 83
        '
        'cboSendReceiveNode
        '
        Me.cboSendReceiveNode.FormattingEnabled = True
        Me.cboSendReceiveNode.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cboSendReceiveNode.Location = New System.Drawing.Point(285, 58)
        Me.cboSendReceiveNode.Name = "cboSendReceiveNode"
        Me.cboSendReceiveNode.Size = New System.Drawing.Size(95, 20)
        Me.cboSendReceiveNode.TabIndex = 82
        '
        'cboSendCommandCode
        '
        Me.cboSendCommandCode.FormattingEnabled = True
        Me.cboSendCommandCode.Items.AddRange(New Object() {"8", "A"})
        Me.cboSendCommandCode.Location = New System.Drawing.Point(25, 58)
        Me.cboSendCommandCode.Name = "cboSendCommandCode"
        Me.cboSendCommandCode.Size = New System.Drawing.Size(72, 20)
        Me.cboSendCommandCode.TabIndex = 81
        '
        'lblSendChecksum
        '
        Me.lblSendChecksum.AutoSize = True
        Me.lblSendChecksum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendChecksum.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendChecksum.Location = New System.Drawing.Point(821, 30)
        Me.lblSendChecksum.Name = "lblSendChecksum"
        Me.lblSendChecksum.Size = New System.Drawing.Size(59, 16)
        Me.lblSendChecksum.TabIndex = 80
        Me.lblSendChecksum.Text = "檢查碼"
        '
        'lblSendCommandValue
        '
        Me.lblSendCommandValue.AutoSize = True
        Me.lblSendCommandValue.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendCommandValue.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendCommandValue.Location = New System.Drawing.Point(642, 30)
        Me.lblSendCommandValue.Name = "lblSendCommandValue"
        Me.lblSendCommandValue.Size = New System.Drawing.Size(76, 16)
        Me.lblSendCommandValue.TabIndex = 78
        Me.lblSendCommandValue.Text = "指令內容"
        '
        'lblSendCommandEncoding
        '
        Me.lblSendCommandEncoding.AutoSize = True
        Me.lblSendCommandEncoding.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendCommandEncoding.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendCommandEncoding.Location = New System.Drawing.Point(528, 30)
        Me.lblSendCommandEncoding.Name = "lblSendCommandEncoding"
        Me.lblSendCommandEncoding.Size = New System.Drawing.Size(76, 16)
        Me.lblSendCommandEncoding.TabIndex = 76
        Me.lblSendCommandEncoding.Text = "指令編碼"
        '
        'lblSendLQI
        '
        Me.lblSendLQI.AutoSize = True
        Me.lblSendLQI.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendLQI.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendLQI.Location = New System.Drawing.Point(230, 30)
        Me.lblSendLQI.Name = "lblSendLQI"
        Me.lblSendLQI.Size = New System.Drawing.Size(36, 16)
        Me.lblSendLQI.TabIndex = 74
        Me.lblSendLQI.Text = "LQI"
        '
        'lblSendCommandLength
        '
        Me.lblSendCommandLength.AutoSize = True
        Me.lblSendCommandLength.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendCommandLength.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendCommandLength.Location = New System.Drawing.Point(421, 30)
        Me.lblSendCommandLength.Name = "lblSendCommandLength"
        Me.lblSendCommandLength.Size = New System.Drawing.Size(76, 16)
        Me.lblSendCommandLength.TabIndex = 72
        Me.lblSendCommandLength.Text = "指令總長"
        '
        'lblSendReceiveNode
        '
        Me.lblSendReceiveNode.AutoSize = True
        Me.lblSendReceiveNode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendReceiveNode.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendReceiveNode.Location = New System.Drawing.Point(287, 30)
        Me.lblSendReceiveNode.Name = "lblSendReceiveNode"
        Me.lblSendReceiveNode.Size = New System.Drawing.Size(93, 16)
        Me.lblSendReceiveNode.TabIndex = 70
        Me.lblSendReceiveNode.Text = "受信端節點"
        '
        'lblSendPacketNumber
        '
        Me.lblSendPacketNumber.AutoSize = True
        Me.lblSendPacketNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendPacketNumber.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendPacketNumber.Location = New System.Drawing.Point(122, 30)
        Me.lblSendPacketNumber.Name = "lblSendPacketNumber"
        Me.lblSendPacketNumber.Size = New System.Drawing.Size(76, 16)
        Me.lblSendPacketNumber.TabIndex = 68
        Me.lblSendPacketNumber.Text = "封包序號"
        '
        'lblSendCommandCode
        '
        Me.lblSendCommandCode.AutoSize = True
        Me.lblSendCommandCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSendCommandCode.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSendCommandCode.Location = New System.Drawing.Point(22, 30)
        Me.lblSendCommandCode.Name = "lblSendCommandCode"
        Me.lblSendCommandCode.Size = New System.Drawing.Size(76, 16)
        Me.lblSendCommandCode.TabIndex = 66
        Me.lblSendCommandCode.Text = "指令代碼"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'Operating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button7)
        Me.Name = "Operating"
        Me.Size = New System.Drawing.Size(986, 510)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSettingRS232 As System.Windows.Forms.Button
    Friend WithEvents btnOpenComport As System.Windows.Forms.Button
    Friend WithEvents cboComports As System.Windows.Forms.ComboBox
    Friend WithEvents txtSendCMD As System.Windows.Forms.TextBox
    Friend WithEvents btnCloseComport As System.Windows.Forms.Button
    Friend WithEvents txtRecvCMD As System.Windows.Forms.TextBox
    Friend WithEvents btnReceive As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnProcessIP_Link As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblComports As System.Windows.Forms.Label
    Friend WithEvents cboBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents cboStopBit As System.Windows.Forms.ComboBox
    Friend WithEvents lblParity As System.Windows.Forms.Label
    Friend WithEvents lblBaudRate As System.Windows.Forms.Label
    Friend WithEvents lblDataBit As System.Windows.Forms.Label
    Friend WithEvents lblStopBit As System.Windows.Forms.Label
    Friend WithEvents cboParity As System.Windows.Forms.ComboBox
    Friend WithEvents cboDataBit As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSettingAutoValue As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents txtByte As System.Windows.Forms.TextBox
    Friend WithEvents lblByte As System.Windows.Forms.Label
    Friend WithEvents txtFrequency As System.Windows.Forms.TextBox
    Friend WithEvents lblFrequency As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRecvChecksum As System.Windows.Forms.TextBox
    Friend WithEvents lblRecvChecksum As System.Windows.Forms.Label
    Friend WithEvents txtRecvCommandValue As System.Windows.Forms.TextBox
    Friend WithEvents lblRecvCommandValue As System.Windows.Forms.Label
    Friend WithEvents txtRecvCommandEncoding As System.Windows.Forms.TextBox
    Friend WithEvents lblRecvCommandEncoding As System.Windows.Forms.Label
    Friend WithEvents txtRecvLQI As System.Windows.Forms.TextBox
    Friend WithEvents lblRecvSendLQI As System.Windows.Forms.Label
    Friend WithEvents txtRecvCommandLength As System.Windows.Forms.TextBox
    Friend WithEvents lblRecvCommandLength As System.Windows.Forms.Label
    Friend WithEvents txtRecvReceiveNode As System.Windows.Forms.TextBox
    Friend WithEvents lblRecvReceiveNode As System.Windows.Forms.Label
    Friend WithEvents txtRecvPacketNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblRecvPacketNumber As System.Windows.Forms.Label
    Friend WithEvents txtRecvCommandCode As System.Windows.Forms.TextBox
    Friend WithEvents lblRecvCommandCode As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSendChecksum As System.Windows.Forms.TextBox
    Friend WithEvents txtSendCommandValue As System.Windows.Forms.TextBox
    Friend WithEvents txtSendCommandLength As System.Windows.Forms.TextBox
    Friend WithEvents txtSendLQI As System.Windows.Forms.TextBox
    Friend WithEvents cboSendPacketNumber As System.Windows.Forms.ComboBox
    Friend WithEvents cboSendCommandEncoding As System.Windows.Forms.ComboBox
    Friend WithEvents cboSendReceiveNode As System.Windows.Forms.ComboBox
    Friend WithEvents cboSendCommandCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblSendChecksum As System.Windows.Forms.Label
    Friend WithEvents lblSendCommandValue As System.Windows.Forms.Label
    Friend WithEvents lblSendCommandEncoding As System.Windows.Forms.Label
    Friend WithEvents lblSendLQI As System.Windows.Forms.Label
    Friend WithEvents lblSendCommandLength As System.Windows.Forms.Label
    Friend WithEvents lblSendReceiveNode As System.Windows.Forms.Label
    Friend WithEvents lblSendPacketNumber As System.Windows.Forms.Label
    Friend WithEvents lblSendCommandCode As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblRecvCMD As System.Windows.Forms.Label
    Friend WithEvents lblSendCMD As System.Windows.Forms.Label
    Friend WithEvents Timer1 As Timer
End Class
