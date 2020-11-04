'Class:     Studnet Cost File
'Develpoer: Peter Keres
'Date       april 22 2019
'purpose:   for a colege student, calculates the semester cost for tuition. 


Option Strict On


Public Class StudentCostsFile

    'class varables
    Private _strStudentID As String
    Private _strStudentName As String
    Private _strMajor As String
    Private _decStudentCosts As Decimal



    Sub New(ByVal StudentID As String, ByVal StudentName As String, ByVal Major As String, ByVal Costs As Decimal)

        _strStudentID = StudentID
        _strStudentName = StudentName
        _strMajor = Major
        _decStudentCosts = Costs

    End Sub


    Sub WriteRecord()

        Dim strNameandLocationOffFile As String = "..\StudentCosts.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameandLocationOffFile)

            objWriter.Write(_strStudentID & ",")
            objWriter.Write(_strStudentName & ",")
            objWriter.Write(_strMajor & ",")
            objWriter.WriteLine(_decStudentCosts)
            objWriter.Close()

        Catch ex As Exception
            MsgBox("no device availbe- program aborted", , "Error")
            Application.Exit()

        End Try

    End Sub



End Class
