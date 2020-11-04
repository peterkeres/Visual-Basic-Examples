'project Holterback Finance on page 560 chapter 10
'By peter keres Date: 11/6/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DisplayNewPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayNewPasswordToolStripMenuItem.Click
        'declar password lenth
        Dim OriPassLen As Integer

        OriPassLen = oripassTxtBox.Text.Length

        'testing to make sure password fits lenth and letters
        If OriPassLen < 5 Or OriPassLen > 7 Then
            Call popuperrorlen()
        ElseIf oripassTxtBox.Text.ToLower Like "*[!a-z,0-9]*" Then
            Call popuperrortxt()
        Else
            Call passwordok()
        End If

    End Sub

    Private Sub popuperrorlen()
        'error to user if password is too long or too short
        MessageBox.Show(" please enter a pass word that is only 5 to 7 characters in lenth.", " Error lenth", MessageBoxButtons.OK, MessageBoxIcon.Error)
        oripassTxtBox.Clear()
    End Sub

    Private Sub popuperrortxt()
        'error to user if password has any speical characters
        MessageBox.Show(" Please only enter numbers and letters. Not any special characters or spaces.", "Error Text", MessageBoxButtons.OK, MessageBoxIcon.Error)
        oripassTxtBox.Clear()
    End Sub

    Private Sub passwordok()
        'if everything checks out ok run this
        Dim OriPassOk As String = Nothing
        Dim OriPassLen As Integer = 0
        Dim LetCheck As String = Nothing
        Dim Count As Integer = 0
        Dim NewPass As String = Nothing
        Dim NewPassRe As String = Nothing

        OriPassOk = oripassTxtBox.Text.ToLower
        OriPassLen = oripassTxtBox.Text.Length

        'setting up loop to check each letter to change 
        For i As Integer = 0 To OriPassLen - 1
            LetCheck = OriPassOk.Substring(i, 1)
            Select Case LetCheck
                Case "a", "e", "i", "o", "u"
                    If Count = 0 Then
                        NewPass += "1"
                        Count += 1
                    ElseIf Count = 1 Then
                        NewPass += "2"
                        Count += 1
                    Else
                        NewPass += "9"
                        Count += 1
                    End If
                Case "0", "1", "2", "3", "4", "5"
                    NewPass += "z"
                Case "6", "7", "8", "9"
                    NewPass += "*"
                Case Else
                    NewPass += LetCheck
            End Select
        Next i

        'revercing the order of the password
        For i As Integer = OriPassLen - 1 To 0 Step -1
            NewPassRe += NewPass.Substring(i, 1)
        Next

        'displaying the new password to user 
        newpassLab.Text = NewPassRe

    End Sub
End Class
