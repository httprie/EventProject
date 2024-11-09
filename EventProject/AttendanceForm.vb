Imports MySql.Data.MySqlClient
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports System.Collections.Generic
Public Class AttendanceForm
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim dt As New DataTable
    Dim sqlQuery As String
    Dim eventID As Integer

    Public Class EventData
        Public Property ID As Integer
        Public Property Name As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Private videoSource As VideoCaptureDevice
    Private webcamRunning As Boolean = False
    Private qrReader As New ZXing.BarcodeReader()
    Private processedStudentIDs As New Dictionary(Of String, Integer)()
    Private lastScanTime As New Dictionary(Of String, DateTime)
    Private cooldownTimer As New Timer With {.Interval = 2000}
    Private cooldownInterval As Integer = 5000 ' 5 seconds

    Private attendanceStatus As New Dictionary(Of String, String)

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pbwebcam.SizeMode = PictureBoxSizeMode.StretchImage
        StartWebcam()
        LoadEventsForToday()

        AddHandler cooldownTimer.Tick, AddressOf ClearCooldownStatus

    End Sub
    Private Sub LoadEventsForToday()
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            sqlQuery = "SELECT eventid, eventname FROM events WHERE eventdate = @currentDate"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@currentDate", currentDate)

            conn.Open()

            dr = cmd.ExecuteReader()

            cbevent.Items.Clear()

            Dim eventList As New List(Of EventData)()

            If dr.HasRows Then
                While dr.Read()
                    eventList.Add(New EventData With {.ID = dr("eventid"), .Name = dr("eventname")})
                End While

                cbevent.DataSource = eventList
                cbevent.DisplayMember = "Name"
                cbevent.ValueMember = "ID"
            Else
                MessageBox.Show("No events found for today.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub DisplayAttendanceLogs()
        Try
            conn.Open()

            ' Query to fetch the attendance logs for the event
            sqlQuery = "SELECT studno, FullName, yearSec, date, timein_time, timeout_time FROM attendancelog WHERE eventid = @eventid"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@eventid", eventID)  ' Pass eventID as needed

            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            ' Bind the DataTable to the DataGridView
            AttendanceData.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub ClearCooldownStatus(sender As Object, e As EventArgs)
        attendanceStatus.Clear()
        cooldownTimer.Stop()
    End Sub

    Private Sub StartWebcam()
        Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count > 0 Then
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler videoSource.NewFrame, AddressOf VideoSource_NewFrame
            videoSource.Start()
            webcamRunning = True
        Else
            MessageBox.Show("No webcam found.")
        End If
    End Sub

    Private Sub StopWebcam()
        If webcamRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            webcamRunning = False
            pbwebcam.Image = Nothing
        End If
    End Sub

    Private Sub ClearProcessedIDs()
        processedStudentIDs.Clear()
    End Sub

    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        pbwebcam.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        Dim result = qrReader.Decode(eventArgs.Frame)
        If result IsNot Nothing Then
            Dim dataParts As String() = result.Text.Split(","c)
            If dataParts.Length >= 4 Then
                Dim studentID As String = dataParts(3)
                Dim studentName As String = dataParts(0)
                Dim course As String = dataParts(1)
                Dim yrsec As String = dataParts(2)
                Dim yearSectionCourse As String = $"{course}-{yrsec}"
                Dim currentDate As String = DateTime.Now.ToShortDateString()
                Dim currentTime As String = DateTime.Now.ToShortTimeString()

                ' Get the event end time for the selected event
                Dim eventEndTime As DateTime = GetEventEndTime(eventID)

                ' Check if the event has ended
                If DateTime.Now > eventEndTime Then
                    ' Event is still ongoing, allow attendance processing
                    If lastScanTime.ContainsKey(studentID) AndAlso
                   (DateTime.Now - lastScanTime(studentID)).TotalMilliseconds < cooldownInterval Then
                        Return
                    End If

                    lastScanTime(studentID) = DateTime.Now

                    If Not attendanceStatus.ContainsKey(studentID) OrElse attendanceStatus(studentID) = "out" Then
                        Me.Invoke(Sub()
                                      Dim row As String() = New String() {studentID, studentName, yearSectionCourse, currentDate, currentTime, ""}
                                      Dim rowIndex As Integer = AttendanceData.Rows.Add(row)
                                      processedStudentIDs(studentID) = rowIndex
                                      attendanceStatus(studentID) = "in"
                                      SaveAttendanceLog(studentID, studentName, "time-in", currentTime)
                                  End Sub)
                    ElseIf attendanceStatus(studentID) = "in" Then
                        Dim rowIndex As Integer = processedStudentIDs(studentID)
                        Me.Invoke(Sub()
                                      AttendanceData.Rows(rowIndex).Cells(5).Value = currentTime
                                  End Sub)
                        attendanceStatus(studentID) = "out"
                        SaveAttendanceLog(studentID, studentName, "time-out", currentTime)
                    End If
                Else
                    ' Event has ended, no new attendance is allowed
                    MessageBox.Show("This event has already ended. No further attendance is allowed.")
                End If
            End If
        End If
    End Sub

    Private Sub SaveAttendanceLog(studno As String, studentName As String, yearSec As String, currentTime As DateTime)
        Try
            conn.Open()

            ' Query to check if the student has already checked in (time-in is not null, timeout_time is null)
            sqlQuery = "SELECT * FROM attendancelog WHERE studno = @studno AND eventid = @eventid AND timein_time IS NOT NULL AND timeout_time IS NULL"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@studno", studno)
            cmd.Parameters.AddWithValue("@eventid", eventID)  ' Pass eventID as needed

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                ' If the student has checked in already, update the timeout time
                dr.Close()
                sqlQuery = "UPDATE attendancelog SET timeout_time = @timeout_time WHERE studno = @studno AND eventid = @eventid AND timeout_time IS NULL"
                cmd = New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@timeout_time", currentTime)
                cmd.Parameters.AddWithValue("@studno", studno)
                cmd.Parameters.AddWithValue("@eventid", eventID)  ' Pass eventID as needed
                cmd.ExecuteNonQuery()

                ' Optionally, you can update the DataGridView here if needed
            Else
                ' Insert a new attendance record (time-in)
                dr.Close()
                sqlQuery = "INSERT INTO attendancelog (studno, FullName, yearSec, eventid, eventname, date, timein_time) " &
                       "VALUES (@studno, @FullName, @yearSec, @eventid, @eventname, @date, @timein_time)"
                cmd = New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@studno", studno)
                cmd.Parameters.AddWithValue("@FullName", studentName)
                cmd.Parameters.AddWithValue("@yearSec", yearSec)
                cmd.Parameters.AddWithValue("@eventid", eventID)  ' Pass eventID
                cmd.Parameters.AddWithValue("@eventname", cbevent.SelectedItem.ToString())  ' Pass event name
                cmd.Parameters.AddWithValue("@date", currentTime.ToString("yyyy-MM-dd")) ' Format current date for SQL
                cmd.Parameters.AddWithValue("@timein_time", currentTime) ' Current datetime for time-in
                cmd.ExecuteNonQuery()

                ' Optionally, you can update the DataGridView here if needed
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Function GetEventEndTime(eventID As Integer) As DateTime
        Try
            ' Query to get the end time of the event
            sqlQuery = "SELECT endtime FROM events WHERE eventid = @eventid"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@eventid", eventID)

            conn.Open()
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                ' Assuming eventendtime is of type datetime
                Return Convert.ToDateTime(dr("endtime"))
            Else
                Return DateTime.MinValue ' Return a default value if not found
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return DateTime.MinValue
        Finally
            conn.Close()
        End Try
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = Date.Now.ToString()
        timedate.Text = s
    End Sub

    Private Sub AttendanceForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Me.Visible Then
            StopWebcam()
        End If
    End Sub

    Private Sub cbevent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbevent.SelectedIndexChanged
        If cbevent.SelectedItem IsNot Nothing Then
            Dim selectedEvent As EventData = CType(cbevent.SelectedItem, EventData)
            Dim selectedEventID As Integer = selectedEvent.ID
            ' You can now use selectedEventID for further processing
        End If
    End Sub
End Class