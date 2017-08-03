Public Class ContainerUserReport
    Inherits UserControl

    Private _ID
    Private _JobName

    Private DataTableSource As DataTable

    Public Property ID
        Set(value)
            _ID = value
        End Set
        Get
            Return _ID
        End Get
    End Property

    Public Property JobName
        Set(value)
            _JobName = value
        End Set
        Get
            Return _JobName
        End Get
    End Property

    Public Property Datasource As DataTable
        Set(value As DataTable)
            DataTableSource = value
            MainDataGrid.DataSource = DataTableSource
            DataTableSource.TableName = "Main"
        End Set
        Get
            Return MainDataGrid.DataSource
        End Get
    End Property

    Public Sub New(ByVal ID As Integer, ByVal JobName As String)

        Me.ID = ID
        Me.JobName = JobName

        Me.Dock = DockStyle.Fill

        InitializeComponent()

    End Sub

    Public Function GetMainDataGrid() As DataGridView
        Return Me.MainDataGrid
    End Function

    Private Sub FilterDataGrid(ByVal Query As String)
        Dim FilteredDataView As DataView

        FilteredDataView = New DataView(DataTableSource, "DisplayName LIKE '*" & Query & "*' OR NAME LIKE '*" & Query & "*'", "DisplayName Desc", DataViewRowState.CurrentRows)

        MainDataGrid.DataSource = FilteredDataView
    End Sub

    Private Sub SearchBoxTb_TextChanged(sender As Object, e As EventArgs) Handles SearchBoxTb.TextChanged
        If Not String.IsNullOrEmpty(SearchBoxTb.Text) Then
            FilterDataGrid(SearchBoxTb.Text.Trim)
        Else
            MainDataGrid.DataSource = DataTableSource
        End If
    End Sub

    Private Sub MainDataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MainDataGrid.CellFormatting
        If MainDataGrid.Columns.Contains("Name") Then
            If e.ColumnIndex = MainDataGrid.Columns("Name").Index Then
                e.CellStyle.BackColor = Color.WhiteSmoke
            End If
        End If

        'Select Case MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountType").Value
        '    Case 805306368
        '        CType(MainDataGrid.Rows(e.RowIndex).Cells("name"), TextAndImageCell).Image = ActiveDirectoryIcon.GetIcon(ActiveDirectoryIcon.ActiveDirectoryIconType.User).ToBitmap
        '    Case 805306369
        '        DirectCast(MainDataGrid.Rows(e.RowIndex).Cells("name"), TextAndImageCell).Image = ActiveDirectoryIcon.GetIcon(ActiveDirectoryIcon.ActiveDirectoryIconType.Computer).ToBitmap
        '    Case Else
        '        DirectCast(MainDataGrid.Rows(e.RowIndex).Cells("name"), TextAndImageCell).Image = Nothing
        'End Select

    End Sub

End Class
