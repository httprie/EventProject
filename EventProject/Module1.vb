Imports MySql.Data.MySqlClient
Module Module1

    Public conn As New MySqlConnection
    Public Sub DbConnect()

        Dim dbname As String = "EventRegistrationSystem"
        Dim uname As String = "root"
        Dim password As String = "admin" 'mysql paswword
        Dim server As String = "127.0.0.1" 'ip address pc

        'check connection 
        If Not conn Is Nothing Then
            conn.Close()
            'new connection create
            conn.ConnectionString = "server= " & server & ";user id = " & uname & "; password= " &
            password & ";database=" & dbname & ""
            ' testing si bakla if mag connect 
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

End Module