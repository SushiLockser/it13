Public Class CreateAccount
    Dim firstname, lastname, position, emp_since, password As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        firstname = txtFirstname.Text
        lastname = txtLastName.Text
        position = txtPosition.Text
        emp_since = txtEmpSince.Text
        password = txtPassword.Text



    End Sub
End Class