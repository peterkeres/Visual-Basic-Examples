'project "happy temps" chapter 7 page 403
'by: peter keres 10/16/2016
'PS i felt like i did option 2 really sloppy with puttin the first day out side the loop. Is there another way to do this ? just let me know thanks !


Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm
   
    Dim Opt1Tot As Integer = 0
    Dim Opt2Tot As Integer = 0
    Dim Opt1Day As Integer = 0
    Dim Opt2Day As Integer = 0
    Dim Opt2DayPay As Integer = 0

    Private Sub compoptBnt_Click(sender As Object, e As EventArgs) Handles compoptBnt.Click

        'math for option 1/displaying to user
        For Opt1DayCnt As Integer = 1 To 10 Step 1
            Opt1Day = 100
            opt1LitBox.Items.Add("Day: " & Opt1DayCnt.ToString & "     Payed:  $" & Opt1Day.ToString & ControlChars.NewLine)
            Opt1Tot += Opt1Day
        Next

        'displaying total for  option 1
        opt1totLab.Text = Opt1Tot.ToString("c0")


        'starting the first day 
        opt2LitBox.Items.Add("Day: 1     Payed:   $1" & ControlChars.NewLine)
        Opt2DayPay = 1

        'math for option 2/ displaying to user
        For Opt2DayCnt As Integer = 2 To 10 Step 1
            Opt2Day = Opt2DayPay * 2
            opt2LitBox.Items.Add("Day : " & Opt2DayCnt.ToString & "     Payed:  $" & Opt2Day.ToString & ControlChars.NewLine)
            Opt2Tot += Opt2Day
            Opt2DayPay = Opt2Day
        Next

        'adding the 1 that was not in the loop 
        Opt2Tot += 1

        'displaying total for option 2 
        opt2totLab.Text = Opt2Tot.ToString("c0")

    End Sub

    Private Sub extBnt_Click(sender As Object, e As EventArgs) Handles extBnt.Click
        Me.Close()

    End Sub
End Class
