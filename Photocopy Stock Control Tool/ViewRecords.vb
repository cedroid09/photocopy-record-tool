Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SQLite
Imports System.Windows.Forms
Imports Photocopy_Stock_Control_Tool.SQLiteDB
Public Class ViewRecords
    Private Sub ViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim sql As New SQLiteDB
        Dim cs As String = sql.getDBPath()
        Dim ds As New DataSet
        Using con As New SQLiteConnection(cs)
            con.Open()
            Dim cmd As String
            cmd = "SELECT * FROM RECORDS"
            Dim dataAdapter As New SQLiteDataAdapter(cmd, con)
            dataAdapter.Fill(ds, "RECORDS")
            con.Close()
            DataView.DataSource = ds
            DataView.DataMember = "RECORDS"
        End Using
    End Sub
End Class