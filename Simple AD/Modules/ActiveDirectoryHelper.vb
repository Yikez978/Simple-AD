Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices.ActiveDirectory

Module ActiveDirectoryHelper

    Public Function GetSingleDomainController(ByVal DomainName As String, ByVal ConnectionUsername As String, ByVal ConnectionPassword As String) As String
        Return Domain.GetDomain(GetDomainContext(DomainName, ConnectionUsername, ConnectionPassword)).PdcRoleOwner.Name
    End Function

    Public Function GetDomainContext(ByVal DomainName As String, ByVal ConnectionUsername As String, ByVal ConnectionPassword As String) As DirectoryContext
        If String.IsNullOrEmpty(ConnectionUsername) Then
            Return New DirectoryContext(DirectoryServices.ActiveDirectory.DirectoryContextType.Domain, DomainName)
        ElseIf String.IsNullOrEmpty(GlobalVariables.LoginUsernamePrefix) Then
            Return (New DirectoryContext(DirectoryServices.ActiveDirectory.DirectoryContextType.Domain, DomainName, ConnectionUsername, ConnectionPassword))
        Else
            Return (New DirectoryContext(DirectoryContextType.DirectoryServer, GlobalVariables.LoginUsernamePrefix, ConnectionUsername, ConnectionPassword))
        End If
    End Function

    Public Function GetLocalDomainName() As String

        Dim DomainName As String = Nothing

        Try
            If Not String.IsNullOrEmpty(GlobalVariables.LoginUsernamePrefix) Then

                Dim DomainContext As DirectoryContext = New DirectoryContext(DirectoryContextType.DirectoryServer, GlobalVariables.LoginUsernamePrefix, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)
                DomainName = DirectoryServices.ActiveDirectory.Domain.GetDomain(DomainContext).Name

            Else
                Try
                    DomainName = DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain.Name
                Catch ex As Exception
                    DomainName = ""
                End Try

                Return DomainName

            End If
        Catch AuthEx As System.Security.Authentication.AuthenticationException
            Debug.WriteLine(AuthEx.InnerException.ToString)
            Return DomainName
        Catch NoneExistantDirEx As System.DirectoryServices.ActiveDirectory.ActiveDirectoryObjectNotFoundException
            Debug.WriteLine(NoneExistantDirEx.InnerException.ToString)
            Return DomainName
        End Try

        Return DomainName
    End Function

    Public Function GetFQDN() As String

        Dim fqdnArray = Strings.Split(GetLocalDomainName(), ".")
        Dim fqdn As String = String.Join(",DC=", fqdnArray)

        Return "DC=" & fqdn
    End Function

    Public Function GetDirEntry() As String

        Dim entry As String

        If String.IsNullOrEmpty(GlobalVariables.LoginUsernamePrefix) Then

            entry = "LDAP://" & GetSingleDomainController(GetLocalDomainName, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)

        Else
            entry = "LDAP://" & GlobalVariables.LoginUsernamePrefix
        End If

        Return entry
    End Function

    Public Function GetDisplayName() As String
        Dim DisplayName As String = "User"
        Try

            Dim Entry As DirectoryEntry = GetDirEntryFromSAM(GlobalVariables.LoginUsername)
            DisplayName = Entry.Properties("displayName").Value

        Catch ex As Exception
            MsgBox(ex.Message)
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
        End Try
        Return Success
    End Function

    Public Function SetADProperty(ByVal de As DirectoryEntry, ByVal pName As String, ByVal pValue As String) As Boolean
        Try
            If Not pValue Is Nothing Then

                Debug.WriteLine("SetADProperty Started")

                With de
                    .Username = GlobalVariables.LoginUsername
                    .Password = GlobalVariables.LoginPassword
                    .AuthenticationType = AuthenticationTypes.Secure
                End With

                'Debug.WriteLine(pName)

                If de.Properties.Contains(pName) Then
                    Debug.WriteLine("SetADProperty Item Amend Ran" & pName.ToString)
                    de.Properties.Item(pName)(0) = pValue
                    de.CommitChanges()
                    Return True
                Else
                    Debug.WriteLine("SetADProperty ELSE Ran - " & pName & ": " & de.Properties(pName).Value)
                    de.Properties(pName).Add(pValue)
                    de.CommitChanges()
                    Return True
                End If
            Else

                With de
                    .Username = GlobalVariables.LoginUsername
                    .Password = GlobalVariables.LoginPassword
                    .AuthenticationType = AuthenticationTypes.Secure
                End With

                If de.Properties.Contains(pName) Then
                    Debug.WriteLine("SetADProperty Item Amend Ran" & pName.ToString)
                    de.Properties.Item(pName).RemoveAt(0)
                    de.CommitChanges()
                    Return True
                Else
                    Return False
                End If
            End If
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message)
            Return False
        End Try
    End Function

    Public Sub CreateUser(Username As String, FirstName As String, LastName As String, Password As String)

        Dim context As PrincipalContext = New PrincipalContext(ContextType.Domain, GetLocalDomainName, GlobalVariables.SelectedOU, ContextOptions.SimpleBind, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)

        Using context

            If (context.ValidateCredentials(GlobalVariables.LoginUsername, GlobalVariables.LoginPassword.ToString)) Then

                Dim UserPrincipal As UserPrincipal = New UserPrincipal(context, Username, Password, True)
                UserPrincipal.GivenName = FirstName
                UserPrincipal.Surname = LastName
                UserPrincipal.DisplayName = UserPrincipal.GivenName + " " + UserPrincipal.Surname
                UserPrincipal.Name = UserPrincipal.GivenName + " " + UserPrincipal.Surname
                UserPrincipal.Save()
                UserPrincipal.Dispose()

            End If
        End Using
    End Sub

    Public Function CheckUserExist(samAccountName As String) As Boolean

        Dim context As PrincipalContext = New PrincipalContext(ContextType.Domain, GetLocalDomainName, GlobalVariables.SelectedOU, ContextOptions.SimpleBind, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)

        Using context

            If (context.ValidateCredentials(GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)) Then

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

    Public Function GetDirEntryFromSAM(ByVal sAMAccountName As String) As DirectoryEntry
        Try
            Dim Entry As DirectoryEntry = New DirectoryEntry(GetDirEntry, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword)

            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntry)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = "(sAMAccountName=" & sAMAccountName & ")"
            End With

            DirSearcher.PropertiesToLoad.AddRange(GetLDAPProps())

            Dim result As SearchResult = DirSearcher.FindOne()

            Return result.GetDirectoryEntry
        Catch Ex As Exception
            Debug.WriteLine(Ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function UpdateLDAPProperty(ByVal SAM As String, LDAPProperty As String) As Boolean

        Try

        Catch ex As Exception

        End Try

        Return False
    End Function

End Module
