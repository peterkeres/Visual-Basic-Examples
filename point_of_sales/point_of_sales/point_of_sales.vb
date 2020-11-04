'Author     Peter Keres
'date       3/11/2019
'Title      Point of sales for "project 2" in CPSC 3118
'
'purpose    This program will take in a user definded amount of money and will return the smallest amount of bills
'           needed to reach that definded amount of money. EX: if user enters in 60$, will return a 50$ and a 10$

Option Strict On

Public Class point_of_sales


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this is run when the user clicks on the clear button
        'this should clear up all values in the text feild and the list box

        clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' this is run when ever the user clicks the exit button
        'this should close the program 

        Close()
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'this code runs when the calculate button is clicked, this is the main loop of the program 

        calculate()
    End Sub


    Private Sub tolstrExit_Click(sender As Object, e As EventArgs) Handles tolstrExit.Click
        'this is run when the drop down exit option is clicked
        Close()
    End Sub


    Private Sub tolstrClear_Click(sender As Object, e As EventArgs) Handles tolstrClear.Click
        'this is run when the drop down clear option is clicked
        clear()
    End Sub


    Private Sub tolstrCalculate_Click(sender As Object, e As EventArgs) Handles tolstrCalculate.Click
        'this is run when the drop down calculate option is clicked
        calculate()
    End Sub


    Private Sub clear()
        'clears out all fields in the app and sets focus
        txtboxChange.Text = ""
        lstboxOutput.Items.Clear()
        txtboxChange.Focus()
    End Sub


    Private Sub calculate()
        'this should take in the user data, see if its a number, then add to the list box the right amount of 
        ' change for the user data given

        'clearing out any items that might be in the list box
        lstboxOutput.Items.Clear()
        'set up the const for values for change
        '5,000 / 1,000 / 500 / 100 / 50 / 20 / 10 / 5 / 1 / .50 / .25 / .10 / .05 / .01
        '           could set up in 2 arrays, one for the values, and one for the count
        Dim arrdecValues() As Decimal = {5000D, 1000D, 500D, 100D, 50D, 20D, 10D, 5D, 1D, 0.5D, 0.25D, 0.1D, 0.05D, 0.01D}
        Dim arrintCounts() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

        Dim intTotalBill As Integer = 0
        Dim intTotalCoin As Integer = 0
        Dim decTotalTotal As Decimal = 0D

        'take in user input
        Dim strUserInput As String = txtboxChange.Text

        'check is number is greater then 2 dec
        'check to see if the string has a '.' , then see how many chars are after that point in the string 
        If (strUserInput.Contains(".")) Then
            Dim intIndexDec As Integer = strUserInput.IndexOf(".")
            Dim intNumOfDec As Integer = strUserInput.Substring(intIndexDec + 1).Length
            If (intNumOfDec > 2) Then
                MsgBox("You have too many digits after the decimal point, please check your input: " & strUserInput,, "decimal point error")
                txtboxChange.Text = ""
                Exit Sub
            End If
        End If


        'if the data is not a number, we thorw up an error and exit this method
        If (Not IsNumeric(strUserInput)) Then
            MsgBox("the data you entered was not a number: " & strUserInput,, "non-number error")
            txtboxChange.Text = ""
            Exit Sub
        End If

        Dim decUserInput As Decimal = Convert.ToDecimal(strUserInput)


        'do a loop to find the higest value that the input will go into
        '   subtrac the value from the input
        '   add to a counter for the value used
        '   do unitll value is 0
        For index = 0 To arrdecValues.GetUpperBound(0)

            While ((decUserInput / arrdecValues(index)) >= 1)
                decUserInput = decUserInput - arrdecValues(index)
                arrintCounts(index) = arrintCounts(index) + 1
            End While

        Next

        'headings
        lstboxOutput.Items.Add("DENOMINATION / AMOUNT / TOTAL AMOUNT")
        lstboxOutput.Items.Add("")
        'display values and the count in the list box
        ' only add if the count is > 0
        ' also gets a grand total and a total for bill and coin count 
        'NOTE: this looks like butt becuase the columns are not aligned up right :(
        For index = 0 To arrdecValues.GetUpperBound(0)

            If (arrintCounts(index) > 0) Then
                lstboxOutput.Items.Add(arrdecValues(index).ToString("C") &
                                       "                  " & arrintCounts(index) &
                                       "                  " & (arrdecValues(index) * arrintCounts(index)).ToString("C"))
                decTotalTotal += arrdecValues(index) * arrintCounts(index)

                If (arrdecValues(index) >= 1D) Then
                    intTotalBill += arrintCounts(index)
                Else
                    intTotalCoin += arrintCounts(index)
                End If

            End If

        Next


        lstboxOutput.Items.Add("")
        'display a total coin/ bill count
        lstboxOutput.Items.Add("total coin count:  " & intTotalCoin)
        'display a grand totoal
        lstboxOutput.Items.Add("total amount return:  " & decTotalTotal.ToString("C"))

        'resetting for next input
        txtboxChange.Text = ""
        txtboxChange.Focus()

    End Sub

    Private Sub point_of_sales_Load(sender As Object, e As EventArgs) Handles Me.Load
        'this code is run when the foarm loads for the first time 
        txtboxChange.Focus()

    End Sub


End Class
