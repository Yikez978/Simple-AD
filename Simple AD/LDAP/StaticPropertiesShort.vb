Module StaticPropertiesShort
    Public Office365PropsShort() As String = {
            "SamAccountName",
            "UserPrincipalName",
            "Alias",
            "DisplayName",
            "PrimarySmtpAddress",
            "WindowsEmailAddress",
            "Name"
    }

    Public LDAPPropsShort() As String = {
            "givenName",
            "sn",
            "userPrincipalName",
            "sAMAccountName",
            "displayName",
            "name",
            "description",
            "sAMAccountType",
            "UserAccountControl"
    }

    Public DefaultLDAPColumns() = {
            "name",
            "displayName",
            "sAMAccountName",
            "description",
            "sAMAccountType"
    }

End Module
