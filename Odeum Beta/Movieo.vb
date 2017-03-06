Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class Movieo

#Region "Preferences (some can be changed)"

    Public devMode As Boolean = True
    Public linkDatabase As String = "https://dl.dropbox.com/s/7rhzy2odzkal6tx/movieo-db.txt?dl=0"
    Public linkChangelog As String = "https://dl.dropbox.com/s/3514qygmbok1rvv/movieo-changelog.txt?dl=0"
    Public linkNotifications As String = "https://dl.dropbox.com/s/eqxi751t8z031na/movieo-notifications.txt?dl=0"
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
    Public ctrlSearchBoxWatermark As String = "Search movies, people, years"
    Public msgBackupDatabaseError As String = "Movieo has bumped into an issue loading movies from our database. Information on your issue has been sent to us, we promise we'll be back up soon :)"
    Public msgNoInternetConnection As String = "Movieo is unable to access the internet to reach our server. Please check your internet connection and try again. If you have anymore issues then please email us at info@movieo.at.vu"
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
        txtboxSearch.WaterMark = ctrlWatermark  'Set search bar watermark text
        LoadLists() 'Load movies into users lists (ListBoxes)
        frmInfo.lblAboutVersion.Text = infoVersionText  'Set current version in ABOUT page
        If CheckForInternetConnection() = True Then 'Proceed to internet required functions
            UseBackupDatabase = False 'So the database function uses the latest (from the server

            'Show startup loading page
            frmStartupTab.Size = New Size(Size.Width, Size.Height - AppTitle.Size.Height - 3)
            frmStartupTab.Show(Me)
            frmStartupTab.Location = New Point(Location.X, Location.Y + AppTitle.Size.Height + 3)
            cmboboxGenre.SelectedIndex = My.Settings.doFilterNum
            CurrentSortBy = 0
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
            If My.Computer.FileSystem.FileExists(pathBackupDatabase) Then
                If ShowYesNo("Unable to load database", "Sorry, Movieo is unable to connect to the internet so we can access our server. Although, we may be able to load-up a backup of the database but unfortunately it could be outdated. Would you like us to proceed?", Me) = DialogResult.Yes Then
                    UseBackupDatabase = True 'So the database function uses the backup of db
                    'Show startup loading page
                    frmStartupTab.Size = New Size(Size.Width, Size.Height - AppTitle.Size.Height - 3)
                    frmStartupTab.Show(Me)
                    frmStartupTab.Location = New Point(Location.X, Location.Y + AppTitle.Size.Height + 3)
                    cmboboxGenre.SelectedIndex = My.Settings.doFilterNum
                    CurrentSortBy = 0
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
                    cmboboxGenre.Enabled = False
                    Enabled = True
                    ShowPopupError("No internet connection",
                    msgNoInternetConnection, Me)
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
                cmboboxGenre.Enabled = False

                Enabled = True
                ShowPopupError("No internet connection",
                msgNoInternetConnection, Me)
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
        If MonthName(Now.Month, False) = "October" Then
            imgCelebrationMonth.Image = My.Resources.CelebHalloween
        ElseIf MonthName(Now.Month, False) = "December" Then
            imgCelebrationMonth.Image = My.Resources.CelebXmas
        End If
    End Sub

    Public Sub SaveBackupDatabase() 'Download and save a backup of the current database
        Try
            NetDl.DownloadFile(linkDatabase, pathBackupDatabase)
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean 'Returns the status of internet connection (must be able to access dropbox)
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

    Public IsNotificationsOpen As Boolean = False

    Private Sub AppNotifications_MouseMove(sender As Object, e As MouseEventArgs) Handles AppNotifications.MouseMove
        If IsNotificationsOpen = True Then
            AppNotifications.Image = My.Resources.notificationsIconH
        Else
            AppNotifications.Image = My.Resources.notificationsIconH
        End If
    End Sub

    Private Sub AppNotifications_MouseLeave(sender As Object, e As EventArgs) Handles AppNotifications.MouseLeave
        If IsNotificationsOpen = True Then
            AppNotifications.Image = My.Resources.notificationsIconH
        Else
            AppNotifications.Image = My.Resources.notificationsIconL
        End If
    End Sub

    Private Sub AppNotifications_Click(sender As Object, e As EventArgs) Handles AppNotifications.Click
        ctrlNotificationsMenu.Location = New Point(AppNotifications.Location.X + 429, AppNotifications.Location.Y + 22)
        AppNotifications.Image = My.Resources.notificationsIconH
        ctrlNotificationsMenu.Show()
        IsNotificationsOpen = True
    End Sub

    Private Sub AppMaximize_MouseMove(sender As Object, e As MouseEventArgs) Handles AppMaximize.MouseMove
        AppMaximize.Image = My.Resources.MaximiseAppH
    End Sub

    Private Sub AppMaximize_MouseLeave(sender As Object, e As EventArgs) Handles AppMaximize.MouseLeave
        AppMaximize.Image = My.Resources.MaximiseAppL
    End Sub

    Private Sub appMaximize_Click(sender As Object, e As EventArgs) Handles AppMaximize.Click
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
        InfoSelectedTab = frmInfo.tabContact
        frmInfo.Show(Me)
    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles AppExit.Click
        Application.Exit()
    End Sub

