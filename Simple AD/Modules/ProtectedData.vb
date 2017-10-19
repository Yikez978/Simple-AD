Imports System.Security.Cryptography

Public Module DataProtection

    ' Create byte array for additional entropy when using Protect method.
    Private s_aditionalEntropy As Byte() = {9, 8, 7, 6, 5}

    Public Function Protect(ByVal data As String) As String
        Try
            ' Encrypt the data using DataProtectionScope.CurrentUser. The result can be decrypted
            '  only by the same current user.
            Dim clearBytes As Byte() = Encoding.UTF8.GetBytes(data)
            Dim EncryptedBytes As Byte() = ProtectedData.Protect(clearBytes, s_aditionalEntropy, DataProtectionScope.CurrentUser)
            Return Convert.ToBase64String(EncryptedBytes)
        Catch e As CryptographicException
            Debug.WriteLine("Data was not encrypted. An error occurred.")
            Debug.WriteLine(e.Message.ToString())
            Return Nothing
        End Try

    End Function


    Public Function Unprotect(ByVal data As String) As String
        Try
            'Decrypt the data using DataProtectionScope.CurrentUser.
            Dim EncryptedBytes As Byte() = Convert.FromBase64String(data)
            Dim clearBytes As Byte() = ProtectedData.Unprotect(EncryptedBytes, s_aditionalEntropy, DataProtectionScope.CurrentUser)
            Return Encoding.UTF8.GetString(clearBytes)
        Catch e As CryptographicException
            Debug.WriteLine("Data was not decrypted. An error occurred.")
            Debug.WriteLine(e.Message.ToString())
            Return Nothing
        End Try

    End Function

End Module
