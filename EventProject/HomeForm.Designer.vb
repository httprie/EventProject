<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSignOut = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.menuicon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlbuttons = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStudent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.TimerReduce = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.TimerIncrease = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(88, 79)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(148, 25)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Juan Dela Cruz"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(89, 107)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(95, 20)
        Me.lblRole.TabIndex = 2
        Me.lblRole.Text = "Head Admin"
        '
        'btnAttendance
        '
        Me.btnAttendance.AutoRoundedCorners = True
        Me.btnAttendance.BackColor = System.Drawing.Color.Transparent
        Me.btnAttendance.BorderRadius = 21
        Me.btnAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttendance.FillColor = System.Drawing.Color.Transparent
        Me.btnAttendance.Font = New System.Drawing.Font("Ubuntu", 10.0!)
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnAttendance.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnAttendance.HoverState.Image = Global.EventProject.My.Resources.Resources.hoveratt
        Me.btnAttendance.Image = Global.EventProject.My.Resources.Resources.icons_attendance
        Me.btnAttendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnAttendance.Location = New System.Drawing.Point(26, 236)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(281, 45)
        Me.btnAttendance.TabIndex = 3
        Me.btnAttendance.Text = "ATTENDANCE"
        Me.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnReport
        '
        Me.btnReport.AutoRoundedCorners = True
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.BorderRadius = 21
        Me.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReport.FillColor = System.Drawing.Color.Transparent
        Me.btnReport.Font = New System.Drawing.Font("Ubuntu", 10.0!)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnReport.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnReport.HoverState.Image = Global.EventProject.My.Resources.Resources.hoverreport
        Me.btnReport.Image = Global.EventProject.My.Resources.Resources.icons8_report_96
        Me.btnReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReport.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnReport.Location = New System.Drawing.Point(26, 532)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(281, 45)
        Me.btnReport.TabIndex = 7
        Me.btnReport.Text = "REPORT"
        Me.btnReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReport.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnSignOut
        '
        Me.btnSignOut.AutoRoundedCorners = True
        Me.btnSignOut.BackColor = System.Drawing.Color.Transparent
        Me.btnSignOut.BorderRadius = 21
        Me.btnSignOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignOut.FillColor = System.Drawing.Color.Transparent
        Me.btnSignOut.Font = New System.Drawing.Font("Ubuntu", 10.0!)
        Me.btnSignOut.ForeColor = System.Drawing.Color.White
        Me.btnSignOut.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnSignOut.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSignOut.HoverState.Image = Global.EventProject.My.Resources.Resources.hoverout
        Me.btnSignOut.Image = Global.EventProject.My.Resources.Resources.logout
        Me.btnSignOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSignOut.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnSignOut.Location = New System.Drawing.Point(26, 608)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(281, 45)
        Me.btnSignOut.TabIndex = 8
        Me.btnSignOut.Text = "SIGN OUT"
        Me.btnSignOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSignOut.TextOffset = New System.Drawing.Point(40, 0)
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.EventProject.My.Resources.Resources.icon_user
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(37, 79)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(45, 43)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'menuicon
        '
        Me.menuicon.BackColor = System.Drawing.Color.Transparent
        Me.menuicon.Image = Global.EventProject.My.Resources.Resources.icons8_menu_96
        Me.menuicon.ImageRotate = 0!
        Me.menuicon.Location = New System.Drawing.Point(37, 22)
        Me.menuicon.Name = "menuicon"
        Me.menuicon.Size = New System.Drawing.Size(45, 35)
        Me.menuicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.menuicon.TabIndex = 1
        Me.menuicon.TabStop = False
        Me.menuicon.UseTransparentBackground = True
        '
        'pnlbuttons
        '
        Me.pnlbuttons.Controls.Add(Me.menuicon)
        Me.pnlbuttons.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlbuttons.Controls.Add(Me.btnSignOut)
        Me.pnlbuttons.Controls.Add(Me.btnReport)
        Me.pnlbuttons.Controls.Add(Me.btnAccount)
        Me.pnlbuttons.Controls.Add(Me.btnEvent)
        Me.pnlbuttons.Controls.Add(Me.btnStudent)
        Me.pnlbuttons.Controls.Add(Me.btnAttendance)
        Me.pnlbuttons.Controls.Add(Me.lblRole)
        Me.pnlbuttons.Controls.Add(Me.lblUsername)
        Me.pnlbuttons.Controls.Add(Me.btnHome)
        Me.pnlbuttons.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlbuttons.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.pnlbuttons.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.pnlbuttons.FillColor3 = System.Drawing.Color.Black
        Me.pnlbuttons.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.pnlbuttons.Location = New System.Drawing.Point(0, 0)
        Me.pnlbuttons.Name = "pnlbuttons"
        Me.pnlbuttons.Size = New System.Drawing.Size(377, 800)
        Me.pnlbuttons.TabIndex = 2
        '
        'btnAccount
        '
        Me.btnAccount.AutoRoundedCorners = True
        Me.btnAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnAccount.BorderRadius = 21
        Me.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAccount.FillColor = System.Drawing.Color.Transparent
        Me.btnAccount.Font = New System.Drawing.Font("Ubuntu", 10.0!)
        Me.btnAccount.ForeColor = System.Drawing.Color.White
        Me.btnAccount.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnAccount.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnAccount.HoverState.Image = Global.EventProject.My.Resources.Resources.hoveracc
        Me.btnAccount.Image = Global.EventProject.My.Resources.Resources.icons8_select_users_96
        Me.btnAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAccount.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnAccount.Location = New System.Drawing.Point(26, 458)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(281, 45)
        Me.btnAccount.TabIndex = 6
        Me.btnAccount.Text = "ACCOUNT"
        Me.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAccount.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnEvent
        '
        Me.btnEvent.AutoRoundedCorners = True
        Me.btnEvent.BackColor = System.Drawing.Color.Transparent
        Me.btnEvent.BorderRadius = 21
        Me.btnEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEvent.FillColor = System.Drawing.Color.Transparent
        Me.btnEvent.Font = New System.Drawing.Font("Ubuntu", 10.0!)
        Me.btnEvent.ForeColor = System.Drawing.Color.White
        Me.btnEvent.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnEvent.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnEvent.HoverState.Image = Global.EventProject.My.Resources.Resources.hoverevent
        Me.btnEvent.Image = Global.EventProject.My.Resources.Resources.icons8_events_96
        Me.btnEvent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEvent.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnEvent.Location = New System.Drawing.Point(26, 384)
        Me.btnEvent.Name = "btnEvent"
        Me.btnEvent.Size = New System.Drawing.Size(281, 45)
        Me.btnEvent.TabIndex = 5
        Me.btnEvent.Text = "EVENT"
        Me.btnEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEvent.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnStudent
        '
        Me.btnStudent.AutoRoundedCorners = True
        Me.btnStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnStudent.BorderRadius = 21
        Me.btnStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudent.FillColor = System.Drawing.Color.Transparent
        Me.btnStudent.Font = New System.Drawing.Font("Ubuntu", 10.0!)
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnStudent.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnStudent.HoverState.Image = Global.EventProject.My.Resources.Resources.hoverstud
        Me.btnStudent.Image = Global.EventProject.My.Resources.Resources.icons8_student_registration_96
        Me.btnStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudent.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnStudent.Location = New System.Drawing.Point(26, 308)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(281, 45)
        Me.btnStudent.TabIndex = 4
        Me.btnStudent.Text = "STUDENT"
        Me.btnStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudent.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnHome
        '
        Me.btnHome.AutoRoundedCorners = True
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BorderRadius = 21
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.FillColor = System.Drawing.Color.Transparent
        Me.btnHome.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnHome.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnHome.HoverState.Image = Global.EventProject.My.Resources.Resources.hoverhome
        Me.btnHome.Image = Global.EventProject.My.Resources.Resources.home
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnHome.Location = New System.Drawing.Point(26, 161)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(281, 45)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "HOME"
        Me.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.TextOffset = New System.Drawing.Point(33, 0)
        '
        'TimerReduce
        '
        Me.TimerReduce.Interval = 1
        '
        'pnlHome
        '
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlHome.Location = New System.Drawing.Point(379, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1011, 800)
        Me.pnlHome.TabIndex = 3
        '
        'TimerIncrease
        '
        Me.TimerIncrease.Interval = 1
        '
        'HomeForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1390, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlHome)
        Me.Controls.Add(Me.pnlbuttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbuttons.ResumeLayout(False)
        Me.pnlbuttons.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents menuicon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlbuttons As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TimerReduce As Timer
    Friend WithEvents pnlHome As Panel
    Friend WithEvents TimerIncrease As Timer
End Class