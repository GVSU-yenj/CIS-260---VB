'Author: Jon ¥
'Assignment: Lab Uno - Weather
'Date: 1/15/2019
Option Strict On

Public Class Form1
    Dim WindSpeed As Integer
    Dim Temperature As Integer
    Dim windChill As Integer
    Dim outputMessage As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        Temperature = Convert.ToInt32(TemperatureInput.Text)
        WindSpeed = Convert.ToInt32(WindSpeedInput.Text)
        windChill = CInt(35.74 + 0.6215 * Temperature - 35.75 * WindSpeed ^ 0.16 + 0.4275 * Temperature * WindSpeed ^ 0.16)
        outputMessage = "With a wind speed of " & WindSpeed & "°F and a temperature of " & Temperature & "°F" & ControlChars.NewLine & "wind chill will be " & windChill & "°F"
        ActualTempOutput.Text = outputMessage

        ClearBtn.Select()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        TemperatureInput.Clear()
        WindSpeedInput.Clear()
        ActualTempOutput.Clear()
        TemperatureInput.Select()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class
