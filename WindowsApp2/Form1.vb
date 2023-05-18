Option Explicit On
Option Strict On
Option Infer Off
Public Class Form1
    Private NumberWeeks As Integer
    Private Money As Integer
    Private AverageMoney As Double
    Private TotalMoney As Integer
    Private Count As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalMoney = 0
        Count = 0
    End Sub

    Private Sub btnNumberweeks_Click(sender As Object, e As EventArgs) Handles btnNumberweeks.Click
        NumberWeeks = CInt(txtNumberWeeks.Text)
    End Sub

    Private Sub btnMoney_Click(sender As Object, e As EventArgs) Handles btnMoney.Click
        While Count < NumberWeeks


            Money = CInt(txtMoney.Text)
            TotalMoney = TotalMoney + Money
            Count = Count + 1
        End While
    End Sub

    Private Sub btnAverageMoney_Click(sender As Object, e As EventArgs) Handles btnAverageMoney.Click
        AverageMoney = TotalMoney / NumberWeeks
        txtAverageMoney.Text = CStr(AverageMoney)
        While AverageMoney < 5000
            txtSuccess.Text = CStr("Consider shutting event")
        End While
        While AverageMoney >= 5000
            txtSuccess.Text = CStr(" The event requires some attention")
        End While
        While AverageMoney >= 10000
            txtSuccess.Text = CStr("Continue with event")
        End While

    End Sub

    Private Sub btnSuccess_Click(sender As Object, e As EventArgs)

    End Sub
End Class
