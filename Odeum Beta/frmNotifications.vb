Imports System.Net

Public Class frmNotifications
    Private Sub frmNotifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 24
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.ClientSize

        timerGetNotifications.Enabled = True
    End Sub

    Private Sub timerGetNotifications_Tick(sender As Object, e As EventArgs) Handles timerGetNotifications.Tick
        Try
            Dim countItem As Integer = 0
            Dim objDl As New WebClient
            Dim NotificationDb As String = objDl.DownloadString(Movieo.linkNotifications)
            Dim LineByLine() As String = Split(NotificationDb, vbNewLine) 'Split db into lines

            For Each MessageText As String In LineByLine.Reverse
                Dim NotifText As String() = Split(MessageText, "|") 'Split text line into Id, Image & Message
                If Not MessageText = "" Then 'If message isn't blank
                    addControl(NotifText(1), NotifText(2), NotifText(3))
                End If
            Next
            lblStatus.Visible = False
            panelNotifications.Visible = True
            timerGetNotifications.Enabled = False
        Catch ex As Exception
            panelNotifications.Visible = False
            lblStatus.Text = "Notifications can't be loaded right now." + vbNewLine + vbNewLine + ex.Message
            lblStatus.Visible = True
            timerGetNotifications.Enabled = False
        End Try
    End Sub

    Private Sub addControl(notifDate As String, notifTag As String, notifMessage As String)
        Dim lblTag As New CButtonLib.CButton
        lblTag.FillType = CButtonLib.CButton.eFillType.Solid
        lblTag.DimFactorClick = 0
        lblTag.DimFactorHover = 0
        If notifTag = "NEW MOVIE" Then
            lblTag.Text = "NEW MOVIE"
            lblTag.Size = New Size(95, 21)
            lblTag.ColorFillSolid = Color.SteelBlue
            lblTag.BorderColor = Color.SteelBlue
        ElseIf notifTag = "INFO" Then
            lblTag.Text = "INFO"
            lblTag.Size = New Size(52, 21)
            lblTag.ColorFillSolid = Color.DarkViolet
            lblTag.BorderColor = Color.DarkViolet
        ElseIf notifTag = "QUESTION" Then
            lblTag.Text = "QUESTION"
            lblTag.Size = New Size(85, 21)
            lblTag.ColorFillSolid = Color.DodgerBlue
            lblTag.BorderColor = Color.DodgerBlue
        ElseIf notifTag = "WARNING" Then
            lblTag.Text = "WARNING"
            lblTag.Size = New Size(85, 21)
            lblTag.ColorFillSolid = Color.Goldenrod
            lblTag.BorderColor = Color.Goldenrod
        ElseIf notifTag = "IMPORTANT" Then
            lblTag.Text = "IMPORTANT"
            lblTag.Size = New Size(96, 21)
            lblTag.ColorFillSolid = Color.Red
            lblTag.BorderColor = Color.Red
        ElseIf notifTag = "TIP" Then
            lblTag.Text = "TIP"
            lblTag.Size = New Size(41, 21)
            lblTag.ColorFillSolid = Color.Green
            lblTag.BorderColor = Color.Green
        ElseIf notifTag = "HELP" Then
            lblTag.Text = "HELP"
            lblTag.Size = New Size(52, 21)
            lblTag.ColorFillSolid = Color.MediumPurple
            lblTag.BorderColor = Color.MediumPurple
        End If
        lblTag.Font = Movieo.CreateFont("Segoe UI", 14, False, False, False)
        lblTag.TextShadowShow = False
        lblTag.Corners.All = 2
        lblTag.ShowFocus = CButtonLib.CButton.eFocus.None
        lblTag.TextMargin = New Padding(1, 3, 0, 2)
        lblTag.ForeColor = Color.White
        lblTag.Show()
        panelNotifications.Controls.Add(lblTag)

        Dim lblDate As New Label
        lblDate.Text = frmMovieDetails.TimeAgo(notifDate).ToLower
        lblDate.ForeColor = Color.FromArgb(150, 159, 170)
        lblDate.AutoSize = True
        lblDate.Margin = New Padding(0, 2, 0, 0)
        lblDate.Font = Movieo.CreateFont("Segoe UI", 10, True, False, False)
        lblDate.Show()
        panelNotifications.Controls.Add(lblDate)
        panelNotifications.SetFlowBreak(lblDate, True)

        Dim lblMessage As New Label
        lblMessage.Font = Movieo.CreateFont("Segoe UI", 14.25, False, False, False)
        lblMessage.Text = notifMessage
        lblMessage.ForeColor = Color.FromArgb(150, 159, 170)
        lblMessage.Margin = New Padding(0, 5, 0, 0)
        lblMessage.AutoSize = True
        lblMessage.Show()
        panelNotifications.Controls.Add(lblMessage)
        panelNotifications.SetFlowBreak(lblMessage, True)

        Dim splitter As New Label
        splitter.Text = "--------------------------------------------------------------------------------------------"
        splitter.Margin = New Padding(0, 15, 0, 15)
        splitter.AutoSize = False
        splitter.Size = New Size(panelNotifications.Size.Width - 2, 30)
        splitter.Font = Movieo.CreateFont("Segoe UI", 15, True, False, False)
        splitter.ForeColor = Color.FromArgb(58, 70, 84)
        splitter.Show()
        panelNotifications.Controls.Add(splitter)
        panelNotifications.SetFlowBreak(splitter, True)
    End Sub

    Private Sub meClose_Click(sender As Object, e As EventArgs) Handles meClose.Click
        Close()
    End Sub

    Private Sub meClose_MouseMove(sender As Object, e As MouseEventArgs) Handles meClose.MouseMove
        meClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub meClose_MouseLeave(sender As Object, e As EventArgs) Handles meClose.MouseLeave
        meClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub frmNotifications_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        Update()
    End Sub
End Class