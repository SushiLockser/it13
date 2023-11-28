Public Class StaffLogin
    Dim email, password As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        email = txtEmail.Text
        password = txtPassword.Text


        If email = "" And password = "" Then
            MessageBox.Show("INPUT ACCOUNT", "LOGIN MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            staffAccountLogin(email, password)
            MessageBox.Show("PAYNALEE")
            StaffSideBar.Show()
        End If
    End Sub
End Class