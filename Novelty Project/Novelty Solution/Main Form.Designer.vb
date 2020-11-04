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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxItmPri = New System.Windows.Forms.TextBox()
        Me.labSubTot = New System.Windows.Forms.Label()
        Me.bntCalTot = New System.Windows.Forms.Button()
        Me.bntExt = New System.Windows.Forms.Button()
        Me.labSalTax = New System.Windows.Forms.Label()
        Me.labShi = New System.Windows.Forms.Label()
        Me.labTotDue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Price :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subtotal :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sales Tax :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Shipping :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Due :"
        '
        'txtboxItmPri
        '
        Me.txtboxItmPri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxItmPri.Location = New System.Drawing.Point(100, 57)
        Me.txtboxItmPri.Multiline = True
        Me.txtboxItmPri.Name = "txtboxItmPri"
        Me.txtboxItmPri.Size = New System.Drawing.Size(137, 22)
        Me.txtboxItmPri.TabIndex = 1
        '
        'labSubTot
        '
        Me.labSubTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labSubTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSubTot.Location = New System.Drawing.Point(149, 144)
        Me.labSubTot.Name = "labSubTot"
        Me.labSubTot.Size = New System.Drawing.Size(100, 23)
        Me.labSubTot.TabIndex = 0
        Me.labSubTot.Text = " "
        '
        'bntCalTot
        '
        Me.bntCalTot.Location = New System.Drawing.Point(280, 24)
        Me.bntCalTot.Name = "bntCalTot"
        Me.bntCalTot.Size = New System.Drawing.Size(96, 40)
        Me.bntCalTot.TabIndex = 2
        Me.bntCalTot.Text = "&Calculate Total"
        Me.bntCalTot.UseVisualStyleBackColor = True
        '
        'bntExt
        '
        Me.bntExt.Location = New System.Drawing.Point(280, 77)
        Me.bntExt.Name = "bntExt"
        Me.bntExt.Size = New System.Drawing.Size(96, 40)
        Me.bntExt.TabIndex = 3
        Me.bntExt.Text = "&Exit"
        Me.bntExt.UseVisualStyleBackColor = True
        '
        'labSalTax
        '
        Me.labSalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labSalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSalTax.Location = New System.Drawing.Point(149, 183)
        Me.labSalTax.Name = "labSalTax"
        Me.labSalTax.Size = New System.Drawing.Size(100, 23)
        Me.labSalTax.TabIndex = 0
        Me.labSalTax.Text = " "
        '
        'labShi
        '
        Me.labShi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labShi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labShi.Location = New System.Drawing.Point(149, 221)
        Me.labShi.Name = "labShi"
        Me.labShi.Size = New System.Drawing.Size(100, 23)
        Me.labShi.TabIndex = 0
        Me.labShi.Text = " "
        '
        'labTotDue
        '
        Me.labTotDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labTotDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotDue.Location = New System.Drawing.Point(149, 274)
        Me.labTotDue.Name = "labTotDue"
        Me.labTotDue.Size = New System.Drawing.Size(100, 23)
        Me.labTotDue.TabIndex = 0
        Me.labTotDue.Text = " "
        '
        'MainForm
        '
        Me.AcceptButton = Me.bntCalTot
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 322)
        Me.Controls.Add(Me.bntExt)
        Me.Controls.Add(Me.bntCalTot)
        Me.Controls.Add(Me.txtboxItmPri)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labTotDue)
        Me.Controls.Add(Me.labShi)
        Me.Controls.Add(Me.labSalTax)
        Me.Controls.Add(Me.labSubTot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novelty Warehouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtboxItmPri As System.Windows.Forms.TextBox
    Friend WithEvents labSubTot As System.Windows.Forms.Label
    Friend WithEvents bntCalTot As System.Windows.Forms.Button
    Friend WithEvents bntExt As System.Windows.Forms.Button
    Friend WithEvents labSalTax As System.Windows.Forms.Label
    Friend WithEvents labShi As System.Windows.Forms.Label
    Friend WithEvents labTotDue As System.Windows.Forms.Label

End Class
