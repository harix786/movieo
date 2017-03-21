Public Class ctrlNotification
    Private Sub MessageNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Movieo.PanelMovies.BackColor
    End Sub

    Private Sub LblNotification_Click(sender As Object, e As EventArgs) Handles LblNotification.Click
        ctrlNotificationsMenu.Hide()
        imgIsNew.Visible = False
        Movieo.ShowPopupError("Notifications", sender.Text, Movieo)
    End Sub
End Class