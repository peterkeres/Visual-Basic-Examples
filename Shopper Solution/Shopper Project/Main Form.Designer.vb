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
        Me.totmonpurTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rewpoiLab = New System.Windows.Forms.Label()
        Me.basRdoBnt = New System.Windows.Forms.RadioButton()
        Me.staRdoBnt = New System.Windows.Forms.RadioButton()
        Me.preRdoBnt = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.calBnt = New System.Windows.Forms.Button()
        Me.extBnt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'totmonpurTxtBox
        '
        Me.totmonpurTxtBox.Location = New System.Drawing.Point(37, 58)
        Me.totmonpurTxtBox.Multiline = True
        Me.totmonpurTxtBox.Name = "totmonpurTxtBox"
        Me.totmonpurTxtBox.Size = New System.Drawing.Size(125, 29)
        Me.totmonpurTxtBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total monthly purchase ($):"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reward points:"
        '
        'rewpoiLab
        '
        Me.rewpoiLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rewpoiLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rewpoiLab.Location = New System.Drawing.Point(37, 166)
        Me.rewpoiLab.Name = "rewpoiLab"
        Me.rewpoiLab.Size = New System.Drawing.Size(128, 29)
        Me.rewpoiLab.TabIndex = 0
        '
        'basRdoBnt
        '
        Me.basRdoBnt.AutoSize = True
        Me.basRdoBnt.Checked = True
        Me.basRdoBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basRdoBnt.Location = New System.Drawing.Point(292, 67)
        Me.basRdoBnt.Name = "basRdoBnt"
        Me.basRdoBnt.Size = New System.Drawing.Size(60, 20)
        Me.basRdoBnt.TabIndex = 2
        Me.basRdoBnt.TabStop = True
        Me.basRdoBnt.Text = "&Basic"
        Me.basRdoBnt.UseVisualStyleBackColor = True
        '
        'staRdoBnt
        '
        Me.staRdoBnt.AutoSize = True
        Me.staRdoBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staRdoBnt.Location = New System.Drawing.Point(292, 106)
        Me.staRdoBnt.Name = "staRdoBnt"
        Me.staRdoBnt.Size = New System.Drawing.Size(81, 20)
        Me.staRdoBnt.TabIndex = 3
        Me.staRdoBnt.Text = "&Standard"
        Me.staRdoBnt.UseVisualStyleBackColor = True
        '
        'preRdoBnt
        '
        Me.preRdoBnt.AutoSize = True
        Me.preRdoBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preRdoBnt.Location = New System.Drawing.Point(292, 143)
        Me.preRdoBnt.Name = "preRdoBnt"
        Me.preRdoBnt.Size = New System.Drawing.Size(79, 20)
        Me.preRdoBnt.TabIndex = 4
        Me.preRdoBnt.Text = "&Premium"
        Me.preRdoBnt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Membership type:"
        '
        'calBnt
        '
        Me.calBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calBnt.Location = New System.Drawing.Point(201, 186)
        Me.calBnt.Name = "calBnt"
        Me.calBnt.Size = New System.Drawing.Size(96, 37)
        Me.calBnt.TabIndex = 5
        Me.calBnt.Text = "&Calculate"
        Me.calBnt.UseVisualStyleBackColor = True
        '
        'extBnt
        '
        Me.extBnt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.extBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extBnt.Location = New System.Drawing.Point(317, 186)
        Me.extBnt.Name = "extBnt"
        Me.extBnt.Size = New System.Drawing.Size(96, 37)
        Me.extBnt.TabIndex = 6
        Me.extBnt.Text = "&Exit"
        Me.extBnt.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.calBnt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.extBnt
        Me.ClientSize = New System.Drawing.Size(443, 235)
        Me.Controls.Add(Me.extBnt)
        Me.Controls.Add(Me.calBnt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.preRdoBnt)
        Me.Controls.Add(Me.staRdoBnt)
        Me.Controls.Add(Me.basRdoBnt)
        Me.Controls.Add(Me.rewpoiLab)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.totmonpurTxtBox)
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopper Stoppers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents totmonpurTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rewpoiLab As System.Windows.Forms.Label
    Friend WithEvents basRdoBnt As System.Windows.Forms.RadioButton
    Friend WithEvents staRdoBnt As System.Windows.Forms.RadioButton
    Friend WithEvents preRdoBnt As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents calBnt As System.Windows.Forms.Button
    Friend WithEvents extBnt As System.Windows.Forms.Button

End Class
