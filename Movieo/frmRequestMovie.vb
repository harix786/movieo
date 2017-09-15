Public Class frmRequestMovie


    Private Sub frmRequestMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = Movieo.ClientRectangle.Top + 23
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.ClientSize
    End Sub

    Private Sub btnFormSubmit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnFormSubmit.ClickButtonArea
        If Not txtFormMovieTitle.Text = "" Then
            Try
                showMessage("Opening Mail Client...")
                Movieo.openMail("Movieo - Request Movie",
                "Movie Title: " + txtFormMovieTitle.Text + "%0A" +
                "More Info: " + txtFormMoreInfo.Text + "%0A")
                txtFormMovieTitle.Text = ""
                txtFormMoreInfo.Text = ""
            Catch ex As Exception
                showMessage("Unable to open request.")
            End Try
        Else
            showMessage("Movie title can't be blank.")
        End If
    End Sub

    Private Sub BtnSubmitForm_MouseMove(sender As Object, e As EventArgs) Handles btnFormSubmit.MouseMove, btnFormSubmit.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub BtnSubmitForm_MouseLeave(sender As Object, e As EventArgs) Handles btnFormSubmit.MouseLeave, btnFormSubmit.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(86, 98, 115)
        sender.ColorFillSolid = Color.Transparent
    End Sub

#Region "Close Button / Image"

    'Close window image
    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles MeClose.MouseMove
        MeClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles MeClose.MouseLeave
        MeClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub MeClose_MouseClick(sender As Object, e As EventArgs) Handles MeClose.Click
        My.Settings.Reload()
        Close()
    End Sub

#End Region

#Region "Notification Message"

    Private Sub HideSettingsConfirmation_Tick(sender As Object, e As EventArgs) Handles timerHideNotifications.Tick
        lblMessageSent.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Private Sub HideSettingsConfirmation_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles lblMessageSent.ClickButtonArea
        lblMessageSent.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Public Sub showMessage(Message As String)
        timerHideNotifications.Enabled = False

        lblMessageSent.Text = Message
        Dim myFont As New Font(lblMessageSent.Font.FontFamily, Me.lblMessageSent.Font.Size)
        Dim mySize = lblMessageSent.CreateGraphics.MeasureString(Message, myFont)

        lblMessageSent.Width = CType(Math.Round(mySize.Width, 0), Integer) + 20
        lblMessageSent.Height = CType(Math.Round(mySize.Height, 0), Integer) + 14
        lblMessageSent.Location = New Point((ClientSize.Width - lblMessageSent.Width) \ 2, -1)
        lblMessageSent.Visible = True

        timerHideNotifications.Enabled = True
    End Sub

#End Region

End Class