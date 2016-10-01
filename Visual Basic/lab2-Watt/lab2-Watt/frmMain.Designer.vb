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
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnBMI = New System.Windows.Forms.Button
        Me.btnMortgageCalculator = New System.Windows.Forms.Button
        Me.CalorieCounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MortgageCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BodyMassIndexCaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PayrollCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCalorieCounter = New System.Windows.Forms.Button
        Me.btnPayroll = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'btnBMI
        '
        Me.btnBMI.Location = New System.Drawing.Point(56, 213)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(164, 48)
        Me.btnBMI.TabIndex = 6
        Me.btnBMI.Text = "Body Mass Index Calculator"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnMortgageCalculator
        '
        Me.btnMortgageCalculator.Location = New System.Drawing.Point(56, 159)
        Me.btnMortgageCalculator.Name = "btnMortgageCalculator"
        Me.btnMortgageCalculator.Size = New System.Drawing.Size(164, 48)
        Me.btnMortgageCalculator.TabIndex = 5
        Me.btnMortgageCalculator.Text = "Mortgage Calculator"
        Me.btnMortgageCalculator.UseVisualStyleBackColor = True
        '
        'CalorieCounterToolStripMenuItem
        '
        Me.CalorieCounterToolStripMenuItem.Name = "CalorieCounterToolStripMenuItem"
        Me.CalorieCounterToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CalorieCounterToolStripMenuItem.Text = "&Calorie Counter"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.PreferencesToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackColourToolStripMenuItem})
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'BackColourToolStripMenuItem
        '
        Me.BackColourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YellowToolStripMenuItem, Me.BlueToolStripMenuItem, Me.DefaultToolStripMenuItem})
        Me.BackColourToolStripMenuItem.Name = "BackColourToolStripMenuItem"
        Me.BackColourToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackColourToolStripMenuItem.Text = "&Back Colour"
        '
        'YellowToolStripMenuItem
        '
        Me.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        Me.YellowToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.YellowToolStripMenuItem.Text = "&Yellow"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueToolStripMenuItem.Text = "&Blue"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DefaultToolStripMenuItem.Text = "&Default"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MortgageCalculatorToolStripMenuItem, Me.BodyMassIndexCaToolStripMenuItem, Me.CalorieCounterToolStripMenuItem, Me.PayrollCalculatorToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'MortgageCalculatorToolStripMenuItem
        '
        Me.MortgageCalculatorToolStripMenuItem.Name = "MortgageCalculatorToolStripMenuItem"
        Me.MortgageCalculatorToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.MortgageCalculatorToolStripMenuItem.Text = "&Mortgage Calculator"
        '
        'BodyMassIndexCaToolStripMenuItem
        '
        Me.BodyMassIndexCaToolStripMenuItem.Name = "BodyMassIndexCaToolStripMenuItem"
        Me.BodyMassIndexCaToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.BodyMassIndexCaToolStripMenuItem.Text = "&Body Mass Index Calculator"
        '
        'PayrollCalculatorToolStripMenuItem
        '
        Me.PayrollCalculatorToolStripMenuItem.Name = "PayrollCalculatorToolStripMenuItem"
        Me.PayrollCalculatorToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.PayrollCalculatorToolStripMenuItem.Text = "&Payroll Calculator"
        '
        'btnCalorieCounter
        '
        Me.btnCalorieCounter.Location = New System.Drawing.Point(56, 105)
        Me.btnCalorieCounter.Name = "btnCalorieCounter"
        Me.btnCalorieCounter.Size = New System.Drawing.Size(164, 48)
        Me.btnCalorieCounter.TabIndex = 7
        Me.btnCalorieCounter.Text = "Calorie Counter"
        Me.btnCalorieCounter.UseVisualStyleBackColor = True
        '
        'btnPayroll
        '
        Me.btnPayroll.Location = New System.Drawing.Point(56, 50)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(164, 49)
        Me.btnPayroll.TabIndex = 8
        Me.btnPayroll.Text = "&Payroll Calculator"
        Me.btnPayroll.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.btnPayroll)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btnMortgageCalculator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCalorieCounter)
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBMI As System.Windows.Forms.Button
    Friend WithEvents btnMortgageCalculator As System.Windows.Forms.Button
    Friend WithEvents CalorieCounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MortgageCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BodyMassIndexCaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCalorieCounter As System.Windows.Forms.Button
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackColourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPayroll As System.Windows.Forms.Button

End Class
