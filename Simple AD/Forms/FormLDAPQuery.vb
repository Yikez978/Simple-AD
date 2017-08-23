Public Class FormLDAPQuery
    Private Sub LDAPQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RunBn.Enabled = False
        QueryTb.Select()
    End Sub

    Private Sub QueryTb_TextChanged(sender As Object, e As EventArgs) Handles QueryTb.TextChanged
        If Not String.IsNullOrEmpty(QueryTb.Text) Then
            RunBn.Enabled = True
        Else
            RunBn.Enabled = False
        End If
    End Sub

    Private Sub RunBn_Click(sender As Object, e As EventArgs) Handles RunBn.Click
        Me.Hide()
        Dim NewCustomQueryReport As JobUserReport = New JobUserReport(ReportType.CustomLDAP, QueryTb.Text.Trim)
        Me.Close()
    End Sub
End Class