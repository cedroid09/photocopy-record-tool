Imports Photocopy_Stock_Control_Tool.SQLiteDB
Module Functions
    Dim sql As New SQLiteDB
    Public Function AddRecord(ByVal Dat As String, Name As String, Purpose As String, Ref_Number As Integer, Num_Copies As Integer, Counter As Integer, Paid_Status As String, OperatorName As String, Price As Integer, Optional ByVal notes As String = Nothing) As Boolean
        Dim rs As Boolean = Sql.Query("INSERT INTO RECORDS(Date, Name, Purpose, Ref_Num, Num_Copies, Counter_Num, Paid_Status, Operator, Price, Notes) VALUES(" & "'" & Dat & "', " & "'" & Name & "'," & "'" & Purpose & "'," & "'" & Ref_Number & "'," & "'" & Num_Copies & "'," & "'" & Counter & "'," & "'" & Paid_Status & "'," & "'" & OperatorName & "'," & "'" & Price & "'," & "'" & notes & "'" & ")")

        If rs = False Then
            MsgBox("Error adding to Records table")
        End If
        Return True
    End Function
    Public Function UpdateCounter(ByVal counter As Integer) As Boolean
        Dim rs As Boolean = sql.Query("UPDATE COUNTER SET VALUE=" & "'" & counter & "'" & " WHERE Ind='1'")

        If rs = False Then
            MsgBox("Error updating counter")
            Return False
        End If
        Return True
    End Function
End Module
