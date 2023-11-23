Imports System.Data.SQLite

Module mod_staff_db
    Public dbConnection As New SQLiteConnection("Data Source = " & Application.StartupPath & "\employee.db")

    Public Sub SQLite_Open_Connection()
        Try
            If dbConnection.State = ConnectionState.Closed Then
                dbConnection.Open()
                MessageBox.Show("Connected duh succeffully", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As SQLiteException
            MessageBox.Show("Error: ", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SQLite_Close_Connection()
        Try
            If dbConnection.State = ConnectionState.Open Then
                dbConnection.Close()
                MsgBox("Disconnected")
            End If
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

End Module
