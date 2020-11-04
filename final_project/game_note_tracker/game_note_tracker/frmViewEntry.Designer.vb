<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewEntry
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabpGeneral = New System.Windows.Forms.TabPage()
        Me.txtState = New System.Windows.Forms.Label()
        Me.txtHourCount = New System.Windows.Forms.Label()
        Me.txtDateLastPlayed = New System.Windows.Forms.Label()
        Me.txtDateStarted = New System.Windows.Forms.Label()
        Me.txtCoop = New System.Windows.Forms.Label()
        Me.txtGenra = New System.Windows.Forms.Label()
        Me.txtEarlyAccess = New System.Windows.Forms.Label()
        Me.txtReleaseDate = New System.Windows.Forms.Label()
        Me.txtdevelpor = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblHourCount = New System.Windows.Forms.Label()
        Me.lblDateLastPlayed = New System.Windows.Forms.Label()
        Me.lblDateStarted = New System.Windows.Forms.Label()
        Me.lblCoop = New System.Windows.Forms.Label()
        Me.lblGenra = New System.Windows.Forms.Label()
        Me.lblEarlyAccess = New System.Windows.Forms.Label()
        Me.lblReleaseDate = New System.Windows.Forms.Label()
        Me.lblDevelpor = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabStory = New System.Windows.Forms.TabPage()
        Me.tabControllStory = New System.Windows.Forms.TabControl()
        Me.tabStoryEvents = New System.Windows.Forms.TabPage()
        Me.txtStoryEvents = New System.Windows.Forms.Label()
        Me.tabStoryCharacters = New System.Windows.Forms.TabPage()
        Me.txtStoryCharacters = New System.Windows.Forms.Label()
        Me.tabStoryWorld = New System.Windows.Forms.TabPage()
        Me.txtStoryWorld = New System.Windows.Forms.Label()
        Me.tabStoryThoughts = New System.Windows.Forms.TabPage()
        Me.txtStoryThoughts = New System.Windows.Forms.Label()
        Me.tabStoryToDoList = New System.Windows.Forms.TabPage()
        Me.txtStoryToDoList = New System.Windows.Forms.Label()
        Me.tabGamePlay = New System.Windows.Forms.TabPage()
        Me.tabControllGamePlay = New System.Windows.Forms.TabControl()
        Me.tabGamePlayMechanics = New System.Windows.Forms.TabPage()
        Me.txtGamePlayMechanics = New System.Windows.Forms.Label()
        Me.tabGamePlayToDoList = New System.Windows.Forms.TabPage()
        Me.txtGamePlayToDoList = New System.Windows.Forms.Label()
        Me.tabGamePlayThoughts = New System.Windows.Forms.TabPage()
        Me.txtGamePlayThoughts = New System.Windows.Forms.Label()
        Me.tabGamePlayStrategy = New System.Windows.Forms.TabPage()
        Me.txtGamePlayStrategy = New System.Windows.Forms.Label()
        Me.tabOnline = New System.Windows.Forms.TabPage()
        Me.tabControllerOnline = New System.Windows.Forms.TabControl()
        Me.tabOnlinePeople = New System.Windows.Forms.TabPage()
        Me.txtOnlinePeople = New System.Windows.Forms.Label()
        Me.tabOnlineGuild = New System.Windows.Forms.TabPage()
        Me.txtOnlineGuild = New System.Windows.Forms.Label()
        Me.tabOnlineEvents = New System.Windows.Forms.TabPage()
        Me.txtOnlineEvents = New System.Windows.Forms.Label()
        Me.tabOnlineToDoList = New System.Windows.Forms.TabPage()
        Me.txtOnlineToDoList = New System.Windows.Forms.Label()
        Me.tabOnlineThoughts = New System.Windows.Forms.TabPage()
        Me.txtOnlineThoughts = New System.Windows.Forms.Label()
        Me.tabReview = New System.Windows.Forms.TabPage()
        Me.txtReview = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.tabpGeneral.SuspendLayout()
        Me.tabStory.SuspendLayout()
        Me.tabControllStory.SuspendLayout()
        Me.tabStoryEvents.SuspendLayout()
        Me.tabStoryCharacters.SuspendLayout()
        Me.tabStoryWorld.SuspendLayout()
        Me.tabStoryThoughts.SuspendLayout()
        Me.tabStoryToDoList.SuspendLayout()
        Me.tabGamePlay.SuspendLayout()
        Me.tabControllGamePlay.SuspendLayout()
        Me.tabGamePlayMechanics.SuspendLayout()
        Me.tabGamePlayToDoList.SuspendLayout()
        Me.tabGamePlayThoughts.SuspendLayout()
        Me.tabGamePlayStrategy.SuspendLayout()
        Me.tabOnline.SuspendLayout()
        Me.tabControllerOnline.SuspendLayout()
        Me.tabOnlinePeople.SuspendLayout()
        Me.tabOnlineGuild.SuspendLayout()
        Me.tabOnlineEvents.SuspendLayout()
        Me.tabOnlineToDoList.SuspendLayout()
        Me.tabOnlineThoughts.SuspendLayout()
        Me.tabReview.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabpGeneral)
        Me.TabControl.Controls.Add(Me.tabStory)
        Me.TabControl.Controls.Add(Me.tabGamePlay)
        Me.TabControl.Controls.Add(Me.tabOnline)
        Me.TabControl.Controls.Add(Me.tabReview)
        Me.TabControl.Location = New System.Drawing.Point(0, 1)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(974, 565)
        Me.TabControl.TabIndex = 0
        '
        'tabpGeneral
        '
        Me.tabpGeneral.AutoScroll = True
        Me.tabpGeneral.BackColor = System.Drawing.SystemColors.Window
        Me.tabpGeneral.Controls.Add(Me.txtState)
        Me.tabpGeneral.Controls.Add(Me.txtHourCount)
        Me.tabpGeneral.Controls.Add(Me.txtDateLastPlayed)
        Me.tabpGeneral.Controls.Add(Me.txtDateStarted)
        Me.tabpGeneral.Controls.Add(Me.txtCoop)
        Me.tabpGeneral.Controls.Add(Me.txtGenra)
        Me.tabpGeneral.Controls.Add(Me.txtEarlyAccess)
        Me.tabpGeneral.Controls.Add(Me.txtReleaseDate)
        Me.tabpGeneral.Controls.Add(Me.txtdevelpor)
        Me.tabpGeneral.Controls.Add(Me.txtPublisher)
        Me.tabpGeneral.Controls.Add(Me.txtTitle)
        Me.tabpGeneral.Controls.Add(Me.lblState)
        Me.tabpGeneral.Controls.Add(Me.lblHourCount)
        Me.tabpGeneral.Controls.Add(Me.lblDateLastPlayed)
        Me.tabpGeneral.Controls.Add(Me.lblDateStarted)
        Me.tabpGeneral.Controls.Add(Me.lblCoop)
        Me.tabpGeneral.Controls.Add(Me.lblGenra)
        Me.tabpGeneral.Controls.Add(Me.lblEarlyAccess)
        Me.tabpGeneral.Controls.Add(Me.lblReleaseDate)
        Me.tabpGeneral.Controls.Add(Me.lblDevelpor)
        Me.tabpGeneral.Controls.Add(Me.lblPublisher)
        Me.tabpGeneral.Controls.Add(Me.lblTitle)
        Me.tabpGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpGeneral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpGeneral.Name = "tabpGeneral"
        Me.tabpGeneral.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpGeneral.Size = New System.Drawing.Size(966, 536)
        Me.tabpGeneral.TabIndex = 0
        Me.tabpGeneral.Text = "General"
        '
        'txtState
        '
        Me.txtState.AutoSize = True
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Location = New System.Drawing.Point(379, 396)
        Me.txtState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(64, 18)
        Me.txtState.TabIndex = 21
        Me.txtState.Text = "xxxxxxxxx"
        '
        'txtHourCount
        '
        Me.txtHourCount.AutoSize = True
        Me.txtHourCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHourCount.Location = New System.Drawing.Point(164, 396)
        Me.txtHourCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtHourCount.Name = "txtHourCount"
        Me.txtHourCount.Size = New System.Drawing.Size(94, 18)
        Me.txtHourCount.TabIndex = 20
        Me.txtHourCount.Text = "xxxxxxxxxxxxxx"
        '
        'txtDateLastPlayed
        '
        Me.txtDateLastPlayed.AutoSize = True
        Me.txtDateLastPlayed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateLastPlayed.Location = New System.Drawing.Point(724, 273)
        Me.txtDateLastPlayed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtDateLastPlayed.Name = "txtDateLastPlayed"
        Me.txtDateLastPlayed.Size = New System.Drawing.Size(64, 18)
        Me.txtDateLastPlayed.TabIndex = 19
        Me.txtDateLastPlayed.Text = "xxxxxxxxx"
        '
        'txtDateStarted
        '
        Me.txtDateStarted.AutoSize = True
        Me.txtDateStarted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateStarted.Location = New System.Drawing.Point(425, 273)
        Me.txtDateStarted.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtDateStarted.Name = "txtDateStarted"
        Me.txtDateStarted.Size = New System.Drawing.Size(88, 18)
        Me.txtDateStarted.TabIndex = 18
        Me.txtDateStarted.Text = "xxxxxxxxxxxxx"
        '
        'txtCoop
        '
        Me.txtCoop.AutoSize = True
        Me.txtCoop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCoop.Location = New System.Drawing.Point(129, 273)
        Me.txtCoop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtCoop.Name = "txtCoop"
        Me.txtCoop.Size = New System.Drawing.Size(64, 18)
        Me.txtCoop.TabIndex = 17
        Me.txtCoop.Text = "xxxxxxxxx"
        '
        'txtGenra
        '
        Me.txtGenra.AutoSize = True
        Me.txtGenra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenra.Location = New System.Drawing.Point(655, 150)
        Me.txtGenra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtGenra.Name = "txtGenra"
        Me.txtGenra.Size = New System.Drawing.Size(76, 18)
        Me.txtGenra.TabIndex = 16
        Me.txtGenra.Text = "xxxxxxxxxxx"
        '
        'txtEarlyAccess
        '
        Me.txtEarlyAccess.AutoSize = True
        Me.txtEarlyAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEarlyAccess.Location = New System.Drawing.Point(425, 150)
        Me.txtEarlyAccess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtEarlyAccess.Name = "txtEarlyAccess"
        Me.txtEarlyAccess.Size = New System.Drawing.Size(76, 18)
        Me.txtEarlyAccess.TabIndex = 15
        Me.txtEarlyAccess.Text = "xxxxxxxxxxx"
        '
        'txtReleaseDate
        '
        Me.txtReleaseDate.AutoSize = True
        Me.txtReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReleaseDate.Location = New System.Drawing.Point(179, 150)
        Me.txtReleaseDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtReleaseDate.Name = "txtReleaseDate"
        Me.txtReleaseDate.Size = New System.Drawing.Size(58, 18)
        Me.txtReleaseDate.TabIndex = 14
        Me.txtReleaseDate.Text = "xxxxxxxx"
        '
        'txtdevelpor
        '
        Me.txtdevelpor.AutoSize = True
        Me.txtdevelpor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdevelpor.Location = New System.Drawing.Point(669, 52)
        Me.txtdevelpor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtdevelpor.Name = "txtdevelpor"
        Me.txtdevelpor.Size = New System.Drawing.Size(100, 18)
        Me.txtdevelpor.TabIndex = 13
        Me.txtdevelpor.Text = "xxxxxxxxxxxxxxx"
        '
        'txtPublisher
        '
        Me.txtPublisher.AutoSize = True
        Me.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPublisher.Location = New System.Drawing.Point(403, 52)
        Me.txtPublisher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(58, 18)
        Me.txtPublisher.TabIndex = 12
        Me.txtPublisher.Text = "xxxxxxxx"
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTitle.Location = New System.Drawing.Point(119, 52)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(70, 18)
        Me.txtTitle.TabIndex = 11
        Me.txtTitle.Text = "xxxxxxxxxx"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(328, 396)
        Me.lblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(44, 16)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "State"
        '
        'lblHourCount
        '
        Me.lblHourCount.AutoSize = True
        Me.lblHourCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourCount.Location = New System.Drawing.Point(75, 396)
        Me.lblHourCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHourCount.Name = "lblHourCount"
        Me.lblHourCount.Size = New System.Drawing.Size(84, 16)
        Me.lblHourCount.TabIndex = 9
        Me.lblHourCount.Text = "Hour Count"
        '
        'lblDateLastPlayed
        '
        Me.lblDateLastPlayed.AutoSize = True
        Me.lblDateLastPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateLastPlayed.Location = New System.Drawing.Point(599, 273)
        Me.lblDateLastPlayed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateLastPlayed.Name = "lblDateLastPlayed"
        Me.lblDateLastPlayed.Size = New System.Drawing.Size(127, 16)
        Me.lblDateLastPlayed.TabIndex = 8
        Me.lblDateLastPlayed.Text = "Date Last Played"
        '
        'lblDateStarted
        '
        Me.lblDateStarted.AutoSize = True
        Me.lblDateStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateStarted.Location = New System.Drawing.Point(328, 273)
        Me.lblDateStarted.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateStarted.Name = "lblDateStarted"
        Me.lblDateStarted.Size = New System.Drawing.Size(95, 16)
        Me.lblDateStarted.TabIndex = 7
        Me.lblDateStarted.Text = "Date Started"
        '
        'lblCoop
        '
        Me.lblCoop.AutoSize = True
        Me.lblCoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoop.Location = New System.Drawing.Point(75, 273)
        Me.lblCoop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCoop.Name = "lblCoop"
        Me.lblCoop.Size = New System.Drawing.Size(50, 16)
        Me.lblCoop.TabIndex = 6
        Me.lblCoop.Text = "Co-op"
        '
        'lblGenra
        '
        Me.lblGenra.AutoSize = True
        Me.lblGenra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenra.Location = New System.Drawing.Point(599, 150)
        Me.lblGenra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenra.Name = "lblGenra"
        Me.lblGenra.Size = New System.Drawing.Size(50, 16)
        Me.lblGenra.TabIndex = 5
        Me.lblGenra.Text = "Genra"
        '
        'lblEarlyAccess
        '
        Me.lblEarlyAccess.AutoSize = True
        Me.lblEarlyAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEarlyAccess.Location = New System.Drawing.Point(328, 150)
        Me.lblEarlyAccess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEarlyAccess.Name = "lblEarlyAccess"
        Me.lblEarlyAccess.Size = New System.Drawing.Size(99, 16)
        Me.lblEarlyAccess.TabIndex = 4
        Me.lblEarlyAccess.Text = "Early Access"
        '
        'lblReleaseDate
        '
        Me.lblReleaseDate.AutoSize = True
        Me.lblReleaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReleaseDate.Location = New System.Drawing.Point(75, 150)
        Me.lblReleaseDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReleaseDate.Name = "lblReleaseDate"
        Me.lblReleaseDate.Size = New System.Drawing.Size(104, 16)
        Me.lblReleaseDate.TabIndex = 3
        Me.lblReleaseDate.Text = "Release Date"
        '
        'lblDevelpor
        '
        Me.lblDevelpor.AutoSize = True
        Me.lblDevelpor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevelpor.Location = New System.Drawing.Point(599, 52)
        Me.lblDevelpor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDevelpor.Name = "lblDevelpor"
        Me.lblDevelpor.Size = New System.Drawing.Size(72, 16)
        Me.lblDevelpor.TabIndex = 2
        Me.lblDevelpor.Text = "Develpor"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.Location = New System.Drawing.Point(328, 52)
        Me.lblPublisher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(73, 16)
        Me.lblPublisher.TabIndex = 1
        Me.lblPublisher.Text = "Publisher"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(75, 52)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(43, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'tabStory
        '
        Me.tabStory.AutoScroll = True
        Me.tabStory.Controls.Add(Me.tabControllStory)
        Me.tabStory.Location = New System.Drawing.Point(4, 25)
        Me.tabStory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStory.Name = "tabStory"
        Me.tabStory.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStory.Size = New System.Drawing.Size(966, 536)
        Me.tabStory.TabIndex = 1
        Me.tabStory.Text = "Story"
        Me.tabStory.UseVisualStyleBackColor = True
        '
        'tabControllStory
        '
        Me.tabControllStory.Controls.Add(Me.tabStoryEvents)
        Me.tabControllStory.Controls.Add(Me.tabStoryCharacters)
        Me.tabControllStory.Controls.Add(Me.tabStoryWorld)
        Me.tabControllStory.Controls.Add(Me.tabStoryThoughts)
        Me.tabControllStory.Controls.Add(Me.tabStoryToDoList)
        Me.tabControllStory.Location = New System.Drawing.Point(8, 7)
        Me.tabControllStory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabControllStory.Name = "tabControllStory"
        Me.tabControllStory.SelectedIndex = 0
        Me.tabControllStory.Size = New System.Drawing.Size(954, 509)
        Me.tabControllStory.TabIndex = 0
        '
        'tabStoryEvents
        '
        Me.tabStoryEvents.AutoScroll = True
        Me.tabStoryEvents.Controls.Add(Me.txtStoryEvents)
        Me.tabStoryEvents.Location = New System.Drawing.Point(4, 25)
        Me.tabStoryEvents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryEvents.Name = "tabStoryEvents"
        Me.tabStoryEvents.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryEvents.Size = New System.Drawing.Size(946, 480)
        Me.tabStoryEvents.TabIndex = 0
        Me.tabStoryEvents.Text = "Events"
        Me.tabStoryEvents.UseVisualStyleBackColor = True
        '
        'txtStoryEvents
        '
        Me.txtStoryEvents.AutoSize = True
        Me.txtStoryEvents.Location = New System.Drawing.Point(9, 9)
        Me.txtStoryEvents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtStoryEvents.Name = "txtStoryEvents"
        Me.txtStoryEvents.Size = New System.Drawing.Size(49, 16)
        Me.txtStoryEvents.TabIndex = 0
        Me.txtStoryEvents.Text = "Label1"
        '
        'tabStoryCharacters
        '
        Me.tabStoryCharacters.AutoScroll = True
        Me.tabStoryCharacters.Controls.Add(Me.txtStoryCharacters)
        Me.tabStoryCharacters.Location = New System.Drawing.Point(4, 25)
        Me.tabStoryCharacters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryCharacters.Name = "tabStoryCharacters"
        Me.tabStoryCharacters.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryCharacters.Size = New System.Drawing.Size(919, 480)
        Me.tabStoryCharacters.TabIndex = 1
        Me.tabStoryCharacters.Text = "Characters"
        Me.tabStoryCharacters.UseVisualStyleBackColor = True
        '
        'txtStoryCharacters
        '
        Me.txtStoryCharacters.AutoSize = True
        Me.txtStoryCharacters.Location = New System.Drawing.Point(9, 9)
        Me.txtStoryCharacters.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtStoryCharacters.Name = "txtStoryCharacters"
        Me.txtStoryCharacters.Size = New System.Drawing.Size(49, 16)
        Me.txtStoryCharacters.TabIndex = 0
        Me.txtStoryCharacters.Text = "Label1"
        '
        'tabStoryWorld
        '
        Me.tabStoryWorld.AutoScroll = True
        Me.tabStoryWorld.Controls.Add(Me.txtStoryWorld)
        Me.tabStoryWorld.Location = New System.Drawing.Point(4, 25)
        Me.tabStoryWorld.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryWorld.Name = "tabStoryWorld"
        Me.tabStoryWorld.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryWorld.Size = New System.Drawing.Size(919, 480)
        Me.tabStoryWorld.TabIndex = 2
        Me.tabStoryWorld.Text = "World"
        Me.tabStoryWorld.UseVisualStyleBackColor = True
        '
        'txtStoryWorld
        '
        Me.txtStoryWorld.AutoSize = True
        Me.txtStoryWorld.Location = New System.Drawing.Point(9, 9)
        Me.txtStoryWorld.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtStoryWorld.Name = "txtStoryWorld"
        Me.txtStoryWorld.Size = New System.Drawing.Size(49, 16)
        Me.txtStoryWorld.TabIndex = 0
        Me.txtStoryWorld.Text = "Label1"
        '
        'tabStoryThoughts
        '
        Me.tabStoryThoughts.AutoScroll = True
        Me.tabStoryThoughts.Controls.Add(Me.txtStoryThoughts)
        Me.tabStoryThoughts.Location = New System.Drawing.Point(4, 25)
        Me.tabStoryThoughts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryThoughts.Name = "tabStoryThoughts"
        Me.tabStoryThoughts.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryThoughts.Size = New System.Drawing.Size(919, 480)
        Me.tabStoryThoughts.TabIndex = 3
        Me.tabStoryThoughts.Text = "Thoughts"
        Me.tabStoryThoughts.UseVisualStyleBackColor = True
        '
        'txtStoryThoughts
        '
        Me.txtStoryThoughts.AutoSize = True
        Me.txtStoryThoughts.Location = New System.Drawing.Point(9, 9)
        Me.txtStoryThoughts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtStoryThoughts.Name = "txtStoryThoughts"
        Me.txtStoryThoughts.Size = New System.Drawing.Size(49, 16)
        Me.txtStoryThoughts.TabIndex = 0
        Me.txtStoryThoughts.Text = "Label1"
        '
        'tabStoryToDoList
        '
        Me.tabStoryToDoList.AutoScroll = True
        Me.tabStoryToDoList.Controls.Add(Me.txtStoryToDoList)
        Me.tabStoryToDoList.Location = New System.Drawing.Point(4, 25)
        Me.tabStoryToDoList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryToDoList.Name = "tabStoryToDoList"
        Me.tabStoryToDoList.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabStoryToDoList.Size = New System.Drawing.Size(919, 480)
        Me.tabStoryToDoList.TabIndex = 4
        Me.tabStoryToDoList.Text = "To Do List"
        Me.tabStoryToDoList.UseVisualStyleBackColor = True
        '
        'txtStoryToDoList
        '
        Me.txtStoryToDoList.AutoSize = True
        Me.txtStoryToDoList.Location = New System.Drawing.Point(9, 9)
        Me.txtStoryToDoList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtStoryToDoList.Name = "txtStoryToDoList"
        Me.txtStoryToDoList.Size = New System.Drawing.Size(49, 16)
        Me.txtStoryToDoList.TabIndex = 0
        Me.txtStoryToDoList.Text = "Label1"
        '
        'tabGamePlay
        '
        Me.tabGamePlay.AutoScroll = True
        Me.tabGamePlay.Controls.Add(Me.tabControllGamePlay)
        Me.tabGamePlay.Location = New System.Drawing.Point(4, 25)
        Me.tabGamePlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlay.Name = "tabGamePlay"
        Me.tabGamePlay.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlay.Size = New System.Drawing.Size(966, 536)
        Me.tabGamePlay.TabIndex = 2
        Me.tabGamePlay.Text = "Game Play"
        Me.tabGamePlay.UseVisualStyleBackColor = True
        '
        'tabControllGamePlay
        '
        Me.tabControllGamePlay.Controls.Add(Me.tabGamePlayMechanics)
        Me.tabControllGamePlay.Controls.Add(Me.tabGamePlayToDoList)
        Me.tabControllGamePlay.Controls.Add(Me.tabGamePlayThoughts)
        Me.tabControllGamePlay.Controls.Add(Me.tabGamePlayStrategy)
        Me.tabControllGamePlay.Location = New System.Drawing.Point(5, 9)
        Me.tabControllGamePlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabControllGamePlay.Name = "tabControllGamePlay"
        Me.tabControllGamePlay.SelectedIndex = 0
        Me.tabControllGamePlay.Size = New System.Drawing.Size(952, 508)
        Me.tabControllGamePlay.TabIndex = 0
        '
        'tabGamePlayMechanics
        '
        Me.tabGamePlayMechanics.AutoScroll = True
        Me.tabGamePlayMechanics.Controls.Add(Me.txtGamePlayMechanics)
        Me.tabGamePlayMechanics.Location = New System.Drawing.Point(4, 22)
        Me.tabGamePlayMechanics.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlayMechanics.Name = "tabGamePlayMechanics"
        Me.tabGamePlayMechanics.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlayMechanics.Size = New System.Drawing.Size(944, 482)
        Me.tabGamePlayMechanics.TabIndex = 0
        Me.tabGamePlayMechanics.Text = "Mechanics"
        Me.tabGamePlayMechanics.UseVisualStyleBackColor = True
        '
        'txtGamePlayMechanics
        '
        Me.txtGamePlayMechanics.AutoSize = True
        Me.txtGamePlayMechanics.Location = New System.Drawing.Point(9, 9)
        Me.txtGamePlayMechanics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtGamePlayMechanics.Name = "txtGamePlayMechanics"
        Me.txtGamePlayMechanics.Size = New System.Drawing.Size(49, 16)
        Me.txtGamePlayMechanics.TabIndex = 0
        Me.txtGamePlayMechanics.Text = "Label1"
        '
        'tabGamePlayToDoList
        '
        Me.tabGamePlayToDoList.AutoScroll = True
        Me.tabGamePlayToDoList.Controls.Add(Me.txtGamePlayToDoList)
        Me.tabGamePlayToDoList.Location = New System.Drawing.Point(4, 22)
        Me.tabGamePlayToDoList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlayToDoList.Name = "tabGamePlayToDoList"
        Me.tabGamePlayToDoList.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlayToDoList.Size = New System.Drawing.Size(944, 482)
        Me.tabGamePlayToDoList.TabIndex = 1
        Me.tabGamePlayToDoList.Text = "To Do List"
        Me.tabGamePlayToDoList.UseVisualStyleBackColor = True
        '
        'txtGamePlayToDoList
        '
        Me.txtGamePlayToDoList.AutoSize = True
        Me.txtGamePlayToDoList.Location = New System.Drawing.Point(9, 9)
        Me.txtGamePlayToDoList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtGamePlayToDoList.Name = "txtGamePlayToDoList"
        Me.txtGamePlayToDoList.Size = New System.Drawing.Size(49, 16)
        Me.txtGamePlayToDoList.TabIndex = 0
        Me.txtGamePlayToDoList.Text = "Label1"
        '
        'tabGamePlayThoughts
        '
        Me.tabGamePlayThoughts.AutoScroll = True
        Me.tabGamePlayThoughts.Controls.Add(Me.txtGamePlayThoughts)
        Me.tabGamePlayThoughts.Location = New System.Drawing.Point(4, 22)
        Me.tabGamePlayThoughts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlayThoughts.Name = "tabGamePlayThoughts"
        Me.tabGamePlayThoughts.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlayThoughts.Size = New System.Drawing.Size(944, 482)
        Me.tabGamePlayThoughts.TabIndex = 2
        Me.tabGamePlayThoughts.Text = "Thoughts"
        Me.tabGamePlayThoughts.UseVisualStyleBackColor = True
        '
        'txtGamePlayThoughts
        '
        Me.txtGamePlayThoughts.AutoSize = True
        Me.txtGamePlayThoughts.Location = New System.Drawing.Point(9, 9)
        Me.txtGamePlayThoughts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtGamePlayThoughts.Name = "txtGamePlayThoughts"
        Me.txtGamePlayThoughts.Size = New System.Drawing.Size(49, 16)
        Me.txtGamePlayThoughts.TabIndex = 0
        Me.txtGamePlayThoughts.Text = "Label1"
        '
        'tabGamePlayStrategy
        '
        Me.tabGamePlayStrategy.AutoScroll = True
        Me.tabGamePlayStrategy.Controls.Add(Me.txtGamePlayStrategy)
        Me.tabGamePlayStrategy.Location = New System.Drawing.Point(4, 25)
        Me.tabGamePlayStrategy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlayStrategy.Name = "tabGamePlayStrategy"
        Me.tabGamePlayStrategy.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabGamePlayStrategy.Size = New System.Drawing.Size(944, 479)
        Me.tabGamePlayStrategy.TabIndex = 3
        Me.tabGamePlayStrategy.Text = "Strategy"
        Me.tabGamePlayStrategy.UseVisualStyleBackColor = True
        '
        'txtGamePlayStrategy
        '
        Me.txtGamePlayStrategy.AutoSize = True
        Me.txtGamePlayStrategy.Location = New System.Drawing.Point(9, 9)
        Me.txtGamePlayStrategy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtGamePlayStrategy.Name = "txtGamePlayStrategy"
        Me.txtGamePlayStrategy.Size = New System.Drawing.Size(49, 16)
        Me.txtGamePlayStrategy.TabIndex = 0
        Me.txtGamePlayStrategy.Text = "Label1"
        Me.txtGamePlayStrategy.Visible = False
        '
        'tabOnline
        '
        Me.tabOnline.AutoScroll = True
        Me.tabOnline.Controls.Add(Me.tabControllerOnline)
        Me.tabOnline.Location = New System.Drawing.Point(4, 25)
        Me.tabOnline.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnline.Name = "tabOnline"
        Me.tabOnline.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnline.Size = New System.Drawing.Size(966, 536)
        Me.tabOnline.TabIndex = 3
        Me.tabOnline.Text = "Online"
        Me.tabOnline.UseVisualStyleBackColor = True
        '
        'tabControllerOnline
        '
        Me.tabControllerOnline.Controls.Add(Me.tabOnlinePeople)
        Me.tabControllerOnline.Controls.Add(Me.tabOnlineGuild)
        Me.tabControllerOnline.Controls.Add(Me.tabOnlineEvents)
        Me.tabControllerOnline.Controls.Add(Me.tabOnlineToDoList)
        Me.tabControllerOnline.Controls.Add(Me.tabOnlineThoughts)
        Me.tabControllerOnline.Location = New System.Drawing.Point(9, 9)
        Me.tabControllerOnline.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabControllerOnline.Name = "tabControllerOnline"
        Me.tabControllerOnline.SelectedIndex = 0
        Me.tabControllerOnline.Size = New System.Drawing.Size(948, 505)
        Me.tabControllerOnline.TabIndex = 0
        '
        'tabOnlinePeople
        '
        Me.tabOnlinePeople.AutoScroll = True
        Me.tabOnlinePeople.Controls.Add(Me.txtOnlinePeople)
        Me.tabOnlinePeople.Location = New System.Drawing.Point(4, 25)
        Me.tabOnlinePeople.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlinePeople.Name = "tabOnlinePeople"
        Me.tabOnlinePeople.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlinePeople.Size = New System.Drawing.Size(940, 476)
        Me.tabOnlinePeople.TabIndex = 0
        Me.tabOnlinePeople.Text = "People"
        Me.tabOnlinePeople.UseVisualStyleBackColor = True
        '
        'txtOnlinePeople
        '
        Me.txtOnlinePeople.AutoSize = True
        Me.txtOnlinePeople.Location = New System.Drawing.Point(9, 9)
        Me.txtOnlinePeople.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtOnlinePeople.Name = "txtOnlinePeople"
        Me.txtOnlinePeople.Size = New System.Drawing.Size(49, 16)
        Me.txtOnlinePeople.TabIndex = 0
        Me.txtOnlinePeople.Text = "Label1"
        '
        'tabOnlineGuild
        '
        Me.tabOnlineGuild.AutoScroll = True
        Me.tabOnlineGuild.Controls.Add(Me.txtOnlineGuild)
        Me.tabOnlineGuild.Location = New System.Drawing.Point(4, 22)
        Me.tabOnlineGuild.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlineGuild.Name = "tabOnlineGuild"
        Me.tabOnlineGuild.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlineGuild.Size = New System.Drawing.Size(940, 479)
        Me.tabOnlineGuild.TabIndex = 1
        Me.tabOnlineGuild.Text = "Guild"
        Me.tabOnlineGuild.UseVisualStyleBackColor = True
        '
        'txtOnlineGuild
        '
        Me.txtOnlineGuild.AutoSize = True
        Me.txtOnlineGuild.Location = New System.Drawing.Point(9, 9)
        Me.txtOnlineGuild.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtOnlineGuild.Name = "txtOnlineGuild"
        Me.txtOnlineGuild.Size = New System.Drawing.Size(49, 16)
        Me.txtOnlineGuild.TabIndex = 0
        Me.txtOnlineGuild.Text = "Label1"
        '
        'tabOnlineEvents
        '
        Me.tabOnlineEvents.AutoScroll = True
        Me.tabOnlineEvents.Controls.Add(Me.txtOnlineEvents)
        Me.tabOnlineEvents.Location = New System.Drawing.Point(4, 22)
        Me.tabOnlineEvents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlineEvents.Name = "tabOnlineEvents"
        Me.tabOnlineEvents.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlineEvents.Size = New System.Drawing.Size(940, 479)
        Me.tabOnlineEvents.TabIndex = 2
        Me.tabOnlineEvents.Text = "Events"
        Me.tabOnlineEvents.UseVisualStyleBackColor = True
        '
        'txtOnlineEvents
        '
        Me.txtOnlineEvents.AutoSize = True
        Me.txtOnlineEvents.Location = New System.Drawing.Point(9, 9)
        Me.txtOnlineEvents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtOnlineEvents.Name = "txtOnlineEvents"
        Me.txtOnlineEvents.Size = New System.Drawing.Size(49, 16)
        Me.txtOnlineEvents.TabIndex = 0
        Me.txtOnlineEvents.Text = "Label1"
        '
        'tabOnlineToDoList
        '
        Me.tabOnlineToDoList.AutoScroll = True
        Me.tabOnlineToDoList.Controls.Add(Me.txtOnlineToDoList)
        Me.tabOnlineToDoList.Location = New System.Drawing.Point(4, 22)
        Me.tabOnlineToDoList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlineToDoList.Name = "tabOnlineToDoList"
        Me.tabOnlineToDoList.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlineToDoList.Size = New System.Drawing.Size(940, 479)
        Me.tabOnlineToDoList.TabIndex = 3
        Me.tabOnlineToDoList.Text = "To Do List"
        Me.tabOnlineToDoList.UseVisualStyleBackColor = True
        '
        'txtOnlineToDoList
        '
        Me.txtOnlineToDoList.AutoSize = True
        Me.txtOnlineToDoList.Location = New System.Drawing.Point(9, 9)
        Me.txtOnlineToDoList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtOnlineToDoList.Name = "txtOnlineToDoList"
        Me.txtOnlineToDoList.Size = New System.Drawing.Size(49, 16)
        Me.txtOnlineToDoList.TabIndex = 0
        Me.txtOnlineToDoList.Text = "Label1"
        '
        'tabOnlineThoughts
        '
        Me.tabOnlineThoughts.AutoScroll = True
        Me.tabOnlineThoughts.Controls.Add(Me.txtOnlineThoughts)
        Me.tabOnlineThoughts.Location = New System.Drawing.Point(4, 22)
        Me.tabOnlineThoughts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlineThoughts.Name = "tabOnlineThoughts"
        Me.tabOnlineThoughts.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOnlineThoughts.Size = New System.Drawing.Size(940, 479)
        Me.tabOnlineThoughts.TabIndex = 4
        Me.tabOnlineThoughts.Text = "Thoughts"
        Me.tabOnlineThoughts.UseVisualStyleBackColor = True
        '
        'txtOnlineThoughts
        '
        Me.txtOnlineThoughts.AutoSize = True
        Me.txtOnlineThoughts.Location = New System.Drawing.Point(9, 9)
        Me.txtOnlineThoughts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtOnlineThoughts.Name = "txtOnlineThoughts"
        Me.txtOnlineThoughts.Size = New System.Drawing.Size(49, 16)
        Me.txtOnlineThoughts.TabIndex = 0
        Me.txtOnlineThoughts.Text = "Label1"
        '
        'tabReview
        '
        Me.tabReview.AutoScroll = True
        Me.tabReview.Controls.Add(Me.txtReview)
        Me.tabReview.Location = New System.Drawing.Point(4, 25)
        Me.tabReview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabReview.Name = "tabReview"
        Me.tabReview.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabReview.Size = New System.Drawing.Size(966, 536)
        Me.tabReview.TabIndex = 4
        Me.tabReview.Text = "Review"
        Me.tabReview.UseVisualStyleBackColor = True
        '
        'txtReview
        '
        Me.txtReview.AutoSize = True
        Me.txtReview.Location = New System.Drawing.Point(9, 9)
        Me.txtReview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtReview.Name = "txtReview"
        Me.txtReview.Size = New System.Drawing.Size(49, 16)
        Me.txtReview.TabIndex = 0
        Me.txtReview.Text = "Label1"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(978, 105)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(108, 41)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(978, 425)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 41)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmViewEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1093, 546)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.TabControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmViewEntry"
        Me.Text = "NAME OF GAME"
        Me.TabControl.ResumeLayout(False)
        Me.tabpGeneral.ResumeLayout(False)
        Me.tabpGeneral.PerformLayout()
        Me.tabStory.ResumeLayout(False)
        Me.tabControllStory.ResumeLayout(False)
        Me.tabStoryEvents.ResumeLayout(False)
        Me.tabStoryEvents.PerformLayout()
        Me.tabStoryCharacters.ResumeLayout(False)
        Me.tabStoryCharacters.PerformLayout()
        Me.tabStoryWorld.ResumeLayout(False)
        Me.tabStoryWorld.PerformLayout()
        Me.tabStoryThoughts.ResumeLayout(False)
        Me.tabStoryThoughts.PerformLayout()
        Me.tabStoryToDoList.ResumeLayout(False)
        Me.tabStoryToDoList.PerformLayout()
        Me.tabGamePlay.ResumeLayout(False)
        Me.tabControllGamePlay.ResumeLayout(False)
        Me.tabGamePlayMechanics.ResumeLayout(False)
        Me.tabGamePlayMechanics.PerformLayout()
        Me.tabGamePlayToDoList.ResumeLayout(False)
        Me.tabGamePlayToDoList.PerformLayout()
        Me.tabGamePlayThoughts.ResumeLayout(False)
        Me.tabGamePlayThoughts.PerformLayout()
        Me.tabGamePlayStrategy.ResumeLayout(False)
        Me.tabGamePlayStrategy.PerformLayout()
        Me.tabOnline.ResumeLayout(False)
        Me.tabControllerOnline.ResumeLayout(False)
        Me.tabOnlinePeople.ResumeLayout(False)
        Me.tabOnlinePeople.PerformLayout()
        Me.tabOnlineGuild.ResumeLayout(False)
        Me.tabOnlineGuild.PerformLayout()
        Me.tabOnlineEvents.ResumeLayout(False)
        Me.tabOnlineEvents.PerformLayout()
        Me.tabOnlineToDoList.ResumeLayout(False)
        Me.tabOnlineToDoList.PerformLayout()
        Me.tabOnlineThoughts.ResumeLayout(False)
        Me.tabOnlineThoughts.PerformLayout()
        Me.tabReview.ResumeLayout(False)
        Me.tabReview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents tabStory As TabPage
    Friend WithEvents tabGamePlay As TabPage
    Friend WithEvents tabOnline As TabPage
    Friend WithEvents tabpGeneral As TabPage
    Friend WithEvents tabReview As TabPage
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents txtState As Label
    Friend WithEvents txtHourCount As Label
    Friend WithEvents txtDateLastPlayed As Label
    Friend WithEvents txtDateStarted As Label
    Friend WithEvents txtCoop As Label
    Friend WithEvents txtGenra As Label
    Friend WithEvents txtEarlyAccess As Label
    Friend WithEvents txtReleaseDate As Label
    Friend WithEvents txtdevelpor As Label
    Friend WithEvents txtPublisher As Label
    Friend WithEvents txtTitle As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblHourCount As Label
    Friend WithEvents lblDateLastPlayed As Label
    Friend WithEvents lblDateStarted As Label
    Friend WithEvents lblCoop As Label
    Friend WithEvents lblGenra As Label
    Friend WithEvents lblEarlyAccess As Label
    Friend WithEvents lblReleaseDate As Label
    Friend WithEvents lblDevelpor As Label
    Friend WithEvents tabControllStory As TabControl
    Friend WithEvents tabStoryEvents As TabPage
    Friend WithEvents tabStoryCharacters As TabPage
    Friend WithEvents txtStoryEvents As Label
    Friend WithEvents txtStoryCharacters As Label
    Friend WithEvents tabStoryWorld As TabPage
    Friend WithEvents txtStoryWorld As Label
    Friend WithEvents tabStoryThoughts As TabPage
    Friend WithEvents txtStoryThoughts As Label
    Friend WithEvents tabStoryToDoList As TabPage
    Friend WithEvents txtStoryToDoList As Label
    Friend WithEvents tabControllGamePlay As TabControl
    Friend WithEvents tabGamePlayMechanics As TabPage
    Friend WithEvents tabGamePlayToDoList As TabPage
    Friend WithEvents tabGamePlayThoughts As TabPage
    Friend WithEvents tabGamePlayStrategy As TabPage
    Friend WithEvents txtGamePlayMechanics As Label
    Friend WithEvents txtGamePlayToDoList As Label
    Friend WithEvents txtGamePlayThoughts As Label
    Friend WithEvents txtGamePlayStrategy As Label
    Friend WithEvents tabControllerOnline As TabControl
    Friend WithEvents tabOnlinePeople As TabPage
    Friend WithEvents tabOnlineGuild As TabPage
    Friend WithEvents tabOnlineEvents As TabPage
    Friend WithEvents tabOnlineToDoList As TabPage
    Friend WithEvents tabOnlineThoughts As TabPage
    Friend WithEvents txtOnlinePeople As Label
    Friend WithEvents txtOnlineGuild As Label
    Friend WithEvents txtOnlineEvents As Label
    Friend WithEvents txtOnlineToDoList As Label
    Friend WithEvents txtOnlineThoughts As Label
    Friend WithEvents txtReview As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClose As Button
End Class
