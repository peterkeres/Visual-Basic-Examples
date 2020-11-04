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
        Me.lethTxtBox = New System.Windows.Forms.TextBox()
        Me.withTxtBox = New System.Windows.Forms.TextBox()
        Me.highTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totsquftLab = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totrolLab = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.calBnt = New System.Windows.Forms.Button()
        Me.extBnt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lethTxtBox
        '
        Me.lethTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lethTxtBox.Location = New System.Drawing.Point(41, 67)
        Me.lethTxtBox.Name = "lethTxtBox"
        Me.lethTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.lethTxtBox.TabIndex = 1
        '
        'withTxtBox
        '
        Me.withTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withTxtBox.Location = New System.Drawing.Point(203, 67)
        Me.withTxtBox.Name = "withTxtBox"
        Me.withTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.withTxtBox.TabIndex = 2
        '
        'highTxtBox
        '
        Me.highTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highTxtBox.Location = New System.Drawing.Point(355, 67)
        Me.highTxtBox.Name = "highTxtBox"
        Me.highTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.highTxtBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Length (feet):"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Width (feet):"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Height (feet):"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total volume feet:"
        '
        'totsquftLab
        '
        Me.totsquftLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totsquftLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totsquftLab.Location = New System.Drawing.Point(91, 146)
        Me.totsquftLab.Name = "totsquftLab"
        Me.totsquftLab.Size = New System.Drawing.Size(137, 23)
        Me.totsquftLab.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Single rolls needed:"
        '
        'totrolLab
        '
        Me.totrolLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totrolLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totrolLab.Location = New System.Drawing.Point(280, 146)
        Me.totrolLab.Name = "totrolLab"
        Me.totrolLab.Size = New System.Drawing.Size(137, 23)
        Me.totrolLab.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "* Each roll is a 1 ft by 1ft by 1 ft sheet *"
        '
        'calBnt
        '
        Me.calBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calBnt.Location = New System.Drawing.Point(100, 208)
        Me.calBnt.Name = "calBnt"
        Me.calBnt.Size = New System.Drawing.Size(126, 39)
        Me.calBnt.TabIndex = 4
        Me.calBnt.Text = "&Calculate"
        Me.calBnt.UseVisualStyleBackColor = True
        '
        'extBnt
        '
        Me.extBnt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.extBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extBnt.Location = New System.Drawing.Point(280, 208)
        Me.extBnt.Name = "extBnt"
        Me.extBnt.Size = New System.Drawing.Size(126, 39)
        Me.extBnt.TabIndex = 5
        Me.extBnt.Text = "E&xit"
        Me.extBnt.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.calBnt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.extBnt
        Me.ClientSize = New System.Drawing.Size(503, 267)
        Me.Controls.Add(Me.extBnt)
        Me.Controls.Add(Me.calBnt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totsquftLab)
        Me.Controls.Add(Me.totrolLab)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.highTxtBox)
        Me.Controls.Add(Me.withTxtBox)
        Me.Controls.Add(Me.lethTxtBox)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wallpaper Warehouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lethTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents withTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents highTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents totsquftLab As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents totrolLab As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents calBnt As System.Windows.Forms.Button
    Friend WithEvents extBnt As System.Windows.Forms.Button

End Class
