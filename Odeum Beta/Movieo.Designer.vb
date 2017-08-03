<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Movieo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movieo))
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.tabDiscover = New System.Windows.Forms.TabPage()
        Me.panelGenres = New System.Windows.Forms.Panel()
        Me.btnGenreAllMovies = New CButtonLib.CButton()
        Me.btnGenreWestern = New CButtonLib.CButton()
        Me.btnGenreWar = New CButtonLib.CButton()
        Me.btnGenreThriller = New CButtonLib.CButton()
        Me.btnGenreSciFi = New CButtonLib.CButton()
        Me.btnGenreRomance = New CButtonLib.CButton()
        Me.btnGenreMystery = New CButtonLib.CButton()
        Me.btnGenreMusic = New CButtonLib.CButton()
        Me.btnGenreHorror = New CButtonLib.CButton()
        Me.btnGenreHistory = New CButtonLib.CButton()
        Me.btnGenreFantasy = New CButtonLib.CButton()
        Me.btnGenreFamily = New CButtonLib.CButton()
        Me.btnGenreDrama = New CButtonLib.CButton()
        Me.btnGenreDocumentary = New CButtonLib.CButton()
        Me.btnGenreCrime = New CButtonLib.CButton()
        Me.btnGenreComedy = New CButtonLib.CButton()
        Me.btnGenreAnimation = New CButtonLib.CButton()
        Me.btnGenreAdventure = New CButtonLib.CButton()
        Me.btnGenreAction = New CButtonLib.CButton()
        Me.imgPanelsEmptyAllMovies = New System.Windows.Forms.Label()
        Me.panelMovies = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabMyLists = New System.Windows.Forms.TabPage()
        Me.panelMyLists = New System.Windows.Forms.Panel()
        Me.btnListsBlack = New CButtonLib.CButton()
        Me.btnListsSeen = New CButtonLib.CButton()
        Me.btnListWatch = New CButtonLib.CButton()
        Me.btnListsFavourites = New CButtonLib.CButton()
        Me.tabsMyLists = New System.Windows.Forms.TabControl()
        Me.tabMyListsFavourites = New System.Windows.Forms.TabPage()
        Me.imgPanelsEmptyFavourites = New System.Windows.Forms.Label()
        Me.panelMyListsFavourites = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabMyListsWatchList = New System.Windows.Forms.TabPage()
        Me.imgPanelsEmptyWatchList = New System.Windows.Forms.Label()
        Me.panelMyListsWatchList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabMyListsSeenList = New System.Windows.Forms.TabPage()
        Me.imgPanelsEmptySeenList = New System.Windows.Forms.Label()
        Me.panelMyListsSeenList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabMyListsBlackList = New System.Windows.Forms.TabPage()
        Me.imgPanelsEmptyBlackList = New System.Windows.Forms.Label()
        Me.panelMyListsBlackList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLoading = New System.Windows.Forms.TabPage()
        Me.itemsCollectionsBookmarked = New System.Windows.Forms.ListBox()
        Me.itemsDownloads = New System.Windows.Forms.ListBox()
        Me.itemsMoviesNewReleases = New System.Windows.Forms.ListBox()
        Me.itemsMoviesTopRated = New System.Windows.Forms.ListBox()
        Me.itemsMoviesTrending = New System.Windows.Forms.ListBox()
        Me.itemsRecentlyWatched = New System.Windows.Forms.ListBox()
        Me.itemsBlackList = New System.Windows.Forms.ListBox()
        Me.lblLoadingText = New CButtonLib.CButton()
        Me.itemsNotificationList = New System.Windows.Forms.ListBox()
        Me.itemsWatchList = New System.Windows.Forms.ListBox()
        Me.itemsSeenList = New System.Windows.Forms.ListBox()
        Me.itemsFavouritesList = New System.Windows.Forms.ListBox()
        Me.richtxtMovieDb = New System.Windows.Forms.RichTextBox()
        Me.lblSearchingText = New CButtonLib.CButton()
        Me.tabSearches = New System.Windows.Forms.TabPage()
        Me.tabsSearches = New System.Windows.Forms.TabControl()
        Me.tabSearchesHome = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tabSearchesMovies = New System.Windows.Forms.TabPage()
        Me.imgPanelsEmptySearches = New System.Windows.Forms.Label()
        Me.panelSearches = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtboxSearchBG = New CButtonLib.CButton()
        Me.TextUseBrowseTab = New System.Windows.Forms.Label()
        Me.timerStartup = New System.Windows.Forms.Timer(Me.components)
        Me.timerGetUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.ContentToFilter1 = New System.Windows.Forms.ListBox()
        Me.ContentToFilter2 = New System.Windows.Forms.ListBox()
        Me.panelTabTitles = New System.Windows.Forms.Panel()
        Me.fncSplitter2 = New CButtonLib.CButton()
        Me.titleCoreMyLists = New CButtonLib.CButton()
        Me.btnInfoMenu = New System.Windows.Forms.PictureBox()
        Me.titleCoreDiscover = New CButtonLib.CButton()
        Me.imgSearchIcon = New System.Windows.Forms.PictureBox()
        Me.ContentToFilter3 = New System.Windows.Forms.ListBox()
        Me.ContentToFilter4 = New System.Windows.Forms.ListBox()
        Me.timerResetFilters = New System.Windows.Forms.Timer(Me.components)
        Me.timerFilterGenre = New System.Windows.Forms.Timer(Me.components)
        Me.timerSearchMovies = New System.Windows.Forms.Timer(Me.components)
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.imgDropShadowMainTabs = New System.Windows.Forms.PictureBox()
        Me.icoLoadingWeb = New System.Windows.Forms.PictureBox()
        Me.txtboxSearch = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.Tab.SuspendLayout()
        Me.tabDiscover.SuspendLayout()
        Me.panelGenres.SuspendLayout()
        Me.tabMyLists.SuspendLayout()
        Me.panelMyLists.SuspendLayout()
        Me.tabsMyLists.SuspendLayout()
        Me.tabMyListsFavourites.SuspendLayout()
        Me.tabMyListsWatchList.SuspendLayout()
        Me.tabMyListsSeenList.SuspendLayout()
        Me.tabMyListsBlackList.SuspendLayout()
        Me.tabLoading.SuspendLayout()
        Me.tabSearches.SuspendLayout()
        Me.tabsSearches.SuspendLayout()
        Me.tabSearchesHome.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearchesMovies.SuspendLayout()
        Me.panelTabTitles.SuspendLayout()
        CType(Me.btnInfoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDropShadowMainTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.CausesValidation = False
        Me.Tab.Controls.Add(Me.tabDiscover)
        Me.Tab.Controls.Add(Me.tabMyLists)
        Me.Tab.Controls.Add(Me.tabLoading)
        Me.Tab.Controls.Add(Me.tabSearches)
        Me.Tab.Location = New System.Drawing.Point(-25, 50)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1322, 688)
        Me.Tab.TabIndex = 1000
        Me.Tab.TabStop = False
        '
        'tabDiscover
        '
        Me.tabDiscover.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabDiscover.Controls.Add(Me.panelGenres)
        Me.tabDiscover.Controls.Add(Me.imgPanelsEmptyAllMovies)
        Me.tabDiscover.Controls.Add(Me.panelMovies)
        Me.tabDiscover.Location = New System.Drawing.Point(23, 4)
        Me.tabDiscover.Margin = New System.Windows.Forms.Padding(0)
        Me.tabDiscover.Name = "tabDiscover"
        Me.tabDiscover.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.tabDiscover.Size = New System.Drawing.Size(1295, 680)
        Me.tabDiscover.TabIndex = 0
        Me.tabDiscover.Text = "DISCOVER"
        '
        'panelGenres
        '
        Me.panelGenres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelGenres.AutoScroll = True
        Me.panelGenres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelGenres.Controls.Add(Me.btnGenreAllMovies)
        Me.panelGenres.Controls.Add(Me.btnGenreWestern)
        Me.panelGenres.Controls.Add(Me.btnGenreWar)
        Me.panelGenres.Controls.Add(Me.btnGenreThriller)
        Me.panelGenres.Controls.Add(Me.btnGenreSciFi)
        Me.panelGenres.Controls.Add(Me.btnGenreRomance)
        Me.panelGenres.Controls.Add(Me.btnGenreMystery)
        Me.panelGenres.Controls.Add(Me.btnGenreMusic)
        Me.panelGenres.Controls.Add(Me.btnGenreHorror)
        Me.panelGenres.Controls.Add(Me.btnGenreHistory)
        Me.panelGenres.Controls.Add(Me.btnGenreFantasy)
        Me.panelGenres.Controls.Add(Me.btnGenreFamily)
        Me.panelGenres.Controls.Add(Me.btnGenreDrama)
        Me.panelGenres.Controls.Add(Me.btnGenreDocumentary)
        Me.panelGenres.Controls.Add(Me.btnGenreCrime)
        Me.panelGenres.Controls.Add(Me.btnGenreComedy)
        Me.panelGenres.Controls.Add(Me.btnGenreAnimation)
        Me.panelGenres.Controls.Add(Me.btnGenreAdventure)
        Me.panelGenres.Controls.Add(Me.btnGenreAction)
        Me.panelGenres.Location = New System.Drawing.Point(2, 0)
        Me.panelGenres.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.panelGenres.Name = "panelGenres"
        Me.panelGenres.Size = New System.Drawing.Size(172, 679)
        Me.panelGenres.TabIndex = 100020
        '
        'btnGenreAllMovies
        '
        Me.btnGenreAllMovies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreAllMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnGenreAllMovies.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreAllMovies.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreAllMovies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreAllMovies.DesignerSelected = False
        Me.btnGenreAllMovies.DimFactorClick = 0
        Me.btnGenreAllMovies.DimFactorHover = 0
        Me.btnGenreAllMovies.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreAllMovies.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreAllMovies.ImageIndex = 0
        Me.btnGenreAllMovies.Location = New System.Drawing.Point(9, 543)
        Me.btnGenreAllMovies.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreAllMovies.Name = "btnGenreAllMovies"
        Me.btnGenreAllMovies.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreAllMovies.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreAllMovies.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreAllMovies.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreAllMovies.TabIndex = 100039
        Me.btnGenreAllMovies.TabStop = False
        Me.btnGenreAllMovies.Text = "All Movies"
        Me.btnGenreAllMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreAllMovies.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreAllMovies.TextShadow = System.Drawing.Color.White
        Me.btnGenreAllMovies.TextShadowShow = False
        '
        'btnGenreWestern
        '
        Me.btnGenreWestern.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreWestern.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreWestern.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreWestern.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreWestern.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreWestern.DesignerSelected = False
        Me.btnGenreWestern.DimFactorClick = 0
        Me.btnGenreWestern.DimFactorHover = 0
        Me.btnGenreWestern.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreWestern.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreWestern.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreWestern.ImageIndex = 0
        Me.btnGenreWestern.Location = New System.Drawing.Point(9, 513)
        Me.btnGenreWestern.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreWestern.Name = "btnGenreWestern"
        Me.btnGenreWestern.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreWestern.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreWestern.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreWestern.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreWestern.TabIndex = 100038
        Me.btnGenreWestern.TabStop = False
        Me.btnGenreWestern.Text = "Western"
        Me.btnGenreWestern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreWestern.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreWestern.TextShadow = System.Drawing.Color.White
        Me.btnGenreWestern.TextShadowShow = False
        '
        'btnGenreWar
        '
        Me.btnGenreWar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreWar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreWar.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreWar.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreWar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreWar.DesignerSelected = False
        Me.btnGenreWar.DimFactorClick = 0
        Me.btnGenreWar.DimFactorHover = 0
        Me.btnGenreWar.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreWar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreWar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreWar.ImageIndex = 0
        Me.btnGenreWar.Location = New System.Drawing.Point(9, 483)
        Me.btnGenreWar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreWar.Name = "btnGenreWar"
        Me.btnGenreWar.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreWar.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreWar.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreWar.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreWar.TabIndex = 100037
        Me.btnGenreWar.TabStop = False
        Me.btnGenreWar.Text = "War"
        Me.btnGenreWar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreWar.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreWar.TextShadow = System.Drawing.Color.White
        Me.btnGenreWar.TextShadowShow = False
        '
        'btnGenreThriller
        '
        Me.btnGenreThriller.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreThriller.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreThriller.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreThriller.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreThriller.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreThriller.DesignerSelected = False
        Me.btnGenreThriller.DimFactorClick = 0
        Me.btnGenreThriller.DimFactorHover = 0
        Me.btnGenreThriller.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreThriller.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreThriller.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreThriller.ImageIndex = 0
        Me.btnGenreThriller.Location = New System.Drawing.Point(9, 453)
        Me.btnGenreThriller.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreThriller.Name = "btnGenreThriller"
        Me.btnGenreThriller.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreThriller.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreThriller.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreThriller.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreThriller.TabIndex = 100036
        Me.btnGenreThriller.TabStop = False
        Me.btnGenreThriller.Text = "Thriller"
        Me.btnGenreThriller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreThriller.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreThriller.TextShadow = System.Drawing.Color.White
        Me.btnGenreThriller.TextShadowShow = False
        '
        'btnGenreSciFi
        '
        Me.btnGenreSciFi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreSciFi.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreSciFi.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreSciFi.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreSciFi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreSciFi.DesignerSelected = False
        Me.btnGenreSciFi.DimFactorClick = 0
        Me.btnGenreSciFi.DimFactorHover = 0
        Me.btnGenreSciFi.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreSciFi.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreSciFi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreSciFi.ImageIndex = 0
        Me.btnGenreSciFi.Location = New System.Drawing.Point(9, 423)
        Me.btnGenreSciFi.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreSciFi.Name = "btnGenreSciFi"
        Me.btnGenreSciFi.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreSciFi.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreSciFi.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreSciFi.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreSciFi.TabIndex = 100034
        Me.btnGenreSciFi.TabStop = False
        Me.btnGenreSciFi.Text = "Sci-Fi"
        Me.btnGenreSciFi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreSciFi.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreSciFi.TextShadow = System.Drawing.Color.White
        Me.btnGenreSciFi.TextShadowShow = False
        '
        'btnGenreRomance
        '
        Me.btnGenreRomance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreRomance.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreRomance.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreRomance.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreRomance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreRomance.DesignerSelected = False
        Me.btnGenreRomance.DimFactorClick = 0
        Me.btnGenreRomance.DimFactorHover = 0
        Me.btnGenreRomance.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreRomance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreRomance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreRomance.ImageIndex = 0
        Me.btnGenreRomance.Location = New System.Drawing.Point(9, 393)
        Me.btnGenreRomance.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreRomance.Name = "btnGenreRomance"
        Me.btnGenreRomance.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreRomance.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreRomance.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreRomance.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreRomance.TabIndex = 100033
        Me.btnGenreRomance.TabStop = False
        Me.btnGenreRomance.Text = "Romance"
        Me.btnGenreRomance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreRomance.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreRomance.TextShadow = System.Drawing.Color.White
        Me.btnGenreRomance.TextShadowShow = False
        '
        'btnGenreMystery
        '
        Me.btnGenreMystery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreMystery.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreMystery.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreMystery.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreMystery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreMystery.DesignerSelected = False
        Me.btnGenreMystery.DimFactorClick = 0
        Me.btnGenreMystery.DimFactorHover = 0
        Me.btnGenreMystery.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreMystery.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreMystery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreMystery.ImageIndex = 0
        Me.btnGenreMystery.Location = New System.Drawing.Point(9, 363)
        Me.btnGenreMystery.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreMystery.Name = "btnGenreMystery"
        Me.btnGenreMystery.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreMystery.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreMystery.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreMystery.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreMystery.TabIndex = 100032
        Me.btnGenreMystery.TabStop = False
        Me.btnGenreMystery.Text = "Mystery"
        Me.btnGenreMystery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreMystery.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreMystery.TextShadow = System.Drawing.Color.White
        Me.btnGenreMystery.TextShadowShow = False
        '
        'btnGenreMusic
        '
        Me.btnGenreMusic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreMusic.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreMusic.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreMusic.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreMusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreMusic.DesignerSelected = False
        Me.btnGenreMusic.DimFactorClick = 0
        Me.btnGenreMusic.DimFactorHover = 0
        Me.btnGenreMusic.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreMusic.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreMusic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreMusic.ImageIndex = 0
        Me.btnGenreMusic.Location = New System.Drawing.Point(9, 333)
        Me.btnGenreMusic.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreMusic.Name = "btnGenreMusic"
        Me.btnGenreMusic.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreMusic.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreMusic.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreMusic.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreMusic.TabIndex = 100031
        Me.btnGenreMusic.TabStop = False
        Me.btnGenreMusic.Text = "Music"
        Me.btnGenreMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreMusic.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreMusic.TextShadow = System.Drawing.Color.White
        Me.btnGenreMusic.TextShadowShow = False
        '
        'btnGenreHorror
        '
        Me.btnGenreHorror.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreHorror.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreHorror.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreHorror.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreHorror.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreHorror.DesignerSelected = False
        Me.btnGenreHorror.DimFactorClick = 0
        Me.btnGenreHorror.DimFactorHover = 0
        Me.btnGenreHorror.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreHorror.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreHorror.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreHorror.ImageIndex = 0
        Me.btnGenreHorror.Location = New System.Drawing.Point(9, 303)
        Me.btnGenreHorror.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreHorror.Name = "btnGenreHorror"
        Me.btnGenreHorror.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreHorror.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreHorror.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreHorror.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreHorror.TabIndex = 100030
        Me.btnGenreHorror.TabStop = False
        Me.btnGenreHorror.Text = "Horror"
        Me.btnGenreHorror.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreHorror.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreHorror.TextShadow = System.Drawing.Color.White
        Me.btnGenreHorror.TextShadowShow = False
        '
        'btnGenreHistory
        '
        Me.btnGenreHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreHistory.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreHistory.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreHistory.DesignerSelected = False
        Me.btnGenreHistory.DimFactorClick = 0
        Me.btnGenreHistory.DimFactorHover = 0
        Me.btnGenreHistory.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreHistory.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreHistory.ImageIndex = 0
        Me.btnGenreHistory.Location = New System.Drawing.Point(9, 273)
        Me.btnGenreHistory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreHistory.Name = "btnGenreHistory"
        Me.btnGenreHistory.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreHistory.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreHistory.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreHistory.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreHistory.TabIndex = 100029
        Me.btnGenreHistory.TabStop = False
        Me.btnGenreHistory.Text = "History"
        Me.btnGenreHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreHistory.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreHistory.TextShadow = System.Drawing.Color.White
        Me.btnGenreHistory.TextShadowShow = False
        '
        'btnGenreFantasy
        '
        Me.btnGenreFantasy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreFantasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreFantasy.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreFantasy.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreFantasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreFantasy.DesignerSelected = False
        Me.btnGenreFantasy.DimFactorClick = 0
        Me.btnGenreFantasy.DimFactorHover = 0
        Me.btnGenreFantasy.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreFantasy.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreFantasy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreFantasy.ImageIndex = 0
        Me.btnGenreFantasy.Location = New System.Drawing.Point(9, 243)
        Me.btnGenreFantasy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreFantasy.Name = "btnGenreFantasy"
        Me.btnGenreFantasy.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreFantasy.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreFantasy.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreFantasy.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreFantasy.TabIndex = 100027
        Me.btnGenreFantasy.TabStop = False
        Me.btnGenreFantasy.Text = "Fantasy"
        Me.btnGenreFantasy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreFantasy.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreFantasy.TextShadow = System.Drawing.Color.White
        Me.btnGenreFantasy.TextShadowShow = False
        '
        'btnGenreFamily
        '
        Me.btnGenreFamily.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreFamily.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreFamily.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreFamily.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreFamily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreFamily.DesignerSelected = False
        Me.btnGenreFamily.DimFactorClick = 0
        Me.btnGenreFamily.DimFactorHover = 0
        Me.btnGenreFamily.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreFamily.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreFamily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreFamily.ImageIndex = 0
        Me.btnGenreFamily.Location = New System.Drawing.Point(9, 213)
        Me.btnGenreFamily.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreFamily.Name = "btnGenreFamily"
        Me.btnGenreFamily.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreFamily.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreFamily.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreFamily.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreFamily.TabIndex = 100026
        Me.btnGenreFamily.TabStop = False
        Me.btnGenreFamily.Text = "Family"
        Me.btnGenreFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreFamily.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreFamily.TextShadow = System.Drawing.Color.White
        Me.btnGenreFamily.TextShadowShow = False
        '
        'btnGenreDrama
        '
        Me.btnGenreDrama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreDrama.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreDrama.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreDrama.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreDrama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreDrama.DesignerSelected = False
        Me.btnGenreDrama.DimFactorClick = 0
        Me.btnGenreDrama.DimFactorHover = 0
        Me.btnGenreDrama.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreDrama.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreDrama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreDrama.ImageIndex = 0
        Me.btnGenreDrama.Location = New System.Drawing.Point(9, 183)
        Me.btnGenreDrama.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreDrama.Name = "btnGenreDrama"
        Me.btnGenreDrama.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreDrama.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreDrama.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreDrama.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreDrama.TabIndex = 100025
        Me.btnGenreDrama.TabStop = False
        Me.btnGenreDrama.Text = "Drama"
        Me.btnGenreDrama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreDrama.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreDrama.TextShadow = System.Drawing.Color.White
        Me.btnGenreDrama.TextShadowShow = False
        '
        'btnGenreDocumentary
        '
        Me.btnGenreDocumentary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreDocumentary.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreDocumentary.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreDocumentary.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreDocumentary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreDocumentary.DesignerSelected = False
        Me.btnGenreDocumentary.DimFactorClick = 0
        Me.btnGenreDocumentary.DimFactorHover = 0
        Me.btnGenreDocumentary.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreDocumentary.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreDocumentary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreDocumentary.ImageIndex = 0
        Me.btnGenreDocumentary.Location = New System.Drawing.Point(9, 153)
        Me.btnGenreDocumentary.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreDocumentary.Name = "btnGenreDocumentary"
        Me.btnGenreDocumentary.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreDocumentary.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreDocumentary.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreDocumentary.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreDocumentary.TabIndex = 100024
        Me.btnGenreDocumentary.TabStop = False
        Me.btnGenreDocumentary.Text = "Documentary"
        Me.btnGenreDocumentary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreDocumentary.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreDocumentary.TextShadow = System.Drawing.Color.White
        Me.btnGenreDocumentary.TextShadowShow = False
        '
        'btnGenreCrime
        '
        Me.btnGenreCrime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreCrime.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreCrime.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreCrime.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreCrime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreCrime.DesignerSelected = False
        Me.btnGenreCrime.DimFactorClick = 0
        Me.btnGenreCrime.DimFactorHover = 0
        Me.btnGenreCrime.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreCrime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreCrime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreCrime.ImageIndex = 0
        Me.btnGenreCrime.Location = New System.Drawing.Point(9, 123)
        Me.btnGenreCrime.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreCrime.Name = "btnGenreCrime"
        Me.btnGenreCrime.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreCrime.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreCrime.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreCrime.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreCrime.TabIndex = 100023
        Me.btnGenreCrime.TabStop = False
        Me.btnGenreCrime.Text = "Crime"
        Me.btnGenreCrime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreCrime.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreCrime.TextShadow = System.Drawing.Color.White
        Me.btnGenreCrime.TextShadowShow = False
        '
        'btnGenreComedy
        '
        Me.btnGenreComedy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreComedy.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreComedy.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreComedy.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreComedy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreComedy.DesignerSelected = False
        Me.btnGenreComedy.DimFactorClick = 0
        Me.btnGenreComedy.DimFactorHover = 0
        Me.btnGenreComedy.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreComedy.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreComedy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreComedy.ImageIndex = 0
        Me.btnGenreComedy.Location = New System.Drawing.Point(9, 93)
        Me.btnGenreComedy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreComedy.Name = "btnGenreComedy"
        Me.btnGenreComedy.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreComedy.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreComedy.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreComedy.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreComedy.TabIndex = 100022
        Me.btnGenreComedy.TabStop = False
        Me.btnGenreComedy.Text = "Comedy"
        Me.btnGenreComedy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreComedy.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreComedy.TextShadow = System.Drawing.Color.White
        Me.btnGenreComedy.TextShadowShow = False
        '
        'btnGenreAnimation
        '
        Me.btnGenreAnimation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreAnimation.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreAnimation.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreAnimation.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreAnimation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreAnimation.DesignerSelected = False
        Me.btnGenreAnimation.DimFactorClick = 0
        Me.btnGenreAnimation.DimFactorHover = 0
        Me.btnGenreAnimation.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreAnimation.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreAnimation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreAnimation.ImageIndex = 0
        Me.btnGenreAnimation.Location = New System.Drawing.Point(9, 63)
        Me.btnGenreAnimation.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreAnimation.Name = "btnGenreAnimation"
        Me.btnGenreAnimation.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreAnimation.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreAnimation.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreAnimation.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreAnimation.TabIndex = 100021
        Me.btnGenreAnimation.TabStop = False
        Me.btnGenreAnimation.Text = "Animation"
        Me.btnGenreAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreAnimation.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreAnimation.TextShadow = System.Drawing.Color.White
        Me.btnGenreAnimation.TextShadowShow = False
        '
        'btnGenreAdventure
        '
        Me.btnGenreAdventure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreAdventure.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreAdventure.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreAdventure.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreAdventure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreAdventure.DesignerSelected = False
        Me.btnGenreAdventure.DimFactorClick = 0
        Me.btnGenreAdventure.DimFactorHover = 0
        Me.btnGenreAdventure.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreAdventure.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreAdventure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreAdventure.ImageIndex = 0
        Me.btnGenreAdventure.Location = New System.Drawing.Point(9, 33)
        Me.btnGenreAdventure.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreAdventure.Name = "btnGenreAdventure"
        Me.btnGenreAdventure.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreAdventure.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreAdventure.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreAdventure.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreAdventure.TabIndex = 100020
        Me.btnGenreAdventure.TabStop = False
        Me.btnGenreAdventure.Text = "Adventure"
        Me.btnGenreAdventure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreAdventure.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreAdventure.TextShadow = System.Drawing.Color.White
        Me.btnGenreAdventure.TextShadowShow = False
        '
        'btnGenreAction
        '
        Me.btnGenreAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreAction.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreAction.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreAction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreAction.DesignerSelected = False
        Me.btnGenreAction.DimFactorClick = 0
        Me.btnGenreAction.DimFactorHover = 0
        Me.btnGenreAction.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreAction.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnGenreAction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreAction.ImageIndex = 0
        Me.btnGenreAction.Location = New System.Drawing.Point(9, 3)
        Me.btnGenreAction.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreAction.Name = "btnGenreAction"
        Me.btnGenreAction.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreAction.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreAction.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreAction.Size = New System.Drawing.Size(155, 30)
        Me.btnGenreAction.TabIndex = 100019
        Me.btnGenreAction.TabStop = False
        Me.btnGenreAction.Text = "Action"
        Me.btnGenreAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreAction.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnGenreAction.TextShadow = System.Drawing.Color.White
        Me.btnGenreAction.TextShadowShow = False
        '
        'imgPanelsEmptyAllMovies
        '
        Me.imgPanelsEmptyAllMovies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanelsEmptyAllMovies.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmptyAllMovies.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.imgPanelsEmptyAllMovies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmptyAllMovies.Location = New System.Drawing.Point(309, 102)
        Me.imgPanelsEmptyAllMovies.Name = "imgPanelsEmptyAllMovies"
        Me.imgPanelsEmptyAllMovies.Size = New System.Drawing.Size(841, 56)
        Me.imgPanelsEmptyAllMovies.TabIndex = 10004
        Me.imgPanelsEmptyAllMovies.Text = "No movies found :/"
        Me.imgPanelsEmptyAllMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.imgPanelsEmptyAllMovies.Visible = False
        '
        'panelMovies
        '
        Me.panelMovies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMovies.AutoScroll = True
        Me.panelMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelMovies.Location = New System.Drawing.Point(174, 1)
        Me.panelMovies.Margin = New System.Windows.Forms.Padding(0, 6, 3, 3)
        Me.panelMovies.Name = "panelMovies"
        Me.panelMovies.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.panelMovies.Size = New System.Drawing.Size(1119, 678)
        Me.panelMovies.TabIndex = 10006
        '
        'tabMyLists
        '
        Me.tabMyLists.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabMyLists.Controls.Add(Me.panelMyLists)
        Me.tabMyLists.Controls.Add(Me.tabsMyLists)
        Me.tabMyLists.Location = New System.Drawing.Point(23, 4)
        Me.tabMyLists.Name = "tabMyLists"
        Me.tabMyLists.Size = New System.Drawing.Size(1295, 680)
        Me.tabMyLists.TabIndex = 10
        Me.tabMyLists.Text = "tabMyLists"
        '
        'panelMyLists
        '
        Me.panelMyLists.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelMyLists.AutoScroll = True
        Me.panelMyLists.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelMyLists.Controls.Add(Me.btnListsBlack)
        Me.panelMyLists.Controls.Add(Me.btnListsSeen)
        Me.panelMyLists.Controls.Add(Me.btnListWatch)
        Me.panelMyLists.Controls.Add(Me.btnListsFavourites)
        Me.panelMyLists.Location = New System.Drawing.Point(2, 0)
        Me.panelMyLists.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.panelMyLists.Name = "panelMyLists"
        Me.panelMyLists.Size = New System.Drawing.Size(172, 679)
        Me.panelMyLists.TabIndex = 100021
        '
        'btnListsBlack
        '
        Me.btnListsBlack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListsBlack.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnListsBlack.BorderColor = System.Drawing.Color.Transparent
        Me.btnListsBlack.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnListsBlack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListsBlack.DesignerSelected = False
        Me.btnListsBlack.DimFactorClick = 0
        Me.btnListsBlack.DimFactorHover = 0
        Me.btnListsBlack.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnListsBlack.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnListsBlack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnListsBlack.ImageIndex = 0
        Me.btnListsBlack.Location = New System.Drawing.Point(9, 93)
        Me.btnListsBlack.Margin = New System.Windows.Forms.Padding(0)
        Me.btnListsBlack.Name = "btnListsBlack"
        Me.btnListsBlack.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnListsBlack.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListsBlack.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnListsBlack.Size = New System.Drawing.Size(155, 30)
        Me.btnListsBlack.TabIndex = 100039
        Me.btnListsBlack.TabStop = False
        Me.btnListsBlack.Text = "Black List"
        Me.btnListsBlack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListsBlack.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnListsBlack.TextShadow = System.Drawing.Color.White
        Me.btnListsBlack.TextShadowShow = False
        '
        'btnListsSeen
        '
        Me.btnListsSeen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListsSeen.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnListsSeen.BorderColor = System.Drawing.Color.Transparent
        Me.btnListsSeen.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnListsSeen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListsSeen.DesignerSelected = False
        Me.btnListsSeen.DimFactorClick = 0
        Me.btnListsSeen.DimFactorHover = 0
        Me.btnListsSeen.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnListsSeen.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnListsSeen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnListsSeen.ImageIndex = 0
        Me.btnListsSeen.Location = New System.Drawing.Point(9, 63)
        Me.btnListsSeen.Margin = New System.Windows.Forms.Padding(0)
        Me.btnListsSeen.Name = "btnListsSeen"
        Me.btnListsSeen.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnListsSeen.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListsSeen.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnListsSeen.Size = New System.Drawing.Size(155, 30)
        Me.btnListsSeen.TabIndex = 100021
        Me.btnListsSeen.TabStop = False
        Me.btnListsSeen.Text = "Seen List"
        Me.btnListsSeen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListsSeen.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnListsSeen.TextShadow = System.Drawing.Color.White
        Me.btnListsSeen.TextShadowShow = False
        '
        'btnListWatch
        '
        Me.btnListWatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListWatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnListWatch.BorderColor = System.Drawing.Color.Transparent
        Me.btnListWatch.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnListWatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListWatch.DesignerSelected = False
        Me.btnListWatch.DimFactorClick = 0
        Me.btnListWatch.DimFactorHover = 0
        Me.btnListWatch.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnListWatch.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnListWatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnListWatch.ImageIndex = 0
        Me.btnListWatch.Location = New System.Drawing.Point(9, 33)
        Me.btnListWatch.Margin = New System.Windows.Forms.Padding(0)
        Me.btnListWatch.Name = "btnListWatch"
        Me.btnListWatch.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnListWatch.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListWatch.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnListWatch.Size = New System.Drawing.Size(155, 30)
        Me.btnListWatch.TabIndex = 100020
        Me.btnListWatch.TabStop = False
        Me.btnListWatch.Text = "Watch List"
        Me.btnListWatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListWatch.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnListWatch.TextShadow = System.Drawing.Color.White
        Me.btnListWatch.TextShadowShow = False
        '
        'btnListsFavourites
        '
        Me.btnListsFavourites.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListsFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnListsFavourites.BorderColor = System.Drawing.Color.Transparent
        Me.btnListsFavourites.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnListsFavourites.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListsFavourites.DesignerSelected = False
        Me.btnListsFavourites.DimFactorClick = 0
        Me.btnListsFavourites.DimFactorHover = 0
        Me.btnListsFavourites.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnListsFavourites.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnListsFavourites.ImageIndex = 0
        Me.btnListsFavourites.Location = New System.Drawing.Point(9, 3)
        Me.btnListsFavourites.Margin = New System.Windows.Forms.Padding(0)
        Me.btnListsFavourites.Name = "btnListsFavourites"
        Me.btnListsFavourites.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnListsFavourites.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListsFavourites.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnListsFavourites.Size = New System.Drawing.Size(155, 30)
        Me.btnListsFavourites.TabIndex = 100019
        Me.btnListsFavourites.TabStop = False
        Me.btnListsFavourites.Text = "Favourites"
        Me.btnListsFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListsFavourites.TextMargin = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.btnListsFavourites.TextShadow = System.Drawing.Color.White
        Me.btnListsFavourites.TextShadowShow = False
        '
        'tabsMyLists
        '
        Me.tabsMyLists.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabsMyLists.Controls.Add(Me.tabMyListsFavourites)
        Me.tabsMyLists.Controls.Add(Me.tabMyListsWatchList)
        Me.tabsMyLists.Controls.Add(Me.tabMyListsSeenList)
        Me.tabsMyLists.Controls.Add(Me.tabMyListsBlackList)
        Me.tabsMyLists.Location = New System.Drawing.Point(170, -22)
        Me.tabsMyLists.Name = "tabsMyLists"
        Me.tabsMyLists.SelectedIndex = 0
        Me.tabsMyLists.Size = New System.Drawing.Size(1127, 706)
        Me.tabsMyLists.TabIndex = 100009
        '
        'tabMyListsFavourites
        '
        Me.tabMyListsFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabMyListsFavourites.Controls.Add(Me.imgPanelsEmptyFavourites)
        Me.tabMyListsFavourites.Controls.Add(Me.panelMyListsFavourites)
        Me.tabMyListsFavourites.Location = New System.Drawing.Point(4, 22)
        Me.tabMyListsFavourites.Name = "tabMyListsFavourites"
        Me.tabMyListsFavourites.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMyListsFavourites.Size = New System.Drawing.Size(1119, 680)
        Me.tabMyListsFavourites.TabIndex = 0
        Me.tabMyListsFavourites.Text = "tabMyListsFavourites"
        '
        'imgPanelsEmptyFavourites
        '
        Me.imgPanelsEmptyFavourites.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanelsEmptyFavourites.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmptyFavourites.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.imgPanelsEmptyFavourites.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmptyFavourites.Location = New System.Drawing.Point(141, 82)
        Me.imgPanelsEmptyFavourites.Name = "imgPanelsEmptyFavourites"
        Me.imgPanelsEmptyFavourites.Size = New System.Drawing.Size(835, 56)
        Me.imgPanelsEmptyFavourites.TabIndex = 10007
        Me.imgPanelsEmptyFavourites.Text = "Nothing to see here..."
        Me.imgPanelsEmptyFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelMyListsFavourites
        '
        Me.panelMyListsFavourites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMyListsFavourites.AutoScroll = True
        Me.panelMyListsFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelMyListsFavourites.Location = New System.Drawing.Point(0, 0)
        Me.panelMyListsFavourites.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelMyListsFavourites.Name = "panelMyListsFavourites"
        Me.panelMyListsFavourites.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.panelMyListsFavourites.Size = New System.Drawing.Size(1119, 679)
        Me.panelMyListsFavourites.TabIndex = 10008
        '
        'tabMyListsWatchList
        '
        Me.tabMyListsWatchList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabMyListsWatchList.Controls.Add(Me.imgPanelsEmptyWatchList)
        Me.tabMyListsWatchList.Controls.Add(Me.panelMyListsWatchList)
        Me.tabMyListsWatchList.Location = New System.Drawing.Point(4, 22)
        Me.tabMyListsWatchList.Name = "tabMyListsWatchList"
        Me.tabMyListsWatchList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMyListsWatchList.Size = New System.Drawing.Size(1119, 680)
        Me.tabMyListsWatchList.TabIndex = 1
        Me.tabMyListsWatchList.Text = "tabMyListsWatchList"
        '
        'imgPanelsEmptyWatchList
        '
        Me.imgPanelsEmptyWatchList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanelsEmptyWatchList.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmptyWatchList.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.imgPanelsEmptyWatchList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmptyWatchList.Location = New System.Drawing.Point(141, 82)
        Me.imgPanelsEmptyWatchList.Name = "imgPanelsEmptyWatchList"
        Me.imgPanelsEmptyWatchList.Size = New System.Drawing.Size(835, 56)
        Me.imgPanelsEmptyWatchList.TabIndex = 10007
        Me.imgPanelsEmptyWatchList.Text = "Nothing to see here..."
        Me.imgPanelsEmptyWatchList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelMyListsWatchList
        '
        Me.panelMyListsWatchList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMyListsWatchList.AutoScroll = True
        Me.panelMyListsWatchList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelMyListsWatchList.Location = New System.Drawing.Point(0, 9)
        Me.panelMyListsWatchList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelMyListsWatchList.Name = "panelMyListsWatchList"
        Me.panelMyListsWatchList.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.panelMyListsWatchList.Size = New System.Drawing.Size(1119, 670)
        Me.panelMyListsWatchList.TabIndex = 10008
        '
        'tabMyListsSeenList
        '
        Me.tabMyListsSeenList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabMyListsSeenList.Controls.Add(Me.imgPanelsEmptySeenList)
        Me.tabMyListsSeenList.Controls.Add(Me.panelMyListsSeenList)
        Me.tabMyListsSeenList.Location = New System.Drawing.Point(4, 22)
        Me.tabMyListsSeenList.Name = "tabMyListsSeenList"
        Me.tabMyListsSeenList.Size = New System.Drawing.Size(1119, 680)
        Me.tabMyListsSeenList.TabIndex = 2
        Me.tabMyListsSeenList.Text = "tabMyListsSeenList"
        '
        'imgPanelsEmptySeenList
        '
        Me.imgPanelsEmptySeenList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanelsEmptySeenList.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmptySeenList.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.imgPanelsEmptySeenList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmptySeenList.Location = New System.Drawing.Point(141, 82)
        Me.imgPanelsEmptySeenList.Name = "imgPanelsEmptySeenList"
        Me.imgPanelsEmptySeenList.Size = New System.Drawing.Size(835, 56)
        Me.imgPanelsEmptySeenList.TabIndex = 10007
        Me.imgPanelsEmptySeenList.Text = "Nothing to see here..."
        Me.imgPanelsEmptySeenList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelMyListsSeenList
        '
        Me.panelMyListsSeenList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMyListsSeenList.AutoScroll = True
        Me.panelMyListsSeenList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelMyListsSeenList.Location = New System.Drawing.Point(0, 9)
        Me.panelMyListsSeenList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelMyListsSeenList.Name = "panelMyListsSeenList"
        Me.panelMyListsSeenList.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.panelMyListsSeenList.Size = New System.Drawing.Size(1119, 670)
        Me.panelMyListsSeenList.TabIndex = 10008
        '
        'tabMyListsBlackList
        '
        Me.tabMyListsBlackList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabMyListsBlackList.Controls.Add(Me.imgPanelsEmptyBlackList)
        Me.tabMyListsBlackList.Controls.Add(Me.panelMyListsBlackList)
        Me.tabMyListsBlackList.Location = New System.Drawing.Point(4, 22)
        Me.tabMyListsBlackList.Name = "tabMyListsBlackList"
        Me.tabMyListsBlackList.Size = New System.Drawing.Size(1119, 680)
        Me.tabMyListsBlackList.TabIndex = 3
        Me.tabMyListsBlackList.Text = "tabMyListsBlackList"
        '
        'imgPanelsEmptyBlackList
        '
        Me.imgPanelsEmptyBlackList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanelsEmptyBlackList.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmptyBlackList.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.imgPanelsEmptyBlackList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmptyBlackList.Location = New System.Drawing.Point(141, 82)
        Me.imgPanelsEmptyBlackList.Name = "imgPanelsEmptyBlackList"
        Me.imgPanelsEmptyBlackList.Size = New System.Drawing.Size(835, 56)
        Me.imgPanelsEmptyBlackList.TabIndex = 10007
        Me.imgPanelsEmptyBlackList.Text = "Nothing to see here..."
        Me.imgPanelsEmptyBlackList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelMyListsBlackList
        '
        Me.panelMyListsBlackList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMyListsBlackList.AutoScroll = True
        Me.panelMyListsBlackList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelMyListsBlackList.Location = New System.Drawing.Point(0, 10)
        Me.panelMyListsBlackList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelMyListsBlackList.Name = "panelMyListsBlackList"
        Me.panelMyListsBlackList.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.panelMyListsBlackList.Size = New System.Drawing.Size(1119, 670)
        Me.panelMyListsBlackList.TabIndex = 10008
        '
        'tabLoading
        '
        Me.tabLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLoading.Controls.Add(Me.itemsCollectionsBookmarked)
        Me.tabLoading.Controls.Add(Me.itemsDownloads)
        Me.tabLoading.Controls.Add(Me.itemsMoviesNewReleases)
        Me.tabLoading.Controls.Add(Me.itemsMoviesTopRated)
        Me.tabLoading.Controls.Add(Me.itemsMoviesTrending)
        Me.tabLoading.Controls.Add(Me.itemsRecentlyWatched)
        Me.tabLoading.Controls.Add(Me.itemsBlackList)
        Me.tabLoading.Controls.Add(Me.lblLoadingText)
        Me.tabLoading.Controls.Add(Me.itemsNotificationList)
        Me.tabLoading.Controls.Add(Me.itemsWatchList)
        Me.tabLoading.Controls.Add(Me.itemsSeenList)
        Me.tabLoading.Controls.Add(Me.itemsFavouritesList)
        Me.tabLoading.Controls.Add(Me.richtxtMovieDb)
        Me.tabLoading.Controls.Add(Me.lblSearchingText)
        Me.tabLoading.Location = New System.Drawing.Point(23, 4)
        Me.tabLoading.Name = "tabLoading"
        Me.tabLoading.Size = New System.Drawing.Size(1295, 680)
        Me.tabLoading.TabIndex = 5
        Me.tabLoading.Text = "tabLoading"
        '
        'itemsCollectionsBookmarked
        '
        Me.itemsCollectionsBookmarked.FormattingEnabled = True
        Me.itemsCollectionsBookmarked.Location = New System.Drawing.Point(689, 287)
        Me.itemsCollectionsBookmarked.Name = "itemsCollectionsBookmarked"
        Me.itemsCollectionsBookmarked.Size = New System.Drawing.Size(120, 95)
        Me.itemsCollectionsBookmarked.TabIndex = 36
        Me.itemsCollectionsBookmarked.Visible = False
        '
        'itemsDownloads
        '
        Me.itemsDownloads.FormattingEnabled = True
        Me.itemsDownloads.Location = New System.Drawing.Point(550, 287)
        Me.itemsDownloads.Name = "itemsDownloads"
        Me.itemsDownloads.Size = New System.Drawing.Size(120, 95)
        Me.itemsDownloads.TabIndex = 35
        Me.itemsDownloads.Visible = False
        '
        'itemsMoviesNewReleases
        '
        Me.itemsMoviesNewReleases.FormattingEnabled = True
        Me.itemsMoviesNewReleases.Location = New System.Drawing.Point(411, 287)
        Me.itemsMoviesNewReleases.Name = "itemsMoviesNewReleases"
        Me.itemsMoviesNewReleases.Size = New System.Drawing.Size(120, 95)
        Me.itemsMoviesNewReleases.TabIndex = 32
        Me.itemsMoviesNewReleases.Visible = False
        '
        'itemsMoviesTopRated
        '
        Me.itemsMoviesTopRated.FormattingEnabled = True
        Me.itemsMoviesTopRated.Location = New System.Drawing.Point(276, 287)
        Me.itemsMoviesTopRated.Name = "itemsMoviesTopRated"
        Me.itemsMoviesTopRated.Size = New System.Drawing.Size(120, 95)
        Me.itemsMoviesTopRated.TabIndex = 31
        Me.itemsMoviesTopRated.Visible = False
        '
        'itemsMoviesTrending
        '
        Me.itemsMoviesTrending.FormattingEnabled = True
        Me.itemsMoviesTrending.Location = New System.Drawing.Point(138, 287)
        Me.itemsMoviesTrending.Name = "itemsMoviesTrending"
        Me.itemsMoviesTrending.Size = New System.Drawing.Size(120, 95)
        Me.itemsMoviesTrending.TabIndex = 30
        Me.itemsMoviesTrending.Visible = False
        '
        'itemsRecentlyWatched
        '
        Me.itemsRecentlyWatched.FormattingEnabled = True
        Me.itemsRecentlyWatched.Location = New System.Drawing.Point(964, 175)
        Me.itemsRecentlyWatched.Name = "itemsRecentlyWatched"
        Me.itemsRecentlyWatched.Size = New System.Drawing.Size(120, 95)
        Me.itemsRecentlyWatched.TabIndex = 29
        Me.itemsRecentlyWatched.Visible = False
        '
        'itemsBlackList
        '
        Me.itemsBlackList.FormattingEnabled = True
        Me.itemsBlackList.Location = New System.Drawing.Point(827, 175)
        Me.itemsBlackList.Name = "itemsBlackList"
        Me.itemsBlackList.Size = New System.Drawing.Size(120, 95)
        Me.itemsBlackList.TabIndex = 28
        Me.itemsBlackList.Visible = False
        '
        'lblLoadingText
        '
        Me.lblLoadingText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoadingText.BackColor = System.Drawing.Color.Transparent
        Me.lblLoadingText.BorderColor = System.Drawing.Color.White
        Me.lblLoadingText.BorderShow = False
        Me.lblLoadingText.ColorFillSolid = System.Drawing.Color.Transparent
        Me.lblLoadingText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLoadingText.DesignerSelected = False
        Me.lblLoadingText.DimFactorClick = 0
        Me.lblLoadingText.DimFactorHover = 0
        Me.lblLoadingText.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblLoadingText.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoadingText.ImageIndex = 0
        Me.lblLoadingText.Location = New System.Drawing.Point(104, 71)
        Me.lblLoadingText.Name = "lblLoadingText"
        Me.lblLoadingText.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblLoadingText.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoadingText.SideImageSize = New System.Drawing.Size(17, 18)
        Me.lblLoadingText.Size = New System.Drawing.Size(1086, 32)
        Me.lblLoadingText.TabIndex = 27
        Me.lblLoadingText.Text = "Loading..."
        Me.lblLoadingText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblLoadingText.TextShadow = System.Drawing.Color.White
        Me.lblLoadingText.TextShadowShow = False
        '
        'itemsNotificationList
        '
        Me.itemsNotificationList.FormattingEnabled = True
        Me.itemsNotificationList.Location = New System.Drawing.Point(411, 175)
        Me.itemsNotificationList.Name = "itemsNotificationList"
        Me.itemsNotificationList.Size = New System.Drawing.Size(120, 95)
        Me.itemsNotificationList.TabIndex = 26
        Me.itemsNotificationList.Visible = False
        '
        'itemsWatchList
        '
        Me.itemsWatchList.FormattingEnabled = True
        Me.itemsWatchList.Location = New System.Drawing.Point(689, 176)
        Me.itemsWatchList.Name = "itemsWatchList"
        Me.itemsWatchList.Size = New System.Drawing.Size(120, 95)
        Me.itemsWatchList.TabIndex = 25
        Me.itemsWatchList.Visible = False
        '
        'itemsSeenList
        '
        Me.itemsSeenList.FormattingEnabled = True
        Me.itemsSeenList.Location = New System.Drawing.Point(550, 175)
        Me.itemsSeenList.Name = "itemsSeenList"
        Me.itemsSeenList.Size = New System.Drawing.Size(120, 95)
        Me.itemsSeenList.TabIndex = 24
        Me.itemsSeenList.Visible = False
        '
        'itemsFavouritesList
        '
        Me.itemsFavouritesList.FormattingEnabled = True
        Me.itemsFavouritesList.Location = New System.Drawing.Point(138, 175)
        Me.itemsFavouritesList.Name = "itemsFavouritesList"
        Me.itemsFavouritesList.Size = New System.Drawing.Size(120, 95)
        Me.itemsFavouritesList.TabIndex = 22
        Me.itemsFavouritesList.Visible = False
        '
        'richtxtMovieDb
        '
        Me.richtxtMovieDb.Location = New System.Drawing.Point(276, 175)
        Me.richtxtMovieDb.Name = "richtxtMovieDb"
        Me.richtxtMovieDb.Size = New System.Drawing.Size(120, 96)
        Me.richtxtMovieDb.TabIndex = 23
        Me.richtxtMovieDb.Text = ""
        Me.richtxtMovieDb.Visible = False
        '
        'lblSearchingText
        '
        Me.lblSearchingText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSearchingText.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchingText.BorderColor = System.Drawing.Color.White
        Me.lblSearchingText.BorderShow = False
        Me.lblSearchingText.ColorFillSolid = System.Drawing.Color.Transparent
        Me.lblSearchingText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearchingText.DesignerSelected = False
        Me.lblSearchingText.DimFactorClick = 0
        Me.lblSearchingText.DimFactorHover = 0
        Me.lblSearchingText.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblSearchingText.Font = New System.Drawing.Font("Segoe UI Semibold", 13.5!)
        Me.lblSearchingText.ImageIndex = 0
        Me.lblSearchingText.Location = New System.Drawing.Point(104, 99)
        Me.lblSearchingText.Name = "lblSearchingText"
        Me.lblSearchingText.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblSearchingText.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSearchingText.SideImageSize = New System.Drawing.Size(17, 18)
        Me.lblSearchingText.Size = New System.Drawing.Size(1086, 209)
        Me.lblSearchingText.TabIndex = 6
        Me.lblSearchingText.Text = "Please wait, we're loading your movies..."
        Me.lblSearchingText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblSearchingText.TextShadow = System.Drawing.Color.White
        Me.lblSearchingText.TextShadowShow = False
        '
        'tabSearches
        '
        Me.tabSearches.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSearches.Controls.Add(Me.tabsSearches)
        Me.tabSearches.Location = New System.Drawing.Point(23, 4)
        Me.tabSearches.Name = "tabSearches"
        Me.tabSearches.Size = New System.Drawing.Size(1295, 680)
        Me.tabSearches.TabIndex = 11
        Me.tabSearches.Text = "tabSearches"
        '
        'tabsSearches
        '
        Me.tabsSearches.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabsSearches.Controls.Add(Me.tabSearchesHome)
        Me.tabsSearches.Controls.Add(Me.tabSearchesMovies)
        Me.tabsSearches.Location = New System.Drawing.Point(-2, -22)
        Me.tabsSearches.Name = "tabsSearches"
        Me.tabsSearches.SelectedIndex = 0
        Me.tabsSearches.Size = New System.Drawing.Size(1299, 713)
        Me.tabsSearches.TabIndex = 100010
        '
        'tabSearchesHome
        '
        Me.tabSearchesHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSearchesHome.Controls.Add(Me.Label3)
        Me.tabSearchesHome.Controls.Add(Me.PictureBox3)
        Me.tabSearchesHome.Controls.Add(Me.Label2)
        Me.tabSearchesHome.Controls.Add(Me.PictureBox2)
        Me.tabSearchesHome.Controls.Add(Me.Label1)
        Me.tabSearchesHome.Controls.Add(Me.PictureBox1)
        Me.tabSearchesHome.Location = New System.Drawing.Point(4, 22)
        Me.tabSearchesHome.Name = "tabSearchesHome"
        Me.tabSearchesHome.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearchesHome.Size = New System.Drawing.Size(1291, 687)
        Me.tabSearchesHome.TabIndex = 0
        Me.tabSearchesHome.Text = "tabSearchesHome"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(836, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 44)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Paste HTTP links"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.Image = Global.Movieo.My.Resources.Resources.iconURLs
        Me.PictureBox3.Location = New System.Drawing.Point(890, 82)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(256, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 44)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search for movies"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.Movieo.My.Resources.Resources.iconMovies
        Me.PictureBox2.Location = New System.Drawing.Point(310, 82)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(546, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search for actors, directors and writers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.Movieo.My.Resources.Resources.iconActors
        Me.PictureBox1.Location = New System.Drawing.Point(600, 82)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tabSearchesMovies
        '
        Me.tabSearchesMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSearchesMovies.Controls.Add(Me.imgPanelsEmptySearches)
        Me.tabSearchesMovies.Controls.Add(Me.panelSearches)
        Me.tabSearchesMovies.Location = New System.Drawing.Point(4, 22)
        Me.tabSearchesMovies.Name = "tabSearchesMovies"
        Me.tabSearchesMovies.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearchesMovies.Size = New System.Drawing.Size(1291, 687)
        Me.tabSearchesMovies.TabIndex = 1
        Me.tabSearchesMovies.Text = "tabSearchesHome"
        '
        'imgPanelsEmptySearches
        '
        Me.imgPanelsEmptySearches.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanelsEmptySearches.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmptySearches.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.imgPanelsEmptySearches.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmptySearches.Location = New System.Drawing.Point(141, 82)
        Me.imgPanelsEmptySearches.Name = "imgPanelsEmptySearches"
        Me.imgPanelsEmptySearches.Size = New System.Drawing.Size(1007, 56)
        Me.imgPanelsEmptySearches.TabIndex = 10007
        Me.imgPanelsEmptySearches.Text = "Nothing to see here..."
        Me.imgPanelsEmptySearches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.imgPanelsEmptySearches.Visible = False
        '
        'panelSearches
        '
        Me.panelSearches.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSearches.AutoScroll = True
        Me.panelSearches.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelSearches.Location = New System.Drawing.Point(0, 0)
        Me.panelSearches.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelSearches.Name = "panelSearches"
        Me.panelSearches.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.panelSearches.Size = New System.Drawing.Size(1291, 687)
        Me.panelSearches.TabIndex = 10008
        '
        'txtboxSearchBG
        '
        Me.txtboxSearchBG.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtboxSearchBG.BackColor = System.Drawing.Color.Transparent
        Me.txtboxSearchBG.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtboxSearchBG.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtboxSearchBG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearchBG.DesignerSelected = False
        Me.txtboxSearchBG.DimFactorClick = 0
        Me.txtboxSearchBG.DimFactorHover = 0
        Me.txtboxSearchBG.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtboxSearchBG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtboxSearchBG.ImageIndex = 0
        Me.txtboxSearchBG.Location = New System.Drawing.Point(974, 0)
        Me.txtboxSearchBG.Name = "txtboxSearchBG"
        Me.txtboxSearchBG.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtboxSearchBG.Size = New System.Drawing.Size(255, 46)
        Me.txtboxSearchBG.TabIndex = 100025
        Me.txtboxSearchBG.Text = ""
        Me.txtboxSearchBG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtboxSearchBG.TextShadow = System.Drawing.Color.White
        Me.txtboxSearchBG.TextShadowShow = False
        '
        'TextUseBrowseTab
        '
        Me.TextUseBrowseTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextUseBrowseTab.BackColor = System.Drawing.Color.Transparent
        Me.TextUseBrowseTab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextUseBrowseTab.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TextUseBrowseTab.Location = New System.Drawing.Point(127, 224)
        Me.TextUseBrowseTab.Name = "TextUseBrowseTab"
        Me.TextUseBrowseTab.Size = New System.Drawing.Size(1040, 253)
        Me.TextUseBrowseTab.TabIndex = 19
        Me.TextUseBrowseTab.Text = "Use the 'Movies' tab to find a movie :)"
        Me.TextUseBrowseTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerStartup
        '
        Me.timerStartup.Interval = 750
        '
        'timerGetUpdate
        '
        Me.timerGetUpdate.Interval = 750
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
        'panelTabTitles
        '
        Me.panelTabTitles.BackColor = System.Drawing.Color.Transparent
        Me.panelTabTitles.Controls.Add(Me.fncSplitter2)
        Me.panelTabTitles.Controls.Add(Me.titleCoreMyLists)
        Me.panelTabTitles.Controls.Add(Me.txtboxSearch)
        Me.panelTabTitles.Controls.Add(Me.btnInfoMenu)
        Me.panelTabTitles.Controls.Add(Me.titleCoreDiscover)
        Me.panelTabTitles.Controls.Add(Me.imgSearchIcon)
        Me.panelTabTitles.Controls.Add(Me.txtboxSearchBG)
        Me.panelTabTitles.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTabTitles.Location = New System.Drawing.Point(0, 0)
        Me.panelTabTitles.Name = "panelTabTitles"
        Me.panelTabTitles.Size = New System.Drawing.Size(1291, 46)
        Me.panelTabTitles.TabIndex = 1027
        '
        'fncSplitter2
        '
        Me.fncSplitter2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fncSplitter2.BackColor = System.Drawing.Color.Transparent
        Me.fncSplitter2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter2.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter2.Cursor = System.Windows.Forms.Cursors.Default
        Me.fncSplitter2.DesignerSelected = False
        Me.fncSplitter2.DimFactorClick = 0
        Me.fncSplitter2.DimFactorHover = 0
        Me.fncSplitter2.FillType = CButtonLib.CButton.eFillType.Solid
        Me.fncSplitter2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.fncSplitter2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter2.ImageIndex = 0
        Me.fncSplitter2.Location = New System.Drawing.Point(1242, 16)
        Me.fncSplitter2.Name = "fncSplitter2"
        Me.fncSplitter2.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.fncSplitter2.SideImageSize = New System.Drawing.Size(14, 15)
        Me.fncSplitter2.Size = New System.Drawing.Size(1, 16)
        Me.fncSplitter2.TabIndex = 100029
        Me.fncSplitter2.TabStop = False
        Me.fncSplitter2.Text = ""
        Me.fncSplitter2.TextShadow = System.Drawing.Color.White
        Me.fncSplitter2.TextShadowShow = False
        '
        'titleCoreMyLists
        '
        Me.titleCoreMyLists.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.titleCoreMyLists.BackColor = System.Drawing.Color.Transparent
        Me.titleCoreMyLists.BorderColor = System.Drawing.Color.Transparent
        Me.titleCoreMyLists.BorderShow = False
        Me.titleCoreMyLists.ColorFillSolid = System.Drawing.Color.Transparent
        Me.titleCoreMyLists.Corners.UpperLeft = 2
        Me.titleCoreMyLists.Corners.UpperRight = 2
        Me.titleCoreMyLists.Cursor = System.Windows.Forms.Cursors.Hand
        Me.titleCoreMyLists.DesignerSelected = False
        Me.titleCoreMyLists.DimFactorClick = 0
        Me.titleCoreMyLists.DimFactorHover = 0
        Me.titleCoreMyLists.FillType = CButtonLib.CButton.eFillType.Solid
        Me.titleCoreMyLists.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.titleCoreMyLists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.titleCoreMyLists.ImageIndex = 0
        Me.titleCoreMyLists.Location = New System.Drawing.Point(87, 11)
        Me.titleCoreMyLists.Margin = New System.Windows.Forms.Padding(0)
        Me.titleCoreMyLists.Name = "titleCoreMyLists"
        Me.titleCoreMyLists.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.titleCoreMyLists.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.titleCoreMyLists.SideImageSize = New System.Drawing.Size(14, 15)
        Me.titleCoreMyLists.Size = New System.Drawing.Size(70, 24)
        Me.titleCoreMyLists.TabIndex = 100006
        Me.titleCoreMyLists.TabStop = False
        Me.titleCoreMyLists.Text = "MY LISTS"
        Me.titleCoreMyLists.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.titleCoreMyLists.TextShadow = System.Drawing.Color.White
        Me.titleCoreMyLists.TextShadowShow = False
        '
        'btnInfoMenu
        '
        Me.btnInfoMenu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnInfoMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnInfoMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInfoMenu.Image = Global.Movieo.My.Resources.Resources.DropletsIconL
        Me.btnInfoMenu.Location = New System.Drawing.Point(1249, 8)
        Me.btnInfoMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInfoMenu.Name = "btnInfoMenu"
        Me.btnInfoMenu.Size = New System.Drawing.Size(34, 32)
        Me.btnInfoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnInfoMenu.TabIndex = 1006
        Me.btnInfoMenu.TabStop = False
        '
        'titleCoreDiscover
        '
        Me.titleCoreDiscover.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.titleCoreDiscover.BackColor = System.Drawing.Color.Transparent
        Me.titleCoreDiscover.BorderColor = System.Drawing.Color.Transparent
        Me.titleCoreDiscover.BorderShow = False
        Me.titleCoreDiscover.ColorFillSolid = System.Drawing.Color.Transparent
        Me.titleCoreDiscover.Corners.UpperLeft = 2
        Me.titleCoreDiscover.Corners.UpperRight = 2
        Me.titleCoreDiscover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.titleCoreDiscover.DesignerSelected = False
        Me.titleCoreDiscover.DimFactorClick = 0
        Me.titleCoreDiscover.DimFactorHover = 0
        Me.titleCoreDiscover.FillType = CButtonLib.CButton.eFillType.Solid
        Me.titleCoreDiscover.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.titleCoreDiscover.ImageIndex = 0
        Me.titleCoreDiscover.Location = New System.Drawing.Point(10, 11)
        Me.titleCoreDiscover.Margin = New System.Windows.Forms.Padding(0)
        Me.titleCoreDiscover.Name = "titleCoreDiscover"
        Me.titleCoreDiscover.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.titleCoreDiscover.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.titleCoreDiscover.SideImageSize = New System.Drawing.Size(14, 15)
        Me.titleCoreDiscover.Size = New System.Drawing.Size(76, 24)
        Me.titleCoreDiscover.TabIndex = 2
        Me.titleCoreDiscover.TabStop = False
        Me.titleCoreDiscover.Text = "DISCOVER"
        Me.titleCoreDiscover.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.titleCoreDiscover.TextShadow = System.Drawing.Color.White
        Me.titleCoreDiscover.TextShadowShow = False
        '
        'imgSearchIcon
        '
        Me.imgSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.imgSearchIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.imgSearchIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgSearchIcon.Image = CType(resources.GetObject("imgSearchIcon.Image"), System.Drawing.Image)
        Me.imgSearchIcon.Location = New System.Drawing.Point(985, 15)
        Me.imgSearchIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.imgSearchIcon.Name = "imgSearchIcon"
        Me.imgSearchIcon.Size = New System.Drawing.Size(18, 18)
        Me.imgSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSearchIcon.TabIndex = 100026
        Me.imgSearchIcon.TabStop = False
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
        'ContentToFilter4
        '
        Me.ContentToFilter4.FormattingEnabled = True
        Me.ContentToFilter4.Location = New System.Drawing.Point(494, 5)
        Me.ContentToFilter4.Name = "ContentToFilter4"
        Me.ContentToFilter4.Size = New System.Drawing.Size(66, 17)
        Me.ContentToFilter4.TabIndex = 100004
        Me.ContentToFilter4.Visible = False
        '
        'timerResetFilters
        '
        Me.timerResetFilters.Interval = 750
        '
        'timerFilterGenre
        '
        Me.timerFilterGenre.Interval = 750
        '
        'timerSearchMovies
        '
        Me.timerSearchMovies.Interval = 750
        '
        'timerHideNotifications
        '
        Me.timerHideNotifications.Interval = 4000
        '
        'imgDropShadowMainTabs
        '
        Me.imgDropShadowMainTabs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgDropShadowMainTabs.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.imgDropShadowMainTabs.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgDropShadowMainTabs.Image = Global.Movieo.My.Resources.Resources.Drop_Shadow
        Me.imgDropShadowMainTabs.Location = New System.Drawing.Point(-354, 32)
        Me.imgDropShadowMainTabs.Name = "imgDropShadowMainTabs"
        Me.imgDropShadowMainTabs.Size = New System.Drawing.Size(2000, 22)
        Me.imgDropShadowMainTabs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDropShadowMainTabs.TabIndex = 100003
        Me.imgDropShadowMainTabs.TabStop = False
        '
        'icoLoadingWeb
        '
        Me.icoLoadingWeb.Location = New System.Drawing.Point(0, 0)
        Me.icoLoadingWeb.Name = "icoLoadingWeb"
        Me.icoLoadingWeb.Size = New System.Drawing.Size(100, 50)
        Me.icoLoadingWeb.TabIndex = 0
        Me.icoLoadingWeb.TabStop = False
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtboxSearch.ForeColor = System.Drawing.Color.White
        Me.txtboxSearch.Location = New System.Drawing.Point(1009, 13)
        Me.txtboxSearch.MaxLength = 50
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(213, 18)
        Me.txtboxSearch.TabIndex = 100022
        Me.txtboxSearch.WaterMark = "Search movies, people, years..."
        Me.txtboxSearch.WaterMarkActiveForeColor = System.Drawing.Color.White
        Me.txtboxSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtboxSearch.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        '
        'Movieo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1291, 733)
        Me.Controls.Add(Me.panelTabTitles)
        Me.Controls.Add(Me.ContentToFilter4)
        Me.Controls.Add(Me.ContentToFilter3)
        Me.Controls.Add(Me.ContentToFilter2)
        Me.Controls.Add(Me.ContentToFilter1)
        Me.Controls.Add(Me.imgDropShadowMainTabs)
        Me.Controls.Add(Me.Tab)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(864, 369)
        Me.Name = "Movieo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movieo - Discover and watch movies instantly"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Tab.ResumeLayout(False)
        Me.tabDiscover.ResumeLayout(False)
        Me.panelGenres.ResumeLayout(False)
        Me.tabMyLists.ResumeLayout(False)
        Me.panelMyLists.ResumeLayout(False)
        Me.tabsMyLists.ResumeLayout(False)
        Me.tabMyListsFavourites.ResumeLayout(False)
        Me.tabMyListsWatchList.ResumeLayout(False)
        Me.tabMyListsSeenList.ResumeLayout(False)
        Me.tabMyListsBlackList.ResumeLayout(False)
        Me.tabLoading.ResumeLayout(False)
        Me.tabSearches.ResumeLayout(False)
        Me.tabsSearches.ResumeLayout(False)
        Me.tabSearchesHome.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearchesMovies.ResumeLayout(False)
        Me.panelTabTitles.ResumeLayout(False)
        Me.panelTabTitles.PerformLayout()
        CType(Me.btnInfoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDropShadowMainTabs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab As TabControl
    Friend WithEvents tabDiscover As TabPage
    Friend WithEvents timerStartup As Timer
    Friend WithEvents tabLoading As TabPage
    Friend WithEvents txtPlayingTitle As Label
    Friend WithEvents TextUseBrowseTab As Label
    Friend WithEvents timerGetUpdate As Timer
    Friend WithEvents icoLoadingWeb As PictureBox
    Friend WithEvents ContentToFilter1 As ListBox
    Friend WithEvents ContentToFilter2 As ListBox
    Friend WithEvents GoFilm As Button
    Friend WithEvents FaveMovie As Button
    Friend WithEvents iconReportMovie As Button
    Friend WithEvents iconCloseMovie As Button
    Friend WithEvents panelTabTitles As Panel
    Friend WithEvents ContentToFilter3 As ListBox
    Public WithEvents titleCoreDiscover As CButtonLib.CButton
    Friend WithEvents btnInfoMenu As PictureBox
    Friend WithEvents lblSearchingText As CButtonLib.CButton
    Friend WithEvents itemsWatchList As ListBox
    Friend WithEvents itemsSeenList As ListBox
    Friend WithEvents itemsFavouritesList As ListBox
    Friend WithEvents richtxtMovieDb As RichTextBox
    Friend WithEvents itemsNotificationList As ListBox
    Friend WithEvents lblLoadingText As CButtonLib.CButton
    Friend WithEvents ContentToFilter4 As ListBox
    Friend WithEvents itemsBlackList As ListBox
    Friend WithEvents imgDropShadowMainTabs As PictureBox
    Friend WithEvents imgPanelsEmptyAllMovies As Label
    Friend WithEvents panelMovies As FlowLayoutPanel
    Friend WithEvents itemsRecentlyWatched As ListBox
    Friend WithEvents itemsMoviesTrending As ListBox
    Friend WithEvents itemsMoviesTopRated As ListBox
    Friend WithEvents itemsMoviesNewReleases As ListBox
    Friend WithEvents itemsDownloads As ListBox
    Friend WithEvents titleCoreMyLists As CButtonLib.CButton
    Friend WithEvents tabMyLists As TabPage
    Friend WithEvents tabsMyLists As TabControl
    Friend WithEvents tabMyListsFavourites As TabPage
    Friend WithEvents tabMyListsWatchList As TabPage
    Friend WithEvents tabMyListsSeenList As TabPage
    Friend WithEvents tabMyListsBlackList As TabPage
    Friend WithEvents imgPanelsEmptyFavourites As Label
    Friend WithEvents panelMyListsFavourites As FlowLayoutPanel
    Friend WithEvents imgPanelsEmptyWatchList As Label
    Friend WithEvents panelMyListsWatchList As FlowLayoutPanel
    Friend WithEvents imgPanelsEmptySeenList As Label
    Friend WithEvents panelMyListsSeenList As FlowLayoutPanel
    Friend WithEvents imgPanelsEmptyBlackList As Label
    Friend WithEvents panelMyListsBlackList As FlowLayoutPanel
    Friend WithEvents itemsCollectionsBookmarked As ListBox
    Friend WithEvents txtboxSearch As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents imgSearchIcon As PictureBox
    Friend WithEvents txtboxSearchBG As CButtonLib.CButton
    Friend WithEvents timerResetFilters As Timer
    Friend WithEvents timerFilterGenre As Timer
    Friend WithEvents timerSearchMovies As Timer
    Friend WithEvents fncSplitter2 As CButtonLib.CButton
    Friend WithEvents tabSearches As TabPage
    Friend WithEvents tabsSearches As TabControl
    Friend WithEvents tabSearchesHome As TabPage
    Friend WithEvents tabSearchesMovies As TabPage
    Friend WithEvents imgPanelsEmptySearches As Label
    Friend WithEvents panelSearches As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelGenres As Panel
    Friend WithEvents btnGenreAllMovies As CButtonLib.CButton
    Friend WithEvents btnGenreWestern As CButtonLib.CButton
    Friend WithEvents btnGenreWar As CButtonLib.CButton
    Friend WithEvents btnGenreThriller As CButtonLib.CButton
    Friend WithEvents btnGenreSciFi As CButtonLib.CButton
    Friend WithEvents btnGenreRomance As CButtonLib.CButton
    Friend WithEvents btnGenreMystery As CButtonLib.CButton
    Friend WithEvents btnGenreMusic As CButtonLib.CButton
    Friend WithEvents btnGenreHorror As CButtonLib.CButton
    Friend WithEvents btnGenreHistory As CButtonLib.CButton
    Friend WithEvents btnGenreFantasy As CButtonLib.CButton
    Friend WithEvents btnGenreFamily As CButtonLib.CButton
    Friend WithEvents btnGenreDrama As CButtonLib.CButton
    Friend WithEvents btnGenreDocumentary As CButtonLib.CButton
    Friend WithEvents btnGenreCrime As CButtonLib.CButton
    Friend WithEvents btnGenreComedy As CButtonLib.CButton
    Friend WithEvents btnGenreAnimation As CButtonLib.CButton
    Friend WithEvents btnGenreAdventure As CButtonLib.CButton
    Friend WithEvents btnGenreAction As CButtonLib.CButton
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents panelMyLists As Panel
    Friend WithEvents btnListsBlack As CButtonLib.CButton
    Friend WithEvents btnListsSeen As CButtonLib.CButton
    Friend WithEvents btnListWatch As CButtonLib.CButton
    Friend WithEvents btnListsFavourites As CButtonLib.CButton
End Class
