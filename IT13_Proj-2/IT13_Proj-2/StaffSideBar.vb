Public Class StaffSideBar
    Private Sub btnProjectPage_Click(sender As Object, e As EventArgs) Handles btnProjectPage.Click
        childForm(projectPage)
    End Sub

    Private Sub btnDashboardPage_Click(sender As Object, e As EventArgs) Handles btnDashboardPage.Click
        childForm(dashboardPage)

    End Sub

    Private Sub btnSearchPage_Click(sender As Object, e As EventArgs) Handles btnSearchPage.Click
        childForm(SearchPage)
    End Sub

    Private Sub btnAccountPage_Click(sender As Object, e As EventArgs) Handles btnAccountPage.Click
        childForm(Profile)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub
End Class