Imports MySql.Data.MySqlClient

Public Class AdminAccForm

    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    Private Sub AdminAccForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        DbConnect()
        LoadAccountsData()
        DataAccount.Columns("Password").Visible = False
    End Sub

    Public Event AccountAdded()


    Private Sub LoadAccountsData()
        Try
            sqlQuery = "SELECT * FROM Accounts"
            da = New MySqlDataAdapter(sqlQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            DataAccount.DataSource = dt
            AddButtonsToDataGridView()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub SearchAccountsData(searchQuery As String)
        Try
            sqlQuery = "SELECT * FROM Accounts WHERE UserName LIKE @search OR FullName LIKE @search OR Role LIKE @search"
            da = New MySqlDataAdapter(sqlQuery, conn)
            da.SelectCommand.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
            dt = New DataTable
            da.Fill(dt)
            DataAccount.DataSource = dt
            AddButtonsToDataGridView()

        Catch ex As Exception
            MessageBox.Show("Error during search: " & ex.Message)
        End Try
    End Sub


    Private Sub btnSearchAccount_Click(sender As Object, e As EventArgs) Handles btnSearchAccount.Click
        Dim search As String = txtSearchAcc.Text.Trim()

        If Not String.IsNullOrEmpty(search) Then
            SearchAccountsData(search)
        Else
            LoadAccountsData()
        End If
    End Sub

    Private Sub AddButtonsToDataGridView()
        If DataAccount.Columns.Contains("Edit") Then DataAccount.Columns.Remove("Edit")
        If DataAccount.Columns.Contains("Delete") Then DataAccount.Columns.Remove("Delete")

        Dim editButton As New DataGridViewButtonColumn()
        editButton.HeaderText = "Edit"
        editButton.Text = "Edit"
        editButton.Name = "Edit"
        editButton.UseColumnTextForButtonValue = True
        DataAccount.Columns.Add(editButton)

        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.HeaderText = "Delete"
        deleteButton.Text = "Delete"
        deleteButton.Name = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        DataAccount.Columns.Add(deleteButton)
    End Sub

    Private Sub DataAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataAccount.CellContentClick
        If e.ColumnIndex = DataAccount.Columns("Edit").Index Then
            EditRecord(e.RowIndex)
        ElseIf e.ColumnIndex = DataAccount.Columns("Delete").Index Then
            DeleteRecord(e.RowIndex)
        End If
    End Sub

    Private Sub EditRecord(rowIndex As Integer)
        Dim username As String = DataAccount.Rows(rowIndex).Cells("UserName").Value.ToString()
        Dim fullname As String = DataAccount.Rows(rowIndex).Cells("FullName").Value.ToString()
        Dim password As String = DataAccount.Rows(rowIndex).Cells("Password").Value.ToString()
        Dim role As String = DataAccount.Rows(rowIndex).Cells("Role").Value.ToString()

        Dim editForm As New EditAccountForm()
        editForm.txtUname.Text = username
        editForm.txtFname.Text = fullname
        editForm.txtPwd.Text = password
        editForm.cbRole.SelectedItem = role

        If editForm.ShowDialog() = DialogResult.OK Then

            Dim newUsername As String = editForm.txtuname.Text.Trim()
            Dim newPassword As String = editForm.txtpwd.Text.Trim()
            Dim newFullname As String = editForm.txtfname.Text.Trim()
            Dim newRole As String = editForm.cbRole.SelectedItem.ToString()

            Dim query As String = "UPDATE Accounts SET UserName = @UserName, Password = @Password, FullName = @FullName, Role = @Role WHERE UserName = @OldUserName;"
            Dim cmd As New MySqlCommand(query, Module1.conn)

            cmd.Parameters.AddWithValue("@UserName", newUsername)
            cmd.Parameters.AddWithValue("@Password", newPassword)
            cmd.Parameters.AddWithValue("@FullName", newFullname)
            cmd.Parameters.AddWithValue("@Role", newRole)
            cmd.Parameters.AddWithValue("@OldUserName", username)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record updated successfully.")
                LoadAccountsData()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub DeleteRecord(rowIndex As Integer)
        Dim id As Integer = DataAccount.Rows(rowIndex).Cells("UserID").Value

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then

            Dim query As String = "DELETE FROM Accounts WHERE UserID = @id"
            Dim cmd As New MySqlCommand(query, Module1.conn)
            cmd.Parameters.AddWithValue("@id", id)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully.")
                LoadAccountsData()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timer As String = Date.Now.ToString()
        timedate.Text = timer
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        Dim addAccountForm As New AddAccountForm()

        AddHandler addAccountForm.AccountAdded, AddressOf OnAccountAdded

        addAccountForm.ShowDialog()
        addAccountForm.Show()
    End Sub

    Private Sub OnAccountAdded()
        LoadAccountsData()
    End Sub

End Class
