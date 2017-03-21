Public Class frmSettings

#Region "Base"

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set position/size of window
        Top = 0
        Left = 0
        Size = New Size(Movieo.Size)

        'General
        cmboboxStartScreen.SelectedIndex = My.Settings.doStartScr
        chckFilters.Checked = My.Settings.doFilters
        cmboboxWatchedMovies.SelectedIndex = My.Settings.doWatchedMovies

        'Playback
        chckPlayFullscr.Checked = My.Settings.doFullScr

        'Features
        chckWatchList.Checked = My.Settings.doWatchList
        chckRandomizeBtn.Checked = My.Settings.doRndmBtn

        'Database
        chckBackupDb.Checked = My.Settings.doBackupDb
        txtDbDir.Text = Movieo.pathBackupDatabase

        'Connection
        rdioAutoProxy.Checked = My.Settings.doAutoProxy
        rdioManualProxy.Checked = My.Settings.doManualProxy
        txtProxyAddress.Text = My.Settings.webProxyAddress
        txtProxyPort.Text = My.Settings.webProxyPort
        txtProxyUsername.Text = My.Settings.webProxyUsername
        txtProxyPassword.Text = My.Settings.webProxyPassword

        'Miscellaneous
        chckAutoUpdate.Checked = My.Settings.doAutoUpdate
        chckCelebr8.Checked = My.Settings.doCelebr8
    End Sub

    'Close window image
    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles MeClose.MouseMove
        MeClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles MeClose.MouseLeave
        MeClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub MeClose_MouseClick(sender As Object, e As EventArgs) Handles MeClose.MouseClick
        Close()
    End Sub

    'Prevent lag on scroll
    Private Sub MyBase_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        sender.update()
    End Sub

#End Region

#Region "General"

    Private Sub chkAlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlwaysOnTop.CheckedChanged
        My.Settings.doOnTop = chkAlwaysOnTop.Checked
        Movieo.TopMost = True
    End Sub

    Private Sub chkShowRating_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowRating.CheckedChanged
        My.Settings.doRatingOnPoster = chkShowRating.Checked
    End Sub

    Private Sub cmboTxtStartScreen_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboTxtStartScreen.ClickButtonArea
        cmboboxStartScreen.DroppedDown = True
    End Sub

    Private Sub cmboboxStartScreen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxStartScreen.SelectedIndexChanged
        cmboTxtStartScreen.Text = cmboboxStartScreen.SelectedItem.ToString
        My.Settings.doStartScr = cmboboxStartScreen.SelectedIndex
    End Sub

    Private Sub chckFilters_CheckedChanged(sender As Object, e As EventArgs) Handles chckFilters.CheckedChanged
        My.Settings.doFilters = chckFilters.Checked
    End Sub

    Private Sub cmboTxtWatchedMovies_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboTxtWatchedMovies.ClickButtonArea
        cmboboxWatchedMovies.DroppedDown = True
    End Sub

    Private Sub cmboboxWatchedMovies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxWatchedMovies.SelectedIndexChanged
        cmboTxtWatchedMovies.Text = cmboboxWatchedMovies.SelectedItem.ToString
        My.Settings.doWatchedMovies = cmboboxWatchedMovies.SelectedIndex
    End Sub

#End Region

#Region "Quality"

    Private Sub chkShowMovieQuality_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowMovieQuality.CheckedChanged
        My.Settings.doQualityOnPoster = chkShowMovieQuality.Checked
    End Sub

#End Region

#Region "Playback"

    Private Sub chckPlayFullscr_CheckedChanged(Sender As Object, e As EventArgs) Handles chckPlayFullscr.CheckedChanged
        My.Settings.doFullScr = chckPlayFullscr.Checked
    End Sub

#End Region

#Region "Features"

    Private Sub chckWatchList_CheckedChanged(Sender As Object, e As EventArgs) Handles chckWatchList.CheckedChanged
        My.Settings.doWatchList = chckWatchList.Checked
    End Sub

    Private Sub chckRandomizeBtn_CheckedChanged(Sender As Object, e As EventArgs) Handles chckRandomizeBtn.CheckedChanged
        My.Settings.doRndmBtn = chckRandomizeBtn.Checked
    End Sub

#End Region

#Region "Database"

    Private Sub chckBackupDb_CheckedChanged(sender As Object, e As EventArgs) Handles chckBackupDb.CheckedChanged
        My.Settings.doBackupDb = chckBackupDb.Checked
    End Sub

    Private Sub btnDbExport_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDbExport.ClickButtonArea
        Dim ab As New SaveFileDialog
        If ab.ShowDialog = DialogResult.OK Then
            Try
                Movieo.NetDl.DownloadFile(Movieo.linkDatabase, ab.FileName)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub imgOpenFolder_Click(Sender As Object, e As EventArgs) Handles imgOpenFolder.Click
        Movieo.ShowFile(txtDbDir.Text)
    End Sub

    Private Sub imgOpenFolder_MouseMove(Sender As Object, e As MouseEventArgs) Handles imgOpenFolder.MouseMove
        imgOpenFolder.Image = My.Resources.BrowseIconH
    End Sub

    Private Sub imgOpenFolder_MouseLeave(Sender As Object, e As EventArgs) Handles imgOpenFolder.MouseLeave
        imgOpenFolder.Image = My.Resources.BrowseIconL
    End Sub

