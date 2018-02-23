Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SQLite
Imports System.Windows.Forms
Public Class SQLiteDB
    Public Function getDBPath() As String
        Dim SQLiteDatabase As String = "Data Source=" & Application.StartupPath & "\psc.s3db"
        Return SQLiteDatabase
    End Function
    Public Sub Connection()
        Dim con As SQLiteConnection
        Dim cmd As SQLiteCommand

        Try
            Dim cs = getDBPath()
            con = New SQLiteConnection(cs)
            con.Open()
            Dim stmt As String = "SELECT SQLITE_VERSION()"
            cmd = New SQLiteCommand(stmt, con)

            Dim str As String = Convert.ToString(cmd.ExecuteScalar)
            MsgBox("SQLIte Version: " & str)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If cmd IsNot Nothing Then
                cmd.Dispose()
            End If

            If con IsNot Nothing Then

                Try
                    con.Close()
                Catch ex As SQLiteException
                    Console.WriteLine("Failed closing connection")
                    Console.WriteLine("Error: " & ex.ToString())
                Finally
                    con.Close()
                    con.Dispose()
                End Try

            End If
        End Try
    End Sub
    Public Function Query(ByVal statement As String) As Boolean
        Dim con As SQLiteConnection
        Dim cmd As SQLiteCommand

        Try
            Dim cs = getDBPath()
            con = New SQLiteConnection(cs)
            con.Open()
            Dim stmt As String = statement
            cmd = New SQLiteCommand(stmt, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        Finally
            If cmd IsNot Nothing Then
                cmd.Dispose()
            End If

            If con IsNot Nothing Then

                Try
                    con.Close()
                Catch ex As SQLiteException
                    Console.WriteLine("Failed closing connection")
                    Console.WriteLine("Error: " & ex.ToString())
                Finally
                    con.Close()
                    con.Dispose()
                End Try

            End If
        End Try
        Return True
    End Function
    Public Function QueryReader(ByVal query As String) As String
        Dim cs As String = getDBPath()
        Dim rs As String = Nothing
        Using con As New SQLiteConnection(cs)
            con.Open()
            Using cmd As New SQLiteCommand(con)
                cmd.CommandText = query
                Dim reader As SQLiteDataReader = cmd.ExecuteReader
                Using reader
                    While reader.Read
                        rs = reader.GetName("Name")
                    End While
                End Using
                con.Close()
            End Using
        End Using
        Return rs
    End Function
End Class
