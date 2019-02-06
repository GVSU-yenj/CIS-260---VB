Option Strict On
Public Class SemesterBudgeter

    Dim TotalExpense As Decimal = 0
    Dim TotalIncome As Decimal = 0

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'the expense inputs
        ClothingExpense.Clear()
        CarMaintenanceExpense.Clear()
        GasExpense.Clear()
        UtilExpense.Clear()
        RentExpense.Clear()
        EntertainmentExpense.Clear()
        FoodExpense.Clear()
        MiscExpense.Clear()
        'the expense percentages
        ClothingPercentage.Clear()
        CarMaintenancePercentage.Clear()
        GasPercentage.Clear()
        UtilPercentage.Clear()
        RentPercentage.Clear()
        EntertainmentPercentage.Clear()
        FoodPercentage.Clear()
        MiscPercentage.Clear()
        'the income inputs
        ParentIncome.Clear()
        JobIncome.Clear()
        ExcessScholarshipIncome.Clear()
        SellingIncome.Clear()
        'the income percentages
        ParentPercentage.Clear()
        JobPercentage.Clear()
        ExcessScholarshipPercentage.Clear()
        SellingPercentage.Clear()
        'the totals
        TotalExpenseOutput.Clear()
        TotalIncomeOutput.Clear()
        BalanceOutput.Text = "[    ]"
        BalanceOutput.ForeColor = Color.Black

        ClothingExpense.Select()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click

        '//checking to see if there is a blank box, starting with expenses
        If ClothingExpense.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into clothing expense")
        ElseIf CarMaintenanceExpense.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into car maintenance expense")
        ElseIf GasExpense.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into gas (car) expense")
        ElseIf UtilExpense.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into utilities expense")
        ElseIf RentExpense.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into rent expense")
        ElseIf EntertainmentExpense.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into entertainment expense")
        ElseIf FoodExpense.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into food expense")
        ElseIf MiscExpense.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into misc expense")
            '//then the incomes
        ElseIf ParentIncome.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into income from parents")
        ElseIf JobIncome.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into income from jobs")
        ElseIf ExcessScholarshipIncome.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into income from excess scholarships")
        ElseIf SellingIncome.Text.Equals("") Then
            MessageBox.Show("Type a number - 0 or greater - into income from selling stuff")
            '//Checking to see if there is a box that is numeric, starting with expenses
        ElseIf Not IsNumeric(ClothingExpense.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into clothing expense")
        ElseIf Not IsNumeric(CarMaintenanceExpense.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into car maintenance expense")
        ElseIf Not IsNumeric(GasExpense.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into gas (car) expense")
        ElseIf Not IsNumeric(UtilExpense.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into utilities expense")
        ElseIf Not IsNumeric(RentExpense.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into rent expense")
        ElseIf Not IsNumeric(EntertainmentExpense.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into entertainment expense")
        ElseIf Not IsNumeric(FoodExpense.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into food expense")
        ElseIf Not IsNumeric(MiscExpense.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into misc expense")
            '//then the incomes
        ElseIf Not IsNumeric(ParentIncome.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into income from parents")
        ElseIf Not IsNumeric(JobIncome.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into income from jobs")
        ElseIf Not IsNumeric(ExcessScholarshipIncome.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into income from excess scholarships")
        ElseIf Not IsNumeric(SellingIncome.Text) Then
            MessageBox.Show("Type a number - 0 or greater - into income from selling stuff")
            '//checking to see if all boxes are positive, starting with expenses
        ElseIf Convert.ToDecimal(ClothingExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into clothing expense")
        ElseIf Convert.ToDecimal(CarMaintenanceExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into car maintenance expense")
        ElseIf Convert.ToDecimal(GasExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into gas (car) expense")
        ElseIf Convert.ToDecimal(UtilExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into utilities expense")
        ElseIf Convert.ToDecimal(RentExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into rent expense")
        ElseIf Convert.ToDecimal(EntertainmentExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into entertainment expense")
        ElseIf Convert.ToDecimal(FoodExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into food expense")
        ElseIf Convert.ToDecimal(MiscExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into misc expense")
            '//then the incomes
        ElseIf Convert.ToDecimal(ParentIncome.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into income from parents")
        ElseIf Convert.ToDecimal(JobIncome.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into income from jobs")
        ElseIf Convert.ToDecimal(ExcessScholarshipIncome.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into income from excess scholarships")
        ElseIf Convert.ToDecimal(SellingIncome.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into income from selling stuff")
            '//finally time to calculate
        Else
            Dim TempExpense As Decimal = 0
            Dim TempIncome As Decimal = 0

            TempExpense += Convert.ToDecimal(ClothingExpense.Text)
            TempExpense += Convert.ToDecimal(CarMaintenanceExpense.Text)
            TempExpense += Convert.ToDecimal(GasExpense.Text)
            TempExpense += Convert.ToDecimal(UtilExpense.Text)
            TempExpense += Convert.ToDecimal(RentExpense.Text)
            TempExpense += Convert.ToDecimal(EntertainmentExpense.Text)
            TempExpense += Convert.ToDecimal(FoodExpense.Text)
            TempExpense += Convert.ToDecimal(MiscExpense.Text)

            ClothingPercentage.Text = FormatPercent(Convert.ToDecimal(ClothingExpense.Text) / TempExpense, 1)
            CarMaintenancePercentage.Text = FormatPercent(Convert.ToDecimal(CarMaintenanceExpense.Text) / TempExpense, 1)
            GasPercentage.Text = FormatPercent(Convert.ToDecimal(GasExpense.Text) / TempExpense, 1)
            UtilPercentage.Text = FormatPercent(Convert.ToDecimal(UtilExpense.Text) / TempExpense, 1)
            RentPercentage.Text = FormatPercent(Convert.ToDecimal(RentExpense.Text) / TempExpense, 1)
            EntertainmentPercentage.Text = FormatPercent(Convert.ToDecimal(EntertainmentExpense.Text) / TempExpense, 1)
            FoodPercentage.Text = FormatPercent(Convert.ToDecimal(FoodExpense.Text) / TempExpense, 1)
            MiscPercentage.Text = FormatPercent(Convert.ToDecimal(MiscExpense.Text) / TempExpense, 1)

            TempIncome += Convert.ToDecimal(ParentIncome.Text)
            TempIncome += Convert.ToDecimal(JobIncome.Text)
            TempIncome += Convert.ToDecimal(ExcessScholarshipIncome.Text)
            TempIncome += Convert.ToDecimal(SellingIncome.Text)

            ParentPercentage.Text = FormatPercent(Convert.ToDecimal(ParentIncome.Text) / TempIncome, 1)
            JobPercentage.Text = FormatPercent(Convert.ToDecimal(JobIncome.Text) / TempIncome, 1)
            ExcessScholarshipPercentage.Text = FormatPercent(Convert.ToDecimal(ExcessScholarshipIncome.Text) / TempIncome, 1)
            SellingPercentage.Text = FormatPercent(Convert.ToDecimal(SellingIncome.Text) / TempIncome, 1)

            If Convert.ToDecimal(TempIncome) - Convert.ToDecimal(TempExpense) < 0 Then
                BalanceOutput.ForeColor = Color.DarkRed
                BalanceOutput.Text = (Convert.ToDecimal(TempIncome) - Convert.ToDecimal(TempExpense)).ToString("C2")
            ElseIf Convert.ToDecimal(TempIncome) - Convert.ToDecimal(TempExpense) < 0 Then
                BalanceOutput.ForeColor = Color.LightGreen
                BalanceOutput.Text = (Convert.ToDecimal(TempIncome) - Convert.ToDecimal(TempExpense)).ToString("C2")
            End If

            TotalExpenseOutput.Text = TempExpense.ToString("C2")
            TotalIncomeOutput.Text = TempIncome.ToString("C2")

            TempExpense = 0
            TempIncome = 0

        End If
    End Sub

End Class
