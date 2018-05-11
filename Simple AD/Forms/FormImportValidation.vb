Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing

Public Class FormImportValidation

    Private DataTable As New DataTable()
    Private view As DataView

    Public Property Errors As New List(Of ImportError)


    Public Sub New()

        InitializeComponent()
        MainPb.Image = New Icon(My.Resources.Attention, New Size(32, 32)).ToBitmap
    End Sub

    Public Sub Add(ByVal ErrorType As String, ByVal Details As String)
        Errors.Add(New ImportError With {.ErrorName = ErrorType, .ErrorMessage = Details})
    End Sub

    Private Sub ImportValidationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorListView.SetObjects(Errors)
    End Sub

    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click
        Close()
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles IgnoreBn.Click
        Close()
    End Sub

    Public Class ImportError
        Public Property ErrorName As String
        Public Property ErrorMessage As String
    End Class


End Class