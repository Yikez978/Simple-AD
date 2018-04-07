Imports System.Windows.Forms
Imports SimpleLib

Public Class UIHandler

    Private _ControlList As ControlDomainListView = Nothing
    Private _Explorer As ContainerExplorer = Nothing

    Public Sub New(ByVal ParamArray Controls As Object())

        For i As Integer = 0 To Controls.Length - 1

            If Controls(i).GetType Is GetType(ControlDomainListView) Then

                _ControlList = DirectCast(Controls(i), ControlDomainListView)
                Logger.Log("[Info] New Handler joined to " & _ControlList.Name)
            End If

            If Controls(i).GetType Is GetType(ContainerExplorer) Then
                _Explorer = DirectCast(Controls(i), ContainerExplorer)
            End If

        Next

    End Sub

    Public Sub NewUserButton_Click(sender As Object, e As EventArgs)
        If Not String.IsNullOrEmpty(_Explorer.DomainTreeView.SelectedItem) Then
            Dim NewUserJob As TaskNewUser = New TaskNewUser(_Explorer.DomainTreeView.SelectedItem, _Explorer.Job)
        End If
    End Sub

    Public Sub DeleteBulk_Click(sender As Object, e As EventArgs)
        Dim DeleteBulkJob As TaskBulkDelete = New TaskBulkDelete(_ControlList.SelectedObjects, _Explorer.Job)
    End Sub

    Public Sub EnableBulk_Click(sender As Object, e As EventArgs)
        Dim EnableDisableBulkJob As JobEnableDisableBulk = New JobEnableDisableBulk(_ControlList.SelectedObjects, _Explorer.Job, True)
    End Sub

    Public Sub DisableBulk_Click(sender As Object, e As EventArgs)
        Dim EnableDisableBulkJob As JobEnableDisableBulk = New JobEnableDisableBulk(_ControlList.SelectedObjects, _Explorer.Job, False)
    End Sub

    Public Sub MoveSingle_Click(sender As Object, e As EventArgs)
        If _ControlList.SelectedItems.Count > 0 Then
            Dim MoveJob As TaskMove = New TaskMove(DirectCast(_ControlList.SelectedObject, DomainObject), _Explorer.Job)
        End If
    End Sub

    Public Sub ResetSingle_Click(sender As Object, e As EventArgs)
        If _ControlList.SelectedItems.Count = 1 Then

            Dim TargetUser As UserDomainObject = TryCast(_ControlList.SelectedObject, UserDomainObject)

            If TargetUser IsNot Nothing Then
                Dim ResetPassordJob As TaskPasswordReset = New TaskPasswordReset(TargetUser, _Explorer.Job)
            End If

        End If
    End Sub

    Public Sub Enable_Click(sender As Object, e As EventArgs)
        If _ControlList.SelectedItems.Count = 1 Then
            Dim EnableDisableJob As TaskEnableDisable = New TaskEnableDisable(DirectCast(_ControlList.SelectedObject, UserDomainObject), _Explorer.Job, True)
        End If
    End Sub

    Public Sub Disable_Click(sender As Object, e As EventArgs)
        If _ControlList.SelectedItems.Count = 1 Then
            Dim EnableDisableJob As TaskEnableDisable = New TaskEnableDisable(DirectCast(_ControlList.SelectedObject, UserDomainObject), _Explorer.Job, False)
        End If
    End Sub

    Public Sub DeleteSingle_Click(sender As Object, e As EventArgs)
        If _ControlList.SelectedItems.Count > 0 Then
            Dim DeleteJob As TaskDelete = New TaskDelete(DirectCast(_ControlList.SelectedItem.RowObject, DomainObject), _Explorer.Job)
        End If
    End Sub

    Public Sub BulkModify_Click(sender As Object, e As EventArgs)
        Dim NewBulkModifyForm As FormObjectAttributesBulk = New FormObjectAttributesBulk(_ControlList.SelectedObjects, _Explorer.Job)
    End Sub

    Public Sub MoveBulk_Click(sender As Object, e As EventArgs)
        Dim MoveBulkJob As TaskBulkMove = New TaskBulkMove(_ControlList.SelectedObjects, _Explorer.Job)
    End Sub

    Public Sub ResetBulk_Click(sender As Object, e As EventArgs)
        Dim BulkResetForm As FormPasswordResetBulk = New FormPasswordResetBulk(_ControlList.SelectedObjects)
        BulkResetForm.ShowDialog()
    End Sub

    Public Sub Ping_Click(sender As Object, e As EventArgs)
        Dim ComputerObject = TryCast(_ControlList.SelectedObject, ComputerDomainObject)

        If ComputerObject IsNot Nothing Then
            If Not String.IsNullOrEmpty(ComputerObject.Name) Then
                Dim PingTask As TaskPing = New TaskPing(ComputerObject)
            End If
        End If
    End Sub

    Public Sub ImportCSV_Click(sender As Object, e As EventArgs)
        Try
            Dim ImportForm As FormImport = New FormImport()
            ImportForm.ShowDialog()
        Catch Ex As Exception
            Logger.Log("[Error] Unable to create new Import Form: " & Ex.Message)
        End Try
    End Sub

    Public Sub TemplateManager_Click(sender As Object, e As EventArgs)
        FormTemplateManager.Show()
    End Sub

    Public Sub NewReport_Click(sender As Object, e As EventArgs)
        Dim ReportTask As TaskReport = New TaskReport
    End Sub

    Public Sub OpenActiveDirectory_Click(sender As Object, e As EventArgs)
        Try
            Dim procInfo As New ProcessStartInfo() With {
            .UseShellExecute = True,
            .FileName = (Environment.SystemDirectory & "\dsa.msc"),
            .WorkingDirectory = "",
            .Verb = "runas"}

            Process.Start(procInfo)
        Catch ex As Exception
            Logger.Log("[Error] Unable to open active diretory users and computers" & ex.Message)
        End Try
    End Sub

    Public Sub NewOrganizationalUnit_Click(sender As Object, e As EventArgs)
        Dim NewOuTask As TaskNewOu = New TaskNewOu(GetMainDomainTreeView.SelectedNode.Name, _Explorer.Job)
    End Sub

    Public Sub SearchMenuItem_Click(sender As Object, e As EventArgs)
        Dim SearchForm As FormSearch = New FormSearch
        SearchForm.Show()
    End Sub

    Public Sub PropertiesSingle_Click(sender As Object, e As EventArgs)
        Try
            If _ControlList.SelectedItems.Count = 1 Then
                Dim DomainObject As DomainObject = DirectCast(_ControlList.SelectedItem.RowObject, DomainObject)
                Dim oClass As String = DomainObject.Type

                Dim ShowUserProps As FormObjectAttributes = New FormObjectAttributes(DomainObject, _Explorer.Job)

            End If
        Catch Ex As Exception
            Logger.Log("[Error] Unable to load object properties Form: " & Ex.Message)
        End Try
    End Sub

    Public Sub CopyNameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim DomainObject As DomainObject = TryCast(_ControlList.SelectedItem.RowObject, DomainObject)

        If DomainObject IsNot Nothing Then
            Dim StringToCopy As String = DomainObject.Name
            My.Computer.Clipboard.SetText(StringToCopy)
        End If
    End Sub

    Public Sub CopySamToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim DomainObject As DomainObject = TryCast(_ControlList.SelectedItem.RowObject, DomainObject)

        If DomainObject IsNot Nothing Then
            Dim StringToCopy As String = DomainObject.SAMAccountName
            My.Computer.Clipboard.SetText(StringToCopy)
        End If
    End Sub

    Public Sub CopyDNToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim DomainObject As DomainObject = TryCast(_ControlList.SelectedItem.RowObject, DomainObject)

        If DomainObject IsNot Nothing Then
            Dim StringToCopy As String = DomainObject.DistinguishedName
            My.Computer.Clipboard.SetText(StringToCopy)
        End If
    End Sub

    Public Sub CellEditFinishing(sender As Object, e As CellEditEventArgs)

        Dim DomainObject As DomainObject = DirectCast(_ControlList.SelectedItem.RowObject, DomainObject)

        If Not DomainObject.Name = e.NewValue.ToString Then
            Dim RenameTask As TaskRename = New TaskRename(DomainObject, _ControlList, e.NewValue.ToString, e.Value.ToString)
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub NewReportMenutItem_Click(sender As Object, e As EventArgs)
        Dim NewReportTask As TaskReport = New TaskReport()
    End Sub

End Class
