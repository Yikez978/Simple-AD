Imports SimpleLib
Imports System.Runtime.Serialization
Imports System.Security.Permissions

<Serializable()>
Public Class JobImport
    Inherits SimpleADJob
    Implements ISerializable

    Dim ErForm As New FormImportValidation

#Region "Properties"

    Private JobFile As String
    Private DisplayNamebool As Boolean
    Private NewImportJobContainer As ContainerImport
    Private TabPage As TabPage
    Private MainListView As ObjectListView

    Public ForcePasswordReset As Boolean
    Public CreateHomeFodlers As Boolean
    Public EnableAccounts As Boolean

    Public Property FileName As String

    Public Property Users As New List(Of SimpleADBulkUserDomainObject)

#End Region

    Public Sub New(ByVal ImportFile As String)
        MyBase.New

        JobFile = ImportFile
        JobType = SimpleADJobType.UserImport
        JobName = ImportFile.Split(New Char() {"\"})(ImportFile.Split(New Char() {"\"}).Count - 1)
        FileName = JobName

        Dim FullName As String() = ImportFile.Split(New Char() {"\"})

        MainListView = GetContainerImport.MainListView

        GetMainTabCtrl.SelectTab(GetMainTabCtrl.TabPages("ImportTab"))

        Threading.ThreadPool.QueueUserWorkItem(AddressOf ImportCSV, ImportFile)
    End Sub

    Private Sub ImportCSV(ByVal stateInfo As Object)

        Dim Datatable As New DataTable
        Dim FirstLine As Boolean = True
        Dim FirstRow As String() = {}

        Dim ImportFile = CStr(stateInfo)

        Try
            Using StreamReader As New IO.StreamReader(ImportFile)
                While Not StreamReader.EndOfStream
                    If FirstLine Then
                        FirstLine = False
                        Dim Cols = StreamReader.ReadLine.Split(",")
                        FirstRow = Cols

                        If Not FirstRow.Contains("sAMAccountName") Then
                            ErForm.Add("Missing Property Exception", "The Imported File contains no 'Username' Column")
                        End If
                        If Not FirstRow.Contains("password") Then
                            ErForm.Add("Missing Property Exception", "The Imported File contains no 'Password' Column, Account with no password will be disabled upon creation")
                        End If
                        If Not FirstRow.Contains("name") Then
                            ErForm.Add("Missing Property Exception", "The Imported File contains no 'Name' Column")
                        End If
                        If ErForm.Errors.Count > 0 Then
                            ImportContainerHandle.Invoke(New Action(Sub() ErForm.ShowDialog()))
                        End If

                        For Each col In Cols
                            Datatable.Columns.Add(New DataColumn(col, GetType(String)))
                        Next
                    Else
                        Dim data() As String = StreamReader.ReadLine.Split(",")
                        Datatable.Rows.Add(data.ToArray)
                    End If
                End While
                StreamReader.Close()
            End Using
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.Message)
            ImportFailed(Ex.Message)
        End Try

        For Each Row As DataRow In Datatable.Rows
            Dim NewUserObject As New SimpleADBulkUserDomainObject With {
                .Type = "user",
                .TypeFriendly = "User"
            }

            If Datatable.Columns.Contains("name") Then
                NewUserObject.Name = CleanInput(Row.Item("name"))
            End If
            If Datatable.Columns.Contains("sAMAccountName") Then
                NewUserObject.SAMAccountName = CleanInput(Row.Item("sAMAccountName"))
            End If
            If Datatable.Columns.Contains("displayName") Then
                NewUserObject.DisplayName = Row.Item("displayName")
            End If
            If Datatable.Columns.Contains("description") Then
                NewUserObject.Description = CleanInput(Row.Item("description"))
            End If
            If Datatable.Columns.Contains("givenName") Then
                NewUserObject.GivenName = CleanInput(Row.Item("givenName"))
            End If
            If Datatable.Columns.Contains("sn") Then
                NewUserObject.Sn = CleanInput(Row.Item("sn"))
            End If
            If Datatable.Columns.Contains("homeDirectory") Then
                NewUserObject.HomeDirectory = Row.Item("homeDirectory")
            End If
            If Datatable.Columns.Contains("homeDrive") Then
                NewUserObject.HomeDrive = Row.Item("homeDrive")
            End If
            If Datatable.Columns.Contains("pager") Then
                NewUserObject.Pager = Row.Item("pager")
            End If
            If Datatable.Columns.Contains("scriptPath") Then
                NewUserObject.ScriptPath = Row.Item("scriptPath")
            End If
            If Datatable.Columns.Contains("password") Then
                NewUserObject.Password = Row.Item("password")
            End If
            If Datatable.Columns.Contains("mail") Then
                NewUserObject.Mail = Row.Item("mail")
            End If
            If Datatable.Columns.Contains("profilePath") Then
                NewUserObject.ProfilePath = Row.Item("profilePath")
            End If
            If Datatable.Columns.Contains("tsProfilePath") Then
                NewUserObject.TsProfilePath = Row.Item("tsProfilePath")
            End If
            If Datatable.Columns.Contains("physicalDeliveryOfficeName") Then
                NewUserObject.Office = Row.Item("physicalDeliveryOfficeName")
            End If
            If Datatable.Columns.Contains("department") Then
                NewUserObject.Department = Row.Item("department")
            End If
            If Datatable.Columns.Contains("company") Then
                NewUserObject.Company = Row.Item("company")
            End If
            If Datatable.Columns.Contains("manager") Then
                NewUserObject.Manager = Row.Item("manager")
            End If
            If Datatable.Columns.Contains("title") Then
                NewUserObject.Title = Row.Item("title")
            End If
            If Datatable.Columns.Contains("telephoneNumber") Then
                NewUserObject.TelephoneNumber = Row.Item("telephoneNumber")
            End If
            If Datatable.Columns.Contains("wWWHomePage") Then
                NewUserObject.WWWHomePage = Row.Item("wWWHomePage")
            End If

            'Insert Name property if not supplied with csv
            If NewUserObject.Name Is Nothing AndAlso Not NewUserObject.DisplayName Is Nothing Then
                NewUserObject.Name = NewUserObject.DisplayName
            End If

            NewUserObject.Status = "Pending"
            Users.Add(NewUserObject)
        Next
        Datatable.Dispose()
        ImportFinished()
    End Sub

    Private Sub ImportFinished()
        If GetContainerImport.InvokeRequired Then
            GetContainerImport.Invoke(New Action(AddressOf ImportFinished))
        Else
            JobProgressMax = Users.Count
            NewTask(Me)
        End If
    End Sub

    Private Sub ImportFailed(ByVal ErrorMessage As String)
        If NewImportJobContainer.InvokeRequired Then
            NewImportJobContainer.Invoke(New Action(Of String)(AddressOf ImportFailed), ErrorMessage)
        Else
            Dim ImportFailedForm = New FormAlert("Import Failed - " & ErrorMessage, AlertType.ErrorAlert)
            ImportFailedForm.StartPosition = FormStartPosition.CenterScreen
            ImportFailedForm.ShowDialog()
        End If
    End Sub

#Region "Serialisation"
    Protected Sub New(info As SerializationInfo, context As StreamingContext)
        JobName = info.GetString("JobName")
        JobType = DirectCast([Enum].Parse(GetType(SimpleADJobType), info.GetString("JobType")), SimpleADJobType)
        JobOwner = info.GetString("JobOwner")
        JobCreated = info.GetDateTime("JobCreated")
        JobDescription = info.GetString("JobDescription")
        JobStatus = DirectCast([Enum].Parse(GetType(SimpleADJobStatus), info.GetString("JobStatus")), SimpleADJobStatus)
        JobProgress = info.GetInt32("JobProgress")
        JobProgressMax = info.GetInt32("JobProgressMax")

        FileName = info.GetString("FileName")
        JobFile = info.GetString("JobFile")
        'Users = info.GetValue("Users", GetType(List(Of SimpleADBulkUserDomainObject)))

        ForcePasswordReset = info.GetBoolean("ForcePasswordReset")
        CreateHomeFodlers = info.GetBoolean("CreateHomeFodlers")
        EnableAccounts = info.GetBoolean("EnableAccounts")
    End Sub

    <SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter:=True)>
    Public Overrides Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        info.AddValue("JobName", JobName)
        info.AddValue("JobType", JobType.ToString)
        info.AddValue("JobOwner", JobOwner)
        info.AddValue("JobCreated", JobCreated)
        info.AddValue("JobDescription", JobDescription)
        info.AddValue("JobStatus", JobStatus.ToString)
        info.AddValue("JobProgress", JobProgress)
        info.AddValue("JobProgressMax", JobProgressMax)

        info.AddValue("JobFile", JobFile)
        info.AddValue("FileName", FileName)
        'info.AddValue("Users", Users)

        info.AddValue("ForcePasswordReset", ForcePasswordReset)
        info.AddValue("CreateHomeFodlers", CreateHomeFodlers)
        info.AddValue("EnableAccounts", EnableAccounts)
    End Sub
#End Region

End Class