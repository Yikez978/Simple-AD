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

    Public Function GetMainDataGrid() As DataGridView
        Try
            Dim CurrentTab As TabPage = GetMainTabCtrl.SelectedTab
            Dim MainContainer As Object = CurrentTab.Controls.Item(0)
            Return MainContainer.GetMainDataGrid()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetBulkUserContainer() As ContainerUserBulk
        Dim CurrentTab As ContainerUserBulk = GetMainTabCtrl.SelectedTab.Controls.Item(0)
        Return CurrentTab
    End Function

    Public Function GetDomainPanel() As ControlDomainTreeView
        Try
            Dim CurrentTab As ContainerUserReport = GetMainTabCtrl.SelectedTab.Controls.Item(0)
            Return CurrentTab.GetDomainPanel()
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetMainListView() As ControlListView
        Try
            Dim CurrentTab As ContainerUserReport = GetMainTabCtrl.SelectedTab.Controls.Item(0)
            Return CurrentTab.MainListView
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return Nothing
        End Try
    End Function

End Module
