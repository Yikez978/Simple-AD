Imports System.DirectoryServices

Public Class JobExplorer
    Inherits SimpleADJob

    Private MainListView As ControlListView
    Private MainTreeView As ControlDomainTreeView

    Private UserReportContainer As ContainerExplorer
    Private FindObjectsThread As Threading.Thread

    Private _Path As String
    Private _LDAPQuery As String
    Private _Type As ReportType

    Public Class Jobparameters
        Property Type As ReportType
        Property Filter As String
        Property Entry As String
    End Class

    Public Sub New(ByVal Type As ReportType, Optional LDAPQuery As String = Nothing)
        MyBase.New(SimpleADJobType.Explorer, GetDomainNetBiosName)

        _Type = Type

        GetContainerExplorer.Job = Me
        MainListView = GetContainerExplorer.MainListView
        MainTreeView = GetContainerExplorer.DomainTreeView

        GetMainTabCtrl.SelectTab(GetMainTabCtrl.TabPages("ExplorerTab"))

        If LDAPQuery IsNot Nothing Then
            _LDAPQuery = LDAPQuery
        End If

        Refresh()
    End Sub

    Public Sub Refresh(Optional Path As String = Nothing, Optional JobType As ReportType = Nothing)

        If Not JobType = Nothing Then
            _Type = JobType
        End If

        Dim paras As New Jobparameters With {
        .Type = _Type
        }

        Select Case paras.Type
            Case ReportType.AllAdmins
                paras.Filter = "(memberOf:1.2.840.113556.1.4.1941:=cn=Administrators,cn=Builtin," & GetFQDN() & ")"
            Case ReportType.DisabledUsers
                paras.Filter = "(&(objectCategory=person)(objectClass=user)(userAccountControl:1.2.840.113556.1.4.803:=2))"
            Case ReportType.CustomLDAP
                paras.Filter = _LDAPQuery
            Case ReportType.AllObjects
                paras.Filter = "(objectClass=*)"
            Case ReportType.Explorer
                If Not String.IsNullOrEmpty(Path) Then
                    paras.Entry = Path
                    _Path = Path
                Else
                    paras.Entry = _Path
                End If
        End Select

        MainListView.BeginUpdate()
        Threading.ThreadPool.QueueUserWorkItem(Sub() GetObjects(paras))

    End Sub

    Private Sub GetObjects(ByVal Param As Jobparameters)
        Try

            Dim Type As ReportType = Param.Type
            Dim Filter As String = Param.Filter
            Dim EntryPath As String = Param.Entry

            Dim Entry As DirectoryEntry = GetDirEntry(Param.Entry)

            Dim DirSearcher As DirectorySearcher = New DirectorySearcher(GetDirEntryPath)

            With DirSearcher
                .SearchRoot = Entry
                .Filter = Param.Filter
                Select Case Type
                    Case ReportType.Explorer
                        .SearchScope = SearchScope.OneLevel
                    Case Else
                        .SearchScope = SearchScope.Subtree
                End Select
            End With

            DirSearcher.PropertiesToLoad.AddRange(LDAPPropsShort)

            Dim results As SearchResultCollection = DirSearcher.FindAll()

            Dim DomainObjectList = New List(Of DomainObject)

            For Each result As SearchResult In results
                If result.Properties("name").Count > 0 Then

                    Dim DomainObject As DomainObject

                    If result.Properties.Item("objectClass").Count > 0 Then

                        Dim ObjectType As String = result.Properties.Item("objectClass").Item(result.Properties.Item("objectClass").Count - 1)
                        Select Case ObjectType
                            Case "user"
                                DomainObject = New UserDomainObject
                            Case Else
                                DomainObject = New DomainObject
                        End Select

                        Dim TypeStringBuilder As New StringBuilder

                        For Each Item As Object In result.Properties.Item("objectClass")
                            TypeStringBuilder.AppendLine(CStr(Item) & ";")
                        Next
                        DomainObject.TypeFull = TypeStringBuilder.ToString


                        DomainObject.Type = ObjectType
                        DomainObject.TypeFriendly = GetFriendlyTypeName(ObjectType)

                        DomainObject.Name = (CStr(result.Properties("name").Item(0)))

                        If result.Properties("sAMAccountName").Count > 0 Then
                            DomainObject.SAMAccountName = result.Properties("sAMAccountName").Item(0)
                        Else
                            DomainObject.SAMAccountName = Nothing
                        End If

                        If result.Properties("distinguishedName").Count > 0 Then
                            DomainObject.DistinguishedName = result.Properties("distinguishedName").Item(0)
                        End If

                        If result.Properties("description").Count > 0 Then
                            DomainObject.Description = result.Properties.Item("description").Item(0)
                        End If

                        If result.Properties("userAccountControl").Count > 0 Then
                            DomainObject.UserAccountControl = result.Properties.Item("userAccountControl").Item(0)
                        End If

                        If result.Properties("isCriticalSystemObject").Count > 0 Then
                            DomainObject.IsCriticalSystemObject = result.Properties.Item("isCriticalSystemObject").Item(0)
                        End If

                        If result.Properties("showInAdvancedViewOnly").Count > 0 Then
                            DomainObject.ShowInAdvancedViewOnly = result.Properties.Item("showInAdvancedViewOnly").Item(0)
                        End If

                        DomainObjectList.Add(DomainObject)
                    End If
                End If
            Next

            MainListView.Invoke(New Action(Of List(Of DomainObject))(AddressOf AfterFindObjects), DomainObjectList)

        Catch ArgEx As ArgumentException
            ReportError(ArgEx)
            Debug.WriteLine("[Error] " & ArgEx.GetBaseException.ToString & ArgEx.Message)
        Catch Ex As Exception
            Debug.WriteLine("[Error] " & Ex.GetBaseException.ToString & Ex.Message)
            ReportError(Ex)
        End Try
    End Sub

    Private Sub AfterFindObjects(ByVal DomainObjectList As List(Of DomainObject))
        MainListView.SetObjects(DomainObjectList)
        MainListView.EndUpdate()
    End Sub

    Private Sub ReportError(ByVal ErrorMessage As Exception)
        If Not UserReportContainer Is Nothing Then
            If UserReportContainer.InvokeRequired Then
                UserReportContainer.Invoke(New Action(Of Exception)(AddressOf ReportError), ErrorMessage)
            Else
                Debug.WriteLine("[Error] " & ErrorMessage.Message)
                Debug.WriteLine("[Error] " & ErrorMessage.StackTrace.ToString)
            End If
        End If
    End Sub

End Class