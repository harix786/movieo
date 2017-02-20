Public Class ctrlInfoMenu

    Private Sub InfoContextMenu_Load(ByVal c As Object, ByVal e As EventArgs) Handles MyBase.Load
        ShowInTaskbar = False
        'InitializeComponent()
    End Sub

    Private Sub CButton1_MouseMove(sender As Object, e As MouseEventArgs) Handles btnFavourites.MouseMove, btnWatchList.MouseMove, btnSeenList.MouseMove, btnBlackList.MouseMove, btnSettings.MouseMove, btnContact.MouseMove, btnChangelog.MouseMove, btnLegal.MouseMove, btnFAQ.MouseMove, btnAbout.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Public Sub CtrlsLeave_Leave(sender As Object, e As EventArgs) Handles btnFavourites.MouseLeave, btnWatchList.MouseLeave, btnSeenList.MouseLeave, btnBlackList.MouseLeave, btnSettings.MouseLeave, btnContact.MouseLeave, btnChangelog.MouseLeave, btnLegal.MouseLeave, btnFAQ.MouseLeave, btnAbout.MouseLeave
        sender.ForeColor = Color.FromArgb(166, 166, 166)
    End Sub

    Private Sub OnDeactivated_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
        Movieo.IsContextOpen = False
        Movieo.BtnSendFeedback.Image = My.Resources.DropletsIconL
        Me.Hide()
    End Sub

    Private Sub OnMouseDown_MouseDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseDown
        Movieo.IsContextOpen = False
        Movieo.BtnSendFeedback.Image = My.Resources.DropletsIconL
        'MyBase.OnMouseDown(e)
        Me.Hide()
    End Sub

    Private Sub OnKeyDown_KeyDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.KeyDown
        Movieo.IsContextOpen = False
        Movieo.BtnSendFeedback.Image = My.Resources.DropletsIconL
        'MyBase.OnKeyDown(e)
        Me.Hide()
    End Sub

    Private Sub OnLostFocus_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.LostFocus
        Movieo.IsContextOpen = False
        Movieo.BtnSendFeedback.Image = My.Resources.DropletsIconL
        'MyBase.OnLostFocus(e)
        Me.Hide()
    End Sub

    Private Sub btnAbout_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnAbout.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.TabAbout
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLegal_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnLegal.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.TabLegal
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnFAQ_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnFAQ.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.TabHelpFaq
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnChangelog_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnChangelog.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.TabChangelog
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnContact_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnContact.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.TabContact
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSettings_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSettings.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            frmSettings.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnShortcuts_ClickButtonArea(Sender As Object, e As MouseEventArgs) 
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.TabContact
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnFavourites_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnFavourites.ClickButtonArea
        Movieo.Tab.SelectedTab = Movieo.tabFavourites
        Hide()
    End Sub

    Private Sub btnWatchList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnWatchList.ClickButtonArea
        Movieo.Tab.SelectedTab = Movieo.tabWatchList
        Hide()
    End Sub

    Private Sub btnSeenList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSeenList.ClickButtonArea
        Movieo.Tab.SelectedTab = Movieo.tabSeenList
        Hide()
    End Sub

    Private Sub btnBlackList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnBlackList.ClickButtonArea
        Movieo.Tab.SelectedTab = Movieo.tabBlackList
        Hide()
    End Sub
End Class