Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Imports BrightIdeasSoftware
Imports SimpleLib

Public Class ControlDomainListView
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

    Public Property RowContextMenu As ContextMenu
    Public Property OffRowContextMenu As ContextMenu

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

        LoadImages()

        Font = SystemFonts.DefaultFont
        CellEditUseWholeCell = False
        Cursor = Cursors.Default
        EmptyListMsg = "No Results"

        FullRowSelect = True
        HideSelection = False
        IncludeColumnHeadersInCopy = True
        Location = New Point(0, 0)
        RowHeight = 21
        Size = New Size(402, 271)
        TabIndex = 1
        UseFiltering = True
        View = View.Details

        ShowGroups = True
        UseExplorerTheme = True
        HeaderUsesThemes = True
        OwnerDraw = False
        UseHotControls = False
        UseHotItem = False
        UseCustomSelectionColors = False
        HeaderMinimumHeight = 21

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

        If AllColumns.Count > 0 Then
            AllColumns(0).ImageGetter = New ImageGetterDelegate(AddressOf NameImageGetter)
        End If

        EmptyListMsgOverlay = TextOverlay

        Activation = ItemActivation.Standard

    End Sub

    Public Sub AttachToStatusBar()
        AddHandler ItemsChanged, AddressOf ControlListView_ItemsChanged
        AddHandler ItemSelectionChanged, AddressOf ControlListView_ItemSelectionChanged
    End Sub

    Public Sub ControlListView_ItemsChanged(sender As Object, e As ItemsChangedEventArgs)
        If Items.Count > 0 Then
            UpdateContextStripText(Items.Count & " Objects")
        Else
            UpdateContextStripText("Empty")
        End If
    End Sub

    Private Sub ControlListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
        If SelectedItems.Count > 1 Then
            UpdateStatusStripText(SelectedItems.Count & " Objects Selected")
        Else
            ClearStatus()
        End If
    End Sub

    Private Sub ControlListView_AboutToCreateGroups(sender As Object, e As CreateGroupsEventArgs) Handles Me.AboutToCreateGroups
        For Each Group As OLVGroup In e.Groups
            If Group.Items.Count > 1 Then
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

    Private Sub MainListView_CellRightClick(sender As Object, e As CellRightClickEventArgs) Handles Me.CellRightClick
        If e.Model IsNot Nothing Then
            Dim DomainObject As DomainObject = DirectCast(e.Model, DomainObject)
            GetListViewConextMenu(Me, e, RowContextMenu, Me, DomainObject)
        Else
            GetListViewConextMenu(Me, e, OffRowContextMenu, Me, Nothing)
        End If
    End Sub

    Private Sub LoadImages()

        Dim Images As New ImageList()
        With Images
            .Images.Add("Container", New Icon(My.Resources.Container, New Size(16, 16)).ToBitmap)
            .Images.Add("Domain", New Icon(My.Resources.Domain, New Size(16, 16)).ToBitmap)
            .Images.Add("OrganizationalUnit", New Icon(My.Resources.Container, New Size(16, 16)).ToBitmap)
            .Images.Add("Group", New Icon(My.Resources.Group, New Size(16, 16)).ToBitmap)
            .Images.Add("Computer", New Icon(My.Resources.Computer, New Size(16, 16)).ToBitmap)
            .Images.Add("User", New Icon(My.Resources.User, New Size(16, 16)).ToBitmap)
            .Images.Add("UserDisabled", New Icon(My.Resources.UserDisabled, New Size(16, 16)).ToBitmap)
            .Images.Add("Contact", New Icon(My.Resources.Contact, New Size(16, 16)).ToBitmap)
            .Images.Add("Unknown", New Icon(My.Resources.Unknown, New Size(16, 16)).ToBitmap)
            .Images.Add("Hidden", New Icon(My.Resources.DataProtection, New Size(16, 16)).ToBitmap)
            .Images.Add("builtinDomain", New Icon(My.Resources.Builtin, New Size(16, 16)).ToBitmap)
            .Images.Add("lostAndFound", New Icon(My.Resources.LostAndFound, New Size(16, 16)).ToBitmap)
            .Images.Add("msDS-QuotaContainer", New Icon(My.Resources.Quota, New Size(16, 16)).ToBitmap)
            .Images.Add("msTPM-InformationObjectsContainer", New Icon(My.Resources.SecurityLock, New Size(16, 16)).ToBitmap)
            .Images.Add("msExchSystemObjectsContainer", New Icon(My.Resources.Message, New Size(16, 16)).ToBitmap)
            .ColorDepth = ColorDepth.Depth32Bit
            .ImageSize = New Size(16, 16)
        End With

        SmallImageList = Images

    End Sub

    Public Function ImageGetter(rowObject As Object) As Object

        Dim DomainObject As DomainObject = DirectCast(rowObject, DomainObject)
        Return DomainObject.ImageKey

    End Function

End Class
