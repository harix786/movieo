<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovieInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovieInfo))
        Me.MovieTitleText = New System.Windows.Forms.Label()
        Me.MovieDescriptionText = New System.Windows.Forms.Label()
        Me.MovieYearText = New System.Windows.Forms.Label()
        Me.MovieGenreText = New System.Windows.Forms.Label()
        Me.MovieRatingText = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MovieDurationText = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MovieImageLinkText = New System.Windows.Forms.Label()
        Me.JustTitle = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnFavourite = New System.Windows.Forms.PictureBox()
        Me.TextFavourites = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnWatchList = New System.Windows.Forms.PictureBox()
        Me.TextWatchList = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnWatched = New System.Windows.Forms.PictureBox()
        Me.TextWatched = New System.Windows.Forms.Label()
        Me.MovieStarsText = New System.Windows.Forms.Label()
        Me.MovieDirectorText = New System.Windows.Forms.Label()
        Me.getStarsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MovieLinkText = New System.Windows.Forms.Label()
        Me.LblStars = New System.Windows.Forms.Label()
        Me.LblDirectors = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.BtnDownloadMovie = New CButtonLib.CButton()
        Me.btnWatchMovie = New CButtonLib.CButton()
        Me.appClose = New System.Windows.Forms.PictureBox()
        Me.MovImage = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.BtnFavourite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnWatchList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnWatched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MovieTitleText
        '
        Me.MovieTitleText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovieTitleText.AutoEllipsis = True
        Me.MovieTitleText.Cursor = System.Windows.Forms.Cursors.Default
        Me.MovieTitleText.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieTitleText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MovieTitleText.Location = New System.Drawing.Point(438, 95)
        Me.MovieTitleText.Name = "MovieTitleText"
        Me.MovieTitleText.Size = New System.Drawing.Size(637, 50)
        Me.MovieTitleText.TabIndex = 46
        Me.MovieTitleText.Text = "Movie Title"
        '
        'MovieDescriptionText
        '
        Me.MovieDescriptionText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovieDescriptionText.AutoEllipsis = True
        Me.MovieDescriptionText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieDescriptionText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieDescriptionText.Location = New System.Drawing.Point(444, 297)
        Me.MovieDescriptionText.Name = "MovieDescriptionText"
        Me.MovieDescriptionText.Size = New System.Drawing.Size(635, 294)
        Me.MovieDescriptionText.TabIndex = 10
        Me.MovieDescriptionText.Text = "Description"
        '
        'MovieYearText
        '
        Me.MovieYearText.AutoSize = True
        Me.MovieYearText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieYearText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieYearText.Location = New System.Drawing.Point(3, 0)
        Me.MovieYearText.Name = "MovieYearText"
        Me.MovieYearText.Size = New System.Drawing.Size(40, 21)
        Me.MovieYearText.TabIndex = 3
        Me.MovieYearText.Text = "Year"
        '
        'MovieGenreText
        '
        Me.MovieGenreText.AutoSize = True
        Me.MovieGenreText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieGenreText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieGenreText.Location = New System.Drawing.Point(172, 0)
        Me.MovieGenreText.Name = "MovieGenreText"
        Me.MovieGenreText.Size = New System.Drawing.Size(69, 21)
        Me.MovieGenreText.TabIndex = 4
        Me.MovieGenreText.Text = "Genre(s)"
        '
        'MovieRatingText
        '
        Me.MovieRatingText.AutoSize = True
        Me.MovieRatingText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieRatingText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieRatingText.Location = New System.Drawing.Point(270, 0)
        Me.MovieRatingText.Name = "MovieRatingText"
        Me.MovieRatingText.Size = New System.Drawing.Size(43, 21)
        Me.MovieRatingText.TabIndex = 1035
        Me.MovieRatingText.Text = "0/10"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.MovieYearText)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.MovieDurationText)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.Controls.Add(Me.MovieGenreText)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Controls.Add(Me.MovieRatingText)
        Me.FlowLayoutPanel2.Controls.Add(Me.MovieImageLinkText)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(440, 148)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(635, 27)
        Me.FlowLayoutPanel2.TabIndex = 1036
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "•"
        '
        'MovieDurationText
        '
        Me.MovieDurationText.AutoSize = True
        Me.MovieDurationText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieDurationText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieDurationText.Location = New System.Drawing.Point(72, 0)
        Me.MovieDurationText.Name = "MovieDurationText"
        Me.MovieDurationText.Size = New System.Drawing.Size(71, 21)
        Me.MovieDurationText.TabIndex = 1036
        Me.MovieDurationText.Text = "Duration"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(149, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 21)
        Me.Label8.TabIndex = 1037
        Me.Label8.Text = "•"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(247, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "•"
        '
        'MovieImageLinkText
        '
        Me.MovieImageLinkText.AutoSize = True
        Me.MovieImageLinkText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieImageLinkText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieImageLinkText.Location = New System.Drawing.Point(319, 0)
        Me.MovieImageLinkText.Name = "MovieImageLinkText"
        Me.MovieImageLinkText.Size = New System.Drawing.Size(150, 21)
        Me.MovieImageLinkText.TabIndex = 1047
        Me.MovieImageLinkText.Text = "Image Link (Hidden)"
        Me.MovieImageLinkText.Visible = False
        '
        'JustTitle
        '
        Me.JustTitle.AutoSize = True
        Me.JustTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.JustTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JustTitle.ForeColor = System.Drawing.Color.White
        Me.JustTitle.Location = New System.Drawing.Point(206, 121)
        Me.JustTitle.Name = "JustTitle"
        Me.JustTitle.Size = New System.Drawing.Size(0, 37)
        Me.JustTitle.TabIndex = 48
        Me.JustTitle.Visible = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel3.Controls.Add(Me.BtnFavourite)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextFavourites)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel3.Controls.Add(Me.BtnWatchList)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextWatchList)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Controls.Add(Me.BtnWatched)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextWatched)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(445, 609)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(607, 25)
        Me.FlowLayoutPanel3.TabIndex = 1040
        '
        'BtnFavourite
        '
        Me.BtnFavourite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFavourite.Image = Global.Odeum.My.Resources.Resources.FavouriteL
        Me.BtnFavourite.Location = New System.Drawing.Point(3, 2)
        Me.BtnFavourite.Margin = New System.Windows.Forms.Padding(3, 2, 0, 3)
        Me.BtnFavourite.Name = "BtnFavourite"
        Me.BtnFavourite.Size = New System.Drawing.Size(20, 20)
        Me.BtnFavourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFavourite.TabIndex = 47
        Me.BtnFavourite.TabStop = False
        '
        'TextFavourites
        '
        Me.TextFavourites.AutoSize = True
        Me.TextFavourites.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextFavourites.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextFavourites.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.TextFavourites.Location = New System.Drawing.Point(23, 1)
        Me.TextFavourites.Margin = New System.Windows.Forms.Padding(0, 1, 3, 0)
        Me.TextFavourites.Name = "TextFavourites"
        Me.TextFavourites.Size = New System.Drawing.Size(129, 21)
        Me.TextFavourites.TabIndex = 1036
        Me.TextFavourites.Text = "Add to favourites"
        Me.TextFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(158, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 21)
        Me.Label5.TabIndex = 1037
        Me.Label5.Text = "•"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnWatchList
        '
        Me.BtnWatchList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWatchList.Image = Global.Odeum.My.Resources.Resources.WatchListL
        Me.BtnWatchList.Location = New System.Drawing.Point(186, 2)
        Me.BtnWatchList.Margin = New System.Windows.Forms.Padding(3, 2, 1, 3)
        Me.BtnWatchList.Name = "BtnWatchList"
        Me.BtnWatchList.Size = New System.Drawing.Size(20, 20)
        Me.BtnWatchList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnWatchList.TabIndex = 1038
        Me.BtnWatchList.TabStop = False
        '
        'TextWatchList
        '
        Me.TextWatchList.AutoSize = True
        Me.TextWatchList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextWatchList.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextWatchList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.TextWatchList.Location = New System.Drawing.Point(207, 1)
        Me.TextWatchList.Margin = New System.Windows.Forms.Padding(0, 1, 3, 0)
        Me.TextWatchList.Name = "TextWatchList"
        Me.TextWatchList.Size = New System.Drawing.Size(125, 21)
        Me.TextWatchList.TabIndex = 1039
        Me.TextWatchList.Text = "Add to watch list"
        Me.TextWatchList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(338, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 21)
        Me.Label2.TabIndex = 1040
        Me.Label2.Text = "•"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnWatched
        '
        Me.BtnWatched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWatched.Image = Global.Odeum.My.Resources.Resources.WatchedL
        Me.BtnWatched.Location = New System.Drawing.Point(366, 3)
        Me.BtnWatched.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.BtnWatched.Name = "BtnWatched"
        Me.BtnWatched.Size = New System.Drawing.Size(25, 19)
        Me.BtnWatched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnWatched.TabIndex = 1041
        Me.BtnWatched.TabStop = False
        '
        'TextWatched
        '
        Me.TextWatched.AutoSize = True
        Me.TextWatched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextWatched.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextWatched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.TextWatched.Location = New System.Drawing.Point(391, 1)
        Me.TextWatched.Margin = New System.Windows.Forms.Padding(0, 1, 3, 0)
        Me.TextWatched.Name = "TextWatched"
        Me.TextWatched.Size = New System.Drawing.Size(98, 21)
        Me.TextWatched.TabIndex = 1042
        Me.TextWatched.Text = "Not watched"
        Me.TextWatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MovieStarsText
        '
        Me.MovieStarsText.AutoSize = True
        Me.MovieStarsText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieStarsText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieStarsText.Location = New System.Drawing.Point(444, 248)
        Me.MovieStarsText.Name = "MovieStarsText"
        Me.MovieStarsText.Size = New System.Drawing.Size(44, 21)
        Me.MovieStarsText.TabIndex = 1048
        Me.MovieStarsText.Text = "Stars"
        '
        'MovieDirectorText
        '
        Me.MovieDirectorText.AutoSize = True
        Me.MovieDirectorText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieDirectorText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MovieDirectorText.Location = New System.Drawing.Point(444, 200)
        Me.MovieDirectorText.Name = "MovieDirectorText"
        Me.MovieDirectorText.Size = New System.Drawing.Size(73, 21)
        Me.MovieDirectorText.TabIndex = 1049
        Me.MovieDirectorText.Text = "Directors"
        '
        'getStarsTimer
        '
        Me.getStarsTimer.Interval = 10
        '
        'MovieLinkText
        '
        Me.MovieLinkText.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieLinkText.ForeColor = System.Drawing.Color.White
        Me.MovieLinkText.Location = New System.Drawing.Point(176, 685)
        Me.MovieLinkText.Name = "MovieLinkText"
        Me.MovieLinkText.Size = New System.Drawing.Size(178, 20)
        Me.MovieLinkText.TabIndex = 1056
        Me.MovieLinkText.Text = "Link Here"
        Me.MovieLinkText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MovieLinkText.Visible = False
        '
        'LblStars
        '
        Me.LblStars.AutoSize = True
        Me.LblStars.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStars.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LblStars.Location = New System.Drawing.Point(444, 227)
        Me.LblStars.Name = "LblStars"
        Me.LblStars.Size = New System.Drawing.Size(47, 21)
        Me.LblStars.TabIndex = 1058
        Me.LblStars.Text = "Stars"
        '
        'LblDirectors
        '
        Me.LblDirectors.AutoSize = True
        Me.LblDirectors.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDirectors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LblDirectors.Location = New System.Drawing.Point(444, 179)
        Me.LblDirectors.Name = "LblDirectors"
        Me.LblDirectors.Size = New System.Drawing.Size(79, 21)
        Me.LblDirectors.TabIndex = 1059
        Me.LblDirectors.Text = "Directors"
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LblDescription.Location = New System.Drawing.Point(444, 276)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(98, 21)
        Me.LblDescription.TabIndex = 1061
        Me.LblDescription.Text = "Description"
        '
        'BtnDownloadMovie
        '
        Me.BtnDownloadMovie.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnDownloadMovie.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BtnDownloadMovie.Corners.All = 2
        Me.BtnDownloadMovie.Corners.LowerLeft = 2
        Me.BtnDownloadMovie.Corners.LowerRight = 2
        Me.BtnDownloadMovie.Corners.UpperLeft = 2
        Me.BtnDownloadMovie.Corners.UpperRight = 2
        Me.BtnDownloadMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDownloadMovie.DesignerSelected = False
        Me.BtnDownloadMovie.DimFactorClick = 0
        Me.BtnDownloadMovie.DimFactorHover = 0
        Me.BtnDownloadMovie.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnDownloadMovie.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!)
        Me.BtnDownloadMovie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnDownloadMovie.ImageIndex = 0
        Me.BtnDownloadMovie.Location = New System.Drawing.Point(276, 602)
        Me.BtnDownloadMovie.Name = "BtnDownloadMovie"
        Me.BtnDownloadMovie.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnDownloadMovie.Size = New System.Drawing.Size(160, 37)
        Me.BtnDownloadMovie.TabIndex = 1057
        Me.BtnDownloadMovie.Text = "Download"
        Me.BtnDownloadMovie.TextShadowShow = False
        Me.BtnDownloadMovie.Visible = False
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
        Me.btnWatchMovie.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!)
        Me.btnWatchMovie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnWatchMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWatchMovie.ImageIndex = 0
        Me.btnWatchMovie.ImageSize = New System.Drawing.Size(25, 36)
        Me.btnWatchMovie.Location = New System.Drawing.Point(78, 602)
        Me.btnWatchMovie.Name = "btnWatchMovie"
        Me.btnWatchMovie.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnWatchMovie.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWatchMovie.SideImageSize = New System.Drawing.Size(36, 36)
        Me.btnWatchMovie.Size = New System.Drawing.Size(358, 37)
        Me.btnWatchMovie.TabIndex = 1050
        Me.btnWatchMovie.Text = "Watch Movie"
        Me.btnWatchMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnWatchMovie.TextShadowShow = False
        '
        'appClose
        '
        Me.appClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.appClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appClose.Image = Global.Odeum.My.Resources.Resources.PopupCloseL
        Me.appClose.Location = New System.Drawing.Point(1150, 29)
        Me.appClose.Name = "appClose"
        Me.appClose.Size = New System.Drawing.Size(25, 25)
        Me.appClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.appClose.TabIndex = 48
        Me.appClose.TabStop = False
        '
        'MovImage
        '
        Me.MovImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MovImage.Location = New System.Drawing.Point(78, 102)
        Me.MovImage.Name = "MovImage"
        Me.MovImage.Size = New System.Drawing.Size(358, 492)
        Me.MovImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MovImage.TabIndex = 1063
        Me.MovImage.TabStop = False
        '
        'MovieInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1218, 740)
        Me.Controls.Add(Me.BtnDownloadMovie)
        Me.Controls.Add(Me.MovieLinkText)
        Me.Controls.Add(Me.btnWatchMovie)
        Me.Controls.Add(Me.appClose)
        Me.Controls.Add(Me.JustTitle)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.LblDescription)
        Me.Controls.Add(Me.LblDirectors)
        Me.Controls.Add(Me.LblStars)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.MovieStarsText)
        Me.Controls.Add(Me.MovieDirectorText)
        Me.Controls.Add(Me.MovieDescriptionText)
        Me.Controls.Add(Me.MovieTitleText)
        Me.Controls.Add(Me.MovImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MovieInfo"
        Me.Opacity = 0.97R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movie Details"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.BtnFavourite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnWatchList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnWatched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MovieTitleText As Label
    Friend WithEvents MovieDescriptionText As Label
    Friend WithEvents MovieYearText As Label
    Friend WithEvents MovieGenreText As Label
    Friend WithEvents BtnFavourite As PictureBox
    Friend WithEvents MovieRatingText As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents JustTitle As Label
    Friend WithEvents appClose As PictureBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents TextFavourites As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnWatchList As PictureBox
    Friend WithEvents TextWatchList As Label
    Friend WithEvents MovieDurationText As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MovieImageLinkText As Label
    Friend WithEvents MovieStarsText As Label
    Friend WithEvents MovieDirectorText As Label
    Public WithEvents btnWatchMovie As CButtonLib.CButton
    Friend WithEvents getStarsTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnWatched As PictureBox
    Friend WithEvents TextWatched As Label
    Friend WithEvents MovieLinkText As Label
    Public WithEvents BtnDownloadMovie As CButtonLib.CButton
    Friend WithEvents LblStars As Label
    Friend WithEvents LblDirectors As Label
    Friend WithEvents LblDescription As Label
    Friend WithEvents MovImage As PictureBox
End Class
