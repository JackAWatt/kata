<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmBMI
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
        Me.lblBMI = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCompute = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtFeet = New System.Windows.Forms.TextBox
        Me.txtInches = New System.Windows.Forms.TextBox
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblBMI
        '
        Me.lblBMI.Location = New System.Drawing.Point(-3, 122)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(240, 23)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(171, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 14)
        Me.Label5.Text = "in"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(108, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.Text = "&ft"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.Text = "&Height:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.Text = "&Weight:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(129, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.Text = "pounds"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(17, 228)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 43
        Me.btnCompute.Text = "&Compute"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(111, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 44
        Me.btnClear.Text = "C&lear"
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(72, 88)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(30, 21)
        Me.txtFeet.TabIndex = 41
        Me.txtFeet.Text = "5"
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(139, 88)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(26, 21)
        Me.txtInches.TabIndex = 42
        Me.txtInches.Text = "10"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(72, 18)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(51, 21)
        Me.txtWeight.TabIndex = 40
        Me.txtWeight.Text = "190"
        '
        'frmBMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.txtWeight)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmBMI"
        Me.Text = "frmBMI"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBMI As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtFeet As System.Windows.Forms.TextBox
    Friend WithEvents txtInches As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
End Class
