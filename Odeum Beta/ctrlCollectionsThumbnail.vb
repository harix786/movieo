Public Class ctrlCollectionsThumbnail
    Private Sub ctrlCollectionsThumbnail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InfoPoster_MouseEnter(sender As Object, e As EventArgs) Handles imgCollectionsThumbnail.MouseEnter
        Try
            imgCollectionsThumbnail.BorderShow = True
            If Not imgCollectionsThumbnailDefault.Image Is Nothing Then
                imgCollectionsThumbnailDefault.Image.Dispose()
            End If
            imgCollectionsThumbnailDefault.Image = New Bitmap(imgCollectionsThumbnail.BackgroundImage)
            imgCollectionsThumbnail.BackgroundImage.Dispose()
            imgCollectionsThumbnail.BackgroundImage = ctrlPosterTitle.ChangeOpacity(imgCollectionsThumbnailDefault.Image, 0.4)
            imgCollectionsThumbnail.BorderShow = True
            Update()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InfoPoster_MouseLeave(sender As Object, e As EventArgs) Handles imgCollectionsThumbnail.MouseLeave
        Try
            imgCollectionsThumbnail.BackgroundImage.Dispose()
            imgCollectionsThumbnail.BackgroundImage = ctrlPosterTitle.ChangeOpacity(imgCollectionsThumbnailDefault.Image, 1)
            imgCollectionsThumbnail.BorderShow = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub imgCollectionsThumbnail_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles imgCollectionsThumbnail.ClickButtonArea
        Movieo.panelCollectionsMovies.Controls.Clear()

        Dim countMovie As Integer = 0

        Movieo.lblCollectionsTitle.Text = lblCollectionsTitle.Text
        Movieo.lblCollectionsComment.Text = lblCollectionsComment.Text

        For Each a In Movieo.storeControlsAllMovies
            For Each ab As Control In a.Controls
                If ab.Name = "InfoImdbId" Then
                    If itemsCollectionsMovies.Items.Contains(ab.Text) Then
                        countMovie = countMovie + 1
                        If countMovie <= 40 Then
                            Movieo.panelCollectionsMovies.Controls.Add(a)
                        Else
                            Movieo.storeControlsCollectionsScroll.Add(a)
                        End If
                    End If
                End If
            Next
        Next

        Movieo.lblCollectionMoviesWatched.Text = itemsCollectionsMovies.Items.Count.ToString + " movies"

        Movieo.tabsCollections.SelectedTab = Movieo.tabCollectionsMovies
    End Sub
End Class