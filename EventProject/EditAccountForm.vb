Imports System.Runtime.InteropServices
Public Class EditAccountForm
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function
    Private WithEvents myComboBox As New ComboBox()

    Private Sub EditAccountForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
    End Sub
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
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ClearTextBoxes()
        txtUname.Text = ""
        txtFname.Text = ""
        txtPwd.Text = ""
        cbRole.Text = -1
    End Sub
    Private Sub btnClearTxt_Click(sender As Object, e As EventArgs) Handles btnClearTxt.Click
        ClearTextBoxes()
    End Sub

    Private Sub btnshowpwd_Click(sender As Object, e As EventArgs) Handles btnShowPwd.Click
        If txtPwd.PasswordChar = "*" Then
            txtPwd.PasswordChar = ""
            btnShowPwd.Text = "Hide"
        Else
            txtPwd.PasswordChar = "*"
            btnShowPwd.Text = "Show"

        End If
    End Sub
End Class