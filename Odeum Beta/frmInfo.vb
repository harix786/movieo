Imports System.Globalization
Imports System.Net
Imports System.Text.RegularExpressions

Public Class frmInfo
    Private Sub PopupChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set selected tab
        Tab.SelectedTab = Movieo.InfoSelectedTab

        'Set position/size of window
        Top = 0
        Left = 0
        Size = New Size(Movieo.Size)

        'Latest changelog text
        Try
            LblChangelongText.Text = New WebClient().DownloadString(Movieo.MovieoChangelog)
        Catch ex As Exception
            LblChangelongText.Text = ex.Message
        End Try

        'Fix bug where textboxes were sometimes hidden (sent to the back of backgrounds)
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
    Private Sub LblAbout_Click(sender As Object, e As EventArgs) Handles LblNavAbout.Click
        Tab.SelectedTab = TabAbout
    End Sub

    Private Sub LblLegal_Click(sender As Object, e As EventArgs) Handles LblNavLegal.Click
        Tab.SelectedTab = TabLegal
    End Sub

    Private Sub LblFAQ_Click(sender As Object, e As EventArgs) Handles LblNavFAQ.Click
        Tab.SelectedTab = TabHelpFaq
    End Sub

    Private Sub LblChangelog_Click(sender As Object, e As EventArgs) Handles LblNavChangelog.Click
        Tab.SelectedTab = TabChangelog
    End Sub

    Private Sub LblContact_Click(sender As Object, e As EventArgs) Handles LblNavContact.Click
        Tab.SelectedTab = TabContact
    End Sub

    Private Sub LblAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles LblNavContact.MouseMove, LblNavChangelog.MouseMove, LblNavLegal.MouseMove, LblNavFAQ.MouseMove, LblNavAbout.MouseMove
        sender.ForeColor = SelectedTabColour
    End Sub

    Private Sub LblAbout_MouseLeave(sender As Object, e As EventArgs) Handles LblNavContact.MouseLeave, LblNavChangelog.MouseLeave, LblNavLegal.MouseLeave, LblNavFAQ.MouseLeave, LblNavAbout.MouseLeave
        If sender IsNot CurrentTab Then sender.ForeColor = NonSelectedTabColour
    End Sub

    Dim CurrentTab As Object = LblNavAbout
    Dim SelectedTabColour As Color = Color.FromArgb(172, 180, 191)
    Dim NonSelectedTabColour As Color = Color.FromArgb(86, 98, 115)

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            CurrentTab = LblNavAbout
            LblNavAbout.ForeColor = SelectedTabColour
            LblNavLegal.ForeColor = NonSelectedTabColour
            LblNavFAQ.ForeColor = NonSelectedTabColour
            LblNavChangelog.ForeColor = NonSelectedTabColour
            LblNavContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 1 Then
            CurrentTab = LblNavLegal
            LblNavAbout.ForeColor = NonSelectedTabColour
            LblNavLegal.ForeColor = SelectedTabColour
            LblNavFAQ.ForeColor = NonSelectedTabColour
            LblNavChangelog.ForeColor = NonSelectedTabColour
            LblNavContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 2 Then
            CurrentTab = LblNavFAQ
            LblNavAbout.ForeColor = NonSelectedTabColour
            LblNavLegal.ForeColor = NonSelectedTabColour
            LblNavFAQ.ForeColor = SelectedTabColour
            LblNavChangelog.ForeColor = NonSelectedTabColour
            LblNavContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 3 Then
            CurrentTab = LblNavChangelog
            LblNavAbout.ForeColor = NonSelectedTabColour
            LblNavLegal.ForeColor = NonSelectedTabColour
            LblNavFAQ.ForeColor = NonSelectedTabColour
            LblNavChangelog.ForeColor = SelectedTabColour
            LblNavContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 4 Then
            CurrentTab = LblNavContact
            LblNavAbout.ForeColor = NonSelectedTabColour
            LblNavLegal.ForeColor = NonSelectedTabColour
            LblNavFAQ.ForeColor = NonSelectedTabColour
            LblNavChangelog.ForeColor = NonSelectedTabColour
            LblNavContact.ForeColor = SelectedTabColour
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
                If IsValidEmail(TxtEmailForm.Text) = True Then
                    Try
                        Movieo.SendMail("Message",
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
                    MsgSentConfirmation.Text = "Your email doesn't look right."
                    MsgSentConfirmation.Visible = True
                    HideConfirmation.Enabled = True
                End If
            Else
                MsgSentConfirmation.Text = "Your email cannot be blank."
                MsgSentConfirmation.Visible = True
                HideConfirmation.Enabled = True
            End If
        Else
            MsgSentConfirmation.Text = "Your message cannot be blank."
            MsgSentConfirmation.Visible = True
            HideConfirmation.Enabled = True
        End If
    End Sub

    Dim invalid As Boolean = False

    Public Function IsValidEmail(strIn As String) As Boolean
        invalid = False
        If String.IsNullOrEmpty(strIn) Then Return False

        ' Use IdnMapping class to convert Unicode domain names.
        Try
            strIn = Regex.Replace(strIn, "(@)(.+)$", AddressOf Me.DomainMapper,
                                RegexOptions.None, TimeSpan.FromMilliseconds(200))
        Catch ex As RegexMatchTimeoutException
            Return False
        End Try

        If invalid Then Return False

        ' Return true if strIn is in valid e-mail format.
        Try
            Return Regex.IsMatch(strIn,
                 "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                 RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))
        Catch e As RegexMatchTimeoutException
            Return False
        End Try
    End Function

    Private Function DomainMapper(match As Match) As String
        'IdnMapping class with default property values.
        Dim idn As New IdnMapping()

        Dim domainName As String = match.Groups(2).Value
        Try
            domainName = idn.GetAscii(domainName)
        Catch ex As ArgumentException
            invalid = True
        End Try
        Return match.Groups(1).Value + domainName
    End Function

    Private Sub BtnSubmitForm_MouseMove(sender As Object, e As EventArgs) Handles BtnSubmitForm.MouseMove, BtnSubmitForm.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub BtnSubmitForm_MouseLeave(sender As Object, e As EventArgs) Handles BtnSubmitForm.MouseLeave, BtnSubmitForm.LostFocus
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