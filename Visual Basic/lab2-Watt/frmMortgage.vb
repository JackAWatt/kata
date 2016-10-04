''' <summary>
''' Mortgage Calculator
''' Jack Watt
''' 1/19/2010
''' </summary>
''' <remarks>changed from messagebox to error provider</remarks>
Public Class frmMortgage
    Const LOAN_MIN As Integer = 5000
    Const LOAN_MAX As Integer = 500000
    Const INTEREST_MIN As Integer = 0
    Const INTEREST_MAX As Integer = 20
    Const DURATION_MIN As Integer = 12
    Const DURATION_MAX As Integer = 420
    Private Sub txtDuration_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuration.Leave
        validateTextBox(txtDuration, DURATION_MIN, DURATION_MAX, "Duration")
    End Sub
    Private Sub validateTextBox(ByVal txtbox As TextBox, ByVal min As Double, ByVal max As Double, ByVal item As String)
        'let the user exit and clear the form with invalid data
        If txtbox.Text <> "" And Me.ActiveControl IsNot btnExit And Me.ActiveControl IsNot btnClear Then
            If Not IsNumeric(txtbox.Text) Then
                ' MessageBox.Show(item & " must be a number.", "Data Entry Error")
                errData.SetError(txtbox, " must be a number.")
                txtbox.Focus()
                txtbox.SelectAll()
            Else
                'cast textbox content to integer
                Dim value As Double = 0
                value = Convert.ToDouble(txtbox.Text)
                'compare textbox value to min and max
                If value < min Or value > max Then
                    'set user up to fix invalid data
                    MessageBox.Show("Must be between " & min & _
                            " and " & max & ".", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbox.Focus()
                    txtbox.SelectAll()
                Else
                    errData.Clear()
                End If
            End If
        End If
    End Sub


    Private Sub txtInterestRate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInterestRate.Leave
        validateTextBox(txtInterestRate, INTEREST_MIN, INTEREST_MAX, "Interest Rate")
    End Sub

    Private Sub txtLoanAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoanAmount.Leave
        validateTextBox(txtLoanAmount, LOAN_MIN, LOAN_MAX, "Loan Amount")
    End Sub

    Private Sub frmMortgage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clearForm()
        txtLoanAmount.Focus()
        lblLoanAmount.Text = Convert.ToString(LOAN_MIN) + " - " + Convert.ToString(LOAN_MAX)
        lblDuration.Text = Convert.ToString(DURATION_MIN) + " - " + Convert.ToString(DURATION_MAX)
        lblInterestRate.Text = Convert.ToString(INTEREST_MIN) + " - " + Convert.ToString(INTEREST_MAX)
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'calls function to reset all form properties
        clearForm()
    End Sub
    Private Sub clearForm()
        txtDuration.Clear()
        txtInterestRate.Clear()
        txtLoanAmount.Clear()
        lblPayment.Text = ""
        lblTotalInterest.Text = ""
        txtLoanAmount.Focus()
        errData.Clear()

    End Sub
    Private Function missingData() As Boolean
        'makes sure all user entered feilds have values
        Dim result As Boolean = True
        If txtLoanAmount.Text = "" Then
            errData.SetError(txtLoanAmount, "Loan Amount must be a number")
            txtLoanAmount.Focus()
        ElseIf txtInterestRate.Text = "" Then
            errData.SetError(txtInterestRate, "Interest Rate must be a number")
        ElseIf txtDuration.Text = "" Then
            errData.SetError(txtDuration, "Duration must be a number")
        Else
            result = False
        End If

    End Function

    Private Sub btnAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyze.Click
        If Not missingData() Then
            calculatePayment()
        End If


    End Sub
    Private Sub calculatePayment()
        'cast & asign all values needed for equation
        Dim loanAmount As Double = Convert.ToDouble(txtLoanAmount.Text)
        Dim interestRate As Double = (Convert.ToDouble(txtInterestRate.Text) / 12.0) / 100
        Dim loanDuration As Integer = Convert.ToInt32(txtDuration.Text)
        Dim payment As Double = 0
        Dim totalInterest As Double = 0

        'payment = p * r /(1-(1+r)^(-n))
        If interestRate = 0 Then
            payment = loanAmount / (Convert.ToDouble(loanDuration))
            totalInterest = 0
        Else
            payment = loanAmount * interestRate / (1 - (1 + interestRate) ^ (Convert.ToDouble(-loanDuration)))


            totalInterest = loanDuration * payment - loanAmount
        End If

        lblPayment.Text = "Payment: " + FormatCurrency(Convert.ToString(payment), 2)
        lblTotalInterest.Text = "Total Interest: " + FormatCurrency(Convert.ToString(totalInterest), 2)

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class