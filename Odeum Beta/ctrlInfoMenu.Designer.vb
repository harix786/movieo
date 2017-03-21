<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlInfoMenu
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
        Me.btnAbout = New CButtonLib.CButton()
        Me.btnLegal = New CButtonLib.CButton()
        Me.btnChangelog = New CButtonLib.CButton()
        Me.btnFAQ = New CButtonLib.CButton()
        Me.btnContact = New CButtonLib.CButton()
        Me.btnSettings = New CButtonLib.CButton()
        Me.topArrow = New CButtonLib.CButton()
        Me.topHeaderBlank = New CButtonLib.CButton()
        Me.background = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.BorderColor = System.Drawing.Color.Gray
        Me.btnAbout.BorderShow = False
        Me.btnAbout.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.DesignerSelected = True
        Me.btnAbout.DimFactorClick = 0
        Me.btnAbout.DimFactorHover = 0
        Me.btnAbout.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.Silver
        Me.btnAbout.ImageIndex = 0
        Me.btnAbout.Location = New System.Drawing.Point(1, 13)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnAbout.Size = New System.Drawing.Size(153, 32)
        Me.btnAbout.TabIndex = 0
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAbout.TextShadowShow = False
        '
        'btnLegal
        '
        Me.btnLegal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLegal.BackColor = System.Drawing.Color.Transparent
        Me.btnLegal.BorderColor = System.Drawing.Color.Gray
        Me.btnLegal.BorderShow = False
        Me.btnLegal.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnLegal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLegal.DesignerSelected = False
        Me.btnLegal.DimFactorClick = 0
        Me.btnLegal.DimFactorHover = 0
        Me.btnLegal.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnLegal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLegal.ForeColor = System.Drawing.Color.Silver
        Me.btnLegal.ImageIndex = 0
        Me.btnLegal.Location = New System.Drawing.Point(1, 74)
        Me.btnLegal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLegal.Name = "btnLegal"
        Me.btnLegal.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnLegal.Size = New System.Drawing.Size(153, 32)
        Me.btnLegal.TabIndex = 2
        Me.btnLegal.Text = "Legal"
        Me.btnLegal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLegal.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLegal.TextShadowShow = False
        '
        'btnChangelog
        '
        Me.btnChangelog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangelog.BackColor = System.Drawing.Color.Transparent
        Me.btnChangelog.BorderColor = System.Drawing.Color.Gray
        Me.btnChangelog.BorderShow = False
        Me.btnChangelog.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnChangelog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangelog.DesignerSelected = False
        Me.btnChangelog.DimFactorClick = 0
        Me.btnChangelog.DimFactorHover = 0
        Me.btnChangelog.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnChangelog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangelog.ForeColor = System.Drawing.Color.Silver
        Me.btnChangelog.ImageIndex = 0
        Me.btnChangelog.Location = New System.Drawing.Point(1, 105)
        Me.btnChangelog.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChangelog.Name = "btnChangelog"
        Me.btnChangelog.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnChangelog.Size = New System.Drawing.Size(153, 32)
        Me.btnChangelog.TabIndex = 3
        Me.btnChangelog.Text = "Changelog"
        Me.btnChangelog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangelog.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnChangelog.TextShadowShow = False
        '
        'btnFAQ
        '
        Me.btnFAQ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFAQ.BackColor = System.Drawing.Color.Transparent
        Me.btnFAQ.BorderColor = System.Drawing.Color.Gray
        Me.btnFAQ.BorderShow = False
        Me.btnFAQ.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFAQ.DesignerSelected = False
        Me.btnFAQ.DimFactorClick = 0
        Me.btnFAQ.DimFactorHover = 0
        Me.btnFAQ.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnFAQ.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFAQ.ForeColor = System.Drawing.Color.Silver
        Me.btnFAQ.ImageIndex = 0
        Me.btnFAQ.Location = New System.Drawing.Point(1, 43)
        Me.btnFAQ.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFAQ.Name = "btnFAQ"
        Me.btnFAQ.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnFAQ.Size = New System.Drawing.Size(153, 32)
        Me.btnFAQ.TabIndex = 1
        Me.btnFAQ.Text = "Help / Faq's"
        Me.btnFAQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFAQ.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnFAQ.TextShadowShow = False
        '
        'btnContact
        '
        Me.btnContact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContact.BackColor = System.Drawing.Color.Transparent
        Me.btnContact.BorderColor = System.Drawing.Color.Gray
        Me.btnContact.BorderShow = False
        Me.btnContact.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContact.DesignerSelected = False
        Me.btnContact.DimFactorClick = 0
        Me.btnContact.DimFactorHover = 0
        Me.btnContact.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnContact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContact.ForeColor = System.Drawing.Color.Silver
        Me.btnContact.ImageIndex = 0
        Me.btnContact.Location = New System.Drawing.Point(1, 136)
        Me.btnContact.Margin = New System.Windows.Forms.Padding(0)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnContact.Size = New System.Drawing.Size(153, 32)
        Me.btnContact.TabIndex = 4
        Me.btnContact.Text = "Contact"
        Me.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnContact.TextShadowShow = False
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BorderColor = System.Drawing.Color.Gray
        Me.btnSettings.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.DesignerSelected = False
        Me.btnSettings.DimFactorClick = 0
        Me.btnSettings.DimFactorHover = 0
        Me.btnSettings.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Silver
        Me.btnSettings.ImageIndex = 0
        Me.btnSettings.Location = New System.Drawing.Point(0, 167)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnSettings.Size = New System.Drawing.Size(155, 32)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSettings.TextShadowShow = False
        '
        'topArrow
        '
        Me.topArrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.topArrow.BorderColor = System.Drawing.Color.Gray
        Me.topArrow.ColorFillSolid = System.Drawing.Color.Gray
        Me.topArrow.DesignerSelected = False
        Me.topArrow.DimFactorClick = 0
        Me.topArrow.DimFactorHover = 0
        Me.topArrow.FillType = CButtonLib.CButton.eFillType.Solid
        Me.topArrow.ImageIndex = 0
        Me.topArrow.Location = New System.Drawing.Point(15, 4)
        Me.topArrow.Name = "topArrow"
        Me.topArrow.Shape = CButtonLib.CButton.eShape.TriangleUp
        Me.topArrow.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.topArrow.Size = New System.Drawing.Size(14, 8)
        Me.topArrow.TabIndex = 12
        Me.topArrow.TabStop = False
        Me.topArrow.Text = ""
        '
        'topHeaderBlank
        '
        Me.topHeaderBlank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.topHeaderBlank.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.topHeaderBlank.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.topHeaderBlank.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.topHeaderBlank.DesignerSelected = False
        Me.topHeaderBlank.DimFactorClick = 0
        Me.topHeaderBlank.DimFactorHover = 0
        Me.topHeaderBlank.FillType = CButtonLib.CButton.eFillType.Solid
        Me.topHeaderBlank.ImageIndex = 0
        Me.topHeaderBlank.Location = New System.Drawing.Point(0, -4)
        Me.topHeaderBlank.Name = "topHeaderBlank"
        Me.topHeaderBlank.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.topHeaderBlank.Size = New System.Drawing.Size(155, 16)
        Me.topHeaderBlank.TabIndex = 13
        Me.topHeaderBlank.TabStop = False
        Me.topHeaderBlank.Text = ""
        '
        'background
        '
        Me.background.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.background.BackColor = System.Drawing.Color.Gray
        Me.background.BorderColor = System.Drawing.Color.Gray
        Me.background.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.background.DesignerSelected = False
        Me.background.DimFactorClick = 0
        Me.background.DimFactorHover = 0
        Me.background.FillType = CButtonLib.CButton.eFillType.Solid
        Me.background.ImageIndex = 0
        Me.background.Location = New System.Drawing.Point(0, 12)
        Me.background.Name = "background"
        Me.background.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.background.Size = New System.Drawing.Size(155, 183)
        Me.background.TabIndex = 14
        Me.background.TabStop = False
        Me.background.Text = " "
        '
        'ctrlInfoMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(155, 199)
        Me.Controls.Add(Me.btnChangelog)
        Me.Controls.Add(Me.btnFAQ)
        Me.Controls.Add(Me.btnLegal)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnContact)
        Me.Controls.Add(Me.topArrow)
        Me.Controls.Add(Me.topHeaderBlank)
        Me.Controls.Add(Me.background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ctrlInfoMenu"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Info"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAbout As CButtonLib.CButton
    Friend WithEvents btnLegal As CButtonLib.CButton
    Friend WithEvents btnChangelog As CButtonLib.CButton
    Friend WithEvents btnFAQ As CButtonLib.CButton
    Friend WithEvents btnContact As CButtonLib.CButton
    Friend WithEvents btnSettings As CButtonLib.CButton
    Friend WithEvents topArrow As CButtonLib.CButton
    Friend WithEvents topHeaderBlank As CButtonLib.CButton
    Friend WithEvents background As CButtonLib.CButton
End Class
