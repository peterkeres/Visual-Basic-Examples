'program name:  decking cost calculator app
'author:        peter keres
'date:          feb 22
'purpose:       this is for the guided programing assigment 4 on page 277

'does not do type conversation automatically 
Option Strict On


Public Class frmDecking

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' this click even should caclualte the total amount of $ for the deck

        'NOTES-- decimal is not the same as floating point number! decimal will keep its dec position/the dec point will not move
        '           where a floating point, its dec point could move when doing math
        '           the 'D' is needed to make the number a decimal. if not, the compiler thinks its a float/double
        'declar var
        Dim decFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decLumberCost As Decimal = 2.35D
        Dim decRedwoodCost As Decimal = 7.75D
        Dim decCompositeCost As Decimal = 8.5D

        'NOTES-- if statments in vb read semi english like, format is 'if' then contional then 'then'. also each if needs to have an 
        '               'end if' statment to "close off" that if statment 
        '               isNumeric is a function that returns T/F if the statment has all numbers in it
        'check user input if it is a number
        If IsNumeric(txtFootage.Text) Then
            'NOTES-- we can use convter.To'somthing' to take a string value and change it to a numator type of 'something'
            decFootage = Convert.ToDecimal(txtFootage.Text)

            'see if higher then 0
            If decFootage > 0 Then

                'NOTES-- here we are checking if the check field of a radio button is set to true by the user
                'seeing which radio button is checkd
                If radLumber.Checked Then
                    decCostPerSquareFoot = decLumberCost
                ElseIf radRedwood.Checked Then
                    decCostPerSquareFoot = decRedwoodCost
                ElseIf radComposite.Checked Then
                    decCostPerSquareFoot = decCompositeCost
                End If

                'showing the cost to the user in the cost lable
                decCostEstimate = decFootage * decCostPerSquareFoot
                'NOTES-- the ToString method of any varable will turn it into a string. We can use a paramater if we want the string value
                ' in any type of format. here "c" is for currency format
                lblCostEstimate.Text = decCostEstimate.ToString("c")

                'show an error message if the footage is not grater then 0
            Else
                'NOTES-- msgBox method, will show a popup message to the user
                '           the first param is the message within the box
                '           the third param is the title of the message box
                MsgBox("you entered" & decFootage.ToString() & ". enter a positive number", , "Input Error")
                txtFootage.Text = ""
                'NOTES-- focus, will make this item the "selected" element in the gui
                txtFootage.Focus()
            End If

            ' if user enters something that is not a number
        Else
            MsgBox("Enter the square footage of the decking", , "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' when the clear button is clicked, it should clear out the form and reset back to a normal state

        'NOTES-- the clear will clear out a txtbox frield from user input
        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radLumber.Checked = True
        radRedwood.Checked = False
        radComposite.Checked = False
        txtFootage.Focus()

    End Sub

    Private Sub frmDecking_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' this code will run when the form is loaded for the first time

        txtFootage.Focus()
        lblCostEstimate.Text = ""
    End Sub
End Class

