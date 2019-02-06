<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemesterBudgeter
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
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.TotalExpensesLbl = New System.Windows.Forms.Label()
        Me.TotalIncomeLbl = New System.Windows.Forms.Label()
        Me.TotalExpenseOutput = New System.Windows.Forms.TextBox()
        Me.TotalIncomeOutput = New System.Windows.Forms.TextBox()
        Me.ClothingExpense = New System.Windows.Forms.TextBox()
        Me.MiscExpense = New System.Windows.Forms.TextBox()
        Me.FoodExpense = New System.Windows.Forms.TextBox()
        Me.EntertainmentExpense = New System.Windows.Forms.TextBox()
        Me.RentExpense = New System.Windows.Forms.TextBox()
        Me.UtilExpense = New System.Windows.Forms.TextBox()
        Me.GasExpense = New System.Windows.Forms.TextBox()
        Me.CarMaintenanceExpense = New System.Windows.Forms.TextBox()
        Me.SellingIncome = New System.Windows.Forms.TextBox()
        Me.ExcessScholarshipIncome = New System.Windows.Forms.TextBox()
        Me.JobIncome = New System.Windows.Forms.TextBox()
        Me.ParentIncome = New System.Windows.Forms.TextBox()
        Me.ClothesExpenseLbl = New System.Windows.Forms.Label()
        Me.GasLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SellIncomeLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClothingPercentage = New System.Windows.Forms.TextBox()
        Me.FoodPercentage = New System.Windows.Forms.TextBox()
        Me.EntertainmentPercentage = New System.Windows.Forms.TextBox()
        Me.RentPercentage = New System.Windows.Forms.TextBox()
        Me.UtilPercentage = New System.Windows.Forms.TextBox()
        Me.GasPercentage = New System.Windows.Forms.TextBox()
        Me.CarMaintenancePercentage = New System.Windows.Forms.TextBox()
        Me.MiscPercentage = New System.Windows.Forms.TextBox()
        Me.SellingPercentage = New System.Windows.Forms.TextBox()
        Me.ExcessScholarshipPercentage = New System.Windows.Forms.TextBox()
        Me.JobPercentage = New System.Windows.Forms.TextBox()
        Me.ParentPercentage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BalanceOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(634, 53)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(110, 43)
        Me.CalculateBtn.TabIndex = 12
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(635, 139)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(110, 43)
        Me.ClearBtn.TabIndex = 13
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(634, 232)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(110, 43)
        Me.ExitBtn.TabIndex = 14
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'TotalExpensesLbl
        '
        Me.TotalExpensesLbl.AutoSize = True
        Me.TotalExpensesLbl.Location = New System.Drawing.Point(145, 288)
        Me.TotalExpensesLbl.Name = "TotalExpensesLbl"
        Me.TotalExpensesLbl.Size = New System.Drawing.Size(80, 13)
        Me.TotalExpensesLbl.TabIndex = 3
        Me.TotalExpensesLbl.Text = "Total Expenses"
        '
        'TotalIncomeLbl
        '
        Me.TotalIncomeLbl.AutoSize = True
        Me.TotalIncomeLbl.Location = New System.Drawing.Point(457, 288)
        Me.TotalIncomeLbl.Name = "TotalIncomeLbl"
        Me.TotalIncomeLbl.Size = New System.Drawing.Size(69, 13)
        Me.TotalIncomeLbl.TabIndex = 4
        Me.TotalIncomeLbl.Text = "Total Income"
        '
        'TotalExpenseOutput
        '
        Me.TotalExpenseOutput.Location = New System.Drawing.Point(110, 265)
        Me.TotalExpenseOutput.Name = "TotalExpenseOutput"
        Me.TotalExpenseOutput.ReadOnly = True
        Me.TotalExpenseOutput.Size = New System.Drawing.Size(153, 20)
        Me.TotalExpenseOutput.TabIndex = 5
        Me.TotalExpenseOutput.TabStop = False
        '
        'TotalIncomeOutput
        '
        Me.TotalIncomeOutput.Location = New System.Drawing.Point(411, 265)
        Me.TotalIncomeOutput.Name = "TotalIncomeOutput"
        Me.TotalIncomeOutput.ReadOnly = True
        Me.TotalIncomeOutput.Size = New System.Drawing.Size(153, 20)
        Me.TotalIncomeOutput.TabIndex = 6
        Me.TotalIncomeOutput.TabStop = False
        '
        'ClothingExpense
        '
        Me.ClothingExpense.Location = New System.Drawing.Point(110, 50)
        Me.ClothingExpense.Name = "ClothingExpense"
        Me.ClothingExpense.Size = New System.Drawing.Size(99, 20)
        Me.ClothingExpense.TabIndex = 0
        '
        'MiscExpense
        '
        Me.MiscExpense.Location = New System.Drawing.Point(110, 232)
        Me.MiscExpense.Name = "MiscExpense"
        Me.MiscExpense.Size = New System.Drawing.Size(99, 20)
        Me.MiscExpense.TabIndex = 7
        '
        'FoodExpense
        '
        Me.FoodExpense.Location = New System.Drawing.Point(110, 206)
        Me.FoodExpense.Name = "FoodExpense"
        Me.FoodExpense.Size = New System.Drawing.Size(99, 20)
        Me.FoodExpense.TabIndex = 6
        '
        'EntertainmentExpense
        '
        Me.EntertainmentExpense.Location = New System.Drawing.Point(110, 180)
        Me.EntertainmentExpense.Name = "EntertainmentExpense"
        Me.EntertainmentExpense.Size = New System.Drawing.Size(99, 20)
        Me.EntertainmentExpense.TabIndex = 5
        '
        'RentExpense
        '
        Me.RentExpense.Location = New System.Drawing.Point(110, 154)
        Me.RentExpense.Name = "RentExpense"
        Me.RentExpense.Size = New System.Drawing.Size(99, 20)
        Me.RentExpense.TabIndex = 4
        '
        'UtilExpense
        '
        Me.UtilExpense.Location = New System.Drawing.Point(110, 128)
        Me.UtilExpense.Name = "UtilExpense"
        Me.UtilExpense.Size = New System.Drawing.Size(99, 20)
        Me.UtilExpense.TabIndex = 3
        '
        'GasExpense
        '
        Me.GasExpense.Location = New System.Drawing.Point(110, 102)
        Me.GasExpense.Name = "GasExpense"
        Me.GasExpense.Size = New System.Drawing.Size(99, 20)
        Me.GasExpense.TabIndex = 2
        '
        'CarMaintenanceExpense
        '
        Me.CarMaintenanceExpense.Location = New System.Drawing.Point(110, 76)
        Me.CarMaintenanceExpense.Name = "CarMaintenanceExpense"
        Me.CarMaintenanceExpense.Size = New System.Drawing.Size(99, 20)
        Me.CarMaintenanceExpense.TabIndex = 1
        '
        'SellingIncome
        '
        Me.SellingIncome.Location = New System.Drawing.Point(411, 128)
        Me.SellingIncome.Name = "SellingIncome"
        Me.SellingIncome.Size = New System.Drawing.Size(99, 20)
        Me.SellingIncome.TabIndex = 11
        '
        'ExcessScholarshipIncome
        '
        Me.ExcessScholarshipIncome.Location = New System.Drawing.Point(411, 102)
        Me.ExcessScholarshipIncome.Name = "ExcessScholarshipIncome"
        Me.ExcessScholarshipIncome.Size = New System.Drawing.Size(99, 20)
        Me.ExcessScholarshipIncome.TabIndex = 10
        '
        'JobIncome
        '
        Me.JobIncome.Location = New System.Drawing.Point(411, 76)
        Me.JobIncome.Name = "JobIncome"
        Me.JobIncome.Size = New System.Drawing.Size(99, 20)
        Me.JobIncome.TabIndex = 9
        '
        'ParentIncome
        '
        Me.ParentIncome.Location = New System.Drawing.Point(411, 50)
        Me.ParentIncome.Name = "ParentIncome"
        Me.ParentIncome.Size = New System.Drawing.Size(99, 20)
        Me.ParentIncome.TabIndex = 8
        '
        'ClothesExpenseLbl
        '
        Me.ClothesExpenseLbl.AutoSize = True
        Me.ClothesExpenseLbl.Location = New System.Drawing.Point(58, 50)
        Me.ClothesExpenseLbl.Name = "ClothesExpenseLbl"
        Me.ClothesExpenseLbl.Size = New System.Drawing.Size(45, 13)
        Me.ClothesExpenseLbl.TabIndex = 24
        Me.ClothesExpenseLbl.Text = "Clothing"
        '
        'GasLbl
        '
        Me.GasLbl.AutoSize = True
        Me.GasLbl.Location = New System.Drawing.Point(52, 102)
        Me.GasLbl.Name = "GasLbl"
        Me.GasLbl.Size = New System.Drawing.Size(51, 13)
        Me.GasLbl.TabIndex = 25
        Me.GasLbl.Text = "Gas (Car)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Entertainment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Misc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Food"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Car Maintenance"
        '
        'SellIncomeLbl
        '
        Me.SellIncomeLbl.AutoSize = True
        Me.SellIncomeLbl.Location = New System.Drawing.Point(367, 128)
        Me.SellIncomeLbl.Name = "SellIncomeLbl"
        Me.SellIncomeLbl.Size = New System.Drawing.Size(38, 13)
        Me.SellIncomeLbl.TabIndex = 30
        Me.SellIncomeLbl.Text = "Selling"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Parents"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Utilities"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(74, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Rent"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(306, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Excess Scholarship"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(381, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Job"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Expenses Towards"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(340, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Income from"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Semester Balance"
        '
        'ClothingPercentage
        '
        Me.ClothingPercentage.Location = New System.Drawing.Point(215, 50)
        Me.ClothingPercentage.Name = "ClothingPercentage"
        Me.ClothingPercentage.ReadOnly = True
        Me.ClothingPercentage.Size = New System.Drawing.Size(49, 20)
        Me.ClothingPercentage.TabIndex = 40
        '
        'FoodPercentage
        '
        Me.FoodPercentage.Location = New System.Drawing.Point(215, 206)
        Me.FoodPercentage.Name = "FoodPercentage"
        Me.FoodPercentage.ReadOnly = True
        Me.FoodPercentage.Size = New System.Drawing.Size(49, 20)
        Me.FoodPercentage.TabIndex = 41
        '
        'EntertainmentPercentage
        '
        Me.EntertainmentPercentage.Location = New System.Drawing.Point(215, 180)
        Me.EntertainmentPercentage.Name = "EntertainmentPercentage"
        Me.EntertainmentPercentage.ReadOnly = True
        Me.EntertainmentPercentage.Size = New System.Drawing.Size(49, 20)
        Me.EntertainmentPercentage.TabIndex = 42
        '
        'RentPercentage
        '
        Me.RentPercentage.Location = New System.Drawing.Point(215, 154)
        Me.RentPercentage.Name = "RentPercentage"
        Me.RentPercentage.ReadOnly = True
        Me.RentPercentage.Size = New System.Drawing.Size(49, 20)
        Me.RentPercentage.TabIndex = 43
        '
        'UtilPercentage
        '
        Me.UtilPercentage.Location = New System.Drawing.Point(215, 128)
        Me.UtilPercentage.Name = "UtilPercentage"
        Me.UtilPercentage.ReadOnly = True
        Me.UtilPercentage.Size = New System.Drawing.Size(49, 20)
        Me.UtilPercentage.TabIndex = 44
        '
        'GasPercentage
        '
        Me.GasPercentage.Location = New System.Drawing.Point(215, 102)
        Me.GasPercentage.Name = "GasPercentage"
        Me.GasPercentage.ReadOnly = True
        Me.GasPercentage.Size = New System.Drawing.Size(49, 20)
        Me.GasPercentage.TabIndex = 45
        '
        'CarMaintenancePercentage
        '
        Me.CarMaintenancePercentage.Location = New System.Drawing.Point(215, 76)
        Me.CarMaintenancePercentage.Name = "CarMaintenancePercentage"
        Me.CarMaintenancePercentage.ReadOnly = True
        Me.CarMaintenancePercentage.Size = New System.Drawing.Size(49, 20)
        Me.CarMaintenancePercentage.TabIndex = 46
        '
        'MiscPercentage
        '
        Me.MiscPercentage.Location = New System.Drawing.Point(215, 232)
        Me.MiscPercentage.Name = "MiscPercentage"
        Me.MiscPercentage.ReadOnly = True
        Me.MiscPercentage.Size = New System.Drawing.Size(49, 20)
        Me.MiscPercentage.TabIndex = 47
        '
        'SellingPercentage
        '
        Me.SellingPercentage.Location = New System.Drawing.Point(516, 128)
        Me.SellingPercentage.Name = "SellingPercentage"
        Me.SellingPercentage.ReadOnly = True
        Me.SellingPercentage.Size = New System.Drawing.Size(49, 20)
        Me.SellingPercentage.TabIndex = 48
        '
        'ExcessScholarshipPercentage
        '
        Me.ExcessScholarshipPercentage.Location = New System.Drawing.Point(516, 102)
        Me.ExcessScholarshipPercentage.Name = "ExcessScholarshipPercentage"
        Me.ExcessScholarshipPercentage.ReadOnly = True
        Me.ExcessScholarshipPercentage.Size = New System.Drawing.Size(49, 20)
        Me.ExcessScholarshipPercentage.TabIndex = 49
        '
        'JobPercentage
        '
        Me.JobPercentage.Location = New System.Drawing.Point(516, 76)
        Me.JobPercentage.Name = "JobPercentage"
        Me.JobPercentage.ReadOnly = True
        Me.JobPercentage.Size = New System.Drawing.Size(49, 20)
        Me.JobPercentage.TabIndex = 50
        '
        'ParentPercentage
        '
        Me.ParentPercentage.Location = New System.Drawing.Point(516, 50)
        Me.ParentPercentage.Name = "ParentPercentage"
        Me.ParentPercentage.ReadOnly = True
        Me.ParentPercentage.Size = New System.Drawing.Size(49, 20)
        Me.ParentPercentage.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "% of Expenses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(507, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "% of Income"
        '
        'BalanceOutput
        '
        Me.BalanceOutput.AutoSize = True
        Me.BalanceOutput.Location = New System.Drawing.Point(326, 268)
        Me.BalanceOutput.Name = "BalanceOutput"
        Me.BalanceOutput.Size = New System.Drawing.Size(25, 13)
        Me.BalanceOutput.TabIndex = 55
        Me.BalanceOutput.Text = "[    ]"
        '
        'SemesterBudgeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 317)
        Me.Controls.Add(Me.BalanceOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ParentPercentage)
        Me.Controls.Add(Me.JobPercentage)
        Me.Controls.Add(Me.ExcessScholarshipPercentage)
        Me.Controls.Add(Me.SellingPercentage)
        Me.Controls.Add(Me.MiscPercentage)
        Me.Controls.Add(Me.CarMaintenancePercentage)
        Me.Controls.Add(Me.GasPercentage)
        Me.Controls.Add(Me.UtilPercentage)
        Me.Controls.Add(Me.RentPercentage)
        Me.Controls.Add(Me.EntertainmentPercentage)
        Me.Controls.Add(Me.FoodPercentage)
        Me.Controls.Add(Me.ClothingPercentage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SellIncomeLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GasLbl)
        Me.Controls.Add(Me.ClothesExpenseLbl)
        Me.Controls.Add(Me.ParentIncome)
        Me.Controls.Add(Me.JobIncome)
        Me.Controls.Add(Me.ExcessScholarshipIncome)
        Me.Controls.Add(Me.SellingIncome)
        Me.Controls.Add(Me.CarMaintenanceExpense)
        Me.Controls.Add(Me.GasExpense)
        Me.Controls.Add(Me.UtilExpense)
        Me.Controls.Add(Me.RentExpense)
        Me.Controls.Add(Me.EntertainmentExpense)
        Me.Controls.Add(Me.FoodExpense)
        Me.Controls.Add(Me.MiscExpense)
        Me.Controls.Add(Me.ClothingExpense)
        Me.Controls.Add(Me.TotalIncomeOutput)
        Me.Controls.Add(Me.TotalExpenseOutput)
        Me.Controls.Add(Me.TotalIncomeLbl)
        Me.Controls.Add(Me.TotalExpensesLbl)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Name = "SemesterBudgeter"
        Me.Text = "Semester Budgeter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculateBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents TotalExpensesLbl As Label
    Friend WithEvents TotalIncomeLbl As Label
    Friend WithEvents TotalExpenseOutput As TextBox
    Friend WithEvents TotalIncomeOutput As TextBox
    Friend WithEvents ClothingExpense As TextBox
    Friend WithEvents MiscExpense As TextBox
    Friend WithEvents FoodExpense As TextBox
    Friend WithEvents EntertainmentExpense As TextBox
    Friend WithEvents RentExpense As TextBox
    Friend WithEvents UtilExpense As TextBox
    Friend WithEvents GasExpense As TextBox
    Friend WithEvents CarMaintenanceExpense As TextBox
    Friend WithEvents SellingIncome As TextBox
    Friend WithEvents ExcessScholarshipIncome As TextBox
    Friend WithEvents JobIncome As TextBox
    Friend WithEvents ParentIncome As TextBox
    Friend WithEvents ClothesExpenseLbl As Label
    Friend WithEvents GasLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SellIncomeLbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ClothingPercentage As TextBox
    Friend WithEvents FoodPercentage As TextBox
    Friend WithEvents EntertainmentPercentage As TextBox
    Friend WithEvents RentPercentage As TextBox
    Friend WithEvents UtilPercentage As TextBox
    Friend WithEvents GasPercentage As TextBox
    Friend WithEvents CarMaintenancePercentage As TextBox
    Friend WithEvents MiscPercentage As TextBox
    Friend WithEvents SellingPercentage As TextBox
    Friend WithEvents ExcessScholarshipPercentage As TextBox
    Friend WithEvents JobPercentage As TextBox
    Friend WithEvents ParentPercentage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BalanceOutput As Label
End Class
