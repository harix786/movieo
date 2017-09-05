Public Class ctrlContextMenuInfo

    Private Sub btnChangelog_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSettings.MouseMove, btnNotifications.MouseMove, btnRequestMovie.MouseMove, btnLegalInfoDMCA.MouseMove, btnHelpFAQ.MouseMove, btnContactUs.MouseMove, btnReleaseNotes.MouseMove, btnAboutMovieo.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnChangelog_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave, btnNotifications.MouseLeave, btnRequestMovie.MouseLeave, btnLegalInfoDMCA.MouseLeave, btnHelpFAQ.MouseLeave, btnContactUs.MouseLeave, btnReleaseNotes.MouseLeave, btnAboutMovieo.MouseLeave
        sender.ForeColor = Color.Silver
    End Sub

    Private Sub OnDeactivated_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
        Movieo.IsContextOpen = False
        Movieo.btnInfoMenu.Image = My.Resources.DropletsIconL
        Me.Hide()
    End Sub

    Private Sub OnMouseDown_MouseDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseDown
        Movieo.IsContextOpen = False
        Movieo.btnInfoMenu.Image = My.Resources.DropletsIconL
        'MyBase.OnMouseDown(e)
        Me.Hide()
    End Sub

    Private Sub OnKeyDown_KeyDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.KeyDown
        Movieo.IsContextOpen = False
        Movieo.btnInfoMenu.Image = My.Resources.DropletsIconL
        'MyBase.OnKeyDown(e)
        Me.Hide()
    End Sub

    Private Sub OnLostFocus_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.LostFocus
        Movieo.IsContextOpen = False
        Movieo.btnInfoMenu.Image = My.Resources.DropletsIconL
        'MyBase.OnLostFocus(e)
        Me.Hide()
    End Sub

    Private Sub btnAbout_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnAboutMovieo.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabAbout
            Hide()
            frmInfo.ShowDialog(Movieo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLegal_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnLegalInfoDMCA.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabLegal
            Hide()
            frmInfo.ShowDialog(Movieo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnFAQ_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnHelpFAQ.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabHelpFaq
            Hide()
            frmInfo.ShowDialog(Movieo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnChangelog_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnReleaseNotes.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabChangelog
            Hide()
            frmInfo.ShowDialog(Movieo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnContact_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnContactUs.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabContact
            Hide()
            frmInfo.ShowDialog(Movieo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRequestMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnRequestMovie.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Hide()
            frmRequestMovie.ShowDialog(Movieo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNotifications_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnNotifications.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Hide()
            frmNotifications.ShowDialog(Movieo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSettings_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSettings.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Hide()
            frmSettings.ShowDialog(Movieo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnUpdateAvailable_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnUpdateAvailable.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Hide()
            Try
                Process.Start(Movieo.pathUpdater)
                Application.Exit()
            Catch ex As Exception
                Movieo.ShowPopupOk("Update Failed", ex.Message, Movieo)
            End Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ctrlContextMenuInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class