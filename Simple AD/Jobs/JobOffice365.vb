Imports System.Management.Automation
Imports System.Management.Automation.Runspaces

Public Class JobOffice365

    Private DataGrid As DataGridView
    Private TabPage As TabPage
    Private NewOffice365Container As ContainerOffice365
    Private Spinner As ControlTabSpinner
    Private Connect365Thread As New Threading.Thread(AddressOf GetOffice365Users)

    Private _Email
    Private _Password

    Private dt As DataTable

    Public Sub New(ByVal Email As String, ByVal Password As String)

        _Email = Email
        _Password = Password

        Dim Domain As String() = Email.Split(New Char() {"@"c})

        Dim NewId = GenerateJobID()
        NewOffice365Container = New ContainerOffice365(NewId, "Office 365 - " & Domain(1).ToString)
        NewOffice365Container.Visible = False

        TabPage = New TabPage
        With TabPage
            .Name = NewOffice365Container.JobName
            .Text = NewOffice365Container.JobName
            .Visible = True
            .BackColor = Color.FromArgb(124, 65, 153)
            .ForeColor = SystemColors.ControlText
            .Controls.Add(NewOffice365Container)
        End With

        FormMain.GetMainTabCtrl().TabPages.Add(TabPage)
        DataGrid = NewOffice365Container.GetMainDataGrid()

        FormMain.GetMainTabCtrl.SelectTab(FormMain.GetMainTabCtrl.TabCount - 1)

        FormMain.GetMainTabCtrl.SelectedTab.BackColor = SystemColors.Window
        FormMain.GetMainTabCtrl.SelectedTab.Controls.Add(NewOffice365Container)
        FormMain.GetMainTabCtrl.Visible = True

        Spinner = New ControlTabSpinner("Connecting to " & Domain(1).ToString, NewOffice365Container)
        Spinner.SpinnerVisible = True

        TabPage.Controls.Add(Spinner)
        Spinner.BringToFront()

        Dim paras As New Jobparameters
        paras.DataGrid = DataGrid

        Connect365Thread.IsBackground = True
        Connect365Thread.Start(paras)
    End Sub

    Public Class Jobparameters
        Property DataGrid As DataGridView
    End Class

    Private Function GenerateJobID() As Integer

        Dim random As Random = New Random()
        Dim randNumber As Byte = random.Next(255)
        Return CInt(randNumber)

    End Function

    Private Sub ApplyDataSource(ByVal datagrid As DataGridView, ByVal datasource As DataTable)
        If datagrid.InvokeRequired Then
            datagrid.Invoke(New Action(Of DataGridView, DataTable)(AddressOf ApplyDataSource), datagrid, datasource)
        Else
            If Not FormMain.IsDisposed Then
                NewOffice365Container.Datasource = datasource

                For Each column As DataGridViewColumn In datagrid.Columns
                    If Not GlobalVariables.DefaultOffice365Columns.Contains(column.Name) Then
                        column.Visible = False
                    End If
                Next

                Spinner.Dispose()
                NewOffice365Container.Visible = True
            End If
        End If
    End Sub

    Private Sub GetOffice365Users(ByVal Param As Object)

        Dim p As Jobparameters = CType(Param, Jobparameters)
        Dim DataGridPara = p.DataGrid
        Dim dt As New DataTable

        For Each Office365Prop In Office365Props
            dt.Columns.Add(New DataColumn(Office365Prop, GetType(String)))
        Next

        Dim secureString As System.Security.SecureString = New System.Security.SecureString()

        For Each c As Char In _Password
            secureString.AppendChar(c)
        Next

        Dim credential As PSCredential = New PSCredential(_Email, secureString)
        Dim connectionInfo As WSManConnectionInfo = New WSManConnectionInfo(New Uri(My.Settings.OfficeURI), My.Settings.OfficeShellURI, credential)

        With connectionInfo
            .AuthenticationMechanism = AuthenticationMechanism.Basic
            .SkipCACheck = True
            .SkipCNCheck = True
            .UseCompression = True
            .MaximumConnectionRedirectionCount = 4
        End With

        Dim runspace As Runspace = RunspaceFactory.CreateRunspace(connectionInfo)

        Try
            runspace.Open()
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message)
        End Try

        'Make a Get-Mailbox requst using the Server Argument
        Dim gmGetMailbox As Command = New Command("Get-Mailbox")
        gmGetMailbox.Parameters.Add("ResultSize", 500)

        Dim plPileLine As Pipeline = runspace.CreatePipeline()
        plPileLine.Commands.Add(gmGetMailbox)
        Try
            Dim RsResultsresults = plPileLine.Invoke()
            Dim gmResults As New Dictionary(Of String, PSObject)

            For Each obj As PSObject In RsResultsresults
                gmResults.Add(obj.Members("WindowsEmailAddress").Value.ToString(), obj)
            Next

            plPileLine.Stop()
            plPileLine.Dispose()

            For Each Item As KeyValuePair(Of String, PSObject) In gmResults
                Dim newrow As DataRow = dt.NewRow

                For Each Office365Prop In Office365Props
                    If Not Item.Value.Members(Office365Prop).Value Is Nothing Then
                        newrow.Item(Office365Prop) = Item.Value.Members(Office365Prop).Value.ToString
                    Else
                        newrow.Item(Office365Prop) = ""
                    End If
                Next
                dt.Rows.Add(newrow)
            Next

            ApplyDataSource(DataGridPara, dt)

        Catch Ex As Exception
            Debug.WriteLine(Ex.Message)
            Debug.WriteLine(Ex.InnerException)
            FailedToLoadData(Ex.Message, Ex.Data.ToString)
        End Try

    End Sub

    Private Sub FailedToLoadData(ErrorMessage As String, InnerException As String)
        If NewOffice365Container.InvokeRequired Then
            NewOffice365Container.Invoke(New Action(Of String, String)(AddressOf FailedToLoadData), ErrorMessage, InnerException)

        Else
            Spinner.SpinnerVisible = False
            Spinner.DisplayText = ErrorMessage
        End If
    End Sub

End Class
