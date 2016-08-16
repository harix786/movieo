<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Odeum_Movies
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Odeum_Movies))
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.tabMovies = New System.Windows.Forms.TabPage()
        Me.PanelMovies = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabFavourites = New System.Windows.Forms.TabPage()
        Me.TextEmpty1 = New System.Windows.Forms.PictureBox()
        Me.PanelFavourites = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabWatchList = New System.Windows.Forms.TabPage()
        Me.TextEmpty2 = New System.Windows.Forms.PictureBox()
        Me.PanelWatchList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLoading = New System.Windows.Forms.TabPage()
        Me.NotifCheck = New System.Windows.Forms.ListBox()
        Me.WatchListMovies = New System.Windows.Forms.ListBox()
        Me.WatchedMovies = New System.Windows.Forms.ListBox()
        Me.FavouriteMovies = New System.Windows.Forms.ListBox()
        Me.MovieContent = New System.Windows.Forms.RichTextBox()
        Me.CButton1 = New CButtonLib.CButton()
        Me.tabSearchResults = New System.Windows.Forms.TabPage()
        Me.TextEmpty0 = New System.Windows.Forms.Label()
        Me.PanelSearchResultsText = New System.Windows.Forms.FlowLayoutPanel()
        Me.LblShowingResultsFor = New System.Windows.Forms.Label()
        Me.LblSearchResultsText = New System.Windows.Forms.Label()
        Me.PanelSearchResults = New System.Windows.Forms.FlowLayoutPanel()
        Me.SearchResultsClose = New System.Windows.Forms.PictureBox()
        Me.BgPanel = New System.Windows.Forms.Panel()
        Me.BoxText = New CButtonLib.CButton()
        Me.filterGenreBox = New System.Windows.Forms.ComboBox()
        Me.btnFAQ = New System.Windows.Forms.Label()
        Me.TextUseBrowseTab = New System.Windows.Forms.Label()
        Me.AppTitle = New System.Windows.Forms.Label()
        Me.StartupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FilterGenreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SearchMovies = New System.Windows.Forms.Timer(Me.components)
        Me.ShowMoviesTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GetUpdateNotification = New System.Windows.Forms.Timer(Me.components)
        Me.SortByTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ContentToFilter1 = New System.Windows.Forms.ListBox()
        Me.ContentToFilter2 = New System.Windows.Forms.ListBox()
        Me.PanelTabTitles = New System.Windows.Forms.Panel()
        Me.SearchClose = New System.Windows.Forms.PictureBox()
        Me.FncSplitter = New CButtonLib.CButton()
        Me.TxtSearchIcon = New System.Windows.Forms.PictureBox()
        Me.TxtSearchBox = New Odeum.RtfExtensions()
        Me.TxtSearchBg = New CButtonLib.CButton()
        Me.BtnSortByYearReleased = New CButtonLib.CButton()
        Me.BtnSortByAZ = New CButtonLib.CButton()
        Me.BtnSortByNewlyAdded = New CButtonLib.CButton()
        Me.BtnSortByPopularity = New CButtonLib.CButton()
        Me.txtWatchList = New CButtonLib.CButton()
        Me.txtFavourites = New CButtonLib.CButton()
        Me.txtMovies = New CButtonLib.CButton()
        Me.GetNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.ContentToFilter3 = New System.Windows.Forms.ListBox()
        Me.PanelTopRight = New System.Windows.Forms.FlowLayoutPanel()
        Me.AppExit = New System.Windows.Forms.PictureBox()
        Me.AppMaximize = New System.Windows.Forms.PictureBox()
        Me.AppMinimize = New System.Windows.Forms.PictureBox()
        Me.btnChangelog = New System.Windows.Forms.Label()
        Me.SearchFavourites = New System.Windows.Forms.Timer(Me.components)
        Me.SearchWatchList = New System.Windows.Forms.Timer(Me.components)
        Me.FilterSearchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ResetFiltersTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSendFeedback = New System.Windows.Forms.PictureBox()
        Me.icoLoadingWeb = New System.Windows.Forms.PictureBox()
        Me.Tabs.SuspendLayout()
        Me.tabMovies.SuspendLayout()
        Me.tabFavourites.SuspendLayout()
        CType(Me.TextEmpty1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWatchList.SuspendLayout()
        CType(Me.TextEmpty2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLoading.SuspendLayout()
        Me.tabSearchResults.SuspendLayout()
        Me.PanelSearchResultsText.SuspendLayout()
        CType(Me.SearchResultsClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BgPanel.SuspendLayout()
        Me.PanelTabTitles.SuspendLayout()
        CType(Me.SearchClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTopRight.SuspendLayout()
        CType(Me.AppExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSendFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs.CausesValidation = False
        Me.Tabs.Controls.Add(Me.tabMovies)
        Me.Tabs.Controls.Add(Me.tabFavourites)
        Me.Tabs.Controls.Add(Me.tabWatchList)
        Me.Tabs.Controls.Add(Me.tabLoading)
        Me.Tabs.Controls.Add(Me.tabSearchResults)
        Me.Tabs.Location = New System.Drawing.Point(-25, 68)
        Me.Tabs.Multiline = True
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(1322, 680)
        Me.Tabs.TabIndex = 1000
        Me.Tabs.TabStop = False
        '
        'tabMovies
        '
        Me.tabMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabMovies.Controls.Add(Me.PanelMovies)
        Me.tabMovies.Location = New System.Drawing.Point(23, 4)
        Me.tabMovies.Margin = New System.Windows.Forms.Padding(0)
        Me.tabMovies.Name = "tabMovies"
        Me.tabMovies.Padding = New System.Windows.Forms.Padding(2)
        Me.tabMovies.Size = New System.Drawing.Size(1295, 672)
        Me.tabMovies.TabIndex = 0
        Me.tabMovies.Text = "tabBrowse"
        '
        'PanelMovies
        '
        Me.PanelMovies.AutoScroll = True
        Me.PanelMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelMovies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMovies.Location = New System.Drawing.Point(2, 2)
        Me.PanelMovies.Name = "PanelMovies"
        Me.PanelMovies.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelMovies.Size = New System.Drawing.Size(1291, 668)
        Me.PanelMovies.TabIndex = 9
        '
        'tabFavourites
        '
        Me.tabFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabFavourites.Controls.Add(Me.TextEmpty1)
        Me.tabFavourites.Controls.Add(Me.PanelFavourites)
        Me.tabFavourites.Location = New System.Drawing.Point(23, 4)
        Me.tabFavourites.Name = "tabFavourites"
        Me.tabFavourites.Size = New System.Drawing.Size(1295, 672)
        Me.tabFavourites.TabIndex = 3
        Me.tabFavourites.Text = "t"
        '
        'TextEmpty1
        '
        Me.TextEmpty1.BackColor = System.Drawing.Color.Transparent
        Me.TextEmpty1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextEmpty1.Image = Global.Odeum.My.Resources.Resources.Add_Movies_to_Favourites
        Me.TextEmpty1.Location = New System.Drawing.Point(115, 0)
        Me.TextEmpty1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextEmpty1.Name = "TextEmpty1"
        Me.TextEmpty1.Size = New System.Drawing.Size(433, 156)
        Me.TextEmpty1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TextEmpty1.TabIndex = 100002
        Me.TextEmpty1.TabStop = False
        '
        'PanelFavourites
        '
        Me.PanelFavourites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelFavourites.AutoScroll = True
        Me.PanelFavourites.BackColor = System.Drawing.Color.Transparent
        Me.PanelFavourites.Location = New System.Drawing.Point(3, 3)
        Me.PanelFavourites.Name = "PanelFavourites"
        Me.PanelFavourites.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelFavourites.Size = New System.Drawing.Size(1290, 666)
        Me.PanelFavourites.TabIndex = 2
        '
        'tabWatchList
        '
        Me.tabWatchList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabWatchList.Controls.Add(Me.TextEmpty2)
        Me.tabWatchList.Controls.Add(Me.PanelWatchList)
        Me.tabWatchList.Location = New System.Drawing.Point(23, 4)
        Me.tabWatchList.Name = "tabWatchList"
        Me.tabWatchList.Size = New System.Drawing.Size(1295, 672)
        Me.tabWatchList.TabIndex = 6
        Me.tabWatchList.Text = "tabWatchList"
        '
        'TextEmpty2
        '
        Me.TextEmpty2.BackColor = System.Drawing.Color.Transparent
        Me.TextEmpty2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextEmpty2.Image = Global.Odeum.My.Resources.Resources.Add_Movies_to_Favourites
        Me.TextEmpty2.Location = New System.Drawing.Point(115, 0)
        Me.TextEmpty2.Margin = New System.Windows.Forms.Padding(0)
        Me.TextEmpty2.Name = "TextEmpty2"
        Me.TextEmpty2.Size = New System.Drawing.Size(433, 156)
        Me.TextEmpty2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TextEmpty2.TabIndex = 100003
        Me.TextEmpty2.TabStop = False
        '
        'PanelWatchList
        '
        Me.PanelWatchList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelWatchList.AutoScroll = True
        Me.PanelWatchList.BackColor = System.Drawing.Color.Transparent
        Me.PanelWatchList.Location = New System.Drawing.Point(3, 3)
        Me.PanelWatchList.Name = "PanelWatchList"
        Me.PanelWatchList.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelWatchList.Size = New System.Drawing.Size(1290, 666)
        Me.PanelWatchList.TabIndex = 3
        '
        'tabLoading
        '
        Me.tabLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLoading.Controls.Add(Me.NotifCheck)
        Me.tabLoading.Controls.Add(Me.WatchListMovies)
        Me.tabLoading.Controls.Add(Me.WatchedMovies)
        Me.tabLoading.Controls.Add(Me.FavouriteMovies)
        Me.tabLoading.Controls.Add(Me.MovieContent)
        Me.tabLoading.Controls.Add(Me.CButton1)
        Me.tabLoading.Location = New System.Drawing.Point(23, 4)
        Me.tabLoading.Name = "tabLoading"
        Me.tabLoading.Size = New System.Drawing.Size(1295, 672)
        Me.tabLoading.TabIndex = 5
        Me.tabLoading.Text = "tabLoading"
        '
        'NotifCheck
        '
        Me.NotifCheck.FormattingEnabled = True
        Me.NotifCheck.Location = New System.Drawing.Point(396, 175)
        Me.NotifCheck.Name = "NotifCheck"
        Me.NotifCheck.Size = New System.Drawing.Size(120, 95)
        Me.NotifCheck.TabIndex = 26
        Me.NotifCheck.Visible = False
        '
        'WatchListMovies
        '
        Me.WatchListMovies.FormattingEnabled = True
        Me.WatchListMovies.Location = New System.Drawing.Point(674, 176)
        Me.WatchListMovies.Name = "WatchListMovies"
        Me.WatchListMovies.Size = New System.Drawing.Size(120, 95)
        Me.WatchListMovies.TabIndex = 25
        Me.WatchListMovies.Visible = False
        '
        'WatchedMovies
        '
        Me.WatchedMovies.FormattingEnabled = True
        Me.WatchedMovies.Location = New System.Drawing.Point(535, 175)
        Me.WatchedMovies.Name = "WatchedMovies"
        Me.WatchedMovies.Size = New System.Drawing.Size(120, 95)
        Me.WatchedMovies.TabIndex = 24
        Me.WatchedMovies.Visible = False
        '
        'FavouriteMovies
        '
        Me.FavouriteMovies.FormattingEnabled = True
        Me.FavouriteMovies.Location = New System.Drawing.Point(138, 175)
        Me.FavouriteMovies.Name = "FavouriteMovies"
        Me.FavouriteMovies.Size = New System.Drawing.Size(120, 95)
        Me.FavouriteMovies.TabIndex = 22
        Me.FavouriteMovies.Visible = False
        '
        'MovieContent
        '
        Me.MovieContent.Location = New System.Drawing.Point(279, 175)
        Me.MovieContent.Name = "MovieContent"
        Me.MovieContent.Size = New System.Drawing.Size(100, 96)
        Me.MovieContent.TabIndex = 23
        Me.MovieContent.Text = ""
        Me.MovieContent.Visible = False
        '
        'CButton1
        '
        Me.CButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CButton1.BackColor = System.Drawing.Color.Transparent
        Me.CButton1.BorderColor = System.Drawing.Color.White
        Me.CButton1.BorderShow = False
        Me.CButton1.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton1.DesignerSelected = False
        Me.CButton1.DimFactorClick = 0
        Me.CButton1.DimFactorHover = 0
        Me.CButton1.FillType = CButtonLib.CButton.eFillType.Solid
        Me.CButton1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.CButton1.ImageIndex = 0
        Me.CButton1.Location = New System.Drawing.Point(396, 73)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.CButton1.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CButton1.SideImageSize = New System.Drawing.Size(17, 18)
        Me.CButton1.Size = New System.Drawing.Size(503, 30)
        Me.CButton1.TabIndex = 6
        Me.CButton1.Text = "Please wait, we're loading your movies..."
        Me.CButton1.TextShadow = System.Drawing.Color.White
        Me.CButton1.TextShadowShow = False
        '
        'tabSearchResults
        '
        Me.tabSearchResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSearchResults.Controls.Add(Me.TextEmpty0)
        Me.tabSearchResults.Controls.Add(Me.PanelSearchResultsText)
        Me.tabSearchResults.Controls.Add(Me.PanelSearchResults)
        Me.tabSearchResults.Controls.Add(Me.SearchResultsClose)
        Me.tabSearchResults.Location = New System.Drawing.Point(23, 4)
        Me.tabSearchResults.Name = "tabSearchResults"
        Me.tabSearchResults.Size = New System.Drawing.Size(1295, 672)
        Me.tabSearchResults.TabIndex = 7
        Me.tabSearchResults.Text = "tabSearchResults"
        '
        'TextEmpty0
        '
        Me.TextEmpty0.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEmpty0.BackColor = System.Drawing.Color.Transparent
        Me.TextEmpty0.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmpty0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.TextEmpty0.Location = New System.Drawing.Point(85, 80)
        Me.TextEmpty0.Name = "TextEmpty0"
        Me.TextEmpty0.Size = New System.Drawing.Size(1124, 56)
        Me.TextEmpty0.TabIndex = 10003
        Me.TextEmpty0.Text = "No movies found..."
        Me.TextEmpty0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TextEmpty0.Visible = False
        '
        'PanelSearchResultsText
        '
        Me.PanelSearchResultsText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSearchResultsText.Controls.Add(Me.LblShowingResultsFor)
        Me.PanelSearchResultsText.Controls.Add(Me.LblSearchResultsText)
        Me.PanelSearchResultsText.Location = New System.Drawing.Point(10, 12)
        Me.PanelSearchResultsText.Name = "PanelSearchResultsText"
        Me.PanelSearchResultsText.Size = New System.Drawing.Size(1250, 35)
        Me.PanelSearchResultsText.TabIndex = 4
        '
        'LblShowingResultsFor
        '
        Me.LblShowingResultsFor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblShowingResultsFor.AutoSize = True
        Me.LblShowingResultsFor.BackColor = System.Drawing.Color.Transparent
        Me.LblShowingResultsFor.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.LblShowingResultsFor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.LblShowingResultsFor.Location = New System.Drawing.Point(0, 0)
        Me.LblShowingResultsFor.Margin = New System.Windows.Forms.Padding(0)
        Me.LblShowingResultsFor.Name = "LblShowingResultsFor"
        Me.LblShowingResultsFor.Size = New System.Drawing.Size(189, 28)
        Me.LblShowingResultsFor.TabIndex = 10000
        Me.LblShowingResultsFor.Text = "Showing results for"
        Me.LblShowingResultsFor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSearchResultsText
        '
        Me.LblSearchResultsText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSearchResultsText.AutoSize = True
        Me.LblSearchResultsText.BackColor = System.Drawing.Color.Transparent
        Me.LblSearchResultsText.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.LblSearchResultsText.ForeColor = System.Drawing.Color.White
        Me.LblSearchResultsText.Location = New System.Drawing.Point(189, 0)
        Me.LblSearchResultsText.Margin = New System.Windows.Forms.Padding(0)
        Me.LblSearchResultsText.Name = "LblSearchResultsText"
        Me.LblSearchResultsText.Size = New System.Drawing.Size(150, 28)
        Me.LblSearchResultsText.TabIndex = 10001
        Me.LblSearchResultsText.Text = "Search Bar Text"
        Me.LblSearchResultsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelSearchResults
        '
        Me.PanelSearchResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSearchResults.AutoScroll = True
        Me.PanelSearchResults.BackColor = System.Drawing.Color.Transparent
        Me.PanelSearchResults.Location = New System.Drawing.Point(2, 52)
        Me.PanelSearchResults.Name = "PanelSearchResults"
        Me.PanelSearchResults.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelSearchResults.Size = New System.Drawing.Size(1291, 617)
        Me.PanelSearchResults.TabIndex = 3
        '
        'SearchResultsClose
        '
        Me.SearchResultsClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchResultsClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchResultsClose.Image = Global.Odeum.My.Resources.Resources.PopupCloseL
        Me.SearchResultsClose.Location = New System.Drawing.Point(1265, 17)
        Me.SearchResultsClose.Name = "SearchResultsClose"
        Me.SearchResultsClose.Size = New System.Drawing.Size(15, 15)
        Me.SearchResultsClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SearchResultsClose.TabIndex = 10002
        Me.SearchResultsClose.TabStop = False
        '
        'BgPanel
        '
        Me.BgPanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BgPanel.BackColor = System.Drawing.Color.Transparent
        Me.BgPanel.Controls.Add(Me.BoxText)
        Me.BgPanel.Location = New System.Drawing.Point(810, 6)
        Me.BgPanel.Name = "BgPanel"
        Me.BgPanel.Size = New System.Drawing.Size(124, 30)
        Me.BgPanel.TabIndex = 1018
        '
        'BoxText
        '
        Me.BoxText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxText.BackColor = System.Drawing.Color.Transparent
        Me.BoxText.BorderColor = System.Drawing.Color.White
        Me.BoxText.BorderShow = False
        Me.BoxText.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BoxText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BoxText.DesignerSelected = False
        Me.BoxText.DimFactorClick = 0
        Me.BoxText.DimFactorHover = 0
        Me.BoxText.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BoxText.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.BoxText.ImageIndex = 0
        Me.BoxText.Location = New System.Drawing.Point(0, 0)
        Me.BoxText.Name = "BoxText"
        Me.BoxText.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BoxText.SideImage = Global.Odeum.My.Resources.Resources.ArrowDown
        Me.BoxText.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BoxText.SideImageSize = New System.Drawing.Size(17, 18)
        Me.BoxText.Size = New System.Drawing.Size(121, 30)
        Me.BoxText.TabIndex = 5
        Me.BoxText.Text = "Any Genre"
        Me.BoxText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BoxText.TextShadow = System.Drawing.Color.White
        Me.BoxText.TextShadowShow = False
        '
        'filterGenreBox
        '
        Me.filterGenreBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.filterGenreBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.filterGenreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterGenreBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filterGenreBox.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.filterGenreBox.ForeColor = System.Drawing.Color.White
        Me.filterGenreBox.FormattingEnabled = True
        Me.filterGenreBox.Items.AddRange(New Object() {"Any Genre", "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Short", "Sport", "Thriller", "War", "Western"})
        Me.filterGenreBox.Location = New System.Drawing.Point(811, 9)
        Me.filterGenreBox.Name = "filterGenreBox"
        Me.filterGenreBox.Size = New System.Drawing.Size(117, 27)
        Me.filterGenreBox.TabIndex = 0
        Me.filterGenreBox.TabStop = False
        Me.filterGenreBox.Visible = False
        '
        'btnFAQ
        '
        Me.btnFAQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFAQ.AutoSize = True
        Me.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFAQ.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnFAQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnFAQ.Location = New System.Drawing.Point(380, 4)
        Me.btnFAQ.Margin = New System.Windows.Forms.Padding(2, 4, 6, 2)
        Me.btnFAQ.Name = "btnFAQ"
        Me.btnFAQ.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnFAQ.Size = New System.Drawing.Size(33, 22)
        Me.btnFAQ.TabIndex = 12
        Me.btnFAQ.Text = "FAQ"
        '
        'TextUseBrowseTab
        '
        Me.TextUseBrowseTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextUseBrowseTab.BackColor = System.Drawing.Color.Transparent
        Me.TextUseBrowseTab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextUseBrowseTab.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUseBrowseTab.Location = New System.Drawing.Point(127, 224)
        Me.TextUseBrowseTab.Name = "TextUseBrowseTab"
        Me.TextUseBrowseTab.Size = New System.Drawing.Size(1040, 253)
        Me.TextUseBrowseTab.TabIndex = 19
        Me.TextUseBrowseTab.Text = "Use the 'Movies' tab to find a movie :)"
        Me.TextUseBrowseTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AppTitle
        '
        Me.AppTitle.BackColor = System.Drawing.Color.Transparent
        Me.AppTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.AppTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppTitle.ForeColor = System.Drawing.Color.White
        Me.AppTitle.Location = New System.Drawing.Point(0, 0)
        Me.AppTitle.Name = "AppTitle"
        Me.AppTitle.Size = New System.Drawing.Size(1291, 27)
        Me.AppTitle.TabIndex = 99999
        Me.AppTitle.Text = "Odeum Movies"
        Me.AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartupTimer
        '
        Me.StartupTimer.Interval = 1400
        '
        'FilterGenreTimer
        '
        Me.FilterGenreTimer.Interval = 1300
        '
        'SearchMovies
        '
        Me.SearchMovies.Interval = 1400
        '
        'ShowMoviesTimer
        '
        Me.ShowMoviesTimer.Interval = 1000
        '
        'GetUpdateNotification
        '
        '
        'SortByTimer
        '
        Me.SortByTimer.Interval = 800
        '
        'ContentToFilter1
        '
        Me.ContentToFilter1.FormattingEnabled = True
        Me.ContentToFilter1.Location = New System.Drawing.Point(280, 5)
        Me.ContentToFilter1.Name = "ContentToFilter1"
        Me.ContentToFilter1.Size = New System.Drawing.Size(66, 17)
        Me.ContentToFilter1.TabIndex = 0
        Me.ContentToFilter1.Visible = False
        '
        'ContentToFilter2
        '
        Me.ContentToFilter2.FormattingEnabled = True
        Me.ContentToFilter2.Location = New System.Drawing.Point(350, 5)
        Me.ContentToFilter2.Name = "ContentToFilter2"
        Me.ContentToFilter2.Size = New System.Drawing.Size(66, 17)
        Me.ContentToFilter2.TabIndex = 1024
        Me.ContentToFilter2.Visible = False
        '
        'PanelTabTitles
        '
        Me.PanelTabTitles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTabTitles.BackColor = System.Drawing.Color.Transparent
        Me.PanelTabTitles.Controls.Add(Me.SearchClose)
        Me.PanelTabTitles.Controls.Add(Me.FncSplitter)
        Me.PanelTabTitles.Controls.Add(Me.TxtSearchIcon)
        Me.PanelTabTitles.Controls.Add(Me.TxtSearchBox)
        Me.PanelTabTitles.Controls.Add(Me.TxtSearchBg)
        Me.PanelTabTitles.Controls.Add(Me.BtnSortByYearReleased)
        Me.PanelTabTitles.Controls.Add(Me.BtnSortByAZ)
        Me.PanelTabTitles.Controls.Add(Me.BtnSortByNewlyAdded)
        Me.PanelTabTitles.Controls.Add(Me.BtnSortByPopularity)
        Me.PanelTabTitles.Controls.Add(Me.BgPanel)
        Me.PanelTabTitles.Controls.Add(Me.filterGenreBox)
        Me.PanelTabTitles.Controls.Add(Me.txtWatchList)
        Me.PanelTabTitles.Controls.Add(Me.txtFavourites)
        Me.PanelTabTitles.Controls.Add(Me.txtMovies)
        Me.PanelTabTitles.Location = New System.Drawing.Point(0, 28)
        Me.PanelTabTitles.Name = "PanelTabTitles"
        Me.PanelTabTitles.Size = New System.Drawing.Size(1291, 44)
        Me.PanelTabTitles.TabIndex = 1027
        '
        'SearchClose
        '
        Me.SearchClose.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SearchClose.BackColor = System.Drawing.Color.Transparent
        Me.SearchClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchClose.Image = Global.Odeum.My.Resources.Resources.PopupCloseH
        Me.SearchClose.Location = New System.Drawing.Point(241, 16)
        Me.SearchClose.Name = "SearchClose"
        Me.SearchClose.Size = New System.Drawing.Size(13, 13)
        Me.SearchClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SearchClose.TabIndex = 100001
        Me.SearchClose.TabStop = False
        Me.SearchClose.Visible = False
        '
        'FncSplitter
        '
        Me.FncSplitter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.FncSplitter.BackColor = System.Drawing.Color.Transparent
        Me.FncSplitter.BorderColor = System.Drawing.SystemColors.ScrollBar
        Me.FncSplitter.ColorFillSolid = System.Drawing.SystemColors.ScrollBar
        Me.FncSplitter.Cursor = System.Windows.Forms.Cursors.Default
        Me.FncSplitter.DesignerSelected = False
        Me.FncSplitter.DimFactorClick = 0
        Me.FncSplitter.DimFactorHover = 0
        Me.FncSplitter.FillType = CButtonLib.CButton.eFillType.Solid
        Me.FncSplitter.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FncSplitter.ForeColor = System.Drawing.Color.DarkGray
        Me.FncSplitter.ImageIndex = 0
        Me.FncSplitter.Location = New System.Drawing.Point(943, 10)
        Me.FncSplitter.Name = "FncSplitter"
        Me.FncSplitter.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.FncSplitter.SideImageSize = New System.Drawing.Size(14, 15)
        Me.FncSplitter.Size = New System.Drawing.Size(2, 24)
        Me.FncSplitter.TabIndex = 1030
        Me.FncSplitter.TabStop = False
        Me.FncSplitter.Text = ""
        Me.FncSplitter.TextShadow = System.Drawing.Color.White
        Me.FncSplitter.TextShadowShow = False
        '
        'TxtSearchIcon
        '
        Me.TxtSearchIcon.BackColor = System.Drawing.Color.Transparent
        Me.TxtSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtSearchIcon.Image = Global.Odeum.My.Resources.Resources.SearchIconL1
        Me.TxtSearchIcon.Location = New System.Drawing.Point(19, 14)
        Me.TxtSearchIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSearchIcon.Name = "TxtSearchIcon"
        Me.TxtSearchIcon.Size = New System.Drawing.Size(16, 16)
        Me.TxtSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TxtSearchIcon.TabIndex = 100000
        Me.TxtSearchIcon.TabStop = False
        '
        'TxtSearchBox
        '
        Me.TxtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtSearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearchBox.DetectUrls = False
        Me.TxtSearchBox.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSearchBox.ForeColor = System.Drawing.Color.White
        Me.TxtSearchBox.Location = New System.Drawing.Point(42, 12)
        Me.TxtSearchBox.MaxLength = 50
        Me.TxtSearchBox.Multiline = False
        Me.TxtSearchBox.Name = "TxtSearchBox"
        Me.TxtSearchBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TxtSearchBox.Size = New System.Drawing.Size(214, 19)
        Me.TxtSearchBox.TabIndex = 1
        Me.TxtSearchBox.Text = ""
        Me.TxtSearchBox.Watermark = "Search movies, people, years..."
        Me.TxtSearchBox.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        '
        'TxtSearchBg
        '
        Me.TxtSearchBg.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtSearchBg.BackColor = System.Drawing.Color.Transparent
        Me.TxtSearchBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TxtSearchBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.TxtSearchBg.Corners.All = 14
        Me.TxtSearchBg.Corners.LowerLeft = 14
        Me.TxtSearchBg.Corners.LowerRight = 14
        Me.TxtSearchBg.Corners.UpperLeft = 14
        Me.TxtSearchBg.Corners.UpperRight = 14
        Me.TxtSearchBg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearchBg.DesignerSelected = False
        Me.TxtSearchBg.DimFactorClick = 0
        Me.TxtSearchBg.DimFactorHover = 0
        Me.TxtSearchBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.TxtSearchBg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TxtSearchBg.ImageIndex = 0
        Me.TxtSearchBg.Location = New System.Drawing.Point(7, 7)
        Me.TxtSearchBg.Name = "TxtSearchBg"
        Me.TxtSearchBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.TxtSearchBg.Size = New System.Drawing.Size(260, 30)
        Me.TxtSearchBg.TabIndex = 1024
        Me.TxtSearchBg.Text = ""
        Me.TxtSearchBg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TxtSearchBg.TextShadow = System.Drawing.Color.White
        Me.TxtSearchBg.TextShadowShow = False
        '
        'BtnSortByYearReleased
        '
        Me.BtnSortByYearReleased.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSortByYearReleased.BackColor = System.Drawing.Color.Transparent
        Me.BtnSortByYearReleased.BorderShow = False
        Me.BtnSortByYearReleased.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BtnSortByYearReleased.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSortByYearReleased.DesignerSelected = False
        Me.BtnSortByYearReleased.DimFactorClick = 0
        Me.BtnSortByYearReleased.DimFactorHover = 0
        Me.BtnSortByYearReleased.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnSortByYearReleased.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSortByYearReleased.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnSortByYearReleased.ImageIndex = 0
        Me.BtnSortByYearReleased.Location = New System.Drawing.Point(1149, 10)
        Me.BtnSortByYearReleased.Name = "BtnSortByYearReleased"
        Me.BtnSortByYearReleased.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnSortByYearReleased.SideImageSize = New System.Drawing.Size(14, 15)
        Me.BtnSortByYearReleased.Size = New System.Drawing.Size(96, 26)
        Me.BtnSortByYearReleased.TabIndex = 8
        Me.BtnSortByYearReleased.Text = "Year Released"
        Me.BtnSortByYearReleased.TextShadow = System.Drawing.Color.White
        Me.BtnSortByYearReleased.TextShadowShow = False
        '
        'BtnSortByAZ
        '
        Me.BtnSortByAZ.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSortByAZ.BackColor = System.Drawing.Color.Transparent
        Me.BtnSortByAZ.BorderShow = False
        Me.BtnSortByAZ.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BtnSortByAZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSortByAZ.DesignerSelected = False
        Me.BtnSortByAZ.DimFactorClick = 0
        Me.BtnSortByAZ.DimFactorHover = 0
        Me.BtnSortByAZ.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnSortByAZ.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSortByAZ.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnSortByAZ.ImageIndex = 0
        Me.BtnSortByAZ.Location = New System.Drawing.Point(1247, 10)
        Me.BtnSortByAZ.Name = "BtnSortByAZ"
        Me.BtnSortByAZ.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnSortByAZ.SideImageSize = New System.Drawing.Size(14, 15)
        Me.BtnSortByAZ.Size = New System.Drawing.Size(35, 26)
        Me.BtnSortByAZ.TabIndex = 9
        Me.BtnSortByAZ.Text = "A-Z"
        Me.BtnSortByAZ.TextShadow = System.Drawing.Color.White
        Me.BtnSortByAZ.TextShadowShow = False
        '
        'BtnSortByNewlyAdded
        '
        Me.BtnSortByNewlyAdded.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSortByNewlyAdded.BackColor = System.Drawing.Color.Transparent
        Me.BtnSortByNewlyAdded.BorderShow = False
        Me.BtnSortByNewlyAdded.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BtnSortByNewlyAdded.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSortByNewlyAdded.DesignerSelected = False
        Me.BtnSortByNewlyAdded.DimFactorClick = 0
        Me.BtnSortByNewlyAdded.DimFactorHover = 0
        Me.BtnSortByNewlyAdded.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnSortByNewlyAdded.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSortByNewlyAdded.ImageIndex = 0
        Me.BtnSortByNewlyAdded.Location = New System.Drawing.Point(956, 9)
        Me.BtnSortByNewlyAdded.Name = "BtnSortByNewlyAdded"
        Me.BtnSortByNewlyAdded.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnSortByNewlyAdded.SideImageSize = New System.Drawing.Size(14, 15)
        Me.BtnSortByNewlyAdded.Size = New System.Drawing.Size(104, 26)
        Me.BtnSortByNewlyAdded.TabIndex = 6
        Me.BtnSortByNewlyAdded.Text = "Newly Added"
        Me.BtnSortByNewlyAdded.TextShadow = System.Drawing.Color.White
        Me.BtnSortByNewlyAdded.TextShadowShow = False
        '
        'BtnSortByPopularity
        '
        Me.BtnSortByPopularity.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSortByPopularity.BackColor = System.Drawing.Color.Transparent
        Me.BtnSortByPopularity.BorderShow = False
        Me.BtnSortByPopularity.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BtnSortByPopularity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSortByPopularity.DesignerSelected = False
        Me.BtnSortByPopularity.DimFactorClick = 0
        Me.BtnSortByPopularity.DimFactorHover = 0
        Me.BtnSortByPopularity.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnSortByPopularity.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSortByPopularity.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnSortByPopularity.ImageIndex = 0
        Me.BtnSortByPopularity.Location = New System.Drawing.Point(1062, 9)
        Me.BtnSortByPopularity.Name = "BtnSortByPopularity"
        Me.BtnSortByPopularity.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnSortByPopularity.SideImageSize = New System.Drawing.Size(14, 15)
        Me.BtnSortByPopularity.Size = New System.Drawing.Size(85, 26)
        Me.BtnSortByPopularity.TabIndex = 7
        Me.BtnSortByPopularity.Text = "Popularity"
        Me.BtnSortByPopularity.TextShadow = System.Drawing.Color.White
        Me.BtnSortByPopularity.TextShadowShow = False
        '
        'txtWatchList
        '
        Me.txtWatchList.BackColor = System.Drawing.Color.Transparent
        Me.txtWatchList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtWatchList.BorderShow = False
        Me.txtWatchList.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtWatchList.Corners.UpperLeft = 2
        Me.txtWatchList.Corners.UpperRight = 2
        Me.txtWatchList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtWatchList.DesignerSelected = False
        Me.txtWatchList.DimFactorClick = 0
        Me.txtWatchList.DimFactorHover = 0
        Me.txtWatchList.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtWatchList.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWatchList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtWatchList.ImageIndex = 0
        Me.txtWatchList.Location = New System.Drawing.Point(458, 10)
        Me.txtWatchList.Name = "txtWatchList"
        Me.txtWatchList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtWatchList.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtWatchList.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtWatchList.Size = New System.Drawing.Size(97, 34)
        Me.txtWatchList.TabIndex = 4
        Me.txtWatchList.Text = "Watch List"
        Me.txtWatchList.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtWatchList.TextShadow = System.Drawing.Color.White
        Me.txtWatchList.TextShadowShow = False
        '
        'txtFavourites
        '
        Me.txtFavourites.BackColor = System.Drawing.Color.Transparent
        Me.txtFavourites.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtFavourites.BorderShow = False
        Me.txtFavourites.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtFavourites.Corners.UpperLeft = 2
        Me.txtFavourites.Corners.UpperRight = 2
        Me.txtFavourites.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFavourites.DesignerSelected = False
        Me.txtFavourites.DimFactorClick = 0
        Me.txtFavourites.DimFactorHover = 0
        Me.txtFavourites.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtFavourites.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFavourites.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtFavourites.ImageIndex = 0
        Me.txtFavourites.Location = New System.Drawing.Point(362, 10)
        Me.txtFavourites.Name = "txtFavourites"
        Me.txtFavourites.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtFavourites.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtFavourites.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtFavourites.Size = New System.Drawing.Size(91, 34)
        Me.txtFavourites.TabIndex = 3
        Me.txtFavourites.Text = "Favourites"
        Me.txtFavourites.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtFavourites.TextShadow = System.Drawing.Color.White
        Me.txtFavourites.TextShadowShow = False
        '
        'txtMovies
        '
        Me.txtMovies.BackColor = System.Drawing.Color.Transparent
        Me.txtMovies.BorderColor = System.Drawing.Color.White
        Me.txtMovies.BorderShow = False
        Me.txtMovies.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtMovies.Corners.UpperLeft = 2
        Me.txtMovies.Corners.UpperRight = 2
        Me.txtMovies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtMovies.DesignerSelected = False
        Me.txtMovies.DimFactorClick = 0
        Me.txtMovies.DimFactorHover = 0
        Me.txtMovies.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtMovies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovies.ImageIndex = 0
        Me.txtMovies.Location = New System.Drawing.Point(277, 10)
        Me.txtMovies.Name = "txtMovies"
        Me.txtMovies.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtMovies.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtMovies.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtMovies.Size = New System.Drawing.Size(80, 34)
        Me.txtMovies.TabIndex = 2
        Me.txtMovies.Text = "Movies"
        Me.txtMovies.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtMovies.TextShadow = System.Drawing.Color.White
        Me.txtMovies.TextShadowShow = False
        '
        'GetNotifications
        '
        '
        'ContentToFilter3
        '
        Me.ContentToFilter3.FormattingEnabled = True
        Me.ContentToFilter3.Location = New System.Drawing.Point(422, 5)
        Me.ContentToFilter3.Name = "ContentToFilter3"
        Me.ContentToFilter3.Size = New System.Drawing.Size(66, 17)
        Me.ContentToFilter3.TabIndex = 1029
        Me.ContentToFilter3.Visible = False
        '
        'PanelTopRight
        '
        Me.PanelTopRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTopRight.Controls.Add(Me.AppExit)
        Me.PanelTopRight.Controls.Add(Me.AppMaximize)
        Me.PanelTopRight.Controls.Add(Me.AppMinimize)
        Me.PanelTopRight.Controls.Add(Me.btnFAQ)
        Me.PanelTopRight.Controls.Add(Me.btnChangelog)
        Me.PanelTopRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.PanelTopRight.Location = New System.Drawing.Point(790, -4)
        Me.PanelTopRight.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelTopRight.Name = "PanelTopRight"
        Me.PanelTopRight.Size = New System.Drawing.Size(500, 32)
        Me.PanelTopRight.TabIndex = 0
        '
        'AppExit
        '
        Me.AppExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppExit.BackColor = System.Drawing.Color.Transparent
        Me.AppExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppExit.Image = Global.Odeum.My.Resources.Resources.CloseApp
        Me.AppExit.Location = New System.Drawing.Point(473, 0)
        Me.AppExit.Margin = New System.Windows.Forms.Padding(0)
        Me.AppExit.Name = "AppExit"
        Me.AppExit.Size = New System.Drawing.Size(27, 32)
        Me.AppExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppExit.TabIndex = 1001
        Me.AppExit.TabStop = False
        '
        'AppMaximize
        '
        Me.AppMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppMaximize.BackColor = System.Drawing.Color.Transparent
        Me.AppMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppMaximize.Image = Global.Odeum.My.Resources.Resources.MaximiseApp
        Me.AppMaximize.Location = New System.Drawing.Point(446, 0)
        Me.AppMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.AppMaximize.Name = "AppMaximize"
        Me.AppMaximize.Size = New System.Drawing.Size(27, 32)
        Me.AppMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppMaximize.TabIndex = 1004
        Me.AppMaximize.TabStop = False
        '
        'AppMinimize
        '
        Me.AppMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppMinimize.BackColor = System.Drawing.Color.Transparent
        Me.AppMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppMinimize.Image = Global.Odeum.My.Resources.Resources.MinimiseApp
        Me.AppMinimize.Location = New System.Drawing.Point(419, 0)
        Me.AppMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.AppMinimize.Name = "AppMinimize"
        Me.AppMinimize.Size = New System.Drawing.Size(27, 32)
        Me.AppMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppMinimize.TabIndex = 1002
        Me.AppMinimize.TabStop = False
        '
        'btnChangelog
        '
        Me.btnChangelog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangelog.AutoSize = True
        Me.btnChangelog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangelog.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnChangelog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnChangelog.Location = New System.Drawing.Point(304, 4)
        Me.btnChangelog.Margin = New System.Windows.Forms.Padding(2, 4, 0, 2)
        Me.btnChangelog.Name = "btnChangelog"
        Me.btnChangelog.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnChangelog.Size = New System.Drawing.Size(74, 22)
        Me.btnChangelog.TabIndex = 11
        Me.btnChangelog.Text = "Changelog"
        '
        'SearchFavourites
        '
        Me.SearchFavourites.Interval = 1400
        '
        'SearchWatchList
        '
        Me.SearchWatchList.Interval = 1400
        '
        'FilterSearchTimer
        '
        Me.FilterSearchTimer.Interval = 1300
        '
        'ResetFiltersTimer
        '
        Me.ResetFiltersTimer.Interval = 1400
        '
        'BtnSendFeedback
        '
        Me.BtnSendFeedback.BackColor = System.Drawing.Color.Transparent
        Me.BtnSendFeedback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSendFeedback.Image = Global.Odeum.My.Resources.Resources.FeedbackL2
        Me.BtnSendFeedback.Location = New System.Drawing.Point(7, 5)
        Me.BtnSendFeedback.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSendFeedback.Name = "BtnSendFeedback"
        Me.BtnSendFeedback.Size = New System.Drawing.Size(23, 20)
        Me.BtnSendFeedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSendFeedback.TabIndex = 1006
        Me.BtnSendFeedback.TabStop = False
        '
        'icoLoadingWeb
        '
        Me.icoLoadingWeb.Location = New System.Drawing.Point(0, 0)
        Me.icoLoadingWeb.Name = "icoLoadingWeb"
        Me.icoLoadingWeb.Size = New System.Drawing.Size(100, 50)
        Me.icoLoadingWeb.TabIndex = 0
        Me.icoLoadingWeb.TabStop = False
        '
        'Odeum_Movies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1291, 741)
        Me.Controls.Add(Me.PanelTopRight)
        Me.Controls.Add(Me.PanelTabTitles)
        Me.Controls.Add(Me.BtnSendFeedback)
        Me.Controls.Add(Me.ContentToFilter3)
        Me.Controls.Add(Me.ContentToFilter2)
        Me.Controls.Add(Me.ContentToFilter1)
        Me.Controls.Add(Me.AppTitle)
        Me.Controls.Add(Me.Tabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Odeum_Movies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Odeum Movies"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Tabs.ResumeLayout(False)
        Me.tabMovies.ResumeLayout(False)
        Me.tabFavourites.ResumeLayout(False)
        CType(Me.TextEmpty1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWatchList.ResumeLayout(False)
        CType(Me.TextEmpty2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLoading.ResumeLayout(False)
        Me.tabSearchResults.ResumeLayout(False)
        Me.PanelSearchResultsText.ResumeLayout(False)
        Me.PanelSearchResultsText.PerformLayout()
        CType(Me.SearchResultsClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BgPanel.ResumeLayout(False)
        Me.PanelTabTitles.ResumeLayout(False)
        CType(Me.SearchClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTopRight.ResumeLayout(False)
        Me.PanelTopRight.PerformLayout()
        CType(Me.AppExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSendFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents tabMovies As TabPage
    Friend WithEvents AppTitle As Label
    Friend WithEvents StartupTimer As Timer
    Friend WithEvents PanelMovies As FlowLayoutPanel
    Friend WithEvents tabFavourites As TabPage
    Friend WithEvents tabLoading As TabPage
    Friend WithEvents filterGenreBox As ComboBox
    Friend WithEvents FilterGenreTimer As Timer
    Friend WithEvents txtPlayingTitle As Label
    Friend WithEvents PanelFavourites As FlowLayoutPanel
    Friend WithEvents TextUseBrowseTab As Label
    Friend WithEvents SearchMovies As Timer
    Friend WithEvents ShowMoviesTimer As Timer
    Friend WithEvents AppExit As PictureBox
    Friend WithEvents AppMinimize As PictureBox
    Friend WithEvents GetUpdateNotification As Timer
    Friend WithEvents tabWatchList As TabPage
    Friend WithEvents icoLoadingWeb As PictureBox
    Friend WithEvents BgPanel As Panel
    Friend WithEvents btnFAQ As Label
    Friend WithEvents SortByTimer As Timer
    Friend WithEvents ContentToFilter1 As ListBox
    Friend WithEvents ContentToFilter2 As ListBox
    Friend WithEvents PanelWatchList As FlowLayoutPanel
    Friend WithEvents GoFilm As Button
    Friend WithEvents FaveMovie As Button
    Friend WithEvents iconReportMovie As Button
    Friend WithEvents iconCloseMovie As Button
    Friend WithEvents PanelTabTitles As Panel
    Friend WithEvents GetNotifications As Timer
    Friend WithEvents ContentToFilter3 As ListBox
    Friend WithEvents BoxText As CButtonLib.CButton
    Friend WithEvents TxtSearchBg As CButtonLib.CButton
    Friend WithEvents txtWatchList As CButtonLib.CButton
    Friend WithEvents txtFavourites As CButtonLib.CButton
    Public WithEvents txtMovies As CButtonLib.CButton
    Friend WithEvents PanelTopRight As FlowLayoutPanel
    Friend WithEvents AppMaximize As PictureBox
    Friend WithEvents BtnSendFeedback As PictureBox
    Friend WithEvents BtnSortByNewlyAdded As CButtonLib.CButton
    Friend WithEvents BtnSortByPopularity As CButtonLib.CButton
    Friend WithEvents BtnSortByAZ As CButtonLib.CButton
    Friend WithEvents BtnSortByYearReleased As CButtonLib.CButton
    Friend WithEvents FncSplitter As CButtonLib.CButton
    Friend WithEvents btnChangelog As Label
    Friend WithEvents TxtSearchBox As RtfExtensions
    Friend WithEvents SearchFavourites As Timer
    Friend WithEvents SearchWatchList As Timer
    Friend WithEvents tabSearchResults As TabPage
    Friend WithEvents PanelSearchResults As FlowLayoutPanel
    Friend WithEvents PanelSearchResultsText As FlowLayoutPanel
    Friend WithEvents LblShowingResultsFor As Label
    Friend WithEvents LblSearchResultsText As Label
    Friend WithEvents SearchResultsClose As PictureBox
    Friend WithEvents TextEmpty0 As Label
    Friend WithEvents TxtSearchIcon As PictureBox
    Friend WithEvents CButton1 As CButtonLib.CButton
    Friend WithEvents TextEmpty1 As PictureBox
    Friend WithEvents WatchListMovies As ListBox
    Friend WithEvents WatchedMovies As ListBox
    Friend WithEvents FavouriteMovies As ListBox
    Friend WithEvents MovieContent As RichTextBox
    Friend WithEvents TextEmpty2 As PictureBox
    Friend WithEvents NotifCheck As ListBox
    Friend WithEvents FilterSearchTimer As Timer
    Friend WithEvents SearchClose As PictureBox
    Friend WithEvents ResetFiltersTimer As Timer
End Class
