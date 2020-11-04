<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLatteSelection
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picPumpkin = New System.Windows.Forms.PictureBox()
        Me.picMocha = New System.Windows.Forms.PictureBox()
        Me.btnMocha = New System.Windows.Forms.Button()
        Me.btnPumpkin = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(273, 41)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Latte Selection"
        '
        'picPumpkin
        '
        Me.picPumpkin.Location = New System.Drawing.Point(38, 88)
        Me.picPumpkin.Name = "picPumpkin"
        Me.picPumpkin.Size = New System.Drawing.Size(300, 250)
        Me.picPumpkin.TabIndex = 1
        Me.picPumpkin.TabStop = False
        '
        'picMocha
        '
        Me.picMocha.Location = New System.Drawing.Point(377, 88)
        Me.picMocha.Name = "picMocha"
        Me.picMocha.Size = New System.Drawing.Size(300, 250)
        Me.picMocha.TabIndex = 1
        Me.picMocha.TabStop = False
        '
        'btnMocha
        '
        Me.btnMocha.Location = New System.Drawing.Point(461, 373)
        Me.btnMocha.Name = "btnMocha"
        Me.btnMocha.Size = New System.Drawing.Size(162, 23)
        Me.btnMocha.TabIndex = 2
        Me.btnMocha.Text = "Mocha"
        Me.btnMocha.UseVisualStyleBackColor = True
        '
        'btnPumpkin
        '
        Me.btnPumpkin.Location = New System.Drawing.Point(93, 373)
        Me.btnPumpkin.Name = "btnPumpkin"
        Me.btnPumpkin.Size = New System.Drawing.Size(162, 23)
        Me.btnPumpkin.TabIndex = 2
        Me.btnPumpkin.Text = "Pumpkin Spice"
        Me.btnPumpkin.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(277, 373)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(162, 23)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select Latte "
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(198, 419)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(318, 14)
        Me.lblInstructions.TabIndex = 3
        Me.lblInstructions.Text = "Choose a Latte Flavor and then click Select Latte button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(283, 451)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(148, 14)
        Me.lblConfirmation.TabIndex = 3
        Me.lblConfirmation.Text = "Enjoy Your latte selection"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(276, 490)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLatteSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 661)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPumpkin)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnMocha)
        Me.Controls.Add(Me.picMocha)
        Me.Controls.Add(Me.picPumpkin)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmLatteSelection"
        Me.Text = "Latte Selection"
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents picMocha As PictureBox
    Friend WithEvents btnMocha As Button
    Friend WithEvents btnPumpkin As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
