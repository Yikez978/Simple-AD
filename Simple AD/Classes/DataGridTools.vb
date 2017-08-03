Module DataGridTools

    Public Function GetMainDataGrid(SourceGrid As DataGridView)

        Dim targetGrid As New DataGridView
        Dim targetRows = New List(Of DataGridViewRow)

        For Each sourceRow As DataGridViewRow In SourceGrid.Rows

            If (Not sourceRow.IsNewRow) Then

                Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)

                For i As Integer = 0 To sourceRow.Cells.Count - 1
                    targetRow.Cells(i).Value = sourceRow.Cells(i).Value
                Next

                targetRows.Add(targetRow)

            End If

        Next

        targetGrid.Columns.Clear()

        Try
            For Each column As DataGridViewColumn In SourceGrid.Columns
                targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
            Next

            targetGrid.Rows.AddRange(targetRows.ToArray())

        Catch Ex As Exception
            Debug.WriteLine(Ex)
        End Try

        Return targetGrid
    End Function

    Public Function GetCellContents(DataViewGrid As DataGridView, ColumnName As String, Row As Integer)

        Dim Result As String

        Try
            Result = DataViewGrid.Rows.Item(Row).Cells(ColumnName).Value
        Catch Ex As System.InvalidCastException
            Result = ""
        End Try
        Return Result
    End Function

End Module
