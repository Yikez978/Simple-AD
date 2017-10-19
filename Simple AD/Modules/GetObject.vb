Public Module GetObject

    Public Function GetMainTabCtrl() As TabControl
        Try
            Return FormMain.MainTabCtrl
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetMainSplitContainer0() As SplitContainer
        Try
            Dim CurrentTab As TabPage = GetMainTabCtrl.SelectedTab
            Dim MainContainer As Object = CurrentTab.Controls.Item(0)
            Return MainContainer.GetMainSplitContainer0()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetMainSplitContainer1() As SplitContainer
        Try
            Dim CurrentTab As TabPage = GetMainTabCtrl.SelectedTab
            Dim MainContainer As Object = CurrentTab.Controls.Item(0)
            Return MainContainer.GetMainSplitContainer1()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetBulkUserContainer() As ContainerImport
        Dim CurrentTab As ContainerImport = GetMainTabCtrl.SelectedTab.Controls.Item(0)
        Return CurrentTab
    End Function

    Public Function GetDomainPanel() As ControlDomainTreeView
        Try
            Dim CurrentTab As ContainerExplorer = GetMainTabCtrl.SelectedTab.Controls.Item(0)
            Return CurrentTab.GetDomainPanel()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetMainListView() As ControlListView
        Try
            Dim CurrentTab As Object = GetMainTabCtrl.SelectedTab.Controls.Item(0)
            Return CurrentTab.GetMainListView()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetStatusStrip() As StatusStrip
        Try
            Return FormMain.StatusStrip()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetExplorerTab() As TabPage
        Return FormMain.MainTabCtrl.TabPages("ExplorerTab")
    End Function

    Public Function GetImportTab() As TabPage
        Return FormMain.MainTabCtrl.TabPages("ImportTab")
    End Function

    Public Function GetTemplateTab() As TabPage
        Return FormMain.MainTabCtrl.TabPages("TemplateTab")
    End Function

    Public ExplorerContainerHandle As ContainerExplorer
    Public Function GetContainerExplorer() As ContainerExplorer
        Return ExplorerContainerHandle
    End Function

    Public ImportContainerHandle As ContainerImport
    Public Function GetContainerImport() As ContainerImport
        Return ImportContainerHandle
    End Function

    Public TemplateContainerHandle As ContainerTemplate
    Public Function GetContainerTemplate() As ContainerTemplate
        Return TemplateContainerHandle
    End Function

    Public TaskFlowHandle As TableLayoutPanel
    Public Function GetTaskFlow() As TableLayoutPanel
        Return TaskFlowHandle
    End Function

End Module
