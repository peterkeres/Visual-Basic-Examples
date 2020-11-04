'Project JM Sales Chapter 9 page 515
'BY: peter keres Date: 10/30/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm
    'set up array/ bariable 
    Dim SalesId(4) As Double
    Dim SaleTot As Double

    Private Sub extBnt_Click(sender As Object, e As EventArgs) Handles extBnt.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'setting up the sales ID list box
        salesidLitBox.Items.Add("101")
        salesidLitBox.Items.Add("112")
        salesidLitBox.Items.Add("203")
        salesidLitBox.Items.Add("301")
        salesidLitBox.Items.Add("302")
        salesidLitBox.SelectedIndex = 0
    End Sub

    Private Sub addtotBnt_Click(sender As Object, e As EventArgs) Handles addtotBnt.Click
        'declaring variable
        Dim SalesIn As Double

        'getting input from user
        Double.TryParse(salesentTxtBox.Text, SalesIn)

        'putting the data into array 
        SalesId(salesidLitBox.SelectedIndex) += SalesIn
        SaleTot += SalesIn

    End Sub

    Private Sub cretrepotBnt_Click(sender As Object, e As EventArgs) Handles cretrepotBnt.Click
        'showing each Id to the user 
        For i As Integer = 0 To 4
            saletotTxtBox.Text += Convert.ToString(salesidLitBox.Items(i)) + "    " + SalesId(i).ToString("c2") + ControlChars.NewLine
        Next i
        saletotTxtBox.Text += ControlChars.NewLine + ControlChars.NewLine + "total:    " + SaleTot.ToString("c2")
    End Sub

    Private Sub salesentTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salesentTxtBox.KeyPress
        'making sure they only enter numbers
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
