' Program Name: Latte Selection
' Developer:    Peter Keres
' Purpose:      This is for chapter 3 Assigment 2



Public Class frmLatteSelection


    Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        'Should display the picture of the pumpkin drink

        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True

    End Sub


    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'When the user clicks the select button

        btnPumpkin.Enabled = False
        btnSelect.Enabled = False
        btnMocha.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True

    End Sub


    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        'Should display the picture of the pumpkin dirnk

        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelect.Enabled = True

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the program

        Close()

    End Sub


End Class
