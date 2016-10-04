Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetData()
    End Sub
    Function resetData() As Boolean
        radStraightLine.Checked = True
        lstSchedule.Items.Clear()
        txtDescription.Clear()
        txtStart.Clear()
        nudYears.Value = 5
        txtDescription.Select()




        Return resetData
    End Function

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        resetData()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to close the program?", "exit?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If


    End Sub

    Private Sub btnCreateSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSchedule.Click

    End Sub
    Function isValidData() As Boolean
        Dim yesNo As Boolean = False

        If txtDescription.Text = "" Then
            yesNo = False
        ElseIf Not IsNumeric(txtStart) Then
            yesNo = False
        ElseIf txtStart.Text < 500 Then



        End If
        Return isValidData
    End Function
End Class
