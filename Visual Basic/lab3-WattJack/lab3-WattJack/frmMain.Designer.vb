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
        Me.btnAnalyzeGrades = New System.Windows.Forms.Button
        Me.lstCurvingGrades = New System.Windows.Forms.ListBox
        Me.ofdScores = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'btnAnalyzeGrades
        '
        Me.btnAnalyzeGrades.Location = New System.Drawing.Point(77, 26)
        Me.btnAnalyzeGrades.Name = "btnAnalyzeGrades"
        Me.btnAnalyzeGrades.Size = New System.Drawing.Size(75, 23)
        Me.btnAnalyzeGrades.TabIndex = 0
        Me.btnAnalyzeGrades.Text = "Analyze"
        Me.btnAnalyzeGrades.UseVisualStyleBackColor = True
        '
        'lstCurvingGrades
        '
        Me.lstCurvingGrades.FormattingEnabled = True
        Me.lstCurvingGrades.Location = New System.Drawing.Point(12, 78)
        Me.lstCurvingGrades.Name = "lstCurvingGrades"
        Me.lstCurvingGrades.Size = New System.Drawing.Size(208, 264)
        Me.lstCurvingGrades.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 361)
        Me.Controls.Add(Me.lstCurvingGrades)
        Me.Controls.Add(Me.btnAnalyzeGrades)
        Me.Name = "frmMain"
        Me.Text = "Analyze"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAnalyzeGrades As System.Windows.Forms.Button
    Friend WithEvents lstCurvingGrades As System.Windows.Forms.ListBox
    Friend WithEvents ofdScores As System.Windows.Forms.OpenFileDialog

End Class
