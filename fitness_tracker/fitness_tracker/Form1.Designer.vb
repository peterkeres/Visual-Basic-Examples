<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.txtfldFirstName = New System.Windows.Forms.MaskedTextBox()
        Me.txtfldLastName = New System.Windows.Forms.MaskedTextBox()
        Me.txtfldBirth = New System.Windows.Forms.MaskedTextBox()
        Me.txtfldCurrentDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblTotalHoursHeading = New System.Windows.Forms.Label()
        Me.lblFullNameHeading = New System.Windows.Forms.Label()
        Me.picMainPicture = New System.Windows.Forms.PictureBox()
        CType(Me.picMainPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(74, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(252, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Fitness tracker!"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFirstName.Location = New System.Drawing.Point(27, 85)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(71, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLastName.Location = New System.Drawing.Point(26, 118)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(71, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBirthDate.Location = New System.Drawing.Point(26, 151)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(68, 13)
        Me.lblBirthDate.TabIndex = 3
        Me.lblBirthDate.Text = "Birth Date:"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCurrentDate.Location = New System.Drawing.Point(27, 184)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(83, 13)
        Me.lblCurrentDate.TabIndex = 4
        Me.lblCurrentDate.Text = "Current Date:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Goldenrod
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(30, 253)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(150, 253)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(270, 253)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFullName.Location = New System.Drawing.Point(83, 297)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(129, 20)
        Me.lblFullName.TabIndex = 8
        Me.lblFullName.Text = "PLACEHOLDER"
        Me.lblFullName.Visible = False
        '
        'lblTotalHours
        '
        Me.lblTotalHours.AutoSize = True
        Me.lblTotalHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHours.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalHours.Location = New System.Drawing.Point(443, 297)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(90, 20)
        Me.lblTotalHours.TabIndex = 9
        Me.lblTotalHours.Text = "888888888"
        Me.lblTotalHours.Visible = False
        '
        'txtfldFirstName
        '
        Me.txtfldFirstName.Location = New System.Drawing.Point(150, 83)
        Me.txtfldFirstName.Name = "txtfldFirstName"
        Me.txtfldFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtfldFirstName.TabIndex = 1
        '
        'txtfldLastName
        '
        Me.txtfldLastName.Location = New System.Drawing.Point(150, 117)
        Me.txtfldLastName.Name = "txtfldLastName"
        Me.txtfldLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtfldLastName.TabIndex = 2
        '
        'txtfldBirth
        '
        Me.txtfldBirth.Location = New System.Drawing.Point(150, 151)
        Me.txtfldBirth.Mask = "00/00/0000"
        Me.txtfldBirth.Name = "txtfldBirth"
        Me.txtfldBirth.Size = New System.Drawing.Size(100, 20)
        Me.txtfldBirth.TabIndex = 3
        Me.txtfldBirth.ValidatingType = GetType(Date)
        '
        'txtfldCurrentDate
        '
        Me.txtfldCurrentDate.Location = New System.Drawing.Point(150, 185)
        Me.txtfldCurrentDate.Mask = "00/00/0000"
        Me.txtfldCurrentDate.Name = "txtfldCurrentDate"
        Me.txtfldCurrentDate.Size = New System.Drawing.Size(100, 20)
        Me.txtfldCurrentDate.TabIndex = 4
        Me.txtfldCurrentDate.ValidatingType = GetType(Date)
        '
        'lblTotalHoursHeading
        '
        Me.lblTotalHoursHeading.AutoSize = True
        Me.lblTotalHoursHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHoursHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalHoursHeading.Location = New System.Drawing.Point(274, 297)
        Me.lblTotalHoursHeading.Name = "lblTotalHoursHeading"
        Me.lblTotalHoursHeading.Size = New System.Drawing.Size(163, 20)
        Me.lblTotalHoursHeading.TabIndex = 10
        Me.lblTotalHoursHeading.Text = "Total hours exercised:"
        Me.lblTotalHoursHeading.Visible = False
        '
        'lblFullNameHeading
        '
        Me.lblFullNameHeading.AutoSize = True
        Me.lblFullNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullNameHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFullNameHeading.Location = New System.Drawing.Point(22, 297)
        Me.lblFullNameHeading.Name = "lblFullNameHeading"
        Me.lblFullNameHeading.Size = New System.Drawing.Size(55, 20)
        Me.lblFullNameHeading.TabIndex = 11
        Me.lblFullNameHeading.Text = "Name:"
        Me.lblFullNameHeading.Visible = False
        '
        'picMainPicture
        '
        Me.picMainPicture.Image = Global.fitness_tracker.My.Resources.Resources.download
        Me.picMainPicture.Location = New System.Drawing.Point(289, 49)
        Me.picMainPicture.Name = "picMainPicture"
        Me.picMainPicture.Size = New System.Drawing.Size(228, 181)
        Me.picMainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMainPicture.TabIndex = 12
        Me.picMainPicture.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(561, 333)
        Me.Controls.Add(Me.picMainPicture)
        Me.Controls.Add(Me.lblFullNameHeading)
        Me.Controls.Add(Me.lblTotalHoursHeading)
        Me.Controls.Add(Me.txtfldCurrentDate)
        Me.Controls.Add(Me.txtfldBirth)
        Me.Controls.Add(Me.txtfldLastName)
        Me.Controls.Add(Me.txtfldFirstName)
        Me.Controls.Add(Me.lblTotalHours)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "Fitness Tracker"
        CType(Me.picMainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblTotalHours As Label
    Friend WithEvents txtfldFirstName As MaskedTextBox
    Friend WithEvents txtfldLastName As MaskedTextBox
    Friend WithEvents txtfldBirth As MaskedTextBox
    Friend WithEvents txtfldCurrentDate As MaskedTextBox
    Friend WithEvents lblTotalHoursHeading As Label
    Friend WithEvents lblFullNameHeading As Label
    Friend WithEvents picMainPicture As PictureBox
End Class
