﻿Public Class FormMain

    Private ftdt As New DataTable

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        For Each control As ToolStripMenuItem In MainMenuStrip.Items
            AddHandler control.DropDownOpening, AddressOf MenuStripHelper.SubMenuClickHandler
        Next
    End Sub

    Private Sub DataReviewForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowsApi.SetWindowTheme(Me.Handle, “explorer”, Nothing)
        VersionLb.Text = My.Application.Info.Version.ToString

        BuildLdapAttributeMatrix()

        ColumnsVisibleChangedByUser = False
        PopulateRecentFileList()
        UserToolStripMenuItem.Text = GetDisplayName()

        Dim DragTabs As New TabDragger(MainTabCtrl, TabDragBehavior.TabDragOut)

        If My.Settings.CheckForUpdatesOnStart = True Then
            Dim RunUpdateCheck As New FormUpdate
        End If
    End Sub

    Private Sub HideEmptyColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideEmptyColumnsToolStripMenuItem.Click
        If HideEmptyColumnsToolStripMenuItem.Checked = False Then

            For Each Column In HiddenColums
                If Not Column = "Status" Then
                    GetMainDataGrid().Columns(Column).Visible = True
                End If
            Next
        Else
            If Not HideColumnsWorker.GetCBWBusy Then
                HideColumnsWorker.HideColumns(GetMainDataGrid())
            Else
                HideEmptyColumnsToolStripMenuItem.CheckState = CheckState.Checked
                Return
            End If
        End If

    End Sub

    Private Sub ExportAsCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAsCSVToolStripMenuItem.Click
        With ExportCSVDialog
            .Title = "Export CSV File"
            .Filter = "Comma Dellimited|*.csv"
            .FileName = "SimpleAD_Export"
        End With

        ExportCSVDialog.ShowDialog()
    End Sub

    Private Sub ExportCSVWriteFile(sender As Object, e As EventArgs) Handles ExportCSVDialog.FileOk
        FileExportHelper.ExportFile(GetMainDataGrid, ExportCSVDialog)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        FormOptions.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub SelectColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColumnsToolStripMenuItem.Click

        If Not FormSelectColumns.Visible Then
            FormSelectColumns.FillCheckListBox(GetMainDataGrid())
            FormSelectColumns.ShowDialog()
        End If
    End Sub

    Private Sub ImportCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportCSVToolStripMenuItem.Click
        BulkUserInit()
    End Sub

    Public Sub BulkUserInit()
        OpenFileDialogImport.Title = "Import a CSV File"
        OpenFileDialogImport.Filter = "Comma Dellimited|*.csv"
        OpenFileDialogImport.ShowDialog()

        Dim csvPathSs = OpenFileDialogImport.FileName

        If csvPathSs IsNot Nothing Then
            Try
                If IO.File.Exists(OpenFileDialogImport.FileName) Then
                    If Not FileInUse(OpenFileDialogImport.FileName) Then

#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
                        SaveRecentFile(OpenFileDialogImport.FileName)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

                        Dim NewImportFile = New JobUserBulk(OpenFileDialogImport.FileName)

                    Else
                        Debug.WriteLine("[Error] Unable to open file as it is being used by another process")
                        MsgBox("Unable to open file as it is being used by another process")
                    End If
                End If
            Catch Ex As Exception
                Debug.WriteLine("[Error] " & Ex.Message)
            End Try
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MainApplicationForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub ViewSideBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        GetMainSplitContainer1.Panel2Collapsed = Not GetMainSplitContainer1.Panel2Collapsed
    End Sub

    Public Sub FileToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownOpening
        PopulateRecentFileList()
    End Sub

    Private Sub ToolStripMenuItemLogin_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemLogin.Click
        FormLogin.Text = "Switch User"
        FormLogin.ShowDialog()
    End Sub

    Private Sub DomainPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomainPanelToolStripMenuItem.Click
        GetMainSplitContainer0.Panel1Collapsed = Not GetMainSplitContainer0.Panel1Collapsed
    End Sub

    Private Sub BulkUserWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkUserWizardToolStripMenuItem.Click
        FormBulkUser.ShowDialog()
    End Sub

    Public Sub CloseTab(TabPage As TabPage)
        GetMainTabCtrl.TabPages.Remove(TabPage)
    End Sub

    Private Sub MainTabCtrl_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MainTabCtrl.Click
        If e.Button = MouseButtons.Right Then
            For index As Integer = 0 To Me.MainTabCtrl.TabCount - 1 Step 1
                If Me.MainTabCtrl.GetTabRect(index).Contains(e.Location) Then
                    TabContextMenu.Show(Cursor.Position)
                    RightClickedTab = MainTabCtrl.TabPages(index)
                    Exit For
                End If
            Next index
        End If
    End Sub

    Private Sub DisabledUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisabledUsersToolStripMenuItem.Click
        Dim NewReport As JobUserReport = New JobUserReport(ReportType.DisabledUsers)
    End Sub

    Private Sub CustomQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomQueryToolStripMenuItem.Click
        FormLDAPQuery.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        CloseTab(RightClickedTab)
    End Sub

    Private Sub OpenActiveDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenActiveDirectoryToolStripMenuItem.Click
        Try
            Dim procInfo As New ProcessStartInfo() With {
            .UseShellExecute = True,
            .FileName = (Environment.SystemDirectory & "\dsa.msc"),
            .WorkingDirectory = "",
            .Verb = "runas"}

            Process.Start(procInfo)
        Catch ex As Exception
            Debug.WriteLine("[Error] " & ex.Message)
        End Try
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        FormO365Login.ShowDialog()
    End Sub

    Private Sub MainTabCtrl_Selected(sender As Object, e As TabControlEventArgs)
        If Not e.TabPage Is Nothing Then
            If e.TabPage.Tag = "365" Then
                Me.Style = MetroFramework.MetroColorStyle.Orange
                Me.Refresh()
            ElseIf e.TabPage.Tag = "Report" Then
                Me.Style = MetroFramework.MetroColorStyle.Purple
                Me.Refresh()
            Else
                Me.Style = MetroFramework.MetroColorStyle.Default
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        FormUpdate.Show()
    End Sub

    Private Sub EntireDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntireDirectoryToolStripMenuItem.Click
        Dim NewReport As JobUserReport = New JobUserReport(ReportType.AllObjects)
    End Sub

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        FormConsole.Show()
    End Sub

    Private Sub BrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseToolStripMenuItem.Click
        Dim NewReport As JobUserReport = New JobUserReport(ReportType.Explorer)
    End Sub

End Class