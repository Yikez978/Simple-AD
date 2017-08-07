Imports System.DirectoryServices
Imports System.ComponentModel
Imports System.Security.AccessControl
Imports System.DirectoryServices.Protocols
Imports TSUSEREXLib
Imports System.Net

Public Class BulkADWorker

    Private _BulkUserContainer As ContainerUserBulk
    Private _SourceGrid As DataGridView
    Private bw As BackgroundWorker = New BackgroundWorker

    Private Name
    Private Password
    Private TsProfilePath
    Private Description
    Private Pager
    Private HomeDirectory
    Private HomeDrive
    Private Username
    Private DisplayName
    Private ScriptPath
    Private FirstName
    Private Surname
    Private _UPNS

    Public Sub New(SourceGrid As DataGridView, bulkUserContainer As ContainerUserBulk)
        _SourceGrid = SourceGrid
        _BulkUserContainer = bulkUserContainer

        _BulkUserContainer.GetProgressBar.Maximum = _SourceGrid.Rows.Count
        _BulkUserContainer.GetProgressBar.Step = 1

        _UPNS = GetUPNSuffix(0)

    End Sub

    Public Sub RunBulkUserSetup()

        With bw
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With

        AddHandler bw.DoWork, AddressOf Bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf Bw_RunWorkerCompleted

        If Not (bw.IsBusy) Then
            bw.RunWorkerAsync()
        End If
        bw.Dispose()

        _BulkUserContainer.GetSpinner().Visible = True
        _BulkUserContainer.GetSpinner().Spinning = True

    End Sub

    Private Sub Bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        Debug.WriteLine("[Info] BulkADWorkers Class Main Worker Initiated")

        Dim autoMainDataGrid As DataGridView = GetMainDataGrid(_SourceGrid)

        Dim objADAM As DirectoryEntry       ' Binding object.
        'Dim objUser As DirectoryEntry       ' User object.
        Dim strPath As String               ' Binding path.
        Dim strUser As String               ' User to create.
        Dim strUserPrincipalName As String  ' Principal name of user.



        ' Construct the binding string.       
        If String.IsNullOrEmpty(GlobalVariables.LoginUsernamePrefix) Then
            strPath = "LDAP://" & GlobalVariables.SelectedOU
        Else
            strPath = "LDAP://" & GlobalVariables.LoginUsernamePrefix & ":389/" & GlobalVariables.SelectedOU
        End If

        Debug.WriteLine("[LDAP] Bind to: " & strPath)

        ' Get AD LDS object.

        objADAM = New DirectoryEntry(strPath, GlobalVariables.LoginUsername, GlobalVariables.LoginPassword, AuthenticationTypes.Secure)

        Try
            objADAM.RefreshCache()

            'Main User Creation Loop
            For i As Integer = 0 To autoMainDataGrid.RowCount - 2

                If sender.CancellationPending = True Then
                    e.Cancel = True
                    Exit For
                End If

                Dim row As DataGridViewRow = autoMainDataGrid.Rows(i)

                If row.Cells("Name").Value IsNot Nothing Then
                    Name = row.Cells("Name").Value.ToString
                End If

                If row.Cells("FirstName").Value IsNot Nothing Then
                    FirstName = row.Cells("FirstName").Value.ToString
                End If

                If row.Cells("Surname").Value IsNot Nothing Then
                    Surname = row.Cells("Surname").Value.ToString
                End If

                If row.Cells("DisplayName").Value IsNot Nothing Then
                    DisplayName = row.Cells("DisplayName").Value.ToString
                End If

                If row.Cells("Username").Value IsNot Nothing Then
                    Username = row.Cells("Username").Value.ToString
                End If

                If row.Cells("ScriptPath").Value IsNot Nothing Then
                    ScriptPath = row.Cells("ScriptPath").Value.ToString
                End If

                If row.Cells("HomeDrive").Value IsNot Nothing Then
                    HomeDrive = row.Cells("HomeDrive").Value.ToString
                End If

                If row.Cells("HomeDirectory").Value IsNot Nothing Then
                    HomeDirectory = row.Cells("HomeDirectory").Value.ToString
                End If

                If row.Cells("Pager").Value IsNot Nothing Then
                    Pager = row.Cells("Pager").Value.ToString
                End If

                If row.Cells("Description").Value IsNot Nothing Then
                    Description = row.Cells("Description").Value.ToString
                End If

                If row.Cells("TsProfilePath").Value IsNot Nothing Then
                    TsProfilePath = row.Cells("TsProfilePath").Value.ToString
                End If

                If row.Cells("Password").Value IsNot Nothing Then
                    Password = row.Cells("Password").Value.ToString
                End If


                ' Specify User.
                strUser = "CN=" & Name
                strUserPrincipalName = Username & "@" & _UPNS
                Debug.WriteLine("[Info] Create: " & strUser)

                ' Create User.
                Try

                    Dim objUser As DirectoryEntry = objADAM.Children.Add(strUser, "user")

                    If Not objUser Is Nothing Then

                        objUser.Properties.Item("SamAccountName").Add(Username)
                        objUser.Properties("userPrincipalName").Add(strUserPrincipalName)
                        objUser.Properties("displayName").Add(DisplayName)
                        objUser.Properties.Item("givenName").Add(FirstName)
                        objUser.Properties.Item("sn").Add(Surname)

                        objUser.CommitChanges()

                        If GlobalVariables.ForcePwdReset = True Then
                            objUser.Properties("pwdLastSet").Value = 0
                        End If
                        objUser.CommitChanges()

                        objUser.Properties("scriptPath").Value = ScriptPath
                        objUser.Properties.Item("description").Value = Description
                        objUser.CommitChanges()

                        'Setting TSProfilePath
                        Dim oUser As ADsTSUserEx = CType(objUser.NativeObject, ADsTSUserEx)
                        oUser.AllowLogon = 1
                        oUser.TerminalServicesProfilePath = TsProfilePath

                        'Set Password
                        objUser.Invoke("SetPassword", New Object() {Password})
                        objUser.CommitChanges()

                        'Enable account
                        If GlobalVariables.EnableNewAccounts = True Then
                            Dim val As Integer = objUser.Properties("userAccountControl").Value
                            objUser.Properties("userAccountControl").Value = val And Not &H2
                        End If
                        objUser.CommitChanges()

                        'Setting up folder

                        If (GlobalVariables.CreateHomeFolders) Then
                            If Not String.IsNullOrEmpty(HomeDirectory) Then

                                Try
                                    objUser.Properties("homeDirectory").Value = HomeDirectory
                                    objUser.Properties("homeDrive").Value = HomeDrive
                                    objUser.CommitChanges()

                                    IO.Directory.CreateDirectory(HomeDirectory)
                                Catch Ex As Exception
                                    Debug.WriteLine("[Error] Error While Creating Home folder for user: " & Username)
                                    Debug.WriteLine("[Error] " & Ex.Message)
                                End Try

                                If IO.Directory.Exists(HomeDirectory) Then
                                    Try
                                        Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(HomeDirectory)
                                        Dim FolderAcl As New DirectorySecurity

                                        FolderAcl.AddAccessRule(New FileSystemAccessRule(CStr(GetLocalDomainName() & "\" & Username), FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
                                        FolderInfo.SetAccessControl(FolderAcl)
                                    Catch Ex As Exception
                                        Debug.WriteLine("[Error] Error While Setting permisions on Home folder for user " & Username)
                                        Debug.WriteLine("[Error] " & Ex.Message)
                                    End Try
                                End If

                            Else
                                Debug.WriteLine("[Info] Folder Already Exists in location: " & HomeDirectory)
                                Debug.WriteLine("[Info] Home Folder Creation for user " & Username & " Has been skipped!")
                            End If
                        End If

                        Debug.WriteLine("[Info] Success: Create succeeded.")
                        Debug.WriteLine("[Info] Name: ", objUser.Name)

                        Dim argArray As Array = {row.Index}
                        sender.ReportProgress(0, argArray)

                    End If

                    objUser.Close()

                Catch exc As Exception

                    Dim ErrorMsgCon = "Unable to Create User: " & Username & " - " & exc.Message

                    Dim argArray As Array = {row.Index, ErrorMsgCon, exc.Message}

                    Debug.WriteLine("[Error] Unable to Create User: " & Username)
                    Debug.WriteLine("[Error] " & exc.Message)

                    sender.ReportProgress(1, argArray)

                End Try

            Next


            objADAM.Close()

        Catch bindError As Exception
            Debug.WriteLine("[Error] Bind failed.")
            Debug.WriteLine("[LDAP] " & bindError.Message)
        End Try

    End Sub

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)

        'User creation Succeded
        If e.ProgressPercentage = 0 Then

            With DirectCast(_SourceGrid.Rows.Item(e.UserState(0)).Cells("Status"), TextAndImageCell)
                .Image = New Bitmap(ConvertToGrayScale(My.Resources.appbar_check), 16, 16)
                .Value = "User Created Succesfully"
                .ReadOnly = True
            End With

            With DirectCast(_SourceGrid.Rows.Item(e.UserState(0)).Cells("Name"), TextAndImageCell)
                .Image = GlobalVariables.IconUser
            End With

            _SourceGrid.Rows.Item(e.UserState(0)).DefaultCellStyle.ForeColor = SystemColors.ControlText

        End If

        'User Creation failed
        If e.ProgressPercentage = 1 Then

            If e.UserState(0) < _SourceGrid.Rows.Count Then
                With DirectCast(_SourceGrid.Rows.Item(e.UserState(0)).Cells("Status"), TextAndImageCell)
                    .Image = New Bitmap(My.Resources.ErrorAlt, 16, 16)
                    .Value = CStr(e.UserState(2))
                    .ToolTipText = CStr(e.UserState(2))
                    .ReadOnly = True
                End With

            End If
        End If
        _BulkUserContainer.GetProgressBar.PerformStep()
    End Sub

    Private Sub Bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        _BulkUserContainer.ProgressBar.Visible = False
        _BulkUserContainer.AcceptBt.Enabled = False
        _BulkUserContainer.AcceptBt.Text = "Done"

        _BulkUserContainer.GetSpinner().Visible = False
        _BulkUserContainer.GetSpinner().Spinning = False

        FormMain.StatusStrip.BackColor = SystemColors.Highlight

        If e.Cancelled = True Then
            FormMain.ToolStripStatusLabelStatus.Text = "Operation Canceled"
        ElseIf e.Error IsNot Nothing Then
            FormMain.ToolStripStatusLabelStatus.Text = "Error: " & e.Error.Message
        Else
            FormMain.ToolStripStatusLabelStatus.Text = "Operation Complete!"
        End If

    End Sub

    Public Sub CancelWork()
        If bw.WorkerSupportsCancellation = True Then
            bw.CancelAsync()
        End If
    End Sub

    Private Sub SetPassword(connection As DirectoryConnection, userDN As String, password As String)

        Dim pwdMod As DirectoryAttributeModification = New DirectoryAttributeModification()
        With pwdMod
            pwdMod.Name = "unicodePwd"
            pwdMod.Add(GetPasswordData(password))
            pwdMod.Operation = DirectoryAttributeOperation.Replace
        End With

        Dim request As ModifyRequest = New ModifyRequest(userDN, pwdMod)

        Dim response As DirectoryResponse = connection.SendRequest(request)
    End Sub

    Private Function GetPasswordData(password As String) As Byte()
        Dim formattedPassword As String
        formattedPassword = String.Format("\{0}\", password)
        Return (Encoding.Unicode.GetBytes(formattedPassword))
    End Function

    Private Function GetConnection(server As String, credential As NetworkCredential, useSsl As Boolean) As DirectoryConnection

        Dim connection As LdapConnection = New LdapConnection(server)

        If (useSsl) Then
            connection.SessionOptions.SecureSocketLayer = True
        Else
            connection.SessionOptions.Sealing = True
        End If

        connection.Bind(credential)
        Return connection
    End Function

    Public Sub Main()

        Dim credential As NetworkCredential = New NetworkCredential("someuser", "Password1", "domain")
        Dim Connection As DirectoryConnection

        Try
            ''change these options to use Kerberos encryption
            Connection = GetConnection("domain.com:636", credential, True)
            Console.WriteLine("Password modified!")
            Dim disposable As IDisposable = Connection

            If (Not disposable Is Nothing) Then
                disposable.Dispose()
            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub



End Class
