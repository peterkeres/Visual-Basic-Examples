'Class:         database Reader
'Delevpor:      Peter Keres
'date:          April 23 2019
'Purpose:       this class will be used to read from the database. it will do the following actions
'               * get the Recent entrys list from the database 
'               * save a game entry to the database 
'               * find an game entry from the database 
'               * check for game in database 
'               * update the recent entry file


Option Strict On



Public Class DatabaseReader

    'class level varables
    Dim recentEntryFile As String = "..\files\recent_entry.txt"
    Dim recentEntrySize As Integer = 10
    Dim gameEntryPath As String = "..\files\game_entrys\"
    Dim fullGamePath As String
    Dim objReader As IO.StreamReader
    Dim objCreate As IO.FileStream
    Dim objWriter As IO.StreamWriter



    'creates the directory to hold database
    Sub New()
        My.Computer.FileSystem.CreateDirectory("..\files\game_entrys")
    End Sub


    ' this will get a game from the data base and return it as an object
    ' NOTE: assumes the game is in the database, no error checking here 
    Public Sub setGameEntry(ByVal game As String)
        fullGamePath = gameEntryPath & game & "\" & game & "_"

        setGeneral(fullGamePath)
        setStroy(fullGamePath)
        setGamePlay(fullGamePath)
        setOnline(fullGamePath)
        setReview(fullGamePath)


    End Sub




    ' checks to see if the game is in the database
    Public Function Check(ByVal game As String) As Boolean
        Dim inDataBase As Boolean = False
        Dim gameFilePath As String = gameEntryPath & game & "\" & game & "_general.txt"

        If (IO.File.Exists(gameFilePath)) Then
            inDataBase = True
        End If

        Return inDataBase
    End Function


    'updating the recent entiry text file with new search
    Public Sub updateRecentEntries(ByVal game As String)
        Dim oldList() As String = LoadRecentEntry()
        Dim newList() As String

        'gets size of new list based on size of old list
        If (oldList.Length > recentEntrySize) Then
            ReDim newList(oldList.Length + 1)
        Else
            ReDim newList(oldList.Length)
        End If

        'moves items from old list to new list in que fasion
        For current = 0 To oldList.Length - 1
            If (current = recentEntrySize) Then

            Else
                newList(current + 1) = oldList(current)
            End If
        Next

        'adding the new entry to front/top of list
        newList(0) = game

        ' open and fill the list
        objWriter = New IO.StreamWriter(recentEntryFile)

        For currentGame = 0 To newList.Length - 1
            objWriter.WriteLine(newList(currentGame))
        Next

        objWriter.Close()

    End Sub


    'this loads the recent entry file and return its contents
    Public Function LoadRecentEntry() As String()
        Dim list(recentEntrySize) As String
        Dim current As Integer = 0


        If (IO.File.Exists(recentEntryFile)) Then
            'file there, open and fill the list
            objReader = IO.File.OpenText(recentEntryFile)

            'gets items from recent list
            Do While objReader.Peek <> -1 And current <= recentEntrySize
                list(current) = objReader.ReadLine
                current = current + 1
            Loop

            'resizing the list
            If (current < 1) Then
                list(0) = ""
                ReDim Preserve list(0)
            Else
                ReDim Preserve list(current - 1)
            End If

            objReader.Close()
        Else
            'make a recent entry file 
            objCreate = IO.File.Create(recentEntryFile)

            list(0) = ""
            ReDim Preserve list(0)
            objCreate.Close()
        End If


        'return that string array 
        Return list
    End Function


    'this sets all the general fields in the entry varable from the general text file
    Private Sub setGeneral(ByVal gamePath As String)
        objReader = IO.File.OpenText(gamePath & "general.txt")

        'title
        frmMainMenu.entry._strTitle = objReader.ReadLine
        'publisher
        frmMainMenu.entry._strPublisher = objReader.ReadLine
        'developer
        frmMainMenu.entry._strDeveloper = objReader.ReadLine
        'releasedate
        frmMainMenu.entry._strReleaseDate = objReader.ReadLine
        'earlyaccess
        frmMainMenu.entry._boolEarlyAccess = objReader.ReadLine
        'genre
        frmMainMenu.entry._strGenre = objReader.ReadLine
        'coop
        frmMainMenu.entry._boolCoop = objReader.ReadLine
        'datestarted
        frmMainMenu.entry._strDateStarted = objReader.ReadLine
        'dataelastplayed
        frmMainMenu.entry._strDateLastPlayed = objReader.ReadLine
        'hourcount
        frmMainMenu.entry._intHourCount = objReader.ReadLine
        'state
        frmMainMenu.entry._strState = objReader.ReadLine

        objReader.Close()

    End Sub


    'this sets all the story fields in the entry varable from the story text file
    Private Sub setStroy(ByVal gamePath As String)

        'story events
        objReader = IO.File.OpenText(gamePath & "story_events.txt")
        frmMainMenu.entry._strStoryEvents = objReader.ReadToEnd
        objReader.Close()

        'this gets the story characters
        objReader = IO.File.OpenText(gamePath & "story_characters.txt")
        frmMainMenu.entry._strStoryCharacters = objReader.ReadToEnd
        objReader.Close()


        'story world
        objReader = IO.File.OpenText(gamePath & "story_world.txt")
        frmMainMenu.entry._strStoryWorld = objReader.ReadToEnd
        objReader.Close()

        'story thoughts
        objReader = IO.File.OpenText(gamePath & "story_thoughts.txt")
        frmMainMenu.entry._strStoryThoughts = objReader.ReadToEnd
        objReader.Close()

        'story to do list
        objReader = IO.File.OpenText(gamePath & "story_todolist.txt")
        frmMainMenu.entry._strStoryToDoList = objReader.ReadToEnd
        objReader.Close()

    End Sub


    'this sets all the gameplay fields in the entry varable from the gaemplay text file
    Private Sub setGamePlay(ByVal gamePath As String)

        'gameplay mechanics
        objReader = IO.File.OpenText(gamePath & "gameplay_mechanics.txt")
        frmMainMenu.entry._strGamePlayMechanics = objReader.ReadToEnd
        objReader.Close()

        'gameplay todo list
        objReader = IO.File.OpenText(gamePath & "gameplay_todolist.txt")
        frmMainMenu.entry._strGamePlayToDoList = objReader.ReadToEnd
        objReader.Close()


        'gameplay thoughts
        objReader = IO.File.OpenText(gamePath & "gameplay_thoughts.txt")
        frmMainMenu.entry._strGamePlayThoughts = objReader.ReadToEnd
        objReader.Close()

        'gameplay strategy
        objReader = IO.File.OpenText(gamePath & "gameplay_strategy.txt")
        frmMainMenu.entry._strGamePlayStrategy = objReader.ReadToEnd
        objReader.Close()

    End Sub


    'this sets all the online  fields in the entry varable from the online text file
    Private Sub setOnline(ByVal gamePath As String)

        'online people
        objReader = IO.File.OpenText(gamePath & "online_people.txt")
        frmMainMenu.entry._strOnlinePeople = objReader.ReadToEnd
        objReader.Close()

        'online guild
        objReader = IO.File.OpenText(gamePath & "online_guild.txt")
        frmMainMenu.entry._strOnlineGuild = objReader.ReadToEnd
        objReader.Close()


        'online events
        objReader = IO.File.OpenText(gamePath & "online_events.txt")
        frmMainMenu.entry._strOnlineEvents = objReader.ReadToEnd
        objReader.Close()

        'online todo list
        objReader = IO.File.OpenText(gamePath & "online_todolist.txt")
        frmMainMenu.entry._strOnlineToDoList = objReader.ReadToEnd
        objReader.Close()

        'online thoughts
        objReader = IO.File.OpenText(gamePath & "online_thoughts.txt")
        frmMainMenu.entry._strOnlineThoughts = objReader.ReadToEnd
        objReader.Close()

    End Sub

    'sets the reivew field of the entry varable from the reveiw text file
    Private Sub setReview(ByVal gamePath As String)

        'review
        objReader = IO.File.OpenText(gamePath & "review.txt")
        frmMainMenu.entry._strReview = objReader.ReadToEnd
        objReader.Close()

    End Sub


    'this saves over a text file based on what is sent
    Public Sub saveField(ByVal field As String)

        Select Case field
            Case "General"
                objWriter = New IO.StreamWriter(fullGamePath & "general.txt")
                objWriter.WriteLine(frmMainMenu.entry._strTitle)
                objWriter.WriteLine(frmMainMenu.entry._strPublisher)
                objWriter.WriteLine(frmMainMenu.entry._strDeveloper)
                objWriter.WriteLine(frmMainMenu.entry._strReleaseDate)
                objWriter.WriteLine(frmMainMenu.entry._boolEarlyAccess)
                objWriter.WriteLine(frmMainMenu.entry._strGenre)
                objWriter.WriteLine(frmMainMenu.entry._boolCoop)
                objWriter.WriteLine(frmMainMenu.entry._strDateStarted)
                objWriter.WriteLine(frmMainMenu.entry._strDateLastPlayed)
                objWriter.WriteLine(frmMainMenu.entry._intHourCount)
                objWriter.WriteLine(frmMainMenu.entry._strState)
                objWriter.Close()
            Case "Story Events"
                objWriter = New IO.StreamWriter(fullGamePath & "story_events.txt")
                objWriter.Write(frmMainMenu.entry._strStoryEvents)
                objWriter.Close()
            Case "Story Characters"
                objWriter = New IO.StreamWriter(fullGamePath & "story_characters.txt")
                objWriter.Write(frmMainMenu.entry._strStoryCharacters)
                objWriter.Close()
            Case "Story World"
                objWriter = New IO.StreamWriter(fullGamePath & "story_world.txt")
                objWriter.Write(frmMainMenu.entry._strStoryWorld)
                objWriter.Close()
            Case "Story Thoughts"
                objWriter = New IO.StreamWriter(fullGamePath & "story_thoughts.txt")
                objWriter.Write(frmMainMenu.entry._strStoryThoughts)
                objWriter.Close()
            Case "Story To Do List"
                objWriter = New IO.StreamWriter(fullGamePath & "story_todolist.txt")
                objWriter.Write(frmMainMenu.entry._strStoryToDoList)
                objWriter.Close()
            Case "GamePlay Mechanics"
                objWriter = New IO.StreamWriter(fullGamePath & "gameplay_mechanics.txt")
                objWriter.Write(frmMainMenu.entry._strGamePlayMechanics)
                objWriter.Close()
            Case "GamePlay To Do List"
                objWriter = New IO.StreamWriter(fullGamePath & "gameplay_todolist.txt")
                objWriter.Write(frmMainMenu.entry._strGamePlayToDoList)
                objWriter.Close()
            Case "GamePlay Thoughts"
                objWriter = New IO.StreamWriter(fullGamePath & "gameplay_thoughts.txt")
                objWriter.Write(frmMainMenu.entry._strGamePlayThoughts)
                objWriter.Close()
            Case "GamePlay Strategy"
                objWriter = New IO.StreamWriter(fullGamePath & "gameplay_strategy.txt")
                objWriter.Write(frmMainMenu.entry._strGamePlayStrategy)
                objWriter.Close()
            Case "Online People"
                objWriter = New IO.StreamWriter(fullGamePath & "online_people.txt")
                objWriter.Write(frmMainMenu.entry._strOnlinePeople)
                objWriter.Close()
            Case "Online Guild"
                objWriter = New IO.StreamWriter(fullGamePath & "online_guild.txt")
                objWriter.Write(frmMainMenu.entry._strOnlineGuild)
                objWriter.Close()
            Case "Online Events"
                objWriter = New IO.StreamWriter(fullGamePath & "online_events.txt")
                objWriter.Write(frmMainMenu.entry._strOnlineEvents)
                objWriter.Close()
            Case "Online To Do List"
                objWriter = New IO.StreamWriter(fullGamePath & "online_todolist.txt")
                objWriter.Write(frmMainMenu.entry._strOnlineToDoList)
                objWriter.Close()
            Case "Online Thoughts"
                objWriter = New IO.StreamWriter(fullGamePath & "online_thoughts.txt")
                objWriter.Write(frmMainMenu.entry._strOnlineThoughts)
                objWriter.Close()
            Case Else
                objWriter = New IO.StreamWriter(fullGamePath & "review.txt")
                objWriter.Write(frmMainMenu.entry._strReview)
                objWriter.Close()
        End Select


    End Sub


    'this makes a enw entry in the database based on user input
    Public Sub makeNewEntry(ByVal title As String, ByVal publisher As String, ByVal developer As String,
                            ByVal gamestate As String, ByVal genre As String,
                            ByVal coop As String, ByVal earlyaccess As String)


        My.Computer.FileSystem.CreateDirectory(gameEntryPath & title)

        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_general.txt")
        objCreate.Close()

        objWriter = New IO.StreamWriter(gameEntryPath & title & "\" & title & "_general.txt")

        objWriter.WriteLine(title)
        objWriter.WriteLine(publisher)
        objWriter.WriteLine(developer)
        objWriter.WriteLine("na")
        objWriter.WriteLine(earlyaccess)
        objWriter.WriteLine(genre)
        objWriter.WriteLine(coop)
        objWriter.WriteLine("na")
        objWriter.WriteLine("na")
        objWriter.WriteLine("0")
        objWriter.WriteLine(gamestate)
        objWriter.Close()

        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_story_events.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_story_characters.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_story_world.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_story_thoughts.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_story_todolist.txt")
        objCreate.Close()

        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_gameplay_mechanics.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_gameplay_todolist.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_gameplay_thoughts.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_gameplay_strategy.txt")
        objCreate.Close()

        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_online_guild.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_online_people.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_online_events.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_online_todolist.txt")
        objCreate.Close()
        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_online_thoughts.txt")
        objCreate.Close()


        objCreate = IO.File.Create(gameEntryPath & title & "\" & title & "_review.txt")
        objCreate.Close()




    End Sub


End Class
