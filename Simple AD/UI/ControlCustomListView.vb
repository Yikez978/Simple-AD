Imports System.Runtime.InteropServices

Public Class ControlCustomListView
    Inherits ObjectListView

    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SetWindowTheme(hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer
    End Function

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()

        If My.Settings.UseNativeWindowsTheme = True Then
            SetWindowTheme(Handle, "explorer", Nothing)
        End If
    End Sub

    Public Sub SetListStyle()

        If My.Settings.UseNativeWindowsTheme = True Then
            UseExplorerTheme = True
            HeaderUsesThemes = True
            OwnerDraw = False
            UseHotControls = False
            UseHotItem = False
            UseCustomSelectionColors = False
        Else

            HotItemStyle = New HotItemStyle()
            HotItemStyle.BackColor = Color.FromArgb(210, 206, 225)

            SelectedBackColor = Color.FromArgb(100, 18, 99)

        End If

        HeaderUsesThemes = False

        Dim HeaderStyle As HeaderFormatStyle = New HeaderFormatStyle
        Dim HeaderFont As Font = New Font("Segoe UI", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        With HeaderStyle
            .Hot.BackColor = SystemColors.Control
            .Normal.BackColor = SystemColors.Window
            .Pressed.BackColor = Color.FromArgb(210, 206, 225)

            .Hot.ForeColor = Color.FromArgb(49, 12, 66)
            .Normal.ForeColor = Color.FromArgb(49, 12, 66)
            .Pressed.ForeColor = Color.FromArgb(49, 12, 66)

            .Hot.FrameWidth = 0
            .Normal.FrameWidth = 0
            .Pressed.FrameWidth = 0

            .Hot.Font = HeaderFont
            .Normal.Font = HeaderFont
            .Pressed.Font = HeaderFont

        End With

        HeaderFormatStyle = HeaderStyle

    End Sub

End Class
