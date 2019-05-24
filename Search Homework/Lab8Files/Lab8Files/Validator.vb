Public Class Validator

    Public Shared Property Title As String = "Data Error"

    Public Shared Function IsPresent(stringEntered As String) _
            As Boolean
        If stringEntered = Nothing Then
            MessageBox.Show("There is a blank within the data - the flawed records will not be displayed.", Title)
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsDecimal(stringEntered As String) _
            As Boolean
        Dim number As Decimal = 0
        If Decimal.TryParse(stringEntered, number) Then
            Return True
        Else
            MessageBox.Show("Improper decimal value found - the flawed records will not be displayed.", Title)
            Return False
        End If
    End Function

    Public Shared Function IsValidPaymentMethod(charEntered As Char) _
            As Boolean
        If charEntered = "C"c Or charEntered = "D"c Or charEntered = "R"c Or charEntered = "K"c Or charEntered = "T"c Then
            Return True
        Else
            MessageBox.Show("There was an invalid payment method in the data - the flawed records will not be displayed.", Title)
            Return False
        End If
    End Function

    Public Shared Function IsValidDateTime(dateEntered As String) _
            As Boolean
        Dim dateTest As DateTime
        If DateTime.TryParse(dateEntered, dateTest) Then
            Return True
        Else
            MessageBox.Show("There is an invalid date in the data - the flawed records will not be displayed.", Title)
            Return False
        End If
    End Function

    Public Shared Function IsWithinRange(textBox As TextBox,
            min As Decimal, max As Decimal) As Boolean
        Dim number As Decimal = CDec(textBox.Text)
        If number < min OrElse number > max Then
            MessageBox.Show(textBox.Tag.ToString & " must be between " &
                min & " and " & max & ".", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

End Class
