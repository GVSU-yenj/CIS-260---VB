Option Strict On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        'make sure to not use strings, but variables equal to the converted strings. Then put them into the scope of the button.
        Dim BillAmt As Decimal = Convert.ToDecimal(BillAmount.Text)
        Dim TipPerc As Double = Convert.ToDouble(TipPercent.Text)
        TipOutput.Text = Tip(BillAmt, TipPerc).ToString("C2")
    End Sub

    Private Sub Procedure_Click(sender As Object, e As EventArgs) Handles ProcedureBtn.Click
        Dim BillAmt As Decimal = Convert.ToDecimal(BillAmount.Text)
        Dim TipPerc As Double = Convert.ToDouble(TipPercent.Text)
        'the following line is an example of your old ways
        'CalculateTip(Convert.ToDecimal(BillAmount.Text), Convert.ToDecimal(TipPercent.Text), TipOutput.Text)
        CalculateTip(BillAmt, TipPerc, TipOutput.Text)
    End Sub

    'the f(x)
    Public Function Tip(BillAmt As Decimal, TipPerc As Double) As Decimal

        Return Convert.ToDecimal(BillAmt * (TipPerc * 0.01))
    End Function

    'the procedure
    Public Sub CalculateTip(ByVal BillAmt As Decimal, ByVal TipPerc As Double, ByRef TipOut As String)

        TipOut = (BillAmt * (TipPerc * 0.01)).ToString("C2")
    End Sub

End Class
