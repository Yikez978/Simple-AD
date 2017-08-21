Imports System.Environment

Public Module GlobalVariables

    Public ButtonHoverColor = SystemColors.Highlight
    Public ButtonHoverClickColor = SystemColors.ButtonShadow

    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Simple AD"
    Public LoginUsernamePrefix As String

    Public Property LoginUsername As String
    Public Property LoginPassword As String
    Public Property Office365Username As String
    Public Property Office365Password As String

    Public OfficeURI As String = "https://ps.outlook.com/PowerShell-LiveID?PSVersion=2.0"
    Public OfficeShellURI As String = "http://schemas.microsoft.com/powershell/Microsoft.Exchange"

    Public UpdateURI As String = "http://storage.googleapis.com/simple-ad.appspot.com/SimpleAD/versioninfo.xml"

    Public Property IconGroup As Image = GetImage(ActiveDirectoryIconType.Group)
    Public Property IconUser As Image = GetImage(ActiveDirectoryIconType.User)
    Public Property IconComputer As Image = GetImage(ActiveDirectoryIconType.Computer)
    Public Property IconDisabledUSer As Image = GetImage(ActiveDirectoryIconType.DisabledUser)
    Public Property IconOU As Image = GetImage(ActiveDirectoryIconType.OU)
    Public Property IconDomian As Image = GetImage(ActiveDirectoryIconType.Domain)
    Public Property IconContainer As Image = GetImage(ActiveDirectoryIconType.Container)
    Public Property IconContact As Image = GetImage(ActiveDirectoryIconType.Contact)

    Public HiddenColums As New List(Of String)
    Public TempHiddenColumns As New List(Of String)
    Public CustomColumns As New List(Of String)
    Public OngoingBulkJobs As New List(Of BulkADWorker)

    Public ColumnsVisibleChangedByUser As Boolean

    Public Headers() = {"name", "status", "sAMAccountName", "givenName", "sn", "displayName", "scriptPath", "homeDrive", "homeDirectory", "pager", "mail", "description", "tsProfilePath", "password"}
    Public DefaultColumns() = {"nameCol", "description", "status"}
    Public DefaultOffice365Columns() = {"Name", "DisplayName", "Alias", "WindowsEmailAddress", "Filler"}

    Public PersistantColumns() = {"Status", "Filler", "nameCol"}

    Public MainViewMode As String
    Public ProcessedUsers As Integer = 0
    Public SelectedOU = ""
    Public RightClickedTab As TabPage

#Region "Options"
    Public Property ForcePwdReset As Boolean
    Public Property CreateHomeFolders As Boolean
    Public Property EnableNewAccounts As Boolean
#End Region

End Module
