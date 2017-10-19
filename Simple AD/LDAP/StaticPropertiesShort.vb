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
            "name",
            "objectClass",
            "description",
            "UserAccountControl",
            "sAMAccountName",
            "distinguishedName",
            "isCriticalSystemObject",
            "showInAdvancedViewOnly"
    }

    Public ListViewPropsColumns() As String = {
            "name",
            "objectClass",
            "description"
    }

    Public ListViewProps() = {
            "objectClass",
            "description"
    }

    Public DefaultLDAPColumns() = {
            "name",
            "displayName",
            "sAMAccountName",
            "description"
    }

    Public LDAPBulkSupportedProps() = {
            "displayName",
            "sAMAccountName",
            "description",
            "proxyAddresses",
            "pager",
            "name",
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
