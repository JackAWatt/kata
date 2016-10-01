'jack watt
'main form
'jan 19th 2012
Public Class frmMain
    'call to mortgage form
    Private Sub btnMortgageCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                            Handles btnMortgageCalculator.Click, MortgageCalculatorToolStripMenuItem.Click
        Dim formMortgage As frmMortgage = New frmMortgage
        formMortgage.ShowDialog()
    End Sub



    Private Sub CalorieCounter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                            Handles btnCalorieCounter.Click, CalorieCounterToolStripMenuItem.Click
        'call to calorie counter
        Dim formCalorieCounter As frmCalorieCounter = New frmCalorieCounter
        formCalorieCounter.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub BMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                            Handles btnBMI.Click, BodyMassIndexCaToolStripMenuItem.Click
        'call to BMI form
        Dim formBMI As frmBMI = New frmBMI
        formBMI.ShowDialog()


    End Sub



    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim abbBox As AbbBox = New AbbBox
        abbBox.ShowDialog()
    End Sub
End Class
