'Program Name:  Fitness Challenge
'Author:        Peter Keres
'Date:          feb,2,2018
'Purpose:       This program is for assigment 5. which follws the guided program development on page 355
'               This assigment seems to mostly cover the idea of loops/ list gui element/ input box/ menu strips/ publish apps?


Option Strict On

Public Class frmFitness


    Private Sub btnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        'this code will run when the 'enter weight loss' button is clicked
        'will show 8 values in the list box, then get the avg of the 8 values

        'declaring vars
        Dim strWeightLoss As String = ""
        Dim decWeightLoss As Decimal = 0D
        Dim decAverageLoss As Decimal = 0D
        Dim decTotalWeightLoss As Decimal = 0D
        Dim strInputMessage As String = "Enter the weight loss for team member #"
        Dim strInputHeading As String = "Weight Loss"
        Dim strNormalMesage As String = "Enter the weight loss for team member #"
        Dim strNonNumericError As String = "Error - Enter a number for the weight loss of team member #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss of team member #"

        'declaring vars for loop
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        'gets the first value from the user for the list
        'format goes 'message on the box' 'title of the box' 'defalut in input box'
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        'do unitll loop - keep doing untill a true statment happens
        Do Until intNumberOfEntries > intMaxNumberOfEntries OrElse strWeightLoss = strCancelClicked

            'see if user data is a number, then convert it 
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)

                ' if numb is bigger then 0, add to the list
                If decWeightLoss > 0 Then
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss = decTotalWeightLoss + decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMesage
                Else
                    strInputMessage = strNegativeError
                End If

                ' if data cant be a number
            Else
                strInputMessage = strNonNumericError
            End If

            'gets another number if not at our max
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'will only display the lables if there is an item in the list
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average weight loss is " & decAverageLoss.ToString("F1") & " lbs"
        Else
            MsgBox("No weight loss value entered")
        End If

        btnWeightLoss.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'this code is run when the user clicks the clear button in the menu list
        ' should clear out all values in the form

        lstWeightLoss.Items.Clear()
        lblAverageLoss.Visible = False
        btnWeightLoss.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'this code is run when the user clicks the exit button in the menu list
        ' should close the app

        Close()
    End Sub


End Class


