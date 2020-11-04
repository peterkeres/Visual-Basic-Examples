'Chapter 4 program page 239
'By : peter keres
'date : 9/21/2016

Option Explicit On
Option Infer Off
Option Strict On


Public Class MainForm

    'delcaring variable
    Dim SubTot As Double = 0.0
    Dim TotDue As Double = 0.0
    Dim ItePri As Double = 0.0
    Dim SubTotTax As Double = 0.0

    Private Sub bntCalTot_Click(sender As Object, e As EventArgs) Handles bntCalTot.Click


        'delcaring variable
        Static SalTax As Double = 0.03
        Dim ShiPri As Double = 15.0

        'converting / accumulator
        Double.TryParse(txtboxItmPri.Text, ItePri)
        SubTot = SubTot + ItePri


        'free shipping
        If SubTot >= 100 Then
            ShiPri = 0.0
        End If

        SubTotTax = SalTax * SubTot
        TotDue = SubTotTax + SubTot + ShiPri

        'Show to user / converting
        labSubTot.Text = SubTot.ToString("c2")
        labSalTax.Text = SubTotTax.ToString("c2")
        labShi.Text = ShiPri.ToString("c2")
        labTotDue.Text = TotDue.ToString("c2")

        'clearing text
        txtboxItmPri.Text = " "

    End Sub

    Private Sub bntExt_Click(sender As Object, e As EventArgs) Handles bntExt.Click
        Me.Close()

    End Sub
End Class
