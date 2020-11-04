<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditFieldGeneral
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
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblGameState = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.lblReleaseDate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtboxGenre = New System.Windows.Forms.TextBox()
        Me.txtboxPublisher = New System.Windows.Forms.TextBox()
        Me.cboxGameState = New System.Windows.Forms.ComboBox()
        Me.txtboxDeveloper = New System.Windows.Forms.TextBox()
        Me.txtboxReleaseDate = New System.Windows.Forms.MaskedTextBox()
        Me.ckboxCoop = New System.Windows.Forms.CheckBox()
        Me.ckboxEarlyAccess = New System.Windows.Forms.CheckBox()
        Me.lblDateStarted = New System.Windows.Forms.Label()
        Me.lblDateLastPlayed = New System.Windows.Forms.Label()
        Me.lblHourCount = New System.Windows.Forms.Label()
        Me.txtboxDateStart = New System.Windows.Forms.MaskedTextBox()
        Me.txtboxDateLast = New System.Windows.Forms.MaskedTextBox()
        Me.txtboxHourCount = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(682, 37)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(54, 16)
        Me.lblGenre.TabIndex = 1
        Me.lblGenre.Text = "Genre:"
        '
        'lblGameState
        '
        Me.lblGameState.AutoSize = True
        Me.lblGameState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameState.Location = New System.Drawing.Point(682, 124)
        Me.lblGameState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGameState.Name = "lblGameState"
        Me.lblGameState.Size = New System.Drawing.Size(93, 16)
        Me.lblGameState.TabIndex = 2
        Me.lblGameState.Text = "Game State:"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.Location = New System.Drawing.Point(49, 37)
        Me.lblPublisher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(77, 16)
        Me.lblPublisher.TabIndex = 3
        Me.lblPublisher.Text = "Publisher:"
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeveloper.Location = New System.Drawing.Point(387, 35)
        Me.lblDeveloper.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(85, 16)
        Me.lblDeveloper.TabIndex = 6
        Me.lblDeveloper.Text = "Developer:"
        '
        'lblReleaseDate
        '
        Me.lblReleaseDate.AutoSize = True
        Me.lblReleaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReleaseDate.Location = New System.Drawing.Point(49, 124)
        Me.lblReleaseDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReleaseDate.Name = "lblReleaseDate"
        Me.lblReleaseDate.Size = New System.Drawing.Size(108, 16)
        Me.lblReleaseDate.TabIndex = 7
        Me.lblReleaseDate.Text = "Release Date:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(257, 339)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(634, 339)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtboxGenre
        '
        Me.txtboxGenre.Location = New System.Drawing.Point(815, 35)
        Me.txtboxGenre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxGenre.Name = "txtboxGenre"
        Me.txtboxGenre.Size = New System.Drawing.Size(132, 22)
        Me.txtboxGenre.TabIndex = 13
        '
        'txtboxPublisher
        '
        Me.txtboxPublisher.Location = New System.Drawing.Point(165, 32)
        Me.txtboxPublisher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxPublisher.Name = "txtboxPublisher"
        Me.txtboxPublisher.Size = New System.Drawing.Size(132, 22)
        Me.txtboxPublisher.TabIndex = 14
        '
        'cboxGameState
        '
        Me.cboxGameState.FormattingEnabled = True
        Me.cboxGameState.Location = New System.Drawing.Point(815, 121)
        Me.cboxGameState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxGameState.Name = "cboxGameState"
        Me.cboxGameState.Size = New System.Drawing.Size(160, 24)
        Me.cboxGameState.TabIndex = 15
        '
        'txtboxDeveloper
        '
        Me.txtboxDeveloper.Location = New System.Drawing.Point(489, 31)
        Me.txtboxDeveloper.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxDeveloper.Name = "txtboxDeveloper"
        Me.txtboxDeveloper.Size = New System.Drawing.Size(132, 22)
        Me.txtboxDeveloper.TabIndex = 16
        '
        'txtboxReleaseDate
        '
        Me.txtboxReleaseDate.Location = New System.Drawing.Point(165, 118)
        Me.txtboxReleaseDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxReleaseDate.Mask = "00/00/0000"
        Me.txtboxReleaseDate.Name = "txtboxReleaseDate"
        Me.txtboxReleaseDate.Size = New System.Drawing.Size(132, 22)
        Me.txtboxReleaseDate.TabIndex = 17
        Me.txtboxReleaseDate.ValidatingType = GetType(Date)
        '
        'ckboxCoop
        '
        Me.ckboxCoop.AutoSize = True
        Me.ckboxCoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckboxCoop.Location = New System.Drawing.Point(49, 195)
        Me.ckboxCoop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckboxCoop.Name = "ckboxCoop"
        Me.ckboxCoop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckboxCoop.Size = New System.Drawing.Size(69, 20)
        Me.ckboxCoop.TabIndex = 18
        Me.ckboxCoop.Text = "Co-op"
        Me.ckboxCoop.UseVisualStyleBackColor = True
        '
        'ckboxEarlyAccess
        '
        Me.ckboxEarlyAccess.AutoSize = True
        Me.ckboxEarlyAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckboxEarlyAccess.Location = New System.Drawing.Point(387, 119)
        Me.ckboxEarlyAccess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckboxEarlyAccess.Name = "ckboxEarlyAccess"
        Me.ckboxEarlyAccess.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckboxEarlyAccess.Size = New System.Drawing.Size(118, 20)
        Me.ckboxEarlyAccess.TabIndex = 20
        Me.ckboxEarlyAccess.Text = "Early Access"
        Me.ckboxEarlyAccess.UseVisualStyleBackColor = True
        '
        'lblDateStarted
        '
        Me.lblDateStarted.AutoSize = True
        Me.lblDateStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateStarted.Location = New System.Drawing.Point(387, 195)
        Me.lblDateStarted.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateStarted.Name = "lblDateStarted"
        Me.lblDateStarted.Size = New System.Drawing.Size(99, 16)
        Me.lblDateStarted.TabIndex = 21
        Me.lblDateStarted.Text = "Date Started:"
        '
        'lblDateLastPlayed
        '
        Me.lblDateLastPlayed.AutoSize = True
        Me.lblDateLastPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateLastPlayed.Location = New System.Drawing.Point(682, 197)
        Me.lblDateLastPlayed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateLastPlayed.Name = "lblDateLastPlayed"
        Me.lblDateLastPlayed.Size = New System.Drawing.Size(127, 16)
        Me.lblDateLastPlayed.TabIndex = 22
        Me.lblDateLastPlayed.Text = "Date Last Played"
        '
        'lblHourCount
        '
        Me.lblHourCount.AutoSize = True
        Me.lblHourCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourCount.Location = New System.Drawing.Point(49, 270)
        Me.lblHourCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHourCount.Name = "lblHourCount"
        Me.lblHourCount.Size = New System.Drawing.Size(84, 16)
        Me.lblHourCount.TabIndex = 23
        Me.lblHourCount.Text = "Hour Count"
        '
        'txtboxDateStart
        '
        Me.txtboxDateStart.Location = New System.Drawing.Point(489, 191)
        Me.txtboxDateStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxDateStart.Mask = "00/00/0000"
        Me.txtboxDateStart.Name = "txtboxDateStart"
        Me.txtboxDateStart.Size = New System.Drawing.Size(132, 22)
        Me.txtboxDateStart.TabIndex = 24
        Me.txtboxDateStart.ValidatingType = GetType(Date)
        '
        'txtboxDateLast
        '
        Me.txtboxDateLast.Location = New System.Drawing.Point(815, 195)
        Me.txtboxDateLast.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxDateLast.Mask = "00/00/0000"
        Me.txtboxDateLast.Name = "txtboxDateLast"
        Me.txtboxDateLast.Size = New System.Drawing.Size(132, 22)
        Me.txtboxDateLast.TabIndex = 25
        Me.txtboxDateLast.ValidatingType = GetType(Date)
        '
        'txtboxHourCount
        '
        Me.txtboxHourCount.Location = New System.Drawing.Point(165, 264)
        Me.txtboxHourCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtboxHourCount.Mask = "000000000"
        Me.txtboxHourCount.Name = "txtboxHourCount"
        Me.txtboxHourCount.Size = New System.Drawing.Size(132, 22)
        Me.txtboxHourCount.TabIndex = 26
        Me.txtboxHourCount.ValidatingType = GetType(Integer)
        '
        'frmEditFieldGeneral
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1013, 376)
        Me.Controls.Add(Me.txtboxHourCount)
        Me.Controls.Add(Me.txtboxDateLast)
        Me.Controls.Add(Me.txtboxDateStart)
        Me.Controls.Add(Me.lblHourCount)
        Me.Controls.Add(Me.lblDateLastPlayed)
        Me.Controls.Add(Me.lblDateStarted)
        Me.Controls.Add(Me.ckboxEarlyAccess)
        Me.Controls.Add(Me.ckboxCoop)
        Me.Controls.Add(Me.txtboxReleaseDate)
        Me.Controls.Add(Me.txtboxDeveloper)
        Me.Controls.Add(Me.cboxGameState)
        Me.Controls.Add(Me.txtboxPublisher)
        Me.Controls.Add(Me.txtboxGenre)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblReleaseDate)
        Me.Controls.Add(Me.lblDeveloper)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.lblGameState)
        Me.Controls.Add(Me.lblGenre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEditFieldGeneral"
        Me.Text = "frmEditFieldGeneral"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblGameState As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents lblReleaseDate As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtboxGenre As TextBox
    Friend WithEvents txtboxPublisher As TextBox
    Friend WithEvents cboxGameState As ComboBox
    Friend WithEvents txtboxDeveloper As TextBox
    Friend WithEvents txtboxReleaseDate As MaskedTextBox
    Friend WithEvents ckboxCoop As CheckBox
    Friend WithEvents ckboxEarlyAccess As CheckBox
    Friend WithEvents lblDateStarted As Label
    Friend WithEvents lblDateLastPlayed As Label
    Friend WithEvents lblHourCount As Label
    Friend WithEvents txtboxDateStart As MaskedTextBox
    Friend WithEvents txtboxDateLast As MaskedTextBox
    Friend WithEvents txtboxHourCount As MaskedTextBox
End Class
