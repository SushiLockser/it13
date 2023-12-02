Imports System.Windows

Module mod_CRUD

    'ADD STAFF
    Public Sub Add_StaffInformation(idNum As Integer, fullname As String, ByVal password As String, ByVal position As String, ByVal emp_since As String, ByVal email As String, ByVal status As String)
        idNum = mod_db.GetLastValidIdFromDatabase() - 1
        status = "Active"
        fullname = $"{CreateAccount.txtFirstname.Text} {CreateAccount.txtLastName.Text}"
        Dim emailDomain As String = "@gvalias.com"
        email = $"{CreateAccount.txtFirstname.Text.Substring(0, 1)}.{CreateAccount.txtLastName.Text}.{idNum}.{emailDomain}"

        CreateAccount.dgvStaff.Rows.Add(idNum, fullname, password, position, emp_since, email, status)
    End Sub

    'UPDATE STAFF
    Public Sub Update_StaffInformation(ByVal rowIndex As Integer, ByVal fullname As String, ByVal password As String, ByVal position As String, ByVal emp_since As String, ByVal email As String, ByVal status As String)
        Dim idNum As Integer = CInt(CreateAccount.dgvStaff.Rows(rowIndex).Cells(0).Value)
        status = "Active"
        fullname = $"{CreateAccount.txtFirstname.Text} {CreateAccount.txtLastName.Text}"
        Dim emailDomain As String = "@gvalias.com"
        email = $"{CreateAccount.txtFirstname.Text.Substring(0, 1)}.{CreateAccount.txtLastName.Text}.{idNum}.{emailDomain}"

        CreateAccount.dgvStaff.Rows(rowIndex).Cells(1).Value = fullname.ToString
        CreateAccount.dgvStaff.Rows(rowIndex).Cells(2).Value = password.ToString
        CreateAccount.dgvStaff.Rows(rowIndex).Cells(3).Value = position.ToString
        CreateAccount.dgvStaff.Rows(rowIndex).Cells(4).Value = emp_since.ToString
        CreateAccount.dgvStaff.Rows(rowIndex).Cells(5).Value = email.ToString
        CreateAccount.dgvStaff.Rows(rowIndex).Cells(6).Value = status.ToString

    End Sub

    'delete record
    Public Sub Remove_StaffInformation(ByVal rowIndex As Integer)
        CreateAccount.dgvStaff.Rows.RemoveAt(rowIndex)
    End Sub

    ' ---------------------- PRODUCTS ----------------------

    Dim qty, prc, multiply As Double

    ' total value
    Public Sub Get_Value(ByVal num1 As Double, ByVal num2 As Double)
        qty = num1
        prc = num2
    End Sub

    Public Function getValue()
        multiply = qty * prc
        Return multiply
    End Function

    ' updated at
    Public Sub get_date(ByVal time As DateTime)
        time = DateTime.Now
        Dim format As String = "ddd MM/dd/yyyy HH:mm"
        Console.WriteLine(time.ToString(format))
    End Sub
End Module
