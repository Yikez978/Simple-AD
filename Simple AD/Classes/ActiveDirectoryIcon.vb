Imports System.Drawing

Friend Class ActiveDirectoryIcon
    ''' <summary>
    ''' Gets the icon that is at the specified index in the exe, dll or ico file
    ''' </summary>
    ''' <param name="FilePath">The exe, dll or ico file to extract the icon from</param>
    ''' <param name="Index">The zero-based index of the icon to be extracted</param>
    ''' <param name="GetSmallIcon">Set to True to extract the small version of the icon, usually 16 x 16 in size</param>
    Private Shared Function GetIconAtIndex(ByVal FilePath As String, ByVal Index As Integer, ByVal GetSmallIcon As Boolean) As Drawing.Icon
        Dim NumberOfIcons As UInteger = 0
        'Find out how many icons are in the selected file
        NumberOfIcons = WindowsApi.ExtractIconEx(FilePath, -1, Nothing, Nothing, 0)
        If NumberOfIcons = 0 Then
            Throw New ApplicationException("The specified file could not be found or does not contain any icons")
        ElseIf NumberOfIcons < (Index + 1) Then
            Throw New ArgumentOutOfRangeException("Index", "The icon index " & Index & " is not valid as the specified file does not contain this many icons")
        End If

        Dim SmallIconHandle As IntPtr = Nothing
        Dim LargeIconHandle As IntPtr = Nothing
        Dim ReturnedIcon As Drawing.Icon
        'Call the API to extract the icon at the specified index
        WindowsApi.ExtractIconEx(FilePath, Index, LargeIconHandle, SmallIconHandle, 1)
        If GetSmallIcon Then
            ReturnedIcon = Drawing.Icon.FromHandle(SmallIconHandle)
        Else
            ReturnedIcon = Drawing.Icon.FromHandle(LargeIconHandle)
        End If
        Return ReturnedIcon
    End Function


    Public Shared Function GetIcon(ByVal IconType As ActiveDirectoryIconType) As Drawing.Icon
        Return GetIconAtIndex(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "dsuiext.dll"), IconType, True)
    End Function

End Class