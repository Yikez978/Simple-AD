Imports System.IO
Imports System.Security.AccessControl

Public Module FileSystemHelper

    Public Function FileInUse(ByVal Path As String) As Boolean
        Dim Stream As FileStream = Nothing
        Dim file As FileInfo = New FileInfo(Path)

        Try
            Stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None)
        Catch generatedExceptionName As IOException
            Return True
        Finally
            If Stream IsNot Nothing Then
                Stream.Close()
            End If
        End Try

        Return False
    End Function

    Public Function HasWritePermissionOnDir(path As String) As Boolean
        Dim writeAllow = False
        Dim writeDeny = False
        Dim accessControlList = Directory.GetAccessControl(path)
        If accessControlList Is Nothing Then
            Return False
        End If
        Dim accessRules = accessControlList.GetAccessRules(True, True, GetType(System.Security.Principal.SecurityIdentifier))
        If accessRules Is Nothing Then
            Return False
        End If

        For Each rule As FileSystemAccessRule In accessRules
            If (FileSystemRights.Write And rule.FileSystemRights) <> FileSystemRights.Write Then
                Continue For
            End If

            If rule.AccessControlType = AccessControlType.Allow Then
                writeAllow = True
            ElseIf rule.AccessControlType = AccessControlType.Deny Then
                writeDeny = True
            End If
        Next

        Return writeAllow AndAlso Not writeDeny
    End Function

End Module
