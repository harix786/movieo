<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlItemNotificationUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlItemNotificationUpdate))
        Me.LblNotification = New System.Windows.Forms.Label()
        Me.BtnInstall = New CButtonLib.CButton()
        Me.PanelItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNotification
        '
        Me.LblNotification.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblNotification.AutoSize = True
        Me.LblNotification.BackColor = System.Drawing.Color.Transparent
        Me.LblNotification.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LblNotification.ForeColor = System.Drawing.Color.White
        Me.LblNotification.Location = New System.Drawing.Point(0, 3)
        Me.LblNotification.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.LblNotification.Name = "LblNotification"
        Me.LblNotification.Size = New System.Drawing.Size(155, 20)
        Me.LblNotification.TabIndex = 0
        Me.LblNotification.Text = "*VERSION MESSAGE*"
        '
        'BtnInstall
        '
        Me.BtnInstall.BackColor = System.Drawing.Color.Transparent
        Me.BtnInstall.BorderShow = False
        Me.BtnInstall.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BtnInstall.Corners.All = 3
        Me.BtnInstall.Corners.LowerLeft = 3
        Me.BtnInstall.Corners.LowerRight = 3
        Me.BtnInstall.Corners.UpperLeft = 3
        Me.BtnInstall.Corners.UpperRight = 3
        Me.BtnInstall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInstall.DesignerSelected = False
        Me.BtnInstall.DimFactorHover = -25
        Me.BtnInstall.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnInstall.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInstall.ImageIndex = 0
        Me.BtnInstall.Location = New System.Drawing.Point(157, 4)
        Me.BtnInstall.Margin = New System.Windows.Forms.Padding(0, 4, 3, 3)
        Me.BtnInstall.Name = "BtnInstall"
        Me.BtnInstall.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnInstall.Size = New System.Drawing.Size(107, 20)
        Me.BtnInstall.TabIndex = 1050
        Me.BtnInstall.Text = "Install Now..."
        Me.BtnInstall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInstall.TextMargin = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.BtnInstall.TextShadowShow = False
        '
        'PanelItems
        '
        Me.PanelItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelItems.BackColor = System.Drawing.Color.Transparent
        Me.PanelItems.Controls.Add(Me.LblNotification)
        Me.PanelItems.Controls.Add(Me.BtnInstall)
        Me.PanelItems.Location = New System.Drawing.Point(4, 3)
        Me.PanelItems.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.PanelItems.Name = "PanelItems"
        Me.PanelItems.Size = New System.Drawing.Size(760, 28)
        Me.PanelItems.TabIndex = 1052
        '
        'ctrlNotificationUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 34)
        Me.Controls.Add(Me.PanelItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ctrlNotificationUpdate"
        Me.Opacity = 0.5R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "UpdateNotification"
        Me.TransparencyKey = System.Drawing.Color.DarkGray
        Me.PanelItems.ResumeLayout(False)
        Me.PanelItems.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblNotification As Label
    Public WithEvents BtnInstall As CButtonLib.CButton
    Friend WithEvents PanelItems As FlowLayoutPanel
End Class
