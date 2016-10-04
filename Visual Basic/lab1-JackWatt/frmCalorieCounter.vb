'
' Calorie Counter
' Jack Watt
'1/17/2012
'
' handled all error checking within the numeric updown
'you can physically input higher values then your set maximum
' but it changes it to the maximum before you can change controls 
'added a check to make sure value of the nud was within the min & max - 
'even when i typed outside of those numbers my validate function didn't pick it up.
'I find it intrigiging that even when I have a leave event the NUD changes it before I can flag it
'I'm going to look into that now. oh and sorry that my brief notes turned into a rant.


Public Class frmCalorieCounter
    Const MIN_CARBOHYDRATES As Integer = 0
    Const MAX_CARBOHYDRATES As Integer = 80
    Const MIN_FAT As Integer = 0
    Const MAX_FAT As Integer = 50
    Const MIN_PROTEIN As Integer = 0
    Const MAX_PROTEIN As Integer = 50



    Private Sub frmCalorieCounter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nudCarbohydrates.Maximum = MAX_CARBOHYDRATES
        nudCarbohydrates.Minimum = MIN_CARBOHYDRATES
        nudFat.Maximum = MAX_FAT
        nudFat.Minimum = MIN_FAT
        nudProtein.Maximum = MAX_PROTEIN
        nudProtein.Minimum = MIN_PROTEIN
        clear()
    End Sub
    Private Sub clear()
        lblCarbohydrates.Text = Convert.ToString(MIN_CARBOHYDRATES) + " - " + Convert.ToString(MAX_CARBOHYDRATES)
        lblFat.Text = Convert.ToString(MIN_FAT) + " - " + Convert.ToString(MAX_FAT)
        lblProtein.Text = Convert.ToString(MIN_PROTEIN) + " - " + Convert.ToString(MAX_PROTEIN)
        lblTotalCalories.Text = "Total Calories: "
        nudCarbohydrates.Value = 0
        nudFat.Value = 0
        nudProtein.Value = 0
    End Sub


    Private Sub nudCarbohydrates_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudCarbohydrates.Leave

        ValidData(nudCarbohydrates, MIN_CARBOHYDRATES, MAX_CARBOHYDRATES)

    End Sub
    Private Function ValidData(ByVal nud As NumericUpDown, ByVal min As Integer, ByVal max As Integer) As Boolean

        Dim result As Boolean = False
        'check to see if is numeric
        If Not IsNumeric(nud.Value) Then
            errData.SetError(nud, "must be numeric")
            nud.Focus()
            'make sure value is within bounds
        ElseIf nud.Value < min Or nud.Value > max Then
            errData.SetError(nud, "must be between " & min & " & " & max)
            nud.Focus()

        Else
            Dim value As Double = nud.Value

            If value = 0 Then
                result = True
                errData.Clear()
            Else
                'if value higher then 0 loops to find out if divisible by .5
                While value > 0
                    value = value - 0.5
                End While
                If value = 0 Then
                    result = True
                    errData.Clear()
                Else
                    'set error and prevent from leaving
                    errData.SetError(nud, "must be a a multiple of .5 (ex. 0.5 , 1.0 , 1.5...)")
                    nud.Focus()
                End If

                
            End If

        End If
        Return result
    End Function

    Private Sub btnComputeCalories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputeCalories.Click
        Dim carbohydrates As Double = Convert.ToDouble(nudCarbohydrates.Value)
        Dim fat As Double = Convert.ToDouble(nudFat.Value)
        Dim protein As Double = Convert.ToDouble(nudProtein.Value)
        compute(carbohydrates, fat, protein)
    End Sub

  

  
    Private Sub compute(ByVal carbohydrates As Double, ByVal fat As Double, ByVal protein As Double)
        Const CARBOHYDRATES_CALORIES As Integer = 4
        Const FAT_CALORIES As Integer = 9
        Const PROTEIN_CALORIES As Integer = 4
        Dim totalCalories As Double = 0

        totalCalories = (carbohydrates * CARBOHYDRATES_CALORIES) + (fat * FAT_CALORIES) + (protein * PROTEIN_CALORIES)
        lblTotalCalories.Text = "Total Calories: " + Convert.ToString(totalCalories)
    End Sub

    Private Sub nudFat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudFat.Leave
        ValidData(nudFat, MIN_FAT, MAX_FAT)
    End Sub

    Private Sub nudProtein_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudProtein.Leave
        ValidData(nudProtein, MIN_PROTEIN, MAX_PROTEIN)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class