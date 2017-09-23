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
        Top = Movieo.ClientRectangle.Top + 23
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.ClientSize

        If Movieo.listFavourites.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteL
        End If

        If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListL
        End If

        If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListL
        End If

        If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListL
        End If

        panelHeaders.Size = New Size(InfoPanel1.Size.Width, InfoPanel1.Size.Height)

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
                panelHeaders.Visible = True
                lblHeaderComments.Visible = True
                lineSplitter.Visible = True
                lineComments.Visible = True
                txtFormNameBG.Visible = True
            Catch ex As Exception
                panelComments.Visible = False
                panelHeaders.Visible = False
                lblHeaderComments.Visible = False
                lineSplitter.Visible = False
                lineComments.Visible = False
                txtFormNameBG.Visible = True
            End Try
        Else
            panelComments.Visible = False
            panelHeaders.Visible = False
            lblHeaderComments.Visible = False
            lineSplitter.Visible = False
            lineComments.Visible = False
            txtFormNameBG.Visible = False
        End If

        btnWatchTrailer.Location = imgPoster.PointToClient(btnWatchTrailer.Parent.PointToScreen(btnWatchTrailer.Location))
        btnWatchTrailer.Parent = imgPoster
        btnWatchTrailer.BackColor = Color.Transparent
        btnWatchTrailer.BringToFront()
        btnWatchTrailer.Location = New Point((imgPoster.Width - btnWatchTrailer.Width) \ 2, (imgPoster.Height - btnWatchTrailer.Height) \ 2)

        'If Popcorn Time API doesn't have trailer available
        If infoTrailerLink.Text = "" Then
            btnWatchTrailer.Visible = False
        Else
            btnWatchTrailer.Visible = True
        End If
        Show()
    End Sub

