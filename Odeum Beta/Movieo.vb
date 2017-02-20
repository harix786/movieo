Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class Movieo

#Region "Preferences (some can be changed)"

    Public DeveloperMode As Boolean = True
    Public CurrentDatabase As String = "https://dl.dropbox.com/s/7rhzy2odzkal6tx/movieo-db.txt?dl=0"
    Public BackupDatabase As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Movieo.db"
    Public MovieoChangelog As String = "https://dl.dropbox.com/s/3514qygmbok1rvv/movieo-changelog.txt?dl=0"
    Public MovieoNotifications As String = "https://dl.dropbox.com/s/eqxi751t8z031na/movieo-notifications.txt?dl=0"
    Public LatestVersion As String = "https://dl.dropbox.com/s/n0lwh73gh15vpf5/movieo-version.txt?dl=0"
    Public AutoUpdater As String = "https://dl.dropbox.com/s/aqouj2qgn7galjd/Movieo%20Updater.exe?dl=0"
    Public FavouritesListPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\favourites.txt"
    Public WatchListPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\watch list.txt"
    Public WatchedListPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\watched.txt"
    Public ThisVersion As String = "Beta Build v" + Application.ProductVersion
    Public DownloadLocation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Downloads\"
    Public SearchboxWatermark As String = "Search movies, people, years..."
    Public TempUpdaterPath As String = Path.GetTempPath + "\Movieo Updater.exe"
    Public UpdaterPath As String = Application.StartupPath + "\Movieo Updater.exe"
    Public BackupDatabaseErrorMessage As String = "Movieo has bumped into an issue loading movies from our database. Information on your issue has been sent to us, we promise we'll be back up soon :)"
    Public NoInternetErrorMessage As String = "Movieo is unable to access the internet to reach our server. Please check your internet connection and try again. If you have anymore issues then please email us at info@movieo.at.vu"
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
        "Remember to get up & stretch" + vbNewLine + "once in a while.",
        "Teaching snakes to kick."}

    Dim UseBackupDatabase As Boolean = False

#End Region

#Region "Movieo"

    Private Sub Movieo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.doCelebr8 = True Then
            ShowCelebrationIcon()
        End If

        frmStartupTab.txtLoading.Text = "Loading, please wait..."
        Threading.Thread.Sleep(1000)

        Tab.SelectedTab = tabLoading 'Show loading page
        'Set top left and maximum size
        Enabled = False
        Top = 0
        Left = 0
        Height = Screen.PrimaryScreen.WorkingArea.Height
        Width = Screen.PrimaryScreen.WorkingArea.Width
        TxtSearchBox.Watermark = SearchboxWatermark 'Set search bar watermark text
        LoadLists() 'Load movies into users lists (ListBoxes)
        frmInfo.LblVersion.Text = ThisVersion 'Set current version in ABOUT page
        If CheckForInternetConnection() = True Then 'Proceed to internet required functions
            UseBackupDatabase = False 'So the database function uses the latest (from the server

            'Show startup loading page
            frmStartupTab.Size = New Size(Size.Width, Size.Height - AppTitle.Size.Height - 3)
            frmStartupTab.Show(Me)
            frmStartupTab.Location = New Point(Location.X, Location.Y + AppTitle.Size.Height + 3)
            filterGenreBox.SelectedIndex = My.Settings.doFilterNum
            CurrentSortBy = BtnSortByNewlyAdded
            Tab.SelectedTab = tabLoading
            Enabled = False
            Tab.SelectedTab = tabLoading
            GetNotifications.Enabled = True
            If My.Settings.doAutoUpdate = True Then
                GetUpdateNotification.Enabled = True
            End If
            StartupTimer.Enabled = True
            If My.Settings.doBackupDb = True Then
                SaveBackupDatabase()
            End If
        Else
            If My.Computer.FileSystem.FileExists(BackupDatabase) Then
                If ShowYesNo("Unable to load database", "Sorry, Movieo is unable to connect to the internet so we can access our server. Although, we may be able to load-up a backup of the database but unfortunately it could be outdated. Would you like us to proceed?", Me) = DialogResult.Yes Then
                    UseBackupDatabase = True 'So the database function uses the backup of db
                    'Show startup loading page
                    frmStartupTab.Size = New Size(Size.Width, Size.Height - AppTitle.Size.Height - 3)
                    frmStartupTab.Show(Me)
                    frmStartupTab.Location = New Point(Location.X, Location.Y + AppTitle.Size.Height + 3)
                    filterGenreBox.SelectedIndex = My.Settings.doFilterNum
                    CurrentSortBy = BtnSortByNewlyAdded
                    Tab.SelectedTab = tabLoading
                    Enabled = False
                    Tab.SelectedTab = tabLoading
                    GetNotifications.Enabled = True
                    If My.Settings.doAutoUpdate = True Then
                        GetUpdateNotification.Enabled = True
                    End If
                    StartupTimer.Enabled = True
                Else
                    'Show error form on movies tab
                    tabMovies.Controls.Remove(PanelMovies)
                    Dim a As New frmErrorTab
                    a.TopLevel = False
                    a.Show()
                    tabMovies.Controls.Add(a)
                    a.Dock = DockStyle.Fill
                    a.BringToFront()
                    Tab.SelectedTab = tabMovies
                    BtnSortByAZ.Enabled = False
                    BtnSortByNewlyAdded.Visible = False
                    BtnSortByYearReleased.Visible = False
                    BtnSortByPopularity.Visible = False
                    Enabled = True
                    ShowPopupError("No internet connection",
                    NoInternetErrorMessage)
                End If
            Else
                'Show error form on movies tab - if no backup database file stored
                tabMovies.Controls.Remove(PanelMovies)
                Dim a As New frmErrorTab
                a.TopLevel = False
                a.Show()
                tabMovies.Controls.Add(a)
                a.Dock = DockStyle.Fill
                a.BringToFront()
                Tab.SelectedTab = tabMovies
                BtnSortByAZ.Enabled = False
                BtnSortByNewlyAdded.Visible = False
                BtnSortByYearReleased.Visible = False
                BtnSortByPopularity.Visible = False
                Enabled = True
                ShowPopupError("No internet connection",
                NoInternetErrorMessage)
            End If
        End If
    End Sub

    'Save users list on application exit
    Private Sub Movieo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveLists()
    End Sub

    'Drag form using mouse (form title)
    Dim MouseDrag As Boolean
    Dim MouseX As Integer
    Dim MouseY As Integer

    Private Sub appTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles AppTitle.MouseUp
        MouseDrag = False
    End Sub

    Private Sub appTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles AppTitle.MouseMove
        If MouseDrag Then
            Top = Cursor.Position.Y - MouseY
            Left = Cursor.Position.X - MouseX
        End If
    End Sub

    Private Sub appTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles AppTitle.MouseDown
        MouseDrag = True
        MouseX = Cursor.Position.X - Me.Left
        MouseY = Cursor.Position.Y - Me.Top
    End Sub

    Public Sub ShowCelebrationIcon() 'Sets the Celebration icon form the returned current month
        If MonthName(10, False) = "October" Then
            imgCelebrationMonth.Image = My.Resources.CelebHalloween
        ElseIf MonthName(12, False) = "December" Then
            imgCelebrationMonth.Image = My.Resources.CelebXmas
        End If
    End Sub

    Public Sub SaveBackupDatabase() 'Download and save a backup of the current database
        Try
            NetDl.DownloadFile(CurrentDatabase, BackupDatabase)
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean 'Returns the current status of internet connection (must be able to access dropbox)
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.dropbox.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Top Right Controls (Window)"

    Private Sub appExpand_MouseMove(sender As Object, e As MouseEventArgs) Handles AppMaximize.MouseMove
        AppMaximize.Image = My.Resources.MaximiseAppH
    End Sub

    Private Sub appExpand_MouseLeave(sender As Object, e As EventArgs) Handles AppMaximize.MouseLeave
        AppMaximize.Image = My.Resources.MaximiseAppL
    End Sub

    Private Sub appExpand_Click(sender As Object, e As EventArgs) Handles AppMaximize.Click
        Me.WindowState = FormWindowState.Normal
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
    End Sub

    Private Sub appMin_MouseMove(sender As Object, e As MouseEventArgs) Handles AppMinimize.MouseMove
        AppMinimize.Image = My.Resources.MinimiseAppH
    End Sub

    Private Sub appMin_MouseLeave(sender As Object, e As EventArgs) Handles AppMinimize.MouseLeave
        AppMinimize.Image = My.Resources.MinimiseAppL
    End Sub

    Private Sub appMin_Click(sender As Object, e As EventArgs) Handles AppMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As MouseEventArgs) Handles AppExit.MouseMove
        AppExit.Image = My.Resources.CloseAppH
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles AppExit.MouseLeave
        AppExit.Image = My.Resources.CloseAppL
    End Sub

    Private Sub TopRight_MouseMove(sender As Object, e As MouseEventArgs) Handles btnRequestMovie.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub TopRight_MouseLeave(sender As Object, e As EventArgs) Handles btnRequestMovie.MouseLeave
        sender.ForeColor = Color.FromArgb(166, 166, 166)
    End Sub

    Private Sub btnChangelog_Click(sender As Object, e As EventArgs) Handles btnRequestMovie.Click
        InfoSelectedTab = frmInfo.TabContact
        frmInfo.Show(Me)
    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles AppExit.Click
        Application.Exit()
    End Sub

