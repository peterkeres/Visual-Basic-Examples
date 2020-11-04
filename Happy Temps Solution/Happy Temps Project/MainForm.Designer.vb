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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.compoptBnt = New System.Windows.Forms.Button()
        Me.extBnt = New System.Windows.Forms.Button()
        Me.opt1totLab = New System.Windows.Forms.Label()
        Me.opt2totLab = New System.Windows.Forms.Label()
        Me.opt1LitBox = New System.Windows.Forms.ListBox()
        Me.opt2LitBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Option 1 ($100 per day for 10 days):"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 62)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Option 2 (starts at $1 and then doubles each day for the next 9 days):"
        '
        'compoptBnt
        '
        Me.compoptBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compoptBnt.Location = New System.Drawing.Point(398, 41)
        Me.compoptBnt.Name = "compoptBnt"
        Me.compoptBnt.Size = New System.Drawing.Size(122, 42)
        Me.compoptBnt.TabIndex = 1
        Me.compoptBnt.Text = "&Compare Options"
        Me.compoptBnt.UseVisualStyleBackColor = True
        '
        'extBnt
        '
        Me.extBnt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.extBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extBnt.Location = New System.Drawing.Point(398, 103)
        Me.extBnt.Name = "extBnt"
        Me.extBnt.Size = New System.Drawing.Size(122, 42)
        Me.extBnt.TabIndex = 2
        Me.extBnt.Text = "E&xit"
        Me.extBnt.UseVisualStyleBackColor = True
        '
        'opt1totLab
        '
        Me.opt1totLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.opt1totLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt1totLab.Location = New System.Drawing.Point(15, 103)
        Me.opt1totLab.Name = "opt1totLab"
        Me.opt1totLab.Size = New System.Drawing.Size(94, 26)
        Me.opt1totLab.TabIndex = 0
        '
        'opt2totLab
        '
        Me.opt2totLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.opt2totLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt2totLab.Location = New System.Drawing.Point(240, 103)
        Me.opt2totLab.Name = "opt2totLab"
        Me.opt2totLab.Size = New System.Drawing.Size(94, 26)
        Me.opt2totLab.TabIndex = 0
        '
        'opt1LitBox
        '
        Me.opt1LitBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt1LitBox.FormattingEnabled = True
        Me.opt1LitBox.ItemHeight = 16
        Me.opt1LitBox.Location = New System.Drawing.Point(12, 162)
        Me.opt1LitBox.Name = "opt1LitBox"
        Me.opt1LitBox.Size = New System.Drawing.Size(147, 164)
        Me.opt1LitBox.TabIndex = 0
        Me.opt1LitBox.TabStop = False
        '
        'opt2LitBox
        '
        Me.opt2LitBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt2LitBox.FormattingEnabled = True
        Me.opt2LitBox.ItemHeight = 16
        Me.opt2LitBox.Location = New System.Drawing.Point(240, 162)
        Me.opt2LitBox.Name = "opt2LitBox"
        Me.opt2LitBox.Size = New System.Drawing.Size(152, 164)
        Me.opt2LitBox.TabIndex = 0
        Me.opt2LitBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Daily Pay:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Daily Pay:"
        '
        'MainForm
        '
        Me.AcceptButton = Me.compoptBnt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.extBnt
        Me.ClientSize = New System.Drawing.Size(534, 348)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.opt2LitBox)
        Me.Controls.Add(Me.opt1LitBox)
        Me.Controls.Add(Me.extBnt)
        Me.Controls.Add(Me.compoptBnt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.opt2totLab)
        Me.Controls.Add(Me.opt1totLab)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Happy Temps "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents compoptBnt As System.Windows.Forms.Button
    Friend WithEvents extBnt As System.Windows.Forms.Button
    Friend WithEvents opt1totLab As System.Windows.Forms.Label
    Friend WithEvents opt2totLab As System.Windows.Forms.Label
    Friend WithEvents opt1LitBox As System.Windows.Forms.ListBox
    Friend WithEvents opt2LitBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
