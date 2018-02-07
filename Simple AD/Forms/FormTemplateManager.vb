Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports BrightIdeasSoftware
Imports SimpleLib

Public Class FormTemplateManager

    Private NameColRenderer As DescribedTaskRenderer

    Public Sub New()
        InitializeComponent()

        NameColRenderer = New DescribedTaskRenderer
        With NameColRenderer
            .Aspect = "Name"
            .DescriptionAspectName = "Description"
        End With

        NameCol.Renderer = NameColRenderer
        NameCol.ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter)
        LoadImages()

        AddHandler TemplateManager.FinishedRefresh, AddressOf TemplatesRefreshed

    End Sub

    Private Sub MainListView_MouseDown(sender As Object, e As MouseEventArgs) Handles MainListView.MouseDown
        If e.Button = MouseButtons.Right Then
            GetTemplateManConextMenu(MainListView, e, RightClickMenu, Me, Nothing)
        End If
    End Sub

    Private Sub AddMenuItem_Click(sender As Object, e As EventArgs) Handles AddMenuItem.Click
        Dim NewTemplateForm As FormNewTemplate = New FormNewTemplate
        NewTemplateForm.ShowDialog()
    End Sub

    Private Sub ContainerTemplate_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshTamplates()
    End Sub

    Private Sub RefreshMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshMenuItem.Click
        RefreshTamplates()
    End Sub

    Public Function NameImageGetter(rowObject As Object) As Object
        Dim TemplateObject As UserTemplate = DirectCast(rowObject, UserTemplate)
        Return TemplateObject.IconKey
    End Function

    Public Sub TemplatesRefreshed()
        If Not Me.IsDisposed Then
            MainListView.SetObjects(TemplateList)
        End If
    End Sub


    Private Sub LoadImages()

        Dim runTimeResourceSet As Resources.ResourceSet
        Dim dictEntry As DictionaryEntry
        Dim IconImageList As ImageList = New ImageList With {.ColorDepth = ColorDepth.Depth32Bit}

        runTimeResourceSet = My.Resources.ResourceManager.GetResourceSet(Globalization.CultureInfo.CurrentUICulture, False, True)
        For Each dictEntry In runTimeResourceSet
            If dictEntry.Value.GetType() Is GetType(Bitmap) Then
                Dim image As String = dictEntry.Key.ToString

                If image.Contains("Template") Then
                    IconImageList.Images.Add(dictEntry.Key.ToString, DirectCast(My.Resources.ResourceManager.GetObject(dictEntry.Key.ToString), Image))
                End If
            End If
        Next

        MainListView.SmallImageList = IconImageList
        MainListView.LargeImageList = IconImageList
        NameColRenderer.ImageList = IconImageList
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.Close()
    End Sub
End Class


