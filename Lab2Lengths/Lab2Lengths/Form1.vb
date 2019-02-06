Option Strict On

Public Class Form1
    Dim InputValue As Double
    Dim OutputValue As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConvertType.SelectedIndexChanged
        If ConvertType.SelectedIndex = 0 Then
            InputLbl.Text = "Miles"
            OutputLbl.Text = "To Kilometers"
        ElseIf ConvertType.SelectedIndex = 1 Then
            InputLbl.Text = "Kilometers"
            OutputLbl.Text = "To Miles"
        ElseIf ConvertType.SelectedIndex = 2 Then
            InputLbl.Text = "Feet"
            OutputLbl.Text = "To Meters"
        ElseIf ConvertType.SelectedIndex = 3 Then
            InputLbl.Text = "Meters"
            OutputLbl.Text = "To Feet"
        ElseIf ConvertType.SelectedIndex = 4 Then
            InputLbl.Text = "Inches"
            OutputLbl.Text = "To Centimeters"
        ElseIf ConvertType.SelectedIndex = 5 Then
            InputLbl.Text = "Centimeters"
            OutputLbl.Text = "To Inches"
        End If
    End Sub

    Private Sub ConvertBtn_Click(sender As Object, e As EventArgs) Handles ConvertBtn.Click
        'extra time/to do - display an error message due to lack of requirement
        If UnitInput.Text = "" Then
            MessageBox.Show("Please enter a value.", "Error")
        ElseIf ConvertType.SelectedIndex = -1 Then
            MessageBox.Show("Please choose a conversion.", "Error")
            'end extra time/to do
        ElseIf ConvertType.SelectedIndex = 0 Then
            InputValue = Convert.ToDouble(UnitInput.Text)
            OutputValue = InputValue * 1.6093
            UnitOutput.Text = CType(OutputValue, String)
        ElseIf ConvertType.SelectedIndex = 1 Then
            InputValue = Convert.ToDouble(UnitInput.Text)
            OutputValue = InputValue * 0.6214
            UnitOutput.Text = CType(OutputValue, String)
        ElseIf ConvertType.SelectedIndex = 2 Then
            InputValue = Convert.ToDouble(UnitInput.Text)
            OutputValue = InputValue * 0.3048
            UnitOutput.Text = CType(OutputValue, String)
        ElseIf ConvertType.SelectedIndex = 3 Then
            InputValue = Convert.ToDouble(UnitInput.Text)
            OutputValue = InputValue * 3.2808
            UnitOutput.Text = CType(OutputValue, String)
        ElseIf ConvertType.SelectedIndex = 4 Then
            InputValue = Convert.ToDouble(UnitInput.Text)
            OutputValue = InputValue * 2.54
            UnitOutput.Text = CType(OutputValue, String)
        ElseIf ConvertType.SelectedIndex = 5 Then
            InputValue = Convert.ToDouble(UnitInput.Text)
            OutputValue = InputValue * 0.3937
            UnitOutput.Text = CType(OutputValue, String)
        End If
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        UnitInput.Clear()
        UnitOutput.Clear()
        InputLbl.Text = "Convert This:"
        OutputLbl.Text = "To This:"
        ConvertType.SelectedIndex = -1
        UnitInput.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
