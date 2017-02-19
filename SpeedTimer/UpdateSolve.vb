Imports MySql.Data.MySqlClient


Public Class UpdateSolve
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim constr As String = "database=cube; data source = localhost; user id = root; password = zsxdcf;"

    Dim funcs As New CommonFunctions

    Private Sub updateSolve_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function mysqlquery(stmt As String)
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


    Private Sub updateSolveButton_Click(sender As Object, e As EventArgs) Handles updateSolveButton.Click
        '        Dim query As String = "
        'UPDATE times t
        'INNER JOIN colors   AS  c   ON  c.id = t.startcolor
        'SET t.startcolor = c.id
        'WHERE   c.name like '@startcolor' AND t.id = @id
        '"

        Dim query As String = "
UPDATE times t
SET t.startcolor = (SELECT id FROM colors WHERE name like @startcolor)
WHERE t.id = @id
"

        Dim cmd = New MySqlCommand(query, conn)
        Dim color As String = StartColorCombobox.Text
        Dim u As New mainForm


        cmd.Parameters.AddWithValue("@id", Val(solveid.Text))
        cmd.Parameters.AddWithValue("@startcolor", color)



        Try
            cmd.ExecuteNonQuery()
            conn.Close()
            funcs.updateTimes()
            MsgBox("Updated")
            Me.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString())
        Finally

        End Try
    End Sub
End Class