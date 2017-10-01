Option Explicit On
Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class ctrlPosterTitle

    Private Sub InfoPoster_Click(sender As Object, e As EventArgs) Handles InfoPoster.Click
        ShowMovie()
    End Sub

    Public Sub ShowMovie()
        Try
            'Prioritise already acquired information in the case of an error
            frmMovieDetails.infoTitle.Text = InfoTitle.Text
            frmMovieDetails.infoYear.Text = InfoYear.Text
            frmMovieDetails.infoCountry.Text = InfoCountry.Text
            frmMovieDetails.infoLanguage.Text = InfoLanguage.Text
            frmMovieDetails.infoImdbId.Text = InfoImdbId.Text
            frmMovieDetails.infoRatingIMDb.Text = infoRatingIMDb.Text
            frmMovieDetails.infoQuality.Text = ReturnQuality(InfoMovieLink.Text)
            frmMovieDetails.infoWatchLinks.Text = InfoMovieLink.Text
            frmMovieDetails.infoImageLink.Text = InfoPosterLink.Text


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
                'Split Director/Cast/Genres into clickable Labels to search

                Dim countDirector As Integer = 0
                frmMovieDetails.infoDirectors.Visible = False
                frmMovieDetails.infoDirectors.Text = InfoDirector.Text
                Dim directorInText() As String = Split(InfoDirector.Text, ", ")
                For Each director As String In directorInText
                    countDirector = countDirector + 1
                    Dim aDirector As New Label
                    With aDirector
                        .AutoSize = True
                        .Font = Movieo.CreateFont("Segoe UI", 12.5, False, False, False)
                        .ForeColor = Color.FromArgb(150, 159, 170)
                        .Margin = New Padding(0, 13, 0, 0)
                        .Text = director
                        .BackColor = Color.Transparent
                        .Cursor = Cursors.Hand
                        .Name = director
                        .Show()
                        AddHandler .Click, AddressOf frmMovieDetails.searchItem_Click
                        AddHandler .MouseMove, AddressOf frmMovieDetails.searchItem_MouseMove
                        AddHandler .MouseLeave, AddressOf frmMovieDetails.searchItem_MouseLeave
                    End With
                    frmMovieDetails.InfoPanel1.Controls.Add(aDirector)
                    frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aDirector, frmMovieDetails.InfoPanel1.Controls.IndexOf(frmMovieDetails.lblSubDirectors) + 1)
                    frmMovieDetails.dynControls.Add(aDirector)
                    If countDirector = 1 Then
                        frmMovieDetails.InfoPanel1.SetFlowBreak(aDirector, True)
                    End If
                Next

                frmMovieDetails.infoCast.Visible = False
                frmMovieDetails.infoCast.Text = InfoStars.Text
                Dim castInText() As String = Split(InfoStars.Text, ", ")
                For Each cast As String In castInText
                    Dim aCast As New Label
                    With aCast
                        .AutoSize = True
                        .Font = Movieo.CreateFont("Segoe UI", 12.5, False, False, False)
                        .ForeColor = Color.FromArgb(150, 159, 170)
                        .Margin = New Padding(0, 7, 0, 0)
                        .Text = cast
                        .BackColor = Color.Transparent
                        .Cursor = Cursors.Hand
                        .Name = cast
                        .Show()
                        AddHandler .Click, AddressOf frmMovieDetails.searchItem_Click
                        AddHandler .MouseMove, AddressOf frmMovieDetails.searchItem_MouseMove
                        AddHandler .MouseLeave, AddressOf frmMovieDetails.searchItem_MouseLeave
                    End With
                    frmMovieDetails.InfoPanel1.Controls.Add(aCast)
                    frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aCast, frmMovieDetails.InfoPanel1.Controls.IndexOf(frmMovieDetails.lblSubCast) + 1)
                    frmMovieDetails.dynControls.Add(aCast)
                Next

                frmMovieDetails.infoGenre.Visible = False
                frmMovieDetails.infoGenre.Text = InfoGenre.Text
                Dim countGenres As Integer = 0
                Dim genresInText() As String = Split(InfoGenre.Text, ", ")
                For Each genre As String In genresInText
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
                        AddHandler .MouseMove, AddressOf frmMovieDetails.genreItem_MouseMove
                        AddHandler .MouseLeave, AddressOf frmMovieDetails.genreItem_MouseLeave
                    End With
                    frmMovieDetails.InfoPanel1.Controls.Add(aGenre)
                    frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aGenre, 3)
                    frmMovieDetails.dynControls.Add(aGenre)
                Next
            Catch
            End Try

            Try
                frmMovieDetails.imgPoster.BackgroundImage = New Bitmap(New MemoryStream(WebClient.DownloadData(InfoPosterLink.Text)))
                frmMovieDetails.imgPoster.BackgroundImage = ChangeOpacity(frmMovieDetails.imgPoster.BackgroundImage, 0.8)
            Catch
            End Try

            Try
                Dim popcorntimeAPI = WebClient.DownloadString("https://tv-v2.api-fetch.website/movie/" + InfoImdbId.Text)
                Dim jsonPTAPI As JObject = JObject.Parse(popcorntimeAPI)

                'Details from Popcorn Time API for Background (fanart)
                Dim backgroundLink As String = jsonPTAPI.SelectToken("images").SelectToken("fanart")
                Dim trailerLink As String = jsonPTAPI.SelectToken("trailer")

                frmBackgroundMovieDetails.BackgroundImage = New Bitmap(New MemoryStream(WebClient.DownloadData(backgroundLink)))
                frmMovieDetails.infoBackgroundImageLink.Text = backgroundLink
                frmMovieDetails.Opacity = 0.85

                'Details from Popcorn Time API for Trailer Link (YouTube)
                frmMovieDetails.infoTrailerLink.Text = trailerLink
                frmBackgroundMovieDetails.Opacity = 100
            Catch ex As Exception
                frmBackgroundMovieDetails.Opacity = 0
                frmMovieDetails.infoTrailerLink.Text = ""
                frmMovieDetails.infoBackgroundImageLink.Text = ""
                frmMovieDetails.Opacity = 0.98
            End Try

            frmMovieDetails.Show(frmBackgroundMovieDetails)
            frmBackgroundMovieDetails.Show(Movieo)
        Catch ex As Exception
            'False Positive (Ignore exception)
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
        InfoImdbRatingPoster.BackColor = Color.Transparent
        InfoImdbRatingPoster.ShowFocus = CButtonLib.CButton.eFocus.None
        InfoImdbRatingPoster.BringToFront()
        InfoImdbRatingPoster.Location = New Point(64, 8)
        InfoImdbRatingPoster.Visible = False

        BackColor = Movieo.panelMovies.BackColor
    End Sub

    Dim ignoreControls As ICollection(Of String) = {Movieo.panelLibraryBlackList.Name, Movieo.panelLibrarySeenList.Name, Movieo.panelLibraryWatchList.Name, Movieo.panelLibraryFavourites.Name, Movieo.panelDownloads.Name, Movieo.panelMyListsMovies.Name}

    Private Sub ctrlPosterTitle_Validated(sender As Object, e As EventArgs) Handles Me.Validated
        Dim WebClient = New WebClient()

        If Not ignoreControls.Contains(Parent.Name) Then
            If Movieo.listSeenList.Contains(InfoTitleAndYear.Text) Then
                If My.Settings.doWatchedMovies = 0 Then
                    InfoPoster.BackgroundImage = ChangeOpacity(InfoPoster.BackgroundImage, 0.3)
                    Show()
                ElseIf My.Settings.doWatchedMovies = 1 Then
                    Hide()
                ElseIf My.Settings.doWatchedMovies = 2 Then
                    InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(WebClient.DownloadData(InfoPosterLink.Text)))
                    Show()
                End If
            ElseIf Movieo.listBlackList.Contains(InfoTitleAndYear.Text) Then
                Hide()
            Else
                InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(WebClient.DownloadData(InfoPosterLink.Text)))
                Show()
            End If
        End If
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

#End Region

End Class