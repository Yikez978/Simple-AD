Public Module EnvironmentHelper

    Public Function IsWindows7() As Boolean
        Return Environment.OSVersion.Version.Major = 6
    End Function

End Module
