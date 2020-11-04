'Class:     student
'Develpoer: Peter Keres
'Date       april 22 2019
'purpose:   for a colege student, calculates the semester cost for tuition. 


Option Strict On


Public Class Student

    'class level varables
    Protected _strStudentID As String
    Protected _strStudentName As String
    Protected _strMajor As String
    Protected _intUnits As Integer
    Protected _decCost As Decimal
    Protected _decCostPerUnit As Decimal = 450D

    Dim objStudentCostsFile As StudentCostsFile

    Sub New(ByVal strSTudentID As String, ByVal strStudentName As String, ByVal strMajor As String, ByVal intUnits As String)

        _strStudentID = strSTudentID
        _strStudentName = strStudentName
        _strMajor = strMajor
        _intUnits = Convert.ToInt32(intUnits)
    End Sub


    Overridable Function ComputeCosts() As Decimal


        'cal costs
        _decCost = _intUnits * _decCostPerUnit

        'wirte to studetn record
        objStudentCostsFile = New StudentCostsFile(_strStudentID, _strStudentName, _strMajor, _decCost)
        objStudentCostsFile.WriteRecord()

        Return _decCost
    End Function




End Class
