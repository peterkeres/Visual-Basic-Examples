<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class point_of_sales
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
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstboxOutput = New System.Windows.Forms.ListBox()
        Me.txtboxChange = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tolstrFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tolstrCalculate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tolstrClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tolstrExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblChange.Location = New System.Drawing.Point(103, 36)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(69, 20)
        Me.lblChange.TabIndex = 0
        Me.lblChange.Text = "Change:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkGray
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnCalculate.Location = New System.Drawing.Point(47, 306)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 35)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkGray
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnClear.Location = New System.Drawing.Point(186, 306)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkGray
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnExit.Location = New System.Drawing.Point(325, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lstboxOutput
        '
        Me.lstboxOutput.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lstboxOutput.FormattingEnabled = True
        Me.lstboxOutput.Location = New System.Drawing.Point(30, 77)
        Me.lstboxOutput.Name = "lstboxOutput"
        Me.lstboxOutput.Size = New System.Drawing.Size(397, 212)
        Me.lstboxOutput.TabIndex = 5
        '
        'txtboxChange
        '
        Me.txtboxChange.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtboxChange.Location = New System.Drawing.Point(178, 36)
        Me.txtboxChange.Name = "txtboxChange"
        Me.txtboxChange.Size = New System.Drawing.Size(100, 20)
        Me.txtboxChange.TabIndex = 1
        Me.txtboxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtboxChange.UseWaitCursor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tolstrFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tolstrFile
        '
        Me.tolstrFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tolstrCalculate, Me.tolstrClear, Me.tolstrExit})
        Me.tolstrFile.Name = "tolstrFile"
        Me.tolstrFile.Size = New System.Drawing.Size(37, 20)
        Me.tolstrFile.Text = "&File"
        '
        'tolstrCalculate
        '
        Me.tolstrCalculate.Name = "tolstrCalculate"
        Me.tolstrCalculate.ShortcutKeyDisplayString = "Ctrl A"
        Me.tolstrCalculate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tolstrCalculate.Size = New System.Drawing.Size(160, 22)
        Me.tolstrCalculate.Text = "Calculate"
        '
        'tolstrClear
        '
        Me.tolstrClear.Name = "tolstrClear"
        Me.tolstrClear.ShortcutKeyDisplayString = "Ctrl C"
        Me.tolstrClear.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tolstrClear.Size = New System.Drawing.Size(160, 22)
        Me.tolstrClear.Text = "&Clear"
        '
        'tolstrExit
        '
        Me.tolstrExit.Name = "tolstrExit"
        Me.tolstrExit.ShortcutKeyDisplayString = "Ctrl E"
        Me.tolstrExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tolstrExit.Size = New System.Drawing.Size(160, 22)
        Me.tolstrExit.Text = "E&xit"
        '
        'point_of_sales
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(457, 352)
        Me.Controls.Add(Me.txtboxChange)
        Me.Controls.Add(Me.lstboxOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "point_of_sales"
        Me.Text = "Point of Sales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChange As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstboxOutput As ListBox
    Friend WithEvents txtboxChange As MaskedTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tolstrFile As ToolStripMenuItem
    Friend WithEvents tolstrCalculate As ToolStripMenuItem
    Friend WithEvents tolstrClear As ToolStripMenuItem
    Friend WithEvents tolstrExit As ToolStripMenuItem
End Class
