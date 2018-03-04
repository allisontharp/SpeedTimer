Imports MySql.Data.MySqlClient


Public Class CommonFunctions
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim constr As String = "database=cube; data source = localhost; user id = root; password = zsxdcf;"

    Public Function updateTimes()
        ' Update Overall Stats
        mainForm.bestLabel.Text = mysqlquery("SELECT min(solvetime) from times")
        mainForm.ao5Label.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times ORDER BY id DESC LIMIT 5)X")
        mainForm.ao100Label.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times ORDER BY id DESC LIMIT 100)X")
        mainForm.worstLabel.Text = mysqlquery("SELECT max(solvetime) FROM times")

        ' Update White Stats
        mainForm.whiteBest.Text = mysqlquery("SELECT min(solvetime) from times WHERE startcolor = 1")
        mainForm.whiteAo5.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 1 ORDER BY id DESC LIMIT 5)X")
        mainForm.whiteAo100.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 1 ORDER BY id DESC LIMIT 100)X")
        mainForm.whiteWorst.Text = mysqlquery("SELECT max(solvetime) FROM times  WHERE startcolor = 1")
        mainForm.whiteToday.Text = mysqlquery("SELECT count(*) FROM times WHERE date(date) = current_date AND startcolor = 1")
        mainForm.whiteTotal.Text = mysqlquery("SELECT count(*) FROM times WHERE startcolor = 1")


        ' Update Yellow Stats
        mainForm.yellowBest.Text = mysqlquery("SELECT min(solvetime) from times WHERE startcolor = 2")
        mainForm.yellowAo5.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 2 ORDER BY id DESC LIMIT 5)X")
        mainForm.yellowAo100.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 2 ORDER BY id DESC LIMIT 100)X")
        mainForm.yellowWorst.Text = mysqlquery("SELECT max(solvetime) FROM times  WHERE startcolor = 2")
        mainForm.yellowToday.Text = mysqlquery("SELECT count(*) FROM times WHERE date(date) = current_date AND startcolor = 2")
        mainForm.yellowTotal.Text = mysqlquery("SELECT count(*) FROM times WHERE startcolor = 2")

        ' Update Green Stats
        mainForm.greenBest.Text = mysqlquery("SELECT min(solvetime) from times WHERE startcolor = 3")
        mainForm.greenAo5.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 3 ORDER BY id DESC LIMIT 5)X")
        mainForm.greenAo100.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 3 ORDER BY id DESC LIMIT 100)X")
        mainForm.greenWorst.Text = mysqlquery("SELECT max(solvetime) FROM times  WHERE startcolor = 3")
        mainForm.greenToday.Text = mysqlquery("SELECT count(*) FROM times WHERE date(date) = current_date AND startcolor = 3")
        mainForm.greenTotal.Text = mysqlquery("SELECT count(*) FROM times WHERE startcolor = 3")

        ' Update Blue Stats
        mainForm.blueBest.Text = mysqlquery("SELECT min(solvetime) from times WHERE startcolor = 4")
        mainForm.blueAo5.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 4 ORDER BY id DESC LIMIT 5)X")
        mainForm.blueAo100.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 4 ORDER BY id DESC LIMIT 100)X")
        mainForm.blueWorst.Text = mysqlquery("SELECT max(solvetime) FROM times  WHERE startcolor = 4")
        mainForm.blueToday.Text = mysqlquery("SELECT count(*) FROM times WHERE date(date) = current_date AND startcolor = 4")
        mainForm.blueTotal.Text = mysqlquery("SELECT count(*) FROM times WHERE startcolor = 4")

        ' Update Red Stats
        mainForm.redBest.Text = mysqlquery("SELECT min(solvetime) from times WHERE startcolor = 5")
        mainForm.redAo5.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 5 ORDER BY id DESC LIMIT 5)X")
        mainForm.redAo100.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 5 ORDER BY id DESC LIMIT 100)X")
        mainForm.redWorst.Text = mysqlquery("SELECT max(solvetime) FROM times  WHERE startcolor = 5")
        mainForm.redToday.Text = mysqlquery("SELECT count(*) FROM times WHERE date(date) = current_date AND startcolor = 5")
        mainForm.redTotal.Text = mysqlquery("SELECT count(*) FROM times WHERE startcolor = 5")

        ' Update Orange Stats
        mainForm.orangeBest.Text = mysqlquery("SELECT min(solvetime) from times WHERE startcolor = 6")
        mainForm.orangeAo5.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 6 ORDER BY id DESC LIMIT 5)X")
        mainForm.orangeAo100.Text = mysqlquery("SELECT TRUNCATE(avg(x.solvetime),3) FROM (SELECT solvetime FROM times  WHERE startcolor = 6 ORDER BY id DESC LIMIT 100)X")
        mainForm.orangeWorst.Text = mysqlquery("SELECT max(solvetime) FROM times  WHERE startcolor = 6")
        mainForm.orangeToday.Text = mysqlquery("SELECT count(*) FROM times WHERE date(date) = current_date AND startcolor = 6")
        mainForm.orangeTotal.Text = mysqlquery("SELECT count(*) FROM times WHERE startcolor = 6")

        GetWorstA0100()

        ' Update Recent Solves Table

        Dim query As String = "SELECT t.id, t.date, t.solvetime, c.name AS color FROM times t LEFT JOIN colors c ON c.id = t.startcolor ORDER BY date desc"

        Try
            conn.Close()
        Catch ex As Exception
        End Try

        Try
            conn.Open()
        Catch ex As MySqlException
            MsgBox("An Error Occurred. " & ex.Number & “ – “ & ex.Message)
        End Try

        Dim adap As MySqlDataAdapter = New MySqlDataAdapter(query, conn)

        Dim ds As New DataSet()

        mainForm.recentSolvesDataGrid.DataSource = Nothing
        adap = New MySqlDataAdapter(query, conn)

        adap.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Try
                mainForm.recentSolvesDataGrid.DataSource = ds.Tables(0)
                ds = Nothing
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

        query = "SELECT t.solvetime FROM times AS t ORDER BY t.date ASC"
        adap = New MySqlDataAdapter(query, conn)
        ds = New DataSet()

        mainForm.totalAvgChart.DataSource = Nothing
        adap = New MySqlDataAdapter(query, conn)

        adap.Fill(ds)
        mainForm.totalAvgChart.Series(0).YValueMembers = "solvetime"
        mainForm.totalAvgChart.DataSource = ds

    End Function

    Public Function GetWorstA0100()
        Dim worstColor As String
        Dim query As String = "
