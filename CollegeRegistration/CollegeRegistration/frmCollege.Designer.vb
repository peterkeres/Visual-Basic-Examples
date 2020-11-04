<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollege
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollege))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picGroup = New System.Windows.Forms.PictureBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.gboxResidence = New System.Windows.Forms.GroupBox()
        Me.rbtnOffCampus = New System.Windows.Forms.RadioButton()
        Me.rbtnOnCampus = New System.Windows.Forms.RadioButton()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.cboxMajor = New System.Windows.Forms.ComboBox()
        Me.btnCosts = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCostHeader = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.grpHousingBoard = New System.Windows.Forms.GroupBox()
        Me.radCooperDorm = New System.Windows.Forms.RadioButton()
        Me.radCraigHall = New System.Windows.Forms.RadioButton()
        Me.radJulianSuites = New System.Windows.Forms.RadioButton()
        CType(Me.picGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxResidence.SuspendLayout()
        Me.grpHousingBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Navy
        Me.lblHeading.Location = New System.Drawing.Point(325, 44)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(313, 78)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Rgister for Classes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bedford College"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picGroup
        '
        Me.picGroup.Image = CType(resources.GetObject("picGroup.Image"), System.Drawing.Image)
        Me.picGroup.Location = New System.Drawing.Point(12, 12)
        Me.picGroup.Name = "picGroup"
        Me.picGroup.Size = New System.Drawing.Size(279, 164)
        Me.picGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGroup.TabIndex = 1
        Me.picGroup.TabStop = False
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(59, 204)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(91, 19)
        Me.lblStudentID.TabIndex = 2
        Me.lblStudentID.Text = "Student ID:"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(62, 250)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(115, 19)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name:"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(62, 299)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(135, 19)
        Me.lblUnit.TabIndex = 4
        Me.lblUnit.Text = "Number Of Units:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(242, 202)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 20)
        Me.txtID.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(242, 248)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(362, 20)
        Me.txtName.TabIndex = 6
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(242, 297)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(49, 20)
        Me.txtUnits.TabIndex = 7
        '
        'gboxResidence
        '
        Me.gboxResidence.Controls.Add(Me.rbtnOnCampus)
        Me.gboxResidence.Controls.Add(Me.rbtnOffCampus)
        Me.gboxResidence.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxResidence.Location = New System.Drawing.Point(24, 367)
        Me.gboxResidence.Name = "gboxResidence"
        Me.gboxResidence.Size = New System.Drawing.Size(153, 96)
        Me.gboxResidence.TabIndex = 8
        Me.gboxResidence.TabStop = False
        Me.gboxResidence.Text = "Residence"
        '
        'rbtnOffCampus
        '
        Me.rbtnOffCampus.AutoSize = True
        Me.rbtnOffCampus.Location = New System.Drawing.Point(6, 26)
        Me.rbtnOffCampus.Name = "rbtnOffCampus"
        Me.rbtnOffCampus.Size = New System.Drawing.Size(112, 23)
        Me.rbtnOffCampus.TabIndex = 0
        Me.rbtnOffCampus.TabStop = True
        Me.rbtnOffCampus.Text = "Off-Campus"
        Me.rbtnOffCampus.UseVisualStyleBackColor = True
        '
        'rbtnOnCampus
        '
        Me.rbtnOnCampus.AutoSize = True
        Me.rbtnOnCampus.Location = New System.Drawing.Point(6, 55)
        Me.rbtnOnCampus.Name = "rbtnOnCampus"
        Me.rbtnOnCampus.Size = New System.Drawing.Size(111, 23)
        Me.rbtnOnCampus.TabIndex = 9
        Me.rbtnOnCampus.TabStop = True
        Me.rbtnOnCampus.Text = "On-Campus"
        Me.rbtnOnCampus.UseVisualStyleBackColor = True
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(432, 369)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(55, 19)
        Me.lblMajor.TabIndex = 10
        Me.lblMajor.Text = "Major:"
        '
        'cboxMajor
        '
        Me.cboxMajor.FormattingEnabled = True
        Me.cboxMajor.Location = New System.Drawing.Point(517, 367)
        Me.cboxMajor.Name = "cboxMajor"
        Me.cboxMajor.Size = New System.Drawing.Size(154, 21)
        Me.cboxMajor.TabIndex = 11
        '
        'btnCosts
        '
        Me.btnCosts.BackColor = System.Drawing.Color.Transparent
        Me.btnCosts.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCosts.Location = New System.Drawing.Point(144, 497)
        Me.btnCosts.Name = "btnCosts"
        Me.btnCosts.Size = New System.Drawing.Size(147, 39)
        Me.btnCosts.TabIndex = 12
        Me.btnCosts.Text = "Calculate Costs"
        Me.btnCosts.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(483, 497)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 39)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCostHeader
        '
        Me.lblTotalCostHeader.AutoSize = True
        Me.lblTotalCostHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostHeader.Location = New System.Drawing.Point(206, 547)
        Me.lblTotalCostHeader.Name = "lblTotalCostHeader"
        Me.lblTotalCostHeader.Size = New System.Drawing.Size(188, 19)
        Me.lblTotalCostHeader.TabIndex = 14
        Me.lblTotalCostHeader.Text = "Total Semester costs are:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(417, 547)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(57, 19)
        Me.lblTotalCost.TabIndex = 15
        Me.lblTotalCost.Text = "xxxxxx"
        '
        'grpHousingBoard
        '
        Me.grpHousingBoard.Controls.Add(Me.radJulianSuites)
        Me.grpHousingBoard.Controls.Add(Me.radCraigHall)
        Me.grpHousingBoard.Controls.Add(Me.radCooperDorm)
        Me.grpHousingBoard.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHousingBoard.Location = New System.Drawing.Point(210, 369)
        Me.grpHousingBoard.Name = "grpHousingBoard"
        Me.grpHousingBoard.Size = New System.Drawing.Size(200, 112)
        Me.grpHousingBoard.TabIndex = 16
        Me.grpHousingBoard.TabStop = False
        Me.grpHousingBoard.Text = "Housing/Board"
        '
        'radCooperDorm
        '
        Me.radCooperDorm.AutoSize = True
        Me.radCooperDorm.Location = New System.Drawing.Point(19, 24)
        Me.radCooperDorm.Name = "radCooperDorm"
        Me.radCooperDorm.Size = New System.Drawing.Size(123, 23)
        Me.radCooperDorm.TabIndex = 0
        Me.radCooperDorm.TabStop = True
        Me.radCooperDorm.Text = "Cooper Dorm"
        Me.radCooperDorm.UseVisualStyleBackColor = True
        '
        'radCraigHall
        '
        Me.radCraigHall.AutoSize = True
        Me.radCraigHall.Location = New System.Drawing.Point(19, 53)
        Me.radCraigHall.Name = "radCraigHall"
        Me.radCraigHall.Size = New System.Drawing.Size(96, 23)
        Me.radCraigHall.TabIndex = 1
        Me.radCraigHall.TabStop = True
        Me.radCraigHall.Text = "Craig Hall"
        Me.radCraigHall.UseVisualStyleBackColor = True
        '
        'radJulianSuites
        '
        Me.radJulianSuites.AutoSize = True
        Me.radJulianSuites.Location = New System.Drawing.Point(19, 82)
        Me.radJulianSuites.Name = "radJulianSuites"
        Me.radJulianSuites.Size = New System.Drawing.Size(115, 23)
        Me.radJulianSuites.TabIndex = 2
        Me.radJulianSuites.TabStop = True
        Me.radJulianSuites.Text = "Julian Suites"
        Me.radJulianSuites.UseVisualStyleBackColor = True
        '
        'frmCollege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(683, 575)
        Me.Controls.Add(Me.grpHousingBoard)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostHeader)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCosts)
        Me.Controls.Add(Me.cboxMajor)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.gboxResidence)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.picGroup)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmCollege"
        Me.Text = "College Registration Costs"
        CType(Me.picGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxResidence.ResumeLayout(False)
        Me.gboxResidence.PerformLayout()
        Me.grpHousingBoard.ResumeLayout(False)
        Me.grpHousingBoard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picGroup As PictureBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents gboxResidence As GroupBox
    Friend WithEvents rbtnOffCampus As RadioButton
    Friend WithEvents rbtnOnCampus As RadioButton
    Friend WithEvents lblMajor As Label
    Friend WithEvents cboxMajor As ComboBox
    Friend WithEvents btnCosts As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCostHeader As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents grpHousingBoard As GroupBox
    Friend WithEvents radJulianSuites As RadioButton
    Friend WithEvents radCraigHall As RadioButton
    Friend WithEvents radCooperDorm As RadioButton
End Class
