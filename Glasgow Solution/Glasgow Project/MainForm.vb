'Project for chapter 14 page: 749 
'by: peter keres Date: 12/7/2016

Public Class MainForm

    Private Sub extBnt_Click(sender As Object, e As EventArgs) Handles extBnt.Click
        Me.Close()
    End Sub

    Private Sub calBnt_Click(sender As Object, e As EventArgs) Handles calBnt.Click
        'delcarling varbials
        Dim BasicFee As Integer = 0
        Dim AddFee As Integer = 0
        Dim MontlyFee As New MonthlyDues


        'figuring out membership and fees
        If singRadBnt.Checked = True Then
            BasicFee = 50
            If golCheBox.Checked = True Then
                AddFee += 25
            End If
            If tenCheBox.Checked = True Then
                AddFee += 30
            End If
            If racCheBox.Checked = True Then
                AddFee += 20
            End If
        Else
            BasicFee = 90
            If golCheBox.Checked = True Then
                AddFee += 35
            End If
            If tenCheBox.Checked = True Then
                AddFee += 50
            End If
            If racCheBox.Checked = True Then
                AddFee += 30
            End If
        End If


        'putting values into the class
        MontlyFee.BacFee = BasicFee
        MontlyFee.AddFee = AddFee

        'using class to get monthly total 
        Call MontlyFee.MontlyFee()


        'showing values to user
        bacfeeLab.Text = BasicFee.ToString
        addfeeLab.Text = AddFee.ToString
        mondueLab.Text = MontlyFee.MonFee.ToString

    End Sub
End Class
