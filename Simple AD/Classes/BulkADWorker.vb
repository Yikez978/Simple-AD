Imports System.DirectoryServices
Imports System.ComponentModel
Imports System.Security.AccessControl
Imports System.DirectoryServices.Protocols
Imports TSUSEREXLib
Imports System.Net
Imports System.DirectoryServices.AccountManagement

Public Class BulkADWorker

    Private _BulkUserContainer As ContainerUserBulk
    Private _SourceGrid As DataGridView
    Private bw As BackgroundWorker = New BackgroundWorker
    Private _JobClass As JobUserBulk

    Public Property BulkUserContainerObject As ContainerUserBulk
        Set(value As ContainerUserBulk)
            _BulkUserContainer = value
        End Set
        Get
            Return _BulkUserContainer
        End Get
    End Property


    Public Sub New(SourceGrid As DataGridView, bulkUserContainer As ContainerUserBulk, JobClass As JobUserBulk)
        _SourceGrid = SourceGrid
        BulkUserContainerObject = bulkUserContainer
        _JobClass = JobClass
        _BulkUserContainer.GetProgressBar.Maximum = _SourceGrid.Rows.Count
        _BulkUserContainer.GetProgressBar.Step = 1

        '_UPNS = GetUPNSuffix(0)

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

        Debug.WriteLine("[Info] BulkADWorkers Class Main Worker Initiated")

        Dim autoMainDataGrid = _SourceGrid

        Dim strPath As String               ' Binding path.
        Dim strUser As String               ' User to create.

        ' Construct the binding string.       
        If String.IsNullOrEmpty(GlobalVariables.LoginUsernamePrefix) Then
            strPath = "LDAP://" & GlobalVariables.SelectedOU
        Else
            strPath = "LDAP://" & GlobalVariables.LoginUsernamePrefix & "/" & GlobalVariables.SelectedOU
        End If

        Debug.WriteLine("[LDAP] Bind to: " & strPath)



        ' Get AD LDS object.
        Try

            Dim domainContext As PrincipalContext = GetPrincipalContext(LoginUsername, LoginPassword)

            Using objADAM As New DirectoryEntry(strPath, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword, AuthenticationTypes.Secure)


                objADAM.RefreshCache()

                'Main User Creation Loop
                For i As Integer = 0 To autoMainDataGrid.RowCount - 1

                    If sender.CancellationPending = True Then
                        e.Cancel = True
                        Exit For
                    End If


                    Dim row As DataGridViewRow = autoMainDataGrid.Rows(i)
                    Dim User As UserObject = GetUserFromDataGridViewRow(autoMainDataGrid, row)

                    Try

                        If Not User Is Nothing Then

                            ' Specify User.
                            strUser = "CN=" & User.name
                            Debug.WriteLine("[Info] Create: " & strUser)

                            ' Create User.

                            Dim objUser As DirectoryEntry = objADAM.Children.Add(strUser, "user")

                            If Not objUser Is Nothing Then

                                objUser.Properties.Item("SamAccountName").Add(User.sAMAccountName)
                                objUser.Properties("userPrincipalName").Add(User.sAMAccountName)

                                If Not String.IsNullOrEmpty(User.displayName) Then
                                    objUser.Properties("displayName").Add(User.displayName)
                                End If

                                If Not String.IsNullOrEmpty(User.givenName) Then
                                    objUser.Properties("givenName").Add(User.givenName)
                                End If

                                If Not String.IsNullOrEmpty(User.sn) Then
                                    objUser.Properties("sn").Add(User.sn)
                                End If

                                If Not String.IsNullOrEmpty(User.scriptPath) Then
                                    objUser.Properties("scriptPath").Add(User.scriptPath)
                                End If

                                If Not String.IsNullOrEmpty(User.description) Then
                                    objUser.Properties("description").Add(User.description)
                                End If

                                If Not String.IsNullOrEmpty(User.homeDirectory) Then
                                    objUser.Properties("homeDirectory").Add(User.homeDirectory)
                                End If

                                If Not String.IsNullOrEmpty(User.homeDrive) Then
                                    objUser.Properties("homeDrive").Add(User.homeDrive)
                                End If

                                If _JobClass.ForcePasswordReset = True Then
                                    objUser.Properties("pwdLastSet").Value = 0
                                End If
                                objUser.CommitChanges()

                                'Setting TSProfilePath
                                Dim oUser As ADsTSUserEx = CType(objUser.NativeObject, ADsTSUserEx)
                                oUser.AllowLogon = 1
                                oUser.TerminalServicesProfilePath = User.tsProfilePath

                                'Setting up folder

                                If _JobClass.CreateHomeFodlers = True Then
                                    If Not String.IsNullOrEmpty(User.homeDirectory) Then
                                        Try
                                            IO.Directory.CreateDirectory(User.homeDirectory)
                                        Catch Ex As Exception
                                            Debug.WriteLine("[Error] Error While Creating Home folder for user: " & User.sAMAccountName)
                                            Debug.WriteLine("[Error] " & Ex.Message)
                                        End Try

                                        If IO.Directory.Exists(User.homeDirectory) Then
                                            Try
                                                Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(User.homeDirectory)
                                                Dim FolderAcl As New DirectorySecurity

                                                FolderAcl.AddAccessRule(New FileSystemAccessRule(CStr(GetLocalDomainName() & "\" & User.sAMAccountName), FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
                                                FolderInfo.SetAccessControl(FolderAcl)
                                            Catch Ex As Exception
                                                Debug.WriteLine("[Error] Error While Setting permisions on Home folder for user " & User.sAMAccountName)
                                                Debug.WriteLine("[Error] " & Ex.Message)
                                            End Try
                                        End If

                                    Else
                                        Debug.WriteLine("[Info] Folder Already Exists in location: " & User.homeDirectory)
                                        Debug.WriteLine("[Info] Home Folder Creation for user " & User.sAMAccountName & " Has been skipped!")
                                    End If
                                End If

                                ' Setting Password and enabling account
                                Try
                                    If Not User.password Is Nothing Then
                                        Dim UserPr As UserPrincipal = UserPrincipal.FindByIdentity(domainContext, IdentityType.SamAccountName, User.sAMAccountName)
                                        UserPr.SetPassword(User.password)
                                        If _JobClass.EnableAccounts = True Then
                                            UserPr.Enabled = True
                                        Else
                                            UserPr.Enabled = False
                                        End If
                                        UserPr.Save()
                                        UserPr.Dispose()
                                    End If
                                Catch Ex As Exception
                                    Debug.WriteLine("[Error] Unable to set password on user (" & User.sAMAccountName & "):" & Ex.Message)
                                End Try

                                Debug.WriteLine("[Info] Success: Create succeeded.")
                                Debug.WriteLine("[Info] Name: ", objUser.Name)

                                Dim argArray As Array = {row.Index}
                                sender.ReportProgress(0, argArray)

                                objUser.Close()
                                objUser.Dispose()

                            End If


                        End If

                    Catch exc As Exception

                        Dim ErrorMsgCon = "Unable to Create User: " & User.sAMAccountName & " - " & exc.Message

                        Dim argArray As Array = {row.Index, ErrorMsgCon, exc.Message}

                        Debug.WriteLine("[Error] Unable to Create User: " & User.sAMAccountName)
                        Debug.WriteLine("[Error] " & exc.Message)

                        sender.ReportProgress(1, argArray)

                    End Try

                Next
                domainContext.Dispose()
                objADAM.Close()
                objADAM.Dispose()
            End Using

        Catch bindError As Exception
            Debug.WriteLine("[Error] Bind failed.")
            Debug.WriteLine("[LDAP] " & bindError.Message)
        End Try

    End Sub

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)

        'User creation Succeded
        If e.ProgressPercentage = 0 Then

            With DirectCast(_SourceGrid.Rows.Item(e.UserState(0)).Cells("Status"), TextAndImageCell)
                .Image = New Bitmap(My.Resources.appbar_check, 16, 16)
                .Value = "User Created Succesfully"
                .ReadOnly = True
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

        FormMain.StatusStrip.BackColor = Color.FromArgb(124, 65, 153)

        If e.Cancelled = True Then
            FormMain.ToolStripStatusLabelStatus.Text = "Operation Canceled"
        ElseIf e.Error IsNot Nothing Then
            FormMain.ToolStripStatusLabelStatus.Text = "Error: " & e.Error.Message
        Else
            FormMain.ToolStripStatusLabelStatus.Text = "Operation Complete!"
        End If

    End Sub

    Public Sub CancelWork()
        If bw.WorkerSupportsCancellation = True Then
            bw.CancelAsync()
        End If
    End Sub

    Private Sub SetPassword(connection As DirectoryConnection, userDN As String, password As String)

        Dim pwdMod As DirectoryAttributeModification = New DirectoryAttributeModification()
        With pwdMod
            pwdMod.Name = "unicodePwd"
            pwdMod.Add(GetPasswordData(password))
            pwdMod.Operation = DirectoryAttributeOperation.Replace
        End With

        Dim request As ModifyRequest = New ModifyRequest(userDN, pwdMod)

        Dim response As DirectoryResponse = connection.SendRequest(request)
    End Sub

    Private Function GetPasswordData(password As String) As Byte()
        Dim formattedPassword As String
        formattedPassword = String.Format("\{0}\", password)
        Return (Encoding.Unicode.GetBytes(formattedPassword))
    End Function

    Private Function GetConnection(server As String, credential As NetworkCredential, useSsl As Boolean) As DirectoryConnection

        Dim connection As LdapConnection = New LdapConnection(server)

        If (useSsl) Then
            connection.SessionOptions.SecureSocketLayer = True
        Else
            connection.SessionOptions.Sealing = True
        End If

        connection.Bind(credential)
        Return connection
    End Function

    Public Sub Main()

        Dim credential As NetworkCredential = New NetworkCredential("someuser", "Password1", "domain")
        Dim Connection As DirectoryConnection

        Try
            ''change these options to use Kerberos encryption
            Connection = GetConnection("domain.com:636", credential, True)
            Console.WriteLine("Password modified!")
            Dim disposable As IDisposable = Connection

            If (Not disposable Is Nothing) Then
                disposable.Dispose()
            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub



End Class