#End Region

#Region "Show popups / Open folder"

    Public Sub ShowPopupError(Title As String, Message As String, owns As Form)
        Try
            frmPopupBg.Show(owns)
            frmPopupOk.DialogTitle.Text = Title
            frmPopupOk.DialogMessage.Text = Message
            frmPopupOk.Show(frmPopupBg)
        Catch ex As Exception
        End Try
    End Sub

    Public Function ShowYesNo(Title As String, Message As String, owns As Form) As DialogResult
        frmPopupBg.Show(owns)
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
            Dim MoviesFavourites() As String = File.ReadAllLines(pathFavouritesList)
            itemsFavouritesList.Items.AddRange(MoviesFavourites)

            Dim MoviesWatchList() As String = File.ReadAllLines(pathWatchList)
            itemsWatchList.Items.AddRange(MoviesWatchList)

            Dim MoviesWatched() As String = File.ReadAllLines(pathSeenList)
            itemsSeenList.Items.AddRange(MoviesWatched)

            Dim NotifItem As String = My.Settings.NotifNumbers
            If NotifItem <> "" Then
                itemsNotificationList.Items.Clear()
                itemsNotificationList.Items.AddRange(NotifItem.Split("|"))
            End If
        Catch ex As Exception
            If ex.Message.ToString.Contains(pathFavouritesList) Then
                CreateEmptyListFiles()
            Else
                ShowPopupError("Issue Loading Lists", ex.Message, Me)
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

            My.Settings.Save()
        Catch ex As Exception
            ShowPopupError("Issue loading your lists", ex.Message, Me)
        End Try
    End Sub

    Public Sub CreateEmptyListFiles()
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Lists\")
        My.Computer.FileSystem.CreateDirectory(pathDownloads)
        File.WriteAllText(pathFavouritesList, "")
        File.WriteAllText(pathWatchList, "")
        File.WriteAllText(pathSeenList, "")
        File.WriteAllText(pathBlackList, "")
        File.WriteAllText(pathBackupDatabase, "")
    End Sub

#End Region

