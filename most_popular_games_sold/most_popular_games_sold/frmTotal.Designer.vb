<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotal
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
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.lblUnitSold = New System.Windows.Forms.Label()
        Me.lstGameName = New System.Windows.Forms.ListBox()
        Me.lstGameDownLoads = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblGameTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGameTitle
        '
        Me.lblGameTitle.AutoSize = True
        Me.lblGameTitle.Location = New System.Drawing.Point(285, 37)
        Me.lblGameTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(116, 25)
        Me.lblGameTitle.TabIndex = 0
        Me.lblGameTitle.Text = "Game Title"
        '
        'lblUnitSold
        '
        Me.lblUnitSold.AutoSize = True
        Me.lblUnitSold.Location = New System.Drawing.Point(584, 37)
        Me.lblUnitSold.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblUnitSold.Name = "lblUnitSold"
        Me.lblUnitSold.Size = New System.Drawing.Size(212, 25)
        Me.lblUnitSold.TabIndex = 1
        Me.lblUnitSold.Text = "Units Sold in Millions"
        '
        'lstGameName
        '
        Me.lstGameName.FormattingEnabled = True
        Me.lstGameName.ItemHeight = 25
        Me.lstGameName.Location = New System.Drawing.Point(197, 110)
        Me.lstGameName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstGameName.Name = "lstGameName"
        Me.lstGameName.Size = New System.Drawing.Size(314, 329)
        Me.lstGameName.TabIndex = 2
        '
        'lstGameDownLoads
        '
        Me.lstGameDownLoads.FormattingEnabled = True
        Me.lstGameDownLoads.ItemHeight = 25
        Me.lstGameDownLoads.Location = New System.Drawing.Point(589, 110)
        Me.lstGameDownLoads.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstGameDownLoads.Name = "lstGameDownLoads"
        Me.lstGameDownLoads.Size = New System.Drawing.Size(202, 329)
        Me.lstGameDownLoads.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(335, 489)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(66, 25)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'lblGameTotal
        '
        Me.lblGameTotal.AutoSize = True
        Me.lblGameTotal.Location = New System.Drawing.Point(635, 489)
        Me.lblGameTotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblGameTotal.Name = "lblGameTotal"
        Me.lblGameTotal.Size = New System.Drawing.Size(100, 25)
        Me.lblGameTotal.TabIndex = 5
        Me.lblGameTotal.Text = "xxxxxxxx"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnExit.Location = New System.Drawing.Point(612, 558)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 44)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(290, 547)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 44)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1053, 672)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblGameTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstGameDownLoads)
        Me.Controls.Add(Me.lstGameName)
        Me.Controls.Add(Me.lblUnitSold)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmTotal"
        Me.Text = "Most Popular Games Sold"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGameTitle As Label
    Friend WithEvents lblUnitSold As Label
    Friend WithEvents lstGameName As ListBox
    Friend WithEvents lstGameDownLoads As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblGameTotal As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
End Class
