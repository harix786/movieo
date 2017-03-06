
Public Class frmPlayer
    Private Sub FastWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 0
        Left = 0
        Size = New Size(Movieo.Size)

        MediaPlayerControl.uiMode = "full"
        MediaPlayerControl.stretchToFit = True
        MediaPlayerControl.enableContextMenu = False

        If My.Settings.doFullScr = True Then
            MediaPlayerControl.fullScreen = True
        End If
    End Sub

    Private Sub btnReportBroken_ClickButtonArea(sender As Object, e As EventArgs) Handles btnReportBroken.ClickButtonArea
        Movieo.InfoSelectedTab = frmInfo.tabContact
        frmInfo.Show(Me)
        frmInfo.txtFormMessage.Focus()
        frmInfo.txtFormMessage.Text = "I am having issues with movie """ + PlayerMovieTitle.Text + """ because "
        frmInfo.txtFormMessage.SelectionStart = frmInfo.txtFormMessage.TextLength
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