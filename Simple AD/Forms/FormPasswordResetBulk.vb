Imports System
Imports System.Collections
Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.Drawing
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports SimpleLib

Public Class FormPasswordResetBulk

    Private _Password As String
    Private _SelectedUsers As IList
    Private _ProgressForm As FormProgressBar = New FormProgressBar("Reseting Passwords...")

    Private _UseUpper As Boolean
    Private _UseNumbers As Boolean
    Private _UseSymbols As Boolean

    Private _PasswordLength As Integer

    Private _DomainPrincipal As PrincipalContext

    Public Property Password As String
        Set(value As String)
            _Password = value
        End Set
        Get
            Return _Password
        End Get
    End Property

    Public Sub New(ByVal SelectedUsers As IList)
        InitializeComponent()

        _SelectedUsers = SelectedUsers
        SpecifyRadioBn.Checked = True
    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBn.Click

        If SpecifyRadioBn.Checked = True Then

            If Password0Tb.Text = Password1Tb.Text Then
                If Not String.IsNullOrEmpty(Me.Password0Tb.Text) AndAlso Not String.IsNullOrEmpty(Password1Tb.Text) Then

                    _Password = Password0Tb.Text

                Else
                    ErrorLb.Text = "Please enter passwords into the text boxes below."
                    ErrorLb.Visible = True
                End If
            Else
                ErrorLb.Text = "The Passwords do not match."
                ErrorLb.Visible = True
            End If
        Else

            _UseUpper = Me.UseUpperCheckBox.Checked
            _UseNumbers = Me.UseNumbersCheckBox.Checked
            _UseSymbols = Me.UseSymbolsCheckBox.Checked

            _PasswordLength = CInt(PasswordLengthTb.Text)

        End If

        Me.Enabled = False

        Dim Tasks(_SelectedUsers.Count) As Task
        _ProgressForm.Maximum = _SelectedUsers.Count
        _ProgressForm.BarStep = 1
        _ProgressForm.StatusLb.Text = "Running Batch Password Reset Operation..."
        _ProgressForm.Show()

        _DomainPrincipal = GetPrincipalContext()

        For i As Integer = 0 To _SelectedUsers.Count - 1

            Dim Iterator As Integer = i
            Dim User As UserDomainObject = CType(_SelectedUsers(i), UserDomainObject)

            Try
                Select Case SpecifyRadioBn.Checked
                    Case True
                        Tasks(i) = Task.Run(Sub() ResetUserPasswordBulk(User, _Password, ForceResetToggle.Checked, UnlockToggle.Checked))
                    Case False
                        Tasks(i) = Task.Run(Sub() ResetUserPasswordBulk(User, GeneratePassword(), ForceResetToggle.Checked, UnlockToggle.Checked))
                End Select

            Catch Ex As Exception
                Logger.Log("[Error] Unable to Set Password for User " & User.Name & ": " & Ex.Message)
            End Try
        Next

    End Sub

    Public Sub ResetUserPasswordBulk(ByVal UserObject As UserDomainObject, ByVal Password As String, ForceReset As Boolean, UnlockAccount As Boolean)
        Logger.Log("[Info] Password reset requested on object: " & UserObject.Name)

        Dim Result = New SimpleResult

        Using userEntry As DirectoryEntry = GetDirEntryFromDomainObject(UserObject)

            'Setting user password
            Dim oPassword As Object() = New Object() {UserObject.Password}
            Dim Ret As Object = userEntry.Invoke("SetPassword", oPassword)

            If UnlockAccount Then
                userEntry.Properties("LockOutTime").Value = 0
            End If

            userEntry.CommitChanges()

            If UserObject.ForcePasswordReset Then
                'Forcing user to change password on next logon
                userEntry.Properties("pwdLastSet").Value = 0
                userEntry.CommitChanges()
            End If

            Result.IsSuccess = True

        End Using

        PasswordResetFinished()
    End Sub

    Private Sub PasswordResetFinished()
        If _ProgressForm.InvokeRequired Then
            _ProgressForm.Invoke(New Action(AddressOf PasswordResetFinished))
        Else
            _ProgressForm.MainProgressBar.PerformStep()
            If _ProgressForm.MainProgressBar.Value = _ProgressForm.MainProgressBar.Maximum Then
                _ProgressForm.Close()
                Close()
            End If
        End If
    End Sub

    Private Function GeneratePassword() As String
        Dim Upper As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim Lower As String = "abcdefghijklmnopqrstuvwxyz"
        Dim Numbers As String = "0123456789"
        Dim Symbols As String = "!£$%^&*()@#?/[]|"

        Dim Rand As New Random

        Dim PasswordCharBuilder As New StringBuilder
        PasswordCharBuilder.Append(Lower)

        If _UseUpper = True Then
            PasswordCharBuilder.Append(Upper)
        End If
        If _UseNumbers = True Then
            PasswordCharBuilder.Append(Numbers)
        End If
        If _UseSymbols = True Then
            PasswordCharBuilder.Append(Symbols)
        End If

        Dim PasswordChars As String = PasswordCharBuilder.ToString
        Dim PasswordBuilder As New StringBuilder

        For i As Integer = 1 To _PasswordLength
            Dim idx As Integer = Rand.Next(0, PasswordChars.Length)
            PasswordBuilder.Append(PasswordChars.Substring(idx, 1))
        Next

        Return PasswordBuilder.ToString()

    End Function

#Region "Event Handlers"
    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Passwords_TextChanged(sender As Object, e As EventArgs) Handles Password0Tb.TextChanged, Password1Tb.TextChanged
        If ErrorLb.Visible = True Then
            ErrorLb.Visible = False
        End If
    End Sub

    Private Sub SpecifyRadioBn_CheckedChanged(sender As Object, e As EventArgs) Handles SpecifyRadioBn.CheckedChanged
        If Me.SpecifyRadioBn.Checked = True Then
            For Each Item As Control In SpecifyPl.Controls
                Item.Enabled = True
            Next
            For Each Item As Control In GeneratePl.Controls
                Item.Enabled = False
            Next
        Else
            For Each Item As Control In GeneratePl.Controls
                Item.Enabled = True
            Next
            For Each Item As Control In SpecifyPl.Controls
                Item.Enabled = False
            Next
        End If
    End Sub

    Private Sub FooterPl_Paint(sender As Object, e As PaintEventArgs) Handles FooterPl.Paint
        Dim s As Panel = FooterPl
        If Not s Is Nothing Then
            Dim Pen As New Pen(Color.FromArgb(217, 217, 217))
            e.Graphics.DrawLine(Pen, 0, 0, s.Width, 0)
        End If
    End Sub

#End Region

End Class