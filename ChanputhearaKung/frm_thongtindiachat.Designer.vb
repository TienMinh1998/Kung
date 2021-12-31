<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_thongtindiachat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_thongtindiachat))
        Me.dgv_diachat = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btn_nhap_excel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Close = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv_diachat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_diachat
        '
        Me.dgv_diachat.AllowUserToAddRows = False
        Me.dgv_diachat.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.dgv_diachat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_diachat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_diachat.BackgroundColor = System.Drawing.Color.White
        Me.dgv_diachat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_diachat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_diachat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_diachat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_diachat.ColumnHeadersHeight = 60
        Me.dgv_diachat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_diachat.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_diachat.EnableHeadersVisualStyles = False
        Me.dgv_diachat.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.dgv_diachat.Location = New System.Drawing.Point(0, 36)
        Me.dgv_diachat.Name = "dgv_diachat"
        Me.dgv_diachat.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_diachat.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_diachat.RowHeadersVisible = False
        Me.dgv_diachat.RowTemplate.Height = 50
        Me.dgv_diachat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_diachat.Size = New System.Drawing.Size(1019, 278)
        Me.dgv_diachat.TabIndex = 5
        Me.dgv_diachat.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_diachat.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_diachat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_diachat.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_diachat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_diachat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_diachat.ThemeStyle.HeaderStyle.Height = 60
        Me.dgv_diachat.ThemeStyle.ReadOnly = True
        Me.dgv_diachat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_diachat.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_diachat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_diachat.ThemeStyle.RowsStyle.Height = 50
        Me.dgv_diachat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "STT"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Loại đất"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Trạng Thái đất."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Độ dày."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Dung Trọng Riêng"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Modun dàn hồi."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Góc Ms Trong."
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Độ Rời."
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Qc"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "N"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Hệ Số K"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Hệ số alpha"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_nhap_excel
        '
        Me.btn_nhap_excel.Image = CType(resources.GetObject("btn_nhap_excel.Image"), System.Drawing.Image)
        Me.btn_nhap_excel.Location = New System.Drawing.Point(826, 320)
        Me.btn_nhap_excel.Name = "btn_nhap_excel"
        Me.btn_nhap_excel.Size = New System.Drawing.Size(54, 43)
        Me.btn_nhap_excel.TabIndex = 6
        Me.btn_nhap_excel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NHẬP LIỆU ĐỊA CHẤT."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btn_Close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 35)
        Me.Panel1.TabIndex = 10
        '
        'Btn_Close
        '
        Me.Btn_Close.AnimationHoverSpeed = 0.07!
        Me.Btn_Close.AnimationSpeed = 0.03!
        Me.Btn_Close.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Close.BorderColor = System.Drawing.Color.Black
        Me.Btn_Close.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Btn_Close.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btn_Close.CheckedForeColor = System.Drawing.Color.White
        Me.Btn_Close.CheckedImage = CType(resources.GetObject("Btn_Close.CheckedImage"), System.Drawing.Image)
        Me.Btn_Close.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btn_Close.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Close.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Close.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Close.ForeColor = System.Drawing.Color.White
        Me.Btn_Close.Image = CType(resources.GetObject("Btn_Close.Image"), System.Drawing.Image)
        Me.Btn_Close.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Close.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Close.Location = New System.Drawing.Point(978, 1)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Close.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Close.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Close.OnHoverImage = Nothing
        Me.Btn_Close.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Close.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Close.Size = New System.Drawing.Size(38, 31)
        Me.Btn_Close.TabIndex = 15
        Me.Btn_Close.Text = "GunaAdvenceButton1"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(886, 320)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(121, 41)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "Xác Nhận"
        '
        'frm_thongtindiachat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.dgv_diachat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_nhap_excel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_thongtindiachat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập các thông tin của địa chất"
        CType(Me.dgv_diachat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btn_nhap_excel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_diachat As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewLinkColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Close As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
