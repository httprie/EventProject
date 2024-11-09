Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class AddEventsForm
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Dim cmd As New MySqlCommand
    Dim sqlQuery As String
    Dim da As MySqlDataAdapter

    Public Property ParentFormInstance As EventsForm
    Public Property IsEditMode As Boolean = False
    Public Property EventID As Integer

    Public EventIDtoEdit As Integer
    Public EventName As String
    Public Venue As String
    Public EventDate As DateTime
    Public Department As String
    Public StartTime As DateTime
    Public EndTime As DateTime
    Public Created_By As String

    Private loggedInUser As String

    ' Constructor to accept logged-in user's full name
    Public Sub New(userFullName As String)
        InitializeComponent()
        loggedInUser = userFullName
    End Sub
    Private Sub AddNewEventsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        dtpEventDate.Value = DateTime.Now.Date
        dtpStartTime.Value = DateTime.Now
        dtpEndTime.Value = DateTime.Now


        If IsEditMode Then
            Label7.Text = "Edit Event"
            btnAddEvent.Text = "Edit Event"

            txtEventName.Text = EventName
            txtVenue.Text = Venue
            dtpEventDate.Value = EventDate
            txtDepartment.Text = Department
            dtpStartTime.Value = StartTime
            dtpEndTime.Value = EndTime
        Else
            Label7.Text = "Add New Event"
            btnAddEvent.Text = "Add Event"
        End If
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim eventName As String = txtEventName.Text
        Dim venue As String = txtVenue.Text
        Dim department As String = txtDepartment.Text
        Dim eventDate As DateTime = dtpEventDate.Value
        Dim startTime As DateTime = dtpStartTime.Value
        Dim endTime As DateTime = dtpEndTime.Value

        If IsEditMode Then
            Dim confirmEdit As DialogResult = MessageBox.Show("Are you sure you want to edit this event?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmEdit = DialogResult.Yes Then
                If String.IsNullOrWhiteSpace(eventName) OrElse String.IsNullOrWhiteSpace(venue) OrElse String.IsNullOrWhiteSpace(department) Then
                    MessageBox.Show("All fields are required. Please fill them out.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Try
                    sqlQuery = "UPDATE Events SET EventName = @EventName, Venue = @Venue, EventDate = @EventDate, Department = @Department, StartTime = @StartTime, EndTime = @EndTime WHERE EventID = @EventID"
                    cmd = New MySqlCommand(sqlQuery, conn)
                    cmd.Parameters.AddWithValue("@EventID", EventID)
                    cmd.Parameters.AddWithValue("@EventName", eventName)
                    cmd.Parameters.AddWithValue("@Venue", venue)
                    cmd.Parameters.AddWithValue("@EventDate", eventDate)
                    cmd.Parameters.AddWithValue("@Department", department)
                    cmd.Parameters.AddWithValue("@StartTime", startTime.TimeOfDay)
                    cmd.Parameters.AddWithValue("@EndTime", endTime.TimeOfDay)

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    conn.Close()

                    If rowsAffected > 0 Then
                        ParentFormInstance.LoadEventsData()
                        MessageBox.Show("Event edited successfully.")
                    Else
                        MessageBox.Show("Update failed. Please check the EventID.")
                    End If
                    Me.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If

        Else
            Dim confirmAdd As DialogResult = MessageBox.Show("Do you want to add this event?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmAdd = DialogResult.Yes Then
                Try
                    sqlQuery = "INSERT INTO Events (EventName, Venue, EventDate, Department, StartTime, EndTime, Created_By) 
            VALUES (@EventName, @Venue, @EventDate, @Department, @StartTime, @EndTime, @Created_By)"
                    cmd = New MySqlCommand(sqlQuery, conn)
                    cmd.Parameters.AddWithValue("@EventName", eventName)
                    cmd.Parameters.AddWithValue("@Venue", venue)
                    cmd.Parameters.AddWithValue("@EventDate", eventDate)
                    cmd.Parameters.AddWithValue("@Department", department)
                    cmd.Parameters.AddWithValue("@StartTime", startTime.TimeOfDay)
                    cmd.Parameters.AddWithValue("@EndTime", endTime.TimeOfDay)
                    cmd.Parameters.AddWithValue("@Created_By", loggedInUser)  ' Replace with actual username or session data


                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    conn.Close()

                    If rowsAffected > 0 Then
                        ParentFormInstance.LoadEventsData()
                        MessageBox.Show("New event added successfully.")
                    Else
                        MessageBox.Show("Failed to add the event.")
                    End If
                    Me.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub ClearTextBoxes()
        txtEventName.Text = ""
        txtVenue.Text = ""
        txtDepartment.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTextBoxes()
    End Sub
End Class