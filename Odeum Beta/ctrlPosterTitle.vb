Option Explicit On
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class ctrlPosterTitle

    Public Sub ShowMovie()
        Try
            'Prioritise already acquired information
            frmMovieDetails.infoTitle.Text = InfoTitle.Text
            frmMovieDetails.infoYear.Text = InfoYear.Text
            frmMovieDetails.infoGenre.Text = InfoGenre.Text
            frmMovieDetails.infoCountry.Text = InfoCountry.Text
            frmMovieDetails.infoLanguage.Text = InfoLanguage.Text
            frmMovieDetails.infoImdbId.Text = InfoImdbId.Text
            frmMovieDetails.infoRatingIMDb.Text = infoRatingIMDb.Text
            frmMovieDetails.infoQuality.Text = ReturnQuality(InfoMovieLink.Text)
            frmMovieDetails.infoWatchLinks.Text = InfoMovieLink.Text
            frmMovieDetails.infoImageLink.Text = InfoPosterLink.Text
            frmMovieDetails.infoCast.Text = InfoStars.Text
            frmMovieDetails.infoDirectors.Text = InfoDirector.Text


            Dim WebClient = New WebClient()

            'Details from OMDbAPI
            Dim OMDbAPI = WebClient.DownloadString("http://www.omdbapi.com/?apikey=c933e052&t=" & InfoTitle.Text & "&y=" & InfoYear.Text + "&tomatoes=true")
            Dim jsonOMDbAPI As JObject = JObject.Parse(OMDbAPI)

            frmMovieDetails.infoDescription.Text = jsonOMDbAPI.SelectToken("Plot")
            frmMovieDetails.infoDuration.Text = jsonOMDbAPI.SelectToken("Runtime")
            frmMovieDetails.infoReleaseDate.Text = jsonOMDbAPI.SelectToken("Released")
            frmMovieDetails.infoRating.Text = jsonOMDbAPI.SelectToken("Rated")
            frmMovieDetails.infoProduction.Text = jsonOMDbAPI.SelectToken("Production")
            frmMovieDetails.infoBoxOffice.Text = jsonOMDbAPI.SelectToken("BoxOffice")
            frmMovieDetails.infoAwards.Text = jsonOMDbAPI.SelectToken("Awards")

            'Ratings
            frmMovieDetails.infoImdbId.Text = jsonOMDbAPI.SelectToken("imdbID")
            frmMovieDetails.infoRatingIMDb.Text = jsonOMDbAPI.SelectToken("imdbRating")
            frmMovieDetails.infoRatingMetaScore.Text = jsonOMDbAPI.SelectToken("Metascore")

            'Netflix Rating
            Try
                Dim netflixrouletteAPI = WebClient.DownloadString("https://netflixroulette.net/api/api.php?title=" & InfoTitle.Text & "&year=" & InfoYear.Text)
                Dim jsonNetflixRouletteAPI As JObject = JObject.Parse(netflixrouletteAPI)
                frmMovieDetails.infoRatingNetflix.Text = jsonNetflixRouletteAPI.SelectToken("rating")
            Catch ex As Exception
                frmMovieDetails.infoRatingNetflix.Text = "N/A"
            End Try

            Try
                'Split Director/Cast into clickable Labels to search
                frmMovieDetails.infoDirectors.Visible = False
                Dim aDirector As New Label
                With aDirector
                    .AutoSize = True
                    .Font = Movieo.CreateFont("Segoe UI", 12.5, False, False, False)
                    .ForeColor = Color.FromArgb(150, 159, 170)
                    .Margin = New Padding(0, 14, 3, 0)
                    .Text = InfoDirector.Text
                    .BackColor = Color.Transparent
                    .Cursor = Cursors.Hand
                    .Name = InfoDirector.Text
                    .Show()
                    AddHandler .Click, AddressOf frmMovieDetails.castItem_Click
                    AddHandler .MouseMove, AddressOf frmMovieDetails.castItem_MouseMove
                    AddHandler .MouseLeave, AddressOf frmMovieDetails.castItem_MouseLeave
                End With
                frmMovieDetails.InfoPanel1.Controls.Add(aDirector)
                frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aDirector, 8)
                frmMovieDetails.InfoPanel1.SetFlowBreak(aDirector, True)
                frmMovieDetails.dynControls.Add(aDirector)

                frmMovieDetails.infoCast.Visible = False
                Dim countCast As Integer = 0
                Dim castInText() As String = Split(InfoStars.Text, ", ")
                For Each cast As String In castInText
                    countCast = countCast + 1
                    Dim aCast As New Label
                    With aCast
                        .AutoSize = True
                        .Font = Movieo.CreateFont("Segoe UI", 12.5, False, False, False)
                        .ForeColor = Color.FromArgb(150, 159, 170)
                        .Margin = New Padding(0, 7, 3, 0)
                        .Text = cast
                        .BackColor = Color.Transparent
                        .Cursor = Cursors.Hand
                        .Name = cast
                        .Show()
                        AddHandler .Click, AddressOf frmMovieDetails.castItem_Click
                        AddHandler .MouseMove, AddressOf frmMovieDetails.castItem_MouseMove
                        AddHandler .MouseLeave, AddressOf frmMovieDetails.castItem_MouseLeave
                    End With
                    frmMovieDetails.InfoPanel1.Controls.Add(aCast)
                    frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aCast, 10)
                    frmMovieDetails.dynControls.Add(aCast)
                Next

                'Split Genres
                frmMovieDetails.infoGenre.Visible = False
                Dim countGenres As Integer = 0
                Dim genresInText() As String = Split(InfoGenre.Text, ", ")
                For Each genre As String In genresInText
                    countCast = countCast + 1
                    Dim aGenre As New Label
                    With aGenre
                        .AutoSize = True
                        .Font = Movieo.CreateFont("Segoe UI", 12.25, False, False, False)
                        .ForeColor = Color.FromArgb(172, 180, 191)
                        .Margin = New Padding(3, 5, 0, 20)
                        .Text = genre
                        .BackColor = Color.Transparent
                        .Cursor = Cursors.Hand
                        .Name = genre
                        .Show()
                        AddHandler .Click, AddressOf frmMovieDetails.genreItem_Click
                        AddHandler .MouseMove, AddressOf frmMovieDetails.castItem_MouseMove
                        AddHandler .MouseLeave, AddressOf frmMovieDetails.castItem_MouseLeave
                    End With
                    frmMovieDetails.InfoPanel1.Controls.Add(aGenre)
                    frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aGenre, 3)
                    frmMovieDetails.dynControls.Add(aGenre)
                Next
            Catch
            End Try

            Try
                frmMovieDetails.MovImage.BackgroundImage = New Bitmap(New MemoryStream(WebClient.DownloadData(InfoPosterLink.Text)))
            Catch
            End Try

            Try
                Dim popcorntimeAPI = WebClient.DownloadString("https://tv-v2.api-fetch.website/movie/" + InfoImdbId.Text)
                Dim jsonPTAPI As JObject = JObject.Parse(popcorntimeAPI)

                'Details from Popcorn Time API for Background (fanart)
                Dim backgroundLink As String = jsonPTAPI.SelectToken("images").SelectToken("fanart")
                Dim trailerLink As String = jsonPTAPI.SelectToken("trailer")

                frmBackgroundMovieDetails.BackgroundImage = New Bitmap(New MemoryStream(WebClient.DownloadData(backgroundLink)))
                frmMovieDetails.Opacity = 0.9

                'Details from Popcorn Time Api for Trailer Link (YouTube)
                frmMovieDetails.infoTrailerLink.Text = trailerLink
            Catch ex As Exception
                frmMovieDetails.Opacity = 0.98
                frmBackgroundMovieDetails.Opacity = 0
            End Try

            frmMovieDetails.Show(frmBackgroundMovieDetails)
            frmBackgroundMovieDetails.Show(Movieo)
        Catch ex As Exception
            'False Positive (Ignore exception)
            MsgBox(ex.Message)
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
            If My.Settings.doRatingOnPoster = True Then
                InfoImdbRatingPoster.Visible = True
            End If
            Update()
        Catch
        End Try
    End Sub

    Private Sub InfoPoster_MouseLeave(sender As Object, e As EventArgs) Handles InfoPoster.MouseLeave
        Try
            InfoImdbRatingPoster.Visible = False
            InfoPoster.BackgroundImage.Dispose()
            InfoPoster.BorderShow = False
            InfoPoster.BackgroundImage = ChangeOpacity(InfoPoster2.Image, 1)
        Catch
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
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub MovieTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InfoImdbRatingPoster.Parent = InfoPoster
        InfoImdbRatingPoster.BorderColor = Color.White
        InfoImdbRatingPoster.Corners.All = 2
        InfoImdbRatingPoster.ShowFocus = CButtonLib.CButton.eFocus.None
        InfoImdbRatingPoster.BackColor = Color.Transparent
        InfoImdbRatingPoster.ForeColor = Color.White
        InfoImdbRatingPoster.BringToFront()
        InfoImdbRatingPoster.Location = New Point(6, 6)
        InfoImdbRatingPoster.Visible = False

        BackColor = Movieo.panelMovies.BackColor

    End Sub

#Region "Get Quality"

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

    Private Sub InfoPoster_Click(sender As Object, e As EventArgs) Handles InfoPoster.Click
        ShowMovie()
    End Sub

#End Region

End Class