#Region "Searchable Labels Events"

    Public Sub searchItem_Click(sender As Object, e As EventArgs)
        Try
            If Not sender.Text = "N/A" Then
                frmBackgroundMovieDetails.Hide()
                Hide()
                Movieo.txtboxSearch.Focus()
                Movieo.txtboxSearch.Text = sender.text
                Movieo.Tab.SelectedTab = Movieo.tabLoading
                Movieo.timerSearchMovies.Enabled = True
                Close()
            End If
        Catch ex As Exception
            'False Positive
        End Try
    End Sub

    Public Sub searchItem_MouseMove(sender As Object, e As EventArgs)
        sender.ForeColor = Color.White
    End Sub

    Public Sub searchItem_MouseLeave(sender As Object, e As EventArgs)
        sender.ForeColor = Color.FromArgb(150, 159, 170)
    End Sub

    Public Sub genreItem_MouseMove(sender As Object, e As EventArgs)
        sender.ForeColor = Color.White
    End Sub

    Public Sub genreItem_MouseLeave(sender As Object, e As EventArgs)
        sender.ForeColor = Color.FromArgb(172, 180, 191)
    End Sub

    Public Sub genreItem_Click(sender As Object, e As EventArgs)
        frmBackgroundMovieDetails.Hide()
        Hide()
        For Each a As Control In Movieo.panelGenresCtrls.Controls
            If sender.Text = a.Text Then
                a.BackColor = Color.FromArgb(43, 50, 61)
                a.ForeColor = Color.White
            Else
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            End If
        Next

        Movieo.panelMovies.Controls.Clear()
        Movieo.storeControlsScroll.Clear()

        Movieo.selectedGenre = sender.Text

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
        If Movieo.listFavourites.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteH
        End If
    End Sub

    Private Sub BtnFavouriteList_MouseLeave(sender As Object, e As EventArgs) Handles BtnFavouriteList.MouseLeave
        If Movieo.listFavourites.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteL
        End If
    End Sub

    Private Sub BtnFavouriteList_Click(sender As Object, e As EventArgs) Handles BtnFavouriteList.Click
        If Movieo.listFavourites.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.panelLibraryFavourites, Movieo.listFavourites, infoTitle.Text, infoYear.Text, infoImdbId.Text)
            BtnFavouriteList.Image = imgFavouriteL
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " removed from Favourites")
        Else
            Movieo.AddMovie(Movieo.panelLibraryFavourites, Movieo.listFavourites, infoTitle.Text, infoYear.Text, infoGenre.Text, infoDirectors.Text, infoCast.Text, infoDescription.Text, infoDuration.Text, infoRating.Text, infoReleaseDate.Text, infoCountry.Text, infoLanguage.Text, infoProduction.Text, infoBoxOffice.Text, infoAwards.Text, infoImdbId.Text, infoRatingIMDb.Text, infoRatingNetflix.Text, infoRatingMetaScore.Text, infoImageLink.Text, MovieLinkText.Text)
            BtnFavouriteList.Image = imgFavouriteSticky
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " added to Favourites")
        End If
    End Sub

    Private Sub BtnWatchList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnWatchList.MouseMove
        If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListH
        End If
    End Sub

    Private Sub BtnWatchList_MouseLeave(sender As Object, e As EventArgs) Handles BtnWatchList.MouseLeave
        If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListL
        End If
    End Sub

    Private Sub btnWatchList_Click(sender As Object, e As EventArgs) Handles BtnWatchList.Click
        If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.panelLibraryWatchList, Movieo.listWatchList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
            BtnWatchList.Image = imgWatchListL
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " removed from Watch List")
        Else
            Movieo.AddMovie(Movieo.panelLibraryWatchList, Movieo.listWatchList, infoTitle.Text, infoYear.Text, infoGenre.Text, infoDirectors.Text, infoCast.Text, infoDescription.Text, infoDuration.Text, infoRating.Text, infoReleaseDate.Text, infoCountry.Text, infoLanguage.Text, infoProduction.Text, infoBoxOffice.Text, infoAwards.Text, infoImdbId.Text, infoRatingIMDb.Text, infoRatingNetflix.Text, infoRatingMetaScore.Text, infoImageLink.Text, MovieLinkText.Text)
            BtnWatchList.Image = imgWatchListSticky
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " added to Watch List")

            If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelLibraryBlackList, Movieo.listBlackList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnBlackList.Image = imgBlackListL
            End If

            If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelLibrarySeenList, Movieo.listSeenList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnSeenList.Image = imgSeenListL
            End If
        End If

    End Sub

    Private Sub btnSeenList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSeenList.MouseMove
        If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListH
        End If
    End Sub

    Private Sub btnSeenList_MouseLeave(sender As Object, e As EventArgs) Handles BtnSeenList.MouseLeave
        If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListL
        End If
    End Sub

    Private Sub btnSeenList_Click(sender As Object, e As EventArgs) Handles BtnSeenList.Click
        If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.panelLibrarySeenList, Movieo.listSeenList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
            BtnSeenList.Image = imgSeenListL
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " removed from Seen List")
        Else
            Movieo.AddMovie(Movieo.panelLibrarySeenList, Movieo.listSeenList, infoTitle.Text, infoYear.Text, infoGenre.Text, infoDirectors.Text, infoCast.Text, infoDescription.Text, infoDuration.Text, infoRating.Text, infoReleaseDate.Text, infoCountry.Text, infoLanguage.Text, infoProduction.Text, infoBoxOffice.Text, infoAwards.Text, infoImdbId.Text, infoRatingIMDb.Text, infoRatingNetflix.Text, infoRatingMetaScore.Text, infoImageLink.Text, MovieLinkText.Text)
            BtnSeenList.Image = imgSeenListSticky
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " added to Seen List")

            If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelLibraryBlackList, Movieo.listBlackList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnBlackList.Image = imgBlackListL
            End If

            If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelLibraryWatchList, Movieo.listWatchList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnWatchList.Image = imgWatchListL
            End If
        End If

    End Sub

    Private Sub BtnBlackList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnBlackList.MouseMove
        If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListH
        End If
    End Sub

    Private Sub BtnBlackList_MouseLeave(sender As Object, e As EventArgs) Handles BtnBlackList.MouseLeave
        If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListL
        End If
    End Sub

    Private Sub BtnBlackList_Click(sender As Object, e As EventArgs) Handles BtnBlackList.Click
        If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.panelLibraryBlackList, Movieo.listBlackList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
            BtnBlackList.Image = imgBlackListL
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " removed from Black List")
        Else
            Movieo.AddMovie(Movieo.panelLibraryBlackList, Movieo.listBlackList, infoTitle.Text, infoYear.Text, infoGenre.Text, infoDirectors.Text, infoCast.Text, infoDescription.Text, infoDuration.Text, infoRating.Text, infoReleaseDate.Text, infoCountry.Text, infoLanguage.Text, infoProduction.Text, infoBoxOffice.Text, infoAwards.Text, infoImdbId.Text, infoRatingIMDb.Text, infoRatingNetflix.Text, infoRatingMetaScore.Text, infoImageLink.Text, MovieLinkText.Text)
            BtnBlackList.Image = imgBlackListSticky
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " added to Black List")

            If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelLibrarySeenList, Movieo.listSeenList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnSeenList.Image = imgSeenListL
            End If

            If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.panelLibraryWatchList, Movieo.listWatchList, infoTitle.Text, infoYear.Text, infoImdbId.Text)
                BtnWatchList.Image = imgWatchListL
            End If
        End If
    End Sub

#End Region

