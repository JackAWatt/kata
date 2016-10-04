Imports System.IO
Public Class frmPayrollCalculator

    Private Sub frmPayrollCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstPayroll.Items.Add("Employee" & ControlChars.Tab & "Hourly Rate" & ControlChars.Tab & "Hours worked" & ControlChars.Tab & "Gross Pay")





    End Sub
    Private Function calculate(ByVal rate As Double, ByVal hours As Integer) As Double
        Dim totalWage As Double = 0

        If hours > 40 Then
            Dim overTime As Integer = hours - 40
            totalWage = overTime * rate
            totalWage += 40 * rate
        Else
            totalWage = rate * hours

        End If
        Return totalWage
    End Function

    Private Sub BtnProduce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduce.Click
        Dim reader As New StreamReader("c:\data\payroll.txt")
        Dim line As String = ""
        Dim count As Integer = 0 ' increment 3 positions then reset
        Dim i As Integer = 0 'used for position in list box
        Dim name As String = ""
        Dim rate As Double = 0
        Dim hours As Integer = 0
        Dim totalWage As Double = 0
        While Not reader.EndOfStream
            name = reader.ReadLine
            rate = Convert.ToDouble(reader.ReadLine)
            hours = Convert.ToInt32(reader.ReadLine)

            totalWage = calculate(rate, hours)
            'lstPayroll.Items.Add("Employee" & ControlChars.Tab & "Hourly Rate" & ControlChars.Tab & "Hours worked" & ControlChars.Tab & "Gross Pay")
            lstPayroll.Items.Add(name & ControlChars.Tab & "$" & rate & ControlChars.Tab & ControlChars.Tab & hours & ControlChars.Tab & ControlChars.Tab & "$" & totalWage)


            i += 1
        End While
        reader.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        sfdSave.ShowDialog()
        Dim writer As New StreamWriter(sfdSave.FileName)

        For Each ln In lstPayroll.Items
            writer.WriteLine(ln)


        Next
        writer.Close()



    End Sub
End Class