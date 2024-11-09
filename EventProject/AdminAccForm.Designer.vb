<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAccForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearchAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearchAcc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataAccount = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.timedate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddAccount
        '
        Me.btnAddAccount.AutoRoundedCorners = True
        Me.btnAddAccount.BorderRadius = 21
        Me.btnAddAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddAccount.FillColor = System.Drawing.Color.White
        Me.btnAddAccount.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAddAccount.Location = New System.Drawing.Point(759, 127)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(218, 45)
        Me.btnAddAccount.TabIndex = 6
        Me.btnAddAccount.Text = "Add New Account"
        '
        'btnSearchAccount
        '
        Me.btnSearchAccount.AutoRoundedCorners = True
        Me.btnSearchAccount.BorderRadius = 21
        Me.btnSearchAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchAccount.FillColor = System.Drawing.Color.White
        Me.btnSearchAccount.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSearchAccount.Location = New System.Drawing.Point(532, 127)
        Me.btnSearchAccount.Name = "btnSearchAccount"
        Me.btnSearchAccount.Size = New System.Drawing.Size(196, 45)
        Me.btnSearchAccount.TabIndex = 5
        Me.btnSearchAccount.Text = "Search"
        '
        'txtSearchAcc
        '
        Me.txtSearchAcc.BorderRadius = 8
        Me.txtSearchAcc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchAcc.DefaultText = ""
        Me.txtSearchAcc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchAcc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchAcc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchAcc.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAcc.ForeColor = System.Drawing.Color.Black
        Me.txtSearchAcc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchAcc.Location = New System.Drawing.Point(22, 127)
        Me.txtSearchAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchAcc.Name = "txtSearchAcc"
        Me.txtSearchAcc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchAcc.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSearchAcc.PlaceholderText = "Search"
        Me.txtSearchAcc.SelectedText = ""
        Me.txtSearchAcc.Size = New System.Drawing.Size(475, 45)
        Me.txtSearchAcc.TabIndex = 4
        '
        'DataAccount
        '
        Me.DataAccount.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataAccount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataAccount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataAccount.ColumnHeadersHeight = 42
        Me.DataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataAccount.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataAccount.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataAccount.Location = New System.Drawing.Point(0, 201)
        Me.DataAccount.Name = "DataAccount"
        Me.DataAccount.ReadOnly = True
        Me.DataAccount.RowHeadersVisible = False
        Me.DataAccount.RowHeadersWidth = 62
        Me.DataAccount.RowTemplate.Height = 28
        Me.DataAccount.Size = New System.Drawing.Size(1010, 530)
        Me.DataAccount.TabIndex = 14
        Me.DataAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataAccount.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataAccount.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DataAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataAccount.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataAccount.ThemeStyle.HeaderStyle.Height = 42
        Me.DataAccount.ThemeStyle.ReadOnly = True
        Me.DataAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataAccount.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataAccount.ThemeStyle.RowsStyle.Height = 28
        Me.DataAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.DataAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.Location = New System.Drawing.Point(18, 29)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 17
        Me.timedate.Text = "                       "
        '
        'Timer1
        '
        '
        'AdminAccForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.DataAccount)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.btnSearchAccount)
        Me.Controls.Add(Me.txtSearchAcc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminAccForm"
        CType(Me.DataAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearchAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchAcc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataAccount As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents timedate As Label
    Friend WithEvents Timer1 As Timer
End Class
