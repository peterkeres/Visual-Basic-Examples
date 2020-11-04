'program for cahpter 12 on page 663
' By peter keres Date: 12/1/16
'not going to lie here, im really lost on how to get a GPA but i know how to manipulate with a table. 

Option Explicit On
Option Infer On
Option Strict On


Public Class MainForm

    Private Sub TblCoursesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblCoursesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCoursesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CoursesDataSet)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoursesDataSet.tblCourses' table. You can move, or remove it, as needed.
        Me.TblCoursesTableAdapter.Fill(Me.CoursesDataSet.tblCourses)

        'add items to the list box
        letgradLitBox.Items.Add("A")
        letgradLitBox.Items.Add("B")
        letgradLitBox.Items.Add("C")
        letgradLitBox.Items.Add("D")
        letgradLitBox.Items.Add("F")
        letgradLitBox.Items.Add("All Grades")

    End Sub


    Private Sub disgradeBnt_Click(sender As Object, e As EventArgs) Handles disgradeBnt.Click
        'varbials 
        Dim SelectItem As Integer = 0
        SelectItem = letgradLitBox.SelectedIndex

        'use case to get the grades user selected 
        Select Case SelectItem
            Case 0
                Dim AllA = From Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "A" Select Grade
                TblCoursesBindingSource.DataSource = AllA.AsDataView
            Case 1
                Dim AllB = From Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "B" Select Grade
                TblCoursesBindingSource.DataSource = AllB.AsDataView
            Case 2
                Dim AllC = From Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "C" Select Grade
                TblCoursesBindingSource.DataSource = AllC.AsDataView
            Case 3
                Dim AllD = From Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "D" Select Grade
                TblCoursesBindingSource.DataSource = AllD.AsDataView
            Case 4
                Dim AllF = From Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "D" Select Grade
                TblCoursesBindingSource.DataSource = AllF.AsDataView
            Case 5
                Dim AllLet = From Grade In CoursesDataSet.tblCourses Select Grade
                TblCoursesBindingSource.DataSource = AllLet.AsDataView
        End Select
    End Sub


    Private Sub totgpaBnt_Click(sender As Object, e As EventArgs) Handles totgpaBnt.Click
        'varibals 
        Dim TotalGPA As Double = 0
        Dim TotA As Integer = 0       
        Dim TotB As Integer = 0
        Dim TotC As Integer = 0
        Dim TotD As Integer = 0
        Dim TotF As Integer = 0


        'getting numbers for each grade 
        Dim AllA As Integer =
            Aggregate Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "A" Into Count()
        TotA = AllA * 4
        Dim AllCreA As Integer =
            Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "A" Select Credit.CreditHours Into Sum()
        Dim CCreA As Integer =
            Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "A" Into Count()

        Dim AllB As Integer =
            Aggregate Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "B" Into Count()
        TotB = AllB * 3
        Dim AllCreB As Integer =
           Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "B" Select Credit.CreditHours Into Sum()
        Dim CCreB As Integer =
            Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "B" Into Count()

        Dim AllC As Integer =
            Aggregate Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "C" Into Count()
        TotC = AllC * 2
        Dim AllCreC As Integer =
           Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "C" Select Credit.CreditHours Into Sum()
        Dim CCreC As Integer =
            Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "C" Into Count()

        Dim AllD As Integer =
            Aggregate Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "D" Into Count()
        TotD = AllD * 1
        Dim AllCreD As Integer =
           Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "D" Select Credit.CreditHours Into Sum()
        Dim CCreD As Integer =
            Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "D" Into Count()

        Dim AllF As Integer =
            Aggregate Grade In CoursesDataSet.tblCourses Where Grade.Grade.ToUpper = "F" Into Count()
        TotF = AllF * 0
        Dim AllCreF As Integer =
           Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "F" Select Credit.CreditHours Into Sum()
        Dim CCreF As Integer =
            Aggregate Credit In CoursesDataSet.tblCourses Where Credit.Grade.ToUpper = "F" Into Count()

        'getting the final GPA
        TotalGPA = (AllA + AllB + AllC + AllD + AllF) / ((AllCreA + AllCreB + AllCreC + AllCreD + AllCreF) / (CCreA + CCreB + CCreC + CCreD + CCreF))

        'displaying to the user
        MessageBox.Show(" The GPA for this student is : " & TotalGPA.ToString("n2"), " GPA ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub
End Class
