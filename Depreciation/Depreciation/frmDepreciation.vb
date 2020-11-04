'Program Name:  Chef shack food truck
'Aurthor:       peter keres
'date:          april 4 2019
'purpose:       this is for the guided program of chapter 8 on page 494


Option Strict On


Public Class frmDepreciation
    'class level varabiles
    Private _intLifeOfItems As Integer = 5
    Public Shared _intSizeOfArray As Integer = 7
    Public Shared _strInventoryItem(_intSizeOfArray) As String
    Private _strItemId(_intSizeOfArray) As String
    Private _decInitialPrice(_intSizeOfArray) As Decimal
    Private _intQuantity(_intSizeOfArray) As Integer


    Private Sub frmDepreciation_Load(sender As Object, e As EventArgs) Handles Me.Load
        'this code runs when the depreciation from is loaded 
        'fills a listbox with items from a file

        'initialize an instance of the streamReader object and delcare variables
        'use stream reader to read items from files
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "..\files\inventory.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not avaiable. Restart when the file is available."

        'verify the files exists
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            'reads the file line by line
            'note, each item is on a different line in the file
            Do While objReader.Peek <> -1
                _strInventoryItem(intCount) = objReader.ReadLine()
                _strItemId(intCount) = objReader.ReadLine()
                _decInitialPrice(intCount) = Convert.ToDecimal(objReader.ReadLine())
                _intQuantity(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop
            'fills the list box with the item id only
            For intFill = 0 To (_strItemId.Length - 1)
                lstInventoryId.Items.Add(_strItemId(intFill))
            Next

        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub



    Private Sub btnCalculateDepreciation_Click(sender As Object, e As EventArgs) Handles btnCalculateDepreciation.Click
        'this code is run with the calculate button is clicked
        'will call methods based on what item is checked in the radio box

        'declar varables
        Dim intSelectedItemId As Integer
        Dim strMissingSelection As String = "Missing Selection"
        Dim strSelectionDepreciationError As String = "Select a Depreciation Method"
        Dim strSelectInventoryItemIdError As String = "Select an Inventory Item ID"

        'checks to see what radio button is slelected, if any, then calls the right method/ error message
        If lstInventoryId.SelectedIndex >= 0 Then
            intSelectedItemId = lstInventoryId.SelectedIndex
            If radStraightLine.Checked Then
                StraightLineDepreciation(intSelectedItemId)
            ElseIf radDoubleDeclining.Checked Then
                DoubleDecliningDepreciation(intSelectedItemId)
            Else
                MsgBox(strSelectionDepreciationError, , strMissingSelection)
            End If
        Else
            MsgBox(strSelectInventoryItemIdError, , strMissingSelection)
        End If

    End Sub

    Private Sub StraightLineDepreciation(ByVal intItemId As Integer)
        'computes and displays the straight line depresciation for the item selected
        'declar varables
        Dim intStraightPresentYear As Integer
        Dim decStraightPresentYearValue As Decimal = 0
        Dim decStraightDepreciation As Decimal
        Dim decStraightTotal As Decimal
        Dim strDepreciationItem As String = "The depreciation of the item: "
        Dim strQuantityMessage As String = "Quantity: "

        'calls  a precdure to display the form objects
        MakeObjectsVisible()
        'display the tiem and quantity of the select item
        lblItem.Text = strDepreciationItem & _strInventoryItem(intItemId)
        lblQuantity.Text = strQuantityMessage & _intQuantity(intItemId).ToString()
        'the formula for straight line depreciation
        decStraightDepreciation = _decInitialPrice(intItemId) / _intLifeOfItems
        decStraightPresentYearValue = _decInitialPrice(intItemId)

        'the loop repeats for the life of the item
        For intStraightPresentYear = 1 To _intLifeOfItems
            'the total of depreciation
            decStraightTotal += decStraightDepreciation
            'displays the depreciation amounts
            lstYear.Items.Add(intStraightPresentYear.ToString)
            lstPresentValue.Items.Add(decStraightPresentYearValue.ToString("c"))
            lstYEarDepreciation.Items.Add(decStraightDepreciation.ToString("c"))
            lstTotalDepreciation.Items.Add(decStraightTotal.ToString("c"))
            decStraightPresentYearValue -= decStraightDepreciation
        Next

    End Sub

    Private Sub DoubleDecliningDepreciation(ByVal intItemId As Integer)
        ' this method will compute and display the double declining
        Dim intDoublePresentYear As Integer
        Dim decDoublePresentYearValue As Decimal = 0
        Dim decDoubleDepreciation As Decimal
        Dim decDoubleTotal As Decimal

        'makes objects visiable in the form
        MakeObjectsVisible()
        'dispaly items and quantity of the item
        lblItem.Text = "The depreciation of the item: " & _strInventoryItem(intItemId)
        lblQuantity.Text = "Quantity: " & _intQuantity(intItemId).ToString
        decDoublePresentYearValue = _decInitialPrice(intItemId)

        'the loop reaptest for the life of the item
        For intDoublePresentYear = 1 To _intLifeOfItems
            decDoubleDepreciation = (decDoublePresentYearValue * 2D) / _intLifeOfItems
            decDoubleTotal += decDoubleDepreciation
            lstYear.Items.Add(intDoublePresentYear.ToString)
            lstPresentValue.Items.Add(decDoublePresentYearValue.ToString("c"))
            lstYEarDepreciation.Items.Add(decDoubleDepreciation.ToString("c"))
            lstTotalDepreciation.Items.Add(decDoubleTotal.ToString("c"))
            decDoublePresentYearValue -= decDoubleDepreciation
        Next

    End Sub

    Private Sub MakeObjectsVisible()
        'hows the items in the form
        lblItem.Visible = True
        lblQuantity.Visible = True
        lblYear.Visible = True
        lstYear.Visible = True
        lblPresentValue.Visible = True
        lstPresentValue.Visible = True
        lblYearDepreciation.Visible = True
        lstYEarDepreciation.Visible = True
        lblTotalDepreciation.Visible = True
        lstTotalDepreciation.Visible = True
        'remove old data
        lstYear.Items.Clear()
        lstPresentValue.Items.Clear()
        lstYEarDepreciation.Items.Clear()
        lstTotalDepreciation.Items.Clear()

    End Sub


    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click

        Dim frmSecond As New frmDisplayInventory

        'hid this form and hosw the other form
        Hide()
        frmSecond.ShowDialog()
    End Sub


    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstInventoryId.SelectedIndex = -1
        radStraightLine.Checked = False
        radDoubleDeclining.Checked = False
        lblItem.Visible = False
        lblQuantity.Visible = False
        lblYear.Visible = False
        lstYear.Visible = False
        lstYear.Items.Clear()
        lblPresentValue.Visible = False
        lstPresentValue.Visible = False
        lstPresentValue.Items.Clear()
        lblYearDepreciation.Visible = False
        lstYEarDepreciation.Visible = False
        lstYEarDepreciation.Items.Clear()
        lblTotalDepreciation.Visible = False
        lstTotalDepreciation.Visible = False
        lstTotalDepreciation.Items.Clear()

    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub


End Class
