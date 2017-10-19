Public Module ContextMenuHelper

    Public Sub GetListViewConextMenu(ListView As ListView, e As EventArgs, ContextMenuStrip As ContextMenu, sender As Object, RowObject As DomainObject)
        If RowObject Is Nothing Then
            ContextMenuStrip.Show(ListView, ListView.PointToClient(Cursor.Position))
        Else

            For Each Item As MenuItem In ContextMenuStrip.MenuItems
                Item.Enabled = True
                Item.Visible = False
            Next

            If ListView.SelectedItems.Count > 1 Then

                Debug.WriteLine("[INFO] Multiple Objects Selected Object Selected")
                EnableMenuItems(ContextMenuStrip, BulkUserMenuItems)

            Else
                Debug.WriteLine("[INFO] " & RowObject.Type & " Object Selected")
                Select Case RowObject.Type
                    Case "user"
                        EnableMenuItems(ContextMenuStrip, SingleUserMenuItems)
                    Case "computer"
                        EnableMenuItems(ContextMenuStrip, ComputerMenuItems)
                    Case "container"
                        EnableMenuItems(ContextMenuStrip, ContainerMenuItems)
                    Case "organizationalUnit"
                        EnableMenuItems(ContextMenuStrip, OrganizationalUnitMenuItems)
                    Case Else
                        EnableMenuItems(ContextMenuStrip, DefaultMenuItems)

                        If RowObject.IsCriticalSystemObject Then
                            DisableMenuItem("DeleteSingleToolStripMenuItem", ContextMenuStrip)
                            DisableMenuItem("MoveSingleToolStripMenuItem", ContextMenuStrip)
                        End If

                End Select
            End If
            ContextMenuStrip.Show(ListView, ListView.PointToClient(Cursor.Position))
        End If
    End Sub

    Public Sub GetTemplateManConextMenu(ListView As ListView, e As EventArgs, ContextMenuStrip As ContextMenu, sender As Object, RowObject As DomainObject)
        ContextMenuStrip.Show(ListView, ListView.PointToClient(Cursor.Position))
    End Sub

    Private Sub EnableMenuItems(ByVal ContextMenuStrip As ContextMenu, MenuItems As String())
        For Each MenuItem As MenuItem In ContextMenuStrip.MenuItems
            If MenuItems.Contains(MenuItem.Tag) Then
                MenuItem.Visible = True
            End If
        Next
    End Sub

    Private Sub DisableMenuItem(ByVal MenuItemTag As String, ByVal ContextMenuStrip As ContextMenu)
        For Each MenuItem As MenuItem In ContextMenuStrip.MenuItems
            If MenuItem.Tag = MenuItemTag Then
                MenuItem.Enabled = False
            End If
        Next
    End Sub

    Private SingleUserMenuItems As String() = {
        "RenameMenuItem",
        "CopyToClipBoardToolStripMenuItem",
        "ResetSingleToolStripMenuItem",
        "EnableDisableSingleToolStripMenuItem",
        "MoveSingleToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "PropertiesToolStripMenuItem"
        }
    Private BulkUserMenuItems As String() = {
        "BulkModifyToolStripMenuItem",
        "ResetBulkToolStripMenuItem",
        "EnableDisableBulkToolStripMenuItem",
        "MoveBulkToolStripMenuItem",
        "DeleteBulkToolStripMenuItem",
        "PropertiesToolStripMenuItem"
        }
    Private BulkDefaultMenuItems As String() = {
        "MoveBulkToolStripMenuItem",
        "DeleteBulkToolStripMenuItem",
        "PropertiesToolStripMenuItem"
        }
    Private ComputerMenuItems As String() = {
        "RenameMenuItem",
        "CopyToClipBoardToolStripMenuItem",
        "EnableDisableSingleToolStripMenuItem",
        "MoveSingleToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "PropertiesToolStripMenuItem"
        }
    Private ContainerMenuItems As String() = {
        "CopyToClipBoardToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "PropertiesToolStripMenuItem"
        }
    Private OrganizationalUnitMenuItems As String() = {
        "RenameMenuItem",
        "CopyToClipBoardToolStripMenuItem",
        "MoveSingleToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "PropertiesToolStripMenuItem"
        }
    Private DefaultMenuItems As String() = {
        "RenameMenuItem",
        "CopyToClipBoardToolStripMenuItem",
        "MoveSingleToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "PropertiesToolStripMenuItem"
        }
End Module
