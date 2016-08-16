<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PosterTitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PosterTitle))
        Me.InfoMovieLink = New System.Windows.Forms.Label()
        Me.InfoPosterLink = New System.Windows.Forms.Label()
        Me.InfoDesc = New System.Windows.Forms.Label()
        Me.InfoDuration = New System.Windows.Forms.Label()
        Me.InfoRating = New System.Windows.Forms.Label()
        Me.InfoYear = New System.Windows.Forms.Label()
        Me.InfoGenre = New System.Windows.Forms.Label()
        Me.InfoSearches = New System.Windows.Forms.RichTextBox()
        Me.InfoStars = New System.Windows.Forms.Label()
        Me.InfoDirector = New System.Windows.Forms.Label()
        Me.InfoReleaseDate = New System.Windows.Forms.Label()
        Me.InfoBasic = New System.Windows.Forms.Label()
        Me.InfoTitle = New System.Windows.Forms.Label()
        Me.InfoPoster = New CButtonLib.CButton()
        Me.InfoPoster2 = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'InfoMovieLink
        '
        Me.InfoMovieLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoMovieLink.AutoSize = True
        Me.InfoMovieLink.Location = New System.Drawing.Point(70, 174)
        Me.InfoMovieLink.Name = "InfoMovieLink"
        Me.InfoMovieLink.Size = New System.Drawing.Size(39, 13)
        Me.InfoMovieLink.TabIndex = 29
        Me.InfoMovieLink.Text = "Label2"
        Me.InfoMovieLink.Visible = False
        '
        'InfoPosterLink
        '
        Me.InfoPosterLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoPosterLink.AutoSize = True
        Me.InfoPosterLink.Location = New System.Drawing.Point(70, 161)
        Me.InfoPosterLink.Name = "InfoPosterLink"
        Me.InfoPosterLink.Size = New System.Drawing.Size(39, 13)
        Me.InfoPosterLink.TabIndex = 28
        Me.InfoPosterLink.Text = "Label2"
        Me.InfoPosterLink.Visible = False
        '
        'InfoDesc
        '
        Me.InfoDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoDesc.AutoSize = True
        Me.InfoDesc.Location = New System.Drawing.Point(70, 148)
        Me.InfoDesc.Name = "InfoDesc"
        Me.InfoDesc.Size = New System.Drawing.Size(39, 13)
        Me.InfoDesc.TabIndex = 27
        Me.InfoDesc.Text = "Label2"
        Me.InfoDesc.Visible = False
        '
        'InfoDuration
        '
        Me.InfoDuration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoDuration.AutoSize = True
        Me.InfoDuration.Location = New System.Drawing.Point(70, 135)
        Me.InfoDuration.Name = "InfoDuration"
        Me.InfoDuration.Size = New System.Drawing.Size(39, 13)
        Me.InfoDuration.TabIndex = 26
        Me.InfoDuration.Text = "Label2"
        Me.InfoDuration.Visible = False
        '
        'InfoRating
        '
        Me.InfoRating.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoRating.AutoSize = True
        Me.InfoRating.Location = New System.Drawing.Point(70, 122)
        Me.InfoRating.Name = "InfoRating"
        Me.InfoRating.Size = New System.Drawing.Size(39, 13)
        Me.InfoRating.TabIndex = 25
        Me.InfoRating.Text = "Label2"
        Me.InfoRating.Visible = False
        '
        'InfoYear
        '
        Me.InfoYear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoYear.AutoSize = True
        Me.InfoYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.InfoYear.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.InfoYear.ForeColor = System.Drawing.Color.Gainsboro
        Me.InfoYear.Location = New System.Drawing.Point(74, 145)
        Me.InfoYear.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.InfoYear.Name = "InfoYear"
        Me.InfoYear.Size = New System.Drawing.Size(35, 19)
        Me.InfoYear.TabIndex = 23
        Me.InfoYear.Text = "Year"
        Me.InfoYear.Visible = False
        '
        'InfoGenre
        '
        Me.InfoGenre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoGenre.AutoSize = True
        Me.InfoGenre.Location = New System.Drawing.Point(70, 109)
        Me.InfoGenre.Name = "InfoGenre"
        Me.InfoGenre.Size = New System.Drawing.Size(39, 13)
        Me.InfoGenre.TabIndex = 22
        Me.InfoGenre.Text = "Label2"
        Me.InfoGenre.Visible = False
        '
        'InfoSearches
        '
        Me.InfoSearches.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoSearches.Location = New System.Drawing.Point(26, 23)
        Me.InfoSearches.Name = "InfoSearches"
        Me.InfoSearches.Size = New System.Drawing.Size(10, 9)
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
        Me.InfoStars.Location = New System.Drawing.Point(64, 129)
        Me.InfoStars.Name = "InfoStars"
        Me.InfoStars.Size = New System.Drawing.Size(39, 13)
        Me.InfoStars.TabIndex = 35
        Me.InfoStars.Text = "Label2"
        Me.InfoStars.Visible = False
        '
        'InfoDirector
        '
        Me.InfoDirector.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoDirector.AutoSize = True
        Me.InfoDirector.Location = New System.Drawing.Point(72, 137)
        Me.InfoDirector.Name = "InfoDirector"
        Me.InfoDirector.Size = New System.Drawing.Size(39, 13)
        Me.InfoDirector.TabIndex = 36
        Me.InfoDirector.Text = "Label2"
        Me.InfoDirector.Visible = False
        '
        'InfoReleaseDate
        '
        Me.InfoReleaseDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoReleaseDate.AutoSize = True
        Me.InfoReleaseDate.Location = New System.Drawing.Point(80, 145)
        Me.InfoReleaseDate.Name = "InfoReleaseDate"
        Me.InfoReleaseDate.Size = New System.Drawing.Size(39, 13)
        Me.InfoReleaseDate.TabIndex = 37
        Me.InfoReleaseDate.Text = "Label2"
        Me.InfoReleaseDate.Visible = False
        '
        'InfoBasic
        '
        Me.InfoBasic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoBasic.AutoEllipsis = True
        Me.InfoBasic.BackColor = System.Drawing.Color.Transparent
        Me.InfoBasic.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.InfoBasic.ForeColor = System.Drawing.Color.White
        Me.InfoBasic.Location = New System.Drawing.Point(8, 247)
        Me.InfoBasic.Margin = New System.Windows.Forms.Padding(3)
        Me.InfoBasic.Name = "InfoBasic"
        Me.InfoBasic.Size = New System.Drawing.Size(148, 18)
        Me.InfoBasic.TabIndex = 26
        Me.InfoBasic.Text = "☆ 0.0 • 0000"
        Me.InfoBasic.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'InfoTitle
        '
        Me.InfoTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTitle.AutoEllipsis = True
        Me.InfoTitle.BackColor = System.Drawing.Color.Transparent
        Me.InfoTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.InfoTitle.ForeColor = System.Drawing.Color.White
        Me.InfoTitle.Location = New System.Drawing.Point(8, 226)
        Me.InfoTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.InfoTitle.Name = "InfoTitle"
        Me.InfoTitle.Size = New System.Drawing.Size(148, 24)
        Me.InfoTitle.TabIndex = 43
        Me.InfoTitle.Text = "Movie Title Text"
        Me.InfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.InfoPoster.Corners.All = 2
        Me.InfoPoster.Corners.LowerLeft = 2
        Me.InfoPoster.Corners.LowerRight = 2
        Me.InfoPoster.Corners.UpperLeft = 2
        Me.InfoPoster.Corners.UpperRight = 2
        Me.InfoPoster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InfoPoster.DesignerSelected = True
        Me.InfoPoster.DimFactorClick = 0
        Me.InfoPoster.DimFactorHover = 0
        Me.InfoPoster.FillType = CButtonLib.CButton.eFillType.Solid
        Me.InfoPoster.ForeColor = System.Drawing.Color.DarkGray
        Me.InfoPoster.ImageIndex = 0
        Me.InfoPoster.Location = New System.Drawing.Point(2, 0)
        Me.InfoPoster.Name = "InfoPoster"
        Me.InfoPoster.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.InfoPoster.Size = New System.Drawing.Size(157, 222)
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
        Me.InfoPoster2.Corners.All = 2
        Me.InfoPoster2.Corners.LowerLeft = 2
        Me.InfoPoster2.Corners.LowerRight = 2
        Me.InfoPoster2.Corners.UpperLeft = 2
        Me.InfoPoster2.Corners.UpperRight = 2
        Me.InfoPoster2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InfoPoster2.DesignerSelected = False
        Me.InfoPoster2.DimFactorClick = 0
        Me.InfoPoster2.DimFactorHover = 0
        Me.InfoPoster2.FillType = CButtonLib.CButton.eFillType.Solid
        Me.InfoPoster2.ForeColor = System.Drawing.Color.DarkGray
        Me.InfoPoster2.ImageIndex = 0
        Me.InfoPoster2.Location = New System.Drawing.Point(3, 0)
        Me.InfoPoster2.Name = "InfoPoster2"
        Me.InfoPoster2.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.InfoPoster2.Size = New System.Drawing.Size(155, 220)
        Me.InfoPoster2.TabIndex = 44
        Me.InfoPoster2.TabStop = False
        Me.InfoPoster2.Text = ""
        '
        'PosterTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(161, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.InfoTitle)
        Me.Controls.Add(Me.InfoPoster)
        Me.Controls.Add(Me.InfoReleaseDate)
        Me.Controls.Add(Me.InfoDirector)
        Me.Controls.Add(Me.InfoStars)
        Me.Controls.Add(Me.InfoSearches)
        Me.Controls.Add(Me.InfoMovieLink)
        Me.Controls.Add(Me.InfoPosterLink)
        Me.Controls.Add(Me.InfoDesc)
        Me.Controls.Add(Me.InfoDuration)
        Me.Controls.Add(Me.InfoRating)
        Me.Controls.Add(Me.InfoGenre)
        Me.Controls.Add(Me.InfoBasic)
        Me.Controls.Add(Me.InfoYear)
        Me.Controls.Add(Me.InfoPoster2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PosterTitle"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PosterTitle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InfoMovieLink As Label
    Friend WithEvents InfoPosterLink As Label
    Friend WithEvents InfoDesc As Label
    Friend WithEvents InfoDuration As Label
    Friend WithEvents InfoRating As Label
    Friend WithEvents InfoYear As Label
    Friend WithEvents InfoGenre As Label
    Friend WithEvents InfoSearches As RichTextBox
    Friend WithEvents InfoStars As Label
    Friend WithEvents InfoDirector As Label
    Friend WithEvents InfoReleaseDate As Label
    Public WithEvents InfoPoster As CButtonLib.CButton
    Friend WithEvents InfoBasic As Label
    Friend WithEvents InfoTitle As Label
    Public WithEvents InfoPoster2 As CButtonLib.CButton
End Class
