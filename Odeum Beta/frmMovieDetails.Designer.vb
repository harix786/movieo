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
        Me.InfoTitle = New System.Windows.Forms.Label()
        Me.InfoYear = New System.Windows.Forms.Label()
        Me.InfoGenre = New System.Windows.Forms.Label()
        Me.MovieDuration = New System.Windows.Forms.Label()
        Me.InfoQuality = New System.Windows.Forms.Label()
        Me.MovieImageLinkText = New System.Windows.Forms.Label()
        Me.ActionsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnFavouriteList = New System.Windows.Forms.PictureBox()
        Me.Splitter2 = New System.Windows.Forms.Label()
        Me.BtnWatchList = New System.Windows.Forms.PictureBox()
        Me.Splitter3 = New System.Windows.Forms.Label()
        Me.BtnSeenList = New System.Windows.Forms.PictureBox()
        Me.Splitter4 = New System.Windows.Forms.Label()
        Me.BtnBlackList = New System.Windows.Forms.PictureBox()
        Me.InfoCast = New System.Windows.Forms.Label()
        Me.InfoDirectors = New System.Windows.Forms.Label()
        Me.getStarsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MovieLinkText = New System.Windows.Forms.Label()
        Me.lblSubCast = New System.Windows.Forms.Label()
        Me.lblSubDirectors = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Label()
        Me.lblSubRating = New System.Windows.Forms.Label()
        Me.lblSubRuntime = New System.Windows.Forms.Label()
        Me.lblSubReleaseDate = New System.Windows.Forms.Label()
        Me.lblSubCountry = New System.Windows.Forms.Label()
        Me.lblHeaderDetails = New System.Windows.Forms.Label()
        Me.MovieRating = New System.Windows.Forms.Label()
        Me.MovieImdbRating = New System.Windows.Forms.Label()
        Me.MovieTomRating = New System.Windows.Forms.Label()
        Me.MovieMetaRating = New System.Windows.Forms.Label()
        Me.MovieReleaseDate = New System.Windows.Forms.Label()
        Me.MovieProduction = New System.Windows.Forms.Label()
        Me.lblSubProduction = New System.Windows.Forms.Label()
        Me.MovieBoxOffice = New System.Windows.Forms.Label()
        Me.lblSubBoxOffice = New System.Windows.Forms.Label()
        Me.InfoPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.InfoDescription = New System.Windows.Forms.Label()
        Me.MovieLanguage = New System.Windows.Forms.Label()
        Me.lblSubLanguage = New System.Windows.Forms.Label()
        Me.MovieCountry = New System.Windows.Forms.Label()
        Me.MovieAwards = New System.Windows.Forms.Label()
        Me.lblSubAwards = New System.Windows.Forms.Label()
        Me.MovieImdbId = New System.Windows.Forms.Label()
        Me.MovieRTomLink = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MovImage = New CButtonLib.CButton()
        Me.SplitterLine1 = New CButtonLib.CButton()
        Me.btnDownloadMovie = New CButtonLib.CButton()
        Me.btnWatchMovie = New CButtonLib.CButton()
        Me.frmFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.panelDetails = New System.Windows.Forms.FlowLayoutPanel()
        Me.ImgMetaCritic = New System.Windows.Forms.PictureBox()
        Me.ImgRTomatoes = New System.Windows.Forms.PictureBox()
        Me.ImgImdb = New System.Windows.Forms.PictureBox()
        Me.appClose = New System.Windows.Forms.PictureBox()
        Me.btnWatchTrailer = New CButtonLib.CButton()
        Me.ActionsPanel.SuspendLayout()
        CType(Me.BtnFavouriteList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnWatchList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSeenList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBlackList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoPanel1.SuspendLayout()
        Me.panelDetails.SuspendLayout()
        CType(Me.ImgMetaCritic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgRTomatoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgImdb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoTitle
        '
        Me.InfoTitle.AutoEllipsis = True
        resources.ApplyResources(Me.InfoTitle, "InfoTitle")
        Me.InfoTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.InfoTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.InfoTitle.Name = "InfoTitle"
        '
        'InfoYear
        '
        resources.ApplyResources(Me.InfoYear, "InfoYear")
        Me.InfoPanel1.SetFlowBreak(Me.InfoYear, True)
        Me.InfoYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.InfoYear.Name = "InfoYear"
        '
        'InfoGenre
        '
        resources.ApplyResources(Me.InfoGenre, "InfoGenre")
        Me.InfoGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.InfoGenre.Name = "InfoGenre"
        '
        'MovieDuration
        '
        resources.ApplyResources(Me.MovieDuration, "MovieDuration")
        Me.panelDetails.SetFlowBreak(Me.MovieDuration, True)
        Me.MovieDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieDuration.Name = "MovieDuration"
        '
        'InfoQuality
        '
        resources.ApplyResources(Me.InfoQuality, "InfoQuality")
        Me.InfoPanel1.SetFlowBreak(Me.InfoQuality, True)
        Me.InfoQuality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.InfoQuality.Name = "InfoQuality"
        '
        'MovieImageLinkText
        '
        resources.ApplyResources(Me.MovieImageLinkText, "MovieImageLinkText")
        Me.MovieImageLinkText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieImageLinkText.Name = "MovieImageLinkText"
        '
        'ActionsPanel
        '
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
        '
        'InfoCast
        '
        resources.ApplyResources(Me.InfoCast, "InfoCast")
        Me.InfoCast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.InfoCast.Name = "InfoCast"
        '
        'InfoDirectors
        '
        resources.ApplyResources(Me.InfoDirectors, "InfoDirectors")
        Me.InfoPanel1.SetFlowBreak(Me.InfoDirectors, True)
        Me.InfoDirectors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.InfoDirectors.Name = "InfoDirectors"
        '
        'getStarsTimer
        '
        Me.getStarsTimer.Interval = 10
        '
        'MovieLinkText
        '
        resources.ApplyResources(Me.MovieLinkText, "MovieLinkText")
        Me.MovieLinkText.ForeColor = System.Drawing.Color.White
        Me.MovieLinkText.Name = "MovieLinkText"
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
        Me.lblHeaderDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblHeaderDetails.Name = "lblHeaderDetails"
        '
        'MovieRating
        '
        resources.ApplyResources(Me.MovieRating, "MovieRating")
        Me.panelDetails.SetFlowBreak(Me.MovieRating, True)
        Me.MovieRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieRating.Name = "MovieRating"
        '
        'MovieImdbRating
        '
        resources.ApplyResources(Me.MovieImdbRating, "MovieImdbRating")
        Me.MovieImdbRating.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MovieImdbRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MovieImdbRating.Name = "MovieImdbRating"
        '
        'MovieTomRating
        '
        resources.ApplyResources(Me.MovieTomRating, "MovieTomRating")
        Me.MovieTomRating.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MovieTomRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MovieTomRating.Name = "MovieTomRating"
        '
        'MovieMetaRating
        '
        resources.ApplyResources(Me.MovieMetaRating, "MovieMetaRating")
        Me.MovieMetaRating.Cursor = System.Windows.Forms.Cursors.Default
        Me.MovieMetaRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MovieMetaRating.Name = "MovieMetaRating"
        '
        'MovieReleaseDate
        '
        resources.ApplyResources(Me.MovieReleaseDate, "MovieReleaseDate")
        Me.panelDetails.SetFlowBreak(Me.MovieReleaseDate, True)
        Me.MovieReleaseDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieReleaseDate.Name = "MovieReleaseDate"
        '
        'MovieProduction
        '
        resources.ApplyResources(Me.MovieProduction, "MovieProduction")
        Me.MovieProduction.AutoEllipsis = True
        Me.panelDetails.SetFlowBreak(Me.MovieProduction, True)
        Me.MovieProduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieProduction.Name = "MovieProduction"
        '
        'lblSubProduction
        '
        resources.ApplyResources(Me.lblSubProduction, "lblSubProduction")
        Me.lblSubProduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubProduction.Name = "lblSubProduction"
        '
        'MovieBoxOffice
        '
        resources.ApplyResources(Me.MovieBoxOffice, "MovieBoxOffice")
        Me.panelDetails.SetFlowBreak(Me.MovieBoxOffice, True)
        Me.MovieBoxOffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieBoxOffice.Name = "MovieBoxOffice"
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
        Me.InfoPanel1.Controls.Add(Me.InfoTitle)
        Me.InfoPanel1.Controls.Add(Me.InfoYear)
        Me.InfoPanel1.Controls.Add(Me.InfoGenre)
        Me.InfoPanel1.Controls.Add(Me.Splitter1)
        Me.InfoPanel1.Controls.Add(Me.InfoQuality)
        Me.InfoPanel1.Controls.Add(Me.InfoDescription)
        Me.InfoPanel1.Controls.Add(Me.lblSubDirectors)
        Me.InfoPanel1.Controls.Add(Me.InfoDirectors)
        Me.InfoPanel1.Controls.Add(Me.lblSubCast)
        Me.InfoPanel1.Controls.Add(Me.InfoCast)
        Me.InfoPanel1.Name = "InfoPanel1"
        '
        'InfoDescription
        '
        resources.ApplyResources(Me.InfoDescription, "InfoDescription")
        Me.InfoPanel1.SetFlowBreak(Me.InfoDescription, True)
        Me.InfoDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.InfoDescription.Name = "InfoDescription"
        '
        'MovieLanguage
        '
        resources.ApplyResources(Me.MovieLanguage, "MovieLanguage")
        Me.MovieLanguage.AutoEllipsis = True
        Me.panelDetails.SetFlowBreak(Me.MovieLanguage, True)
        Me.MovieLanguage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieLanguage.Name = "MovieLanguage"
        '
        'lblSubLanguage
        '
        resources.ApplyResources(Me.lblSubLanguage, "lblSubLanguage")
        Me.lblSubLanguage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubLanguage.Name = "lblSubLanguage"
        '
        'MovieCountry
        '
        resources.ApplyResources(Me.MovieCountry, "MovieCountry")
        Me.MovieCountry.AutoEllipsis = True
        Me.panelDetails.SetFlowBreak(Me.MovieCountry, True)
        Me.MovieCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieCountry.Name = "MovieCountry"
        '
        'MovieAwards
        '
        resources.ApplyResources(Me.MovieAwards, "MovieAwards")
        Me.panelDetails.SetFlowBreak(Me.MovieAwards, True)
        Me.MovieAwards.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieAwards.Name = "MovieAwards"
        '
        'lblSubAwards
        '
        resources.ApplyResources(Me.lblSubAwards, "lblSubAwards")
        Me.lblSubAwards.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSubAwards.Name = "lblSubAwards"
        '
        'MovieImdbId
        '
        resources.ApplyResources(Me.MovieImdbId, "MovieImdbId")
        Me.MovieImdbId.ForeColor = System.Drawing.Color.White
        Me.MovieImdbId.Name = "MovieImdbId"
        '
        'MovieRTomLink
        '
        resources.ApplyResources(Me.MovieRTomLink, "MovieRTomLink")
        Me.MovieRTomLink.ForeColor = System.Drawing.Color.White
        Me.MovieRTomLink.Name = "MovieRTomLink"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'MovImage
        '
        Me.MovImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        resources.ApplyResources(Me.MovImage, "MovImage")
        Me.MovImage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MovImage.ColorFillSolid = System.Drawing.Color.Transparent
        Me.MovImage.Corners.All = 2
        Me.MovImage.Corners.LowerLeft = 2
        Me.MovImage.Corners.LowerRight = 2
        Me.MovImage.Corners.UpperLeft = 2
        Me.MovImage.Corners.UpperRight = 2
        Me.MovImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.MovImage.DesignerSelected = False
        Me.MovImage.DimFactorClick = 0
        Me.MovImage.DimFactorHover = 0
        Me.MovImage.FillType = CButtonLib.CButton.eFillType.Solid
        Me.MovImage.ForeColor = System.Drawing.Color.DarkGray
        Me.MovImage.ImageIndex = 0
        Me.MovImage.ImageSize = New System.Drawing.Size(256, 376)
        Me.MovImage.Name = "MovImage"
        Me.MovImage.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.MovImage.TabStop = False
        '
        'SplitterLine1
        '
        resources.ApplyResources(Me.SplitterLine1, "SplitterLine1")
        Me.SplitterLine1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.SplitterLine1.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.SplitterLine1.Corners.All = 2
        Me.SplitterLine1.Corners.LowerLeft = 2
        Me.SplitterLine1.Corners.LowerRight = 2
        Me.SplitterLine1.Corners.UpperLeft = 2
        Me.SplitterLine1.Corners.UpperRight = 2
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
        'frmFadeIn
        '
        Me.frmFadeIn.Interval = 200
        '
        'panelDetails
        '
        resources.ApplyResources(Me.panelDetails, "panelDetails")
        Me.panelDetails.Controls.Add(Me.lblHeaderDetails)
        Me.panelDetails.Controls.Add(Me.lblSubRating)
        Me.panelDetails.Controls.Add(Me.MovieRating)
        Me.panelDetails.Controls.Add(Me.lblSubRuntime)
        Me.panelDetails.Controls.Add(Me.MovieDuration)
        Me.panelDetails.Controls.Add(Me.lblSubReleaseDate)
        Me.panelDetails.Controls.Add(Me.MovieReleaseDate)
        Me.panelDetails.Controls.Add(Me.lblSubCountry)
        Me.panelDetails.Controls.Add(Me.MovieCountry)
        Me.panelDetails.Controls.Add(Me.lblSubLanguage)
        Me.panelDetails.Controls.Add(Me.MovieLanguage)
        Me.panelDetails.Controls.Add(Me.lblSubProduction)
        Me.panelDetails.Controls.Add(Me.MovieProduction)
        Me.panelDetails.Controls.Add(Me.lblSubBoxOffice)
        Me.panelDetails.Controls.Add(Me.MovieBoxOffice)
        Me.panelDetails.Controls.Add(Me.lblSubAwards)
        Me.panelDetails.Controls.Add(Me.MovieAwards)
        Me.panelDetails.Name = "panelDetails"
        '
        'ImgMetaCritic
        '
        resources.ApplyResources(Me.ImgMetaCritic, "ImgMetaCritic")
        Me.ImgMetaCritic.Image = Global.Movieo.My.Resources.Resources.MetaCriticIcon
        Me.ImgMetaCritic.Name = "ImgMetaCritic"
        Me.ImgMetaCritic.TabStop = False
        '
        'ImgRTomatoes
        '
        resources.ApplyResources(Me.ImgRTomatoes, "ImgRTomatoes")
        Me.ImgRTomatoes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgRTomatoes.Image = Global.Movieo.My.Resources.Resources.RTomatoesIcon
        Me.ImgRTomatoes.Name = "ImgRTomatoes"
        Me.ImgRTomatoes.TabStop = False
        '
        'ImgImdb
        '
        resources.ApplyResources(Me.ImgImdb, "ImgImdb")
        Me.ImgImdb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgImdb.Image = Global.Movieo.My.Resources.Resources.ImdbIcon
        Me.ImgImdb.Name = "ImgImdb"
        Me.ImgImdb.TabStop = False
        '
        'appClose
        '
        resources.ApplyResources(Me.appClose, "appClose")
        Me.appClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.appClose.Name = "appClose"
        Me.appClose.TabStop = False
        '
        'btnWatchTrailer
        '
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
        'frmMovieDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Controls.Add(Me.btnWatchTrailer)
        Me.Controls.Add(Me.panelDetails)
        Me.Controls.Add(Me.MovieImageLinkText)
        Me.Controls.Add(Me.MovieRTomLink)
        Me.Controls.Add(Me.MovieImdbId)
        Me.Controls.Add(Me.MovImage)
        Me.Controls.Add(Me.MovieMetaRating)
        Me.Controls.Add(Me.ImgMetaCritic)
        Me.Controls.Add(Me.MovieTomRating)
        Me.Controls.Add(Me.ImgRTomatoes)
        Me.Controls.Add(Me.MovieImdbRating)
        Me.Controls.Add(Me.ImgImdb)
        Me.Controls.Add(Me.SplitterLine1)
        Me.Controls.Add(Me.btnDownloadMovie)
        Me.Controls.Add(Me.MovieLinkText)
        Me.Controls.Add(Me.btnWatchMovie)
        Me.Controls.Add(Me.appClose)
        Me.Controls.Add(Me.ActionsPanel)
        Me.Controls.Add(Me.InfoPanel1)
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
        Me.panelDetails.ResumeLayout(False)
        Me.panelDetails.PerformLayout()
        CType(Me.ImgMetaCritic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgRTomatoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgImdb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InfoTitle As Label
    Friend WithEvents InfoYear As Label
    Friend WithEvents InfoGenre As Label
    Friend WithEvents BtnFavouriteList As PictureBox
    Friend WithEvents appClose As PictureBox
    Friend WithEvents ActionsPanel As FlowLayoutPanel
    Friend WithEvents Splitter2 As Label
    Friend WithEvents BtnWatchList As PictureBox
    Friend WithEvents MovieDuration As Label
    Friend WithEvents MovieImageLinkText As Label
    Friend WithEvents InfoCast As Label
    Friend WithEvents InfoDirectors As Label
    Public WithEvents btnWatchMovie As CButtonLib.CButton
    Friend WithEvents getStarsTimer As Timer
    Friend WithEvents MovieLinkText As Label
    Public WithEvents btnDownloadMovie As CButtonLib.CButton
    Friend WithEvents lblSubCast As Label
    Friend WithEvents lblSubDirectors As Label
    Friend WithEvents Splitter3 As Label
    Friend WithEvents BtnSeenList As PictureBox
    Friend WithEvents Splitter4 As Label
    Friend WithEvents BtnBlackList As PictureBox
    Friend WithEvents InfoQuality As Label
    Public WithEvents SplitterLine1 As CButtonLib.CButton
    Friend WithEvents lblSubRating As Label
    Friend WithEvents lblSubRuntime As Label
    Friend WithEvents lblSubReleaseDate As Label
    Friend WithEvents lblSubCountry As Label
    Friend WithEvents lblHeaderDetails As Label
    Friend WithEvents MovieRating As Label
    Friend WithEvents ImgImdb As PictureBox
    Friend WithEvents MovieImdbRating As Label
    Friend WithEvents MovieTomRating As Label
    Friend WithEvents ImgRTomatoes As PictureBox
    Friend WithEvents MovieMetaRating As Label
    Friend WithEvents ImgMetaCritic As PictureBox
    Friend WithEvents MovieReleaseDate As Label
    Friend WithEvents Splitter1 As Label
    Friend WithEvents MovieProduction As Label
    Friend WithEvents lblSubProduction As Label
    Friend WithEvents MovieBoxOffice As Label
    Friend WithEvents lblSubBoxOffice As Label
    Friend WithEvents InfoPanel1 As FlowLayoutPanel
    Public WithEvents MovImage As CButtonLib.CButton
    Friend WithEvents MovieLanguage As Label
    Friend WithEvents lblSubLanguage As Label
    Friend WithEvents MovieCountry As Label
    Friend WithEvents MovieAwards As Label
    Friend WithEvents lblSubAwards As Label
    Friend WithEvents MovieImdbId As Label
    Friend WithEvents InfoDescription As Label
    Friend WithEvents MovieRTomLink As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents frmFadeIn As Timer
    Friend WithEvents panelDetails As FlowLayoutPanel
    Public WithEvents btnWatchTrailer As CButtonLib.CButton
End Class
