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
        Dim aboutBox As abbBox = New abbBox
        aboutBox.ShowDialog()
    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.Blue
        frmBMI.BackColor = Color.Blue
        frmMortgage.BackColor = Color.Blue
        frmPayrollCalculator.BackColor = Color.Blue
        frmCalorieCounter.BackColor = Color.Blue

    End Sub

    Private Sub YellowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YellowToolStripMenuItem.Click
        Me.BackColor = Color.Yellow
        frmBMI.BackColor = Color.Yellow
        frmMortgage.BackColor = Color.Yellow
        frmPayrollCalculator.BackColor = Color.Yellow
        frmCalorieCounter.BackColor = Color.Yellow


    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.Gray
        frmBMI.BackColor = Color.Gray
        frmMortgage.BackColor = Color.Gray
        frmPayrollCalculator.BackColor = Color.Gray
        frmCalorieCounter.BackColor = Color.Gray

    End Sub

    Private Sub btnPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayroll.Click, PayrollCalculatorToolStripMenuItem.Click

        Dim formPayroll As frmPayrollCalculator = New frmPayrollCalculator



        formPayroll.ShowDialog()

    End Sub

    
End Class
