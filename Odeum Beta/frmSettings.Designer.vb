<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.lblComingSoon = New System.Windows.Forms.Label()
        Me.Splitter1g = New System.Windows.Forms.Label()
        Me.chckCelebr8 = New System.Windows.Forms.CheckBox()
        Me.chckBackupDb = New System.Windows.Forms.CheckBox()
        Me.txtDbDir = New System.Windows.Forms.TextBox()
        Me.chckRandomizeBtn = New System.Windows.Forms.CheckBox()
        Me.chckAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.lblHeaderMisc = New System.Windows.Forms.Label()
        Me.Splitter1f = New System.Windows.Forms.Label()
        Me.lblHeaderDb = New System.Windows.Forms.Label()
        Me.Splitter1d = New System.Windows.Forms.Label()
        Me.chckWatchList = New System.Windows.Forms.CheckBox()
        Me.lblSettingsFeatures = New System.Windows.Forms.Label()
        Me.Splitter1c = New System.Windows.Forms.Label()
        Me.chckPlayFullscr = New System.Windows.Forms.CheckBox()
        Me.lblHeaderPlayBck = New System.Windows.Forms.Label()
        Me.cmboBoxStartScreenPanel = New System.Windows.Forms.Panel()
        Me.cmboTxtStartScreen = New CButtonLib.CButton()
        Me.cmboboxStartScreen = New System.Windows.Forms.ComboBox()
        Me.cmboBoxWatchedMoviesPanel = New System.Windows.Forms.Panel()
        Me.cmboTxtWatchedMovies = New CButtonLib.CButton()
        Me.cmboboxWatchedMovies = New System.Windows.Forms.ComboBox()
        Me.chckFilters = New System.Windows.Forms.CheckBox()
        Me.lblHeaderGeneral = New System.Windows.Forms.Label()
        Me.Splitter1a = New System.Windows.Forms.Label()
        Me.lblWatchedMovies = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblStartScreen = New System.Windows.Forms.Label()
        Me.Splitter1b = New System.Windows.Forms.Label()
        Me.lblDbDir = New System.Windows.Forms.Label()
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.lblHeaderConnection = New System.Windows.Forms.Label()
        Me.Splitter1e = New System.Windows.Forms.Label()
        Me.rdioAutoProxy = New System.Windows.Forms.RadioButton()
        Me.rdioManualProxy = New System.Windows.Forms.RadioButton()
        Me.txtProxyAddress = New System.Windows.Forms.TextBox()
        Me.lblProxyAddress = New System.Windows.Forms.Label()
        Me.txtProxyPort = New System.Windows.Forms.TextBox()
        Me.lblProxyPort = New System.Windows.Forms.Label()
        Me.txtProxyPassword = New System.Windows.Forms.TextBox()
        Me.lblProxyPassword = New System.Windows.Forms.Label()
        Me.txtProxyUsername = New System.Windows.Forms.TextBox()
        Me.lblProxyUsername = New System.Windows.Forms.Label()
        Me.txtProxyPasswordBg = New CButtonLib.CButton()
        Me.txtProxyUsernameBg = New CButtonLib.CButton()
        Me.txtProxyPortBg = New CButtonLib.CButton()
        Me.txtProxyAddressBg = New CButtonLib.CButton()
        Me.lblSucessText = New CButtonLib.CButton()
        Me.btnResetAllDatabases = New CButtonLib.CButton()
        Me.btnResetSettings = New CButtonLib.CButton()
        Me.btnSaveSettings = New CButtonLib.CButton()
        Me.txtDbDirBg = New CButtonLib.CButton()
        Me.imgOpenFolder = New System.Windows.Forms.PictureBox()
        Me.btnDbExport = New CButtonLib.CButton()
        Me.MeClose = New System.Windows.Forms.PictureBox()
        Me.lblStillBeta = New System.Windows.Forms.Label()
        Me.chkAlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.chkShowRating = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkShowMovieQuality = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmboBoxStartScreenPanel.SuspendLayout()
        Me.cmboBoxWatchedMoviesPanel.SuspendLayout()
        CType(Me.imgOpenFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblComingSoon
        '
        Me.lblComingSoon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblComingSoon.AutoSize = True
        Me.lblComingSoon.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblComingSoon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblComingSoon.Location = New System.Drawing.Point(121, 1882)
        Me.lblComingSoon.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblComingSoon.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblComingSoon.Name = "lblComingSoon"
        Me.lblComingSoon.Size = New System.Drawing.Size(750, 57)
        Me.lblComingSoon.TabIndex = 100000000
        Me.lblComingSoon.Text = resources.GetString("lblComingSoon.Text")
        '
        'Splitter1g
        '
        Me.Splitter1g.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1g.AutoSize = True
        Me.Splitter1g.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1g.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1g.Location = New System.Drawing.Point(117, 1782)
        Me.Splitter1g.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1g.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1g.Name = "Splitter1g"
        Me.Splitter1g.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1g.TabIndex = 100000000
        Me.Splitter1g.Text = "-------------------------------------------------------------------------"
        '
        'chckCelebr8
        '
        Me.chckCelebr8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckCelebr8.AutoSize = True
        Me.chckCelebr8.Checked = True
        Me.chckCelebr8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckCelebr8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckCelebr8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckCelebr8.Location = New System.Drawing.Point(127, 1741)
        Me.chckCelebr8.Name = "chckCelebr8"
        Me.chckCelebr8.Size = New System.Drawing.Size(199, 25)
        Me.chckCelebr8.TabIndex = 18
        Me.chckCelebr8.Text = "Celebrate various events"
        Me.chckCelebr8.UseVisualStyleBackColor = True
        '
        'chckBackupDb
        '
        Me.chckBackupDb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckBackupDb.AutoSize = True
        Me.chckBackupDb.Checked = True
        Me.chckBackupDb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckBackupDb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckBackupDb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckBackupDb.Location = New System.Drawing.Point(126, 1068)
        Me.chckBackupDb.Name = "chckBackupDb"
        Me.chckBackupDb.Size = New System.Drawing.Size(194, 25)
        Me.chckBackupDb.TabIndex = 7
        Me.chckBackupDb.Text = "Create backup database"
        Me.chckBackupDb.UseVisualStyleBackColor = True
        '
        'txtDbDir
        '
        Me.txtDbDir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDbDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtDbDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDbDir.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDbDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDbDir.Location = New System.Drawing.Point(356, 1111)
        Me.txtDbDir.Name = "txtDbDir"
        Me.txtDbDir.ReadOnly = True
        Me.txtDbDir.Size = New System.Drawing.Size(396, 19)
        Me.txtDbDir.TabIndex = 8
        '
        'chckRandomizeBtn
        '
        Me.chckRandomizeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckRandomizeBtn.AutoSize = True
        Me.chckRandomizeBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckRandomizeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckRandomizeBtn.Location = New System.Drawing.Point(127, 923)
        Me.chckRandomizeBtn.Name = "chckRandomizeBtn"
        Me.chckRandomizeBtn.Size = New System.Drawing.Size(242, 25)
        Me.chckRandomizeBtn.TabIndex = 6
        Me.chckRandomizeBtn.Text = "Randomise button for movies*"
        Me.chckRandomizeBtn.UseVisualStyleBackColor = True
        '
        'chckAutoUpdate
        '
        Me.chckAutoUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckAutoUpdate.AutoSize = True
        Me.chckAutoUpdate.Checked = True
        Me.chckAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckAutoUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckAutoUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckAutoUpdate.Location = New System.Drawing.Point(127, 1699)
        Me.chckAutoUpdate.Name = "chckAutoUpdate"
        Me.chckAutoUpdate.Size = New System.Drawing.Size(229, 25)
        Me.chckAutoUpdate.TabIndex = 17
        Me.chckAutoUpdate.Text = "Check for updates on startup"
        Me.chckAutoUpdate.UseVisualStyleBackColor = True
        '
        'lblHeaderMisc
        '
        Me.lblHeaderMisc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderMisc.AutoSize = True
        Me.lblHeaderMisc.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderMisc.ForeColor = System.Drawing.Color.White
        Me.lblHeaderMisc.Location = New System.Drawing.Point(121, 1647)
        Me.lblHeaderMisc.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderMisc.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderMisc.Name = "lblHeaderMisc"
        Me.lblHeaderMisc.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderMisc.TabIndex = 100000000
        Me.lblHeaderMisc.Text = "Miscellaneous"
        '
        'Splitter1f
        '
        Me.Splitter1f.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1f.AutoSize = True
        Me.Splitter1f.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1f.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1f.Location = New System.Drawing.Point(117, 1594)
        Me.Splitter1f.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1f.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1f.Name = "Splitter1f"
        Me.Splitter1f.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1f.TabIndex = 100000000
        Me.Splitter1f.Text = "-------------------------------------------------------------------------"
        '
        'lblHeaderDb
        '
        Me.lblHeaderDb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderDb.AutoSize = True
        Me.lblHeaderDb.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderDb.ForeColor = System.Drawing.Color.White
        Me.lblHeaderDb.Location = New System.Drawing.Point(121, 1021)
        Me.lblHeaderDb.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderDb.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderDb.Name = "lblHeaderDb"
        Me.lblHeaderDb.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderDb.TabIndex = 100000000
        Me.lblHeaderDb.Text = "Database"
        '
        'Splitter1d
        '
        Me.Splitter1d.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1d.AutoSize = True
        Me.Splitter1d.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1d.Location = New System.Drawing.Point(117, 970)
        Me.Splitter1d.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1d.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1d.Name = "Splitter1d"
        Me.Splitter1d.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1d.TabIndex = 100000000
        Me.Splitter1d.Text = "-------------------------------------------------------------------------"
        '
        'chckWatchList
        '
        Me.chckWatchList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckWatchList.AutoSize = True
        Me.chckWatchList.Checked = True
        Me.chckWatchList.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckWatchList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckWatchList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckWatchList.Location = New System.Drawing.Point(126, 881)
        Me.chckWatchList.Name = "chckWatchList"
        Me.chckWatchList.Size = New System.Drawing.Size(100, 25)
        Me.chckWatchList.TabIndex = 5
        Me.chckWatchList.Text = "Watch List"
        Me.chckWatchList.UseVisualStyleBackColor = True
        '
        'lblSettingsFeatures
        '
        Me.lblSettingsFeatures.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSettingsFeatures.AutoSize = True
        Me.lblSettingsFeatures.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsFeatures.ForeColor = System.Drawing.Color.White
        Me.lblSettingsFeatures.Location = New System.Drawing.Point(121, 831)
        Me.lblSettingsFeatures.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblSettingsFeatures.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblSettingsFeatures.Name = "lblSettingsFeatures"
        Me.lblSettingsFeatures.Size = New System.Drawing.Size(750, 30)
        Me.lblSettingsFeatures.TabIndex = 100000000
        Me.lblSettingsFeatures.Text = "Features"
        '
        'Splitter1c
        '
        Me.Splitter1c.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1c.AutoSize = True
        Me.Splitter1c.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1c.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1c.Location = New System.Drawing.Point(117, 776)
        Me.Splitter1c.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1c.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1c.Name = "Splitter1c"
        Me.Splitter1c.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1c.TabIndex = 100000000
        Me.Splitter1c.Text = "-------------------------------------------------------------------------"
        '
        'chckPlayFullscr
        '
        Me.chckPlayFullscr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckPlayFullscr.AutoSize = True
        Me.chckPlayFullscr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckPlayFullscr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckPlayFullscr.Location = New System.Drawing.Point(127, 726)
        Me.chckPlayFullscr.Name = "chckPlayFullscr"
        Me.chckPlayFullscr.Size = New System.Drawing.Size(256, 25)
        Me.chckPlayFullscr.TabIndex = 4
        Me.chckPlayFullscr.Text = "Always start playing in fullscreen"
        Me.chckPlayFullscr.UseVisualStyleBackColor = True
        '
        'lblHeaderPlayBck
        '
        Me.lblHeaderPlayBck.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderPlayBck.AutoSize = True
        Me.lblHeaderPlayBck.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderPlayBck.ForeColor = System.Drawing.Color.White
        Me.lblHeaderPlayBck.Location = New System.Drawing.Point(121, 674)
        Me.lblHeaderPlayBck.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderPlayBck.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderPlayBck.Name = "lblHeaderPlayBck"
        Me.lblHeaderPlayBck.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderPlayBck.TabIndex = 100000000
        Me.lblHeaderPlayBck.Text = "Playback"
        '
        'cmboBoxStartScreenPanel
        '
        Me.cmboBoxStartScreenPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboBoxStartScreenPanel.BackColor = System.Drawing.Color.Transparent
        Me.cmboBoxStartScreenPanel.Controls.Add(Me.cmboTxtStartScreen)
        Me.cmboBoxStartScreenPanel.Location = New System.Drawing.Point(353, 331)
        Me.cmboBoxStartScreenPanel.Name = "cmboBoxStartScreenPanel"
        Me.cmboBoxStartScreenPanel.Size = New System.Drawing.Size(135, 31)
        Me.cmboBoxStartScreenPanel.TabIndex = 100000006
        '
        'cmboTxtStartScreen
        '
        Me.cmboTxtStartScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboTxtStartScreen.BackColor = System.Drawing.Color.Transparent
        Me.cmboTxtStartScreen.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboTxtStartScreen.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboTxtStartScreen.Corners.All = 2
        Me.cmboTxtStartScreen.Corners.LowerLeft = 2
        Me.cmboTxtStartScreen.Corners.LowerRight = 2
        Me.cmboTxtStartScreen.Corners.UpperLeft = 2
        Me.cmboTxtStartScreen.Corners.UpperRight = 2
        Me.cmboTxtStartScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboTxtStartScreen.DesignerSelected = False
        Me.cmboTxtStartScreen.DimFactorClick = 0
        Me.cmboTxtStartScreen.DimFactorHover = 0
        Me.cmboTxtStartScreen.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboTxtStartScreen.FocalPoints.CenterPtX = 0!
        Me.cmboTxtStartScreen.FocalPoints.CenterPtY = 0!
        Me.cmboTxtStartScreen.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboTxtStartScreen.ImageIndex = 0
        Me.cmboTxtStartScreen.Location = New System.Drawing.Point(0, 0)
        Me.cmboTxtStartScreen.Name = "cmboTxtStartScreen"
        Me.cmboTxtStartScreen.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboTxtStartScreen.SideImage = CType(resources.GetObject("cmboTxtStartScreen.SideImage"), System.Drawing.Image)
        Me.cmboTxtStartScreen.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboTxtStartScreen.SideImageSize = New System.Drawing.Size(17, 18)
        Me.cmboTxtStartScreen.Size = New System.Drawing.Size(134, 30)
        Me.cmboTxtStartScreen.TabIndex = 1
        Me.cmboTxtStartScreen.Text = "Movies"
        Me.cmboTxtStartScreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboTxtStartScreen.TextMargin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.cmboTxtStartScreen.TextShadow = System.Drawing.Color.White
        Me.cmboTxtStartScreen.TextShadowShow = False
        '
        'cmboboxStartScreen
        '
        Me.cmboboxStartScreen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboboxStartScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxStartScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxStartScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxStartScreen.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboboxStartScreen.ForeColor = System.Drawing.Color.White
        Me.cmboboxStartScreen.FormattingEnabled = True
        Me.cmboboxStartScreen.Items.AddRange(New Object() {"Movies", "Favourites", "Watch List"})
        Me.cmboboxStartScreen.Location = New System.Drawing.Point(353, 335)
        Me.cmboboxStartScreen.Name = "cmboboxStartScreen"
        Me.cmboboxStartScreen.Size = New System.Drawing.Size(134, 27)
        Me.cmboboxStartScreen.TabIndex = 100000005
        Me.cmboboxStartScreen.TabStop = False
        Me.cmboboxStartScreen.Visible = False
        '
        'cmboBoxWatchedMoviesPanel
        '
        Me.cmboBoxWatchedMoviesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboBoxWatchedMoviesPanel.BackColor = System.Drawing.Color.Transparent
        Me.cmboBoxWatchedMoviesPanel.Controls.Add(Me.cmboTxtWatchedMovies)
        Me.cmboBoxWatchedMoviesPanel.Location = New System.Drawing.Point(353, 415)
        Me.cmboBoxWatchedMoviesPanel.Name = "cmboBoxWatchedMoviesPanel"
        Me.cmboBoxWatchedMoviesPanel.Size = New System.Drawing.Size(135, 31)
        Me.cmboBoxWatchedMoviesPanel.TabIndex = 100000004
        '
        'cmboTxtWatchedMovies
        '
        Me.cmboTxtWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboTxtWatchedMovies.BackColor = System.Drawing.Color.Transparent
        Me.cmboTxtWatchedMovies.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboTxtWatchedMovies.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboTxtWatchedMovies.Corners.All = 2
        Me.cmboTxtWatchedMovies.Corners.LowerLeft = 2
        Me.cmboTxtWatchedMovies.Corners.LowerRight = 2
        Me.cmboTxtWatchedMovies.Corners.UpperLeft = 2
        Me.cmboTxtWatchedMovies.Corners.UpperRight = 2
        Me.cmboTxtWatchedMovies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboTxtWatchedMovies.DesignerSelected = False
        Me.cmboTxtWatchedMovies.DimFactorClick = 0
        Me.cmboTxtWatchedMovies.DimFactorHover = 0
        Me.cmboTxtWatchedMovies.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboTxtWatchedMovies.FocalPoints.CenterPtX = 0!
        Me.cmboTxtWatchedMovies.FocalPoints.CenterPtY = 0!
        Me.cmboTxtWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboTxtWatchedMovies.ImageIndex = 0
        Me.cmboTxtWatchedMovies.Location = New System.Drawing.Point(0, 0)
        Me.cmboTxtWatchedMovies.Name = "cmboTxtWatchedMovies"
        Me.cmboTxtWatchedMovies.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboTxtWatchedMovies.SideImage = CType(resources.GetObject("cmboTxtWatchedMovies.SideImage"), System.Drawing.Image)
        Me.cmboTxtWatchedMovies.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboTxtWatchedMovies.SideImageSize = New System.Drawing.Size(17, 18)
        Me.cmboTxtWatchedMovies.Size = New System.Drawing.Size(134, 30)
        Me.cmboTxtWatchedMovies.TabIndex = 3
        Me.cmboTxtWatchedMovies.Text = "Fade"
        Me.cmboTxtWatchedMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboTxtWatchedMovies.TextMargin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.cmboTxtWatchedMovies.TextShadow = System.Drawing.Color.White
        Me.cmboTxtWatchedMovies.TextShadowShow = False
        '
        'cmboboxWatchedMovies
        '
        Me.cmboboxWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboboxWatchedMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxWatchedMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxWatchedMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboboxWatchedMovies.ForeColor = System.Drawing.Color.White
        Me.cmboboxWatchedMovies.FormattingEnabled = True
        Me.cmboboxWatchedMovies.Items.AddRange(New Object() {"Fade", "Hide", "Show"})
        Me.cmboboxWatchedMovies.Location = New System.Drawing.Point(353, 419)
        Me.cmboboxWatchedMovies.Name = "cmboboxWatchedMovies"
        Me.cmboboxWatchedMovies.Size = New System.Drawing.Size(134, 27)
        Me.cmboboxWatchedMovies.TabIndex = 100000003
        Me.cmboboxWatchedMovies.TabStop = False
        Me.cmboboxWatchedMovies.Visible = False
        '
        'chckFilters
        '
        Me.chckFilters.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckFilters.AutoSize = True
        Me.chckFilters.Enabled = False
        Me.chckFilters.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckFilters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckFilters.Location = New System.Drawing.Point(125, 377)
        Me.chckFilters.Name = "chckFilters"
        Me.chckFilters.Size = New System.Drawing.Size(156, 25)
        Me.chckFilters.TabIndex = 2
        Me.chckFilters.Text = "Remember filters*"
        Me.chckFilters.UseVisualStyleBackColor = True
        '
        'lblHeaderGeneral
        '
        Me.lblHeaderGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderGeneral.AutoSize = True
        Me.lblHeaderGeneral.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderGeneral.ForeColor = System.Drawing.Color.White
        Me.lblHeaderGeneral.Location = New System.Drawing.Point(119, 190)
        Me.lblHeaderGeneral.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderGeneral.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderGeneral.Name = "lblHeaderGeneral"
        Me.lblHeaderGeneral.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderGeneral.TabIndex = 100000000
        Me.lblHeaderGeneral.Text = "General"
        '
        'Splitter1a
        '
        Me.Splitter1a.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1a.AutoSize = True
        Me.Splitter1a.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1a.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1a.Location = New System.Drawing.Point(116, 139)
        Me.Splitter1a.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1a.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1a.Name = "Splitter1a"
        Me.Splitter1a.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1a.TabIndex = 100000000
        Me.Splitter1a.Text = "-------------------------------------------------------------------------"
        '
        'lblWatchedMovies
        '
        Me.lblWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblWatchedMovies.AutoSize = True
        Me.lblWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchedMovies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblWatchedMovies.Location = New System.Drawing.Point(121, 418)
        Me.lblWatchedMovies.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblWatchedMovies.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblWatchedMovies.Name = "lblWatchedMovies"
        Me.lblWatchedMovies.Size = New System.Drawing.Size(750, 21)
        Me.lblWatchedMovies.TabIndex = 100000000
        Me.lblWatchedMovies.Text = "Watched movies"
        '
        'lblSettings
        '
        Me.lblSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSettings.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.White
        Me.lblSettings.Location = New System.Drawing.Point(424, 83)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(141, 45)
        Me.lblSettings.TabIndex = 100000000
        Me.lblSettings.Text = "Settings"
        '
        'lblStartScreen
        '
        Me.lblStartScreen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStartScreen.AutoSize = True
        Me.lblStartScreen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartScreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblStartScreen.Location = New System.Drawing.Point(121, 335)
        Me.lblStartScreen.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblStartScreen.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblStartScreen.Name = "lblStartScreen"
        Me.lblStartScreen.Size = New System.Drawing.Size(750, 21)
        Me.lblStartScreen.TabIndex = 100000000
        Me.lblStartScreen.Text = "Start screen"
        '
        'Splitter1b
        '
        Me.Splitter1b.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1b.AutoSize = True
        Me.Splitter1b.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1b.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1b.Location = New System.Drawing.Point(116, 463)
        Me.Splitter1b.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1b.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1b.Name = "Splitter1b"
        Me.Splitter1b.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1b.TabIndex = 100000008
        Me.Splitter1b.Text = "-------------------------------------------------------------------------"
        '
        'lblDbDir
        '
        Me.lblDbDir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDbDir.AutoSize = True
        Me.lblDbDir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDbDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDbDir.Location = New System.Drawing.Point(121, 1110)
        Me.lblDbDir.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblDbDir.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblDbDir.Name = "lblDbDir"
        Me.lblDbDir.Size = New System.Drawing.Size(750, 21)
        Me.lblDbDir.TabIndex = 100000000
        Me.lblDbDir.Text = "Database Directory"
        '
        'timerHideNotifications
        '
        Me.timerHideNotifications.Interval = 4000
        '
        'lblHeaderConnection
        '
        Me.lblHeaderConnection.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderConnection.AutoSize = True
        Me.lblHeaderConnection.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderConnection.ForeColor = System.Drawing.Color.White
        Me.lblHeaderConnection.Location = New System.Drawing.Point(121, 1273)
        Me.lblHeaderConnection.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderConnection.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblHeaderConnection.Name = "lblHeaderConnection"
        Me.lblHeaderConnection.Size = New System.Drawing.Size(750, 30)
        Me.lblHeaderConnection.TabIndex = 100000000
        Me.lblHeaderConnection.Text = "Connection"
        '
        'Splitter1e
        '
        Me.Splitter1e.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1e.AutoSize = True
        Me.Splitter1e.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1e.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1e.Location = New System.Drawing.Point(117, 1220)
        Me.Splitter1e.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1e.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1e.Name = "Splitter1e"
        Me.Splitter1e.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1e.TabIndex = 100000000
        Me.Splitter1e.Text = "-------------------------------------------------------------------------"
        '
        'rdioAutoProxy
        '
        Me.rdioAutoProxy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdioAutoProxy.AutoSize = True
        Me.rdioAutoProxy.Checked = True
        Me.rdioAutoProxy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.rdioAutoProxy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rdioAutoProxy.Location = New System.Drawing.Point(126, 1324)
        Me.rdioAutoProxy.Name = "rdioAutoProxy"
        Me.rdioAutoProxy.Size = New System.Drawing.Size(208, 25)
        Me.rdioAutoProxy.TabIndex = 10
        Me.rdioAutoProxy.TabStop = True
        Me.rdioAutoProxy.Text = "Auto detect proxy settings"
        Me.rdioAutoProxy.UseVisualStyleBackColor = True
        '
        'rdioManualProxy
        '
        Me.rdioManualProxy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdioManualProxy.AutoSize = True
        Me.rdioManualProxy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.rdioManualProxy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rdioManualProxy.Location = New System.Drawing.Point(126, 1366)
        Me.rdioManualProxy.Name = "rdioManualProxy"
        Me.rdioManualProxy.Size = New System.Drawing.Size(223, 25)
        Me.rdioManualProxy.TabIndex = 11
        Me.rdioManualProxy.Text = "Manual proxy configuration:"
        Me.rdioManualProxy.UseVisualStyleBackColor = True
        '
        'txtProxyAddress
        '
        Me.txtProxyAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProxyAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtProxyAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProxyAddress.Enabled = False
        Me.txtProxyAddress.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtProxyAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProxyAddress.Location = New System.Drawing.Point(356, 1420)
        Me.txtProxyAddress.Name = "txtProxyAddress"
        Me.txtProxyAddress.Size = New System.Drawing.Size(277, 19)
        Me.txtProxyAddress.TabIndex = 12
        '
        'lblProxyAddress
        '
        Me.lblProxyAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProxyAddress.AutoSize = True
        Me.lblProxyAddress.Enabled = False
        Me.lblProxyAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblProxyAddress.Location = New System.Drawing.Point(121, 1418)
        Me.lblProxyAddress.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblProxyAddress.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblProxyAddress.Name = "lblProxyAddress"
        Me.lblProxyAddress.Size = New System.Drawing.Size(750, 21)
        Me.lblProxyAddress.TabIndex = 100000000
        Me.lblProxyAddress.Text = "HTTP Address"
        '
        'txtProxyPort
        '
        Me.txtProxyPort.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProxyPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtProxyPort.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProxyPort.Enabled = False
        Me.txtProxyPort.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtProxyPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProxyPort.Location = New System.Drawing.Point(356, 1462)
        Me.txtProxyPort.Name = "txtProxyPort"
        Me.txtProxyPort.Size = New System.Drawing.Size(277, 19)
        Me.txtProxyPort.TabIndex = 13
        '
        'lblProxyPort
        '
        Me.lblProxyPort.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProxyPort.AutoSize = True
        Me.lblProxyPort.Enabled = False
        Me.lblProxyPort.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblProxyPort.Location = New System.Drawing.Point(121, 1460)
        Me.lblProxyPort.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblProxyPort.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblProxyPort.Name = "lblProxyPort"
        Me.lblProxyPort.Size = New System.Drawing.Size(750, 21)
        Me.lblProxyPort.TabIndex = 100000000
        Me.lblProxyPort.Text = "HTTP Port"
        '
        'txtProxyPassword
        '
        Me.txtProxyPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProxyPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtProxyPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProxyPassword.Enabled = False
        Me.txtProxyPassword.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtProxyPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProxyPassword.Location = New System.Drawing.Point(356, 1547)
        Me.txtProxyPassword.Name = "txtProxyPassword"
        Me.txtProxyPassword.Size = New System.Drawing.Size(277, 19)
        Me.txtProxyPassword.TabIndex = 15
        '
        'lblProxyPassword
        '
        Me.lblProxyPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProxyPassword.AutoSize = True
        Me.lblProxyPassword.Enabled = False
        Me.lblProxyPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblProxyPassword.Location = New System.Drawing.Point(121, 1545)
        Me.lblProxyPassword.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblProxyPassword.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblProxyPassword.Name = "lblProxyPassword"
        Me.lblProxyPassword.Size = New System.Drawing.Size(750, 21)
        Me.lblProxyPassword.TabIndex = 100000000
        Me.lblProxyPassword.Text = "Password (optional)"
        '
        'txtProxyUsername
        '
        Me.txtProxyUsername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProxyUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtProxyUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProxyUsername.Enabled = False
        Me.txtProxyUsername.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtProxyUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProxyUsername.Location = New System.Drawing.Point(356, 1507)
        Me.txtProxyUsername.Name = "txtProxyUsername"
        Me.txtProxyUsername.Size = New System.Drawing.Size(277, 19)
        Me.txtProxyUsername.TabIndex = 14
        '
        'lblProxyUsername
        '
        Me.lblProxyUsername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProxyUsername.AutoSize = True
        Me.lblProxyUsername.Enabled = False
        Me.lblProxyUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxyUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblProxyUsername.Location = New System.Drawing.Point(121, 1503)
        Me.lblProxyUsername.MaximumSize = New System.Drawing.Size(750, 0)
        Me.lblProxyUsername.MinimumSize = New System.Drawing.Size(750, 0)
        Me.lblProxyUsername.Name = "lblProxyUsername"
        Me.lblProxyUsername.Size = New System.Drawing.Size(750, 21)
        Me.lblProxyUsername.TabIndex = 100000000
        Me.lblProxyUsername.Text = "Username (optional)"
        '
        'txtProxyPasswordBg
        '
        Me.txtProxyPasswordBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProxyPasswordBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProxyPasswordBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtProxyPasswordBg.Corners.All = 2
        Me.txtProxyPasswordBg.Corners.LowerLeft = 2
        Me.txtProxyPasswordBg.Corners.LowerRight = 2
        Me.txtProxyPasswordBg.Corners.UpperLeft = 2
        Me.txtProxyPasswordBg.Corners.UpperRight = 2
        Me.txtProxyPasswordBg.DesignerSelected = False
        Me.txtProxyPasswordBg.DimFactorClick = 0
        Me.txtProxyPasswordBg.DimFactorHover = 0
        Me.txtProxyPasswordBg.Enabled = False
        Me.txtProxyPasswordBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtProxyPasswordBg.ImageIndex = 0
        Me.txtProxyPasswordBg.Location = New System.Drawing.Point(349, 1544)
        Me.txtProxyPasswordBg.Name = "txtProxyPasswordBg"
        Me.txtProxyPasswordBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtProxyPasswordBg.Size = New System.Drawing.Size(291, 26)
        Me.txtProxyPasswordBg.TabIndex = 100000000
        Me.txtProxyPasswordBg.TabStop = False
        Me.txtProxyPasswordBg.Text = ""
        '
        'txtProxyUsernameBg
        '
        Me.txtProxyUsernameBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProxyUsernameBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProxyUsernameBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtProxyUsernameBg.Corners.All = 2
        Me.txtProxyUsernameBg.Corners.LowerLeft = 2
        Me.txtProxyUsernameBg.Corners.LowerRight = 2
        Me.txtProxyUsernameBg.Corners.UpperLeft = 2
        Me.txtProxyUsernameBg.Corners.UpperRight = 2
        Me.txtProxyUsernameBg.DesignerSelected = False
        Me.txtProxyUsernameBg.DimFactorClick = 0
        Me.txtProxyUsernameBg.DimFactorHover = 0
        Me.txtProxyUsernameBg.Enabled = False
        Me.txtProxyUsernameBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtProxyUsernameBg.ImageIndex = 0
        Me.txtProxyUsernameBg.Location = New System.Drawing.Point(349, 1504)
        Me.txtProxyUsernameBg.Name = "txtProxyUsernameBg"
        Me.txtProxyUsernameBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtProxyUsernameBg.Size = New System.Drawing.Size(291, 26)
        Me.txtProxyUsernameBg.TabIndex = 100000000
        Me.txtProxyUsernameBg.TabStop = False
        Me.txtProxyUsernameBg.Text = ""
        '
        'txtProxyPortBg
        '
        Me.txtProxyPortBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProxyPortBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProxyPortBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtProxyPortBg.Corners.All = 2
        Me.txtProxyPortBg.Corners.LowerLeft = 2
        Me.txtProxyPortBg.Corners.LowerRight = 2
        Me.txtProxyPortBg.Corners.UpperLeft = 2
        Me.txtProxyPortBg.Corners.UpperRight = 2
        Me.txtProxyPortBg.DesignerSelected = False
        Me.txtProxyPortBg.DimFactorClick = 0
        Me.txtProxyPortBg.DimFactorHover = 0
        Me.txtProxyPortBg.Enabled = False
        Me.txtProxyPortBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtProxyPortBg.ImageIndex = 0
        Me.txtProxyPortBg.Location = New System.Drawing.Point(349, 1459)
        Me.txtProxyPortBg.Name = "txtProxyPortBg"
        Me.txtProxyPortBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtProxyPortBg.Size = New System.Drawing.Size(291, 26)
        Me.txtProxyPortBg.TabIndex = 100000000
        Me.txtProxyPortBg.TabStop = False
        Me.txtProxyPortBg.Text = ""
        '
        'txtProxyAddressBg
        '
        Me.txtProxyAddressBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProxyAddressBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProxyAddressBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtProxyAddressBg.Corners.All = 2
        Me.txtProxyAddressBg.Corners.LowerLeft = 2
        Me.txtProxyAddressBg.Corners.LowerRight = 2
        Me.txtProxyAddressBg.Corners.UpperLeft = 2
        Me.txtProxyAddressBg.Corners.UpperRight = 2
        Me.txtProxyAddressBg.DesignerSelected = False
        Me.txtProxyAddressBg.DimFactorClick = 0
        Me.txtProxyAddressBg.DimFactorHover = 0
        Me.txtProxyAddressBg.Enabled = False
        Me.txtProxyAddressBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtProxyAddressBg.ImageIndex = 0
        Me.txtProxyAddressBg.Location = New System.Drawing.Point(349, 1417)
        Me.txtProxyAddressBg.Name = "txtProxyAddressBg"
        Me.txtProxyAddressBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtProxyAddressBg.Size = New System.Drawing.Size(291, 26)
        Me.txtProxyAddressBg.TabIndex = 100000000
        Me.txtProxyAddressBg.TabStop = False
        Me.txtProxyAddressBg.Text = ""
        '
        'lblSucessText
        '
        Me.lblSucessText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSucessText.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblSucessText.BorderShow = False
        Me.lblSucessText.ColorFillSolid = System.Drawing.Color.Transparent
        Me.lblSucessText.Corners.All = 2
        Me.lblSucessText.Corners.LowerLeft = 2
        Me.lblSucessText.Corners.LowerRight = 2
        Me.lblSucessText.Corners.UpperLeft = 2
        Me.lblSucessText.Corners.UpperRight = 2
        Me.lblSucessText.DesignerSelected = False
        Me.lblSucessText.DimFactorClick = 0
        Me.lblSucessText.DimFactorHover = 0
        Me.lblSucessText.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblSucessText.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!)
        Me.lblSucessText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSucessText.ImageIndex = 0
        Me.lblSucessText.Location = New System.Drawing.Point(637, 1834)
        Me.lblSucessText.Name = "lblSucessText"
        Me.lblSucessText.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblSucessText.Size = New System.Drawing.Size(293, 41)
        Me.lblSucessText.TabIndex = 22
        Me.lblSucessText.Text = "Your settings have been saved. Some may take affect after the next startup."
        Me.lblSucessText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSucessText.TextShadowShow = False
        Me.lblSucessText.Visible = False
        '
        'btnResetAllDatabases
        '
        Me.btnResetAllDatabases.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnResetAllDatabases.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnResetAllDatabases.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnResetAllDatabases.Corners.All = 2
        Me.btnResetAllDatabases.Corners.LowerLeft = 2
        Me.btnResetAllDatabases.Corners.LowerRight = 2
        Me.btnResetAllDatabases.Corners.UpperLeft = 2
        Me.btnResetAllDatabases.Corners.UpperRight = 2
        Me.btnResetAllDatabases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetAllDatabases.DesignerSelected = False
        Me.btnResetAllDatabases.DimFactorClick = 0
        Me.btnResetAllDatabases.DimFactorHover = 0
        Me.btnResetAllDatabases.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnResetAllDatabases.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!)
        Me.btnResetAllDatabases.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnResetAllDatabases.ImageIndex = 0
        Me.btnResetAllDatabases.Location = New System.Drawing.Point(463, 1837)
        Me.btnResetAllDatabases.Name = "btnResetAllDatabases"
        Me.btnResetAllDatabases.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnResetAllDatabases.Size = New System.Drawing.Size(163, 35)
        Me.btnResetAllDatabases.TabIndex = 21
        Me.btnResetAllDatabases.Text = "Flush All Databases"
        Me.btnResetAllDatabases.TextShadowShow = False
        '
        'btnResetSettings
        '
        Me.btnResetSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnResetSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnResetSettings.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnResetSettings.Corners.All = 2
        Me.btnResetSettings.Corners.LowerLeft = 2
        Me.btnResetSettings.Corners.LowerRight = 2
        Me.btnResetSettings.Corners.UpperLeft = 2
        Me.btnResetSettings.Corners.UpperRight = 2
        Me.btnResetSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetSettings.DesignerSelected = False
        Me.btnResetSettings.DimFactorClick = 0
        Me.btnResetSettings.DimFactorHover = 0
        Me.btnResetSettings.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnResetSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!)
        Me.btnResetSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnResetSettings.ImageIndex = 0
        Me.btnResetSettings.Location = New System.Drawing.Point(257, 1837)
        Me.btnResetSettings.Name = "btnResetSettings"
        Me.btnResetSettings.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnResetSettings.Size = New System.Drawing.Size(195, 35)
        Me.btnResetSettings.TabIndex = 20
        Me.btnResetSettings.Text = "Restore Default Settings"
        Me.btnResetSettings.TextShadowShow = False
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSaveSettings.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnSaveSettings.Corners.All = 2
        Me.btnSaveSettings.Corners.LowerLeft = 2
        Me.btnSaveSettings.Corners.LowerRight = 2
        Me.btnSaveSettings.Corners.UpperLeft = 2
        Me.btnSaveSettings.Corners.UpperRight = 2
        Me.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSettings.DesignerSelected = False
        Me.btnSaveSettings.DimFactorClick = 0
        Me.btnSaveSettings.DimFactorHover = 0
        Me.btnSaveSettings.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnSaveSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!)
        Me.btnSaveSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSaveSettings.ImageIndex = 0
        Me.btnSaveSettings.Location = New System.Drawing.Point(125, 1837)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnSaveSettings.Size = New System.Drawing.Size(121, 35)
        Me.btnSaveSettings.TabIndex = 19
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.TextShadowShow = False
        '
        'txtDbDirBg
        '
        Me.txtDbDirBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDbDirBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDbDirBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtDbDirBg.Corners.All = 2
        Me.txtDbDirBg.Corners.LowerLeft = 2
        Me.txtDbDirBg.Corners.LowerRight = 2
        Me.txtDbDirBg.Corners.UpperLeft = 2
        Me.txtDbDirBg.Corners.UpperRight = 2
        Me.txtDbDirBg.DesignerSelected = False
        Me.txtDbDirBg.DimFactorClick = 0
        Me.txtDbDirBg.DimFactorHover = 0
        Me.txtDbDirBg.Enabled = False
        Me.txtDbDirBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtDbDirBg.ImageIndex = 0
        Me.txtDbDirBg.Location = New System.Drawing.Point(349, 1108)
        Me.txtDbDirBg.Name = "txtDbDirBg"
        Me.txtDbDirBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtDbDirBg.Size = New System.Drawing.Size(410, 26)
        Me.txtDbDirBg.TabIndex = 100000020
        Me.txtDbDirBg.TabStop = False
        Me.txtDbDirBg.Text = ""
        '
        'imgOpenFolder
        '
        Me.imgOpenFolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgOpenFolder.Image = Global.Movieo.My.Resources.Resources.BrowseIconL
        Me.imgOpenFolder.Location = New System.Drawing.Point(768, 1112)
        Me.imgOpenFolder.Name = "imgOpenFolder"
        Me.imgOpenFolder.Size = New System.Drawing.Size(20, 18)
        Me.imgOpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgOpenFolder.TabIndex = 100000021
        Me.imgOpenFolder.TabStop = False
        '
        'btnDbExport
        '
        Me.btnDbExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDbExport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDbExport.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnDbExport.Corners.All = 2
        Me.btnDbExport.Corners.LowerLeft = 2
        Me.btnDbExport.Corners.LowerRight = 2
        Me.btnDbExport.Corners.UpperLeft = 2
        Me.btnDbExport.Corners.UpperRight = 2
        Me.btnDbExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDbExport.DesignerSelected = False
        Me.btnDbExport.DimFactorClick = 0
        Me.btnDbExport.DimFactorHover = 0
        Me.btnDbExport.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnDbExport.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!)
        Me.btnDbExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDbExport.ImageIndex = 0
        Me.btnDbExport.Location = New System.Drawing.Point(125, 1158)
        Me.btnDbExport.Name = "btnDbExport"
        Me.btnDbExport.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnDbExport.Size = New System.Drawing.Size(147, 35)
        Me.btnDbExport.TabIndex = 9
        Me.btnDbExport.Text = "Export Database"
        Me.btnDbExport.TextShadowShow = False
        '
        'MeClose
        '
        Me.MeClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MeClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.MeClose.Location = New System.Drawing.Point(929, 33)
        Me.MeClose.Name = "MeClose"
        Me.MeClose.Size = New System.Drawing.Size(23, 23)
        Me.MeClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MeClose.TabIndex = 100000055
        Me.MeClose.TabStop = False
        '
        'lblStillBeta
        '
        Me.lblStillBeta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStillBeta.AutoSize = True
        Me.lblStillBeta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStillBeta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblStillBeta.Location = New System.Drawing.Point(239, 1286)
        Me.lblStillBeta.Name = "lblStillBeta"
        Me.lblStillBeta.Size = New System.Drawing.Size(65, 13)
        Me.lblStillBeta.TabIndex = 100000056
        Me.lblStillBeta.Text = "Still in beta"
        '
        'chkAlwaysOnTop
        '
        Me.chkAlwaysOnTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkAlwaysOnTop.AutoSize = True
        Me.chkAlwaysOnTop.Enabled = False
        Me.chkAlwaysOnTop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkAlwaysOnTop.Location = New System.Drawing.Point(124, 244)
        Me.chkAlwaysOnTop.Name = "chkAlwaysOnTop"
        Me.chkAlwaysOnTop.Size = New System.Drawing.Size(127, 25)
        Me.chkAlwaysOnTop.TabIndex = 100000057
        Me.chkAlwaysOnTop.Text = "Always on top"
        Me.chkAlwaysOnTop.UseVisualStyleBackColor = True
        '
        'chkShowRating
        '
        Me.chkShowRating.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkShowRating.AutoSize = True
        Me.chkShowRating.Checked = True
        Me.chkShowRating.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowRating.Enabled = False
        Me.chkShowRating.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkShowRating.Location = New System.Drawing.Point(124, 289)
        Me.chkShowRating.Name = "chkShowRating"
        Me.chkShowRating.Size = New System.Drawing.Size(197, 25)
        Me.chkShowRating.TabIndex = 100000058
        Me.chkShowRating.Text = "Show rating on posters*"
        Me.chkShowRating.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(117, 619)
        Me.Label1.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(750, 32)
        Me.Label1.TabIndex = 100000060
        Me.Label1.Text = "-------------------------------------------------------------------------"
        '
        'chkShowMovieQuality
        '
        Me.chkShowMovieQuality.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkShowMovieQuality.AutoSize = True
        Me.chkShowMovieQuality.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowMovieQuality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkShowMovieQuality.Location = New System.Drawing.Point(127, 569)
        Me.chkShowMovieQuality.Name = "chkShowMovieQuality"
        Me.chkShowMovieQuality.Size = New System.Drawing.Size(212, 25)
        Me.chkShowMovieQuality.TabIndex = 100000059
        Me.chkShowMovieQuality.Text = "Show movie quality on list"
        Me.chkShowMovieQuality.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(119, 517)
        Me.Label2.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label2.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(750, 30)
        Me.Label2.TabIndex = 100000061
        Me.Label2.Text = "Quality"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1058, 561)
        Me.Controls.Add(Me.cmboBoxWatchedMoviesPanel)
        Me.Controls.Add(Me.cmboboxWatchedMovies)
        Me.Controls.Add(Me.lblWatchedMovies)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkShowMovieQuality)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkShowRating)
        Me.Controls.Add(Me.chkAlwaysOnTop)
        Me.Controls.Add(Me.lblStillBeta)
        Me.Controls.Add(Me.MeClose)
        Me.Controls.Add(Me.txtProxyPassword)
        Me.Controls.Add(Me.txtProxyPasswordBg)
        Me.Controls.Add(Me.lblProxyPassword)
        Me.Controls.Add(Me.txtProxyUsername)
        Me.Controls.Add(Me.txtProxyUsernameBg)
        Me.Controls.Add(Me.lblProxyUsername)
        Me.Controls.Add(Me.txtProxyPort)
        Me.Controls.Add(Me.txtProxyPortBg)
        Me.Controls.Add(Me.lblProxyPort)
        Me.Controls.Add(Me.txtProxyAddress)
        Me.Controls.Add(Me.txtProxyAddressBg)
        Me.Controls.Add(Me.lblProxyAddress)
        Me.Controls.Add(Me.rdioManualProxy)
        Me.Controls.Add(Me.lblHeaderConnection)
        Me.Controls.Add(Me.Splitter1e)
        Me.Controls.Add(Me.lblComingSoon)
        Me.Controls.Add(Me.lblSucessText)
        Me.Controls.Add(Me.Splitter1g)
        Me.Controls.Add(Me.btnResetAllDatabases)
        Me.Controls.Add(Me.btnResetSettings)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.chckCelebr8)
        Me.Controls.Add(Me.btnDbExport)
        Me.Controls.Add(Me.chckBackupDb)
        Me.Controls.Add(Me.txtDbDir)
        Me.Controls.Add(Me.txtDbDirBg)
        Me.Controls.Add(Me.chckRandomizeBtn)
        Me.Controls.Add(Me.chckAutoUpdate)
        Me.Controls.Add(Me.lblHeaderMisc)
        Me.Controls.Add(Me.Splitter1f)
        Me.Controls.Add(Me.lblHeaderDb)
        Me.Controls.Add(Me.Splitter1d)
        Me.Controls.Add(Me.chckWatchList)
        Me.Controls.Add(Me.lblSettingsFeatures)
        Me.Controls.Add(Me.Splitter1c)
        Me.Controls.Add(Me.chckPlayFullscr)
        Me.Controls.Add(Me.lblHeaderPlayBck)
        Me.Controls.Add(Me.cmboBoxStartScreenPanel)
        Me.Controls.Add(Me.cmboboxStartScreen)
        Me.Controls.Add(Me.chckFilters)
        Me.Controls.Add(Me.lblHeaderGeneral)
        Me.Controls.Add(Me.Splitter1a)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblStartScreen)
        Me.Controls.Add(Me.imgOpenFolder)
        Me.Controls.Add(Me.rdioAutoProxy)
        Me.Controls.Add(Me.lblDbDir)
        Me.Controls.Add(Me.Splitter1b)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSettings"
        Me.cmboBoxStartScreenPanel.ResumeLayout(False)
        Me.cmboBoxWatchedMoviesPanel.ResumeLayout(False)
        CType(Me.imgOpenFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblComingSoon As Label
    Friend WithEvents lblSucessText As CButtonLib.CButton
    Friend WithEvents Splitter1g As Label
    Friend WithEvents btnResetAllDatabases As CButtonLib.CButton
    Friend WithEvents btnResetSettings As CButtonLib.CButton
    Friend WithEvents btnSaveSettings As CButtonLib.CButton
    Friend WithEvents chckCelebr8 As CheckBox
    Friend WithEvents chckBackupDb As CheckBox
    Friend WithEvents txtDbDir As TextBox
    Friend WithEvents txtDbDirBg As CButtonLib.CButton
    Friend WithEvents chckRandomizeBtn As CheckBox
    Friend WithEvents chckAutoUpdate As CheckBox
    Friend WithEvents lblHeaderMisc As Label
    Friend WithEvents Splitter1f As Label
    Friend WithEvents lblHeaderDb As Label
    Friend WithEvents Splitter1d As Label
    Friend WithEvents chckWatchList As CheckBox
    Friend WithEvents lblSettingsFeatures As Label
    Friend WithEvents Splitter1c As Label
    Friend WithEvents chckPlayFullscr As CheckBox
    Friend WithEvents lblHeaderPlayBck As Label
    Friend WithEvents cmboBoxStartScreenPanel As Panel
    Friend WithEvents cmboTxtStartScreen As CButtonLib.CButton
    Friend WithEvents cmboboxStartScreen As ComboBox
    Friend WithEvents cmboBoxWatchedMoviesPanel As Panel
    Friend WithEvents cmboTxtWatchedMovies As CButtonLib.CButton
    Friend WithEvents cmboboxWatchedMovies As ComboBox
    Friend WithEvents chckFilters As CheckBox
    Friend WithEvents lblHeaderGeneral As Label
    Friend WithEvents Splitter1a As Label
    Friend WithEvents lblWatchedMovies As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents lblStartScreen As Label
    Friend WithEvents Splitter1b As Label
    Friend WithEvents imgOpenFolder As PictureBox
    Friend WithEvents lblDbDir As Label
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents lblHeaderConnection As Label
    Friend WithEvents Splitter1e As Label
    Friend WithEvents rdioAutoProxy As RadioButton
    Friend WithEvents rdioManualProxy As RadioButton
    Friend WithEvents txtProxyAddress As TextBox
    Friend WithEvents txtProxyAddressBg As CButtonLib.CButton
    Friend WithEvents lblProxyAddress As Label
    Friend WithEvents txtProxyPort As TextBox
    Friend WithEvents txtProxyPortBg As CButtonLib.CButton
    Friend WithEvents lblProxyPort As Label
    Friend WithEvents txtProxyPassword As TextBox
    Friend WithEvents txtProxyPasswordBg As CButtonLib.CButton
    Friend WithEvents lblProxyPassword As Label
    Friend WithEvents txtProxyUsername As TextBox
    Friend WithEvents txtProxyUsernameBg As CButtonLib.CButton
    Friend WithEvents lblProxyUsername As Label
    Friend WithEvents btnDbExport As CButtonLib.CButton
    Friend WithEvents MeClose As PictureBox
    Friend WithEvents lblStillBeta As Label
    Friend WithEvents chkAlwaysOnTop As CheckBox
    Friend WithEvents chkShowRating As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkShowMovieQuality As CheckBox
    Friend WithEvents Label2 As Label
End Class
