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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtDepartmentNo = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtDateHired = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblDateHired = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDepartmentNo = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstEmployeeInfo = New System.Windows.Forms.ListBox()
        Me.btnLstClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(4, 12)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(55, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(81, 12)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(105, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtDepartmentNo
        '
        Me.txtDepartmentNo.Location = New System.Drawing.Point(81, 90)
        Me.txtDepartmentNo.Name = "txtDepartmentNo"
        Me.txtDepartmentNo.Size = New System.Drawing.Size(48, 20)
        Me.txtDepartmentNo.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(81, 51)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(105, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtDateHired
        '
        Me.txtDateHired.Location = New System.Drawing.Point(81, 198)
        Me.txtDateHired.Mask = "00/00/0000"
        Me.txtDateHired.Name = "txtDateHired"
        Me.txtDateHired.Size = New System.Drawing.Size(77, 20)
        Me.txtDateHired.TabIndex = 5
        Me.txtDateHired.ValidatingType = GetType(Date)
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(81, 163)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(84, 20)
        Me.txtPhone.TabIndex = 4
        '
        'lblDateHired
        '
        Me.lblDateHired.AutoSize = True
        Me.lblDateHired.Location = New System.Drawing.Point(4, 201)
        Me.lblDateHired.Name = "lblDateHired"
        Me.lblDateHired.Size = New System.Drawing.Size(56, 13)
        Me.lblDateHired.TabIndex = 9
        Me.lblDateHired.Text = "Date hired"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(4, 163)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(48, 13)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone #"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(4, 128)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email"
        '
        'lblDepartmentNo
        '
        Me.lblDepartmentNo.AutoSize = True
        Me.lblDepartmentNo.Location = New System.Drawing.Point(4, 93)
        Me.lblDepartmentNo.Name = "lblDepartmentNo"
        Me.lblDepartmentNo.Size = New System.Drawing.Size(72, 13)
        Me.lblDepartmentNo.TabIndex = 12
        Me.lblDepartmentNo.Text = "Department #"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(4, 54)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(56, 13)
        Me.lblLastName.TabIndex = 13
        Me.lblLastName.Text = "Last name"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(81, 128)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(144, 20)
        Me.txtEmail.TabIndex = 3
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Location = New System.Drawing.Point(617, 12)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(78, 38)
        Me.btnAddEmployee.TabIndex = 6
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(617, 111)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 37)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(617, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstEmployeeInfo
        '
        Me.lstEmployeeInfo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEmployeeInfo.FormattingEnabled = True
        Me.lstEmployeeInfo.ItemHeight = 14
        Me.lstEmployeeInfo.Location = New System.Drawing.Point(12, 224)
        Me.lstEmployeeInfo.Name = "lstEmployeeInfo"
        Me.lstEmployeeInfo.Size = New System.Drawing.Size(578, 130)
        Me.lstEmployeeInfo.TabIndex = 17
        '
        'btnLstClear
        '
        Me.btnLstClear.Location = New System.Drawing.Point(617, 210)
        Me.btnLstClear.Name = "btnLstClear"
        Me.btnLstClear.Size = New System.Drawing.Size(78, 37)
        Me.btnLstClear.TabIndex = 18
        Me.btnLstClear.Text = "Clear List"
        Me.btnLstClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 370)
        Me.Controls.Add(Me.btnLstClear)
        Me.Controls.Add(Me.lstEmployeeInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblDepartmentNo)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblDateHired)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtDateHired)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtDepartmentNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "Form1"
        Me.Text = "Employee Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtDepartmentNo As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtDateHired As MaskedTextBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents lblDateHired As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDepartmentNo As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstEmployeeInfo As ListBox
    Friend WithEvents btnLstClear As Button
End Class
