Imports System.Net.Mail
Imports System.Runtime.InteropServices
Public Class EmailForm
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Dim mail As New MailMessage()
    Dim smtserver As New SmtpClient("smtp.gmail.com")

    Public Property email As String
    Public Property message As String
    Public Property qrCodePath As String

    Private Sub EmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))

        lblto.Text = email
        lblsubject.Text = "Attendance QR Code"
        lblEMessage.Text = message

        If Not String.IsNullOrEmpty(qrCodePath) Then
            Dim attach As New Attachment(qrCodePath)
            mail.Attachments.Add(attach)
        End If
    End Sub

    Private Sub btnattach_Click(sender As Object, e As EventArgs) Handles btnattach.Click
        OpenFileDialog1.ShowDialog()
        lblfilename.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click



        mail.From = New MailAddress("dyci.eventreg@gmail.com")
        mail.To.Add(email)
        mail.Subject = lblsubject.Text
        mail.Body = lblEMessage.Text

        Dim attach As System.Net.Mail.Attachment
        attach = New System.Net.Mail.Attachment(lblfilename.Text)
        mail.Attachments.Add(attach)

        smtserver.Port = 587
        smtserver.Credentials = New System.Net.NetworkCredential("dyci.eventreg@gmail.com", "qxfc xvqr amsy wyxe
")
        smtserver.EnableSsl = True
        smtserver.Send(mail)

        MessageBox.Show("Email sent!")
        Me.Hide()

    End Sub


End Class