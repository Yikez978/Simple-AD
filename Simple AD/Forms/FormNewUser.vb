Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework.Controls
Imports SimpleLib

Public Class FormNewUser

    Public Property User As New UserDomainObject
    Public Property ContainerPath As String
        Set(value As String)
            ContainerLb.Text = GetContainerPathShort(value)
        End Set
        Get
            Return ContainerLb.Text
        End Get
    End Property

    Public Sub New()

        InitializeComponent()

        DialogResult = DialogResult.Cancel

        MainPb.Image = New Icon(My.Resources.CreateUser, New Size(96, 96)).ToBitmap
        ContainerPb.Image = New Icon(My.Resources.Container, New Size(16, 16)).ToBitmap

        MainTabControl.SelectedTab = MainTabControl.TabPages(0)

        AddHandler FnTb.TextChanged, AddressOf NameInputChanged
        AddHandler SnTb.TextChanged, AddressOf NameInputChanged

        For Each Control As Control In Controls
            If Control.GetType = GetType(ControlTextBox) Then
                AddHandler Control.TextChanged, AddressOf InputChanged
            End If
        Next

    End Sub

    Private Sub OKBn_Click(sender As Object, e As EventArgs) Handles OkBn.Click

        If ValidateInput() = True Then

            With User
                .Name = FullnTb.Text
                .SAMAccountName = UsernameTb.Text
                .Password = Pass0Tb.Text

                .GivenName = FnTb.Text
                .Sn = SnTb.Text
                .DisplayName = FullnTb.Text

                .ForcePasswordReset = ChangePassCb.Checked
                .CannotChangePassword = CannotChangePassCb.Checked
                .PasswordNeverExpires = PassNeverExpiresCb.Checked
                .EnableAccount = Not AccountDisabledCb.Checked
            End With

            DialogResult = DialogResult.Yes
        Else

            ErrorLb.Visible = True

        End If

    End Sub

    Private Function ValidateInput() As Boolean

        Dim IsValidated As Boolean = True

        For Each Control As Control In Controls
            If Control.GetType = GetType(ControlTextBox) Then
                Dim ControlTb As ControlTextBox = DirectCast(Control, ControlTextBox)

                If String.IsNullOrEmpty(ControlTb.Text) Then
                    IsValidated = False
                End If
            End If
        Next

        If Not Pass0Tb.Text = Pass1Tb.Text Then
            IsValidated = False
        End If

        Return IsValidated

    End Function

    Private Sub NameInputChanged(sender As Object, e As EventArgs)
        FullnTb.Text = String.Format("{0} {1}", FnTb.Text, SnTb.Text)
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs)
        ErrorLb.Visible = False
    End Sub

    Private Function GetContainerPathShort(ByVal Path As String) As String
        Dim sDelimStart As String = "="
        Dim sDelimEnd As String = ","
        Dim nIndexStart As Integer = Path.IndexOf(sDelimStart)
        Dim nIndexEnd As Integer = Path.IndexOf(sDelimEnd)

        Dim Result As String = Mid(Path, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length)

        Return Result
    End Function

    Private Sub ContainerLb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ContainerLb.LinkClicked

        Dim MoveForm As FormMoveObject = New FormMoveObject
        MoveForm.StartPosition = FormStartPosition.CenterScreen
        MoveForm.ShowDialog()

        If MoveForm.DialogResult = DialogResult.Yes Then
            ContainerPath = MoveForm.SelecetdOU
        End If

    End Sub
End Class