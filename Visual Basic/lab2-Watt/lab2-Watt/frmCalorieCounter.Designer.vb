<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalorieCounter
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.nudCarbohydrates = New System.Windows.Forms.NumericUpDown
        Me.nudFat = New System.Windows.Forms.NumericUpDown
        Me.nudProtein = New System.Windows.Forms.NumericUpDown
        Me.btnComputeCalories = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.errData = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblCarbohydrates = New System.Windows.Forms.Label
        Me.lblFat = New System.Windows.Forms.Label
        Me.lblProtein = New System.Windows.Forms.Label
        Me.lblTotalCalories = New System.Windows.Forms.Label
        CType(Me.nudCarbohydrates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudProtein, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Grams Of Carbohydrates"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Grams Of Fat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grams Of Protein"
        '
        'nudCarbohydrates
        '
        Me.nudCarbohydrates.DecimalPlaces = 1
        Me.nudCarbohydrates.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudCarbohydrates.Location = New System.Drawing.Point(152, 12)
        Me.nudCarbohydrates.Name = "nudCarbohydrates"
        Me.nudCarbohydrates.Size = New System.Drawing.Size(48, 20)
        Me.nudCarbohydrates.TabIndex = 0
        '
        'nudFat
        '
        Me.nudFat.DecimalPlaces = 1
        Me.nudFat.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudFat.Location = New System.Drawing.Point(152, 38)
        Me.nudFat.Name = "nudFat"
        Me.nudFat.Size = New System.Drawing.Size(48, 20)
        Me.nudFat.TabIndex = 1
        '
        'nudProtein
        '
        Me.nudProtein.DecimalPlaces = 1
        Me.nudProtein.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudProtein.Location = New System.Drawing.Point(152, 64)
        Me.nudProtein.Name = "nudProtein"
        Me.nudProtein.Size = New System.Drawing.Size(48, 20)
        Me.nudProtein.TabIndex = 2
        '
        'btnComputeCalories
        '
        Me.btnComputeCalories.Location = New System.Drawing.Point(12, 116)
        Me.btnComputeCalories.Name = "btnComputeCalories"
        Me.btnComputeCalories.Size = New System.Drawing.Size(78, 38)
        Me.btnComputeCalories.TabIndex = 6
        Me.btnComputeCalories.Text = "&Compute"
        Me.btnComputeCalories.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(96, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 38)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(180, 116)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 38)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'errData
        '
        Me.errData.ContainerControl = Me
        '
        'lblCarbohydrates
        '
        Me.lblCarbohydrates.AutoSize = True
        Me.lblCarbohydrates.Location = New System.Drawing.Point(207, 13)
        Me.lblCarbohydrates.Name = "lblCarbohydrates"
        Me.lblCarbohydrates.Size = New System.Drawing.Size(0, 13)
        Me.lblCarbohydrates.TabIndex = 9
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.Location = New System.Drawing.Point(207, 40)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(0, 13)
        Me.lblFat.TabIndex = 10
        '
        'lblProtein
        '
        Me.lblProtein.AutoSize = True
        Me.lblProtein.Location = New System.Drawing.Point(207, 66)
        Me.lblProtein.Name = "lblProtein"
        Me.lblProtein.Size = New System.Drawing.Size(0, 13)
        Me.lblProtein.TabIndex = 11
        '
        'lblTotalCalories
        '
        Me.lblTotalCalories.AutoSize = True
        Me.lblTotalCalories.Location = New System.Drawing.Point(24, 97)
        Me.lblTotalCalories.Name = "lblTotalCalories"
        Me.lblTotalCalories.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalCalories.TabIndex = 12
        '
        'frmCalorieCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblTotalCalories)
        Me.Controls.Add(Me.lblProtein)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCarbohydrates)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnComputeCalories)
        Me.Controls.Add(Me.nudProtein)
        Me.Controls.Add(Me.nudFat)
        Me.Controls.Add(Me.nudCarbohydrates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCalorieCounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calorie Counter"
        CType(Me.nudCarbohydrates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudProtein, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudCarbohydrates As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFat As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudProtein As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnComputeCalories As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents errData As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblProtein As System.Windows.Forms.Label
    Friend WithEvents lblFat As System.Windows.Forms.Label
    Friend WithEvents lblCarbohydrates As System.Windows.Forms.Label
    Friend WithEvents lblTotalCalories As System.Windows.Forms.Label
End Class
