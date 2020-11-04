'program:   MIDTERM EXAM
'by:        peter keres
'date:      3/15/2019

Option Strict On

Public Class frmMain

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'this code will run when the cal button is clicked, main loop of program

        'get input
        Dim strUserInput As String = txtboxUserInput.Text

        'valadate input
        'if not a number
        If (Not IsNumeric(strUserInput)) Then
            MsgBox("the data you entered is not a number: " & strUserInput, , "non-number error")
            txtboxUserInput.Text = ""
            txtboxUserInput.Focus()
            Exit Sub
        End If

        'convet to a dec number
        Dim decUserInput As Double = Convert.ToDouble(strUserInput)
        Dim decReturnvalue As Double

        'have if for 2 formalus
        If (rbtnCelsius.Checked) Then
            'check number for greater then -237
            If (Not decUserInput >= -237D) Then
                MsgBox("Please enter a number grater then -237 C", , "Not greater then -237C error")
                txtboxUserInput.Text = ""
                txtboxUserInput.Focus()
                Exit Sub
            End If
            'to get fah
            decReturnvalue = ((9 / 5) * decUserInput) + 32
            lblOutput.Text = decReturnvalue.ToString("N") & "F"
            lblOutput.Show()

        ElseIf (rbtnFahrenheit.Checked) Then
            'check if number for grater then -459.4F
            If (Not decUserInput >= -459.4D) Then
                MsgBox("Please enter a number grater then -459.4 F", , "Not greater then -459.4F error")
                txtboxUserInput.Text = ""
                txtboxUserInput.Focus()
                Exit Sub
            End If
            'to get cel
            decReturnvalue = (32 - decUserInput) * (5 / 9)
            lblOutput.Text = decReturnvalue.ToString("N") & "F"
            lblOutput.Show()

        Else
            'if no button was chekced, error 
            MsgBox("No convtert option was picked, please select one", , "no button selected error")

        End If


    End Sub


End Class
