Public Class UpCounter
    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        For Each item As Char In txtNumber.Text
            If IsNumeric(item) = False Then
                MsgBox("Name cannot contain a alphabetical values", vbCritical, "Invalid Character")
                txtNumber.Text = txtNumber.Text.Remove(txtNumber.Text.Length - 1)
            End If
        Next item
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtNumber.Text <> Nothing Then
            Dim rs As Boolean = UpdateCounter(CInt(txtNumber.Text))
            If rs = False Then
                MsgBox("Update failed!", vbCritical, "Update")
            Else
                MsgBox("Counter number updated successfully.", vbInformation, "Sucess")
                Me.Close()
            End If
        Else
            MsgBox("Please enter new counter values", vbExclamation, "Empty Field")
        End If
    End Sub

    Private Sub UpCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumber.Text = Nothing
    End Sub
End Class