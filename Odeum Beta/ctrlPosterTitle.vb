Option Explicit On
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net

Public Class ctrlPosterTitle

    Private Sub InfoPoster_Click(sender As Object, e As EventArgs) Handles InfoPoster.Click
        ShowMovie()
    End Sub

    Public Sub ShowMovie()
        Try
            frmMovieDetails.InfoTitle.Text = InfoTitle.Text
            frmMovieDetails.InfoDescription.Text = InfoDesc.Text
            frmMovieDetails.MovieDuration.Text = InfoDuration.Text
            frmMovieDetails.InfoYear.Text = InfoYear.Text
            frmMovieDetails.InfoGenre.Text = InfoGenre.Text
            frmMovieDetails.InfoDirectors.Text = InfoDirector.Text
            frmMovieDetails.InfoCast.Text = InfoStars.Text
            frmMovieDetails.InfoQuality.Text = InfoMovieQuality.Text

            frmMovieDetails.MovieImdbRating.Text = InfoImdbRating.Text
            frmMovieDetails.MovieTomRating.Text = InfoRTomatoes.Text + "%"
            frmMovieDetails.MovieMetaRating.Text = InfoRMetaCritic.Text

            frmMovieDetails.MovieRating.Text = InfoRating.Text
            frmMovieDetails.MovieReleaseDate.Text = InfoReleaseDate.Text
            frmMovieDetails.MovieCountry.Text = InfoCountry.Text
            frmMovieDetails.MovieLanguage.Text = InfoLanguage.Text
            frmMovieDetails.MovieProduction.Text = InfoProduction.Text
            frmMovieDetails.MovieBoxOffice.Text = InfoBoxOffice.Text
            frmMovieDetails.MovieAwards.Text = InfoAwards.Text
            frmMovieDetails.MovieImdbId.text = InfoImdbId.Text
            frmMovieDetails.MovieRTomLink.Text = InfoRTomLink.Text

            frmMovieDetails.MovieLinkText.Text = InfoMovieLink.Text

            Dim WebClient = New WebClient()
            frmMovieDetails.MovImage.Image = New Bitmap(New MemoryStream(WebClient.DownloadData(InfoPosterLink.Text)))

            frmMovieDetails.MovieImageLinkText.Text = InfoPosterLink.Text
            frmMovieDetails.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Public Function ReturnQuality(Link As String) As String
        If Link.ToLower.Contains("1080") Then
            Return "1080p"
        ElseIf Link.ToLower.Contains("hdts") Then
            Return "1080p"
        ElseIf Link.ToLower.Contains("bdrip") Then
            Return "1080p"
        ElseIf Link.ToLower.Contains("bd-rip") Then
            Return "1080p"
        ElseIf Link.ToLower.Contains("720") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("webdl") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("web-dl") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("dvdrip") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("dvd-rip") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("hdrip") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("hd-rip") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("hdtv") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("480") Then
            Return "480p"
        ElseIf Link.ToLower.Contains("camrip") Then
            Return "CAM"
        Else
            Return "n/a"
        End If
    End Function

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
        BackColor = Movieo.PanelMovies.BackColor
    End Sub
End Class