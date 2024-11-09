Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class SubDashboard
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Dim sqlQuery As String
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Private Sub SubDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        pnltotalatt.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnltotalatt.Width, pnltotalatt.Height, 40, 40))
        pnlupcoming.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlupcoming.Width, pnlupcoming.Height, 40, 40))
        pnltotalqr.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnltotalqr.Width, pnltotalqr.Height, 40, 40))

        pnlrecentevent.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlrecentevent.Width, pnlrecentevent.Height, 40, 40))
        pnlrecentatt.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlrecentatt.Width, pnlrecentatt.Height, 40, 40))

        RecentAttendees.Rows.Add("2023-11111", "Jeon Jungkook", "BSIT", "1B", "60", "Mass", "2024-11-09 01:00:00", "2024-11-09 01:30:00", "Complete")
        RecentAttendees.Rows.Add("2023-11112", "Park Jimin", "BSME", "3A", "60", "Mass", "2024-11-09 01:00:00", "2024-11-09 01:30:00", "Complete")
        RecentAttendees.Rows.Add("2023-11115", "Kim Namjoon", "BSIT", "1D", "60", "Mass", "2024-11-09 01:00:00", "2024-11-09 01:30:00", "Complete")
        RecentAttendees.Rows.Add("2023-11113", "Kim Seokjin", "ACT", "1A", "61", "The Feast", "2024-11-09 01:00:00", "2024-11-09 01:30:00", "Complete")
        RecentAttendees.Rows.Add("2023-11114", "Kim Taehyung", "ACT", "2C", "61", "The Feast", "2024-11-09 01:00:00", "2024-11-09 01:30:00", "Complete")
        RecentAttendees.Rows.Add("2023-11116", "Lee Jihoon", "BSME", "4A", "61", "The Feast", "2024-11-09 01:00:00", "2024-11-09 01:30:00", "Complete")


        UpcomingEvents.Rows.Add("62", "Mass")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timer As String
        timer = Date.Now.ToString()
        timedate.Text = timer
    End Sub
End Class