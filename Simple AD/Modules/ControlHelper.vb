Imports System.Drawing
Imports System.Windows.Forms

Module ControlHelper

    Public Function FindControlAtPoint(container As Control, pos As Point) As Control
        Dim child As Control


        For Each c As Control In container.Controls

            If c.Visible = True And c.Bounds.Contains(pos) Then
                child = FindControlAtPoint(c, New Point(pos.X - c.Left, pos.Y - c.Top))
                If Not child Is Nothing Then
                    Return c
                Else
                    Return child
                End If
            End If
        Next

        Return Nothing
    End Function

    Public Function FindControlAtCursor(form As Form) As Control

        Dim pos As Point = Cursor.Position
        If (form.Bounds.Contains(pos)) Then
            Return FindControlAtPoint(form, form.PointToClient(pos))
        End If
        Return Nothing
    End Function


    Private Const WM_SETREDRAW As Integer = 11

    ''' <summary>
    ''' Suspends painting for the target control. Do NOT forget to call EndControlUpdate!!!
    ''' </summary>
    ''' <param name="control">visual control</param>
    Public Sub BeginControlUpdate(control As Control)
        Dim msgSuspendUpdate As Message = Message.Create(control.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero)

        Dim window As NativeWindow = NativeWindow.FromHandle(control.Handle)
        window.DefWndProc(msgSuspendUpdate)
    End Sub

    ''' <summary>
    ''' Resumes painting for the target control. Intended to be called following a call to BeginControlUpdate()
    ''' </summary>
    ''' <param name="control">visual control</param>
    Public Sub EndControlUpdate(control As Control)
        ' Create a C "true" boolean as an IntPtr
        Dim wparam As New IntPtr(1)
        Dim msgResumeUpdate As Message = Message.Create(control.Handle, WM_SETREDRAW, wparam, IntPtr.Zero)

        Dim window As NativeWindow = NativeWindow.FromHandle(control.Handle)
        window.DefWndProc(msgResumeUpdate)
        control.Invalidate()
        control.Refresh()
    End Sub

End Module
