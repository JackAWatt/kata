<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmCrapsGame
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
        Me.mnuPlay = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnuShowStats = New System.Windows.Forms.MenuItem
        Me.mnuClear = New System.Windows.Forms.MenuItem
        Me.lblShowHide = New System.Windows.Forms.Label
        Me.txtGameStatus = New System.Windows.Forms.TextBox
        Me.txtGames = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ltbStat = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.mnuPlay)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'mnuPlay
        '
        Me.mnuPlay.Text = "Play"
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.mnuShowStats)
        Me.MenuItem2.MenuItems.Add(Me.mnuClear)
        Me.MenuItem2.Text = "More"
        '
        'mnuShowStats
        '
        Me.mnuShowStats.Text = "Show Stats"
        '
        'mnuClear
        '
        Me.mnuClear.Text = "Clear"
        '
        'lblShowHide
        '
        Me.lblShowHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblShowHide.Location = New System.Drawing.Point(34, 69)
        Me.lblShowHide.Name = "lblShowHide"
        Me.lblShowHide.Size = New System.Drawing.Size(173, 16)
        Me.lblShowHide.Text = "Detail of Games"
        '
        'txtGameStatus
        '
        Me.txtGameStatus.Location = New System.Drawing.Point(34, 88)
        Me.txtGameStatus.Multiline = True
        Me.txtGameStatus.Name = "txtGameStatus"
        Me.txtGameStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGameStatus.Size = New System.Drawing.Size(173, 144)
        Me.txtGameStatus.TabIndex = 7
        '
        'txtGames
        '
        Me.txtGames.Location = New System.Drawing.Point(96, 24)
        Me.txtGames.Name = "txtGames"
        Me.txtGames.Size = New System.Drawing.Size(70, 21)
        Me.txtGames.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.Text = "Games to Play:"
        '
        'ltbStat
        '
        Me.ltbStat.Location = New System.Drawing.Point(34, 88)
        Me.ltbStat.Name = "ltbStat"
        Me.ltbStat.Size = New System.Drawing.Size(173, 156)
        Me.ltbStat.TabIndex = 9
        Me.ltbStat.Visible = False
        '
        'FrmCrapsGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.ltbStat)
        Me.Controls.Add(Me.lblShowHide)
        Me.Controls.Add(Me.txtGameStatus)
        Me.Controls.Add(Me.txtGames)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "FrmCrapsGame"
        Me.Text = "frmCraps"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblShowHide As System.Windows.Forms.Label
    Friend WithEvents txtGameStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtGames As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mnuPlay As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuShowStats As System.Windows.Forms.MenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.MenuItem
    Friend WithEvents ltbStat As System.Windows.Forms.ListBox
End Class
