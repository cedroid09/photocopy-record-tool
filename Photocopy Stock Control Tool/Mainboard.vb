Public Class Mainboard
    Private Sub Mainboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.Size
    End Sub

    Private Sub btndd_Click(sender As Object, e As EventArgs) Handles btndd.Click
        Main.ShowDialog()
    End Sub

    Private Sub btnUpdateCounter_Click(sender As Object, e As EventArgs) Handles btnUpdateCounter.Click
        UpCounter.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As New SQLiteDB
        sql.QueryReader("INSERT INTO OPERATOR VALUES ('Varun');")
    End Sub
End Class