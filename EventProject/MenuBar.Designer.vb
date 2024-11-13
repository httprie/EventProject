<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuBar
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
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.TimerReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.pnlbuttons = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStudent = New Guna.UI2.WinForms.Guna2Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSignOut = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlbuttons.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHome
        '
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlHome.Location = New System.Drawing.Point(377, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1013, 800)
        Me.pnlHome.TabIndex = 1
        '
        'TimerReduce
        '
        Me.TimerReduce.Interval = 1
        '
        'TimerIncrease
        '
        Me.TimerIncrease.Interval = 1
        '
        'pnlbuttons
        '
        Me.pnlbuttons.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlbuttons.Controls.Add(Me.btnSignOut)
        Me.pnlbuttons.Controls.Add(Me.btnReport)
        Me.pnlbuttons.Controls.Add(Me.btnAccount)
        Me.pnlbuttons.Controls.Add(Me.btnEvent)
        Me.pnlbuttons.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlbuttons.Controls.Add(Me.lblRole)
        Me.pnlbuttons.Controls.Add(Me.lblUsername)
        Me.pnlbuttons.Controls.Add(Me.btnStudent)
        Me.pnlbuttons.Controls.Add(Me.btnAttendance)
        Me.pnlbuttons.Controls.Add(Me.btnHome)
        Me.pnlbuttons.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlbuttons.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.pnlbuttons.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.pnlbuttons.FillColor3 = System.Drawing.Color.Black
        Me.pnlbuttons.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.pnlbuttons.Location = New System.Drawing.Point(0, 0)
        Me.pnlbuttons.Name = "pnlbuttons"
        Me.pnlbuttons.Size = New System.Drawing.Size(377, 800)
        Me.pnlbuttons.TabIndex = 0
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
        Me.btnHome.Font = New System.Drawing.Font("Ubuntu", 10.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnHome.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnHome.HoverState.Image = Global.EventProject.My.Resources.Resources.hoverhome
        Me.btnHome.Image = Global.EventProject.My.Resources.Resources.home
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnHome.Location = New System.Drawing.Point(12, 160)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(397, 45)
        Me.btnHome.TabIndex = 16
        Me.btnHome.Text = "HOME"
        Me.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.TextOffset = New System.Drawing.Point(33, 0)
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
        Me.btnAttendance.Location = New System.Drawing.Point(12, 235)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(365, 45)
        Me.btnAttendance.TabIndex = 17
        Me.btnAttendance.Text = "ATTENDANCE"
        Me.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.TextOffset = New System.Drawing.Point(40, 0)
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
        Me.btnStudent.Location = New System.Drawing.Point(12, 316)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(365, 45)
        Me.btnStudent.TabIndex = 18
        Me.btnStudent.Text = "STUDENT"
        Me.btnStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudent.TextOffset = New System.Drawing.Point(40, 0)
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(91, 76)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(148, 25)
        Me.lblUsername.TabIndex = 19
        Me.lblUsername.Text = "Juan Dela Cruz"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(92, 104)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(95, 20)
        Me.lblRole.TabIndex = 20
        Me.lblRole.Text = "Head Admin"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.EventProject.My.Resources.Resources.icon_user
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(26, 81)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(45, 43)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 21
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
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
        Me.btnEvent.Location = New System.Drawing.Point(12, 398)
        Me.btnEvent.Name = "btnEvent"
        Me.btnEvent.Size = New System.Drawing.Size(365, 45)
        Me.btnEvent.TabIndex = 27
        Me.btnEvent.Text = "EVENT"
        Me.btnEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEvent.TextOffset = New System.Drawing.Point(40, 0)
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
        Me.btnAccount.Location = New System.Drawing.Point(12, 479)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(365, 45)
        Me.btnAccount.TabIndex = 28
        Me.btnAccount.Text = "ACCOUNT"
        Me.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAccount.TextOffset = New System.Drawing.Point(40, 0)
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
        Me.btnReport.Location = New System.Drawing.Point(12, 554)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(365, 45)
        Me.btnReport.TabIndex = 29
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
        Me.btnSignOut.Location = New System.Drawing.Point(12, 631)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(365, 45)
        Me.btnSignOut.TabIndex = 30
        Me.btnSignOut.Text = "SIGN OUT"
        Me.btnSignOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSignOut.TextOffset = New System.Drawing.Point(40, 0)
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.EventProject.My.Resources.Resources.icons8_menu_96
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(45, 40)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'MenuBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1390, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlbuttons)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlbuttons.ResumeLayout(False)
        Me.pnlbuttons.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHome As Panel
    Friend WithEvents TimerReduce As Timer
    Friend WithEvents TimerIncrease As Timer
    Friend WithEvents pnlbuttons As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
End Class
