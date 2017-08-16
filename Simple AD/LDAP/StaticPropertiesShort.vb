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

    Public LDAPBulkSupportedProps() = {
            "displayName",
            "sAMAccountName",
            "description",
            "proxyAddresses",
            "pager",
            "sn",
            "givenName",
            "scriptPath",
            "company",
            "department",
            "employeeID",
            "facsimileTelephoneNumber",
            "homeDirectory",
            "homeDrive",
            "homePhone",
            "info",
            "initials",
            "ipPhone",
            "l",
            "mail",
            "middleName",
            "mobile",
            "personalTitle",
            "physicalDeliveryOfficeName",
            "postalCode",
            "postOfficeBox",
            "primaryInternationalISDNNumber",
            "primaryTelexNumber",
            "profilePath",
            "st",
            "streetAddress",
            "telephoneNumber",
            "title",
            "url",
            "wWWHomePage"
    }
End Module
