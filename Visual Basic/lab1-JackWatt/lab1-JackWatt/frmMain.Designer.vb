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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MortgageCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BodyMassIndexCaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalorieCounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnMortgageCalculator = New System.Windows.Forms.Button
        Me.btnBMI = New System.Windows.Forms.Button
        Me.btnCalorieCounter = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MortgageCalculatorToolStripMenuItem, Me.BodyMassIndexCaToolStripMenuItem, Me.CalorieCounterToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
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
        'CalorieCounterToolStripMenuItem
        '
        Me.CalorieCounterToolStripMenuItem.Name = "CalorieCounterToolStripMenuItem"
        Me.CalorieCounterToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CalorieCounterToolStripMenuItem.Text = "&Calorie Counter"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'btnMortgageCalculator
        '
        Me.btnMortgageCalculator.Location = New System.Drawing.Point(56, 128)
        Me.btnMortgageCalculator.Name = "btnMortgageCalculator"
        Me.btnMortgageCalculator.Size = New System.Drawing.Size(164, 48)
        Me.btnMortgageCalculator.TabIndex = 1
        Me.btnMortgageCalculator.Text = "Mortgage Calculator"
        Me.btnMortgageCalculator.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Location = New System.Drawing.Point(56, 202)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(164, 48)
        Me.btnBMI.TabIndex = 2
        Me.btnBMI.Text = "Body Mass Index Calculator"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnCalorieCounter
        '
        Me.btnCalorieCounter.Location = New System.Drawing.Point(56, 52)
        Me.btnCalorieCounter.Name = "btnCalorieCounter"
        Me.btnCalorieCounter.Size = New System.Drawing.Size(164, 48)
        Me.btnCalorieCounter.TabIndex = 3
        Me.btnCalorieCounter.Text = "Calorie Counter"
        Me.btnCalorieCounter.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCalorieCounter)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btnMortgageCalculator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MortgageCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BodyMassIndexCaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalorieCounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMortgageCalculator As System.Windows.Forms.Button
    Friend WithEvents btnBMI As System.Windows.Forms.Button
    Friend WithEvents btnCalorieCounter As System.Windows.Forms.Button

End Class
