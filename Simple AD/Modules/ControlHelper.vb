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

End Module
