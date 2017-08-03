Imports System.ComponentModel
Imports System.Net
Imports System.Text.RegularExpressions

Public Class frmMovieDetails

#Region "Lists Button Icons"

    Public imgFavouriteH As Bitmap = My.Resources.Favourite_H
    Public imgFavouriteL As Bitmap = My.Resources.Favourite_L
    Public imgFavouriteSticky As Bitmap = My.Resources.Favourite_H_STICKY
    '
    Public imgWatchListH As Bitmap = My.Resources.Watch_List_H
    Public imgWatchListL As Bitmap = My.Resources.Watch_List_L
    Public imgWatchListSticky As Bitmap = My.Resources.Watch_List_H_STICKY
    '
    Public imgSeenListH As Bitmap = My.Resources.Seen_List_H
    Public imgSeenListL As Bitmap = My.Resources.Seen_List_L
    Public imgSeenListSticky As Bitmap = My.Resources.Seen_List_H_STICKY
    '
    Public imgBlackListH As Bitmap = My.Resources.Black_List_Icon_H
    Public imgBlackListL As Bitmap = My.Resources.Black_List_Icon_L
    Public imgBlackListSticky As Bitmap = My.Resources.Black_List_H_STICKY

#End Region

    Private Sub MovieInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hide()
        Top = 24
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.Size

        If Movieo.itemsFavouritesList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteL
        End If

        If Movieo.itemsWatchList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListL
        End If

        If Movieo.itemsSeenList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListL
        End If

        If Movieo.itemsBlackList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListL
        End If

        panelShareComment.Size = New Size(InfoPanel1.Size.Width, InfoPanel1.Size.Height)

        'Download button (settings)
        If My.Settings.doDownloadBtn = True Then
            btnDownloadMovie.Visible = True
        Else
            btnDownloadMovie.Visible = False
        End If

        'Get Comments
        If My.Settings.doUserComments = True Then
            Try
                Dim WebDl = New WebClient()
                WebDl.Proxy = Nothing

                Dim MoviesContent As String = WebDl.DownloadString(Movieo.linkMovieComments)
                Dim MoviesByLine() As String = Split(MoviesContent, vbNewLine)

                For Each MovieOnLine As String In MoviesByLine
                    If Not MovieOnLine = "" Then
                        Dim MovieCred As String() = Split(MovieOnLine, "|")
                        If MovieCred(0) = infoTitle.Text + " (" + infoYear.Text + ")" Then
                            Dim a As New ctrlItemComment
                            a.infoDate.Text = TimeAgo(MovieCred(1))
                            a.infoUserName.Text = MovieCred(2)
                            a.infoUserComment.Text = MovieCred(3)
                            a.Size = New Size(panelComments.Size.Width - 8, a.Size.Height)
                            panelComments.SetFlowBreak(a, True)
                            'a.Margin = New Padding(3, 0, 0, 0)
                            a.TopLevel = False
                            a.Show()
                            panelComments.Controls.Add(a)
                        End If
                    End If
                Next

                panelComments.Visible = True
                panelShareComment.Visible = True
                lblHeaderComments.Visible = True
                lineSplitter.Visible = True
                lineComments.Visible = True
                txtFormNameBG.Visible = True
            Catch ex As Exception
                panelComments.Visible = False
                panelShareComment.Visible = False
                lblHeaderComments.Visible = False
                lineSplitter.Visible = False
                lineComments.Visible = False
                txtFormNameBG.Visible = True
            End Try
        Else
            panelComments.Visible = False
            panelShareComment.Visible = False
            lblHeaderComments.Visible = False
            lineSplitter.Visible = False
            lineComments.Visible = False
            txtFormNameBG.Visible = False
        End If

        'If Popcorn Time API doesn't have trailer available
        If infoTrailerLink.Text = "" Then
            btnWatchTrailer.Enabled = False
        Else
            btnWatchTrailer.Enabled = True
        End If
    End Sub

