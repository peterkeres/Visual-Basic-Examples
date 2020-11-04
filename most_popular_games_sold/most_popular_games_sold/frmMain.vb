'Program:       Most Popular Games Sold
'Developer:     Peter Keres
'Date:          April 19 2019
'Purpose:       This applaction will dispaly the most popular games sold
'               this form is the main menu of that applaction




Public Class frmMain
    'class level varables
    Public _FileReader As ReadFile

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'when the form is loaded 
        _FileReader = New ReadFile("..\files\mobile.txt")

        'populate the games name list
        For i As Integer = 0 To _FileReader.getGameNames().Length - 1
            lstGameName.Items.Add((_FileReader.getGameNames).GetValue(i))
        Next


    End Sub

    Private Sub LstGameName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGameName.SelectedIndexChanged
        'whenever a new item is selected from the game name list
        lblNumberGamesSold.Text = (_FileReader.getUnitsSold.GetValue(lstGameName.SelectedIndex)).ToString
        lblNumberGamesSold.Visible = True
        lblMillion.Visible = True
        lblGamesSold.Visible = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when the exit button is clicked
        Environment.Exit(0)
    End Sub

    Private Sub BtnTotalDownLoads_Click(sender As Object, e As EventArgs) Handles btnTotalDownLoads.Click
        'when the button to see the total amount is clicked
        Dim frmTotal As New frmTotal

        Hide()
        frmTotal.ShowDialog()
    End Sub


End Class
