Public Class FormOptions

    Private _ForcePwdReset As Boolean
    Private _CreateHomeFolders As Boolean
    Private _EnableNewAccounts As Boolean

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _ForcePwdReset = GlobalVariables.ForcePwdReset
        _CreateHomeFolders = GlobalVariables.CreateHomeFolders
        _EnableNewAccounts = GlobalVariables.EnableNewAccounts

        FpCb.Checked = GlobalVariables.ForcePwdReset
        ChCb.Checked = GlobalVariables.CreateHomeFolders
        EaCb.Checked = GlobalVariables.EnableNewAccounts

        LaCb.Checked = My.Settings.LoadAdvLDAP
        URITb.Text = My.Settings.OfficeURI
        ShellURITb.Text = My.Settings.OfficeShellURI
        ProxyToggle.Checked = My.Settings.UseProxy

        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)

    End Sub

    Private Sub OKBt_Click(sender As Object, e As EventArgs) Handles OKBt.Click

        Hide()

        GlobalVariables.ForcePwdReset = FpCb.Checked
        GlobalVariables.CreateHomeFolders = ChCb.Checked
        GlobalVariables.EnableNewAccounts = EaCb.Checked

        My.Settings.LoadAdvLDAP = LaCb.Checked
        My.Settings.OfficeURI = URITb.Text.Trim
        My.Settings.OfficeShellURI = ShellURITb.Text.Trim

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
    End Sub

    Private Sub ResetShellURIBn_Click(sender As Object, e As EventArgs) Handles ResetShellURIBn.Click
        My.Settings.OfficeShellURI = "http://schemas.microsoft.com/powershell/Microsoft.Exchange"
        ShellURITb.Text = "http://schemas.microsoft.com/powershell/Microsoft.Exchange"
    End Sub

    Private Sub ProxyToggle_CheckedChanged(sender As Object, e As EventArgs) Handles ProxyToggle.CheckedChanged
        My.Settings.UseProxy = ProxyToggle.Checked
    End Sub
End Class