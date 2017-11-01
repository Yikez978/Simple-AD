Imports System.DirectoryServices
Imports System.Security.AccessControl
Imports TSUSEREXLib
Imports System.DirectoryServices.AccountManagement
Imports SimpleLib

Public Class BulkADWorker

    Private _BulkUserContainer As ContainerImport
    Public _JobClass As JobImport
    Private _ListView As ObjectListView
    Private _Path As String
    Private _NewDomainObjects As List(Of DomainObject)

    Private DomainContext As PrincipalContext
    Private DirEntry As DirectoryEntry

    Public Event JobCompleted()

    Public Property BulkUserContainerObject As ContainerImport
        Set(value As ContainerImport)
            _BulkUserContainer = value
        End Set
        Get
            Return _BulkUserContainer
        End Get
    End Property


    Public Sub New(ByVal NewDomainObjects As List(Of DomainObject), ByVal ListView As ObjectListView, ByVal bulkUserContainer As ContainerImport, ByVal JobClass As JobImport, ByVal Path As String)
        BulkUserContainerObject = bulkUserContainer
        _NewDomainObjects = NewDomainObjects
        _ListView = ListView
        _JobClass = JobClass
        _JobClass.JobStatus = SimpleADJobStatus.InProgress

        _Path = Path

        SetupBulkCreationJob()
    End Sub

    Private Async Sub SetupBulkCreationJob()
        Debug.WriteLine("[Info] BulkADWorkers Class Main Worker Initiated")

        Dim strPath As String               ' Binding path.


        ' Construct the binding string.       
        If String.IsNullOrEmpty(LoginUsernamePrefix) Then
            strPath = "LDAP://" & _Path
        Else
            strPath = "LDAP://" & LoginUsernamePrefix & "/" & _Path
        End If

        Debug.WriteLine("[LDAP] Bind to: " & strPath)

        ' Get AD LDS object.
        Try
            DomainContext = GetPrincipalContext()
            Debug.WriteLine("[Info] Set up PrincipalContext on " & DomainContext.ConnectedServer.ToString)
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to create Domain Context object from PrincipalContext: " & Ex.Message)
            Dim DomainContextError As New FormAlert(DomainContextErrorMessage & Environment.NewLine & Ex.Message, AlertType.ErrorAlert)
            _BulkUserContainer.Invoke(New Action(AddressOf BulkADWorker_Completed))
            _JobClass.JobStatus = SimpleADJobStatus.Failed
            DomainContextError.ShowDialog()
            Exit Sub
        End Try

        DirEntry = New DirectoryEntry(strPath, LoginUsername, LoginPassword, AuthenticationTypes.Secure)

        DirEntry.RefreshCache()

        _JobClass.JobStatus = SimpleADJobStatus.InProgress

        Dim CreateUsersTask As New List(Of Task)()

        For i As Integer = 0 To _NewDomainObjects.Count - 1
            Dim Iterator As Integer = i
            CreateUsersTask.Add(Task.Run(Sub() CreateADObject(_NewDomainObjects(Iterator))))
        Next

        Await Task.WhenAll(CreateUsersTask)

        BulkADWorker_Completed()

    End Sub

    Private Async Sub CreateADObject(ByVal DomainObject As Object)

        Try
            If Not DomainObject.Name Is Nothing Then

                Debug.WriteLine(Environment.NewLine & "[Info] Started user setup with user: " & DomainObject.Name)

                Dim UserObject As SimpleADBulkUserDomainObject = DirectCast(DomainObject, UserDomainObject)
                Dim UserObjectErrorsList As New List(Of String)

                ' Create User.
                Dim objUser As DirectoryEntry = DirEntry.Children.Add("CN=" & UserObject.Name, "user")

                If Not objUser Is Nothing Then

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
                        UserObjectErrorsList.Add(TSProfError)
                    End Try

                    ' Setting Password and enabling account
                    Try
                        If Not UserObject.Password Is Nothing Then
                            Try
                                Dim UserPr As UserPrincipal = UserPrincipal.FindByIdentity(DomainContext, IdentityType.SamAccountName, UserObject.SAMAccountName)
                                UserPr.SetPassword(UserObject.Password)
                                If _JobClass.EnableAccounts = True Then
                                    UserPr.Enabled = True
                                End If
                                If _JobClass.ForcePasswordReset = True Then
                                    UserPr.ExpirePasswordNow()
                                End If
                                UserPr.Save()
                            Catch Ex As Exception
                                Dim UserPrincipalError As String = "[Error] Unable to create UserPrincipal object with user (" & UserObject.Name & "): " & Ex.Message
                                Debug.WriteLine(UserPrincipalError)
                                UserObjectErrorsList.Add(UserPrincipalError)
                                If Not Ex.InnerException Is Nothing Then
                                    Debug.WriteLine("[Inner Exception] " & Ex.InnerException.Message)
                                End If
                            End Try
                        End If
                    Catch Ex As Exception
                        Dim PasswordError As String = "[Error] Unable to set password and enable account on user (" & UserObject.Name & "):" & Ex.Message
                        Debug.WriteLine(PasswordError)
                        UserObjectErrorsList.Add(PasswordError)
                    End Try

                    'Setting up folder
                    If _JobClass.CreateHomeFodlers = True Then
                        If Not String.IsNullOrEmpty(UserObject.HomeDirectory) Then
                            Try
                                IO.Directory.CreateDirectory(UserObject.HomeDirectory)
                            Catch Ex As Exception
                                Dim HomeFolderError As String = "[Error] Error While Creating Home folder for user: " & UserObject.Name & ": " & Ex.Message
                                Debug.WriteLine(HomeFolderError)
                                UserObjectErrorsList.Add(HomeFolderError)
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
                                    UserObjectErrorsList.Add(HomeFolderPermsError)
                                End Try
                            End If
                        End If
                    End If

                    Debug.WriteLine("[Info] Success: Create succeeded.")
                    Debug.WriteLine("[Info] Name: ", UserObject.Name)

                    Dim HasErrors As Integer = 0
                    Dim SimpleADBulkUserDomainObject As SimpleADBulkUserDomainObject = DirectCast(DomainObject, SimpleADBulkUserDomainObject)
                    SimpleADBulkUserDomainObject.Errors = UserObjectErrorsList

                    If SimpleADBulkUserDomainObject.Errors.Count > 0 Then
                        HasErrors = 1
                        DomainObject.Status = "Errors"
                    End If

                    UserObject.Status = "Completed"

                    objUser.Close()

                End If
            End If

        Catch Exc As Exception

            Dim ErrorMsgCon = "Unable to Create User: " & DomainObject.SAMAccountName
            Dim InnerException As String = Nothing

            If Not Exc.InnerException Is Nothing Then
                InnerException = Exc.InnerException.Message
            End If

            DomainObject.Status = "Failed"

            Debug.WriteLine("[Error] Unable to Create User: " & DomainObject.SAMAccountName)
            Debug.WriteLine("[Error] " & Exc.Message)
            If Not Exc.InnerException Is Nothing Then
                Debug.WriteLine("[Inner Exception] " & Exc.InnerException.Message)
            End If
        End Try

        _JobClass.JobProgress = _JobClass.JobProgress + 1

        Await Task.CompletedTask
    End Sub

    Private Sub BulkADWorker_Completed()
        RaiseEvent JobCompleted()
        _JobClass.JobStatus = SimpleADJobStatus.Completed
        OngoingBulkJobs.Remove(Me)

        _ListView.RefreshObjects(_NewDomainObjects)

        Debug.WriteLine("[Info] All Tasks Completed")

        If OngoingBulkJobs.Count = 0 Then
            WorkInProgress = False
        End If

        FormMain.ToolStripStatusLabelStatus.Text = "Operation Complete"
    End Sub

End Class
