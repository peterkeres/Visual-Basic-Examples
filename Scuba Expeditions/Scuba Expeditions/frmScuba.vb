'program name:  scuba expeditions application
'aurthor:       peter keres
'date:          3/31/2019
'purpose:       this is the guided program / assigment 7. Starts on page 421 in the visual basic book
'               this covers SPLASH SCREENS, COMBO BOXES, METHODS/PRECDURES, TRY CATCH BLOCKS.


Option Strict On


Public Class frmScuba

    'class level variables
    Private _intFourHour As Integer = 4
    Private _intSixHour As Integer = 6
    Private _intEightHour As Integer = 8
    Private _strDive1 As String = "Great Barrier Reef"
    Private _strDive2 As String = "Tiger Shark"
    Private _strDive3 As String = "Fathom Chasm"
    Private _strDive4 As String = "Great Blue Chasm"
    Private _strDive5 As String = "Rainbow Reff"
    Private _strDive6 As String = "Namena Sunken Ship"


    Private Sub cboLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocation.SelectedIndexChanged
        ' this lets the user enter the locatoin and then calls methods to place the dive types in the list

        Dim intLocationChoice As Integer

        intLocationChoice = cboLocation.SelectedIndex
        lstDive.Items.Clear()

        Select Case intLocationChoice
            Case 0
                AustraliaTeam()
            Case 1
                BelizeTeam()
            Case 2
                FijiTeam()
        End Select

        'making teh GUI items visible
        lblTeam.Visible = True
        txtTeam.Visible = True
        lblSelect.Visible = True
        lstDive.Visible = True
        btnDiveCost.Visible = True
        btnClear.Visible = True
        lblScubaDive.Visible = True
        lblCost.Visible = True
        lblLength.Visible = True
        'clearing out any labels
        lblScubaDive.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        'set focus
        txtTeam.Focus()

    End Sub

    Private Sub AustraliaTeam()
        'this procedure fills in the possible dive types offered in australia
        lstDive.Items.Add(_strDive1)
        lstDive.Items.Add(_strDive2)
        lstDive.Items.Add(_strDive3)
    End Sub

    Private Sub BelizeTeam()
        'this procedure fills in the possible dive types offered in Belize
        lstDive.Items.Add(_strDive4)
        lstDive.Items.Add(_strDive5)
    End Sub

    Private Sub FijiTeam()
        'this procedure fills in the possible dive types offered in Fiji
        lstDive.Items.Add(_strDive2)
        lstDive.Items.Add(_strDive3)
        lstDive.Items.Add(_strDive6)
    End Sub



    Private Sub btnDiveCost_Click(sender As Object, e As EventArgs) Handles btnDiveCost.Click
        ' when the Dive Cost button is clicked, shows size of dive team, the cost, and lenght of the dive

        Dim intTeamSize As Integer
        Dim blnNumberINTeamIsValid As Boolean = False
        Dim blnDiveIsSelected As Boolean = False
        Dim intDiveChoice As Integer
        Dim strSelectedTeam As String = ""
        Dim intlocationChoice As Integer
        Dim intLength As Integer = 0
        Dim decTotalCost As Decimal

        'call functions to see if num of people in dive team is valid
        blnNumberINTeamIsValid = ValidateNumberInTeam()
        'call a function to make sure suba dive was selected
        intDiveChoice = ValidateDiveSelection(blnDiveIsSelected, strSelectedTeam)

        'if both tests are valid 
        If (blnNumberINTeamIsValid And blnDiveIsSelected) Then
            intTeamSize = Convert.ToInt32(txtTeam.Text)
            intlocationChoice = cboLocation.SelectedIndex

            Select Case intlocationChoice
                Case 0
                    decTotalCost = AustraliaDiveCost(intDiveChoice, intTeamSize, intLength)
                Case 1
                    decTotalCost = BelizeDiveCost(intDiveChoice, intTeamSize, intLength)
                Case 2
                    decTotalCost = FijiDiveCost(intDiveChoice, intTeamSize, intLength)
            End Select

            'display the cost of the scuba dive
            lblScubaDive.Text = "Dive: " & strSelectedTeam
            lblCost.Text = "Cost: " & decTotalCost.ToString("C")
            lblLength.Text = "Length: " & intLength.ToString() & " hours"
        End If

    End Sub

    Private Function ValidateNumberINTeam() As Boolean
        'validates the value entered for the dive team size
        Dim intTeamSize As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberInTeamMessage As String = "Please enter the number of people in your dive team (2-6)"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intTeamSize = Convert.ToInt32(txtTeam.Text)
            If intTeamSize >= 2 And intTeamSize <= 6 Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberInTeamMessage, , strMessageBoxTitle)
                txtTeam.Focus()
                txtTeam.Clear()
            End If
        Catch ex As FormatException
            MsgBox(strNumberInTeamMessage, , strMessageBoxTitle)
            txtTeam.Focus()
            txtTeam.Clear()
        Catch ex As OverflowException
            MsgBox(strNumberInTeamMessage, , strMessageBoxTitle)
            txtTeam.Focus()
            txtTeam.Clear()
        Catch ex As SystemException
            MsgBox(strNumberInTeamMessage, , strMessageBoxTitle)
            txtTeam.Focus()
            txtTeam.Clear()
        End Try

        Return blnValidityCheck
    End Function

    Private Function ValidateDiveSelection(ByRef blnDive As Boolean, ByRef strDive As String) As Integer
        'makes sure the user selected a dive type
        Dim intDiveType As Integer

        Try
            intDiveType = Convert.ToInt32(lstDive.SelectedIndex)
            strDive = lstDive.SelectedItem.ToString()
            blnDive = True
        Catch ex As SystemException
            'if a dive type is not selected
            MsgBox("Select a Dive Type", , "Error")
            blnDive = False
        End Try

        Return intDiveType
    End Function

    Private Function AustraliaDiveCost(ByVal intDive As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        'calculates the cost of the dive team in australia
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal
        Dim decAustraliaDive1 As Decimal = 359D
        Dim decAustraliaDive2 As Decimal = 200D
        Dim decAustraliaDive3 As Decimal = 125D

        Select Case intDive
            Case 0
                decTeamCost = decAustraliaDive1
                intTime = _intEightHour
            Case 1
                decTeamCost = decAustraliaDive2
                intTime = _intSixHour
            Case 2
                decTeamCost = decAustraliaDive3
                intTime = _intFourHour
        End Select

        decFinalCost = decTeamCost * intTeam

        Return decFinalCost
    End Function

    Private Function BelizeDiveCost(ByVal intDive As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        'the cost of the dive team in belize
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal
        Dim decBelizeDive4 As Decimal = 200D
        Dim decBelizeDive5 As Decimal = 150D

        Select Case intDive
            Case 0
                decTeamCost = decBelizeDive4
                intTime = _intEightHour
            Case 1
                decTeamCost = decBelizeDive5
                intTime = _intSixHour
        End Select

        decFinalCost = decTeamCost * intTeam

        Return decFinalCost
    End Function

    Private Function FijiDiveCost(ByVal intDive As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        'the cost of the dive team in fiji
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal
        Dim decFijiDive2 As Decimal = 280D
        Dim decFijiDive3 As Decimal = 225D
        Dim decFijiDive6 As Decimal = 200D

        Select Case intDive
            Case 0
                decTeamCost = decFijiDive2
                intTime = _intEightHour
            Case 1
                decTeamCost = decFijiDive3
                intTime = _intSixHour
            Case 2
                decTeamCost = decFijiDive6
                intTime = _intFourHour
        End Select

        decFinalCost = decTeamCost * intTeam

        Return decFinalCost
    End Function



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'when the clrea button is clicked, clears out all fields in the form 
        cboLocation.Text = "Select Location"
        txtTeam.Clear()
        lstDive.Items.Clear()
        lblScubaDive.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        lblTeam.Visible = False
        txtTeam.Visible = False
        lblSelect.Visible = False
        lstDive.Visible = False
        btnDiveCost.Visible = False
        btnClear.Visible = False
        lblScubaDive.Visible = False
        lblCost.Visible = False
        lblLength.Visible = False
    End Sub



    Private Sub frmScuba_Load(sender As Object, e As EventArgs) Handles Me.Load
        'when the form loads, let the splash screen display longer 
        Threading.Thread.Sleep(5000)
    End Sub


End Class
