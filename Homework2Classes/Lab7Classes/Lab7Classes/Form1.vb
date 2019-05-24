'Author: Jon Yen
'Assignment: HW 2
'Date: 3/23/2019
Option Strict On
Public Class Form1
    Dim header As String = "First Name".PadRight(25) & "Last Name".PadRight(30) & "Email"
    Dim DepartmentHeader As String = "Name".PadRight(45) & "Department"
    Dim EmployeeList As New List(Of EmployeeInformation)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstEmployeeInfo.Items.Add(header)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim departmentNumber As Integer = Convert.ToInt32(txtDepartmentNo.Text)
        Dim email As String = txtEmail.Text

        If IsValidData(txtFirstName, txtLastName, txtDepartmentNo, txtEmail) Then
            Dim Employee As New EmployeeInformation(txtFirstName.Text, txtLastName.Text, Convert.ToInt32(txtDepartmentNo.Text), txtEmail.Text, txtPhone.Text, txtDateHired.Text)
            EmployeeList.Add(Employee)
            Dim EmployeeEntry As String = Employee.DisplayAddress() & ControlChars.CrLf
            lstEmployeeInfo.Items.Add(EmployeeEntry)
        End If
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

    Public Function IsValidData(fNameBox As TextBox, lNamebox As TextBox, depNumBox As TextBox, emailBox As TextBox) As Boolean
        If Validator.IsPresent(fNameBox) AndAlso Validator.IsPresent(lNamebox) _
            AndAlso Validator.IsInt32(depNumBox) AndAlso Validator.IsValidEmailAddress(emailBox) Then
            Return True
        Else Return False

        End If
    End Function

    Private Sub btnDepartmentDisplay_Click(sender As Object, e As EventArgs) Handles btnDepartmentDisplay.Click
        lstEmployeeInfo.Items.Clear()
        lstEmployeeInfo.Items.Add(DepartmentHeader)

        For Each employee As EmployeeInformation In EmployeeList
            lstEmployeeInfo.Items.Add(employee.EmployeeDepartment())
        Next
    End Sub
End Class
