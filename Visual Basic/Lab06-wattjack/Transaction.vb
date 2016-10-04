'Transaction Class
'handeling all data end and file writing
Public Class Transaction
    Private m_accountNumber As Integer
    Private m_balance As Decimal
    Private m_description As String
    Public Const LOGFILE_PATH As String = "c:\data\Watt.txt"
    Sub New()

    End Sub
    Sub New(ByVal accountNumber As Integer, ByVal description As String, _
            ByVal balance As Decimal)
        m_accountNumber = accountNumber
        m_balance = balance
        m_description = description
    End Sub

    Sub Record()
        Dim logFile As System.IO.StreamWriter = IO.File.AppendText(LOGFILE_PATH)
        logFile.WriteLine(m_accountNumber & "-" & m_balance & "-" & m_description)
        logFile.Close()
    End Sub
End Class
