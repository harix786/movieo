<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TabPageError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabPageError))
        Me.TextError = New System.Windows.Forms.Label()
        Me.BtnRestart = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'TextError
        '
        Me.TextError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextError.Font = New System.Drawing.Font("Segoe UI", 19.5!, System.Drawing.FontStyle.Bold)
        Me.TextError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TextError.Location = New System.Drawing.Point(223, 98)
        Me.TextError.Name = "TextError"
        Me.TextError.Size = New System.Drawing.Size(758, 81)
        Me.TextError.TabIndex = 9999
        Me.TextError.Text = "Oops!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Something's gone wrong..."
        Me.TextError.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnRestart
        '
        Me.BtnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnRestart.BackColor = System.Drawing.Color.Transparent
        Me.BtnRestart.BorderColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnRestart.ColorFillSolid = System.Drawing.Color.Transparent
        Me.BtnRestart.Corners.All = 2
        Me.BtnRestart.Corners.LowerLeft = 2
        Me.BtnRestart.Corners.LowerRight = 2
        Me.BtnRestart.Corners.UpperLeft = 2
        Me.BtnRestart.Corners.UpperRight = 2
        Me.BtnRestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestart.DesignerSelected = False
        Me.BtnRestart.DimFactorClick = 0
        Me.BtnRestart.DimFactorHover = 0
        Me.BtnRestart.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnRestart.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestart.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.BtnRestart.ImageIndex = 0
        Me.BtnRestart.Location = New System.Drawing.Point(538, 236)
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnRestart.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRestart.SideImageBehindText = False
        Me.BtnRestart.SideImageIsClickable = True
        Me.BtnRestart.SideImageSize = New System.Drawing.Size(20, 20)
        Me.BtnRestart.Size = New System.Drawing.Size(128, 37)
        Me.BtnRestart.TabIndex = 0
        Me.BtnRestart.Text = "Restart"
        Me.BtnRestart.TextShadowShow = False
        '
        'TabPageError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1205, 545)
        Me.Controls.Add(Me.BtnRestart)
        Me.Controls.Add(Me.TextError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TabPageError"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Oops!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextError As Label
    Public WithEvents BtnRestart As CButtonLib.CButton
End Class
