<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrailerPlayer
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
        Me.web = New System.Windows.Forms.WebBrowser()
        Me.appClose = New System.Windows.Forms.PictureBox()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'web
        '
        Me.web.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web.Location = New System.Drawing.Point(80, 64)
        Me.web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.web.Name = "web"
        Me.web.ScriptErrorsSuppressed = True
        Me.web.ScrollBarsEnabled = False
        Me.web.Size = New System.Drawing.Size(1058, 604)
        Me.web.TabIndex = 0
        '
        'appClose
        '
        Me.appClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.appClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.appClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.appClose.Location = New System.Drawing.Point(1178, 12)
        Me.appClose.Name = "appClose"
        Me.appClose.Size = New System.Drawing.Size(28, 28)
        Me.appClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.appClose.TabIndex = 49
        Me.appClose.TabStop = False
        '
        'frmTrailerPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1218, 733)
        Me.Controls.Add(Me.appClose)
        Me.Controls.Add(Me.web)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTrailerPlayer"
        Me.Opacity = 0.97R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Watch Tailer"
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents web As WebBrowser
    Friend WithEvents appClose As PictureBox
End Class
