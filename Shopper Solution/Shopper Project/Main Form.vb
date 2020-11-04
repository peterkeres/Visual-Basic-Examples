'chapter 5 program page 287 by peter keres 9/29/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm


    Private Sub extBnt_Click(sender As Object, e As EventArgs) Handles extBnt.Click

        Me.Close()

    End Sub


    Private Sub calBnt_Click(sender As Object, e As EventArgs) Handles calBnt.Click

        'declaring variables
        Dim TotMonPur As Double = 0
        Dim RewPoi As Double = 0

        'getting data from user
        Double.TryParse(totmonpurTxtBox.Text, TotMonPur)

        'figuring out reward points/ membership type
        Select Case True
            Case basRdoBnt.Checked
                If TotMonPur > 100 Then
                    RewPoi = TotMonPur * 0.05
                Else
                    RewPoi = TotMonPur * 0.07
                End If
            Case staRdoBnt.Checked
                If TotMonPur < 150 Then
                    RewPoi = TotMonPur * 0.06
                ElseIf TotMonPur >= 150 AndAlso TotMonPur <= 299.99 Then
                    RewPoi = TotMonPur * 0.08
                Else
                    RewPoi = TotMonPur * 0.1
                End If
            Case preRdoBnt.Checked
                If TotMonPur < 200 Then
                    RewPoi = TotMonPur * 0.07
                Else
                    RewPoi = TotMonPur * 0.15
                End If
        End Select

        'displaying to the user/ hope it is ok to round 
        rewpoiLab.Text = RewPoi.ToString("n0")
    End Sub


    Private Sub totmonpurTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles totmonpurTxtBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


End Class
