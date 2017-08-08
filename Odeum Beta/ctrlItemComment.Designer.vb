<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlItemComment
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
        Me.infoUserComment = New System.Windows.Forms.Label()
        Me.infoUserName = New System.Windows.Forms.Label()
        Me.underline = New CButtonLib.CButton()
        Me.infoDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'infoUserComment
        '
        Me.infoUserComment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoUserComment.AutoEllipsis = True
        Me.infoUserComment.BackColor = System.Drawing.Color.Transparent
        Me.infoUserComment.Cursor = System.Windows.Forms.Cursors.Default
        Me.infoUserComment.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.infoUserComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.infoUserComment.Location = New System.Drawing.Point(2, 26)
        Me.infoUserComment.Name = "infoUserComment"
        Me.infoUserComment.Size = New System.Drawing.Size(451, 24)
        Me.infoUserComment.TabIndex = 1062
        Me.infoUserComment.Text = "Comment here..."
        '
        'infoUserName
        '
        Me.infoUserName.AutoSize = True
        Me.infoUserName.BackColor = System.Drawing.Color.Transparent
        Me.infoUserName.Cursor = System.Windows.Forms.Cursors.Default
        Me.infoUserName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.infoUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoUserName.Location = New System.Drawing.Point(2, 2)
        Me.infoUserName.Name = "infoUserName"
        Me.infoUserName.Size = New System.Drawing.Size(43, 21)
        Me.infoUserName.TabIndex = 1063
        Me.infoUserName.Text = "User"
        '
        'underline
        '
        Me.underline.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.underline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.underline.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.underline.Cursor = System.Windows.Forms.Cursors.Default
        Me.underline.DesignerSelected = False
        Me.underline.DimFactorClick = 0
        Me.underline.DimFactorHover = 0
        Me.underline.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.underline.FillType = CButtonLib.CButton.eFillType.Solid
        Me.underline.ImageIndex = 0
        Me.underline.Location = New System.Drawing.Point(0, 54)
        Me.underline.Name = "underline"
        Me.underline.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.underline.Size = New System.Drawing.Size(459, 1)
        Me.underline.TabIndex = 1066
        Me.underline.Text = ""
        '
        'infoDate
        '
        Me.infoDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoDate.BackColor = System.Drawing.Color.Transparent
        Me.infoDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.infoDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.infoDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.infoDate.Location = New System.Drawing.Point(334, 5)
        Me.infoDate.Name = "infoDate"
        Me.infoDate.Size = New System.Drawing.Size(124, 18)
        Me.infoDate.TabIndex = 1067
        Me.infoDate.Text = "a day ago"
        Me.infoDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ctrlItemComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 55)
        Me.Controls.Add(Me.infoDate)
        Me.Controls.Add(Me.infoUserName)
        Me.Controls.Add(Me.infoUserComment)
        Me.Controls.Add(Me.underline)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ctrlItemComment"
        Me.Text = "ctrlComment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents infoUserComment As Label
    Friend WithEvents infoUserName As Label
    Friend WithEvents underline As CButtonLib.CButton
    Friend WithEvents infoDate As Label
End Class
