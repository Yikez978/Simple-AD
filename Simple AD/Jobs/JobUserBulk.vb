Public Class JobUserBulk

    Dim ErForm As New FormImportValidation
    Dim DataGrid As DataGridView

    Private File As String
    Private DisplayNamebool As Boolean
    Private NewImportJobContainer As ContainerUserBulk
    Private TabPage As TabPage
    Private Spinner As ControlTabSpinner

    Private ImportThread As New Threading.Thread(AddressOf ImportCSV)

    Public Sub New(ByVal ImportFile As String)

        NewImportJobContainer = New ContainerUserBulk(1, "User Import - " & GetFileNameShort(ImportFile))

        TabPage = New TabPage
        With TabPage
            .Name = NewImportJobContainer.JobName
            .Text = NewImportJobContainer.JobName
            .Visible = True
            .BackColor = Color.FromArgb(124, 65, 153)
            .ForeColor = SystemColors.ControlText
            .Controls.Add(NewImportJobContainer)
        End With

        FormMain.GetMainTabCtrl().TabPages.Add(TabPage)

        FormMain.GetMainTabCtrl.SelectTab(FormMain.GetMainTabCtrl.TabCount - 1)

        DataGrid = FormMain.GetMainDataGrid

        Spinner = New ControlTabSpinner("Importing Data...", NewImportJobContainer)
        Spinner.SpinnerVisible = True

        NewImportJobContainer.Controls.Add(Spinner)
        Spinner.BringToFront()

        Dim paras As New ImportParameters
        paras.ImportFile = ImportFile
        paras.DataGrid = DataGrid

        ImportThread.IsBackground = True
        ImportThread.Start(paras)
    End Sub

    Public Class ImportParameters
        Property ImportFile As String
        Property DataGrid As DataGridView
    End Class

    Private Sub ApplyDataSource(ByVal datagrid As DataGridView, ByVal datasource As DataTable)
        If datagrid.InvokeRequired Then
            datagrid.Invoke(New Action(Of DataGridView, DataTable)(AddressOf ApplyDataSource), datagrid, datasource)
        Else
            If Not FormMain.IsDisposed Then

                If ErForm.Errors.Count > 0 Then
                    Spinner.SpinnerVisible = False
                    ErForm.ShowDialog()
                End If

                datagrid.DataSource = datasource

                If DisplayNamebool Then
                    For i As Integer = 0 To datagrid.Rows.Count - 1
                        With DirectCast(datagrid.Rows.Item(i).Cells("nameCol"), TextAndImageCell)
                            .Value = datasource.Rows(i).Item("displayName")
                        End With
                    Next
                Else
                    For i As Integer = 0 To datagrid.Rows.Count - 1
                        With DirectCast(datagrid.Rows.Item(i).Cells("nameCol"), TextAndImageCell)
                            .Value = datasource.Rows(i).Item("sAMAccountName")
                        End With
                    Next
                End If

                datagrid.DataSource = datasource

                FormMain.ToolStripStatusLabelStatus.Text = "Select an Organizational Unit"

                For Each column As DataGridViewColumn In datagrid.Columns

                    column.HeaderText = GetFriendlyLDAPName(column.HeaderText)
                    column.Width = 170

                    If Not DefaultColumns.Contains(column.Name) Then
                        column.Visible = False
                    End If
                Next

                datagrid.Columns("nameCol").Width = 170
                datagrid.Columns("description").Width = 200
                datagrid.Columns("status").Width = 300

                Spinner.SpinnerVisible = False

                NewImportJobContainer.GetMainSplitContainer0.Visible = True

            End If
        End If
    End Sub

    Private Sub ImportCSV(ByVal Param As Object)

        Dim p As ImportParameters = CType(Param, ImportParameters)

        Dim dt As New DataTable
        Dim ftdt As New DataTable
        Dim ftdtfl As New List(Of String)
        Dim firstLine As Boolean = True
        Dim firstRow As String() = {}

        'clear all tables on new import
        dt.Clear()
        ftdt.Clear()
        ftdtfl.Clear()

        File = p.ImportFile

        DisplayNamebool = False

        'Read from the CSV file
        Try
            Using sr As New IO.StreamReader(p.ImportFile)
                While Not sr.EndOfStream
                    If firstLine Then
                        firstLine = False
                        Dim cols = sr.ReadLine.Split(",")
                        firstRow = cols

                        If Not firstRow.Contains("sAMAccountName") Then
                            ErForm.Add("Missing Property Exception", "The Imported File contains no 'Username' Column")
                        End If
                        If Not firstRow.Contains("password") Then
                            ErForm.Add("Missing Property Exception", "The Imported File contains no 'Password' Column")
                        End If
                        If Not firstRow.Contains("name") Then
                            ErForm.Add("Missing Property Exception", "The Imported File contains no 'Name' Column")
                        End If
                        If firstRow.Contains("displayName") Then
                            DisplayNamebool = True
                        End If


                        For Each col In cols
                            dt.Columns.Add(New DataColumn(col, GetType(String)))
                        Next
                    Else
                        Dim data() As String = sr.ReadLine.Split(",")
                        dt.Rows.Add(data.ToArray)
                    End If
                End While
                sr.Close()
            End Using
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            ImportFailed(Ex.Message)
        End Try

        For i As Integer = 0 To firstRow.Length - 1

            For j As Integer = 0 To Headers.Length - 1
                If firstRow(i) = Headers(j) Then
                    ftdtfl.Add(Headers(j))
                End If
            Next
        Next

        For i As Integer = 0 To ftdtfl.Count - 1
            ftdt.Columns.Add(ftdtfl(i))
        Next

        For Each row As DataRow In dt.Rows
            ftdt.ImportRow(row)
        Next

        For Each Globalcolumn In Headers
            If Not ftdt.Columns.Contains(Globalcolumn) Then
                ftdt.Columns.Add(New DataColumn(Globalcolumn, GetType(String)))
            End If
        Next

        ApplyDataSource(p.DataGrid, ftdt)

    End Sub

    Private Sub ImportFailed(ByVal ErrorMessage As String)
        If NewImportJobContainer.InvokeRequired Then
            NewImportJobContainer.Invoke(New Action(Of String)(AddressOf ImportFailed), ErrorMessage)
        Else
            Spinner.DisplayText = "Error Loading CSV File"
            Spinner.Tooltiptext = ErrorMessage
        End If

    End Sub

End Class