<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BillLbl = New System.Windows.Forms.Label()
        Me.TipAmountLbl = New System.Windows.Forms.Label()
        Me.TipLbl = New System.Windows.Forms.Label()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.BillAmount = New System.Windows.Forms.TextBox()
        Me.TipOutput = New System.Windows.Forms.TextBox()
        Me.TipPercent = New System.Windows.Forms.TextBox()
        Me.ProcedureBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BillLbl
        '
        Me.BillLbl.AutoSize = True
        Me.BillLbl.Location = New System.Drawing.Point(16, 15)
        Me.BillLbl.Name = "BillLbl"
        Me.BillLbl.Size = New System.Drawing.Size(59, 13)
        Me.BillLbl.TabIndex = 0
        Me.BillLbl.Text = "Bill Amount"
        '
        'TipAmountLbl
        '
        Me.TipAmountLbl.AutoSize = True
        Me.TipAmountLbl.Location = New System.Drawing.Point(16, 88)
        Me.TipAmountLbl.Name = "TipAmountLbl"
        Me.TipAmountLbl.Size = New System.Drawing.Size(61, 13)
        Me.TipAmountLbl.TabIndex = 1
        Me.TipAmountLbl.Text = "Tip Amount"
        '
        'TipLbl
        '
        Me.TipLbl.AutoSize = True
        Me.TipLbl.Location = New System.Drawing.Point(16, 52)
        Me.TipLbl.Name = "TipLbl"
        Me.TipLbl.Size = New System.Drawing.Size(33, 13)
        Me.TipLbl.TabIndex = 2
        Me.TipLbl.Text = "Tip %"
        '
        'CalcBtn
        '
        Me.CalcBtn.Location = New System.Drawing.Point(22, 134)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(109, 37)
        Me.CalcBtn.TabIndex = 3
        Me.CalcBtn.Text = "Calculate f(x)"
        Me.CalcBtn.UseVisualStyleBackColor = True
        '
        'BillAmount
        '
        Me.BillAmount.Location = New System.Drawing.Point(96, 12)
        Me.BillAmount.Name = "BillAmount"
        Me.BillAmount.Size = New System.Drawing.Size(100, 20)
        Me.BillAmount.TabIndex = 4
        '
        'TipOutput
        '
        Me.TipOutput.Location = New System.Drawing.Point(96, 85)
        Me.TipOutput.Name = "TipOutput"
        Me.TipOutput.ReadOnly = True
        Me.TipOutput.Size = New System.Drawing.Size(100, 20)
        Me.TipOutput.TabIndex = 5
        '
        'TipPercent
        '
        Me.TipPercent.Location = New System.Drawing.Point(96, 49)
        Me.TipPercent.Name = "TipPercent"
        Me.TipPercent.Size = New System.Drawing.Size(100, 20)
        Me.TipPercent.TabIndex = 6
        '
        'ProcedureBtn
        '
        Me.ProcedureBtn.Location = New System.Drawing.Point(172, 134)
        Me.ProcedureBtn.Name = "ProcedureBtn"
        Me.ProcedureBtn.Size = New System.Drawing.Size(109, 37)
        Me.ProcedureBtn.TabIndex = 7
        Me.ProcedureBtn.Text = "Calculate Prodecure"
        Me.ProcedureBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 188)
        Me.Controls.Add(Me.ProcedureBtn)
        Me.Controls.Add(Me.TipPercent)
        Me.Controls.Add(Me.TipOutput)
        Me.Controls.Add(Me.BillAmount)
        Me.Controls.Add(Me.CalcBtn)
        Me.Controls.Add(Me.TipLbl)
        Me.Controls.Add(Me.TipAmountLbl)
        Me.Controls.Add(Me.BillLbl)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BillLbl As Label
    Friend WithEvents TipAmountLbl As Label
    Friend WithEvents TipLbl As Label
    Friend WithEvents CalcBtn As Button
    Friend WithEvents BillAmount As TextBox
    Friend WithEvents TipOutput As TextBox
    Friend WithEvents TipPercent As TextBox
    Friend WithEvents ProcedureBtn As Button
End Class