#Region "Watch Movie, Download Movie & Watch Trailer (beta)"

    Public IsMovieUrlContextOpen As Boolean = False

    Private Sub btnWatchMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnWatchMovie.ClickButtonArea
        Try
            If infoBackgroundImageLink.Text = "" Then
                frmSelectSource.Opacity = 0.98
            Else
                frmSelectSource.Opacity = 0.85
            End If

            Dim getUrlFromUser As String = Movieo.returnSource(Me, infoTitle.Text + " (" + infoYear.Text + ")", infoWatchLinks.Text, "watch")

            If Not getUrlFromUser = Nothing Then
                frmMediaPlayer.Text = "Watching " + infoTitle.Text + " (" + infoYear.Text + ")"
                frmMediaPlayer.MediaPlayerControl.URL = getUrlFromUser
                frmMediaPlayer.Show(Me)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnWatchMovie_MouseMove(sender As Object, e As MouseEventArgs) Handles btnWatchMovie.MouseMove, btnDownloadMovie.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.FromArgb(87, 102, 125)
        sender.ColorFillSolid = Color.FromArgb(87, 102, 125)
    End Sub

    Private Sub btnWatchMovie_MouseLeave(sender As Object, e As EventArgs) Handles btnWatchMovie.MouseLeave, btnDownloadMovie.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(60, 70, 85)
        sender.ColorFillSolid = Color.FromArgb(60, 70, 85)
    End Sub

    Private Sub btnWatchTrailer_Click(Sender As Object, e As MouseEventArgs) Handles btnWatchTrailer.Click
        Try
            If Not infoTrailerLink.Text = "" Then
                frmTrailerPlayer.swfPlayer.Movie = infoTrailerLink.Text.Replace("watch?v=", "v/") 'Valid Example: https://youtube.com/v/kmJLuwP3MbY
                frmTrailerPlayer.Show(Me)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDownloadMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDownloadMovie.ClickButtonArea
        Try
            If infoBackgroundImageLink.Text = "" Then
                frmSelectSource.Opacity = 0.98
            Else
                frmSelectSource.Opacity = 0.85
            End If

            Dim getUrlFromUser As String = Movieo.returnSource(Me, infoTitle.Text + " (" + infoYear.Text + ")", infoWatchLinks.Text, "download")

            If Not getUrlFromUser = Nothing Then
                frmDownloadClient.doDownload(getUrlFromUser, infoTitle.Text, infoYear.Text, getUrlFromUser.Substring(infoWatchLinks.Text.Length - 3))
                frmDownloadClient.ShowDialog(Me)
            End If
        Catch ex As Exception
            Show()
            Movieo.ShowPopupOk("Unable to download movie", "It seems there's an issue connecting to the stream. Please try using a different source. ", Me)
        End Try
    End Sub

#End Region

#Region "Go to Movie on Website (IMDb)"

    Private Sub ImgImdb_Click(sender As Object, e As EventArgs) Handles infoRatingIMDb.Click, imgImdb.Click
        Try
            Process.Start("http://www.imdb.com/title/" + infoImdbId.Text)
        Catch ex As Exception
            Movieo.ShowPopupOk("Unable to open URL", ex.Message, Me)
        End Try
    End Sub

    Private Sub frmMovieDetails_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Show()
    End Sub

#End Region

#Region "User Reviews (Comments)"

    Private Sub btnCommentSubmit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnCommentSubmit.ClickButtonArea
        If Not TimeAgo(TimeStamp) = "just now" Then
            If txtShareComment.Text = "" Or txtShareName.Text = "" Then
                showMessage("Content can't be blank," + vbNewLine + "Content is too short (minimum is 1 character)")
            Else
                showMessage("Opening default mail client...")
                Movieo.openMail("Movieo - New Comment", "Date: " + Date.Now.ToString("dd/MM/yyyy") + "%0A" + "Movie: " + infoTitle.Text + " (" + infoYear.Text + ")" + "%0A" + "Name: " + txtShareName.Text + "%0A" + "Comment: " + txtShareComment.Text)
                txtShareComment.Text = ""
                txtShareName.Text = ""
            End If
        Else
            showMessage("Please wait before posting again.")
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

    Private Sub panelComments_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelComments.ControlAdded
        imgPanelsEmptyReviews.Visible = False
    End Sub

#End Region

#Region "Notification Message"

    Private Sub timerHideNotification_Tick(sender As Object, e As EventArgs) Handles timerHideNotifications.Tick
        lblMessageSent.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Private Sub lblMessageSent_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles lblMessageSent.ClickButtonArea
        lblMessageSent.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Public Sub showMessage(Message As String)
        lblMessageSent.Text = Message
        Dim myFont As New Font(lblMessageSent.Font.FontFamily, Me.lblMessageSent.Font.Size)
        '
        ' Or, use this for a specific font and font size.
        ' Dim myFont As New System.Drawing.Font("Verdana", 8)

        ' Get the size given the string and the font
        Dim mySize = lblMessageSent.CreateGraphics.MeasureString(Message, myFont)

        ' Resize the textbox to accommodate the entire string
        'Me.TextBox1.Width = mySize.Width
        lblMessageSent.Width = CType(Math.Round(mySize.Width, 0), Integer) + 20
        lblMessageSent.Height = CType(Math.Round(mySize.Height, 0), Integer) + 14
        lblMessageSent.Location = New Point((ClientSize.Width - lblMessageSent.Width) \ 2, -1)
        lblMessageSent.Visible = True
        TimeStamp = Date.Now
        timerHideNotifications.Enabled = True
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

    Private Sub frmMovieDetails_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Try
            For Each item As Label In dynControls
                InfoPanel1.Controls.Remove(item)
            Next
            dynControls.Clear()
            frmBackgroundMovieDetails.Close()
        Catch ex As Exception
        End Try
    End Sub

#End Region

End Class