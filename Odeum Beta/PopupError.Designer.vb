<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopupError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopupError))
        Me.BtnSubmit = New CButtonLib.CButton()
        Me.DialogMessage = New System.Windows.Forms.Label()
        Me.DialogTitle = New System.Windows.Forms.Label()
        Me.DialogLine = New System.Windows.Forms.Label()
        Me.DialogBackground = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSubmit.BackColor = System.Drawing.Color.White
        Me.BtnSubmit.BorderColor = System.Drawing.Color.White
        Me.BtnSubmit.BorderShow = False
        Me.BtnSubmit.ColorFillSolid = System.Drawing.Color.SteelBlue
        Me.BtnSubmit.Corners.All = 3
        Me.BtnSubmit.Corners.LowerLeft = 3
        Me.BtnSubmit.Corners.LowerRight = 3
        Me.BtnSubmit.Corners.UpperLeft = 3
        Me.BtnSubmit.Corners.UpperRight = 3
        Me.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubmit.DesignerSelected = False
        Me.BtnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnSubmit.DimFactorHover = -25
        Me.BtnSubmit.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnSubmit.FocalPoints.CenterPtX = 0!
        Me.BtnSubmit.FocalPoints.CenterPtY = 0!
        Me.BtnSubmit.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.BtnSubmit.ImageIndex = 0
        Me.BtnSubmit.Location = New System.Drawing.Point(412, 153)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnSubmit.Size = New System.Drawing.Size(119, 33)
        Me.BtnSubmit.TabIndex = 1065
        Me.BtnSubmit.Text = "Okay"
        Me.BtnSubmit.TextShadowShow = False
        '
        'DialogMessage
        '
        Me.DialogMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DialogMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DialogMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.DialogMessage.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.DialogMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DialogMessage.Location = New System.Drawing.Point(13, 51)
        Me.DialogMessage.Name = "DialogMessage"
        Me.DialogMessage.Size = New System.Drawing.Size(520, 96)
        Me.DialogMessage.TabIndex = 1068
        Me.DialogMessage.Text = "Dialog Message"
        '
        'DialogTitle
        '
        Me.DialogTitle.AutoSize = True
        Me.DialogTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DialogTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.DialogTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DialogTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DialogTitle.Location = New System.Drawing.Point(12, 9)
        Me.DialogTitle.Name = "DialogTitle"
        Me.DialogTitle.Size = New System.Drawing.Size(110, 25)
        Me.DialogTitle.TabIndex = 1066
        Me.DialogTitle.Text = "Dialog Title"
        '
        'DialogLine
        '
        Me.DialogLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DialogLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DialogLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.DialogLine.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DialogLine.ForeColor = System.Drawing.Color.Silver
        Me.DialogLine.Location = New System.Drawing.Point(-30, 28)
        Me.DialogLine.Name = "DialogLine"
        Me.DialogLine.Size = New System.Drawing.Size(595, 16)
        Me.DialogLine.TabIndex = 1067
        Me.DialogLine.Text = "_________________________________________________________________________________" &
    "______________________________________________________"
        '
        'DialogBackground
        '
        Me.DialogBackground.BackColor = System.Drawing.Color.Black
        Me.DialogBackground.BorderColor = System.Drawing.Color.White
        Me.DialogBackground.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DialogBackground.Corners.All = 3
        Me.DialogBackground.Corners.LowerLeft = 3
        Me.DialogBackground.Corners.LowerRight = 3
        Me.DialogBackground.Corners.UpperLeft = 3
        Me.DialogBackground.Corners.UpperRight = 3
        Me.DialogBackground.DesignerSelected = False
        Me.DialogBackground.DimFactorClick = 0
        Me.DialogBackground.DimFactorHover = 0
        Me.DialogBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DialogBackground.FillType = CButtonLib.CButton.eFillType.Solid
        Me.DialogBackground.ForeColor = System.Drawing.Color.Black
        Me.DialogBackground.ImageIndex = 0
        Me.DialogBackground.Location = New System.Drawing.Point(0, 0)
        Me.DialogBackground.Name = "DialogBackground"
        Me.DialogBackground.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.DialogBackground.Size = New System.Drawing.Size(545, 200)
        Me.DialogBackground.TabIndex = 1069
        Me.DialogBackground.Text = ""
        '
        'PopupError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(545, 200)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.DialogMessage)
        Me.Controls.Add(Me.DialogTitle)
        Me.Controls.Add(Me.DialogLine)
        Me.Controls.Add(Me.DialogBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopupError"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PopupError"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents BtnSubmit As CButtonLib.CButton
    Friend WithEvents DialogMessage As Label
    Friend WithEvents DialogTitle As Label
    Friend WithEvents DialogLine As Label
    Friend WithEvents DialogBackground As CButtonLib.CButton
End Class
