Imports MySql.Data.MySqlClient


Public Class mainForm
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim constr As String = "database=cube; data source = localhost; user id = root; password = zsxdcf;"


    Private stopwatch As New Stopwatch
    Private timerOn As Boolean = 0
    Private prestopwatch As New Stopwatch
    Dim csvFile As String = My.Application.Info.DirectoryPath & "\MyTimes.csv"

    Dim last5(4) As Decimal
    Dim last5count As Integer = 0

    Dim time As Decimal

    Private Function mysqlquery(stmt As String)
        Try
            ' conn.Close()
        Catch ex As Exception

        End Try

        Try
            conn = New MySqlConnection(constr)
            conn.Open()


            Dim cmd As MySqlCommand = New MySqlCommand(stmt, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            While reader.Read
                If IsDBNull(reader) Then
                    Return ("empty")
                Else
                    Return reader.GetString(0)
                End If
            End While


        Catch ex As MySqlException
            ' TextBox1.Text = ex.ToString()
            Console.WriteLine("Error: " & ex.ToString())
            Return ex.ToString()
        Finally
            ' conn.Close()
        End Try
    End Function

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try


        bestLabel.Text = mysqlquery("SELECT min(solvetime) from times")
        ao5Label.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times ORDER BY id DESC LIMIT 5)X")
        ao100Label.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times ORDER BY id DESC LIMIT 100)X")
        worstLabel.Text = mysqlquery("SELECT max(solvetime) FROM times")

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

        Dim submitQuery As String = "INSERT INTO times (solvetime) VALUES (@time)"
        Dim cmd = New MySqlCommand(submitQuery, conn)

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
            bestLabel.Text = mysqlquery("SELECT min(solvetime) from times")
            ao5Label.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times ORDER BY id DESC LIMIT 5)X")
            ao100Label.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times ORDER BY id DESC LIMIT 100)X")
            worstLabel.Text = mysqlquery("SELECT max(solvetime) FROM times")


            ' Reset timer
            timerButton.Text = "Ready!"
            timerButton.BackColor = Color.Yellow
            timerOn = 0
            Me.stopwatch.Reset()
        End If


        Me.prestopwatch.Reset()

        outFile.Close()


    End Sub


End Class
