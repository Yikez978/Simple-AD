Public Class FormPasswordReset

    Private _Password As String

    Public Property Password As String
        Set(value As String)
            _Password = value
        End Set
        Get
            Return _Password
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AcceptBn_Click(sender As Object, e As EventArgs) Handles AcceptBn.Click
        If Me.Password0Tb.Text = Me.Password1Tb.Text Then
            If Not String.IsNullOrEmpty(Me.Password0Tb.Text) AndAlso Not String.IsNullOrEmpty(Password1Tb.Text) Then
                Me.Password = Password1Tb.Text
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
    End Sub
End Class