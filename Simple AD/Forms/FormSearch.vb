Imports System
Imports BrightIdeasSoftware

Public Class FormSearch

    Private _UIHandler As UIHandler

    Public Sub New()
        InitializeComponent()

        SearchResultsListView.SetListStyle()
        SearchResultsListView.PrimarySortColumn = TypeCol

        NameCol.ImageGetter = New ImageGetterDelegate(AddressOf SearchResultsListView.ImageGetter)

        InitEventHandlers()

    End Sub

    Private Sub SearchBn_Click(sender As Object, e As EventArgs) Handles SearchBn.Click

        Dim SearchTask As New TaskSearch(SearchResultsListView, SearchTb.Text.Trim)
        SearchTask.RunSearch()

    End Sub

    Private Sub InitEventHandlers()

        SearchResultsListView.RowContextMenu = RowObjectContextMenu

        _UIHandler = New UIHandler(SearchResultsListView, GetContainerExplorer)

        AddHandler SearchResultsListView.SelectionChanged, AddressOf RefreshToolStrip
        AddHandler SearchResultsListView.ItemsChanged, AddressOf RefreshToolStrip

        AddHandler DeleteBulkToolStripMenuItem.Click, AddressOf _UIHandler.DeleteBulk_Click
        AddHandler MoveSingleToolStripMenuItem.Click, AddressOf _UIHandler.MoveSingle_Click
        AddHandler ResetSingleToolStripMenuItem.Click, AddressOf _UIHandler.ResetSingle_Click
        AddHandler EnableToolStripMenuItem.Click, AddressOf _UIHandler.Enable_Click
        AddHandler DisableToolStripMenuItem.Click, AddressOf _UIHandler.Disable_Click
        AddHandler EnableBulkToolStripMenuItem.Click, AddressOf _UIHandler.EnableBulk_Click
        AddHandler DisableBulkToolStripMenuItem.Click, AddressOf _UIHandler.DisableBulk_Click
        AddHandler DeleteSingleToolStripMenuItem.Click, AddressOf _UIHandler.DeleteSingle_Click
        AddHandler BulkModifyToolStripMenuItem.Click, AddressOf _UIHandler.BulkModify_Click
        AddHandler MoveBulkToolStripMenuItem.Click, AddressOf _UIHandler.MoveBulk_Click
        AddHandler ResetBulkToolStripMenuItem.Click, AddressOf _UIHandler.ResetBulk_Click
        AddHandler PingMachineToolStripMenuItem.Click, AddressOf _UIHandler.Ping_Click

        AddHandler PropertiesToolStripMenuItem.Click, AddressOf _UIHandler.PropertiesSingle_Click
        AddHandler SearchResultsListView.ItemActivate, AddressOf _UIHandler.PropertiesSingle_Click

        AddHandler CopyDNToolStripMenuItem.Click, AddressOf _UIHandler.CopyDNToolStripMenuItem_Click
        AddHandler CopyNameToolStripMenuItem.Click, AddressOf _UIHandler.CopyNameToolStripMenuItem_Click
        AddHandler CopySamToolStripMenuItem.Click, AddressOf _UIHandler.CopySamToolStripMenuItem_Click

    End Sub

End Class