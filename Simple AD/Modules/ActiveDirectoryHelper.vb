Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices.ActiveDirectory

Module ActiveDirectoryHelper

    Public Function GetSingleDomainController(ByVal ConnectionUsername As String, ByVal ConnectionPassword As String) As String
        Return Domain.GetDomain(GetDomainContext(ConnectionUsername, ConnectionPassword)).PdcRoleOwner.Name
    End Function

    Public Function GetDomainContext(ByVal ConnectionUsername As String, ByVal ConnectionPassword As String) As DirectoryContext
        If String.IsNullOrEmpty(ConnectionUsername) Then
            Return New DirectoryContext(DirectoryContextType.Domain, GetLocalDomainName)
        ElseIf String.IsNullOrEmpty(LoginUsernamePrefix) Then
            Return New DirectoryContext(DirectoryContextType.Domain, GetLocalDomainName, ConnectionUsername, ConnectionPassword)
        Else
            Return New DirectoryContext(DirectoryContextType.DirectoryServer, LoginUsernamePrefix, ConnectionUsername, ConnectionPassword)
        End If
    End Function

    Public Function GetPrincipalContext(ByVal ConnectionUsername As String, ByVal ConnectionPassword As String) As PrincipalContext
        If String.IsNullOrEmpty(ConnectionUsername) Then
            Return New PrincipalContext(ContextType.Domain, GetLocalDomainName)
        ElseIf String.IsNullOrEmpty(LoginUsernamePrefix) Then
            Return New PrincipalContext(ContextType.Machine, GetDomainControllerIPAddress(0).ToString, ConnectionUsername, ConnectionPassword)
        Else
            Return New PrincipalContext(ContextType.Machine, LoginUsernamePrefix, ConnectionUsername, ConnectionPassword)
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
        Dim DomainArray As String() = Strings.Split(Domain.GetCurrentDomain.Name, ".")
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
            entry = "LDAP://" & GetSingleDomainController(LoginUsername, LoginPassword)
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

            Dim Entry As DirectoryEntry = New DirectoryEntry(GetDirEntryPath, LoginUsername, LoginPassword)
            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = "(&(objectClass=user)(sAMAccountName=" & LoginUsername & "))"
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

                Dim existedUserPrincipal As UserPrincipal = New UserPrincipal(context)
                existedUserPrincipal.SamAccountName = samAccountName
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
        Return Net.Dns.GetHostAddresses(GetSingleDomainController(LoginUsername, LoginPassword))
    End Function

    Public Function GetDirEntryFromSAM(ByVal sAMAccountName As String) As DirectoryEntry
        Try
            Using Entry As DirectoryEntry = New DirectoryEntry(GetDirEntryPath, LoginUsername, LoginPassword)

                Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

                With DirSearcher
                    .SearchRoot = Entry
                    .Filter = "(sAMAccountName=" & sAMAccountName & ")"
                End With

                DirSearcher.PropertiesToLoad.AddRange(GetLDAPProps())

                Dim result As SearchResult = DirSearcher.FindOne()

                Return result.GetDirectoryEntry
            End Using
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unabel to retrieve directory entry with the supplied username (" & sAMAccountName & "): " & Ex.Message)
        End Try
        Return Nothing
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

    Public Function EnableADUserUsingUserAccountControl(Username As String) As Integer
        Try
            Using userEntry As DirectoryEntry = GetDirEntryFromSAM(Username)

                Dim old_UAC As Integer = CInt(userEntry.Properties("userAccountControl")(0))

                Dim ADS_UF_ACCOUNTDISABLE As Integer = 2

                userEntry.Properties("userAccountControl")(0) = (old_UAC And Not ADS_UF_ACCOUNTDISABLE)
                userEntry.CommitChanges()

                Debug.WriteLine("[Info] Active Directory User Account Enabled successfully through userAccountControl property")
                Return userEntry.Properties("userAccountControl")(0)
            End Using

            Return Nothing
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to Enable User account though userAccountControl property: " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function DisableADUserUsingUserAccountControl(Username As String) As Integer
        Try
            Using userEntry As DirectoryEntry = GetDirEntryFromSAM(Username)

                Dim old_UAC As Integer = CInt(userEntry.Properties("userAccountControl")(0))

                Dim ADS_UF_ACCOUNTDISABLE As Integer = 2

                userEntry.Properties("userAccountControl")(0) = (old_UAC Or ADS_UF_ACCOUNTDISABLE)
                userEntry.CommitChanges()

                Debug.WriteLine("[Info] Active Directory User Account Disabled successfully through userAccountControl property")
                Return userEntry.Properties("userAccountControl")(0)
            End Using

            Return Nothing
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to Disable User account though userAccountControl property: " & Ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function IsAccountEnabled(ByVal Username As String) As Boolean
        Try
            Using userEntry As DirectoryEntry = GetDirEntryFromSAM(Username)
                Const ADS_UF_ACCOUNTDISABLE As Integer = &H2

                Dim Flags As Integer = CInt(userEntry.Properties("userAccountControl").Value)
                If CBool(Flags And ADS_UF_ACCOUNTDISABLE) Then
                    Return True
                Else
                    Return False
                End If

            End Using
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to retrive the status of the supplied account (" & Username & "): " & Ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function DeleteADObject(ByVal Username As String) As Boolean
        Debug.WriteLine("[Info] Delete requested on user: " & Username)
        Dim UserEntry As DirectoryEntry = GetDirEntryFromSAM(Username)
        Try
            If Not UserEntry Is Nothing Then
                UserEntry.DeleteTree()
                UserEntry.CommitChanges()
                UserEntry.Close()
                Return True
            End If
            Return False
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to Delete User (" & Username & "): " & Ex.Message & Environment.NewLine & Ex.StackTrace.ToString)
            Return False
        End Try
    End Function

    Public Function MoveADObject(ByVal Username As String, ByVal Container As String) As Boolean
        Debug.WriteLine("[Info] Move requested on object: " & Username & " to container at: " & Container)
        Dim UserEntry As DirectoryEntry = GetDirEntryFromSAM(Username)
        Try
            If Not UserEntry Is Nothing Then
                Dim Path As String
                If String.IsNullOrEmpty(LoginUsernamePrefix) Then
                    Path = "LDAP://" & Container
                Else
                    Path = "LDAP://" & LoginUsernamePrefix & "/" & Container
                End If
                UserEntry.MoveTo(New DirectoryEntry(Path, LoginUsername, LoginPassword, AuthenticationTypes.Secure))
                Debug.WriteLine("[Info] Successfully moved object (" & Username & ") to container (" & Container & ")")
                Return True
            End If
            Return False
        Catch Ex As Exception
            Debug.WriteLine("[Error] Unable to Move User (" & Username & ") to Container (" & Container & "): " & Ex.Message & Environment.NewLine & Ex.StackTrace.ToString)
            Return False
        End Try
    End Function

End Module
