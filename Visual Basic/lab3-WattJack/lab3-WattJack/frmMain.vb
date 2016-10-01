Public Class frmMain

    Const SCORES_SIZE As Integer = 100
    Dim scores(SCORES_SIZE) As Integer

    Private Sub btnAnalyzeGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyzeGrades.Click
        clear()
        Dim mean As Double = 0
        Dim line As String = ""
        'loop control for first loop
        Dim i As Integer = 0
        'first value for Standard Devieation
        Dim stndDeviation As Double = 0
        ofdScores.FileName = ""
        ofdScores.ShowDialog()


        If ofdScores.FileName <> "" Then
            Dim scoresReader As New System.IO.StreamReader(ofdScores.FileName)
            While Not scoresReader.EndOfStream
                line = scoresReader.ReadLine()
                'provided a simple means of error checking by 
                'ignoring anything in the file that isnt numeric
                If IsNumeric(line) Then
                    'if more scores in file then size of array will allocate more memory
                    If i > scores.Length - 1 Then
                        ReDim Preserve scores(scores.Length + SCORES_SIZE)
                    End If
                    scores(i) = Convert.ToInt32(line)
                    mean += Convert.ToInt32(line)
                    i += 1
                End If



            End While
            scoresReader.Close()
            ReDim Preserve scores(i - 1)
            mean = mean / scores.Length

            For j As Integer = 0 To scores.Length - 1
                stndDeviation += (scores(j) - mean) ^ 2
            Next
            stndDeviation = Math.Sqrt(stndDeviation / (scores.Length - 1))

            lstCurvingGrades.Items.Add("There were " & scores.Length & " exams")
            lstCurvingGrades.Items.Add("Mean: " & FormatNumber(mean, 2))
            lstCurvingGrades.Items.Add("Stnd Deviation: " & FormatNumber(stndDeviation, 2))
            lstCurvingGrades.Items.Add(" ")
            lstCurvingGrades.Items.Add("Score" & vbTab & "Grade")
            For j As Integer = 0 To scores.Length - 1
                lstCurvingGrades.Items.Add(scores(j) & vbTab & _
                                           LetterGrade(scores(j), mean, stndDeviation))
            Next
            lstCurvingGrades.Items.Add("mean is " & FormatNumber(mean, 2))
        End If

    End Sub
    Private Function LetterGrade(ByVal score As Integer, ByVal mean As Double, ByVal stndDeviation As Double) As String
        Dim str As String = ""
        If score >= mean + (1.5 * stndDeviation) Then
            str = "A"
        ElseIf mean + (0.5 * stndDeviation) <= score And score < mean + (1.5 * stndDeviation) Then
            str = "B"
        ElseIf mean - (0.5 * stndDeviation) <= score And score < mean + (0.5 * stndDeviation) Then
            str = "C"
        ElseIf mean - (1.5 * stndDeviation) <= score And score < mean - (0.5 * stndDeviation) Then
            str = "D"
        ElseIf score < mean - (1.5 * stndDeviation) Then
            str = "F"
        End If


        Return str
    End Function

    Private Sub clear()
        ReDim scores(SCORES_SIZE)
        lstCurvingGrades.Items.Clear()
        ofdScores.FileName = ""

    End Sub
End Class
