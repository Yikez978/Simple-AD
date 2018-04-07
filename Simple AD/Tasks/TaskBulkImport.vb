Imports System.Linq
Imports System.Windows.Forms
Imports BrightIdeasSoftware

Imports SimpleAD.LocalData

Imports SimpleLib
Imports SimpleLib.SystemHelper

Public Class TaskBulkImport
    Inherits TaskBase

    Private DisplayNamebool As Boolean
    Private MainListView As ObjectListView

    Private ImportErrorForm As FormImportValidation
    Private Delegate Sub Delegate_ImportError()

    Public WithEvents ImportForm As FormImport
    Private WithEvents ImportWorker As BulkADWorker

    Public ForcePasswordReset As Boolean
    Public CreateHomeFolders As Boolean
    Public EnableAccounts As Boolean

    Public Property ImportPath As String

    Public Property FileName As String
    Public Property Users As New List(Of SimpleADBulkUserDomainObject)

    Public Event ImportCompleted()

    Public Sub New(ByVal IFile As String, ByVal IForm As FormImport)
        MyBase.New

        ImportPath = IFile
        ImportForm = IForm
    End Sub

    Public Sub BeginImport()

        Dim FileToImport As String = String.Empty

        If String.IsNullOrEmpty(ImportPath) Then
            FileToImport = GetImportPath()
        Else
            FileToImport = ImportPath
        End If

        If String.IsNullOrEmpty(FileToImport) Then
            Exit Sub
        End If

        ImportErrorForm = New FormImportValidation

        TaskType = ActiveTaskType.UserImport
        TaskName = FileToImport.Split(New Char() {"\"c})(FileToImport.Split(New Char() {"\"c}).Count - 1)
        FileName = TaskName

        Dim FullName As String() = FileToImport.Split(New Char() {"\"c})

        Threading.ThreadPool.QueueUserWorkItem(AddressOf ImportCSV, FileToImport)

    End Sub

    Public Function GetImportPath() As String

        Dim FilePath As String = Nothing

        Dim OpenFileDialogImport As OpenFileDialog = New OpenFileDialog With {
            .Title = "Import a CSV File",
            .Filter = "Comma Delimited|*.csv|All Files|*.*"
        }

        OpenFileDialogImport.ShowDialog()

        Dim ImportedPath As String = OpenFileDialogImport.FileName

        If String.IsNullOrEmpty(ImportedPath) Then
            Return Nothing
        End If

        Try
            If IO.File.Exists(OpenFileDialogImport.FileName) Then
                If Not FileInUse(OpenFileDialogImport.FileName) Then

                    FilePath = OpenFileDialogImport.FileName

                    RecentFiles.SaveRecentFile(OpenFileDialogImport.FileName)

                Else

                    Dim AlertForm As New FormAlert("Unable to open file as it is being used by another process", AlertType.Warning)
                    AlertForm.ShowDialog()
                End If
            End If
        Catch Ex As Exception
            Logger.Log("[Error] " & Ex.Message)
        End Try

        ImportForm.MainTabControl.SelectTab(ImportForm.MainTabControl.TabPages.IndexOf(ImportForm.WelcomeTab))

        Return FilePath

    End Function

    Public Overrides Sub Cancel()
        MyBase.Cancel()

        If ImportWorker IsNot Nothing Then
            ImportWorker.AbortTask()
        End If

        If ImportForm Is Nothing Then
            Exit Sub
        End If

        If ImportForm.IsClosing Then
            ImportForm.Close()
        End If

    End Sub

    Private Sub ImportCSV(ByVal stateInfo As Object)

        Dim Datatable As New DataTable
        Dim FirstLine As Boolean = True
        Dim FirstRow As String() = {}

        Dim ImportFile As String = CStr(stateInfo)

        Dim UPNSuffix As String = "@" & GetLocalDomainName()

        Try

            Using StreamReader As New IO.StreamReader(ImportFile, True)

                ''Logger.Log(String.Format("[Debug] File '{0}' Encoding {1}", ImportFile, StreamReader.CurrentEncoding.EncodingName))

                While Not StreamReader.EndOfStream

                    If FirstLine Then
                        FirstLine = False

                        Dim Cols As String() = StreamReader.ReadLine.Split(","c)
                        FirstRow = Cols

                        If Not FirstRow.Contains("sAMAccountName") Then
                            ImportErrorForm.Add("Missing Property Exception", "The Imported File contains no 'Username' Column")
                        End If
                        If Not FirstRow.Contains("password") Then
                            ImportErrorForm.Add("Missing Property Alert", "The Imported File contains no 'Password' Column, Account with no password will be disabled upon creation")
                        End If
                        If Not FirstRow.Contains("name") Then
                            ImportErrorForm.Add("Missing Property Alert", "The Imported File contains no 'Name' Column")
                        End If
                        For Each col As String In Cols
                            Datatable.Columns.Add(New DataColumn(col, GetType(String)))
                        Next
                    Else
                        Dim data() As String = StreamReader.ReadLine.Split(","c)
                        Datatable.Rows.Add(data.ToArray)
                    End If
                End While

            End Using

        Catch Ex As Exception

            ImportFailed(Ex.Message)

        End Try

        If Datatable.Rows.Count = 0 Then
            ImportFailed("Simple AD was unable to parse the user data from the supplied file")
            Exit Sub
        End If

        Users.Clear()

        For i as Integer = 0 to Datatable.Rows.Count - 1

            Dim Row As DataRow = Datatable.Rows(i)

            Dim NewUserObject As New SimpleADBulkUserDomainObject With {
                .Type = "user",
                .TypeFriendly = "User"
            }

            If Datatable.Columns.Contains("name") Then
                NewUserObject.Name = CleanInput(Row.Item("name").ToString)
            End If
            If Datatable.Columns.Contains("sAMAccountName") Then
                NewUserObject.SAMAccountName = CleanInput(Row.Item("sAMAccountName").ToString)
            End If
            If Datatable.Columns.Contains("displayName") Then
                NewUserObject.DisplayName = Row.Item("displayName").ToString
            End If
            If Datatable.Columns.Contains("description") Then
                NewUserObject.Description = CleanInput(Row.Item("description").ToString)
            End If
            If Datatable.Columns.Contains("givenName") Then
                NewUserObject.GivenName = CleanInput(Row.Item("givenName").ToString)
            End If
            If Datatable.Columns.Contains("sn") Then
                NewUserObject.Sn = CleanInput(Row.Item("sn").ToString)
            End If

            If Datatable.Columns.Contains("homeDirectory") Then

                Dim HomeDir = Row.Item("homeDirectory").ToString

                NewUserObject.HomeDirectory = HomeDir
                ValidateHomeDir(NewUserObject, HomeDir)

            End If

            If Datatable.Columns.Contains("homeDrive") Then
                Dim HomeDrive = Row.Item("homeDrive").ToString

                NewUserObject.HomeDrive = HomeDrive
                ValidateHomeDrive(NewUserObject, HomeDrive)
            End If
            If Datatable.Columns.Contains("pager") Then
                NewUserObject.Pager = Row.Item("pager").ToString
            End If
            If Datatable.Columns.Contains("scriptPath") Then
                NewUserObject.ScriptPath = Row.Item("scriptPath").ToString
            End If

            If Datatable.Columns.Contains("password") Then
                NewUserObject.Password = Row.Item("password").ToString

                If String.IsNullOrWhiteSpace(NewUserObject.Password) Then
                    ImportErrorForm.Add("Password not Specified",
                               String.Format("No Password has been specified for user {0}. The account cannot be enabled without a password",
                                             If(String.IsNullOrEmpty(NewUserObject.Name),
                                             NewUserObject.SAMAccountName,
                                             NewUserObject.Name)))
                End If
            End If

            If Datatable.Columns.Contains("mail") Then
                NewUserObject.Mail = Row.Item("mail").ToString
            End If
            If Datatable.Columns.Contains("profilePath") Then
                NewUserObject.ProfilePath = Row.Item("profilePath").ToString
            End If
            If Datatable.Columns.Contains("tsProfilePath") Then
                NewUserObject.TsProfilePath = Row.Item("tsProfilePath").ToString
            End If
            If Datatable.Columns.Contains("physicalDeliveryOfficeName") Then
                NewUserObject.Office = Row.Item("physicalDeliveryOfficeName").ToString
            End If
            If Datatable.Columns.Contains("department") Then
                NewUserObject.Department = Row.Item("department").ToString
            End If
            If Datatable.Columns.Contains("company") Then
                NewUserObject.Company = Row.Item("company").ToString
            End If
            If Datatable.Columns.Contains("manager") Then
                NewUserObject.Manager = Row.Item("manager").ToString
            End If
            If Datatable.Columns.Contains("title") Then
                NewUserObject.Title = Row.Item("title").ToString
            End If
            If Datatable.Columns.Contains("telephoneNumber") Then
                NewUserObject.TelephoneNumber = Row.Item("telephoneNumber").ToString
            End If
            If Datatable.Columns.Contains("wWWHomePage") Then
                NewUserObject.WWWHomePage = Row.Item("wWWHomePage").ToString
            End If

            NewUserObject.UserPrincipalName = NewUserObject.SAMAccountName & UPNSuffix

            If NewUserObject.Name Is Nothing AndAlso Not NewUserObject.DisplayName Is Nothing Then
                NewUserObject.Name = NewUserObject.DisplayName
            ElseIf Not NewUserObject.SAMAccountName Is Nothing Then
                NewUserObject.Name = NewUserObject.SAMAccountName
            End If

            Users.Add(NewUserObject)
        Next

        If ImportErrorForm.Errors.Count > 0 Then
            If GetContainerExplorer.InvokeRequired Then
                GetContainerExplorer.Invoke(New Delegate_ImportError(AddressOf InvalidImport))
            End If
        End If

        Datatable.Dispose()
        TaskProgressMax = Users.Count

        ImportForm.Invoke(Sub() ImportForm.SetObjects())

    End Sub

    Private Sub InvalidImport()
        If ImportErrorForm Is Nothing Then
            Exit Sub
        End If

        ImportErrorForm.ShowDialog()

        If ImportErrorForm.DialogResult = DialogResult.Ignore Then
            Exit Sub
        End If

        If ImportErrorForm.DialogResult = DialogResult.Retry Then

            Dim ImportTask = New TaskBulkImport(Nothing, ImportForm)
            ImportForm.ImportTask = ImportTask

            ImportTask.BeginImport()
        End If

    End Sub

    Private Sub ADImportStarted() Handles ImportForm.BeginImport

        CreateHomeFolders = ImportForm.CreateHomeFolders
        EnableAccounts = ImportForm.EnableAccounts
        ForcePasswordReset = ImportForm.ForcePasswordReset

        ImportWorker = New BulkADWorker(MainListView, Me, ImportForm.Path)
    End Sub

    Private Sub ADImportFinished() Handles ImportWorker.BulkImportCompleted
        RaiseEvent ImportCompleted()
    End Sub

    Private Sub ADImportStatuschanged(ByVal Message As String) Handles ImportWorker.BulkImportStatusChanged
        StatusMessage = Message
    End Sub

    Private Sub ImportFailed(ByVal ErrorMessage As String)
        If GetContainerExplorer.InvokeRequired Then
            GetContainerExplorer.Invoke(New Action(Of String)(AddressOf ImportFailed), ErrorMessage)
        Else

            If ImportForm IsNot Nothing Then
                ImportForm.Close()
            End If

            Dim ImportFailedForm = New FormAlert("Import Failed - " & ErrorMessage, AlertType.ErrorAlert)
            ImportFailedForm.StartPosition = FormStartPosition.CenterScreen
            ImportFailedForm.ShowDialog()
        End If
    End Sub

    Public Sub ValidateHomeDir(ByVal NewUserObject As SimpleADBulkUserDomainObject, ByVal HomeDir As String)

        If String.IsNullOrWhiteSpace(HomeDir) Then
            ImportErrorForm.Add("Path Not Specified",
                                String.Format("No Home Directory Path was Specified for user {0}",
                                              If(String.IsNullOrEmpty(NewUserObject.Name),
                                              NewUserObject.SAMAccountName,
                                              NewUserObject.Name)))
            Exit Sub
        End If

        If HomeDir.Contains(IO.Path.GetInvalidPathChars) Then
            ImportErrorForm.Add("Invalid Path",
                                String.Format("The home directory path ppecified for user {0} is invalid. Path specified: {1}",
                                              If(String.IsNullOrEmpty(NewUserObject.Name),
                                              NewUserObject.SAMAccountName,
                                              NewUserObject.Name),
                                              HomeDir))
        End If

    End Sub

    Public Sub ValidateHomeDrive(ByVal NewUserObject As SimpleADBulkUserDomainObject, ByVal HomeDrive As String)

        If String.IsNullOrWhiteSpace(HomeDrive) Then
            ImportErrorForm.Add("Drive Letter Not Specified",
                                String.Format("No drive letter was Specified for user {0}",
                                              If(String.IsNullOrEmpty(NewUserObject.Name),
                                              NewUserObject.SAMAccountName,
                                              NewUserObject.Name)))
            Exit Sub
        End If

        If EnvironmentHelper.ValidDriveLetters.Contains(HomeDrive.Trim()) Then
            Exit Sub
        End If

        ImportErrorForm.Add("Invalid Drive Letter",
                                String.Format("The home drive letter specified for user {0} is invalid. Letter specified: {1}",
                                              If(String.IsNullOrEmpty(NewUserObject.Name),
                                              NewUserObject.SAMAccountName,
                                              NewUserObject.Name),
                                              HomeDrive))

    End Sub

End Class