#End Region

#Region "Show popups / Open folder"

    Public Sub ShowPopupError(Title As String, Message As String)
        Try
            frmPopupBg.ShowDialog(Me)
            frmPopupOk.DialogTitle.Text = Title
            frmPopupOk.DialogMessage.Text = Message
            frmPopupOk.Show(frmPopupBg)
        Catch ex As Exception
        End Try
    End Sub

    Public Function ShowYesNo(Title As String, Message As String, owns As Form) As DialogResult
        frmPopupBg.ShowDialog(Me)
        frmPopupYesNo.DialogTitle.Text = Title
        frmPopupYesNo.DialogMessage.Text = Message
        frmPopupYesNo.ShowDialog(frmPopupBg)
        Return frmPopupYesNo.DialogResult
    End Function

    Public Sub ShowFile(file As String)
        Dim args As String = String.Format("/Select, ""{0}""", file)
        Dim pfi As New ProcessStartInfo("Explorer.exe", args)
        Process.Start(pfi)
    End Sub

#End Region

#Region "Create/Save/Load Lists"

    Private Sub LoadLists()
        Try
            Dim MoviesFavourites() As String = File.ReadAllLines(FavouritesListPath)
            itemsFavouritesList.Items.AddRange(MoviesFavourites)

            Dim MoviesWatchList() As String = File.ReadAllLines(WatchListPath)
            itemsWatchList.Items.AddRange(MoviesWatchList)

            Dim MoviesWatched() As String = File.ReadAllLines(WatchedListPath)
            itemsSeenList.Items.AddRange(MoviesWatched)

            Dim NotifItem As String = My.Settings.NotifNumbers
            If NotifItem <> "" Then
                itemsNotificationList.Items.Clear()
                itemsNotificationList.Items.AddRange(NotifItem.Split("|"))
            End If
        Catch ex As Exception
            If ex.Message.ToString.Contains(FavouritesListPath) Then
                CreateEmptyListFiles()
            Else
                ShowPopupError("Issue Loading Lists", ex.Message)
            End If
        End Try
    End Sub

    Private Sub SaveLists()
        Try
            My.Settings.doo = False

            'Favourite Movies
            Dim BuildLists1 As New Text.StringBuilder()
            For Each MovieItem As String In itemsFavouritesList.Items
                BuildLists1.AppendLine(MovieItem)
            Next
            File.WriteAllText(FavouritesListPath, BuildLists1.ToString())

            'Watch List Movies
            Dim BuildLists2 As New Text.StringBuilder()
            For Each MovieItem As String In itemsWatchList.Items
                BuildLists2.AppendLine(MovieItem)
            Next
            File.WriteAllText(WatchListPath, BuildLists2.ToString())

            'Watched Movies
            Dim BuildLists3 As New Text.StringBuilder()
            For Each MovieItem As String In itemsSeenList.Items
                BuildLists3.AppendLine(MovieItem)
            Next
            File.WriteAllText(WatchedListPath, BuildLists3.ToString())

            'Notifications
            Dim NotifItem As New List(Of String)
            For Each NotifNumber As String In itemsNotificationList.Items
                NotifItem.Add(NotifNumber)
            Next
            My.Settings.NotifNumbers = String.Join("|", NotifItem.ToArray)

            My.Settings.Save()
        Catch ex As Exception
            ShowPopupError("Issue loading your lists", ex.Message)
        End Try
    End Sub

    Public Sub CreateEmptyListFiles()
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\")
        My.Computer.FileSystem.CreateDirectory(DownloadLocation)
        File.WriteAllText(FavouritesListPath, "")
        File.WriteAllText(WatchListPath, "")
        File.WriteAllText(WatchedListPath, "")
        File.WriteAllText(BackupDatabase, "")
    End Sub

#End Region

