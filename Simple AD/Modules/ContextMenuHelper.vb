Public Module ContextMenuHelper

    Public Sub GetDataGridViewConextMenu(DataGrid As DataGridView, e As DataGridViewCellMouseEventArgs, ContextMenuStrip As ContextMenuStrip)

        If e.Button = MouseButtons.Right Then
            Try
                If DataGrid.SelectedRows.Count = 1 Then
                    If e.RowIndex > -1 Then
                        DataGrid.ClearSelection()
                        DataGrid.Rows(e.RowIndex).Selected = True

                        If ContextMenuStrip.Name = "CMStripRowRClick" Then

                            If DataGrid.ReadOnly Then
                                ContextMenuStrip.Items("DeleteRow").Enabled = False
                                ContextMenuStrip.Items("InsertNewRow").Enabled = False
                            Else
                                ContextMenuStrip.Items("DeleteRow").Enabled = True
                                ContextMenuStrip.Items("InsertNewRow").Enabled = True
                            End If
                        End If

                        ContextMenuStrip.Show((CInt(Cursor.Position.X)), (CInt(Cursor.Position.Y)))


                    End If

                ElseIf DataGrid.SelectedRows.Count > 1 Then

                    ContextMenuStrip.Show((CInt(Cursor.Position.X)), (CInt(Cursor.Position.Y)))

                End If

            Catch Ex As System.ArgumentOutOfRangeException
                Debug.WriteLine("[Error] " & Ex.Message)
                Debug.WriteLine("[Error] " & Ex.StackTrace)
                Return
            End Try
        End If
    End Sub

End Module
