Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Login
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Dim username As String
    Dim password As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        AcceptButton = btnSignIn
        Timer1.Enabled = True
    End Sub
    Public Sub ResetFields()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        username = txtUsername.Text
        password = txtPassword.Text

        DbConnect()

        Try
            Dim sqlQuery As String = "SELECT FullName, Role FROM Accounts WHERE UserName = @UserName AND Password = @Password"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@UserName", username)
            cmd.Parameters.AddWithValue("@Password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim fullName As String = reader("FullName").ToString()
                Dim role As String = reader("Role").ToString()
                Dim home As New HomeForm(fullName, role)
                home.Show()
                Me.Hide()
                home.childform(New AdminDashboard())
            ElseIf username = "" Or password = "" Then
                MessageBox.Show("Please fill in the login details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Username or Password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnShow_CheckedChanged(sender As Object, e As EventArgs) Handles btnShow.CheckedChanged
        If btnShow.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = Date.Now.ToString()
        timedate.Text = s
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to close the program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            End
        ElseIf result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class