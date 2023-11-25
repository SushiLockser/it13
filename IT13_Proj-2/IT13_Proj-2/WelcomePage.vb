Public Class WelcomePage
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Login.Show()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        StaffLogin.Show()
    End Sub
End Class