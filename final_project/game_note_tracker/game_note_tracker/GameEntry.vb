'Class:         Game Entry 
'Delevpor:      Peter Keres
'date:          April 23 2019
'Purpose:       this class will hold a game entry from a text file. 
'               this will take all the data from the file reader object and make it nice and orginzed
'               NOTE: this is really just a container 

Option Strict On



Public Class GameEntry

    'Class level varables
    'game detials
    Public _strTitle As String
    Public _strPublisher As String
    Public _strDeveloper As String
    Public _strReleaseDate As String
    Public _boolEarlyAccess As String
    Public _strGenre As String
    Public _boolCoop As String
    Public _strDateStarted As String
    Public _strDateLastPlayed As String
    Public _intHourCount As String
    Public _strState As String
    'game notes
    'story
    Public _strStoryEvents As String
    Public _strStoryCharacters As String
    Public _strStoryWorld As String
    Public _strStoryThoughts As String
    Public _strStoryToDoList As String
    'gameplay
    Public _strGamePlayMechanics As String
    Public _strGamePlayToDoList As String
    Public _strGamePlayThoughts As String
    Public _strGamePlayStrategy As String
    'online
    Public _strOnlinePeople As String
    Public _strOnlineGuild As String
    Public _strOnlineEvents As String
    Public _strOnlineToDoList As String
    Public _strOnlineThoughts As String
    'review
    Public _strReview As String


    Sub New()

    End Sub



End Class
