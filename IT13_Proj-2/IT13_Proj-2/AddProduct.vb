Public Class AddProduct
    Dim productType, quality, supplier As String
    Dim quantity, quantityUsed, price As Integer
    Dim num1, num2, total As Double
    Dim currentDate As DateTime
    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this is supposed to be sa form
        lblProductName.Text = AddProject.txtProductName.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        quantity = CInt(txtQuantity.Text)
        quantityUsed = CInt(txtQuantityUsed.Text)
        productType = cbProductType.SelectedItem.ToString()
        quality = cbQuality.SelectedItem.ToString()
        price = CInt(txtPrice.Text)
        supplier = txtSupplier.Text

        If ProductName = "" Then
            MessageBox.Show("Please input the form", "UNSUCCESSFUL", MessageBoxButtons.RetryCancel)
            txtQuantity.Clear()
            txtQuantityUsed.Clear()
            txtPrice.Clear()
            txtSupplier.Clear()
        Else

            'TOTAL VALUE
            num1 = CDbl(txtQuantity.Text)
            num2 = CDbl(txtPrice.Text)
            Get_Value(num1, num2)
            total = getValue()
            lblTotalValue.Text = total

            'SET DATE
            currentDate = set_date()
            lblUpdatedAt.Text = currentDate
        End If
    End Sub
End Class