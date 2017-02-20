<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDownloadClient
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
        Me.LblTitleProgress = New System.Windows.Forms.Label()
        Me.LblLocation = New System.Windows.Forms.Label()
        Me.TextDownloadLocation = New System.Windows.Forms.Label()
        Me.TextDownloadSize = New System.Windows.Forms.Label()
        Me.LblSize = New System.Windows.Forms.Label()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.BtnCancel = New CButtonLib.CButton()
        Me.DownloadClientBg = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'LblTitleProgress
        '
        Me.LblTitleProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTitleProgress.AutoEllipsis = True
        Me.LblTitleProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblTitleProgress.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!)
        Me.LblTitleProgress.Location = New System.Drawing.Point(241, 175)
        Me.LblTitleProgress.Name = "LblTitleProgress"
        Me.LblTitleProgress.Size = New System.Drawing.Size(502, 25)
        Me.LblTitleProgress.TabIndex = 0
        Me.LblTitleProgress.Text = "Downloading..."
        Me.LblTitleProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblLocation
        '
        Me.LblLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblLocation.AutoSize = True
        Me.LblLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblLocation.Location = New System.Drawing.Point(308, 232)
        Me.LblLocation.Name = "LblLocation"
        Me.LblLocation.Size = New System.Drawing.Size(130, 19)
        Me.LblLocation.TabIndex = 1060
        Me.LblLocation.Text = "Download Location:"
        '
        'TextDownloadLocation
        '
        Me.TextDownloadLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextDownloadLocation.AutoEllipsis = True
        Me.TextDownloadLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TextDownloadLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextDownloadLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextDownloadLocation.Location = New System.Drawing.Point(440, 232)
        Me.TextDownloadLocation.Name = "TextDownloadLocation"
        Me.TextDownloadLocation.Size = New System.Drawing.Size(236, 20)
        Me.TextDownloadLocation.TabIndex = 1061
        Me.TextDownloadLocation.Text = "\Downloads\"
        Me.TextDownloadLocation.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextDownloadSize
        '
        Me.TextDownloadSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextDownloadSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TextDownloadSize.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextDownloadSize.Location = New System.Drawing.Point(349, 255)
        Me.TextDownloadSize.Name = "TextDownloadSize"
        Me.TextDownloadSize.Size = New System.Drawing.Size(327, 17)
        Me.TextDownloadSize.TabIndex = 1065
        Me.TextDownloadSize.Text = "MB"
        Me.TextDownloadSize.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblSize
        '
        Me.LblSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSize.AutoSize = True
        Me.LblSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblSize.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblSize.Location = New System.Drawing.Point(308, 255)
        Me.LblSize.Name = "LblSize"
        Me.LblSize.Size = New System.Drawing.Size(35, 19)
        Me.LblSize.TabIndex = 1064
        Me.LblSize.Text = "Size:"
        '
        'prgBar
        '
        Me.prgBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prgBar.Location = New System.Drawing.Point(225, 209)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(536, 12)
        Me.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgBar.TabIndex = 1066
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCancel.BorderColor = System.Drawing.Color.White
        Me.BtnCancel.BorderShow = False
        Me.BtnCancel.ColorFillSolid = System.Drawing.Color.Firebrick
        Me.BtnCancel.Corners.All = 3
        Me.BtnCancel.Corners.LowerLeft = 3
        Me.BtnCancel.Corners.LowerRight = 3
        Me.BtnCancel.Corners.UpperLeft = 3
        Me.BtnCancel.Corners.UpperRight = 3
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DesignerSelected = False
        Me.BtnCancel.DimFactorClick = -30
        Me.BtnCancel.DimFactorHover = -20
        Me.BtnCancel.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCancel.ImageIndex = 0
        Me.BtnCancel.Location = New System.Drawing.Point(442, 294)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnCancel.Size = New System.Drawing.Size(100, 34)
        Me.BtnCancel.TabIndex = 1058
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextShadowShow = False
        '
        'DownloadClientBg
        '
        Me.DownloadClientBg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DownloadClientBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.DownloadClientBg.BorderShow = False
        Me.DownloadClientBg.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.DownloadClientBg.Corners.All = 4
        Me.DownloadClientBg.Corners.LowerLeft = 4
        Me.DownloadClientBg.Corners.LowerRight = 4
        Me.DownloadClientBg.Corners.UpperLeft = 4
        Me.DownloadClientBg.Corners.UpperRight = 4
        Me.DownloadClientBg.DesignerSelected = False
        Me.DownloadClientBg.DimFactorClick = 0
        Me.DownloadClientBg.DimFactorHover = 0
        Me.DownloadClientBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.DownloadClientBg.FocalPoints.CenterPtX = 0!
        Me.DownloadClientBg.FocalPoints.CenterPtY = 0!
        Me.DownloadClientBg.ImageIndex = 0
        Me.DownloadClientBg.Location = New System.Drawing.Point(187, 159)
        Me.DownloadClientBg.Name = "DownloadClientBg"
        Me.DownloadClientBg.Size = New System.Drawing.Size(612, 190)
        Me.DownloadClientBg.TabIndex = 1059
        Me.DownloadClientBg.Text = ""
        '
        'frmDownloadClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 508)
        Me.Controls.Add(Me.prgBar)
        Me.Controls.Add(Me.TextDownloadSize)
        Me.Controls.Add(Me.LblSize)
        Me.Controls.Add(Me.TextDownloadLocation)
        Me.Controls.Add(Me.LblLocation)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblTitleProgress)
        Me.Controls.Add(Me.DownloadClientBg)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDownloadClient"
        Me.Opacity = 0.97R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloading Movie..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitleProgress As Label
    Public WithEvents BtnCancel As CButtonLib.CButton
    Friend WithEvents DownloadClientBg As CButtonLib.CButton
    Friend WithEvents LblLocation As Label
    Friend WithEvents TextDownloadLocation As Label
    Friend WithEvents TextDownloadSize As Label
    Friend WithEvents LblSize As Label
    Friend WithEvents prgBar As ProgressBar
End Class
