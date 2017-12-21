Public Module GetObject

    Public Function GetStatusStrip() As StatusStrip
        Try
            Return FormMain.StatusStrip()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public ExplorerSplitContainerHandle As ControlSplitConatiner
    Public Function GetExplorerSplitContainer() As ControlSplitConatiner
        Return ExplorerSplitContainerHandle
    End Function

    Public MainListViewHandle As ControlListView
    Public Function GetMainListView() As ControlListView
        Return MainListViewHandle
    End Function

    Public ExplorerContainerHandle As ContainerExplorer
    Public Function GetContainerExplorer() As ContainerExplorer
        Return ExplorerContainerHandle
    End Function

    Public TaskFlowHandle As Panel
    Public Function GetTaskFlow() As Panel
        Return TaskFlowHandle
    End Function

    Public MainDomainTreeViewHandle As ControlDomainTreeView
    Public Function GetMainDomainTreeView() As ControlDomainTreeView
        Return MainDomainTreeViewHandle
    End Function

End Module
