Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim pass As String = txtPassword.Text

        If username = "" Or pass = "" Then
            MessageBox.Show("Please enter both email and password.", "LOGIN UNSUCCESSFUL", MessageBoxButtons.RetryCancel)
            txtUsername.Clear()
            txtPassword.Clear()
        Else
            If adminLoginFunction(username, pass) Then
                MessageBox.Show("Welcome! Admin", "LOGIN SUCCESSFULLY", MessageBoxButtons.OK)
                sideBar.Show()
            Else
                MessageBox.Show("Incorrect email or password.", "LOGIN UNSUCCESSFUL", MessageBoxButtons.RetryCancel)
                txtUsername.Clear()
                txtPassword.Clear()
            End If
        End If
    End Sub

End Class