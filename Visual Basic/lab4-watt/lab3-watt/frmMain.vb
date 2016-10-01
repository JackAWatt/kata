'main form, used to call off to other forms
'created by jack watt
'feb 2011
Public Class frmMain

    Private Sub bcYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcYellow.Click
        Me.BackColor = Color.Yellow()


    End Sub

    Private Sub bcCyan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcCyan.Click
        Me.BackColor = Color.Cyan()
      

    End Sub

    Private Sub bcDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcDefault.Click
        Me.BackColor = Color.Gray()
        
    End Sub


    Private Sub mnuCraps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCraps.Click, btnCraps.Click
        Dim crapsGame As New FrmCrapsGame
        crapsGame.BackColor = Me.BackColor
        crapsGame.Show()

    End Sub

 

    Private Sub btnBMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBMI.Click, mnuBMI.Click
        Dim BMI As New frmBMI
        BMI.BackColor = Me.BackColor
        BMI.Show()
    End Sub


    Private Sub btnMortgage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMortgage.Click, mnuMortgage.Click

        Dim mortgage As New frmMortgage
        mortgage.BackColor = Me.BackColor
        frmMortgage.Show()

    End Sub

  
End Class