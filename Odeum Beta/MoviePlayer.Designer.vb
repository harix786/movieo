<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MoviePlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoviePlayer))
        Me.appClose = New System.Windows.Forms.PictureBox()
        Me.btnReportBroken = New CButtonLib.CButton()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PlayerMovieTitle = New System.Windows.Forms.Label()
        Me.MediaPlayerControl = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        CType(Me.MediaPlayerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'appClose
        '
        Me.appClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.appClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appClose.Image = Global.Odeum.My.Resources.Resources.PopupCloseL
        Me.appClose.Location = New System.Drawing.Point(1197, 11)
        Me.appClose.Name = "appClose"
        Me.appClose.Size = New System.Drawing.Size(25, 25)
        Me.appClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.appClose.TabIndex = 1046
        Me.appClose.TabStop = False
        '
        'btnReportBroken
        '
        Me.btnReportBroken.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnReportBroken.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnReportBroken.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnReportBroken.Corners.All = 2
        Me.btnReportBroken.Corners.LowerLeft = 2
        Me.btnReportBroken.Corners.LowerRight = 2
        Me.btnReportBroken.Corners.UpperLeft = 2
        Me.btnReportBroken.Corners.UpperRight = 2
        Me.btnReportBroken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportBroken.DesignerSelected = True
        Me.btnReportBroken.DimFactorClick = 0
        Me.btnReportBroken.DimFactorHover = 0
        Me.btnReportBroken.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnReportBroken.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnReportBroken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnReportBroken.ImageIndex = 0
        Me.btnReportBroken.Location = New System.Drawing.Point(1066, 8)
        Me.btnReportBroken.Name = "btnReportBroken"
        Me.btnReportBroken.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnReportBroken.Size = New System.Drawing.Size(122, 31)
        Me.btnReportBroken.TabIndex = 1048
        Me.btnReportBroken.Text = "Report Broken"
        Me.btnReportBroken.TextShadowShow = False
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.btnReportBroken)
        Me.PanelTop.Controls.Add(Me.PlayerMovieTitle)
        Me.PanelTop.Controls.Add(Me.appClose)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1233, 48)
        Me.PanelTop.TabIndex = 1058
        '
        'PlayerMovieTitle
        '
        Me.PlayerMovieTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerMovieTitle.AutoEllipsis = True
        Me.PlayerMovieTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerMovieTitle.ForeColor = System.Drawing.Color.White
        Me.PlayerMovieTitle.Location = New System.Drawing.Point(10, 7)
        Me.PlayerMovieTitle.Name = "PlayerMovieTitle"
        Me.PlayerMovieTitle.Size = New System.Drawing.Size(1049, 34)
        Me.PlayerMovieTitle.TabIndex = 1061
        Me.PlayerMovieTitle.Text = "Movie Title"
        Me.PlayerMovieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MediaPlayerControl
        '
        Me.MediaPlayerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaPlayerControl.Enabled = True
        Me.MediaPlayerControl.Location = New System.Drawing.Point(0, 48)
        Me.MediaPlayerControl.Name = "MediaPlayerControl"
        Me.MediaPlayerControl.OcxState = CType(resources.GetObject("MediaPlayerControl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayerControl.Size = New System.Drawing.Size(1233, 732)
        Me.MediaPlayerControl.TabIndex = 1060
        '
        'MoviePlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1233, 780)
        Me.Controls.Add(Me.MediaPlayerControl)
        Me.Controls.Add(Me.PanelTop)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "MoviePlayer"
        Me.ShowInTaskbar = False
        Me.Text = "FastWeb"
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        CType(Me.MediaPlayerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents appClose As PictureBox
    Public WithEvents btnReportBroken As CButtonLib.CButton
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PlayerMovieTitle As Label
    Friend WithEvents MediaPlayerControl As AxWMPLib.AxWindowsMediaPlayer
End Class
