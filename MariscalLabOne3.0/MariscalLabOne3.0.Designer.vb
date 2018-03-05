<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMariscalLabOne
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
        Me.components = New System.ComponentModel.Container()
        Me.lbAverageDisplay = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.tbUnitsOutput = New System.Windows.Forms.TextBox()
        Me.lbDays = New System.Windows.Forms.Label()
        Me.tbUnitInput = New System.Windows.Forms.TextBox()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.ToolTipAverageUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbAverageDisplay
        '
        Me.lbAverageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageDisplay.Location = New System.Drawing.Point(7, 182)
        Me.lbAverageDisplay.Name = "lbAverageDisplay"
        Me.lbAverageDisplay.Size = New System.Drawing.Size(267, 23)
        Me.lbAverageDisplay.TabIndex = 24
        Me.lbAverageDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAverageUnitsShipped.SetToolTip(Me.lbAverageDisplay, "The calculated average of the week goes here")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(201, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "E&xit"
        Me.ToolTipAverageUnitsShipped.SetToolTip(Me.btnExit, "Exits the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(109, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "&Reset"
        Me.ToolTipAverageUnitsShipped.SetToolTip(Me.btnReset, "Resets the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(15, 226)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 21
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipAverageUnitsShipped.SetToolTip(Me.btnEnter, "Lets you input number into array")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'tbUnitsOutput
        '
        Me.tbUnitsOutput.Location = New System.Drawing.Point(38, 32)
        Me.tbUnitsOutput.Multiline = True
        Me.tbUnitsOutput.Name = "tbUnitsOutput"
        Me.tbUnitsOutput.ReadOnly = True
        Me.tbUnitsOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbUnitsOutput.Size = New System.Drawing.Size(205, 138)
        Me.tbUnitsOutput.TabIndex = 20
        Me.ToolTipAverageUnitsShipped.SetToolTip(Me.tbUnitsOutput, "Shows the units for each day")
        '
        'lbDays
        '
        Me.lbDays.AutoSize = True
        Me.lbDays.Location = New System.Drawing.Point(166, 4)
        Me.lbDays.Name = "lbDays"
        Me.lbDays.Size = New System.Drawing.Size(49, 17)
        Me.lbDays.TabIndex = 19
        Me.lbDays.Text = "&Day 1:"
        Me.ToolTipAverageUnitsShipped.SetToolTip(Me.lbDays, "Shows the day that needs a units amount entered into")
        '
        'tbUnitInput
        '
        Me.tbUnitInput.Location = New System.Drawing.Point(76, 4)
        Me.tbUnitInput.Name = "tbUnitInput"
        Me.tbUnitInput.Size = New System.Drawing.Size(66, 22)
        Me.tbUnitInput.TabIndex = 18
        Me.ToolTipAverageUnitsShipped.SetToolTip(Me.tbUnitInput, "enter the units here")
        '
        'lbUnits
        '
        Me.lbUnits.AutoSize = True
        Me.lbUnits.Location = New System.Drawing.Point(35, 4)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(44, 17)
        Me.lbUnits.TabIndex = 17
        Me.lbUnits.Text = "&Units:"
        '
        'frmMariscalLabOne
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(291, 255)
        Me.Controls.Add(Me.lbAverageDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbUnitsOutput)
        Me.Controls.Add(Me.lbDays)
        Me.Controls.Add(Me.tbUnitInput)
        Me.Controls.Add(Me.lbUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMariscalLabOne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbAverageDisplay As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents tbUnitsOutput As TextBox
    Friend WithEvents lbDays As Label
    Friend WithEvents tbUnitInput As TextBox
    Friend WithEvents lbUnits As Label
    Friend WithEvents ToolTipAverageUnitsShipped As ToolTip
End Class
