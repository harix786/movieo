<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlNotification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlNotification))
        Me.LblNotification = New System.Windows.Forms.Label()
        Me.LblNotifNumber = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgIsNew = New CButtonLib.CButton()
        Me.background = New CButtonLib.CButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNotification
        '
        Me.LblNotification.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNotification.AutoEllipsis = True
        Me.LblNotification.BackColor = System.Drawing.Color.Transparent
        Me.LblNotification.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblNotification.ForeColor = System.Drawing.Color.White
        Me.LblNotification.Location = New System.Drawing.Point(48, 4)
        Me.LblNotification.Name = "LblNotification"
        Me.LblNotification.Size = New System.Drawing.Size(339, 38)
        Me.LblNotification.TabIndex = 1057
        Me.LblNotification.Text = "Message to display..."
        Me.LblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNotifNumber
        '
        Me.LblNotifNumber.AutoSize = True
        Me.LblNotifNumber.ForeColor = System.Drawing.Color.White
        Me.LblNotifNumber.Location = New System.Drawing.Point(279, 22)
        Me.LblNotifNumber.Name = "LblNotifNumber"
        Me.LblNotifNumber.Size = New System.Drawing.Size(104, 13)
        Me.LblNotifNumber.TabIndex = 1058
        Me.LblNotifNumber.Text = "MSG NO. (HIDDEN)"
        Me.LblNotifNumber.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.PictureBox1.Location = New System.Drawing.Point(20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1059
        Me.PictureBox1.TabStop = False
        '
        'imgIsNew
        '
        Me.imgIsNew.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.imgIsNew.BackColor = System.Drawing.Color.Transparent
        Me.imgIsNew.ColorFillSolid = System.Drawing.Color.SteelBlue
        Me.imgIsNew.DesignerSelected = False
        Me.imgIsNew.DimFactorClick = 0
        Me.imgIsNew.DimFactorHover = 0
        Me.imgIsNew.FillType = CButtonLib.CButton.eFillType.Solid
        Me.imgIsNew.ImageIndex = 0
        Me.imgIsNew.Location = New System.Drawing.Point(6, 21)
        Me.imgIsNew.Name = "imgIsNew"
        Me.imgIsNew.Shape = CButtonLib.CButton.eShape.Ellipse
        Me.imgIsNew.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.imgIsNew.Size = New System.Drawing.Size(6, 6)
        Me.imgIsNew.TabIndex = 1060
        Me.imgIsNew.Text = ""
        Me.imgIsNew.Visible = False
        '
        'background
        '
        Me.background.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.background.BorderColor = System.Drawing.Color.Gray
        Me.background.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.background.DesignerSelected = True
        Me.background.DimFactorClick = 0
        Me.background.DimFactorHover = 0
        Me.background.FillType = CButtonLib.CButton.eFillType.Solid
        Me.background.ImageIndex = 0
        Me.background.Location = New System.Drawing.Point(-1, -1)
        Me.background.Name = "background"
        Me.background.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.background.Size = New System.Drawing.Size(398, 48)
        Me.background.TabIndex = 1061
        Me.background.Text = "CButton1"
        '
        'ctrlNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(395, 47)
        Me.Controls.Add(Me.imgIsNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblNotification)
        Me.Controls.Add(Me.LblNotifNumber)
        Me.Controls.Add(Me.background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ctrlNotification"
        Me.Opacity = 0.5R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "MessageNotification"
        Me.TransparencyKey = System.Drawing.Color.DarkGray
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNotification As Label
    Friend WithEvents LblNotifNumber As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imgIsNew As CButtonLib.CButton
    Friend WithEvents background As CButtonLib.CButton
End Class
