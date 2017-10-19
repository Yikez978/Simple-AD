Imports System.Environment

Public Module GlobalVariables

    Public ButtonHoverColor = SystemColors.Highlight
    Public ButtonHoverClickColor = SystemColors.ButtonShadow

    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Simple AD"
    Public LoginUsernamePrefix As String

    Public UpdateURI As String = "http://storage.googleapis.com/simple-ad.appspot.com/SimpleAD/versioninfo.xml"

    Public Property LoginUsername As String
    Public Property LoginPassword As String

    Public Property Office365Username As String
    Public Property Office365Password As String

#Region "Images"
    Public Property IconGroup As Image = GetImage(ActiveDirectoryIconType.Group)
    Public Property IconUser As Image = GetImage(ActiveDirectoryIconType.User)
    Public Property IconComputer As Image = GetImage(ActiveDirectoryIconType.Computer)
    Public Property IconDisabledUSer As Image = GetImage(ActiveDirectoryIconType.DisabledUser)
    Public Property IconOU As Image = GetImage(ActiveDirectoryIconType.OU)
    Public Property IconDomian As Image = GetImage(ActiveDirectoryIconType.Domain)
    Public Property IconContainer As Image = GetImage(ActiveDirectoryIconType.Container)
    Public Property IconUnknown As Image = GetImage(ActiveDirectoryIconType.Unknown)
    Public Property IconContact As Image = GetImage(ActiveDirectoryIconType.Contact)
    Public Property IconSearch As Image = GetImage(ActiveDirectoryIconType.Search)
    Public Property IconUserSuccess As Image = GetImage(ActiveDirectoryIconType.UserSuccess)
    Public Property IconUserFailed As Image = GetImage(ActiveDirectoryIconType.UserFailed)
    Public Property IconUserError As Image = GetImage(ActiveDirectoryIconType.UserError)
    Public Property IconUserPending As Image = GetImage(ActiveDirectoryIconType.UserPending)

    Public Property IconOULarge As Image = GetLargeImage(ActiveDirectoryIconType.OU)
    Public Property IconDomianLarge As Image = GetLargeImage(ActiveDirectoryIconType.Domain)
    Public Property IconContainerLarge As Image = GetLargeImage(ActiveDirectoryIconType.Container)
    Public Property IconGroupLarge As Image = GetLargeImage(ActiveDirectoryIconType.Group)
    Public Property IconComputerLarge As Image = GetLargeImage(ActiveDirectoryIconType.Computer)
    Public Property IconUserLarge As Image = GetLargeImage(ActiveDirectoryIconType.User)
    Public Property IconDisabledUserLarge As Image = GetLargeImage(ActiveDirectoryIconType.DisabledUser)
    Public Property IconContactLarge As Image = GetLargeImage(ActiveDirectoryIconType.Contact)
    Public Property IconUnknownLarge As Image = GetLargeImage(ActiveDirectoryIconType.Unknown)


    Public Property IconUserFlat As Image = My.Resources.User
    Public Property IconGroupFlat As Image = My.Resources.Group
    Public Property IconUserCrossFlat As Image = My.Resources.UserDisabled

#End Region



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
