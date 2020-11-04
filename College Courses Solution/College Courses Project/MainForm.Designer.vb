<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CoursesDataSet = New College_Courses_Project.CoursesDataSet()
        Me.TblCoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCoursesTableAdapter = New College_Courses_Project.CoursesDataSetTableAdapters.tblCoursesTableAdapter()
        Me.TableAdapterManager = New College_Courses_Project.CoursesDataSetTableAdapters.TableAdapterManager()
        Me.TblCoursesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblCoursesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.totgpaBnt = New System.Windows.Forms.ToolStripButton()
        Me.TblCoursesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.letgradLitBox = New System.Windows.Forms.ListBox()
        Me.disgradeBnt = New System.Windows.Forms.Button()
        CType(Me.CoursesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCoursesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblCoursesBindingNavigator.SuspendLayout()
        CType(Me.TblCoursesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CoursesDataSet
        '
        Me.CoursesDataSet.DataSetName = "CoursesDataSet"
        Me.CoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCoursesBindingSource
        '
        Me.TblCoursesBindingSource.DataMember = "tblCourses"
        Me.TblCoursesBindingSource.DataSource = Me.CoursesDataSet
        '
        'TblCoursesTableAdapter
        '
        Me.TblCoursesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCoursesTableAdapter = Me.TblCoursesTableAdapter
        Me.TableAdapterManager.UpdateOrder = College_Courses_Project.CoursesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCoursesBindingNavigator
        '
        Me.TblCoursesBindingNavigator.AddNewItem = Nothing
        Me.TblCoursesBindingNavigator.BindingSource = Me.TblCoursesBindingSource
        Me.TblCoursesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblCoursesBindingNavigator.DeleteItem = Nothing
        Me.TblCoursesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TblCoursesBindingNavigatorSaveItem, Me.totgpaBnt})
        Me.TblCoursesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblCoursesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblCoursesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblCoursesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblCoursesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblCoursesBindingNavigator.Name = "TblCoursesBindingNavigator"
        Me.TblCoursesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblCoursesBindingNavigator.Size = New System.Drawing.Size(452, 25)
        Me.TblCoursesBindingNavigator.TabIndex = 0
        Me.TblCoursesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblCoursesBindingNavigatorSaveItem
        '
        Me.TblCoursesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblCoursesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblCoursesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblCoursesBindingNavigatorSaveItem.Name = "TblCoursesBindingNavigatorSaveItem"
        Me.TblCoursesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblCoursesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'totgpaBnt
        '
        Me.totgpaBnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.totgpaBnt.Image = CType(resources.GetObject("totgpaBnt.Image"), System.Drawing.Image)
        Me.totgpaBnt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.totgpaBnt.Name = "totgpaBnt"
        Me.totgpaBnt.Size = New System.Drawing.Size(85, 22)
        Me.totgpaBnt.Text = "Calculate GPA"
        '
        'TblCoursesDataGridView
        '
        Me.TblCoursesDataGridView.AutoGenerateColumns = False
        Me.TblCoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCoursesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblCoursesDataGridView.DataSource = Me.TblCoursesBindingSource
        Me.TblCoursesDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.TblCoursesDataGridView.Name = "TblCoursesDataGridView"
        Me.TblCoursesDataGridView.Size = New System.Drawing.Size(443, 192)
        Me.TblCoursesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CreditHours"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CreditHours"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Grade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Grade"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'letgradLitBox
        '
        Me.letgradLitBox.FormattingEnabled = True
        Me.letgradLitBox.Location = New System.Drawing.Point(12, 226)
        Me.letgradLitBox.Name = "letgradLitBox"
        Me.letgradLitBox.Size = New System.Drawing.Size(107, 95)
        Me.letgradLitBox.TabIndex = 2
        '
        'disgradeBnt
        '
        Me.disgradeBnt.Location = New System.Drawing.Point(125, 271)
        Me.disgradeBnt.Name = "disgradeBnt"
        Me.disgradeBnt.Size = New System.Drawing.Size(136, 50)
        Me.disgradeBnt.TabIndex = 3
        Me.disgradeBnt.Text = "Display Grades"
        Me.disgradeBnt.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 335)
        Me.Controls.Add(Me.disgradeBnt)
        Me.Controls.Add(Me.letgradLitBox)
        Me.Controls.Add(Me.TblCoursesDataGridView)
        Me.Controls.Add(Me.TblCoursesBindingNavigator)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Courses"
        CType(Me.CoursesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCoursesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblCoursesBindingNavigator.ResumeLayout(False)
        Me.TblCoursesBindingNavigator.PerformLayout()
        CType(Me.TblCoursesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CoursesDataSet As College_Courses_Project.CoursesDataSet
    Friend WithEvents TblCoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCoursesTableAdapter As College_Courses_Project.CoursesDataSetTableAdapters.tblCoursesTableAdapter
    Friend WithEvents TableAdapterManager As College_Courses_Project.CoursesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCoursesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblCoursesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblCoursesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents letgradLitBox As System.Windows.Forms.ListBox
    Friend WithEvents disgradeBnt As System.Windows.Forms.Button
    Friend WithEvents totgpaBnt As System.Windows.Forms.ToolStripButton

End Class
