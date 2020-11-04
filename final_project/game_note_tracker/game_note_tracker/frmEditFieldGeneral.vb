'Applaction:    game_note_tracker
'Delevpor:      Peter Keres
'date:          April 23 2019
'Purpose:       this is the edit entry form for the general items, it is used to let the user edit a field of a game entry 
'               * allow the user to edit any general items of a game entry 
'               * allow user to save the edit of the general items 
'               * allow user to cancle the edit of the general items 


Option Strict On





Public Class frmEditFieldGeneral

    'when the form is loaded
    Private Sub frmEditFieldGeneral_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Text = frmMainMenu.entry._strTitle & "'s edit window"


        'filling the game state box
        cboxGameState.Items.Add("Beaten")
        cboxGameState.Items.Add("Started")
        cboxGameState.Items.Add("Walked Away")
        cboxGameState.Items.Add("In Progress")
        cboxGameState.Items.Add("continues")
        cboxGameState.Items.Add("waiting")

        'adding the values from the file/game entry object
        txtboxPublisher.Text = frmMainMenu.entry._strPublisher
        txtboxDeveloper.Text = frmMainMenu.entry._strDeveloper
        txtboxReleaseDate.Text = frmMainMenu.entry._strReleaseDate
        ckboxEarlyAccess.Checked = Convert.ToBoolean(frmMainMenu.entry._boolEarlyAccess)
        txtboxGenre.Text = frmMainMenu.entry._strGenre
        ckboxCoop.Checked = Convert.ToBoolean(frmMainMenu.entry._boolCoop)
        txtboxDateStart.Text = frmMainMenu.entry._strDateStarted
        txtboxDateLast.Text = frmMainMenu.entry._strDateLastPlayed
        txtboxHourCount.Text = frmMainMenu.entry._intHourCount
        cboxGameState.Text = frmMainMenu.entry._strState

    End Sub


    'when the user hits save button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'updates the game entry item
        frmMainMenu.entry._strPublisher = txtboxPublisher.Text
        frmMainMenu.entry._strDeveloper = txtboxDeveloper.Text
        frmMainMenu.entry._strReleaseDate = txtboxReleaseDate.Text
        frmMainMenu.entry._boolEarlyAccess = ckboxEarlyAccess.Checked.ToString
        frmMainMenu.entry._strGenre = txtboxGenre.Text
        frmMainMenu.entry._boolCoop = ckboxCoop.Checked.ToString
        frmMainMenu.entry._strDateStarted = txtboxDateStart.Text
        frmMainMenu.entry._strDateLastPlayed = txtboxDateLast.Text
        frmMainMenu.entry._intHourCount = txtboxHourCount.Text
        frmMainMenu.entry._strState = cboxGameState.SelectedItem.ToString

        'saves changes to the file
        frmMainMenu.databaseReader.saveField("General")


        Dim viewForm As New frmViewEntry

        Me.Close()
        Me.Hide()
        viewForm.ShowDialog()
    End Sub


    'when the cancel button is clicked
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim viewForm As New frmViewEntry

        Me.Close()
        Me.Hide()
        viewForm.ShowDialog()
    End Sub


End Class