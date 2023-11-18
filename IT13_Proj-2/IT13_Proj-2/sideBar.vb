Public Class sideBar


    Private Sub btnProjectPage_Click(sender As Object, e As EventArgs) Handles btnProjectPage.Click
        childForm(projectPage)

    End Sub

    Private Sub btnDashboardPage_Click(sender As Object, e As EventArgs) Handles btnDashboardPage.Click
        childForm(dashboardPage)
    End Sub

    Private Sub pagePlaceholder_Paint(sender As Object, e As PaintEventArgs) Handles pagePlaceholder.Paint

    End Sub

    Private Sub btnSearchPage_Click(sender As Object, e As EventArgs) Handles btnSearchPage.Click
        childForm(SearchPage)
    End Sub

    Private Sub BtnEcoPage_Click(sender As Object, e As EventArgs) Handles BtnEcoPage.Click
        childForm(EconomicPage)
    End Sub
End Class