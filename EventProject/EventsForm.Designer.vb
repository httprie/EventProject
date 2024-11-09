<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventsForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearchEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridViewEvents = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.eventid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.starttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timedate = New System.Windows.Forms.Label()
        Me.dtpSearchDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        CType(Me.DataGridViewEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BorderRadius = 8
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(13, 91)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(382, 45)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearchEvent
        '
        Me.btnSearchEvent.AutoRoundedCorners = True
        Me.btnSearchEvent.BorderRadius = 21
        Me.btnSearchEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchEvent.FillColor = System.Drawing.Color.White
        Me.btnSearchEvent.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSearchEvent.Location = New System.Drawing.Point(670, 91)
        Me.btnSearchEvent.Name = "btnSearchEvent"
        Me.btnSearchEvent.Size = New System.Drawing.Size(155, 45)
        Me.btnSearchEvent.TabIndex = 2
        Me.btnSearchEvent.Text = "Search"
        '
        'btnAddEvent
        '
        Me.btnAddEvent.AutoRoundedCorners = True
        Me.btnAddEvent.BorderRadius = 21
        Me.btnAddEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddEvent.FillColor = System.Drawing.Color.White
        Me.btnAddEvent.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAddEvent.Location = New System.Drawing.Point(831, 91)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(168, 45)
        Me.btnAddEvent.TabIndex = 3
        Me.btnAddEvent.Text = "Add New Event"
        '
        'DataGridViewEvents
        '
        Me.DataGridViewEvents.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEvents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewEvents.ColumnHeadersHeight = 42
        Me.DataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eventid, Me.eventname, Me.venue, Me.department, Me.eventdate, Me.starttime, Me.endtime, Me.edit, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewEvents.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewEvents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewEvents.Location = New System.Drawing.Point(0, 202)
        Me.DataGridViewEvents.Name = "DataGridViewEvents"
        Me.DataGridViewEvents.ReadOnly = True
        Me.DataGridViewEvents.RowHeadersVisible = False
        Me.DataGridViewEvents.RowHeadersWidth = 62
        Me.DataGridViewEvents.RowTemplate.Height = 28
        Me.DataGridViewEvents.Size = New System.Drawing.Size(1009, 530)
        Me.DataGridViewEvents.TabIndex = 13
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewEvents.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.Height = 42
        Me.DataGridViewEvents.ThemeStyle.ReadOnly = True
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.Height = 28
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'eventid
        '
        Me.eventid.HeaderText = "Event ID"
        Me.eventid.MinimumWidth = 8
        Me.eventid.Name = "eventid"
        Me.eventid.ReadOnly = True
        '
        'eventname
        '
        Me.eventname.HeaderText = "Event Name"
        Me.eventname.MinimumWidth = 8
        Me.eventname.Name = "eventname"
        Me.eventname.ReadOnly = True
        '
        'venue
        '
        Me.venue.HeaderText = "Venue"
        Me.venue.MinimumWidth = 8
        Me.venue.Name = "venue"
        Me.venue.ReadOnly = True
        '
        'department
        '
        Me.department.HeaderText = "Department"
        Me.department.MinimumWidth = 8
        Me.department.Name = "department"
        Me.department.ReadOnly = True
        '
        'eventdate
        '
        Me.eventdate.HeaderText = "Date"
        Me.eventdate.MinimumWidth = 8
        Me.eventdate.Name = "eventdate"
        Me.eventdate.ReadOnly = True
        '
        'starttime
        '
        Me.starttime.HeaderText = "Start Time"
        Me.starttime.MinimumWidth = 8
        Me.starttime.Name = "starttime"
        Me.starttime.ReadOnly = True
        '
        'endtime
        '
        Me.endtime.HeaderText = "End TIme"
        Me.endtime.MinimumWidth = 8
        Me.endtime.Name = "endtime"
        Me.endtime.ReadOnly = True
        '
        'edit
        '
        Me.edit.HeaderText = "Edit"
        Me.edit.MinimumWidth = 8
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        '
        'delete
        '
        Me.delete.HeaderText = "Delete"
        Me.delete.MinimumWidth = 8
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        '
        'Timer1
        '
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.Location = New System.Drawing.Point(12, 22)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 16
        Me.timedate.Text = "                       "
        '
        'dtpSearchDate
        '
        Me.dtpSearchDate.AutoRoundedCorners = True
        Me.dtpSearchDate.BackColor = System.Drawing.SystemColors.Control
        Me.dtpSearchDate.BorderColor = System.Drawing.Color.White
        Me.dtpSearchDate.BorderRadius = 21
        Me.dtpSearchDate.Checked = True
        Me.dtpSearchDate.FillColor = System.Drawing.Color.White
        Me.dtpSearchDate.Font = New System.Drawing.Font("Ubuntu", 9.0!)
        Me.dtpSearchDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpSearchDate.Location = New System.Drawing.Point(402, 91)
        Me.dtpSearchDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpSearchDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpSearchDate.Name = "dtpSearchDate"
        Me.dtpSearchDate.Size = New System.Drawing.Size(262, 45)
        Me.dtpSearchDate.TabIndex = 18
        Me.dtpSearchDate.Value = New Date(2024, 11, 8, 16, 4, 40, 702)
        '
        'EventsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtpSearchDate)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.DataGridViewEvents)
        Me.Controls.Add(Me.btnAddEvent)
        Me.Controls.Add(Me.btnSearchEvent)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EventsForm"
        Me.Text = "Event"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearchEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewEvents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timedate As Label
    Friend WithEvents dtpSearchDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents eventid As DataGridViewTextBoxColumn
    Friend WithEvents eventname As DataGridViewTextBoxColumn
    Friend WithEvents venue As DataGridViewTextBoxColumn
    Friend WithEvents department As DataGridViewTextBoxColumn
    Friend WithEvents eventdate As DataGridViewTextBoxColumn
    Friend WithEvents starttime As DataGridViewTextBoxColumn
    Friend WithEvents endtime As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewTextBoxColumn
End Class
