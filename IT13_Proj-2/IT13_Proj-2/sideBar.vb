Public Class sideBar


    Private Sub btnProjectPage_Click(sender As Object, e As EventArgs) Handles btnProjectPage.Click
        childForm(projectPage)

    End Sub

    Private Sub btnDashboardPage_Click(sender As Object, e As EventArgs) Handles btnDashboardPage.Click
        childForm(dashboardPage)
    End Sub

    Private Sub btnSearchPage_Click(sender As Object, e As EventArgs) Handles btnSearchPage.Click
        childForm(SearchPage)
    End Sub

    Private Sub BtnEcoPage_Click(sender As Object, e As EventArgs) Handles BtnEcoPage.Click
        childForm(EconomicPage)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class