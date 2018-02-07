Imports System

Public Class FormPasswordReset

    Public Property Password As String
    Public Property UnlockAccount As Boolean

    Public Sub New()
        InitializeComponent()

        Password0Tb.Select()
    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBn.Click
        If Me.Password0Tb.Text = Me.Password1Tb.Text Then
            If Not String.IsNullOrEmpty(Me.Password0Tb.Text) AndAlso Not String.IsNullOrEmpty(Password1Tb.Text) Then
                Me.Password = Password1Tb.Text
                Me.UnlockAccount = UnlockCb.Checked
                Me.DialogResult = DialogResult.Yes
            Else
                ErrorLb.Text = "Please enter passwords into the text boxes below."
                ErrorLb.Visible = True
            End If
        Else
            ErrorLb.Text = "The Passwords do not match."
            ErrorLb.Visible = True
        End If
    End Sub

    Private Sub CancelBn_Click(sender As Object, e As EventArgs) Handles CancelBn.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Passwords_TextChanged(sender As Object, e As EventArgs) Handles Password0Tb.TextChanged, Password1Tb.TextChanged
        If ErrorLb.Visible = True Then
            ErrorLb.Visible = False
        End If

        Dim passwordStrengthScore As PasswordScore = PasswordAdvisor.CheckStrength(Password0Tb.Text)

        Select Case passwordStrengthScore
            Case PasswordScore.Blank
                PwdProgressBar.Value = 0
            Case PasswordScore.TooShort
                PwdProgressBar.Value = 12
            Case PasswordScore.RequirementsNotMet
                PwdProgressBar.Value = 24
            Case PasswordScore.VeryWeak
                PwdProgressBar.Value = 32
            Case PasswordScore.Weak
                PwdProgressBar.Value = 40
            Case PasswordScore.Fair
                PwdProgressBar.Value = 52
            Case PasswordScore.Medium
                PwdProgressBar.Value = 64
            Case PasswordScore.Strong
                PwdProgressBar.Value = 72
            Case PasswordScore.VeryStrong
                PwdProgressBar.Value = 100
        End Select

        ScoreLb.Text = passwordStrengthScore.ToString

    End Sub
End Class