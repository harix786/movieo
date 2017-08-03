<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMediaPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMediaPlayer))
        Me.timerGoToTime = New System.Windows.Forms.Timer(Me.components)
        Me.tab = New System.Windows.Forms.TabControl()
        Me.tabPlayer = New System.Windows.Forms.TabPage()
        Me.MediaPlayerControl = New AxWMPLib.AxWindowsMediaPlayer()
        Me.tabStatus = New System.Windows.Forms.TabPage()
        Me.lblErrorText = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnReportBroken = New CButtonLib.CButton()
        Me.PlayerMovieTitle = New System.Windows.Forms.Label()
        Me.appClose = New System.Windows.Forms.PictureBox()
        Me.timerUntilConnected = New System.Windows.Forms.Timer(Me.components)
        Me.tab.SuspendLayout()
        Me.tabPlayer.SuspendLayout()
        CType(Me.MediaPlayerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabStatus.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerGoToTime
        '
        Me.timerGoToTime.Interval = 500
        '
        'tab
        '
        Me.tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab.Controls.Add(Me.tabPlayer)
        Me.tab.Controls.Add(Me.tabStatus)
        Me.tab.Location = New System.Drawing.Point(-4, 26)
        Me.tab.Name = "tab"
        Me.tab.Padding = New System.Drawing.Point(0, 0)
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(1241, 758)
        Me.tab.TabIndex = 1062
        '
        'tabPlayer
        '
        Me.tabPlayer.BackColor = System.Drawing.Color.Black
        Me.tabPlayer.Controls.Add(Me.MediaPlayerControl)
        Me.tabPlayer.Location = New System.Drawing.Point(4, 22)
        Me.tabPlayer.Name = "tabPlayer"
        Me.tabPlayer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPlayer.Size = New System.Drawing.Size(1233, 732)
        Me.tabPlayer.TabIndex = 0
        Me.tabPlayer.Text = "Media Player"
        '
        'MediaPlayerControl
        '
        Me.MediaPlayerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaPlayerControl.Enabled = True
        Me.MediaPlayerControl.Location = New System.Drawing.Point(3, 3)
        Me.MediaPlayerControl.Name = "MediaPlayerControl"
        Me.MediaPlayerControl.OcxState = CType(resources.GetObject("MediaPlayerControl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayerControl.Size = New System.Drawing.Size(1227, 726)
        Me.MediaPlayerControl.TabIndex = 1061
        '
        'tabStatus
        '
        Me.tabStatus.BackColor = System.Drawing.Color.Black
        Me.tabStatus.Controls.Add(Me.lblErrorText)
        Me.tabStatus.Location = New System.Drawing.Point(4, 22)
        Me.tabStatus.Name = "tabStatus"
        Me.tabStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStatus.Size = New System.Drawing.Size(1233, 732)
        Me.tabStatus.TabIndex = 1
        Me.tabStatus.Text = "Status"
        '
        'lblErrorText
        '
        Me.lblErrorText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblErrorText.AutoEllipsis = True
        Me.lblErrorText.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorText.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!)
        Me.lblErrorText.Location = New System.Drawing.Point(346, 289)
        Me.lblErrorText.Name = "lblErrorText"
        Me.lblErrorText.Size = New System.Drawing.Size(540, 106)
        Me.lblErrorText.TabIndex = 1067
        Me.lblErrorText.Text = "Connecting to server, please wait..."
        Me.lblErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Black
        Me.PanelTop.Controls.Add(Me.btnReportBroken)
        Me.PanelTop.Controls.Add(Me.PlayerMovieTitle)
        Me.PanelTop.Controls.Add(Me.appClose)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1233, 48)
        Me.PanelTop.TabIndex = 1063
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
        Me.btnReportBroken.DesignerSelected = False
        Me.btnReportBroken.DimFactorClick = 0
        Me.btnReportBroken.DimFactorHover = 0
        Me.btnReportBroken.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnReportBroken.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnReportBroken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnReportBroken.ImageIndex = 0
        Me.btnReportBroken.Location = New System.Drawing.Point(1064, 8)
        Me.btnReportBroken.Name = "btnReportBroken"
        Me.btnReportBroken.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnReportBroken.Size = New System.Drawing.Size(122, 31)
        Me.btnReportBroken.TabIndex = 1048
        Me.btnReportBroken.Text = "Report Broken"
        Me.btnReportBroken.TextShadowShow = False
        '
        'PlayerMovieTitle
        '
        Me.PlayerMovieTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerMovieTitle.AutoEllipsis = True
        Me.PlayerMovieTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerMovieTitle.ForeColor = System.Drawing.Color.White
        Me.PlayerMovieTitle.Location = New System.Drawing.Point(10, 6)
        Me.PlayerMovieTitle.Name = "PlayerMovieTitle"
        Me.PlayerMovieTitle.Size = New System.Drawing.Size(1049, 34)
        Me.PlayerMovieTitle.TabIndex = 1061
        Me.PlayerMovieTitle.Text = "Movie Title"
        Me.PlayerMovieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'appClose
        '
        Me.appClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.appClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.appClose.Location = New System.Drawing.Point(1197, 11)
        Me.appClose.Name = "appClose"
        Me.appClose.Size = New System.Drawing.Size(25, 25)
        Me.appClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.appClose.TabIndex = 1046
        Me.appClose.TabStop = False
        '
        'timerUntilConnected
        '
        Me.timerUntilConnected.Interval = 800
        '
        'frmMediaPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1233, 772)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.tab)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmMediaPlayer"
        Me.ShowInTaskbar = False
        Me.Text = "Watch Movie"
        Me.tab.ResumeLayout(False)
        Me.tabPlayer.ResumeLayout(False)
        CType(Me.MediaPlayerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabStatus.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timerGoToTime As Timer
    Friend WithEvents tab As TabControl
    Friend WithEvents tabStatus As TabPage
    Friend WithEvents tabPlayer As TabPage
    Friend WithEvents MediaPlayerControl As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblErrorText As Label
    Friend WithEvents PanelTop As Panel
    Public WithEvents btnReportBroken As CButtonLib.CButton
    Friend WithEvents PlayerMovieTitle As Label
    Friend WithEvents appClose As PictureBox
    Friend WithEvents timerUntilConnected As Timer
End Class
