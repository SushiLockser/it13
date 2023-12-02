Public Class projectPage
    Private Sub btnAddProj_Click(sender As Object, e As EventArgs) Handles btnAddProj.Click
        AddProject.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Pag-click ang row kay mapunta siya sa ProductPage
        'Copy+Paste lngss itu na code--> childForm(ViewProject)
    End Sub
End Class