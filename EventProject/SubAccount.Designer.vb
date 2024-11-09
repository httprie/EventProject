<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubAccount
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
        Me.timedate = New System.Windows.Forms.Label()
        Me.btnUpdateAcc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditAcc = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShowPwd = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.txtPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSubRole = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.Location = New System.Drawing.Point(18, 24)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 22
        Me.timedate.Text = "                       "
        '
        'btnUpdateAcc
        '
        Me.btnUpdateAcc.AutoRoundedCorners = True
        Me.btnUpdateAcc.BorderRadius = 21
        Me.btnUpdateAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateAcc.FillColor = System.Drawing.Color.White
        Me.btnUpdateAcc.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnUpdateAcc.Location = New System.Drawing.Point(515, 530)
        Me.btnUpdateAcc.Name = "btnUpdateAcc"
        Me.btnUpdateAcc.Size = New System.Drawing.Size(218, 45)
        Me.btnUpdateAcc.TabIndex = 20
        Me.btnUpdateAcc.Text = "Update"
        '
        'btnEditAcc
        '
        Me.btnEditAcc.AutoRoundedCorners = True
        Me.btnEditAcc.BorderRadius = 21
        Me.btnEditAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditAcc.FillColor = System.Drawing.Color.White
        Me.btnEditAcc.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnEditAcc.Location = New System.Drawing.Point(292, 530)
        Me.btnEditAcc.Name = "btnEditAcc"
        Me.btnEditAcc.Size = New System.Drawing.Size(196, 45)
        Me.btnEditAcc.TabIndex = 19
        Me.btnEditAcc.Text = "Edit"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(390, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Show Password"
        '
        'btnShowPwd
        '
        Me.btnShowPwd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowPwd.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowPwd.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.btnShowPwd.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnShowPwd.Location = New System.Drawing.Point(335, 358)
        Me.btnShowPwd.Name = "btnShowPwd"
        Me.btnShowPwd.Size = New System.Drawing.Size(49, 24)
        Me.btnShowPwd.TabIndex = 80
        Me.btnShowPwd.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnShowPwd.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnShowPwd.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.btnShowPwd.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'txtPwd
        '
        Me.txtPwd.AutoRoundedCorners = True
        Me.txtPwd.BorderRadius = 15
        Me.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPwd.DefaultText = ""
        Me.txtPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPwd.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPwd.Location = New System.Drawing.Point(332, 316)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.PlaceholderText = ""
        Me.txtPwd.SelectedText = ""
        Me.txtPwd.Size = New System.Drawing.Size(460, 32)
        Me.txtPwd.TabIndex = 79
        '
        'txtFname
        '
        Me.txtFname.AutoRoundedCorners = True
        Me.txtFname.BorderRadius = 15
        Me.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFname.DefaultText = ""
        Me.txtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.Location = New System.Drawing.Point(332, 245)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.PlaceholderText = ""
        Me.txtFname.SelectedText = ""
        Me.txtFname.Size = New System.Drawing.Size(460, 32)
        Me.txtFname.TabIndex = 78
        '
        'txtUname
        '
        Me.txtUname.AutoRoundedCorners = True
        Me.txtUname.BorderRadius = 15
        Me.txtUname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUname.DefaultText = ""
        Me.txtUname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUname.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUname.Location = New System.Drawing.Point(332, 173)
        Me.txtUname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUname.PlaceholderText = ""
        Me.txtUname.SelectedText = ""
        Me.txtUname.Size = New System.Drawing.Size(460, 32)
        Me.txtUname.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(262, 412)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 25)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Role:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(213, 179)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(211, 252)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 25)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Full Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(217, 322)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 25)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(425, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(337, 39)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Account Information"
        '
        'txtSubRole
        '
        Me.txtSubRole.AutoRoundedCorners = True
        Me.txtSubRole.BorderRadius = 15
        Me.txtSubRole.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubRole.DefaultText = ""
        Me.txtSubRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubRole.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubRole.Location = New System.Drawing.Point(332, 405)
        Me.txtSubRole.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtSubRole.Name = "txtSubRole"
        Me.txtSubRole.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubRole.PlaceholderText = ""
        Me.txtSubRole.SelectedText = ""
        Me.txtSubRole.Size = New System.Drawing.Size(460, 32)
        Me.txtSubRole.TabIndex = 85
        '
        'SubAccount
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSubRole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnShowPwd)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.btnUpdateAcc)
        Me.Controls.Add(Me.btnEditAcc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SubAccount"
        Me.Text = "SubAccount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timedate As Label
    Friend WithEvents btnUpdateAcc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditAcc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents btnShowPwd As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txtPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSubRole As Guna.UI2.WinForms.Guna2TextBox
End Class
