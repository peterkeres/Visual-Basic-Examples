'Chapter 8 project " wallpaper warehouse" on page 465
'By peter keres date: 10/23/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub calBnt_Click(sender As Object, e As EventArgs) Handles calBnt.Click
        'variables
        Dim Leth As Double = 0
        Dim High As Double = 0
        Dim Wih As Double = 0
        Dim VolmBox As Double = 0


        'converting from user
        Double.TryParse(lethTxtBox.Text, Leth)
        Double.TryParse(highTxtBox.Text, High)
        Double.TryParse(withTxtBox.Text, Wih)

        'getting the volume of the box and displaying it 
        VolmBox = Leth * High * Wih
        totsquftLab.Text = Convert.ToString(VolmBox)

        'getting the total number of boxes from the function and displaying it to user
        totrolLab.Text = Howmanysheetsinbox(Leth, High, Wih)

    End Sub

    Private Function Howmanysheetsinbox(ByVal Lenth As Double, ByVal Hight As Double, ByVal wth As Double) As String
        'variables
        Dim lenthtot As Double = 0
        Dim hightot As Double = 0
        Dim wihtot As Double = 0
        Dim volmbox As String

        'figuring out how many fit in the volume
        lenthtot = Lenth / 1
        hightot = Hight / 1
        wihtot = wth / 1

        volmbox = Convert.ToString(lenthtot * hightot * wihtot)
        Return volmbox

    End Function

    Private Sub extBnt_Click(sender As Object, e As EventArgs) Handles extBnt.Click
        Me.Close()
    End Sub

    Private Sub onlythatnumishit(sender As Object, e As KeyPressEventArgs) Handles highTxtBox.KeyPress, lethTxtBox.KeyPress, withTxtBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then

            e.Handled = True
        End If

    End Sub

End Class
