Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar

Public Class CreateAccount
    Dim Firstname, Lastname, position, Password, email, Status As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Dim Emp_since, idNum As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Firstname = txtFirstname.Text
        Lastname = txtLastName.Text
        position = txtPosition.Text
        Password = txtPassword.Text
        Status = txtStatus.Text

        If Integer.TryParse(txtEmpSince.Text, Emp_since) Then
            If Firstname = "" Or Lastname = "" Or position = "" Or Password = "" Then
                MessageBox.Show("Please fill up necessary details", "LOGIN UNSUCCESSFUL", MessageBoxButtons.RetryCancel)
                txtFirstname.Clear()
                txtLastName.Clear()
                txtPosition.Clear()
                txtPassword.Clear()
                txtEmpSince.Clear()
                txtStatus.Clear()
            Else
                CreateAccountStaff(Firstname, Lastname, position, Emp_since, Password, Status)
            End If
        Else
            MsgBox("Please enter a valid number for year of employment.", "Error", MessageBoxIcon.Error)
            txtEmpSince.Clear()
        End If
    End Sub

End Class
