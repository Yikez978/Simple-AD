Public Module ToolStripHandler

    Dim StaticButtonsGroup As New ControlToolStripGroup With {.DisplayText = "Simple AD"}
    Dim ExportButtonsGroup As New ControlToolStripGroup With {.DisplayText = "Export", .Visible = True}
    Dim CreateButtonsGroup As New ControlToolStripGroup With {.DisplayText = "New Object", .Visible = True}
    Dim SingleUserButtonsGroup As New ControlToolStripGroup With {.DisplayText = "User Actions", .Visible = False}


    Public Function LoadToolStripItems() As List(Of ControlToolStripGroup)

        Dim Groups As New List(Of ControlToolStripGroup)

        ''
        '' STATIC BUTTONS
        ''

        Dim StaticButtons As New List(Of ControlToolStripButton)

        Dim ImportCSVBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "ImportCSVBn", .Text = "Import CSV", .Image = New Icon(My.Resources.JobImport, New Size(32, 32)).ToBitmap}
        AddHandler ImportCSVBn.ButtonClicked, AddressOf ImportCSV_Click
        StaticButtons.Add(ImportCSVBn)

        Dim TemplateBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "TemplateBn", .Text = "Template Manager", .Image = New Icon(My.Resources.Template, New Size(32, 32)).ToBitmap}
        AddHandler TemplateBn.ButtonClicked, AddressOf TemplateManager_Click
        StaticButtons.Add(TemplateBn)

        Dim ActiveDirectoryBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "ActiveDirectoryBn", .Text = "Active Directory", .Image = New Icon(My.Resources.ActiveDirectory, New Size(32, 32)).ToBitmap}
        AddHandler ActiveDirectoryBn.ButtonClicked, AddressOf OpenActiveDirectory_Click
        StaticButtons.Add(ActiveDirectoryBn)

        LoadGroupButtons(StaticButtonsGroup, StaticButtons)
        Groups.Add(StaticButtonsGroup)

        ''
        '' EXPORT FILE BUTTONS
        ''

        Dim ExportButtons As New List(Of ControlToolStripButton)

        Dim CSVBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "CSVBn", .Text = "csv", .Image = New Icon(My.Resources.CSV, New Size(32, 32)).ToBitmap}
        AddHandler CSVBn.ButtonClicked, AddressOf ExportCSV
        ExportButtons.Add(CSVBn)

        Dim TextFileBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "TextFileBn", .Text = "Text File", .Image = New Icon(My.Resources.TextFile, New Size(32, 32)).ToBitmap}
        AddHandler TextFileBn.ButtonClicked, AddressOf ExportTab
        ExportButtons.Add(TextFileBn)

        Dim HTMLBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "HTMLBn", .Text = "HTML", .Image = New Icon(My.Resources.HTML, New Size(32, 32)).ToBitmap}
        AddHandler HTMLBn.ButtonClicked, AddressOf ExportHTML
        ExportButtons.Add(HTMLBn)

        LoadGroupButtons(ExportButtonsGroup, ExportButtons)
        Groups.Add(ExportButtonsGroup)

        ''
        '' CREATE NEW OBJECT BUTTONS
        ''

        Dim CreateButtons As New List(Of ControlToolStripButton)

        Dim CreateUserBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "CreateUserBn", .Text = "New User", .Image = New Icon(My.Resources.CreateUser, New Size(32, 32)).ToBitmap}
        AddHandler CreateUserBn.ButtonClicked, AddressOf NewUserButton_Click
        CreateButtons.Add(CreateUserBn)

        Dim CreateGroupBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "CreateGroupBn", .Text = "New Group", .Image = New Icon(My.Resources.CreateGroup, New Size(32, 32)).ToBitmap}
        'AddHandler CreateGroupBn.ButtonClicked, AddressOf DeleteSingleToolStripMenuItem_Click
        CreateButtons.Add(CreateGroupBn)

        Dim CreateOUBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "CreateOUBn", .Text = "New OU", .Image = New Icon(My.Resources.CreateOU, New Size(32, 32)).ToBitmap}
        'AddHandler CreateOUBn.ButtonClicked, AddressOf DeleteSingleToolStripMenuItem_Click
        CreateButtons.Add(CreateOUBn)

        LoadGroupButtons(CreateButtonsGroup, CreateButtons)
        Groups.Add(CreateButtonsGroup)

        ''
        '' SINGLE USER BUTTONS
        ''

        Dim SingleUserButtons As New List(Of ControlToolStripButton)

        Dim ResetPasswordBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "ResetPasswordBn", .Text = "Reset Password", .Image = New Icon(My.Resources.JobPasswordReset, New Size(32, 32)).ToBitmap}
        AddHandler ResetPasswordBn.ButtonClicked, AddressOf ResetSingle_Click
        SingleUserButtons.Add(ResetPasswordBn)

        Dim MoveObjectBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "MoveObjectBn", .Text = "Move", .Image = New Icon(My.Resources.JobMove, New Size(32, 32)).ToBitmap}
        AddHandler MoveObjectBn.ButtonClicked, AddressOf MoveSingle_Click
        SingleUserButtons.Add(MoveObjectBn)

        Dim EnableBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "EnableBn", .Text = "Enable / Disable", .Image = New Icon(My.Resources.JobEnableDisable, New Size(32, 32)).ToBitmap}
        AddHandler EnableBn.ButtonClicked, AddressOf Enable_Click
        SingleUserButtons.Add(EnableBn)

        Dim DeleteBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "DeleteBn", .Text = "Delete", .Image = New Icon(My.Resources.JobDelete, New Size(32, 32)).ToBitmap}
        AddHandler DeleteBn.ButtonClicked, AddressOf DeleteSingle_Click
        SingleUserButtons.Add(DeleteBn)

        LoadGroupButtons(SingleUserButtonsGroup, SingleUserButtons)
        Groups.Add(SingleUserButtonsGroup)

        Return Groups
    End Function

    Private Sub LoadGroupButtons(ByVal Group As ControlToolStripGroup, ByVal Buttons As List(Of ControlToolStripButton))
        If FormMain.InvokeRequired Then
            FormMain.Invoke(New Action(Of ControlToolStripGroup, List(Of ControlToolStripButton))(AddressOf LoadGroupButtons), Group, Buttons)
        Else
            For Each Item As ControlToolStripButton In Buttons
                Group.Controls.Add(Item)
            Next
        End If
    End Sub

    Public Sub RefreshToolStrip(sender As Object, e As EventArgs)

        Dim ObjectQuery As Object = Nothing

        If GetMainListView.SelectedItem IsNot Nothing Then
            ObjectQuery = GetMainListView.SelectedItem.RowObject
        End If

        If ObjectQuery IsNot Nothing Then

            If ObjectQuery.GetType Is GetType(UserDomainObject) Then
                SingleUserButtonsGroup.Visible = True
            End If
        Else
            SingleUserButtonsGroup.Visible = False
        End If

        If GetContainerExplorer.Job.JobPath IsNot Nothing Then
            CreateButtonsGroup.Visible = True
        Else
            CreateButtonsGroup.Visible = False
        End If

        If GetMainListView.Items.Count < 1 Then
            ExportButtonsGroup.Visible = False
        Else
            ExportButtonsGroup.Visible = True
        End If

    End Sub

End Module
