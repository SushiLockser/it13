Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar

Public Class CreateAccount
    Dim Firstname, Lastname, position, Password, email, status As String

    Dim indexCount, idNum As Integer
    Dim selectedDate As String
    Dim fullname As String
    Dim emailDomain As String = "@gvalias.com"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Firstname = txtFirstname.Text
        Lastname = txtLastName.Text
        position = txtPosition.Text
        Password = txtPassword.Text
        selectedDate = dtpEmpSince.Value

        If Firstname = "" Or Lastname = "" Or position = "" Or Password = "" Then
            MessageBox.Show("Please fill up necessary details", "LOGIN UNSUCCESSFUL", MessageBoxButtons.RetryCancel)
            txtFirstname.Clear()
            txtLastName.Clear()
            txtPosition.Clear()
            txtPassword.Clear()
        Else
            CreateAccountStaff(Firstname, Lastname, position, selectedDate, Password, status)
            Add_StaffInformation(idNum, fullname, Password, position, selectedDate, email, status)
        End If

    End Sub

    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        'ID
        idNum = dgvStaff.Rows(indexCount).Cells(0).Value.ToString

        'NAME
        fullname = dgvStaff.Rows(indexCount).Cells(1).Value.ToString

        'PASSWORD
        txtPassword.Text = dgvStaff.Rows(indexCount).Cells(2).Value.ToString

        'POSITION
        txtPosition.Text = dgvStaff.Rows(indexCount).Cells(3).Value.ToString

        'EMPLOYEE YEAR
        selectedDate = dgvStaff.Rows(indexCount).Cells(4).Value.ToString

        'EMAIL
        email = dgvStaff.Rows(indexCount).Cells(5).Value.ToString

        'STATUS
        status = dgvStaff.Rows(indexCount).Cells(6).Value.ToString

    End Sub
End Class