select avg.color
from (
SELECT TRUNCATE(avg(t.solvetime),3) as Ao100, t.color
from 
(
			(SELECT solvetime , c.name as color
			FROM times  as t
			join colors as c on c.id = t.startcolor
			WHERE c.name = 'white'
			ORDER BY t.date DESC 
			LIMIT 100)

union 
		(
			SELECT solvetime , c.name as color
			FROM times  as t
			join colors as c on c.id = t.startcolor
			WHERE c.name = 'yellow'
			ORDER BY t.date DESC 
			LIMIT 100
		)
		
union 
		(
			SELECT solvetime , c.name as color
			FROM times  as t
			join colors as c on c.id = t.startcolor
			WHERE c.name = 'green'
			ORDER BY t.date DESC 
			LIMIT 100
		)
		
union 
(SELECT solvetime , c.name as color
			FROM times  as t
			join colors as c on c.id = t.startcolor
			WHERE c.name = 'orange'
			ORDER BY t.date DESC 
			LIMIT 100)

union 
		(
			SELECT solvetime , c.name as color
			FROM times  as t
			join colors as c on c.id = t.startcolor
			WHERE c.name = 'blue'
			ORDER BY t.date DESC 
			LIMIT 100
		)
		
union 
		(
			SELECT solvetime , c.name as color
			FROM times  as t
			join colors as c on c.id = t.startcolor
			WHERE c.name = 'red'
			ORDER BY t.date DESC 
			LIMIT 100
		)

) as t	
group by t.color		
) as avg
order by avg.ao100 desc 
limit 1
"
        worstColor = mysqlquery(query)
        If worstColor = "white" Then
            mainForm.whiteAo100.Font = New Font(mainForm.whiteAo100.Font.SystemFontName, mainForm.whiteAo100.Font.Size, FontStyle.Bold)
            mainForm.yellowAo100.Font = New Font(mainForm.yellowAo100.Font.SystemFontName, mainForm.yellowAo100.Font.Size, FontStyle.Regular)
            mainForm.redAo100.Font = New Font(mainForm.redAo100.Font.SystemFontName, mainForm.redAo100.Font.Size, FontStyle.Regular)
            mainForm.orangeAo100.Font = New Font(mainForm.orangeAo100.Font.SystemFontName, mainForm.orangeAo100.Font.Size, FontStyle.Regular)
            mainForm.blueAo100.Font = New Font(mainForm.blueAo100.Font.SystemFontName, mainForm.blueAo100.Font.Size, FontStyle.Regular)
            mainForm.greenAo100.Font = New Font(mainForm.greenAo100.Font.SystemFontName, mainForm.greenAo100.Font.Size, FontStyle.Regular)
        ElseIf worstColor = "yellow" Then
            mainForm.whiteAo100.Font = New Font(mainForm.whiteAo100.Font.SystemFontName, mainForm.whiteAo100.Font.Size, FontStyle.Regular)
            mainForm.yellowAo100.Font = New Font(mainForm.yellowAo100.Font.SystemFontName, mainForm.yellowAo100.Font.Size, FontStyle.Bold)
            mainForm.redAo100.Font = New Font(mainForm.redAo100.Font.SystemFontName, mainForm.redAo100.Font.Size, FontStyle.Regular)
            mainForm.orangeAo100.Font = New Font(mainForm.orangeAo100.Font.SystemFontName, mainForm.orangeAo100.Font.Size, FontStyle.Regular)
            mainForm.blueAo100.Font = New Font(mainForm.blueAo100.Font.SystemFontName, mainForm.blueAo100.Font.Size, FontStyle.Regular)
            mainForm.greenAo100.Font = New Font(mainForm.greenAo100.Font.SystemFontName, mainForm.greenAo100.Font.Size, FontStyle.Regular)
        ElseIf worstColor = "red" Then
            mainForm.whiteAo100.Font = New Font(mainForm.whiteAo100.Font.SystemFontName, mainForm.whiteAo100.Font.Size, FontStyle.Regular)
            mainForm.yellowAo100.Font = New Font(mainForm.yellowAo100.Font.SystemFontName, mainForm.yellowAo100.Font.Size, FontStyle.Regular)
            mainForm.redAo100.Font = New Font(mainForm.redAo100.Font.SystemFontName, mainForm.redAo100.Font.Size, FontStyle.Bold)
            mainForm.orangeAo100.Font = New Font(mainForm.orangeAo100.Font.SystemFontName, mainForm.orangeAo100.Font.Size, FontStyle.Regular)
            mainForm.blueAo100.Font = New Font(mainForm.blueAo100.Font.SystemFontName, mainForm.blueAo100.Font.Size, FontStyle.Regular)
            mainForm.greenAo100.Font = New Font(mainForm.greenAo100.Font.SystemFontName, mainForm.greenAo100.Font.Size, FontStyle.Regular)
        ElseIf worstColor = "orange" Then
            mainForm.whiteAo100.Font = New Font(mainForm.whiteAo100.Font.SystemFontName, mainForm.whiteAo100.Font.Size, FontStyle.Regular)
            mainForm.yellowAo100.Font = New Font(mainForm.yellowAo100.Font.SystemFontName, mainForm.yellowAo100.Font.Size, FontStyle.Regular)
            mainForm.redAo100.Font = New Font(mainForm.redAo100.Font.SystemFontName, mainForm.redAo100.Font.Size, FontStyle.Regular)
            mainForm.orangeAo100.Font = New Font(mainForm.orangeAo100.Font.SystemFontName, mainForm.orangeAo100.Font.Size, FontStyle.Bold)
            mainForm.blueAo100.Font = New Font(mainForm.blueAo100.Font.SystemFontName, mainForm.blueAo100.Font.Size, FontStyle.Regular)
            mainForm.greenAo100.Font = New Font(mainForm.greenAo100.Font.SystemFontName, mainForm.greenAo100.Font.Size, FontStyle.Regular)
        ElseIf worstColor = "blue" Then
            mainForm.whiteAo100.Font = New Font(mainForm.whiteAo100.Font.SystemFontName, mainForm.whiteAo100.Font.Size, FontStyle.Regular)
            mainForm.yellowAo100.Font = New Font(mainForm.yellowAo100.Font.SystemFontName, mainForm.yellowAo100.Font.Size, FontStyle.Regular)
            mainForm.redAo100.Font = New Font(mainForm.redAo100.Font.SystemFontName, mainForm.redAo100.Font.Size, FontStyle.Regular)
            mainForm.orangeAo100.Font = New Font(mainForm.orangeAo100.Font.SystemFontName, mainForm.orangeAo100.Font.Size, FontStyle.Regular)
            mainForm.blueAo100.Font = New Font(mainForm.blueAo100.Font.SystemFontName, mainForm.blueAo100.Font.Size, FontStyle.Bold)
            mainForm.greenAo100.Font = New Font(mainForm.greenAo100.Font.SystemFontName, mainForm.greenAo100.Font.Size, FontStyle.Regular)
        ElseIf worstColor = "green" Then
            mainForm.whiteAo100.Font = New Font(mainForm.whiteAo100.Font.SystemFontName, mainForm.whiteAo100.Font.Size, FontStyle.Regular)
            mainForm.yellowAo100.Font = New Font(mainForm.yellowAo100.Font.SystemFontName, mainForm.yellowAo100.Font.Size, FontStyle.Regular)
            mainForm.redAo100.Font = New Font(mainForm.redAo100.Font.SystemFontName, mainForm.redAo100.Font.Size, FontStyle.Regular)
            mainForm.orangeAo100.Font = New Font(mainForm.orangeAo100.Font.SystemFontName, mainForm.orangeAo100.Font.Size, FontStyle.Regular)
            mainForm.blueAo100.Font = New Font(mainForm.blueAo100.Font.SystemFontName, mainForm.blueAo100.Font.Size, FontStyle.Regular)
            mainForm.greenAo100.Font = New Font(mainForm.greenAo100.Font.SystemFontName, mainForm.greenAo100.Font.Size, FontStyle.Bold)
        End If

    End Function

    Public Function mysqlquery(stmt As String)
        Try
            conn.Close()
        Catch ex As Exception

        End Try

        Try
            conn = New MySqlConnection(constr)
            conn.Open()


            Dim cmd As MySqlCommand = New MySqlCommand(stmt, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader

            While reader.Read
                ' If IsDBNull(reader) Then

                If reader.IsDBNull(0) Then
                    Return ("NULL")
                Else
                    Return reader.GetString(0)
                End If
            End While


        Catch ex As MySqlException
            ' TextBox1.Text = ex.ToString()
            Console.WriteLine("Error: " & ex.ToString())
            MsgBox(ex.ToString())
            Return ex.ToString()
        Finally
            ' conn.Close()
        End Try
    End Function

    Public Function scramble()
        Dim possible() As String = {"F", "F'", "F2", "R", "R'", "R2", "L", "L'", "L2", "B", "B'", "B2", "U", "U'", "U2", "D", "D'", "D2"}
        Dim moves(20) As String
        Dim rdm As String
        Dim i As Integer

        rdm = possible(New Random().Next(0, possible.Length - 1))
        moves(0) = rdm

        For i = 1 To moves.Length() - 1
            rdm = possible(New Random().Next(0, possible.Length - 1))
            While rdm.Substring(0, 1) = moves(i - 1).Substring(0, 1)
                rdm = possible(New Random().Next(0, possible.Length - 1))
            End While
            moves(i) = rdm
        Next i

        Dim results As String = String.Join(" ", moves)

        mainForm.scrambleLabel.Text = results


    End Function

    Public Function pll_scramble()
        Dim i As Integer
        Dim s As String = "("


        If mainForm.PLLList.CheckedItems.Count <> 0 Then


            For i = 0 To mainForm.PLLList.CheckedItems.Count - 1
                s = s & """" & mainForm.PLLList.CheckedItems(i).ToString & ""","
            Next i

            s = s.TrimEnd(CChar(","))
            s = s & ")"

        End If

        Dim selectQuery As String = "SELECT alg FROM algs WHERE alg_name_id in (SELECT id FROM alg_name WHERE name in "
        selectQuery = selectQuery & s & ") ORDER BY RAND() LIMIT 1"

        Dim result As String = mysqlquery(selectQuery)

        mainForm.PLLScramble.Text = result
    End Function


End Class



