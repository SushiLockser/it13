﻿Public Class CreateAccount
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
                CreateAccountStaff(Firstname, Lastname, position, Emp_since, Password)
            End If
        Else
            MsgBox("Please enter a valid number for year of employment.")
        End If
    End Sub

End Class
