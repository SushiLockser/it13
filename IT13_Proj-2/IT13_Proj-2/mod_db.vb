Imports System.Data.SQLite

Module mod_db
    Public sqliteConnection As New SQLiteConnection("Data Source = " & Application.StartupPath & "\gvalias_user.db")

    Dim sqliteDataAdapter As SQLiteDataAdapter
    Dim dataSet As DataSet

    Public Sub userAdminAccount(ByVal email As String, ByVal password As String)
        Try
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO user_admin VALUES('" & email & "','" & password & "')", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "user_admin")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally

        End Try
    End Sub

    Public Sub userStaffAccount(ByVal idNum As Integer, ByVal firstname As String, ByVal lastname As String, ByVal position As String, ByVal emp_since As String, ByVal password As String)
        Try
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO user_staff VALUES('" & idNum & "','" & firstname & "','" & lastname & "', '" & position & "','" & emp_since & "','" & password & "' )", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "user_staff")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally

        End Try
    End Sub

    Public Sub Product(ByVal id As Integer, ByVal name As String, ByVal product As String, ByVal item_description As String, ByVal quantity As String, ByVal price As String, ByVal supplier As String, ByVal quality As String)
        Try
            dataSet = New DataSet
            sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO product VALUES('" & id & "','" & name & "','" & product & "', '" & item_description & "','" & quantity & "','" & price & "','" & supplier & "','" & quality & "' )", sqliteConnection)
            sqliteDataAdapter.Fill(dataSet, "product")
        Catch ex As SQLiteException
            MessageBox.Show("Error: " & ex.Message)
        Finally

        End Try
    End Sub

    '   Public Sub slogin(ByVal email As String, ByVal password As String)

    '      dataSet = New DataSet
    '      sqliteDataAdapter = New SQLiteDataAdapter("INSERT INTO user_staff VALUES('" & email & "', '" & password & "' )", sqliteConnection)
    '      sqliteDataAdapter.Fill(dataSet, "user_staff")
    '      sqliteDataAdapter = New SQLiteDataAdapter("SELECT firstname, password FROM user_staff('" & email & "', '" & password & "' )", sqliteConnection)

    '  End Sub

End Module
