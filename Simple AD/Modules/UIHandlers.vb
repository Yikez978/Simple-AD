Public Module UIHandlers

    Public Sub NewUserButton_Click(sender As Object, e As EventArgs)
        If Not String.IsNullOrEmpty(GetContainerExplorer.DomainTreeView.SelectedOU) Then
            Dim NewUserJob As JobNewUser = New JobNewUser(GetContainerExplorer.DomainTreeView.SelectedOU, GetContainerExplorer.Job)
        End If
    End Sub

    Public Sub DeleteBulk_Click(sender As Object, e As EventArgs)
        Dim DeleteBulkJob As JobDeleteBulk = New JobDeleteBulk(GetContainerExplorer.MainListView.SelectedObjects, GetContainerExplorer.Job)
    End Sub

    Public Sub EnableBulk_Click(sender As Object, e As EventArgs)
        Dim EnableDisableBulkJob As JobEnableDisableBulk = New JobEnableDisableBulk(GetContainerExplorer.MainListView.SelectedObjects, GetContainerExplorer.Job, True)
    End Sub

    Public Sub DisableBulk_Click(sender As Object, e As EventArgs)
        Dim EnableDisableBulkJob As JobEnableDisableBulk = New JobEnableDisableBulk(GetContainerExplorer.MainListView.SelectedObjects, GetContainerExplorer.Job, False)
    End Sub

    Public Sub MoveSingle_Click(sender As Object, e As EventArgs)
        If GetContainerExplorer.MainListView.SelectedItems.Count > 0 Then
            Dim MoveJob As JobMove = New JobMove(DirectCast(GetContainerExplorer.MainListView.SelectedItem.RowObject, DomainObject), GetContainerExplorer.Job)
        End If
    End Sub

    Public Sub ResetSingle_Click(sender As Object, e As EventArgs)
        If GetContainerExplorer.MainListView.SelectedItems.Count = 1 Then

            Dim TargetUser As UserDomainObject = TryCast(GetMainListView.SelectedObject, UserDomainObject)

            If TargetUser.GetType() Is GetType(UserDomainObject) Then
                Dim ResetPassordJob As JobPasswordReset = New JobPasswordReset(TargetUser, GetContainerExplorer.Job)
            End If

        End If
    End Sub

    Public Sub Enable_Click(sender As Object, e As EventArgs)
        If GetContainerExplorer.MainListView.SelectedItems.Count = 1 Then
            Dim EnableDisableJob As JobEnableDisable = New JobEnableDisable(DirectCast(GetContainerExplorer.MainListView.SelectedObject, UserDomainObject), GetContainerExplorer.Job, True)
        End If
    End Sub

    Public Sub Disable_Click(sender As Object, e As EventArgs)
        If GetContainerExplorer.MainListView.SelectedItems.Count = 1 Then
            Dim EnableDisableJob As JobEnableDisable = New JobEnableDisable(DirectCast(GetContainerExplorer.MainListView.SelectedObject, UserDomainObject), GetContainerExplorer.Job, False)
        End If
    End Sub

    Public Sub DeleteSingle_Click(sender As Object, e As EventArgs)
        If GetContainerExplorer.MainListView.SelectedItems.Count > 0 Then
            Dim DeleteJob As JobDelete = New JobDelete(DirectCast(GetContainerExplorer.MainListView.SelectedItem.RowObject, DomainObject), GetContainerExplorer.Job)
        End If
    End Sub

    Public Sub BulkModify_Click(sender As Object, e As EventArgs)
        Dim NewBulkModifyForm As FormObjectAttributesBulk = New FormObjectAttributesBulk(GetContainerExplorer.GetSelectedUsers(), GetContainerExplorer.Job)
    End Sub

    Public Sub MoveBulk_Click(sender As Object, e As EventArgs)
        Dim MoveBulkJob As JobMoveBulk = New JobMoveBulk(GetContainerExplorer.MainListView.SelectedObjects, GetContainerExplorer.Job)
    End Sub

    Public Sub ResetBulk_Click(sender As Object, e As EventArgs)
        Dim BulkResetForm As FormPasswordResetBulk = New FormPasswordResetBulk(GetContainerExplorer.GetSelectedUsers)
        BulkResetForm.ShowDialog()
    End Sub

    Public Sub ImportCSV_Click(sender As Object, e As EventArgs)
        Dim ImportForm As FormImport = New FormImport()
        ImportForm.ShowDialog()
    End Sub

    Public Sub TemplateManager_Click(sender As Object, e As EventArgs)
        FormTemplateManager.Show()
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
            Debug.WriteLine("[Error] " & ex.Message)
        End Try
    End Sub

End Module
