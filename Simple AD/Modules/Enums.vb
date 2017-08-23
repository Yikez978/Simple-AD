Public Module Enums

    Public Enum ReportType
        CustomLDAP
        DisabledUsers
        AllObjects
        Explorer
    End Enum

    Public Enum ActiveDirectoryIconType
        Computer = 1
        Contact = 3
        Container = 4
        Domain = 5
        Group = 7
        User = 12
        OU = 13
        DisabledUser = 27
        Unknown
        Search
    End Enum

    Public Enum ConfirmationType
        Delete
    End Enum

    Public Enum AlertType
        Success
        ErrorAlert
    End Enum

    Public Enum ObjectClass
        organizationalUnit
        container
        computer
        user
        group
        dnsNode
        dnsZode
        linkTrackOMTEntry
        publicFolder
        contact
        msSFU30NISMapConfig
        msSFU30DomainInfo
        nTFRSReplicaSet
        serviceConnectionPoint
        groupPolicyContainer
    End Enum

    Public Enum ADNodeType
        Container
        OU
        Domain
        Unknown
    End Enum
End Module