#Region "Startup Timer / Grab Movies"

    Private Sub StartupTimer_Tick(sender As Object, e As EventArgs) Handles StartupTimer.Tick
        If UseBackupDatabase = False Then
            GrabMovies(CurrentDatabase)
        Else
            GrabMovies(BackupDatabase)
        End If

        Enabled = True

        If My.Settings.doStartScr = 0 Then
            Tab.SelectedTab = tabMovies
        ElseIf My.Settings.doStartScr = 1 Then
            Tab.SelectedTab = tabFavourites
        ElseIf My.Settings.doStartScr = 2 Then
            Tab.SelectedTab = tabWatchList
        End If

        'If My.Settings.doFilters = True Then
        'filterGenreBox.SelectedIndex = My.Settings.doFilterNum
        'End If

        frmStartupTab.Close()
        StartupTimer.Enabled = False
    End Sub

    'Get if movie is not found in omdbapi
    Dim ErrorMovie As String = ""

    'Count movies
    Dim MovieItem As Integer

    'Get movies, display in movies and both lists
    Public NetDl = New WebClient()

    Public Sub GrabMovies(Content As String)
        Try
            MovieItem = 0
            ContentToFilter3.Items.Clear()
            ContentToFilter1.Items.Clear()
            ContentToFilter2.Items.Clear()
            filterGenreBox.SelectedIndex = My.Settings.doFilterNum  'Reset genre filter box
            Tab.SelectedTab = tabLoading
            TxtSearchBox.Text = "" 'Reset search bar text

            'Remove movies from panels
            PanelWatchList.Controls.Clear()
            PanelFavourites.Controls.Clear()
            PanelMovies.Controls.Clear()

            'Split data
            Dim DataSplitter As String = "~"

            Dim MyWebProxy As New WebProxy
            Dim MyCredentials As New NetworkCredential

            If My.Settings.doAutoProxy = True Then
                NetDl.Proxy = Nothing
            Else
                With MyCredentials
                    .UserName = ""
                    .Password = ""
                End With

                With MyWebProxy
                    .Address = New Uri("")
                    .Credentials = MyCredentials
                    .BypassProxyOnLocal = True 'or false
                End With

                NetDl.Proxy = MyWebProxy
            End If

            Dim WebDl = New WebClient()
            WebDl.Proxy = Nothing

            Dim MoviesContent As String = NetDl.DownloadString(Content)
            Dim MoviesByLine() As String = Split(MoviesContent, vbNewLine)

            For Each MovieOnLine As String In MoviesByLine.Reverse
                If Not MovieOnLine = "" Then
                    MovieItem = MovieItem + 1

                    Dim MovieCred As String() = Split(MovieOnLine, DataSplitter)

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    ErrorMovie = MovieCred(0)

                    a.InfoTitle.Text = MovieCred(0)
                    a.InfoYear.Text = MovieCred(1)

                    Dim TitleAndYear As String = MovieCred(0) + " (" + MovieCred(1) + ")"

                    Dim dstring = WebDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text + "&tomatoes=true")
                    Dim dar = dstring.Split(Chr(34))
                    Dim time = dar(19)
                    Dim genre = dar(23)
                    Dim about = dar(39)
                    Dim director = dar(27)
                    Dim stars = dar(35)
                    Dim poster = dar(55)

                    'MORE DETAILS
                    Dim imdbrating = dar(63)
                    a.InfoImdbRating.Text = imdbrating
                    If a.InfoImdbRating.Text.Contains("N/A") Then a.InfoImdbRating.Text = imdbrating.Replace("N/A", "0")
                    Dim rtomatoes = dar(79)
                    a.InfoRTomatoes.Text = rtomatoes
                    Dim metacritic = dar(59)
                    a.InfoRMetaCritic.Text = metacritic

                    Dim releasedate = dar(15)
                    Dim rating = dar(11)
                    Dim country = dar(47)
                    Dim language = dar(43)
                    Dim production = dar(131)
                    Dim boxoffice = dar(127)
                    Dim awards = dar(51)
                    Dim imdbid = dar(71)
                    Dim rtomlink = dar(119)

                    a.InfoGenre.Text = genre
                    a.InfoDesc.Text = about
                    a.InfoDuration.Text = time
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoPosterLink.Text = poster

                    'MORE DETAILS
                    a.InfoReleaseDate.Text = releasedate
                    a.InfoRating.Text = rating
                    a.InfoCountry.Text = country
                    a.InfoLanguage.Text = language
                    a.InfoProduction.Text = production
                    a.InfoBoxOffice.Text = boxoffice
                    a.InfoAwards.Text = awards
                    a.InfoImdbId.Text = imdbid
                    a.InfoRTomLink.Text = rtomlink

                    a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(WebDl.DownloadData(poster)))
                    a.InfoMovieLink.Text = MovieCred(2)
                    a.InfoBasic.Text = "☆ " + imdbrating + " • " + MovieCred(1)
                    a.InfoSearches.Text = MovieCred(0) + " " + MovieCred(1) + " " + genre + " " + director + " " + stars
                    a.Show()
                    ContentToFilter3.Items.Add(imdbrating + "~" + MovieCred(0) + "~" + MovieCred(1) + "~" + genre + "~" + time + "~" + director + "~" + stars + "~" + about + "~" + poster + "~" + MovieCred(2))
                    ContentToFilter1.Items.Add(MovieCred(1) + "~" + MovieCred(0) + "~" + imdbrating + "~" + genre + "~" + time + "~" + director + "~" + stars + "~" + about + "~" + poster + "~" + MovieCred(2))
                    ContentToFilter2.Items.Add(MovieCred(0) + "~" + MovieCred(1) + "~" + imdbrating + "~" + genre + "~" + time + "~" + director + "~" + stars + "~" + about + "~" + poster + "~" + MovieCred(2))

                    a.Name = MovieCred(0).Replace(" ", "") + "(" + MovieCred(1) + ")"

                    If My.Settings.doWatchedMovies = 0 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        a.BackgroundImage = a.ChangeOpacity(a.BackgroundImage, 0.4)
                        PanelMovies.Controls.Add(a)
                    ElseIf My.Settings.doWatchedMovies = 1 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        'Do nothing
                    ElseIf My.Settings.doWatchedMovies = 2 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    Else
                        PanelMovies.Controls.Add(a)
                    End If

                    If itemsFavouritesList.Items.Contains(TitleAndYear) Then
                        AddMovieOnStartup(PanelFavourites, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoImdbRating.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                    End If

                    If itemsWatchList.Items.Contains(TitleAndYear) Then
                        AddMovieOnStartup(PanelWatchList, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoImdbRating.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                    End If

                    If itemsSeenList.Items.Contains(TitleAndYear) Then
                        AddMovieOnStartup(PanelSeenList, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoImdbRating.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                    End If

                    If itemsBlackList.Items.Contains(TitleAndYear) Then
                        AddMovieOnStartup(PanelBlackList, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoImdbRating.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                    End If

                    If MovieItem Mod 30 = 0 Then 'Change to a random loading text every x movies, this case it's 30
                        frmStartupTab.txtLoading.Text = RandomText(SearchingTexts)
                        Threading.Thread.Sleep(3500)
                    End If
                End If
            Next
            richtxtMovieDb.Text = MoviesContent
        Catch ex As Exception
            StartupTimer.Enabled = False
            'Show error form on browse tab
            tabMovies.Controls.Remove(PanelMovies)
            Dim a As New frmErrorTab
            a.TopLevel = False
            a.Show()
            tabMovies.Controls.Add(a)
            a.Dock = DockStyle.Fill
            a.BringToFront()
            Tab.SelectedTab = tabMovies
            Enabled = True
            'SendMail("Issue Loading Movies", ex.Message)
            If DeveloperMode = True Then
                ShowPopupError("Oh no!", ErrorMovie +
                BackupDatabaseErrorMessage)
            Else
                ShowPopupError("Oh no!",
                BackupDatabaseErrorMessage)
            End If
        End Try
    End Sub

#End Region

#Region "Add/Remove Movies from Panel"

    Public Sub AddMovieOnStartup(AddToPanel As FlowLayoutPanel, Title As String, Year As String, Genre As String, Director As String, Stars As String, Description As String, Duration As String, Rating As String, PosterLink As String, MovieLink As String)
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
        tab.InfoImdbRating.Text = Rating
        tab.InfoDirector.Text = Director
        tab.InfoStars.Text = Stars
        tab.InfoPosterLink.Text = PosterLink
        tab.InfoBasic.Text = "☆ " + Rating + " • " + Year
        tab.InfoMovieLink.Text = MovieLink
        tab.InfoSearches.Text = Title + " " + Year + " " + Genre + " " + Director + " " + Stars
        Try
            tab.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(NetDl.DownloadData(PosterLink)))
        Catch ex As Exception
            tab.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
        End Try
        tab.Show()
        AddToPanel.Controls.Add(tab)
    End Sub

    'Add Movie to Favourites/Watch List
    Public Sub AddMovie(AddToPanel As FlowLayoutPanel, AddToList As ListBox, Title As String, Year As String, Genre As String, Director As String, Stars As String, Description As String, Duration As String, Rating As String, PosterLink As String, MovieLink As String)
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
        tab.InfoImdbRating.Text = Rating
        tab.InfoDirector.Text = Director
        tab.InfoStars.Text = Stars
        tab.InfoPosterLink.Text = PosterLink
        tab.InfoBasic.Text = "☆ " + Rating + " • " + Year
        tab.InfoMovieLink.Text = MovieLink
        tab.InfoSearches.Text = Title + " " + Year + " " + Genre + " " + Director + " " + Stars
        Try
            tab.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(NetDl.DownloadData(PosterLink)))
        Catch ex As Exception
            tab.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
        End Try
        tab.Show()
        AddToPanel.Controls.Add(tab)
        AddToList.Items.Add(Title + " (" + Year + ")")
    End Sub

    Public Sub RemoveMovie(RemoveFromPanel As FlowLayoutPanel, RemoveFromList As ListBox, Title As String, Year As String)
        For Each a As Control In RemoveFromPanel.Controls
            For Each ab As Control In a.Controls
                If ab.Text = Title Then
                    RemoveFromPanel.Controls.Remove(a)
                End If
            Next
        Next

        RemoveFromList.Items.Remove(Title + " (" + Year + ")")
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

#Region "Tabs"

    Private Sub Movieo_KeyDown(sender As Object, e As KeyEventArgs) Handles Tab.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtBrowse_Click(sender As Object, e As EventArgs) Handles txtMovies.ClickButtonArea
        Tab.SelectedTab = tabMovies
    End Sub

    Private Sub txtFavourites_Click(sender As Object, e As EventArgs) Handles txtFavourites.ClickButtonArea
        Tab.SelectedTab = tabFavourites
    End Sub

    Private Sub txtWatchList_Click(sender As Object, e As EventArgs) Handles txtWatchList.ClickButtonArea
        Tab.SelectedTab = tabWatchList
    End Sub

    'Tab Title Effects
    Private Sub txtWatchList_MouseMove(sender As Object, e As MouseEventArgs) Handles txtWatchList.MouseMove, txtMovies.MouseMove, txtFavourites.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub txtWatchList_MouseLeave(sender As Object, e As EventArgs) Handles txtWatchList.MouseLeave, txtMovies.MouseLeave, txtFavourites.MouseLeave
        If Not Tab.SelectedTab.Name.Replace("tab", "").Contains(sender.Text.ToString.Replace(" ", "")) Then
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

    'Selected Tabs
    Dim SelectedTab As String

    Dim SearchboxIsActive As Boolean = False
    Dim GoToNextTab As Integer = 0

    Private Sub appTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            ShowExt()
            SelectedTab = tabMovies.Name
            txtMovies.ForeColor = Color.White
            txtFavourites.ForeColor = Color.FromArgb(161, 168, 179)
            txtWatchList.ForeColor = Color.FromArgb(161, 168, 179)
            txtSeenList.ForeColor = Color.FromArgb(161, 168, 179)
            txtBlackList.ForeColor = Color.FromArgb(161, 168, 179)
        ElseIf Tab.SelectedIndex = 1 Then
            HideExt()
            GoToNextTab = 1
            SelectedTab = tabFavourites.Name
            txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
            txtFavourites.ForeColor = Color.White
            txtWatchList.ForeColor = Color.FromArgb(161, 168, 179)
            txtSeenList.ForeColor = Color.FromArgb(161, 168, 179)
            txtBlackList.ForeColor = Color.FromArgb(161, 168, 179)

            If SearchboxIsActive = True Then
                SearchboxInactive()
                Tab.SelectedTab = tabLoading
                Tab.SelectedIndex = GoToNextTab
                ResetFiltersTimer.Enabled = True
            End If

            If PanelFavourites.Controls.Count = 0 Then
                imgPanelsEmpty1.Visible = True
            Else
                imgPanelsEmpty1.Visible = False
            End If
        ElseIf Tab.SelectedIndex = 2 Then
            HideExt()
            GoToNextTab = 2
            SelectedTab = tabWatchList.Name
            txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
            txtFavourites.ForeColor = Color.FromArgb(161, 168, 179)
            txtWatchList.ForeColor = Color.White
            txtSeenList.ForeColor = Color.FromArgb(161, 168, 179)
            txtBlackList.ForeColor = Color.FromArgb(161, 168, 179)

            If SearchboxIsActive = True Then
                SearchboxInactive()
                Tab.SelectedTab = tabLoading
                Tab.SelectedIndex = GoToNextTab
                ResetFiltersTimer.Enabled = True
            End If

            If PanelWatchList.Controls.Count = 0 Then
                imgPanelsEmpty2.Visible = True
            Else
                imgPanelsEmpty2.Visible = False
            End If
        ElseIf Tab.SelectedIndex = 3 Then
            HideExt()
            GoToNextTab = 3
            SelectedTab = txtSeenList.Name
            txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
            txtFavourites.ForeColor = Color.FromArgb(161, 168, 179)
            txtWatchList.ForeColor = Color.FromArgb(161, 168, 179)
            txtSeenList.ForeColor = Color.White
            txtBlackList.ForeColor = Color.FromArgb(161, 168, 179)

            If SearchboxIsActive = True Then
                SearchboxInactive()
                Tab.SelectedTab = tabLoading
                Tab.SelectedIndex = GoToNextTab
                ResetFiltersTimer.Enabled = True
            End If

            If PanelSeenList.Controls.Count = 0 Then
                imgPanelsEmpty3.Visible = True
            Else
                imgPanelsEmpty3.Visible = False
            End If
        ElseIf Tab.SelectedIndex = 4 Then
            HideExt()
            GoToNextTab = 4
            SelectedTab = txtBlackList.Name
            txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
            txtFavourites.ForeColor = Color.FromArgb(161, 168, 179)
            txtWatchList.ForeColor = Color.FromArgb(161, 168, 179)
            txtSeenList.ForeColor = Color.FromArgb(161, 168, 179)
            txtBlackList.ForeColor = Color.White

            If SearchboxIsActive = True Then
                SearchboxInactive()
                Tab.SelectedTab = tabLoading
                Tab.SelectedIndex = GoToNextTab
                ResetFiltersTimer.Enabled = True
            End If

            If PanelBlackList.Controls.Count = 0 Then
                imgPanelsEmpty4.Visible = True
            Else
                imgPanelsEmpty4.Visible = False
            End If
        ElseIf Tab.SelectedIndex = 5 Then
            lblSearchingText.Text = RandomText(SearchingTexts)

            If GoToNextTab = 1 Then
                txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
                txtFavourites.ForeColor = Color.White
                txtWatchList.ForeColor = Color.FromArgb(161, 168, 179)
            ElseIf GoToNextTab = 2 Then
                txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
                txtFavourites.ForeColor = Color.FromArgb(161, 168, 179)
                txtWatchList.ForeColor = Color.White
            End If

            SelectedTab = tabLoading.Name
            txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
            txtFavourites.ForeColor = Color.FromArgb(161, 168, 179)
            txtWatchList.ForeColor = Color.FromArgb(161, 168, 179)

            If SearchboxIsActive = True Then
                SearchboxActive()
            Else
                SearchboxInactive()
            End If
        End If
    End Sub

    'Generate a random loading screen text
    Public Function RandomText(ByVal Items As ICollection(Of String)) As String
        Dim Rndm As New Random()
        Dim StringList As New List(Of String)(Items)
        Return StringList(Rndm.Next(0, Items.Count))
    End Function

    Private Sub PanelMovies_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelMovies.Scroll
        PanelMovies.Update()
    End Sub

    Private Sub PanelWatchList_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelWatchList.Scroll
        PanelWatchList.Update()
    End Sub

    Private Sub PanelFavourites_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelFavourites.Scroll
        PanelFavourites.Update()
    End Sub

    Private Sub PanelSeenList_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelSeenList.Scroll
        PanelSeenList.Update()
    End Sub

    Private Sub PanelBlackList_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelBlackList.Scroll
        PanelBlackList.Update()
    End Sub

#End Region

#Region "Filter, Sort & Search"

    Private Sub ShowMoviesTimer_Tick(sender As Object, e As EventArgs) Handles ShowMoviesTimer.Tick
        If UseBackupDatabase = False Then
            GrabMovies(CurrentDatabase)
        Else
            GrabMovies(BackupDatabase)
        End If
        doBothFilters()
        Tab.SelectedTab = tabMovies
        ShowMoviesTimer.Enabled = False
    End Sub

    'Filter Functions
    Dim DoFilter As Boolean = True 'Stop the double function of filtering movies

    Private Sub filterGenreBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterGenreBox.SelectedIndexChanged
        If DoFilter = True Then
            Tab.SelectedTab = tabLoading
            cmboTextGenre.Text = filterGenreBox.SelectedItem.ToString
            FilterGenreTimer.Enabled = True
        End If
        My.Settings.doFilterNum = filterGenreBox.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub FilterGenreTimer_Tick(sender As Object, e As EventArgs) Handles FilterGenreTimer.Tick
        If TxtSearchBox.Text = "" Then
            If filterGenreBox.SelectedIndex = 0 Then
                ResetFilterGenre()
                Tab.SelectedTab = tabMovies
                FilterGenreTimer.Enabled = False
            Else
                ResetFilterGenre()
                FilterMoviesByGenre()
                Tab.SelectedTab = tabMovies
                FilterGenreTimer.Enabled = False
            End If
        Else
            If filterGenreBox.SelectedIndex = 0 Then
                ResetFilterGenre()
                FilterMoviesBySearch()
                Tab.SelectedTab = tabMovies
                FilterGenreTimer.Enabled = False
            Else
                Tab.SelectedTab = tabLoading
                FilterAndSearchMovies()
                Tab.SelectedTab = tabMovies
                FilterGenreTimer.Enabled = False
            End If
        End If
    End Sub

    Public Sub FilterMoviesBySearch()
        For Each a As Control In PanelMovies.Controls
            a.Visible = True
        Next


        Dim IfNone As Integer = 0
        For Each a As Control In PanelMovies.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoSearches" Then
                    If Not ab.Text.ToLower.Contains(TxtSearchBox.Text.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next


        If IfNone = 0 Then imgPanelsEmpty0.Visible = True Else imgPanelsEmpty0.Visible = False
    End Sub

    Public Sub FilterAndSearchMovies()
        For Each a As Control In PanelMovies.Controls
            a.Visible = True
        Next


        Dim IfNone As Integer = 0
        For Each a As Control In PanelMovies.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoSearches" Then
                    If Not ab.Text.ToLower.Contains(TxtSearchBox.Text.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next


        For Each a As Control In PanelMovies.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoGenre" Then
                    If Not ab.Text.ToLower.Contains(filterGenreBox.SelectedItem.ToString.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next

        If IfNone = 0 Then imgPanelsEmpty0.Visible = True Else imgPanelsEmpty0.Visible = False
    End Sub

    Public Sub FilterMoviesByGenre()
        For Each a As Control In PanelMovies.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoGenre" Then
                    If Not ab.Text.ToLower.Contains(filterGenreBox.SelectedItem.ToString.ToLower) Then
                        a.Visible = False
                    End If
                End If
            Next
        Next
    End Sub

    Dim isUndoAll As Boolean = False

    'Search Movies Bar (All/Favourites/Watch List)
    Dim GoInactive As Boolean = True 'Keep search box inactive or not

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Tab.SelectedIndex = 0 Then
                If TxtSearchBox.Text = "" Then
                    Tab.SelectedTab = tabLoading
                    SearchboxInactive()
                    SearchboxIsActive = False
                    GoToNextTab = 0
                    ResetFiltersTimer.Enabled = True
                Else
                    SearchboxActive()
                    SearchboxIsActive = True
                    Tab.SelectedTab = tabLoading
                    SearchMovies.Enabled = True
                End If
            ElseIf Tab.SelectedIndex = 1 Then
                Tab.SelectedTab = tabLoading
                SearchFavourites.Enabled = True
            ElseIf Tab.SelectedIndex = 2 Then
                Tab.SelectedTab = tabLoading
                SearchWatchList.Enabled = True
            End If
        End If
    End Sub

    Private Sub SearchMovies_Tick(sender As Object, e As EventArgs) Handles SearchMovies.Tick
        DoFilter = False
        SearchClose.Visible = True
        filterGenreBox.SelectedIndex = 0
        cmboTextGenre.Text = "Any Genre"
        SearchMoviesFnc()
        Tab.SelectedTab = tabMovies
        DoFilter = True
        SearchMovies.Enabled = False
    End Sub

    Private Sub SearchFavourites_Tick(sender As Object, e As EventArgs) Handles SearchFavourites.Tick
        SearchFavouritesFunc()
        Tab.SelectedTab = tabFavourites
        SearchFavourites.Enabled = False
    End Sub

    Private Sub SearchWatchList_Tick(sender As Object, e As EventArgs) Handles SearchWatchList.Tick
        SearchWatchListFunc()
        Tab.SelectedTab = tabWatchList
        SearchWatchList.Enabled = False
    End Sub

    Private Sub ResetFilterGenre()
        For Each a As Control In PanelMovies.Controls
            a.Visible = True
        Next
    End Sub

    Private Sub ResetAllFilters()
        SearchboxInactive()
        filterGenreBox.SelectedIndex = 0
        For Each a As Control In PanelMovies.Controls
            a.Visible = True
        Next
    End Sub

    Dim CloseSearch As Boolean = False

    Private Sub ResetFiltersTimer_Tick(sender As Object, e As EventArgs) Handles ResetFiltersTimer.Tick
        TxtSearchBox.Text = ""
        SearchboxInactive()
        SearchboxIsActive = False
        ResetAllFilters()
        Tab.SelectedIndex = GoToNextTab
        ResetFiltersTimer.Enabled = False
    End Sub

    Public Sub SearchMoviesFnc()
        For Each a As Control In PanelMovies.Controls
            a.Visible = True
        Next

        Dim IfNone As Integer = 0
        For Each a As Control In PanelMovies.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoSearches" Then
                    If Not ab.Text.ToLower.Contains(TxtSearchBox.Text.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next

        If IfNone = 0 Then imgPanelsEmpty0.Visible = True Else imgPanelsEmpty0.Visible = False
    End Sub

    Public Sub SearchFavouritesFunc()
        Dim IfNone As Integer = 0
        For Each a As Control In PanelFavourites.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoSearches" Then
                    If Not ab.Text.ToLower.Contains(TxtSearchBox.Text.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next

        If IfNone = 0 Then imgPanelsEmpty1.Visible = True Else imgPanelsEmpty1.Visible = False
    End Sub

    Public Sub SearchWatchListFunc()
        Dim IfNone As Integer = 0
        For Each a As Control In PanelWatchList.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoSearches" Then
                    If Not ab.Text.ToLower.Contains(TxtSearchBox.Text.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next

        If IfNone = 0 Then imgPanelsEmpty2.Visible = True Else imgPanelsEmpty2.Visible = False
    End Sub

    Private Sub TxtSearchBg_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles TxtSearchBg.ClickButtonArea
        TxtSearchBox.Focus()
    End Sub

    Private Sub SearchClose_Click(sender As Object, e As EventArgs) Handles SearchClose.Click
        If SearchboxIsActive = True Then
            GoToNextTab = 0
            SearchboxIsActive = False
            Tab.SelectedTab = tabLoading
            ResetFiltersTimer.Enabled = True
        Else
            TxtSearchBox.Text = ""
            Refresh()
            Update()
            TxtSearchBox.Refresh()
            TxtSearchBox.Update()
        End If
    End Sub

    Private Sub TxtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchBox.TextChanged
        If TxtSearchBox.Text = "" Then
            SearchClose.Visible = False
        Else
            SearchClose.Visible = True
        End If
    End Sub

    'Make Searchbox Inactive Colours
    Public Sub SearchboxInactive()
        TxtSearchBox.Text = ""
        TxtSearchBg.BorderColor = Color.FromArgb(161, 168, 179)
        TxtSearchIcon.Image = My.Resources.SearchIconL
    End Sub

    Public Sub SearchboxActive()
        TxtSearchBg.BorderColor = Color.White
        TxtSearchIcon.Image = My.Resources.SearchIconH
    End Sub

    Private Sub BoxText_Click(sender As Object, e As EventArgs) Handles cmboTextGenre.ClickButtonArea
        filterGenreBox.DroppedDown = True
    End Sub

    'Sort Movies
    Private Sub SortByNewlyAdded_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSortByYearReleased.MouseMove, BtnSortByPopularity.MouseMove, BtnSortByNewlyAdded.MouseMove, BtnSortByAZ.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub SortByNewlyAdded_MouseLeave(sender As Object, e As EventArgs) Handles BtnSortByYearReleased.MouseLeave, BtnSortByPopularity.MouseLeave, BtnSortByNewlyAdded.MouseLeave, BtnSortByAZ.MouseLeave
        If Not sender.name = CurrentSortBy.Name Then
            sender.ForeColor = Color.FromName("ScrollBar")
        End If
    End Sub

    Dim CurrentSortBy = BtnSortByNewlyAdded

    Private Sub SortByAZ_Click(sender As Object, e As EventArgs) Handles BtnSortByYearReleased.Click, BtnSortByPopularity.Click, BtnSortByNewlyAdded.Click, BtnSortByAZ.Click
        If Not sender.name = CurrentSortBy.name Then
            Tab.SelectedTab = tabLoading
            CurrentSortBy = sender
            BtnSortByYearReleased.ForeColor = Color.FromName("ScrollBar")
            BtnSortByPopularity.ForeColor = Color.FromName("ScrollBar")
            BtnSortByAZ.ForeColor = Color.FromName("ScrollBar")
            BtnSortByNewlyAdded.ForeColor = Color.FromName("ScrollBar")
            sender.ForeColor = Color.White
            SortByTimer.Enabled = True
        End If
    End Sub

    Private Sub SortByTimer_Tick(sender As Object, e As EventArgs) Handles SortByTimer.Tick
        filterGenreBox.SelectedIndex = 0
        SearchboxInactive()
        If CurrentSortBy.Name = BtnSortByNewlyAdded.Name Then
            If UseBackupDatabase = False Then
                GrabMovies(CurrentDatabase)
            Else
                GrabMovies(BackupDatabase)
            End If
        ElseIf CurrentSortBy.Name = BtnSortByPopularity.Name Then
            SortByRating()
        ElseIf CurrentSortBy.Name = BtnSortByYearReleased.Name Then
            SortByYear()
        ElseIf CurrentSortBy.Name = BtnSortByAZ.Name Then
            SortByName()
        End If
        Tab.SelectedTab = tabMovies
        SortByTimer.Enabled = False
    End Sub

    Private Sub txtboxSearch_Enter(sender As Object, e As EventArgs) Handles TxtSearchBox.Enter
        TxtSearchBg.BorderColor = Color.White
        TxtSearchIcon.Image = My.Resources.SearchIconH
    End Sub

    Private Sub txtboxSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearchBox.Leave
        If Not Tab.SelectedIndex = 4 Then
            TxtSearchBg.BorderColor = Color.FromArgb(161, 168, 179)
            TxtSearchIcon.Image = My.Resources.SearchIconL
        End If
    End Sub

    Private Sub SortByNewlyAdded()
        Try
            PanelMovies.Controls.Clear()
            ContentToFilter4.Sorted = True
            Dim credentialsplitter As String = "~"
            Dim Items() As String = ContentToFilter4.Items.Cast(Of String).ToArray
            Array.Reverse(Items)
            Dim objDl = New WebClient()
            objDl.Proxy = Nothing
            For Each lineinbox As String In Items
                If Not lineinbox = "" Then
                    Dim credentials As String() = Split(lineinbox, credentialsplitter)


                    Dim rating As String = credentials(0)
                    Dim title As String = credentials(1)
                    Dim year As String = credentials(2)
                    Dim genre As String = credentials(3)
                    Dim time As String = credentials(4)
                    Dim director As String = credentials(5)
                    Dim stars As String = credentials(6)
                    Dim desc As String = credentials(7)
                    Dim posterlink As String = credentials(8)
                    Dim movielink As String = credentials(9)

                    Dim TitleAndYear As String = title + " (" + year + ")"

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    a.InfoTitle.Text = title
                    a.InfoYear.Text = year
                    a.InfoGenre.Text = genre
                    a.InfoDuration.Text = time
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoDesc.Text = desc
                    a.InfoImdbRating.Text = rating
                    a.InfoPosterLink.Text = posterlink

                    Try
                        a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(posterlink)))
                    Catch ex As Exception
                        a.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
                        My.Settings.doo = True
                    End Try

                    a.InfoBasic.Text = "☆ " + rating + " • " + year
                    a.InfoMovieLink.Text = movielink
                    a.InfoSearches.Text = title + " " + year + " " + genre + " " + director + " " + stars
                    a.Show()

                    If My.Settings.doWatchedMovies = 0 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    ElseIf My.Settings.doWatchedMovies = 1 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        'Do nothing
                    ElseIf My.Settings.doWatchedMovies = 2 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    Else
                        PanelMovies.Controls.Add(a)
                    End If
                End If
            Next
        Catch ex As Exception
            SendMail("Issue", ex.Message)
            'ShowPopupError("Oh no!",
            '"We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message and we'll get back to you as soon as. Sorry for the inconvenience.")
        End Try
    End Sub

    Private Sub SortByRating()
        Try
            PanelMovies.Controls.Clear()
            ContentToFilter3.Sorted = True
            Dim credentialsplitter As String = "~"
            Dim Items() As String = ContentToFilter3.Items.Cast(Of String).ToArray
            Array.Reverse(Items)
            Dim objDl = New WebClient()
            objDl.Proxy = Nothing
            For Each lineinbox As String In Items
                If Not lineinbox = "" Then
                    Dim credentials As String() = Split(lineinbox, credentialsplitter)


                    Dim rating As String = credentials(0)
                    Dim title As String = credentials(1)
                    Dim year As String = credentials(2)
                    Dim genre As String = credentials(3)
                    Dim time As String = credentials(4)
                    Dim director As String = credentials(5)
                    Dim stars As String = credentials(6)
                    Dim desc As String = credentials(7)
                    Dim posterlink As String = credentials(8)
                    Dim movielink As String = credentials(9)

                    Dim TitleAndYear As String = title + " (" + year + ")"

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    a.InfoTitle.Text = title
                    a.InfoYear.Text = year
                    a.InfoGenre.Text = genre
                    a.InfoDuration.Text = time
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoDesc.Text = desc
                    a.InfoImdbRating.Text = rating
                    a.InfoPosterLink.Text = posterlink

                    Try
                        a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(posterlink)))
                    Catch ex As Exception
                        a.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
                        My.Settings.doo = True
                    End Try

                    a.InfoBasic.Text = "☆ " + rating + " • " + year
                    a.InfoMovieLink.Text = movielink
                    a.InfoSearches.Text = title + " " + year + " " + genre + " " + director + " " + stars
                    a.Show()

                    If My.Settings.doWatchedMovies = 0 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    ElseIf My.Settings.doWatchedMovies = 1 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        'Do nothing
                    ElseIf My.Settings.doWatchedMovies = 2 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    Else
                        PanelMovies.Controls.Add(a)
                    End If
                End If
            Next
        Catch ex As Exception
            SendMail("Issue", ex.Message)
            'ShowPopupError("Oh no!",
            '"We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message and we'll get back to you as soon as. Sorry for the inconvenience.")
        End Try
    End Sub

    Private Sub SortByYear()
        Try
            PanelMovies.Controls.Clear()
            ContentToFilter1.Sorted = True
            Dim credentialsplitter As String = "~"
            Dim Items() As String = ContentToFilter1.Items.Cast(Of String).ToArray
            Array.Reverse(Items)
            Dim objDl = New WebClient()
            objDl.Proxy = Nothing
            For Each credentialsline As String In Items
                If Not credentialsline = "" Then

                    Dim credentials As String() = Split(credentialsline, credentialsplitter)

                    Dim rating As String = credentials(2)
                    Dim title As String = credentials(1)
                    Dim year As String = credentials(0)
                    Dim genre As String = credentials(3)
                    Dim time As String = credentials(4)
                    Dim director As String = credentials(5)
                    Dim stars As String = credentials(6)
                    Dim desc As String = credentials(7)
                    Dim posterlink As String = credentials(8)
                    Dim movielink As String = credentials(9)

                    Dim TitleAndYear As String = title + " (" + year + ")"

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    a.InfoTitle.Text = title
                    a.InfoYear.Text = year
                    a.InfoGenre.Text = genre
                    a.InfoDuration.Text = time
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoDesc.Text = desc
                    a.InfoImdbRating.Text = rating
                    a.InfoPosterLink.Text = posterlink

                    Try
                        a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(posterlink)))
                    Catch ex As Exception
                        a.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
                        My.Settings.doo = True
                    End Try

                    a.InfoBasic.Text = "☆ " + rating + " • " + year
                    a.InfoMovieLink.Text = movielink
                    a.InfoSearches.Text = title + " " + year + " " + genre + " " + director + " " + stars
                    a.Show()

                    If My.Settings.doWatchedMovies = 0 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    ElseIf My.Settings.doWatchedMovies = 1 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        'Do nothing
                    ElseIf My.Settings.doWatchedMovies = 2 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    Else
                        PanelMovies.Controls.Add(a)
                    End If
                End If
            Next
        Catch ex As Exception
            SendMail("Issue", ex.Message)
            ShowPopupError("Oh no!",
            "We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message and we'll get back to you as soon as. Sorry for the inconvenience.")
        End Try
    End Sub

    Private Sub SortByName()
        Try
            PanelMovies.Controls.Clear()
            ContentToFilter2.Sorted = True
            Dim credentialsplitter As String = "~"
            Dim objDl = New WebClient()
            objDl.Proxy = Nothing
            For Each credentialsline As String In ContentToFilter2.Items
                If Not credentialsline = "" Then

                    Dim credentials As String() = Split(credentialsline, credentialsplitter)

                    Dim rating As String = credentials(2)
                    Dim title As String = credentials(0)
                    Dim year As String = credentials(1)
                    Dim genre As String = credentials(3)
                    Dim time As String = credentials(4)
                    Dim director As String = credentials(5)
                    Dim stars As String = credentials(6)
                    Dim desc As String = credentials(7)
                    Dim posterlink As String = credentials(8)
                    Dim movielink As String = credentials(9)

                    Dim TitleAndYear As String = title + " (" + year + ")"

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    a.InfoTitle.Text = title
                    a.InfoYear.Text = year
                    a.InfoGenre.Text = genre
                    a.InfoDuration.Text = time
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoDesc.Text = desc
                    a.InfoImdbRating.Text = rating
                    a.InfoPosterLink.Text = posterlink

                    Try
                        a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(posterlink)))
                    Catch ex As Exception
                        a.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
                        My.Settings.doo = True
                    End Try

                    a.InfoBasic.Text = "☆ " + rating + " • " + year
                    a.InfoMovieLink.Text = movielink
                    a.InfoSearches.Text = title + " " + year + " " + genre + " " + director + " " + stars
                    a.Show()

                    If My.Settings.doWatchedMovies = 0 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    ElseIf My.Settings.doWatchedMovies = 1 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        'Do nothing
                    ElseIf My.Settings.doWatchedMovies = 2 AndAlso itemsSeenList.Items.Contains(TitleAndYear) Then
                        PanelMovies.Controls.Add(a)
                    Else
                        PanelMovies.Controls.Add(a)
                    End If
                End If
            Next
        Catch ex As Exception
            SendMail("Issue", ex.Message)
            ShowPopupError("Oh no!",
            "We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message and we'll get back to you as soon as. Sorry for the inconvenience.")
        End Try
    End Sub

    Public Sub doBothFilters()
        TxtSearchBox.Text = ""

        For Each a As Control In PanelMovies.Controls
            For Each ab As Control In a.Controls
                a.Visible = True
            Next
        Next

        If Not filterGenreBox.SelectedIndex = 0 Then
            FilterMoviesByGenre()
        End If
    End Sub

    'Hide Genre Filter and Sort By items for Selected Tab
    Private Sub HideExt()
        filterGenreBox.Visible = False
        BgPanel.Visible = False
        FncSplitter.Visible = False
        BtnSortByAZ.Visible = False
        BtnSortByNewlyAdded.Visible = False
        BtnSortByPopularity.Visible = False
        BtnSortByYearReleased.Visible = False
        BtnSortByAZ.Visible = False
    End Sub

    Private Sub ShowExt()
        filterGenreBox.Visible = True
        BgPanel.Visible = True
        FncSplitter.Visible = True
        BtnSortByAZ.Visible = True
        BtnSortByNewlyAdded.Visible = True
        BtnSortByPopularity.Visible = True
        BtnSortByYearReleased.Visible = True
        BtnSortByAZ.Visible = True
    End Sub

