Public Class ContextMenuHelper

    Public Shared Sub GetDataGridViewConextMenu(DataGrid As DataGridView, e As DataGridViewCellMouseEventArgs, ContextMenuStrip As ContextMenuStrip)

        If e.Button = MouseButtons.Right Then
            Try
                Debug.WriteLine("Right Click detected" & DataGrid.Rows(e.RowIndex).ToString)

                If DataGrid.SelectedRows.Count = 1 Then

                    DataGrid.ClearSelection()
                    DataGrid.Rows(e.RowIndex).Selected = True

                    If DataGrid.ReadOnly Then
                        ContextMenuStrip.Items("DeleteRow").Enabled = False
                        ContextMenuStrip.Items("InsertNewRow").Enabled = False
                    Else
                        ContextMenuStrip.Items("DeleteRow").Enabled = True
                        ContextMenuStrip.Items("InsertNewRow").Enabled = True
                    End If

                    ContextMenuStrip.Show((CInt(Cursor.Position.X)), (CInt(Cursor.Position.Y)))

                ElseIf DataGrid.SelectedRows.Count > 1 Then

                    ContextMenuStrip.Show((CInt(Cursor.Position.X)), (CInt(Cursor.Position.Y)))
                End If

            Catch Ex As System.ArgumentOutOfRangeException
                Return
            End Try
        End If
    End Sub

End Class
