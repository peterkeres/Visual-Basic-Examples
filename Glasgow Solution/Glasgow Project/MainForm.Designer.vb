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
        Me.bacfeeLab = New System.Windows.Forms.Label()
        Me.mondueLab = New System.Windows.Forms.Label()
        Me.addfeeLab = New System.Windows.Forms.Label()
        Me.calBnt = New System.Windows.Forms.Button()
        Me.extBnt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.golCheBox = New System.Windows.Forms.CheckBox()
        Me.tenCheBox = New System.Windows.Forms.CheckBox()
        Me.racCheBox = New System.Windows.Forms.CheckBox()
        Me.singRadBnt = New System.Windows.Forms.RadioButton()
        Me.famRadBnt = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'bacfeeLab
        '
        Me.bacfeeLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bacfeeLab.Location = New System.Drawing.Point(36, 211)
        Me.bacfeeLab.Name = "bacfeeLab"
        Me.bacfeeLab.Size = New System.Drawing.Size(116, 29)
        Me.bacfeeLab.TabIndex = 0
        '
        'mondueLab
        '
        Me.mondueLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mondueLab.Location = New System.Drawing.Point(36, 276)
        Me.mondueLab.Name = "mondueLab"
        Me.mondueLab.Size = New System.Drawing.Size(116, 29)
        Me.mondueLab.TabIndex = 0
        '
        'addfeeLab
        '
        Me.addfeeLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addfeeLab.Location = New System.Drawing.Point(264, 211)
        Me.addfeeLab.Name = "addfeeLab"
        Me.addfeeLab.Size = New System.Drawing.Size(116, 29)
        Me.addfeeLab.TabIndex = 0
        '
        'calBnt
        '
        Me.calBnt.Location = New System.Drawing.Point(224, 276)
        Me.calBnt.Name = "calBnt"
        Me.calBnt.Size = New System.Drawing.Size(89, 43)
        Me.calBnt.TabIndex = 1
        Me.calBnt.Text = "&Calculate"
        Me.calBnt.UseVisualStyleBackColor = True
        '
        'extBnt
        '
        Me.extBnt.Location = New System.Drawing.Point(329, 276)
        Me.extBnt.Name = "extBnt"
        Me.extBnt.Size = New System.Drawing.Size(92, 43)
        Me.extBnt.TabIndex = 1
        Me.extBnt.Text = "E&xit"
        Me.extBnt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(33, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Basic Fee:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(33, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Monthly Dues:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(261, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Additional:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(33, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Membership"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(261, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Additional"
        '
        'golCheBox
        '
        Me.golCheBox.AutoSize = True
        Me.golCheBox.Location = New System.Drawing.Point(264, 55)
        Me.golCheBox.Name = "golCheBox"
        Me.golCheBox.Size = New System.Drawing.Size(45, 17)
        Me.golCheBox.TabIndex = 3
        Me.golCheBox.Text = "&Golf"
        Me.golCheBox.UseVisualStyleBackColor = True
        '
        'tenCheBox
        '
        Me.tenCheBox.AutoSize = True
        Me.tenCheBox.Location = New System.Drawing.Point(264, 90)
        Me.tenCheBox.Name = "tenCheBox"
        Me.tenCheBox.Size = New System.Drawing.Size(58, 17)
        Me.tenCheBox.TabIndex = 3
        Me.tenCheBox.Text = "&Tennis"
        Me.tenCheBox.UseVisualStyleBackColor = True
        '
        'racCheBox
        '
        Me.racCheBox.AutoSize = True
        Me.racCheBox.Location = New System.Drawing.Point(264, 127)
        Me.racCheBox.Name = "racCheBox"
        Me.racCheBox.Size = New System.Drawing.Size(83, 17)
        Me.racCheBox.TabIndex = 3
        Me.racCheBox.Text = "&Racquetball"
        Me.racCheBox.UseVisualStyleBackColor = True
        '
        'singRadBnt
        '
        Me.singRadBnt.AutoSize = True
        Me.singRadBnt.Checked = True
        Me.singRadBnt.Location = New System.Drawing.Point(36, 72)
        Me.singRadBnt.Name = "singRadBnt"
        Me.singRadBnt.Size = New System.Drawing.Size(54, 17)
        Me.singRadBnt.TabIndex = 4
        Me.singRadBnt.TabStop = True
        Me.singRadBnt.Text = "&Single"
        Me.singRadBnt.UseVisualStyleBackColor = True
        '
        'famRadBnt
        '
        Me.famRadBnt.AutoSize = True
        Me.famRadBnt.Location = New System.Drawing.Point(36, 115)
        Me.famRadBnt.Name = "famRadBnt"
        Me.famRadBnt.Size = New System.Drawing.Size(54, 17)
        Me.famRadBnt.TabIndex = 4
        Me.famRadBnt.TabStop = True
        Me.famRadBnt.Text = "&Family"
        Me.famRadBnt.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.calBnt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.extBnt
        Me.ClientSize = New System.Drawing.Size(505, 359)
        Me.Controls.Add(Me.famRadBnt)
        Me.Controls.Add(Me.singRadBnt)
        Me.Controls.Add(Me.racCheBox)
        Me.Controls.Add(Me.tenCheBox)
        Me.Controls.Add(Me.golCheBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.extBnt)
        Me.Controls.Add(Me.calBnt)
        Me.Controls.Add(Me.mondueLab)
        Me.Controls.Add(Me.addfeeLab)
        Me.Controls.Add(Me.bacfeeLab)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Glasgow Health Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bacfeeLab As System.Windows.Forms.Label
    Friend WithEvents mondueLab As System.Windows.Forms.Label
    Friend WithEvents addfeeLab As System.Windows.Forms.Label
    Friend WithEvents calBnt As System.Windows.Forms.Button
    Friend WithEvents extBnt As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents golCheBox As System.Windows.Forms.CheckBox
    Friend WithEvents tenCheBox As System.Windows.Forms.CheckBox
    Friend WithEvents racCheBox As System.Windows.Forms.CheckBox
    Friend WithEvents singRadBnt As System.Windows.Forms.RadioButton
    Friend WithEvents famRadBnt As System.Windows.Forms.RadioButton

End Class
