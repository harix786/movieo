Public Class frmSelectSource

    Private Sub frmSelectSource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 24
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.ClientSize
    End Sub

    Private Sub itemsMovieSourcesTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemsMovieSourcesTitle.SelectedIndexChanged
        Try
            itemsMovieSources.SelectedIndex = itemsMovieSourcesTitle.SelectedIndex
            frmMediaPlayer.PlayerMovieTitle.Text = frmMovieDetails.infoTitle.Text + " (" + frmMovieDetails.infoYear.Text + ")"
            frmMediaPlayer.MediaPlayerControl.URL = itemsMovieSources.SelectedItem.ToString
            frmMediaPlayer.Show(frmMovieDetails)
            Close()
        Catch ex As Exception
            Close()
        End Try
    End Sub

#Region "Close Button"

    Private Sub meClose_Click(sender As Object, e As EventArgs) Handles meClose.Click
        Close()
    End Sub

    Private Sub meClose_MouseMove(sender As Object, e As MouseEventArgs) Handles meClose.MouseMove
        meClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub meClose_MouseLeave(sender As Object, e As EventArgs) Handles meClose.MouseLeave
        meClose.Image = My.Resources.PopupCloseL
    End Sub

#End Region

End Class