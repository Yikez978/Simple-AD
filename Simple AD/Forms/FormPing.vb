Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports BrightIdeasSoftware
Imports SimpleLib

Public Class FormPing

    Public Property PingTask As TaskPing
    Public Property Computer As ComputerDomainObject

    Public Shadows Event FormClosed()

    Public Sub New(Task As TaskPing, ComputerObject As ComputerDomainObject)
        InitializeComponent()

        PingTask = Task
        Computer = ComputerObject

        TitleLb.Text = String.Format("Ping {0}", ComputerObject.Name)

        MainListView.SetListStyle()
        LoadImages()

        TypeCol.ImageGetter = New ImageGetterDelegate(AddressOf ImageGetter)
        TypeCol.AspectGetter = New AspectGetterDelegate(Function(RowObject As Object) String.Empty)

        TTLCol.AspectGetter = New AspectGetterDelegate(
            Function(RowObject As Object)
                Return If(DirectCast(RowObject, PingListItem).TimeToLive = Nothing,
                    String.Empty, String.Format("{0} ms",
                    DirectCast(RowObject, PingListItem).TimeToLive))
            End Function)

        RTTCol.AspectGetter = New AspectGetterDelegate(
            Function(RowObject As Object)
                Return If(DirectCast(RowObject, PingListItem).RoundTripTime = -1,
                    String.Empty, String.Format("{0} ms",
                    CStr(DirectCast(RowObject, PingListItem).RoundTripTime)))
            End Function)

        BufferCol.AspectGetter = New AspectGetterDelegate(
            Function(RowObject As Object)
                Return If(DirectCast(RowObject, PingListItem).BufferSize = Nothing,
                    String.Empty, String.Format("{0} bytes",
                    DirectCast(RowObject, PingListItem).BufferSize))
            End Function)

        CountBox.SelectedIndex = 3
        IntervalBox.SelectedIndex = 2

    End Sub

    Private Sub SendBn_Click(sender As Object, e As EventArgs) Handles SendBn.Click
        If PingTask Is Nothing Then
            Exit Sub
        End If

        MainListView.Items.Clear()

        ToggleButtons()
        PingTask.SendPing()
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click

        If PingTask.IsRunning Then
            PingTask.Cancel()
        Else
            Close()
        End If

    End Sub

    Private Sub LoadImages()

        Dim Images As New ImageList()
        With Images
            .Images.Add("0", New Icon(My.Resources.Info, New Size(16, 16)).ToBitmap)
            .Images.Add("1", New Icon(My.Resources.Responce, New Size(16, 16)).ToBitmap)
            .Images.Add("2", New Icon(My.Resources.Failed, New Size(16, 16)).ToBitmap)
            .Images.Add("3", New Icon(My.Resources.Failed, New Size(16, 16)).ToBitmap)
            .ColorDepth = ColorDepth.Depth32Bit
            .ImageSize = New Size(16, 16)
        End With

        MainListView.SmallImageList = Images

    End Sub

    Public Function ImageGetter(rowObject As Object) As Object

        Dim Item As PingListItem = DirectCast(rowObject, PingListItem)
        Return CStr(Item.Type)

    End Function

    Private Sub CountBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles CountBox.SelectedValueChanged

        Dim Count As Integer

        If Integer.TryParse(CountBox.Text, Count) Then
            PingTask.PingCountMax = Count
        Else
            PingTask.PingCountMax = -1
        End If

    End Sub

    Private Sub IntervalBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles IntervalBox.SelectedValueChanged

        Select Case IntervalBox.SelectedIndex
            Case 0
                PingTask.PingInterval = 250
            Case 1
                PingTask.PingInterval = 500
            Case 2
                PingTask.PingInterval = 1000
            Case 3
                PingTask.PingInterval = 2000
            Case 4
                PingTask.PingInterval = 3000
            Case 5
                PingTask.PingInterval = 4000
        End Select

    End Sub

    Public Sub ToggleButtons()

        If CancelBn.Text = "Cancel" Then
            CancelBn.Text = "Close"
        Else
            CancelBn.Text = "Cancel"
        End If

        SendBn.Enabled = Not SendBn.Enabled
        CountBox.Enabled = Not CountBox.Enabled
        IntervalBox.Enabled = Not IntervalBox.Enabled
    End Sub

    Public Sub WritetoList(ByVal Item As PingListItem)
        MainListView.AddObject(Item)
    End Sub

    Public Sub WritetoList(ByVal Type As TaskPing.PingMessageType, ByVal message As String)
        MainListView.AddObject(New PingListItem(Type, message))
    End Sub

    Private Sub FormPing_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If PingTask Is Nothing Then
            Exit Sub
        End If

        e.Cancel = True

        TitleLb.Text = "Cancelling Ping Request..."

        MainListView.Enabled = False
        SendBn.Enabled = False
        CountBox.Enabled = False
        IntervalBox.Enabled = False

        RaiseEvent FormClosed()

    End Sub

End Class

Public Class PingListItem

    Property Type As Integer = Nothing
    Property Message As String = " - "
    Property Address As String = Nothing
    Property RoundTripTime As Long = -1
    Property TimeToLive As Integer = Nothing
    Property BufferSize As Integer = Nothing

    Public Sub New()

    End Sub

    Public Sub New(InType As Integer, InMessage As String)
        Type = InType
        Message = InMessage
    End Sub

    Public Sub New(InType As Integer, Addr As String, Rtt As Long, Ttl As Integer, BufferSz As Integer)
        Type = InType
        Address = Addr
        RoundTripTime = Rtt
        TimeToLive = Ttl
        BufferSize = BufferSz
    End Sub

End Class