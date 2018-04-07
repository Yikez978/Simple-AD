Imports System.Linq
Imports System.Windows.Forms
Imports SimpleLib

Public Module ContextMenuHelper

    Public Sub GetListViewConextMenu(ListView As ListView, e As EventArgs, ContextMenuStrip As ContextMenu, sender As Object, RowObject As DomainObject)
        If RowObject Is Nothing Then

            If ContextMenuStrip IsNot Nothing Then
                ContextMenuStrip.Show(ListView, ListView.PointToClient(Cursor.Position))
            End If

        Else

            For Each Item As MenuItem In ContextMenuStrip.MenuItems
                Item.Enabled = True
                Item.Visible = False
            Next

            If ListView.SelectedItems.Count > 1 Then

                EnableMenuItems(ContextMenuStrip, BulkUserMenuItems)

            Else

                Select Case RowObject.Type
                    Case "user"
                        EnableMenuItems(ContextMenuStrip, SingleUserMenuItemsEnabled)
                    Case "userDisabled"
                        EnableMenuItems(ContextMenuStrip, SingleUserMenuItemsDisabled)
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

    Public Sub GetDomianConextMenu(ByVal Node As TreeNode, ByVal ContextMenuStrip As ContextMenu)
        If Node.Name IsNot Nothing Then
            ContextMenuStrip.Show(Node.TreeView, Node.TreeView.PointToClient(Cursor.Position))
        End If
    End Sub

    Public Sub GetTemplateManConextMenu(ListView As ListView, e As EventArgs, ContextMenuStrip As ContextMenu, sender As Object, RowObject As DomainObject)
        ContextMenuStrip.Show(ListView, ListView.PointToClient(Cursor.Position))
    End Sub

    Private Sub EnableMenuItems(ByVal ContextMenuStrip As ContextMenu, MenuItems As String())
        For Each MenuItem As MenuItem In ContextMenuStrip.MenuItems

            If MenuItem.Tag IsNot Nothing Then
                If MenuItems.Contains(MenuItem.Tag.ToString) Then
                    MenuItem.Visible = True
                End If
            End If

        Next
    End Sub

    Private Sub DisableMenuItem(ByVal MenuItemTag As String, ByVal ContextMenuStrip As ContextMenu)
        For Each MenuItem As MenuItem In ContextMenuStrip.MenuItems

            If MenuItem.Tag IsNot Nothing Then
                If MenuItem.Tag.ToString = MenuItemTag Then
                    MenuItem.Enabled = False
                End If
            End If

        Next
    End Sub

    Private SingleUserMenuItemsEnabled As String() = {
        "CopyToClipBoardToolStripMenuItem",
        "Seperator1",
        "RenameMenuItem",
        "ResetSingleToolStripMenuItem",
        "DisableToolStripMenuItem",
        "MoveSingleToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "Seperator3",
        "PropertiesToolStripMenuItem"
        }
    Private SingleUserMenuItemsDisabled As String() = {
        "CopyToClipBoardToolStripMenuItem",
        "Seperator1",
        "RenameMenuItem",
        "ResetSingleToolStripMenuItem",
        "EnableToolStripMenuItem",
        "MoveSingleToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "Seperator3",
        "PropertiesToolStripMenuItem"
        }
    Private BulkUserMenuItems As String() = {
        "BulkModifyToolStripMenuItem",
        "ResetBulkToolStripMenuItem",
        "EnableBulkToolStripMenuItem",
        "DisableBulkToolStripMenuItem",
        "MoveBulkToolStripMenuItem",
        "DeleteBulkToolStripMenuItem",
        "Seperator3",
        "PropertiesToolStripMenuItem"
        }
    Private BulkDefaultMenuItems As String() = {
        "MoveBulkToolStripMenuItem",
        "DeleteBulkToolStripMenuItem",
        "Seperator3",
        "PropertiesToolStripMenuItem"
        }
    Private ComputerMenuItems As String() = {
        "RenameMenuItem",
        "CopyToClipBoardToolStripMenuItem",
        "PingMachineToolStripMenuItem",
        "MoveSingleToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "Seperator3",
        "PropertiesToolStripMenuItem"
        }
    Private ContainerMenuItems As String() = {
        "CopyToClipBoardToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "Seperator3",
        "PropertiesToolStripMenuItem"
        }
    Private OrganizationalUnitMenuItems As String() = {
        "RenameMenuItem",
        "CopyToClipBoardToolStripMenuItem",
        "MoveSingleToolStripMenuItem",
        "DeleteSingleToolStripMenuItem",
        "Seperator3",
        "PropertiesToolStripMenuItem"
        }
    Private DefaultMenuItems As String() = {
        "CopyToClipBoardToolStripMenuItem",
        "Seperator3",
        "PropertiesToolStripMenuItem"
        }

End Module
