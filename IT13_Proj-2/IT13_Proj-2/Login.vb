Public Class Login
    Dim email, password As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        email = txtEmail.Text
        password = txtPassword.Text

        userAdminAccount(email, password)

        sideBar.Show()
        Me.Hide()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(Application.StartupPath)
    End Sub
End Class