#Region "Searchable Labels Events"

    Public Sub castItem_Click(sender As Object, e As EventArgs)
        Try
            frmBackgroundMovieDetails.Hide()
            Hide()
            Movieo.txtboxSearch.Focus()
            Movieo.txtboxSearch.Text = sender.text
            Movieo.Tab.SelectedTab = Movieo.tabLoading
            Movieo.timerSearchMovies.Enabled = True
            Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub castItem_MouseMove(sender As Object, e As EventArgs)
        'sender.BackColor = Color.FromArgb(23, 27, 32)
        sender.ForeColor = Color.White
    End Sub

    Public Sub castItem_MouseLeave(sender As Object, e As EventArgs)
        'sender.BackColor = Color.Transparent
        sender.ForeColor = Color.FromArgb(150, 159, 170)
    End Sub

    Public Sub genreItem_Click(sender As Object, e As EventArgs)
        frmBackgroundMovieDetails.Hide()
        Hide()
        For Each a As Control In Movieo.panelGenres.Controls
            If a.Text = sender.Text Then
                a.BackColor = Color.FromArgb(43, 50, 61)
                a.ForeColor = Color.White
            Else
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            End If
        Next

        Movieo.panelMovies.Controls.Clear()
        Movieo.storeControlsScroll.Clear()

        Movieo.selectedGenre = sender.text

        Dim countMovie As Integer = 0

        For Each a In Movieo.storeControlsAllMovies
            For Each ab As Control In a.Controls
                If ab.Name = "InfoGenre" Then
                    If ab.Text.ToLower.Contains(sender.Text.ToString.ToLower) Then
                        countMovie = countMovie + 1
                        If countMovie <= 40 Then
                            Movieo.panelMovies.Controls.Add(a)
                        Else
                            Movieo.storeControlsScroll.Add(a)
                        End If
                    End If
                End If
            Next
        Next
        Close()
    End Sub
#End Region

