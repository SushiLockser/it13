Imports System.Data.SQLite

Module mod_db
    Dim sqliteConnection As String = "Data Source=gvalias_user.db;Version=3;"

    Sub AdminAccount()
        Try
            Using connection As New SQLiteConnection(sqliteConnection)
                connection.Open()
                Dim query As String = "INSERT INTO user_admin (username, password) VALUES (@userNameAdmin, @passwordAdmin);"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@emailAdmin", "Admin")
                    command.Parameters.AddWithValue("@passwordAdmin", "adminpassword")
                    command.ExecuteNonQuery()
                    Console.WriteLine("Admin account created successfully.")
                End Using
            End Using
        Catch ex As SQLiteException
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Function admin() As Tuple(Of String, String)
        Try
            Using connection As New SQLiteConnection(sqliteConnection)
                connection.Open()

                Dim query As String = "SELECT username, password FROM user_admin LIMIT 1;"
                Using command As New SQLiteCommand(query, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Return Tuple.Create(reader("username").ToString(), reader("password").ToString())
                        End If
                    End Using
                End Using
            End Using
        Catch ex As SQLiteException
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return Tuple.Create("", "")
    End Function
End Module
