Public Module MenuStripHelper

    Public Sub SubMenuClickHandler(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        Dim DomainItem As ToolStripMenuItem

        If btn.Name = "ViewToolStripMenuItem" Then
            If GetMainListView() Is Nothing Then
                btn.DropDownItems.Item("DomainPanelToolStripMenuItem").Enabled = False
            Else
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

            If GetMainListView() Is Nothing Then
                btn.DropDownItems.Item("ModeToolStripMenuItem").Enabled = False
                btn.DropDownItems.Item("ShowGroupsToolStripMenuItem").Enabled = False
            Else
                btn.DropDownItems.Item("ModeToolStripMenuItem").Enabled = True
                btn.DropDownItems.Item("ShowGroupsToolStripMenuItem").Enabled = True
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

End Module
