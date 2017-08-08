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
        Me.MainSplitContainer.Panel1.Controls.Add(New DomainTreeContainer(Me))
        Me.MainSplitContainer.Panel1Collapsed = True
    End Sub

    Public Function GetMainDataGrid() As DataGridView
        Return Me.MainDataGrid
    End Function

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Me.MainSplitContainer
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

        If String.IsNullOrEmpty(MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountName").Value.ToString) Then
            MainDataGrid.Rows(e.RowIndex).DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark
        End If

        Try
            If Not String.IsNullOrEmpty(MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountType").Value.ToString) Then

                Select Case MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountType").Value.ToString
                    Case "805306368"
                        If MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "546" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "514" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "66082" Or MainDataGrid.Rows(e.RowIndex).Cells("UserAccountControl").Value = "66050" Then
                            With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                                .Image = GlobalVariables.IconDisabledUSer
                            End With
                        Else
                            With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                                .Image = GlobalVariables.IconUser
                            End With
                        End If
                    Case "805306369"
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconComputer
                        End With
                    Case "268435456"
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconGroup
                        End With
                    Case "268435457"
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconGroup
                        End With
                    Case "536870912"
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconGroup
                        End With
                    Case Else
                        With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                            .Image = GlobalVariables.IconContainer
                        End With
                End Select
            Else
                With DirectCast(MainDataGrid.Rows.Item(e.RowIndex).Cells("name"), TextAndImageCell)
                    .Image = GlobalVariables.IconContainer
                End With
            End If

        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Sub MainDataGrid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MainDataGrid.CellMouseDoubleClick
        Try
            If Not IsDBNull(MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountName").Value) Then
                Dim Sam = MainDataGrid.Rows(e.RowIndex).Cells("sAMAccountName").Value
                Dim Name = MainDataGrid.Rows(e.RowIndex).Cells("Name").Value
                Dim ShowUserProps = New FormUserAttributes(Sam, Name, e.RowIndex)
            End If
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try
    End Sub

    Private Sub MainSplitContainer_Panel1_Validated(sender As Object, e As EventArgs) Handles MainSplitContainer.Panel1.Validated

    End Sub
End Class