#End Region

#Region "Connection"

    Private Sub rdioAutoProxy_CheckedChanged(sender As Object, e As EventArgs) Handles rdioAutoProxy.CheckedChanged
        My.Settings.doAutoProxy = rdioAutoProxy.Checked

        txtProxyAddress.Enabled = False
        txtProxyAddressBg.Enabled = False
        txtProxyPassword.Enabled = False
        txtProxyPasswordBg.Enabled = False
        txtProxyPort.Enabled = False
        txtProxyPortBg.Enabled = False
        txtProxyUsername.Enabled = False
        txtProxyUsernameBg.Enabled = False

        lblProxyAddress.Enabled = False
        lblProxyPassword.Enabled = False
        lblProxyPort.Enabled = False
        lblProxyUsername.Enabled = False
    End Sub

    Private Sub rdioManualProxy_CheckedChanged(sender As Object, e As EventArgs) Handles rdioManualProxy.CheckedChanged
        My.Settings.doManualProxy = rdioManualProxy.Checked

        txtProxyAddress.Enabled = True
        txtProxyAddressBg.Enabled = True
        txtProxyPassword.Enabled = True
        txtProxyPasswordBg.Enabled = True
        txtProxyPort.Enabled = True
        txtProxyPortBg.Enabled = True
        txtProxyUsername.Enabled = True
        txtProxyUsernameBg.Enabled = True

        lblProxyAddress.Enabled = True
        lblProxyPassword.Enabled = True
        lblProxyPort.Enabled = True
        lblProxyUsername.Enabled = True
    End Sub

#End Region

#Region "Miscellaneous"

    Private Sub chckAutoUpdate_CheckedChanged(Sender As Object, e As EventArgs) Handles chckAutoUpdate.CheckedChanged
        My.Settings.doAutoUpdate = chckAutoUpdate.Checked
    End Sub

    Private Sub chckCelebr8e_CheckedChanged(Sender As Object, e As EventArgs) Handles chckCelebr8.CheckedChanged
        My.Settings.doCelebr8 = chckCelebr8.Checked
    End Sub

#End Region

#Region "Save Settings / Reset Settings / Flush Databases"

    Private Sub btnSaveSettings_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSaveSettings.ClickButtonArea
        My.Settings.webProxyAddress = txtProxyAddress.Text
        My.Settings.webProxyPort = txtProxyPort.Text
        My.Settings.webProxyUsername = txtProxyUsername.Text
        My.Settings.webProxyPassword = txtProxyPassword.Text
        My.Settings.Save()
        showMessage("Your settings have been saved.")
    End Sub

    Private Sub btnResetSettings_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnResetSettings.ClickButtonArea
        If Movieo.ShowYesNo("Confirmation", "Are you sure you want to reset your settings?", Me) = MsgBoxResult.Yes Then
            showMessage("Settings restored to default.")
        End If
    End Sub

    Private Sub btnResetAllDatabases_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnResetAllDatabases.ClickButtonArea
        If Movieo.ShowYesNo("Confirmation", "Are you sure you want to delete all of your custom-made lists? You can restore from the recyling bin on your computer to bring them back.", Me) = MsgBoxResult.Yes Then
            Movieo.CreateEmptyListFiles()
            showMessage("Your lists have been wiped.")
        End If
    End Sub

#End Region

#Region "Highlight Buttons"

    Private Sub HighlightButtons_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSaveSettings.MouseMove, btnResetSettings.MouseMove, btnResetAllDatabases.MouseMove, btnDbExport.MouseMove
        Sender.ForeColor = Color.White
        Sender.BorderColor = Color.White
        Sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub HighlightButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnSaveSettings.MouseLeave, btnResetSettings.MouseLeave, btnResetAllDatabases.MouseLeave, btnDbExport.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub

#End Region

#Region "Notification message"

    Private Sub HideSettingsConfirmation_Tick(sender As Object, e As EventArgs) Handles timerHideNotifications.Tick
        lblSucessText.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Private Sub HideSettingsConfirmation_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles lblSucessText.ClickButtonArea
        lblSucessText.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Public Sub showMessage(Message As String)
        lblSucessText.Text = Message
        lblSucessText.Visible = True
        timerHideNotifications.Enabled = True
    End Sub

#End Region

End Class