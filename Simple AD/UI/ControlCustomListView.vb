Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Imports BrightIdeasSoftware

Public Class ControlCustomListView
    Inherits ObjectListView

    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SetWindowTheme(hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer
    End Function


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    End Function

    Private Const WM_CHANGEUISTATE As Integer = 295
    Private Const UIS_SET As Integer = 1
    Private Const UISF_HIDEFOCUS As Integer = 1

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()

        SendMessage(Me.Handle, WM_CHANGEUISTATE, MakeLong(UIS_SET, UISF_HIDEFOCUS), 0)
        SetWindowTheme(Handle, "explorer", Nothing)
    End Sub

    Private Function MakeLong(ByVal wLow As Integer, ByVal wHigh As Integer) As Integer
        Dim low As Integer = CInt(IntLoWord(wLow))
        Dim high As Short = IntLoWord(wHigh)
        Dim product As Integer = 65536 * CInt(high)
        Dim mkLong As Integer = CInt((low Or product))
        Return mkLong
    End Function

    Private Function IntLoWord(ByVal word As Integer) As Short
        Return CShort((word And Short.MaxValue))
    End Function

    Public Sub SetListStyle()

        Font = SystemFonts.DefaultFont
        CellEditUseWholeCell = False
        Cursor = Cursors.Default
        EmptyListMsg = "No Results"

        FullRowSelect = True
        BorderStyle = BorderStyle.Fixed3D
        HideSelection = False
        IncludeColumnHeadersInCopy = True
        RowHeight = 21
        TabIndex = 1
        UseFiltering = True
        View = View.Details

        UseExplorerTheme = True
        HeaderUsesThemes = True
        OwnerDraw = False
        UseHotControls = False
        UseHotItem = False
        UseCustomSelectionColors = False
        HeaderMinimumHeight = 18
        HeaderMaximumHeight = -1

        Dim TextOverlay As New TextOverlay

        With TextOverlay
            .TextColor = SystemColors.ControlDark
            .BackColor = SystemColors.ControlLightLight
            .BorderColor = SystemColors.ControlDark
            .BorderWidth = 1.0F
            .CornerRounding = 1.0F
            .Font = New Font("Segoe UI Semilight", 14.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            .Alignment = ContentAlignment.MiddleCenter
        End With

        EmptyListMsgOverlay = TextOverlay

    End Sub

End Class
