Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class Odeum_Movies


    'Preferences
    Public CurrentDatabase As String = "https://dl.dropbox.com/s/7rhzy2odzkal6tx/odeum-db.txt?dl=0"
    Public OdeumChangelog As String = "https://dl.dropbox.com/s/3514qygmbok1rvv/odeum-changelog.txt?dl=0"
    Public OdeumNotifications As String = "https://dl.dropbox.com/s/eqxi751t8z031na/odeum-notifications.txt?dl=0"
    Public LatestVersion As String = "https://dl.dropbox.com/s/n0lwh73gh15vpf5/latest-version.txt?dl=0"
    Public AutoUpdater As String = "https://dl.dropbox.com/s/aqouj2qgn7galjd/Odeum%20Movies%20Updater.exe?dl=0"
    Public ThisVersion As String = "Beta Build v" + Application.ProductVersion
    Public DownloadLocation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Odeum Movies\"
    Public UpdateNotificationText As String = "New version is available, get downloading now! - v"
    Public SearchboxWatermark As String = "Search movies, people, years..."
    Public TempUpdaterPath As String = Path.GetTempPath + "\Odeum Movies Updater.exe"
    Public UpdaterPath As String = Application.StartupPath + "\Odeum Movies Updater.exe"

    Private Sub Odeum_Movies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabs.SelectedTab = tabLoading 'Set to loading page
        'Set top left and maximised
        Enabled = False
        Top = 0
        Left = 0
        Height = Screen.PrimaryScreen.WorkingArea.Height
        Width = Screen.PrimaryScreen.WorkingArea.Width
        My.Settings.ToggleZoom = True 'Reset global property to normal size 
        TxtSearchBox.Watermark = SearchboxWatermark 'Set search bar watermark text
        LoadLists() 'Load movies in favourite/watch list/watched
        '#Delete the auto updater
        'If My.Computer.FileSystem.FileExists(TempUpdaterPath) Then
        'My.Computer.FileSystem.DeleteFile(TempUpdaterPath)
        'End If
        InfoTabs.LblVersion.Text = ThisVersion 'Set current version in ABOUT page
        If CheckForInternetConnection() = True Then 'Initiate internet required functions
            Show()
            'Show startup loading page
            StartupTab.Size = New Size(Size.Width, Size.Height - AppTitle.Size.Height - 3)
            StartupTab.Show(Me)
            StartupTab.Location = New Point(Location.X, Location.Y + AppTitle.Size.Height + 3)
            filterGenreBox.SelectedIndex = 0
            CurrentSortBy = BtnSortByNewlyAdded
            Tabs.SelectedTab = tabLoading
            Enabled = False
            Tabs.SelectedTab = tabLoading
            GetNotifications.Enabled = True
            GetUpdateNotification.Enabled = True
            StartupTimer.Enabled = True
        Else
            'Show error form on movies tab
            tabMovies.Controls.Remove(PanelMovies)
            Dim a As New TabPageError
            a.TopLevel = False
            a.Show()
            tabMovies.Controls.Add(a)
            a.Dock = DockStyle.Fill
            a.BringToFront()
            Tabs.SelectedTab = tabMovies
            Enabled = True
        End If
    End Sub

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

    Public Shared Function CheckForInternetConnection() As Boolean
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

    'Load & Save Favourites/Watch Lists/Watched
    Private Sub LoadLists()
        Dim MovieTitle1 As String = My.Settings.FavouriteItems
        If MovieTitle1 <> "" Then
            FavouriteMovies.Items.Clear()
            FavouriteMovies.Items.AddRange(MovieTitle1.Split("|"))
        End If

        Dim MovieTitle2 As String = My.Settings.WatchListItems
        If MovieTitle2 <> "" Then
            WatchListMovies.Items.Clear()
            WatchListMovies.Items.AddRange(MovieTitle2.Split("|"))
        End If

        Dim MovieTitle3 As String = My.Settings.WatchedItems
        If MovieTitle3 <> "" Then
            WatchedMovies.Items.Clear()
            WatchedMovies.Items.AddRange(MovieTitle3.Split("|"))
        End If

        Dim NotifItem As String = My.Settings.NotifNumbers
        If NotifItem <> "" Then
            NotifCheck.Items.Clear()
            NotifCheck.Items.AddRange(NotifItem.Split("|"))
        End If

    End Sub

    Private Sub SaveLists()
        My.Settings.IsImageError = False

        Dim MovieItems1 As New List(Of String)
        For Each MovieTitle1 As String In FavouriteMovies.Items
            MovieItems1.Add(MovieTitle1)
        Next
        My.Settings.FavouriteItems = String.Join("|", MovieItems1.ToArray)

        Dim MovieItems2 As New List(Of String)
        For Each MovieTitle2 As String In WatchListMovies.Items
            MovieItems2.Add(MovieTitle2)
        Next
        My.Settings.WatchListItems = String.Join("|", MovieItems2.ToArray)

        Dim MovieItems3 As New List(Of String)
        For Each MovieTitle3 As String In WatchedMovies.Items
            MovieItems3.Add(MovieTitle3)
        Next
        My.Settings.WatchedItems = String.Join("|", MovieItems3.ToArray)

        Dim NotifItem As New List(Of String)
        For Each NotifNumber As String In NotifCheck.Items
            NotifItem.Add(NotifNumber)
        Next
        My.Settings.NotifNumbers = String.Join("|", NotifItem.ToArray)

        My.Settings.Save()
    End Sub

    Private Sub Odeum_Movies_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveLists()
    End Sub

    Private Sub StartupTimer_Tick(sender As Object, e As EventArgs) Handles StartupTimer.Tick
        GrabMovies()
        Enabled = True
        Tabs.SelectedTab = tabMovies
        StartupTab.Close()
        StartupTimer.Enabled = False
    End Sub

    'Get if movie is not found in omdbapi
    Dim ErrorMovie As String = ""

    'Get movies, display in movies and both lists

    Public Sub GrabMovies()
        Try
            ContentToFilter3.Items.Clear()
            ContentToFilter1.Items.Clear()
            ContentToFilter2.Items.Clear()
            filterGenreBox.SelectedIndex = 0
            Tabs.SelectedTab = tabLoading
            TxtSearchBox.Text = "" 'Reset search bar text

            'Remove movies from panels
            PanelWatchList.Controls.Clear()
            PanelFavourites.Controls.Clear()
            PanelMovies.Controls.Clear()

            'Split data
            Dim DataSplitter As String = "~"

            Dim NetDl = New WebClient()
            NetDl.Proxy = Nothing
            Dim MoviesContent As String = NetDl.DownloadString(CurrentDatabase)
            Dim SplitMovies() As String = Split(MoviesContent, vbNewLine)

            For Each MovieOnLine As String In SplitMovies.Reverse
                If Not MovieOnLine = "" Then
                    Dim MovieCred As String() = Split(MovieOnLine, DataSplitter)

                    Dim a As New PosterTitle
                    a.TopLevel = False
                    a.Hide()

                    ErrorMovie = MovieCred(0)

                    a.InfoTitle.Text = MovieCred(0)
                    a.InfoYear.Text = MovieCred(1)

                    Dim dstring = NetDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text)
                    Dim dar = dstring.Split(Chr(34))
                    Dim time = dar(19)
                    Dim genre = dar(23)
                    Dim about = dar(39)
                    Dim rating = dar(63)
                    Dim director = dar(27)
                    Dim stars = dar(35)
                    Dim poster = dar(55)

                    a.InfoGenre.Text = genre
                    a.InfoDesc.Text = about
                    a.InfoDuration.Text = time
                    a.InfoRating.Text = rating
                    If a.InfoRating.Text.Contains("N/A") Then a.InfoRating.Text = rating.Replace("N/A", "0")
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoPosterLink.Text = poster

                    a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(NetDl.DownloadData(poster)))
                    a.InfoMovieLink.Text = MovieCred(2)
                    a.InfoBasic.Text = "☆ " + rating + " • " + MovieCred(1)
                    a.InfoSearches.Text = MovieCred(0) + " " + MovieCred(1) + " " + genre + " " + director + " " + stars
                    a.Show()
                    ContentToFilter3.Items.Add(a.InfoRating.Text + "~" + MovieCred(0) + "~" + MovieCred(1) + "~" + genre + "~" + time + "~" + about + "~" + poster + "~" + MovieCred(2))
                    ContentToFilter1.Items.Add(MovieCred(1) + "~" + MovieCred(0) + "~" + genre + "~" + time + "~" + about + "~" + poster + "~" + MovieCred(2))
                    ContentToFilter2.Items.Add(MovieCred(0) + "~" + MovieCred(1) + "~" + genre + "~" + time + "~" + about + "~" + poster + "~" + MovieCred(2))

                    PanelMovies.Controls.Add(a)


                    If FavouriteMovies.Items.Contains(MovieCred(0) + " (" + MovieCred(1) + ")") Then
                        AddMovieOnStartup(PanelFavourites, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                    End If

                    If WatchListMovies.Items.Contains(MovieCred(0) + " (" + MovieCred(1) + ")") Then
                        AddMovieOnStartup(PanelWatchList, a.InfoTitle.Text, a.InfoYear.Text, a.InfoGenre.Text, a.InfoDirector.Text, a.InfoStars.Text, a.InfoDesc.Text, a.InfoDuration.Text, a.InfoRating.Text, a.InfoPosterLink.Text, a.InfoMovieLink.Text)
                    End If
                End If
            Next
            MovieContent.Text = MoviesContent
        Catch ex As Exception
            StartupTimer.Enabled = False
            'Show error form on browse tab
            tabMovies.Controls.Remove(PanelMovies)
            Dim a As New TabPageError
            a.TopLevel = False
            a.Show()
            tabMovies.Controls.Add(a)
            a.Dock = DockStyle.Fill
            a.BringToFront()
            Tabs.SelectedTab = tabMovies
            Enabled = True
            'SendMail("Issue Loading Movies", ex.InnerException.Message)
            ShowPopupError("Oh no!", ErrorMovie +
            " We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message. Sorry for the inconvenience.")
        End Try
    End Sub

    'Add Movie to Favourites/Watch List - ON STARTUP (DOESN'T DUPLICATE ITEM IN LIST)
    Public Sub AddMovieOnStartup(AddToPanel As FlowLayoutPanel, Title As String, Year As String, Genre As String, Director As String, Stars As String, Description As String, Duration As String, Rating As String, PosterLink As String, MovieLink As String)
        Dim NetDl As New WebClient
        NetDl.Proxy = Nothing
        Dim tab As New PosterTitle
        tab.Hide()
        tab.TopLevel = False
        tab.InfoTitle.Text = Title
        tab.InfoYear.Text = Year
        tab.InfoGenre.Text = Genre
        tab.InfoDesc.Text = Description
        tab.InfoDuration.Text = Duration
        tab.InfoRating.Text = Rating
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
        Dim tab As New PosterTitle
        tab.Hide()
        tab.TopLevel = False
        tab.InfoTitle.Text = Title
        tab.InfoYear.Text = Year
        tab.InfoGenre.Text = Genre
        tab.InfoDesc.Text = Description
        tab.InfoDuration.Text = Duration
        tab.InfoRating.Text = Rating
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

    'Show Error Dialogs
    Public Sub ShowPopupError(Title As String, Message As String)
        PopupBackground.Show(Me)
        PopupError.DialogTitle.Text = Title
        PopupError.DialogMessage.Text = Message
        PopupError.Show(PopupBackground)
    End Sub

    'Send Messages via Email
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

    Public Function GetErrorCode(value As String) As String
        If value.Contains("404") Then
            Return "Oh no! It seems we're unable to locate our database :/"
        ElseIf value.Contains("403") Then
            Return "We've locked access to our database for the moment, as we're doing some adjustments. We won't take a moment."
        Else
            Return "Oh no!"
        End If
    End Function

    'Make Searchbox Inactive Colours
    Public Sub SearchboxInactive()
        TxtSearchBox.Text = ""
        TxtSearchBg.BorderColor = Color.FromArgb(161, 168, 179)
        TxtSearchIcon.Image = My.Resources.SearchIconL1
    End Sub

    Public Sub SearchboxActive()
        TxtSearchBg.BorderColor = Color.White
        TxtSearchIcon.Image = My.Resources.SearchIconH1
    End Sub

    'Switch Tabs
    Private Sub txtBrowse_Click(sender As Object, e As EventArgs) Handles txtMovies.ClickButtonArea
        Tabs.SelectedTab = tabMovies
    End Sub

    Private Sub txtFavourites_Click(sender As Object, e As EventArgs) Handles txtFavourites.ClickButtonArea
        Tabs.SelectedTab = tabFavourites
    End Sub

    Private Sub txtWatchList_Click(sender As Object, e As EventArgs) Handles txtWatchList.ClickButtonArea
        Tabs.SelectedTab = tabWatchList
    End Sub

    'Tab Title Effects
    Private Sub txtWatchList_MouseMove(sender As Object, e As MouseEventArgs) Handles txtWatchList.MouseMove, txtFavourites.MouseMove, txtMovies.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub txtWatchList_MouseLeave(sender As Object, e As EventArgs) Handles txtWatchList.MouseLeave, txtFavourites.MouseLeave, txtMovies.MouseLeave
        If Not Tabs.SelectedTab.Name.Replace("tab", "").Contains(sender.Text.ToString.Replace(" ", "")) Then
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

    'Selected Tabs
    Dim SelectedTab As String

    Dim SearchboxIsActive As Boolean = False
    Dim GoToNextTab As Integer = 0

    Private Sub appTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tabs.SelectedIndexChanged
        If Tabs.SelectedIndex = 0 Then
            ShowExt()
            SelectedTab = tabMovies.Name
            txtMovies.ForeColor = Color.White
            txtFavourites.ForeColor = Color.FromArgb(161, 168, 179)
            txtWatchList.ForeColor = Color.FromArgb(161, 168, 179)
        ElseIf Tabs.SelectedIndex = 1 Then
            HideExt()
            GoToNextTab = 1
            SelectedTab = tabFavourites.Name
            txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
            txtFavourites.ForeColor = Color.White
            txtWatchList.ForeColor = Color.FromArgb(161, 168, 179)

            If SearchboxIsActive = True Then
                SearchboxInactive()
                Tabs.SelectedTab = tabLoading
                Tabs.SelectedIndex = GoToNextTab
                ResetFiltersTimer.Enabled = True
            End If

            If PanelFavourites.Controls.Count = 0 Then
                TextEmpty1.Visible = True
            Else
                TextEmpty1.Visible = False
            End If
        ElseIf Tabs.SelectedIndex = 2 Then
            HideExt()
            GoToNextTab = 2
            SelectedTab = tabWatchList.Name
            txtMovies.ForeColor = Color.FromArgb(161, 168, 179)
            txtFavourites.ForeColor = Color.FromArgb(161, 168, 179)
            txtWatchList.ForeColor = Color.White

            If SearchboxIsActive = True Then
                SearchboxInactive()
                Tabs.SelectedTab = tabLoading
                Tabs.SelectedIndex = GoToNextTab
                ResetFiltersTimer.Enabled = True
            End If

            If PanelWatchList.Controls.Count = 0 Then
                TextEmpty2.Visible = True
            Else
                TextEmpty2.Visible = False
            End If

        ElseIf Tabs.SelectedIndex = 3 Then
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

    'Filter Functions
    Private Sub filterGenreBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterGenreBox.SelectedIndexChanged
        Tabs.SelectedTab = tabLoading
        BoxText.Text = filterGenreBox.SelectedItem.ToString
        FilterGenreTimer.Enabled = True
    End Sub

    Private Sub FilterGenreTimer_Tick(sender As Object, e As EventArgs) Handles FilterGenreTimer.Tick
        If TxtSearchBox.Text = "" Then
            ResetFilterGenre()
            FilterMoviesByGenre()
            Tabs.SelectedTab = tabMovies
            FilterGenreTimer.Enabled = False
        Else
            FilterAndSearchMovies()
            Tabs.SelectedTab = tabMovies
            FilterGenreTimer.Enabled = False
        End If
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
                    If ab.Text.ToLower.Contains(filterGenreBox.SelectedItem.ToString.ToLower) Then
                        a.Visible = False
                    Else
                        IfNone = IfNone + 1
                    End If
                End If
            Next
        Next

        If IfNone = 0 Then TextEmpty0.Visible = True Else TextEmpty0.Visible = False
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
            If Tabs.SelectedIndex = 0 Then
                If TxtSearchBox.Text = "" Then
                    SearchboxInactive()
                    SearchboxIsActive = False
                    GoToNextTab = 0
                    Tabs.SelectedTab = tabLoading
                    ResetFiltersTimer.Enabled = True
                Else
                    SearchboxActive()
                    SearchboxIsActive = True
                    Tabs.SelectedTab = tabLoading
                    SearchMovies.Enabled = True
                End If
            ElseIf Tabs.SelectedIndex = 1 Then
                Tabs.SelectedTab = tabLoading
                SearchFavourites.Enabled = True
            ElseIf Tabs.SelectedIndex = 2 Then
                Tabs.SelectedTab = tabLoading
                SearchWatchList.Enabled = True
            End If
        End If
    End Sub

    Private Sub SearchMovies_Tick(sender As Object, e As EventArgs) Handles SearchMovies.Tick
        SearchClose.Visible = True
        filterGenreBox.SelectedIndex = 0
        SearchMoviesFnc()
        Tabs.SelectedTab = tabMovies
        SearchMovies.Enabled = False
    End Sub

    Private Sub SearchFavourites_Tick(sender As Object, e As EventArgs) Handles SearchFavourites.Tick
        SearchFavouritesFunc()
        Tabs.SelectedTab = tabFavourites
        SearchFavourites.Enabled = False
    End Sub

    Private Sub SearchWatchList_Tick(sender As Object, e As EventArgs) Handles SearchWatchList.Tick
        SearchWatchListFunc()
        Tabs.SelectedTab = tabWatchList
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
        Tabs.SelectedIndex = GoToNextTab
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

        If IfNone = 0 Then TextEmpty0.Visible = True Else TextEmpty0.Visible = False
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

        If IfNone = 0 Then TextEmpty1.Visible = True Else TextEmpty1.Visible = False
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

        If IfNone = 0 Then TextEmpty2.Visible = True Else TextEmpty2.Visible = False
    End Sub

    Private Sub TxtSearchBg_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles TxtSearchBg.ClickButtonArea
        TxtSearchBox.Focus()
    End Sub

    Private Sub SearchClose_Click(sender As Object, e As EventArgs) Handles SearchClose.Click
        If SearchboxIsActive = True Then
            GoToNextTab = 0
            SearchboxIsActive = False
            Tabs.SelectedTab = tabLoading
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

    'Window control box (Close, Maximize, Minimize)
    Private Sub appExpand_MouseMove(sender As Object, e As MouseEventArgs) Handles AppMaximize.MouseMove
        AppMaximize.Image = My.Resources.MaximiseAppH
    End Sub

    Private Sub appExpand_MouseLeave(sender As Object, e As EventArgs) Handles AppMaximize.MouseLeave
        AppMaximize.Image = My.Resources.MaximiseApp
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
        AppMinimize.Image = My.Resources.MinimiseApp
    End Sub

    Private Sub appMin_Click(sender As Object, e As EventArgs) Handles AppMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As MouseEventArgs) Handles AppExit.MouseMove
        AppExit.Image = My.Resources.CloseAppH
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles AppExit.MouseLeave
        AppExit.Image = My.Resources.CloseApp
    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles AppExit.Click
        Application.Exit()
    End Sub

    Private Sub ShowMoviesTimer_Tick(sender As Object, e As EventArgs) Handles ShowMoviesTimer.Tick
        GrabMovies()
        doallfilters()
        Tabs.SelectedTab = tabMovies
        ShowMoviesTimer.Enabled = False
    End Sub

    Private Sub btnDeveloper_Click(sender As Object, e As EventArgs)
        Process.Start("www.zeduc.cf")
    End Sub

    Public InfoSelectedTab As TabPage = InfoTabs.TabAbout

    Private Sub btnChangelog_Click(sender As Object, e As EventArgs) Handles btnChangelog.Click
        InfoSelectedTab = InfoTabs.TabChangelog
        InfoTabs.Show(Me)
    End Sub

    Private Sub btnFAQ_Click(sender As Object, e As EventArgs) Handles btnFAQ.Click
        InfoSelectedTab = InfoTabs.TabHelpFaq
        InfoTabs.Show(Me)
    End Sub

    Private Sub SendFeedback_Click(sender As Object, e As EventArgs) Handles BtnSendFeedback.Click
        InfoSelectedTab = InfoTabs.TabContact
        InfoTabs.Show(Me)
    End Sub

    Private Sub LayoutFaves_ControlAdded(sender As Object, e As ControlEventArgs) Handles PanelFavourites.ControlAdded
        If PanelFavourites.Controls.Count = 0 Then
            TextEmpty1.Visible = True
        Else
            TextEmpty1.Visible = False
        End If
    End Sub

    Private Sub LayoutFaves_ControlRemoved(sender As Object, e As ControlEventArgs) Handles PanelFavourites.ControlRemoved
        If PanelFavourites.Controls.Count = 0 Then
            TextEmpty1.Visible = True
        Else
            TextEmpty1.Visible = False
        End If
    End Sub

    Private Sub Odeum_Movies_KeyDown(sender As Object, e As KeyEventArgs) Handles Tabs.KeyDown
        e.Handled = True
    End Sub

    Private Sub GetUpdateNotification_Tick(sender As Object, e As EventArgs) Handles GetUpdateNotification.Tick
        Try
            Dim request As System.Net.HttpWebRequest = WebRequest.Create(LatestVersion)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion

            If Not newestversion.Contains(currentversion) Then
                Dim a As New UpdateNotification
                a.LblNotification.Text = UpdateNotificationText + newestversion
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

    Private Sub BoxText_Click(sender As Object, e As EventArgs) Handles BoxText.ClickButtonArea
        filterGenreBox.DroppedDown = True
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

                    Dim a As New PosterTitle
                    a.TopLevel = False
                    a.Hide()
                    a.InfoTitle.Text = credentials(1)
                    a.InfoYear.Text = credentials(2)

                    Dim dstring = objDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text)
                    Dim dar = dstring.Split(Chr(34))
                    Dim time = dar(19)
                    Dim genre = dar(23)
                    Dim about = dar(39)
                    Dim rating = dar(63)
                    Dim director = dar(27)
                    Dim stars = dar(35)
                    Dim poster = dar(55)

                    a.InfoGenre.Text = genre
                    a.InfoDesc.Text = about
                    a.InfoDuration.Text = time
                    a.InfoRating.Text = rating
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoPosterLink.Text = poster
                    Try
                        a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(poster)))
                    Catch ex As Exception
                        a.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
                        My.Settings.IsImageError = True
                    End Try
                    a.InfoBasic.Text = "☆ " + rating + " • " + credentials(1)
                    a.InfoMovieLink.Text = credentials(2)
                    a.InfoSearches.Text = credentials(1) + " " + credentials(2) + " " + genre + " " + director + " " + stars
                    a.Show()
                    PanelMovies.Controls.Add(a)
                End If
            Next
        Catch ex As Exception
            SendMail("Issue", ex.Message)
            ShowPopupError("Oh no!",
            "We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message and we'll get back to you as soon as. Sorry for the inconvenience.")
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

                    Dim a As New PosterTitle
                    a.TopLevel = False
                    a.Hide()
                    a.InfoTitle.Text = credentials(1)
                    a.InfoYear.Text = credentials(0)

                    Dim dstring = objDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text)
                    Dim dar = dstring.Split(Chr(34))
                    Dim time = dar(19)
                    Dim genre = dar(23)
                    Dim about = dar(39)
                    Dim rating = dar(63)
                    Dim director = dar(27)
                    Dim stars = dar(35)
                    Dim poster = dar(55)

                    a.InfoGenre.Text = genre
                    a.InfoDesc.Text = about
                    a.InfoDuration.Text = time
                    a.InfoRating.Text = rating
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoPosterLink.Text = poster
                    Try
                        a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(poster)))
                    Catch ex As Exception
                        a.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
                        My.Settings.IsImageError = True
                    End Try
                    a.InfoBasic.Text = "☆ " + rating + " • " + a.InfoYear.Text
                    a.InfoMovieLink.Text = credentials(2)
                    a.InfoSearches.Text = a.InfoTitle.Text + " " + a.InfoYear.Text + " " + genre + " " + director + " " + stars
                    a.Show()
                    PanelMovies.Controls.Add(a)
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

                    Dim a As New PosterTitle
                    a.TopLevel = False
                    a.Hide()
                    a.InfoTitle.Text = credentials(0)
                    a.InfoYear.Text = credentials(1)

                    Dim dstring = objDl.DownloadString("http://www.omdbapi.com/?t=" & a.InfoTitle.Text & "&y=" & a.InfoYear.Text)
                    Dim dar = dstring.Split(Chr(34))
                    Dim time = dar(19)
                    Dim genre = dar(23)
                    Dim about = dar(39)
                    Dim rating = dar(63)
                    Dim director = dar(27)
                    Dim stars = dar(35)
                    Dim poster = dar(55)

                    a.InfoGenre.Text = genre
                    a.InfoDesc.Text = about
                    a.InfoDuration.Text = time
                    a.InfoRating.Text = rating
                    a.InfoDirector.Text = director
                    a.InfoStars.Text = stars
                    a.InfoPosterLink.Text = poster
                    Try
                        a.InfoPoster.BackgroundImage = New Bitmap(New MemoryStream(objDl.DownloadData(poster)))
                    Catch ex As Exception
                        a.InfoPoster.BackgroundImage = My.Resources.MovieErrorImage
                        My.Settings.IsImageError = True
                    End Try
                    a.InfoBasic.Text = "☆ " + rating + " • " + credentials(1)
                    a.InfoMovieLink.Text = credentials(2)
                    a.InfoSearches.Text = credentials(0) + " " + credentials(1) + " " + genre + " " + director + " " + stars
                    a.Show()
                    PanelMovies.Controls.Add(a)
                End If
            Next
        Catch ex As Exception
            SendMail("Issue", ex.Message)
            ShowPopupError("Oh no!",
            "We've bumped into an issue loading movies, information on your issue has been sent to us - until then you can send us a message and we'll get back to you as soon as. Sorry for the inconvenience.")
        End Try
    End Sub

    Private Sub TopRight_MouseMove(sender As Object, e As MouseEventArgs) Handles btnFAQ.MouseMove, btnChangelog.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub TopRight_MouseLeave(sender As Object, e As EventArgs) Handles btnFAQ.MouseLeave, btnChangelog.MouseLeave
        sender.ForeColor = Color.FromArgb(166, 166, 166)
    End Sub

    Public Sub doallfilters()
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

    Private Sub GetNotifications_Tick(sender As Object, e As EventArgs) Handles GetNotifications.Tick
        Try
            Dim objDl As New WebClient
            Dim NotificationDb As String = objDl.DownloadString(OdeumNotifications)
            Dim LineByLine() As String = Split(NotificationDb, vbNewLine) 'Split db into lines

            For Each MessageText As String In LineByLine.Reverse
                Dim NotifText As String() = Split(MessageText, "|") 'Split text line into Number & Message
                If Not MessageText = "" Then 'If message isn't blank
                    If Not NotifCheck.Items.Contains(NotifText(0)) Then 'If user has seen the notification 
                        Dim a As New MessageNotification
                        a.LblNotifNumber.Text = NotifText(0)
                        a.LblNotification.Text = NotifText(1) 'Set text to current message text retrieved
                        a.Dock = DockStyle.Top
                        a.TopLevel = False
                        a.Show()
                        tabMovies.Controls.Add(a)
                    End If
                End If
            Next
            GetNotifications.Enabled = False
        Catch ex As Exception
            GetNotifications.Enabled = False
        End Try
    End Sub

    Private Sub SendFeedback_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSendFeedback.MouseMove
        BtnSendFeedback.Image = My.Resources.FeedbackH
    End Sub

    Private Sub SendFeedback_MouseLeave(sender As Object, e As EventArgs) Handles BtnSendFeedback.MouseLeave
        BtnSendFeedback.Image = My.Resources.FeedbackL2
    End Sub

    Private Sub PanelMovies_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelMovies.Scroll
        PanelMovies.Update()
    End Sub

    Private Sub PanelWatchList_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelWatchList.Scroll
        PanelWatchList.Update()
    End Sub

    Private Sub PanelFavourites_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelFavourites.Scroll
        PanelFavourites.Update()
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

    Dim CurrentSortBy

    Private Sub SortByAZ_Click(sender As Object, e As EventArgs) Handles BtnSortByYearReleased.Click, BtnSortByPopularity.Click, BtnSortByNewlyAdded.Click, BtnSortByAZ.Click
        If Not sender.name = CurrentSortBy.name Then
            Tabs.SelectedTab = tabLoading
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
        If CurrentSortBy.Name = BtnSortByNewlyAdded.Name Then
            GrabMovies()
        ElseIf CurrentSortBy.Name = BtnSortByPopularity.Name Then
            SortByRating()
        ElseIf CurrentSortBy.Name = BtnSortByYearReleased.Name Then
            SortByYear()
        ElseIf CurrentSortBy.Name = BtnSortByAZ.Name Then
            SortByName()
        End If
        Tabs.SelectedTab = tabMovies
        SortByTimer.Enabled = False
    End Sub

    Private Sub txtboxSearch_Enter(sender As Object, e As EventArgs) Handles TxtSearchBox.Enter
        TxtSearchBg.BorderColor = Color.White
        TxtSearchIcon.Image = My.Resources.SearchIconH1
    End Sub

    Private Sub txtboxSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearchBox.Leave
        If Not Tabs.SelectedIndex = 4 Then
            TxtSearchBg.BorderColor = Color.FromArgb(161, 168, 179)
            TxtSearchIcon.Image = My.Resources.SearchIconL1
        End If
    End Sub


    'Hide Filter and Sort By items
    Private Sub HideExt()
        BoxText.Visible = False
        FncSplitter.Visible = False
        BtnSortByAZ.Visible = False
        BtnSortByNewlyAdded.Visible = False
        BtnSortByPopularity.Visible = False
        BtnSortByYearReleased.Visible = False
    End Sub

    Private Sub ShowExt()
        BoxText.Visible = True
        FncSplitter.Visible = True
        BtnSortByAZ.Visible = True
        BtnSortByNewlyAdded.Visible = True
        BtnSortByPopularity.Visible = True
        BtnSortByYearReleased.Visible = True
    End Sub

End Class
