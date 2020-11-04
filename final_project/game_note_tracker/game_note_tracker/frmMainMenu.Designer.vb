<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstRecentEntries = New System.Windows.Forms.ListBox()
        Me.txtUserGameSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblContactVersionNum = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRecentEntrie = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstRecentEntries
        '
        Me.lstRecentEntries.BackColor = System.Drawing.SystemColors.Window
        Me.lstRecentEntries.FormattingEnabled = True
        Me.lstRecentEntries.ItemHeight = 16
        Me.lstRecentEntries.Location = New System.Drawing.Point(2, 30)
        Me.lstRecentEntries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstRecentEntries.Name = "lstRecentEntries"
        Me.lstRecentEntries.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstRecentEntries.Size = New System.Drawing.Size(258, 340)
        Me.lstRecentEntries.TabIndex = 0
        '
        'txtUserGameSearch
        '
        Me.txtUserGameSearch.Location = New System.Drawing.Point(365, 86)
        Me.txtUserGameSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserGameSearch.Name = "txtUserGameSearch"
        Me.txtUserGameSearch.Size = New System.Drawing.Size(390, 22)
        Me.txtUserGameSearch.TabIndex = 1
        Me.txtUserGameSearch.Text = "Enter a game title"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(507, 162)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnCreateNew
        '
        Me.btnCreateNew.Location = New System.Drawing.Point(363, 258)
        Me.btnCreateNew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(100, 28)
        Me.btnCreateNew.TabIndex = 3
        Me.btnCreateNew.Text = "Create New"
        Me.btnCreateNew.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(653, 258)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblContactVersionNum
        '
        Me.lblContactVersionNum.AutoSize = True
        Me.lblContactVersionNum.Location = New System.Drawing.Point(379, 358)
        Me.lblContactVersionNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactVersionNum.Name = "lblContactVersionNum"
        Me.lblContactVersionNum.Size = New System.Drawing.Size(332, 16)
        Me.lblContactVersionNum.TabIndex = 5
        Me.lblContactVersionNum.Text = "Email: PeterNKeres@gmail.com   version number: v1.0"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(475, 30)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(165, 20)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Game Note Tracker"
        '
        'lblRecentEntrie
        '
        Me.lblRecentEntrie.AutoSize = True
        Me.lblRecentEntrie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentEntrie.Location = New System.Drawing.Point(63, 10)
        Me.lblRecentEntrie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecentEntrie.Name = "lblRecentEntrie"
        Me.lblRecentEntrie.Size = New System.Drawing.Size(124, 16)
        Me.lblRecentEntrie.TabIndex = 7
        Me.lblRecentEntrie.Text = "Recent Entry List"
        '
        'frmMainMenu
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(952, 386)
        Me.Controls.Add(Me.lblRecentEntrie)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblContactVersionNum)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreateNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtUserGameSearch)
        Me.Controls.Add(Me.lstRecentEntries)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Game Note Tracker App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRecentEntries As ListBox
    Friend WithEvents txtUserGameSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCreateNew As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblContactVersionNum As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRecentEntrie As Label
End Class
