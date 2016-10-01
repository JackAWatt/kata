<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMortgage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.txtLoanAmount = New System.Windows.Forms.TextBox
        Me.txtDuration = New System.Windows.Forms.TextBox
        Me.txtInterestRate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAnalyze = New System.Windows.Forms.Button
        Me.lblPayment = New System.Windows.Forms.Label
        Me.lblTotalInterest = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Location = New System.Drawing.Point(3, 16)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(100, 21)
        Me.txtLoanAmount.TabIndex = 0
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(3, 95)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 21)
        Me.txtDuration.TabIndex = 1
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(3, 56)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 21)
        Me.txtInterestRate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(109, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.Text = "Loan Ammount"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(109, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "duration"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(109, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "intrest Rate"
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(20, 198)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(72, 20)
        Me.btnAnalyze.TabIndex = 8
        Me.btnAnalyze.Text = "Analyze"
        '
        'lblPayment
        '
        Me.lblPayment.Location = New System.Drawing.Point(3, 132)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(237, 20)
        '
        'lblTotalInterest
        '
        Me.lblTotalInterest.Location = New System.Drawing.Point(3, 175)
        Me.lblTotalInterest.Name = "lblTotalInterest"
        Me.lblTotalInterest.Size = New System.Drawing.Size(237, 20)
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(122, 198)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 20)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        '
        'frmMortgage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotalInterest)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmMortgage"
        Me.Text = "frmMortgage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLoanAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAnalyze As System.Windows.Forms.Button
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblTotalInterest As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
