Imports System.Net

Public Class InfoTabs
    Private Sub PopupChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set selected tab
        Tab.SelectedTab = Odeum_Movies.InfoSelectedTab

        'Set position/size of window
        Top = 0
        Left = 0
        Size = New Size(Odeum_Movies.Size)

        'Latest changelog text
        Try
            TxtChangelog.Text = New WebClient().DownloadString(Odeum_Movies.OdeumChangelog)
        Catch ex As Exception
            TxtChangelog.Text = "Error loading our changelog..."
        End Try

        'Fix bug where textboxes were sometimes sent to the back
        TxtMessageBg.SendToBack()
        TxtEmailBg.SendToBack()
    End Sub

    'Close window image
    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles MeClose.MouseMove
        MeClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles MeClose.MouseLeave
        MeClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub MeClose_MouseClick(sender As Object, e As EventArgs) Handles MeClose.MouseClick
        Close()
    End Sub

    'Tabs
    Private Sub LblAbout_Click(sender As Object, e As EventArgs) Handles LblAbout.Click
        Tab.SelectedTab = TabAbout
    End Sub

    Private Sub LblFAQ_Click(sender As Object, e As EventArgs) Handles LblFAQ.Click
        Tab.SelectedTab = TabHelpFaq
    End Sub

    Private Sub LblChangelog_Click(sender As Object, e As EventArgs) Handles LblChangelog.Click
        Tab.SelectedTab = TabChangelog
    End Sub

    Private Sub LblContact_Click(sender As Object, e As EventArgs) Handles LblContact.Click
        Tab.SelectedTab = TabContact
    End Sub

    Private Sub LblAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles LblFAQ.MouseMove, LblContact.MouseMove, LblChangelog.MouseMove, LblAbout.MouseMove
        sender.ForeColor = SelectedTabColour
    End Sub

    Private Sub LblAbout_MouseLeave(sender As Object, e As EventArgs) Handles LblFAQ.MouseLeave, LblContact.MouseLeave, LblChangelog.MouseLeave, LblAbout.MouseLeave
        If Not sender.Name = CurrentTab.Name Then
            sender.ForeColor = NonSelectedTabColour
        End If
    End Sub

    Dim CurrentTab
    Dim SelectedTabColour As Color = Color.FromArgb(172, 180, 191)
    Dim NonSelectedTabColour As Color = Color.FromArgb(86, 98, 115)

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            CurrentTab = LblAbout
            LblAbout.ForeColor = SelectedTabColour
            LblFAQ.ForeColor = NonSelectedTabColour
            LblChangelog.ForeColor = NonSelectedTabColour
            LblContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 1 Then
            CurrentTab = LblFAQ
            LblAbout.ForeColor = NonSelectedTabColour
            LblFAQ.ForeColor = SelectedTabColour
            LblChangelog.ForeColor = NonSelectedTabColour
            LblContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 2 Then
            CurrentTab = LblChangelog
            LblAbout.ForeColor = NonSelectedTabColour
            LblFAQ.ForeColor = NonSelectedTabColour
            LblChangelog.ForeColor = SelectedTabColour
            LblContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 3 Then
            CurrentTab = LblContact
            LblAbout.ForeColor = NonSelectedTabColour
            LblFAQ.ForeColor = NonSelectedTabColour
            LblChangelog.ForeColor = NonSelectedTabColour
            LblContact.ForeColor = SelectedTabColour
        End If
    End Sub

    'Data provider link
    Private Sub ImgProvider_Click(sender As Object, e As EventArgs) Handles ImgProvider.Click
        Process.Start("http://omdbapi.com/")
    End Sub

    'Share links
    Private Sub BtnShareTw_Click(sender As Object, e As EventArgs) Handles BtnShareTw.Click
        Process.Start("https://twitter.com/intent/tweet?text=https://twitter.com/intent/tweet?url=http%3A%2F%2Fodeum.at.vu%2F&text=Watch%20your%20favourite%20movies%20with%20Odeum%20Movies!%20Download%20it%20at%20&original_referer=")
    End Sub

    Private Sub BtnShareFb_Click(sender As Object, e As EventArgs) Handles BtnShareFb.Click
        Process.Start("https://www.facebook.com/sharer/sharer.php?u=http://odeum.at.vu")
    End Sub

    'Message submit button
    Private Sub BtnSubmitForm_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles BtnSubmitForm.ClickButtonArea
        If Not TxtMessageForm.Text = "" Then
            If Not TxtEmailForm.Text = "" Then
                Try
                    Odeum_Movies.SendMail("Message",
                    "Message: " + vbNewLine + TxtMessageForm.Text + vbNewLine + vbNewLine +
                    "From: " + vbNewLine + TxtEmailForm.Text)
                    MsgSentConfirmation.Text = "Message sent! Thank you so much ❤"
                    MsgSentConfirmation.Visible = True
                    HideConfirmation.Enabled = True
                Catch ex As Exception
                    MsgSentConfirmation.Text = "Unable to send your message."
                    MsgSentConfirmation.Visible = True
                    HideConfirmation.Enabled = True
                End Try
            Else
                MsgSentConfirmation.Text = "Message can't be blank."
                MsgSentConfirmation.Visible = True
                HideConfirmation.Enabled = True
            End If
        Else
            MsgSentConfirmation.Text = "Email can't be blank."
            MsgSentConfirmation.Visible = True
            HideConfirmation.Enabled = True
        End If
    End Sub

    Private Sub BtnSubmitForm_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSubmitForm.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub BtnSubmitForm_MouseLeave(sender As Object, e As EventArgs) Handles BtnSubmitForm.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    'Confirmation text
    Private Sub HideConfirmation_Tick(sender As Object, e As EventArgs) Handles HideConfirmation.Tick
        MsgSentConfirmation.Visible = False
        HideConfirmation.Enabled = False
    End Sub

    Private Sub MsgSentConfirmation_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles MsgSentConfirmation.ClickButtonArea
        MsgSentConfirmation.Visible = False
        HideConfirmation.Enabled = False
    End Sub

    'Social links
    Private Sub ContactEmail_Click(sender As Object, e As EventArgs) Handles ContactEmail.Click
        Process.Start("mailto:" + ContactEmail.Text)
    End Sub

    Private Sub ContactSourceForge_Click(sender As Object, e As EventArgs) Handles ContactSourceForge.Click
        Process.Start("https://sourceforge.net/p/odeum-movies-beta")
    End Sub

    Private Sub ContactTwitter_Click(sender As Object, e As EventArgs) Handles ContactTwitter.Click
        Process.Start("http://twitter.com/zeduc1")
    End Sub

End Class