'craps form is used to simulate craps game
'added functionality to show stats for games
'including % of wins
Public Class FrmCrapsGame
    Dim arrWin(10)

    Dim arrLose(10)
    Dim mDieResults(6) As Integer
    Dim gameAmount = 0 ' declared for when switching back from stat view to normal view
    ' die-roll constants
    Enum DiceNames
        SNAKE_EYES = 2
        TREY = 3
        LUCKY_SEVEN = 7
        CRAPS = 7
        YO_LEVEN = 11
        BOX_CARS = 12
    End Enum

    Enum GameStatus
        LOSE
        WIN
        ROLLAGAIN
        'by not assigning any values they will be 0, 1 and 2 respectively
    End Enum

    'Private Sub btnPlay_Click(ByVal sender As System.Object, _
    '    ByVal e As System.EventArgs) Handles btnPlay.Click
    '    ' initialize variables for game
    '    Dim myPoint As Integer ' total point
    '    Dim sum As Integer, rollCount As Integer = 1
    '    Dim status As GameStatus = GameStatus.ROLLAGAIN
    '    myPoint = 0
    '    sum = RollDice() ' roll dice and calculate sum
    '    ' check die roll
    '    Select Case sum
    '        Case DiceNames.LUCKY_SEVEN, DiceNames.YO_LEVEN
    '            status = GameStatus.WIN
    '        Case DiceNames.SNAKE_EYES, DiceNames.TREY, DiceNames.BOX_CARS
    '            status = GameStatus.LOSE
    '        Case Else
    '            status = GameStatus.ROLLAGAIN
    '            myPoint = sum
    '    End Select
    '    While status = GameStatus.ROLLAGAIN
    '        sum = RollDice() ' roll dice and calculate sum
    '        rollCount += 1  ' add one to the number of rolls in this game
    '        ' check outcome of roll
    '        If sum = myPoint Then ' win
    '            status = GameStatus.WIN
    '        ElseIf sum = DiceNames.CRAPS Then ' lose
    '            status = GameStatus.LOSE
    '        End If
    '    End While
    '    If status = GameStatus.LOSE Then
    '        txtGameStatus.Text &= "Lost in " & rollCount & " rolls." & vbCrLf
    '    Else
    '        txtGameStatus.Text &= "Won in " & rollCount & " rolls." & vbCrLf
    '    End If
    'End Sub ' btnPlay_Click


    ' generate random die rolls
    Function RollDice() As Integer
        Dim myDie1 As Integer ' die1 face
        Dim myDie2 As Integer ' die2 face
        Static randomObject As New Random() ' generate random number
        ' determine random integer
        myDie1 = randomObject.Next(1, 7)
        mDieResults(myDie1) += 1
        myDie2 = randomObject.Next(1, 7)
        mDieResults(myDie2) += 1
        Return myDie1 + myDie2 ' return sum
    End Function ' RollDice

    'Private Sub btnDieResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDieResults.Click
    '    Dim results As String = "Result" & ControlChars.Tab & "Count" & ControlChars.NewLine
    '    For i As Integer = 1 To mDieResults.GetUpperBound(0)
    '        results &= i & ControlChars.Tab & mDieResults(i) & ControlChars.NewLine
    '    Next
    '    MessageBox.Show(results, "Die Results")
    'End Sub

    Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click
        gameAmount = txtGames.Text

        play()
    End Sub


    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        clear()

    End Sub

    Private Sub mnuShowStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowStats.Click
        Static yesNo As Boolean = 0
        Dim wins As Integer = 0
        Dim loses As Integer = 0
        yesNo = Not yesNo
        'switches boolean to toggle between stats and regular view
        If yesNo = 0 Then
            lblShowHide.Text = "Detail of games"
            mnuShowStats.Text = "Show Status"
            ltbStat.Visible = False
        Else
            'output changes label to change views
            lblShowHide.Text = "Rolls" & "         " & "Wins" & "         " & "Losses"
            mnuShowStats.Text = "Hide Status"

            ltbStat.Visible = True
            For i = 1 To arrLose.GetUpperBound(0)
                If i = arrLose.GetUpperBound(0) Then
                    Dim line As String = i & "        " & arrWin(i) & "        " & arrLose(i)
                    ltbStat.Items.Add(line)
                Else
                    Dim line As String = i & "         " & arrWin(i) & "         " & arrLose(i)
                    ltbStat.Items.Add(line)
                End If

                ' txtGameStatus.Text &= i & ControlChars.Tab & arrWin(i) & ControlChars.Tab & arrLose(i) & vbCrLf
            Next
            For i = 1 To arrLose.GetUpperBound(0)
                wins = wins + arrWin(i)
                loses = loses + arrLose(i)
            Next
            ltbStat.Items.Add("Win % = " & wins / (wins + loses) * 100)

        End If
    End Sub
    Sub play()
        ' initialize variables for game
        Dim myPoint As Integer ' total point
        Dim sum As Integer, rollCount As Integer = 1
        Dim status As GameStatus = GameStatus.ROLLAGAIN
        myPoint = 0
        
        'made following into loop so game ammount would work
        For i As Double = 1 To gameAmount
            rollCount = 1


            sum = RollDice() ' roll dice and calculate sum
            ' check die roll
            Select Case sum
                Case DiceNames.LUCKY_SEVEN, DiceNames.YO_LEVEN
                    status = GameStatus.WIN
                Case DiceNames.SNAKE_EYES, DiceNames.TREY, DiceNames.BOX_CARS
                    status = GameStatus.LOSE
                Case Else
                    status = GameStatus.ROLLAGAIN
                    myPoint = sum
            End Select
            While status = GameStatus.ROLLAGAIN
                sum = RollDice() ' roll dice and calculate sum
                rollCount += 1  ' add one to the number of rolls in this game
                ' check outcome of roll
                If sum = myPoint Then ' win
                    status = GameStatus.WIN
                ElseIf sum = DiceNames.CRAPS Then ' lose
                    status = GameStatus.LOSE
                End If
            End While
            If status = GameStatus.LOSE Then
                txtGameStatus.Text &= "Lost in " & rollCount & " rolls." & vbCrLf
                If rollCount > arrLose.GetUpperBound(0) Then
                    arrLose(arrLose.GetUpperBound(0)) += 1
                Else
                    arrLose(rollCount) += 1
                End If
            Else
                txtGameStatus.Text &= "Won in " & rollCount & " rolls." & vbCrLf
                If rollCount > arrWin.GetUpperBound(0) Then
                    arrWin(arrWin.GetUpperBound(0)) += 1
                Else
                    arrWin(rollCount) += 1
                End If
            End If
        Next

    End Sub

    Private Sub FrmCrapsGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()


    End Sub
    Sub clear()
        'clears all data on screen
        txtGames.Text = ""
        txtGameStatus.Text = ""
        For i = 1 To arrWin.GetUpperBound(0)
            arrWin(i) = 0
            arrLose(i) = 0
        Next

    End Sub
End Class ' FrmCrapsGame
