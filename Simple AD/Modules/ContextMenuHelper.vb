Public Module ContextMenuHelper

    Public Sub GetDataGridViewConextMenu(DataGrid As DataGridView, e As DataGridViewCellMouseEventArgs, ContextMenuStrip As ContextMenu, sender As Object)

        If e.Button = MouseButtons.Right Then
            Try
                If DataGrid.SelectedRows.Count = 1 Then
                    If e.RowIndex > -1 Then
                        DataGrid.ClearSelection()
                        DataGrid.Rows(e.RowIndex).Selected = True

                        If ContextMenuStrip.Name = "CMStripRowRClick" Then

                            If DataGrid.ReadOnly Then
                                ContextMenuStrip.MenuItems("DeleteRow").Enabled = False
                                ContextMenuStrip.MenuItems("InsertNewRow").Enabled = False
                            Else
                                ContextMenuStrip.MenuItems("DeleteRow").Enabled = True
                                ContextMenuStrip.MenuItems("InsertNewRow").Enabled = True
                            End If
                        End If

                        'ContextMenuStrip.Show((CInt(Cursor.Position.X)), (CInt(Cursor.Position.Y)))
                        ContextMenuStrip.Show(DataGrid, DataGrid.PointToClient(Cursor.Position))

                    End If

                ElseIf DataGrid.SelectedRows.Count > 1 Then

                    'ContextMenuStrip.Show((CInt(Cursor.Position.X)), (CInt(Cursor.Position.Y)))
                    ContextMenuStrip.Show(DataGrid, DataGrid.PointToClient(Cursor.Position))

                End If

            Catch Ex As System.ArgumentOutOfRangeException
                Debug.WriteLine("[Error] " & Ex.Message)
                Debug.WriteLine("[Error] " & Ex.StackTrace)
                Return
            End Try
        End If
    End Sub

End Module
