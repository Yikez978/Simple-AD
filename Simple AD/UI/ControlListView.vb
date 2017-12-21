Imports System.Runtime.InteropServices

<SerializableAttribute>
Public Class ControlListView
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
        Font = SystemFonts.DefaultFont
        CellEditUseWholeCell = False
        Cursor = Cursors.Default
        EmptyListMsg = "No Results"
        Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        FullRowSelect = True
        HideSelection = False
        IncludeColumnHeadersInCopy = True
        Location = New Point(0, 0)
        RowHeight = 21
        Size = New Size(402, 271)
        TabIndex = 1
        UseFiltering = True
        View = View.Details

        If My.Settings.UseNativeWindowsTheme = True Then
            UseExplorerTheme = True
            HeaderUsesThemes = True
            OwnerDraw = False
            UseHotControls = False
            UseHotItem = False
            UseCustomSelectionColors = False
        Else

            HeaderMinimumHeight = 32

            UseExplorerTheme = False
            HeaderUsesThemes = False

            OwnerDraw = True
            UseHotControls = True
            UseHotItem = True
            UseCustomSelectionColors = True

            UseCellFormatEvents = True

            Dim HeaderStyle As HeaderFormatStyle = New HeaderFormatStyle
            Dim HeaderFont As Font = New Font("Segoe UI", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

            With HeaderStyle
                .Hot.BackColor = SystemColors.Control
                .Normal.BackColor = SystemColors.Window
                .Pressed.BackColor = Color.FromArgb(210, 206, 225)

                .Hot.ForeColor = Color.FromArgb(49, 12, 66)
                .Normal.ForeColor = Color.FromArgb(49, 12, 66)
                .Pressed.ForeColor = Color.FromArgb(49, 12, 66)

                .Hot.FrameColor = SystemColors.ControlDarkDark
                .Normal.FrameColor = SystemColors.ControlDarkDark
                .Pressed.FrameColor = SystemColors.ControlDarkDark

                .Hot.FrameWidth = 0
                .Normal.FrameWidth = 0
                .Pressed.FrameWidth = 0

                .Hot.Font = HeaderFont
                .Normal.Font = HeaderFont
                .Pressed.Font = HeaderFont

            End With

            HeaderFormatStyle = HeaderStyle

            HotItemStyle = New HotItemStyle()
            HotItemStyle.BackColor = Color.FromArgb(231, 243, 255)

            SelectedBackColor = Color.FromArgb(206, 235, 255)
            SelectedForeColor = SystemColors.ControlText

            Dim RowDeco As RowBorderDecoration = New RowBorderDecoration With {
            .BorderPen = New Pen(Color.FromArgb(156, 211, 255)),
            .BoundsPadding = New Size(0, 0),
            .FillBrush = Nothing,
            .CornerRounding = 0
            }

            SelectedRowDecoration = RowDeco

        End If

        Dim TextOverlay As New TextOverlay
        TextOverlay.TextColor = SystemColors.ControlDark
        TextOverlay.BackColor = SystemColors.ControlLightLight
        TextOverlay.BorderColor = SystemColors.ControlDark
        TextOverlay.BorderWidth = 1.0F
        TextOverlay.CornerRounding = 1.0F
        TextOverlay.Font = New Font("Segoe UI Semilight", 14.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        TextOverlay.Alignment = ContentAlignment.MiddleCenter

        EmptyListMsgOverlay = TextOverlay
    End Sub

    Public Sub ControlListView_ItemsChanged(sender As Object, e As ItemsChangedEventArgs) Handles Me.ItemsChanged
        If Items.Count > 0 Then
            UpdateContextStripText(Items.Count & " Objects")
        Else
            UpdateContextStripText("Empty")
            'ClearContext()
        End If
    End Sub

    Private Sub ControlListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles Me.ItemSelectionChanged
        If SelectedItems.Count > 1 Then
            UpdateStatusStripText(SelectedItems.Count & " Objects Selected")
        Else
            ClearStatus()
        End If
    End Sub

    Private Sub ControlListView_AboutToCreateGroups(sender As Object, e As CreateGroupsEventArgs) Handles Me.AboutToCreateGroups
        For Each Group As OLVGroup In e.Groups
            If Group.Items.Count > 3 Then
                Group.Header = String.Format("{0} ({1})", Group.Header, Group.Items.Count)
            End If
        Next
    End Sub

    Private Sub ControlListView_FormatRow(sender As Object, e As FormatCellEventArgs) Handles Me.FormatCell
        If e.ColumnIndex = 0 Then
            e.SubItem.ForeColor = SystemColors.ControlText
        Else
            e.SubItem.ForeColor = Color.FromArgb(42, 42, 42)
        End If
    End Sub
End Class
