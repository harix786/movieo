Public Class frmSelectSource

    Private Sub frmSelectSource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMovieDetails.Opacity = 0
        Top = Movieo.ClientRectangle.Top + 23
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.ClientSize
        btnOk.Enabled = False
    End Sub

    Private Sub itemsMovieSourcesTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemsMovieSourcesTitle.SelectedIndexChanged
        Try
            If Not itemsMovieSourcesTitle.SelectedIndex = -1 Then
                itemsMovieSources.SelectedIndex = itemsMovieSourcesTitle.SelectedIndex
                btnOk.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

#Region "Close Button"

    Private Sub meClose_Click(sender As Object, e As EventArgs) Handles meClose.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub meClose_MouseMove(sender As Object, e As MouseEventArgs) Handles meClose.MouseMove
        meClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub meClose_MouseLeave(sender As Object, e As EventArgs) Handles meClose.MouseLeave
        meClose.Image = My.Resources.PopupCloseL
    End Sub

#End Region

End Class