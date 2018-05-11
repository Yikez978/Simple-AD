Imports System
Imports System.Collections.Generic
Imports System.Drawing

Imports SimpleAD.LocalData.Export.ExportHandler

Imports SimpleLib

Public Module ToolStripHandler

    Dim StaticButtonsGroup As New ControlToolStripGroup With
        {
            .DisplayText = "Simple AD"
        }

    Dim ExportButtonsGroup As New ControlToolStripGroup With
        {
            .DisplayText = "Export",
            .Visible = True
        }

    Dim CreateButtonsGroup As New ControlToolStripGroup With
        {
            .DisplayText = "Create",
            .Visible = True
        }

    Dim ReportingButtonsGroup As New ControlToolStripGroup With
        {
            .DisplayText = "Reporting",
            .Visible = False
        }

    Dim DirectoryButtonsGroup As New ControlToolStripGroup With
        {
            .DisplayText = "Directory",
            .Visible = False
        }

    Dim SingleUserButtonsGroup As New ControlToolStripGroup With
        {
            .DisplayText = "User Actions",
            .Visible = False
        }

    Private _ToolStripHandler As UIHandler = Nothing

    Public Function LoadToolStripItems(ByVal Handler As UIHandler) As List(Of ControlToolStripGroup)

        _ToolStripHandler = Handler

        Dim Groups As New List(Of ControlToolStripGroup)

        ''
        '' STATIC BUTTONS
        ''

        Dim StaticButtons As New List(Of ControlToolStripButton)

        Dim ImportCSVBn As ControlToolStripButton = New ControlToolStripButton With
            {
                .Name = "ImportCSVBn", .Text = "Import CSV",
                .Image = New Icon(My.Resources.JobImport, New Size(32, 32)).ToBitmap, .Enabled = True
            }
        AddHandler ImportCSVBn.ButtonClicked, AddressOf _ToolStripHandler.ImportCSV_Click
        StaticButtons.Add(ImportCSVBn)

        Dim TemplateBn As ControlToolStripButton = New ControlToolStripButton With
            {
                .Name = "TemplateBn", .Text = "Template Manager",
                .Image = New Icon(My.Resources.Template, New Size(32, 32)).ToBitmap, .Enabled = False
            }

        AddHandler TemplateBn.ButtonClicked, AddressOf _ToolStripHandler.TemplateManager_Click
        StaticButtons.Add(TemplateBn)

        Dim ActiveDirectoryBn As ControlToolStripButton = New ControlToolStripButton With
            {
                .Name = "ActiveDirectoryBn", .Text = "Active Directory",
                .Image = New Icon(My.Resources.ActiveDirectory, New Size(32, 32)).ToBitmap, .Enabled = True
            }

        AddHandler ActiveDirectoryBn.ButtonClicked, AddressOf _ToolStripHandler.OpenActiveDirectory_Click
        StaticButtons.Add(ActiveDirectoryBn)

        LoadGroupButtons(StaticButtonsGroup, StaticButtons)
        Groups.Add(StaticButtonsGroup)

        ''
        '' EXPORT FILE BUTTONS
        ''

        Dim ExportButtons As New List(Of ControlToolStripButton)

        Dim CSVBn As ControlToolStripButton = New ControlToolStripButton With
            {
                .Name = "CSVBn", .Text = "csv",
                .Image = New Icon(My.Resources.CSV, New Size(32, 32)).ToBitmap, .Enabled = True
            }
        ''AddHandler CSVBn.ButtonClicked, New EventHandler(null, null)(New Action(Of ObjectListView)(AddressOf ExportCSV), FormMain.ContainerExplorer.MainListView)
        ExportButtons.Add(CSVBn)

        Dim TextFileBn As ControlToolStripButton = New ControlToolStripButton With
            {
                .Name = "TextFileBn", .Text = "Text File",
                .Image = New Icon(My.Resources.TextFile, New Size(32, 32)).ToBitmap, .Enabled = True
            }

        ''AddHandler TextFileBn.ButtonClicked, AddressOf ExportTab
        ExportButtons.Add(TextFileBn)

        Dim HTMLBn As ControlToolStripButton = New ControlToolStripButton With
            {
                .Name = "HTMLBn", .Text = "HTML",
                .Image = New Icon(My.Resources.HTML, New Size(32, 32)).ToBitmap, .Enabled = True
            }
        ''AddHandler HTMLBn.ButtonClicked, AddressOf ExportHTML
        ExportButtons.Add(HTMLBn)

        LoadGroupButtons(ExportButtonsGroup, ExportButtons)
        Groups.Add(ExportButtonsGroup)

        ''
        '' CREATE NEW OBJECT BUTTONS
        ''

        Dim CreateButtons As New List(Of ControlToolStripButton)

        Dim CreateUserBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "CreateUserBn", .Text = "New User", .Image = New Icon(My.Resources.CreateUser, New Size(32, 32)).ToBitmap, .Enabled = True}
        AddHandler CreateUserBn.ButtonClicked, AddressOf _ToolStripHandler.NewUserButton_Click
        CreateButtons.Add(CreateUserBn)

        Dim CreateGroupBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "CreateGroupBn", .Text = "New Group", .Image = New Icon(My.Resources.CreateGroup, New Size(32, 32)).ToBitmap, .Enabled = False}
        'AddHandler CreateGroupBn.ButtonClicked, AddressOf DeleteSingleToolStripMenuItem_Click
        CreateButtons.Add(CreateGroupBn)

        Dim CreateOUBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "CreateOUBn", .Text = "New OU", .Image = New Icon(My.Resources.CreateOU, New Size(32, 32)).ToBitmap, .Enabled = True}
        AddHandler CreateOUBn.ButtonClicked, AddressOf _ToolStripHandler.NewOrganizationalUnit_Click
        CreateButtons.Add(CreateOUBn)

        LoadGroupButtons(CreateButtonsGroup, CreateButtons)
        Groups.Add(CreateButtonsGroup)

        ''
        '' DIRECTORY BUTTONS
        ''

        Dim DirectoryButtons As New List(Of ControlToolStripButton)

        Dim SearchBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "SearchBn", .Text = "Search", .Image = New Icon(My.Resources.Search, New Size(32, 32)).ToBitmap, .Enabled = True}
        AddHandler SearchBn.ButtonClicked, AddressOf _ToolStripHandler.SearchMenuItem_Click
        DirectoryButtons.Add(SearchBn)

        LoadGroupButtons(DirectoryButtonsGroup, DirectoryButtons)
        Groups.Add(DirectoryButtonsGroup)

        ''
        '' REPORTING BUTTONS
        ''

        Dim ReportingButtons As New List(Of ControlToolStripButton)

        Dim NewReportBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "NewReportBn", .Text = "New Report", .Image = New Icon(My.Resources.report, New Size(32, 32)).ToBitmap, .Enabled = True}
        AddHandler NewReportBn.ButtonClicked, AddressOf _ToolStripHandler.NewReport_Click
        ReportingButtons.Add(NewReportBn)

        LoadGroupButtons(ReportingButtonsGroup, ReportingButtons)
        Groups.Add(ReportingButtonsGroup)

        ''
        '' SINGLE USER BUTTONS
        ''

        Dim SingleUserButtons As New List(Of ControlToolStripButton)

        Dim ResetPasswordBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "ResetPasswordBn", .Text = "Reset Password", .Image = New Icon(My.Resources.JobPasswordReset, New Size(32, 32)).ToBitmap, .Enabled = True}
        AddHandler ResetPasswordBn.ButtonClicked, AddressOf _ToolStripHandler.ResetSingle_Click
        SingleUserButtons.Add(ResetPasswordBn)

        Dim MoveObjectBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "MoveObjectBn", .Text = "Move", .Image = New Icon(My.Resources.JobMove, New Size(32, 32)).ToBitmap, .Enabled = True}
        AddHandler MoveObjectBn.ButtonClicked, AddressOf _ToolStripHandler.MoveSingle_Click
        SingleUserButtons.Add(MoveObjectBn)

        Dim EnableBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "EnableBn", .Text = "Enable / Disable", .Image = New Icon(My.Resources.JobEnableDisable, New Size(32, 32)).ToBitmap, .Enabled = True}
        AddHandler EnableBn.ButtonClicked, AddressOf _ToolStripHandler.Enable_Click
        SingleUserButtons.Add(EnableBn)

        Dim DeleteBn As ControlToolStripButton = New ControlToolStripButton With
            {.Name = "DeleteBn", .Text = "Delete", .Image = New Icon(My.Resources.JobDelete, New Size(32, 32)).ToBitmap, .Enabled = True}
        AddHandler DeleteBn.ButtonClicked, AddressOf _ToolStripHandler.DeleteSingle_Click
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

        'Dim ObjectQuery As Object = Nothing

        'If GetMainListView.SelectedItem IsNot Nothing Then
        '    ObjectQuery = GetMainListView.SelectedItem.RowObject
        'End If

        'If ObjectQuery IsNot Nothing Then

        '    If ObjectQuery.GetType Is GetType(UserDomainObject) Then
        '        SingleUserButtonsGroup.Visible = True
        '    End If
        'Else
        '    SingleUserButtonsGroup.Visible = False
        'End If

        'If GetContainerExplorer.Job.JobPath IsNot Nothing Then
        '    CreateButtonsGroup.Visible = True
        'Else
        '    CreateButtonsGroup.Visible = False
        'End If

        'If GetMainListView.Items.Count < 1 Then
        '    ExportButtonsGroup.Visible = False
        '    DirectoryButtonsGroup.Visible = False
        '    ReportingButtonsGroup.Visible = False
        'Else
        '    DirectoryButtonsGroup.Visible = True
        '    ReportingButtonsGroup.Visible = True
        '    ExportButtonsGroup.Visible = True
        'End If

    End Sub

End Module
