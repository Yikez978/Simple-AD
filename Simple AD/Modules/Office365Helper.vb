Imports System.Management.Automation
Imports System.Management.Automation.Runspaces

Module Office365Helper

    Public Function ValidateOffice365Login(ByVal Email As String, ByVal Password As String) As Boolean

        Dim secureString As System.Security.SecureString = New System.Security.SecureString()

        For Each c As Char In Password
            secureString.AppendChar(c)
        Next

        Dim credential As PSCredential = New PSCredential(Email, secureString)
        Dim connectionInfo As WSManConnectionInfo
        Try
            connectionInfo = New WSManConnectionInfo(New Uri(My.Settings.OfficeURI), My.Settings.OfficeShellURI, credential)
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
        End Try

        With connectionInfo
            .AuthenticationMechanism = AuthenticationMechanism.Basic
            .SkipCACheck = True
            .SkipCNCheck = True
            .UseCompression = True
            .MaximumConnectionRedirectionCount = 4
        End With

        Dim runspace As Runspace = RunspaceFactory.CreateRunspace(connectionInfo)
        Try
            runspace.Open()
            Return True
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            Return False
        End Try

    End Function

    Public Sub ResetOffice365Password()
        Dim iss As InitialSessionState = InitialSessionState.CreateDefault()
        Dim newImport() = {"MSOnline"}
        iss.ImportPSModule(newImport)
        Using psRunSpace As Runspace = RunspaceFactory.CreateRunspace(iss)
            psRunSpace.Open()
            Using powershell As PowerShell = PowerShell.Create()
            End Using
        End Using
    End Sub

End Module