#Region "Close Button"

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Close()
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As MouseEventArgs) Handles appClose.MouseMove
        Try
            appClose.Image = My.Resources.PopupCloseH
        Catch ex As Exception
        End Try
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles appClose.MouseLeave
        Try
            appClose.Image = My.Resources.PopupCloseL
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Lists Buttons"

    Private Sub BtnFavouriteList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnFavouriteList.MouseMove
        If Movieo.itemsFavouritesList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteH
        End If
    End Sub

    Private Sub BtnFavouriteList_MouseLeave(sender As Object, e As EventArgs) Handles BtnFavouriteList.MouseLeave
        If Movieo.itemsFavouritesList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteL
        End If
    End Sub

    Private Sub BtnFavouriteList_Click(sender As Object, e As EventArgs) Handles BtnFavouriteList.Click
        If Movieo.itemsFavouritesList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.panelMyListsFavourites, Movieo.itemsFavouritesList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
            BtnFavouriteList.Image = imgFavouriteL
        Else
            Movieo.AddMovie(Movieo.panelMyListsFavourites, Movieo.itemsFavouritesList, infoTitle.Text, infoYear.Text, infoGenre.Text, infoDirectors.Text, infoCast.Text, infoDescription.Text, infoDuration.Text, infoRating.Text, infoReleaseDate.Text, infoCountry.Text, infoLanguage.Text, infoProduction.Text, infoBoxOffice.Text, infoAwards.Text, infoImdbId.Text, infoRatingIMDb.Text, infoRatingNetflix.Text, infoRatingMetaScore.Text, infoImageLink.Text, MovieLinkText.Text)
            BtnFavouriteList.Image = imgFavouriteSticky
        End If
    End Sub

    Private Sub BtnWatchList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnWatchList.MouseMove
        If Movieo.itemsWatchList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListH
        End If
    End Sub

    Private Sub BtnWatchList_MouseLeave(sender As Object, e As EventArgs) Handles BtnWatchList.MouseLeave
        If Movieo.itemsWatchList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListL
        End If
    End Sub

    Private Sub btnWatchList_Click(sender As Object, e As EventArgs) Handles BtnWatchList.Click
        If Movieo.itemsWatchList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.panelMyListsWatchList, Movieo.itemsWatchList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
            BtnWatchList.Image = imgWatchListL
        Else
            Movieo.AddMovie(Movieo.panelMyListsWatchList, Movieo.itemsWatchList, infoTitle.Text, infoYear.Text, infoGenre.Text, infoDirectors.Text, infoCast.Text, infoDescription.Text, infoDuration.Text, infoRating.Text, infoReleaseDate.Text, infoCountry.Text, infoLanguage.Text, infoProduction.Text, infoBoxOffice.Text, infoAwards.Text, infoImdbId.Text, infoRatingIMDb.Text, infoRatingNetflix.Text, infoRatingMetaScore.Text, infoImageLink.Text, MovieLinkText.Text)
            BtnWatchList.Image = imgWatchListSticky

            If Movieo.itemsBlackList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelMyListsBlackList, Movieo.itemsBlackList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnBlackList.Image = imgBlackListL
            End If

            If Movieo.itemsSeenList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelMyListsSeenList, Movieo.itemsSeenList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnSeenList.Image = imgSeenListL
            End If
        End If

    End Sub

    Private Sub btnSeenList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSeenList.MouseMove
        If Movieo.itemsSeenList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListH
        End If
    End Sub

    Private Sub btnSeenList_MouseLeave(sender As Object, e As EventArgs) Handles BtnSeenList.MouseLeave
        If Movieo.itemsSeenList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListL
        End If
    End Sub

    Private Sub btnSeenList_Click(sender As Object, e As EventArgs) Handles BtnSeenList.Click
        If Movieo.itemsSeenList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.panelMyListsSeenList, Movieo.itemsSeenList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
            BtnSeenList.Image = imgSeenListL
        Else
            Movieo.AddMovie(Movieo.panelMyListsSeenList, Movieo.itemsSeenList, infoTitle.Text, infoYear.Text, infoGenre.Text, infoDirectors.Text, infoCast.Text, infoDescription.Text, infoDuration.Text, infoRating.Text, infoReleaseDate.Text, infoCountry.Text, infoLanguage.Text, infoProduction.Text, infoBoxOffice.Text, infoAwards.Text, infoImdbId.Text, infoRatingIMDb.Text, infoRatingNetflix.Text, infoRatingMetaScore.Text, infoImageLink.Text, MovieLinkText.Text)
            BtnSeenList.Image = imgSeenListSticky

            If Movieo.itemsBlackList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelMyListsBlackList, Movieo.itemsBlackList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnBlackList.Image = imgBlackListL
            End If

            If Movieo.itemsWatchList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelMyListsWatchList, Movieo.itemsWatchList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnWatchList.Image = imgWatchListL
            End If
        End If

    End Sub

    Private Sub BtnBlackList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnBlackList.MouseMove
        If Movieo.itemsBlackList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListH
        End If
    End Sub

    Private Sub BtnBlackList_MouseLeave(sender As Object, e As EventArgs) Handles BtnBlackList.MouseLeave
        If Movieo.itemsBlackList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListL
        End If
    End Sub

    Private Sub BtnBlackList_Click(sender As Object, e As EventArgs) Handles BtnBlackList.Click
        If Movieo.itemsBlackList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.panelMyListsBlackList, Movieo.itemsBlackList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
            BtnBlackList.Image = imgBlackListL
        Else
            Movieo.AddMovie(Movieo.panelMyListsBlackList, Movieo.itemsBlackList, infoTitle.Text, infoYear.Text, infoGenre.Text, infoDirectors.Text, infoCast.Text, infoDescription.Text, infoDuration.Text, infoRating.Text, infoReleaseDate.Text, infoCountry.Text, infoLanguage.Text, infoProduction.Text, infoBoxOffice.Text, infoAwards.Text, infoImdbId.Text, infoRatingIMDb.Text, infoRatingNetflix.Text, infoRatingMetaScore.Text, infoImageLink.Text, MovieLinkText.Text)
            BtnBlackList.Image = imgBlackListSticky

            If Movieo.itemsSeenList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelMyListsSeenList, Movieo.itemsSeenList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnSeenList.Image = imgSeenListL
            End If

            If Movieo.itemsWatchList.Items.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelMyListsWatchList, Movieo.itemsWatchList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnWatchList.Image = imgWatchListL
            End If
        End If
    End Sub

