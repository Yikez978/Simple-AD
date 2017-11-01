Imports System.ComponentModel
Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory
Imports System.Security.Principal
Imports SimpleLib

Public Class FormObjectAttributes

    Private _DomainObject As DomainObject
    Private _Job As JobExplorer

    Private AttributesList As New List(Of SimpleADAttributeFormItem)
    Private TextMatchFilter As TextMatchFilter
    Private MainDataGrid As DataGridView

    Private LoadAtrThread As Threading.Thread

    Public Sub New(DomainObject As DomainObject, ByVal Job As JobExplorer)

        InitializeComponent()

        Text = DomainObject.Name

        DropDownFilter.SelectedIndex = 0

        _Job = Job
        _DomainObject = DomainObject

        Show()

        LoadAtrThread = New Threading.Thread(AddressOf LoadAttributes)
        LoadAtrThread.Start(_DomainObject)
    End Sub

    Private Sub LoadAttributes(ByVal DomainObject As DomainObject)

        Me.Invoke(New Action(Sub() MainListView.BeginUpdate()))

        Dim ObjectDirEntry As DirectoryEntry = GetDirEntryFromDomainObject(DomainObject)

        Try
            Dim Temp As String = ObjectDirEntry.SchemaClassName
        Catch ex As Exception
            Exit Sub
        End Try

        If ObjectDirEntry.SchemaClassName IsNot Nothing Then

            Dim SchemaCollection As ReadOnlyActiveDirectorySchemaPropertyCollection = GetSchemaPropeterties(ObjectDirEntry.SchemaClassName)

            If Not SchemaCollection Is Nothing Then

                For i As Integer = 0 To SchemaCollection.Count - 1

                    Dim SchemaProperty As ActiveDirectorySchemaProperty = SchemaCollection.Item(i)
                    Dim Prop As String = SchemaProperty.Name
                    Dim Attr As New SimpleADAttributeFormItem

                    Attr.Name = Prop
                    'Attr.FriendlyName = GetFriendlyLDAPName(Prop)

                    If Not ObjectDirEntry.Properties(Prop).Value Is Nothing Then

                        Attr.Type = SchemaProperty.Syntax.ToString
                        Attr.Count = ObjectDirEntry.Properties(Prop).Count

                        If Attr.Count > 1 Then

                            Dim Builder As New StringBuilder
                            For j As Integer = 0 To Attr.Count - 1
                                Builder.AppendLine(ObjectDirEntry.Properties(Prop).Item(j).ToString & ";")
                            Next

                            Attr.Value = Builder.ToString
                        Else
                            If ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(Byte()) Then
                                If DirectCast(ObjectDirEntry.Properties(Prop).Value, Byte()).Length = 16 Then
                                    Dim DecodedByte As Guid = New Guid(DirectCast(ObjectDirEntry.Properties(Prop).Value, Byte()))
                                    Attr.Value = DecodedByte.ToString
                                End If
                            ElseIf SchemaProperty.Syntax = ActiveDirectorySyntax.Int64 Then
                                Attr.Value = ConvertADSLargeIntegerToInt64(ObjectDirEntry.Properties(Prop).Value)
                            ElseIf SchemaProperty.Syntax = ActiveDirectorySyntax.Sid Then
                                Attr.Value = New SecurityIdentifier(ObjectDirEntry.Properties(Prop)(0), 0).ToString
                            ElseIf ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(String) Then
                                Attr.Value = ObjectDirEntry.Properties(Prop).Value
                            ElseIf ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(Integer) Then
                                Attr.Value = ObjectDirEntry.Properties(Prop).Value.ToString
                            ElseIf ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(DateTime) Then
                                Attr.Value = ObjectDirEntry.Properties(Prop).Value.ToString
                            ElseIf ObjectDirEntry.Properties(Prop).Value.GetType() = GetType(Boolean) Then
                                Attr.Value = ObjectDirEntry.Properties(Prop).Value.ToString
                            Else
                                Attr.Value = "N/A"
                            End If
                        End If
                    End If

                    If Attr.Name IsNot Nothing Then
                        AttributesList.Add(Attr)
                    End If

                Next
            End If

        End If

        LoadFinished()
    End Sub

    Private Sub LoadFinished()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf LoadFinished))
        Else
            MainListView.SetObjects(AttributesList)
            MainListView.EndUpdate()
        End If
    End Sub

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
            Case "Only Attributes That Have Values"
                MainListView.ModelFilter = New OnlyPropertiesthatHaveValuesFilter()
        End Select
    End Sub

    Private Sub FormObjectAttributes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoadAtrThread.Abort()
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.Close()
    End Sub

End Class

Public Class SimpleADAttributeFormItem
    Public Property Name As String
    Public Property FriendlyName As String
    Public Property Value As String
    Public Property Type As String
    Public Property Count As Integer
    Public Property IsWritable As Boolean
End Class

Public Class OnlyPropertiesthatHaveValuesFilter
    Implements IModelFilter

    Public Function Filter(modelObject As Object) As Boolean Implements IModelFilter.Filter
        Return Not String.IsNullOrEmpty(DirectCast(modelObject, SimpleADAttributeFormItem).Value)
    End Function
End Class