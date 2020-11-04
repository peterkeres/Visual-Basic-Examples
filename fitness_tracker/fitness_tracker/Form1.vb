'Author     Peter Keres
'date       2/25/2019
'Title      fitness tracker for "project" 1 in CPSC 3118
'
'purpose    This program will take in a users date of birth and current date to find out how many hours
'           of fitness they have done in their life. We are assuming that they average 2.5 hours per week

Option Strict On

Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' this will handle when the exit button is clicked
        ' it will close the program 

        Close()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this button should clear out all the text fields in the main form, and set the focus back to the first name

        txtfldFirstName.Text = ""
        txtfldLastName.Text = ""
        txtfldBirth.Text = ""
        txtfldCurrentDate.Text = ""
        lblFullName.Text = ""
        lblTotalHours.Text = ""

        txtfldFirstName.Focus()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'this will run when the form is loaded for the first time
        ' we set focus to the firt name field

        txtfldFirstName.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' this is main loop of program, it is whenever the valvualte button is clicked
        ' it will take the users name and put it as a full name into the form lable
        ' it will also calcualte how many hours the person has worked out and display that total 

        'declar varl i will need
        Dim strFullName As String
        Dim dtmBrithDate As Date
        Dim dtmCurDate As Date
        Const DLBAVGHOURS As Double = 2.5
        Dim lngDiffDays As Long
        Dim lngDiffYears As Long
        Dim dlbTotalHours As Double

        'getting data from gui and putting into the vars
        strFullName = txtfldFirstName.Text & " " & txtfldLastName.Text

        ' we convert the brith text field into a date field
        'if the user entered in a date that does not fit the format, we show an error message
        ' this also catches dates that are not valid, EX: having a month of 13
        Try
            dtmBrithDate = Convert.ToDateTime(txtfldBirth.Text)
        Catch ex As FormatException
            MsgBox("The date you entered for bith date was not in the format show, it should be in MM/DD/YYYY", , "Birth Date format error")
            txtfldBirth.Text = ""
            txtfldBirth.Focus()
            Exit Sub
        End Try

        ' we convert the current text field into a date field
        'if the user entered in a date that does not fit the format, we show an error message
        ' this also catches dates that are not valid, EX: having a day of 38
        Try
            dtmCurDate = Convert.ToDateTime(txtfldCurrentDate.Text)
        Catch ex As FormatException
            MsgBox("The date you entered for current date was not in the format show, it should be in MM/DD/YYYY", , "Current Date format error")
            txtfldCurrentDate.Text = ""
            txtfldCurrentDate.Focus()
            Exit Sub
        End Try


        ' more user error checking
        If (dtmBrithDate >= dtmCurDate) Then
            'the current date is set before the birth date, this is an error!
            MsgBox("You enterd in the dates so that birth date comes before current date, please fix", , "Date Error")
            txtfldBirth.Focus()

        ElseIf (txtfldFirstName.Text = "") Then
            ' if user does not enter a first name, this is an error
            MsgBox("You did not enter a name in the first name field, please do so", , "First name Error")
            txtfldFirstName.Focus()

        ElseIf (txtfldLastName.Text = "") Then
            'if user does not enter a last name, this is an error 
            MsgBox("You did not enter a name in the last name field, please do so", , "Last name Error")
            txtfldLastName.Focus()
        Else
            'everything seems good, main loop of program 

            'get the number of days
            lngDiffDays = DateDiff(DateInterval.Day, dtmBrithDate, dtmCurDate)
            'get number of years so can do leap year 
            lngDiffYears = DateDiff(DateInterval.Year, dtmBrithDate, dtmCurDate)
            'this should hold the number of days plus a leab year days
            lngDiffDays = lngDiffDays + Convert.ToInt64(lngDiffYears / 4)
            'getting total numbers of days into a week format then * 2.5 for each week
            dlbTotalHours = (lngDiffDays / 7) * DLBAVGHOURS

            'setting up so user can see results
            lblFullName.Visible = True
            lblTotalHours.Visible = True
            lblFullNameHeading.Visible = True
            lblTotalHoursHeading.Visible = True
            lblFullName.Text = strFullName
            lblTotalHours.Text = dlbTotalHours.ToString("n")

            'now user can just hit enter to enter in new data 
            btnClear.Focus()
        End If
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lblTotalHoursHeading_Click(sender As Object, e As EventArgs) Handles lblTotalHoursHeading.Click

    End Sub
End Class


