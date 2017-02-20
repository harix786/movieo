Public Class ctrlNotification
    Private Sub MessageNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Movieo.PanelMovies.BackColor
    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Movieo.itemsNotificationList.Items.Add(LblNotifNumber.Text)
        Me.Close()
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As EventArgs) Handles appClose.MouseMove
        appClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles appClose.MouseLeave
        appClose.Image = My.Resources.PopupCloseL
    End Sub
End Class