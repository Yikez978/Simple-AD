Public Class FormSelectColumns

    Dim CurItemsLength As Integer
    Dim AvaItemsLength As Integer


    Public Sub FillCheckListBox(DataGridView As DataGridView)

        For Each column As DataGridViewColumn In DataGridView.Columns
            If Not GlobalVariables.PersistantColumns.Contains(column.Name) Then
                If column.Visible = True Then
                    CurrentColumnsLb.Items.Add(CStr(column.HeaderText))
                Else
                    AvailableColumnsLb.Items.Add(CStr(column.HeaderText))
                End If
            End If
        Next

        CurItemsLength = CurrentColumnsLb.Items.Count
        AvaItemsLength = AvailableColumnsLb.Items.Count

    End Sub

    Private Sub AcBt_Click(sender As Object, e As EventArgs) Handles AcBt.Click

        GlobalVariables.ColumnsVisibleChangedByUser = True
        GlobalVariables.CustomColumns.Clear()

        For Each column As DataGridViewColumn In FormMain.GetMainDataGrid.Columns
            If Not GlobalVariables.PersistantColumns.Contains(column.Name) Then
                column.Visible = False
            End If
        Next

        For Each item As Object In CurrentColumnsLb.Items
            For Each column As DataGridViewColumn In FormMain.GetMainDataGrid.Columns
                If column.HeaderText = CStr(item) Then
                    column.Visible = True
                    GlobalVariables.CustomColumns.Add(CStr(item))
                End If
            Next
        Next

        If FormMain.GetMainDataGrid.Columns.Contains("Filler") Then
            FormMain.GetMainDataGrid.Columns("Filler").DisplayIndex = FormMain.GetMainDataGrid.Columns.Count - 1
        End If

        Me.Close()

    End Sub

    Private Sub RmvBn_Click(sender As Object, e As EventArgs) Handles RmvBn.Click
        If CurrentColumnsLb.SelectedItems.Count > 0 Then

            Dim Items As New List(Of String)
            For Each Item In CurrentColumnsLb.SelectedItems
                Items.Add(Item)
            Next

            For i As Integer = 0 To Items.Count - 1
                AvailableColumnsLb.Items.Add(Items(i))
                CurrentColumnsLb.Items.Remove(Items(i))
            Next
        End If
    End Sub

    Private Sub AddBn_Click(sender As Object, e As EventArgs) Handles AddBn.Click
        If AvailableColumnsLb.SelectedItems.Count > 0 Then

            Dim Items As New List(Of String)
            For Each Item In AvailableColumnsLb.SelectedItems
                Items.Add(Item)
            Next

            For i As Integer = 0 To Items.Count - 1
                CurrentColumnsLb.Items.Add(Items(i))
                AvailableColumnsLb.Items.Remove(Items(i))
            Next
        End If
    End Sub

    Private Sub AddAllBn_Click(sender As Object, e As EventArgs) Handles AddAllBn.Click

        Dim AvaItemsLength = AvailableColumnsLb.Items.Count

        For Each item In AvailableColumnsLb.Items
            CurrentColumnsLb.Items.Add(item)
        Next

        AvailableColumnsLb.Items.Clear()
    End Sub

    Private Sub RmvAllBn_Click(sender As Object, e As EventArgs) Handles RmvAllBn.Click

        For Each item In CurrentColumnsLb.Items
            AvailableColumnsLb.Items.Add(item)
        Next

        CurrentColumnsLb.Items.Clear()

    End Sub

    Private Sub CnBt_Click(sender As Object, e As EventArgs) Handles CnBt.Click
        Me.Close()
    End Sub

    Private Sub SelectColumns_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AvailableColumnsLb.Items.Clear()
        CurrentColumnsLb.Items.Clear()
    End Sub

End Class