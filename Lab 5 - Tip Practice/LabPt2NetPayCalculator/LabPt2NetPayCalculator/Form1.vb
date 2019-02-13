'jon yen
' payroll homework
' 2/12/2019
Public Class Form1
    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        Dim PayRate As Decimal = Convert.ToDecimal(txtPayRate.Text)
        Dim Hours As Double = Convert.ToDouble(txtHours.Text)
        Dim YTDPay As Decimal = Convert.ToDecimal(txtYTDPay.Text)
        Dim GrossPayAmt As Decimal
        Dim StateTaxAmt As Decimal
        Dim SocialSecurityTaxAmt As Decimal
        Dim MedicareTaxAmt As Decimal
        Dim NetPayAmt As Decimal

        GrossPayAmt = TtlGrossPay(PayRate, Hours)
        txtGrossPay.Text = GrossPayAmt.ToString("C2")

        StateTaxAmt = StateTax(GrossPayAmt)
        txtStateTax.Text = StateTaxAmt.ToString("C2")

        SocialSecurityTaxAmt = SocialSecurityTax(YTDPay, GrossPayAmt)
        txtSocialSecurity.Text = SocialSecurityTaxAmt.ToString("C2")

        MedicareTaxAmt = MedicareTax(GrossPayAmt)
        txtMedicare.Text = MedicareTaxAmt.ToString("C2")

        NetPayAmt = NetPay(GrossPayAmt, StateTaxAmt, SocialSecurityTaxAmt, MedicareTaxAmt)
        txtNetPay.Text = NetPayAmt.ToString("c2")

    End Sub

    Public Function TtlGrossPay(Rate As Double, Hours As Double) As Decimal
        If Hours <= 40 Then
            Return Rate * Hours
        Else
            Return (Rate * 40) + ((Rate * 1.5) * (Hours - 40))
        End If
    End Function

    Public Function StateTax(GrossPay As Decimal) As Decimal
        Return GrossPay * 0.0425
    End Function

    Public Function SocialSecurityTax(YTDPay As Decimal, GrossPay As Decimal) As Decimal
        If YTDPay + GrossPay > 118500 Then
            If YTDPay <= 118500 Then
                Return (118500 - YTDPay) * 0.062
            End If
        ElseIf YTDPay + GrossPay <= 118500 Then
            Return GrossPay * 0.062
        Else
            Return 0
        End If
    End Function

    Public Function MedicareTax(GrossPay As Decimal) As Decimal
        Return GrossPay * 0.0145
    End Function

    Public Function NetPay(GrossPayAmt As Decimal, StateTaxAmt As Decimal, SocialSecurityTaxAmt As Decimal, MedicareTaxAmt As Decimal) As Decimal
        Return GrossPayAmt - (StateTaxAmt + SocialSecurityTaxAmt + MedicareTaxAmt)
    End Function

End Class
