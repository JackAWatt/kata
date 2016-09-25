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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstSchedule = New System.Windows.Forms.ListBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtStart = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radDoubleDeclining = New System.Windows.Forms.RadioButton
        Me.radStraightLine = New System.Windows.Forms.RadioButton
        Me.btnCreateSchedule = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.nudYears = New System.Windows.Forms.NumericUpDown
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudYears, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Starting Value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Years:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Schedule:"
        '
        'lstSchedule
        '
        Me.lstSchedule.FormattingEnabled = True
        Me.lstSchedule.Location = New System.Drawing.Point(371, 45)
        Me.lstSchedule.Name = "lstSchedule"
        Me.lstSchedule.Size = New System.Drawing.Size(290, 264)
        Me.lstSchedule.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(106, 30)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 6
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(106, 56)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(100, 20)
        Me.txtStart.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDoubleDeclining)
        Me.GroupBox1.Controls.Add(Me.radStraightLine)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'radDoubleDeclining
        '
        Me.radDoubleDeclining.AutoSize = True
        Me.radDoubleDeclining.Location = New System.Drawing.Point(16, 54)
        Me.radDoubleDeclining.Name = "radDoubleDeclining"
        Me.radDoubleDeclining.Size = New System.Drawing.Size(106, 17)
        Me.radDoubleDeclining.TabIndex = 1
        Me.radDoubleDeclining.TabStop = True
        Me.radDoubleDeclining.Text = "Double-Declining"
        Me.radDoubleDeclining.UseVisualStyleBackColor = True
        '
        'radStraightLine
        '
        Me.radStraightLine.AutoSize = True
        Me.radStraightLine.Location = New System.Drawing.Point(16, 30)
        Me.radStraightLine.Name = "radStraightLine"
        Me.radStraightLine.Size = New System.Drawing.Size(84, 17)
        Me.radStraightLine.TabIndex = 0
        Me.radStraightLine.TabStop = True
        Me.radStraightLine.Text = "Straight-Line"
        Me.radStraightLine.UseVisualStyleBackColor = True
        '
        'btnCreateSchedule
        '
        Me.btnCreateSchedule.Location = New System.Drawing.Point(276, 45)
        Me.btnCreateSchedule.Name = "btnCreateSchedule"
        Me.btnCreateSchedule.Size = New System.Drawing.Size(75, 42)
        Me.btnCreateSchedule.TabIndex = 10
        Me.btnCreateSchedule.Text = "&Create Schedule"
        Me.btnCreateSchedule.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(276, 115)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 42)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(276, 191)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 42)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'nudYears
        '
        Me.nudYears.Location = New System.Drawing.Point(106, 85)
        Me.nudYears.Name = "nudYears"
        Me.nudYears.Size = New System.Drawing.Size(100, 20)
        Me.nudYears.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 321)
        Me.Controls.Add(Me.nudYears)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCreateSchedule)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lstSchedule)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudYears, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstSchedule As System.Windows.Forms.ListBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radDoubleDeclining As System.Windows.Forms.RadioButton
    Friend WithEvents radStraightLine As System.Windows.Forms.RadioButton
    Friend WithEvents btnCreateSchedule As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents nudYears As System.Windows.Forms.NumericUpDown

End Class
