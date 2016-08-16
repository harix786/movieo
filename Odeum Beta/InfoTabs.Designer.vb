<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfoTabs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoTabs))
        Me.LblHeaderChangelog = New System.Windows.Forms.Label()
        Me.LblAbout = New System.Windows.Forms.Label()
        Me.LblChangelog = New System.Windows.Forms.Label()
        Me.LblFAQ = New System.Windows.Forms.Label()
        Me.LblContact = New System.Windows.Forms.Label()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.TabAbout = New System.Windows.Forms.TabPage()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.ImgProvider = New System.Windows.Forms.PictureBox()
        Me.AboutSubHeader2 = New System.Windows.Forms.Label()
        Me.AboutSubHeader1 = New System.Windows.Forms.Label()
        Me.AboutSubText = New System.Windows.Forms.Label()
        Me.LblHeaderAbout = New System.Windows.Forms.Label()
        Me.PanelShareBtns = New System.Windows.Forms.Panel()
        Me.BtnShareTw = New CButtonLib.CButton()
        Me.BtnShareFb = New CButtonLib.CButton()
        Me.TabHelpFaq = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Splitter4 = New System.Windows.Forms.Label()
        Me.qSub4 = New System.Windows.Forms.Label()
        Me.qHeader4 = New System.Windows.Forms.Label()
        Me.Splitter3 = New System.Windows.Forms.Label()
        Me.qSub3 = New System.Windows.Forms.Label()
        Me.qHeader3 = New System.Windows.Forms.Label()
        Me.Splitter2 = New System.Windows.Forms.Label()
        Me.qSub2 = New System.Windows.Forms.Label()
        Me.qHeader2 = New System.Windows.Forms.Label()
        Me.qSub1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Label()
        Me.qHeader1 = New System.Windows.Forms.Label()
        Me.LblHeaderHelpFaq = New System.Windows.Forms.Label()
        Me.TabChangelog = New System.Windows.Forms.TabPage()
        Me.TxtChangelog = New System.Windows.Forms.Label()
        Me.TabContact = New System.Windows.Forms.TabPage()
        Me.MsgSentConfirmation = New CButtonLib.CButton()
        Me.PanelSocialItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.LblEmailUsAt = New System.Windows.Forms.Label()
        Me.ContactEmail = New System.Windows.Forms.Label()
        Me.LblVisitUsOn1 = New System.Windows.Forms.Label()
        Me.ContactSourceForge = New System.Windows.Forms.Label()
        Me.LblVisitUsOn2 = New System.Windows.Forms.Label()
        Me.ContactTwitter = New System.Windows.Forms.Label()
        Me.Splitter5 = New CButtonLib.CButton()
        Me.BtnSubmitForm = New CButtonLib.CButton()
        Me.LblHeaderContact = New System.Windows.Forms.Label()
        Me.LblSubContact = New System.Windows.Forms.Label()
        Me.TxtEmailForm = New Odeum.RtfExtensions()
        Me.TxtMessageForm = New Odeum.RtfExtensions()
        Me.TxtMessageBg = New CButtonLib.CButton()
        Me.TxtEmailBg = New CButtonLib.CButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LblVisitTwitter = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.MeClose = New System.Windows.Forms.PictureBox()
        Me.TopWidePanel = New System.Windows.Forms.Panel()
        Me.HideConfirmation = New System.Windows.Forms.Timer(Me.components)
        Me.Tab.SuspendLayout()
        Me.TabAbout.SuspendLayout()
        CType(Me.ImgProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelShareBtns.SuspendLayout()
        Me.TabHelpFaq.SuspendLayout()
        Me.TabChangelog.SuspendLayout()
        Me.TabContact.SuspendLayout()
        Me.PanelSocialItems.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.MeClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHeaderChangelog
        '
        Me.LblHeaderChangelog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblHeaderChangelog.AutoSize = True
        Me.LblHeaderChangelog.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblHeaderChangelog.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeaderChangelog.ForeColor = System.Drawing.Color.White
        Me.LblHeaderChangelog.Location = New System.Drawing.Point(371, 55)
        Me.LblHeaderChangelog.Name = "LblHeaderChangelog"
        Me.LblHeaderChangelog.Size = New System.Drawing.Size(266, 45)
        Me.LblHeaderChangelog.TabIndex = 1050
        Me.LblHeaderChangelog.Text = "Release Changes"
        '
        'LblAbout
        '
        Me.LblAbout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblAbout.AutoSize = True
        Me.LblAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAbout.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LblAbout.Location = New System.Drawing.Point(247, 14)
        Me.LblAbout.Name = "LblAbout"
        Me.LblAbout.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblAbout.Size = New System.Drawing.Size(94, 30)
        Me.LblAbout.TabIndex = 1051
        Me.LblAbout.Text = "ABOUT"
        '
        'LblChangelog
        '
        Me.LblChangelog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblChangelog.AutoSize = True
        Me.LblChangelog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblChangelog.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChangelog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.LblChangelog.Location = New System.Drawing.Point(472, 14)
        Me.LblChangelog.Name = "LblChangelog"
        Me.LblChangelog.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblChangelog.Size = New System.Drawing.Size(151, 30)
        Me.LblChangelog.TabIndex = 1052
        Me.LblChangelog.Text = "CHANGELOG"
        '
        'LblFAQ
        '
        Me.LblFAQ.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblFAQ.AutoSize = True
        Me.LblFAQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblFAQ.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFAQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.LblFAQ.Location = New System.Drawing.Point(346, 14)
        Me.LblFAQ.Name = "LblFAQ"
        Me.LblFAQ.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblFAQ.Size = New System.Drawing.Size(124, 30)
        Me.LblFAQ.TabIndex = 1053
        Me.LblFAQ.Text = "HELP/FAQ"
        '
        'LblContact
        '
        Me.LblContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblContact.AutoSize = True
        Me.LblContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblContact.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.LblContact.Location = New System.Drawing.Point(625, 14)
        Me.LblContact.Name = "LblContact"
        Me.LblContact.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblContact.Size = New System.Drawing.Size(120, 30)
        Me.LblContact.TabIndex = 1054
        Me.LblContact.Text = "CONTACT"
        '
        'Tab
        '
        Me.Tab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.Controls.Add(Me.TabAbout)
        Me.Tab.Controls.Add(Me.TabHelpFaq)
        Me.Tab.Controls.Add(Me.TabChangelog)
        Me.Tab.Controls.Add(Me.TabContact)
        Me.Tab.Location = New System.Drawing.Point(-23, 54)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1036, 511)
        Me.Tab.TabIndex = 1055
        '
        'TabAbout
        '
        Me.TabAbout.AutoScroll = True
        Me.TabAbout.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.TabAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TabAbout.Controls.Add(Me.LblVersion)
        Me.TabAbout.Controls.Add(Me.ImgProvider)
        Me.TabAbout.Controls.Add(Me.AboutSubHeader2)
        Me.TabAbout.Controls.Add(Me.AboutSubHeader1)
        Me.TabAbout.Controls.Add(Me.AboutSubText)
        Me.TabAbout.Controls.Add(Me.LblHeaderAbout)
        Me.TabAbout.Controls.Add(Me.PanelShareBtns)
        Me.TabAbout.Location = New System.Drawing.Point(23, 4)
        Me.TabAbout.Name = "TabAbout"
        Me.TabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAbout.Size = New System.Drawing.Size(1009, 503)
        Me.TabAbout.TabIndex = 1
        Me.TabAbout.Text = "ABOUT"
        '
        'LblVersion
        '
        Me.LblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.LblVersion.Location = New System.Drawing.Point(6, 3830)
        Me.LblVersion.MaximumSize = New System.Drawing.Size(730, 0)
        Me.LblVersion.MinimumSize = New System.Drawing.Size(730, 0)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LblVersion.Size = New System.Drawing.Size(730, 31)
        Me.LblVersion.TabIndex = 1092
        Me.LblVersion.Text = "Beta Build v"
        '
        'ImgProvider
        '
        Me.ImgProvider.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ImgProvider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgProvider.Image = Global.Odeum.My.Resources.Resources.themoviedb_org
        Me.ImgProvider.Location = New System.Drawing.Point(267, 579)
        Me.ImgProvider.Name = "ImgProvider"
        Me.ImgProvider.Size = New System.Drawing.Size(355, 69)
        Me.ImgProvider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgProvider.TabIndex = 1088
        Me.ImgProvider.TabStop = False
        '
        'AboutSubHeader2
        '
        Me.AboutSubHeader2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AboutSubHeader2.AutoSize = True
        Me.AboutSubHeader2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutSubHeader2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.AboutSubHeader2.Location = New System.Drawing.Point(79, 545)
        Me.AboutSubHeader2.MaximumSize = New System.Drawing.Size(730, 0)
        Me.AboutSubHeader2.MinimumSize = New System.Drawing.Size(730, 0)
        Me.AboutSubHeader2.Name = "AboutSubHeader2"
        Me.AboutSubHeader2.Size = New System.Drawing.Size(730, 30)
        Me.AboutSubHeader2.TabIndex = 1087
        Me.AboutSubHeader2.Text = "CORE DATA PROVIDER"
        Me.AboutSubHeader2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AboutSubHeader1
        '
        Me.AboutSubHeader1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AboutSubHeader1.AutoSize = True
        Me.AboutSubHeader1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutSubHeader1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.AboutSubHeader1.Location = New System.Drawing.Point(79, 408)
        Me.AboutSubHeader1.MaximumSize = New System.Drawing.Size(730, 0)
        Me.AboutSubHeader1.MinimumSize = New System.Drawing.Size(730, 0)
        Me.AboutSubHeader1.Name = "AboutSubHeader1"
        Me.AboutSubHeader1.Size = New System.Drawing.Size(730, 30)
        Me.AboutSubHeader1.TabIndex = 1086
        Me.AboutSubHeader1.Text = "HELP US GROW"
        Me.AboutSubHeader1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AboutSubText
        '
        Me.AboutSubText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AboutSubText.AutoSize = True
        Me.AboutSubText.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.AboutSubText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.AboutSubText.Location = New System.Drawing.Point(87, 116)
        Me.AboutSubText.MaximumSize = New System.Drawing.Size(730, 0)
        Me.AboutSubText.MinimumSize = New System.Drawing.Size(730, 0)
        Me.AboutSubText.Name = "AboutSubText"
        Me.AboutSubText.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.AboutSubText.Size = New System.Drawing.Size(730, 235)
        Me.AboutSubText.TabIndex = 1085
        Me.AboutSubText.Text = resources.GetString("AboutSubText.Text")
        '
        'LblHeaderAbout
        '
        Me.LblHeaderAbout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblHeaderAbout.AutoSize = True
        Me.LblHeaderAbout.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblHeaderAbout.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeaderAbout.ForeColor = System.Drawing.Color.White
        Me.LblHeaderAbout.Location = New System.Drawing.Point(262, 55)
        Me.LblHeaderAbout.Name = "LblHeaderAbout"
        Me.LblHeaderAbout.Size = New System.Drawing.Size(381, 45)
        Me.LblHeaderAbout.TabIndex = 1083
        Me.LblHeaderAbout.Text = "What is Odeum Movies?"
        '
        'PanelShareBtns
        '
        Me.PanelShareBtns.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelShareBtns.Controls.Add(Me.BtnShareTw)
        Me.PanelShareBtns.Controls.Add(Me.BtnShareFb)
        Me.PanelShareBtns.Location = New System.Drawing.Point(262, 443)
        Me.PanelShareBtns.Name = "PanelShareBtns"
        Me.PanelShareBtns.Size = New System.Drawing.Size(364, 50)
        Me.PanelShareBtns.TabIndex = 1091
        '
        'BtnShareTw
        '
        Me.BtnShareTw.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnShareTw.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BtnShareTw.BorderShow = False
        Me.BtnShareTw.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BtnShareTw.Corners.All = 2
        Me.BtnShareTw.Corners.LowerLeft = 2
        Me.BtnShareTw.Corners.LowerRight = 2
        Me.BtnShareTw.Corners.UpperLeft = 2
        Me.BtnShareTw.Corners.UpperRight = 2
        Me.BtnShareTw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShareTw.DesignerSelected = False
        Me.BtnShareTw.DimFactorClick = -26
        Me.BtnShareTw.DimFactorHover = 14
        Me.BtnShareTw.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnShareTw.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShareTw.ImageIndex = 0
        Me.BtnShareTw.Location = New System.Drawing.Point(193, 13)
        Me.BtnShareTw.Name = "BtnShareTw"
        Me.BtnShareTw.ShowFocus = CButtonLib.CButton.eFocus.[Dim]
        Me.BtnShareTw.SideImage = Global.Odeum.My.Resources.Resources.twitterLogo
        Me.BtnShareTw.SideImageSize = New System.Drawing.Size(32, 23)
        Me.BtnShareTw.Size = New System.Drawing.Size(162, 34)
        Me.BtnShareTw.TabIndex = 1090
        Me.BtnShareTw.Text = "       Share on Twitter"
        Me.BtnShareTw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnShareTw.TextShadowShow = False
        '
        'BtnShareFb
        '
        Me.BtnShareFb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnShareFb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnShareFb.BorderShow = False
        Me.BtnShareFb.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnShareFb.Corners.All = 2
        Me.BtnShareFb.Corners.LowerLeft = 2
        Me.BtnShareFb.Corners.LowerRight = 2
        Me.BtnShareFb.Corners.UpperLeft = 2
        Me.BtnShareFb.Corners.UpperRight = 2
        Me.BtnShareFb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShareFb.DesignerSelected = False
        Me.BtnShareFb.DimFactorClick = -26
        Me.BtnShareFb.DimFactorHover = 14
        Me.BtnShareFb.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnShareFb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShareFb.ImageIndex = 0
        Me.BtnShareFb.Location = New System.Drawing.Point(9, 13)
        Me.BtnShareFb.Name = "BtnShareFb"
        Me.BtnShareFb.ShowFocus = CButtonLib.CButton.eFocus.[Dim]
        Me.BtnShareFb.SideImage = Global.Odeum.My.Resources.Resources.FacebookLogo
        Me.BtnShareFb.SideImageSize = New System.Drawing.Size(32, 23)
        Me.BtnShareFb.Size = New System.Drawing.Size(170, 34)
        Me.BtnShareFb.TabIndex = 1089
        Me.BtnShareFb.Text = "      Share on Facebook"
        Me.BtnShareFb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnShareFb.TextShadowShow = False
        '
        'TabHelpFaq
        '
        Me.TabHelpFaq.AutoScroll = True
        Me.TabHelpFaq.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.TabHelpFaq.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TabHelpFaq.Controls.Add(Me.Label1)
        Me.TabHelpFaq.Controls.Add(Me.Label2)
        Me.TabHelpFaq.Controls.Add(Me.Label3)
        Me.TabHelpFaq.Controls.Add(Me.Splitter4)
        Me.TabHelpFaq.Controls.Add(Me.qSub4)
        Me.TabHelpFaq.Controls.Add(Me.qHeader4)
        Me.TabHelpFaq.Controls.Add(Me.Splitter3)
        Me.TabHelpFaq.Controls.Add(Me.qSub3)
        Me.TabHelpFaq.Controls.Add(Me.qHeader3)
        Me.TabHelpFaq.Controls.Add(Me.Splitter2)
        Me.TabHelpFaq.Controls.Add(Me.qSub2)
        Me.TabHelpFaq.Controls.Add(Me.qHeader2)
        Me.TabHelpFaq.Controls.Add(Me.qSub1)
        Me.TabHelpFaq.Controls.Add(Me.Splitter1)
        Me.TabHelpFaq.Controls.Add(Me.qHeader1)
        Me.TabHelpFaq.Controls.Add(Me.LblHeaderHelpFaq)
        Me.TabHelpFaq.Location = New System.Drawing.Point(23, 4)
        Me.TabHelpFaq.Name = "TabHelpFaq"
        Me.TabHelpFaq.Size = New System.Drawing.Size(1009, 503)
        Me.TabHelpFaq.TabIndex = 2
        Me.TabHelpFaq.Text = "HELP/FAQ"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 1061)
        Me.Label1.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(750, 32)
        Me.Label1.TabIndex = 1067
        Me.Label1.Text = "-------------------------------------------------------------------------"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(74, 1146)
        Me.Label2.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label2.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(750, 85)
        Me.Label2.TabIndex = 1066
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(74, 1116)
        Me.Label3.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label3.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(750, 30)
        Me.Label3.TabIndex = 1065
        Me.Label3.Text = "Why is it free?"
        '
        'Splitter4
        '
        Me.Splitter4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter4.AutoSize = True
        Me.Splitter4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter4.Location = New System.Drawing.Point(73, 792)
        Me.Splitter4.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter4.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(750, 32)
        Me.Splitter4.TabIndex = 1064
        Me.Splitter4.Text = "-------------------------------------------------------------------------"
        '
        'qSub4
        '
        Me.qSub4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qSub4.AutoSize = True
        Me.qSub4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.qSub4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qSub4.Location = New System.Drawing.Point(74, 877)
        Me.qSub4.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qSub4.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qSub4.Name = "qSub4"
        Me.qSub4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.qSub4.Size = New System.Drawing.Size(750, 160)
        Me.qSub4.TabIndex = 1063
        Me.qSub4.Text = resources.GetString("qSub4.Text")
        '
        'qHeader4
        '
        Me.qHeader4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qHeader4.AutoSize = True
        Me.qHeader4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qHeader4.ForeColor = System.Drawing.Color.White
        Me.qHeader4.Location = New System.Drawing.Point(74, 847)
        Me.qHeader4.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qHeader4.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qHeader4.Name = "qHeader4"
        Me.qHeader4.Size = New System.Drawing.Size(750, 30)
        Me.qHeader4.TabIndex = 1062
        Me.qHeader4.Text = "Can I suggest a movie?"
        '
        'Splitter3
        '
        Me.Splitter3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter3.AutoSize = True
        Me.Splitter3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter3.Location = New System.Drawing.Point(73, 602)
        Me.Splitter3.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter3.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(750, 32)
        Me.Splitter3.TabIndex = 1061
        Me.Splitter3.Text = "-------------------------------------------------------------------------"
        '
        'qSub3
        '
        Me.qSub3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qSub3.AutoSize = True
        Me.qSub3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.qSub3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qSub3.Location = New System.Drawing.Point(74, 687)
        Me.qSub3.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qSub3.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qSub3.Name = "qSub3"
        Me.qSub3.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.qSub3.Size = New System.Drawing.Size(750, 85)
        Me.qSub3.TabIndex = 1060
        Me.qSub3.Text = resources.GetString("qSub3.Text")
        '
        'qHeader3
        '
        Me.qHeader3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qHeader3.AutoSize = True
        Me.qHeader3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qHeader3.ForeColor = System.Drawing.Color.White
        Me.qHeader3.Location = New System.Drawing.Point(74, 657)
        Me.qHeader3.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qHeader3.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qHeader3.Name = "qHeader3"
        Me.qHeader3.Size = New System.Drawing.Size(750, 30)
        Me.qHeader3.TabIndex = 1059
        Me.qHeader3.Text = "Why can't I open Odeum Movies?"
        '
        'Splitter2
        '
        Me.Splitter2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter2.AutoSize = True
        Me.Splitter2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter2.Location = New System.Drawing.Point(73, 358)
        Me.Splitter2.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter2.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(750, 32)
        Me.Splitter2.TabIndex = 1058
        Me.Splitter2.Text = "-------------------------------------------------------------------------"
        '
        'qSub2
        '
        Me.qSub2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qSub2.AutoSize = True
        Me.qSub2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.qSub2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qSub2.Location = New System.Drawing.Point(74, 444)
        Me.qSub2.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qSub2.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qSub2.Name = "qSub2"
        Me.qSub2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.qSub2.Size = New System.Drawing.Size(750, 135)
        Me.qSub2.TabIndex = 1057
        Me.qSub2.Text = resources.GetString("qSub2.Text")
        '
        'qHeader2
        '
        Me.qHeader2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qHeader2.AutoSize = True
        Me.qHeader2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qHeader2.ForeColor = System.Drawing.Color.White
        Me.qHeader2.Location = New System.Drawing.Point(74, 414)
        Me.qHeader2.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qHeader2.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qHeader2.Name = "qHeader2"
        Me.qHeader2.Size = New System.Drawing.Size(750, 30)
        Me.qHeader2.TabIndex = 1056
        Me.qHeader2.Text = "I'm having some issues..."
        '
        'qSub1
        '
        Me.qSub1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qSub1.AutoSize = True
        Me.qSub1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.qSub1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.qSub1.Location = New System.Drawing.Point(74, 202)
        Me.qSub1.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qSub1.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qSub1.Name = "qSub1"
        Me.qSub1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.qSub1.Size = New System.Drawing.Size(750, 135)
        Me.qSub1.TabIndex = 1055
        Me.qSub1.Text = resources.GetString("qSub1.Text")
        '
        'Splitter1
        '
        Me.Splitter1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1.AutoSize = True
        Me.Splitter1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1.Location = New System.Drawing.Point(73, 121)
        Me.Splitter1.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1.TabIndex = 1054
        Me.Splitter1.Text = "-------------------------------------------------------------------------"
        '
        'qHeader1
        '
        Me.qHeader1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qHeader1.AutoSize = True
        Me.qHeader1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qHeader1.ForeColor = System.Drawing.Color.White
        Me.qHeader1.Location = New System.Drawing.Point(74, 172)
        Me.qHeader1.MaximumSize = New System.Drawing.Size(750, 0)
        Me.qHeader1.MinimumSize = New System.Drawing.Size(750, 0)
        Me.qHeader1.Name = "qHeader1"
        Me.qHeader1.Size = New System.Drawing.Size(750, 30)
        Me.qHeader1.TabIndex = 1053
        Me.qHeader1.Text = "How does it work?"
        '
        'LblHeaderHelpFaq
        '
        Me.LblHeaderHelpFaq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblHeaderHelpFaq.AutoSize = True
        Me.LblHeaderHelpFaq.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblHeaderHelpFaq.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeaderHelpFaq.ForeColor = System.Drawing.Color.White
        Me.LblHeaderHelpFaq.Location = New System.Drawing.Point(235, 55)
        Me.LblHeaderHelpFaq.Name = "LblHeaderHelpFaq"
        Me.LblHeaderHelpFaq.Size = New System.Drawing.Size(427, 45)
        Me.LblHeaderHelpFaq.TabIndex = 1052
        Me.LblHeaderHelpFaq.Text = "Help && Frequent Questions"
        '
        'TabChangelog
        '
        Me.TabChangelog.AutoScroll = True
        Me.TabChangelog.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.TabChangelog.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TabChangelog.Controls.Add(Me.TxtChangelog)
        Me.TabChangelog.Controls.Add(Me.LblHeaderChangelog)
        Me.TabChangelog.Location = New System.Drawing.Point(23, 4)
        Me.TabChangelog.Name = "TabChangelog"
        Me.TabChangelog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabChangelog.Size = New System.Drawing.Size(1009, 503)
        Me.TabChangelog.TabIndex = 0
        Me.TabChangelog.Text = "CHANGELOG"
        '
        'TxtChangelog
        '
        Me.TxtChangelog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtChangelog.AutoSize = True
        Me.TxtChangelog.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.TxtChangelog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TxtChangelog.Location = New System.Drawing.Point(114, 129)
        Me.TxtChangelog.MaximumSize = New System.Drawing.Size(780, 0)
        Me.TxtChangelog.MinimumSize = New System.Drawing.Size(780, 0)
        Me.TxtChangelog.Name = "TxtChangelog"
        Me.TxtChangelog.Size = New System.Drawing.Size(780, 31)
        Me.TxtChangelog.TabIndex = 1051
        Me.TxtChangelog.Text = "Changelog text..."
        Me.TxtChangelog.UseCompatibleTextRendering = True
        '
        'TabContact
        '
        Me.TabContact.AutoScroll = True
        Me.TabContact.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.TabContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TabContact.Controls.Add(Me.MsgSentConfirmation)
        Me.TabContact.Controls.Add(Me.PanelSocialItems)
        Me.TabContact.Controls.Add(Me.Splitter5)
        Me.TabContact.Controls.Add(Me.BtnSubmitForm)
        Me.TabContact.Controls.Add(Me.LblHeaderContact)
        Me.TabContact.Controls.Add(Me.LblSubContact)
        Me.TabContact.Controls.Add(Me.TxtEmailForm)
        Me.TabContact.Controls.Add(Me.TxtMessageForm)
        Me.TabContact.Controls.Add(Me.TxtMessageBg)
        Me.TabContact.Controls.Add(Me.TxtEmailBg)
        Me.TabContact.Location = New System.Drawing.Point(23, 4)
        Me.TabContact.Name = "TabContact"
        Me.TabContact.Size = New System.Drawing.Size(1009, 503)
        Me.TabContact.TabIndex = 3
        Me.TabContact.Text = "CONTACT"
        '
        'MsgSentConfirmation
        '
        Me.MsgSentConfirmation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MsgSentConfirmation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.MsgSentConfirmation.BorderShow = False
        Me.MsgSentConfirmation.ColorFillSolid = System.Drawing.Color.Transparent
        Me.MsgSentConfirmation.Corners.All = 2
        Me.MsgSentConfirmation.Corners.LowerLeft = 2
        Me.MsgSentConfirmation.Corners.LowerRight = 2
        Me.MsgSentConfirmation.Corners.UpperLeft = 2
        Me.MsgSentConfirmation.Corners.UpperRight = 2
        Me.MsgSentConfirmation.DesignerSelected = False
        Me.MsgSentConfirmation.DimFactorClick = 0
        Me.MsgSentConfirmation.DimFactorHover = 0
        Me.MsgSentConfirmation.FillType = CButtonLib.CButton.eFillType.Solid
        Me.MsgSentConfirmation.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!)
        Me.MsgSentConfirmation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MsgSentConfirmation.ImageIndex = 0
        Me.MsgSentConfirmation.Location = New System.Drawing.Point(307, 442)
        Me.MsgSentConfirmation.Name = "MsgSentConfirmation"
        Me.MsgSentConfirmation.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.MsgSentConfirmation.Size = New System.Drawing.Size(296, 31)
        Me.MsgSentConfirmation.TabIndex = 99999
        Me.MsgSentConfirmation.Text = "Message sent! Thank you so much ❤"
        Me.MsgSentConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MsgSentConfirmation.TextShadowShow = False
        Me.MsgSentConfirmation.Visible = False
        '
        'PanelSocialItems
        '
        Me.PanelSocialItems.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelSocialItems.Controls.Add(Me.LblEmailUsAt)
        Me.PanelSocialItems.Controls.Add(Me.ContactEmail)
        Me.PanelSocialItems.Controls.Add(Me.LblVisitUsOn1)
        Me.PanelSocialItems.Controls.Add(Me.ContactSourceForge)
        Me.PanelSocialItems.Controls.Add(Me.LblVisitUsOn2)
        Me.PanelSocialItems.Controls.Add(Me.ContactTwitter)
        Me.PanelSocialItems.Location = New System.Drawing.Point(189, 520)
        Me.PanelSocialItems.Name = "PanelSocialItems"
        Me.PanelSocialItems.Size = New System.Drawing.Size(535, 101)
        Me.PanelSocialItems.TabIndex = 1057
        '
        'LblEmailUsAt
        '
        Me.LblEmailUsAt.AutoSize = True
        Me.LblEmailUsAt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailUsAt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.LblEmailUsAt.Location = New System.Drawing.Point(0, 0)
        Me.LblEmailUsAt.Margin = New System.Windows.Forms.Padding(0)
        Me.LblEmailUsAt.Name = "LblEmailUsAt"
        Me.LblEmailUsAt.Size = New System.Drawing.Size(103, 25)
        Me.LblEmailUsAt.TabIndex = 99999
        Me.LblEmailUsAt.Text = "email us at"
        '
        'ContactEmail
        '
        Me.ContactEmail.AutoSize = True
        Me.ContactEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelSocialItems.SetFlowBreak(Me.ContactEmail, True)
        Me.ContactEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ContactEmail.Location = New System.Drawing.Point(103, 0)
        Me.ContactEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.ContactEmail.Name = "ContactEmail"
        Me.ContactEmail.Size = New System.Drawing.Size(166, 25)
        Me.ContactEmail.TabIndex = 3
        Me.ContactEmail.Text = "info@odeum.at.vu"
        '
        'LblVisitUsOn1
        '
        Me.LblVisitUsOn1.AutoSize = True
        Me.LblVisitUsOn1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVisitUsOn1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.LblVisitUsOn1.Location = New System.Drawing.Point(0, 25)
        Me.LblVisitUsOn1.Margin = New System.Windows.Forms.Padding(0)
        Me.LblVisitUsOn1.Name = "LblVisitUsOn1"
        Me.LblVisitUsOn1.Size = New System.Drawing.Size(96, 25)
        Me.LblVisitUsOn1.TabIndex = 99999
        Me.LblVisitUsOn1.Text = "visit us on"
        '
        'ContactSourceForge
        '
        Me.ContactSourceForge.AutoSize = True
        Me.ContactSourceForge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelSocialItems.SetFlowBreak(Me.ContactSourceForge, True)
        Me.ContactSourceForge.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactSourceForge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ContactSourceForge.Location = New System.Drawing.Point(96, 25)
        Me.ContactSourceForge.Margin = New System.Windows.Forms.Padding(0)
        Me.ContactSourceForge.Name = "ContactSourceForge"
        Me.ContactSourceForge.Size = New System.Drawing.Size(118, 25)
        Me.ContactSourceForge.TabIndex = 4
        Me.ContactSourceForge.Text = "SourceForge"
        '
        'LblVisitUsOn2
        '
        Me.LblVisitUsOn2.AutoSize = True
        Me.LblVisitUsOn2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVisitUsOn2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.LblVisitUsOn2.Location = New System.Drawing.Point(0, 50)
        Me.LblVisitUsOn2.Margin = New System.Windows.Forms.Padding(0)
        Me.LblVisitUsOn2.Name = "LblVisitUsOn2"
        Me.LblVisitUsOn2.Size = New System.Drawing.Size(96, 25)
        Me.LblVisitUsOn2.TabIndex = 99999
        Me.LblVisitUsOn2.Text = "visit us on"
        '
        'ContactTwitter
        '
        Me.ContactTwitter.AutoSize = True
        Me.ContactTwitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelSocialItems.SetFlowBreak(Me.ContactTwitter, True)
        Me.ContactTwitter.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTwitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ContactTwitter.Location = New System.Drawing.Point(96, 50)
        Me.ContactTwitter.Margin = New System.Windows.Forms.Padding(0)
        Me.ContactTwitter.Name = "ContactTwitter"
        Me.ContactTwitter.Size = New System.Drawing.Size(69, 25)
        Me.ContactTwitter.TabIndex = 5
        Me.ContactTwitter.Text = "Twitter"
        '
        'Splitter5
        '
        Me.Splitter5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Splitter5.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Splitter5.Corners.All = 2
        Me.Splitter5.Corners.LowerLeft = 2
        Me.Splitter5.Corners.LowerRight = 2
        Me.Splitter5.Corners.UpperLeft = 2
        Me.Splitter5.Corners.UpperRight = 2
        Me.Splitter5.DesignerSelected = False
        Me.Splitter5.DimFactorClick = 0
        Me.Splitter5.DimFactorHover = 0
        Me.Splitter5.FillType = CButtonLib.CButton.eFillType.Solid
        Me.Splitter5.ImageIndex = 0
        Me.Splitter5.Location = New System.Drawing.Point(194, 500)
        Me.Splitter5.Name = "Splitter5"
        Me.Splitter5.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.Splitter5.Size = New System.Drawing.Size(525, 1)
        Me.Splitter5.TabIndex = 1056
        Me.Splitter5.Text = ""
        '
        'BtnSubmitForm
        '
        Me.BtnSubmitForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSubmitForm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BtnSubmitForm.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BtnSubmitForm.Corners.All = 2
        Me.BtnSubmitForm.Corners.LowerLeft = 2
        Me.BtnSubmitForm.Corners.LowerRight = 2
        Me.BtnSubmitForm.Corners.UpperLeft = 2
        Me.BtnSubmitForm.Corners.UpperRight = 2
        Me.BtnSubmitForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubmitForm.DesignerSelected = False
        Me.BtnSubmitForm.DimFactorClick = 0
        Me.BtnSubmitForm.DimFactorHover = 0
        Me.BtnSubmitForm.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnSubmitForm.Font = New System.Drawing.Font("Segoe UI", 11.55!, System.Drawing.FontStyle.Bold)
        Me.BtnSubmitForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnSubmitForm.ImageIndex = 0
        Me.BtnSubmitForm.Location = New System.Drawing.Point(612, 438)
        Me.BtnSubmitForm.Name = "BtnSubmitForm"
        Me.BtnSubmitForm.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnSubmitForm.Size = New System.Drawing.Size(107, 37)
        Me.BtnSubmitForm.TabIndex = 2
        Me.BtnSubmitForm.Text = "Submit"
        Me.BtnSubmitForm.TextShadowShow = False
        '
        'LblHeaderContact
        '
        Me.LblHeaderContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblHeaderContact.AutoSize = True
        Me.LblHeaderContact.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblHeaderContact.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeaderContact.ForeColor = System.Drawing.Color.White
        Me.LblHeaderContact.Location = New System.Drawing.Point(352, 55)
        Me.LblHeaderContact.Name = "LblHeaderContact"
        Me.LblHeaderContact.Size = New System.Drawing.Size(208, 45)
        Me.LblHeaderContact.TabIndex = 99999
        Me.LblHeaderContact.Text = "Get In Touch"
        '
        'LblSubContact
        '
        Me.LblSubContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSubContact.AutoSize = True
        Me.LblSubContact.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LblSubContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.LblSubContact.Location = New System.Drawing.Point(91, 94)
        Me.LblSubContact.MaximumSize = New System.Drawing.Size(730, 0)
        Me.LblSubContact.MinimumSize = New System.Drawing.Size(730, 0)
        Me.LblSubContact.Name = "LblSubContact"
        Me.LblSubContact.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LblSubContact.Size = New System.Drawing.Size(730, 60)
        Me.LblSubContact.TabIndex = 99999
        Me.LblSubContact.Text = "Question? Problem? Movie suggestion? Every" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "piece of feedback is welcome ^.^"
        Me.LblSubContact.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtEmailForm
        '
        Me.TxtEmailForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtEmailForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TxtEmailForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmailForm.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.TxtEmailForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.TxtEmailForm.Location = New System.Drawing.Point(201, 399)
        Me.TxtEmailForm.MaxLength = 20
        Me.TxtEmailForm.Multiline = False
        Me.TxtEmailForm.Name = "TxtEmailForm"
        Me.TxtEmailForm.Size = New System.Drawing.Size(511, 22)
        Me.TxtEmailForm.TabIndex = 1
        Me.TxtEmailForm.Text = ""
        Me.TxtEmailForm.Watermark = "Your email"
        Me.TxtEmailForm.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'TxtMessageForm
        '
        Me.TxtMessageForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtMessageForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TxtMessageForm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMessageForm.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.TxtMessageForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.TxtMessageForm.Location = New System.Drawing.Point(201, 195)
        Me.TxtMessageForm.MaxLength = 200
        Me.TxtMessageForm.Name = "TxtMessageForm"
        Me.TxtMessageForm.Size = New System.Drawing.Size(511, 180)
        Me.TxtMessageForm.TabIndex = 0
        Me.TxtMessageForm.Text = ""
        Me.TxtMessageForm.Watermark = "How can we help?"
        Me.TxtMessageForm.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'TxtMessageBg
        '
        Me.TxtMessageBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtMessageBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.TxtMessageBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.TxtMessageBg.Corners.All = 2
        Me.TxtMessageBg.Corners.LowerLeft = 2
        Me.TxtMessageBg.Corners.LowerRight = 2
        Me.TxtMessageBg.Corners.UpperLeft = 2
        Me.TxtMessageBg.Corners.UpperRight = 2
        Me.TxtMessageBg.DesignerSelected = False
        Me.TxtMessageBg.DimFactorClick = 0
        Me.TxtMessageBg.DimFactorHover = 0
        Me.TxtMessageBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.TxtMessageBg.ImageIndex = 0
        Me.TxtMessageBg.Location = New System.Drawing.Point(194, 188)
        Me.TxtMessageBg.Name = "TxtMessageBg"
        Me.TxtMessageBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.TxtMessageBg.Size = New System.Drawing.Size(525, 195)
        Me.TxtMessageBg.TabIndex = 99999
        Me.TxtMessageBg.Text = ""
        '
        'TxtEmailBg
        '
        Me.TxtEmailBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtEmailBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.TxtEmailBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.TxtEmailBg.Corners.All = 2
        Me.TxtEmailBg.Corners.LowerLeft = 2
        Me.TxtEmailBg.Corners.LowerRight = 2
        Me.TxtEmailBg.Corners.UpperLeft = 2
        Me.TxtEmailBg.Corners.UpperRight = 2
        Me.TxtEmailBg.DesignerSelected = False
        Me.TxtEmailBg.DimFactorClick = 0
        Me.TxtEmailBg.DimFactorHover = 0
        Me.TxtEmailBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.TxtEmailBg.ImageIndex = 0
        Me.TxtEmailBg.Location = New System.Drawing.Point(194, 392)
        Me.TxtEmailBg.Name = "TxtEmailBg"
        Me.TxtEmailBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.TxtEmailBg.Size = New System.Drawing.Size(525, 37)
        Me.TxtEmailBg.TabIndex = 99999
        Me.TxtEmailBg.Text = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LblVisitTwitter)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(194, 459)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(578, 100)
        Me.FlowLayoutPanel1.TabIndex = 111158
        '
        'LblVisitTwitter
        '
        Me.LblVisitTwitter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblVisitTwitter.AutoSize = True
        Me.LblVisitTwitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlowLayoutPanel1.SetFlowBreak(Me.LblVisitTwitter, True)
        Me.LblVisitTwitter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVisitTwitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LblVisitTwitter.Location = New System.Drawing.Point(0, 0)
        Me.LblVisitTwitter.Margin = New System.Windows.Forms.Padding(0)
        Me.LblVisitTwitter.Name = "LblVisitTwitter"
        Me.LblVisitTwitter.Size = New System.Drawing.Size(75, 30)
        Me.LblVisitTwitter.TabIndex = 1060
        Me.LblVisitTwitter.Text = "Twitter"
        '
        'TopPanel
        '
        Me.TopPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopPanel.Controls.Add(Me.MeClose)
        Me.TopPanel.Controls.Add(Me.LblAbout)
        Me.TopPanel.Controls.Add(Me.LblContact)
        Me.TopPanel.Controls.Add(Me.LblChangelog)
        Me.TopPanel.Controls.Add(Me.LblFAQ)
        Me.TopPanel.Location = New System.Drawing.Point(0, -1)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(992, 60)
        Me.TopPanel.TabIndex = 1056
        '
        'MeClose
        '
        Me.MeClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MeClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MeClose.Image = Global.Odeum.My.Resources.Resources.PopupCloseL
        Me.MeClose.Location = New System.Drawing.Point(959, 21)
        Me.MeClose.Name = "MeClose"
        Me.MeClose.Size = New System.Drawing.Size(23, 23)
        Me.MeClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MeClose.TabIndex = 1055
        Me.MeClose.TabStop = False
        '
        'TopWidePanel
        '
        Me.TopWidePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopWidePanel.Location = New System.Drawing.Point(0, -1)
        Me.TopWidePanel.Name = "TopWidePanel"
        Me.TopWidePanel.Size = New System.Drawing.Size(1009, 60)
        Me.TopWidePanel.TabIndex = 1058
        '
        'HideConfirmation
        '
        Me.HideConfirmation.Interval = 4000
        '
        'InfoTabs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 561)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.TopWidePanel)
        Me.Controls.Add(Me.Tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InfoTabs"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "More Tabs"
        Me.Tab.ResumeLayout(False)
        Me.TabAbout.ResumeLayout(False)
        Me.TabAbout.PerformLayout()
        CType(Me.ImgProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelShareBtns.ResumeLayout(False)
        Me.TabHelpFaq.ResumeLayout(False)
        Me.TabHelpFaq.PerformLayout()
        Me.TabChangelog.ResumeLayout(False)
        Me.TabChangelog.PerformLayout()
        Me.TabContact.ResumeLayout(False)
        Me.TabContact.PerformLayout()
        Me.PanelSocialItems.ResumeLayout(False)
        Me.PanelSocialItems.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.MeClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblHeaderChangelog As Label
    Friend WithEvents LblAbout As Label
    Friend WithEvents LblChangelog As Label
    Friend WithEvents LblFAQ As Label
    Friend WithEvents LblContact As Label
    Friend WithEvents Tab As TabControl
    Friend WithEvents TabChangelog As TabPage
    Friend WithEvents TabAbout As TabPage
    Friend WithEvents TopPanel As Panel
    Friend WithEvents MeClose As PictureBox
    Friend WithEvents TabHelpFaq As TabPage
    Friend WithEvents TabContact As TabPage
    Friend WithEvents MsgEmail As RtfExtensions
    Friend WithEvents MsgText As RtfExtensions
    Friend WithEvents LblHeaderAbout As Label
    Friend WithEvents TxtChangelog As Label
    Friend WithEvents LblHeaderHelpFaq As Label
    Friend WithEvents Splitter4 As Label
    Friend WithEvents qSub4 As Label
    Friend WithEvents qHeader4 As Label
    Friend WithEvents Splitter3 As Label
    Friend WithEvents qSub3 As Label
    Friend WithEvents qHeader3 As Label
    Friend WithEvents Splitter2 As Label
    Friend WithEvents qSub2 As Label
    Friend WithEvents qHeader2 As Label
    Friend WithEvents qSub1 As Label
    Friend WithEvents Splitter1 As Label
    Friend WithEvents qHeader1 As Label
    Friend WithEvents AboutSubHeader2 As Label
    Friend WithEvents AboutSubHeader1 As Label
    Friend WithEvents AboutSubText As Label
    Friend WithEvents ImgProvider As PictureBox
    Friend WithEvents BtnShareFb As CButtonLib.CButton
    Friend WithEvents BtnShareTw As CButtonLib.CButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LblVisitTwitter As Label
    Friend WithEvents LblHeaderContact As Label
    Friend WithEvents TxtMessageBg As CButtonLib.CButton
    Friend WithEvents TxtEmailBg As CButtonLib.CButton
    Friend WithEvents TxtMessageForm As RtfExtensions
    Friend WithEvents BtnSubmitForm As CButtonLib.CButton
    Friend WithEvents TxtEmailForm As RtfExtensions
    Friend WithEvents PanelSocialItems As FlowLayoutPanel
    Friend WithEvents LblEmailUsAt As Label
    Friend WithEvents ContactEmail As Label
    Friend WithEvents LblVisitUsOn1 As Label
    Friend WithEvents ContactSourceForge As Label
    Friend WithEvents LblVisitUsOn2 As Label
    Friend WithEvents ContactTwitter As Label
    Friend WithEvents Splitter5 As CButtonLib.CButton
    Friend WithEvents PanelShareBtns As Panel
    Friend WithEvents LblVersion As Label
    Friend WithEvents TopWidePanel As Panel
    Friend WithEvents LblSubContact As Label
    Friend WithEvents MsgSentConfirmation As CButtonLib.CButton
    Friend WithEvents HideConfirmation As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
