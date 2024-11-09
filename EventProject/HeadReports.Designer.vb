<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeadReports
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
        Me.timedate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbstudid = New System.Windows.Forms.ComboBox()
        Me.cbename = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnstudinfo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnename = New Guna.UI2.WinForms.Guna2Button()
        Me.btnallact = New Guna.UI2.WinForms.Guna2Button()
        Me.btnstudact = New Guna.UI2.WinForms.Guna2Button()
        Me.ReportData = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.ReportData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.ForeColor = System.Drawing.Color.Black
        Me.timedate.Location = New System.Drawing.Point(13, 26)
        Me.timedate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 41
        Me.timedate.Text = "                       "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(383, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "FILTER BY:"
        '
        'cbstudid
        '
        Me.cbstudid.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbstudid.ForeColor = System.Drawing.Color.Black
        Me.cbstudid.FormattingEnabled = True
        Me.cbstudid.Location = New System.Drawing.Point(12, 125)
        Me.cbstudid.Name = "cbstudid"
        Me.cbstudid.Size = New System.Drawing.Size(119, 33)
        Me.cbstudid.TabIndex = 35
        '
        'cbename
        '
        Me.cbename.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbename.ForeColor = System.Drawing.Color.Black
        Me.cbename.FormattingEnabled = True
        Me.cbename.Location = New System.Drawing.Point(136, 125)
        Me.cbename.Name = "cbename"
        Me.cbename.Size = New System.Drawing.Size(246, 33)
        Me.cbename.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(140, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "EVENT NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "STUDENT ID"
        '
        'Timer1
        '
        '
        'btnstudinfo
        '
        Me.btnstudinfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnstudinfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnstudinfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnstudinfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnstudinfo.FillColor = System.Drawing.Color.White
        Me.btnstudinfo.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstudinfo.ForeColor = System.Drawing.Color.Black
        Me.btnstudinfo.Image = Global.EventProject.My.Resources.Resources.studentinfo
        Me.btnstudinfo.Location = New System.Drawing.Point(388, 120)
        Me.btnstudinfo.Name = "btnstudinfo"
        Me.btnstudinfo.Size = New System.Drawing.Size(147, 32)
        Me.btnstudinfo.TabIndex = 42
        Me.btnstudinfo.Text = "Student Info"
        '
        'btnename
        '
        Me.btnename.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnename.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnename.FillColor = System.Drawing.Color.White
        Me.btnename.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnename.ForeColor = System.Drawing.Color.Black
        Me.btnename.Image = Global.EventProject.My.Resources.Resources.event_name
        Me.btnename.Location = New System.Drawing.Point(862, 120)
        Me.btnename.Name = "btnename"
        Me.btnename.Size = New System.Drawing.Size(137, 32)
        Me.btnename.TabIndex = 39
        Me.btnename.Text = "Event Name"
        '
        'btnallact
        '
        Me.btnallact.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnallact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnallact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnallact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnallact.FillColor = System.Drawing.Color.White
        Me.btnallact.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnallact.ForeColor = System.Drawing.Color.Black
        Me.btnallact.Image = Global.EventProject.My.Resources.Resources.all_act
        Me.btnallact.Location = New System.Drawing.Point(708, 120)
        Me.btnallact.Name = "btnallact"
        Me.btnallact.Size = New System.Drawing.Size(148, 32)
        Me.btnallact.TabIndex = 38
        Me.btnallact.Text = "All Activity"
        '
        'btnstudact
        '
        Me.btnstudact.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnstudact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnstudact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnstudact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnstudact.FillColor = System.Drawing.Color.White
        Me.btnstudact.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstudact.ForeColor = System.Drawing.Color.Black
        Me.btnstudact.Image = Global.EventProject.My.Resources.Resources.stud_act
        Me.btnstudact.Location = New System.Drawing.Point(541, 120)
        Me.btnstudact.Name = "btnstudact"
        Me.btnstudact.Size = New System.Drawing.Size(161, 32)
        Me.btnstudact.TabIndex = 37
        Me.btnstudact.Text = "Student Activity"
        '
        'ReportData
        '
        Me.ReportData.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ReportData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ReportData.ColumnHeadersHeight = 42
        Me.ReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ReportData.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReportData.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReportData.Location = New System.Drawing.Point(1, 173)
        Me.ReportData.Name = "ReportData"
        Me.ReportData.ReadOnly = True
        Me.ReportData.RowHeadersVisible = False
        Me.ReportData.RowHeadersWidth = 62
        Me.ReportData.RowTemplate.Height = 28
        Me.ReportData.Size = New System.Drawing.Size(1010, 530)
        Me.ReportData.TabIndex = 43
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ReportData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ReportData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReportData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.ReportData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ReportData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.ReportData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ReportData.ThemeStyle.HeaderStyle.Height = 42
        Me.ReportData.ThemeStyle.ReadOnly = True
        Me.ReportData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ReportData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ReportData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ReportData.ThemeStyle.RowsStyle.Height = 28
        Me.ReportData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.ReportData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'HeadReports
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReportData)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbstudid)
        Me.Controls.Add(Me.cbename)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnstudinfo)
        Me.Controls.Add(Me.btnename)
        Me.Controls.Add(Me.btnallact)
        Me.Controls.Add(Me.btnstudact)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HeadReports"
        Me.Text = "HeadReports"
        CType(Me.ReportData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timedate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbstudid As ComboBox
    Friend WithEvents cbename As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnstudinfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnename As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnallact As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnstudact As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ReportData As Guna.UI2.WinForms.Guna2DataGridView
End Class
