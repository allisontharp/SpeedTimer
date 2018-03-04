Imports MySql.Data.MySqlClient


Public Class mainForm
    ' TODO: handle > 60 seconds
    ' TODO: add plots average by day by color, all on one plot
    ' TODO: add functionality to practice just cross or F2L
    ' TODO: add functionality to test and practice PLL
    ' TODO: add functionality to add custom PLL algs

    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim constr As String = "database=cube; data source = localhost; user id = root; password = zsxdcf;"
    Dim funcs As New CommonFunctions


    Private stopwatch As New Stopwatch
    Private timerOn As Boolean = 0
    Private prestopwatch As New Stopwatch
    Dim csvFile As String = My.Application.Info.DirectoryPath & "\MyTimes.csv"

    Dim last5(4) As Decimal
    Dim last5count As Integer = 0

    Dim time As Decimal

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try



        funcs.updateTimes()

        'Dim results As String = funcs.scramble()
        'scrambleLabel.Text = results
        funcs.scramble()

        'totalAvgChart.Series(0).Points.Add(Val(timerLabel.Text))

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        timerLabel.Text = String.Format("{0:00}.{1:00}", elapsed.Seconds, elapsed.Milliseconds)
    End Sub


    Private Sub pretimer_Tick(sender As Object, e As EventArgs) Handles pretimer.Tick
        Dim pretimerelapsed As TimeSpan = Me.prestopwatch.Elapsed
    End Sub


    Private Sub timerButton_KeyDown(sender As Object, e As KeyEventArgs) Handles timerButton.KeyDown
        ' User must hold timer for 1 second before letting go for timer to start
        Dim pretimerelapsed As TimeSpan = Me.prestopwatch.Elapsed
        pretimer.Start()
        Me.prestopwatch.Start()

        If pretimerelapsed.Seconds >= 0.5 Then
            timerButton.Text = "Go!"
            timerButton.BackColor = Color.LimeGreen

        End If

    End Sub


    Private Sub timerButton_KeyUp(sender As Object, e As KeyEventArgs) Handles timerButton.KeyUp
        ' Start/Stop button 
        ' If timerOn variable = 0, timer is not on, start timer.
        ' If timerOn = 1, timer is on, stop timer.
        Dim pretimerelapsed As TimeSpan = Me.prestopwatch.Elapsed
        Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, True)

        Dim submitQuery As String = "INSERT INTO times (solvetime, startcolor, scramble) VALUES (@time, @startcolor, @scramble)"
        Dim cmd = New MySqlCommand(submitQuery, conn)

        Dim startColor As String = ""

        If whiteCB.Checked Then
            startColor = "1"
        ElseIf yellowCB.Checked Then
            startColor = "2"
        ElseIf greenCB.Checked Then
            startColor = "3"
        ElseIf blueCB.Checked Then
            startColor = "4"
        ElseIf redCB.Checked Then
            startColor = "5"
        ElseIf orangeCB.Checked Then
            startColor = "6"
        Else
            startColor = ""
        End If


        conn = New MySqlConnection(constr)
        conn.Open()

        pretimer.Stop()
        Me.prestopwatch.Stop()

        If Not timerOn Then
            If pretimerelapsed.Seconds >= 0.5 Then
                'TODO: user must hold timer for 1 second before letting go

                Timer1.Start()
                Me.stopwatch.Start()
                timerButton.Text = "Stop"
                timerButton.BackColor = Color.Red
                timerOn = 1


            Else
                timerButton.Text = "Ready!"
                timerButton.BackColor = Color.Yellow
                timerOn = 0
                Me.stopwatch.Reset()
            End If
        Else
            Timer1.Stop()
            Me.stopwatch.Stop()



            ' Plot Each Time
            totalAvgChart.Series(0).Points.Add(Val(timerLabel.Text))
            ' totalAvgChart.Series(1).Points.Add(Val(timerLabel.Text) / 2)

            ' Write to Database
            cmd.Parameters.AddWithValue("@time", Val(timerLabel.Text))
            cmd.Parameters.AddWithValue("@startcolor", startColor)
            cmd.Parameters.AddWithValue("@scramble", "" & scrambleLabel.Text & "")

            Try
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MsgBox(ex.ToString())
            Finally

            End Try

            ' Write to CSV
            outFile.Write("3x3," & System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "," & timerLabel.Text)
            outFile.Write(Environment.NewLine)

            ' Update Stats!
            funcs.updateTimes()
            funcs.scramble()

            ' Reset timer
            timerButton.Text = "Ready!"
            timerButton.BackColor = Color.Yellow
            timerOn = 0
            Me.stopwatch.Reset()
        End If


        Me.prestopwatch.Reset()

        outFile.Close()


    End Sub



    Private Sub whiteCB_CheckedChanged(sender As Object, e As EventArgs) Handles whiteCB.CheckedChanged
        If whiteCB.Checked Then
            redCB.Checked = False
            blueCB.Checked = False
            greenCB.Checked = False
            orangeCB.Checked = False
            yellowCB.Checked = False
        End If
    End Sub

    Private Sub orangeCB_CheckedChanged(sender As Object, e As EventArgs) Handles orangeCB.CheckedChanged
        If orangeCB.Checked Then
            redCB.Checked = False
            blueCB.Checked = False
            yellowCB.Checked = False
            greenCB.Checked = False
            whiteCB.Checked = False
        End If
    End Sub

    Private Sub greenCB_CheckedChanged(sender As Object, e As EventArgs) Handles greenCB.CheckedChanged
        If greenCB.Checked Then
            redCB.Checked = False
            yellowCB.Checked = False
            blueCB.Checked = False
            orangeCB.Checked = False
            whiteCB.Checked = False
        End If
    End Sub

    Private Sub blueCB_CheckedChanged(sender As Object, e As EventArgs) Handles blueCB.CheckedChanged
        If blueCB.Checked Then
            redCB.Checked = False
            yellowCB.Checked = False
            greenCB.Checked = False
            orangeCB.Checked = False
            whiteCB.Checked = False
        End If
    End Sub

    Private Sub yellowCB_CheckedChanged(sender As Object, e As EventArgs) Handles yellowCB.CheckedChanged
        If yellowCB.Checked Then
            redCB.Checked = False
            blueCB.Checked = False
            greenCB.Checked = False
            orangeCB.Checked = False
            whiteCB.Checked = False
        End If
    End Sub

    Private Sub redCB_CheckedChanged(sender As Object, e As EventArgs) Handles redCB.CheckedChanged
        If redCB.Checked Then
            yellowCB.Checked = False
            blueCB.Checked = False
            greenCB.Checked = False
            orangeCB.Checked = False
            whiteCB.Checked = False
        End If
    End Sub

    Private Sub recentSolvesDataGrid_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles recentSolvesDataGrid.CellMouseDown


        If (e.Button = MouseButtons.Right) Then
            recentSolves_Strip.Show(MousePosition.X, MousePosition.Y)
        End If




    End Sub

    Private Sub DeleteSolveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSolveToolStripMenuItem.Click
        Dim i As Integer
        conn.Close()
        Try
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

        Try
            i = recentSolvesDataGrid.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Dim solveid As String = recentSolvesDataGrid.Item(0, i).Value


        Dim query As String = "DELETE FROM times WHERE id = @id"

        Dim cmd = New MySqlCommand(query, conn)


        cmd.Parameters.AddWithValue("@id", solveid)

        Try
            cmd.ExecuteNonQuery()
            conn.Close()
            funcs.updateTimes()
        Catch ex As MySqlException
            MsgBox(ex.ToString())
        Finally

        End Try

    End Sub



    Private Sub UpdateStartColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStartColorToolStripMenuItem.Click
        Dim obj As New UpdateSolve

        Dim i As Integer

        Try
            i = recentSolvesDataGrid.CurrentRow.Index
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Dim solveid As String = recentSolvesDataGrid.Item(0, i).Value
        Dim solvedate As String = recentSolvesDataGrid.Item(1, i).Value
        Dim solvetime As String = recentSolvesDataGrid.Item(2, i).Value
        Dim color As String = recentSolvesDataGrid.Item(3, i).Value

        obj.solveid.Text = solveid

        obj.Show()


    End Sub

    Private Sub scrambleButton_Click(sender As Object, e As EventArgs) Handles scrambleButton.Click
        funcs.scramble()

    End Sub

    Private Sub OLLList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PLLList.SelectedIndexChanged
        Dim index As Integer = PLLList.SelectedIndex
        PLLPicture.Image = PLLImageList.Images(index - 1)

        Dim query As String = "SELECT alg FROM algs WHERE alg_name_id = (SELECT id FROM alg_name WHERE name like """
        query = query & PLLList.SelectedItem & """)"

        Dim alg As String = funcs.mysqlquery(query)

        PLLAlg.Text = alg

    End Sub

    Private Sub PLLList_MouseDown(sender As Object, e As MouseEventArgs) Handles PLLList.MouseDown
        If (e.Button = MouseButtons.Right) Then
            UpdateAlgStrip.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub AddAlgorithmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAlgorithmToolStripMenuItem.Click
        Dim obj As New AddAlg
        Dim name As String = PLLList.SelectedItem

        obj.AlgNameLabel.Text = name
        obj.Show()
    End Sub

    Private Sub PLLTimerButton_KeyDown(sender As Object, e As KeyEventArgs) Handles PLLTimerButton.KeyDown
        ' User must hold timer for 0.5 second before letting go for timer to start
        Dim pretimerelapsed As TimeSpan = Me.prestopwatch.Elapsed
        pretimer.Start()
        Me.prestopwatch.Start()

        If pretimerelapsed.Seconds >= 0.5 Then
            PLLTimerButton.Text = "Go!"
            PLLTimerButton.BackColor = Color.LimeGreen

        End If
    End Sub

    Private Sub PLLTimerButton_KeyUp(sender As Object, e As KeyEventArgs) Handles PLLTimerButton.KeyUp
        Dim pretimerelapsed As TimeSpan = Me.prestopwatch.Elapsed

        Dim submitQuery As String = "INSERT "





        'conn = New MySqlConnection(constr)
        'conn.Open()

        'pretimer.Stop()
        'Me.prestopwatch.Stop()

        'If Not timerOn Then
        '    If pretimerelapsed.Seconds >= 0.5 Then
        '        'TODO: user must hold timer for 1 second before letting go

        '        Timer1.Start()
        '        Me.stopwatch.Start()
        '        PLLTimerButton.Text = "Stop"
        '        PLLTimerButton.BackColor = Color.Red
        '        timerOn = 1


        '    Else
        '        PLLTimerButton.Text = "Ready!"
        '        PLLTimerButton.BackColor = Color.Yellow
        '        timerOn = 0
        '        Me.stopwatch.Reset()
        '    End If
        'Else
        '    Timer1.Stop()
        '    Me.stopwatch.Stop()



        '    ' Plot Each Time
        '    'totalAvgChart.Series(0).Points.Add(Val(timerLabel.Text))
        '    ' totalAvgChart.Series(1).Points.Add(Val(timerLabel.Text) / 2)

        '    ' Write to Database
        '    cmd.Parameters.AddWithValue("@time", Val(timerLabel.Text))
        '    cmd.Parameters.AddWithValue("@startcolor", startColor)
        '    cmd.Parameters.AddWithValue("@scramble", "" & scrambleLabel.Text & "")

        '    Try
        '        cmd.ExecuteNonQuery()
        '    Catch ex As MySqlException
        '        MsgBox(ex.ToString())
        '    Finally

        '    End Try


        '    '' Update Stats!
        '    'funcs.updateTimes()
        '    'funcs.scramble()

        '    ' Reset timer
        '    timerButton.Text = "Ready!"
        '    timerButton.BackColor = Color.Yellow
        '    timerOn = 0
        '    Me.stopwatch.Reset()
        'End If


        'Me.prestopwatch.Reset()



    End Sub


    Private Sub PLLScrambleButton_Click(sender As Object, e As EventArgs) Handles PLLScrambleButton.Click
        funcs.pll_scramble()
    End Sub

    Private Sub PLLTimerButton_Click(sender As Object, e As EventArgs) Handles PLLTimerButton.Click

    End Sub

    Private Sub totalAvgChart_Click(sender As Object, e As EventArgs) Handles totalAvgChart.Click

    End Sub
End Class
