'Applaction:    game_note_tracker
'Delevpor:      Peter Keres
'date:          April 23 2019
'Purpose:       this is the edit entry form, it is used to let the user edit a field of a game entry 
'               * allow the user to edit a field of a game entry 
'               * allow user to save the edit of the field 
'               * allow user to cancle the edit of the field 


Option Strict On


Public Class frmEditField



    'this is when the close button is clicked
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim viewForm As New frmViewEntry

        Me.Close()
        Me.Hide()
        viewForm.ShowDialog()
    End Sub


    'this is when the save button is clicked
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'figures out what section is currently being viewed, then saves over that file

        Select Case frmMainMenu.selectedField
            Case 1
                Select Case frmMainMenu.selectedFieldSub
                    Case 0
                        frmMainMenu.entry._strStoryEvents = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Story Events")
                    Case 1
                        frmMainMenu.entry._strStoryCharacters = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Story Characters")
                    Case 2
                        frmMainMenu.entry._strStoryWorld = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Story World")
                    Case 3
                        frmMainMenu.entry._strStoryThoughts = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Story Thoughts")
                    Case Else
                        frmMainMenu.entry._strStoryToDoList = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Story To Do List")
                End Select
            Case 2
                Select Case frmMainMenu.selectedFieldSub
                    Case 0
                        frmMainMenu.entry._strGamePlayMechanics = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("GamePlay Mechanics")
                    Case 1
                        frmMainMenu.entry._strGamePlayToDoList = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("GamePlay To Do List")
                    Case 2
                        frmMainMenu.entry._strStoryThoughts = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("GamePlay Thoughts")
                    Case Else
                        frmMainMenu.entry._strGamePlayStrategy = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("GamePlay Strategy")
                End Select
            Case 3
                Select Case frmMainMenu.selectedFieldSub
                    Case 0
                        frmMainMenu.entry._strOnlinePeople = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Online People")
                    Case 1
                        frmMainMenu.entry._strOnlineGuild = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Online Guild")
                    Case 2
                        frmMainMenu.entry._strOnlineEvents = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Online Events")
                    Case 3
                        frmMainMenu.entry._strOnlineToDoList = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Online To Do List")
                    Case Else
                        frmMainMenu.entry._strOnlineThoughts = txtboxFieldText.Text
                        frmMainMenu.databaseReader.saveField("Online Thoughts")
                End Select
            Case Else
                frmMainMenu.entry._strReview = txtboxFieldText.Text
                frmMainMenu.databaseReader.saveField("review")
        End Select


        Dim viewForm As New frmViewEntry

        Me.Close()
        Me.Hide()
        viewForm.ShowDialog()
    End Sub


    'when the form is loaded
    Private Sub frmEditField_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Text = frmMainMenu.entry._strTitle & "'s edit window"

        ' puts the right data in the edit txt field
        Select Case frmMainMenu.selectedField
            Case 0
                Dim generalForm As New frmEditFieldGeneral

                Me.Close()
                generalForm.ShowDialog()
            Case 1
                Select Case frmMainMenu.selectedFieldSub
                    Case 0
                        txtboxFieldText.Text = frmMainMenu.entry._strStoryEvents
                        lblNameField.Text = "Story Events"
                    Case 1
                        txtboxFieldText.Text = frmMainMenu.entry._strStoryCharacters
                        lblNameField.Text = "Story Characters"
                    Case 2
                        txtboxFieldText.Text = frmMainMenu.entry._strStoryWorld
                        lblNameField.Text = "Story World"
                    Case 3
                        txtboxFieldText.Text = frmMainMenu.entry._strStoryThoughts
                        lblNameField.Text = "Story Thoughts"
                    Case Else
                        txtboxFieldText.Text = frmMainMenu.entry._strStoryToDoList
                        lblNameField.Text = "Story To Do List"
                End Select
            Case 2
                Select Case frmMainMenu.selectedFieldSub
                    Case 0
                        txtboxFieldText.Text = frmMainMenu.entry._strGamePlayMechanics
                        lblNameField.Text = "Game Play Mechaincs"
                    Case 1
                        txtboxFieldText.Text = frmMainMenu.entry._strGamePlayToDoList
                        lblNameField.Text = "Game Play To Do List"
                    Case 2
                        txtboxFieldText.Text = frmMainMenu.entry._strGamePlayThoughts
                        lblNameField.Text = "Game Play Thoughts"
                    Case Else
                        txtboxFieldText.Text = frmMainMenu.entry._strGamePlayStrategy
                        lblNameField.Text = "Game Play Strategy"
                End Select
            Case 3
                Select Case frmMainMenu.selectedFieldSub
                    Case 0
                        txtboxFieldText.Text = frmMainMenu.entry._strOnlinePeople
                        lblNameField.Text = "Online People"
                    Case 1
                        txtboxFieldText.Text = frmMainMenu.entry._strOnlineGuild
                        lblNameField.Text = "Online Guild"
                    Case 2
                        txtboxFieldText.Text = frmMainMenu.entry._strOnlineEvents
                        lblNameField.Text = "Online Events"
                    Case 3
                        txtboxFieldText.Text = frmMainMenu.entry._strOnlineToDoList
                        lblNameField.Text = "Online To Do List"
                    Case Else
                        txtboxFieldText.Text = frmMainMenu.entry._strOnlineThoughts
                        lblNameField.Text = "Online Thoughts"
                End Select
            Case Else
                txtboxFieldText.Text = frmMainMenu.entry._strReview
                lblNameField.Text = "Review"
        End Select


    End Sub


End Class