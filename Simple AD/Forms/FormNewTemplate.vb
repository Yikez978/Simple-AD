Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Class FormNewTemplate

    Public Property Template As UserTemplate

    Public Sub New()

        InitializeComponent()

        Me.Template = New UserTemplate(Guid.NewGuid)
        Me.IDTb.Text = Me.Template.TemplateID.ToString
        'Me.AuthorValLb.Text = GetDisplayName()

        NameColumn.ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter)

    End Sub

    Private Sub CnBt_Click(sender As Object, e As EventArgs) Handles CnBt.Click
        Me.Close()
    End Sub

    Private Sub OKBt_Click(sender As Object, e As EventArgs) Handles OKBt.Click
        If ValidateNewTemplate() Then

            Dim IconObject As IconObject = TryCast(IconListView.SelectedObject, IconObject)

            Template.Name = NameTb.Text
            Template.Description = DescriptionTb.Text
            Template.Author = AuthorValLb.Text
            Template.IconKey = IconObject.Name

            Dim Formatter As IFormatter = New BinaryFormatter()
            Dim Stream As Stream = New FileStream(".\Templates\" & Template.Name & ".stfx", FileMode.Create, FileAccess.Write, FileShare.None)
            Formatter.Serialize(Stream, Template)
            Stream.Close()

            RefreshTamplates()

            Me.Close()
        Else
            Me.NameTb.BackColor = Color.Pink
        End If
    End Sub

    Private Function ValidateNewTemplate() As Boolean

        If Not String.IsNullOrEmpty(Me.NameTb.Text) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub NameTb_TextChanged(sender As Object, e As EventArgs) Handles NameTb.TextChanged
        Me.NameTb.BackColor = SystemColors.Window
    End Sub

    Private Sub FormNewTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadImagesTab()
    End Sub

    Private Sub LoadImagesTab()
        Dim runTimeResourceSet As Resources.ResourceSet
        Dim dictEntry As DictionaryEntry
        Dim IconImageList As ImageList = New ImageList With {.ColorDepth = ColorDepth.Depth24Bit}
        Dim IconObjectsList As New List(Of IconObject)

        runTimeResourceSet = My.Resources.ResourceManager.GetResourceSet(Globalization.CultureInfo.CurrentUICulture, False, True)
        For Each dictEntry In runTimeResourceSet
            If dictEntry.Value.GetType() Is GetType(Bitmap) Then
                Dim image As String = dictEntry.Key.ToString

                If image.Contains("Template") Then
                    Dim NewIcon As IconObject = New IconObject With {.Name = dictEntry.Key.ToString, .DisplayName = CStr(dictEntry.Key).Substring(8)}
                    IconImageList.Images.Add(dictEntry.Key.ToString, TryCast(My.Resources.ResourceManager.GetObject(dictEntry.Key.ToString), Image))
                    IconObjectsList.Add(NewIcon)
                End If
            End If
        Next

        IconListView.LargeImageList = IconImageList
        IconListView.SmallImageList = IconImageList
        IconListView.SetObjects(IconObjectsList)

    End Sub

    Public Function NameImageGetter(rowObject As Object) As Object
        Dim IconObject As IconObject = DirectCast(rowObject, IconObject)

        If Not String.IsNullOrEmpty(IconObject.Name) Then
            Return IconObject.Name
        Else
            Return "TemplateFemale0"
        End If
    End Function

    Public Class IconObject
        Public Property Name As String
        Public Property DisplayName As String
    End Class

End Class