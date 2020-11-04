<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEntry
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtboxTitle = New System.Windows.Forms.TextBox()
        Me.txtboxGenre = New System.Windows.Forms.TextBox()
        Me.txtboxPublisher = New System.Windows.Forms.TextBox()
        Me.txtboxDeveloper = New System.Windows.Forms.TextBox()
        Me.ckboxCoop = New System.Windows.Forms.CheckBox()
        Me.ckboxEarlyAccess = New System.Windows.Forms.CheckBox()
        Me.cboxGameState = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(64, 62)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 15)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(520, 148)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(50, 15)
        Me.lblGenre.TabIndex = 1
        Me.lblGenre.Text = "Genre:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(157, 148)
        Me.lblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(86, 15)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "Game State:"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.Location = New System.Drawing.Point(318, 62)
        Me.lblPublisher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(72, 15)
        Me.lblPublisher.TabIndex = 3
        Me.lblPublisher.Text = "Publisher:"
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeveloper.Location = New System.Drawing.Point(568, 62)
        Me.lblDeveloper.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(76, 15)
        Me.lblDeveloper.TabIndex = 4
        Me.lblDeveloper.Text = "Developer:"
        '
        'btnSubmit
        '
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.Location = New System.Drawing.Point(292, 285)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(88, 26)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(523, 285)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 26)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtboxTitle
        '
        Me.txtboxTitle.Location = New System.Drawing.Point(106, 58)
        Me.txtboxTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxTitle.Name = "txtboxTitle"
        Me.txtboxTitle.Size = New System.Drawing.Size(116, 21)
        Me.txtboxTitle.TabIndex = 12
        '
        'txtboxGenre
        '
        Me.txtboxGenre.Location = New System.Drawing.Point(571, 145)
        Me.txtboxGenre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxGenre.Name = "txtboxGenre"
        Me.txtboxGenre.Size = New System.Drawing.Size(116, 21)
        Me.txtboxGenre.TabIndex = 13
        '
        'txtboxPublisher
        '
        Me.txtboxPublisher.Location = New System.Drawing.Point(398, 58)
        Me.txtboxPublisher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxPublisher.Name = "txtboxPublisher"
        Me.txtboxPublisher.Size = New System.Drawing.Size(116, 21)
        Me.txtboxPublisher.TabIndex = 14
        '
        'txtboxDeveloper
        '
        Me.txtboxDeveloper.Location = New System.Drawing.Point(644, 58)
        Me.txtboxDeveloper.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxDeveloper.Name = "txtboxDeveloper"
        Me.txtboxDeveloper.Size = New System.Drawing.Size(116, 21)
        Me.txtboxDeveloper.TabIndex = 15
        '
        'ckboxCoop
        '
        Me.ckboxCoop.AutoSize = True
        Me.ckboxCoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckboxCoop.Location = New System.Drawing.Point(319, 212)
        Me.ckboxCoop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckboxCoop.Name = "ckboxCoop"
        Me.ckboxCoop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckboxCoop.Size = New System.Drawing.Size(64, 19)
        Me.ckboxCoop.TabIndex = 18
        Me.ckboxCoop.Text = "Co-op"
        Me.ckboxCoop.UseVisualStyleBackColor = True
        '
        'ckboxEarlyAccess
        '
        Me.ckboxEarlyAccess.AutoSize = True
        Me.ckboxEarlyAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckboxEarlyAccess.Location = New System.Drawing.Point(459, 212)
        Me.ckboxEarlyAccess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckboxEarlyAccess.Name = "ckboxEarlyAccess"
        Me.ckboxEarlyAccess.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckboxEarlyAccess.Size = New System.Drawing.Size(106, 19)
        Me.ckboxEarlyAccess.TabIndex = 20
        Me.ckboxEarlyAccess.Text = "Early Access"
        Me.ckboxEarlyAccess.UseVisualStyleBackColor = True
        '
        'cboxGameState
        '
        Me.cboxGameState.FormattingEnabled = True
        Me.cboxGameState.Location = New System.Drawing.Point(250, 145)
        Me.cboxGameState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxGameState.Name = "cboxGameState"
        Me.cboxGameState.Size = New System.Drawing.Size(140, 23)
        Me.cboxGameState.TabIndex = 21
        '
        'frmNewEntry
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(898, 362)
        Me.Controls.Add(Me.cboxGameState)
        Me.Controls.Add(Me.ckboxEarlyAccess)
        Me.Controls.Add(Me.ckboxCoop)
        Me.Controls.Add(Me.txtboxDeveloper)
        Me.Controls.Add(Me.txtboxPublisher)
        Me.Controls.Add(Me.txtboxGenre)
        Me.Controls.Add(Me.txtboxTitle)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDeveloper)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmNewEntry"
        Me.Text = "Create New Entry Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtboxTitle As TextBox
    Friend WithEvents txtboxGenre As TextBox
    Friend WithEvents txtboxPublisher As TextBox
    Friend WithEvents txtboxDeveloper As TextBox
    Friend WithEvents ckboxCoop As CheckBox
    Friend WithEvents ckboxEarlyAccess As CheckBox
    Friend WithEvents cboxGameState As ComboBox
End Class
