<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
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
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.bcYellow = New System.Windows.Forms.MenuItem
        Me.bcCyan = New System.Windows.Forms.MenuItem
        Me.bcDefault = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.mnuCraps = New System.Windows.Forms.MenuItem
        Me.mnuBMI = New System.Windows.Forms.MenuItem
        Me.mnuMortgage = New System.Windows.Forms.MenuItem
        Me.btnCraps = New System.Windows.Forms.Button
        Me.btnBMI = New System.Windows.Forms.Button
        Me.btnMortgage = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem6)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem1.Text = "Preferences"
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.bcYellow)
        Me.MenuItem2.MenuItems.Add(Me.bcCyan)
        Me.MenuItem2.MenuItems.Add(Me.bcDefault)
        Me.MenuItem2.Text = "Back Colour"
        '
        'bcYellow
        '
        Me.bcYellow.Text = "Yellow"
        '
        'bcCyan
        '
        Me.bcCyan.Text = "Cyan"
        '
        'bcDefault
        '
        Me.bcDefault.Text = "Default"
        '
        'MenuItem6
        '
        Me.MenuItem6.MenuItems.Add(Me.mnuCraps)
        Me.MenuItem6.MenuItems.Add(Me.mnuBMI)
        Me.MenuItem6.MenuItems.Add(Me.mnuMortgage)
        Me.MenuItem6.Text = "Tools"
        '
        'mnuCraps
        '
        Me.mnuCraps.Text = "Craps"
        '
        'mnuBMI
        '
        Me.mnuBMI.Text = "BMI"
        '
        'mnuMortgage
        '
        Me.mnuMortgage.Text = "Mortgage"
        '
        'btnCraps
        '
        Me.btnCraps.Location = New System.Drawing.Point(42, 181)
        Me.btnCraps.Name = "btnCraps"
        Me.btnCraps.Size = New System.Drawing.Size(160, 42)
        Me.btnCraps.TabIndex = 1
        Me.btnCraps.Text = "Craps"
        '
        'btnBMI
        '
        Me.btnBMI.Location = New System.Drawing.Point(40, 113)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(160, 42)
        Me.btnBMI.TabIndex = 2
        Me.btnBMI.Text = "Body Mass Index"
        '
        'btnMortgage
        '
        Me.btnMortgage.Location = New System.Drawing.Point(40, 42)
        Me.btnMortgage.Name = "btnMortgage"
        Me.btnMortgage.Size = New System.Drawing.Size(160, 42)
        Me.btnMortgage.TabIndex = 3
        Me.btnMortgage.Text = "Mortgage"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnMortgage)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btnCraps)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmMain"
        Me.Text = "Lab 4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCraps As System.Windows.Forms.Button
    Friend WithEvents btnBMI As System.Windows.Forms.Button
    Friend WithEvents btnMortgage As System.Windows.Forms.Button
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents bcYellow As System.Windows.Forms.MenuItem
    Friend WithEvents bcCyan As System.Windows.Forms.MenuItem
    Friend WithEvents bcDefault As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCraps As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBMI As System.Windows.Forms.MenuItem

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents mnuMortgage As System.Windows.Forms.MenuItem
End Class
