Imports System.Drawing.Imaging


Public Class PosterTitle

    Private Sub InfoPoster_ClickButtonArea(sender As Object, e As EventArgs) Handles InfoPoster.ClickButtonArea
        ShowMovie()
    End Sub

    Public Sub ShowMovie()
        Try
            If Odeum_Movies.FavouriteMovies.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                MovieInfo.TextFavourites.Text = "Remove from favourites"
            Else
                MovieInfo.TextFavourites.Text = "Add to favourites"
            End If
            If Odeum_Movies.WatchListMovies.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                MovieInfo.TextWatchList.Text = "Remove from watch list"
            Else
                MovieInfo.TextWatchList.Text = "Add to watch list"
            End If

            If Odeum_Movies.WatchedMovies.Items.Contains(InfoTitle.Text + " (" + InfoYear.Text + ")") Then
                MovieInfo.TextWatched.Text = "Watched"
            Else
                MovieInfo.TextWatched.Text = "Not watched"
            End If

            MovieInfo.MovieTitleText.Text = InfoTitle.Text
            MovieInfo.MovieDescriptionText.Text = InfoDesc.Text
            MovieInfo.MovieDurationText.Text = InfoDuration.Text
            MovieInfo.MovieYearText.Text = InfoYear.Text
            MovieInfo.MovieGenreText.Text = InfoGenre.Text
            MovieInfo.MovieDirectorText.Text = InfoDirector.Text
            MovieInfo.MovieStarsText.Text = InfoStars.Text
            MovieInfo.MovieRatingText.Text = InfoRating.Text + "/10"

            MovieInfo.MovieLinkText.Text = InfoMovieLink.Text

            MovieInfo.MovImage.Image = InfoPoster2.Image

            MovieInfo.MovieImageLinkText.Text = InfoPosterLink.Text
            MovieInfo.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InfoPoster_MouseEnter(sender As Object, e As EventArgs) Handles InfoPoster.MouseEnter
        Try
            If Not InfoPoster2.Image Is Nothing Then
                InfoPoster2.Image.Dispose()
            End If
            InfoPoster2.Image = New Bitmap(InfoPoster.BackgroundImage)
            InfoPoster.BorderShow = True
            InfoPoster.BackgroundImage.Dispose()
            InfoPoster.BackgroundImage = ChangeOpacity(InfoPoster2.Image, 0.4)
            Update()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InfoPoster_MouseLeave(sender As Object, e As EventArgs) Handles InfoPoster.MouseLeave
        Try
            InfoPoster.BackgroundImage.Dispose()
            InfoPoster.BorderShow = False
            InfoPoster.BackgroundImage = ChangeOpacity(InfoPoster2.Image, 1)
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap
        Try
            Dim bmp As New Bitmap(img.Width, img.Height)
            Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
            Dim colormatrix As New ColorMatrix
            colormatrix.Matrix33 = opacityvalue
            Dim imgAttribute As New ImageAttributes
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
            graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height,
            GraphicsUnit.Pixel, imgAttribute)
            graphics__1.Dispose()
            Return bmp
        Catch ex As Exception
        End Try
    End Function

    Private Sub MovieTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Odeum_Movies.PanelMovies.BackColor
    End Sub
End Class