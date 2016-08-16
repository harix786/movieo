Imports System.Net

Public Class UpdateNotification

    Private Sub dlBtn_Click(sender As Object, e As EventArgs) Handles BtnInstall.ClickButtonArea
        Try
            Process.Start(Odeum_Movies.UpdaterPath)
            Application.Exit()
        Catch ex As Exception
            Odeum_Movies.ShowPopupError("Update Failed", ex.Message)
        End Try
    End Sub

    Private Sub UpdateNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Odeum_Movies.PanelMovies.BackColor
    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles AppClose.Click
        Me.Close()
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As EventArgs) Handles AppClose.MouseMove
        AppClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles AppClose.MouseLeave
        AppClose.Image = My.Resources.PopupCloseL
    End Sub
End Class