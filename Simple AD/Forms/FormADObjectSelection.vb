Imports System.DirectoryServices
Imports SimpleLib

Public Class FormADObjectSelection

        Private Enum GroupType
            Security = 0
            Distribution = 1
        End Enum

        Private DataTableSource As DataTable

        Private Sub GroupSelectionForm_Load() Handles MyBase.Load

            DataTableSource = New DataTable

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
            Try
                FilteredDataView = New DataView(DataTableSource, "Name LIKE '*" & Query & "*' ", "Name Desc", DataViewRowState.CurrentRows)
                MainGrid.DataSource = FilteredDataView
            Catch Ex As Exception
            Logger.Log("[Error] Invalid Search String: " & Ex.Message)
        End Try
        End Sub


        Private Sub AddGroupToGrid(ByVal Name As String, Type As GroupType, Description As String)
            If Me.InvokeRequired Then
                Me.Invoke(New Action(Of String, GroupType, String)(AddressOf AddGroupToGrid), Name, Type, Description)
            Else
                DataTableSource.Rows.Add(Name, Type, Description)
            End If
        End Sub

        Private Sub GetGroups()

            Dim Entry As DirectoryEntry = New DirectoryEntry(GetDirEntryPath, LoginUsername, LoginPassword)

            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = "(objectCategory=group)"
                .PropertiesToLoad.AddRange(New String() {"cn", "sAMAccountType", "Description"})
            End With

            Dim results As SearchResultCollection = DirSearcher.FindAll()
            For Each result As SearchResult In results
                Dim type As GroupType
                Dim resultType As String = result.GetDirectoryEntry().Properties("sAMAccountType").Value.ToString
                If resultType = "268435457" Then
                    type = GroupType.Distribution
                Else
                    type = GroupType.Security
                End If
                AddGroupToGrid(result.GetDirectoryEntry().Properties("cn").Value.ToString, type, result.GetDirectoryEntry().Properties("description").Value.ToString)
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