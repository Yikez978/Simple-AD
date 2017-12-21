Public Class FormOptions

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpCb.Checked = My.Settings.UsePaging
        ProxyToggle.Checked = My.Settings.UseProxy
        AutoLoginToggle.Checked = My.Settings.AutoLogin
        IconsToggle.Checked = My.Settings.UseSystemIcons
        WindowsStylingToggle.Checked = My.Settings.UseNativeWindowsTheme

        If My.Settings.ManualLogin = False Then
            ManualRadioBn.Checked = False
            UsernameTb.Enabled = False
            PasswordTb.Enabled = False
        Else
            ManualRadioBn.Checked = True
            UsernameTb.Enabled = True
            PasswordTb.Enabled = True
        End If

        If LoginUsername IsNot Nothing Then
            UsernameTb.Text = Unprotect(My.Settings.Username, "Letme1n$")
        End If
        If LoginPassword IsNot Nothing Then
            PasswordTb.Text = LoginPassword
        End If

        AutoRadioBn.Checked = Not ManualRadioBn.Checked

        MainTabControl.SelectedTab = MainTabControl.TabPages.Item(0)

    End Sub

    Private Sub OKBt_Click(sender As Object, e As EventArgs) Handles OKBt.Click

        Hide()

        If ManualRadioBn.Checked = True Then
            If Not String.IsNullOrEmpty(UsernameTb.Text) And Not String.IsNullOrEmpty(PasswordTb.Text) Then

                My.Settings.Username = Protect(UsernameTb.Text, "Letme1n$")
                My.Settings.Password = Protect(PasswordTb.Text, "Letme1n$")

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

    Private Sub IconsToggle_CheckedChanged(sender As Object, e As EventArgs) Handles IconsToggle.CheckedChanged
        My.Settings.UseSystemIcons = IconsToggle.Checked
        My.Settings.Save()
    End Sub

    Private Sub WindowsStylingToggle_CheckedChanged(sender As Object, e As EventArgs) Handles WindowsStylingToggle.CheckedChanged
        My.Settings.UseNativeWindowsTheme = WindowsStylingToggle.Checked
        My.Settings.Save()
    End Sub

    Private Sub ManualRadioBn_CheckedChanged(sender As Object, e As EventArgs) Handles ManualRadioBn.CheckedChanged
        UsernameTb.Enabled = Not UsernameTb.Enabled
        PasswordTb.Enabled = Not PasswordTb.Enabled
    End Sub
End Class