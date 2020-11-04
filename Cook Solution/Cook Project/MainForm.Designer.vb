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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totcrehouLab = New System.Windows.Forms.Label()
        Me.gpaLab = New System.Windows.Forms.Label()
        Me.numgraentLab = New System.Windows.Forms.Label()
        Me.entdatBnt = New System.Windows.Forms.Button()
        Me.extBnt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total credit hours:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "GPA:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Number of grades enterd:"
        '
        'totcrehouLab
        '
        Me.totcrehouLab.AutoSize = True
        Me.totcrehouLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totcrehouLab.Location = New System.Drawing.Point(159, 44)
        Me.totcrehouLab.Name = "totcrehouLab"
        Me.totcrehouLab.Size = New System.Drawing.Size(0, 16)
        Me.totcrehouLab.TabIndex = 1
        '
        'gpaLab
        '
        Me.gpaLab.AutoSize = True
        Me.gpaLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpaLab.Location = New System.Drawing.Point(83, 104)
        Me.gpaLab.Name = "gpaLab"
        Me.gpaLab.Size = New System.Drawing.Size(0, 16)
        Me.gpaLab.TabIndex = 1
        '
        'numgraentLab
        '
        Me.numgraentLab.AutoSize = True
        Me.numgraentLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numgraentLab.Location = New System.Drawing.Point(205, 158)
        Me.numgraentLab.Name = "numgraentLab"
        Me.numgraentLab.Size = New System.Drawing.Size(0, 16)
        Me.numgraentLab.TabIndex = 1
        '
        'entdatBnt
        '
        Me.entdatBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entdatBnt.Location = New System.Drawing.Point(54, 215)
        Me.entdatBnt.Name = "entdatBnt"
        Me.entdatBnt.Size = New System.Drawing.Size(106, 38)
        Me.entdatBnt.TabIndex = 2
        Me.entdatBnt.Text = "&Enter Data"
        Me.entdatBnt.UseVisualStyleBackColor = True
        '
        'extBnt
        '
        Me.extBnt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.extBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extBnt.Location = New System.Drawing.Point(166, 215)
        Me.extBnt.Name = "extBnt"
        Me.extBnt.Size = New System.Drawing.Size(106, 38)
        Me.extBnt.TabIndex = 2
        Me.extBnt.Text = "&Exit"
        Me.extBnt.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.entdatBnt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.extBnt
        Me.ClientSize = New System.Drawing.Size(317, 276)
        Me.Controls.Add(Me.extBnt)
        Me.Controls.Add(Me.entdatBnt)
        Me.Controls.Add(Me.numgraentLab)
        Me.Controls.Add(Me.gpaLab)
        Me.Controls.Add(Me.totcrehouLab)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade Point Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totcrehouLab As System.Windows.Forms.Label
    Friend WithEvents gpaLab As System.Windows.Forms.Label
    Friend WithEvents numgraentLab As System.Windows.Forms.Label
    Friend WithEvents entdatBnt As System.Windows.Forms.Button
    Friend WithEvents extBnt As System.Windows.Forms.Button

End Class
