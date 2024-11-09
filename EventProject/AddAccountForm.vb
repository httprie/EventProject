Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class AddAccountForm
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function
    Public Event AccountAdded()

    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim UserName As String
    Dim Password As String
    Dim FullName As String
    Dim Role As String

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)

        Dim radius As Integer = 23
        Dim rect As New Rectangle(0, 0, cbRole.Width, cbRole.Height)
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()

        cbRole.Region = New Region(path)
    End Sub
    Private Sub AddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        DbConnect()

    End Sub


    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        UserName = txtUname.Text
        Password = txtPwd.Text
        FullName = txtFname.Text

        If cbRole.SelectedItem IsNot Nothing Then
            Role = cbRole.SelectedItem.ToString()
        Else
            MessageBox.Show("Please select a role.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(UserName) OrElse String.IsNullOrWhiteSpace(Password) OrElse String.IsNullOrWhiteSpace(FullName) Then
            MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO Accounts (Username, Password, Fullname, Role) VALUES (@UserName, @Password, @FullName, @Role)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@UserName", UserName)
                .Parameters.AddWithValue("@Password", Password)
                .Parameters.AddWithValue("@FullName", FullName)
                .Parameters.AddWithValue("@Role", Role)

                result = cmd.ExecuteNonQuery()

                If result > 0 Then
                    Dim confirmResult As DialogResult = MessageBox.Show("Do you really want to add this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmResult = DialogResult.Yes Then
                        MessageBox.Show("Account Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        RaiseEvent AccountAdded()
                        Me.Hide()
                        ClearTextBoxes()
                    Else
                        cmd.CommandText = "DELETE FROM Accounts WHERE Username = @UserName"
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Account addition canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Failed to add account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnShowPwd_CheckedChanged(sender As Object, e As EventArgs) Handles btnShowPwd.CheckedChanged
        If btnShowPwd.Checked Then
            txtPwd.PasswordChar = ""
        Else
            txtPwd.PasswordChar = "*"
        End If
    End Sub
    Private Sub ClearTextBoxes()
        txtUname.Text = ""
        txtPwd.Text = ""
        txtFname.Text = ""
        cbRole.SelectedIndex = -1
    End Sub
    Private Sub btnClearTxt_Click(sender As Object, e As EventArgs) Handles btnClearTxt.Click
        ClearTextBoxes()
    End Sub
End Class
