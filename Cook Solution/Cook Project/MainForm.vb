'Chapter 6 program, page 355, " Cook College"
'BY: peter keres, 10/9/2016

Option Explicit On
Option Infer Off
Option Strict On


Public Class MainForm


    Private Sub entdatBnt_Click(sender As Object, e As EventArgs) Handles entdatBnt.Click
        'delcar variables
        Dim CreHour As String = ""
        Dim CreHourNum As Integer = 0
        Dim LetGra As String = ""
        Dim TotCreHour As Decimal = 0
        Dim GPA As Decimal = 0
        Dim CountNumGra As Integer = 0
        Dim NumGra As Integer = 0
        Dim TotNumGra As Decimal = 0

        'getting credited hours from user
        CreHour = InputBox(" Please enter the credited hours for the class; Enter a # when you are done.", " Credited Hours")

        Do Until CreHour = "#"
            CreHourNum = Convert.ToInt32(CreHour)
            TotCreHour = TotCreHour + CreHourNum

            'second imput box for letter grade 
            LetGra = InputBox(" Please enter in the letter grade for that class.", " Letter Grade")
            Select Case LetGra.ToUpper
                Case "A"
                    NumGra = 4 * CreHourNum
                Case "B"
                    NumGra = 3 * CreHourNum
                Case "C"
                    NumGra = 2 * CreHourNum
                Case "D"
                    NumGra = 1 * CreHourNum
                Case "F"
                    NumGra = 0 * CreHourNum
            End Select

            'caculations
            TotNumGra = NumGra + TotNumGra
            CountNumGra = CountNumGra + 1
            GPA = TotNumGra / TotCreHour

            'To let the user leave the loop
            CreHour = InputBox(" Please enter the credited hours for the class; Enter a # when you are done.", " Credited Hours")
        Loop

        'display to the user
        totcrehouLab.Text = Convert.ToString(TotCreHour)
        gpaLab.Text = GPA.ToString("N2")
        numgraentLab.Text = Convert.ToString(CountNumGra)

    End Sub


    Private Sub extBnt_Click(sender As Object, e As EventArgs) Handles extBnt.Click
        Me.Close()
    End Sub


End Class
