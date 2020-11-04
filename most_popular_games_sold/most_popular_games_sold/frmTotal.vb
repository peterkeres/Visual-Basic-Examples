'Program:       Most Popular Games Sold
'Developer:     Peter Keres
'Date:          April 19 2019
'Purpose:       This applaction will dispaly the most popular games sold
'               this form is the total window of that applaction, ti will show only total amounts





Public Class frmTotal


    Private Sub FrmTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'whenever the form is loaded 
        DisplayNames()
        DisplayUnitsSold()

        Dim cal As New Calculations

        'display the total amount for all game units sold 
        lblGameTotal.Text = ((cal.computeTotal(frmMain._FileReader.getUnitsSold)).ToString) & " Million"
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'when the back button is clicked
        Dim frmMain As New frmMain

        Hide()
        frmMain.ShowDialog()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when the exit button is clicked
        Environment.Exit(0)
    End Sub


    Private Sub DisplayNames()
        'populats the game name column
        For i As Integer = 0 To frmMain._FileReader.getGameNames.Length - 1
            lstGameName.Items.Add(frmMain._FileReader.getGameNames.GetValue(i))
        Next

    End Sub

    Private Sub DisplayUnitsSold()
        'populates the units sold column
        For i As Integer = 0 To frmMain._FileReader.getUnitsSold.Length - 1
            lstGameDownLoads.Items.Add(frmMain._FileReader.getUnitsSold.GetValue(i).ToString())
        Next
    End Sub


End Class