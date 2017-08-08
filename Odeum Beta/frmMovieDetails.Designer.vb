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
        Me.BtnFavouriteList = New System.Windows.Forms.PictureBox()
        Me.Splitter2 = New System.Windows.Forms.Label()
        Me.BtnWatchList = New System.Windows.Forms.PictureBox()
        Me.Splitter3 = New System.Windows.Forms.Label()
        Me.BtnSeenList = New System.Windows.Forms.PictureBox()
        Me.Splitter4 = New System.Windows.Forms.Label()
        Me.BtnBlackList = New System.Windows.Forms.PictureBox()
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
        Me.panelShareComment = New System.Windows.Forms.Panel()
        Me.lblMessageSent = New CButtonLib.CButton()
        Me.txtShareName = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.txtShareComment = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.txtFormCommentBG = New CButtonLib.CButton()
        Me.lineComments = New CButtonLib.CButton()
        Me.panelComments = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCommentSubmit = New CButtonLib.CButton()
        Me.txtFormNameBG = New CButtonLib.CButton()
        Me.lblHeaderComments = New System.Windows.Forms.Label()
        Me.lineSplitter = New CButtonLib.CButton()
        Me.lblSimilar = New System.Windows.Forms.Label()
        Me.infoLanguage = New System.Windows.Forms.Label()
        Me.lblSubLanguage = New System.Windows.Forms.Label()
        Me.infoCountry = New System.Windows.Forms.Label()
        Me.infoAwards = New System.Windows.Forms.Label()
        Me.lblSubAwards = New System.Windows.Forms.Label()
        Me.infoImdbId = New System.Windows.Forms.Label()
        Me.infoRTomLink = New System.Windows.Forms.Label()
        Me.panelDetails = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MovieLinkText = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.infoTrailerLink = New System.Windows.Forms.Label()
        Me.msgErrorComments = New System.Windows.Forms.Label()
        Me.imgPanelsEmpty0 = New System.Windows.Forms.Label()
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.getStarsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timerHideNotification = New System.Windows.Forms.Timer(Me.components)
        Me.timerHideNotificationss = New System.Windows.Forms.Timer(Me.components)
        Me.MovImage = New System.Windows.Forms.PictureBox()
        Me.ImgMetaCritic = New System.Windows.Forms.PictureBox()
        Me.imgImdb = New System.Windows.Forms.PictureBox()
        Me.appClose = New System.Windows.Forms.PictureBox()
        Me.infoRatingNetflix = New System.Windows.Forms.Label()
        Me.imgNetflix = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnWatchTrailer = New CButtonLib.CButton()
        Me.SplitterLine1 = New CButtonLib.CButton()
        Me.btnDownloadMovie = New CButtonLib.CButton()
        Me.btnWatchMovie = New CButtonLib.CButton()
        Me.imgPanelsEmptyReviews = New System.Windows.Forms.Label()
        Me.ActionsPanel.SuspendLayout()
        CType(Me.BtnFavouriteList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnWatchList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSeenList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBlackList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoPanel1.SuspendLayout()
        Me.panelShareComment.SuspendLayout()
        Me.panelDetails.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.MovImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMetaCritic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgImdb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNetflix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ActionsPanel.Controls.Add(Me.BtnFavouriteList)
        Me.ActionsPanel.Controls.Add(Me.Splitter2)
        Me.ActionsPanel.Controls.Add(Me.BtnWatchList)
        Me.ActionsPanel.Controls.Add(Me.Splitter3)
        Me.ActionsPanel.Controls.Add(Me.BtnSeenList)
        Me.ActionsPanel.Controls.Add(Me.Splitter4)
        Me.ActionsPanel.Controls.Add(Me.BtnBlackList)
        resources.ApplyResources(Me.ActionsPanel, "ActionsPanel")
        Me.ActionsPanel.Name = "ActionsPanel"
        '
        'BtnFavouriteList
        '
        Me.BtnFavouriteList.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.BtnFavouriteList, "BtnFavouriteList")
        Me.BtnFavouriteList.Name = "BtnFavouriteList"
        Me.BtnFavouriteList.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnFavouriteList, resources.GetString("BtnFavouriteList.ToolTip"))
        '
        'Splitter2
        '
        resources.ApplyResources(Me.Splitter2, "Splitter2")
        Me.Splitter2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Splitter2.Name = "Splitter2"
        '
        'BtnWatchList
        '
        Me.BtnWatchList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWatchList.Image = Global.Movieo.My.Resources.Resources.Watch_List_L
        resources.ApplyResources(Me.BtnWatchList, "BtnWatchList")
        Me.BtnWatchList.Name = "BtnWatchList"
        Me.BtnWatchList.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnWatchList, resources.GetString("BtnWatchList.ToolTip"))
        '
        'Splitter3
        '
        resources.ApplyResources(Me.Splitter3, "Splitter3")
        Me.Splitter3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Splitter3.Name = "Splitter3"
        '
        'BtnSeenList
        '
        Me.BtnSeenList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSeenList.Image = Global.Movieo.My.Resources.Resources.Seen_List_L
        resources.ApplyResources(Me.BtnSeenList, "BtnSeenList")
        Me.BtnSeenList.Name = "BtnSeenList"
        Me.BtnSeenList.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSeenList, resources.GetString("BtnSeenList.ToolTip"))
        '
        'Splitter4
        '
        resources.ApplyResources(Me.Splitter4, "Splitter4")
        Me.Splitter4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Splitter4.Name = "Splitter4"
        '
        'BtnBlackList
        '
        Me.BtnBlackList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBlackList.Image = Global.Movieo.My.Resources.Resources.Black_List_Icon_L
        resources.ApplyResources(Me.BtnBlackList, "BtnBlackList")
        Me.BtnBlackList.Name = "BtnBlackList"
        Me.BtnBlackList.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnBlackList, resources.GetString("BtnBlackList.ToolTip"))
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
        Me.InfoPanel1.Controls.Add(Me.panelShareComment)
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
        'panelShareComment
        '
        resources.ApplyResources(Me.panelShareComment, "panelShareComment")
        Me.panelShareComment.BackColor = System.Drawing.Color.Transparent
        Me.panelShareComment.Controls.Add(Me.imgPanelsEmptyReviews)
        Me.panelShareComment.Controls.Add(Me.lblMessageSent)
        Me.panelShareComment.Controls.Add(Me.txtShareName)
        Me.panelShareComment.Controls.Add(Me.txtShareComment)
        Me.panelShareComment.Controls.Add(Me.txtFormCommentBG)
        Me.panelShareComment.Controls.Add(Me.lineComments)
        Me.panelShareComment.Controls.Add(Me.panelComments)
        Me.panelShareComment.Controls.Add(Me.btnCommentSubmit)
        Me.panelShareComment.Controls.Add(Me.txtFormNameBG)
        Me.panelShareComment.Controls.Add(Me.lblHeaderComments)
        Me.panelShareComment.Controls.Add(Me.lineSplitter)
        Me.panelShareComment.Name = "panelShareComment"
        '
        'lblMessageSent
        '
        resources.ApplyResources(Me.lblMessageSent, "lblMessageSent")
        Me.lblMessageSent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblMessageSent.BorderShow = False
        Me.lblMessageSent.ColorFillSolid = System.Drawing.Color.Transparent
        Me.lblMessageSent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMessageSent.DesignerSelected = False
        Me.lblMessageSent.DimFactorClick = 0
        Me.lblMessageSent.DimFactorHover = 0
        Me.lblMessageSent.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblMessageSent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblMessageSent.ImageIndex = 0
        Me.lblMessageSent.Name = "lblMessageSent"
        Me.lblMessageSent.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblMessageSent.TabStop = False
        Me.lblMessageSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMessageSent.TextMargin = New System.Windows.Forms.Padding(0)
        Me.lblMessageSent.TextShadowShow = False
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
        'lineComments
        '
        Me.lineComments.BackColor = System.Drawing.Color.Transparent
        Me.lineComments.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lineComments.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lineComments.Cursor = System.Windows.Forms.Cursors.Default
        Me.lineComments.DesignerSelected = False
        Me.lineComments.DimFactorClick = 0
        Me.lineComments.DimFactorHover = 0
        Me.lineComments.FillType = CButtonLib.CButton.eFillType.Solid
        resources.ApplyResources(Me.lineComments, "lineComments")
        Me.lineComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lineComments.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lineComments.ImageIndex = 0
        Me.lineComments.ImageSize = New System.Drawing.Size(25, 36)
        Me.lineComments.Name = "lineComments"
        Me.lineComments.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lineComments.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lineComments.SideImageSize = New System.Drawing.Size(36, 36)
        Me.lineComments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.lineComments.TextShadowShow = False
        '
        'panelComments
        '
        resources.ApplyResources(Me.panelComments, "panelComments")
        Me.panelComments.BackColor = System.Drawing.Color.Transparent
        Me.panelComments.Name = "panelComments"
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
        'lblHeaderComments
        '
        resources.ApplyResources(Me.lblHeaderComments, "lblHeaderComments")
        Me.lblHeaderComments.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderComments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHeaderComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblHeaderComments.Name = "lblHeaderComments"
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
        'lblSimilar
        '
        resources.ApplyResources(Me.lblSimilar, "lblSimilar")
        Me.lblSimilar.Name = "lblSimilar"
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
        'infoRTomLink
        '
        Me.infoRTomLink.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.infoRTomLink, "infoRTomLink")
        Me.infoRTomLink.ForeColor = System.Drawing.Color.White
        Me.infoRTomLink.Name = "infoRTomLink"
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblSimilar)
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'FlowLayoutPanel2
        '
        resources.ApplyResources(Me.FlowLayoutPanel2, "FlowLayoutPanel2")
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
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
        'timerHideNotification
        '
        Me.timerHideNotification.Interval = 4000
        '
        'timerHideNotificationss
        '
        Me.timerHideNotificationss.Interval = 4000
        '
        'MovImage
        '
        resources.ApplyResources(Me.MovImage, "MovImage")
        Me.MovImage.Name = "MovImage"
        Me.MovImage.TabStop = False
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
        'infoRatingNetflix
        '
        resources.ApplyResources(Me.infoRatingNetflix, "infoRatingNetflix")
        Me.infoRatingNetflix.BackColor = System.Drawing.Color.Transparent
        Me.infoRatingNetflix.Cursor = System.Windows.Forms.Cursors.Default
        Me.infoRatingNetflix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoRatingNetflix.Name = "infoRatingNetflix"
        '
        'imgNetflix
        '
        resources.ApplyResources(Me.imgNetflix, "imgNetflix")
        Me.imgNetflix.BackColor = System.Drawing.Color.Transparent
        Me.imgNetflix.Image = Global.Movieo.My.Resources.Resources.NetflixIcon
        Me.imgNetflix.Name = "imgNetflix"
        Me.imgNetflix.TabStop = False
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Movieo.My.Resources.Resources.NetflixIcon
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnWatchTrailer
        '
        Me.btnWatchTrailer.BackColor = System.Drawing.Color.Transparent
        Me.btnWatchTrailer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnWatchTrailer.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnWatchTrailer.Corners.All = 2
        Me.btnWatchTrailer.Corners.LowerLeft = 2
        Me.btnWatchTrailer.Corners.LowerRight = 2
        Me.btnWatchTrailer.Corners.UpperLeft = 2
        Me.btnWatchTrailer.Corners.UpperRight = 2
        Me.btnWatchTrailer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWatchTrailer.DesignerSelected = False
        Me.btnWatchTrailer.DimFactorClick = 0
        Me.btnWatchTrailer.DimFactorHover = 0
        Me.btnWatchTrailer.FillType = CButtonLib.CButton.eFillType.Solid
        resources.ApplyResources(Me.btnWatchTrailer, "btnWatchTrailer")
        Me.btnWatchTrailer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnWatchTrailer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWatchTrailer.ImageIndex = 0
        Me.btnWatchTrailer.ImageSize = New System.Drawing.Size(25, 36)
        Me.btnWatchTrailer.Name = "btnWatchTrailer"
        Me.btnWatchTrailer.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnWatchTrailer.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWatchTrailer.SideImageSize = New System.Drawing.Size(36, 36)
        Me.btnWatchTrailer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnWatchTrailer.TextShadowShow = False
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
        Me.btnDownloadMovie.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDownloadMovie.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnDownloadMovie.Corners.All = 2
        Me.btnDownloadMovie.Corners.LowerLeft = 2
        Me.btnDownloadMovie.Corners.LowerRight = 2
        Me.btnDownloadMovie.Corners.UpperLeft = 2
        Me.btnDownloadMovie.Corners.UpperRight = 2
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
        Me.btnWatchMovie.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnWatchMovie.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnWatchMovie.Corners.All = 2
        Me.btnWatchMovie.Corners.LowerLeft = 2
        Me.btnWatchMovie.Corners.LowerRight = 2
        Me.btnWatchMovie.Corners.UpperLeft = 2
        Me.btnWatchMovie.Corners.UpperRight = 2
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
        Me.btnWatchMovie.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWatchMovie.SideImageSize = New System.Drawing.Size(36, 36)
        Me.btnWatchMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnWatchMovie.TextShadowShow = False
        '
        'imgPanelsEmptyReviews
        '
        resources.ApplyResources(Me.imgPanelsEmptyReviews, "imgPanelsEmptyReviews")
        Me.imgPanelsEmptyReviews.BackColor = System.Drawing.Color.Transparent
        Me.imgPanelsEmptyReviews.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.imgPanelsEmptyReviews.Name = "imgPanelsEmptyReviews"
        '
        'frmMovieDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.infoRatingNetflix)
        Me.Controls.Add(Me.imgNetflix)
        Me.Controls.Add(Me.MovImage)
        Me.Controls.Add(Me.infoTrailerLink)
        Me.Controls.Add(Me.btnWatchTrailer)
        Me.Controls.Add(Me.panelDetails)
        Me.Controls.Add(Me.infoImageLink)
        Me.Controls.Add(Me.infoRTomLink)
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
        CType(Me.BtnFavouriteList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnWatchList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSeenList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBlackList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoPanel1.ResumeLayout(False)
        Me.InfoPanel1.PerformLayout()
        Me.panelShareComment.ResumeLayout(False)
        Me.panelShareComment.PerformLayout()
        Me.panelDetails.ResumeLayout(False)
        Me.panelDetails.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.MovImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMetaCritic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgImdb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNetflix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents infoTitle As Label
    Friend WithEvents infoYear As Label
    Friend WithEvents infoGenre As Label
    Friend WithEvents BtnFavouriteList As PictureBox
    Friend WithEvents appClose As PictureBox
    Friend WithEvents ActionsPanel As FlowLayoutPanel
    Friend WithEvents Splitter2 As Label
    Friend WithEvents BtnWatchList As PictureBox
    Friend WithEvents infoDuration As Label
    Friend WithEvents infoImageLink As Label
    Friend WithEvents infoDirectors As Label
    Public WithEvents btnWatchMovie As CButtonLib.CButton
    Friend WithEvents infoWatchLinks As Label
    Public WithEvents btnDownloadMovie As CButtonLib.CButton
    Friend WithEvents lblSubCast As Label
    Friend WithEvents lblSubDirectors As Label
    Friend WithEvents Splitter3 As Label
    Friend WithEvents BtnSeenList As PictureBox
    Friend WithEvents Splitter4 As Label
    Friend WithEvents BtnBlackList As PictureBox
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
    Friend WithEvents infoRTomLink As Label
    Friend WithEvents panelDetails As FlowLayoutPanel
    Public WithEvents btnWatchTrailer As CButtonLib.CButton
    Friend WithEvents lblSimilar As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MovieLinkText As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents panelShareComment As Panel
    Public WithEvents lineComments As CButtonLib.CButton
    Friend WithEvents txtShareName As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents lblHeaderComments As Label
    Friend WithEvents txtFormNameBG As CButtonLib.CButton
    Friend WithEvents btnCommentSubmit As CButtonLib.CButton
    Friend WithEvents txtFormCommentBG As CButtonLib.CButton
    Public WithEvents lineSplitter As CButtonLib.CButton
    Friend WithEvents panelComments As FlowLayoutPanel
    Friend WithEvents txtShareComment As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents infoTrailerLink As Label
    Friend WithEvents msgErrorComments As Label
    Friend WithEvents imgPanelsEmpty0 As Label
    Friend WithEvents lblMessageSent As CButtonLib.CButton
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents getStarsTimer As Timer
    Friend WithEvents timerHideNotification As Timer
    Friend WithEvents MovImage As PictureBox
    Friend WithEvents timerHideNotificationss As Timer
    Friend WithEvents infoCast As Label
    Friend WithEvents infoRatingNetflix As Label
    Friend WithEvents imgNetflix As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imgPanelsEmptyReviews As Label
End Class
