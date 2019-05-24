Option Strict On
'Jonathan Yen
'Lab 8 Files
'3/19/2019
Public Class Payment

    Public Property DatePaid As DateTime
    Public Property Payee As String
    Public Property Amount As Decimal
    Public Property PaymentMethod As Char
    Dim PayTypeList As New SortedList(Of Char, String)

    Public Sub New()

    End Sub

    Public Sub New(DatePaid As DateTime, Payee As String, Amount As Decimal, PaymentMethod As Char)
        Me.DatePaid = DatePaid
        Me.Payee = Payee
        Me.Amount = Amount
        Me.PaymentMethod = PaymentMethod
    End Sub

    Public Function DisplayRecord() As String
        PayTypeList.Add(Convert.ToChar("C"), "Cash")
        PayTypeList.Add(Convert.ToChar("D"), "Debit")
        PayTypeList.Add(Convert.ToChar("R"), "Credit")
        PayTypeList.Add(Convert.ToChar("K"), "Check")
        PayTypeList.Add(Convert.ToChar("T"), "Transfer")
        'to short date will get rid of what time it took place. It will then only display the date.
        Return DatePaid.ToShortDateString.PadRight(10) & "".PadLeft(5) & Payee.PadRight(15) & Amount.ToString("c2").PadLeft(10) & "".PadLeft(8) &
            PayTypeList.Item(PaymentMethod).ToString.PadRight(13)
    End Function

    Public Function IsValidData(dateEntered As String, payeeEntered As String, amountEntered As String, paymentMethod As Char) As Boolean
        'add more isPresents for each column()
        If Validator.IsPresent(dateEntered) AndAlso Validator.IsPresent(payeeEntered) AndAlso Validator.IsPresent(amountEntered) AndAlso Validator.IsPresent(paymentMethod) AndAlso
 Validator.IsValidDateTime(dateEntered) AndAlso Validator.IsDecimal(amountEntered) AndAlso Validator.IsValidPaymentMethod(paymentMethod) Then
            Return True
        Else Return False

        End If
    End Function

End Class
