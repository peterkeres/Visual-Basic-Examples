'Title:     Gaming Art Windows Application
'Author:    Peter Keres
'Date:      April 14 2019
'Purpose:   this is for assigment 9, which is over the walk along coding part on page 628 of the visual basic book 2017




Public Class frmArt
    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub

    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)

    End Sub


    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        'this will run whenever the value button is clicked
        'it should get the total values from the database table file

        'the sql statment to get the data we want from the database file
        Dim strSql As String = "SELECT * FROM Artist"

        'the database type & path to the datatbase
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=..\..\Art.accdb"
        'setting up a new object that lets us interact with the database
        Dim odaArtist As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim dataValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D

        'the datvalue datatable is filled with the talbe data from the data base
        odaArtist.Fill(dataValue)
        'disconnect the database
        odaArtist.Dispose()

        'going though each row of the table and getting the data in the retail price column 
        For intCount = 0 To dataValue.Rows.Count - 1
            decTotalValue += Convert.ToDecimal(dataValue.Rows(intCount)("Retail Price"))
        Next

        'displaying the results
        lblTotalRetailValue.Visible = True
        lblTotalRetailValue.Text = "The Total Retail Value is " & decTotalValue.ToString("C")

    End Sub


End Class
