Imports System.Runtime.InteropServices

Friend Class WindowsApi

    ''' <summary>
    ''' Extracts an icon from a specified exe, dll or icon file. Call DestroyIcon on handles once finished.
    ''' </summary>
    ''' <param name="lpszFile">The file to extract the icon from</param>
    ''' <param name="nIconIndex">Specifies the zero-based index of the icon to extract. If this value is –1 and phiconLarge and phiconSmall are both NULL, the function returns the total number of icons in the specified file</param>
    ''' <param name="phiconLarge">Handle to the large version of the icon requested</param>
    ''' <param name="phiconSmall">handle to the small version of the icon requested</param>
    ''' <param name="nIcons">Number of icons to extract</param>
    <DllImport("shell32.dll", EntryPoint:="ExtractIconExW", CallingConvention:=CallingConvention.StdCall, SetLastError:=True)>
    Public Shared Function ExtractIconEx(<InAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpszFile As String, ByVal nIconIndex As Integer, ByRef phiconLarge As IntPtr, ByRef phiconSmall As IntPtr, ByVal nIcons As UInteger) As UInteger
    End Function

    <DllImport("uxtheme", CharSet:=CharSet.Unicode)>
    Public Shared Function SetWindowTheme(ByVal hWnd As IntPtr, ByVal textSubAppName As String, ByVal textSubIdList As String) As Integer
    End Function

End Class