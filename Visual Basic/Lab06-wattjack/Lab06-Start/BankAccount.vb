'deal with all business end
Public Class BankAccount
    Private m_accountNumber As Integer
    Private m_balance As Decimal
    Private m_firstName As String
    Private m_lastName As String
    Private m_transactionCount As Integer = 0
    Public TRANSACTION_FEE As Decimal = 1.25
    'Default Constructor
    Sub New()
        m_firstName = "Unknown"
        m_lastName = "Unknown"
        LogTransaction("Default account created")
    End Sub

    Private Sub LogTransaction(ByVal describe As String)
        Dim newTransaction As New Transaction(m_accountNumber, describe, m_balance)
        newTransaction.Record()
    End Sub

    Public Sub ChangeAccountNumber(ByVal newAccountNumber As Integer)
        Dim oldAccountNumber As Integer
        oldAccountNumber = m_accountNumber
        m_accountNumber = newAccountNumber
        LogTransaction("Account number changed was " & oldAccountNumber)
    End Sub

    Public Function Withdraw(ByVal amount As Decimal) As Decimal
        If amount > m_balance Then
            LogTransaction("withdraw insufficient funds")
        Else
            m_balance -= amount
            LogTransaction("successful withdraw")
            m_transactionCount += 1
        End If
        Return m_balance
    End Function

    Sub New(ByVal AccountNumber As Integer, ByVal FirstName As String, _
    ByVal LastName As String, ByVal Balance As Decimal)
        m_accountNumber = AccountNumber
        m_firstName = FirstName
        m_lastName = LastName
        'Assign balance
        m_balance = Balance
        ' display  first name and last name
        LogTransaction("Account created for " & m_firstName & " " & m_lastName)
    End Sub

    Public Function EndMonth() As Decimal
        Dim totalFees As Decimal
        totalFees = m_transactionCount * TRANSACTION_FEE
        m_balance -= totalFees
        LogTransaction("End Month fees for " & m_transactionCount & " Transaction Processed")
        m_transactionCount = 0
        Return m_balance
    End Function
    Public ReadOnly Property AccountNumber() As Integer
        Get
            Return m_accountNumber
        End Get
    End Property

    Public ReadOnly Property Transactions() As Integer
        Get
            Return m_transactionCount
        End Get
    End Property

    Public Property Balance() As Decimal
        Get
            Return m_balance
        End Get
        'makes sure balance is not negitive
        Set(ByVal value As Decimal)
            If value < 0 Then
                m_balance = 0
            Else
                m_balance = value
            End If
        End Set
    End Property

    Public Function Deposit(ByVal amount As Decimal) As Decimal
        'process for determining if deposit is legal
        If amount > 0 Then
            m_balance += amount
            LogTransaction("Successful Deposit")
            m_transactionCount += 1
        Else
            'return if deposit is not legal
            LogTransaction("Attempt to deposit negative amount")
        End If
        Return m_balance
    End Function

    Property FirstName() As String
        Get
            Return m_firstName
        End Get
        Set(ByVal value As String)
            m_firstName = value
        End Set
    End Property

    Property LastName() As String
        Get
            Return m_lastName
        End Get
        Set(ByVal value As String)
            m_lastName = value
        End Set
    End Property
End Class



