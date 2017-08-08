Imports System.Environment

Public Class GlobalVariables

    Public Shared Sub Load()
        ForcePwdReset = True
        CreateHomeFolders = True
        EnableNewAccounts = True
    End Sub

    Public Shared ButtonHoverColor = SystemColors.Highlight
    Public Shared ButtonHoverClickColor = SystemColors.ButtonShadow

    Public Shared appData As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Simple AD"
    Public Shared LoginUsernamePrefix As String

    Public Shared DomainItems As New List(Of DomainTreeContainerItem)

    Public Shared Property LoginUsername As String
    Public Shared Property LoginPassword As String
    Public Shared Property Office365Username As String
    Public Shared Property Office365Password As String

    Public Shared OfficeURI As String = "https://ps.outlook.com/PowerShell-LiveID?PSVersion=2.0"
    Public Shared OfficeShellURI As String = "http://schemas.microsoft.com/powershell/Microsoft.Exchange"

    Public Shared UpdateURI As String = "http://storage.googleapis.com/simple-ad.appspot.com/SimpleAD/versioninfo.xml"

    Public Shared Property IconGroup As Image = GetImage(ActiveDirectoryIconType.Group)
    Public Shared Property IconUser As Image = GetImage(ActiveDirectoryIconType.User)
    Public Shared Property IconComputer As Image = GetImage(ActiveDirectoryIconType.Computer)
    Public Shared Property IconDisabledUSer As Image = GetImage(ActiveDirectoryIconType.DisabledUser)
    Public Shared Property IconOU As Image = GetImage(ActiveDirectoryIconType.OU)
    Public Shared Property IconDomian As Image = GetImage(ActiveDirectoryIconType.Domain)
    Public Shared Property IconContainer As Image = GetImage(ActiveDirectoryIconType.Container)

    Public Shared HiddenColums As New List(Of String)
    Public Shared TempHiddenColumns As New List(Of String)
    Public Shared ColumnsVisibleChangedByUser As Boolean

    Public Shared Headers() = {"Username", "FirstName", "Surname", "DisplayName", "ScriptPath", "HomeDrive", "HomeDirectory", "Pager", "Mail", "Description", "MailDomain", "TsProfilePath", "Password"}
    Public Shared DefaultColumns() = {"Name", "Description", "Status", "Filler"}
    Public Shared DefaultOffice365Columns() = {"Name", "DisplayName", "Alias", "WindowsEmailAddress", "Filler"}

    Public Shared PersistantColumns() = {"Status", "Filler", "Name"}

    Public Shared CustomColumns As New List(Of String)
    Public Shared MainViewMode As String
    Public Shared ProcessedUsers As Integer = 0
    Public Shared SelectedOU = ""
    Public Shared RightClickedTab As TabPage
#Region "Options"
    Public Shared Property ForcePwdReset As Boolean
    Public Shared Property CreateHomeFolders As Boolean
    Public Shared Property EnableNewAccounts As Boolean
#End Region

End Class
