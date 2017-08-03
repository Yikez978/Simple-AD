Public Class MenuStripHelper

    Public Shared Sub SubMenuClickHandler(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        Dim PropertiesItem As ToolStripMenuItem
        Dim DomainItem As ToolStripMenuItem

        If btn.Name = "ViewToolStripMenuItem" Then
            If MainApplicationForm.GetMainDataGrid() Is Nothing Then
                btn.DropDownItems.Item("HideEmptyColumnsToolStripMenuItem").Enabled = False
                btn.DropDownItems.Item("SelectColumnsToolStripMenuItem").Enabled = False
                btn.DropDownItems.Item("DomainPanelToolStripMenuItem").Enabled = False
                btn.DropDownItems.Item("PropertiesSideBarToolStripMenuItem").Enabled = False
            Else
                btn.DropDownItems.Item("HideEmptyColumnsToolStripMenuItem").Enabled = True
                btn.DropDownItems.Item("SelectColumnsToolStripMenuItem").Enabled = True
                btn.DropDownItems.Item("DomainPanelToolStripMenuItem").Enabled = True
                btn.DropDownItems.Item("PropertiesSideBarToolStripMenuItem").Enabled = True

                PropertiesItem = DirectCast(btn.DropDownItems.Item("PropertiesSideBarToolStripMenuItem"), ToolStripMenuItem)
                DomainItem = DirectCast(btn.DropDownItems.Item("DomainPanelToolStripMenuItem"), ToolStripMenuItem)

                Try
                    PropertiesItem.Checked = Not MainApplicationForm.GetMainSplitContainer1().Panel2Collapsed
                    DomainItem.Checked = Not MainApplicationForm.GetMainSplitContainer0().Panel1Collapsed

                    PropertiesItem.Enabled = True
                    DomainItem.Enabled = True
                Catch ex As Exception
                    PropertiesItem.Checked = False
                    PropertiesItem.Enabled = False

                    DomainItem.Checked = False
                    DomainItem.Enabled = False
                    Debug.WriteLine(ex.Message)
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
