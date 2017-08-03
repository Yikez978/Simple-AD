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

    Public Shared Property LoginUsername As String
    Public Shared Property LoginPassword As String
    Public Shared Property Office365Username As String
    Public Shared Property Office365Password As String

    Public Shared Property GroupImage As Image = ActiveDirectoryIcon.GetIcon(ActiveDirectoryIcon.ActiveDirectoryIconType.Group).ToBitmap

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
