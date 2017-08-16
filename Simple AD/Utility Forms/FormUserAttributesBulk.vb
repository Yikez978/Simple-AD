Public Class FormUserAttributesBulk

    Private DataTableSource As New DataTable

    Private AtrCol As New DataColumn("AttributeFull")
    Private ValCol As New DataColumn("Value")
    Private DisplCol As New DataColumn("Attribute")
    Private ReadyCol As New DataColumn("Ready")

    Private _Users As New List(Of UserRow)

    Private IsWorking As Boolean

    Public Sub New(ByVal Users As List(Of UserRow))

        InitializeComponent()

        _Users = Users

        DropDownFilter.SelectedIndex = 0

        DataTableSource.Columns.Add(AtrCol)
        DataTableSource.Columns.Add(DisplCol)
        DataTableSource.Columns.Add(ValCol)
        DataTableSource.Columns.Add(ReadyCol)

        Show()

        Dim LoadAtrThread As New Threading.Thread(AddressOf LoadAttributes)
        LoadAtrThread.Start()

    End Sub

    Private Sub LoadAttributes()
        For Each Prop As String In LDAPBulkSupportedProps
            DataTableSource.Rows.Add(Prop, GetFriendlyLDAPName(Prop), "", False)
        Next

        LoadFinished()
    End Sub

    Private Sub LoadFinished()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf LoadFinished))
        Else
            MainDataGrid.DataSource = DataTableSource
            MainDataGrid.Columns("AttributeFull").Visible = False
        End If
    End Sub

    Private Sub FilterDataGrid(ByVal Query As String)
        Dim FilteredDataView = New DataView(DataTableSource, "Attribute LIKE '*" & Query & "*' OR Value LIKE '*" & Query & "*' OR AttributeFull LIKE '*" & Query & "*'", "Attribute Desc", DataViewRowState.CurrentRows)
        MainDataGrid.DataSource = FilteredDataView
    End Sub

    Private Sub SearchBoxTb_TextChanged(sender As Object, e As EventArgs) Handles SearchBoxTb.TextChanged
        If Not String.IsNullOrEmpty(SearchBoxTb.Text) Then
            FilterDataGrid(SearchBoxTb.Text.Trim)
        Else
            MainDataGrid.DataSource = DataTableSource
        End If
    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBn.Click
        Dim Rows As List(Of DataGridViewRow) = GetCheckedRows(MainDataGrid)
        If Rows.Count > 0 Then
            For Each Row As DataGridViewRow In Rows
                Dim PropertytName As String = Row.Cells("AttributeFull").Value

                Select Case PropertytName
                    Case "proxyAddresses"
                        BulkModifyProxyAddress(Row)
                    Case Else
                        Dim ModifyThread As New Threading.Thread(AddressOf BulkModifyAbstract)
                        ModifyThread.Start(Row)
                End Select
            Next
        End If
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        If Not IsWorking Then
            Me.Close()
        Else
            MsgBox("Cannot close form while a job is in progress")
        End If
    End Sub

    Private Sub BulkModifyProxyAddress(ByVal Row As DataGridViewRow)

    End Sub

    Private Sub BulkModifyAbstract(ByVal Row As DataGridViewRow)
        For Each User As UserRow In _Users
            Dim PropertyToModify As String = Row.Cells("AttributeFull").Value.ToString
            Dim NewValue As String = Row.Cells("Value").Value.ToString

            If SetADProperty(GetDirEntryFromSAM(User.Username), PropertyToModify, NewValue) = True Then
                If User.Row.DataGridView.Columns.Contains(PropertyToModify) Then
                    User.Row.DataGridView.Invoke(New Action(Sub() User.Row.Cells.Item(PropertyToModify).Value = NewValue))
                End If
            Else
                    Dim ErrorMsg = New FormError("Falied to modify the attribute: " & Row.Cells("AttributeFull").Value.ToString & " for user: " & User.Username, My.Resources.ErrorTriangle)
            End If
        Next
    End Sub
End Class