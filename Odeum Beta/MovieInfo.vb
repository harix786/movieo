Imports System.Drawing.Imaging
Imports System.Net

Public Class MovieInfo

    Public FavouriteImageH As Bitmap = My.Resources.FavouriteH
    Public FavouriteImageL As Bitmap = My.Resources.FavouriteL
    Public WatchListImageH As Bitmap = My.Resources.WatchListH
    Public WatchListImageL As Bitmap = My.Resources.WatchListL
    Public WatchedImageH As Bitmap = My.Resources.WatchedH
    Public WatchedImageL As Bitmap = My.Resources.WatchedL

    Private Sub MovieInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Size = New Size(Odeum_Movies.Size)

        If Odeum_Movies.FavouriteMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            BtnFavourite.Image = FavouriteImageH
            TextFavourites.ForeColor = Color.White
        Else
            BtnFavourite.Image = FavouriteImageL
            TextFavourites.ForeColor = Color.FromArgb(172, 180, 191)
        End If

        If Odeum_Movies.WatchListMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            BtnWatchList.Image = WatchListImageH
            TextWatchList.ForeColor = Color.White
        Else
            BtnWatchList.Image = WatchListImageL
            TextWatchList.ForeColor = Color.FromArgb(172, 180, 191)
        End If

        If Odeum_Movies.WatchedMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            BtnWatched.Image = WatchedImageH
            TextWatched.ForeColor = Color.White
        Else
            BtnWatched.Image = WatchedImageL
            TextWatched.ForeColor = Color.FromArgb(172, 180, 191)
        End If


    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Close()
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As EventArgs) Handles appClose.MouseMove
        appClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles appClose.MouseLeave
        appClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub btnFaveMovie_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnFavourite.MouseMove, TextFavourites.MouseMove
        BtnFavourite.Image = FavouriteImageH
        TextFavourites.ForeColor = Color.White
    End Sub

    Private Sub btnFaveMovie_MouseLeave(sender As Object, e As EventArgs) Handles BtnFavourite.MouseLeave, TextFavourites.MouseLeave
        If Odeum_Movies.FavouriteMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            BtnFavourite.Image = FavouriteImageH
            TextFavourites.ForeColor = Color.White
        Else
            BtnFavourite.Image = FavouriteImageL
            TextFavourites.ForeColor = Color.FromArgb(172, 180, 191)
        End If
    End Sub

    Private Sub btnFaveMovie_Click(sender As Object, e As EventArgs) Handles BtnFavourite.Click, TextFavourites.Click
        If Odeum_Movies.FavouriteMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            For Each a As Control In Odeum_Movies.PanelFavourites.Controls
                For Each ab As Control In a.Controls
                    If ab.Text = MovieTitleText.Text Then
                        Odeum_Movies.PanelFavourites.Controls.Remove(a)
                    End If
                Next
            Next
            Odeum_Movies.FavouriteMovies.Items.Remove(MovieTitleText.Text + " (" + MovieYearText.Text + ")")
            BtnFavourite.Image = FavouriteImageL
            TextFavourites.Text = "Add to favourites"
        Else
            TextFavourites.Text = "Remove from favourites"
            BtnFavourite.Image = FavouriteImageH
            Odeum_Movies.AddMovie(Odeum_Movies.PanelFavourites, Odeum_Movies.FavouriteMovies, MovieTitleText.Text, MovieYearText.Text, MovieGenreText.Text, MovieDirectorText.Text, MovieStarsText.Text, MovieDescriptionText.Text, MovieDurationText.Text, MovieRatingText.Text.Replace("/10", ""), MovieImageLinkText.Text, MovieLinkText.Text)
        End If
    End Sub

    Private Sub btnWatchSeason_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnWatchList.MouseMove, TextWatchList.MouseMove
        BtnWatchList.Image = WatchListImageH
        TextWatchList.ForeColor = Color.White
    End Sub

    Private Sub btnWatchSeason_MouseLeave(sender As Object, e As EventArgs) Handles BtnWatchList.MouseLeave, TextWatchList.MouseLeave
        If Odeum_Movies.WatchListMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            BtnWatchList.Image = WatchListImageH
            TextWatchList.ForeColor = Color.White
        Else
            BtnWatchList.Image = WatchListImageL
            TextWatchList.ForeColor = Color.FromArgb(172, 180, 191)
        End If
    End Sub

    Private Sub btnWatchSeason_Click(sender As Object, e As EventArgs) Handles BtnWatchList.Click, TextWatchList.Click
        If Odeum_Movies.WatchListMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            For Each a As Control In Odeum_Movies.PanelWatchList.Controls
                For Each ab As Control In a.Controls
                    If ab.Text = MovieTitleText.Text Then
                        Odeum_Movies.PanelWatchList.Controls.Remove(a)
                    End If
                Next
            Next
            Odeum_Movies.WatchListMovies.Items.Remove(MovieTitleText.Text + " (" + MovieYearText.Text + ")")
            BtnWatchList.Image = WatchListImageL
            TextWatchList.Text = "Add to watch list"
        Else
            TextWatchList.Text = "Remove from watch list"
            BtnWatchList.Image = WatchListImageH
            Odeum_Movies.AddMovie(Odeum_Movies.PanelWatchList, Odeum_Movies.WatchListMovies, MovieTitleText.Text, MovieYearText.Text, MovieGenreText.Text, MovieDirectorText.Text, MovieStarsText.Text, MovieDescriptionText.Text, MovieDurationText.Text, MovieRatingText.Text.Replace("/10", ""), MovieImageLinkText.Text, MovieLinkText.Text)
        End If
    End Sub

    Private Sub btnSeenMovie_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnWatched.MouseMove, TextWatched.MouseMove
        BtnWatched.Image = WatchedImageH
        TextWatched.ForeColor = Color.White
    End Sub

    Private Sub btnSeenMovie_MouseLeave(sender As Object, e As EventArgs) Handles BtnWatched.MouseLeave, TextWatched.MouseLeave
        If Odeum_Movies.WatchedMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            BtnWatched.Image = WatchedImageH
            TextWatched.ForeColor = Color.White
        Else
            BtnWatched.Image = WatchedImageL
            TextWatched.ForeColor = Color.FromArgb(172, 180, 191)
        End If
    End Sub

    Private Sub btnSeenMovie_Click(sender As Object, e As EventArgs) Handles BtnWatched.Click, TextWatched.Click
        If Odeum_Movies.WatchedMovies.Items.Contains(MovieTitleText.Text + " (" + MovieYearText.Text + ")") Then
            Odeum_Movies.WatchedMovies.Items.Remove(MovieTitleText.Text + " (" + MovieYearText.Text + ")")
            BtnWatched.Image = WatchedImageL
            TextWatched.Text = "Not watched"
        Else
            TextWatched.Text = "Watched"
            BtnWatched.Image = WatchedImageH
            Odeum_Movies.WatchedMovies.Items.Add(MovieTitleText.Text + " (" + MovieYearText.Text + ")")
        End If
    End Sub

    Private Sub btnWatchMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnWatchMovie.ClickButtonArea
        Try
            MoviePlayer.PlayerMovieTitle.Text = MovieTitleText.Text + " (" + MovieYearText.Text + ")"
            MoviePlayer.MediaPlayerControl.URL = MovieLinkText.Text
            MoviePlayer.Show(Me)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CButton2_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles BtnDownloadMovie.ClickButtonArea
        DownloadClient.Show(Me)
        DownloadClient.DownloadMovie(MovieLinkText.Text, MovieTitleText.Text, MovieYearText.Text, MovieLinkText.Text.Substring(MovieLinkText.Text.Length - 3))
    End Sub

    Private Sub BtnDownloadMovie_MouseMove(sender As Object, e As MouseEventArgs) Handles btnWatchMovie.MouseMove, BtnDownloadMovie.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnWatchMovie_MouseLeave(sender As Object, e As EventArgs) Handles btnWatchMovie.MouseLeave, BtnDownloadMovie.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub


End Class