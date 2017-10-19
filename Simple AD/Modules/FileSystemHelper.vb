Imports System.IO
Imports System.Security.AccessControl

Public Module FileSystemHelper

    Public Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    ' thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
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
