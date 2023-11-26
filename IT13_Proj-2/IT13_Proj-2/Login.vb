Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim enteredEmail As String = txtUsername.Text
        Dim enteredPassword As String = txtPassword.Text

        Dim adminCredentials = mod_db.admin()

        If enteredEmail = adminCredentials.Item1 AndAlso enteredPassword = adminCredentials.Item2 Then
            MessageBox.Show("Login successful. Welcome, Admin!")
            sideBar.Show()
        Else
            MessageBox.Show("Invalid credentials. Please try again.")
        End If
    End Sub
End Class