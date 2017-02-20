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
        Me.tabMovies = New System.Windows.Forms.TabPage()
        Me.imgPanelsEmpty0 = New System.Windows.Forms.Label()
        Me.PanelMovies = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabFavourites = New System.Windows.Forms.TabPage()
        Me.imgPanelsEmpty1 = New System.Windows.Forms.PictureBox()
        Me.PanelFavourites = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabWatchList = New System.Windows.Forms.TabPage()
        Me.imgPanelsEmpty2 = New System.Windows.Forms.PictureBox()
        Me.PanelWatchList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLoading = New System.Windows.Forms.TabPage()
        Me.itemsBlackList = New System.Windows.Forms.ListBox()
        Me.lblLoadingText = New CButtonLib.CButton()
        Me.itemsNotificationList = New System.Windows.Forms.ListBox()
        Me.itemsWatchList = New System.Windows.Forms.ListBox()
        Me.itemsSeenList = New System.Windows.Forms.ListBox()
        Me.itemsFavouritesList = New System.Windows.Forms.ListBox()
        Me.richtxtMovieDb = New System.Windows.Forms.RichTextBox()
        Me.lblSearchingText = New CButtonLib.CButton()
        Me.tabSeenList = New System.Windows.Forms.TabPage()
        Me.PanelSeenList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabBlackList = New System.Windows.Forms.TabPage()
        Me.PanelBlackList = New System.Windows.Forms.FlowLayoutPanel()
        Me.BgPanel = New System.Windows.Forms.Panel()
        Me.cmboTextGenre = New CButtonLib.CButton()
        Me.filterGenreBox = New System.Windows.Forms.ComboBox()
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
        Me.txtBlackList = New CButtonLib.CButton()
        Me.txtSeenList = New CButtonLib.CButton()
        Me.SearchClose = New System.Windows.Forms.PictureBox()
        Me.FncSplitter = New CButtonLib.CButton()
        Me.TxtSearchIcon = New System.Windows.Forms.PictureBox()
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
        Me.btnRequestMovie = New System.Windows.Forms.Label()
        Me.SearchFavourites = New System.Windows.Forms.Timer(Me.components)
        Me.SearchWatchList = New System.Windows.Forms.Timer(Me.components)
        Me.FilterSearchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ResetFiltersTimer = New System.Windows.Forms.Timer(Me.components)
        Me.KeyShortcuts = New System.Windows.Forms.Timer(Me.components)
        Me.ContentToFilter4 = New System.Windows.Forms.ListBox()
        Me.imgUnderlineGlow = New System.Windows.Forms.PictureBox()
        Me.imgCelebrationMonth = New System.Windows.Forms.PictureBox()
        Me.BtnSendFeedback = New System.Windows.Forms.PictureBox()
        Me.icoLoadingWeb = New System.Windows.Forms.PictureBox()
        Me.TxtSearchBox = New RtfExtensions()
        Me.imgPanelsEmpty3 = New System.Windows.Forms.PictureBox()
        Me.imgPanelsEmpty4 = New System.Windows.Forms.PictureBox()
        Me.Tab.SuspendLayout()
        Me.tabMovies.SuspendLayout()
        Me.tabFavourites.SuspendLayout()
        CType(Me.imgPanelsEmpty1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWatchList.SuspendLayout()
        CType(Me.imgPanelsEmpty2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLoading.SuspendLayout()
        Me.tabSeenList.SuspendLayout()
        Me.tabBlackList.SuspendLayout()
        Me.BgPanel.SuspendLayout()
        Me.PanelTabTitles.SuspendLayout()
        CType(Me.SearchClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTopRight.SuspendLayout()
        CType(Me.AppExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgUnderlineGlow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCelebrationMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSendFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPanelsEmpty3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPanelsEmpty4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.CausesValidation = False
        Me.Tab.Controls.Add(Me.tabMovies)
        Me.Tab.Controls.Add(Me.tabFavourites)
        Me.Tab.Controls.Add(Me.tabWatchList)
        Me.Tab.Controls.Add(Me.tabSeenList)
        Me.Tab.Controls.Add(Me.tabBlackList)
        Me.Tab.Controls.Add(Me.tabLoading)
        Me.Tab.Location = New System.Drawing.Point(-25, 82)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1322, 664)
        Me.Tab.TabIndex = 1000
        Me.Tab.TabStop = False
        '
        'tabMovies
        '
        Me.tabMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabMovies.Controls.Add(Me.imgPanelsEmpty0)
        Me.tabMovies.Controls.Add(Me.PanelMovies)
        Me.tabMovies.Location = New System.Drawing.Point(23, 4)
        Me.tabMovies.Margin = New System.Windows.Forms.Padding(0)
        Me.tabMovies.Name = "tabMovies"
        Me.tabMovies.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.tabMovies.Size = New System.Drawing.Size(1295, 656)
        Me.tabMovies.TabIndex = 0
        Me.tabMovies.Text = "tabBrowse"
        '
        'imgPanelsEmpty0
        '
        Me.imgPanelsEmpty0.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanelsEmpty0.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty0.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgPanelsEmpty0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmpty0.Location = New System.Drawing.Point(85, 98)
        Me.imgPanelsEmpty0.Name = "imgPanelsEmpty0"
        Me.imgPanelsEmpty0.Size = New System.Drawing.Size(1124, 56)
        Me.imgPanelsEmpty0.TabIndex = 10004
        Me.imgPanelsEmpty0.Text = "No movies found..."
        Me.imgPanelsEmpty0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.imgPanelsEmpty0.Visible = False
        '
        'PanelMovies
        '
        Me.PanelMovies.AutoScroll = True
        Me.PanelMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelMovies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMovies.Location = New System.Drawing.Point(2, 0)
        Me.PanelMovies.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.PanelMovies.Name = "PanelMovies"
        Me.PanelMovies.Padding = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.PanelMovies.Size = New System.Drawing.Size(1291, 654)
        Me.PanelMovies.TabIndex = 9
        '
        'tabFavourites
        '
        Me.tabFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabFavourites.Controls.Add(Me.imgPanelsEmpty1)
        Me.tabFavourites.Controls.Add(Me.PanelFavourites)
        Me.tabFavourites.Location = New System.Drawing.Point(23, 4)
        Me.tabFavourites.Name = "tabFavourites"
        Me.tabFavourites.Size = New System.Drawing.Size(1295, 656)
        Me.tabFavourites.TabIndex = 3
        Me.tabFavourites.Text = "t"
        '
        'imgPanelsEmpty1
        '
        Me.imgPanelsEmpty1.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty1.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPanelsEmpty1.Image = CType(resources.GetObject("imgPanelsEmpty1.Image"), System.Drawing.Image)
        Me.imgPanelsEmpty1.Location = New System.Drawing.Point(115, -13)
        Me.imgPanelsEmpty1.Margin = New System.Windows.Forms.Padding(0)
        Me.imgPanelsEmpty1.Name = "imgPanelsEmpty1"
        Me.imgPanelsEmpty1.Size = New System.Drawing.Size(433, 156)
        Me.imgPanelsEmpty1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPanelsEmpty1.TabIndex = 100002
        Me.imgPanelsEmpty1.TabStop = False
        '
        'PanelFavourites
        '
        Me.PanelFavourites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelFavourites.AutoScroll = True
        Me.PanelFavourites.BackColor = System.Drawing.Color.Transparent
        Me.PanelFavourites.Location = New System.Drawing.Point(2, 0)
        Me.PanelFavourites.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelFavourites.Name = "PanelFavourites"
        Me.PanelFavourites.Padding = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.PanelFavourites.Size = New System.Drawing.Size(1291, 654)
        Me.PanelFavourites.TabIndex = 2
        '
        'tabWatchList
        '
        Me.tabWatchList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabWatchList.Controls.Add(Me.imgPanelsEmpty2)
        Me.tabWatchList.Controls.Add(Me.PanelWatchList)
        Me.tabWatchList.Location = New System.Drawing.Point(23, 4)
        Me.tabWatchList.Name = "tabWatchList"
        Me.tabWatchList.Size = New System.Drawing.Size(1295, 656)
        Me.tabWatchList.TabIndex = 6
        Me.tabWatchList.Text = "tabWatchList"
        '
        'imgPanelsEmpty2
        '
        Me.imgPanelsEmpty2.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty2.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPanelsEmpty2.Image = CType(resources.GetObject("imgPanelsEmpty2.Image"), System.Drawing.Image)
        Me.imgPanelsEmpty2.Location = New System.Drawing.Point(115, -13)
        Me.imgPanelsEmpty2.Margin = New System.Windows.Forms.Padding(0)
        Me.imgPanelsEmpty2.Name = "imgPanelsEmpty2"
        Me.imgPanelsEmpty2.Size = New System.Drawing.Size(433, 156)
        Me.imgPanelsEmpty2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPanelsEmpty2.TabIndex = 100003
        Me.imgPanelsEmpty2.TabStop = False
        '
        'PanelWatchList
        '
        Me.PanelWatchList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelWatchList.AutoScroll = True
        Me.PanelWatchList.BackColor = System.Drawing.Color.Transparent
        Me.PanelWatchList.Location = New System.Drawing.Point(2, 0)
        Me.PanelWatchList.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelWatchList.Name = "PanelWatchList"
        Me.PanelWatchList.Padding = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.PanelWatchList.Size = New System.Drawing.Size(1291, 654)
        Me.PanelWatchList.TabIndex = 3
        '
        'tabLoading
        '
        Me.tabLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
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
        Me.tabLoading.Size = New System.Drawing.Size(1295, 656)
        Me.tabLoading.TabIndex = 5
        Me.tabLoading.Text = "tabLoading"
        '
        'itemsBlackList
        '
        Me.itemsBlackList.FormattingEnabled = True
        Me.itemsBlackList.Location = New System.Drawing.Point(812, 175)
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
        Me.itemsNotificationList.Location = New System.Drawing.Point(396, 175)
        Me.itemsNotificationList.Name = "itemsNotificationList"
        Me.itemsNotificationList.Size = New System.Drawing.Size(120, 95)
        Me.itemsNotificationList.TabIndex = 26
        Me.itemsNotificationList.Visible = False
        '
        'itemsWatchList
        '
        Me.itemsWatchList.FormattingEnabled = True
        Me.itemsWatchList.Location = New System.Drawing.Point(674, 176)
        Me.itemsWatchList.Name = "itemsWatchList"
        Me.itemsWatchList.Size = New System.Drawing.Size(120, 95)
        Me.itemsWatchList.TabIndex = 25
        Me.itemsWatchList.Visible = False
        '
        'itemsSeenList
        '
        Me.itemsSeenList.FormattingEnabled = True
        Me.itemsSeenList.Location = New System.Drawing.Point(535, 175)
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
        Me.richtxtMovieDb.Location = New System.Drawing.Point(279, 175)
        Me.richtxtMovieDb.Name = "richtxtMovieDb"
        Me.richtxtMovieDb.Size = New System.Drawing.Size(100, 96)
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
        'tabSeenList
        '
        Me.tabSeenList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSeenList.Controls.Add(Me.imgPanelsEmpty3)
        Me.tabSeenList.Controls.Add(Me.PanelSeenList)
        Me.tabSeenList.Location = New System.Drawing.Point(23, 4)
        Me.tabSeenList.Name = "tabSeenList"
        Me.tabSeenList.Size = New System.Drawing.Size(1295, 656)
        Me.tabSeenList.TabIndex = 7
        Me.tabSeenList.Text = "tabSeenList"
        '
        'PanelSeenList
        '
        Me.PanelSeenList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSeenList.AutoScroll = True
        Me.PanelSeenList.BackColor = System.Drawing.Color.Transparent
        Me.PanelSeenList.Location = New System.Drawing.Point(2, 0)
        Me.PanelSeenList.Name = "PanelSeenList"
        Me.PanelSeenList.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelSeenList.Size = New System.Drawing.Size(1291, 654)
        Me.PanelSeenList.TabIndex = 3
        '
        'tabBlackList
        '
        Me.tabBlackList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabBlackList.Controls.Add(Me.imgPanelsEmpty4)
        Me.tabBlackList.Controls.Add(Me.PanelBlackList)
        Me.tabBlackList.Location = New System.Drawing.Point(23, 4)
        Me.tabBlackList.Name = "tabBlackList"
        Me.tabBlackList.Size = New System.Drawing.Size(1295, 656)
        Me.tabBlackList.TabIndex = 8
        Me.tabBlackList.Text = "tabBlackList"
        '
        'PanelBlackList
        '
        Me.PanelBlackList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBlackList.AutoScroll = True
        Me.PanelBlackList.BackColor = System.Drawing.Color.Transparent
        Me.PanelBlackList.Location = New System.Drawing.Point(2, 0)
        Me.PanelBlackList.Name = "PanelBlackList"
        Me.PanelBlackList.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelBlackList.Size = New System.Drawing.Size(1291, 654)
        Me.PanelBlackList.TabIndex = 100003
        '
        'BgPanel
        '
        Me.BgPanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BgPanel.BackColor = System.Drawing.Color.Transparent
        Me.BgPanel.Controls.Add(Me.cmboTextGenre)
        Me.BgPanel.Location = New System.Drawing.Point(809, 8)
        Me.BgPanel.Name = "BgPanel"
        Me.BgPanel.Size = New System.Drawing.Size(124, 30)
        Me.BgPanel.TabIndex = 1018
        '
        'cmboTextGenre
        '
        Me.cmboTextGenre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmboTextGenre.BackColor = System.Drawing.Color.Transparent
        Me.cmboTextGenre.BorderColor = System.Drawing.Color.White
        Me.cmboTextGenre.BorderShow = False
        Me.cmboTextGenre.ColorFillSolid = System.Drawing.Color.Transparent
        Me.cmboTextGenre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboTextGenre.DesignerSelected = False
        Me.cmboTextGenre.DimFactorClick = 0
        Me.cmboTextGenre.DimFactorHover = 0
        Me.cmboTextGenre.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboTextGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmboTextGenre.ImageIndex = 0
        Me.cmboTextGenre.Location = New System.Drawing.Point(0, 0)
        Me.cmboTextGenre.Name = "cmboTextGenre"
        Me.cmboTextGenre.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboTextGenre.SideImage = CType(resources.GetObject("cmboTextGenre.SideImage"), System.Drawing.Image)
        Me.cmboTextGenre.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboTextGenre.SideImageSize = New System.Drawing.Size(17, 18)
        Me.cmboTextGenre.Size = New System.Drawing.Size(121, 30)
        Me.cmboTextGenre.TabIndex = 5
        Me.cmboTextGenre.Text = "Any Genre"
        Me.cmboTextGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboTextGenre.TextShadow = System.Drawing.Color.White
        Me.cmboTextGenre.TextShadowShow = False
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
        Me.filterGenreBox.Location = New System.Drawing.Point(810, 11)
        Me.filterGenreBox.Name = "filterGenreBox"
        Me.filterGenreBox.Size = New System.Drawing.Size(117, 27)
        Me.filterGenreBox.TabIndex = 0
        Me.filterGenreBox.TabStop = False
        Me.filterGenreBox.Visible = False
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
        Me.AppTitle.Size = New System.Drawing.Size(1291, 30)
        Me.AppTitle.TabIndex = 99999
        Me.AppTitle.Text = "Movieo"
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
        Me.PanelTabTitles.Controls.Add(Me.txtBlackList)
        Me.PanelTabTitles.Controls.Add(Me.txtSeenList)
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
        Me.PanelTabTitles.Location = New System.Drawing.Point(0, 32)
        Me.PanelTabTitles.Name = "PanelTabTitles"
        Me.PanelTabTitles.Size = New System.Drawing.Size(1291, 49)
        Me.PanelTabTitles.TabIndex = 1027
        '
        'txtBlackList
        '
        Me.txtBlackList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBlackList.BackColor = System.Drawing.Color.Transparent
        Me.txtBlackList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtBlackList.BorderShow = False
        Me.txtBlackList.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtBlackList.Corners.UpperLeft = 2
        Me.txtBlackList.Corners.UpperRight = 2
        Me.txtBlackList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBlackList.DesignerSelected = False
        Me.txtBlackList.DimFactorClick = 0
        Me.txtBlackList.DimFactorHover = 0
        Me.txtBlackList.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtBlackList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtBlackList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtBlackList.ImageIndex = 0
        Me.txtBlackList.Location = New System.Drawing.Point(619, 14)
        Me.txtBlackList.Name = "txtBlackList"
        Me.txtBlackList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtBlackList.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtBlackList.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtBlackList.Size = New System.Drawing.Size(76, 34)
        Me.txtBlackList.TabIndex = 100003
        Me.txtBlackList.Text = "Black List"
        Me.txtBlackList.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtBlackList.TextShadow = System.Drawing.Color.White
        Me.txtBlackList.TextShadowShow = False
        '
        'txtSeenList
        '
        Me.txtSeenList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSeenList.BackColor = System.Drawing.Color.Transparent
        Me.txtSeenList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtSeenList.BorderShow = False
        Me.txtSeenList.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtSeenList.Corners.UpperLeft = 2
        Me.txtSeenList.Corners.UpperRight = 2
        Me.txtSeenList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSeenList.DesignerSelected = False
        Me.txtSeenList.DimFactorClick = 0
        Me.txtSeenList.DimFactorHover = 0
        Me.txtSeenList.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtSeenList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSeenList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtSeenList.ImageIndex = 0
        Me.txtSeenList.Location = New System.Drawing.Point(537, 14)
        Me.txtSeenList.Name = "txtSeenList"
        Me.txtSeenList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtSeenList.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtSeenList.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtSeenList.Size = New System.Drawing.Size(76, 34)
        Me.txtSeenList.TabIndex = 100002
        Me.txtSeenList.Text = "Seen List"
        Me.txtSeenList.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtSeenList.TextShadow = System.Drawing.Color.White
        Me.txtSeenList.TextShadowShow = False
        '
        'SearchClose
        '
        Me.SearchClose.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SearchClose.BackColor = System.Drawing.Color.Transparent
        Me.SearchClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchClose.Image = CType(resources.GetObject("SearchClose.Image"), System.Drawing.Image)
        Me.SearchClose.Location = New System.Drawing.Point(246, 18)
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
        Me.FncSplitter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.FncSplitter.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.FncSplitter.Cursor = System.Windows.Forms.Cursors.Default
        Me.FncSplitter.DesignerSelected = False
        Me.FncSplitter.DimFactorClick = 0
        Me.FncSplitter.DimFactorHover = 0
        Me.FncSplitter.FillType = CButtonLib.CButton.eFillType.Solid
        Me.FncSplitter.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FncSplitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.FncSplitter.ImageIndex = 0
        Me.FncSplitter.Location = New System.Drawing.Point(942, 17)
        Me.FncSplitter.Name = "FncSplitter"
        Me.FncSplitter.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.FncSplitter.SideImageSize = New System.Drawing.Size(14, 15)
        Me.FncSplitter.Size = New System.Drawing.Size(2, 15)
        Me.FncSplitter.TabIndex = 1030
        Me.FncSplitter.TabStop = False
        Me.FncSplitter.Text = ""
        Me.FncSplitter.TextShadow = System.Drawing.Color.White
        Me.FncSplitter.TextShadowShow = False
        '
        'TxtSearchIcon
        '
        Me.TxtSearchIcon.BackColor = System.Drawing.Color.Transparent
        Me.TxtSearchIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtSearchIcon.Image = CType(resources.GetObject("TxtSearchIcon.Image"), System.Drawing.Image)
        Me.TxtSearchIcon.Location = New System.Drawing.Point(24, 16)
        Me.TxtSearchIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSearchIcon.Name = "TxtSearchIcon"
        Me.TxtSearchIcon.Size = New System.Drawing.Size(16, 16)
        Me.TxtSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TxtSearchIcon.TabIndex = 100000
        Me.TxtSearchIcon.TabStop = False
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
        Me.TxtSearchBg.Location = New System.Drawing.Point(12, 9)
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
        Me.BtnSortByYearReleased.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnSortByYearReleased.ImageIndex = 0
        Me.BtnSortByYearReleased.Location = New System.Drawing.Point(1148, 12)
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
        Me.BtnSortByAZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnSortByAZ.ImageIndex = 0
        Me.BtnSortByAZ.Location = New System.Drawing.Point(1246, 12)
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
        Me.BtnSortByNewlyAdded.Location = New System.Drawing.Point(955, 11)
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
        Me.BtnSortByPopularity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BtnSortByPopularity.ImageIndex = 0
        Me.BtnSortByPopularity.Location = New System.Drawing.Point(1061, 11)
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
        Me.txtWatchList.Anchor = System.Windows.Forms.AnchorStyles.Left
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
        Me.txtWatchList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtWatchList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtWatchList.ImageIndex = 0
        Me.txtWatchList.Location = New System.Drawing.Point(445, 14)
        Me.txtWatchList.Name = "txtWatchList"
        Me.txtWatchList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtWatchList.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtWatchList.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtWatchList.Size = New System.Drawing.Size(86, 34)
        Me.txtWatchList.TabIndex = 4
        Me.txtWatchList.Text = "Watch List"
        Me.txtWatchList.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtWatchList.TextShadow = System.Drawing.Color.White
        Me.txtWatchList.TextShadowShow = False
        '
        'txtFavourites
        '
        Me.txtFavourites.Anchor = System.Windows.Forms.AnchorStyles.Left
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
        Me.txtFavourites.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtFavourites.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtFavourites.ImageIndex = 0
        Me.txtFavourites.Location = New System.Drawing.Point(354, 14)
        Me.txtFavourites.Name = "txtFavourites"
        Me.txtFavourites.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtFavourites.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtFavourites.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtFavourites.Size = New System.Drawing.Size(85, 34)
        Me.txtFavourites.TabIndex = 3
        Me.txtFavourites.Text = "Favourites"
        Me.txtFavourites.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtFavourites.TextShadow = System.Drawing.Color.White
        Me.txtFavourites.TextShadowShow = False
        '
        'txtMovies
        '
        Me.txtMovies.Anchor = System.Windows.Forms.AnchorStyles.Left
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
        Me.txtMovies.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtMovies.ImageIndex = 0
        Me.txtMovies.Location = New System.Drawing.Point(285, 14)
        Me.txtMovies.Name = "txtMovies"
        Me.txtMovies.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtMovies.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtMovies.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtMovies.Size = New System.Drawing.Size(63, 34)
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
        Me.PanelTopRight.Controls.Add(Me.btnRequestMovie)
        Me.PanelTopRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.PanelTopRight.Location = New System.Drawing.Point(791, -2)
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
        Me.AppExit.Image = Global.Movieo.My.Resources.Resources.CloseAppL
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
        Me.AppMaximize.Image = Global.Movieo.My.Resources.Resources.MaximiseAppL
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
        Me.AppMinimize.Image = Global.Movieo.My.Resources.Resources.MinimiseAppL
        Me.AppMinimize.Location = New System.Drawing.Point(419, 0)
        Me.AppMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.AppMinimize.Name = "AppMinimize"
        Me.AppMinimize.Size = New System.Drawing.Size(27, 32)
        Me.AppMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppMinimize.TabIndex = 1002
        Me.AppMinimize.TabStop = False
        '
        'btnRequestMovie
        '
        Me.btnRequestMovie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRequestMovie.AutoSize = True
        Me.btnRequestMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRequestMovie.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnRequestMovie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnRequestMovie.Location = New System.Drawing.Point(320, 3)
        Me.btnRequestMovie.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.btnRequestMovie.Name = "btnRequestMovie"
        Me.btnRequestMovie.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnRequestMovie.Size = New System.Drawing.Size(99, 22)
        Me.btnRequestMovie.TabIndex = 11
        Me.btnRequestMovie.Text = "Request Movie"
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
        'KeyShortcuts
        '
        Me.KeyShortcuts.Enabled = True
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
        'imgUnderlineGlow
        '
        Me.imgUnderlineGlow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgUnderlineGlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.imgUnderlineGlow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgUnderlineGlow.Image = Global.Movieo.My.Resources.Resources.UnderlineGlow9x
        Me.imgUnderlineGlow.Location = New System.Drawing.Point(-356, 30)
        Me.imgUnderlineGlow.Name = "imgUnderlineGlow"
        Me.imgUnderlineGlow.Size = New System.Drawing.Size(2000, 56)
        Me.imgUnderlineGlow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUnderlineGlow.TabIndex = 100003
        Me.imgUnderlineGlow.TabStop = False
        '
        'imgCelebrationMonth
        '
        Me.imgCelebrationMonth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgCelebrationMonth.BackColor = System.Drawing.Color.Transparent
        Me.imgCelebrationMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCelebrationMonth.Location = New System.Drawing.Point(671, 2)
        Me.imgCelebrationMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.imgCelebrationMonth.Name = "imgCelebrationMonth"
        Me.imgCelebrationMonth.Size = New System.Drawing.Size(30, 28)
        Me.imgCelebrationMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCelebrationMonth.TabIndex = 1005
        Me.imgCelebrationMonth.TabStop = False
        '
        'BtnSendFeedback
        '
        Me.BtnSendFeedback.BackColor = System.Drawing.Color.Transparent
        Me.BtnSendFeedback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSendFeedback.Image = Global.Movieo.My.Resources.Resources.DropletsIconL
        Me.BtnSendFeedback.Location = New System.Drawing.Point(12, 0)
        Me.BtnSendFeedback.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSendFeedback.Name = "BtnSendFeedback"
        Me.BtnSendFeedback.Size = New System.Drawing.Size(34, 32)
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
        'TxtSearchBox
        '
        Me.TxtSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtSearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearchBox.DetectUrls = False
        Me.TxtSearchBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!)
        Me.TxtSearchBox.ForeColor = System.Drawing.Color.White
        Me.TxtSearchBox.Location = New System.Drawing.Point(47, 14)
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
        'imgPanelsEmpty3
        '
        Me.imgPanelsEmpty3.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty3.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPanelsEmpty3.Image = CType(resources.GetObject("imgPanelsEmpty3.Image"), System.Drawing.Image)
        Me.imgPanelsEmpty3.Location = New System.Drawing.Point(115, -13)
        Me.imgPanelsEmpty3.Margin = New System.Windows.Forms.Padding(0)
        Me.imgPanelsEmpty3.Name = "imgPanelsEmpty3"
        Me.imgPanelsEmpty3.Size = New System.Drawing.Size(433, 156)
        Me.imgPanelsEmpty3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPanelsEmpty3.TabIndex = 100003
        Me.imgPanelsEmpty3.TabStop = False
        '
        'imgPanelsEmpty4
        '
        Me.imgPanelsEmpty4.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty4.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPanelsEmpty4.Image = CType(resources.GetObject("imgPanelsEmpty4.Image"), System.Drawing.Image)
        Me.imgPanelsEmpty4.Location = New System.Drawing.Point(115, -13)
        Me.imgPanelsEmpty4.Margin = New System.Windows.Forms.Padding(0)
        Me.imgPanelsEmpty4.Name = "imgPanelsEmpty4"
        Me.imgPanelsEmpty4.Size = New System.Drawing.Size(433, 156)
        Me.imgPanelsEmpty4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPanelsEmpty4.TabIndex = 100004
        Me.imgPanelsEmpty4.TabStop = False
        '
        'Movieo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1291, 741)
        Me.Controls.Add(Me.ContentToFilter4)
        Me.Controls.Add(Me.PanelTabTitles)
        Me.Controls.Add(Me.imgUnderlineGlow)
        Me.Controls.Add(Me.PanelTopRight)
        Me.Controls.Add(Me.imgCelebrationMonth)
        Me.Controls.Add(Me.BtnSendFeedback)
        Me.Controls.Add(Me.ContentToFilter3)
        Me.Controls.Add(Me.ContentToFilter2)
        Me.Controls.Add(Me.ContentToFilter1)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.AppTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Movieo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movieo"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Tab.ResumeLayout(False)
        Me.tabMovies.ResumeLayout(False)
        Me.tabFavourites.ResumeLayout(False)
        CType(Me.imgPanelsEmpty1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWatchList.ResumeLayout(False)
        CType(Me.imgPanelsEmpty2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLoading.ResumeLayout(False)
        Me.tabSeenList.ResumeLayout(False)
        Me.tabBlackList.ResumeLayout(False)
        Me.BgPanel.ResumeLayout(False)
        Me.PanelTabTitles.ResumeLayout(False)
        CType(Me.SearchClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTopRight.ResumeLayout(False)
        Me.PanelTopRight.PerformLayout()
        CType(Me.AppExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgUnderlineGlow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCelebrationMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSendFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPanelsEmpty3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPanelsEmpty4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab As TabControl
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
    Friend WithEvents cmboTextGenre As CButtonLib.CButton
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
    Friend WithEvents btnRequestMovie As Label
    Friend WithEvents TxtSearchBox As RtfExtensions
    Friend WithEvents SearchFavourites As Timer
    Friend WithEvents SearchWatchList As Timer
    Friend WithEvents tabSeenList As TabPage
    Friend WithEvents PanelSeenList As FlowLayoutPanel
    Friend WithEvents TxtSearchIcon As PictureBox
    Friend WithEvents lblSearchingText As CButtonLib.CButton
    Friend WithEvents imgPanelsEmpty1 As PictureBox
    Friend WithEvents itemsWatchList As ListBox
    Friend WithEvents itemsSeenList As ListBox
    Friend WithEvents itemsFavouritesList As ListBox
    Friend WithEvents richtxtMovieDb As RichTextBox
    Friend WithEvents imgPanelsEmpty2 As PictureBox
    Friend WithEvents itemsNotificationList As ListBox
    Friend WithEvents FilterSearchTimer As Timer
    Friend WithEvents SearchClose As PictureBox
    Friend WithEvents ResetFiltersTimer As Timer
    Friend WithEvents lblLoadingText As CButtonLib.CButton
    Friend WithEvents KeyShortcuts As Timer
    Friend WithEvents ContentToFilter4 As ListBox
    Friend WithEvents tabBlackList As TabPage
    Friend WithEvents PanelBlackList As FlowLayoutPanel
    Friend WithEvents itemsBlackList As ListBox
    Friend WithEvents imgUnderlineGlow As PictureBox
    Friend WithEvents imgPanelsEmpty0 As Label
    Friend WithEvents imgCelebrationMonth As PictureBox
    Friend WithEvents txtBlackList As CButtonLib.CButton
    Friend WithEvents txtSeenList As CButtonLib.CButton
    Friend WithEvents imgPanelsEmpty3 As PictureBox
    Friend WithEvents imgPanelsEmpty4 As PictureBox
End Class
