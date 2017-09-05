<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlCollectionsThumbnail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblCollectionsTitle = New System.Windows.Forms.Label()
        Me.itemsCollectionsMovies = New System.Windows.Forms.ListBox()
        Me.lblCollectionsComment = New System.Windows.Forms.Label()
        Me.imgCollectionsThumbnail = New CButtonLib.CButton()
        Me.imageBackgroundEffect = New System.Windows.Forms.PictureBox()
        Me.imgCollectionsThumbnailDefault = New System.Windows.Forms.PictureBox()
        CType(Me.imageBackgroundEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCollectionsThumbnailDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCollectionsTitle
        '
        Me.lblCollectionsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCollectionsTitle.AutoEllipsis = True
        Me.lblCollectionsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCollectionsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblCollectionsTitle.ForeColor = System.Drawing.Color.White
        Me.lblCollectionsTitle.Location = New System.Drawing.Point(8, 183)
        Me.lblCollectionsTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCollectionsTitle.Name = "lblCollectionsTitle"
        Me.lblCollectionsTitle.Size = New System.Drawing.Size(309, 25)
        Me.lblCollectionsTitle.TabIndex = 44
        Me.lblCollectionsTitle.Text = "Collections Title"
        Me.lblCollectionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemsCollectionsMovies
        '
        Me.itemsCollectionsMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.itemsCollectionsMovies.FormattingEnabled = True
        Me.itemsCollectionsMovies.Location = New System.Drawing.Point(192, 12)
        Me.itemsCollectionsMovies.Name = "itemsCollectionsMovies"
        Me.itemsCollectionsMovies.Size = New System.Drawing.Size(120, 95)
        Me.itemsCollectionsMovies.TabIndex = 45
        Me.itemsCollectionsMovies.Visible = False
        '
        'lblCollectionsComment
        '
        Me.lblCollectionsComment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCollectionsComment.AutoEllipsis = True
        Me.lblCollectionsComment.BackColor = System.Drawing.Color.Transparent
        Me.lblCollectionsComment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollectionsComment.ForeColor = System.Drawing.Color.White
        Me.lblCollectionsComment.Location = New System.Drawing.Point(27, 115)
        Me.lblCollectionsComment.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCollectionsComment.Name = "lblCollectionsComment"
        Me.lblCollectionsComment.Size = New System.Drawing.Size(271, 25)
        Me.lblCollectionsComment.TabIndex = 46
        Me.lblCollectionsComment.Text = "Collections Comment"
        Me.lblCollectionsComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCollectionsComment.Visible = False
        '
        'imgCollectionsThumbnail
        '
        Me.imgCollectionsThumbnail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgCollectionsThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCollectionsThumbnail.BorderColor = System.Drawing.Color.White
        Me.imgCollectionsThumbnail.BorderShow = False
        Me.imgCollectionsThumbnail.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.imgCollectionsThumbnail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCollectionsThumbnail.DesignerSelected = False
        Me.imgCollectionsThumbnail.DimFactorClick = 0
        Me.imgCollectionsThumbnail.DimFactorHover = 0
        Me.imgCollectionsThumbnail.FillType = CButtonLib.CButton.eFillType.Solid
        Me.imgCollectionsThumbnail.ImageIndex = 0
        Me.imgCollectionsThumbnail.Location = New System.Drawing.Point(5, 8)
        Me.imgCollectionsThumbnail.Name = "imgCollectionsThumbnail"
        Me.imgCollectionsThumbnail.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.imgCollectionsThumbnail.Size = New System.Drawing.Size(312, 169)
        Me.imgCollectionsThumbnail.TabIndex = 47
        Me.imgCollectionsThumbnail.Text = ""
        '
        'imageBackgroundEffect
        '
        Me.imageBackgroundEffect.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imageBackgroundEffect.Image = Global.Movieo.My.Resources.Resources.PosterGlow
        Me.imageBackgroundEffect.Location = New System.Drawing.Point(-7, 0)
        Me.imageBackgroundEffect.Name = "imageBackgroundEffect"
        Me.imageBackgroundEffect.Size = New System.Drawing.Size(338, 183)
        Me.imageBackgroundEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBackgroundEffect.TabIndex = 48
        Me.imageBackgroundEffect.TabStop = False
        '
        'imgCollectionsThumbnailDefault
        '
        Me.imgCollectionsThumbnailDefault.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgCollectionsThumbnailDefault.Location = New System.Drawing.Point(12, 12)
        Me.imgCollectionsThumbnailDefault.Name = "imgCollectionsThumbnailDefault"
        Me.imgCollectionsThumbnailDefault.Size = New System.Drawing.Size(100, 50)
        Me.imgCollectionsThumbnailDefault.TabIndex = 49
        Me.imgCollectionsThumbnailDefault.TabStop = False
        '
        'ctrlCollectionsThumbnail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(324, 211)
        Me.Controls.Add(Me.lblCollectionsTitle)
        Me.Controls.Add(Me.imgCollectionsThumbnail)
        Me.Controls.Add(Me.lblCollectionsComment)
        Me.Controls.Add(Me.itemsCollectionsMovies)
        Me.Controls.Add(Me.imageBackgroundEffect)
        Me.Controls.Add(Me.imgCollectionsThumbnailDefault)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ctrlCollectionsThumbnail"
        Me.Text = "ctrlCollectionsThumbnail"
        CType(Me.imageBackgroundEffect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCollectionsThumbnailDefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCollectionsTitle As Label
    Friend WithEvents itemsCollectionsMovies As ListBox
    Friend WithEvents lblCollectionsComment As Label
    Friend WithEvents imgCollectionsThumbnail As CButtonLib.CButton
    Friend WithEvents imageBackgroundEffect As PictureBox
    Friend WithEvents imgCollectionsThumbnailDefault As PictureBox
End Class
