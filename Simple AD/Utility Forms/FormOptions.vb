Public Class FormOptions

    Private _ForcePwdReset As Boolean
    Private _CreateHomeFolders As Boolean
    Private _EnableNewAccounts As Boolean

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _ForcePwdReset = ForcePwdReset
        _CreateHomeFolders = CreateHomeFolders
        _EnableNewAccounts = EnableNewAccounts

        FpCb.Checked = ForcePwdReset
        ChCb.Checked = CreateHomeFolders
        EaCb.Checked = EnableNewAccounts

        'My.Settings.Reload()

        LaCb.Checked = My.Settings.LoadAdvLDAP
        URITb.Text = My.Settings.OfficeURI
        ShellURITb.Text = My.Settings.OfficeShellURI
        ProxyToggle.Checked = My.Settings.UseProxy
        AutoLoginToggle.Checked = My.Settings.AutoLogin
        IconsToggle.Checked = My.Settings.UseSystemIcons
        UseDataGridToggle.Checked = My.Settings.UseDataGrid

        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)

    End Sub

    Private Sub OKBt_Click(sender As Object, e As EventArgs) Handles OKBt.Click

        Hide()

        ForcePwdReset = FpCb.Checked
        CreateHomeFolders = ChCb.Checked
        EnableNewAccounts = EaCb.Checked

        My.Settings.LoadAdvLDAP = LaCb.Checked
        My.Settings.OfficeURI = URITb.Text.Trim
        My.Settings.OfficeShellURI = ShellURITb.Text.Trim
        My.Settings.Save()
        Close()

    End Sub

    Private Sub CnBt_Click(sender As Object, e As EventArgs) Handles CnBt.Click
        FpCb.Checked = _ForcePwdReset
        ChCb.Checked = _CreateHomeFolders
        EaCb.Checked = _EnableNewAccounts

        Close()
    End Sub

    Private Sub ResetURIBn_Click(sender As Object, e As EventArgs) Handles ResetURIBn.Click
        My.Settings.OfficeURI = "https://ps.outlook.com/PowerShell-LiveID?PSVersion=2.0"
        URITb.Text = "https://ps.outlook.com/PowerShell-LiveID?PSVersion=2.0"
        My.Settings.Save()
    End Sub

    Private Sub ResetShellURIBn_Click(sender As Object, e As EventArgs) Handles ResetShellURIBn.Click
        My.Settings.OfficeShellURI = "http://schemas.microsoft.com/powershell/Microsoft.Exchange"
        ShellURITb.Text = "http://schemas.microsoft.com/powershell/Microsoft.Exchange"
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

    Private Sub UseDataGridToggle_CheckedChanged(sender As Object, e As EventArgs) Handles UseDataGridToggle.CheckedChanged
        My.Settings.UseDataGrid = UseDataGridToggle.Checked
        My.Settings.Save()
    End Sub
End Class