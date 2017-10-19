Public Class FormOptions

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LaCb.Checked = My.Settings.LoadAdvLDAP
        ProxyToggle.Checked = My.Settings.UseProxy
        AutoLoginToggle.Checked = My.Settings.AutoLogin
        IconsToggle.Checked = My.Settings.UseSystemIcons

        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)

    End Sub

    Private Sub OKBt_Click(sender As Object, e As EventArgs) Handles OKBt.Click

        Hide()

        My.Settings.LoadAdvLDAP = LaCb.Checked
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

End Class