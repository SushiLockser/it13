Public Class ViewProject
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        childForm(AddProduct)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Pag-click ang row kay mapunta siya sa ProductPage
        'Copy+Paste lngss itu na code--> childForm(ProductPage)
    End Sub
End Class