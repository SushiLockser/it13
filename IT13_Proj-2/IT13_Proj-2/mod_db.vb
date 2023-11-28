Imports System.Data.SQLite
Imports System.Net.Security
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module mod_db
    Dim connectionString As String = "Data Source= " & Application.StartupPath & "\gvalias_user.db; Intergrated Security=true"
    Dim connection As SQLiteConnection

    Public Sub AdminAccount(ByVal admin_username As String, ByVal admin_password As String)
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand("INSERT INTO user_admin (username, password) VALUES (@userNameAdmin, @passwordAdmin);", connection)
                    command.Parameters.AddWithValue("@emailAdmin", admin_username)
                    command.Parameters.AddWithValue("@passwordAdmin", admin_password)
                    command.ExecuteNonQuery()
                    Console.WriteLine("Admin account created successfully.")
                End Using
            End Using
        Catch ex As SQLiteException
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Public Function admin() As Tuple(Of String, String)
        Try
            Using connection As New SQLiteConnection(connectionString)
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

    Public Sub CreateAccountStaff(ByVal firstname As String, ByVal Lastname As String, ByVal position As String, ByVal Emp_since As Integer, ByVal Password As String, ByVal idNum As Integer)

        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand("INSERT INTO user_staff (firstname, lastname, position, emp_since, password, email) VALUES (@FirstName, @Lastname, @Position, @Emp_since, @Password, @Email);", connection)
                    Dim emailDomain As String = "@gvalias.com"
                    Dim concatenatedEmail As String = $"{firstname.ToLower().Substring(0, 1)}.{Lastname.ToLower()}.{idNum}{emailDomain}"
                    command.Parameters.AddWithValue("@FirstName", firstname)
                    command.Parameters.AddWithValue("@Lastname", Lastname)
                    command.Parameters.AddWithValue("@Position", position)
                    command.Parameters.AddWithValue("@Emp_since", Emp_since)
                    command.Parameters.AddWithValue("@Password", Password)
                    command.Parameters.AddWithValue("@Email", concatenatedEmail)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Public Function GenerateEmail(ByVal firstname As String, ByVal lastname As String, ByVal idNum As Integer) As String

        Dim emailDomain As String = "@gvalias.com"
        Dim generatedEmail As String = $"{firstname.ToLower().Substring(0, 1)}.{lastname.ToLower()}.{idNum}{emailDomain}"
        Return generatedEmail

    End Function

    Public Function GeneratePassword(ByVal password As String)

        Dim generatedpassword As String = $"{password.ToLower()}"
        Return generatedpassword
    End Function

    Public Function GetLastInsertedIdFromDatabase() As Integer
        Dim lastInsertedId As Integer = -1

        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand("SELECT COALESCE(MAX(idNum), 0) + 1 FROM user_staff;", connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), lastInsertedId) Then
                        Return lastInsertedId
                    End If
                End Using
            End Using
        Catch ex As SQLiteException
            MessageBox.Show("Error fetching last inserted ID: " & ex.Message)
        End Try

        Return lastInsertedId
    End Function

    Public Function staffAccountLogin(ByVal email As String, ByVal password As String) As Boolean
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand("SELECT COUNT(*) From user_staff WHERE email = @Email And password = @Password);", connection)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Password", password)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Function


End Module
