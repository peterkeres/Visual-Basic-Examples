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
        Me.salesidLitBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.salesentTxtBox = New System.Windows.Forms.TextBox()
        Me.addtotBnt = New System.Windows.Forms.Button()
        Me.cretrepotBnt = New System.Windows.Forms.Button()
        Me.extBnt = New System.Windows.Forms.Button()
        Me.saletotTxtBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'salesidLitBox
        '
        Me.salesidLitBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesidLitBox.FormattingEnabled = True
        Me.salesidLitBox.ItemHeight = 16
        Me.salesidLitBox.Location = New System.Drawing.Point(52, 63)
        Me.salesidLitBox.Name = "salesidLitBox"
        Me.salesidLitBox.Size = New System.Drawing.Size(61, 84)
        Me.salesidLitBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sales:"
        '
        'salesentTxtBox
        '
        Me.salesentTxtBox.Location = New System.Drawing.Point(147, 63)
        Me.salesentTxtBox.Name = "salesentTxtBox"
        Me.salesentTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.salesentTxtBox.TabIndex = 1
        '
        'addtotBnt
        '
        Me.addtotBnt.Location = New System.Drawing.Point(283, 54)
        Me.addtotBnt.Name = "addtotBnt"
        Me.addtotBnt.Size = New System.Drawing.Size(113, 36)
        Me.addtotBnt.TabIndex = 2
        Me.addtotBnt.Text = "&Add to Totals"
        Me.addtotBnt.UseVisualStyleBackColor = True
        '
        'cretrepotBnt
        '
        Me.cretrepotBnt.Location = New System.Drawing.Point(283, 222)
        Me.cretrepotBnt.Name = "cretrepotBnt"
        Me.cretrepotBnt.Size = New System.Drawing.Size(113, 36)
        Me.cretrepotBnt.TabIndex = 3
        Me.cretrepotBnt.Text = "&Create Report"
        Me.cretrepotBnt.UseVisualStyleBackColor = True
        '
        'extBnt
        '
        Me.extBnt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.extBnt.Location = New System.Drawing.Point(283, 284)
        Me.extBnt.Name = "extBnt"
        Me.extBnt.Size = New System.Drawing.Size(113, 36)
        Me.extBnt.TabIndex = 4
        Me.extBnt.Text = "E&xit"
        Me.extBnt.UseVisualStyleBackColor = True
        '
        'saletotTxtBox
        '
        Me.saletotTxtBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saletotTxtBox.Location = New System.Drawing.Point(54, 197)
        Me.saletotTxtBox.Multiline = True
        Me.saletotTxtBox.Name = "saletotTxtBox"
        Me.saletotTxtBox.ReadOnly = True
        Me.saletotTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.saletotTxtBox.Size = New System.Drawing.Size(175, 173)
        Me.saletotTxtBox.TabIndex = 0
        '
        'MainForm
        '
        Me.AcceptButton = Me.addtotBnt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.extBnt
        Me.ClientSize = New System.Drawing.Size(437, 458)
        Me.Controls.Add(Me.saletotTxtBox)
        Me.Controls.Add(Me.extBnt)
        Me.Controls.Add(Me.cretrepotBnt)
        Me.Controls.Add(Me.addtotBnt)
        Me.Controls.Add(Me.salesentTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.salesidLitBox)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " JM Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salesidLitBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents salesentTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents addtotBnt As System.Windows.Forms.Button
    Friend WithEvents cretrepotBnt As System.Windows.Forms.Button
    Friend WithEvents extBnt As System.Windows.Forms.Button
    Friend WithEvents saletotTxtBox As System.Windows.Forms.TextBox

End Class
