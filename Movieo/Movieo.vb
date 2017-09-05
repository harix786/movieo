Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports Newtonsoft.Json.Linq

Public Class Movieo

#Region "Preferences (some can be changed)"

    Public devMode As Boolean = True
    'Public linkMovieDatabase As String = "https://dl.dropbox.com/s/7rhzy2odzkal6tx/movieo-db.txt?dl=0"
    Public linkMovieDatabase As String = "https://dl.dropbox.com/s/7fb0qd74u1h5ddw/movieo-dbTESTING.txt?dl=0" 'FOR TESTING
    Public linkChangelog As String = "https://dl.dropbox.com/s/3514qygmbok1rvv/movieo-changelog.txt?dl=0"
    Public linkNotifications As String = "https://dl.dropbox.com/s/eqxi751t8z031na/movieo-notifications.txt?dl=0"
    Public linkMovieComments As String = "https://dl.dropbox.com/s/swbt9fkbknmoqzz/movieo-comments.txt?dl=0"
    Public linkNewReleases As String = "https://dl.dropbox.com/s/lqxnvez68fxvmx7/movieo-new-releases.txt?dl=0"
    Public linkTrending As String = "https://dl.dropbox.com/s/pmx8vcegi4hhbze/movieo-trending.txt?dl=0"
    Public linkTopRated As String = "https://dl.dropbox.com/s/31yg8647ql86ey8/movieo-top-rated.txt?dl=0"
    Public linkCollections As String = "https://dl.dropbox.com/s/bz42scp93c5we7r/movieo-collections.txt?dl=0"
    Public linkLiveCinema As String = "https://dl.dropbox.com/s/n6fay620ubjsv5i/movieo-schedule.txt?dl=0"
    Public linkLatestVersion As String = "https://dl.dropbox.com/s/n0lwh73gh15vpf5/movieo-version.txt?dl=0"
    Public linkUpdater As String = "https://dl.dropbox.com/s/aqouj2qgn7galjd/Movieo%20Updater.exe?dl=0"
    Public pathBackupDatabase As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Movieo.db"
    Public pathFavouritesList As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\favourites.txt"
    Public pathWatchList As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\watch list.txt"
    Public pathSeenList As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\seen list.txt"
    Public pathBlackList As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\black list.txt"
    Public pathDownloads As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Downloads\"
    Public pathUpdater As String = Application.StartupPath + "\Movieo Updater.exe"
    Public infoVersionText As String = "Beta Build v" + Application.ProductVersion
    Public ctrlSearchBoxWatermark As String = "Search movies, people, years..."
    Public msgBackupDatabaseError As String = "Movieo has bumped into an issue loading movies from our database. Information on your issue has been sent to us, we promise we'll be back up soon :)"
    Public msgNoInternetConnection As String = "Movieo is unable to access the internet to reach our server. Please check your internet connection and try again. If you have anymore issues then please email us at hi@movieo.info"
    Public SearchingTexts As ICollection(Of String) = {"Have a great day!",
        "Thank you for using Movieo." + vbNewLine + "We hope you enjoy!",
        "If nobody comes back from the future to" + vbNewLine + "stop you, then how bad of a decision" + vbNewLine + "can it really be?",
        "Pixelating the pixels.",
        "It's just you, me, and the loading screen.",
        "Doing the impossible.",
        "Each day will be better than the last." + vbNewLine + "This one especially.",
        "Sometimes you eat the bear and" + vbNewLine + "sometimes the bear, well, he eats you.",
        "Don't think of purple hippos",
        "The mystery of life isn't a problem to" + vbNewLine + "solve, but a reality of experience.",
        "Remember to get up && stretch" + vbNewLine + "once in a while.",
        "Teaching snakes to kick."}

    Dim UseBackupDatabase As Boolean = False
    Dim saveListsOnClose As Boolean = True
    Dim intMaxPosters = 40

#End Region

