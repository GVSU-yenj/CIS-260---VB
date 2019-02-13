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
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.HoursLbl = New System.Windows.Forms.Label()
        Me.GrossPayAmtLbl = New System.Windows.Forms.Label()
        Me.RateLbl = New System.Windows.Forms.Label()
        Me.txtStateTax = New System.Windows.Forms.TextBox()
        Me.StateTaxLbl = New System.Windows.Forms.Label()
        Me.txtYTDPay = New System.Windows.Forms.TextBox()
        Me.YTDPayLbl = New System.Windows.Forms.Label()
        Me.txtSocialSecurity = New System.Windows.Forms.TextBox()
        Me.SocialSecurityTaxLbl = New System.Windows.Forms.Label()
        Me.txtMedicare = New System.Windows.Forms.TextBox()
        Me.MedicareTaxLbl = New System.Windows.Forms.Label()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.NetPayLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(299, 6)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 1
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(299, 47)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossPay.TabIndex = 12
        Me.txtGrossPay.TabStop = False
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(92, 6)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(100, 20)
        Me.txtPayRate.TabIndex = 0
        '
        'CalcBtn
        '
        Me.CalcBtn.Location = New System.Drawing.Point(32, 167)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(109, 37)
        Me.CalcBtn.TabIndex = 3
        Me.CalcBtn.Text = "Calculate"
        Me.CalcBtn.UseVisualStyleBackColor = True
        '
        'HoursLbl
        '
        Me.HoursLbl.AutoSize = True
        Me.HoursLbl.Location = New System.Drawing.Point(258, 9)
        Me.HoursLbl.Name = "HoursLbl"
        Me.HoursLbl.Size = New System.Drawing.Size(40, 15)
        Me.HoursLbl.TabIndex = 9
        Me.HoursLbl.Text = "Hours"
        '
        'GrossPayAmtLbl
        '
        Me.GrossPayAmtLbl.AutoSize = True
        Me.GrossPayAmtLbl.Location = New System.Drawing.Point(239, 47)
        Me.GrossPayAmtLbl.Name = "GrossPayAmtLbl"
        Me.GrossPayAmtLbl.Size = New System.Drawing.Size(61, 15)
        Me.GrossPayAmtLbl.TabIndex = 8
        Me.GrossPayAmtLbl.Text = "Gross pay"
        '
        'RateLbl
        '
        Me.RateLbl.AutoSize = True
        Me.RateLbl.Location = New System.Drawing.Point(40, 9)
        Me.RateLbl.Name = "RateLbl"
        Me.RateLbl.Size = New System.Drawing.Size(51, 15)
        Me.RateLbl.TabIndex = 7
        Me.RateLbl.Text = "Pay rate"
        '
        'txtStateTax
        '
        Me.txtStateTax.Location = New System.Drawing.Point(92, 86)
        Me.txtStateTax.Name = "txtStateTax"
        Me.txtStateTax.ReadOnly = True
        Me.txtStateTax.Size = New System.Drawing.Size(100, 20)
        Me.txtStateTax.TabIndex = 15
        Me.txtStateTax.TabStop = False
        '
        'StateTaxLbl
        '
        Me.StateTaxLbl.AutoSize = True
        Me.StateTaxLbl.Location = New System.Drawing.Point(37, 89)
        Me.StateTaxLbl.Name = "StateTaxLbl"
        Me.StateTaxLbl.Size = New System.Drawing.Size(54, 15)
        Me.StateTaxLbl.TabIndex = 14
        Me.StateTaxLbl.Text = "State tax"
        '
        'txtYTDPay
        '
        Me.txtYTDPay.Location = New System.Drawing.Point(92, 47)
        Me.txtYTDPay.Name = "txtYTDPay"
        Me.txtYTDPay.Size = New System.Drawing.Size(100, 20)
        Me.txtYTDPay.TabIndex = 2
        '
        'YTDPayLbl
        '
        Me.YTDPayLbl.AutoSize = True
        Me.YTDPayLbl.Location = New System.Drawing.Point(37, 50)
        Me.YTDPayLbl.Name = "YTDPayLbl"
        Me.YTDPayLbl.Size = New System.Drawing.Size(52, 15)
        Me.YTDPayLbl.TabIndex = 17
        Me.YTDPayLbl.Text = "YTD pay"
        '
        'txtSocialSecurity
        '
        Me.txtSocialSecurity.Location = New System.Drawing.Point(299, 89)
        Me.txtSocialSecurity.Name = "txtSocialSecurity"
        Me.txtSocialSecurity.ReadOnly = True
        Me.txtSocialSecurity.Size = New System.Drawing.Size(100, 20)
        Me.txtSocialSecurity.TabIndex = 19
        Me.txtSocialSecurity.TabStop = False
        '
        'SocialSecurityTaxLbl
        '
        Me.SocialSecurityTaxLbl.AutoSize = True
        Me.SocialSecurityTaxLbl.Location = New System.Drawing.Point(201, 92)
        Me.SocialSecurityTaxLbl.Name = "SocialSecurityTaxLbl"
        Me.SocialSecurityTaxLbl.Size = New System.Drawing.Size(104, 15)
        Me.SocialSecurityTaxLbl.TabIndex = 18
        Me.SocialSecurityTaxLbl.Text = "Social security tax"
        '
        'txtMedicare
        '
        Me.txtMedicare.Location = New System.Drawing.Point(92, 127)
        Me.txtMedicare.Name = "txtMedicare"
        Me.txtMedicare.ReadOnly = True
        Me.txtMedicare.Size = New System.Drawing.Size(100, 20)
        Me.txtMedicare.TabIndex = 21
        Me.txtMedicare.TabStop = False
        '
        'MedicareTaxLbl
        '
        Me.MedicareTaxLbl.AutoSize = True
        Me.MedicareTaxLbl.Location = New System.Drawing.Point(18, 131)
        Me.MedicareTaxLbl.Name = "MedicareTaxLbl"
        Me.MedicareTaxLbl.Size = New System.Drawing.Size(78, 15)
        Me.MedicareTaxLbl.TabIndex = 20
        Me.MedicareTaxLbl.Text = "Medicare tax"
        '
        'txtNetPay
        '
        Me.txtNetPay.Location = New System.Drawing.Point(299, 131)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(100, 20)
        Me.txtNetPay.TabIndex = 23
        Me.txtNetPay.TabStop = False
        '
        'NetPayLbl
        '
        Me.NetPayLbl.AutoSize = True
        Me.NetPayLbl.Location = New System.Drawing.Point(249, 138)
        Me.NetPayLbl.Name = "NetPayLbl"
        Me.NetPayLbl.Size = New System.Drawing.Size(48, 15)
        Me.NetPayLbl.TabIndex = 22
        Me.NetPayLbl.Text = "Net pay"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 213)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.NetPayLbl)
        Me.Controls.Add(Me.txtMedicare)
        Me.Controls.Add(Me.MedicareTaxLbl)
        Me.Controls.Add(Me.txtSocialSecurity)
        Me.Controls.Add(Me.SocialSecurityTaxLbl)
        Me.Controls.Add(Me.YTDPayLbl)
        Me.Controls.Add(Me.txtYTDPay)
        Me.Controls.Add(Me.txtStateTax)
        Me.Controls.Add(Me.StateTaxLbl)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.CalcBtn)
        Me.Controls.Add(Me.HoursLbl)
        Me.Controls.Add(Me.GrossPayAmtLbl)
        Me.Controls.Add(Me.RateLbl)
        Me.Name = "Form1"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtPayRate As TextBox
    Friend WithEvents CalcBtn As Button
    Friend WithEvents HoursLbl As Label
    Friend WithEvents GrossPayAmtLbl As Label
    Friend WithEvents RateLbl As Label
    Friend WithEvents txtStateTax As TextBox
    Friend WithEvents StateTaxLbl As Label
    Friend WithEvents txtYTDPay As TextBox
    Friend WithEvents YTDPayLbl As Label
    Friend WithEvents txtSocialSecurity As TextBox
    Friend WithEvents SocialSecurityTaxLbl As Label
    Friend WithEvents txtMedicare As TextBox
    Friend WithEvents MedicareTaxLbl As Label
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents NetPayLbl As Label
End Class
