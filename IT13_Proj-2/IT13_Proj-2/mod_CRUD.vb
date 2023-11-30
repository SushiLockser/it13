Module mod_CRUD

    Public Sub Add_StaffInformation(idNum As Integer, fullname As String, ByVal password As String, ByVal position As String, ByVal emp_since As String, ByVal email As String, ByVal status As String)
        idNum = mod_db.GetLastValidIdFromDatabase() - 1
        status = "Active"
        fullname = $"{CreateAccount.txtFirstname.Text} {CreateAccount.txtLastName.Text}"
        Dim emailDomain As String = "@gvalias.com"
        email = $"{CreateAccount.txtFirstname.Text.Substring(0, 1)}.{"."}.{CreateAccount.txtLastName.Text}.{"."}.{idNum}.{emailDomain}"

        CreateAccount.dgvStaff.Rows.Add(idNum, fullname, password, position, emp_since, email, status)
    End Sub

End Module
