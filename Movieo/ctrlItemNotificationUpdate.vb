Imports System.Net

Public Class ctrlItemNotificationUpdate

    Private Sub dlBtn_Click(sender As Object, e As EventArgs) Handles BtnInstall.ClickButtonArea
        Try
            Process.Start(Movieo.pathUpdater)
            Application.Exit()
        Catch ex As Exception
            Movieo.ShowPopupOk("Update Failed", ex.Message, Me)
        End Try
    End Sub

    Private Sub UpdateNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Movieo.panelMovies.BackColor
    End Sub
End Class