Imports System.IO
Imports System.Windows.Forms
Public Class noteForm
    Dim changed As Boolean = False

    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        Else
            Try

                RichTextBox1.SaveFile(SaveFileDialog1.FileName)


                If File.Exists(SaveFileDialog1.FileName) Then
                    MessageBox.Show("ok")
                    changed = False 'resets changed boolean for prompt on exit
                Else

                End If
            Catch ex As Exception

                MessageBox.Show(ex.ToString)

            End Try


        End If
    End Sub

    Private Sub mnuLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLoad.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        Else

            Try

                RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try


        End If

    End Sub

    Private Sub mnuFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFont.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        Else
            FontDialog1.ShowDialog()
            RichTextBox1.Font = FontDialog1.Font
        End If

    End Sub

    Private Sub mnuColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        Else
            Me.BackColor = ColorDialog1.Color
            Me.RichTextBox1.BackColor = ColorDialog1.Color
        End If


    End Sub

    Private Sub mnuTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTop.Click
        tm()
    End Sub
    Sub tm()
        If Me.TopMost = True Then
            mnuTop.Text = "Top Most on"
            btnTopmost.BackColor = Drawing.Color.Red
            Me.TopMost = False

        Else
            mnuTop.Text = "top most off"
            btnTopmost.BackColor = Drawing.Color.GreenYellow
            Me.TopMost = True

        End If

    End Sub

    Private Sub btnTopmost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopmost.Click
        tm()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        changed = True
    End Sub
End Class