Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Class ContainerTemplate

    Private NameColRenderer As DescribedTaskRenderer

    Public Function GetMainSplitContainer0() As SplitContainer
        Return Nothing
    End Function

    Public Function GetDomainPanel() As ControlDomainTreeView
        Return Nothing
    End Function

    Public Function GetMainListView() As ObjectListView
        Return Nothing
    End Function

    Public Sub New()
        InitializeComponent()
        TemplateContainerHandle = Me

        NameColRenderer = New DescribedTaskRenderer
        With NameColRenderer
            .Aspect = "Name"
            .DescriptionAspectName = "Description"          
        End With

        NameCol.Renderer = NameColRenderer
        NameCol.ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter)
        LoadImages()

    End Sub

    Private Sub MainListView_MouseClick(sender As Object, e As MouseEventArgs) Handles MainListView.MouseDown
        If e.Button = MouseButtons.Right Then
            GetTemplateManConextMenu(MainListView, e, RightClickMenu, Me, Nothing)
        End If
    End Sub

    Private Sub AddMenuItem_Click(sender As Object, e As EventArgs) Handles AddMenuItem.Click
        Dim NewTemplateForm As FormNewTemplate = New FormNewTemplate
        NewTemplateForm.ShowDialog()
    End Sub

    Private Sub ContainerTemplate_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Directory.Exists(".\Templates") Then
            Directory.CreateDirectory(".\Templates")
        End If

        RefreshTamplates()
    End Sub

    Public Sub RefreshTamplates()
        Dim TemplateList As New List(Of UserTemplate)

        If HasWritePermissionOnDir(".\Templates") Then

            For Each File As String In Directory.GetFiles(".\Templates\")

                Dim Formatter As IFormatter = New BinaryFormatter()
                Dim Stream As Stream = New FileStream(File, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                Dim LoadTemplate As UserTemplate = Formatter.Deserialize(Stream)

                TemplateList.Add(LoadTemplate)

                Stream.Close()
            Next

        End If

        MainListView.SetObjects(TemplateList)
    End Sub

    Private Sub RefreshMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshMenuItem.Click
        RefreshTamplates()
    End Sub

    Public Function NameImageGetter(rowObject As Object) As Object
        Dim TemplateObject As UserTemplate = DirectCast(rowObject, UserTemplate)
        Return TemplateObject.IconKey
    End Function

    Private Sub LoadImages()

        Dim runTimeResourceSet As Object
        Dim dictEntry As DictionaryEntry
        Dim IconImageList = New ImageList With {.ColorDepth = ColorDepth.Depth24Bit}

        runTimeResourceSet = My.Resources.ResourceManager.GetResourceSet(Globalization.CultureInfo.CurrentUICulture, False, True)
        For Each dictEntry In runTimeResourceSet
            If dictEntry.Value.GetType() Is GetType(Bitmap) Then
                Dim image As String = dictEntry.Key

                If image.Contains("Template") Then
                    IconImageList.Images.Add(dictEntry.Key, My.Resources.ResourceManager.GetObject(dictEntry.Key))
                End If
            End If
        Next

        MainListView.SmallImageList = IconImageList
        MainListView.LargeImageList = IconImageList
        NameColRenderer.ImageList = IconImageList
    End Sub
End Class


