<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalculator
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
        Me.lstPayroll = New System.Windows.Forms.ListBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnProduce = New System.Windows.Forms.Button
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'lstPayroll
        '
        Me.lstPayroll.FormattingEnabled = True
        Me.lstPayroll.Location = New System.Drawing.Point(1, 51)
        Me.lstPayroll.Name = "lstPayroll"
        Me.lstPayroll.Size = New System.Drawing.Size(431, 212)
        Me.lstPayroll.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(438, 120)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 40)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save to file"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnProduce
        '
        Me.btnProduce.Location = New System.Drawing.Point(438, 51)
        Me.btnProduce.Name = "btnProduce"
        Me.btnProduce.Size = New System.Drawing.Size(75, 40)
        Me.btnProduce.TabIndex = 2
        Me.btnProduce.Text = "&Produce Report"
        Me.btnProduce.UseVisualStyleBackColor = True
        '
        'frmPayrollCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 273)
        Me.Controls.Add(Me.btnProduce)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstPayroll)
        Me.Name = "frmPayrollCalculator"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPayroll As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnProduce As System.Windows.Forms.Button
    Friend WithEvents sfdSave As System.Windows.Forms.SaveFileDialog
End Class
