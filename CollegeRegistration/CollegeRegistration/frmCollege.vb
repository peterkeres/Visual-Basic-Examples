'Program:       College Registration Costs
'Developer:     Peter Keres
'Date:          April 22 2019
'Purpose:       This program is apart of the guided programming assigemnt for chapter 10, starts on 688


Option Strict On


Public Class frmCollege


    Private Sub btnCosts_Click(sender As Object, e As EventArgs) Handles btnCosts.Click
        'this is for when the calculate cost button is clicked

        Dim objStudent As Student
        Dim objOnCampusStudent As OnCampusStudent
        Dim inputError As Boolean = False

        'is student ID enter properly

        'name entered properly 
        If txtName.TextLength < 1 Or txtName.Text < "A" Then
            MsgBox("Enter your name in the student name box", , "Error")
            txtName.Clear()
            txtName.Focus()
            inputError = True
            'number units entered in properly 
        ElseIf Not IsNumeric(txtUnits.Text) Then
            MsgBox("Enter the units in the number of units box", , "Error")
            txtUnits.Clear()
            txtUnits.Focus()
            inputError = True
        ElseIf Convert.ToInt32(txtUnits.Text) < 1 Or Convert.ToInt32(txtUnits.Text) > 24 Then
            MsgBox("Units must be 1 -24", , "Error")
            txtUnits.Clear()
            txtUnits.Focus()
            inputError = True
            'has major been selected
        ElseIf cboxMajor.SelectedIndex < 0 Then
            MsgBox("Please select a major", , "Error")
            inputError = True
        End If

        'no inputerror, do cotst
        If Not inputError Then
            If rbtnOffCampus.Checked Then
                objStudent = New Student(txtID.Text, txtName.Text, Convert.ToString(cboxMajor.SelectedItem), txtUnits.Text)
                lblTotalCost.Visible = True
                lblTotalCost.Text = objStudent.ComputeCosts().toString("C2")
            Else
                objOnCampusStudent = New OnCampusStudent(txtID.Text, txtName.Text, Convert.ToString(cboxMajor.SelectedItem), txtUnits.Text, radCooperDorm.Checked, radCraigHall.Checked, radJulianSuites.Checked)
                lblTotalCost.Visible = True
                lblTotalCost.Text = objOnCampusStudent.ComputeCosts().ToString("C2")
            End If
        End If

    End Sub

    Private Sub rbtnOffCampus_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOffCampus.CheckedChanged
        grpHousingBoard.Visible = False
    End Sub

    Private Sub rbtnOnCampus_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOnCampus.CheckedChanged
        grpHousingBoard.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtID.Text = ""
        txtName.Text = ""
        txtUnits.Text = ""
        lblTotalCost.Text = "xxxx"

        cboxMajor.SelectedIndex = -1

        rbtnOffCampus.Checked = False
        rbtnOnCampus.Checked = False

        radCooperDorm.Checked = False
        radCraigHall.Checked = False
        radJulianSuites.Checked = False

    End Sub

    Private Sub frmCollege_Load(sender As Object, e As EventArgs) Handles Me.Load

        cboxMajor.Items.Add("Accounting")
        cboxMajor.Items.Add("Agriclture")
        cboxMajor.Items.Add("Enginerring")
        cboxMajor.Items.Add("Management")
    End Sub




End Class
