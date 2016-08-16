Public Class TabPageError
    Private Sub TabPageError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Odeum_Movies.tabMovies.BackColor
    End Sub

    Private Sub Btn1_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles BtnRestart.ClickButtonArea
        Application.Restart()
    End Sub

    Private Sub BtnRestart_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnRestart.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub BtnRestart_MouseLeave(sender As Object, e As EventArgs) Handles BtnRestart.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub
End Class