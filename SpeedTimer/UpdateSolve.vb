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