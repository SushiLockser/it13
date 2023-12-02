Public Class AddProject

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim productname As String = txtProductName.Text

        If productname = "" Then
            MessageBox.Show("Please enter the Product Name", "UNSUCCESSFUL", MessageBoxButtons.RetryCancel)
            txtProductName.Clear()
        Else
            childForm(projectPage)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class