Public Class CreateAccount
    Dim Firstname, Lastname, position, Password, email, genPass As String

    Dim Emp_since, idNum As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Firstname = txtFirstname.Text
        Lastname = txtLastName.Text
        position = txtPosition.Text
        Password = txtPassword.Text

        If Integer.TryParse(txtEmpSince.Text, Emp_since) Then
            If Firstname = "" Or Lastname = "" Or position = "" Or Password = "" Then
                MsgBox("ERROR!!")
            Else
                idNum = GetLastInsertedIdFromDatabase()
                Dim idNumAsString As String = idNum.ToString()
                email = GenerateEmail(Firstname, Lastname, idNumAsString)
                genPass = GeneratePassword(Password)
                CreateAccountStaff(Firstname, Lastname, position, Emp_since, Password, idNum)
                MessageBox.Show("Email: " & email & vbNewLine & "Password: " & genPass, "GENERATED ACCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MsgBox("Please enter a valid number for year of employment.")
        End If
    End Sub
End Class
