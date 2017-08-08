Public Class frmBackgroundMovieDetails
    Private Sub ctrlMovieDetailsBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = Movieo.ClientRectangle.Top + 24
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.ClientSize
    End Sub
End Class