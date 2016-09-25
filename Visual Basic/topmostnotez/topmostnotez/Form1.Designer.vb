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
        Me.mnuTop = New System.Windows.Forms.ToolStripMenuItem
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Process1 = New System.Diagnostics.Process
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.mnuFont = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLoad = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.color = New System.Windows.Forms.MenuStrip
        Me.btnTopmost = New System.Windows.Forms.Button
        Me.NotezToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.color.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTop
        '
        Me.mnuTop.Name = "mnuTop"
        Me.mnuTop.Size = New System.Drawing.Size(143, 22)
        Me.mnuTop.Text = "Top Most off"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(284, 228)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'mnuColor
        '
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(143, 22)
        Me.mnuColor.Text = "&Color..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'mnuFont
        '
        Me.mnuFont.Name = "mnuFont"
        Me.mnuFont.Size = New System.Drawing.Size(143, 22)
        Me.mnuFont.Text = "&Font..."
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuLoad, Me.mnuExit, Me.mnuAbout})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(116, 22)
        Me.mnuSave.Text = "&Save..."
        '
        'mnuLoad
        '
        Me.mnuLoad.Name = "mnuLoad"
        Me.mnuLoad.Size = New System.Drawing.Size(116, 22)
        Me.mnuLoad.Text = "&Load..."
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(116, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(116, 22)
        Me.mnuAbout.Text = "&About..."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFont, Me.mnuColor, Me.mnuTop})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'color
        '
        Me.color.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.color.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.NotezToolStripMenuItem})
        Me.color.Location = New System.Drawing.Point(0, 0)
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(284, 24)
        Me.color.TabIndex = 4
        Me.color.Text = "MenuStrip1"
        '
        'btnTopmost
        '
        Me.btnTopmost.BackColor = System.Drawing.Color.GreenYellow
        Me.btnTopmost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnTopmost.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTopmost.Location = New System.Drawing.Point(0, 252)
        Me.btnTopmost.Name = "btnTopmost"
        Me.btnTopmost.Size = New System.Drawing.Size(284, 10)
        Me.btnTopmost.TabIndex = 5
        Me.btnTopmost.UseVisualStyleBackColor = False
        '
        'NotezToolStripMenuItem
        '
        Me.NotezToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
        Me.NotezToolStripMenuItem.Name = "NotezToolStripMenuItem"
        Me.NotezToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.NotezToolStripMenuItem.Text = "&Notez"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.color)
        Me.Controls.Add(Me.btnTopmost)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.color.ResumeLayout(False)
        Me.color.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents mnuColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents color As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTopmost As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NotezToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
