Imports MySql.Data.MySqlClient


Public Class AddAlg
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim constr As String = "database=cube; data source = localhost; user id = root; password = zsxdcf;"

    Dim funcs As New CommonFunctions

    Private Sub AddAlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = constr
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NewAlgSubmit_Click(sender As Object, e As EventArgs) Handles NewAlgSubmit.Click
        '        Dim query As String = "
        'INSERT INTO algs (alg_name_id, alg) SELECT id, ""@alg"" FROM alg_name WHERE name like ""@name""
        '"

        '        Dim cmd = New MySqlCommand(query, conn)



        '        cmd.Parameters.AddWithValue("@alg", NewAlgTextBox.Text)
        '        cmd.Parameters.AddWithValue("@name", AlgNameLabel.Text)

        '        MsgBox(NewAlgTextBox.Text & " " & AlgNameLabel.Text & " " & cmd.CommandText)



        '        Try
        '            cmd.ExecuteNonQuery()
        '            conn.Close()
        '            MsgBox("Alg Added")
        '            Me.Close()
        '        Catch ex As MySqlException
        '            MsgBox(ex.ToString())
        '        Finally

        '        End Try


        Dim submitQuery As String = "INSERT INTO algs (alg_name_id, alg) SELECT id, @alg FROM alg_name WHERE name like @name"
        Dim cmd = New MySqlCommand(submitQuery, conn)

        Dim alg As String = NewAlgTextBox.ToString()
        Dim name As String = AlgNameLabel.Text

        conn = New MySqlConnection(constr)
        conn.Open()

        cmd.Parameters.AddWithValue("@alg", NewAlgTextBox.Text)
        cmd.Parameters.AddWithValue("@name", AlgNameLabel.Text)

        Try
            cmd.ExecuteNonQuery()
            Me.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString())
        Finally
        End Try

    End Sub
End Class