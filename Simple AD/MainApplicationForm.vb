Imports Simple_AD.FileSystemHelper

Public Class MainApplicationForm

    Private ftdt As New DataTable

    Private Importer As New LocalData

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        For Each control As ToolStripMenuItem In MainMenuStrip.Items
            AddHandler control.DropDownOpening, AddressOf MenuStripHelper.SubMenuClickHandler
        Next
    End Sub

    Private Sub DataReviewForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RunUpdater()

        GlobalVariables.ColumnsVisibleChangedByUser = False

        Importer.PopulateRecentFileList()
        UserToolStripMenuItem.Text = GetDisplayName()

        Me.BackColor = SystemColors.Control

        Dim DragTabs As New TabDragger(MainTabCtrl, TabDragBehavior.TabDragOut)

    End Sub

    Private Sub HideEmptyColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideEmptyColumnsToolStripMenuItem.Click
        If HideEmptyColumnsToolStripMenuItem.Checked = False Then

            For Each Column In GlobalVariables.HiddenColums
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
        FileExportHelper.ExportFile(GetMainDataGrid(), ExportCSVDialog)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        OptionsForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub SelectColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColumnsToolStripMenuItem.Click

        If Not SelectColumns.Visible Then
            SelectColumns.FillCheckListBox(GetMainDataGrid())
            SelectColumns.ShowDialog()
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
                        Importer.SaveRecentFile(OpenFileDialogImport.FileName)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

                        Dim NewImportFile = New JobUserBulk(OpenFileDialogImport.FileName)

                    Else
                        MsgBox("Unable to open file as it is being used by another process")
                    End If
                End If
            Catch Ex As Exception
                MessageBox.Show("Error: " & Ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore)
                Debug.WriteLine("Error: " & Ex.Message)
            End Try
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MainApplicationForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Public Function GetMainTabCtrl() As TabControl
        Try
            Return Me.MainTabCtrl
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Public Shared Function GetMainSplitContainer0() As SplitContainer
        Try
            Dim CurrentTab As TabPage = MainApplicationForm.GetMainTabCtrl.SelectedTab
            Dim MainContainer As Object = CurrentTab.Controls.Item(0)
            Return MainContainer.GetMainSplitContainer0()
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Public Shared Function GetMainSplitContainer1() As SplitContainer
        Try
            Dim CurrentTab As TabPage = MainApplicationForm.GetMainTabCtrl.SelectedTab
            Dim MainContainer As Object = CurrentTab.Controls.Item(0)
            Return MainContainer.GetMainSplitContainer1()
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Public Shared Function GetMainDataGrid() As DataGridView
        Try
            Dim CurrentTab As TabPage = MainApplicationForm.GetMainTabCtrl.SelectedTab
            Dim MainContainer As Object = CurrentTab.Controls.Item(0)
            Return MainContainer.GetMainDataGrid()
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Public Shared Function GetBulkUserContainer() As ContainerUserBulk
        Dim CurrentTab As ContainerUserBulk = MainApplicationForm.GetMainTabCtrl.SelectedTab.Controls.Item(0)
        Return CurrentTab
    End Function

    Public Shared Function GetPropertisPanel() As UserProperties
        Try
            Dim CurrentTab As ContainerUserBulk = MainApplicationForm.GetMainTabCtrl.SelectedTab.Controls.Item(0)
            Return CurrentTab.GetPropertisPanel()
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message.ToString)
            Return Nothing
        End Try
    End Function
    Private Sub ViewSideBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesSideBarToolStripMenuItem.Click
        GetMainSplitContainer1.Panel2Collapsed = Not GetMainSplitContainer1.Panel2Collapsed
    End Sub

    Public Sub FileToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownOpening
        Importer.PopulateRecentFileList()
    End Sub

    Private Sub ToolStripMenuItemLogin_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemLogin.Click
        LoginForm.Text = "Switch User"
        LoginForm.ShowDialog()
    End Sub

    Private Sub DomainPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomainPanelToolStripMenuItem.Click
        GetMainSplitContainer0.Panel1Collapsed = Not GetMainSplitContainer0.Panel1Collapsed
    End Sub

    Private Sub BulkUserWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulkUserWizardToolStripMenuItem.Click
        BulkUserForm.ShowDialog()
    End Sub

    Public Sub CloseTab(TabPage As TabPage)
        GetMainTabCtrl.TabPages.Remove(TabPage)
    End Sub

    Private Sub MainTabCtrl_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MainTabCtrl.Click
        If e.Button = MouseButtons.Right Then
            For index As Integer = 0 To Me.MainTabCtrl.TabCount - 1 Step 1
                If Me.MainTabCtrl.GetTabRect(index).Contains(e.Location) Then
                    TabContextMenu.Show(Cursor.Position)
                    GlobalVariables.RightClickedTab = MainTabCtrl.TabPages(index)
                    Exit For
                End If
            Next index
        End If
    End Sub

    Private Sub DisabledUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisabledUsersToolStripMenuItem.Click
        Dim NewReport As JobUserReport = New JobUserReport(ReportType.DisabledUsers)
    End Sub

    Private Sub CustomQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomQueryToolStripMenuItem.Click
        LDAPQueryForm.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        CloseTab(GlobalVariables.RightClickedTab)
    End Sub

    Private Sub OpenActiveDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenActiveDirectoryToolStripMenuItem.Click
        Try
            Dim procInfo As New ProcessStartInfo()
            procInfo.UseShellExecute = True
            procInfo.FileName = (Environment.SystemDirectory & "\dsa.msc")
            procInfo.WorkingDirectory = ""
            procInfo.Verb = "runas"
            Process.Start(procInfo)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        O365Login.ShowDialog()
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

    Private Sub MainTabCtrl_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainTabCtrl_MouseClick(sender As Object, e As EventArgs) Handles MainTabCtrl.Click

    End Sub
End Class