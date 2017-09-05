<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlPosterTitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlPosterTitle))
        Me.InfoMovieLink = New System.Windows.Forms.Label()
        Me.InfoPosterLink = New System.Windows.Forms.Label()
        Me.InfoDesc = New System.Windows.Forms.Label()
        Me.InfoDuration = New System.Windows.Forms.Label()
        Me.infoRatingIMDb = New System.Windows.Forms.Label()
        Me.InfoYear = New System.Windows.Forms.Label()
        Me.InfoGenre = New System.Windows.Forms.Label()
        Me.InfoSearches = New System.Windows.Forms.RichTextBox()
        Me.InfoStars = New System.Windows.Forms.Label()
        Me.InfoDirector = New System.Windows.Forms.Label()
        Me.InfoReleaseDate = New System.Windows.Forms.Label()
        Me.InfoTitle = New System.Windows.Forms.Label()
        Me.infoRatingMetaScore = New System.Windows.Forms.Label()
        Me.InfoRating = New System.Windows.Forms.Label()
        Me.InfoCountry = New System.Windows.Forms.Label()
        Me.InfoLanguage = New System.Windows.Forms.Label()
        Me.InfoAwards = New System.Windows.Forms.Label()
        Me.InfoProduction = New System.Windows.Forms.Label()
        Me.InfoBoxOffice = New System.Windows.Forms.Label()
        Me.InfoImdbId = New System.Windows.Forms.Label()
        Me.InfoMovieQuality = New System.Windows.Forms.Label()
        Me.InfoPoster = New CButtonLib.CButton()
        Me.InfoPoster2 = New CButtonLib.CButton()
        Me.InfoImdbRatingPoster = New CButtonLib.CButton()
        Me.imageBackgroundEffect = New System.Windows.Forms.PictureBox()
        Me.infoRatingNetflix = New System.Windows.Forms.Label()
        Me.InfoTitleAndYear = New System.Windows.Forms.Label()
        CType(Me.imageBackgroundEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoMovieLink
        '
        Me.InfoMovieLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoMovieLink.AutoSize = True
        Me.InfoMovieLink.Location = New System.Drawing.Point(70, 173)
        Me.InfoMovieLink.Name = "InfoMovieLink"
        Me.InfoMovieLink.Size = New System.Drawing.Size(24, 13)
        Me.InfoMovieLink.TabIndex = 29
        Me.InfoMovieLink.Text = "n/a"
        Me.InfoMovieLink.Visible = False
        '
        'InfoPosterLink
        '
        Me.InfoPosterLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoPosterLink.AutoSize = True
        Me.InfoPosterLink.Location = New System.Drawing.Point(70, 160)
        Me.InfoPosterLink.Name = "InfoPosterLink"
        Me.InfoPosterLink.Size = New System.Drawing.Size(24, 13)
        Me.InfoPosterLink.TabIndex = 28
        Me.InfoPosterLink.Text = "n/a"
        Me.InfoPosterLink.Visible = False
        '
        'InfoDesc
        '
        Me.InfoDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoDesc.AutoSize = True
        Me.InfoDesc.Location = New System.Drawing.Point(70, 147)
        Me.InfoDesc.Name = "InfoDesc"
        Me.InfoDesc.Size = New System.Drawing.Size(24, 13)
        Me.InfoDesc.TabIndex = 27
        Me.InfoDesc.Text = "n/a"
        Me.InfoDesc.Visible = False
        '
        'InfoDuration
        '
        Me.InfoDuration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoDuration.AutoSize = True
        Me.InfoDuration.Location = New System.Drawing.Point(70, 134)
        Me.InfoDuration.Name = "InfoDuration"
        Me.InfoDuration.Size = New System.Drawing.Size(24, 13)
        Me.InfoDuration.TabIndex = 26
        Me.InfoDuration.Text = "n/a"
        Me.InfoDuration.Visible = False
        '
        'infoRatingIMDb
        '
        Me.infoRatingIMDb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoRatingIMDb.AutoSize = True
        Me.infoRatingIMDb.Location = New System.Drawing.Point(70, 121)
        Me.infoRatingIMDb.Name = "infoRatingIMDb"
        Me.infoRatingIMDb.Size = New System.Drawing.Size(24, 13)
        Me.infoRatingIMDb.TabIndex = 25
        Me.infoRatingIMDb.Text = "n/a"
        Me.infoRatingIMDb.Visible = False
        '
        'InfoYear
        '
        Me.InfoYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InfoYear.AutoSize = True
        Me.InfoYear.BackColor = System.Drawing.Color.Transparent
        Me.InfoYear.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.InfoYear.ForeColor = System.Drawing.Color.DarkGray
        Me.InfoYear.Location = New System.Drawing.Point(7, 248)
        Me.InfoYear.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.InfoYear.Name = "InfoYear"
        Me.InfoYear.Size = New System.Drawing.Size(33, 17)
        Me.InfoYear.TabIndex = 23
        Me.InfoYear.Text = "Year"
        '
        'InfoGenre
        '
        Me.InfoGenre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoGenre.AutoSize = True
        Me.InfoGenre.Location = New System.Drawing.Point(70, 108)
        Me.InfoGenre.Name = "InfoGenre"
        Me.InfoGenre.Size = New System.Drawing.Size(24, 13)
        Me.InfoGenre.TabIndex = 22
        Me.InfoGenre.Text = "n/a"
        Me.InfoGenre.Visible = False
        '
        'InfoSearches
        '
        Me.InfoSearches.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoSearches.Location = New System.Drawing.Point(26, 22)
        Me.InfoSearches.Name = "InfoSearches"
        Me.InfoSearches.Size = New System.Drawing.Size(10, 25)
        Me.InfoSearches.TabIndex = 31
        Me.InfoSearches.Text = ""
        Me.InfoSearches.Visible = False
        '
        'InfoStars
        '
        Me.InfoStars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoStars.AutoSize = True
        Me.InfoStars.Location = New System.Drawing.Point(64, 128)
        Me.InfoStars.Name = "InfoStars"
        Me.InfoStars.Size = New System.Drawing.Size(24, 13)
        Me.InfoStars.TabIndex = 35
        Me.InfoStars.Text = "n/a"
        Me.InfoStars.Visible = False
        '
        'InfoDirector
        '
        Me.InfoDirector.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoDirector.AutoSize = True
        Me.InfoDirector.Location = New System.Drawing.Point(72, 136)
        Me.InfoDirector.Name = "InfoDirector"
        Me.InfoDirector.Size = New System.Drawing.Size(24, 13)
        Me.InfoDirector.TabIndex = 36
        Me.InfoDirector.Text = "n/a"
        Me.InfoDirector.Visible = False
        '
        'InfoReleaseDate
        '
        Me.InfoReleaseDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoReleaseDate.AutoSize = True
        Me.InfoReleaseDate.Location = New System.Drawing.Point(80, 144)
        Me.InfoReleaseDate.Name = "InfoReleaseDate"
        Me.InfoReleaseDate.Size = New System.Drawing.Size(24, 13)
        Me.InfoReleaseDate.TabIndex = 37
        Me.InfoReleaseDate.Text = "n/a"
        Me.InfoReleaseDate.Visible = False
        '
        'InfoTitle
        '
        Me.InfoTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTitle.AutoEllipsis = True
        Me.InfoTitle.BackColor = System.Drawing.Color.Transparent
        Me.InfoTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.InfoTitle.ForeColor = System.Drawing.Color.White
        Me.InfoTitle.Location = New System.Drawing.Point(6, 225)
        Me.InfoTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.InfoTitle.Name = "InfoTitle"
        Me.InfoTitle.Size = New System.Drawing.Size(148, 25)
        Me.InfoTitle.TabIndex = 43
        Me.InfoTitle.Text = "Movie Title"
        Me.InfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'infoRatingMetaScore
        '
        Me.infoRatingMetaScore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoRatingMetaScore.AutoSize = True
        Me.infoRatingMetaScore.Location = New System.Drawing.Point(73, 157)
        Me.infoRatingMetaScore.Name = "infoRatingMetaScore"
        Me.infoRatingMetaScore.Size = New System.Drawing.Size(24, 13)
        Me.infoRatingMetaScore.TabIndex = 46
        Me.infoRatingMetaScore.Text = "n/a"
        Me.infoRatingMetaScore.Visible = False
        '
        'InfoRating
        '
        Me.InfoRating.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoRating.AutoSize = True
        Me.InfoRating.Location = New System.Drawing.Point(89, 173)
        Me.InfoRating.Name = "InfoRating"
        Me.InfoRating.Size = New System.Drawing.Size(24, 13)
        Me.InfoRating.TabIndex = 48
        Me.InfoRating.Text = "n/a"
        Me.InfoRating.Visible = False
        '
        'InfoCountry
        '
        Me.InfoCountry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoCountry.AutoSize = True
        Me.InfoCountry.Location = New System.Drawing.Point(97, 181)
        Me.InfoCountry.Name = "InfoCountry"
        Me.InfoCountry.Size = New System.Drawing.Size(24, 13)
        Me.InfoCountry.TabIndex = 49
        Me.InfoCountry.Text = "n/a"
        Me.InfoCountry.Visible = False
        '
        'InfoLanguage
        '
        Me.InfoLanguage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoLanguage.AutoSize = True
        Me.InfoLanguage.Location = New System.Drawing.Point(105, 189)
        Me.InfoLanguage.Name = "InfoLanguage"
        Me.InfoLanguage.Size = New System.Drawing.Size(24, 13)
        Me.InfoLanguage.TabIndex = 50
        Me.InfoLanguage.Text = "n/a"
        Me.InfoLanguage.Visible = False
        '
        'InfoAwards
        '
        Me.InfoAwards.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoAwards.AutoSize = True
        Me.InfoAwards.Location = New System.Drawing.Point(113, 197)
        Me.InfoAwards.Name = "InfoAwards"
        Me.InfoAwards.Size = New System.Drawing.Size(24, 13)
        Me.InfoAwards.TabIndex = 51
        Me.InfoAwards.Text = "n/a"
        Me.InfoAwards.Visible = False
        '
        'InfoProduction
        '
        Me.InfoProduction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoProduction.AutoSize = True
        Me.InfoProduction.Location = New System.Drawing.Point(121, 205)
        Me.InfoProduction.Name = "InfoProduction"
        Me.InfoProduction.Size = New System.Drawing.Size(24, 13)
        Me.InfoProduction.TabIndex = 52
        Me.InfoProduction.Text = "n/a"
        Me.InfoProduction.Visible = False
        '
        'InfoBoxOffice
        '
        Me.InfoBoxOffice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoBoxOffice.AutoSize = True
        Me.InfoBoxOffice.Location = New System.Drawing.Point(129, 213)
        Me.InfoBoxOffice.Name = "InfoBoxOffice"
        Me.InfoBoxOffice.Size = New System.Drawing.Size(24, 13)
        Me.InfoBoxOffice.TabIndex = 53
        Me.InfoBoxOffice.Text = "n/a"
        Me.InfoBoxOffice.Visible = False
        '
        'InfoImdbId
        '
        Me.InfoImdbId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoImdbId.AutoSize = True
        Me.InfoImdbId.Location = New System.Drawing.Point(137, 221)
        Me.InfoImdbId.Name = "InfoImdbId"
        Me.InfoImdbId.Size = New System.Drawing.Size(24, 13)
        Me.InfoImdbId.TabIndex = 54
        Me.InfoImdbId.Text = "n/a"
        Me.InfoImdbId.Visible = False
        '
        'InfoMovieQuality
        '
        Me.InfoMovieQuality.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoMovieQuality.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.InfoMovieQuality.ForeColor = System.Drawing.Color.DarkGray
        Me.InfoMovieQuality.Location = New System.Drawing.Point(92, 248)
        Me.InfoMovieQuality.Name = "InfoMovieQuality"
        Me.InfoMovieQuality.Size = New System.Drawing.Size(61, 18)
        Me.InfoMovieQuality.TabIndex = 56
        Me.InfoMovieQuality.Text = "Quality"
        Me.InfoMovieQuality.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.InfoMovieQuality.Visible = False
        '
        'InfoPoster
        '
        Me.InfoPoster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoPoster.BackColor = System.Drawing.Color.Transparent
        Me.InfoPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InfoPoster.BorderColor = System.Drawing.Color.White
        Me.InfoPoster.BorderShow = False
        Me.InfoPoster.ColorFillSolid = System.Drawing.Color.Transparent
        Me.InfoPoster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InfoPoster.DesignerSelected = False
        Me.InfoPoster.DimFactorClick = 0
        Me.InfoPoster.DimFactorHover = 0
        Me.InfoPoster.FillType = CButtonLib.CButton.eFillType.Solid
        Me.InfoPoster.ForeColor = System.Drawing.Color.DarkGray
        Me.InfoPoster.ImageIndex = 0
        Me.InfoPoster.Location = New System.Drawing.Point(7, 8)
        Me.InfoPoster.Name = "InfoPoster"
        Me.InfoPoster.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.InfoPoster.Size = New System.Drawing.Size(146, 211)
        Me.InfoPoster.TabIndex = 38
        Me.InfoPoster.TabStop = False
        Me.InfoPoster.Text = ""
        '
        'InfoPoster2
        '
        Me.InfoPoster2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoPoster2.BackColor = System.Drawing.Color.Transparent
        Me.InfoPoster2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InfoPoster2.BorderColor = System.Drawing.Color.White
        Me.InfoPoster2.BorderShow = False
        Me.InfoPoster2.ColorFillSolid = System.Drawing.Color.Transparent
        Me.InfoPoster2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InfoPoster2.DesignerSelected = False
        Me.InfoPoster2.DimFactorClick = 0
        Me.InfoPoster2.DimFactorHover = 0
        Me.InfoPoster2.FillType = CButtonLib.CButton.eFillType.Solid
        Me.InfoPoster2.ForeColor = System.Drawing.Color.DarkGray
        Me.InfoPoster2.ImageIndex = 0
        Me.InfoPoster2.Location = New System.Drawing.Point(8, 8)
        Me.InfoPoster2.Name = "InfoPoster2"
        Me.InfoPoster2.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.InfoPoster2.Size = New System.Drawing.Size(144, 209)
        Me.InfoPoster2.TabIndex = 44
        Me.InfoPoster2.TabStop = False
        Me.InfoPoster2.Text = ""
        '
        'InfoImdbRatingPoster
        '
        Me.InfoImdbRatingPoster.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.InfoImdbRatingPoster.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.InfoImdbRatingPoster.Corners.All = 12
        Me.InfoImdbRatingPoster.Corners.LowerLeft = 12
        Me.InfoImdbRatingPoster.Corners.LowerRight = 12
        Me.InfoImdbRatingPoster.Corners.UpperLeft = 12
        Me.InfoImdbRatingPoster.Corners.UpperRight = 12
        Me.InfoImdbRatingPoster.DesignerSelected = True
        Me.InfoImdbRatingPoster.FillType = CButtonLib.CButton.eFillType.Solid
        Me.InfoImdbRatingPoster.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoImdbRatingPoster.ForeColor = System.Drawing.Color.Black
        Me.InfoImdbRatingPoster.ImageIndex = 0
        Me.InfoImdbRatingPoster.Location = New System.Drawing.Point(74, 13)
        Me.InfoImdbRatingPoster.Name = "InfoImdbRatingPoster"
        Me.InfoImdbRatingPoster.Size = New System.Drawing.Size(74, 26)
        Me.InfoImdbRatingPoster.TabIndex = 58
        Me.InfoImdbRatingPoster.Text = "IMDB 0.0"
        Me.InfoImdbRatingPoster.TextMargin = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.InfoImdbRatingPoster.TextShadow = System.Drawing.Color.Gray
        Me.InfoImdbRatingPoster.TextShadowShow = False
        Me.InfoImdbRatingPoster.Visible = False
        '
        'imageBackgroundEffect
        '
        Me.imageBackgroundEffect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imageBackgroundEffect.Image = Global.Movieo.My.Resources.Resources.PosterGlow
        Me.imageBackgroundEffect.Location = New System.Drawing.Point(-2, -3)
        Me.imageBackgroundEffect.Name = "imageBackgroundEffect"
        Me.imageBackgroundEffect.Size = New System.Drawing.Size(165, 230)
        Me.imageBackgroundEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBackgroundEffect.TabIndex = 45
        Me.imageBackgroundEffect.TabStop = False
        '
        'infoRatingNetflix
        '
        Me.infoRatingNetflix.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoRatingNetflix.AutoSize = True
        Me.infoRatingNetflix.Location = New System.Drawing.Point(68, 131)
        Me.infoRatingNetflix.Name = "infoRatingNetflix"
        Me.infoRatingNetflix.Size = New System.Drawing.Size(24, 13)
        Me.infoRatingNetflix.TabIndex = 59
        Me.infoRatingNetflix.Text = "n/a"
        Me.infoRatingNetflix.Visible = False
        '
        'InfoTitleAndYear
        '
        Me.InfoTitleAndYear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTitleAndYear.AutoSize = True
        Me.InfoTitleAndYear.Location = New System.Drawing.Point(76, 139)
        Me.InfoTitleAndYear.Name = "InfoTitleAndYear"
        Me.InfoTitleAndYear.Size = New System.Drawing.Size(0, 13)
        Me.InfoTitleAndYear.TabIndex = 60
        Me.InfoTitleAndYear.Visible = False
        '
        'ctrlPosterTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(161, 275)
        Me.ControlBox = False
        Me.Controls.Add(Me.InfoImdbRatingPoster)
        Me.Controls.Add(Me.InfoMovieQuality)
        Me.Controls.Add(Me.InfoPoster)
        Me.Controls.Add(Me.InfoReleaseDate)
        Me.Controls.Add(Me.InfoDirector)
        Me.Controls.Add(Me.InfoStars)
        Me.Controls.Add(Me.InfoSearches)
        Me.Controls.Add(Me.InfoPosterLink)
        Me.Controls.Add(Me.InfoDesc)
        Me.Controls.Add(Me.InfoDuration)
        Me.Controls.Add(Me.infoRatingIMDb)
        Me.Controls.Add(Me.InfoGenre)
        Me.Controls.Add(Me.InfoYear)
        Me.Controls.Add(Me.InfoTitle)
        Me.Controls.Add(Me.InfoPoster2)
        Me.Controls.Add(Me.imageBackgroundEffect)
        Me.Controls.Add(Me.InfoMovieLink)
        Me.Controls.Add(Me.InfoBoxOffice)
        Me.Controls.Add(Me.InfoAwards)
        Me.Controls.Add(Me.InfoCountry)
        Me.Controls.Add(Me.InfoImdbId)
        Me.Controls.Add(Me.InfoProduction)
        Me.Controls.Add(Me.InfoLanguage)
        Me.Controls.Add(Me.InfoRating)
        Me.Controls.Add(Me.infoRatingMetaScore)
        Me.Controls.Add(Me.infoRatingNetflix)
        Me.Controls.Add(Me.InfoTitleAndYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ctrlPosterTitle"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PosterTitle"
        CType(Me.imageBackgroundEffect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InfoMovieLink As Label
    Friend WithEvents InfoPosterLink As Label
    Friend WithEvents InfoDesc As Label
    Friend WithEvents InfoDuration As Label
    Friend WithEvents infoRatingIMDb As Label
    Friend WithEvents InfoYear As Label
    Friend WithEvents InfoGenre As Label
    Friend WithEvents InfoSearches As RichTextBox
    Friend WithEvents InfoStars As Label
    Friend WithEvents InfoDirector As Label
    Friend WithEvents InfoReleaseDate As Label
    Public WithEvents InfoPoster As CButtonLib.CButton
    Friend WithEvents InfoTitle As Label
    Public WithEvents InfoPoster2 As CButtonLib.CButton
    Friend WithEvents imageBackgroundEffect As PictureBox
    Friend WithEvents infoRatingMetaScore As Label
    Friend WithEvents InfoRating As Label
    Friend WithEvents InfoCountry As Label
    Friend WithEvents InfoLanguage As Label
    Friend WithEvents InfoAwards As Label
    Friend WithEvents InfoProduction As Label
    Friend WithEvents InfoBoxOffice As Label
    Friend WithEvents InfoImdbId As Label
    Friend WithEvents InfoMovieQuality As Label
    Friend WithEvents InfoImdbRatingPoster As CButtonLib.CButton
    Friend WithEvents infoRatingNetflix As Label
    Friend WithEvents InfoTitleAndYear As Label
End Class
