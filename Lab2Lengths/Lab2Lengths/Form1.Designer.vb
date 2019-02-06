<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.InputLbl = New System.Windows.Forms.Label()
        Me.OutputLbl = New System.Windows.Forms.Label()
        Me.UnitInput = New System.Windows.Forms.TextBox()
        Me.UnitOutput = New System.Windows.Forms.TextBox()
        Me.ConvertType = New System.Windows.Forms.ListBox()
        Me.ConvertBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputLbl
        '
        Me.InputLbl.AutoSize = True
        Me.InputLbl.Location = New System.Drawing.Point(12, 26)
        Me.InputLbl.Name = "InputLbl"
        Me.InputLbl.Size = New System.Drawing.Size(70, 13)
        Me.InputLbl.TabIndex = 0
        Me.InputLbl.Text = "Convert This:"
        '
        'OutputLbl
        '
        Me.OutputLbl.AutoSize = True
        Me.OutputLbl.Location = New System.Drawing.Point(12, 69)
        Me.OutputLbl.Name = "OutputLbl"
        Me.OutputLbl.Size = New System.Drawing.Size(46, 13)
        Me.OutputLbl.TabIndex = 1
        Me.OutputLbl.Text = "To This:"
        '
        'UnitInput
        '
        Me.UnitInput.Location = New System.Drawing.Point(89, 24)
        Me.UnitInput.Name = "UnitInput"
        Me.UnitInput.Size = New System.Drawing.Size(111, 20)
        Me.UnitInput.TabIndex = 0
        '
        'UnitOutput
        '
        Me.UnitOutput.Location = New System.Drawing.Point(89, 66)
        Me.UnitOutput.Name = "UnitOutput"
        Me.UnitOutput.ReadOnly = True
        Me.UnitOutput.Size = New System.Drawing.Size(111, 20)
        Me.UnitOutput.TabIndex = 3
        Me.UnitOutput.TabStop = False
        '
        'ConvertType
        '
        Me.ConvertType.FormattingEnabled = True
        Me.ConvertType.Items.AddRange(New Object() {"Miles to Kilometers", "Kilometers to Miles", "Feet to Meters", "Meters to Feet", "Inches to Centimeters", "Centimeters to Inches"})
        Me.ConvertType.Location = New System.Drawing.Point(220, 14)
        Me.ConvertType.Name = "ConvertType"
        Me.ConvertType.Size = New System.Drawing.Size(117, 82)
        Me.ConvertType.TabIndex = 1
        '
        'ConvertBtn
        '
        Me.ConvertBtn.Location = New System.Drawing.Point(17, 105)
        Me.ConvertBtn.Name = "ConvertBtn"
        Me.ConvertBtn.Size = New System.Drawing.Size(64, 24)
        Me.ConvertBtn.TabIndex = 2
        Me.ConvertBtn.Text = "Convert"
        Me.ConvertBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(99, 105)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(78, 24)
        Me.ClearBtn.TabIndex = 3
        Me.ClearBtn.Text = "Reset/Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 134)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.ConvertBtn)
        Me.Controls.Add(Me.ConvertType)
        Me.Controls.Add(Me.UnitOutput)
        Me.Controls.Add(Me.UnitInput)
        Me.Controls.Add(Me.OutputLbl)
        Me.Controls.Add(Me.InputLbl)
        Me.Name = "Form1"
        Me.Text = "Length Unit Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputLbl As Label
    Friend WithEvents OutputLbl As Label
    Friend WithEvents UnitInput As TextBox
    Friend WithEvents UnitOutput As TextBox
    Friend WithEvents ConvertType As ListBox
    Friend WithEvents ConvertBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Button1 As Button
End Class
