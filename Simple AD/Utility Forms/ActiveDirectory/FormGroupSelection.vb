Imports System.DirectoryServices

Public Class FormGroupSelection

    Private Enum GroupType
        Security = 0
        Distribution = 1
    End Enum

    Private DataTableSource As DataTable = New DataTable

    Private Sub GroupSelectionForm_Load() Handles MyBase.Load

        DataTableSource.Columns.Clear()
        DataTableSource.Rows.Clear()

        Dim Namecol As New DataColumn
        Namecol.ColumnName = "Name"
        Dim Type As New DataColumn
        Type.ColumnName = "Type"
        Dim Description As New DataColumn
        Description.ColumnName = "Description"

        DataTableSource.Columns.Add(Namecol)
        DataTableSource.Columns.Add(Type)
        DataTableSource.Columns.Add(Description)

        MainGrid.DataSource = DataTableSource

        MainGrid.ClearSelection()

        Dim SearchThread As New Threading.Thread(AddressOf GetGroups)
        SearchThread.IsBackground = True
        SearchThread.Start()

    End Sub

    Private Sub SearchBn_Click(sender As Object, e As EventArgs) Handles SearchBn.Click
        FilterDataGrid(SelectGroupTb.Text.Trim)
    End Sub

    Private Sub FilterDataGrid(ByVal Query As String)
        Dim FilteredDataView As DataView

        FilteredDataView = New DataView(DataTableSource, "Name LIKE '*" & Query & "*' ", "Name Desc", DataViewRowState.CurrentRows)
        MainGrid.DataSource = FilteredDataView
    End Sub


    Private Sub AddGroupToGrid(ByVal Name As String, Type As GroupType, Description As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String, GroupType, String)(AddressOf AddGroupToGrid), Name, Type, Description)
        Else
            DataTableSource.Rows.Add(Name, Type, Description)
        End If
    End Sub

    Private Sub GetGroups()

        Dim Entry As DirectoryEntry = New DirectoryEntry(GetDirEntry, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)

        Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

        With DirSearcher
            .SearchRoot = Entry
            .Filter = "(objectCategory=group)"
            .PropertiesToLoad.AddRange(New String() {"cn", "sAMAccountType", "Description"})
        End With

        Dim results As SearchResultCollection = DirSearcher.FindAll()
        For Each result As SearchResult In results
            Dim type As GroupType
            Dim resultType = result.GetDirectoryEntry().Properties("sAMAccountType").Value
            If resultType = "268435457" Then
                type = 1
            Else
                type = 0
            End If
            AddGroupToGrid(result.GetDirectoryEntry().Properties("cn").Value, type, result.GetDirectoryEntry().Properties("description").Value)
        Next

        SearchFinished()

        DirSearcher.Dispose()
        Entry.Dispose()
    End Sub

    Private Sub SearchFinished()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf SearchFinished))
        Else

        End If
    End Sub

    Private Sub SelectGroupTb_TextChanged(sender As Object, e As EventArgs) Handles SelectGroupTb.TextChanged
        If Not String.IsNullOrEmpty(SelectGroupTb.Text) Then
            FilterDataGrid(SelectGroupTb.Text.Trim)
        Else
            MainGrid.DataSource = DataTableSource
        End If
    End Sub

End Class