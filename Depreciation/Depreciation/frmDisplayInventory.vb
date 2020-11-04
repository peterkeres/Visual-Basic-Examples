'this form is opend by the frmDepreciation
' it displays the inventory frile in a stored order


Option Strict On


Public Class frmDisplayInventory


    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        'this code will run whenever the frmdispaly inventory is loaded
        'displays the sorted inventory items

        Dim strItem As String

        'sort the _strInventoryItem array
        Array.Sort(frmDepreciation._strInventoryItem)

        'displays the _strInventoryItem array
        For Each strItem In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItem)
        Next

    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'this opens up the first form
        Dim frmFirst As New frmDepreciation

        Hide()
        frmFirst.ShowDialog()
    End Sub



End Class