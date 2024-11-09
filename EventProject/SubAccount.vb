Imports System.Runtime.InteropServices

Public Class SubAccount
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function
    Private Sub btnEditAcc_Click(sender As Object, e As EventArgs) Handles btnEditAcc.Click
        txtUname.Enabled = True
        txtFname.Enabled = True
        txtPwd.Enabled = True
    End Sub

    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to update your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            MessageBox.Show("Account updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SubAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUname.Enabled = False
        txtFname.Enabled = False
        txtPwd.Enabled = False
        txtSubRole.Enabled = False

        txtUname.Text = "2"
        txtFname.Text = "Sub Admin"
        txtPwd.Text = "*"
        txtSubRole.Text = "Sub Admin"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = Date.Now.ToString()
        timedate.Text = s
    End Sub
End Class
