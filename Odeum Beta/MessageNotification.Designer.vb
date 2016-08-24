<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MessageNotification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageNotification))
        Me.appClose = New System.Windows.Forms.PictureBox()
        Me.LblNotification = New System.Windows.Forms.Label()
        Me.LblNotifNumber = New System.Windows.Forms.Label()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'appClose
        '
        Me.appClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.appClose.BackColor = System.Drawing.Color.Transparent
        Me.appClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.appClose.Location = New System.Drawing.Point(739, 10)
        Me.appClose.Name = "appClose"
        Me.appClose.Size = New System.Drawing.Size(14, 14)
        Me.appClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.appClose.TabIndex = 1053
        Me.appClose.TabStop = False
        '
        'LblNotification
        '
        Me.LblNotification.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNotification.AutoEllipsis = True
        Me.LblNotification.BackColor = System.Drawing.Color.Transparent
        Me.LblNotification.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotification.ForeColor = System.Drawing.Color.White
        Me.LblNotification.Location = New System.Drawing.Point(7, 3)
        Me.LblNotification.Name = "LblNotification"
        Me.LblNotification.Size = New System.Drawing.Size(720, 28)
        Me.LblNotification.TabIndex = 1057
        Me.LblNotification.Text = "Message to display..."
        Me.LblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNotifNumber
        '
        Me.LblNotifNumber.AutoSize = True
        Me.LblNotifNumber.ForeColor = System.Drawing.Color.White
        Me.LblNotifNumber.Location = New System.Drawing.Point(636, 12)
        Me.LblNotifNumber.Name = "LblNotifNumber"
        Me.LblNotifNumber.Size = New System.Drawing.Size(92, 13)
        Me.LblNotifNumber.TabIndex = 1058
        Me.LblNotifNumber.Text = "MSG # (HIDDEN)"
        Me.LblNotifNumber.Visible = False
        '
        'MessageNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 34)
        Me.Controls.Add(Me.LblNotifNumber)
        Me.Controls.Add(Me.LblNotification)
        Me.Controls.Add(Me.appClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MessageNotification"
        Me.Opacity = 0.5R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "MessageNotification"
        Me.TransparencyKey = System.Drawing.Color.DarkGray
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents appClose As PictureBox
    Friend WithEvents LblNotification As Label
    Friend WithEvents LblNotifNumber As Label
End Class
