'Applaction:    game_note_tracker
'Delevpor:      Peter Keres
'date:          April 23 2019
'Purpose:       this form allows the user to view a game entry and its fields. it will do the following
'               * allow the user view any field in the game entry
'               * allow user to open up the edit screen for a field
'               * allow user to cancle and go back to main menu



Option Strict On


Public Class frmViewEntry



    ' when the form is loaded
    Private Sub frmViewEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = frmMainMenu.entry._strTitle

        'will take each field from the current game entry object and place it in the form

        'general
        txtTitle.Text = frmMainMenu.entry._strTitle
        txtPublisher.Text = frmMainMenu.entry._strPublisher
        txtdevelpor.Text = frmMainMenu.entry._strDeveloper
        txtReleaseDate.Text = frmMainMenu.entry._strReleaseDate
        txtEarlyAccess.Text = frmMainMenu.entry._boolEarlyAccess
        txtGenra.Text = frmMainMenu.entry._strGenre
        txtCoop.Text = frmMainMenu.entry._boolCoop
        txtDateStarted.Text = frmMainMenu.entry._strDateStarted
        txtDateLastPlayed.Text = frmMainMenu.entry._strDateLastPlayed
        txtHourCount.Text = frmMainMenu.entry._intHourCount
        txtState.Text = frmMainMenu.entry._strState

        'story
        txtStoryEvents.Text = frmMainMenu.entry._strStoryEvents
        txtStoryCharacters.Text = frmMainMenu.entry._strStoryCharacters
        txtStoryWorld.Text = frmMainMenu.entry._strStoryWorld
        txtStoryThoughts.Text = frmMainMenu.entry._strStoryThoughts
        txtStoryToDoList.Text = frmMainMenu.entry._strStoryToDoList

        'gameplay
        txtGamePlayMechanics.Text = frmMainMenu.entry._strGamePlayMechanics
        txtGamePlayToDoList.Text = frmMainMenu.entry._strGamePlayToDoList
        txtGamePlayThoughts.Text = frmMainMenu.entry._strGamePlayThoughts
        txtGamePlayToDoList.Text = frmMainMenu.entry._strGamePlayToDoList

        'online
        txtOnlinePeople.Text = frmMainMenu.entry._strOnlinePeople
        txtOnlineGuild.Text = frmMainMenu.entry._strOnlineGuild
        txtOnlineEvents.Text = frmMainMenu.entry._strOnlineEvents
        txtOnlineToDoList.Text = frmMainMenu.entry._strOnlineToDoList
        txtOnlineThoughts.Text = frmMainMenu.entry._strOnlineThoughts

        'review
        txtReview.Text = frmMainMenu.entry._strReview

        frmMainMenu.selectedField = 0
        frmMainMenu.selectedFieldSub = 0
    End Sub


    'when the edit button is clicked
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'will see what tab is selected and set the correct selected tab field's

        frmMainMenu.selectedField = TabControl.SelectedIndex

        Select Case TabControl.SelectedIndex
            Case 0
                frmMainMenu.selectedFieldSub = 0
            Case 1
                frmMainMenu.selectedFieldSub = tabControllStory.SelectedIndex
            Case 2
                frmMainMenu.selectedFieldSub = tabControllGamePlay.SelectedIndex
            Case 3
                frmMainMenu.selectedFieldSub = tabControllerOnline.SelectedIndex
            Case Else
                frmMainMenu.selectedFieldSub = 0
        End Select

        Dim editMenu As New frmEditField

        Me.Close()
        Me.Hide()
        editMenu.ShowDialog()
    End Sub


    'when the close button is clicked
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim mainMenu As New frmMainMenu

        Me.Close()
        Me.Hide()
        mainMenu.ShowDialog()
    End Sub


End Class