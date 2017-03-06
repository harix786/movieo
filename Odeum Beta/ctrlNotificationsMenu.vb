Imports System.Net

Public Class ctrlNotificationsMenu
    Private Sub ctrlNotificationsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tab.SelectedTab = tabLoading
        timerGetItems.Enabled = True
    End Sub

    Private Sub timerGetItems_Tick(sender As Object, e As EventArgs) Handles timerGetItems.Tick
        Try
            Dim countItem As Integer = 0
            Dim objDl As New WebClient
            Dim NotificationDb As String = objDl.DownloadString(Movieo.linkNotifications)
            Dim LineByLine() As String = Split(NotificationDb, vbNewLine) 'Split db into lines

            For Each MessageText As String In LineByLine.Reverse
                Dim NotifText As String() = Split(MessageText, "|") 'Split text line into Id, Image & Message
                If Not MessageText = "" Then 'If message isn't blank
                    countItem = countItem + 1
                    Dim a As New ctrlNotification
                    a.PictureBox1.Image = Movieo.ConvertImageText(NotifText(1)) 'Set appropriate image
                    a.LblNotifNumber.Text = NotifText(0) 'Set notification id
                    a.LblNotification.Text = NotifText(2) 'Set text to current message text received
                    If Not Movieo.itemsNotificationList.Items.Contains(NotifText(0)) Then 'If user hasn't seen the notification (by id)
                        a.imgIsNew.Visible = True
                    End If
                    If countItem = LineByLine.Length Then
                        a.background.BorderShow = False
                    End If
                    panelNotifications.SetFlowBreak(a, True)
                    a.Size = New Size(panelNotifications.Size.Width - 24, a.Size.Height)
                    a.TopLevel = False
                    a.Show()
                    Movieo.itemsNotificationList.Items.Add(NotifText(0))
                    panelNotifications.Controls.Add(a) 'Add to notifications panel
                End If
            Next
            tab.SelectedTab = tabNotifications
            timerGetItems.Enabled = False
        Catch ex As Exception
            labelLoading.Text = "Unable to get notifications." + vbNewLine + ex.Message
            timerGetItems.Enabled = False
        End Try
    End Sub

    Private Sub OnDeactivated_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
        Movieo.IsNotificationsOpen = False
        Movieo.AppNotifications.Image = My.Resources.notificationsIconL
        Hide()
    End Sub

    Private Sub OnMouseDown_MouseDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseDown
        Movieo.IsNotificationsOpen = False
        Movieo.AppNotifications.Image = My.Resources.notificationsIconL
        'MyBase.OnMouseDown(e)
        Hide()
    End Sub

    Private Sub OnKeyDown_KeyDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.KeyDown
        Movieo.IsNotificationsOpen = False
        Movieo.AppNotifications.Image = My.Resources.notificationsIconL
        'MyBase.OnKeyDown(e)
        Hide()
    End Sub

    Private Sub OnLostFocus_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.LostFocus
        Movieo.IsNotificationsOpen = False
        Movieo.AppNotifications.Image = My.Resources.notificationsIconL
        'MyBase.OnLostFocus(e)
        Hide()
    End Sub
End Class