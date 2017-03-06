Public Class ctrlInfoMenu

    Private Sub InfoContextMenu_Load(ByVal c As Object, ByVal e As EventArgs) Handles MyBase.Load
        ShowInTaskbar = False
        'InitializeComponent()
    End Sub

    Private Sub CButton1_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSettings.MouseMove, btnContact.MouseMove, btnChangelog.MouseMove, btnLegal.MouseMove, btnFAQ.MouseMove, btnAbout.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Public Sub CtrlsLeave_Leave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave, btnContact.MouseLeave, btnChangelog.MouseLeave, btnLegal.MouseLeave, btnFAQ.MouseLeave, btnAbout.MouseLeave
        sender.ForeColor = Color.FromArgb(166, 166, 166)
    End Sub

    Private Sub OnDeactivated_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
        Movieo.IsContextOpen = False
        Movieo.btnInfoMenu.Image = My.Resources.DropletsIconL
        Me.Hide()
    End Sub

    Private Sub OnMouseDown_MouseDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseDown
        Movieo.IsContextOpen = False
        Movieo.btnInfoMenu.Image = My.Resources.DropletsIconL
        'MyBase.OnMouseDown(e)
        Me.Hide()
    End Sub

    Private Sub OnKeyDown_KeyDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.KeyDown
        Movieo.IsContextOpen = False
        Movieo.btnInfoMenu.Image = My.Resources.DropletsIconL
        'MyBase.OnKeyDown(e)
        Me.Hide()
    End Sub

    Private Sub OnLostFocus_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.LostFocus
        Movieo.IsContextOpen = False
        Movieo.btnInfoMenu.Image = My.Resources.DropletsIconL
        'MyBase.OnLostFocus(e)
        Me.Hide()
    End Sub

    Private Sub btnAbout_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnAbout.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabAbout
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLegal_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnLegal.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabLegal
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnFAQ_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnFAQ.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabHelpFaq
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnChangelog_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnChangelog.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabChangelog
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnContact_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnContact.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            Movieo.InfoSelectedTab = frmInfo.tabContact
            frmInfo.Show(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSettings_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSettings.ClickButtonArea
        Try
            Movieo.IsContextOpen = False
            frmSettings.Show(Me)
        Catch ex As Exception
        End Try
    End Sub
End Class