<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlNotificationsMenu
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
        Me.topArrow = New CButtonLib.CButton()
        Me.topHeaderBlank = New CButtonLib.CButton()
        Me.tab = New System.Windows.Forms.TabControl()
        Me.tabLoading = New System.Windows.Forms.TabPage()
        Me.labelLoading = New System.Windows.Forms.Label()
        Me.background0 = New CButtonLib.CButton()
        Me.tabNotifications = New System.Windows.Forms.TabPage()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.panelNotifications = New System.Windows.Forms.FlowLayoutPanel()
        Me.background1 = New CButtonLib.CButton()
        Me.timerGetItems = New System.Windows.Forms.Timer(Me.components)
        Me.tab.SuspendLayout()
        Me.tabLoading.SuspendLayout()
        Me.tabNotifications.SuspendLayout()
        Me.SuspendLayout()
        '
        'topArrow
        '
        Me.topArrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.topArrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.topArrow.BorderColor = System.Drawing.Color.Gray
        Me.topArrow.ColorFillSolid = System.Drawing.Color.Gray
        Me.topArrow.DesignerSelected = False
        Me.topArrow.DimFactorClick = 0
        Me.topArrow.DimFactorHover = 0
        Me.topArrow.FillType = CButtonLib.CButton.eFillType.Solid
        Me.topArrow.ImageIndex = 0
        Me.topArrow.Location = New System.Drawing.Point(370, 4)
        Me.topArrow.Name = "topArrow"
        Me.topArrow.Shape = CButtonLib.CButton.eShape.TriangleUp
        Me.topArrow.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.topArrow.Size = New System.Drawing.Size(14, 8)
        Me.topArrow.TabIndex = 2
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
        Me.topHeaderBlank.Size = New System.Drawing.Size(400, 16)
        Me.topHeaderBlank.TabIndex = 3
        Me.topHeaderBlank.Text = ""
        '
        'tab
        '
        Me.tab.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tab.Controls.Add(Me.tabLoading)
        Me.tab.Controls.Add(Me.tabNotifications)
        Me.tab.Location = New System.Drawing.Point(-4, -10)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(408, 239)
        Me.tab.TabIndex = 4
        '
        'tabLoading
        '
        Me.tabLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLoading.Controls.Add(Me.labelLoading)
        Me.tabLoading.Controls.Add(Me.background0)
        Me.tabLoading.Location = New System.Drawing.Point(4, 22)
        Me.tabLoading.Name = "tabLoading"
        Me.tabLoading.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLoading.Size = New System.Drawing.Size(400, 213)
        Me.tabLoading.TabIndex = 0
        Me.tabLoading.Text = "tabLoading"
        '
        'labelLoading
        '
        Me.labelLoading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelLoading.AutoEllipsis = True
        Me.labelLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.labelLoading.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLoading.ForeColor = System.Drawing.Color.White
        Me.labelLoading.Location = New System.Drawing.Point(53, 43)
        Me.labelLoading.Name = "labelLoading"
        Me.labelLoading.Size = New System.Drawing.Size(294, 126)
        Me.labelLoading.TabIndex = 12
        Me.labelLoading.Text = "Loading..."
        Me.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'background0
        '
        Me.background0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.background0.BackColor = System.Drawing.Color.Gray
        Me.background0.BorderColor = System.Drawing.Color.Gray
        Me.background0.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.background0.DesignerSelected = False
        Me.background0.DimFactorClick = 0
        Me.background0.DimFactorHover = 0
        Me.background0.FillType = CButtonLib.CButton.eFillType.Solid
        Me.background0.ImageIndex = 0
        Me.background0.Location = New System.Drawing.Point(0, 0)
        Me.background0.Name = "background0"
        Me.background0.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.background0.Size = New System.Drawing.Size(400, 213)
        Me.background0.TabIndex = 11
        Me.background0.Text = " "
        '
        'tabNotifications
        '
        Me.tabNotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabNotifications.Controls.Add(Me.labelTitle)
        Me.tabNotifications.Controls.Add(Me.panelNotifications)
        Me.tabNotifications.Controls.Add(Me.background1)
        Me.tabNotifications.Location = New System.Drawing.Point(4, 22)
        Me.tabNotifications.Name = "tabNotifications"
        Me.tabNotifications.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNotifications.Size = New System.Drawing.Size(400, 213)
        Me.tabNotifications.TabIndex = 1
        Me.tabNotifications.Text = "tabNotifications"
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.White
        Me.labelTitle.Location = New System.Drawing.Point(9, 9)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(88, 17)
        Me.labelTitle.TabIndex = 9
        Me.labelTitle.Text = "Notifications"
        '
        'panelNotifications
        '
        Me.panelNotifications.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelNotifications.AutoScroll = True
        Me.panelNotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelNotifications.Location = New System.Drawing.Point(1, 32)
        Me.panelNotifications.Name = "panelNotifications"
        Me.panelNotifications.Size = New System.Drawing.Size(398, 180)
        Me.panelNotifications.TabIndex = 8
        '
        'background1
        '
        Me.background1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.background1.BackColor = System.Drawing.Color.Gray
        Me.background1.BorderColor = System.Drawing.Color.Gray
        Me.background1.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.background1.DesignerSelected = False
        Me.background1.DimFactorClick = 0
        Me.background1.DimFactorHover = 0
        Me.background1.FillType = CButtonLib.CButton.eFillType.Solid
        Me.background1.ImageIndex = 0
        Me.background1.Location = New System.Drawing.Point(0, 0)
        Me.background1.Name = "background1"
        Me.background1.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.background1.Size = New System.Drawing.Size(400, 213)
        Me.background1.TabIndex = 10
        Me.background1.Text = " "
        '
        'timerGetItems
        '
        Me.timerGetItems.Interval = 500
        '
        'ctrlNotificationsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 225)
        Me.Controls.Add(Me.topArrow)
        Me.Controls.Add(Me.topHeaderBlank)
        Me.Controls.Add(Me.tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ctrlNotificationsMenu"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notifications"
        Me.tab.ResumeLayout(False)
        Me.tabLoading.ResumeLayout(False)
        Me.tabNotifications.ResumeLayout(False)
        Me.tabNotifications.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents topArrow As CButtonLib.CButton
    Friend WithEvents topHeaderBlank As CButtonLib.CButton
    Friend WithEvents tab As TabControl
    Friend WithEvents tabLoading As TabPage
    Friend WithEvents tabNotifications As TabPage
    Friend WithEvents labelTitle As Label
    Friend WithEvents panelNotifications As FlowLayoutPanel
    Friend WithEvents background1 As CButtonLib.CButton
    Friend WithEvents background0 As CButtonLib.CButton
    Friend WithEvents labelLoading As Label
    Friend WithEvents timerGetItems As Timer
End Class
