Imports System.DirectoryServices

Public Class FormUserAttributes

    Private _sAMAccountName As String
    Private _defualtCellValue As Object
    Private _Job As JobUserReport

    Private DataTableSource As New DataTable

    Private AtrCol As New DataColumn("AttributeFull")
    Private ValCol As New DataColumn("Value")
    Private DisplCol As New DataColumn("Attribute")

    Public Sub New(ByVal sAMAccountName As String, ByVal Name As String, Item As BrightIdeasSoftware.OLVListItem, ByVal Job As JobUserReport)

        InitializeComponent()

        Text = Name
        ObjectName.Text = Name
        ObjectType.Text = GetProperName(GetDirEntryFromSAM(sAMAccountName).SchemaClassName)

        DropDownFilter.SelectedIndex = 0

        _Job = Job
        _sAMAccountName = sAMAccountName

        DataTableSource.Columns.Add(AtrCol)
        DataTableSource.Columns.Add(DisplCol)
        DataTableSource.Columns.Add(ValCol)

        Show()

        Dim LoadAtrThread As New Threading.Thread(AddressOf LoadAttributes)
        LoadAtrThread.Start(sAMAccountName)
    End Sub

    Private Sub LoadAttributes(ByVal sAMAccountName As String)

        Dim ObjectDirEntry As DirectoryEntry = GetDirEntryFromSAM(sAMAccountName)

        For Each Prop In ObjectDirEntry.Properties.PropertyNames
            If Not ObjectDirEntry.Properties(Prop) Is Nothing Then
                If Not ObjectDirEntry.Properties(Prop).Value Is Nothing Then
                    If ObjectDirEntry.Properties(Prop).Count > 1 Then
                        Dim Builder As New StringBuilder
                        For i As Integer = 0 To ObjectDirEntry.Properties(Prop).Count - 1
                            Builder.AppendLine(ObjectDirEntry.Properties(Prop).Item(i).ToString & ";")
                        Next
                        DataTableSource.Rows.Add(Prop, GetFriendlyLDAPName(Prop), Builder.ToString)
                    Else
                        If ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(Byte()) Then
                            Try
                                Dim DecodedByte As Guid = New Guid(DirectCast(ObjectDirEntry.Properties(Prop).Value, Byte()))
                                DataTableSource.Rows.Add(Prop, GetFriendlyLDAPName(Prop), DecodedByte.ToString)
                            Catch
                                DataTableSource.Rows.Add(Prop, GetFriendlyLDAPName(Prop), "")
                            End Try
                        Else
                            DataTableSource.Rows.Add(Prop, GetFriendlyLDAPName(Prop), ObjectDirEntry.Properties(Prop).Value.ToString)
                        End If
                    End If
                End If
            Else
                DataTableSource.Rows.Add(Prop, GetFriendlyLDAPName(Prop), "")
            End If
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
        Try
            MainDataGrid.DataSource = FilteredDataView
        Catch Ex As Exception
            Debug.WriteLine("[Error] Invalid Search String: " & Ex.Message)
        End Try
    End Sub

    Private Sub SearchBoxTb_TextChanged(sender As Object, e As EventArgs) Handles SearchBoxTb.TextChanged
        If Not String.IsNullOrEmpty(SearchBoxTb.Text) Then
            FilterDataGrid(SearchBoxTb.Text.Trim)
        Else
            MainDataGrid.DataSource = DataTableSource
        End If
    End Sub

    Private Sub DropDownFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles DropDownFilter.SelectionChangeCommitted
        Select Case DropDownFilter.Text
            Case "All"
                MainDataGrid.DataSource = DataTableSource
            Case "Only those that have values"
                Dim ExcludeBlanksFilteredDataView = New DataView(DataTableSource, "Value <> NULL", "Attribute Desc", DataViewRowState.CurrentRows)
        End Select
    End Sub

    Private Sub MainDataGrid_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles MainDataGrid.CellEndEdit

        Dim Entry As DirectoryEntry = GetDirEntryFromSAM(_sAMAccountName)
        Dim Attr As String = MainDataGrid.Rows(e.RowIndex).Cells("AttributeFull").Value
        Dim Value As String

        If Not IsDBNull(MainDataGrid.Rows(e.RowIndex).Cells("Value").Value) Then
            Value = MainDataGrid.Rows(e.RowIndex).Cells("Value").Value
        Else
            Value = ""
        End If

        If SetADProperty(Entry, Attr, Value) Then
            _Job.Refresh()
        Else
            MainDataGrid.Rows(e.RowIndex).Cells("Value").Value = _defualtCellValue
        End If
    End Sub

    Private Sub MainDataGrid_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles MainDataGrid.CellBeginEdit
        _defualtCellValue = MainDataGrid.Rows(e.RowIndex).Cells("Value").Value
    End Sub

    Private Sub MainDataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MainDataGrid.CellFormatting
        If MainDataGrid.Columns(e.ColumnIndex).Name = "Attribute" Then
            e.CellStyle.BackColor = SystemColors.Control
        End If
    End Sub
End Class