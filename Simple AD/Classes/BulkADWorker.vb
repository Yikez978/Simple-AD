Imports System.DirectoryServices
Imports System.Security.AccessControl
Imports System.DirectoryServices.AccountManagement
Imports System.Threading

Public Class BulkADWorker

    Public HostJob As JobImport
    Private _ListView As ObjectListView
    Private _Path As String

    Private DomainContext As PrincipalContext
    Private DirEntry As DirectoryEntry

    Private CreateUsersTask As New List(Of Task)()
    Private ct As CancellationToken

    Public Event JobCompleted()

    Public Sub New(ByVal ListView As ObjectListView, ByVal JobClass As JobImport, ByVal Path As String)
        _ListView = ListView
        HostJob = JobClass
        HostJob.JobStatus = SimpleADJobStatus.InProgress

        _Path = Path

        SetupBulkCreationJob()
    End Sub

    Private Async Sub SetupBulkCreationJob()
        Debug.WriteLine("[Info] BulkADWorkers Class Main Worker Initiated")

        Dim strPath As String

        If String.IsNullOrEmpty(LoginUsernamePrefix) Then
            strPath = "LDAP://" & _Path
        Else
            strPath = "LDAP://" & LoginUsernamePrefix & "/" & _Path
        End If

        Debug.WriteLine("[LDAP] Bind to: " & strPath)

        Try
            DomainContext = GetPrincipalContext()
            Debug.WriteLine("[Info] Set up PrincipalContext on " & DomainContext.ConnectedServer.ToString)
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to create Domain Context object from PrincipalContext: " & Ex.Message)
            Dim DomainContextError As New FormAlert(DomainContextErrorMessage & Environment.NewLine & Ex.Message, AlertType.ErrorAlert)
            HostJob.JobStatus = SimpleADJobStatus.Failed
            DomainContextError.ShowDialog()
            Exit Sub
        End Try

        DirEntry = New DirectoryEntry(strPath, LoginUsername, LoginPassword, AuthenticationTypes.Secure)

        DirEntry.RefreshCache()

        HostJob.JobStatus = SimpleADJobStatus.InProgress

        For i As Integer = 0 To HostJob.Users.Count - 1
            Dim Iterator As Integer = i
            CreateUsersTask.Add(Task.Run(Sub() CreateADObject(HostJob.Users(Iterator))))
        Next

        Await Task.WhenAll(CreateUsersTask)

        BulkADWorker_Completed()

    End Sub

    Private Async Sub CreateADObject(ByVal UserObject As SimpleADBulkUserDomainObject)

        Debug.WriteLine(Environment.NewLine & "[Info] Started user setup with user: " & UserObject.Name)

        UserObject.Errors = New List(Of String)

        Try

            Dim objUser As DirectoryEntry = DirEntry.Children.Add("CN=" & UserObject.Name, "user")

            If Not objUser Is Nothing Then

                Dim obj As Object = objUser.NativeObject

                objUser.Properties.Item("sAMAccountName").Add(UserObject.SAMAccountName)
                objUser.Properties("userPrincipalName").Add(UserObject.SAMAccountName)

                If Not String.IsNullOrEmpty(UserObject.DisplayName) Then
                    objUser.Properties("displayName").Add(UserObject.DisplayName)
                End If
                If Not String.IsNullOrEmpty(UserObject.GivenName) Then
                    objUser.Properties("givenName").Add(UserObject.GivenName)
                End If
                If Not String.IsNullOrEmpty(UserObject.Sn) Then
                    objUser.Properties("sn").Add(UserObject.Sn)
                End If
                If Not String.IsNullOrEmpty(UserObject.ScriptPath) Then
                    objUser.Properties("scriptPath").Add(UserObject.ScriptPath)
                End If
                If Not String.IsNullOrEmpty(UserObject.Description) Then
                    objUser.Properties("description").Add(UserObject.Description)
                End If
                If Not String.IsNullOrEmpty(UserObject.HomeDirectory) Then
                    objUser.Properties("homeDirectory").Add(UserObject.HomeDirectory)
                End If
                If Not String.IsNullOrEmpty(UserObject.HomeDrive) Then
                    objUser.Properties("homeDrive").Add(UserObject.HomeDrive)
                End If
                If Not String.IsNullOrEmpty(UserObject.Pager) Then
                    objUser.Properties("pager").Add(UserObject.Pager)
                End If
                If Not String.IsNullOrEmpty(UserObject.Mail) Then
                    objUser.Properties("mail").Add(UserObject.Mail)
                End If
                If Not String.IsNullOrEmpty(UserObject.ProfilePath) Then
                    objUser.Properties("profilePath").Add(UserObject.ProfilePath)
                End If
                If Not String.IsNullOrEmpty(UserObject.Office) Then
                    objUser.Properties("physicalDeliveryOfficeName").Add(UserObject.Office)
                End If
                If Not String.IsNullOrEmpty(UserObject.Department) Then
                    objUser.Properties("department").Add(UserObject.Department)
                End If
                If Not String.IsNullOrEmpty(UserObject.Company) Then
                    objUser.Properties("company").Add(UserObject.Company)
                End If
                If Not String.IsNullOrEmpty(UserObject.Manager) Then
                    objUser.Properties("manager").Add(UserObject.Manager)
                End If
                If Not String.IsNullOrEmpty(UserObject.Title) Then
                    objUser.Properties("title").Add(UserObject.Title)
                End If
                If Not String.IsNullOrEmpty(UserObject.TelephoneNumber) Then
                    objUser.Properties("telephoneNumber").Add(UserObject.TelephoneNumber)
                End If
                If Not String.IsNullOrEmpty(UserObject.WWWHomePage) Then
                    objUser.Properties("wWWHomePage").Add(UserObject.WWWHomePage)
                End If

                objUser.CommitChanges()
                objUser.RefreshCache()

                'Setting TSProfilePath
                Try
                    If Not String.IsNullOrEmpty(UserObject.TsProfilePath) Then
                        Dim oUser As ADsTSUserEx = CType(objUser.NativeObject, ADsTSUserEx)
                        oUser.AllowLogon = 1
                        oUser.TerminalServicesProfilePath = UserObject.TsProfilePath
                    End If
                Catch Ex As Exception
                    Dim TSProfError As String = "[Error] Unable to set the Terminal Services Profile Path for User (" & UserObject.Name & "): " & Ex.Message
                    Debug.WriteLine(TSProfError)
                    UserObject.Errors.Add(TSProfError)
                End Try

                ' Setting Password and enabling account
                Try
                    If Not UserObject.Password Is Nothing Then
                        Try
                            Dim UserPr As UserPrincipal = UserPrincipal.FindByIdentity(DomainContext, IdentityType.SamAccountName, UserObject.SAMAccountName)
                            UserPr.SetPassword(UserObject.Password)
                            If HostJob.EnableAccounts = True Then
                                UserPr.Enabled = True
                            End If
                            If HostJob.ForcePasswordReset = True Then
                                UserPr.ExpirePasswordNow()
                            End If
                            UserPr.Save()
                        Catch Ex As Exception
                            Dim UserPrincipalError As String = "[Error] Unable to create UserPrincipal object with user (" & UserObject.Name & "): " & Ex.Message
                            Debug.WriteLine(UserPrincipalError)
                            UserObject.Errors.Add(UserPrincipalError)
                            If Not Ex.InnerException Is Nothing Then
                                Debug.WriteLine("[Inner Exception] " & Ex.InnerException.Message)
                            End If
                        End Try
                    End If
                Catch Ex As Exception
                    Dim PasswordError As String = "[Error] Unable to set password and enable account on user (" & UserObject.Name & "):" & Ex.Message
                    Debug.WriteLine(PasswordError)
                    UserObject.Errors.Add(PasswordError)
                End Try

                'Setting up folder
                If HostJob.CreateHomeFolders = True Then
                    If Not String.IsNullOrEmpty(UserObject.HomeDirectory) Then
                        Try
                            IO.Directory.CreateDirectory(UserObject.HomeDirectory)
                        Catch Ex As Exception
                            Dim HomeFolderError As String = "[Error] Error While Creating Home folder for user: " & UserObject.Name & ": " & Ex.Message
                            Debug.WriteLine(HomeFolderError)
                            UserObject.Errors.Add(HomeFolderError)
                        End Try

                        If IO.Directory.Exists(UserObject.HomeDirectory) Then
                            Try
                                Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(UserObject.HomeDirectory)
                                Dim FolderAcl As New DirectorySecurity
                                FolderAcl.AddAccessRule(New FileSystemAccessRule(CStr(GetLocalDomainName() & "\" & UserObject.SAMAccountName), FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
                                FolderInfo.SetAccessControl(FolderAcl)
                            Catch Ex As Exception
                                Dim HomeFolderPermsError As String = "[Error] Error While Setting permisions on Home folder for user " & UserObject.Name & ": " & Ex.Message
                                Debug.WriteLine(HomeFolderPermsError)
                                UserObject.Errors.Add(HomeFolderPermsError)
                            End Try
                        End If
                    End If
                End If

                Debug.WriteLine("[Info] Success: Create succeeded.")
                Debug.WriteLine("[Info] Name: ", UserObject.Name)

                If UserObject.Errors.Count > 0 Then
                    UserObject.Status = "Errors"
                End If

                UserObject.Status = "Completed"

                objUser.Close()

            End If

        Catch Exc As Exception

            Dim ErrorMsgCon As String = "Unable to Create User: " & UserObject.SAMAccountName
            Dim InnerException As String = Nothing

            UserObject.Errors.Add(ErrorMsgCon)
            UserObject.Errors.Add(Exc.Message)

            If Not Exc.InnerException Is Nothing Then
                InnerException = Exc.InnerException.Message
                UserObject.Errors.Add(InnerException)
            End If

            UserObject.Status = "Failed"

            Debug.WriteLine("[Error] Unable to Create User: " & UserObject.SAMAccountName)
            Debug.WriteLine("[Error] " & Exc.Message)
            If Not Exc.InnerException Is Nothing Then
                Debug.WriteLine("[Inner Exception] " & Exc.InnerException.Message)
            End If
        End Try

        HostJob.JobProgress = HostJob.JobProgress + 1

        Await Task.CompletedTask
    End Sub

    Public Sub AbortTask()
        For Each task As Task In CreateUsersTask
            task.Dispose()
        Next
    End Sub

    Private Sub BulkADWorker_Completed()
        RaiseEvent JobCompleted()
        HostJob.JobStatus = SimpleADJobStatus.Completed
        OngoingBulkJobs.Remove(Me)

        Debug.WriteLine("[Info] All Tasks Completed")

        If OngoingBulkJobs.Count = 0 Then
            WorkInProgress = False
        End If

        FormMain.ToolStripStatusLabelStatus.Text = "Operation Complete"
    End Sub

End Class
