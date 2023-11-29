Public Class StaffLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text
        Dim pass As String = txtPassword.Text


        If email = staffAccountLogin.Item1 And pass = staffAccountLogin.Item2 Then
            MessageBox.Show("Login successful. Welcome, Admin!")
            StaffSideBar.Show()
        Else
            MessageBox.Show("Invalid credentials. Please try again.")
        End If
    End Sub

End Class