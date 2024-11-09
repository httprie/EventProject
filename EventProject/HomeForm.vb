Imports System.Runtime.InteropServices
Imports Guna.UI2.WinForms

Public Class HomeForm
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Private userfullName As String
    Private userRole As String

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        lblUsername.Text = userfullName
        lblRole.Text = userRole
    End Sub

    Public Sub New(fullName As String, role As String)
        InitializeComponent()
        userfullName = fullName
        userRole = role
    End Sub

    Sub childform(ByVal panel As Form)
        pnlHome.Controls.Clear()
        panel.TopLevel = False

        pnlHome.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click
        Dim clickedButton As Guna2Button = CType(sender, Guna2Button)

        ResetButtonStyles()

        clickedButton.FillColor = SystemColors.Control
        clickedButton.ForeColor = Color.Black
        clickedButton.BorderRadius = 20
        clickedButton.Image = My.Resources.hoverevent

        childform(New EventsForm(userfullName))
    End Sub

    Private Sub ResetButtonStyles()
        btnHome.FillColor = Color.Transparent
        btnHome.ForeColor = Color.White
        btnHome.Image = My.Resources.home

        btnAttendance.FillColor = Color.Transparent
        btnAttendance.ForeColor = Color.White
        btnAttendance.Image = My.Resources.icons_attendance

        btnStudent.FillColor = Color.Transparent
        btnStudent.ForeColor = Color.White
        btnStudent.Image = My.Resources.icons8_student_registration_96

        btnEvent.FillColor = Color.Transparent
        btnEvent.ForeColor = Color.White
        btnEvent.Image = My.Resources.icons8_events_96

        btnAccount.FillColor = Color.Transparent
        btnAccount.ForeColor = Color.White
        btnAccount.Image = My.Resources.icons8_select_users_96

        btnReport.FillColor = Color.Transparent
        btnReport.ForeColor = Color.White
        btnReport.Image = My.Resources.icons8_report_96

        btnSignOut.FillColor = Color.Transparent
        btnSignOut.ForeColor = Color.White
        btnSignOut.Image = My.Resources.logout


    End Sub


    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim clickedButton As Guna2Button = CType(sender, Guna2Button)

        ResetButtonStyles()

        clickedButton.FillColor = SystemColors.Control
        clickedButton.ForeColor = Color.Black
        clickedButton.BorderRadius = 20
        clickedButton.Image = My.Resources.hoverout

        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to log out this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dispose()
            Dim loginForm As New Login()
            Login.Show()
            Login.ResetFields()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim clickedButton As Guna2Button = CType(sender, Guna2Button)

        ResetButtonStyles()

        clickedButton.FillColor = SystemColors.Control
        clickedButton.ForeColor = Color.Black
        clickedButton.BorderRadius = 20
        clickedButton.Image = My.Resources.hoverhome

        If userRole.ToLower() = "sub admin" Then
            childform(New SubDashboard()) ' This should load the SubDashboard
        Else
            childform(New AdminDashboard()) ' This should load the AdminDashboard
        End If

    End Sub

    Private Sub HomeForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to close the program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            End
        ElseIf result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Dim clickedButton As Guna2Button = CType(sender, Guna2Button)

        ResetButtonStyles()

        clickedButton.FillColor = SystemColors.Control
        clickedButton.ForeColor = Color.Black
        clickedButton.BorderRadius = 20
        clickedButton.Image = My.Resources.hoveratt

        childform(New AttendanceForm())
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim clickedButton As Guna2Button = CType(sender, Guna2Button)

        ResetButtonStyles()

        clickedButton.FillColor = SystemColors.Control
        clickedButton.ForeColor = Color.Black
        clickedButton.BorderRadius = 20
        clickedButton.Image = My.Resources.hoverstud

        childform(New GenerateQR())
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim clickedButton As Guna2Button = CType(sender, Guna2Button)

        ResetButtonStyles()

        clickedButton.FillColor = SystemColors.Control
        clickedButton.ForeColor = Color.Black
        clickedButton.BorderRadius = 20
        clickedButton.Image = My.Resources.hoveracc

        If userRole.ToLower() = "sub admin" Then
            childform(New SubAccount())
        Else
            MessageBox.Show("Loading AdminDashboard")
            childform(New AddAccountForm())
        End If

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim clickedButton As Guna2Button = CType(sender, Guna2Button)

        ResetButtonStyles()

        clickedButton.FillColor = SystemColors.Control
        clickedButton.ForeColor = Color.Black
        clickedButton.BorderRadius = 20
        clickedButton.Image = My.Resources.hoverreport

        childform(New HeadReports())
    End Sub
End Class