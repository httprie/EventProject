Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Data
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions


Public Class GenerateQR
    Private Sub AddButtonsToDataGridView()
        If StudentData.Columns.Contains("Edit") Then StudentData.Columns.Remove("Edit")
        If StudentData.Columns.Contains("Delete") Then StudentData.Columns.Remove("Delete")

        Dim editButton As New DataGridViewButtonColumn()
        editButton.HeaderText = "Edit"
        editButton.Name = "Edit"
        editButton.Text = "Edit"
        editButton.UseColumnTextForButtonValue = True
        StudentData.Columns.Add(editButton)

        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.HeaderText = "Delete"
        deleteButton.Name = "Delete"
        deleteButton.Text = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        StudentData.Columns.Add(deleteButton)
    End Sub

    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click

        Dim fullname As String = txtname.Text
        Dim course As String = txtcourse.Text
        Dim yrsec As String = txtyrsec.Text
        Dim studID As String = txtstudID.Text
        Dim email As String = txtemail.Text

        If String.IsNullOrWhiteSpace(fullname) OrElse String.IsNullOrWhiteSpace(course) OrElse String.IsNullOrWhiteSpace(yrsec) OrElse String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        If EmailExists(email) AndAlso Not isEditing Then
            MessageBox.Show("This email address already exists. Please use a different email.")
            Return
        End If

        Dim gen As New QRCodeEncoder()
        gen.QRCodeScale = 10


        Dim qrData As String = $"{fullname},{course},{yrsec},{studID}"

        Try
            Dim qr As Bitmap = gen.Encode(qrData)

            If qr IsNot Nothing Then
                QRCode.Image = qr

                If isEditing Then
                    UpdateQRCodeInDatabase(fullname, course, yrsec, studID, email, qr)
                    isEditing = False
                    editingStudentID = ""
                Else
                    SaveQRCodeToDatabase(fullname, course, yrsec, studID, email, qr)
                End If
                LoadStudentInfo()
            Else
                MessageBox.Show("Failed to generate QR Code.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private isEditing As Boolean = False
    Private editingStudentID As String = ""

    Private Sub studentData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentData.CellContentClick
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = StudentData.Columns("Edit").Index Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit this student's information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                txtname.Text = StudentData.Rows(e.RowIndex).Cells("FullName").Value.ToString()
                txtcourse.Text = StudentData.Rows(e.RowIndex).Cells("Course").Value.ToString()
                txtyrsec.Text = StudentData.Rows(e.RowIndex).Cells("YearandSection").Value.ToString()
                txtstudID.Text = StudentData.Rows(e.RowIndex).Cells("StudentID").Value.ToString()
                txtemail.Text = StudentData.Rows(e.RowIndex).Cells("Email").Value.ToString()

                isEditing = True
                editingStudentID = StudentData.Rows(e.RowIndex).Cells("StudentID").Value.ToString()
            End If
        ElseIf e.ColumnIndex = StudentData.Columns("Delete").Index Then
            Dim studentID As String = StudentData.Rows(e.RowIndex).Cells("StudentID").Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this student record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                DeleteStudent(studentID)
            End If
        End If
    End Sub

    Private Sub UpdateQRCodeInDatabase(fullname As String, course As String, yrsec As String, studID As String, email As String, qrImage As Bitmap)
        Try
            Using ms As New MemoryStream()
                qrImage.Save(ms, Imaging.ImageFormat.Png)
                Dim qrCodeData As Byte() = ms.ToArray()

                Dim sqlQuery As String = "UPDATE StudentInformation SET FullName = @FullName, Course = @Course, YearandSection = @YearandSection, Email = @Email, QRCodeData = @QRCodeData WHERE StudentID = @StudentID"
                Dim cmd As New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@FullName", fullname)
                cmd.Parameters.AddWithValue("@Course", course)
                cmd.Parameters.AddWithValue("@YearandSection", yrsec)
                cmd.Parameters.AddWithValue("@StudentID", editingStudentID)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@QRCodeData", qrCodeData)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
            MessageBox.Show("Student Information updated successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub DeleteStudent(studentID As String)
        Try
            Dim sqlQuery As String = "DELETE FROM StudentInformation WHERE StudentID = @StudentID"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Student record deleted successfully.")
            LoadStudentInfo()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub SaveQRCodeToDatabase(fullname As String, course As String, yrsec As String, studID As String, email As String, qrImage As Bitmap)
        Try
            If RecordExists(studID) Then
                MessageBox.Show("A record with this Student already exists.")
                Return
            End If

            Using ms As New MemoryStream()
                qrImage.Save(ms, Imaging.ImageFormat.Png)
                Dim qrCodeData As Byte() = ms.ToArray()

                Dim sqlQuery As String = "INSERT INTO StudentInformation (FullName, Course, YearandSection, StudentID, Email, QRCodeData) VALUES (@FullName, @Course, @YearandSection, @StudentID, @Email, @QRCodeData)"
                Dim cmd As New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@FullName", fullname)
                cmd.Parameters.AddWithValue("@Course", course)
                cmd.Parameters.AddWithValue("@YearandSection", yrsec)
                cmd.Parameters.AddWithValue("@StudentID", studID)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@QRCodeData", qrCodeData)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Function RecordExists(studentID As String) As Boolean
        Dim exists As Boolean = False
        Try
            Dim sqlQuery As String = "SELECT COUNT(*) FROM StudentInformation WHERE StudentID = @StudentID"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)

            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            exists = (count > 0)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Return exists
    End Function

    Private Sub LoadStudentInfo()
        Try
            Dim sqlQuery As String = "SELECT StudNo,  StudentID, FullName, Course, YearandSection, Email FROM StudentInformation"
            Dim da As New MySqlDataAdapter(sqlQuery, conn)
            Dim dt As New DataTable()

            conn.Open()
            da.Fill(dt)
            conn.Close()

            StudentData.DataSource = Nothing
            StudentData.Columns.Clear()


            StudentData.DataSource = dt
            AddButtonsToDataGridView()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim fullname As String = txtname.Text
        Dim course As String = txtcourse.Text
        Dim yrsec As String = txtyrsec.Text
        Dim studID As String = txtstudID.Text
        Dim email As String = txtemail.Text

        If String.IsNullOrWhiteSpace(fullname) OrElse String.IsNullOrWhiteSpace(course) OrElse String.IsNullOrWhiteSpace(yrsec) OrElse String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim save As New SaveFileDialog()

        save.InitialDirectory = "C:\Users\user\Documents\BASILIO\QRCode"
        save.FileName = txtname.Text
        save.Filter = "PNG|*.png"

        If save.ShowDialog() = DialogResult.OK Then
            If QRCode.Image IsNot Nothing Then
                QRCode.Image.Save(save.FileName, Imaging.ImageFormat.Png)
            Else
                MessageBox.Show("No QR Code Image to save.")
            End If
        End If
    End Sub

    Private Sub btnsendEmail_Click(sender As Object, e As EventArgs) Handles btnsendEmail.Click
        Dim fullname As String = txtname.Text
        Dim course As String = txtcourse.Text
        Dim yrsec As String = txtyrsec.Text
        Dim studID As String = txtstudID.Text
        Dim email As String = txtemail.Text

        If String.IsNullOrWhiteSpace(fullname) OrElse String.IsNullOrWhiteSpace(course) OrElse String.IsNullOrWhiteSpace(yrsec) OrElse String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim obj As New EmailForm

        obj.email = txtemail.Text
        obj.message = "Attendance QR Code" & vbCrLf &
               "Name: " & txtname.Text & vbCrLf &
               "Course: " & txtcourse.Text & vbCrLf &
               "Year and Section: " & txtyrsec.Text & vbCrLf &
               "Student ID: " & txtstudID.Text & vbCrLf & vbCrLf &
               "Please present this at every event you attend. Thank you!"

        obj.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = Date.Now.ToString()
        timedate.Text = s
    End Sub

    Private Sub GenerateQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        AddButtonsToDataGridView()
        LoadStudentInfo()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Clear()
        txtcourse.Clear()
        txtyrsec.Clear()
        txtstudID.Clear()
        txtemail.Clear()
        QRCode.Image = Nothing
    End Sub
    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function

    Private Function EmailExists(email As String) As Boolean
        Dim exists As Boolean = False
        Try
            Dim sqlQuery As String = "SELECT COUNT(*) FROM StudentInformation WHERE Email = @Email"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@Email", email)

            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            exists = (count > 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Return exists
    End Function

End Class