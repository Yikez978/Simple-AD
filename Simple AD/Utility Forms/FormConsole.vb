﻿Public Class FormConsole

    Private myWriter As TextBoxTraceListener

    Private Sub FormConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myWriter = New TextBoxTraceListener(RichTextBox)
        Debug.Listeners.Add(myWriter)
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged
        RichTextBox.SelectionStart = RichTextBox.Text.Length
        RichTextBox.ScrollToCaret()
    End Sub

End Class

Friend Class TextBoxTraceListener
    Inherits TraceListener

    Private _target As RichTextBox
    Private _invokeWrite As StringSendDelegate

    Public Sub New(target As RichTextBox)
        _target = target
        _invokeWrite = New StringSendDelegate(AddressOf SendString)
    End Sub

    Public Overrides Sub Write(message As String)
        Try
            _target.Invoke(_invokeWrite, New Object() {message})
        Catch Ex As InvalidOperationException
        End Try
    End Sub

    Public Overrides Sub WriteLine(message As String)
        Try
            _target.Invoke(_invokeWrite, New Object() {message + Environment.NewLine})
        Catch Ex As InvalidOperationException
        End Try
    End Sub

    Private Delegate Sub StringSendDelegate(message As String)

    Private Sub SendString(Message As String)

        If Message.Contains("[Error]") Then
            _target.SelectionColor = Color.Red
        End If
        _target.AppendText(Message)
        _target.SelectionColor = Color.Silver
    End Sub

End Class
