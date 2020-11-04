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
        Me.candateLitBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totvotstoneLab = New System.Windows.Forms.Label()
        Me.totvotpatelLab = New System.Windows.Forms.Label()
        Me.totvotperezLab = New System.Windows.Forms.Label()
        Me.savoteBnt = New System.Windows.Forms.Button()
        Me.disvoteBnt = New System.Windows.Forms.Button()
        Me.extBnt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'candateLitBox
        '
        Me.candateLitBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.candateLitBox.FormattingEnabled = True
        Me.candateLitBox.ItemHeight = 16
        Me.candateLitBox.Location = New System.Drawing.Point(31, 38)
        Me.candateLitBox.Name = "candateLitBox"
        Me.candateLitBox.Size = New System.Drawing.Size(159, 68)
        Me.candateLitBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Candidate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mark Stone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sheima Patel:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(289, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sam Perez:"
        '
        'totvotstoneLab
        '
        Me.totvotstoneLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totvotstoneLab.Location = New System.Drawing.Point(42, 208)
        Me.totvotstoneLab.Name = "totvotstoneLab"
        Me.totvotstoneLab.Size = New System.Drawing.Size(79, 41)
        Me.totvotstoneLab.TabIndex = 3
        Me.totvotstoneLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totvotpatelLab
        '
        Me.totvotpatelLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totvotpatelLab.Location = New System.Drawing.Point(163, 208)
        Me.totvotpatelLab.Name = "totvotpatelLab"
        Me.totvotpatelLab.Size = New System.Drawing.Size(79, 41)
        Me.totvotpatelLab.TabIndex = 3
        Me.totvotpatelLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totvotperezLab
        '
        Me.totvotperezLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totvotperezLab.Location = New System.Drawing.Point(292, 208)
        Me.totvotperezLab.Name = "totvotperezLab"
        Me.totvotperezLab.Size = New System.Drawing.Size(79, 41)
        Me.totvotperezLab.TabIndex = 3
        Me.totvotperezLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'savoteBnt
        '
        Me.savoteBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savoteBnt.Location = New System.Drawing.Point(292, 19)
        Me.savoteBnt.Name = "savoteBnt"
        Me.savoteBnt.Size = New System.Drawing.Size(105, 35)
        Me.savoteBnt.TabIndex = 4
        Me.savoteBnt.Text = "&Save Vote"
        Me.savoteBnt.UseVisualStyleBackColor = True
        '
        'disvoteBnt
        '
        Me.disvoteBnt.AutoSize = True
        Me.disvoteBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disvoteBnt.Location = New System.Drawing.Point(292, 60)
        Me.disvoteBnt.Name = "disvoteBnt"
        Me.disvoteBnt.Size = New System.Drawing.Size(105, 35)
        Me.disvoteBnt.TabIndex = 4
        Me.disvoteBnt.Text = "&Display Votes "
        Me.disvoteBnt.UseVisualStyleBackColor = True
        '
        'extBnt
        '
        Me.extBnt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.extBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extBnt.Location = New System.Drawing.Point(292, 101)
        Me.extBnt.Name = "extBnt"
        Me.extBnt.Size = New System.Drawing.Size(105, 35)
        Me.extBnt.TabIndex = 4
        Me.extBnt.Text = "E&xit"
        Me.extBnt.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.savoteBnt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.extBnt
        Me.ClientSize = New System.Drawing.Size(411, 284)
        Me.Controls.Add(Me.extBnt)
        Me.Controls.Add(Me.disvoteBnt)
        Me.Controls.Add(Me.savoteBnt)
        Me.Controls.Add(Me.totvotperezLab)
        Me.Controls.Add(Me.totvotpatelLab)
        Me.Controls.Add(Me.totvotstoneLab)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.candateLitBox)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warren High School"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents candateLitBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents totvotstoneLab As System.Windows.Forms.Label
    Friend WithEvents totvotpatelLab As System.Windows.Forms.Label
    Friend WithEvents totvotperezLab As System.Windows.Forms.Label
    Friend WithEvents savoteBnt As System.Windows.Forms.Button
    Friend WithEvents disvoteBnt As System.Windows.Forms.Button
    Friend WithEvents extBnt As System.Windows.Forms.Button

End Class
