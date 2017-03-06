<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.lblHeaderChangelog = New System.Windows.Forms.Label()
        Me.lblTabAbout = New System.Windows.Forms.Label()
        Me.lblTabChangelog = New System.Windows.Forms.Label()
        Me.lblTabFAQ = New System.Windows.Forms.Label()
        Me.lblTabContact = New System.Windows.Forms.Label()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.lblAboutDevs = New System.Windows.Forms.Label()
        Me.lblAboutVersion = New System.Windows.Forms.Label()
        Me.imgDataProvider = New System.Windows.Forms.PictureBox()
        Me.lblAboutSubHeader2 = New System.Windows.Forms.Label()
        Me.lblAboutSubHeader1 = New System.Windows.Forms.Label()
        Me.AboutSubText = New System.Windows.Forms.Label()
        Me.lblHeaderAbout = New System.Windows.Forms.Label()
        Me.panelHelpGrowSocial = New System.Windows.Forms.Panel()
        Me.btnShareTwitter = New CButtonLib.CButton()
        Me.btnShareFacebook = New CButtonLib.CButton()
        Me.tabLegal = New System.Windows.Forms.TabPage()
        Me.lblLegalText = New System.Windows.Forms.Label()
        Me.lblHeaderLegal = New System.Windows.Forms.Label()
        Me.tabHelpFaq = New System.Windows.Forms.TabPage()
        Me.qHeader0 = New System.Windows.Forms.Label()
        Me.qSub0 = New System.Windows.Forms.Label()
        Me.Splitter1aa = New System.Windows.Forms.Label()
        Me.qHeader4 = New System.Windows.Forms.Label()
        Me.qHeader3 = New System.Windows.Forms.Label()
        Me.qHeader2 = New System.Windows.Forms.Label()
        Me.Splitter1d = New System.Windows.Forms.Label()
        Me.qSub4 = New System.Windows.Forms.Label()
        Me.Splitter1c = New System.Windows.Forms.Label()
        Me.qSub3 = New System.Windows.Forms.Label()
        Me.Splitter1b = New System.Windows.Forms.Label()
        Me.qSub2 = New System.Windows.Forms.Label()
        Me.lblHeaderHelpFaq = New System.Windows.Forms.Label()
        Me.tabChangelog = New System.Windows.Forms.TabPage()
        Me.lblChangelogFull = New System.Windows.Forms.Label()
        Me.tabContact = New System.Windows.Forms.TabPage()
        Me.lblMessageSent = New CButtonLib.CButton()
        Me.txtFormEmail = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.txtFormMessage = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.panelContactUs = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblEmailUsAt = New System.Windows.Forms.Label()
        Me.lblSocialEmail = New System.Windows.Forms.Label()
        Me.lblVisitUsOn1 = New System.Windows.Forms.Label()
        Me.lblSocialSourceForge = New System.Windows.Forms.Label()
        Me.lblVisitUsOn2 = New System.Windows.Forms.Label()
        Me.lblSocialTwitter = New System.Windows.Forms.Label()
        Me.Splitter2a = New CButtonLib.CButton()
        Me.btnFormSubmit = New CButtonLib.CButton()
        Me.lblHeaderContact = New System.Windows.Forms.Label()
        Me.lblSubContact = New System.Windows.Forms.Label()
        Me.txtFormMessageBG = New CButtonLib.CButton()
        Me.txtFormEmailBG = New CButtonLib.CButton()
        Me.panelTopHeaders = New System.Windows.Forms.Panel()
        Me.lblTabLegal = New System.Windows.Forms.Label()
        Me.meClose = New System.Windows.Forms.PictureBox()
        Me.timerHideMessageSent = New System.Windows.Forms.Timer(Me.components)
        Me.Tab.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        CType(Me.imgDataProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelHelpGrowSocial.SuspendLayout()
        Me.tabLegal.SuspendLayout()
        Me.tabHelpFaq.SuspendLayout()
        Me.tabChangelog.SuspendLayout()
        Me.tabContact.SuspendLayout()
        Me.panelContactUs.SuspendLayout()
        Me.panelTopHeaders.SuspendLayout()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderChangelog
        '
        Me.lblHeaderChangelog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderChangelog.AutoSize = True
        Me.lblHeaderChangelog.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeaderChangelog.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderChangelog.ForeColor = System.Drawing.Color.White
        Me.lblHeaderChangelog.Location = New System.Drawing.Point(371, 126)
        Me.lblHeaderChangelog.Name = "lblHeaderChangelog"
        Me.lblHeaderChangelog.Size = New System.Drawing.Size(266, 45)
        Me.lblHeaderChangelog.TabIndex = 1050
        Me.lblHeaderChangelog.Text = "Release Changes"
        '
        'lblTabAbout
        '
        Me.lblTabAbout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTabAbout.AutoSize = True
        Me.lblTabAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTabAbout.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTabAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblTabAbout.Location = New System.Drawing.Point(197, 14)
        Me.lblTabAbout.Name = "lblTabAbout"
        Me.lblTabAbout.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTabAbout.Size = New System.Drawing.Size(94, 30)
        Me.lblTabAbout.TabIndex = 1051
        Me.lblTabAbout.Text = "ABOUT"
        '
        'lblTabChangelog
        '
        Me.lblTabChangelog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTabChangelog.AutoSize = True
        Me.lblTabChangelog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTabChangelog.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTabChangelog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTabChangelog.Location = New System.Drawing.Point(519, 14)
        Me.lblTabChangelog.Name = "lblTabChangelog"
        Me.lblTabChangelog.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTabChangelog.Size = New System.Drawing.Size(151, 30)
        Me.lblTabChangelog.TabIndex = 1052
        Me.lblTabChangelog.Text = "CHANGELOG"
        '
        'lblTabFAQ
        '
        Me.lblTabFAQ.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTabFAQ.AutoSize = True
        Me.lblTabFAQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTabFAQ.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTabFAQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTabFAQ.Location = New System.Drawing.Point(297, 14)
        Me.lblTabFAQ.Name = "lblTabFAQ"
        Me.lblTabFAQ.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTabFAQ.Size = New System.Drawing.Size(124, 30)
        Me.lblTabFAQ.TabIndex = 1053
        Me.lblTabFAQ.Text = "HELP/FAQ"
        '
        'lblTabContact
        '
        Me.lblTabContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTabContact.AutoSize = True
        Me.lblTabContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTabContact.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTabContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTabContact.Location = New System.Drawing.Point(676, 14)
        Me.lblTabContact.Name = "lblTabContact"
        Me.lblTabContact.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTabContact.Size = New System.Drawing.Size(120, 30)
        Me.lblTabContact.TabIndex = 1054
        Me.lblTabContact.Text = "CONTACT"
        '
        'Tab
        '
        Me.Tab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.Controls.Add(Me.tabAbout)
        Me.Tab.Controls.Add(Me.tabLegal)
        Me.Tab.Controls.Add(Me.tabHelpFaq)
        Me.Tab.Controls.Add(Me.tabChangelog)
        Me.Tab.Controls.Add(Me.tabContact)
        Me.Tab.Location = New System.Drawing.Point(-23, -4)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1036, 569)
        Me.Tab.TabIndex = 1055
        '
        'tabAbout
        '
        Me.tabAbout.AutoScroll = True
        Me.tabAbout.AutoScrollMargin = New System.Drawing.Size(20, 70)
        Me.tabAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabAbout.Controls.Add(Me.lblAboutDevs)
        Me.tabAbout.Controls.Add(Me.lblAboutVersion)
        Me.tabAbout.Controls.Add(Me.imgDataProvider)
        Me.tabAbout.Controls.Add(Me.lblAboutSubHeader2)
        Me.tabAbout.Controls.Add(Me.lblAboutSubHeader1)
        Me.tabAbout.Controls.Add(Me.AboutSubText)
        Me.tabAbout.Controls.Add(Me.lblHeaderAbout)
        Me.tabAbout.Controls.Add(Me.panelHelpGrowSocial)
        Me.tabAbout.Location = New System.Drawing.Point(23, 4)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(1009, 561)
        Me.tabAbout.TabIndex = 1
        Me.tabAbout.Text = "ABOUT"
        '
        'lblAboutDevs
        '
        Me.lblAboutDevs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAboutDevs.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAboutDevs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblAboutDevs.Location = New System.Drawing.Point(211, 758)
        Me.lblAboutDevs.Name = "lblAboutDevs"
        Me.lblAboutDevs.Size = New System.Drawing.Size(570, 20)
        Me.lblAboutDevs.TabIndex = 1093
        Me.lblAboutDevs.Text = "freeware made by developers from around the world"
        Me.lblAboutDevs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAboutVersion
        '
        Me.lblAboutVersion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAboutVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAboutVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblAboutVersion.Location = New System.Drawing.Point(328, 784)
        Me.lblAboutVersion.Name = "lblAboutVersion"
        Me.lblAboutVersion.Size = New System.Drawing.Size(341, 20)
        Me.lblAboutVersion.TabIndex = 1092
        Me.lblAboutVersion.Text = "version"
        Me.lblAboutVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgDataProvider
        '
        Me.imgDataProvider.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgDataProvider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgDataProvider.Image = Global.Movieo.My.Resources.Resources.themoviedb_org
        Me.imgDataProvider.Location = New System.Drawing.Point(311, 640)
        Me.imgDataProvider.Name = "imgDataProvider"
        Me.imgDataProvider.Size = New System.Drawing.Size(355, 69)
        Me.imgDataProvider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDataProvider.TabIndex = 1088
        Me.imgDataProvider.TabStop = False
        '
        'lblAboutSubHeader2
        '
        Me.lblAboutSubHeader2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAboutSubHeader2.AutoSize = True
        Me.lblAboutSubHeader2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutSubHeader2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblAboutSubHeader2.Location = New System.Drawing.Point(123, 606)
        Me.lblAboutSubHeader2.MaximumSize = New System.Drawing.Size(730, 0)
        Me.lblAboutSubHeader2.MinimumSize = New System.Drawing.Size(730, 0)
        Me.lblAboutSubHeader2.Name = "lblAboutSubHeader2"
        Me.lblAboutSubHeader2.Size = New System.Drawing.Size(730, 30)
        Me.lblAboutSubHeader2.TabIndex = 1087
        Me.lblAboutSubHeader2.Text = "CORE DATA PROVIDER"
        Me.lblAboutSubHeader2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAboutSubHeader1
        '
        Me.lblAboutSubHeader1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAboutSubHeader1.AutoSize = True
        Me.lblAboutSubHeader1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutSubHeader1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblAboutSubHeader1.Location = New System.Drawing.Point(123, 469)
        Me.lblAboutSubHeader1.MaximumSize = New System.Drawing.Size(730, 0)
        Me.lblAboutSubHeader1.MinimumSize = New System.Drawing.Size(730, 0)
        Me.lblAboutSubHeader1.Name = "lblAboutSubHeader1"
        Me.lblAboutSubHeader1.Size = New System.Drawing.Size(730, 30)
        Me.lblAboutSubHeader1.TabIndex = 1086
        Me.lblAboutSubHeader1.Text = "HELP US GROW"
        Me.lblAboutSubHeader1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AboutSubText
        '
        Me.AboutSubText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AboutSubText.AutoSize = True
        Me.AboutSubText.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.AboutSubText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.AboutSubText.Location = New System.Drawing.Point(123, 190)
        Me.AboutSubText.MaximumSize = New System.Drawing.Size(730, 0)
        Me.AboutSubText.MinimumSize = New System.Drawing.Size(730, 0)
        Me.AboutSubText.Name = "AboutSubText"
        Me.AboutSubText.Size = New System.Drawing.Size(730, 225)
        Me.AboutSubText.TabIndex = 1085
        Me.AboutSubText.Text = resources.GetString("AboutSubText.Text")
        '
        'lblHeaderAbout
        '
        Me.lblHeaderAbout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderAbout.AutoSize = True
        Me.lblHeaderAbout.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeaderAbout.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderAbout.ForeColor = System.Drawing.Color.White
        Me.lblHeaderAbout.Location = New System.Drawing.Point(354, 126)
        Me.lblHeaderAbout.Name = "lblHeaderAbout"
        Me.lblHeaderAbout.Size = New System.Drawing.Size(269, 45)
        Me.lblHeaderAbout.TabIndex = 1083
        Me.lblHeaderAbout.Text = "What is Movieo?"
        '
        'panelHelpGrowSocial
        '
        Me.panelHelpGrowSocial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelHelpGrowSocial.Controls.Add(Me.btnShareTwitter)
        Me.panelHelpGrowSocial.Controls.Add(Me.btnShareFacebook)
        Me.panelHelpGrowSocial.Location = New System.Drawing.Point(306, 504)
        Me.panelHelpGrowSocial.Name = "panelHelpGrowSocial"
        Me.panelHelpGrowSocial.Size = New System.Drawing.Size(364, 50)
        Me.panelHelpGrowSocial.TabIndex = 1091
        '
        'btnShareTwitter
        '
        Me.btnShareTwitter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnShareTwitter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnShareTwitter.BorderShow = False
        Me.btnShareTwitter.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnShareTwitter.Corners.All = 2
        Me.btnShareTwitter.Corners.LowerLeft = 2
        Me.btnShareTwitter.Corners.LowerRight = 2
        Me.btnShareTwitter.Corners.UpperLeft = 2
        Me.btnShareTwitter.Corners.UpperRight = 2
        Me.btnShareTwitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShareTwitter.DesignerSelected = False
        Me.btnShareTwitter.DimFactorClick = -26
        Me.btnShareTwitter.DimFactorHover = 14
        Me.btnShareTwitter.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnShareTwitter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShareTwitter.ImageIndex = 0
        Me.btnShareTwitter.Location = New System.Drawing.Point(193, 13)
        Me.btnShareTwitter.Name = "btnShareTwitter"
        Me.btnShareTwitter.ShowFocus = CButtonLib.CButton.eFocus.[Dim]
        Me.btnShareTwitter.SideImage = Global.Movieo.My.Resources.Resources.twitterLogo
        Me.btnShareTwitter.SideImageSize = New System.Drawing.Size(32, 23)
        Me.btnShareTwitter.Size = New System.Drawing.Size(162, 34)
        Me.btnShareTwitter.TabIndex = 1090
        Me.btnShareTwitter.Text = "       Share on Twitter"
        Me.btnShareTwitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShareTwitter.TextShadowShow = False
        '
        'btnShareFacebook
        '
        Me.btnShareFacebook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnShareFacebook.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnShareFacebook.BorderShow = False
        Me.btnShareFacebook.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnShareFacebook.Corners.All = 2
        Me.btnShareFacebook.Corners.LowerLeft = 2
        Me.btnShareFacebook.Corners.LowerRight = 2
        Me.btnShareFacebook.Corners.UpperLeft = 2
        Me.btnShareFacebook.Corners.UpperRight = 2
        Me.btnShareFacebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShareFacebook.DesignerSelected = False
        Me.btnShareFacebook.DimFactorClick = -26
        Me.btnShareFacebook.DimFactorHover = 14
        Me.btnShareFacebook.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnShareFacebook.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShareFacebook.ImageIndex = 0
        Me.btnShareFacebook.Location = New System.Drawing.Point(9, 13)
        Me.btnShareFacebook.Name = "btnShareFacebook"
        Me.btnShareFacebook.ShowFocus = CButtonLib.CButton.eFocus.[Dim]
        Me.btnShareFacebook.SideImage = Global.Movieo.My.Resources.Resources.FacebookLogo
        Me.btnShareFacebook.SideImageSize = New System.Drawing.Size(32, 23)
        Me.btnShareFacebook.Size = New System.Drawing.Size(170, 34)
        Me.btnShareFacebook.TabIndex = 1089
        Me.btnShareFacebook.Text = "      Share on Facebook"
        Me.btnShareFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShareFacebook.TextShadowShow = False
        '
        'tabLegal
        '
        Me.tabLegal.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabLegal.Controls.Add(Me.lblLegalText)
        Me.tabLegal.Controls.Add(Me.lblHeaderLegal)
        Me.tabLegal.Location = New System.Drawing.Point(23, 4)
        Me.tabLegal.Name = "tabLegal"
        Me.tabLegal.Size = New System.Drawing.Size(1009, 561)
        Me.tabLegal.TabIndex = 4
        Me.tabLegal.Text = "LEGAL"
        '
        'lblLegalText
        '
        Me.lblLegalText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLegalText.AutoSize = True
        Me.lblLegalText.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblLegalText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblLegalText.Location = New System.Drawing.Point(114, 190)
        Me.lblLegalText.MaximumSize = New System.Drawing.Size(780, 0)
        Me.lblLegalText.MinimumSize = New System.Drawing.Size(780, 0)
        Me.lblLegalText.Name = "lblLegalText"
        Me.lblLegalText.Size = New System.Drawing.Size(780, 107)
        Me.lblLegalText.TabIndex = 1088
        Me.lblLegalText.Text = resources.GetString("lblLegalText.Text")
        Me.lblLegalText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblLegalText.UseCompatibleTextRendering = True
        '
        'lblHeaderLegal
        '
        Me.lblHeaderLegal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderLegal.AutoSize = True
        Me.lblHeaderLegal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeaderLegal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderLegal.ForeColor = System.Drawing.Color.White
        Me.lblHeaderLegal.Location = New System.Drawing.Point(330, 126)
        Me.lblHeaderLegal.Name = "lblHeaderLegal"
        Me.lblHeaderLegal.Size = New System.Drawing.Size(349, 45)
        Me.lblHeaderLegal.TabIndex = 1086
        Me.lblHeaderLegal.Text = "Legal Side of Things..."
        '
        'tabHelpFaq
        '
        Me.tabHelpFaq.AutoScroll = True
        Me.tabHelpFaq.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.tabHelpFaq.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabHelpFaq.Controls.Add(Me.qHeader0)
        Me.tabHelpFaq.Controls.Add(Me.qSub0)
        Me.tabHelpFaq.Controls.Add(Me.Splitter1aa)
        Me.tabHelpFaq.Controls.Add(Me.qHeader4)
        Me.tabHelpFaq.Controls.Add(Me.qHeader3)
        Me.tabHelpFaq.Controls.Add(Me.qHeader2)
        Me.tabHelpFaq.Controls.Add(Me.Splitter1d)
        Me.tabHelpFaq.Controls.Add(Me.qSub4)
        Me.tabHelpFaq.Controls.Add(Me.Splitter1c)
        Me.tabHelpFaq.Controls.Add(Me.qSub3)
        Me.tabHelpFaq.Controls.Add(Me.Splitter1b)
        Me.tabHelpFaq.Controls.Add(Me.qSub2)
        Me.tabHelpFaq.Controls.Add(Me.lblHeaderHelpFaq)
        Me.tabHelpFaq.Location = New System.Drawing.Point(23, 4)
        Me.tabHelpFaq.Name = "tabHelpFaq"
        Me.tabHelpFaq.Size = New System.Drawing.Size(1009, 561)
        Me.tabHelpFaq.TabIndex = 2
        Me.tabHelpFaq.Text = "HELP/FAQ"
        '
        'qHeader0
        '
        Me.qHeader0.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qHeader0.AutoSize = True
        Me.qHeader0.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.qHeader0.ForeColor = System.Drawing.Color.White
        Me.qHeader0.Location = New System.Drawing.Point(113, 233)
        Me.qHeader0.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qHeader0.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qHeader0.Name = "qHeader0"
        Me.qHeader0.Size = New System.Drawing.Size(750, 32)
        Me.qHeader0.TabIndex = 1065
        Me.qHeader0.Text = "Read me first!"
        '
        'qSub0
        '
        Me.qSub0.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qSub0.AutoSize = True
        Me.qSub0.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.qSub0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qSub0.Location = New System.Drawing.Point(113, 263)
        Me.qSub0.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qSub0.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qSub0.Name = "qSub0"
        Me.qSub0.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.qSub0.Size = New System.Drawing.Size(750, 185)
        Me.qSub0.TabIndex = 1067
        Me.qSub0.Text = resources.GetString("qSub0.Text")
        '
        'Splitter1aa
        '
        Me.Splitter1aa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1aa.AutoSize = True
        Me.Splitter1aa.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1aa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1aa.Location = New System.Drawing.Point(113, 182)
        Me.Splitter1aa.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1aa.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1aa.Name = "Splitter1aa"
        Me.Splitter1aa.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1aa.TabIndex = 1066
        Me.Splitter1aa.Text = "-------------------------------------------------------------------------"
        '
        'qHeader4
        '
        Me.qHeader4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qHeader4.AutoSize = True
        Me.qHeader4.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.qHeader4.ForeColor = System.Drawing.Color.White
        Me.qHeader4.Location = New System.Drawing.Point(113, 959)
        Me.qHeader4.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qHeader4.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qHeader4.Name = "qHeader4"
        Me.qHeader4.Size = New System.Drawing.Size(750, 32)
        Me.qHeader4.TabIndex = 1062
        Me.qHeader4.Text = "Can I suggest a movie?"
        '
        'qHeader3
        '
        Me.qHeader3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qHeader3.AutoSize = True
        Me.qHeader3.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.qHeader3.ForeColor = System.Drawing.Color.White
        Me.qHeader3.Location = New System.Drawing.Point(113, 769)
        Me.qHeader3.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qHeader3.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qHeader3.Name = "qHeader3"
        Me.qHeader3.Size = New System.Drawing.Size(750, 32)
        Me.qHeader3.TabIndex = 1059
        Me.qHeader3.Text = "Why can't I open Movieo"
        '
        'qHeader2
        '
        Me.qHeader2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qHeader2.AutoSize = True
        Me.qHeader2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.qHeader2.ForeColor = System.Drawing.Color.White
        Me.qHeader2.Location = New System.Drawing.Point(113, 526)
        Me.qHeader2.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qHeader2.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qHeader2.Name = "qHeader2"
        Me.qHeader2.Size = New System.Drawing.Size(750, 32)
        Me.qHeader2.TabIndex = 1056
        Me.qHeader2.Text = "I'm having some issues..."
        '
        'Splitter1d
        '
        Me.Splitter1d.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1d.AutoSize = True
        Me.Splitter1d.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1d.Location = New System.Drawing.Point(113, 904)
        Me.Splitter1d.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1d.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1d.Name = "Splitter1d"
        Me.Splitter1d.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1d.TabIndex = 1064
        Me.Splitter1d.Text = "-------------------------------------------------------------------------"
        '
        'qSub4
        '
        Me.qSub4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qSub4.AutoSize = True
        Me.qSub4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.qSub4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qSub4.Location = New System.Drawing.Point(113, 989)
        Me.qSub4.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qSub4.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qSub4.Name = "qSub4"
        Me.qSub4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.qSub4.Size = New System.Drawing.Size(750, 110)
        Me.qSub4.TabIndex = 1063
        Me.qSub4.Text = resources.GetString("qSub4.Text")
        '
        'Splitter1c
        '
        Me.Splitter1c.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1c.AutoSize = True
        Me.Splitter1c.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1c.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1c.Location = New System.Drawing.Point(113, 714)
        Me.Splitter1c.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1c.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1c.Name = "Splitter1c"
        Me.Splitter1c.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1c.TabIndex = 1061
        Me.Splitter1c.Text = "-------------------------------------------------------------------------"
        '
        'qSub3
        '
        Me.qSub3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qSub3.AutoSize = True
        Me.qSub3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.qSub3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qSub3.Location = New System.Drawing.Point(113, 799)
        Me.qSub3.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qSub3.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qSub3.Name = "qSub3"
        Me.qSub3.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.qSub3.Size = New System.Drawing.Size(750, 85)
        Me.qSub3.TabIndex = 1060
        Me.qSub3.Text = resources.GetString("qSub3.Text")
        '
        'Splitter1b
        '
        Me.Splitter1b.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1b.AutoSize = True
        Me.Splitter1b.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1b.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1b.Location = New System.Drawing.Point(113, 470)
        Me.Splitter1b.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1b.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1b.Name = "Splitter1b"
        Me.Splitter1b.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1b.TabIndex = 1058
        Me.Splitter1b.Text = "-------------------------------------------------------------------------"
        '
        'qSub2
        '
        Me.qSub2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qSub2.AutoSize = True
        Me.qSub2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.qSub2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qSub2.Location = New System.Drawing.Point(113, 556)
        Me.qSub2.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qSub2.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qSub2.Name = "qSub2"
        Me.qSub2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.qSub2.Size = New System.Drawing.Size(750, 135)
        Me.qSub2.TabIndex = 1057
        Me.qSub2.Text = resources.GetString("qSub2.Text")
        '
        'lblHeaderHelpFaq
        '
        Me.lblHeaderHelpFaq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderHelpFaq.AutoSize = True
        Me.lblHeaderHelpFaq.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeaderHelpFaq.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderHelpFaq.ForeColor = System.Drawing.Color.White
        Me.lblHeaderHelpFaq.Location = New System.Drawing.Point(275, 126)
        Me.lblHeaderHelpFaq.Name = "lblHeaderHelpFaq"
        Me.lblHeaderHelpFaq.Size = New System.Drawing.Size(427, 45)
        Me.lblHeaderHelpFaq.TabIndex = 1052
        Me.lblHeaderHelpFaq.Text = "Help && Frequent Questions"
        '
        'tabChangelog
        '
        Me.tabChangelog.AutoScroll = True
        Me.tabChangelog.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.tabChangelog.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabChangelog.Controls.Add(Me.lblChangelogFull)
        Me.tabChangelog.Controls.Add(Me.lblHeaderChangelog)
        Me.tabChangelog.Location = New System.Drawing.Point(23, 4)
        Me.tabChangelog.Name = "tabChangelog"
        Me.tabChangelog.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChangelog.Size = New System.Drawing.Size(1009, 561)
        Me.tabChangelog.TabIndex = 0
        Me.tabChangelog.Text = "CHANGELOG"
        '
        'lblChangelogFull
        '
        Me.lblChangelogFull.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblChangelogFull.AutoSize = True
        Me.lblChangelogFull.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblChangelogFull.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblChangelogFull.Location = New System.Drawing.Point(114, 190)
        Me.lblChangelogFull.MaximumSize = New System.Drawing.Size(780, 0)
        Me.lblChangelogFull.MinimumSize = New System.Drawing.Size(780, 0)
        Me.lblChangelogFull.Name = "lblChangelogFull"
        Me.lblChangelogFull.Size = New System.Drawing.Size(780, 31)
        Me.lblChangelogFull.TabIndex = 1051
        Me.lblChangelogFull.Text = "Changelog text..."
        Me.lblChangelogFull.UseCompatibleTextRendering = True
        '
        'tabContact
        '
        Me.tabContact.AutoScroll = True
        Me.tabContact.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.tabContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabContact.Controls.Add(Me.lblMessageSent)
        Me.tabContact.Controls.Add(Me.txtFormEmail)
        Me.tabContact.Controls.Add(Me.txtFormMessage)
        Me.tabContact.Controls.Add(Me.panelContactUs)
        Me.tabContact.Controls.Add(Me.Splitter2a)
        Me.tabContact.Controls.Add(Me.btnFormSubmit)
        Me.tabContact.Controls.Add(Me.lblHeaderContact)
        Me.tabContact.Controls.Add(Me.lblSubContact)
        Me.tabContact.Controls.Add(Me.txtFormMessageBG)
        Me.tabContact.Controls.Add(Me.txtFormEmailBG)
        Me.tabContact.Location = New System.Drawing.Point(23, 4)
        Me.tabContact.Name = "tabContact"
        Me.tabContact.Size = New System.Drawing.Size(1009, 561)
        Me.tabContact.TabIndex = 3
        Me.tabContact.Text = "CONTACT"
        '
        'lblMessageSent
        '
        Me.lblMessageSent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMessageSent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblMessageSent.ColorFillSolid = System.Drawing.Color.Transparent
        Me.lblMessageSent.Corners.All = 2
        Me.lblMessageSent.Corners.LowerLeft = 2
        Me.lblMessageSent.Corners.LowerRight = 2
        Me.lblMessageSent.Corners.UpperLeft = 2
        Me.lblMessageSent.Corners.UpperRight = 2
        Me.lblMessageSent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMessageSent.DesignerSelected = False
        Me.lblMessageSent.DimFactorClick = 0
        Me.lblMessageSent.DimFactorHover = 0
        Me.lblMessageSent.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblMessageSent.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!)
        Me.lblMessageSent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblMessageSent.ImageIndex = 0
        Me.lblMessageSent.Location = New System.Drawing.Point(330, 57)
        Me.lblMessageSent.Name = "lblMessageSent"
        Me.lblMessageSent.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblMessageSent.Size = New System.Drawing.Size(284, 35)
        Me.lblMessageSent.TabIndex = 100000
        Me.lblMessageSent.TabStop = False
        Me.lblMessageSent.Text = "Message sent! Thank you so much ❤"
        Me.lblMessageSent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblMessageSent.TextMargin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.lblMessageSent.TextShadowShow = False
        Me.lblMessageSent.Visible = False
        '
        'txtFormEmail
        '
        Me.txtFormEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFormEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFormEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFormEmail.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtFormEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFormEmail.Location = New System.Drawing.Point(217, 469)
        Me.txtFormEmail.MaxLength = 75
        Me.txtFormEmail.Name = "txtFormEmail"
        Me.txtFormEmail.Size = New System.Drawing.Size(511, 23)
        Me.txtFormEmail.TabIndex = 3
        Me.txtFormEmail.WaterMark = "Your email"
        Me.txtFormEmail.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFormEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtFormEmail.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'txtFormMessage
        '
        Me.txtFormMessage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFormMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFormMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFormMessage.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtFormMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFormMessage.Location = New System.Drawing.Point(217, 265)
        Me.txtFormMessage.MaxLength = 250
        Me.txtFormMessage.Multiline = True
        Me.txtFormMessage.Name = "txtFormMessage"
        Me.txtFormMessage.Size = New System.Drawing.Size(511, 180)
        Me.txtFormMessage.TabIndex = 2
        Me.txtFormMessage.WaterMark = "How can we help?"
        Me.txtFormMessage.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFormMessage.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtFormMessage.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'panelContactUs
        '
        Me.panelContactUs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelContactUs.Controls.Add(Me.lblEmailUsAt)
        Me.panelContactUs.Controls.Add(Me.lblSocialEmail)
        Me.panelContactUs.Controls.Add(Me.lblVisitUsOn1)
        Me.panelContactUs.Controls.Add(Me.lblSocialSourceForge)
        Me.panelContactUs.Controls.Add(Me.lblVisitUsOn2)
        Me.panelContactUs.Controls.Add(Me.lblSocialTwitter)
        Me.panelContactUs.Location = New System.Drawing.Point(205, 591)
        Me.panelContactUs.Name = "panelContactUs"
        Me.panelContactUs.Size = New System.Drawing.Size(535, 101)
        Me.panelContactUs.TabIndex = 1057
        '
        'lblEmailUsAt
        '
        Me.lblEmailUsAt.AutoSize = True
        Me.lblEmailUsAt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailUsAt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblEmailUsAt.Location = New System.Drawing.Point(0, 0)
        Me.lblEmailUsAt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEmailUsAt.Name = "lblEmailUsAt"
        Me.lblEmailUsAt.Size = New System.Drawing.Size(103, 25)
        Me.lblEmailUsAt.TabIndex = 99999
        Me.lblEmailUsAt.Text = "email us at"
        '
        'lblSocialEmail
        '
        Me.lblSocialEmail.AutoSize = True
        Me.lblSocialEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelContactUs.SetFlowBreak(Me.lblSocialEmail, True)
        Me.lblSocialEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocialEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSocialEmail.Location = New System.Drawing.Point(103, 0)
        Me.lblSocialEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSocialEmail.Name = "lblSocialEmail"
        Me.lblSocialEmail.Size = New System.Drawing.Size(152, 25)
        Me.lblSocialEmail.TabIndex = 5
        Me.lblSocialEmail.Text = "hi@movieo.at.vu"
        '
        'lblVisitUsOn1
        '
        Me.lblVisitUsOn1.AutoSize = True
        Me.lblVisitUsOn1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitUsOn1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblVisitUsOn1.Location = New System.Drawing.Point(0, 25)
        Me.lblVisitUsOn1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVisitUsOn1.Name = "lblVisitUsOn1"
        Me.lblVisitUsOn1.Size = New System.Drawing.Size(96, 25)
        Me.lblVisitUsOn1.TabIndex = 99999
        Me.lblVisitUsOn1.Text = "visit us on"
        '
        'lblSocialSourceForge
        '
        Me.lblSocialSourceForge.AutoSize = True
        Me.lblSocialSourceForge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelContactUs.SetFlowBreak(Me.lblSocialSourceForge, True)
        Me.lblSocialSourceForge.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocialSourceForge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblSocialSourceForge.Location = New System.Drawing.Point(96, 25)
        Me.lblSocialSourceForge.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSocialSourceForge.Name = "lblSocialSourceForge"
        Me.lblSocialSourceForge.Size = New System.Drawing.Size(118, 25)
        Me.lblSocialSourceForge.TabIndex = 6
        Me.lblSocialSourceForge.Text = "SourceForge"
        '
        'lblVisitUsOn2
        '
        Me.lblVisitUsOn2.AutoSize = True
        Me.lblVisitUsOn2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitUsOn2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblVisitUsOn2.Location = New System.Drawing.Point(0, 50)
        Me.lblVisitUsOn2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVisitUsOn2.Name = "lblVisitUsOn2"
        Me.lblVisitUsOn2.Size = New System.Drawing.Size(96, 25)
        Me.lblVisitUsOn2.TabIndex = 99999
        Me.lblVisitUsOn2.Text = "visit us on"
        '
        'lblSocialTwitter
        '
        Me.lblSocialTwitter.AutoSize = True
        Me.lblSocialTwitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelContactUs.SetFlowBreak(Me.lblSocialTwitter, True)
        Me.lblSocialTwitter.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocialTwitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lblSocialTwitter.Location = New System.Drawing.Point(96, 50)
        Me.lblSocialTwitter.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSocialTwitter.Name = "lblSocialTwitter"
        Me.lblSocialTwitter.Size = New System.Drawing.Size(69, 25)
        Me.lblSocialTwitter.TabIndex = 7
        Me.lblSocialTwitter.Text = "Twitter"
        '
        'Splitter2a
        '
        Me.Splitter2a.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter2a.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Splitter2a.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Splitter2a.Corners.All = 2
        Me.Splitter2a.Corners.LowerLeft = 2
        Me.Splitter2a.Corners.LowerRight = 2
        Me.Splitter2a.Corners.UpperLeft = 2
        Me.Splitter2a.Corners.UpperRight = 2
        Me.Splitter2a.DesignerSelected = False
        Me.Splitter2a.DimFactorClick = 0
        Me.Splitter2a.DimFactorHover = 0
        Me.Splitter2a.FillType = CButtonLib.CButton.eFillType.Solid
        Me.Splitter2a.ImageIndex = 0
        Me.Splitter2a.Location = New System.Drawing.Point(210, 571)
        Me.Splitter2a.Name = "Splitter2a"
        Me.Splitter2a.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.Splitter2a.Size = New System.Drawing.Size(525, 1)
        Me.Splitter2a.TabIndex = 99999
        Me.Splitter2a.TabStop = False
        Me.Splitter2a.Text = ""
        '
        'btnFormSubmit
        '
        Me.btnFormSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFormSubmit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnFormSubmit.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnFormSubmit.Corners.All = 2
        Me.btnFormSubmit.Corners.LowerLeft = 2
        Me.btnFormSubmit.Corners.LowerRight = 2
        Me.btnFormSubmit.Corners.UpperLeft = 2
        Me.btnFormSubmit.Corners.UpperRight = 2
        Me.btnFormSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormSubmit.DesignerSelected = False
        Me.btnFormSubmit.DimFactorClick = 0
        Me.btnFormSubmit.DimFactorHover = 0
        Me.btnFormSubmit.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnFormSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnFormSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnFormSubmit.ImageIndex = 0
        Me.btnFormSubmit.Location = New System.Drawing.Point(555, 509)
        Me.btnFormSubmit.Name = "btnFormSubmit"
        Me.btnFormSubmit.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnFormSubmit.Size = New System.Drawing.Size(180, 37)
        Me.btnFormSubmit.TabIndex = 4
        Me.btnFormSubmit.Text = "Send to hi@movieo.at.vu"
        Me.btnFormSubmit.TextShadowShow = False
        '
        'lblHeaderContact
        '
        Me.lblHeaderContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderContact.AutoSize = True
        Me.lblHeaderContact.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeaderContact.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderContact.ForeColor = System.Drawing.Color.White
        Me.lblHeaderContact.Location = New System.Drawing.Point(368, 126)
        Me.lblHeaderContact.Name = "lblHeaderContact"
        Me.lblHeaderContact.Size = New System.Drawing.Size(208, 45)
        Me.lblHeaderContact.TabIndex = 99999
        Me.lblHeaderContact.Text = "Get In Touch"
        '
        'lblSubContact
        '
        Me.lblSubContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubContact.AutoSize = True
        Me.lblSubContact.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblSubContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSubContact.Location = New System.Drawing.Point(107, 190)
        Me.lblSubContact.MaximumSize = New System.Drawing.Size(730, 0)
        Me.lblSubContact.MinimumSize = New System.Drawing.Size(730, 0)
        Me.lblSubContact.Name = "lblSubContact"
        Me.lblSubContact.Size = New System.Drawing.Size(730, 50)
        Me.lblSubContact.TabIndex = 1
        Me.lblSubContact.Text = "Question? Problem? Movie suggestion? Every" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "piece of feedback is welcome ^.^"
        Me.lblSubContact.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFormMessageBG
        '
        Me.txtFormMessageBG.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFormMessageBG.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.txtFormMessageBG.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtFormMessageBG.Corners.All = 2
        Me.txtFormMessageBG.Corners.LowerLeft = 2
        Me.txtFormMessageBG.Corners.LowerRight = 2
        Me.txtFormMessageBG.Corners.UpperLeft = 2
        Me.txtFormMessageBG.Corners.UpperRight = 2
        Me.txtFormMessageBG.DesignerSelected = False
        Me.txtFormMessageBG.DimFactorClick = 0
        Me.txtFormMessageBG.DimFactorHover = 0
        Me.txtFormMessageBG.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtFormMessageBG.ImageIndex = 0
        Me.txtFormMessageBG.Location = New System.Drawing.Point(210, 259)
        Me.txtFormMessageBG.Name = "txtFormMessageBG"
        Me.txtFormMessageBG.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtFormMessageBG.Size = New System.Drawing.Size(525, 195)
        Me.txtFormMessageBG.TabIndex = 99999
        Me.txtFormMessageBG.Text = ""
        '
        'txtFormEmailBG
        '
        Me.txtFormEmailBG.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFormEmailBG.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.txtFormEmailBG.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtFormEmailBG.Corners.All = 2
        Me.txtFormEmailBG.Corners.LowerLeft = 2
        Me.txtFormEmailBG.Corners.LowerRight = 2
        Me.txtFormEmailBG.Corners.UpperLeft = 2
        Me.txtFormEmailBG.Corners.UpperRight = 2
        Me.txtFormEmailBG.DesignerSelected = False
        Me.txtFormEmailBG.DimFactorClick = 0
        Me.txtFormEmailBG.DimFactorHover = 0
        Me.txtFormEmailBG.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtFormEmailBG.ImageIndex = 0
        Me.txtFormEmailBG.Location = New System.Drawing.Point(210, 463)
        Me.txtFormEmailBG.Name = "txtFormEmailBG"
        Me.txtFormEmailBG.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtFormEmailBG.Size = New System.Drawing.Size(525, 37)
        Me.txtFormEmailBG.TabIndex = 99999
        Me.txtFormEmailBG.Text = ""
        '
        'panelTopHeaders
        '
        Me.panelTopHeaders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTopHeaders.Controls.Add(Me.lblTabLegal)
        Me.panelTopHeaders.Controls.Add(Me.meClose)
        Me.panelTopHeaders.Controls.Add(Me.lblTabAbout)
        Me.panelTopHeaders.Controls.Add(Me.lblTabContact)
        Me.panelTopHeaders.Controls.Add(Me.lblTabChangelog)
        Me.panelTopHeaders.Controls.Add(Me.lblTabFAQ)
        Me.panelTopHeaders.Location = New System.Drawing.Point(0, -1)
        Me.panelTopHeaders.Name = "panelTopHeaders"
        Me.panelTopHeaders.Size = New System.Drawing.Size(992, 60)
        Me.panelTopHeaders.TabIndex = 1056
        '
        'lblTabLegal
        '
        Me.lblTabLegal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTabLegal.AutoSize = True
        Me.lblTabLegal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTabLegal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTabLegal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblTabLegal.Location = New System.Drawing.Point(427, 14)
        Me.lblTabLegal.Name = "lblTabLegal"
        Me.lblTabLegal.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTabLegal.Size = New System.Drawing.Size(86, 30)
        Me.lblTabLegal.TabIndex = 1056
        Me.lblTabLegal.Text = "LEGAL"
        '
        'meClose
        '
        Me.meClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.meClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.meClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.meClose.Location = New System.Drawing.Point(949, 21)
        Me.meClose.Name = "meClose"
        Me.meClose.Size = New System.Drawing.Size(23, 23)
        Me.meClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.meClose.TabIndex = 1055
        Me.meClose.TabStop = False
        '
        'timerHideMessageSent
        '
        Me.timerHideMessageSent.Interval = 4000
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 561)
        Me.Controls.Add(Me.panelTopHeaders)
        Me.Controls.Add(Me.Tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInfo"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movieo"
        Me.Tab.ResumeLayout(False)
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        CType(Me.imgDataProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelHelpGrowSocial.ResumeLayout(False)
        Me.tabLegal.ResumeLayout(False)
        Me.tabLegal.PerformLayout()
        Me.tabHelpFaq.ResumeLayout(False)
        Me.tabHelpFaq.PerformLayout()
        Me.tabChangelog.ResumeLayout(False)
        Me.tabChangelog.PerformLayout()
        Me.tabContact.ResumeLayout(False)
        Me.tabContact.PerformLayout()
        Me.panelContactUs.ResumeLayout(False)
        Me.panelContactUs.PerformLayout()
        Me.panelTopHeaders.ResumeLayout(False)
        Me.panelTopHeaders.PerformLayout()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeaderChangelog As Label
    Friend WithEvents lblTabAbout As Label
    Friend WithEvents lblTabChangelog As Label
    Friend WithEvents lblTabFAQ As Label
    Friend WithEvents lblTabContact As Label
    Friend WithEvents Tab As TabControl
    Friend WithEvents tabChangelog As TabPage
    Friend WithEvents tabAbout As TabPage
    Friend WithEvents panelTopHeaders As Panel
    Friend WithEvents meClose As PictureBox
    Friend WithEvents tabHelpFaq As TabPage
    Friend WithEvents tabContact As TabPage
    Friend WithEvents MsgEmail As RtfExtensions
    Friend WithEvents MsgText As RtfExtensions
    Friend WithEvents lblHeaderAbout As Label
    Friend WithEvents lblChangelogFull As Label
    Friend WithEvents lblHeaderHelpFaq As Label
    Friend WithEvents Splitter1d As Label
    Friend WithEvents qSub4 As Label
    Friend WithEvents qHeader4 As Label
    Friend WithEvents Splitter1c As Label
    Friend WithEvents qSub3 As Label
    Friend WithEvents qHeader3 As Label
    Friend WithEvents Splitter1b As Label
    Friend WithEvents qSub2 As Label
    Friend WithEvents qHeader2 As Label
    Friend WithEvents lblAboutSubHeader2 As Label
    Friend WithEvents lblAboutSubHeader1 As Label
    Friend WithEvents AboutSubText As Label
    Friend WithEvents imgDataProvider As PictureBox
    Friend WithEvents btnShareFacebook As CButtonLib.CButton
    Friend WithEvents btnShareTwitter As CButtonLib.CButton
    Friend WithEvents lblHeaderContact As Label
    Friend WithEvents txtFormMessageBG As CButtonLib.CButton
    Friend WithEvents txtFormEmailBG As CButtonLib.CButton
    Friend WithEvents btnFormSubmit As CButtonLib.CButton
    Friend WithEvents panelContactUs As FlowLayoutPanel
    Friend WithEvents lblEmailUsAt As Label
    Friend WithEvents lblSocialEmail As Label
    Friend WithEvents lblVisitUsOn1 As Label
    Friend WithEvents lblSocialSourceForge As Label
    Friend WithEvents lblVisitUsOn2 As Label
    Friend WithEvents lblSocialTwitter As Label
    Friend WithEvents Splitter2a As CButtonLib.CButton
    Friend WithEvents panelHelpGrowSocial As Panel
    Friend WithEvents lblSubContact As Label
    Friend WithEvents timerHideMessageSent As Timer
    Friend WithEvents tabLegal As TabPage
    Friend WithEvents lblHeaderLegal As Label
    Friend WithEvents lblTabLegal As Label
    Friend WithEvents lblLegalText As Label
    Friend WithEvents qHeader0 As Label
    Friend WithEvents qSub0 As Label
    Friend WithEvents Splitter1aa As Label
    Friend WithEvents lblAboutVersion As Label
    Friend WithEvents lblAboutDevs As Label
    Friend WithEvents txtFormEmail As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents txtFormMessage As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents lblMessageSent As CButtonLib.CButton
End Class
