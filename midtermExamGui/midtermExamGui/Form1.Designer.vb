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
        Me.lblConvertFrom = New System.Windows.Forms.Label()
        Me.rbtnCelsius = New System.Windows.Forms.RadioButton()
        Me.rbtnFahrenheit = New System.Windows.Forms.RadioButton()
        Me.lblEnterTemp = New System.Windows.Forms.Label()
        Me.lblOutTitle = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtboxUserInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblConvertFrom
        '
        Me.lblConvertFrom.AutoSize = True
        Me.lblConvertFrom.Location = New System.Drawing.Point(83, 28)
        Me.lblConvertFrom.Name = "lblConvertFrom"
        Me.lblConvertFrom.Size = New System.Drawing.Size(70, 13)
        Me.lblConvertFrom.TabIndex = 0
        Me.lblConvertFrom.Text = "Convert From"
        '
        'rbtnCelsius
        '
        Me.rbtnCelsius.AutoSize = True
        Me.rbtnCelsius.Location = New System.Drawing.Point(207, 49)
        Me.rbtnCelsius.Name = "rbtnCelsius"
        Me.rbtnCelsius.Size = New System.Drawing.Size(58, 17)
        Me.rbtnCelsius.TabIndex = 1
        Me.rbtnCelsius.TabStop = True
        Me.rbtnCelsius.Text = "Celsius"
        Me.rbtnCelsius.UseVisualStyleBackColor = True
        '
        'rbtnFahrenheit
        '
        Me.rbtnFahrenheit.AutoSize = True
        Me.rbtnFahrenheit.Location = New System.Drawing.Point(207, 90)
        Me.rbtnFahrenheit.Name = "rbtnFahrenheit"
        Me.rbtnFahrenheit.Size = New System.Drawing.Size(75, 17)
        Me.rbtnFahrenheit.TabIndex = 2
        Me.rbtnFahrenheit.TabStop = True
        Me.rbtnFahrenheit.Text = "Fahrenheit"
        Me.rbtnFahrenheit.UseVisualStyleBackColor = True
        '
        'lblEnterTemp
        '
        Me.lblEnterTemp.AutoSize = True
        Me.lblEnterTemp.Location = New System.Drawing.Point(86, 161)
        Me.lblEnterTemp.Name = "lblEnterTemp"
        Me.lblEnterTemp.Size = New System.Drawing.Size(95, 13)
        Me.lblEnterTemp.TabIndex = 3
        Me.lblEnterTemp.Text = "Enter Temperature"
        '
        'lblOutTitle
        '
        Me.lblOutTitle.AutoSize = True
        Me.lblOutTitle.Location = New System.Drawing.Point(86, 284)
        Me.lblOutTitle.Name = "lblOutTitle"
        Me.lblOutTitle.Size = New System.Drawing.Size(134, 13)
        Me.lblOutTitle.TabIndex = 4
        Me.lblOutTitle.Text = "The Output Temperature is"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(227, 284)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(43, 13)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "888888"
        Me.lblOutput.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(145, 213)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtboxUserInput
        '
        Me.txtboxUserInput.Location = New System.Drawing.Point(188, 153)
        Me.txtboxUserInput.Name = "txtboxUserInput"
        Me.txtboxUserInput.Size = New System.Drawing.Size(100, 20)
        Me.txtboxUserInput.TabIndex = 7
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 338)
        Me.Controls.Add(Me.txtboxUserInput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblOutTitle)
        Me.Controls.Add(Me.lblEnterTemp)
        Me.Controls.Add(Me.rbtnFahrenheit)
        Me.Controls.Add(Me.rbtnCelsius)
        Me.Controls.Add(Me.lblConvertFrom)
        Me.Name = "frmMain"
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConvertFrom As Label
    Friend WithEvents rbtnCelsius As RadioButton
    Friend WithEvents rbtnFahrenheit As RadioButton
    Friend WithEvents lblEnterTemp As Label
    Friend WithEvents lblOutTitle As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtboxUserInput As TextBox
End Class
