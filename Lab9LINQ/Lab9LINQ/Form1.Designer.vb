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
        Me.lvStudentRecords = New System.Windows.Forms.ListView()
        Me.hdrStudentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrDept = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrClass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hdrCredits = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvStudentRecords
        '
        Me.lvStudentRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hdrStudentID, Me.hdrLastName, Me.hdrFirstName, Me.hdrDept, Me.hdrClass, Me.hdrCredits})
        Me.lvStudentRecords.Location = New System.Drawing.Point(21, 21)
        Me.lvStudentRecords.Name = "lvStudentRecords"
        Me.lvStudentRecords.Size = New System.Drawing.Size(399, 341)
        Me.lvStudentRecords.TabIndex = 0
        Me.lvStudentRecords.UseCompatibleStateImageBehavior = False
        Me.lvStudentRecords.View = System.Windows.Forms.View.Details
        '
        'hdrStudentID
        '
        Me.hdrStudentID.Text = "Student ID"
        Me.hdrStudentID.Width = 85
        '
        'hdrLastName
        '
        Me.hdrLastName.Text = "Last"
        '
        'hdrFirstName
        '
        Me.hdrFirstName.Text = "First"
        '
        'hdrDept
        '
        Me.hdrDept.Text = "Dept"
        '
        'hdrClass
        '
        Me.hdrClass.Text = "Class"
        '
        'hdrCredits
        '
        Me.hdrCredits.Text = "Credits"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(441, 71)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(86, 38)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "Start"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(441, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 38)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 374)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lvStudentRecords)
        Me.Name = "Form1"
        Me.Text = "Grand Jonny U Students"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvStudentRecords As ListView
    Friend WithEvents btnView As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents hdrStudentID As ColumnHeader
    Friend WithEvents hdrLastName As ColumnHeader
    Friend WithEvents hdrFirstName As ColumnHeader
    Friend WithEvents hdrDept As ColumnHeader
    Friend WithEvents hdrClass As ColumnHeader
    Friend WithEvents hdrCredits As ColumnHeader
End Class