#End Region

#Region "Watch Movie, Download Movie & Watch Trailer (beta)"

    Public IsMovieUrlContextOpen As Boolean = False
    Dim webClient As WebClient = New WebClient()

    Private Sub btnWatchMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnWatchMovie.ClickButtonArea
        frmSelectSource.itemsMovieSources.Items.Clear()
        Dim splitSources As String() = Split(infoWatchLinks.Text, "*")
        For Each a As String In splitSources
            Dim sourceTitle As String = a.Substring(a.LastIndexOf("/") + 1)
            frmSelectSource.itemsMovieSourcesTitle.Items.Add(sourceTitle)
            frmSelectSource.itemsMovieSources.Items.Add(a)
        Next
        frmSelectSource.Show(Me)

        'Try
        'frmMediaPlayer.PlayerMovieTitle.Text = infoTitle.Text + " (" + infoYear.Text + ")"
        'frmMediaPlayer.MediaPlayerControl.URL = infoWatchLinks.Text
        'frmMediaPlayer.Show(Me)
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub btnWatchMovie_MouseMove(sender As Object, e As MouseEventArgs) Handles btnWatchMovie.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnWatchMovie_MouseLeave(sender As Object, e As EventArgs) Handles btnWatchMovie.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    Private Sub btnWatchTrailer_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnWatchTrailer.ClickButtonArea
        Try
            If Not infoTrailerLink.Text = "" Then
                Dim input = infoTrailerLink.Text
                frmTrailerPlayer.web.Navigate("https://www.youtube.com/embed/" + GetVideoId(infoTrailerLink.Text) + "?VQ=HD720?autoplay=1")
                frmTrailerPlayer.Show(Me)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Const YoutubeLinkRegex As String = "(?:.+?)?(?:\/v\/|watch\/|\?v=|\&v=|youtube\.com\/|\/v=|^youtube\.com\/)([a-zA-Z0-9_-]{11})+"

    Friend Shared Function GetVideoId(input As String) As String
        Dim regex = New Regex(YoutubeLinkRegex, RegexOptions.Compiled)
        For Each match As Match In regex.Matches(input)
            For Each data As Group In match.Groups.Cast(Of Group)().Where(Function(groupdata) Not groupdata.ToString().StartsWith("http://") AndAlso Not groupdata.ToString().StartsWith("https://") AndAlso Not groupdata.ToString().StartsWith("youtube") AndAlso Not groupdata.ToString().StartsWith("www."))
                Return data.ToString()
            Next
        Next
        Return String.Empty
    End Function

    Private Sub btnWatchTrailer_MouseMove(sender As Object, e As MouseEventArgs) Handles btnWatchTrailer.MouseMove, btnWatchTrailer.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnWatchTrailer_MouseLeave(sender As Object, e As EventArgs) Handles btnWatchTrailer.MouseLeave, btnWatchTrailer.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    Private Sub btnDownloadMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDownloadMovie.ClickButtonArea
        Try
            frmDownloadClient.Show(Me)
            frmDownloadClient.doDownload(infoWatchLinks.Text, infoTitle.Text, infoYear.Text, infoWatchLinks.Text.Substring(infoWatchLinks.Text.Length - 3))
        Catch ex As Exception
            Movieo.ShowPopupOk("Unable to download movie", "It seems there's an issue preventing you from download this movie. We have sent the data to our team so we can fix this immediately. Sorry for the inconvenience", Me)
        End Try
    End Sub

    Private Sub BtnDownloadMovie_MouseMove(sender As Object, e As MouseEventArgs) Handles btnDownloadMovie.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnDownloadMovie_MouseLeave(sender As Object, e As EventArgs) Handles btnDownloadMovie.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub

