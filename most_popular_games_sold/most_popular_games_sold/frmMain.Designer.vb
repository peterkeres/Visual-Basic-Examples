<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstGameName = New System.Windows.Forms.ComboBox()
        Me.lblGamesSold = New System.Windows.Forms.Label()
        Me.lblNumberGamesSold = New System.Windows.Forms.Label()
        Me.btnTotalDownLoads = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMillion = New System.Windows.Forms.Label()
        Me.lblIncstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstGameName
        '
        Me.lstGameName.FormattingEnabled = True
        Me.lstGameName.Location = New System.Drawing.Point(391, 139)
        Me.lstGameName.Margin = New System.Windows.Forms.Padding(6)
        Me.lstGameName.Name = "lstGameName"
        Me.lstGameName.Size = New System.Drawing.Size(238, 33)
        Me.lstGameName.TabIndex = 0
        '
        'lblGamesSold
        '
        Me.lblGamesSold.AutoSize = True
        Me.lblGamesSold.Location = New System.Drawing.Point(340, 234)
        Me.lblGamesSold.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblGamesSold.Name = "lblGamesSold"
        Me.lblGamesSold.Size = New System.Drawing.Size(135, 25)
        Me.lblGamesSold.TabIndex = 1
        Me.lblGamesSold.Text = "Games Sold:"
        Me.lblGamesSold.Visible = False
        '
        'lblNumberGamesSold
        '
        Me.lblNumberGamesSold.AutoSize = True
        Me.lblNumberGamesSold.Location = New System.Drawing.Point(540, 234)
        Me.lblNumberGamesSold.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNumberGamesSold.Name = "lblNumberGamesSold"
        Me.lblNumberGamesSold.Size = New System.Drawing.Size(78, 25)
        Me.lblNumberGamesSold.TabIndex = 2
        Me.lblNumberGamesSold.Text = "xxxxxx"
        Me.lblNumberGamesSold.Visible = False
        '
        'btnTotalDownLoads
        '
        Me.btnTotalDownLoads.Location = New System.Drawing.Point(375, 358)
        Me.btnTotalDownLoads.Margin = New System.Windows.Forms.Padding(6)
        Me.btnTotalDownLoads.Name = "btnTotalDownLoads"
        Me.btnTotalDownLoads.Size = New System.Drawing.Size(270, 44)
        Me.btnTotalDownLoads.TabIndex = 3
        Me.btnTotalDownLoads.Text = "Total Down Loads"
        Me.btnTotalDownLoads.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(435, 490)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 44)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMillion
        '
        Me.lblMillion.AutoSize = True
        Me.lblMillion.Location = New System.Drawing.Point(626, 234)
        Me.lblMillion.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMillion.Name = "lblMillion"
        Me.lblMillion.Size = New System.Drawing.Size(74, 25)
        Me.lblMillion.TabIndex = 5
        Me.lblMillion.Text = "Million"
        Me.lblMillion.Visible = False
        '
        'lblIncstructions
        '
        Me.lblIncstructions.AutoSize = True
        Me.lblIncstructions.Location = New System.Drawing.Point(203, 62)
        Me.lblIncstructions.Name = "lblIncstructions"
        Me.lblIncstructions.Size = New System.Drawing.Size(607, 25)
        Me.lblIncstructions.TabIndex = 6
        Me.lblIncstructions.Text = "Select the game you wish to see the number of games sold for"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1053, 672)
        Me.Controls.Add(Me.lblIncstructions)
        Me.Controls.Add(Me.lblMillion)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTotalDownLoads)
        Me.Controls.Add(Me.lblNumberGamesSold)
        Me.Controls.Add(Me.lblGamesSold)
        Me.Controls.Add(Me.lstGameName)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmMain"
        Me.Text = "Most Popular Games Sold"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGameName As ComboBox
    Friend WithEvents lblGamesSold As Label
    Friend WithEvents lblNumberGamesSold As Label
    Friend WithEvents btnTotalDownLoads As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMillion As Label
    Friend WithEvents lblIncstructions As Label
End Class
