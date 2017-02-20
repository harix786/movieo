Public Class frmTrailerPlayer
    Private Sub frmTrailerPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 0
        Left = 0
        Size = New Size(Movieo.Size)
    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Close()
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As MouseEventArgs) Handles appClose.MouseMove
        appClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles appClose.MouseLeave
        appClose.Image = My.Resources.PopupCloseL
    End Sub
End Class