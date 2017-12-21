Imports BrightIdeasSoftware.OLVExporter

Public Class FormImport

    Public Property Path As String

    Public Property CreateHomeFolders As Boolean
    Public Property ForcePasswordReset As Boolean
    Public Property EnableAccounts As Boolean

    Public Event BeginImport()

    Public WithEvents ImportJob As JobImport

    Private TextMatchFilter As TextMatchFilter
    Private ResultsTextMatchFilter As TextMatchFilter

    Public Sub New(Optional File As String = Nothing)
        InitializeComponent()

        Debug.WriteLineIf(Not String.IsNullOrEmpty(File), "[Debug] New Form Import created with path: " & File)

        ImportJob = New JobImport(File, Me)
        Path = File

        If Not String.IsNullOrEmpty(File) Then
            MainTabControl.SelectedTab = PreviewTab
        End If

    End Sub

    Public Sub SetObjects()
        MainListView.SetObjects(ImportJob.Users)
        MainTabControl.SelectedTab = PreviewTab
    End Sub

    Private Sub FormImport_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not String.IsNullOrEmpty(Path) Then
            Debug.WriteLine("[Debug] Import Path: " & Path)
            ImportJob.BeginImport()
        End If

        If ImportJob IsNot Nothing Then
            If (ImportJob.Users IsNot Nothing) And (ImportJob.Users.Count > 0) Then
                SetObjects()
            End If
        End If

        If DesignMode Then
            MainTabControl.ItemSize = New Size(62, 20)
        Else
            MainTabControl.ItemSize = New Size(62, 0)
        End If

        WelcomeTab.Tag = "Select an Option..."
        PreviewTab.Tag = "User Preview"
        DomainTab.Tag = "Select Location"
        OptionsTab.Tag = "Import Configuration"
        ProgressTab.Tag = "Running Import..."
        ResultsTab.Tag = "Import Summary"

        LoadImages()

        Dim CSVMenutItem As MenuItemLarge = New MenuItemLarge("CSV Import", "Create Multiple users via csv import", My.Resources.List)
        Dim WizardMenuItem As MenuItemLarge = New MenuItemLarge("Import wizard", "Create Multiple users via a step by step wizard", My.Resources.Wizard)

        AddHandler CSVMenutItem.Click, AddressOf CSV_Import_ClicK
        AddHandler WizardMenuItem.Click, AddressOf Wizard_Import_ClicK

        MenuFlow.Controls.AddRange({CSVMenutItem, WizardMenuItem})

        NameCol.ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter)
        NameCol.GroupKeyGetter = New GroupKeyGetterDelegate(AddressOf SortByNameGroupKeyGetter)

        ResNameCol.ImageGetter = New ImageGetterDelegate(AddressOf ResultsListImageGetter)
        ResNameCol.GroupKeyGetter = New GroupKeyGetterDelegate(AddressOf SortByNameGroupKeyGetter)

        ResInfoCol.AspectToStringConverter = New AspectToStringConverterDelegate(AddressOf UserImportErrorAspectToString)

        MainListView.PrimarySortColumn = NameCol
        DropDownFilter.SelectedIndex = 0

        DomainTreeView.InitialLoad()

        DomainTreeView.FullRowSelect = False
        DomainTreeView.SelectedOU = Nothing

        MainTabControl_SelectedIndexChanged(Me, Nothing)

    End Sub

    Private Sub LoadImages()

        Dim AdImagesSmall As New ImageList()
        With AdImagesSmall
            .Images.Add("UserImage", New Icon(My.Resources.User, New Size(16, 16)).ToBitmap)
            .ColorDepth = ColorDepth.Depth32Bit
        End With
        MainListView.SmallImageList = AdImagesSmall

        Dim ResultsImagesSmall As New ImageList()
        With ResultsImagesSmall
            .Images.Add("Completed", New Icon(My.Resources.colorTick, New Size(16, 16)).ToBitmap)
            .Images.Add("Errors", New Icon(My.Resources.colorError, New Size(16, 16)).ToBitmap)
            .Images.Add("Failed", New Icon(My.Resources.colorFailed, New Size(16, 16)).ToBitmap)
            .ColorDepth = ColorDepth.Depth32Bit
        End With
        ResultsListView.SmallImageList = ResultsImagesSmall

    End Sub

    Private Sub CSV_Import_ClicK(sender As Object, e As EventArgs)
        ImportJob.BeginImport()
    End Sub

    Private Sub Wizard_Import_ClicK(sender As Object, e As EventArgs)

    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBn.Click
        If (MainTabControl.SelectedIndex + 1) < MainTabControl.TabCount Then
            If ValidateStage(MainTabControl.TabPages.IndexOf(MainTabControl.SelectedTab)) Then
                Debug.WriteLine("[Debug] Validate Stage returned True")
                MainTabControl.SelectTab(MainTabControl.TabPages(MainTabControl.SelectedIndex + 1))
            Else
                Debug.WriteLine("[Debug]  Validate Stage returned False")
            End If
        End If
    End Sub

    Private Sub BackBn_Click(sender As Object, e As EventArgs) Handles BackBn.Click
        If MainTabControl.SelectedIndex > 0 Then
            MainTabControl.SelectTab(MainTabControl.TabPages(MainTabControl.SelectedIndex - 1))
        End If
    End Sub

    Private Function ValidateStage(ByVal CurrentTabIndex As Integer) As Boolean

        If CurrentTabIndex = MainTabControl.TabPages.IndexOf(PreviewTab) Then

            If MainListView.GetItemCount > 0 Then
                Return True
            End If
        End If

        If CurrentTabIndex = MainTabControl.TabPages.IndexOf(DomainTab) Then
            If Not String.IsNullOrEmpty(DomainTreeView.SelectedOU) Then
                Return True
            Else
                Return False
            End If
        End If

        If CurrentTabIndex = MainTabControl.TabPages.IndexOf(OptionsTab) Then

            Path = DomainTreeView.SelectedOU

            CreateHomeFolders = CrHfldrTg.Checked
            ForcePasswordReset = FpwdTg.Checked
            EnableAccounts = EnAcTg.Checked

            MainProgresBar.Step = 1
            MainProgresBar.Maximum = ImportJob.Users.Count

            RaiseEvent BeginImport()
            Return True
        End If

        If CurrentTabIndex = MainTabControl.TabPages.IndexOf(ProgressTab) Then
            If ImportJob.JobStatus = SimpleADJobStatus.Completed Then
                Return True
            Else
                Return False
            End If

        End If

        Return False

    End Function

    Private Sub MainTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainTabControl.SelectedIndexChanged
        Dim TabIndex As Integer = MainTabControl.SelectedIndex

        If TabIndex = MainTabControl.TabPages.IndexOf(OptionsTab) Then
            AcceptBn.Text = "Import"
        Else
            AcceptBn.Text = "Next"
        End If

        If TabIndex > 0 Then
            BackBn.Visible = True
        Else
            BackBn.Visible = False
        End If

        If TabIndex = MainTabControl.TabPages.IndexOf(ProgressTab) Then
            AcceptBn.Visible = False
            BackBn.Visible = False
        Else
            AcceptBn.Visible = True
        End If

        If TabIndex = MainTabControl.TabPages.IndexOf(ResultsTab) Then
            AcceptBn.Visible = False
            BackBn.Visible = False

            PreviewLink.Enabled = False
            LocationLink.Enabled = False
            PreferencesLink.Enabled = False
            ProgressLink.Enabled = False

            ExportBn.Visible = True
            CancelBn.Text = "Close"
        Else
            ExportBn.Visible = False
            CancelBn.Text = "Cancel"
        End If

        If TabIndex = MainTabControl.TabPages.IndexOf(WelcomeTab) Then
            AcceptBn.Visible = False
            BackBn.Visible = False
        End If

        ImagePl.Refresh()
    End Sub

    Private Sub ImagePl_Paint(sender As Object, e As PaintEventArgs) Handles ImagePl.Paint

        Dim s As Panel = Me.ImagePl

        If s IsNot Nothing Then

            Dim g As Graphics = e.Graphics
            Dim p1 As Point = s.ClientRectangle.Location
            Dim p2 As Point = New Point(s.ClientRectangle.Right, s.ClientRectangle.Bottom)

            Using brsGradient As New Drawing2D.LinearGradientBrush(p1, p2, Color.FromArgb(104, 18, 101), Color.FromArgb(49, 12, 66))
                g.FillRectangle(brsGradient, e.ClipRectangle)
            End Using

            Dim TitleFont As Font = New Font("Segoe UI Light", 16.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

            Dim StringToDraw As String = "Title Required"
            Dim TabString As String = MainTabControl.SelectedTab.Tag.ToString

            If Not String.IsNullOrEmpty(TabString) Then
                StringToDraw = TabString
            End If

            DrawString(e.Graphics, MainTabControl.SelectedTab.Tag.ToString, TitleFont, Color.White, 24, 8)

            End If

    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click

        If ImportJob IsNot Nothing Then
            ImportJob.Cancel()
        End If

        Me.Close()
    End Sub

    Private Sub FormImport_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim s As Form = Me
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, 44, s.Width, 44)
        End If
    End Sub

    Private Sub ProgressChanged() Handles ImportJob.ProgressChanged
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ProgressChanged))
        Else
            MainProgresBar.PerformStep()
        End If
    End Sub

    Private Sub JobCompleted() Handles ImportJob.ImportCompleted
        ResultsListView.SetObjects(ImportJob.Users)
        MainTabControl.SelectedTab = ResultsTab
    End Sub

    Private Sub PreviewLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PreviewLink.LinkClicked
        MainTabControl.SelectedTab = PreviewTab
    End Sub

    Private Sub LocationLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LocationLink.LinkClicked
        MainTabControl.SelectedTab = DomainTab
    End Sub

    Private Sub PreferencesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PreferencesLink.LinkClicked
        MainTabControl.SelectedTab = OptionsTab
    End Sub

    Private Sub ProgressLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProgressLink.LinkClicked
        MainTabControl.SelectedTab = ProgressTab
    End Sub

    Private Sub ResultsListView_SelectionChanged(sender As Object, e As EventArgs) Handles ResultsListView.SelectionChanged

        If ResultsListView.SelectedObject IsNot Nothing Then
            Dim User As SimpleADBulkUserDomainObject = DirectCast(ResultsListView.SelectedObject, SimpleADBulkUserDomainObject)

            If User.Errors IsNot Nothing Then
                If User.Errors.Count > 0 Then

                    Dim ErrorList As New StringBuilder

                    For i As Integer = 0 To User.Errors.Count - 1
                        ErrorList.AppendLine(User.Errors(i))
                    Next

                    InfoBox.Text = ErrorList.ToString

                    Console.WriteLine(ErrorList.ToString)

                End If
            End If

        End If
    End Sub

    Private Sub SearchTb_TextChanged(sender As Object, e As EventArgs) Handles SearchTb.TextChanged
        If Not String.IsNullOrEmpty(SearchTb.Text) Then
            TextMatchFilter = TextMatchFilter.Contains(MainListView, SearchTb.Text)
            MainListView.ModelFilter = TextMatchFilter
            MainListView.DefaultRenderer = New HighlightTextRenderer(TextMatchFilter) With {
                .FillBrush = New SolidBrush(Color.FromArgb(210, 206, 225)),
                .CornerRoundness = Nothing,
                .FramePen = Nothing
                }
        Else
            MainListView.ModelFilter = Nothing
        End If
    End Sub

    Private Sub FilterTb_TextChanged(sender As Object, e As EventArgs) Handles FilterTb.TextChanged
        If Not String.IsNullOrEmpty(FilterTb.Text) Then
            ResultsTextMatchFilter = TextMatchFilter.Contains(ResultsListView, FilterTb.Text)
            ResultsListView.ModelFilter = ResultsTextMatchFilter
            ResultsListView.DefaultRenderer = New HighlightTextRenderer(ResultsTextMatchFilter) With {
                .FillBrush = New SolidBrush(Color.FromArgb(210, 206, 225)),
                .CornerRoundness = CType(0, Single),
                .FramePen = Nothing
                }
        Else
            ResultsListView.ModelFilter = Nothing
        End If
    End Sub

    Private Sub DropDownFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownFilter.SelectedIndexChanged
        Select Case DropDownFilter.Text
            Case "All"
                ResultsListView.ModelFilter = Nothing
            Case "Failed"
                ResultsListView.ModelFilter = New FailedResultsListFileter()
            Case "With Errors"
                ResultsListView.ModelFilter = New ErrorsResultsListFileter()
            Case "Completed"
                ResultsListView.ModelFilter = New CompletedResultsListFileter()
        End Select
    End Sub

    Private Sub ExportBn_Click(sender As Object, e As EventArgs) Handles ExportBn.Click

        If ResultsListView.Items.Count < 1 Then
            Exit Sub
        Else

            Dim SaveDialog As SaveFileDialog = New SaveFileDialog With {
            .Filter = "CSV (Comma delimited)|*.csv|Text (Tab delimited)|*.txt|HTML (Hyper Text Markup Language)|*.html",
            .Title = "Save File"
        }
            SaveDialog.ShowDialog()

            If Not String.IsNullOrEmpty(SaveDialog.FileName) Then
                Dim ListViewExporter As OLVExporter = New OLVExporter With {
                .ListView = ResultsListView(),
                .ModelObjects = DirectCast(ResultsListView.Objects, IList),
                .IncludeColumnHeaders = True,
                .IncludeHiddenColumns = True
                }

                Dim ExportedData As String = String.Empty

                Select Case SaveDialog.FilterIndex
                    Case 1
                        ExportedData = ListViewExporter.ExportTo(ExportFormat.CSV)
                    Case 2
                        ExportedData = ListViewExporter.ExportTo(ExportFormat.TSV)
                    Case 3
                        ExportedData = StyleHTMLExport(ListViewExporter.ExportTo(ExportFormat.HTML))
                End Select

                If Not String.IsNullOrEmpty(ExportedData) Then
                    Threading.ThreadPool.QueueUserWorkItem(Sub() ExportData(ExportedData, SaveDialog.FileName))
                End If
            End If

        End If

    End Sub

    Private Sub MenuFlow_ControlAdded(sender As Object, e As ControlEventArgs) Handles MenuFlow.ControlAdded
        e.Control.Size = New Size(MenuFlow.Width - 16, 76)
    End Sub
End Class

Friend Class FailedResultsListFileter
    Implements IModelFilter

    Public Function Filter(modelObject As Object) As Boolean Implements IModelFilter.Filter
        Return DirectCast(modelObject, SimpleADBulkUserDomainObject).Status = "Failed"
    End Function
End Class

Friend Class CompletedResultsListFileter
    Implements IModelFilter

    Public Function Filter(modelObject As Object) As Boolean Implements IModelFilter.Filter
        Return DirectCast(modelObject, SimpleADBulkUserDomainObject).Status = "Completed"
    End Function
End Class

Friend Class ErrorsResultsListFileter
    Implements IModelFilter

    Public Function Filter(modelObject As Object) As Boolean Implements IModelFilter.Filter
        Return DirectCast(modelObject, SimpleADBulkUserDomainObject).Status = "Errors"
    End Function
End Class