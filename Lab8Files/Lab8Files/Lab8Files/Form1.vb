Imports System.IO
'Jonathan Yen
'Lab 8 Files
'3/19/2019
Public Class Form1
    Dim path As String = "payments.txt"
    Dim textIn As New StreamReader(New FileStream(path, FileMode.Open, FileAccess.Read))
    Dim totalAmount As Decimal

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        lstPayments.Items.Add("Jon's Loan Sharks, Inc. - Accounts Paid".PadLeft(30))
        lstPayments.Items.Add("")
        lstPayments.Items.Add("Date Paid" & "Payee".PadLeft(15) & "Amount".PadLeft(15) & "Payment Method".PadLeft(20))

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim tempTotalAmount As Decimal
            Dim columns() As String = row.Split(CChar("|"))
            Dim PaymentRecord As New Payment
            PaymentRecord.DatePaid = columns(0)
            PaymentRecord.Payee = columns(1)
            PaymentRecord.Amount = columns(2)
            totalAmount += PaymentRecord.Amount
            PaymentRecord.PaymentMethod = Convert.ToChar(columns(3))
            lstPayments.Items.Add(PaymentRecord.DisplayRecord)
        Loop
        lstPayments.Items.Add("")
        lstPayments.Items.Add("total" & totalAmount.ToString("c2").PadLeft(35))
        textIn.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstPayments.Items.Clear()
        btnExit.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