#Region "Startup Timer / Grab Movies"

    Private Sub StartupTimer_Tick(sender As Object, e As EventArgs) Handles StartupTimer.Tick
        If UseBackupDatabase = False Then
            GrabMovies(linkDatabase)
        Else
            GrabMovies(pathBackupDatabase)
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

        doSortByFunc = True

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
            ContentToFilter1.Items.Clear()
            ContentToFilter2.Items.Clear()
            ContentToFilter3.Items.Clear()
            ContentToFilter4.Items.Clear()
            doSortByFunc = False
            cmboboxGenre.SelectedIndex = My.Settings.doFilterNum  'Reset genre filter box
            cmboboxSortBy.SelectedIndex = 0  'Reset sort by box
            Tab.SelectedTab = tabLoading
            txtboxSearch.Text = "" 'Reset search bar text

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
                    ContentToFilter4.Items.Add(MovieCred(0) + "~" + MovieCred(1) + "~" + MovieCred(2))
                    ContentToFilter3.Items.Add(imdbrating + "~" + MovieCred(0) + "~" + MovieCred(1) + "~" + MovieCred(2))
                    ContentToFilter2.Items.Add(MovieCred(0) + "~" + MovieCred(1) + "~" + MovieCred(2))
                    ContentToFilter1.Items.Add(MovieCred(1) + "~" + MovieCred(0) + "~" + MovieCred(2))

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
            If devMode = True Then
                ShowPopupError("Oh no!", ErrorMovie +
                msgBackupDatabaseError, Me)
            Else
                ShowPopupError("Oh no!",
                msgBackupDatabaseError, Me)
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

    Private Sub txtSeenList_Click(sender As Object, e As EventArgs) Handles txtSeenList.ClickButtonArea
        Tab.SelectedTab = tabSeenList
    End Sub

    Private Sub txtBlackList_Click(sender As Object, e As EventArgs) Handles txtBlackList.ClickButtonArea
        Tab.SelectedTab = tabBlackList
    End Sub

    'Tab Title Effects
    Private Sub txtWatchList_MouseMove(sender As Object, e As MouseEventArgs) Handles txtMovies.MouseMove, txtFavourites.MouseMove, txtWatchList.MouseMove, txtSeenList.MouseMove, txtBlackList.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub txtWatchList_MouseLeave(sender As Object, e As EventArgs) Handles txtMovies.MouseLeave, txtFavourites.MouseLeave, txtWatchList.MouseLeave, txtSeenList.MouseLeave, txtBlackList.MouseLeave
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
            GrabMovies(linkDatabase)
        Else
            GrabMovies(pathBackupDatabase)
        End If
        doBothFilters()
        Tab.SelectedTab = tabMovies
        ShowMoviesTimer.Enabled = False
    End Sub

    'Filter Functions
    Dim doFilterFunc As Boolean = True 'Stop the double function of filtering movies

    Private Sub filterGenreBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxGenre.SelectedIndexChanged
        If doFilterFunc = True Then
            Tab.SelectedTab = tabLoading
            cmboTextGenre.Text = cmboboxGenre.SelectedItem.ToString
            FilterGenreTimer.Enabled = True
        End If
        My.Settings.doFilterNum = cmboboxGenre.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub FilterGenreTimer_Tick(sender As Object, e As EventArgs) Handles FilterGenreTimer.Tick
        If txtboxSearch.Text = "" Then
            If cmboboxGenre.SelectedIndex = 0 Then
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
            If cmboboxGenre.SelectedIndex = 0 Then
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
                    If Not ab.Text.ToLower.Contains(txtboxSearch.Text.ToLower) Then
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
                    If Not ab.Text.ToLower.Contains(txtboxSearch.Text.ToLower) Then
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
                    If Not ab.Text.ToLower.Contains(cmboboxGenre.SelectedItem.ToString.ToLower) Then
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
                    If Not ab.Text.ToLower.Contains(cmboboxGenre.SelectedItem.ToString.ToLower) Then
                        a.Visible = False
                    End If
                End If
            Next
        Next
    End Sub

    Dim isUndoAll As Boolean = False

    'Search Movies Bar (All/Favourites/Watch List)
    Dim GoInactive As Boolean = True 'Keep search box inactive or not
    Dim doSearchMovies As Control = PanelMovies

    Private Sub txtboxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Tab.SelectedIndex = 0 Then
                If txtboxSearch.Text = "" Then
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
                timerSearchFavouritesList.Enabled = True
            ElseIf Tab.SelectedIndex = 2 Then
                Tab.SelectedTab = tabLoading
                timerSearchWatchList.Enabled = True
            ElseIf Tab.SelectedIndex = 3 Then
                Tab.SelectedTab = tabLoading
                timerSearchSeenList.Enabled = True
            ElseIf Tab.SelectedIndex = 4 Then
                Tab.SelectedTab = tabLoading
                timerSearchBlackList.Enabled = True
            End If
        End If
    End Sub

    Private Sub SearchMovies_Tick(sender As Object, e As EventArgs) Handles SearchMovies.Tick
        doFilterFunc = False
        doSortByFunc = False
        SearchClose.Visible = True
        cmboboxGenre.SelectedIndex = 0
        cmboboxSortBy.SelectedIndex = 0
        cmboTextGenre.Text = "Any Genre"
        SearchMoviesFnc()
        Tab.SelectedTab = tabMovies
        doFilterFunc = True
        doSortByFunc = True
        SearchMovies.Enabled = False
    End Sub

    Private Sub SearchFavourites_Tick(sender As Object, e As EventArgs) Handles timerSearchFavouritesList.Tick
        SearchFavouritesFunc()
        Tab.SelectedTab = tabFavourites
        timerSearchFavouritesList.Enabled = False
    End Sub

    Private Sub SearchWatchList_Tick(sender As Object, e As EventArgs) Handles timerSearchWatchList.Tick
        SearchWatchListFunc()
        Tab.SelectedTab = tabWatchList
        timerSearchWatchList.Enabled = False
    End Sub

    Private Sub SearchSeenList_Tick(sender As Object, e As EventArgs) Handles timerSearchSeenList.Tick
        SearchSeenListFunc()
        Tab.SelectedTab = tabSeenList
        timerSearchSeenList.Enabled = False
    End Sub

    Private Sub SearchBlackList_Tick(sender As Object, e As EventArgs) Handles timerSearchBlackList.Tick
        SearchBlackListFunc()
        Tab.SelectedTab = tabBlackList
        timerSearchBlackList.Enabled = False
    End Sub

    Private Sub ResetFilterGenre()
        For Each a As Control In PanelMovies.Controls
            a.Visible = True
        Next
    End Sub

    Private Sub ResetAllFilters()
        SearchboxInactive()
        cmboboxGenre.SelectedIndex = 0
        For Each a As Control In PanelMovies.Controls
            a.Visible = True
        Next
    End Sub

    Dim CloseSearch As Boolean = False

    Private Sub ResetFiltersTimer_Tick(sender As Object, e As EventArgs) Handles ResetFiltersTimer.Tick
        txtboxSearch.Text = ""
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
                    If Not ab.Text.ToLower.Contains(txtboxSearch.Text.ToLower) Then
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
                    If Not ab.Text.ToLower.Contains(txtboxSearch.Text.ToLower) Then
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
                    If Not ab.Text.ToLower.Contains(txtboxSearch.Text.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next

        If IfNone = 0 Then imgPanelsEmpty2.Visible = True Else imgPanelsEmpty2.Visible = False
    End Sub

    Public Sub SearchSeenListFunc()
        Dim IfNone As Integer = 0

        For Each a As Control In PanelSeenList.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoSearches" Then
                    If Not ab.Text.ToLower.Contains(txtboxSearch.Text.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next

        If IfNone = 0 Then imgPanelsEmpty3.Visible = True Else imgPanelsEmpty3.Visible = False
    End Sub

    Public Sub SearchBlackListFunc()
        Dim IfNone As Integer = 0

        For Each a As Control In PanelBlackList.Controls
            For Each ab As Control In a.Controls
                If ab.Name = "InfoSearches" Then
                    If Not ab.Text.ToLower.Contains(txtboxSearch.Text.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next

        If IfNone = 0 Then imgPanelsEmpty4.Visible = True Else imgPanelsEmpty4.Visible = False
    End Sub

    Private Sub TxtSearchBg_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles txtboxSearchBG.ClickButtonArea
        txtboxSearch.Focus()
    End Sub

    Private Sub SearchClose_Click(sender As Object, e As EventArgs) Handles SearchClose.Click
        If SearchboxIsActive = True Then
            GoToNextTab = 0
            SearchboxIsActive = False
            Tab.SelectedTab = tabLoading
            ResetFiltersTimer.Enabled = True
        Else
            txtboxSearch.Text = ""
            Refresh()
            Update()
            txtboxSearch.Refresh()
            txtboxSearch.Update()
        End If
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If txtboxSearch.Text = "" Then
            SearchClose.Visible = False
        Else
            SearchClose.Visible = True
        End If
    End Sub

    'Make Searchbox Inactive Colours
    Public Sub SearchboxInactive()
        txtboxSearch.Text = ""
        txtboxSearchBG.BorderColor = Color.FromArgb(161, 168, 179)
        TxtSearchIcon.Image = My.Resources.SearchIconL
    End Sub

    Public Sub SearchboxActive()
        txtboxSearchBG.BorderColor = Color.White
        TxtSearchIcon.Image = My.Resources.SearchIconH
    End Sub

    Private Sub cmboTextGenre_Click(sender As Object, e As EventArgs) Handles cmboTextGenre.ClickButtonArea
        cmboboxGenre.DroppedDown = True
    End Sub

    'Sort Movies

    Dim CurrentSortBy = 0
    Dim doSortByFunc As Boolean = True 'Stop the double function of sorting movies on startup

    Private Sub cmboTextSortBy_Click(sender As Object, e As EventArgs) Handles cmboTextSortBy.ClickButtonArea
        cmboboxSortBy.DroppedDown = True
    End Sub

    Private Sub cmboboxSortBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxSortBy.SelectedIndexChanged
        If doSortByFunc = True Then
            Tab.SelectedTab = tabLoading
            cmboTextSortBy.Text = cmboboxSortBy.SelectedItem.ToString
            CurrentSortBy = cmboboxSortBy.SelectedIndex
            SortByTimer.Enabled = True
        End If
    End Sub

    Private Sub SortByTimer_Tick(sender As Object, e As EventArgs) Handles SortByTimer.Tick
        SearchboxInactive()
        If CurrentSortBy = 0 Then
            If UseBackupDatabase = False Then
                GrabMovies(linkDatabase)
            Else
                GrabMovies(pathBackupDatabase)
            End If
        ElseIf CurrentSortBy = 1 Then
            SortByRating()
        ElseIf CurrentSortBy = 2 Then
            SortByYear()
        ElseIf CurrentSortBy = 3 Then
            SortByName()
        End If
        Tab.SelectedTab = tabMovies
        SortByTimer.Enabled = False
    End Sub

    Private Sub txtboxSearch_Enter(sender As Object, e As EventArgs) Handles txtboxSearch.Enter
        txtboxSearchBG.BorderColor = Color.White
        TxtSearchIcon.Image = My.Resources.SearchIconH
    End Sub

    Private Sub txtboxSearch_Leave(sender As Object, e As EventArgs) Handles txtboxSearch.Leave
        If Not Tab.SelectedIndex = 5 Then
            txtboxSearchBG.BorderColor = Color.FromArgb(161, 168, 179)
            TxtSearchIcon.Image = My.Resources.SearchIconL
        End If
    End Sub

    Private Sub SortByNewlyAdded()
        Try
            PanelMovies.Controls.Clear()
            Dim credentialsplitter As String = "~"
            Dim Items() As String = ContentToFilter4.Items.Cast(Of String).ToArray
            Array.Reverse(Items)
            Dim objDl = New WebClient()
            objDl.Proxy = Nothing

            For Each movieInItem As String In Items
                If Not movieInItem = "" Then
                    Dim MovieCredential As String() = Split(movieInItem, credentialsplitter)

                    Dim TitleAndYear As String = MovieCredential(0) + " (" + MovieCredential(1) + ")"

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    a.InfoTitle.Text = MovieCredential(0)
                    a.InfoYear.Text = MovieCredential(1)

                    Dim dstring = objDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text + "&tomatoes=true")
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

                    a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(poster)))
                    a.InfoMovieLink.Text = MovieCredential(2)
                    a.InfoBasic.Text = "☆ " + imdbrating + " • " + MovieCredential(1)
                    a.InfoSearches.Text = MovieCredential(0) + " " + MovieCredential(1) + " " + genre + " " + director + " " + stars
                    a.Show()

                    a.Name = MovieCredential(0).Replace(" ", "") + "(" + MovieCredential(1) + ")"

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

            For Each movieInItem As String In Items
                If Not movieInItem = "" Then
                    Dim MovieCredential As String() = Split(movieInItem, credentialsplitter)

                    Dim TitleAndYear As String = MovieCredential(1) + " (" + MovieCredential(2) + ")"

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    a.InfoTitle.Text = MovieCredential(1)
                    a.InfoYear.Text = MovieCredential(2)

                    Dim dstring = objDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text + "&tomatoes=true")
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

                    a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(poster)))
                    a.InfoMovieLink.Text = MovieCredential(3)
                    a.InfoBasic.Text = "☆ " + imdbrating + " • " + MovieCredential(2)
                    a.InfoSearches.Text = MovieCredential(1) + " " + MovieCredential(2) + " " + genre + " " + director + " " + stars
                    a.Show()

                    a.Name = MovieCredential(1).Replace(" ", "") + "(" + MovieCredential(2) + ")"

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

            For Each movieInItem As String In Items
                If Not movieInItem = "" Then
                    Dim MovieCredential As String() = Split(movieInItem, credentialsplitter)

                    Dim TitleAndYear As String = MovieCredential(1) + " (" + MovieCredential(0) + ")"

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    a.InfoTitle.Text = MovieCredential(1)
                    a.InfoYear.Text = MovieCredential(0)

                    Dim dstring = objDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text + "&tomatoes=true")
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

                    a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(poster)))
                    a.InfoMovieLink.Text = MovieCredential(2)
                    a.InfoBasic.Text = "☆ " + imdbrating + " • " + MovieCredential(1)
                    a.InfoSearches.Text = MovieCredential(0) + " " + MovieCredential(1) + " " + genre + " " + director + " " + stars
                    a.Show()

                    a.Name = MovieCredential(0).Replace(" ", "") + "(" + MovieCredential(1) + ")"

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
            "We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message and we'll get back to you as soon as. Sorry for the inconvenience.",
            Me)
        End Try
    End Sub

    Private Sub SortByName()
        Try
            PanelMovies.Controls.Clear()
            ContentToFilter2.Sorted = True
            Dim credentialsplitter As String = "~"
            Dim objDl = New WebClient()
            objDl.Proxy = Nothing
            For Each movieInItem As String In ContentToFilter2.Items
                If Not movieInItem = "" Then
                    Dim MovieCredential As String() = Split(movieInItem, credentialsplitter)

                    Dim TitleAndYear As String = MovieCredential(0) + " (" + MovieCredential(1) + ")"

                    Dim a As New ctrlPosterTitle
                    a.TopLevel = False
                    a.Hide()

                    a.InfoTitle.Text = MovieCredential(0)
                    a.InfoYear.Text = MovieCredential(1)

                    Dim dstring = objDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text + "&tomatoes=true")
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

                    a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(poster)))
                    a.InfoMovieLink.Text = MovieCredential(2)
                    a.InfoBasic.Text = "☆ " + imdbrating + " • " + MovieCredential(1)
                    a.InfoSearches.Text = MovieCredential(0) + " " + MovieCredential(1) + " " + genre + " " + director + " " + stars
                    a.Show()

                    a.Name = MovieCredential(0).Replace(" ", "") + "(" + MovieCredential(1) + ")"

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
            "We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message and we'll get back to you as soon as. Sorry for the inconvenience.",
            Me)
        End Try
    End Sub

    Public Sub doBothFilters()
        txtboxSearch.Text = ""

        For Each a As Control In PanelMovies.Controls
            For Each ab As Control In a.Controls
                a.Visible = True
            Next
        Next

        If Not cmboboxGenre.SelectedIndex = 0 Then
            FilterMoviesByGenre()
        End If
    End Sub

    'Hide Genre Filter and Sort By items for Tabs
    Private Sub HideExt()
        cmboboxGenre.Visible = False
        panelFilterBox.Visible = False
        fncSplitter0.Visible = False
        fncSplitter1.Visible = False
        cmboTextGenre.Enabled = False
        panelSortBy.Visible = False
    End Sub

    Private Sub ShowExt()
        cmboboxGenre.Visible = True
        panelFilterBox.Visible = True
        fncSplitter0.Visible = True
        fncSplitter1.Visible = True
        cmboTextGenre.Enabled = True
        panelSortBy.Visible = True
    End Sub

#End Region

#Region "Info Tabs"

    Public InfoSelectedTab As TabPage = frmInfo.tabAbout

    Public IsContextOpen As Boolean = False

    Private Sub btnInfoMenu_Click(sender As Object, e As EventArgs) Handles btnInfoMenu.Click
        'InfoSelectedTab = InfoTabs.TabContact
        'InfoTabs.Show(Me)
        ctrlInfoMenu.Location = New Point(btnInfoMenu.Location.X, btnInfoMenu.Location.Y + 28)
        btnInfoMenu.Image = My.Resources.DropletsIconBgH
        ctrlInfoMenu.Show()
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
            Dim request As HttpWebRequest = WebRequest.Create(linkLatestVersion)
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
