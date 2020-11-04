'Applaction:    game_note_tracker
'Delevpor:      Peter Keres
'date:          April 23 2019
'Purpose:       this form will allow the user to create a new game entry and add it to the database
'               * it will allow the user to enter in data fields about the game entry. Some fields will be manatory or optional
'               * it will allow the usree to save the entry into the data base
'               * it will allow the user to cancle out of making a new entry and go back to the main menu 

Option Strict On



Public Class frmNewEntry

    'class level varables


    'when the "submit" button is clicked
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'check to make user enters in data
        If (txtboxTitle.Text = "") Then
            MsgBox("Please enter a title for the game.", , "ERROR: no title set")
            txtboxTitle.Focus()
        ElseIf (txtboxPublisher.Text = "") Then
            MsgBox("Please enter the publisher for the game", , "ERROR: no publisher set")
            txtboxPublisher.Focus()
        ElseIf (txtboxDeveloper.Text = "") Then
            MsgBox("Please enter the developer for the game", , "ERROR: no developer set")
            txtboxDeveloper.Focus()
        ElseIf (cboxGameState.SelectedIndex < 0) Then
            MsgBox("Please select a game state for the game", , "ERROR: no game state set")
            cboxGameState.Focus()
        ElseIf (txtboxGenre.Text = "") Then
            MsgBox("Please enter a genre for the game", , "ERROR: no genre set")
            txtboxGenre.Focus()
        Else
            'make a new database file
            frmMainMenu.databaseReader.makeNewEntry(txtboxTitle.Text, txtboxPublisher.Text, txtboxDeveloper.Text,
                                                cboxGameState.SelectedItem.ToString, txtboxGenre.Text,
                                                ckboxCoop.Checked.ToString, ckboxEarlyAccess.Checked.ToString)
        End If

        Dim mainform As New frmMainMenu
        mainform.txtUserGameSearch.Text = txtboxTitle.Text

        Me.Close()
        Me.Hide()
        mainform.ShowDialog()

    End Sub


    'when the "cancel" button is clicked
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim mainForm As New frmMainMenu

        Me.Close()
        Me.Hide()
        mainForm.ShowDialog()
    End Sub


    'when the form is loaded 
    Private Sub frmNewEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboxGameState.Items.Add("Beaten")
        cboxGameState.Items.Add("Started")
        cboxGameState.Items.Add("Walked Away")
        cboxGameState.Items.Add("In Progress")
        cboxGameState.Items.Add("continues")
        cboxGameState.Items.Add("waiting")
    End Sub


End Class