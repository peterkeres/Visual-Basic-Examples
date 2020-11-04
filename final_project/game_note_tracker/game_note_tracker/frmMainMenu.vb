'Applaction:    game_note_tracker
'Delevpor:      Peter Keres
'date:          April 23 2019
'Purpose:       This is the main form that is loaded for the program. It will do the following basic functions
'               * allow the user to search for a game entry
'               * allow user to add a new game entry into the database
'               * allow user to quit the program 
'               * allow the user to pick from a list of prev viewed game entry's


Option Strict On


Public Class frmMainMenu

    'class level varables
    'this will hold the current game the whole program is looking at. making it public so all forms can see it
    Public entry As GameEntry
    'this will interact with the database for us. making it pulbic so every form can see it 
    Public databaseReader As DatabaseReader
    'this holds what item was selected in the view entry form 
    Public selectedField As Integer
    'what sub field is being selected in the view entry form
    Public selectedFieldSub As Integer

    'when the form is loaded 
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databaseReader = New DatabaseReader
        loadRecentEntries(databaseReader.LoadRecentEntry())
        entry = New GameEntry
    End Sub


    'populates the list of recent entries 
    Private Sub loadRecentEntries(ByVal list() As String)
        For currentItem = 0 To list.Length - 1
            lstRecentEntries.Items.Add(list(currentItem))
        Next

        If (list.Length = 0) Then
            lstRecentEntries.SelectionMode = SelectionMode.None
        Else
            lstRecentEntries.SelectionMode = SelectionMode.One
        End If

    End Sub


    'when the "Create new" button is clicked
    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        Dim editForm As New frmNewEntry


        Me.Hide()
        editForm.ShowDialog()
    End Sub


    'when the "search" button is clicked
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub



    'when the "exit" button is clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


    'when the recent entrie is clicked
    Private Sub lstRecentEntries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRecentEntries.SelectedIndexChanged

        Try
            txtUserGameSearch.Text = lstRecentEntries.SelectedItem.ToString
        Catch Ex As System.NullReferenceException

        End Try

    End Sub


    'when the recent entrie is double clicked
    Private Sub lstRecentEntries_DoubleClick(sender As Object, e As EventArgs) Handles lstRecentEntries.DoubleClick
        If (txtUserGameSearch.Text <> "") Then
            txtUserGameSearch.Text = lstRecentEntries.SelectedItem.ToString

            Search()
        End If

    End Sub


    'search's for the current item in the search field
    Private Sub Search()
        'see if item is in database
        If (databaseReader.Check(txtUserGameSearch.Text)) Then
            'set the entry object here to it
            databaseReader.setGameEntry(txtUserGameSearch.Text)
            'update the recent entry file
            databaseReader.updateRecentEntries(txtUserGameSearch.Text)
            'will open the game entry that is searched for
            Dim viewForm As New frmViewEntry


            Me.Hide()
            viewForm.ShowDialog()
        Else
            MsgBox("The name of the game you have entered is not in the database. Please check your spelling or for extra spaces.", , "ERROR: Not in DataBase")
        End If

    End Sub


    'to clear out the defualt text in the search field
    Private Sub txtUserGameSearch_GotFocus(sender As Object, e As EventArgs) Handles txtUserGameSearch.GotFocus
        txtUserGameSearch.Text = ""
    End Sub


End Class
