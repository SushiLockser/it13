Imports System.Data.SQLite
Imports System.Net.Security
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module mod_db
    Dim connectionString As String = "Data Source= " & Application.StartupPath & "\gvalias_user.db; Intergrated Security=true"
    Dim connection As SQLiteConnection

    'ADMIN LOGIN ACCOUNT
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

    'ADMIN TO FETCH THE DATA FROM THE DATABASE
    Public Function adminLoginFunction(username As String, password As String) As Boolean
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand("SELECT COUNT(*) FROM user_admin WHERE username = @Username AND password = @Password;", connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using

        End Using
    End Function

    'ADMIN PART TO CREATE AN ACCOUNT FOR STAFF
    Public Sub CreateAccountStaff(ByVal firstname As String, ByVal Lastname As String, ByVal position As String, ByVal Emp_since As Integer, ByVal Password As String, ByVal status As String)

        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand("INSERT INTO user_staff (firstname, lastname, position, emp_since, password, email, status) VALUES (@FirstName, @Lastname, @Position, @Emp_since, @Password, @Email, @Status);", connection)
                    Dim emailDomain As String = "@gvalias.com"
                    Dim idNum As Integer = GetLastValidIdFromDatabase()
                    Dim concatenatedEmail As String = $"{firstname.ToLower().Substring(0, 1)}.{Lastname.ToLower()}.{idNum}{emailDomain}"
                    command.Parameters.AddWithValue("@FirstName", firstname)
                    command.Parameters.AddWithValue("@Lastname", Lastname)
                    command.Parameters.AddWithValue("@Position", position)
                    command.Parameters.AddWithValue("@Emp_since", Emp_since)
                    command.Parameters.AddWithValue("@Password", Password)
                    command.Parameters.AddWithValue("@Email", concatenatedEmail)
                    command.Parameters.AddWithValue("@Status", status)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Email: " & concatenatedEmail & vbNewLine & "Password: " & Password, "GENERATED ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            End Using
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        End Try
        connection.Close()

    End Sub

    'CONCAT EMAIL ACCOUNT FOR STAFF
    Public Function GenerateEmail(ByVal firstname As String, ByVal lastname As String, ByVal idNum As Integer) As String

        Dim emailDomain As String = "@gvalias.com"
        Dim generatedEmail As String = $"{firstname.ToLower().Substring(0, 1)}.{lastname.ToLower()}.{idNum}{emailDomain}"
        Return generatedEmail

    End Function

    'GENERATED PASSWORD
    Public Function GeneratePassword(ByVal password As String)

        Dim generatedpassword As String = $"{password.ToLower()}"
        Return generatedpassword
    End Function

    'IDNUM
    Public Function GetLastValidIdFromDatabase() As Integer
        Dim lastValidId As Integer = -1

        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand("SELECT COALESCE(MAX(idNum), 0) +1 FROM user_staff;", connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), lastValidId) Then
                        Return lastValidId
                    End If
                End Using
            End Using
        Catch ex As SQLiteException
            MessageBox.Show("Error fetching last valid ID: " & ex.Message)
        End Try

        Return lastValidId
    End Function


    'LOGIN ACCOUNT FOR STAFF
    Public Function staffLoginFunction(email As String, password As String) As Boolean
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand("SELECT COUNT(*) FROM user_staff WHERE email = @Email AND password = @Password;", connection)
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
    End Function


End Module