#Region "Movieo"

    Private Sub Movieo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show startup loading page
        frmStartupTab.txtLoading.Text = "Loading, please wait..."
        frmStartupTab.Size = New Size(ClientSize.Width, ClientSize.Height)
        frmStartupTab.Show(Me)
        frmStartupTab.Location = New Point(ClientRectangle.Location.X, ClientRectangle.Location.Y + 23)
        If My.Settings.doOnTop = True Then
            TopMost = True
        End If
        Tab.SelectedTab = tabLoading 'Show loading page
        txtboxSearch.WaterMark = ctrlSearchBoxWatermark  'Set search bar watermark text
        frmInfo.lblAboutVersion.Text = infoVersionText  'Set current version in ABOUT page
        If CheckForInternetConnection() = True Then 'Proceed to internet required functions
            UseBackupDatabase = False 'So the database function uses the latest (from the server
            LoadLists() 'Load movies into users lists (ListBox)
            Enabled = False
            If My.Settings.doAutoUpdate = True Then
                timerGetUpdate.Enabled = True
            End If
            If My.Settings.doBackupDb = True Then
                SaveBackupDatabase()
            End If
            timerStartup.Enabled = True
        Else
            'Show error form on movies tab - if no backup database file stored
            saveListsOnClose = False
            tabDiscover.Controls.Remove(panelMovies)
            tabDiscover.Controls.Remove(panelGenresCtrls)
            Dim a As New frmErrorTab
            a.TopLevel = False
            a.Show()
            tabDiscover.Controls.Add(a)
            a.Dock = DockStyle.Fill
            a.BringToFront()
            Tab.SelectedTab = tabDiscover
            Enabled = True
            txtboxSearch.Enabled = False
            txtboxSearchBG.Enabled = False
            imgSearchIcon.Enabled = False
            titleCoreLibrary.Enabled = False
            frmStartupTab.Close()
            ShowPopupOk("No internet connection",
            msgNoInternetConnection, Me)
        End If
    End Sub

    'Save users list on application exit
    Private Sub Movieo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If saveListsOnClose = True Then
            SaveLists()
        End If
    End Sub

    Public Sub SaveBackupDatabase() 'Download and save a backup of the current database
        Try
            NetDl.DownloadFile(linkMovieDatabase, pathBackupDatabase)
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean 'Returns the status of internet connection (must be able to access dropbox)
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("https://www.dropbox.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Show Popups / Open folder"

    Public Sub ShowPopupOk(Title As String, Message As String, owns As Form)
        Try
            frmPopupBg.Show(owns)
            frmPopupOk.DialogTitle.Text = Title
            frmPopupOk.DialogMessage.Text = Message
            frmPopupOk.Show(frmPopupBg)
        Catch ex As Exception
        End Try
    End Sub

    Public Function ShowPopupYesNo(Title As String, Message As String, owns As Form) As DialogResult
        Try
            frmPopupBg.Show(owns)
            frmPopupYesNo.DialogTitle.Text = Title
            frmPopupYesNo.DialogMessage.Text = Message
            frmPopupYesNo.Show(frmPopupBg)
            Return frmPopupYesNo.DialogResult
        Catch ex As Exception
            Return DialogResult.No
        End Try
    End Function

    Public Sub ShowFile(file As String)
        Dim args As String = String.Format("/Select, ""{0}""", file)
        Dim pfi As New ProcessStartInfo("Explorer.exe", args)
        Process.Start(pfi)
    End Sub

#End Region

#Region "Create/Save/Load/Reset Lists"

    Private Sub LoadLists()
        Try
            Dim WebDl As New WebClient()

            'Trending Movies
            Dim contentTrending As String = WebDl.DownloadString(linkTrending)
            Dim splitTrending() As String = Split(contentTrending, vbNewLine)

            For Each itemTrending As String In splitTrending
                If Not itemTrending = "" Then
                    itemsMoviesTrending.Items.Add(itemTrending)
                End If
            Next

            'New Releases Movies
            Dim contentNewReleases As String = WebDl.DownloadString(linkNewReleases)
            Dim splitNewReleases() As String = Split(contentNewReleases, vbNewLine)

            For Each itemNewReleases As String In splitNewReleases
                If Not itemNewReleases = "" Then
                    itemsMoviesNewlyReleased.Items.Add(itemNewReleases)
                End If
            Next

            'Top Rated
            Dim contentTopRated As String = WebDl.DownloadString(linkTopRated)
            Dim splitTopRated() As String = Split(contentTopRated, vbNewLine)

            For Each itemTopRated As String In splitTopRated
                If Not itemTopRated = "" Then
                    itemsMoviesTopRated.Items.Add(itemTopRated)
                End If
            Next

            'Collections
            Dim contentCollections As String = WebDl.DownloadString(linkCollections)
            Dim splitCollections() As String = Split(contentCollections, vbNewLine)

            For Each itemCollection As String In splitCollections
                If Not itemCollection = "" Then
                    Dim itemsCollection As String() = Split(itemCollection, "|")

                    Dim a As New ctrlCollectionsThumbnail
                    a.TopLevel = False
                    a.lblCollectionsTitle.Text = itemsCollection(0)
                    a.lblCollectionsComment.Text = itemsCollection(1)
                    a.imgCollectionsThumbnail.BackgroundImage = New Bitmap(New MemoryStream(WebDl.DownloadData(itemsCollection(2))))
                    a.imgCollectionsThumbnail.BackgroundImage = ctrlPosterTitle.ChangeOpacity(a.imgCollectionsThumbnail.BackgroundImage, 0.7)

                    Dim movieInCollections As String() = Split(itemsCollection(3), "*")
                    For Each movie As String In movieInCollections
                        a.itemsCollectionsMovies.Items.Add(movie)
                    Next
                    a.Visible = True
                    a.Show()

                    panelCollectionsItems.Controls.Add(a)
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            'User Lists
            Dim decFavourites() As String = File.ReadAllLines(pathFavouritesList)
            itemsFavouritesList.Items.AddRange(decFavourites)

            Dim decWatchList() As String = File.ReadAllLines(pathWatchList)
            itemsWatchList.Items.AddRange(decWatchList)

            Dim decSeenList() As String = File.ReadAllLines(pathSeenList)
            itemsSeenList.Items.AddRange(decSeenList)

            Dim decBlackListed() As String = File.ReadAllLines(pathBlackList)
            itemsBlackList.Items.AddRange(decBlackListed)

            Dim NotifItem As String = My.Settings.NotifNumbers
            If NotifItem <> "" Then
                itemsNotificationList.Items.Clear()
                itemsNotificationList.Items.AddRange(NotifItem.Split("|"))
            End If

            Dim RecentlyWatchedItem As String = My.Settings.listLastWatched
            If RecentlyWatchedItem <> "" Then
                itemsRecentlyWatched.Items.Clear()
                itemsRecentlyWatched.Items.AddRange(RecentlyWatchedItem.Split(","))
            End If

            ListFiles(pathDownloads)
        Catch ex As Exception
            CreateEmptyListFiles()
        End Try
    End Sub

    Private Sub ListFiles(ByVal folderPath As String)
        itemsDownloads.Items.Clear()

        Dim exts As String() = {"*.mp4", "*.avi", "*.mkv"}
        Dim fileNames = My.Computer.FileSystem.GetFiles(folderPath, FileIO.SearchOption.SearchTopLevelOnly, exts)

        For Each fileName As String In fileNames
            Dim cutFileName As String = fileName.Replace(pathDownloads, "")
            itemsDownloads.Items.Add(cutFileName.Substring(0, cutFileName.Length - 4))
        Next
    End Sub

    Private Sub SaveLists()
        Try
            'Favourite Movies
            Dim BuildLists1 As New Text.StringBuilder()
            For Each MovieItem As String In itemsFavouritesList.Items
                BuildLists1.AppendLine(MovieItem)
            Next
            File.WriteAllText(pathFavouritesList, BuildLists1.ToString())

            'Watch List Movies
            Dim BuildLists2 As New Text.StringBuilder()
            For Each MovieItem As String In itemsWatchList.Items
                BuildLists2.AppendLine(MovieItem)
            Next
            File.WriteAllText(pathWatchList, BuildLists2.ToString())

            'Seen List Movies
            Dim BuildLists3 As New Text.StringBuilder()
            For Each MovieItem As String In itemsSeenList.Items
                BuildLists3.AppendLine(MovieItem)
            Next
            File.WriteAllText(pathSeenList, BuildLists3.ToString())

            'Black List Movies
            Dim BuildLists4 As New Text.StringBuilder()
            For Each MovieItem As String In itemsBlackList.Items
                BuildLists4.AppendLine(MovieItem)
            Next
            File.WriteAllText(pathBlackList, BuildLists4.ToString())

            'Notifications
            Dim NotifItem As New List(Of String)
            For Each NotifNumber As String In itemsNotificationList.Items
                NotifItem.Add(NotifNumber)
            Next
            My.Settings.NotifNumbers = String.Join("|", NotifItem.ToArray)

            'Recently Watched
            Dim itemRecentlyWatched As New List(Of String)
            For Each itemRecentlyWatchedInt As String In itemsRecentlyWatched.Items
                itemRecentlyWatched.Add(itemRecentlyWatchedInt)
            Next
            My.Settings.listLastWatched = String.Join(",", itemRecentlyWatched.ToArray)

            My.Settings.Save()
        Catch ex As Exception
            ShowPopupOk("Issue saving your lists", ex.Message, Me)
        End Try
    End Sub

    Public Sub CreateEmptyListFiles()
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\")
        My.Computer.FileSystem.CreateDirectory(pathDownloads)
    End Sub

#End Region

#Region "Startup Timer / Grab Movies"

    Private Sub StartupTimer_Tick(sender As Object, e As EventArgs) Handles timerStartup.Tick
        If UseBackupDatabase = False Then
            GrabMovies(linkMovieDatabase)
        Else
            GrabMovies(pathBackupDatabase)
        End If

        Enabled = True

        'If My.Settings.doFilters = True Then
        'filterGenreBox.SelectedIndex = My.Settings.doFilterNum
        'End If

        frmStartupTab.Hide()
        Tab.SelectedTab = tabDiscover
        timerStartup.Enabled = False
    End Sub

    'Get if movie is not found in omdbapi
    Dim ErrorMovie As String = ""

    'Count movies
    Dim MovieItem As Integer

    'Get movies, display in movies and both lists
    Public NetDl = New WebClient()

    Public storeControlsAllMovies As New List(Of Control)
    Public storeControlsFavourites As New List(Of Control)
    Public storeControlsWatchList As New List(Of Control)
    Public storeControlsSeenList As New List(Of Control)
    Public storeControlsBlackList As New List(Of Control)

    Public Sub GrabMovies(Content As String)
        MovieItem = 0
        ContentToFilter1.Items.Clear()
        ContentToFilter2.Items.Clear()
        ContentToFilter3.Items.Clear()
        ContentToFilter4.Items.Clear()

        Tab.SelectedTab = tabLoading

        'Remove movies from  
        panelLibraryBlackList.Controls.Clear()
        panelLibrarySeenList.Controls.Clear()
        panelLibraryWatchList.Controls.Clear()
        panelLibraryFavourites.Controls.Clear()

        'Split data
        Dim DataSplitter As String = "~"

        Dim WebDl = New WebClient()
        WebDl.Proxy = Nothing

        Dim MoviesContent As String = WebDl.DownloadString(Content)
        Dim MoviesByLine() As String = Split(MoviesContent, vbNewLine)

        For Each MovieOnLine As String In MoviesByLine.Reverse
            If Not MovieOnLine = "" Then
                MovieItem = MovieItem + 1

                Dim MovieCred As String() = Split(MovieOnLine, DataSplitter)

                Dim a As New ctrlPosterTitle
                a.TopLevel = False
                a.Hide()

                Dim TitleAndYear As String = MovieCred(0) + " (" + MovieCred(1) + ")"

                ErrorMovie = TitleAndYear

                a.InfoTitle.Text = MovieCred(0)
                a.InfoYear.Text = MovieCred(1)
                a.InfoTitleAndYear.Text = TitleAndYear

                On Error Resume Next

                Dim dstring = WebDl.DownloadString("http://www.omdbapi.com/?apikey=c933e052&t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text + "&tomatoes=true")
                Dim json As JObject = JObject.Parse(dstring)

                'Necessary Details from OMDb API
                a.InfoGenre.Text = json.SelectToken("Genre")
                a.InfoDirector.Text = json.SelectToken("Director")
                a.InfoStars.Text = json.SelectToken("Actors")
                a.InfoPosterLink.Text = json.SelectToken("Poster")
                a.InfoCountry.Text = json.SelectToken("Country")
                a.InfoLanguage.Text = json.SelectToken("Language")
                a.InfoDesc.Text = json.SelectToken("Plot")

                'Ratings
                a.InfoImdbId.Text = json.SelectToken("imdbID")
                a.infoRatingIMDb.Text = json.SelectToken("imdbRating")
                a.InfoImdbRatingPoster.Text = "IMDb " + a.infoRatingIMDb.Text

                'Poster
                a.InfoPosterLink.Text = json.SelectToken("Poster")
                a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(WebDl.DownloadData(a.InfoPosterLink.Text)))

                'Movie Link
                a.InfoMovieLink.Text = MovieCred(2)
                a.InfoMovieQuality.Text = ctrlPosterTitle.ReturnQuality(MovieCred(2))
                If My.Settings.doQualityOnPoster = True Then a.InfoMovieQuality.Visible = True

                'Searches
                a.InfoSearches.Text = MovieCred(0) + " " + MovieCred(1) + " " + a.InfoGenre.Text + " " + a.InfoDirector.Text + " " + a.InfoStars.Text + " " + a.InfoImdbId.Text + " " + a.InfoCountry.Text


                ContentToFilter4.Items.Add(MovieCred(0) + "~" + MovieCred(1) + "~" + MovieCred(2))
                ContentToFilter3.Items.Add(a.infoRatingIMDb.Text + "~" + MovieCred(0) + "~" + MovieCred(1) + "~" + MovieCred(2))
                ContentToFilter2.Items.Add(MovieCred(0) + "~" + MovieCred(1) + "~" + MovieCred(2))
                ContentToFilter1.Items.Add(MovieCred(1) + "~" + MovieCred(0) + "~" + MovieCred(2))

                a.Name = a.InfoImdbId.Text
                a.Show()

                If MovieItem <= intMaxPosters Then
                    If Not itemsBlackList.Items.Contains(TitleAndYear) Then
                        If itemsSeenList.Items.Contains(TitleAndYear) Then
                            If My.Settings.doWatchedMovies = 0 Then
                                a.InfoPoster.BackgroundImage = a.ChangeOpacity(a.InfoPoster.BackgroundImage, 0.3)
                                panelMovies.Controls.Add(a)
                            ElseIf My.Settings.doWatchedMovies = 1 Then
                                'Do nothing
                            ElseIf My.Settings.doWatchedMovies = 2 Then
                                panelMovies.Controls.Add(a)
                            End If
                        Else
                            panelMovies.Controls.Add(a)
                        End If
                    End If
                Else
                    storeControlsScroll.Add(a)
                End If

                If Not itemsBlackList.Items.Contains(TitleAndYear) Then
                    If itemsSeenList.Items.Contains(TitleAndYear) Then
                        If My.Settings.doWatchedMovies = 0 Then
                            a.InfoPoster.BackgroundImage = a.ChangeOpacity(a.InfoPoster.BackgroundImage, 0.1)
                            storeControlsAllMovies.Add(a)
                        ElseIf My.Settings.doWatchedMovies = 1 Then
                            'Do nothing
                        ElseIf My.Settings.doWatchedMovies = 2 Then
                            storeControlsAllMovies.Add(a)
                        End If
                    Else
                        storeControlsAllMovies.Add(a)
                    End If
                End If

                If itemsFavouritesList.Items.Contains(TitleAndYear) Then
                    storeControlsFavourites.Add(a)
                    AddMovieOnStartup(panelLibraryFavourites, False, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoReleaseDate.Text, a.InfoCountry.Text, a.InfoLanguage.Text, a.InfoProduction.Text, a.InfoBoxOffice.Text, a.InfoAwards.Text, a.InfoImdbId.Text, a.infoRatingIMDb.Text, a.infoRatingNetflix.Text, a.infoRatingMetaScore.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                End If

                If itemsWatchList.Items.Contains(TitleAndYear) Then
                    storeControlsWatchList.Add(a)
                    AddMovieOnStartup(panelLibraryWatchList, False, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoReleaseDate.Text, a.InfoCountry.Text, a.InfoLanguage.Text, a.InfoProduction.Text, a.InfoBoxOffice.Text, a.InfoAwards.Text, a.InfoImdbId.Text, a.infoRatingIMDb.Text, a.infoRatingNetflix.Text, a.infoRatingMetaScore.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                End If

                If itemsSeenList.Items.Contains(TitleAndYear) Then
                    storeControlsSeenList.Add(a)
                    AddMovieOnStartup(panelLibrarySeenList, False, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoReleaseDate.Text, a.InfoCountry.Text, a.InfoLanguage.Text, a.InfoProduction.Text, a.InfoBoxOffice.Text, a.InfoAwards.Text, a.InfoImdbId.Text, a.infoRatingIMDb.Text, a.infoRatingNetflix.Text, a.infoRatingMetaScore.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                End If

                If itemsBlackList.Items.Contains(TitleAndYear) Then
                    storeControlsBlackList.Add(a)
                    AddMovieOnStartup(panelLibraryBlackList, False, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoReleaseDate.Text, a.InfoCountry.Text, a.InfoLanguage.Text, a.InfoProduction.Text, a.InfoBoxOffice.Text, a.InfoAwards.Text, a.InfoImdbId.Text, a.infoRatingIMDb.Text, a.infoRatingNetflix.Text, a.infoRatingMetaScore.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                End If

                If itemsDownloads.Items.Contains(TitleAndYear) Then
                    If itemsSeenList.Items.Contains(TitleAndYear) Then
                        If My.Settings.doWatchedMovies = 0 Then
                            AddMovieOnStartup(panelDownloads, True, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoReleaseDate.Text, a.InfoCountry.Text, a.InfoLanguage.Text, a.InfoProduction.Text, a.InfoBoxOffice.Text, a.InfoAwards.Text, a.InfoImdbId.Text, a.infoRatingIMDb.Text, a.infoRatingNetflix.Text, a.infoRatingMetaScore.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                        ElseIf My.Settings.doWatchedMovies = 1 Then
                            'Do nothing
                        ElseIf My.Settings.doWatchedMovies = 2 Then
                            AddMovieOnStartup(panelDownloads, False, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoReleaseDate.Text, a.InfoCountry.Text, a.InfoLanguage.Text, a.InfoProduction.Text, a.InfoBoxOffice.Text, a.InfoAwards.Text, a.InfoImdbId.Text, a.infoRatingIMDb.Text, a.infoRatingNetflix.Text, a.infoRatingMetaScore.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                        Else
                            AddMovieOnStartup(panelDownloads, False, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoReleaseDate.Text, a.InfoCountry.Text, a.InfoLanguage.Text, a.InfoProduction.Text, a.InfoBoxOffice.Text, a.InfoAwards.Text, a.InfoImdbId.Text, a.infoRatingIMDb.Text, a.infoRatingNetflix.Text, a.infoRatingMetaScore.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                        End If
                    Else
                        AddMovieOnStartup(panelDownloads, False, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoReleaseDate.Text, a.InfoCountry.Text, a.InfoLanguage.Text, a.InfoProduction.Text, a.InfoBoxOffice.Text, a.InfoAwards.Text, a.InfoImdbId.Text, a.infoRatingIMDb.Text, a.infoRatingNetflix.Text, a.infoRatingMetaScore.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                    End If
                End If

                If MovieItem Mod 30 = 0 Then 'Change to a random loading text every x movies, this case it's 30
                    frmStartupTab.txtLoading.Text = RandomText(SearchingTexts)
                    Threading.Thread.Sleep(3500)
                End If

            End If
        Next

        richtxtMovieDb.Text = MoviesContent
    End Sub

#End Region

#Region "Main - Tabs"

    Private Sub Movieo_KeyDown(sender As Object, e As KeyEventArgs) Handles Tab.KeyDown
        e.Handled = True
    End Sub

    Private Sub titleMyListsBrowse_Click(sender As Object, e As EventArgs) Handles titleCoreDiscover.ClickButtonArea
        Tab.SelectedTab = tabDiscover
    End Sub

    Private Sub titleMyLists_ClickButtonArea(sender As Object, e As EventArgs) Handles titleCoreLibrary.ClickButtonArea
        Tab.SelectedTab = tabLibrary
    End Sub

    Private Sub titleCoreCollections_ClickButtonArea(sender As Object, e As EventArgs) Handles titleCoreCollections.ClickButtonArea
        Tab.SelectedTab = tabCollections
    End Sub

    Private Sub titleCoreDownloads_ClickButtonArea(sender As Object, e As EventArgs) Handles titleCoreDownloads.ClickButtonArea
        Tab.SelectedTab = tabDownloads
    End Sub

    'Tab Title Effects
    Private Sub titleMovies_MouseMove(sender As Object, e As MouseEventArgs) Handles titleCoreDiscover.MouseMove, titleCoreLibrary.MouseMove, titleCoreCollections.MouseMove, titleCoreDownloads.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub titleMovies_MouseLeave(sender As Object, e As EventArgs) Handles titleCoreDiscover.MouseLeave, titleCoreLibrary.MouseLeave, titleCoreCollections.MouseLeave, titleCoreDownloads.MouseLeave
        If Not Tab.SelectedTab.Name.Replace("tab", "").ToLower.Contains(sender.Text.ToString.Replace(" ", "").ToLower) Then
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

    'Selected Tabs
    Dim SearchboxIsActive As Boolean = False
    Dim GoToNextTab As Integer = 0

    Private Sub appTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            titleCoreDiscover.ForeColor = Color.White
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxInactive()
            btnGenre_Click(btnGenreAllMovies, e)
        ElseIf Tab.SelectedIndex = 1 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.White
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxInactive()
        ElseIf Tab.SelectedIndex = 2 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.White
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxInactive()
        ElseIf Tab.SelectedIndex = 3 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.White
            SearchboxInactive()
        ElseIf Tab.SelectedIndex = 4 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxActive()
        ElseIf Tab.SelectedIndex = 5 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxInactive()
        ElseIf Tab.SelectedIndex = 6 Then
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            lblSearchingText.Text = RandomText(SearchingTexts)
            SearchboxActive()
        End If
    End Sub

    'Generate a random loading screen text
    Public Function RandomText(ByVal Items As ICollection(Of String)) As String
        Dim Rndm As New Random()
        Dim StringList As New List(Of String)(Items)
        Return StringList(Rndm.Next(0, Items.Count))
    End Function

    Public storeControlsScroll As New List(Of Control)

    Private Sub PanelMovies_Scroll(sender As Object, e As ScrollEventArgs) Handles panelMovies.Scroll
        Try
            Dim vs As VScrollProperties = panelMovies.VerticalScroll
            If e.NewValue = (vs.Maximum - vs.LargeChange) + 1 Then
                If storeControlsScroll.Count >= 30 Then
                    For Each ctrlMovie In storeControlsScroll.Take(30)
                        panelMovies.Controls.Add(ctrlMovie)
                    Next
                    storeControlsScroll.RemoveRange(0, 30)
                Else
                    For Each ctrlMovie In storeControlsScroll
                        panelMovies.Controls.Add(ctrlMovie)
                    Next
                    storeControlsScroll.Clear()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        panelMovies.Update()
    End Sub

    Private Sub panelMyListsFavourites_Scroll(sender As Object, e As ScrollEventArgs) Handles panelLibraryFavourites.Scroll
        panelLibraryFavourites.Update()
    End Sub

    Private Sub panelMyListsWatchList_Scroll(sender As Object, e As ScrollEventArgs) Handles panelLibraryWatchList.Scroll
        panelLibraryWatchList.Update()
    End Sub

    Private Sub panelMyListsSeenList_Scroll(sender As Object, e As ScrollEventArgs) Handles panelLibrarySeenList.Scroll
        panelLibrarySeenList.Update()
    End Sub

    Private Sub panelMyListsBlackList_Scroll(sender As Object, e As ScrollEventArgs) Handles panelLibraryBlackList.Scroll
        panelLibraryBlackList.Update()
    End Sub

    Private Sub panelSearches_Scroll(sender As Object, e As ScrollEventArgs) Handles panelSearches.Scroll
        panelSearches.Update()
    End Sub

#End Region

#Region "Library - Tabs"

    Private Sub tabsMyLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabsLibrary.SelectedIndexChanged
        For Each a As Control In panelLibraryCtrls.Controls
            If a.Text = selectedList Then
                a.BackColor = Color.FromArgb(43, 50, 61)
                a.ForeColor = Color.White
            Else
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            End If
        Next
    End Sub

    'Go to selected tab
    Private Sub titleMyListsFavourites_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnListsFavourites.ClickButtonArea
        selectedList = Sender.text
        tabsLibrary.SelectedTab = tabLibraryFavourites
    End Sub

    Private Sub titleMyListsWatchList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnListWatch.ClickButtonArea
        selectedList = Sender.text
        tabsLibrary.SelectedTab = tabLibraryWatchList
    End Sub

    Private Sub titleMyListsSeenList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnListsSeen.ClickButtonArea
        selectedList = Sender.text
        tabsLibrary.SelectedTab = tabLibrarySeenList
    End Sub

    Private Sub titleMyListsBlackList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnListsBlack.ClickButtonArea
        selectedList = Sender.text
        tabsLibrary.SelectedTab = tabLibraryBlackList
    End Sub

    'Tab Title Effects
    Public selectedList As String = "Favourites"

    Private Sub btnLists_MouseMove(sender As Object, e As MouseEventArgs) Handles btnListsFavourites.MouseMove, btnListWatch.MouseMove, btnListsSeen.MouseMove, btnListsBlack.MouseMove
        sender.BackColor = Color.FromArgb(43, 50, 61)
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnLists_MouseLeave(sender As Object, e As EventArgs) Handles btnListsFavourites.MouseLeave, btnListWatch.MouseLeave, btnListsSeen.MouseLeave, btnListsBlack.MouseLeave
        If Not selectedList = sender.Text Then
            sender.BackColor = Color.FromArgb(24, 32, 45)
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

#End Region

#Region "Add/Remove Movies from Panel"

    Public Sub AddMovieOnStartup(AddToPanel As FlowLayoutPanel, isWatched As Boolean, Title As String, Year As String, Genre As String, Director As String, Stars As String, Description As String, Duration As String, Rating As String, ReleaseDate As String, Country As String, Language As String, Production As String, BoxOffice As String, Awards As String, ImdbId As String, ImdbRating As String, ratingNetflix As String, MetaCritic As String, PosterLink As String, MovieLink As String)
        Dim NetDl As New WebClient
        NetDl.Proxy = Nothing
        Dim tab As New ctrlPosterTitle
        tab.Hide()
        tab.TopLevel = False
        tab.InfoTitle.Text = Title
        tab.InfoYear.Text = Year
        tab.InfoGenre.Text = Genre
        tab.InfoDesc.Text = Description
        tab.InfoDuration.Text = Duration
        tab.InfoDirector.Text = Director
        tab.InfoStars.Text = Stars

        tab.infoRatingIMDb.Text = ImdbRating
        tab.infoRatingMetaScore.Text = MetaCritic

        tab.InfoReleaseDate.Text = ReleaseDate
        tab.InfoRating.Text = Rating
        tab.InfoCountry.Text = Country
        tab.InfoLanguage.Text = Language
        tab.InfoProduction.Text = Production
        tab.InfoBoxOffice.Text = BoxOffice
        tab.InfoAwards.Text = Awards
        tab.InfoImdbId.Text = ImdbId

        tab.InfoPosterLink.Text = PosterLink
        tab.InfoImdbRatingPoster.Text = "IMDb " + tab.infoRatingIMDb.Text
        If My.Settings.doRatingOnPoster = True Then
            tab.InfoImdbRatingPoster.Visible = True
        Else
            tab.InfoImdbRatingPoster.Visible = False
        End If
        tab.InfoMovieLink.Text = MovieLink
        tab.InfoSearches.Text = Title + " " + Year + " " + Genre + " " + Director + " " + Stars
        Try
            tab.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(NetDl.DownloadData(PosterLink)))
        Catch ex As Exception
            tab.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
        End Try

        If isWatched = True Then
            tab.InfoPoster.BackgroundImage = tab.ChangeOpacity(tab.InfoPoster.BackgroundImage, 0.1)
        End If

        tab.Show()
        tab.Name = ImdbId
        AddToPanel.Controls.Add(tab)
    End Sub

    'Add Movie to Lists
    Public Sub AddMovie(AddToPanel As FlowLayoutPanel, AddToList As ListBox, Title As String, Year As String, Genre As String, Director As String, Stars As String, Description As String, Duration As String, Rating As String, ReleaseDate As String, Country As String, Language As String, Production As String, BoxOffice As String, Awards As String, ImdbId As String, ImdbRating As String, ratingNetflix As String, MetaCritic As String, PosterLink As String, MovieLink As String)
        Dim NetDl As New WebClient
        NetDl.Proxy = Nothing
        Dim tab As New ctrlPosterTitle
        tab.Hide()
        tab.TopLevel = False
        tab.InfoTitle.Text = Title
        tab.InfoYear.Text = Year
        tab.InfoGenre.Text = Genre
        tab.InfoDesc.Text = Description
        tab.InfoDuration.Text = Duration
        tab.InfoDirector.Text = Director
        tab.InfoStars.Text = Stars

        tab.infoRatingIMDb.Text = ImdbRating
        tab.infoRatingMetaScore.Text = MetaCritic

        tab.InfoReleaseDate.Text = ReleaseDate
        tab.InfoRating.Text = Rating
        tab.InfoCountry.Text = Country
        tab.InfoLanguage.Text = Language
        tab.InfoProduction.Text = Production
        tab.InfoBoxOffice.Text = BoxOffice
        tab.InfoAwards.Text = Awards
        tab.InfoImdbId.Text = ImdbId

        tab.InfoPosterLink.Text = PosterLink
        tab.InfoImdbRatingPoster.Text = "IMDb " + tab.infoRatingIMDb.Text
        If My.Settings.doRatingOnPoster = True Then
            tab.InfoImdbRatingPoster.Visible = True
        Else
            tab.InfoImdbRatingPoster.Visible = False
        End If
        tab.InfoMovieLink.Text = MovieLink
        tab.InfoSearches.Text = Title + " " + Year + " " + Genre + " " + Director + " " + Stars
        Try
            tab.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(NetDl.DownloadData(PosterLink)))
        Catch ex As Exception
            tab.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
        End Try
        tab.Show()
        tab.Name = ImdbId
        AddToPanel.Controls.Add(tab)
        AddToList.Items.Add(Title + " (" + Year + ")")
    End Sub

    Public Sub RemoveMovie(RemoveFromPanel As FlowLayoutPanel, RemoveFromList As ListBox, Title As String, Year As String, ImdbId As String)
        For Each a As Control In RemoveFromPanel.Controls
            If a.Name = ImdbId Then
                RemoveFromPanel.Controls.Remove(a)
            End If
        Next

        RemoveFromList.Items.Remove(Title + " (" + Year + ")")
    End Sub

#End Region

#Region "Search Movies"

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tab.SelectedTab = tabLoading
            timerSearchMovies.Enabled = True
        End If
    End Sub

    Private Sub timerSearchMovies_Tick(sender As Object, e As EventArgs) Handles timerSearchMovies.Tick
        If txtboxSearch.Text = "" Then
            tabsSearches.SelectedTab = tabSearchesHome
            Tab.SelectedTab = tabSearches
        Else
            If ifURL(txtboxSearch.Text) = True Then
                frmMediaPlayer.Text = "Watching Title Unavailable"
                frmMediaPlayer.MediaPlayerControl.URL = txtboxSearch.Text
                frmMediaPlayer.Show(Me)
                txtboxSearch.Text = ""
            Else
                searchMovies()
                tabsSearches.SelectedTab = tabSearchesMovies
                Tab.SelectedTab = tabSearches
            End If
        End If
        timerSearchMovies.Enabled = False
    End Sub

    Public Shared Function ifURL(source As String) As Boolean
        Dim uriResult As Uri
        Return (Uri.TryCreate(source, UriKind.Absolute, uriResult) _
                    AndAlso (uriResult.Scheme = Uri.UriSchemeHttp))
    End Function

    Public Sub searchMovies()
        panelSearches.Controls.Clear()

        For Each a In storeControlsAllMovies
            For Each ab As Control In a.Controls
                If ab.Name = "InfoSearches" Then
                    If ab.Text.ToLower.Contains(txtboxSearch.Text.ToString.ToLower) Then
                        panelSearches.Controls.Add(a)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub TxtSearchBg_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles txtboxSearchBG.ClickButtonArea
        txtboxSearch.Focus()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If txtboxSearch.Text = "" Then
            tabsSearches.SelectedTab = tabSearchesHome
        End If
    End Sub

    Private Sub txtboxSearch_Enter(sender As Object, e As EventArgs) Handles txtboxSearch.Enter
        txtboxSearch.Text = ""
        panelSearches.Controls.Clear()
        tabsSearches.SelectedTab = tabSearchesHome
        Tab.SelectedTab = tabSearches
        SearchboxActive()
        txtboxSearch.Focus()
    End Sub

    Private Sub txtboxSearch_Leave(sender As Object, e As EventArgs) Handles txtboxSearch.Leave
        If Not Tab.SelectedIndex = 3 Or Not Tab.SelectedIndex = 2 Then
            SearchboxInactive()
        End If
    End Sub

    Private Sub panelSearches_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelSearches.ControlAdded
        imgPanelsEmptySearches.Visible = False
    End Sub

    'Search Box Active/Inactive
    Public Sub SearchboxInactive()
        txtboxSearch.BackColor = Color.FromArgb(59, 63, 77)
        txtboxSearchBG.BorderColor = Color.FromArgb(59, 63, 77)
        txtboxSearchBG.ColorFillSolid = Color.FromArgb(59, 63, 77)
        imgSearchIcon.BackColor = Color.FromArgb(59, 63, 77)
        imgSearchIcon.Image = My.Resources.SearchIconL
    End Sub

    Public Sub SearchboxActive()
        txtboxSearch.BackColor = Color.FromArgb(80, 85, 105)
        txtboxSearchBG.BorderColor = Color.FromArgb(80, 85, 105)
        txtboxSearchBG.ColorFillSolid = Color.FromArgb(80, 85, 105)
        imgSearchIcon.BackColor = Color.FromArgb(80, 85, 105)
        imgSearchIcon.Image = My.Resources.SearchIconH
    End Sub

#End Region

#Region "Info Context Menu"

    Public InfoSelectedTab As TabPage = frmInfo.tabAbout

    Public UpdateAvailable As Boolean = False
    Public IsContextOpen As Boolean = False

    Private Sub btnInfoMenu_Click(sender As Object, e As EventArgs) Handles btnInfoMenu.Click
        Dim a As New ctrlContextMenuInfo
        ctrlContextMenuInfo.Location = New Point(btnInfoMenu.Location.X - ctrlContextMenuInfo.Size.Width + btnInfoMenu.Size.Width + 5, btnInfoMenu.Location.Y + btnInfoMenu.Size.Height + 15)
        If UpdateAvailable = True Then
            ctrlContextMenuInfo.Size = New Size(a.Size.Width, a.Size.Height)
            ctrlContextMenuInfo.btnUpdateAvailable.Visible = True
        Else
            ctrlContextMenuInfo.Size = New Size(a.Size.Width, a.Size.Height - a.btnAboutMovieo.Size.Height)
            ctrlContextMenuInfo.btnUpdateAvailable.Visible = False
        End If
        btnInfoMenu.Image = My.Resources.DropletsIconBgH
        ctrlContextMenuInfo.Show()
        IsContextOpen = True
    End Sub

    Private Sub btnInfoMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles btnInfoMenu.MouseMove
        If IsContextOpen = True Then
            btnInfoMenu.Image = My.Resources.DropletsIconH
        Else
            btnInfoMenu.Image = My.Resources.DropletsIconH
        End If
    End Sub

    Private Sub btnInfoMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnInfoMenu.MouseLeave
        If IsContextOpen = True Then
            btnInfoMenu.Image = My.Resources.DropletsIconH
        Else
            btnInfoMenu.Image = My.Resources.DropletsIconL
        End If
    End Sub

#End Region

#Region "Show Empty Panel Message"

    Private Sub panelMyListsFavourites_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelLibraryFavourites.ControlAdded, panelLibraryFavourites.ControlRemoved
        If panelLibraryFavourites.Controls.Count = 0 Then
            imgPanelsEmptyFavourites.Visible = True
        Else
            imgPanelsEmptyFavourites.Visible = False
        End If
    End Sub

    Private Sub panelMyListsWatchList_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelLibraryWatchList.ControlAdded, panelLibraryWatchList.ControlRemoved
        If panelLibraryWatchList.Controls.Count = 0 Then
            imgPanelsEmptyWatchList.Visible = True
        Else
            imgPanelsEmptyWatchList.Visible = False
        End If
    End Sub

    Private Sub panelMyListsSeenList_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelLibrarySeenList.ControlAdded, panelLibrarySeenList.ControlRemoved
        If panelLibrarySeenList.Controls.Count = 0 Then
            imgPanelsEmptySeenList.Visible = True
        Else
            imgPanelsEmptySeenList.Visible = False
        End If
    End Sub

    Private Sub panelMyListsBlackList_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelLibraryBlackList.ControlAdded, panelLibraryBlackList.ControlRemoved
        If panelLibraryBlackList.Controls.Count = 0 Then
            imgPanelsEmptyBlackList.Visible = True
        Else
            imgPanelsEmptyBlackList.Visible = False
        End If
    End Sub

#End Region

#Region "Get Update Notification"

    Private Sub GetUpdateNotification_Tick(sender As Object, e As EventArgs) Handles timerGetUpdate.Tick
        Try
            Dim request As HttpWebRequest = WebRequest.Create(linkLatestVersion)
            Dim response As HttpWebResponse = request.GetResponse()
            Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
            Dim versionfile As String() = Split(sr.ReadToEnd, "|")
            Dim newestversion As String = versionfile(0)
            Dim currentversion As String = Application.ProductVersion

            If Not versionfile(0).Contains(currentversion) Then
                UpdateAvailable = True

                Dim a As New ctrlItemNotificationUpdate
                a.LblNotification.Text = versionfile(1) + " - v" + versionfile(0)
                a.Size = New Size(panelMovies.Size.Width - 25, a.Size.Height)
                a.TopLevel = False
                a.Show()
                panelMovies.Controls.Add(a)
                panelMovies.Controls.SetChildIndex(a, 0)
                panelMovies.SetFlowBreak(a, True)
            End If
            timerGetUpdate.Enabled = False
        Catch ex As Exception
            timerGetUpdate.Enabled = False
        End Try
    End Sub

#End Region

#Region "Send Mail"

    Public Sub SendMail(bodytext As String, messagetext As String)
        Try
            Dim smtp As New SmtpClient
            Dim message As New MailMessage
            Dim username As String = "contactzeduc@gmail.com"
            Dim password As String = "asecret1"
            smtp.Host = "smtp.gmail.com"
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential(username, password)
            message.To.Add(username)
            message.From = New MailAddress(username)
            message.Subject = bodytext
            message.Body = messagetext
            smtp.Send(message)
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Create Font"

    'Thanks to https://stackoverflow.com/questions/1350993/vb-net-how-to-compose-and-apply-a-font-to-a-label-in-runtime
    Public Function CreateFont(ByVal fontName As String,
                           ByVal fontSize As Integer,
                           ByVal isBold As Boolean,
                           ByVal isItalic As Boolean,
                           ByVal isStrikeout As Boolean) As Font

        Dim styles As FontStyle = FontStyle.Regular

        If (isBold) Then
            styles = styles Or FontStyle.Bold
        End If

        If (isItalic) Then
            styles = styles Or FontStyle.Italic
        End If

        If (isStrikeout) Then
            styles = styles Or FontStyle.Strikeout
        End If

        Dim newFont As New Font(fontName, fontSize, styles)
        Return newFont
    End Function

#End Region

#Region "Filter Movies by Genre / Buttons"

    Public selectedGenre As String = "All Movies"
    Public selectedGenreObject As Object = btnGenreAllMovies

    Public Sub btnGenre_Click(sender As Object, e As EventArgs) Handles btnGenreAllMovies.ClickButtonArea, btnGenreAllMovies.Click, btnGenreDrama.Click, btnGenreFamily.Click, btnGenreFantasy.Click, btnGenreComedy.Click, btnGenreCrime.Click, btnGenreDocumentary.Click, btnGenreSciFi.Click, btnGenreThriller.Click, btnGenreWar.Click, btnGenreWestern.Click, btnGenreMusic.Click, btnGenreMystery.Click, btnGenreRomance.Click, btnGenreHistory.Click, btnGenreHorror.Click, btnGenreAnimation.Click, btnGenreAdventure.Click, btnGenreAction.Click
        Try
            If sender.Text = "All Movies" Then
                For Each a As Control In panelGenresCtrls.Controls
                    a.BackColor = Color.FromArgb(24, 32, 45)
                    a.ForeColor = Color.FromArgb(161, 168, 179)
                Next

                sender.BackColor = Color.FromArgb(43, 50, 61)
                sender.ForeColor = Color.White

                panelMovies.Controls.Clear()
                storeControlsScroll.Clear()

                selectedGenre = sender.Text
                selectedGenreObject = sender

                Dim countMovie As Integer = 0

                For Each a In storeControlsAllMovies
                    countMovie = countMovie + 1
                    If countMovie <= 40 Then
                        panelMovies.Controls.Add(a)
                    Else
                        storeControlsScroll.Add(a)
                    End If
                Next

            Else
                For Each a As Control In panelGenresCtrls.Controls
                    a.BackColor = Color.FromArgb(24, 32, 45)
                    a.ForeColor = Color.FromArgb(161, 168, 179)
                Next

                sender.BackColor = Color.FromArgb(43, 50, 61)
                sender.ForeColor = Color.White

                panelMovies.Controls.Clear()
                storeControlsScroll.Clear()

                selectedGenre = sender.text
                selectedGenreObject = sender

                Dim countMovie As Integer = 0

                For Each a In storeControlsAllMovies
                    For Each ab As Control In a.Controls
                        If ab.Name = "InfoGenre" Then
                            If ab.Text.ToLower.Contains(sender.Text.ToString.ToLower) Then
                                countMovie = countMovie + 1
                                If countMovie <= 40 Then
                                    panelMovies.Controls.Add(a)
                                Else
                                    storeControlsScroll.Add(a)
                                End If
                            End If
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGenre_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGenreDrama.MouseMove, btnGenreFamily.MouseMove, btnGenreFantasy.MouseMove, btnGenreComedy.MouseMove, btnGenreCrime.MouseMove, btnGenreDocumentary.MouseMove, btnGenreAllMovies.MouseMove, btnGenreSciFi.MouseMove, btnGenreThriller.MouseMove, btnGenreWar.MouseMove, btnGenreWestern.MouseMove, btnGenreMusic.MouseMove, btnGenreMystery.MouseMove, btnGenreRomance.MouseMove, btnGenreHistory.MouseMove, btnGenreHorror.MouseMove, btnGenreAnimation.MouseMove, btnGenreAdventure.MouseMove, btnGenreAction.MouseMove
        sender.BackColor = Color.FromArgb(43, 50, 61)
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnGenre_MouseLeave(sender As Object, e As EventArgs) Handles btnGenreDrama.MouseLeave, btnGenreFamily.MouseLeave, btnGenreFantasy.MouseLeave, btnGenreComedy.MouseLeave, btnGenreCrime.MouseLeave, btnGenreDocumentary.MouseLeave, btnGenreAllMovies.MouseLeave, btnGenreSciFi.MouseLeave, btnGenreThriller.MouseLeave, btnGenreWar.MouseLeave, btnGenreWestern.MouseLeave, btnGenreMusic.MouseLeave, btnGenreMystery.MouseLeave, btnGenreRomance.MouseLeave, btnGenreHistory.MouseLeave, btnGenreHorror.MouseLeave, btnGenreAnimation.MouseLeave, btnGenreAdventure.MouseLeave, btnGenreAction.MouseLeave
        If Not selectedGenre = sender.Text Then
            sender.BackColor = Color.FromArgb(24, 32, 45)
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub


    'Top Rated
    Public Sub btnFilterTopRated_Click(sender As Object, e As EventArgs) Handles btnFilterTopRated.Click
        If Not sender.text = selectedGenre Then
            For Each a As Control In panelGenresCtrls.Controls
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            Next

            sender.BackColor = Color.FromArgb(43, 50, 61)
            sender.ForeColor = Color.White

            panelMovies.Controls.Clear()
            storeControlsScroll.Clear()

            selectedGenre = sender.text
            selectedGenreObject = sender

            Dim countMovie As Integer = 0

            For Each a In storeControlsAllMovies
                For Each ab As Control In a.Controls
                    If ab.Name = "InfoTitleAndYear" Then
                        If itemsMoviesTopRated.Items.Contains(ab.Text) Then
                            countMovie = countMovie + 1
                            If countMovie <= 40 Then
                                panelMovies.Controls.Add(a)
                            Else
                                storeControlsScroll.Add(a)
                            End If
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    'New Relases
    Public Sub btnFilterNewReleases_Click(sender As Object, e As EventArgs) Handles btnFilterNewReleases.Click
        If Not sender.text = selectedGenre Then
            For Each a As Control In panelGenresCtrls.Controls
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            Next

            sender.BackColor = Color.FromArgb(43, 50, 61)
            sender.ForeColor = Color.White

            panelMovies.Controls.Clear()
            storeControlsScroll.Clear()

            selectedGenre = sender.text
            selectedGenreObject = sender

            Dim countMovie As Integer = 0

            For Each a In storeControlsAllMovies
                For Each ab As Control In a.Controls
                    If ab.Name = "InfoTitleAndYear" Then
                        If itemsMoviesNewlyReleased.Items.Contains(ab.Text) Then
                            countMovie = countMovie + 1
                            If countMovie <= 40 Then
                                panelMovies.Controls.Add(a)
                            Else
                                storeControlsScroll.Add(a)
                            End If
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    'Trending
    Public Sub btnFilterTrending_Click(sender As Object, e As EventArgs) Handles btnFilterTrending.Click
        If Not sender.text = selectedGenre Then
            For Each a As Control In panelGenresCtrls.Controls
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            Next

            sender.BackColor = Color.FromArgb(43, 50, 61)
            sender.ForeColor = Color.White

            panelMovies.Controls.Clear()
            storeControlsScroll.Clear()

            selectedGenre = sender.text
            selectedGenreObject = sender

            Dim countMovie As Integer = 0

            For Each a In storeControlsAllMovies
                For Each ab As Control In a.Controls
                    If ab.Name = "InfoTitleAndYear" Then
                        If itemsMoviesTrending.Items.Contains(ab.Text) Then
                            countMovie = countMovie + 1
                            If countMovie <= 40 Then
                                panelMovies.Controls.Add(a)
                            Else
                                storeControlsScroll.Add(a)
                            End If
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub btnFilterTrending_MouseMove(sender As Object, e As MouseEventArgs) Handles btnFilterTrending.MouseMove, btnFilterNewReleases.MouseMove, btnFilterTopRated.MouseMove
        sender.BackColor = Color.FromArgb(43, 50, 61)
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnFilterTrending_MouseLeave(sender As Object, e As EventArgs) Handles btnFilterTrending.MouseLeave, btnFilterNewReleases.MouseLeave, btnFilterTopRated.MouseLeave
        If Not selectedGenre = sender.Text Then
            sender.BackColor = Color.FromArgb(24, 32, 45)
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

#End Region

#Region "Collections (beta)"

    Public storeControlsCollectionsScroll As New List(Of Control)

    Private Sub imgCollectionsB2Browse_Click(sender As Object, e As EventArgs) Handles imgCollectionsB2Browse.Click
        tabsCollections.SelectedTab = tabCollectionsHome
    End Sub

    Private Sub panelCollectionsItems_Scroll(sender As Object, e As ScrollEventArgs) Handles panelCollectionsItems.Scroll
        Try
            Dim vs As VScrollProperties = panelCollectionsItems.VerticalScroll
            If e.NewValue = (vs.Maximum - vs.LargeChange) + 1 Then
                If storeControlsCollectionsScroll.Count >= 30 Then
                    For Each ctrlMovie In storeControlsCollectionsScroll.Take(30)
                        panelCollectionsItems.Controls.Add(ctrlMovie)
                    Next
                    storeControlsCollectionsScroll.RemoveRange(0, 30)
                Else
                    For Each ctrlMovie In storeControlsCollectionsScroll
                        panelCollectionsItems.Controls.Add(ctrlMovie)
                    Next
                    storeControlsCollectionsScroll.Clear()
                End If
            End If
        Catch ex As Exception
        End Try

        panelCollectionsItems.Update()
    End Sub

    Private Sub panelCollectionsMovies_Scroll(sender As Object, e As ScrollEventArgs) Handles panelCollectionsMovies.Scroll
        panelCollectionsMovies.Update()
    End Sub

#End Region

#Region "Downloads - Tab"

    Private Sub panelDownloads_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelDownloads.ControlAdded
        imgPanelsEmptyDownloads.Visible = False
    End Sub

#End Region

#Region "Select Source"

    Public Function returnSource(parent As Form, movie As String, links As String, type As String) As String
        Try
            Dim WebClient As New WebClient()
            Dim a As New frmSelectSource
            a.TopLevel = True
            a.Top = parent.ClientRectangle.Top
            a.Left = parent.ClientRectangle.Left
            a.Size = parent.Size

            a.itemsMovieSourcesTitle.Items.Clear()
            a.itemsMovieSources.Items.Clear()

            Dim splitSources As String() = Split(links, "*")
            For Each ab As String In splitSources
                Dim sourceTitle As String = ab.Substring(ab.LastIndexOf("/") + 1)
                a.itemsMovieSourcesTitle.Items.Add(sourceTitle)
                a.itemsMovieSources.Items.Add(ab)
            Next

            If type = "watch" Then
                Dim exts As String() = {"*.mp4", "*.avi", "*.mkv"}
                Dim fileNames = My.Computer.FileSystem.GetFiles(pathDownloads, FileIO.SearchOption.SearchTopLevelOnly, exts)

                For Each fileName As String In fileNames
                    Dim cutFileName As String = fileName.Replace(pathDownloads, "")

                    If cutFileName.Substring(0, cutFileName.Length - 4) = movie Then
                        a.itemsMovieSourcesTitle.Items.Add(cutFileName + " (local)")
                        a.itemsMovieSources.Items.Add(fileName)
                    End If
                Next
            End If

            If a.ShowDialog(parent) = DialogResult.OK Then
                If Not a.itemsMovieSourcesTitle.SelectedIndex = -1 Then
                    Return a.itemsMovieSources.SelectedItem.ToString
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub Movieo_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        btnGenre_Click(btnGenreAllMovies, e)
    End Sub

#End Region

End Class