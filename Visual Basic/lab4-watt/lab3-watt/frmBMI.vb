Option Strict On
Public Class frmBMI
    Const MIN_WEIGHT As Double = 75, MAX_WEIGHT As Double = 500
    Const MIN_FEET As Integer = 3, MAX_FEET As Integer = 8
    Const MIN_INCHES As Integer = 0, MAX_INCHES As Integer = 11

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        If Not MissingData() Then
            Dim weight As Double, feet As Integer
            Dim inches As Integer, height As Double
            Dim bmi As Double
            Const POUND_KG As Double = 2.2
            'get the data
            weight = Convert.ToDouble(txtWeight.Text)
            feet = Convert.ToInt32(txtFeet.Text)
            inches = Convert.ToInt32(txtInches.Text)
            'do conversions
            weight = weight / POUND_KG  'now in kg
            height = feet * 12 + inches 'now in inches
            height = height * 2.54 / 100 'now in metres
            bmi = weight / height ^ 2
            lblBMI.Text = FormatNumber(bmi, 1)
        End If
    End Sub



    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtWeight.Text = ""
        txtInches.Text = ""
        txtFeet.Text = ""
        lblBMI.Text = ""
        txtWeight.Focus()
    End Sub
    Private Sub txtWeight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWeight.LostFocus
        ValidateTextBox(txtWeight, MIN_WEIGHT, MAX_WEIGHT, "Weight")
    End Sub
    Private Sub txtFeet_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFeet.LostFocus
        ValidateTextBox(txtFeet, MIN_FEET, MAX_FEET, "Feet")
    End Sub
    Private Sub txtInches_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInches.LostFocus
        ValidateTextBox(txtInches, MIN_INCHES, MAX_INCHES, "Inches")
    End Sub

    Private Sub ValidateTextBox(ByVal txtBox As TextBox, _
        ByVal min As Double, ByVal max As Double, ByVal item As String)
        If txtBox.Text <> "" Then
            If Not IsNumeric(txtBox.Text) Then
                MessageBox.Show(item & " must be a number.", "Data Entry Error")
                txtBox.Focus()
                txtBox.SelectAll()
            Else
                Dim value As Double
                value = Convert.ToDouble(txtBox.Text)
                If value < min Or value > max Then
                    MessageBox.Show(item & " must be between " & min & _
                            " and " & max & ".", "Data Entry Error")
                    txtBox.Focus()
                    txtBox.SelectAll()
                End If
            End If
        End If
    End Sub

    Private Function MissingData() As Boolean
        Dim result As Boolean = True
        If txtWeight.Text = "" Then
            MessageBox.Show("Weight is required.", "Data Missing")
            txtWeight.Focus()
        ElseIf txtFeet.Text = "" Then
            MessageBox.Show("Feet is required.", "Data Misisng")
            txtFeet.Focus()
        ElseIf txtInches.Text = "" Then
            MessageBox.Show("Inches is required.", "Data Misisng")
            txtInches.Focus()
        Else
            result = False
        End If
        Return result
    End Function

End Class

