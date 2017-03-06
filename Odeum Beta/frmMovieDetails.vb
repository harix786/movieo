Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net

Public Class frmMovieDetails

    'Movie actions icons
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

    Private Sub MovieInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hide()

        Top = 0
        Left = 0
        Size = New Size(Movieo.Size)

        If Movieo.itemsFavouritesList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteL
        End If

        If Movieo.itemsWatchList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListL
        End If

        If Movieo.itemsSeenList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListL
        End If

        If Movieo.itemsBlackList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListL
        End If


    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Close()
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As MouseEventArgs) Handles appClose.MouseMove
        appClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles appClose.MouseLeave
        appClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub btnFaveMovie_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnFavouriteList.MouseMove
        If Movieo.itemsFavouritesList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteH
        End If
    End Sub

    Private Sub btnFaveMovie_MouseLeave(sender As Object, e As EventArgs) Handles BtnFavouriteList.MouseLeave
        If Movieo.itemsFavouritesList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnFavouriteList.Image = imgFavouriteSticky
        Else
            BtnFavouriteList.Image = imgFavouriteL
        End If
    End Sub

    Private Sub btnFaveMovie_Click(sender As Object, e As EventArgs) Handles BtnFavouriteList.Click
        If Movieo.itemsFavouritesList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.PanelFavourites, Movieo.itemsFavouritesList, InfoTitle.Text, InfoYear.Text)
            BtnFavouriteList.Image = imgFavouriteL
        Else
            Movieo.AddMovie(Movieo.PanelFavourites, Movieo.itemsFavouritesList, InfoTitle.Text, InfoYear.Text, InfoGenre.Text, InfoDirectors.Text, InfoCast.Text, InfoDescription.Text, MovieDuration.Text, MovieImdbRating.Text.Replace("/10", ""), MovieImageLinkText.Text, MovieLinkText.Text)
            BtnFavouriteList.Image = imgFavouriteSticky
        End If
    End Sub

    Private Sub btnWatchSeason_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnWatchList.MouseMove
        If Movieo.itemsWatchList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListH
        End If
    End Sub

    Private Sub btnWatchSeason_MouseLeave(sender As Object, e As EventArgs) Handles BtnWatchList.MouseLeave
        If Movieo.itemsWatchList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnWatchList.Image = imgWatchListSticky
        Else
            BtnWatchList.Image = imgWatchListL
        End If
    End Sub

    Private Sub btnWatchListClick(sender As Object, e As EventArgs) Handles BtnWatchList.Click

        If Movieo.itemsWatchList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.PanelWatchList, Movieo.itemsWatchList, InfoTitle.Text, InfoYear.Text)
            BtnWatchList.Image = imgWatchListL
        Else
            Movieo.AddMovie(Movieo.PanelWatchList, Movieo.itemsWatchList, InfoTitle.Text, InfoYear.Text, InfoGenre.Text, InfoDirectors.Text, InfoCast.Text, InfoDescription.Text, MovieDuration.Text, MovieImdbRating.Text.Replace("/10", ""), MovieImageLinkText.Text, MovieLinkText.Text)
            BtnWatchList.Image = imgWatchListSticky

            If Movieo.itemsBlackList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.PanelBlackList, Movieo.itemsBlackList, InfoTitle.Text, InfoYear.Text)
                BtnBlackList.Image = imgBlackListL
            End If

            If Movieo.itemsSeenList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.PanelSeenList, Movieo.itemsSeenList, InfoTitle.Text, InfoYear.Text)
                BtnSeenList.Image = imgSeenListL
            End If
        End If

    End Sub

    Private Sub btnSeenList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSeenList.MouseMove
        If Movieo.itemsSeenList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListH
        End If
    End Sub

    Private Sub btnSeenList_MouseLeave(sender As Object, e As EventArgs) Handles BtnSeenList.MouseLeave
        If Movieo.itemsSeenList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnSeenList.Image = imgSeenListSticky
        Else
            BtnSeenList.Image = imgSeenListL
        End If
    End Sub

    Private Sub btnSeenList_Click(sender As Object, e As EventArgs) Handles BtnSeenList.Click
        If Movieo.itemsSeenList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.PanelSeenList, Movieo.itemsSeenList, InfoTitle.Text, InfoYear.Text)
            BtnSeenList.Image = imgSeenListL
        Else
            Movieo.AddMovie(Movieo.PanelSeenList, Movieo.itemsSeenList, InfoTitle.Text, InfoYear.Text, InfoGenre.Text, InfoDirectors.Text, InfoCast.Text, InfoDescription.Text, MovieDuration.Text, MovieImdbRating.Text.Replace("/10", ""), MovieImageLinkText.Text, MovieLinkText.Text)
            BtnSeenList.Image = imgSeenListSticky

            If Movieo.itemsBlackList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.PanelBlackList, Movieo.itemsBlackList, InfoTitle.Text, InfoYear.Text)
                BtnBlackList.Image = imgBlackListL
            End If

            If Movieo.itemsWatchList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.PanelWatchList, Movieo.itemsWatchList, InfoTitle.Text, InfoYear.Text)
                BtnWatchList.Image = imgWatchListL
            End If
        End If

    End Sub

    Private Sub BtnBlackList_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnBlackList.MouseMove
        If Movieo.itemsBlackList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListH
        End If
    End Sub

    Private Sub BtnBlackList_MouseLeave(sender As Object, e As EventArgs) Handles BtnBlackList.MouseLeave
        If Movieo.itemsBlackList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            BtnBlackList.Image = imgBlackListSticky
        Else
            BtnBlackList.Image = imgBlackListL
        End If
    End Sub

    Private Sub BtnBlackList_Click(sender As Object, e As EventArgs) Handles BtnBlackList.Click
        If Movieo.itemsBlackList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
            Movieo.RemoveMovie(Movieo.PanelBlackList, Movieo.itemsBlackList, InfoTitle.Text, InfoYear.Text)
            BtnBlackList.Image = imgBlackListL
        Else
            Movieo.AddMovie(Movieo.PanelBlackList, Movieo.itemsBlackList, InfoTitle.Text, InfoYear.Text, InfoGenre.Text, InfoDirectors.Text, InfoCast.Text, InfoDescription.Text, MovieDuration.Text, MovieImdbRating.Text.Replace("/10", ""), MovieImageLinkText.Text, MovieLinkText.Text)
            BtnBlackList.Image = imgBlackListSticky

            If Movieo.itemsSeenList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.PanelSeenList, Movieo.itemsSeenList, InfoTitle.Text, InfoYear.Text)
                BtnSeenList.Image = imgSeenListL
            End If

            If Movieo.itemsWatchList.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                Movieo.RemoveMovie(Movieo.PanelWatchList, Movieo.itemsWatchList, InfoTitle.Text, InfoYear.Text)
                BtnWatchList.Image = imgWatchListL
            End If
        End If
    End Sub


    'Watch Trailer (beta), Watch Movie & Download Movie
    Private Sub btnWatchMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnWatchMovie.ClickButtonArea
        Try
            frmPlayer.PlayerMovieTitle.Text = InfoTitle.Text + " (" + InfoYear.Text + ")"
            frmPlayer.MediaPlayerControl.URL = MovieLinkText.Text
            frmPlayer.Show(Me)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
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
            Dim GetLink As String = Movieo.NetDl.DownloadString("http://trailersapi.com/trailers.json?movie=" + InfoTitle.Text + "&limit=1")
            Dim SplitIt = GetLink.Split(Chr(34))
            Dim EmbedLink = SplitIt(12).Replace("\/", "\")
            frmTrailerPlayer.web.Navigate(EmbedLink)
            frmTrailerPlayer.Show(Me)
        Catch ex As Exception
            Movieo.ShowPopupError("Unable to locate trailer", "Sorry, but we're unable to find a trailer for this movie.", Me)
        End Try
    End Sub

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
            frmDownloadClient.doDownload(MovieLinkText.Text, InfoTitle.Text, InfoYear.Text, MovieLinkText.Text.Substring(MovieLinkText.Text.Length - 3))
        Catch ex As Exception
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


    'Go to Movie on Website (IMDb & Rotten Tomatoes)
    Private Sub ImgImdb_Click(sender As Object, e As EventArgs) Handles ImgImdb.Click, MovieImdbRating.Click
        Process.Start("http://www.imdb.com/title/" + MovieImdbId.Text)
    End Sub

    Private Sub ImgRTomatoes_Click(sender As Object, e As EventArgs) Handles ImgRTomatoes.Click, MovieTomRating.Click
        Process.Start(MovieRTomLink.Text)
    End Sub

    Private Sub frmMovieDetails_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Show()
    End Sub
End Class