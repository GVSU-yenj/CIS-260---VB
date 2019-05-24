Option Strict On
Imports System.IO
'Jonathan Yen
'Lab 8 Files
'3/19/2019
Public Class Form1
    'for testing use:
    'Dim path As String = "FakePayments.txt"
    Dim path As String = "Payments.txt"
    Dim textIn As New StreamReader(New FileStream(path, FileMode.Open, FileAccess.Read))
    Dim totalAmount As Decimal
    Dim PaymentList As New List(Of Payment)
    Dim PayTypeList As New SortedList(Of Char, String)
    Dim intPayTypeList As New SortedList(Of Int32, String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEntrySearch.Enabled = False
        btnListSearch.Enabled = False
        PayTypeList.Add(Convert.ToChar("C"), "Cash")
        PayTypeList.Add(Convert.ToChar("D"), "Debit")
        PayTypeList.Add(Convert.ToChar("R"), "Credit")
        PayTypeList.Add(Convert.ToChar("K"), "Check")
        PayTypeList.Add(Convert.ToChar("T"), "Transfer")
        intPayTypeList.Add(0, "Cash")
        intPayTypeList.Add(1, "Debit")
        intPayTypeList.Add(2, "Credit")
        intPayTypeList.Add(3, "Check")
        intPayTypeList.Add(4, "Transfer")
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        btnEntrySearch.Enabled = True
        btnListSearch.Enabled = True
        lstPayments.Items.Add("Jon's Loan Sharks, Inc. - Accounts Paid".PadLeft(30))
        lstPayments.Items.Add("")
        lstPayments.Items.Add("Date Paid" & "Payee".PadLeft(15) & "Amount".PadLeft(15) & "Payment Method".PadLeft(20))

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim tempTotalAmount As Decimal
            Dim columns() As String = row.Split(CChar("|"))
            Dim PaymentRecord As New Payment
            If PaymentRecord.IsValidData(columns(0), columns(1), columns(2), Convert.ToChar(columns(3))) Then
                PaymentRecord.DatePaid = Convert.ToDateTime(columns(0))
                PaymentRecord.Payee = columns(1)
                PaymentRecord.Amount = Convert.ToDecimal(columns(2))
                totalAmount += PaymentRecord.Amount
                PaymentRecord.PaymentMethod = Convert.ToChar(columns(3))
                PaymentList.Add(PaymentRecord)
            End If
        Loop

        For Each paymentRecord In PaymentList
            lstPayments.Items.Add(paymentRecord.DisplayRecord)
        Next

        lstPayments.Items.Add("")
        lstPayments.Items.Add("total" & totalAmount.ToString("c2").PadLeft(35))
        textIn.Close()

        'now to code the seperate payees into the listbox.
        lstPaymentTypes.Items.Add("Cash")
        lstPaymentTypes.Items.Add("Debit")
        lstPaymentTypes.Items.Add("Credit")
        lstPaymentTypes.Items.Add("Check")
        lstPaymentTypes.Items.Add("Transfer")

    End Sub

    'Manual entry for the search criteria
    Private Sub btnEntrySearch_Click(sender As Object, e As EventArgs) Handles btnEntrySearch.Click
        btnView.Enabled = False
        Dim entry As String = InputBox("Enter the desired Payee to display only")
        Dim output As String = ""
        Dim tempTotal As Decimal

        Dim Found =
           From Payments In PaymentList
           Order By Payments.Amount
           Select Payments.Amount, Payments.DatePaid, Payments.Payee, Payments.PaymentMethod

        For Each match In Found
            If entry = match.Payee Then
                output += match.DatePaid.ToShortDateString.PadRight(15) & "".PadLeft(5) & entry.PadRight(15) & match.Amount.ToString("c2").PadLeft(10) & "".PadLeft(8) &
            PayTypeList(match.PaymentMethod).PadRight(13) & ControlChars.CrLf
                tempTotal += match.Amount
            End If
        Next

        MessageBox.Show(output & ControlChars.CrLf & entry & " total ".PadRight(10) & tempTotal.ToString("C2"), "Payees Found", Nothing, MessageBoxIcon.Information)
        tempTotal = 0

    End Sub

    'Chosen entry for the search criteria from a list of Payment Methods.
    Private Sub btnListSearch_Click(sender As Object, e As EventArgs) Handles btnListSearch.Click
        'uses a differnt sortedList here [of (int, string)]
        Dim paymentForm As String = intPayTypeList(lstPaymentTypes.SelectedIndex)
        Dim output As String = ""
        Dim tempTotal As Decimal

        Dim Found =
           From Payments In PaymentList
           Order By Payments.PaymentMethod Descending
           Select Payments.Amount, Payments.DatePaid, Payments.Payee, Payments.PaymentMethod

        For Each match In Found
            If paymentForm = PayTypeList(match.PaymentMethod) Then
                output += match.DatePaid.ToShortDateString.PadRight(15) & "".PadLeft(5) & match.Payee.PadRight(15) & match.Amount.ToString("c2").PadLeft(10) & "".PadLeft(8) &
            PayTypeList(match.PaymentMethod).PadRight(13) & ControlChars.CrLf
                tempTotal += match.Amount
            End If
        Next

        MessageBox.Show(output & ControlChars.CrLf & paymentForm & " total ".PadRight(10) & tempTotal.ToString("C2"), paymentForm, Nothing, MessageBoxIcon.Information)
        tempTotal = 0

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstPayments.Items.Clear()
        btnExit.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class

'this was the old way of the ListBox search.
'If lstPaymentTypes.SelectedIndex = 0 Then
'    paymentForm = "Cash"
'ElseIf lstPaymentTypes.SelectedIndex = 1 Then
'    paymentForm = "Debit"
'ElseIf lstPaymentTypes.SelectedIndex = 2 Then
'    paymentForm = "Credit"
'ElseIf lstPaymentTypes.SelectedIndex = 3 Then
'    paymentForm = "Check"
'ElseIf lstPaymentTypes.SelectedIndex = 4 Then
'    paymentForm = "Transfer"
'End If