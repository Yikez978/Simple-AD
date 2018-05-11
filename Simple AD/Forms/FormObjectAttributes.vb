Imports System
Imports System.Collections.Generic
Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory
Imports System.Drawing
Imports System.Security.Principal
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports BrightIdeasSoftware
Imports SimpleLib

Public Class FormObjectAttributes

    Private _DomainObject As DomainObject
    Private _Job As TaskExplorer

    Private AttributesList As New List(Of SimpleADAttributeFormItem)
    Private TextMatchFilter As TextMatchFilter
    Private MainDataGrid As DataGridView

    Private _AttrCancelSource As CancellationTokenSource
    Private _GroupsCancelSource As CancellationTokenSource

    Private AttributeParser As New AttributeParser

    Private Delegate Sub LoadFinished_Delegate()

    Public Sub New(DomainObject As DomainObject, ByVal Job As TaskExplorer)

        InitializeComponent()

        _Job = Job
        _DomainObject = DomainObject


        MainListView.SetListStyle()
        MainListView.BeginUpdate()

        Text = DomainObject.Name
        AttrTab.Tag = "Property Inspector"
        TitleLb.Text = MainTabControl.SelectedTab.Tag.ToString()

        DropDownFilter.SelectedIndex = 1

        LoadImages()
        Show()

        _AttrCancelSource = New CancellationTokenSource()
        Task.Run(Sub() LoadAttributes(_DomainObject, _AttrCancelSource.Token))

        Dim UserObject = TryCast(_DomainObject, UserDomainObject)

        If UserObject IsNot Nothing Then

            _GroupsCancelSource = New CancellationTokenSource()
            Task.Run(Sub() LoadGroupMembership(_DomainObject, _AttrCancelSource.Token))

        End If

    End Sub

    Private Sub LoadAttributes(ByVal DomainObjectAsObject As Object, ByVal CancelToken As CancellationToken)

        If CancelToken.IsCancellationRequested Then
            Exit Sub
        End If

        Dim DomainObject As DomainObject = DirectCast(DomainObjectAsObject, DomainObject)
        Dim ObjectDirEntry As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)

        Try
            Dim ClassName As String = ObjectDirEntry.SchemaClassName
        Catch ex As Exception
            FormAlert.Show("Simple AD was unbale to determin the schema class of the selected object", AlertType.Warning)
            Exit Sub
        End Try

        Dim SchemaCollection As ReadOnlyActiveDirectorySchemaPropertyCollection = GetSchemaPropeterties(ObjectDirEntry.SchemaClassName)

        If SchemaCollection Is Nothing Then
            Exit Sub
        End If

        For i As Integer = 0 To SchemaCollection.Count - 1

            Dim SchemaProperty As ActiveDirectorySchemaProperty = SchemaCollection.Item(i)
            Dim Prop As String = SchemaProperty.Name
            Dim Attr As New SimpleADAttributeFormItem With {.Name = Prop}

            If Not ObjectDirEntry.Properties(Prop).Value Is Nothing Then

                Attr.Type = SchemaProperty.Syntax.ToString
                Attr.Count = ObjectDirEntry.Properties(Prop).Count

                If Attr.Count > 1 Then

                    Dim Builder As New StringBuilder
                    For j As Integer = 0 To Attr.Count - 1
                        Builder.AppendLine(ObjectDirEntry.Properties(Prop).Item(j).ToString & " | ")
                    Next

                    Attr.Value = Builder.ToString()
                Else

                    If ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(Byte()) Then
                        If DirectCast(ObjectDirEntry.Properties(Prop).Value, Byte()).Length = 16 Then
                            Dim DecodedByte As Guid = New Guid(DirectCast(ObjectDirEntry.Properties(Prop).Value, Byte()))
                            Attr.Value = DecodedByte.ToString
                        End If
                    ElseIf SchemaProperty.Syntax = ActiveDirectorySyntax.Int64 Then
                        Attr.Value = AttributeParser.ConvertADSLargeIntegerToInt64(ObjectDirEntry.Properties(Prop).Value)

                    ElseIf SchemaProperty.Syntax = ActiveDirectorySyntax.Sid Then
                        Attr.Value = New SecurityIdentifier(DirectCast(ObjectDirEntry.Properties(Prop)(0), Byte()), 0).ToString

                    ElseIf SchemaProperty.Syntax = ActiveDirectorySyntax.GeneralizedTime Then
                        Attr.Value = If(DirectCast(ObjectDirEntry.Properties(Prop).Value, DateTime).Year = 1601,
                            "(Not Set)",
                            ObjectDirEntry.Properties(Prop).Value.ToString)

                    ElseIf ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(String) Then
                        Attr.Value = ObjectDirEntry.Properties(Prop).Value.ToString

                    ElseIf ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(Integer) Then
                        Attr.Value = ObjectDirEntry.Properties(Prop).Value.ToString

                    ElseIf ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(DateTime) Then
                        Attr.Value = ObjectDirEntry.Properties(Prop).Value.ToString

                    ElseIf ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(Boolean) Then
                        Attr.Value = ObjectDirEntry.Properties(Prop).Value.ToString

                    Else
                        Attr.Value = "Attribute Parsing failed, unable to decode value"
                    End If
                End If
            End If

            If Attr.Name IsNot Nothing Then
                AttributesList.Add(Attr)
            End If

        Next

        Invoke(New LoadFinished_Delegate(AddressOf LoadFinished))

    End Sub

    Private Sub LoadGroupMembership(ByVal DomainObjectAsObject As Object, ByVal CancelToken As CancellationToken)

        If CancelToken.IsCancellationRequested Then
            Exit Sub
        End If

        Dim DomainObject As DomainObject = DirectCast(DomainObjectAsObject, DomainObject)
        Dim ObjectDirEntry As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)

    End Sub

    Private Sub LoadFinished()

        MainListView.SetObjects(AttributesList)
        MainListView.EndUpdate()

    End Sub

    Private Sub LoadImages()

        Dim Images As New ImageList()
        With Images
            .Images.Add("Registry", New Icon(My.Resources.Registry, New Size(16, 16)).ToBitmap)
            .ColorDepth = ColorDepth.Depth32Bit
            .ImageSize = New Size(16, 16)
        End With

        MainListView.SmallImageList = Images

        NameCol.ImageGetter = New ImageGetterDelegate(AddressOf AttributesImageGetter)

    End Sub

    Private Function AttributesImageGetter(ByVal rowObject As Object) As Object
        Return "Registry"
    End Function

    Private Sub SearchBoxTb_TextChanged(sender As Object, e As EventArgs) Handles SearchBoxTb.TextChanged
        If Not String.IsNullOrEmpty(SearchBoxTb.Text) Then
            TextMatchFilter = TextMatchFilter.Contains(MainListView, SearchBoxTb.Text)
            MainListView.ModelFilter = TextMatchFilter
        Else
            MainListView.ModelFilter = Nothing
        End If
    End Sub

    Private Sub DropDownFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles DropDownFilter.SelectedValueChanged
        Select Case DropDownFilter.Text
            Case "All"
                MainListView.ModelFilter = Nothing
            Case Else
                MainListView.ModelFilter = New OnlyPropertiesthatHaveValuesFilter()
        End Select
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs)
        _AttrCancelSource.Cancel()
        Close()
    End Sub

    Private Sub ImagePl_Paint(sender As Object, e As PaintEventArgs) Handles ImagePl.Paint

        Dim s As Panel = ImagePl

        If s IsNot Nothing Then

            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, s.Height - 1, s.Width, s.Height - 1)

            Pen.Dispose()

        End If

    End Sub
End Class

Public Class SimpleADAttributeFormItem
    Public Property Name As String
    Public Property FriendlyName As String
    Public Property Value As Object
    Public Property Type As String
    Public Property Count As Integer
    Public Property IsWritable As Boolean
End Class

Public Class OnlyPropertiesthatHaveValuesFilter
    Implements IModelFilter

    Public Function Filter(modelObject As Object) As Boolean Implements IModelFilter.Filter
        Return Not DirectCast(modelObject, SimpleADAttributeFormItem).Value Is Nothing
    End Function
End Class