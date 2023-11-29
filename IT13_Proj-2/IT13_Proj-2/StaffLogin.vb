Public Class StaffLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text
        Dim pass As String = txtPassword.Text

        If email = "" Or pass = "" Then
            MessageBox.Show("Please enter both email and password.", "LOGIN UNSUCCESSFUL", MessageBoxButtons.RetryCancel)
        Else
            If staffLoginFunction(email, pass) Then
                MessageBox.Show("Welcome!", "LOGIN SUCCESSFULLY", MessageBoxButtons.OK)
                StaffSideBar.Show()
            Else
                MessageBox.Show("Incorrect email or password.", "LOGIN UNSUCCESSFUL", MessageBoxButtons.RetryCancel)
            End If
        End If
    End Sub

End Class