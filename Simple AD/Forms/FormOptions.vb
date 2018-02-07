Imports SimpleLib.SystemHelper

Public Class FormOptions

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpCb.Checked = My.Settings.UsePaging
        ProxyToggle.Checked = My.Settings.UseProxy
        AutoLoginToggle.Checked = My.Settings.AutoLogin

        If My.Settings.ManualLogin = False Then
            ManualRadioBn.Checked = False
            UsernameTb.Enabled = False
            PasswordTb.Enabled = False
        Else
            ManualRadioBn.Checked = True
            UsernameTb.Enabled = True
            PasswordTb.Enabled = True
        End If

        If SimpleLib.LoginUsername IsNot Nothing Then
            UsernameTb.Text = DataProtection.Unprotect(My.Settings.Username, "Letme1n$")
        End If
        If SimpleLib.LoginPassword IsNot Nothing Then
            PasswordTb.Text = SimpleLib.LoginPassword
        End If

        AutoRadioBn.Checked = Not ManualRadioBn.Checked

        MainTabControl.SelectedTab = MainTabControl.TabPages.Item(0)

    End Sub

    Private Sub OKBt_Click(sender As Object, e As EventArgs) Handles OKBt.Click

        Hide()

        If ManualRadioBn.Checked = True Then
            If Not String.IsNullOrEmpty(UsernameTb.Text) And Not String.IsNullOrEmpty(PasswordTb.Text) Then

                My.Settings.Username = DataProtection.Protect(UsernameTb.Text, "Letme1n$")
                My.Settings.Password = DataProtection.Protect(PasswordTb.Text, "Letme1n$")

                My.Settings.ManualLogin = True

            End If
        End If

        My.Settings.UsePaging = UpCb.Checked
        My.Settings.Save()
        Close()

    End Sub

    Private Sub CnBt_Click(sender As Object, e As EventArgs) Handles CnBt.Click
        Close()
    End Sub

    Private Sub ProxyToggle_CheckedChanged(sender As Object, e As EventArgs) Handles ProxyToggle.CheckedChanged
        My.Settings.UseProxy = ProxyToggle.Checked
        My.Settings.Save()
    End Sub

    Private Sub AutoLoginToggle_CheckedChanged(sender As Object, e As EventArgs) Handles AutoLoginToggle.CheckedChanged
        My.Settings.AutoLogin = AutoLoginToggle.Checked
        My.Settings.Save()
    End Sub

    Private Sub ManualRadioBn_CheckedChanged(sender As Object, e As EventArgs) Handles ManualRadioBn.CheckedChanged
        UsernameTb.Enabled = Not UsernameTb.Enabled
        PasswordTb.Enabled = Not PasswordTb.Enabled
    End Sub
End Class