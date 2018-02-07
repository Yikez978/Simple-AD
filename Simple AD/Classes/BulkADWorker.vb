Imports System.DirectoryServices
Imports System.Security.AccessControl
Imports System.Threading
Imports System.Threading.Tasks

Imports TSUSEREXLib

Imports SimpleLib

Public Class BulkADWorker

    Public TaskHost As TaskBulkImport

    Private _ListView As ObjectListView
    Private _Path As String
    Private _StartPath As String

    Private _CreateUsersTask As New List(Of Task)()

    Private _CancelSource As CancellationTokenSource

    Public Event BulkImportCompleted()
    Public Event BulkImportStatusChanged(ByVal Message As String)
    Public Event BulkImportCanceled()

    Public Sub New(ByVal ListView As ObjectListView, ByVal TaskClass As TaskBulkImport, ByVal Path As String)

        _ListView = ListView
        TaskHost = TaskClass
        TaskHost.TaskStatus = ActiveTaskStatus.InProgress

        _Path = Path

        SetupBulkCreationJob()
    End Sub

    Private Async Sub SetupBulkCreationJob()
        Debug.WriteLine("[Info] BulkADWorkers Class Main Worker Initiated")

        If String.IsNullOrEmpty(LoginUsernamePrefix) Then
            _StartPath = "LDAP://" & _Path
        Else
            _StartPath = "LDAP://" & LoginUsernamePrefix & "/" & _Path
        End If

        Debug.WriteLine("[LDAP] Bind to: " & _StartPath)

        TaskHost.TaskStatus = ActiveTaskStatus.InProgress

        _CancelSource = New CancellationTokenSource()

        For i As Integer = 0 To TaskHost.Users.Count - 1
            Dim Iterator As Integer = i

            TaskHost.Users(Iterator).EnableAccount = TaskHost.EnableAccounts
            TaskHost.Users(Iterator).ForcePasswordReset = TaskHost.ForcePasswordReset
            TaskHost.Users(Iterator).CreateHomeFolder = TaskHost.CreateHomeFolders

            'Set the status to canceled on each user preemptively as if the import is canceled userobjects belonging to tasks that are still in
            'the threadpool queue will not have a chane to have their status changed by thier respective thread
            TaskHost.Users(Iterator).Meta.Status = ActiveTaskStatus.Canceled

            _CreateUsersTask.Add(Task.Run(Function() CreateADObject(TaskHost.Users(Iterator), _CancelSource.Token), _CancelSource.Token))

        Next

        Try
            Await Task.WhenAll(_CreateUsersTask)
        Catch CanceledEx As OperationCanceledException

        Catch ex As Exception

        End Try

        BulkADWorker_Completed()

    End Sub

    'Set up lock to ensure the directory server dosn't get flooded with password reset requests
    Private SetPasswordLock As New Object
    Private AddObjectLock As New Object
    Private CloseObject As New Object

    Private Function CreateADObject(ByVal UserObject As SimpleADBulkUserDomainObject, ByVal CancelToken As CancellationToken) As SimpleResult

        Dim Result As SimpleResult = UserObject.Meta

        If CancelToken.IsCancellationRequested = True Then

            Debug.WriteLine("Creating the user {0} was cancelled before it got started.", UserObject.Name)

            Exit Function
        End If

        Debug.WriteLine(Environment.NewLine & "[Info] Started user setup with user: " & UserObject.Name)

        UserObject.Errors = New List(Of String)

        Try

            RaiseEvent BulkImportStatusChanged(String.Format("Setting up user {0} ", UserObject.Name))

            Dim DirEntry As DirectoryEntry = New DirectoryEntry(_StartPath, LoginUsername, LoginPassword, AuthenticationTypes.Secure)

            Dim objUser As DirectoryEntry

            'SyncLock AddObjectLock
            objUser = DirEntry.Children.Add("CN=" & UserObject.Name, "user")
            'End SyncLock

            If Not objUser Is Nothing Then

                Dim obj As Object = objUser.NativeObject

                objUser.Properties.Item("sAMAccountName").Add(UserObject.SAMAccountName)
                objUser.Properties("userPrincipalName").Add(UserObject.UserPrincipalName)

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

                RaiseEvent BulkImportStatusChanged(String.Format("Comitting user {0} to directory", UserObject.Name))

                objUser.CommitChanges()

                'Setting TSProfilePath

                'Ensures that Simple ad only requests one password reset at a time
                'All code is within Try/Catch to avoid thread deadlock
                'TODO this still needs to be thorughly tested
                'SyncLock SetPasswordLock

                'Setting the Terminal services profile path
                If UserObject.TsProfilePath IsNot Nothing Then
                    Try

                        RaiseEvent BulkImportStatusChanged(String.Format("Setting terminal services properties on user {0}", UserObject.Name))

                        Dim NativeObj As Object = objUser.NativeObject
                        Dim oUser As IADsTSUserEx = CType(NativeObj, IADsTSUserEx)
                        oUser.AllowLogon = 1
                        oUser.TerminalServicesProfilePath = UserObject.TsProfilePath

                    Catch Ex As Exception
                        Dim TSProfError As String = "Unable to set the Terminal Services Profile Path for User (" & UserObject.Name & "): " & Ex.Message
                        Debug.WriteLine("[Error] " & TSProfError)
                        UserObject.Errors.Add(TSProfError)
                    End Try
                End If


                ' Setting Password and enabling account
                If Not UserObject.Password Is Nothing Then

                    Try

                        RaiseEvent BulkImportStatusChanged(String.Format("Setting password for user {0}", UserObject.Name))

                        'Setting user password
                        Dim oPassword As Object() = New Object() {UserObject.Password}
                        Dim Ret As Object = objUser.Invoke("SetPassword", oPassword)
                        objUser.Properties("LockOutTime").Value = 0
                        objUser.CommitChanges()

                        If UserObject.EnableAccount Then
                            'Enabling the new account
                            Dim exp As Integer = CInt(objUser.Properties("userAccountControl").Value)
                            objUser.Properties("userAccountControl").Value = exp Or &H1

                            Dim val As Integer = CInt(objUser.Properties("userAccountControl").Value)
                            objUser.Properties("userAccountControl").Value = val And Not &H2
                            objUser.CommitChanges()
                        End If

                        If UserObject.ForcePasswordReset Then
                            'Forcing user to change password on next logon
                            objUser.Properties("pwdLastSet").Value = 0
                            objUser.CommitChanges()
                        End If

                    Catch Ex As Exception
                        Dim PasswordError As String = "Unable to set password and enable account on user (" & UserObject.Name & "):" & Ex.Message
                        Debug.WriteLine("[Error] " & PasswordError)
                        UserObject.Errors.Add(PasswordError)
                    End Try

                End If

                'End SyncLock

                'Setting up folder
                If Not String.IsNullOrEmpty(UserObject.HomeDirectory) Then
                    If UserObject.CreateHomeFolder Then

                        RaiseEvent BulkImportStatusChanged(String.Format("Creating home folder for user {0}", UserObject.Name))

                        Try
                            IO.Directory.CreateDirectory(UserObject.HomeDirectory)
                        Catch Ex As Exception
                            Dim HomeFolderError As String = "Failed to create home folder for user: " & UserObject.Name & ": " & Ex.Message
                            Debug.WriteLine("[Error] " & HomeFolderError)
                            UserObject.Errors.Add(HomeFolderError)
                        End Try

                        If IO.Directory.Exists(UserObject.HomeDirectory) Then
                            Try
                                Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(UserObject.HomeDirectory)
                                Dim FolderAcl As New DirectorySecurity
                                FolderAcl.AddAccessRule(New FileSystemAccessRule(CStr(GetLocalDomainName() & "\" & UserObject.SAMAccountName), FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
                                FolderInfo.SetAccessControl(FolderAcl)
                            Catch Ex As Exception
                                Dim HomeFolderPermsError As String = "Unable to set permisions on home folder for user " & UserObject.Name & ": " & Ex.Message
                                Debug.WriteLine("[Error] " & HomeFolderPermsError)
                                UserObject.Errors.Add(HomeFolderPermsError)
                            End Try
                        End If

                    End If
                End If

                'Clean up
                If UserObject.Errors.Count > 0 Then
                    Result.Status = ActiveTaskStatus.Errors
                Else
                    Result.Status = ActiveTaskStatus.Completed
                End If

                'SyncLock CloseObject
                objUser.Close()
                'End SyncLock
            End If

        Catch CanceledEx As OperationCanceledException

            Dim ErrorMsgCon As String = String.Format("User {0} was canceled ", UserObject.SAMAccountName)
            Dim InnerException As String = Nothing

            UserObject.Errors.Add(ErrorMsgCon)

            Result.Status = ActiveTaskStatus.Canceled

            Debug.WriteLine(ErrorMsgCon)

        Catch Exc As Exception

            Dim ErrorMsgCon As String = "Unable to Create User: " & UserObject.SAMAccountName
            Dim InnerException As String = Nothing

            UserObject.Errors.Add(Exc.Message)

            If Not Exc.InnerException Is Nothing Then
                InnerException = Exc.InnerException.Message
                UserObject.Errors.Add(InnerException)
            End If

            Result.Status = ActiveTaskStatus.Failed

            Debug.WriteLine("[Error] Unable to Create User: " & UserObject.SAMAccountName)
            Debug.WriteLine("[Error] " & Exc.Message)
            If Not Exc.InnerException Is Nothing Then
                Debug.WriteLine("[Inner Exception] " & Exc.InnerException.Message)
            End If

        End Try

        RaiseEvent BulkImportStatusChanged(String.Format("completed user {0} with status {1}", UserObject.Name, Result.Status.ToString))

        TaskHost.JobProgress = TaskHost.JobProgress + 1

        Return Result

    End Function

    Public Sub AbortTask()
        _CancelSource.Cancel()
    End Sub

    Private Sub BulkADWorker_Completed()

        TaskHost.TaskStatus = ActiveTaskStatus.Completed
        Debug.WriteLine("[Info] All Tasks Completed")

        RaiseEvent BulkImportCompleted()
    End Sub

End Class