#End Region

#Region "Go to Movie on Website (IMDb & Rotten Tomatoes)"

    Private Sub ImgImdb_Click(sender As Object, e As EventArgs) Handles imgImdb.Click, infoRatingIMDb.Click
        Try
            Process.Start("http://www.imdb.com/title/" + infoImdbId.Text)
        Catch ex As Exception
            Movieo.ShowPopupOk("Unable to open IMDb link", ex.Message, Me)
        End Try
    End Sub

    Private Sub frmMovieDetails_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Show()
    End Sub

#End Region

#Region "User Reviews (Comments)"

    Private Sub btnCommentSubmit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnCommentSubmit.ClickButtonArea
        If Not TimeAgo(TimeStamp) = "just now" Then
            Movieo.SendMail("New Comment", "Date: " + Date.Now.ToString("dd/MM/yyyy") + vbNewLine + "Movie: " + infoTitle.Text + "(" + infoYear.Text + ")" + vbNewLine + "Comment: " + txtShareComment.Text + vbNewLine + "Name: " + txtShareName.Text)
            txtShareComment.Text = ""
            txtShareName.Text = ""
            showMessage("Your comment has been sent.")
        Else
            showMessage("Please try again in a moment...")
        End If
    End Sub

    Private Sub BtnSubmitForm_MouseMove(sender As Object, e As EventArgs) Handles btnCommentSubmit.MouseMove, btnCommentSubmit.GotFocus
        sender.ForeColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub BtnSubmitForm_MouseLeave(sender As Object, e As EventArgs) Handles btnCommentSubmit.MouseLeave, btnCommentSubmit.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
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
        lblMessageSent.Text = Message
        lblMessageSent.Visible = True
        timerHideNotifications.Enabled = True
        TimeStamp = Date.Now
    End Sub

    Dim TimeStamp As Date

    Public Shared Function TimeAgo(dt As Date) As String
        Dim span As TimeSpan = DateTime.Now - dt
        If span.Days > 365 Then
            Dim years As Integer = (span.Days / 365)
            If span.Days Mod 365 <> 0 Then
                years += 1
            End If
            Return [String].Format("about {0} {1} ago", years, If(years = 1, "year", "years"))
        End If
        If span.Days > 30 Then
            Dim months As Integer = (span.Days / 30)
            If span.Days Mod 31 <> 0 Then
                months += 1
            End If
            Return [String].Format("about {0} {1} ago", months, If(months = 1, "month", "months"))
        End If
        If span.Days > 0 Then
            Return [String].Format("about {0} {1} ago", span.Days, If(span.Days = 1, "day", "days"))
        End If
        If span.Hours > 0 Then
            Return [String].Format("about {0} {1} ago", span.Hours, If(span.Hours = 1, "hour", "hours"))
        End If
        If span.Minutes > 0 Then
            Return [String].Format("about {0} {1} ago", span.Minutes, If(span.Minutes = 1, "minute", "minutes"))
        End If
        If span.Seconds > 5 Then
            Return [String].Format("about {0} seconds ago", span.Seconds)
        End If
        If span.Seconds <= 5 Then
            Return "just now"
        End If
        Return String.Empty
    End Function

#End Region

#Region "Cast Items (Remove on Form Close)"

    Public dynControls As New List(Of Label)

    Private Sub frmMovieDetails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For Each item As Label In dynControls
            InfoPanel1.Controls.Remove(item)
        Next
        dynControls.Clear()
        frmBackgroundMovieDetails.Close()
    End Sub

#End Region


End Class