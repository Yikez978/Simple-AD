Public Class JobUserBulk
    Inherits SimpleADJob

    Dim ErForm As New FormImportValidation

    Private File As String
    Private DisplayNamebool As Boolean
    Private NewImportJobContainer As ContainerUserBulk
    Private TabPage As TabPage
    Private MainListView As ObjectListView

    Public ForcePasswordReset As Boolean
    Public CreateHomeFodlers As Boolean
    Public EnableAccounts As Boolean

    Private ImportThread As New Threading.Thread(AddressOf ImportCSV)

    Public Sub New(ByVal ImportFile As String)

        NewImportJobContainer = New ContainerUserBulk(1, "User Import - " & GetFileNameShort(ImportFile), Me)

        TabPage = New TabPage
        With TabPage
            .Name = NewImportJobContainer.JobName
            .Text = NewImportJobContainer.JobName
            .Visible = True
            .BackColor = Color.FromArgb(124, 65, 153)
            .ForeColor = SystemColors.ControlText
            .Controls.Add(NewImportJobContainer)
        End With

        GetMainTabCtrl().TabPages.Add(TabPage)
        GetMainTabCtrl().SelectTab(GetMainTabCtrl().TabCount - 1)
        MainListView = NewImportJobContainer.MainListView

        ImportThread.IsBackground = True
        ImportThread.Start(ImportFile)
    End Sub

    Private Sub ImportCSV(ByVal ImportFile As String)

        Dim Datatable As New DataTable
        Dim FirstLine As Boolean = True
        Dim FirstRow As String() = {}

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
                            ErForm.Add("Missing Property Exception", "The Imported File contains no 'Password' Column")
                        End If
                        If Not FirstRow.Contains("name") Then
                            ErForm.Add("Missing Property Exception", "The Imported File contains no 'Name' Column")
                        End If
                        If FirstRow.Contains("displayName") Then
                            DisplayNamebool = True
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


        Dim NewUserObjectList = New List(Of UserDomainObject)

        For Each Row As DataRow In Datatable.Rows
            Dim NewUserObject As New UserDomainObject

            NewUserObject.Type = "user"
            NewUserObject.TypeFriendly = "User"

            If Datatable.Columns.Contains("name") Then
                NewUserObject.Name = Row.Item("name")
            End If
            If Datatable.Columns.Contains("sAMAccountName") Then
                NewUserObject.SAMAccountName = Row.Item("sAMAccountName")
            End If
            If Datatable.Columns.Contains("displayName") Then
                NewUserObject.DisplayName = Row.Item("displayName")
            End If
            If Datatable.Columns.Contains("description") Then
                NewUserObject.Description = Row.Item("description")
            End If
            If Datatable.Columns.Contains("givenName") Then
                NewUserObject.GivenName = Row.Item("givenName")
            End If
            If Datatable.Columns.Contains("sn") Then
                NewUserObject.Sn = Row.Item("sn")
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

            NewUserObjectList.Add(NewUserObject)
        Next

        MainListView.SetObjects(NewUserObjectList)
        MsgBox("MainListViewCount: " & MainListView.Items.Count)
    End Sub

    Private Sub ImportFailed(ByVal ErrorMessage As String)
        If NewImportJobContainer.InvokeRequired Then
            NewImportJobContainer.Invoke(New Action(Of String)(AddressOf ImportFailed), ErrorMessage)
        Else

        End If

    End Sub

End Class