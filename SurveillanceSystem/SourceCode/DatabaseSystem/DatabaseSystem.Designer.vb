<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseSystem
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
        Me.btnCreateTable = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboSelectRange = New System.Windows.Forms.ComboBox()
        Me.lblSelectRange = New System.Windows.Forms.Label()
        Me.cboColumn = New System.Windows.Forms.ComboBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDeleteData = New System.Windows.Forms.Button()
        Me.DataGridView1_Select = New System.Windows.Forms.DataGridView()
        Me.檔案編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.原始資料DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.轉換結果DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.接收時間DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemperatureBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1_Select, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemperatureBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateTable
        '
        Me.btnCreateTable.Location = New System.Drawing.Point(760, 62)
        Me.btnCreateTable.Name = "btnCreateTable"
        Me.btnCreateTable.Size = New System.Drawing.Size(107, 51)
        Me.btnCreateTable.TabIndex = 0
        Me.btnCreateTable.Text = "建立資料表"
        Me.btnCreateTable.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(760, 357)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 46)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "關閉"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboSelectRange
        '
        Me.cboSelectRange.FormattingEnabled = True
        Me.cboSelectRange.Items.AddRange(New Object() {"=", ">", "<", "<>", "<=", ">="})
        Me.cboSelectRange.Location = New System.Drawing.Point(99, 81)
        Me.cboSelectRange.Name = "cboSelectRange"
        Me.cboSelectRange.Size = New System.Drawing.Size(69, 20)
        Me.cboSelectRange.TabIndex = 36
        '
        'lblSelectRange
        '
        Me.lblSelectRange.AutoSize = True
        Me.lblSelectRange.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSelectRange.Location = New System.Drawing.Point(20, 81)
        Me.lblSelectRange.Name = "lblSelectRange"
        Me.lblSelectRange.Size = New System.Drawing.Size(62, 13)
        Me.lblSelectRange.TabIndex = 35
        Me.lblSelectRange.Text = "選擇範圍:"
        '
        'cboColumn
        '
        Me.cboColumn.FormattingEnabled = True
        Me.cboColumn.Items.AddRange(New Object() {"全部欄位", "檔案編號", "原始資料", "轉換結果", "接收時間"})
        Me.cboColumn.Location = New System.Drawing.Point(152, 34)
        Me.cboColumn.Name = "cboColumn"
        Me.cboColumn.Size = New System.Drawing.Size(121, 20)
        Me.cboColumn.TabIndex = 34
        Me.cboColumn.Text = "全部欄位"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(197, 81)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(170, 22)
        Me.txtValue.TabIndex = 33
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(21, 37)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(125, 12)
        Me.lblColumn.TabIndex = 32
        Me.lblColumn.Text = "請輸入查詢欄位名稱："
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(23, 378)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 37)
        Me.btnSearch.TabIndex = 38
        Me.btnSearch.Text = "查詢"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDeleteData
        '
        Me.btnDeleteData.Location = New System.Drawing.Point(760, 214)
        Me.btnDeleteData.Name = "btnDeleteData"
        Me.btnDeleteData.Size = New System.Drawing.Size(107, 51)
        Me.btnDeleteData.TabIndex = 39
        Me.btnDeleteData.Text = "刪除資料"
        Me.btnDeleteData.UseVisualStyleBackColor = True
        '
        'DataGridView1_Select
        '
        Me.DataGridView1_Select.AllowUserToOrderColumns = True
        Me.DataGridView1_Select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1_Select.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.檔案編號DataGridViewTextBoxColumn, Me.原始資料DataGridViewTextBoxColumn, Me.轉換結果DataGridViewTextBoxColumn, Me.接收時間DataGridViewTextBoxColumn})
        Me.DataGridView1_Select.Location = New System.Drawing.Point(23, 109)
        Me.DataGridView1_Select.Name = "DataGridView1_Select"
        Me.DataGridView1_Select.RowTemplate.Height = 24
        Me.DataGridView1_Select.Size = New System.Drawing.Size(630, 248)
        Me.DataGridView1_Select.TabIndex = 2
        '
        '檔案編號DataGridViewTextBoxColumn
        '
        Me.檔案編號DataGridViewTextBoxColumn.DataPropertyName = "檔案編號"
        Me.檔案編號DataGridViewTextBoxColumn.HeaderText = "檔案編號"
        Me.檔案編號DataGridViewTextBoxColumn.Name = "檔案編號DataGridViewTextBoxColumn"
        '
        '原始資料DataGridViewTextBoxColumn
        '
        Me.原始資料DataGridViewTextBoxColumn.DataPropertyName = "原始資料"
        Me.原始資料DataGridViewTextBoxColumn.HeaderText = "原始資料"
        Me.原始資料DataGridViewTextBoxColumn.Name = "原始資料DataGridViewTextBoxColumn"
        '
        '轉換結果DataGridViewTextBoxColumn
        '
        Me.轉換結果DataGridViewTextBoxColumn.DataPropertyName = "轉換結果"
        Me.轉換結果DataGridViewTextBoxColumn.HeaderText = "轉換結果"
        Me.轉換結果DataGridViewTextBoxColumn.Name = "轉換結果DataGridViewTextBoxColumn"
        '
        '接收時間DataGridViewTextBoxColumn
        '
        Me.接收時間DataGridViewTextBoxColumn.DataPropertyName = "接收時間"
        Me.接收時間DataGridViewTextBoxColumn.HeaderText = "接收時間"
        Me.接收時間DataGridViewTextBoxColumn.Name = "接收時間DataGridViewTextBoxColumn"
        '
        'DatabaseSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDeleteData)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cboSelectRange)
        Me.Controls.Add(Me.lblSelectRange)
        Me.Controls.Add(Me.cboColumn)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.DataGridView1_Select)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreateTable)
        Me.Name = "DatabaseSystem"
        Me.Size = New System.Drawing.Size(914, 460)
        CType(Me.DataGridView1_Select, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemperatureBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateTable As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cboSelectRange As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectRange As System.Windows.Forms.Label
    Friend WithEvents cboColumn As System.Windows.Forms.ComboBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents lblColumn As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDeleteData As System.Windows.Forms.Button
    Friend WithEvents DataGridView1_Select As System.Windows.Forms.DataGridView
    '    Friend WithEvents TemperatureTableAdapter As WindowsApplication1.dataDataSet2TableAdapters.TemperatureTableAdapter
    Friend WithEvents 檔案編號DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 原始資料DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 轉換結果DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 接收時間DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemperatureBindingSource1 As System.Windows.Forms.BindingSource
End Class
