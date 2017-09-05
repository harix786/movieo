<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStartupTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartupTab))
        Me.txtLoading = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLoading
        '
        Me.txtLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLoading.AutoSize = True
        Me.txtLoading.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!)
        Me.txtLoading.ForeColor = System.Drawing.Color.White
        Me.txtLoading.Location = New System.Drawing.Point(129, 387)
        Me.txtLoading.MaximumSize = New System.Drawing.Size(730, 100)
        Me.txtLoading.MinimumSize = New System.Drawing.Size(730, 100)
        Me.txtLoading.Name = "txtLoading"
        Me.txtLoading.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.txtLoading.Size = New System.Drawing.Size(730, 100)
        Me.txtLoading.TabIndex = 1086
        Me.txtLoading.Text = "Loading, please wait..."
        Me.txtLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgLogo
        '
        Me.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgLogo.Image = Global.Movieo.My.Resources.Resources.Movieo_Glow
        Me.imgLogo.Location = New System.Drawing.Point(359, 88)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(271, 303)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'frmStartupTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(988, 562)
        Me.Controls.Add(Me.txtLoading)
        Me.Controls.Add(Me.imgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStartupTab"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Loading, please wait..."
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents txtLoading As Label
End Class
