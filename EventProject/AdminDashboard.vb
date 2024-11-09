Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class AdminDashboard
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Dim sqlQuery As String
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        pnltotalatt.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnltotalatt.Width, pnltotalatt.Height, 40, 40))
        pnlupcoming.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlupcoming.Width, pnlupcoming.Height, 40, 40))
        pnltotalqr.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnltotalqr.Width, pnltotalqr.Height, 40, 40))

        pnlrecentevent.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlrecentevent.Width, pnlrecentevent.Height, 40, 40))
        pnlrecentatt.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlrecentatt.Width, pnlrecentatt.Height, 40, 40))

        RecentAttendees.Rows.Add("2023-11111", "Jeonghan Yoon", "BSME", "1C", "59", "Complete")
        RecentAttendees.Rows.Add("2023-19082", "Ariane Sudaria", "BSIT", "3B", "59", "Complete")
        RecentAttendees.Rows.Add("2023-08975", "Riezseht Basilio", "BSIT", "2A", "59", "Complete")
        RecentAttendees.Rows.Add("2023-12093", "Jeon Jungkook", "BSIT", "1B", "59", "Complete")
        RecentAttendees.Rows.Add("2023-02361", "Park Jimin", "BSME", "3A", "59", "Complete")
        RecentAttendees.Rows.Add("2023-13782", "Kim Seokjin", "ACT", "1A", "59", "Complete")
        RecentAttendees.Rows.Add("2023-19483", "Kim Taehyung", "ACT", "2C", "59", "Complete")
        RecentAttendees.Rows.Add("2023-12473", "Kim Namjoon", "BSIT", "1D", "59", "Complete")
        RecentAttendees.Rows.Add("2023-14672", "Lee Jihoon", "BSME", "4A", "59", "Complete")

        UpcomingEvents.Rows.Add("60", "Mass")
        UpcomingEvents.Rows.Add("61", "The Feast")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timer As String
        timer = Date.Now.ToString()
        timedate.Text = timer
    End Sub

End Class