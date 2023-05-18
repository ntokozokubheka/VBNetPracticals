Option Explicit On
Option Strict On
Option Infer Off
Public Class Form1
    Private Sum As Integer
    Private Count As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sum = 0
        Count = 2
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        For Count = 2 To 8 Step 2
            Sum = Sum + Count
        Next Count
        txtSum.Text = CStr(Sum)
    End Sub
End Class
