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
        ElseIf Convert.ToInt32(ClothingExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into clothing expense")
        ElseIf Convert.ToInt32(CarMaintenanceExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into car maintenance expense")
        ElseIf Convert.ToInt32(GasExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into gas (car) expense")
        ElseIf Convert.ToInt32(UtilExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into utilities expense")
        ElseIf Convert.ToInt32(RentExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into rent expense")
        ElseIf Convert.ToInt32(EntertainmentExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into entertainment expense")
        ElseIf Convert.ToInt32(FoodExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into food expense")
        ElseIf Convert.ToInt32(MiscExpense.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into misc expense")
            '//then the incomes
        ElseIf Convert.ToInt32(ParentIncome.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into income from parents")
        ElseIf Convert.ToInt32(JobIncome.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into income from jobs")
        ElseIf Convert.ToInt32(ExcessScholarshipIncome.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into income from excess scholarships")
        ElseIf Convert.ToInt32(SellingIncome.Text) < 0 Then
            MessageBox.Show("Type a number - 0 or greater - into income from selling stuff")
            '//finally time to calculate
        Else
            Dim TempExpense As Decimal = 0
            Dim TempIncome As Decimal = 0

            TempExpense += Convert.ToInt32(ClothingExpense.Text)
            TempExpense += Convert.ToInt32(CarMaintenanceExpense.Text)
            TempExpense += Convert.ToInt32(GasExpense.Text)
            TempExpense += Convert.ToInt32(UtilExpense.Text)
            TempExpense += Convert.ToInt32(RentExpense.Text)
            TempExpense += Convert.ToInt32(EntertainmentExpense.Text)
            TempExpense += Convert.ToInt32(FoodExpense.Text)
            TempExpense += Convert.ToInt32(MiscExpense.Text)

            ClothingPercentage.Text = FormatPercent(Convert.ToInt32(ClothingExpense.Text) / TempExpense)
            CarMaintenancePercentage.Text = FormatPercent(Convert.ToInt32(CarMaintenanceExpense.Text) / TempExpense)
            GasPercentage.Text = FormatPercent(Convert.ToInt32(GasExpense.Text) / TempExpense)
            UtilPercentage.Text = FormatPercent(Convert.ToInt32(UtilExpense.Text) / TempExpense)
            RentPercentage.Text = FormatPercent(Convert.ToInt32(RentExpense.Text) / TempExpense)
            EntertainmentPercentage.Text = FormatPercent(Convert.ToInt32(EntertainmentExpense.Text) / TempExpense)
            FoodPercentage.Text = FormatPercent(Convert.ToInt32(FoodExpense.Text) / TempExpense)
            MiscPercentage.Text = FormatPercent(Convert.ToInt32(MiscExpense.Text) / TempExpense)

            TempIncome += Convert.ToInt32(ParentIncome.Text)
            TempIncome += Convert.ToInt32(JobIncome.Text)
            TempIncome += Convert.ToInt32(ExcessScholarshipIncome.Text)
            TempIncome += Convert.ToInt32(SellingIncome.Text)

            ParentPercentage.Text = FormatPercent(Convert.ToInt32(ParentIncome.Text) / TempIncome)
            JobPercentage.Text = FormatPercent(Convert.ToInt32(JobIncome.Text) / TempIncome)
            ExcessScholarshipPercentage.Text = FormatPercent(Convert.ToInt32(ExcessScholarshipIncome.Text) / TempIncome)
            SellingPercentage.Text = FormatPercent(Convert.ToInt32(SellingIncome.Text) / TempIncome)

            If Convert.ToInt32(TempIncome) - Convert.ToInt32(TempExpense) < 0 Then
                BalanceOutput.ForeColor = Color.DarkRed
                BalanceOutput.Text = (Convert.ToInt32(TempIncome) - Convert.ToInt32(TempExpense)).ToString
            ElseIf Convert.ToInt32(TempIncome) - Convert.ToInt32(TempExpense) < 0 Then
                BalanceOutput.ForeColor = Color.LightGreen
                BalanceOutput.Text = (Convert.ToInt32(TempIncome) - Convert.ToInt32(TempExpense)).ToString
            End If

            TotalExpenseOutput.Text = TempExpense.ToString
            TotalIncomeOutput.Text = TempIncome.ToString

            TempExpense = 0
            TempIncome = 0

        End If
    End Sub

End Class
