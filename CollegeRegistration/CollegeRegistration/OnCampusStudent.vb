'Class:     onCampusStudent
'Develpoer: Peter Keres
'Date       april 22 2019
'purpose:   for a colege student, calculates the semester cost for tuition. 


Option Strict On


Public Class OnCampusStudent
    Inherits Student

    'class level varables
    Private _Cooper As Boolean
    Private _Craig As Boolean
    Private _Julian As Boolean

    Dim objStudentCostsFile As StudentCostsFile



    Sub New(ByVal StudentID As String, ByVal StudentName As String, ByVal Major As String, ByVal Units As String, ByVal Cooper As Boolean, ByVal Craig As Boolean, ByVal Julian As Boolean)

        MyBase.New(StudentID, StudentName, Major, Units)

        _Cooper = Cooper
        _Craig = Craig
        _Julian = Julian
    End Sub


    Public Overrides Function ComputeCosts() As Decimal

        Dim HousingCost As Decimal
        Const cdecCooperHousingCost As Decimal = 2900D
        Const cdecCraigHouingCost As Decimal = 3400D
        Const cdecJulianHousingCost As Decimal = 4000D


        If _Cooper Then
            HousingCost = cdecCooperHousingCost
        ElseIf _Craig Then
            HousingCost = cdecCraigHouingCost
        ElseIf _Julian Then
            HousingCost = cdecJulianHousingCost
        End If


        _decCost = (_intUnits * _decCostPerUnit) + HousingCost


        objStudentCostsFile = New StudentCostsFile(_strStudentID, _strStudentName, _strMajor, _decCost)
        objStudentCostsFile.WriteRecord()

        Return _decCost
    End Function





End Class
