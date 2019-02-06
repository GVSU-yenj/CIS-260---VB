Option Strict On

Public Class Form1

    Dim YearOneSales As Decimal = 11500000
    Dim YearOneProfits As Decimal = 1127000
    Dim TotalSales As Decimal = 0
    Dim TotalProfit As Decimal = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartBtn.Click

        ReportOutput.Items.Add("Sales and Profit Projection".PadLeft(37))
        Dim Subheader As String = "Year".PadRight(10) & "Expected Sales".PadRight(10) & "Projected Profit".PadLeft(21)
        ReportOutput.Items.Add(Subheader)

        Dim Year As Integer = 0
        Dim TempSales As Decimal = YearOneSales
        Dim TempProfit As Decimal = YearOneProfits
        For Year = 1 To 10
            ReportOutput.Items.Add(Year.ToString().PadLeft(3) & TempSales.ToString("C0").PadLeft(20) & TempProfit.ToString("C0").PadLeft(20))
            TempSales = CInt(TempSales * 0.963)
            TotalSales = TotalSales + TempSales
            TempProfit = CInt(TempSales * 0.098)
            TotalProfit = TotalProfit + TempProfit
        Next
        ReportOutput.Items.Add("Totals:".PadRight(12) & TotalSales.ToString("C0").PadLeft(5) & TotalProfit.ToString("C0").PadLeft(20))
        TotalSales = 0
        TotalProfit = 0

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReportOutput.SelectedIndexChanged

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ReportOutput.Items.Clear()
    End Sub

End Class
