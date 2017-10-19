Imports System.Reflection

Module LDAPDataHelper

    Public Enum DataToLoadType
        Condensed = 0
        Full = 1
    End Enum

    Public Function GetLDAPProps() As String()
        Select Case My.Settings.LoadAdvLDAP
            Case False
                Return LDAPPropsShort
            Case True
                Return LDAPProps
        End Select
        Return Nothing
    End Function

End Module
