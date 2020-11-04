'Class:         ReadFile
'Developer:     Peter Keres
'Date:          April 19 2019
'Purpose:       This class will Actions related to reading the "moblie.txt" file for the Most Popular Games sold app
'               basied around 2 methods
'               a get Game names method, which will return an array of game names
'               a get Units sold method, which will reutnr an array of the number of games sold



Option Strict On

Public Class ReadFile

    'class level varables
    Private _strFilePath As String
    Private _strGameNames(100) As String
    Private _intUnitSold(100) As Integer
    Private _strFileNotFoundError As String

    Sub New(ByVal filePath As String)
        'constructor for the readfile class
        _strFilePath = filePath
        _strFileNotFoundError = "The file " & filePath & "was not in location, check and try again"

        getData()

    End Sub


    Public Function getGameNames() As String()
        'returns an array of the game names
        Return _strGameNames
    End Function


    Public Function getUnitsSold() As Integer()
        'returns an array of the units sold
        Return _intUnitSold
    End Function


    Private Sub getData()
        'this method will get the data form the file

        Dim fileReader As IO.StreamReader
        Dim fileCount As Integer = 0

        If IO.File.Exists(_strFilePath) Then
            fileReader = IO.File.OpenText(_strFilePath)

            'getting the data out of file and adding to array 
            Do While fileReader.Peek <> -1
                _strGameNames(fileCount) = fileReader.ReadLine()
                _intUnitSold(fileCount) = Convert.ToInt32(fileReader.ReadLine())
                fileCount = fileCount + 1
            Loop

            'trim down the array 
            fileCount = fileCount - 1
            ReDim Preserve _strGameNames(fileCount)
            ReDim Preserve _intUnitSold(fileCount)

        Else
            'error message if file is not found 
            MsgBox(_strFileNotFoundError, , "File Not Found Error")
            Environment.Exit(0)
        End If

    End Sub

End Class
