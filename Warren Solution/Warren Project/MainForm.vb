'program from chapter 11 "warren high school" page 614
'BY: peter keres Date: 11/13/2016

Option Explicit On
Option Infer Off
Option Strict On


Public Class MainForm
    'declaring vairables
    Dim StoneVot As Integer = 0
    Dim PatelVot As Integer = 0
    Dim PerezVot As Integer = 0

    Private Sub extBnt_Click(sender As Object, e As EventArgs) Handles extBnt.Click
        Me.Close()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'making sure user wants to close 
        Dim Answer As DialogResult
        Answer = MessageBox.Show(" Do you want to exit ?", "Exit Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If Answer = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim InFile As IO.StreamReader

        'loading the candidate name into the list box
        candateLitBox.Items.Add("Mark Stone")
        candateLitBox.Items.Add("Sheima Patel")
        candateLitBox.Items.Add("Sam Perez")
        candateLitBox.SelectedIndex = 0

        'loading the voting.txt file
        If IO.File.Exists("voting.txt") = True Then
            InFile = IO.File.OpenText("voting.txt")
            Dim CandateInVot As Integer = 0
            Dim CandateInSel As Integer = 0

            Do Until InFile.Peek = -1
                Integer.TryParse(InFile.ReadLine, CandateInVot)
                Select Case CandateInSel
                    Case Is = 0
                        StoneVot += CandateInVot
                        CandateInSel += 1
                    Case Is = 1
                        PatelVot += CandateInVot
                        CandateInSel += 1
                    Case Is = 2
                        PerezVot += CandateInVot
                        CandateInSel += 1
                End Select
            Loop

            'closing the file
            InFile.Close()
        End If

    End Sub

    Private Sub savoteBnt_Click(sender As Object, e As EventArgs) Handles savoteBnt.Click
        'delcaring vairables
        Dim SelCandate As Integer = 0
        Dim OutFile As IO.StreamWriter

        'adding in each vote to total  
        Select Case candateLitBox.SelectedIndex
            Case Is = 0
                StoneVot += 1
            Case Is = 1
                PatelVot += 1
            Case Is = 2
                PerezVot += 1
        End Select

        'saving each vote to a file 
        OutFile = IO.File.CreateText("voting.txt")

        'writing totals to the voting.txt file
        OutFile.WriteLine(StoneVot)
        OutFile.WriteLine(PatelVot)
        OutFile.WriteLine(PerezVot)

        'closing the file
        OutFile.Close()

    End Sub

    Private Sub disvoteBnt_Click(sender As Object, e As EventArgs) Handles disvoteBnt.Click
        'showing the vote total to the user
        totvotstoneLab.Text = StoneVot.ToString
        totvotperezLab.Text = PerezVot.ToString
        totvotpatelLab.Text = PatelVot.ToString

    End Sub
End Class
