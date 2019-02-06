Option Strict On
Public Class SemesterBudgeter

    Dim TotalExpense As Decimal = 0
    Dim TotalIncome As Decimal = 0

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'the expenses
        ClothingExpense.Clear()
        CarMaintenanceExpense.Clear()
        GasExpense.Clear()
        UtilExpense.Clear()
        RentExpense.Clear()
        EntertainmentExpense.Clear()
        FoodExpense.Clear()
        MiscExpense.Clear()
        'the incomes
        ParentIncome.Clear()
        JobIncome.Clear()
        ExcessScholarshipIncome.Clear()
        SellingIncome.Clear()
        'the totals
        TotalExpenseOutput.Clear()
        TotalIncomeOutput.Clear()

        ClothingExpense.Select()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim TempExpense As Decimal = 0

        If CInt(ClothingExpense.Text) = 0 Then

        End If
    End Sub

End Class
