Public Class MenuStripHelper

    Public Shared Sub SubMenuClickHandler(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        Dim DomainItem As ToolStripMenuItem

        If btn.Name = "ViewToolStripMenuItem" Then
            If GetMainDataGrid() Is Nothing Then
                btn.DropDownItems.Item("HideEmptyColumnsToolStripMenuItem").Enabled = False
                btn.DropDownItems.Item("SelectColumnsToolStripMenuItem").Enabled = False
                btn.DropDownItems.Item("DomainPanelToolStripMenuItem").Enabled = False
            Else
                btn.DropDownItems.Item("HideEmptyColumnsToolStripMenuItem").Enabled = True
                btn.DropDownItems.Item("SelectColumnsToolStripMenuItem").Enabled = True
                btn.DropDownItems.Item("DomainPanelToolStripMenuItem").Enabled = True

                DomainItem = DirectCast(btn.DropDownItems.Item("DomainPanelToolStripMenuItem"), ToolStripMenuItem)

                Try
                    DomainItem.Checked = Not GetMainSplitContainer0().Panel1Collapsed
                    DomainItem.Enabled = True
                Catch ex As Exception
                    DomainItem.Checked = False
                    DomainItem.Enabled = False
                End Try

            End If
        End If

        If btn.Name = "ToolsToolStripMenuItem" Then
            If IO.File.Exists(Environment.SystemDirectory & "\dsa.msc") Then
                btn.DropDownItems.Item("OpenActiveDirectoryToolStripMenuItem").Enabled = True
            Else
                btn.DropDownItems.Item("OpenActiveDirectoryToolStripMenuItem").Enabled = False
            End If
        End If

    End Sub

End Class
