Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System

Public Class ControlTextBox
    Inherits TextBox

    <DefaultValue(False)>
    <Browsable(True)>
    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set
            MyBase.AutoSize = Value
        End Set
    End Property

    <Localizable(True)>
    Public Property PromptText As String
        Get
            Return MCue
        End Get

        Set(ByVal value As String)
            MCue = value
            UpdateCue()
        End Set
    End Property

    Private Sub UpdateCue()
        If Me.IsHandleCreated AndAlso MCue IsNot Nothing Then
            SendMessage(Me.Handle, 5377, CType(1, IntPtr), MCue)
        End If
    End Sub

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        UpdateCue()
    End Sub

    Private MCue As String

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As String) As IntPtr
    End Function

    Public Sub New()
        MyBase.New()
        AutoSize = False
    End Sub

End Class
