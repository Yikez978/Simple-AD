Imports System.DirectoryServices
Imports System.ComponentModel
Imports System.Security.AccessControl
Imports TSUSEREXLib

Public Class BulkADWorker

    Private _BulkUserContainer As ContainerUserBulk
    Private _SourceGrid As DataGridView
    Private bw As BackgroundWorker = New BackgroundWorker

    Private Name
    Private Password
    Private TsProfilePath
    Private MailDomain
    Private Description
    Private Pager
    Private HomeDirectory
    Private HomeDrive
    Private Username
    Private DisplayName
    Private ScriptPath
    Private FirstName
    Private Surname

    Public Sub New(SourceGrid As DataGridView, bulkUserContainer As ContainerUserBulk)
        _SourceGrid = SourceGrid
        _BulkUserContainer = bulkUserContainer

        _BulkUserContainer.GetProgressBar.Maximum = _SourceGrid.Rows.Count
        _BulkUserContainer.GetProgressBar.Step = 1
    End Sub

    Public Sub RunBulkUserSetup()

        With bw
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With

        AddHandler bw.DoWork, AddressOf Bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf Bw_RunWorkerCompleted

        If Not (bw.IsBusy) Then
            bw.RunWorkerAsync()
        End If
        bw.Dispose()

        _BulkUserContainer.GetSpinner().Visible = True
        _BulkUserContainer.GetSpinner().Spinning = True

    End Sub

    Private Sub Bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        Debug.WriteLine("BulkADWorkers Class Main Worker Initiated")

        Dim autoMainDataGrid As DataGridView = GetMainDataGrid(_SourceGrid)

        Dim objADAM As DirectoryEntry       ' Binding object.
        Dim objUser As DirectoryEntry       ' User object.
        Dim strPath As String               ' Binding path.
        Dim strUser As String               ' User to create.
        Dim strUserPrincipalName As String  ' Principal name of user.



        ' Construct the binding string.       
        If String.IsNullOrEmpty(GlobalVariables.LoginUsernamePrefix) Then
                strPath = "LDAP://" & GlobalVariables.SelectedOU
            Else
                strPath = "LDAP://" & GlobalVariables.LoginUsernamePrefix & "/" & GlobalVariables.SelectedOU
            End If

            Debug.WriteLine("Bind to: {0}" & strPath)

            ' Get AD LDS object.

            objADAM = New DirectoryEntry(strPath)

        With objADAM
            .Username = GlobalVariables.LoginUsername
            .Password = GlobalVariables.LoginPassword
            .AuthenticationType = AuthenticationTypes.Secure
        End With

        Try
            objADAM.RefreshCache()

            'Main User Creation Loop
            For i As Integer = 0 To autoMainDataGrid.RowCount - 2

                If sender.CancellationPending = True Then
                    e.Cancel = True
                    Exit For
                End If

                Dim row As DataGridViewRow = autoMainDataGrid.Rows(i)

                If row.Cells("Name").Value IsNot Nothing Then
                    Name = row.Cells("Name").Value.ToString
                End If

                If row.Cells("FirstName").Value IsNot Nothing Then
                    FirstName = row.Cells("FirstName").Value.ToString
                End If

                If row.Cells("Surname").Value IsNot Nothing Then
                    Surname = row.Cells("Surname").Value.ToString
                End If

                If row.Cells("DisplayName").Value IsNot Nothing Then
                    DisplayName = row.Cells("DisplayName").Value.ToString
                End If

                If row.Cells("Username").Value IsNot Nothing Then
                    Username = row.Cells("Username").Value.ToString
                End If

                If row.Cells("ScriptPath").Value IsNot Nothing Then
                    ScriptPath = row.Cells("ScriptPath").Value.ToString
                End If

                If row.Cells("HomeDrive").Value IsNot Nothing Then
                    HomeDrive = row.Cells("HomeDrive").Value.ToString
                End If

                If row.Cells("HomeDirectory").Value IsNot Nothing Then
                    HomeDirectory = row.Cells("HomeDirectory").Value.ToString
                End If

                If row.Cells("Pager").Value IsNot Nothing Then
                    Pager = row.Cells("Pager").Value.ToString
                End If

                If row.Cells("Description").Value IsNot Nothing Then
                    Description = row.Cells("Description").Value.ToString
                End If

                If row.Cells("MailDomain").Value IsNot Nothing Then
                    MailDomain = row.Cells("MailDomain").Value.ToString
                End If

                If row.Cells("TsProfilePath").Value IsNot Nothing Then
                    TsProfilePath = row.Cells("TsProfilePath").Value.ToString
                End If

                If row.Cells("Password").Value IsNot Nothing Then
                    Password = row.Cells("Password").Value.ToString
                End If


                ' Specify User.
                strUser = "CN=" & Name
                strUserPrincipalName = Username & "@" & MailDomain
                Debug.WriteLine("Create:  {0}" & strUser)

                ' Create User.
                Try
                    objUser = objADAM.Children.Add(strUser, "user")

                    If Not objUser Is Nothing Then

                        objUser.Properties.Item("SamAccountName").Add(Username)
                        objUser.Properties("userPrincipalName").Add(strUserPrincipalName)
                        objUser.Properties("displayName").Add(DisplayName)
                        objUser.Properties.Item("givenName").Add(FirstName)
                        objUser.Properties.Item("sn").Add(Surname)

                        objUser.CommitChanges()

                        If GlobalVariables.ForcePwdReset = True Then
                            objUser.Properties("pwdLastSet").Value = 0
                        End If
                        objUser.CommitChanges()

                        objUser.Properties("scriptPath").Value = ScriptPath
                        objUser.Properties.Item("description").Value = Description
                        objUser.CommitChanges()

                        'Setting TSProfilePath
                        Dim oUser As ADsTSUserEx = CType(objUser.NativeObject, ADsTSUserEx)
                        oUser.AllowLogon = 1
                        oUser.TerminalServicesProfilePath = TsProfilePath

                        'Set Password
                        objUser.Invoke("SetPassword", New Object() {Password})
                        objUser.CommitChanges()

                        'Enable account
                        If GlobalVariables.EnableNewAccounts = True Then
                            Dim val As Integer = objUser.Properties("userAccountControl").Value
                            objUser.Properties("userAccountControl").Value = val And Not &H2
                        End If
                        objUser.CommitChanges()

                        'Setting up folder

                        If (GlobalVariables.CreateHomeFolders) Then
                            If Not String.IsNullOrEmpty(HomeDirectory) Then

                                Try
                                    objUser.Properties("homeDirectory").Value = HomeDirectory
                                    objUser.Properties("homeDrive").Value = HomeDrive
                                    objUser.CommitChanges()

                                    IO.Directory.CreateDirectory(HomeDirectory)
                                Catch Ex As Exception
                                    Debug.WriteLine("Error While Creating Home folder for user " & Username)
                                    Debug.WriteLine(Ex)
                                End Try

                                If IO.Directory.Exists(HomeDirectory) Then
                                    Try
                                        Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(HomeDirectory)
                                        Dim FolderAcl As New DirectorySecurity

                                        FolderAcl.AddAccessRule(New FileSystemAccessRule(CStr(GetLocalDomainName() & "\" & Username), FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
                                        FolderInfo.SetAccessControl(FolderAcl)
                                    Catch Ex As Exception
                                        Debug.WriteLine("Error While Setting permisions on Home folder for user " & Username)
                                        Debug.WriteLine(Ex)
                                    End Try
                                End If

                            Else
                                Debug.WriteLine("Folder Already Exists in location: " & HomeDirectory)
                                Debug.WriteLine("Home Folder Creation for user " & Username & " Has been skipped!")
                            End If
                        End If

                        Debug.WriteLine("Success: Create succeeded.")
                        Debug.WriteLine("Name:    {0}", objUser.Name)

                        Dim argArray As Array = {row.Index}
                        sender.ReportProgress(0, argArray)

                    End If
                Catch exc As Exception

                    Dim ErrorMsgCon = "Unable to Create User: " & Username & " - " & exc.Message

                    Dim argArray As Array = {row.Index, ErrorMsgCon, exc.Message}

                    Debug.WriteLine("Unable to Create User: " & Username)
                    Debug.WriteLine("         {0}", exc.Message)

                    sender.ReportProgress(1, argArray)

                End Try
            Next

            objUser.Close()
            objADAM.Close()

        Catch bindError As Exception
            Debug.WriteLine("Error:   Bind failed.")
            Debug.WriteLine("         {0}" & bindError.Message)
        End Try

    End Sub

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)

        'User creation Succeded
        If e.ProgressPercentage = 0 Then

            With DirectCast(_SourceGrid.Rows.Item(e.UserState(0)).Cells("Status"), TextAndImageCell)
                .Image = New Bitmap(ConvertToGrayScale(My.Resources.appbar_check), 16, 16)
                .Value = "User Created Succesfully"
                .ReadOnly = True
            End With

            With DirectCast(_SourceGrid.Rows.Item(e.UserState(0)).Cells("Name"), TextAndImageCell)
                .Image = (ActiveDirectoryIcon.GetIcon(ActiveDirectoryIcon.ActiveDirectoryIconType.User)).ToBitmap
            End With

            _SourceGrid.Rows.Item(e.UserState(0)).DefaultCellStyle.ForeColor = SystemColors.ControlText

        End If

        'User Creation failed
        If e.ProgressPercentage = 1 Then

            If e.UserState(0) < _SourceGrid.Rows.Count Then
                With DirectCast(_SourceGrid.Rows.Item(e.UserState(0)).Cells("Status"), TextAndImageCell)
                    .Image = New Bitmap(My.Resources.ErrorAlt, 16, 16)
                    .Value = CStr(e.UserState(2))
                    .ToolTipText = CStr(e.UserState(2))
                    .ReadOnly = True
                End With

            End If
        End If
        _BulkUserContainer.GetProgressBar.PerformStep()
    End Sub

    Private Sub Bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        _BulkUserContainer.ProgressBar.Visible = False
        _BulkUserContainer.AcceptBt.Enabled = False
        _BulkUserContainer.AcceptBt.Text = "Done"

        _BulkUserContainer.GetSpinner().Visible = False
        _BulkUserContainer.GetSpinner().Spinning = False

        MainApplicationForm.StatusStrip.BackColor = SystemColors.Highlight

        If e.Cancelled = True Then
            MainApplicationForm.ToolStripStatusLabelStatus.Text = "Operation Canceled"
        ElseIf e.Error IsNot Nothing Then
            MainApplicationForm.ToolStripStatusLabelStatus.Text = "Error: " & e.Error.Message
        Else
            MainApplicationForm.ToolStripStatusLabelStatus.Text = "Operation Complete!"
        End If

    End Sub

    Public Sub CancelWork()
        If bw.WorkerSupportsCancellation = True Then
            bw.CancelAsync()
        End If
    End Sub

End Class
