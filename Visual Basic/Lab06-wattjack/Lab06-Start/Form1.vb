Public Class frmBankAccountTransactions
    'this does not create a BankAccount object rather a variable that CAN refer to a BankAccount object
    Dim myAccount As BankAccount 'needs to be class-level as many procedures need to access it
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        'test the constructors for BankAccount
        If txtAccountNumber.Text = "" Then
            myAccount = New BankAccount()  'create a default bank account
        Else 'create a completed bank account
            myAccount = New BankAccount(Convert.ToInt32(txtAccountNumber.Text), _
                                                    txtFirstName.Text, txtLastName.Text, _
                                                    Convert.ToDecimal(txtStartBalance.Text))
        End If
        'place the balance in the administration area
        txtCurrentBalance.Text = FormatCurrency(myAccount.Balance)
        'enable the buttons as the bank account object now exists and can do transactions on it
        btnDeposit.Enabled = True
        btnWithdraw.Enabled = True
        btnProcessEndMonth.Enabled = True
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        If Not IsNumeric(txtDepositAmount.Text) Then
            MessageBox.Show("Amount to be deposited must be a number.", "Input Error")
            txtDepositAmount.Focus()
            txtDepositAmount.SelectAll()
        Else 'test the Deposit method
            myAccount.Deposit(Convert.ToDecimal(txtDepositAmount.Text))
            txtCurrentBalance.Text = FormatCurrency(myAccount.Balance)
        End If
    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        If Not IsNumeric(txtWithdrawAmount.Text) Then
            MessageBox.Show("Amount to withdraw must be a number.", "Input Error")
            txtWithdrawAmount.Focus()
            txtWithdrawAmount.SelectAll()
        Else 'test the Withdraw method
            'recall that the method returns the updated balance
            txtCurrentBalance.Text = _
                FormatCurrency(myAccount.Withdraw(Convert.ToDecimal(txtWithdrawAmount.Text)))
        End If
    End Sub

    Private Sub btnProcessEndMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessEndMonth.Click
        myAccount.EndMonth() 'process the end-month account fees and display the new balance
        txtCurrentBalance.Text = FormatCurrency(myAccount.Balance)
        ''could alos have been done on one line as the method returns the updated balance
        'txtCurrentBalance.Text = FormatCurrency(myAccount.EndMonth())
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        'Added check , prevents crash
        If ofdLog.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Dim inputFile As New System.IO.StreamReader(ofdLog.FileName)
            lstTransactions.Items.Clear()
            While Not inputFile.EndOfStream
                lstTransactions.Items.Add(inputFile.ReadLine())
            End While
            inputFile.Close()
            btnRefresh.Enabled = True 'to allow the same file to be refreshed in the listbox
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        'ofdLog.ShowDialog() - will use the file previously set in the Filename porperty
        Dim inputFile As New System.IO.StreamReader(ofdLog.FileName)
        lstTransactions.Items.Clear()
        While Not inputFile.EndOfStream
            lstTransactions.Items.Add(inputFile.ReadLine())
        End While
        inputFile.Close()
    End Sub

    Private Sub btnDisplayProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayProperties.Click
        'first test to see if the bank account was created and then retrieve and display its data
        If myAccount Is Nothing Then
            MessageBox.Show("You must create the account first.", "Error")
        Else
            MessageBox.Show("Account Number: " & myAccount.AccountNumber & ControlChars.NewLine & _
                            "Name: " & myAccount.FirstName & " " & myAccount.LastName & ControlChars.NewLine & _
                            "Balance: " & FormatCurrency(myAccount.Balance) & ControlChars.NewLine & _
                            "Transactions: " & myAccount.Transactions, "Account Properties")
        End If
    End Sub

    Private Sub btnChangeAccountNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeAccountNumber.Click
        If myAccount Is Nothing Then
            MessageBox.Show("You must create the account first.", "Error")
        Else 'account exists so prompt for new account number and call the ChangeAccountNumber method
            Dim newAccountNumber As String = InputBox("Enter your new account number:", "Administer Account")
            If newAccountNumber <> "" AndAlso IsNumeric(newAccountNumber) Then
                myAccount.ChangeAccountNumber(Convert.ToInt32(newAccountNumber))
            End If
        End If
    End Sub
End Class