#End Region

#Region "Info Tabs"

    Public InfoSelectedTab As TabPage = frmInfo.TabAbout

    Public IsContextOpen As Boolean = False

    Private Sub SendFeedback_Click(sender As Object, e As EventArgs) Handles BtnSendFeedback.Click
        'InfoSelectedTab = InfoTabs.TabContact
        'InfoTabs.Show(Me)
        ctrlInfoMenu.Location = New Point(BtnSendFeedback.Location.X, BtnSendFeedback.Location.Y + 28)
        BtnSendFeedback.Image = My.Resources.DropletsIconBgH
        ctrlInfoMenu.Show()
        IsContextOpen = True
    End Sub

    Private Sub SendFeedback_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSendFeedback.MouseMove
        If IsContextOpen = True Then
            BtnSendFeedback.Image = My.Resources.DropletsIconBgH
        Else
            BtnSendFeedback.Image = My.Resources.DropletsIconH
        End If
    End Sub

    Private Sub SendFeedback_MouseLeave(sender As Object, e As EventArgs) Handles BtnSendFeedback.MouseLeave
        If IsContextOpen = True Then
            BtnSendFeedback.Image = My.Resources.DropletsIconBgH
        Else
            BtnSendFeedback.Image = My.Resources.DropletsIconL
        End If
    End Sub

