
Public Class MoviePlayer
    Private Sub FastWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 0
        Left = 0
        Size = New Size(Odeum_Movies.Size)

        MediaPlayerControl.uiMode = "full"
        MediaPlayerControl.stretchToFit = True
        MediaPlayerControl.enableContextMenu = False
    End Sub

    Private Sub btnReportBroken_ClickButtonArea(sender As Object, e As EventArgs) Handles btnReportBroken.ClickButtonArea
        Odeum_Movies.InfoSelectedTab = InfoTabs.TabContact
        InfoTabs.Show(Me)
        InfoTabs.TxtMessageForm.Focus()
        InfoTabs.TxtMessageForm.Text = "I am having issues with movie """ + PlayerMovieTitle.Text + """ because "
        InfoTabs.TxtMessageForm.SelectionStart = InfoTabs.TxtMessageForm.TextLength
    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Close()
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As EventArgs) Handles appClose.MouseMove
        appClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles appClose.MouseLeave
        appClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub btnReportBroken_MouseMove(sender As Object, e As MouseEventArgs) Handles btnReportBroken.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnReportBroken_MouseLeave(sender As Object, e As EventArgs) Handles btnReportBroken.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub
End Class