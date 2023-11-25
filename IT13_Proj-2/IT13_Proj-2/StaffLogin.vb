Public Class StaffLogin
    Dim email As String
    Dim password As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        email = txtEmail.Text
        password = txtPassword.Text

        slogin(email, password)

        StaffSideBar.Show()
    End Sub
End Class