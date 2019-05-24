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
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstPayments = New System.Windows.Forms.ListBox()
        Me.btnEntrySearch = New System.Windows.Forms.Button()
        Me.btnListSearch = New System.Windows.Forms.Button()
        Me.lstPaymentTypes = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(470, 11)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 45)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(470, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 45)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(470, 329)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 45)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstPayments
        '
        Me.lstPayments.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPayments.FormattingEnabled = True
        Me.lstPayments.ItemHeight = 14
        Me.lstPayments.Location = New System.Drawing.Point(12, 11)
        Me.lstPayments.Name = "lstPayments"
        Me.lstPayments.Size = New System.Drawing.Size(429, 368)
        Me.lstPayments.TabIndex = 3
        '
        'btnEntrySearch
        '
        Me.btnEntrySearch.Location = New System.Drawing.Point(470, 167)
        Me.btnEntrySearch.Name = "btnEntrySearch"
        Me.btnEntrySearch.Size = New System.Drawing.Size(93, 45)
        Me.btnEntrySearch.TabIndex = 4
        Me.btnEntrySearch.Text = "Search (type in)"
        Me.btnEntrySearch.UseVisualStyleBackColor = True
        '
        'btnListSearch
        '
        Me.btnListSearch.Location = New System.Drawing.Point(470, 218)
        Me.btnListSearch.Name = "btnListSearch"
        Me.btnListSearch.Size = New System.Drawing.Size(93, 45)
        Me.btnListSearch.TabIndex = 5
        Me.btnListSearch.Text = "Search (from list) -->"
        Me.btnListSearch.UseVisualStyleBackColor = True
        '
        'lstPaymentTypes
        '
        Me.lstPaymentTypes.FormattingEnabled = True
        Me.lstPaymentTypes.Location = New System.Drawing.Point(588, 20)
        Me.lstPaymentTypes.Name = "lstPaymentTypes"
        Me.lstPaymentTypes.Size = New System.Drawing.Size(130, 355)
        Me.lstPaymentTypes.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 399)
        Me.Controls.Add(Me.lstPaymentTypes)
        Me.Controls.Add(Me.btnListSearch)
        Me.Controls.Add(Me.btnEntrySearch)
        Me.Controls.Add(Me.lstPayments)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnView)
        Me.Name = "Form1"
        Me.Text = "Payments"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnView As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstPayments As ListBox
    Friend WithEvents btnEntrySearch As Button
    Friend WithEvents btnListSearch As Button
    Friend WithEvents lstPaymentTypes As ListBox
End Class
