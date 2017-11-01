﻿Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices.ActiveDirectory

Public Module ActiveDirectoryHelper

        Public Property LoginUsername As String
        Public Property LoginPassword As String
        Public Property LoginUsernamePrefix As String
        Public Property SelectedOU As String

        Public Function GetSingleDomainController() As String
            If String.IsNullOrEmpty(LoginUsernamePrefix) Then
                Return Domain.GetCurrentDomain.PdcRoleOwner.Name
            Else
                Return Domain.GetDomain(GetDomainContext).PdcRoleOwner.Name
            End If
        End Function

        Public Function GetDomainContext() As DirectoryContext
            If String.IsNullOrEmpty(LoginUsername) Then
                Return New DirectoryContext(DirectoryContextType.DirectoryServer, GetSingleDomainController)
            ElseIf String.IsNullOrEmpty(LoginUsernamePrefix) Then
                Return New DirectoryContext(DirectoryContextType.DirectoryServer, GetSingleDomainController, LoginUsername, LoginPassword)
            Else
                Return New DirectoryContext(DirectoryContextType.DirectoryServer, LoginUsernamePrefix, LoginUsername, LoginPassword)
            End If
        End Function

        Public Function GetPrincipalContext() As PrincipalContext
            If String.IsNullOrEmpty(LoginUsername) Then
                Return New PrincipalContext(ContextType.Domain, GetLocalDomainName)
            ElseIf String.IsNullOrEmpty(LoginUsernamePrefix) Then
                Return New PrincipalContext(ContextType.Domain, GetLocalDomainName, LoginUsername, LoginPassword)
            Else
                Return New PrincipalContext(ContextType.Domain, LoginUsernamePrefix, LoginUsername, LoginPassword)
            End If
        End Function

        Public Function GetLocalDomainName() As String
            Dim DomainName As String = Nothing
            Try
                If Not String.IsNullOrEmpty(LoginUsernamePrefix) Then
                    Dim DomainContext As DirectoryContext = New DirectoryContext(DirectoryContextType.DirectoryServer, LoginUsernamePrefix, LoginUsername, LoginPassword)
                    DomainName = Domain.GetDomain(DomainContext).Name
                Else
                    Try
                        DomainName = Domain.GetCurrentDomain.Name
                    Catch ex As Exception
                        DomainName = ""
                    End Try
                    Return DomainName
                End If
            Catch AuthEx As Security.Authentication.AuthenticationException
                Debug.WriteLine("[Authentication Error] " & AuthEx.InnerException.ToString)
                Return DomainName
            Catch NoneExistantDirEx As ActiveDirectoryObjectNotFoundException
                Debug.WriteLine("[NoneExistantDir Error] " & NoneExistantDirEx.InnerException.ToString)
                Return DomainName
            End Try
            Return DomainName
        End Function

        Public Function GetDomainNetBiosName() As String
            Dim DomainArray As String() = Strings.Split(GetLocalDomainName(), ".")
            Return DomainArray(0)
        End Function

        Public Function GetFQDN() As String
            Dim fqdnArray = Strings.Split(GetLocalDomainName(), ".")
            Dim fqdn As String = String.Join(",DC=", fqdnArray)

            Return "DC=" & fqdn
        End Function

        Public Function GetDirEntryPath() As String
            Dim entry As String

            If String.IsNullOrEmpty(LoginUsernamePrefix) Then
                entry = "LDAP://" & GetSingleDomainController()
            Else
                entry = "LDAP://" & LoginUsernamePrefix
            End If

            Return entry
        End Function

        Public Function GetDirEntry(Optional Path As String = Nothing) As DirectoryEntry
            If Path Is Nothing Then
                Return New DirectoryEntry(GetDirEntryPath, LoginUsername, LoginPassword)
            Else
                Return New DirectoryEntry(GetDirEntryPath() & "/" & Path, LoginUsername, LoginPassword)
            End If
        End Function

        Public Function GetDisplayName() As String
            Dim DisplayName As String = "User"
            Try

                Dim Entry As DirectoryEntry = GetDirEntry()
                Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

                With DirSearcher
                    .SearchRoot = Entry
                    If Not LoginUsername Is Nothing Then
                        .Filter = "(&(objectClass=user)(sAMAccountName=" & LoginUsername & "))"
                    Else
                        .Filter = "(&(objectClass=user)(sAMAccountName=" & Environment.UserName & "))"
                    End If

                End With

                Dim Result As SearchResult = DirSearcher.FindOne

                DisplayName = Result.GetDirectoryEntry().Properties("displayName").Value

            Catch ex As Exception
                Return DisplayName
            End Try
            Return DisplayName
        End Function

        Public Function ValidateActiveDirectoryLogin(ByVal Domain As String, ByVal Username As String, ByVal Password As String, Optional Address As String = Nothing) As Boolean
            Dim Success As Boolean = False

            Try

                Dim Entry As DirectoryEntry

                If String.IsNullOrEmpty(Address) Then
                    Entry = New DirectoryEntry("LDAP://" & Domain, Username, Password)
                Else
                    Entry = New DirectoryEntry("LDAP://" & Address, Username, Password)
                End If

                Dim Searcher As New DirectorySearcher(Entry) With {
                .SearchScope = SearchScope.OneLevel
                }

                Dim Results As SearchResult = Searcher.FindOne
                Success = Not (Results Is Nothing)

            Catch ex As Exception
                Success = False
                Debug.WriteLine("[Error] Unable to validate login request: " & ex.Message)
            End Try
            Return Success
        End Function

        Public Function SetADProperty(ByVal de As DirectoryEntry, ByVal pName As String, ByVal pValue As String) As Boolean
            Try
                If Not pValue Is Nothing Then

                    Debug.WriteLine("[Info] SetADProperty Started: " & de.Name.ToString)

                    With de
                        .Username = LoginUsername
                        .Password = LoginPassword
                        .AuthenticationType = AuthenticationTypes.Secure
                    End With

                    If de.Properties.Contains(pName) Then
                        Debug.WriteLine("[Info] SetADProperty Item Modify - " & pName.ToString)
                        de.Properties.Item(pName)(0) = pValue
                        de.CommitChanges()
                        Return True
                    Else
                        Debug.WriteLine("[Info] SetADProperty Item Add - " & pName & ": " & de.Properties(pName).Value)
                        de.Properties(pName).Add(pValue)
                        de.CommitChanges()
                        Return True
                    End If
                Else

                    With de
                        .Username = LoginUsername
                        .Password = LoginPassword
                        .AuthenticationType = AuthenticationTypes.Secure
                    End With

                    If de.Properties.Contains(pName) Then
                        Debug.WriteLine("[Info] SetADProperty Item Remove - " & pName.ToString)
                        de.Properties.Item(pName).RemoveAt(0)
                        de.CommitChanges()
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch Ex As Exception
                Debug.WriteLine("[Error] Unable to Set Property value for Property: " & pName & " : " & Ex.Message)
                Return False
            End Try
        End Function

        Public Function CheckUserExist(samAccountName As String) As Boolean
            Dim context As PrincipalContext = New PrincipalContext(ContextType.Domain, GetLocalDomainName, SelectedOU, ContextOptions.SimpleBind, LoginUsername, LoginPassword)
            Using context
                If (context.ValidateCredentials(LoginUsername, LoginPassword)) Then

                    Dim existedUserPrincipal As UserPrincipal = New UserPrincipal(context) With {.SamAccountName = samAccountName}
                    Dim searcher As PrincipalSearcher = New PrincipalSearcher(existedUserPrincipal)

                    If (searcher.FindOne() IsNot Nothing) Then
                        Return True
                    End If
                End If
            End Using
            Return False
        End Function

        Public Function GetHostNameFromIP(ByRef IP As String) As String
            Dim host As Net.IPHostEntry
            host = Net.Dns.GetHostEntry(IP)
            Return host.HostName
        End Function

        Public Function GetDomainControllerIPAddress() As Net.IPAddress()
            Return Net.Dns.GetHostAddresses(GetSingleDomainController())
        End Function

        Public Function GetDirEntryFromDomainObject(ByVal DomainObject As DomainObject) As DirectoryEntry
            Try
                If DomainObject.ObjectSid IsNot Nothing Then
                    If String.IsNullOrEmpty(LoginUsernamePrefix) Then
                        Return New DirectoryEntry(String.Format("LDAP://<SID={0}>", DomainObject.ObjectSid.ToString()))
                    Else
                        Return New DirectoryEntry(String.Format("LDAP://{0}/<SID={1}>", LoginUsernamePrefix, DomainObject.ObjectSid.ToString()), LoginUsername, LoginPassword)
                    End If

                Else

                    Using Entry As DirectoryEntry = GetDirEntry()

                        Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

                        With DirSearcher
                            .SearchRoot = Entry
                            .Filter = "(distinguishedName=" & DomainObject.DistinguishedName & ")"
                        End With

                        DirSearcher.PropertiesToLoad.AddRange(LDAPPropsShort)

                        Dim result As SearchResult = DirSearcher.FindOne()

                        If result IsNot Nothing Then
                            Return result.GetDirectoryEntry
                        Else
                            Return Nothing
                        End If
                    End Using
                End If
            Catch Ex As Exception
                Debug.WriteLine("[Error] Unabel to retrieve directory entry from object (" & DomainObject.Name & "): " & Ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function GetUPNSuffix() As String()
            Try
                Dim Entry As New DirectoryEntry("LDAP://" & LoginUsernamePrefix & "/RootDSE", LoginUsername, LoginPassword)
                Entry.RefreshCache()

                Dim strNamingContext As String = Entry.Properties("defaultNamingContext").Value.ToString()
                Dim strConfigContext As String = Entry.Properties("configurationNamingContext").Value.ToString()

                Dim oPartition As New DirectoryEntry("LDAP://" & LoginUsernamePrefix & "/CN=Partitions," & strConfigContext, LoginUsername, LoginPassword)

                oPartition.Invoke("GetEx", New Object() {"uPNSuffixes"})
                Dim suffixes As String() = DirectCast(oPartition.InvokeGet("uPNSuffixes"), String())

                Return suffixes
            Catch ex As Exception
                Debug.WriteLine(String.Format("[Error] Getting UPN Suffixes {0}" & vbLf & " Inner Exception: " & vbLf & " {1}", ex.Message, ex.InnerException))
                Return Nothing
            End Try
        End Function

        Public Function EnableADUserUsingUserAccountControl(ByVal DomainObject As DomainObject) As Integer
            Using userEntry As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)

                Dim old_UAC As Integer = CInt(userEntry.Properties("userAccountControl")(0))

                Dim ADS_UF_ACCOUNTDISABLE As Integer = 2

                userEntry.Properties("userAccountControl")(0) = (old_UAC And Not ADS_UF_ACCOUNTDISABLE)
                userEntry.CommitChanges()

                Debug.WriteLine("[Info] Active Directory User Account Enabled successfully through userAccountControl property")
                Return userEntry.Properties("userAccountControl")(0)
            End Using
        End Function

        Public Function DisableADUserUsingUserAccountControl(DomainObject As DomainObject) As Integer
            Using userEntry As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)

                Dim old_UAC As Integer = CInt(userEntry.Properties("userAccountControl")(0))

                Dim ADS_UF_ACCOUNTDISABLE As Integer = 2

                userEntry.Properties("userAccountControl")(0) = (old_UAC Or ADS_UF_ACCOUNTDISABLE)
                userEntry.CommitChanges()

                Debug.WriteLine("[Info] Active Directory User Account Disabled successfully through userAccountControl property")
                Return userEntry.Properties("userAccountControl")(0)
            End Using
        End Function

        Public Function IsAccountEnabled(ByVal DomainObject As DomainObject) As Boolean
            Try
                Using userEntry As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)
                    Const ADS_UF_ACCOUNTDISABLE As Integer = &H2

                    Dim Flags As Integer = CInt(userEntry.Properties("userAccountControl").Value)
                    If CBool(Flags And ADS_UF_ACCOUNTDISABLE) Then
                        Return True
                    Else
                        Return False
                    End If

                End Using
            Catch Ex As Exception
                Debug.WriteLine("[Error] Unable to retrive the status of the supplied account (" & DomainObject.Name & "): " & Ex.Message)
            End Try
            Return Nothing
        End Function

        Public Function DeleteADObject(ByVal DomainObject As DomainObject, Optional IsBackground As Boolean = False) As Boolean

            Debug.WriteLine("[Info] Delete requested on user: " & DomainObject.Name)
            Dim UserEntry As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)
            Try
                If Not UserEntry Is Nothing Then
                    UserEntry.DeleteTree()
                    UserEntry.CommitChanges()
                    UserEntry.Close()
                    Return True
                End If
                Return False
            Catch Ex As Exception
                Debug.WriteLine("[Error] Unable to Delete User (" & DomainObject.Name & "): " & Ex.Message & Environment.NewLine & Ex.StackTrace.ToString)
                Return False
            End Try
        End Function

        Public Function MoveADObject(ByVal DomainObject As DomainObject, ByVal Container As String) As Boolean
            Debug.WriteLine("[Info] Move requested on object: " & DomainObject.Name & " to container at: " & Container)
            Dim UserEntry As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)
            Try
                If Not UserEntry Is Nothing Then
                    Dim Path As String
                    If String.IsNullOrEmpty(LoginUsernamePrefix) Then
                        Path = "LDAP://" & Container
                    Else
                        Path = "LDAP://" & LoginUsernamePrefix & "/" & Container
                    End If
                    UserEntry.MoveTo(New DirectoryEntry(Path, LoginUsername, LoginPassword, AuthenticationTypes.Secure))
                    Debug.WriteLine("[Info] Successfully moved object (" & DomainObject.Name & ") to container (" & Container & ")")
                    Return True
                End If
                Return False
            Catch Ex As Exception
                Debug.WriteLine("[Error] Unable to Move User (" & DomainObject.Name & ") to Container (" & Container & "): " & Ex.Message & Environment.NewLine & Ex.StackTrace.ToString)
                Return False
            End Try
        End Function

        Public Function ResetUserPassword(ByVal UserObject As UserDomainObject, ByVal Password As String, ForceReset As Boolean) As Boolean
            Debug.WriteLine("[Info] Password reset requested on object: " & UserObject.Name)
            Try
                Try
                    Dim UserPr As UserPrincipal = UserPrincipal.FindByIdentity(GetPrincipalContext(), IdentityType.SamAccountName, UserObject.SAMAccountName)
                    UserPr.SetPassword(Password)
                    If ForceReset = True Then
                        UserPr.ExpirePasswordNow()
                    End If
                    UserPr.Save()
                    Return True
                Catch Ex As Exception
                    Dim UserPrincipalError As String = "[Error] Unable to create UserPrincipal object with user (" & UserObject.Name & "): " & Ex.Message
                    Debug.WriteLine(UserPrincipalError)
                    If Not Ex.InnerException Is Nothing Then
                        Debug.WriteLine("[Inner Exception] " & Ex.InnerException.Message)
                    End If
                    Return False
                End Try
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function GetSchemaPropeterties(ByVal Schema As String) As ReadOnlyActiveDirectorySchemaPropertyCollection
            Dim Properties As ICollection(Of String) = New List(Of String)

            Try
                Dim Adschemaclass As ActiveDirectorySchemaClass = ActiveDirectorySchema.GetSchema(GetDomainContext()).FindClass(Schema)
                Dim PropCol As ReadOnlyActiveDirectorySchemaPropertyCollection = Adschemaclass.GetAllProperties()

                Return PropCol
            Catch AuthEx As UnauthorizedAccessException
                Debug.WriteLine("[Error] Unable to read AD Schema: " & AuthEx.Message)
                Return Nothing
            End Try
        End Function

        Public Function ConvertADSLargeIntegerToInt64(AdsLargeInteger As Object) As String

            Dim highPart = DirectCast(AdsLargeInteger.GetType().InvokeMember("HighPart", Reflection.BindingFlags.GetProperty, Nothing, AdsLargeInteger, Nothing), Int32)
            Dim lowPart = DirectCast(AdsLargeInteger.GetType().InvokeMember("LowPart", Reflection.BindingFlags.GetProperty, Nothing, AdsLargeInteger, Nothing), Int32)
            Dim ValueAsLong As Decimal = highPart * Convert.ToUInt64(UInt32.MaxValue + 1) + lowPart

            Return ValueAsLong.ToString

        End Function

        Public Function RenameObject(ByVal DomainObject As DomainObject, ByVal Name As String) As Boolean
            Debug.WriteLine("[Info] Rename requested on object: " & DomainObject.Name)
            Try
                Dim DomainObjectDE As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)
                DomainObjectDE.Rename("CN=" & Name)
                DomainObjectDE.CommitChanges()
                Return True
            Catch Ex As Exception
                Dim RenameError As String = "[Error] Unable rename object (" & DomainObject.Name & "): " & Ex.Message
                Debug.WriteLine(RenameError)
                If Not Ex.InnerException Is Nothing Then
                    Debug.WriteLine("[Inner Exception] " & Ex.InnerException.Message)
                End If
                Return False
            End Try
        End Function

        Public Sub SetPassword(ByVal Objuser As DirectoryEntry, ByVal sPassword As String)
            Dim oPassword As Object() = New Object() {sPassword}
            Dim ret As Object = Objuser.Invoke("SetPassword", oPassword)
            Objuser.CommitChanges()
        End Sub

        Public Sub EnableAccount(ByVal Objuser As DirectoryEntry)
            Dim exp As Integer = CInt(Objuser.Properties("userAccountControl").Value)
            Objuser.Properties("userAccountControl").Value = exp Or &H1
            Objuser.CommitChanges()
            Dim val As Integer = CInt(Objuser.Properties("userAccountControl").Value)
            Objuser.Properties("userAccountControl").Value = val And Not &H2
            Objuser.CommitChanges()
        End Sub

End Module