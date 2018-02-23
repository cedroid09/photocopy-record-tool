Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SQLite
Imports System.Windows.Forms
Imports Photocopy_Stock_Control_Tool.SQLiteDB
Public Class Main
#Region "Initiators"
    Dim sql As New SQLiteDB
    Dim counter As Integer = vbNull
    Private Sub LoadCounter()
        Dim cs As String = sql.getDBPath()
        Using con As New SQLiteConnection(cs)
            con.Open()
            Using cmd As New SQLiteCommand(con)
                cmd.CommandText = "SELECT Value FROM COUNTER WHERE Ind='1'"
                Dim reader As SQLiteDataReader = cmd.ExecuteReader
                Using reader
                    While reader.Read
                        counter = reader.GetValue("0")
                        txtCounter.Text = counter
                    End While
                End Using
                con.Close()
            End Using
        End Using
    End Sub
    Private Sub LoadPurpose()
        Dim cs As String = sql.getDBPath()
        Using con As New SQLiteConnection(cs)
            con.Open()
            Using cmd As New SQLiteCommand(con)
                cmd.CommandText = "SELECT * FROM PURPOSE"
                Dim reader As SQLiteDataReader = cmd.ExecuteReader
                comPurpose.Items.Clear()

                Using reader
                    While reader.Read
                        comPurpose.Items.Add(reader.GetString("0"))
                    End While
                End Using
                con.Close()
            End Using
        End Using
        comPurpose.SelectedItem = comPurpose.Items.Item(0)
    End Sub
    Private Sub RefNumber()
        Dim cs As String = sql.getDBPath()
        Using con As New SQLiteConnection(cs)
            con.Open()
            Using cmd As New SQLiteCommand(con)
                cmd.CommandText = "SELECT Ref_Num FROM RECORDS"
                Dim reader As SQLiteDataReader = cmd.ExecuteReader
                Using reader
                    While reader.Read
                        txtRefNumber.Text = reader.GetValue("0")
                    End While
                End Using
                con.Close()
            End Using
        End Using
    End Sub
    Private Sub LoadOperator()
        Dim cs As String = sql.getDBPath()
        comOperator.Items.Clear()

        Using con As New SQLiteConnection(cs)
            con.Open()
            Using cmd As New SQLiteCommand(con)
                cmd.CommandText = "SELECT Username FROM OPERATOR"
                Dim reader As SQLiteDataReader = cmd.ExecuteReader
                Using reader
                    While reader.Read
                        comOperator.Items.Add(reader.GetValue("0"))
                    End While
                End Using
                con.Close()
            End Using
            comOperator.SelectedItem = comOperator.Items.Item(0)
        End Using
    End Sub
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As String = Nothing
        Dim paidstat As String = Nothing
        dt = Mid(Date.Now, 1, 10)
        If txtName.Text = Nothing Or txtNumberofC.Text = Nothing Or txtPages.Text = Nothing Or txtRefNumber.Text = Nothing Then
            MsgBox("Please fill out the required fields and then try again", vbCritical, "Missing Fields")
        ElseIf InStr(dt, comDate.Text) = False Then
            MsgBox("Date cannot be set in the past or future. Please check again", vbCritical, "Wrong Date")
        Else
            If chkPaid.Checked Then
                paidstat = "paid"
            ElseIf chkCredited.Checked Then
                paidstat = "unpaid"
            Else
                paidstat = "nil"
            End If
            AddRecord(comDate.Text, txtName.Text, comPurpose.Text, txtRefNumber.Text, txtNumberofC.Text, txtCounter.Text, paidstat, comOperator.Text, CInt(lblPrice.Text), rtbNotes.Text)
            UpdateCounter(CInt(txtCounter.Text))
        End If
    End Sub

    Private Sub chkCredited_CheckedChanged(sender As Object, e As EventArgs) Handles chkCredited.CheckedChanged
        If chkCredited.Checked = True Then
            chkPaid.Checked = False
            chkUnpaid.Checked = False
        End If
    End Sub

    Private Sub chkPaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaid.CheckedChanged
        If chkPaid.Checked = True Then
            chkCredited.Checked = False
            chkUnpaid.Checked = False
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        For Each item As Char In txtName.Text
            If IsNumeric(item) Then
                MsgBox("Name cannot contain a numberical values", vbCritical, "Invalid Character")
                txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1)
            End If
        Next item

    End Sub

    Private Sub txtNumberofC_TextChanged(sender As Object, e As EventArgs) Handles txtNumberofC.TextChanged
        For Each item As Char In txtNumberofC.Text
            If IsNumeric(item) = False Then
                MsgBox("Name cannot contain a alphabetical values", vbCritical, "Invalid Character")
                txtNumberofC.Text = txtNumberofC.Text.Remove(txtNumberofC.Text.Length - 1)
            End If
        Next item

        Dim num_c As Integer
        Dim num_p As Integer = CInt(txtPages.Text)
        Try
            If txtNumberofC.Text <> Nothing Then
                num_c = CInt(txtNumberofC.Text)
                txtCounter.Text = (num_c * num_p) + counter
                lblPrice.Text = num_c * num_p
            Else
                num_c = 0
                txtCounter.Text = (num_c * num_p) + counter
                lblPrice.Text = num_c * num_p
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPages_TextChanged(sender As Object, e As EventArgs) Handles txtPages.TextChanged
        If txtPages.Text = Nothing Then
            txtNumberofC.Enabled = False
        Else
            txtNumberofC.Enabled = True
        End If
        For Each item As Char In txtPages.Text
            If IsNumeric(item) = False Then
                MsgBox("Name cannot contain a alphabetical values", vbCritical, "Invalid Character")
                txtPages.Text = txtPages.Text.Remove(txtPages.Text.Length - 1)
            End If
        Next item
    End Sub

    Private Sub txtRefNumber_TextChanged(sender As Object, e As EventArgs) Handles txtRefNumber.TextChanged
        For Each item As Char In txtRefNumber.Text
            If IsNumeric(item) = False Then
                MsgBox("Name cannot contain a alphabetical values", vbCritical, "Invalid Character")
                txtRefNumber.Text = txtRefNumber.Text.Remove(txtRefNumber.Text.Length - 1)
            End If
        Next item
    End Sub
    Private Sub chkUnpaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnpaid.CheckedChanged
        If chkUnpaid.Checked = True Then
            chkPaid.Checked = False
            chkCredited.Checked = False
        End If
    End Sub
    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        ViewRecords.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCounter()
        LoadPurpose()
        RefNumber()
        LoadOperator()
    End Sub

    Private Sub comOperator_TextChanged(sender As Object, e As EventArgs) Handles comOperator.TextChanged
        For Each item As Char In comOperator.Text
            If IsNumeric(item) Then
                MsgBox("Name cannot contain a numberical values", vbCritical, "Invalid Character")
                comOperator.Text = comOperator.Text.Remove(comOperator.Text.Length - 1)
            End If
        Next item
    End Sub
End Class
