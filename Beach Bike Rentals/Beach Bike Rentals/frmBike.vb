'   Program:    Beach bike Rentals
'   Author:     Peter Keres
'   Date:       feb 16 2019
'   Purpose:    This is for assigment number 3, which is over the pages 201-211 in the text book
'               covers how to do simple math with variables, putting a result into a text field
'               adding buttons,pictures,and lables


'this option, tuns off the "auto convert" data types feature off.
Option Strict On

Public Class frmBike

    'global varables
    'const means its a constant and can not change its value, the _ is a shorthand for 'global varable'
    ' the D at the end, turns the number from a double into a decimal
    ' a decimal in vb, is pretty much a floating point number where the decamil can not move!
    Const _CDECPRICEPERDAY As Decimal = 9.95D



    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' this will find the cost of the bike rental and display it too the screen

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        'this line takes whatever value the user enters into the text fild of this text box and stores it
        strNumberOfDays = txtNumberOfDays.Text
        'this line will take a varable and convert it into a integer, so we can do math with it
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        'this line gets the total cost, by doing simple math
        decTotalCost = intNumberOfDays * _CDECPRICEPERDAY
        'this line will set the text field of the lable to whatever is in the total cost varable. 
        'it converts it too a string And formats it to be a currency ( this Is why we send the to string a "c")
        lblTotalCost.Text = decTotalCost.ToString("C")

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this will clear out all the fields in our applaction. by ether clearing the fild or setting its text to a ""

        ' clear will clear out any txt field
        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        ' focus, will make it so that this object as the currecnt focus or where the curser is set to be at
        txtNumberOfDays.Focus()

    End Sub



    Private Sub frmBike_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' the load event, is what happens whever this form is loaded
        ' this will set up some of the default values for the form to display

        'the & is a way to concatnate 2 or more strings together into a single string. 
        lblCostHeading.Text = _CDECPRICEPERDAY.ToString("C") & " per Day"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' this will close out the applaction

        Close()

    End Sub



End Class
