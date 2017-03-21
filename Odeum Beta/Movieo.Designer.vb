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
        Me.PanelFavourites = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabWatchList = New System.Windows.Forms.TabPage()
        Me.PanelWatchList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabSeenList = New System.Windows.Forms.TabPage()
        Me.PanelSeenList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabBlackList = New System.Windows.Forms.TabPage()
        Me.PanelBlackList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLoading = New System.Windows.Forms.TabPage()
        Me.itemsBlackList = New System.Windows.Forms.ListBox()
        Me.lblLoadingText = New CButtonLib.CButton()
        Me.itemsNotificationList = New System.Windows.Forms.ListBox()
        Me.itemsWatchList = New System.Windows.Forms.ListBox()
        Me.itemsSeenList = New System.Windows.Forms.ListBox()
        Me.itemsFavouritesList = New System.Windows.Forms.ListBox()
        Me.richtxtMovieDb = New System.Windows.Forms.RichTextBox()
        Me.lblSearchingText = New CButtonLib.CButton()
        Me.panelFilterBox = New System.Windows.Forms.Panel()
        Me.cmboboxGenre = New System.Windows.Forms.ComboBox()
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
        Me.fncSplitter0 = New CButtonLib.CButton()
        Me.panelSortBy = New System.Windows.Forms.Panel()
        Me.cmboboxSortBy = New System.Windows.Forms.ComboBox()
        Me.txtBlackList = New CButtonLib.CButton()
        Me.txtSeenList = New CButtonLib.CButton()
        Me.fncSplitter1 = New CButtonLib.CButton()
        Me.txtWatchList = New CButtonLib.CButton()
        Me.txtFavourites = New CButtonLib.CButton()
        Me.txtMovies = New CButtonLib.CButton()
        Me.txtboxSearch = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.txtboxSearchBG = New CButtonLib.CButton()
        Me.GetNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.ContentToFilter3 = New System.Windows.Forms.ListBox()
        Me.PanelTopRight = New System.Windows.Forms.FlowLayoutPanel()
        Me.timerSearchFavouritesList = New System.Windows.Forms.Timer(Me.components)
        Me.timerSearchWatchList = New System.Windows.Forms.Timer(Me.components)
        Me.FilterSearchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ResetFiltersTimer = New System.Windows.Forms.Timer(Me.components)
        Me.KeyShortcuts = New System.Windows.Forms.Timer(Me.components)
        Me.ContentToFilter4 = New System.Windows.Forms.ListBox()
        Me.timerSearchSeenList = New System.Windows.Forms.Timer(Me.components)
        Me.timerSearchBlackList = New System.Windows.Forms.Timer(Me.components)
        Me.cmboTextSortBy = New CButtonLib.CButton()
        Me.SearchClose = New System.Windows.Forms.PictureBox()
        Me.TxtSearchIcon = New System.Windows.Forms.PictureBox()
        Me.cmboTextGenre = New CButtonLib.CButton()
        Me.AppExit = New System.Windows.Forms.PictureBox()
        Me.AppMaximize = New System.Windows.Forms.PictureBox()
        Me.AppMinimize = New System.Windows.Forms.PictureBox()
        Me.AppNotifications = New System.Windows.Forms.PictureBox()
        Me.imgCelebrationMonth = New System.Windows.Forms.PictureBox()
        Me.btnInfoMenu = New System.Windows.Forms.PictureBox()
        Me.imgUnderlineGlow = New System.Windows.Forms.PictureBox()
        Me.imgPanelsEmpty1 = New System.Windows.Forms.PictureBox()
        Me.imgPanelsEmpty2 = New System.Windows.Forms.PictureBox()
        Me.imgPanelsEmpty3 = New System.Windows.Forms.PictureBox()
        Me.imgPanelsEmpty4 = New System.Windows.Forms.PictureBox()
        Me.icoLoadingWeb = New System.Windows.Forms.PictureBox()
        Me.Tab.SuspendLayout()
        Me.tabMovies.SuspendLayout()
        Me.tabFavourites.SuspendLayout()
        Me.tabWatchList.SuspendLayout()
        Me.tabSeenList.SuspendLayout()
        Me.tabBlackList.SuspendLayout()
        Me.tabLoading.SuspendLayout()
        Me.panelFilterBox.SuspendLayout()
        Me.PanelTabTitles.SuspendLayout()
        Me.panelSortBy.SuspendLayout()
        Me.PanelTopRight.SuspendLayout()
        CType(Me.SearchClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCelebrationMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgUnderlineGlow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPanelsEmpty1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPanelsEmpty2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPanelsEmpty3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPanelsEmpty4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Tab.Controls.Add(Me.tabMovies)
        Me.Tab.Controls.Add(Me.tabFavourites)
        Me.Tab.Controls.Add(Me.tabWatchList)
        Me.Tab.Controls.Add(Me.tabSeenList)
        Me.Tab.Controls.Add(Me.tabBlackList)
        Me.Tab.Controls.Add(Me.tabLoading)
        Me.Tab.Location = New System.Drawing.Point(-25, 73)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1322, 674)
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
        Me.tabMovies.Size = New System.Drawing.Size(1295, 666)
        Me.tabMovies.TabIndex = 0
        Me.tabMovies.Text = "tabBrowse"
        '
        'imgPanelsEmpty0
        '
        Me.imgPanelsEmpty0.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanelsEmpty0.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty0.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgPanelsEmpty0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmpty0.Location = New System.Drawing.Point(85, 103)
        Me.imgPanelsEmpty0.Name = "imgPanelsEmpty0"
        Me.imgPanelsEmpty0.Size = New System.Drawing.Size(1124, 56)
        Me.imgPanelsEmpty0.TabIndex = 10004
        Me.imgPanelsEmpty0.Text = "No movies found :/"
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
        Me.PanelMovies.Size = New System.Drawing.Size(1291, 664)
        Me.PanelMovies.TabIndex = 9
        '
        'tabFavourites
        '
        Me.tabFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabFavourites.Controls.Add(Me.imgPanelsEmpty1)
        Me.tabFavourites.Controls.Add(Me.PanelFavourites)
        Me.tabFavourites.Location = New System.Drawing.Point(23, 4)
        Me.tabFavourites.Name = "tabFavourites"
        Me.tabFavourites.Size = New System.Drawing.Size(1295, 666)
        Me.tabFavourites.TabIndex = 3
        Me.tabFavourites.Text = "t"
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
        Me.tabWatchList.Size = New System.Drawing.Size(1295, 666)
        Me.tabWatchList.TabIndex = 6
        Me.tabWatchList.Text = "tabWatchList"
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
        'tabSeenList
        '
        Me.tabSeenList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSeenList.Controls.Add(Me.imgPanelsEmpty3)
        Me.tabSeenList.Controls.Add(Me.PanelSeenList)
        Me.tabSeenList.Location = New System.Drawing.Point(23, 4)
        Me.tabSeenList.Name = "tabSeenList"
        Me.tabSeenList.Size = New System.Drawing.Size(1295, 666)
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
        Me.tabBlackList.Size = New System.Drawing.Size(1295, 666)
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
        Me.tabLoading.Size = New System.Drawing.Size(1295, 666)
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
        'panelFilterBox
        '
        Me.panelFilterBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.panelFilterBox.BackColor = System.Drawing.Color.Transparent
        Me.panelFilterBox.Controls.Add(Me.cmboTextGenre)
        Me.panelFilterBox.Location = New System.Drawing.Point(758, 6)
        Me.panelFilterBox.Name = "panelFilterBox"
        Me.panelFilterBox.Size = New System.Drawing.Size(124, 30)
        Me.panelFilterBox.TabIndex = 1018
        '
        'cmboboxGenre
        '
        Me.cmboboxGenre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmboboxGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmboboxGenre.ForeColor = System.Drawing.Color.White
        Me.cmboboxGenre.FormattingEnabled = True
        Me.cmboboxGenre.Items.AddRange(New Object() {"Any Genre", "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family", "Fantasy", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Short", "Sport", "Thriller", "War", "Western"})
        Me.cmboboxGenre.Location = New System.Drawing.Point(759, 9)
        Me.cmboboxGenre.Name = "cmboboxGenre"
        Me.cmboboxGenre.Size = New System.Drawing.Size(117, 25)
        Me.cmboboxGenre.TabIndex = 0
        Me.cmboboxGenre.TabStop = False
        Me.cmboboxGenre.Visible = False
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
        Me.PanelTabTitles.Controls.Add(Me.fncSplitter0)
        Me.PanelTabTitles.Controls.Add(Me.panelSortBy)
        Me.PanelTabTitles.Controls.Add(Me.cmboboxSortBy)
        Me.PanelTabTitles.Controls.Add(Me.txtBlackList)
        Me.PanelTabTitles.Controls.Add(Me.txtSeenList)
        Me.PanelTabTitles.Controls.Add(Me.SearchClose)
        Me.PanelTabTitles.Controls.Add(Me.fncSplitter1)
        Me.PanelTabTitles.Controls.Add(Me.TxtSearchIcon)
        Me.PanelTabTitles.Controls.Add(Me.panelFilterBox)
        Me.PanelTabTitles.Controls.Add(Me.cmboboxGenre)
        Me.PanelTabTitles.Controls.Add(Me.txtWatchList)
        Me.PanelTabTitles.Controls.Add(Me.txtFavourites)
        Me.PanelTabTitles.Controls.Add(Me.txtMovies)
        Me.PanelTabTitles.Controls.Add(Me.txtboxSearch)
        Me.PanelTabTitles.Controls.Add(Me.txtboxSearchBG)
        Me.PanelTabTitles.Location = New System.Drawing.Point(0, 26)
        Me.PanelTabTitles.Name = "PanelTabTitles"
        Me.PanelTabTitles.Size = New System.Drawing.Size(1291, 45)
        Me.PanelTabTitles.TabIndex = 1027
        '
        'fncSplitter0
        '
        Me.fncSplitter0.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fncSplitter0.BackColor = System.Drawing.Color.Transparent
        Me.fncSplitter0.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter0.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter0.Cursor = System.Windows.Forms.Cursors.Default
        Me.fncSplitter0.DesignerSelected = False
        Me.fncSplitter0.DimFactorClick = 0
        Me.fncSplitter0.DimFactorHover = 0
        Me.fncSplitter0.FillType = CButtonLib.CButton.eFillType.Solid
        Me.fncSplitter0.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.fncSplitter0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter0.ImageIndex = 0
        Me.fncSplitter0.Location = New System.Drawing.Point(1035, 15)
        Me.fncSplitter0.Name = "fncSplitter0"
        Me.fncSplitter0.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.fncSplitter0.SideImageSize = New System.Drawing.Size(14, 15)
        Me.fncSplitter0.Size = New System.Drawing.Size(2, 15)
        Me.fncSplitter0.TabIndex = 100004
        Me.fncSplitter0.TabStop = False
        Me.fncSplitter0.Text = ""
        Me.fncSplitter0.TextShadow = System.Drawing.Color.White
        Me.fncSplitter0.TextShadowShow = False
        '
        'panelSortBy
        '
        Me.panelSortBy.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.panelSortBy.BackColor = System.Drawing.Color.Transparent
        Me.panelSortBy.Controls.Add(Me.cmboTextSortBy)
        Me.panelSortBy.Location = New System.Drawing.Point(906, 8)
        Me.panelSortBy.Name = "panelSortBy"
        Me.panelSortBy.Size = New System.Drawing.Size(121, 30)
        Me.panelSortBy.TabIndex = 1020
        '
        'cmboboxSortBy
        '
        Me.cmboboxSortBy.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmboboxSortBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxSortBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxSortBy.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmboboxSortBy.ForeColor = System.Drawing.Color.White
        Me.cmboboxSortBy.FormattingEnabled = True
        Me.cmboboxSortBy.Items.AddRange(New Object() {"Newly Added", "Popularity", "Year Release", "A-Z"})
        Me.cmboboxSortBy.Location = New System.Drawing.Point(907, 11)
        Me.cmboboxSortBy.Name = "cmboboxSortBy"
        Me.cmboboxSortBy.Size = New System.Drawing.Size(114, 25)
        Me.cmboboxSortBy.TabIndex = 1019
        Me.cmboboxSortBy.TabStop = False
        Me.cmboboxSortBy.Visible = False
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
        Me.txtBlackList.Location = New System.Drawing.Point(330, 12)
        Me.txtBlackList.Name = "txtBlackList"
        Me.txtBlackList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtBlackList.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtBlackList.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtBlackList.Size = New System.Drawing.Size(76, 30)
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
        Me.txtSeenList.Location = New System.Drawing.Point(251, 12)
        Me.txtSeenList.Name = "txtSeenList"
        Me.txtSeenList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtSeenList.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtSeenList.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtSeenList.Size = New System.Drawing.Size(76, 30)
        Me.txtSeenList.TabIndex = 100002
        Me.txtSeenList.Text = "Seen List"
        Me.txtSeenList.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtSeenList.TextShadow = System.Drawing.Color.White
        Me.txtSeenList.TextShadowShow = False
        '
        'fncSplitter1
        '
        Me.fncSplitter1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.fncSplitter1.BackColor = System.Drawing.Color.Transparent
        Me.fncSplitter1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter1.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter1.Cursor = System.Windows.Forms.Cursors.Default
        Me.fncSplitter1.DesignerSelected = False
        Me.fncSplitter1.DimFactorClick = 0
        Me.fncSplitter1.DimFactorHover = 0
        Me.fncSplitter1.FillType = CButtonLib.CButton.eFillType.Solid
        Me.fncSplitter1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.fncSplitter1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fncSplitter1.ImageIndex = 0
        Me.fncSplitter1.Location = New System.Drawing.Point(891, 15)
        Me.fncSplitter1.Name = "fncSplitter1"
        Me.fncSplitter1.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.fncSplitter1.SideImageSize = New System.Drawing.Size(14, 15)
        Me.fncSplitter1.Size = New System.Drawing.Size(2, 15)
        Me.fncSplitter1.TabIndex = 1030
        Me.fncSplitter1.TabStop = False
        Me.fncSplitter1.Text = ""
        Me.fncSplitter1.TextShadow = System.Drawing.Color.White
        Me.fncSplitter1.TextShadowShow = False
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
        Me.txtWatchList.Location = New System.Drawing.Point(163, 12)
        Me.txtWatchList.Name = "txtWatchList"
        Me.txtWatchList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtWatchList.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtWatchList.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtWatchList.Size = New System.Drawing.Size(86, 30)
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
        Me.txtFavourites.Location = New System.Drawing.Point(76, 12)
        Me.txtFavourites.Name = "txtFavourites"
        Me.txtFavourites.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtFavourites.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtFavourites.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtFavourites.Size = New System.Drawing.Size(85, 30)
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
        Me.txtMovies.Location = New System.Drawing.Point(10, 12)
        Me.txtMovies.Name = "txtMovies"
        Me.txtMovies.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtMovies.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtMovies.SideImageSize = New System.Drawing.Size(14, 15)
        Me.txtMovies.Size = New System.Drawing.Size(63, 30)
        Me.txtMovies.TabIndex = 2
        Me.txtMovies.Text = "Movies"
        Me.txtMovies.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtMovies.TextShadow = System.Drawing.Color.White
        Me.txtMovies.TextShadowShow = False
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!)
        Me.txtboxSearch.ForeColor = System.Drawing.Color.White
        Me.txtboxSearch.Location = New System.Drawing.Point(1082, 13)
        Me.txtboxSearch.MaxLength = 50
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(180, 20)
        Me.txtboxSearch.TabIndex = 1
        Me.txtboxSearch.WaterMark = "Search movies, people, years"
        Me.txtboxSearch.WaterMarkActiveForeColor = System.Drawing.Color.White
        Me.txtboxSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI Semibold", 10.75!)
        Me.txtboxSearch.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        '
        'txtboxSearchBG
        '
        Me.txtboxSearchBG.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtboxSearchBG.BackColor = System.Drawing.Color.Transparent
        Me.txtboxSearchBG.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtboxSearchBG.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtboxSearchBG.Corners.All = 14
        Me.txtboxSearchBG.Corners.LowerLeft = 14
        Me.txtboxSearchBG.Corners.LowerRight = 14
        Me.txtboxSearchBG.Corners.UpperLeft = 14
        Me.txtboxSearchBG.Corners.UpperRight = 14
        Me.txtboxSearchBG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearchBG.DesignerSelected = False
        Me.txtboxSearchBG.DimFactorClick = 0
        Me.txtboxSearchBG.DimFactorHover = 0
        Me.txtboxSearchBG.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtboxSearchBG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtboxSearchBG.ImageIndex = 0
        Me.txtboxSearchBG.Location = New System.Drawing.Point(1053, 9)
        Me.txtboxSearchBG.Name = "txtboxSearchBG"
        Me.txtboxSearchBG.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtboxSearchBG.Size = New System.Drawing.Size(226, 28)
        Me.txtboxSearchBG.TabIndex = 1024
        Me.txtboxSearchBG.Text = ""
        Me.txtboxSearchBG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtboxSearchBG.TextShadow = System.Drawing.Color.White
        Me.txtboxSearchBG.TextShadowShow = False
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
        Me.PanelTopRight.Controls.Add(Me.AppNotifications)
        Me.PanelTopRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.PanelTopRight.Location = New System.Drawing.Point(791, -3)
        Me.PanelTopRight.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelTopRight.Name = "PanelTopRight"
        Me.PanelTopRight.Size = New System.Drawing.Size(500, 30)
        Me.PanelTopRight.TabIndex = 0
        '
        'timerSearchFavouritesList
        '
        Me.timerSearchFavouritesList.Interval = 700
        '
        'timerSearchWatchList
        '
        Me.timerSearchWatchList.Interval = 700
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
        'timerSearchSeenList
        '
        Me.timerSearchSeenList.Interval = 700
        '
        'timerSearchBlackList
        '
        Me.timerSearchBlackList.Interval = 700
        '
        'cmboTextSortBy
        '
        Me.cmboTextSortBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmboTextSortBy.BackColor = System.Drawing.Color.Transparent
        Me.cmboTextSortBy.BorderColor = System.Drawing.Color.White
        Me.cmboTextSortBy.BorderShow = False
        Me.cmboTextSortBy.ColorFillSolid = System.Drawing.Color.Transparent
        Me.cmboTextSortBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboTextSortBy.DesignerSelected = False
        Me.cmboTextSortBy.DimFactorClick = 0
        Me.cmboTextSortBy.DimFactorHover = 0
        Me.cmboTextSortBy.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboTextSortBy.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmboTextSortBy.ImageIndex = 0
        Me.cmboTextSortBy.Location = New System.Drawing.Point(0, 0)
        Me.cmboTextSortBy.Name = "cmboTextSortBy"
        Me.cmboTextSortBy.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboTextSortBy.SideImage = CType(resources.GetObject("cmboTextSortBy.SideImage"), System.Drawing.Image)
        Me.cmboTextSortBy.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboTextSortBy.SideImageSize = New System.Drawing.Size(17, 18)
        Me.cmboTextSortBy.Size = New System.Drawing.Size(118, 30)
        Me.cmboTextSortBy.TabIndex = 5
        Me.cmboTextSortBy.Text = "Newly Added"
        Me.cmboTextSortBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboTextSortBy.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.cmboTextSortBy.TextShadow = System.Drawing.Color.Black
        Me.cmboTextSortBy.TextShadowShow = False
        '
        'SearchClose
        '
        Me.SearchClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SearchClose.BackColor = System.Drawing.Color.Transparent
        Me.SearchClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchClose.Image = CType(resources.GetObject("SearchClose.Image"), System.Drawing.Image)
        Me.SearchClose.Location = New System.Drawing.Point(1257, 17)
        Me.SearchClose.Name = "SearchClose"
        Me.SearchClose.Size = New System.Drawing.Size(13, 13)
        Me.SearchClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SearchClose.TabIndex = 100001
        Me.SearchClose.TabStop = False
        Me.SearchClose.Visible = False
        '
        'TxtSearchIcon
        '
        Me.TxtSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtSearchIcon.BackColor = System.Drawing.Color.Transparent
        Me.TxtSearchIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtSearchIcon.Image = CType(resources.GetObject("TxtSearchIcon.Image"), System.Drawing.Image)
        Me.TxtSearchIcon.Location = New System.Drawing.Point(1062, 15)
        Me.TxtSearchIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtSearchIcon.Name = "TxtSearchIcon"
        Me.TxtSearchIcon.Size = New System.Drawing.Size(16, 16)
        Me.TxtSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TxtSearchIcon.TabIndex = 100000
        Me.TxtSearchIcon.TabStop = False
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
        Me.cmboTextGenre.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.cmboTextGenre.TextShadow = System.Drawing.Color.Black
        Me.cmboTextGenre.TextShadowShow = False
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
        'AppNotifications
        '
        Me.AppNotifications.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppNotifications.BackColor = System.Drawing.Color.Transparent
        Me.AppNotifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppNotifications.Image = CType(resources.GetObject("AppNotifications.Image"), System.Drawing.Image)
        Me.AppNotifications.Location = New System.Drawing.Point(389, 0)
        Me.AppNotifications.Margin = New System.Windows.Forms.Padding(0)
        Me.AppNotifications.Name = "AppNotifications"
        Me.AppNotifications.Size = New System.Drawing.Size(30, 32)
        Me.AppNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppNotifications.TabIndex = 1005
        Me.AppNotifications.TabStop = False
        '
        'imgCelebrationMonth
        '
        Me.imgCelebrationMonth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgCelebrationMonth.BackColor = System.Drawing.Color.Transparent
        Me.imgCelebrationMonth.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgCelebrationMonth.Location = New System.Drawing.Point(672, 1)
        Me.imgCelebrationMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.imgCelebrationMonth.Name = "imgCelebrationMonth"
        Me.imgCelebrationMonth.Size = New System.Drawing.Size(25, 25)
        Me.imgCelebrationMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCelebrationMonth.TabIndex = 1005
        Me.imgCelebrationMonth.TabStop = False
        '
        'btnInfoMenu
        '
        Me.btnInfoMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnInfoMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInfoMenu.Image = Global.Movieo.My.Resources.Resources.DropletsIconL
        Me.btnInfoMenu.Location = New System.Drawing.Point(12, -3)
        Me.btnInfoMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInfoMenu.Name = "btnInfoMenu"
        Me.btnInfoMenu.Size = New System.Drawing.Size(34, 32)
        Me.btnInfoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnInfoMenu.TabIndex = 1006
        Me.btnInfoMenu.TabStop = False
        '
        'imgUnderlineGlow
        '
        Me.imgUnderlineGlow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgUnderlineGlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.imgUnderlineGlow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgUnderlineGlow.Image = Global.Movieo.My.Resources.Resources.UnderlineGlow9x
        Me.imgUnderlineGlow.Location = New System.Drawing.Point(-356, 21)
        Me.imgUnderlineGlow.Name = "imgUnderlineGlow"
        Me.imgUnderlineGlow.Size = New System.Drawing.Size(2000, 56)
        Me.imgUnderlineGlow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUnderlineGlow.TabIndex = 100003
        Me.imgUnderlineGlow.TabStop = False
        '
        'imgPanelsEmpty1
        '
        Me.imgPanelsEmpty1.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty1.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPanelsEmpty1.Image = Global.Movieo.My.Resources.Resources.Empty_Panel
        Me.imgPanelsEmpty1.Location = New System.Drawing.Point(797, -13)
        Me.imgPanelsEmpty1.Margin = New System.Windows.Forms.Padding(0)
        Me.imgPanelsEmpty1.Name = "imgPanelsEmpty1"
        Me.imgPanelsEmpty1.Size = New System.Drawing.Size(433, 156)
        Me.imgPanelsEmpty1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPanelsEmpty1.TabIndex = 100002
        Me.imgPanelsEmpty1.TabStop = False
        '
        'imgPanelsEmpty2
        '
        Me.imgPanelsEmpty2.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty2.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPanelsEmpty2.Image = Global.Movieo.My.Resources.Resources.Empty_Panel
        Me.imgPanelsEmpty2.Location = New System.Drawing.Point(797, -13)
        Me.imgPanelsEmpty2.Margin = New System.Windows.Forms.Padding(0)
        Me.imgPanelsEmpty2.Name = "imgPanelsEmpty2"
        Me.imgPanelsEmpty2.Size = New System.Drawing.Size(433, 156)
        Me.imgPanelsEmpty2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPanelsEmpty2.TabIndex = 100003
        Me.imgPanelsEmpty2.TabStop = False
        '
        'imgPanelsEmpty3
        '
        Me.imgPanelsEmpty3.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty3.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPanelsEmpty3.Image = Global.Movieo.My.Resources.Resources.Empty_Panel
        Me.imgPanelsEmpty3.Location = New System.Drawing.Point(797, -13)
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
        Me.imgPanelsEmpty4.Image = Global.Movieo.My.Resources.Resources.Empty_Panel
        Me.imgPanelsEmpty4.Location = New System.Drawing.Point(797, -13)
        Me.imgPanelsEmpty4.Margin = New System.Windows.Forms.Padding(0)
        Me.imgPanelsEmpty4.Name = "imgPanelsEmpty4"
        Me.imgPanelsEmpty4.Size = New System.Drawing.Size(433, 156)
        Me.imgPanelsEmpty4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPanelsEmpty4.TabIndex = 100004
        Me.imgPanelsEmpty4.TabStop = False
        '
        'icoLoadingWeb
        '
        Me.icoLoadingWeb.Location = New System.Drawing.Point(0, 0)
        Me.icoLoadingWeb.Name = "icoLoadingWeb"
        Me.icoLoadingWeb.Size = New System.Drawing.Size(100, 50)
        Me.icoLoadingWeb.TabIndex = 0
        Me.icoLoadingWeb.TabStop = False
        '
        'Movieo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1291, 741)
        Me.Controls.Add(Me.PanelTabTitles)
        Me.Controls.Add(Me.ContentToFilter4)
        Me.Controls.Add(Me.PanelTopRight)
        Me.Controls.Add(Me.imgCelebrationMonth)
        Me.Controls.Add(Me.btnInfoMenu)
        Me.Controls.Add(Me.ContentToFilter3)
        Me.Controls.Add(Me.ContentToFilter2)
        Me.Controls.Add(Me.ContentToFilter1)
        Me.Controls.Add(Me.AppTitle)
        Me.Controls.Add(Me.imgUnderlineGlow)
        Me.Controls.Add(Me.Tab)
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
        Me.tabWatchList.ResumeLayout(False)
        Me.tabSeenList.ResumeLayout(False)
        Me.tabBlackList.ResumeLayout(False)
        Me.tabLoading.ResumeLayout(False)
        Me.panelFilterBox.ResumeLayout(False)
        Me.PanelTabTitles.ResumeLayout(False)
        Me.PanelTabTitles.PerformLayout()
        Me.panelSortBy.ResumeLayout(False)
        Me.PanelTopRight.ResumeLayout(False)
        CType(Me.SearchClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCelebrationMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgUnderlineGlow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPanelsEmpty1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPanelsEmpty2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPanelsEmpty3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPanelsEmpty4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab As TabControl
    Friend WithEvents tabMovies As TabPage
    Friend WithEvents AppTitle As Label
    Friend WithEvents StartupTimer As Timer
    Friend WithEvents PanelMovies As FlowLayoutPanel
    Friend WithEvents tabFavourites As TabPage
    Friend WithEvents tabLoading As TabPage
    Friend WithEvents cmboboxGenre As ComboBox
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
    Friend WithEvents panelFilterBox As Panel
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
    Friend WithEvents txtboxSearchBG As CButtonLib.CButton
    Friend WithEvents txtWatchList As CButtonLib.CButton
    Friend WithEvents txtFavourites As CButtonLib.CButton
    Public WithEvents txtMovies As CButtonLib.CButton
    Friend WithEvents PanelTopRight As FlowLayoutPanel
    Friend WithEvents AppMaximize As PictureBox
    Friend WithEvents btnInfoMenu As PictureBox
    Friend WithEvents fncSplitter1 As CButtonLib.CButton
    Friend WithEvents timerSearchFavouritesList As Timer
    Friend WithEvents timerSearchWatchList As Timer
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
    Friend WithEvents txtboxSearch As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents AppNotifications As PictureBox
    Friend WithEvents panelSortBy As Panel
    Friend WithEvents cmboTextSortBy As CButtonLib.CButton
    Friend WithEvents cmboboxSortBy As ComboBox
    Friend WithEvents fncSplitter0 As CButtonLib.CButton
    Friend WithEvents timerSearchSeenList As Timer
    Friend WithEvents timerSearchBlackList As Timer
End Class
