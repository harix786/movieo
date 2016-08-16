Public Class PopupError
    Private Sub PopupError_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SubmitBtn1_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles BtnSubmit.ClickButtonArea
        PopupBackground.Close()
    End Sub
End Class