<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovieDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovieDetails))
        Me.infoTitle = New System.Windows.Forms.Label()
        Me.infoYear = New System.Windows.Forms.Label()
        Me.infoGenre = New System.Windows.Forms.Label()
        Me.infoDuration = New System.Windows.Forms.Label()
        Me.infoQuality = New System.Windows.Forms.Label()
        Me.infoImageLink = New System.Windows.Forms.Label()
        Me.ActionsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Splitter2 = New System.Windows.Forms.Label()
        Me.Splitter3 = New System.Windows.Forms.Label()
        Me.Splitter4 = New System.Windows.Forms.Label()
        Me.Splitter5 = New System.Windows.Forms.Label()
        Me.infoDirectors = New System.Windows.Forms.Label()
        Me.infoWatchLinks = New System.Windows.Forms.Label()
        Me.lblSubCast = New System.Windows.Forms.Label()
        Me.lblSubDirectors = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Label()
        Me.lblSubRating = New System.Windows.Forms.Label()
        Me.lblSubRuntime = New System.Windows.Forms.Label()
        Me.lblSubReleaseDate = New System.Windows.Forms.Label()
        Me.lblSubCountry = New System.Windows.Forms.Label()
        Me.lblHeaderDetails = New System.Windows.Forms.Label()
        Me.infoRating = New System.Windows.Forms.Label()
        Me.infoRatingIMDb = New System.Windows.Forms.Label()
        Me.infoRatingMetaScore = New System.Windows.Forms.Label()
        Me.infoReleaseDate = New System.Windows.Forms.Label()
        Me.infoProduction = New System.Windows.Forms.Label()
        Me.lblSubProduction = New System.Windows.Forms.Label()
        Me.infoBoxOffice = New System.Windows.Forms.Label()
        Me.lblSubBoxOffice = New System.Windows.Forms.Label()
        Me.InfoPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.infoDescription = New System.Windows.Forms.Label()
        Me.infoCast = New System.Windows.Forms.Label()
        Me.panelHeaders = New System.Windows.Forms.Panel()
        Me.lineUserReviews = New CButtonLib.CButton()
        Me.txtShareComment = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.txtFormCommentBG = New CButtonLib.CButton()
        Me.lblHeaderUserReviews = New System.Windows.Forms.Label()
        Me.imgPanelsEmptyReviews = New System.Windows.Forms.Label()
        Me.lineSplitter = New CButtonLib.CButton()
        Me.txtShareName = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.txtFormNameBG = New CButtonLib.CButton()
        Me.btnCommentSubmit = New CButtonLib.CButton()
        Me.panelComments = New System.Windows.Forms.FlowLayoutPanel()
        Me.infoLanguage = New System.Windows.Forms.Label()
        Me.lblSubLanguage = New System.Windows.Forms.Label()
        Me.infoCountry = New System.Windows.Forms.Label()
        Me.infoAwards = New System.Windows.Forms.Label()
        Me.lblSubAwards = New System.Windows.Forms.Label()
        Me.infoImdbId = New System.Windows.Forms.Label()
        Me.panelDetails = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MovieLinkText = New System.Windows.Forms.Label()
        Me.infoTrailerLink = New System.Windows.Forms.Label()
        Me.msgErrorComments = New System.Windows.Forms.Label()
        Me.imgPanelsEmpty0 = New System.Windows.Forms.Label()
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.getStarsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.infoRatingNetflix = New System.Windows.Forms.Label()
        Me.SplitterLine1 = New CButtonLib.CButton()
        Me.btnDownloadMovie = New CButtonLib.CButton()
        Me.btnWatchMovie = New CButtonLib.CButton()
        Me.lblStatus = New CButtonLib.CButton()
        Me.infoBackgroundImageLink = New System.Windows.Forms.Label()
        Me.btnWatchTrailer = New System.Windows.Forms.PictureBox()
        Me.imgNetflix = New System.Windows.Forms.PictureBox()
        Me.imgPoster = New System.Windows.Forms.PictureBox()
        Me.ImgMetaCritic = New System.Windows.Forms.PictureBox()
        Me.imgImdb = New System.Windows.Forms.PictureBox()
        Me.appClose = New System.Windows.Forms.PictureBox()
        Me.btnFavouriteList = New System.Windows.Forms.PictureBox()
        Me.btnWatchList = New System.Windows.Forms.PictureBox()
        Me.btnSeenList = New System.Windows.Forms.PictureBox()
        Me.btnBlackList = New System.Windows.Forms.PictureBox()
        Me.btnMyList = New System.Windows.Forms.PictureBox()
        Me.ActionsPanel.SuspendLayout()
        Me.InfoPanel1.SuspendLayout()
        Me.panelHeaders.SuspendLayout()
        Me.panelDetails.SuspendLayout()
        CType(Me.btnWatchTrailer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNetflix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMetaCritic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgImdb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFavouriteList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnWatchList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeenList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBlackList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMyList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'infoTitle
        '
        Me.infoTitle.AutoEllipsis = True
        resources.ApplyResources(Me.infoTitle, "infoTitle")
        Me.infoTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.infoTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoTitle.Name = "infoTitle"
        '
        'infoYear
        '
        resources.ApplyResources(Me.infoYear, "infoYear")
        Me.InfoPanel1.SetFlowBreak(Me.infoYear, True)
        Me.infoYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoYear.Name = "infoYear"
        '
        'infoGenre
        '
        resources.ApplyResources(Me.infoGenre, "infoGenre")
        Me.infoGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoGenre.Name = "infoGenre"
        '
        'infoDuration
        '
        resources.ApplyResources(Me.infoDuration, "infoDuration")
        Me.panelDetails.SetFlowBreak(Me.infoDuration, True)
        Me.infoDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoDuration.Name = "infoDuration"
        '
        'infoQuality
        '
        resources.ApplyResources(Me.infoQuality, "infoQuality")
        Me.InfoPanel1.SetFlowBreak(Me.infoQuality, True)
        Me.infoQuality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoQuality.Name = "infoQuality"
        '
        'infoImageLink
        '
        resources.ApplyResources(Me.infoImageLink, "infoImageLink")
        Me.infoImageLink.ForeColor = System.Drawing.Color.White
        Me.infoImageLink.Name = "infoImageLink"
        '
        'ActionsPanel
        '
        Me.ActionsPanel.BackColor = System.Drawing.Color.Transparent
        Me.ActionsPanel.Controls.Add(Me.btnFavouriteList)
        Me.ActionsPanel.Controls.Add(Me.Splitter2)
        Me.ActionsPanel.Controls.Add(Me.btnWatchList)
        Me.ActionsPanel.Controls.Add(Me.Splitter3)
        Me.ActionsPanel.Controls.Add(Me.btnSeenList)
        Me.ActionsPanel.Controls.Add(Me.Splitter4)
        Me.ActionsPanel.Controls.Add(Me.btnBlackList)
        Me.ActionsPanel.Controls.Add(Me.Splitter5)
        Me.ActionsPanel.Controls.Add(Me.btnMyList)
        resources.ApplyResources(Me.ActionsPanel, "ActionsPanel")
        Me.ActionsPanel.Name = "ActionsPanel"
        '
        'Splitter2
        '
        resources.ApplyResources(Me.Splitter2, "Splitter2")
        Me.Splitter2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Splitter2.Name = "Splitter2"
        '
        'Splitter3
        '
        resources.ApplyResources(Me.Splitter3, "Splitter3")
        Me.Splitter3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Splitter3.Name = "Splitter3"
        '
        'Splitter4
        '
        resources.ApplyResources(Me.Splitter4, "Splitter4")
        Me.Splitter4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Splitter4.Name = "Splitter4"
        '
        'Splitter5
        '
        resources.ApplyResources(Me.Splitter5, "Splitter5")
        Me.Splitter5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Splitter5.Name = "Splitter5"
        '
        'infoDirectors
        '
        resources.ApplyResources(Me.infoDirectors, "infoDirectors")
        Me.InfoPanel1.SetFlowBreak(Me.infoDirectors, True)
        Me.infoDirectors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoDirectors.Name = "infoDirectors"
        '
        'infoWatchLinks
        '
        Me.infoWatchLinks.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.infoWatchLinks, "infoWatchLinks")
        Me.infoWatchLinks.ForeColor = System.Drawing.Color.White
        Me.infoWatchLinks.Name = "infoWatchLinks"
        '
        'lblSubCast
        '
        resources.ApplyResources(Me.lblSubCast, "lblSubCast")
        Me.lblSubCast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubCast.Name = "lblSubCast"
        '
        'lblSubDirectors
        '
        resources.ApplyResources(Me.lblSubDirectors, "lblSubDirectors")
        Me.lblSubDirectors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubDirectors.Name = "lblSubDirectors"
        '
        'Splitter1
        '
        resources.ApplyResources(Me.Splitter1, "Splitter1")
        Me.Splitter1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Splitter1.Name = "Splitter1"
        '
        'lblSubRating
        '
        resources.ApplyResources(Me.lblSubRating, "lblSubRating")
        Me.lblSubRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubRating.Name = "lblSubRating"
        '
        'lblSubRuntime
        '
        resources.ApplyResources(Me.lblSubRuntime, "lblSubRuntime")
        Me.lblSubRuntime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubRuntime.Name = "lblSubRuntime"
        '
        'lblSubReleaseDate
        '
        resources.ApplyResources(Me.lblSubReleaseDate, "lblSubReleaseDate")
        Me.lblSubReleaseDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubReleaseDate.Name = "lblSubReleaseDate"
        '
        'lblSubCountry
        '
        resources.ApplyResources(Me.lblSubCountry, "lblSubCountry")
        Me.lblSubCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubCountry.Name = "lblSubCountry"
        '
        'lblHeaderDetails
        '
        resources.ApplyResources(Me.lblHeaderDetails, "lblHeaderDetails")
        Me.panelDetails.SetFlowBreak(Me.lblHeaderDetails, True)
        Me.lblHeaderDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblHeaderDetails.Name = "lblHeaderDetails"
        '
        'infoRating
        '
        resources.ApplyResources(Me.infoRating, "infoRating")
        Me.panelDetails.SetFlowBreak(Me.infoRating, True)
        Me.infoRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoRating.Name = "infoRating"
        '
        'infoRatingIMDb
        '
        resources.ApplyResources(Me.infoRatingIMDb, "infoRatingIMDb")
        Me.infoRatingIMDb.BackColor = System.Drawing.Color.Transparent
        Me.infoRatingIMDb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.infoRatingIMDb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoRatingIMDb.Name = "infoRatingIMDb"
        '
        'infoRatingMetaScore
        '
        resources.ApplyResources(Me.infoRatingMetaScore, "infoRatingMetaScore")
        Me.infoRatingMetaScore.BackColor = System.Drawing.Color.Transparent
        Me.infoRatingMetaScore.Cursor = System.Windows.Forms.Cursors.Default
        Me.infoRatingMetaScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoRatingMetaScore.Name = "infoRatingMetaScore"
        '
        'infoReleaseDate
        '
        resources.ApplyResources(Me.infoReleaseDate, "infoReleaseDate")
        Me.panelDetails.SetFlowBreak(Me.infoReleaseDate, True)
        Me.infoReleaseDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoReleaseDate.Name = "infoReleaseDate"
        '
        'infoProduction
        '
        resources.ApplyResources(Me.infoProduction, "infoProduction")
        Me.infoProduction.AutoEllipsis = True
        Me.panelDetails.SetFlowBreak(Me.infoProduction, True)
        Me.infoProduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoProduction.Name = "infoProduction"
        '
        'lblSubProduction
        '
        resources.ApplyResources(Me.lblSubProduction, "lblSubProduction")
        Me.lblSubProduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubProduction.Name = "lblSubProduction"
        '
        'infoBoxOffice
        '
        resources.ApplyResources(Me.infoBoxOffice, "infoBoxOffice")
        Me.panelDetails.SetFlowBreak(Me.infoBoxOffice, True)
        Me.infoBoxOffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoBoxOffice.Name = "infoBoxOffice"
        '
        'lblSubBoxOffice
        '
        resources.ApplyResources(Me.lblSubBoxOffice, "lblSubBoxOffice")
        Me.lblSubBoxOffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubBoxOffice.Name = "lblSubBoxOffice"
        '
        'InfoPanel1
        '
        resources.ApplyResources(Me.InfoPanel1, "InfoPanel1")
        Me.InfoPanel1.BackColor = System.Drawing.Color.Transparent
        Me.InfoPanel1.Controls.Add(Me.infoTitle)
        Me.InfoPanel1.Controls.Add(Me.infoYear)
        Me.InfoPanel1.Controls.Add(Me.infoGenre)
        Me.InfoPanel1.Controls.Add(Me.Splitter1)
        Me.InfoPanel1.Controls.Add(Me.infoQuality)
        Me.InfoPanel1.Controls.Add(Me.infoDescription)
        Me.InfoPanel1.Controls.Add(Me.lblSubDirectors)
        Me.InfoPanel1.Controls.Add(Me.infoDirectors)
        Me.InfoPanel1.Controls.Add(Me.lblSubCast)
        Me.InfoPanel1.Controls.Add(Me.infoCast)
        Me.InfoPanel1.Controls.Add(Me.panelHeaders)
        Me.InfoPanel1.Name = "InfoPanel1"
        '
        'infoDescription
        '
        resources.ApplyResources(Me.infoDescription, "infoDescription")
        Me.InfoPanel1.SetFlowBreak(Me.infoDescription, True)
        Me.infoDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoDescription.Name = "infoDescription"
        '
        'infoCast
        '
        resources.ApplyResources(Me.infoCast, "infoCast")
        Me.InfoPanel1.SetFlowBreak(Me.infoCast, True)
        Me.infoCast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoCast.Name = "infoCast"
        '
        'panelHeaders
        '
        resources.ApplyResources(Me.panelHeaders, "panelHeaders")
        Me.panelHeaders.BackColor = System.Drawing.Color.Transparent
        Me.panelHeaders.Controls.Add(Me.lineUserReviews)
        Me.panelHeaders.Controls.Add(Me.txtShareComment)
        Me.panelHeaders.Controls.Add(Me.txtFormCommentBG)
        Me.panelHeaders.Controls.Add(Me.lblHeaderUserReviews)
        Me.panelHeaders.Controls.Add(Me.imgPanelsEmptyReviews)
        Me.panelHeaders.Controls.Add(Me.lineSplitter)
        Me.panelHeaders.Controls.Add(Me.txtShareName)
        Me.panelHeaders.Controls.Add(Me.txtFormNameBG)
        Me.panelHeaders.Controls.Add(Me.btnCommentSubmit)
        Me.panelHeaders.Controls.Add(Me.panelComments)
        Me.panelHeaders.Name = "panelHeaders"
        '
        'lineUserReviews
        '
        Me.lineUserReviews.BackColor = System.Drawing.Color.Transparent
        Me.lineUserReviews.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lineUserReviews.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lineUserReviews.Cursor = System.Windows.Forms.Cursors.Default
        Me.lineUserReviews.DesignerSelected = False
        Me.lineUserReviews.DimFactorClick = 0
        Me.lineUserReviews.DimFactorHover = 0
        Me.lineUserReviews.FillType = CButtonLib.CButton.eFillType.Solid
        resources.ApplyResources(Me.lineUserReviews, "lineUserReviews")
        Me.lineUserReviews.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lineUserReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lineUserReviews.ImageIndex = 0
        Me.lineUserReviews.ImageSize = New System.Drawing.Size(25, 36)
        Me.lineUserReviews.Name = "lineUserReviews"
        Me.lineUserReviews.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lineUserReviews.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lineUserReviews.SideImageSize = New System.Drawing.Size(36, 36)
        Me.lineUserReviews.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.lineUserReviews.TextShadowShow = False
        '
        'txtShareComment
        '
        resources.ApplyResources(Me.txtShareComment, "txtShareComment")
        Me.txtShareComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtShareComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtShareComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtShareComment.Name = "txtShareComment"
        Me.txtShareComment.WaterMark = "Share your thoughts..."
        Me.txtShareComment.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtShareComment.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtShareComment.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'txtFormCommentBG
        '
        resources.ApplyResources(Me.txtFormCommentBG, "txtFormCommentBG")
        Me.txtFormCommentBG.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.txtFormCommentBG.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtFormCommentBG.Corners.UpperLeft = 2
        Me.txtFormCommentBG.Corners.UpperRight = 2
        Me.txtFormCommentBG.DesignerSelected = False
        Me.txtFormCommentBG.DimFactorClick = 0
        Me.txtFormCommentBG.DimFactorHover = 0
        Me.txtFormCommentBG.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtFormCommentBG.ImageIndex = 0
        Me.txtFormCommentBG.Name = "txtFormCommentBG"
        Me.txtFormCommentBG.ShowFocus = CButtonLib.CButton.eFocus.None
        '
        'lblHeaderUserReviews
        '
        resources.ApplyResources(Me.lblHeaderUserReviews, "lblHeaderUserReviews")
        Me.lblHeaderUserReviews.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderUserReviews.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHeaderUserReviews.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblHeaderUserReviews.Name = "lblHeaderUserReviews"
        '
        'imgPanelsEmptyReviews
        '
        resources.ApplyResources(Me.imgPanelsEmptyReviews, "imgPanelsEmptyReviews")
        Me.imgPanelsEmptyReviews.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmptyReviews.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmptyReviews.Name = "imgPanelsEmptyReviews"
        '
        'lineSplitter
        '
        resources.ApplyResources(Me.lineSplitter, "lineSplitter")
        Me.lineSplitter.BackColor = System.Drawing.Color.Transparent
        Me.lineSplitter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lineSplitter.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lineSplitter.Cursor = System.Windows.Forms.Cursors.Default
        Me.lineSplitter.DesignerSelected = False
        Me.lineSplitter.DimFactorClick = 0
        Me.lineSplitter.DimFactorHover = 0
        Me.lineSplitter.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lineSplitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lineSplitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lineSplitter.ImageIndex = 0
        Me.lineSplitter.ImageSize = New System.Drawing.Size(25, 36)
        Me.lineSplitter.Name = "lineSplitter"
        Me.lineSplitter.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lineSplitter.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lineSplitter.SideImageSize = New System.Drawing.Size(36, 36)
        Me.lineSplitter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.lineSplitter.TextShadowShow = False
        '
        'txtShareName
        '
        Me.txtShareName.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtShareName.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtShareName, "txtShareName")
        Me.txtShareName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtShareName.Name = "txtShareName"
        Me.txtShareName.WaterMark = "Your Name..."
        Me.txtShareName.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtShareName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtShareName.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'txtFormNameBG
        '
        Me.txtFormNameBG.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.txtFormNameBG.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtFormNameBG.Corners.LowerLeft = 2
        Me.txtFormNameBG.Corners.LowerRight = 2
        Me.txtFormNameBG.DesignerSelected = False
        Me.txtFormNameBG.DimFactorClick = 0
        Me.txtFormNameBG.DimFactorHover = 0
        Me.txtFormNameBG.FillType = CButtonLib.CButton.eFillType.Solid
        resources.ApplyResources(Me.txtFormNameBG, "txtFormNameBG")
        Me.txtFormNameBG.ImageIndex = 0
        Me.txtFormNameBG.Name = "txtFormNameBG"
        Me.txtFormNameBG.ShowFocus = CButtonLib.CButton.eFocus.None
        '
        'btnCommentSubmit
        '
        resources.ApplyResources(Me.btnCommentSubmit, "btnCommentSubmit")
        Me.btnCommentSubmit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnCommentSubmit.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnCommentSubmit.Corners.LowerLeft = 2
        Me.btnCommentSubmit.Corners.LowerRight = 2
        Me.btnCommentSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCommentSubmit.DesignerSelected = False
        Me.btnCommentSubmit.DimFactorClick = 0
        Me.btnCommentSubmit.DimFactorHover = 0
        Me.btnCommentSubmit.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnCommentSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCommentSubmit.ImageIndex = 0
        Me.btnCommentSubmit.Name = "btnCommentSubmit"
        Me.btnCommentSubmit.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnCommentSubmit.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.btnCommentSubmit.TextShadowShow = False
        '
        'panelComments
        '
        resources.ApplyResources(Me.panelComments, "panelComments")
        Me.panelComments.BackColor = System.Drawing.Color.Transparent
        Me.panelComments.Name = "panelComments"
        '
        'infoLanguage
        '
        resources.ApplyResources(Me.infoLanguage, "infoLanguage")
        Me.infoLanguage.AutoEllipsis = True
        Me.panelDetails.SetFlowBreak(Me.infoLanguage, True)
        Me.infoLanguage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoLanguage.Name = "infoLanguage"
        '
        'lblSubLanguage
        '
        resources.ApplyResources(Me.lblSubLanguage, "lblSubLanguage")
        Me.lblSubLanguage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubLanguage.Name = "lblSubLanguage"
        '
        'infoCountry
        '
        resources.ApplyResources(Me.infoCountry, "infoCountry")
        Me.infoCountry.AutoEllipsis = True
        Me.panelDetails.SetFlowBreak(Me.infoCountry, True)
        Me.infoCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoCountry.Name = "infoCountry"
        '
        'infoAwards
        '
        resources.ApplyResources(Me.infoAwards, "infoAwards")
        Me.panelDetails.SetFlowBreak(Me.infoAwards, True)
        Me.infoAwards.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoAwards.Name = "infoAwards"
        '
        'lblSubAwards
        '
        resources.ApplyResources(Me.lblSubAwards, "lblSubAwards")
        Me.lblSubAwards.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubAwards.Name = "lblSubAwards"
        '
        'infoImdbId
        '
        Me.infoImdbId.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.infoImdbId, "infoImdbId")
        Me.infoImdbId.ForeColor = System.Drawing.Color.White
        Me.infoImdbId.Name = "infoImdbId"
        '
        'panelDetails
        '
        resources.ApplyResources(Me.panelDetails, "panelDetails")
        Me.panelDetails.BackColor = System.Drawing.Color.Transparent
        Me.panelDetails.Controls.Add(Me.lblHeaderDetails)
        Me.panelDetails.Controls.Add(Me.lblSubRating)
        Me.panelDetails.Controls.Add(Me.infoRating)
        Me.panelDetails.Controls.Add(Me.lblSubRuntime)
        Me.panelDetails.Controls.Add(Me.infoDuration)
        Me.panelDetails.Controls.Add(Me.lblSubReleaseDate)
        Me.panelDetails.Controls.Add(Me.infoReleaseDate)
        Me.panelDetails.Controls.Add(Me.lblSubCountry)
        Me.panelDetails.Controls.Add(Me.infoCountry)
        Me.panelDetails.Controls.Add(Me.lblSubLanguage)
        Me.panelDetails.Controls.Add(Me.infoLanguage)
        Me.panelDetails.Controls.Add(Me.lblSubProduction)
        Me.panelDetails.Controls.Add(Me.infoProduction)
        Me.panelDetails.Controls.Add(Me.lblSubBoxOffice)
        Me.panelDetails.Controls.Add(Me.infoBoxOffice)
        Me.panelDetails.Controls.Add(Me.lblSubAwards)
        Me.panelDetails.Controls.Add(Me.infoAwards)
        Me.panelDetails.Name = "panelDetails"
        '
        'MovieLinkText
        '
        resources.ApplyResources(Me.MovieLinkText, "MovieLinkText")
        Me.MovieLinkText.ForeColor = System.Drawing.Color.White
        Me.MovieLinkText.Name = "MovieLinkText"
        '
        'infoTrailerLink
        '
        Me.infoTrailerLink.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.infoTrailerLink, "infoTrailerLink")
        Me.infoTrailerLink.ForeColor = System.Drawing.Color.White
        Me.infoTrailerLink.Name = "infoTrailerLink"
        '
        'msgErrorComments
        '
        resources.ApplyResources(Me.msgErrorComments, "msgErrorComments")
        Me.msgErrorComments.BackColor = System.Drawing.Color.Transparent
        Me.msgErrorComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.msgErrorComments.Name = "msgErrorComments"
        '
        'imgPanelsEmpty0
        '
        resources.ApplyResources(Me.imgPanelsEmpty0, "imgPanelsEmpty0")
        Me.imgPanelsEmpty0.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmpty0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmpty0.Name = "imgPanelsEmpty0"
        '
        'timerHideNotifications
        '
        Me.timerHideNotifications.Interval = 4000
        '
        'getStarsTimer
        '
        Me.getStarsTimer.Interval = 10
        '
        'infoRatingNetflix
        '
        resources.ApplyResources(Me.infoRatingNetflix, "infoRatingNetflix")
        Me.infoRatingNetflix.BackColor = System.Drawing.Color.Transparent
        Me.infoRatingNetflix.Cursor = System.Windows.Forms.Cursors.Default
        Me.infoRatingNetflix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoRatingNetflix.Name = "infoRatingNetflix"
        '
        'SplitterLine1
        '
        resources.ApplyResources(Me.SplitterLine1, "SplitterLine1")
        Me.SplitterLine1.BackColor = System.Drawing.Color.Transparent
        Me.SplitterLine1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.SplitterLine1.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.SplitterLine1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitterLine1.DesignerSelected = False
        Me.SplitterLine1.DimFactorClick = 0
        Me.SplitterLine1.DimFactorHover = 0
        Me.SplitterLine1.FillType = CButtonLib.CButton.eFillType.Solid
        Me.SplitterLine1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SplitterLine1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SplitterLine1.ImageIndex = 0
        Me.SplitterLine1.ImageSize = New System.Drawing.Size(25, 36)
        Me.SplitterLine1.Name = "SplitterLine1"
        Me.SplitterLine1.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.SplitterLine1.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SplitterLine1.SideImageSize = New System.Drawing.Size(36, 36)
        Me.SplitterLine1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.SplitterLine1.TextShadowShow = False
        '
        'btnDownloadMovie
        '
        Me.btnDownloadMovie.BackColor = System.Drawing.Color.Transparent
        Me.btnDownloadMovie.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnDownloadMovie.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnDownloadMovie.Corners.All = 3
        Me.btnDownloadMovie.Corners.LowerLeft = 3
        Me.btnDownloadMovie.Corners.LowerRight = 3
        Me.btnDownloadMovie.Corners.UpperLeft = 3
        Me.btnDownloadMovie.Corners.UpperRight = 3
        Me.btnDownloadMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownloadMovie.DesignerSelected = False
        Me.btnDownloadMovie.DimFactorClick = 0
        Me.btnDownloadMovie.DimFactorHover = 0
        Me.btnDownloadMovie.FillType = CButtonLib.CButton.eFillType.Solid
        resources.ApplyResources(Me.btnDownloadMovie, "btnDownloadMovie")
        Me.btnDownloadMovie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDownloadMovie.ImageIndex = 0
        Me.btnDownloadMovie.Name = "btnDownloadMovie"
        Me.btnDownloadMovie.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnDownloadMovie.TextShadowShow = False
        '
        'btnWatchMovie
        '
        Me.btnWatchMovie.BackColor = System.Drawing.Color.Transparent
        Me.btnWatchMovie.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnWatchMovie.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnWatchMovie.Corners.All = 3
        Me.btnWatchMovie.Corners.LowerLeft = 3
        Me.btnWatchMovie.Corners.LowerRight = 3
        Me.btnWatchMovie.Corners.UpperLeft = 3
        Me.btnWatchMovie.Corners.UpperRight = 3
        Me.btnWatchMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWatchMovie.DesignerSelected = False
        Me.btnWatchMovie.DimFactorClick = 0
        Me.btnWatchMovie.DimFactorHover = 0
        Me.btnWatchMovie.FillType = CButtonLib.CButton.eFillType.Solid
        resources.ApplyResources(Me.btnWatchMovie, "btnWatchMovie")
        Me.btnWatchMovie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnWatchMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWatchMovie.ImageIndex = 0
        Me.btnWatchMovie.ImageSize = New System.Drawing.Size(25, 36)
        Me.btnWatchMovie.Name = "btnWatchMovie"
        Me.btnWatchMovie.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnWatchMovie.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnWatchMovie.SideImageSize = New System.Drawing.Size(25, 25)
        Me.btnWatchMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnWatchMovie.TextMargin = New System.Windows.Forms.Padding(1, 2, 0, 2)
        Me.btnWatchMovie.TextShadowShow = False
        '
        'lblStatus
        '
        resources.ApplyResources(Me.lblStatus, "lblStatus")
        Me.lblStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblStatus.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblStatus.Corners.LowerLeft = 2
        Me.lblStatus.Corners.LowerRight = 2
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStatus.DesignerSelected = True
        Me.lblStatus.DimFactorClick = 0
        Me.lblStatus.DimFactorHover = 0
        Me.lblStatus.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblStatus.ImageIndex = 0
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblStatus.TabStop = False
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblStatus.TextMargin = New System.Windows.Forms.Padding(1, 2, 2, 5)
        Me.lblStatus.TextShadowShow = False
        '
        'infoBackgroundImageLink
        '
        resources.ApplyResources(Me.infoBackgroundImageLink, "infoBackgroundImageLink")
        Me.infoBackgroundImageLink.ForeColor = System.Drawing.Color.White
        Me.infoBackgroundImageLink.Name = "infoBackgroundImageLink"
        '
        'btnWatchTrailer
        '
        Me.btnWatchTrailer.BackColor = System.Drawing.Color.Transparent
        Me.btnWatchTrailer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWatchTrailer.Image = Global.Movieo.My.Resources.Resources.PlayIcon
        resources.ApplyResources(Me.btnWatchTrailer, "btnWatchTrailer")
        Me.btnWatchTrailer.Name = "btnWatchTrailer"
        Me.btnWatchTrailer.TabStop = False
        '
        'imgNetflix
        '
        resources.ApplyResources(Me.imgNetflix, "imgNetflix")
        Me.imgNetflix.BackColor = System.Drawing.Color.Transparent
        Me.imgNetflix.Image = Global.Movieo.My.Resources.Resources.NetflixIcon
        Me.imgNetflix.Name = "imgNetflix"
        Me.imgNetflix.TabStop = False
        '
        'imgPoster
        '
        resources.ApplyResources(Me.imgPoster, "imgPoster")
        Me.imgPoster.Name = "imgPoster"
        Me.imgPoster.TabStop = False
        '
        'ImgMetaCritic
        '
        resources.ApplyResources(Me.ImgMetaCritic, "ImgMetaCritic")
        Me.ImgMetaCritic.BackColor = System.Drawing.Color.Transparent
        Me.ImgMetaCritic.Image = Global.Movieo.My.Resources.Resources.MetaCriticIcon
        Me.ImgMetaCritic.Name = "ImgMetaCritic"
        Me.ImgMetaCritic.TabStop = False
        '
        'imgImdb
        '
        resources.ApplyResources(Me.imgImdb, "imgImdb")
        Me.imgImdb.BackColor = System.Drawing.Color.Transparent
        Me.imgImdb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgImdb.Image = Global.Movieo.My.Resources.Resources.ImdbIcon
        Me.imgImdb.Name = "imgImdb"
        Me.imgImdb.TabStop = False
        '
        'appClose
        '
        resources.ApplyResources(Me.appClose, "appClose")
        Me.appClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.appClose.Name = "appClose"
        Me.appClose.TabStop = False
        '
        'btnFavouriteList
        '
        Me.btnFavouriteList.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnFavouriteList, "btnFavouriteList")
        Me.btnFavouriteList.Name = "btnFavouriteList"
        Me.btnFavouriteList.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnFavouriteList, resources.GetString("btnFavouriteList.ToolTip"))
        '
        'btnWatchList
        '
        Me.btnWatchList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWatchList.Image = Global.Movieo.My.Resources.Resources.Watch_List_L
        resources.ApplyResources(Me.btnWatchList, "btnWatchList")
        Me.btnWatchList.Name = "btnWatchList"
        Me.btnWatchList.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnWatchList, resources.GetString("btnWatchList.ToolTip"))
        '
        'btnSeenList
        '
        Me.btnSeenList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeenList.Image = Global.Movieo.My.Resources.Resources.Seen_List_L
        resources.ApplyResources(Me.btnSeenList, "btnSeenList")
        Me.btnSeenList.Name = "btnSeenList"
        Me.btnSeenList.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnSeenList, resources.GetString("btnSeenList.ToolTip"))
        '
        'btnBlackList
        '
        Me.btnBlackList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlackList.Image = Global.Movieo.My.Resources.Resources.Black_List_Icon_L
        resources.ApplyResources(Me.btnBlackList, "btnBlackList")
        Me.btnBlackList.Name = "btnBlackList"
        Me.btnBlackList.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnBlackList, resources.GetString("btnBlackList.ToolTip"))
        '
        'btnMyList
        '
        Me.btnMyList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyList.Image = Global.Movieo.My.Resources.Resources.My_Lists_L
        resources.ApplyResources(Me.btnMyList, "btnMyList")
        Me.btnMyList.Name = "btnMyList"
        Me.btnMyList.TabStop = False
        Me.ToolTip.SetToolTip(Me.btnMyList, resources.GetString("btnMyList.ToolTip"))
        '
        'frmMovieDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.btnWatchTrailer)
        Me.Controls.Add(Me.infoBackgroundImageLink)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.infoRatingNetflix)
        Me.Controls.Add(Me.imgNetflix)
        Me.Controls.Add(Me.imgPoster)
        Me.Controls.Add(Me.infoTrailerLink)
        Me.Controls.Add(Me.panelDetails)
        Me.Controls.Add(Me.infoImageLink)
        Me.Controls.Add(Me.infoImdbId)
        Me.Controls.Add(Me.infoRatingMetaScore)
        Me.Controls.Add(Me.ImgMetaCritic)
        Me.Controls.Add(Me.infoRatingIMDb)
        Me.Controls.Add(Me.imgImdb)
        Me.Controls.Add(Me.SplitterLine1)
        Me.Controls.Add(Me.btnDownloadMovie)
        Me.Controls.Add(Me.infoWatchLinks)
        Me.Controls.Add(Me.btnWatchMovie)
        Me.Controls.Add(Me.appClose)
        Me.Controls.Add(Me.ActionsPanel)
        Me.Controls.Add(Me.InfoPanel1)
        Me.Controls.Add(Me.msgErrorComments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovieDetails"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.ActionsPanel.ResumeLayout(False)
        Me.InfoPanel1.ResumeLayout(False)
        Me.InfoPanel1.PerformLayout()
        Me.panelHeaders.ResumeLayout(False)
        Me.panelHeaders.PerformLayout()
        Me.panelDetails.ResumeLayout(False)
        Me.panelDetails.PerformLayout()
        CType(Me.btnWatchTrailer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNetflix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPoster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMetaCritic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgImdb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFavouriteList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnWatchList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeenList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBlackList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMyList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents infoTitle As Label
    Friend WithEvents infoYear As Label
    Friend WithEvents infoGenre As Label
    Friend WithEvents btnFavouriteList As PictureBox
    Friend WithEvents appClose As PictureBox
    Friend WithEvents ActionsPanel As FlowLayoutPanel
    Friend WithEvents Splitter2 As Label
    Friend WithEvents btnWatchList As PictureBox
    Friend WithEvents infoDuration As Label
    Friend WithEvents infoImageLink As Label
    Friend WithEvents infoDirectors As Label
    Public WithEvents btnWatchMovie As CButtonLib.CButton
    Friend WithEvents infoWatchLinks As Label
    Public WithEvents btnDownloadMovie As CButtonLib.CButton
    Friend WithEvents lblSubCast As Label
    Friend WithEvents lblSubDirectors As Label
    Friend WithEvents Splitter3 As Label
    Friend WithEvents btnSeenList As PictureBox
    Friend WithEvents Splitter4 As Label
    Friend WithEvents btnBlackList As PictureBox
    Friend WithEvents infoQuality As Label
    Public WithEvents SplitterLine1 As CButtonLib.CButton
    Friend WithEvents lblSubRating As Label
    Friend WithEvents lblSubRuntime As Label
    Friend WithEvents lblSubReleaseDate As Label
    Friend WithEvents lblSubCountry As Label
    Friend WithEvents lblHeaderDetails As Label
    Friend WithEvents infoRating As Label
    Friend WithEvents imgImdb As PictureBox
    Friend WithEvents infoRatingIMDb As Label
    Friend WithEvents infoRatingMetaScore As Label
    Friend WithEvents ImgMetaCritic As PictureBox
    Friend WithEvents infoReleaseDate As Label
    Friend WithEvents Splitter1 As Label
    Friend WithEvents infoProduction As Label
    Friend WithEvents lblSubProduction As Label
    Friend WithEvents infoBoxOffice As Label
    Friend WithEvents lblSubBoxOffice As Label
    Friend WithEvents InfoPanel1 As FlowLayoutPanel
    Friend WithEvents infoLanguage As Label
    Friend WithEvents lblSubLanguage As Label
    Friend WithEvents infoCountry As Label
    Friend WithEvents infoAwards As Label
    Friend WithEvents lblSubAwards As Label
    Friend WithEvents infoImdbId As Label
    Friend WithEvents infoDescription As Label
    Friend WithEvents panelDetails As FlowLayoutPanel
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MovieLinkText As Label
    Friend WithEvents panelHeaders As Panel
    Public WithEvents lineUserReviews As CButtonLib.CButton
    Friend WithEvents txtShareName As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents lblHeaderUserReviews As Label
    Friend WithEvents txtFormNameBG As CButtonLib.CButton
    Friend WithEvents btnCommentSubmit As CButtonLib.CButton
    Friend WithEvents txtFormCommentBG As CButtonLib.CButton
    Public WithEvents lineSplitter As CButtonLib.CButton
    Friend WithEvents panelComments As FlowLayoutPanel
    Friend WithEvents txtShareComment As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents infoTrailerLink As Label
    Friend WithEvents msgErrorComments As Label
    Friend WithEvents imgPanelsEmpty0 As Label
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents getStarsTimer As Timer
    Friend WithEvents imgPoster As PictureBox
    Friend WithEvents infoCast As Label
    Friend WithEvents infoRatingNetflix As Label
    Friend WithEvents imgNetflix As PictureBox
    Friend WithEvents imgPanelsEmptyReviews As Label
    Friend WithEvents lblStatus As CButtonLib.CButton
    Friend WithEvents infoBackgroundImageLink As Label
    Friend WithEvents btnWatchTrailer As PictureBox
    Friend WithEvents Splitter5 As Label
    Friend WithEvents btnMyList As PictureBox
End Class
