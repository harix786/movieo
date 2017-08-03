<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSource
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
        Me.itemsBackground = New CButtonLib.CButton()
        Me.itemsMovieSources = New System.Windows.Forms.ListBox()
        Me.titleForm = New CButtonLib.CButton()
        Me.meClose = New System.Windows.Forms.PictureBox()
        Me.itemsMovieSourcesTitle = New System.Windows.Forms.ListBox()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itemsBackground
        '
        Me.itemsBackground.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemsBackground.BackColor = System.Drawing.Color.Transparent
        Me.itemsBackground.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.itemsBackground.BorderShow = False
        Me.itemsBackground.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.itemsBackground.Corners.All = 2
        Me.itemsBackground.Corners.LowerLeft = 2
        Me.itemsBackground.Corners.LowerRight = 2
        Me.itemsBackground.Corners.UpperLeft = 2
        Me.itemsBackground.Corners.UpperRight = 2
        Me.itemsBackground.Cursor = System.Windows.Forms.Cursors.Hand
        Me.itemsBackground.DesignerSelected = False
        Me.itemsBackground.DimFactorClick = 0
        Me.itemsBackground.DimFactorHover = 0
        Me.itemsBackground.FillType = CButtonLib.CButton.eFillType.Solid
        Me.itemsBackground.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.itemsBackground.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.itemsBackground.ImageIndex = 0
        Me.itemsBackground.Location = New System.Drawing.Point(221, 218)
        Me.itemsBackground.Margin = New System.Windows.Forms.Padding(0)
        Me.itemsBackground.Name = "itemsBackground"
        Me.itemsBackground.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.itemsBackground.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.itemsBackground.SideImageSize = New System.Drawing.Size(14, 15)
        Me.itemsBackground.Size = New System.Drawing.Size(544, 181)
        Me.itemsBackground.TabIndex = 100006
        Me.itemsBackground.TabStop = False
        Me.itemsBackground.Text = ""
        Me.itemsBackground.TextShadow = System.Drawing.Color.White
        Me.itemsBackground.TextShadowShow = False
        '
        'itemsMovieSources
        '
        Me.itemsMovieSources.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemsMovieSources.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.itemsMovieSources.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.itemsMovieSources.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!)
        Me.itemsMovieSources.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.itemsMovieSources.FormattingEnabled = True
        Me.itemsMovieSources.HorizontalScrollbar = True
        Me.itemsMovieSources.ItemHeight = 19
        Me.itemsMovieSources.Location = New System.Drawing.Point(224, 223)
        Me.itemsMovieSources.Name = "itemsMovieSources"
        Me.itemsMovieSources.Size = New System.Drawing.Size(538, 171)
        Me.itemsMovieSources.TabIndex = 0
        Me.itemsMovieSources.UseTabStops = False
        '
        'titleForm
        '
        Me.titleForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.titleForm.BackColor = System.Drawing.Color.Transparent
        Me.titleForm.BorderColor = System.Drawing.Color.Transparent
        Me.titleForm.BorderShow = False
        Me.titleForm.ColorFillSolid = System.Drawing.Color.Transparent
        Me.titleForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.titleForm.DesignerSelected = False
        Me.titleForm.DimFactorClick = 0
        Me.titleForm.DimFactorHover = 0
        Me.titleForm.FillType = CButtonLib.CButton.eFillType.Solid
        Me.titleForm.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.titleForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.titleForm.ImageIndex = 0
        Me.titleForm.Location = New System.Drawing.Point(275, 161)
        Me.titleForm.Name = "titleForm"
        Me.titleForm.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.titleForm.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.titleForm.SideImageSize = New System.Drawing.Size(14, 15)
        Me.titleForm.Size = New System.Drawing.Size(436, 42)
        Me.titleForm.TabIndex = 0
        Me.titleForm.TabStop = False
        Me.titleForm.Text = "Choose Movie Source:"
        Me.titleForm.TextShadow = System.Drawing.Color.White
        Me.titleForm.TextShadowShow = False
        '
        'meClose
        '
        Me.meClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.meClose.BackColor = System.Drawing.Color.Transparent
        Me.meClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.meClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.meClose.Location = New System.Drawing.Point(946, 12)
        Me.meClose.Name = "meClose"
        Me.meClose.Size = New System.Drawing.Size(28, 28)
        Me.meClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.meClose.TabIndex = 100000056
        Me.meClose.TabStop = False
        '
        'itemsMovieSourcesTitle
        '
        Me.itemsMovieSourcesTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemsMovieSourcesTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.itemsMovieSourcesTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.itemsMovieSourcesTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!)
        Me.itemsMovieSourcesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.itemsMovieSourcesTitle.FormattingEnabled = True
        Me.itemsMovieSourcesTitle.HorizontalScrollbar = True
        Me.itemsMovieSourcesTitle.ItemHeight = 19
        Me.itemsMovieSourcesTitle.Location = New System.Drawing.Point(224, 223)
        Me.itemsMovieSourcesTitle.Name = "itemsMovieSourcesTitle"
        Me.itemsMovieSourcesTitle.Size = New System.Drawing.Size(538, 171)
        Me.itemsMovieSourcesTitle.TabIndex = 100000057
        Me.itemsMovieSourcesTitle.UseTabStops = False
        '
        'frmSelectSource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 561)
        Me.Controls.Add(Me.itemsMovieSourcesTitle)
        Me.Controls.Add(Me.meClose)
        Me.Controls.Add(Me.titleForm)
        Me.Controls.Add(Me.itemsBackground)
        Me.Controls.Add(Me.itemsMovieSources)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectSource"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Movie Source:"
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents itemsBackground As CButtonLib.CButton
    Friend WithEvents itemsMovieSources As ListBox
    Friend WithEvents titleForm As CButtonLib.CButton
    Friend WithEvents meClose As PictureBox
    Friend WithEvents itemsMovieSourcesTitle As ListBox
End Class
