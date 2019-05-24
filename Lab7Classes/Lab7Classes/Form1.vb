Public Class Form1
    Dim header As String = "First Name".PadRight(25) & "Last Name".PadRight(30) & "Email"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstEmployeeInfo.Items.Add(header)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim Employee As New EmployeeInformation(txtFirstName.Text, txtLastName.Text, txtDepartmentNo.Text, txtEmail.Text, txtPhone.Text, txtDateHired.Text)
        Dim EmployeeEntry As String = Employee.DisplayAddress() & ControlChars.CrLf
        lstEmployeeInfo.Items.Add(EmployeeEntry)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearTextBoxes()
    End Sub

    Private Sub clearTextBoxes()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = String.Empty
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                ctrl.Text = String.Empty
            End If
        Next ctrl

        txtFirstName.Select()
    End Sub

    Private Sub btnLstClear_Click(sender As Object, e As EventArgs) Handles btnLstClear.Click
        lstEmployeeInfo.Items.Clear()
        lstEmployeeInfo.Items.Add(header)
    End Sub
End Class
