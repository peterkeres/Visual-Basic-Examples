'Class:         Calculations
'Developer:     Peter Keres
'Date:          April 19 2019
'Purpose:       this class will do any caclulations that is needed by the Most popular Games sold project
'               Even though, this will only really hold one method. 


Option Strict On



Public Class Calculations


    Sub New()
        'constructor for the calculations class

    End Sub


    Function computeTotal(ByVal list() As Integer) As Integer
        'will calculate a total from a list of integers and return that total
        Dim total As Integer

        For i As Integer = 0 To list.Length - 1
            total = total + list(i)
        Next

        Return total
    End Function


End Class