#End Region

#Region "Show Empty Panel Message"

    Private Sub PanelFavourites_ControlAdded(sender As Object, e As ControlEventArgs) Handles PanelFavourites.ControlAdded
        If PanelFavourites.Controls.Count = 0 Then
            imgPanelsEmpty1.Visible = True
        Else
            imgPanelsEmpty1.Visible = False
        End If
    End Sub

    Private Sub PanelFavourites_ControlRemoved(sender As Object, e As ControlEventArgs) Handles PanelFavourites.ControlRemoved
        If PanelFavourites.Controls.Count = 0 Then
            imgPanelsEmpty1.Visible = True
        Else
            imgPanelsEmpty1.Visible = False
        End If
    End Sub

#End Region

#Region "Update / Notifications"

    Private Sub GetUpdateNotification_Tick(sender As Object, e As EventArgs) Handles GetUpdateNotification.Tick
        Try
            Dim request As HttpWebRequest = WebRequest.Create(LatestVersion)
            Dim response As HttpWebResponse = request.GetResponse()
            Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
            Dim versionfile As String() = Split(sr.ReadToEnd, "~")
            Dim newestversion As String = versionfile(0)
            Dim currentversion As String = Application.ProductVersion

            If Not versionfile(0).Contains(currentversion) Then
                Dim a As New ctrlNotificationUpdate
                a.LblNotification.Text = versionfile(1) + " - v" + versionfile(0)
                a.Dock = DockStyle.Top
                a.TopLevel = False
                a.Show()
                tabMovies.Controls.Add(a)
            End If
            GetUpdateNotification.Enabled = False
        Catch ex As Exception
            GetUpdateNotification.Enabled = False
        End Try
    End Sub

    Private Sub GetNotifications_Tick(sender As Object, e As EventArgs) Handles GetNotifications.Tick
        Try
            Dim objDl As New WebClient
            Dim NotificationDb As String = objDl.DownloadString(MovieoNotifications)
            Dim LineByLine() As String = Split(NotificationDb, vbNewLine) 'Split db into lines

            For Each MessageText As String In LineByLine.Reverse
                Dim NotifText As String() = Split(MessageText, "|") 'Split text line into Number & Message
                If Not MessageText = "" Then 'If message isn't blank
                    If Not itemsNotificationList.Items.Contains(NotifText(0)) Then 'If user has 'closed' the notification 
                        Dim a As New ctrlNotification
                        a.PictureBox1.Image = ConvertImageText(NotifText(1))
                        a.LblNotifNumber.Text = NotifText(0) 'Set image to appropriate
                        a.LblNotification.Text = NotifText(2) 'Set text to current message text received
                        a.Dock = DockStyle.Top
                        a.TopLevel = False
                        a.Show()
                        tabMovies.Controls.Add(a) 'Add to notifications panel (above posters)
                    End If
                End If
            Next
            GetNotifications.Enabled = False
        Catch ex As Exception
            GetNotifications.Enabled = False
        End Try
    End Sub

    Public Function ConvertImageText(txt As String) As Bitmap 'Returns the notification image froom text
        If txt = "info" Then
            Return SystemIcons.Information.ToBitmap()
        ElseIf txt = "excl" Then
            Return SystemIcons.Exclamation.ToBitmap()
        ElseIf txt = "ques" Then
            Return SystemIcons.Question.ToBitmap()
        ElseIf txt = "warn" Then
            Return SystemIcons.Warning.ToBitmap()
        ElseIf txt = "aste" Then
            Return SystemIcons.Asterisk.ToBitmap()
        ElseIf txt = "appl" Then
            Return SystemIcons.Application.ToBitmap()
        ElseIf txt = "hand" Then
            Return SystemIcons.Hand.ToBitmap()
        ElseIf txt = "shield" Then
            Return SystemIcons.Shield.ToBitmap()
        Else
            Return SystemIcons.Information.ToBitmap()
        End If
    End Function

#End Region

End Class
