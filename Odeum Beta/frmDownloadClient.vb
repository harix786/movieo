Imports System.ComponentModel
Imports System.Net

Public Class frmDownloadClient
    Private Sub DownloadClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitleProgress.Text = "Connecting..."
        Top = 28
        Left = 0
        Size = New Size(Movieo.Size.Width, Movieo.Size.Height)
        BtnCancel.Text = "Cancel"
    End Sub

    Dim client As WebClient = New WebClient

    Dim TitleAndYear As String
    Dim Title As String

    Public Sub doDownload(MovieLink As String, MovieTitle As String, MovieYear As String, MovieExtension As String)
        Try
            LblTitleProgress.Text = "Connecting..."
            If Not My.Computer.FileSystem.DirectoryExists(Movieo.pathDownloads) Then
                My.Computer.FileSystem.CreateDirectory(Movieo.pathDownloads)
            End If
            TitleAndYear = MovieTitle + " (" + MovieYear + ")"
            Title = MovieTitle
            Dim DownloadDirectory As String = Movieo.pathDownloads + TitleAndYear + "." + MovieExtension
            TextDownloadLocation.Text = DownloadDirectory
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            client.DownloadFileAsync(New Uri(MovieLink), DownloadDirectory)
        Catch ex As Exception
            Movieo.ShowPopupOk("Unable to download movie.", ex.Message, Me)
        End Try
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
            Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
            Dim percentage As Double = bytesIn / totalBytes * 100

            prgBar.Value = Int32.Parse(Math.Truncate(percentage).ToString())

            LblTitleProgress.Text = "Downloading " + Title + " (" + prgBar.Value.ToString + "%)"
            Dim SmallFormat As String = FormatBytes(e.BytesReceived).ToString
            TextDownloadSize.Text = SmallFormat + "/" + FormatBytes(e.TotalBytesToReceive)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        Try
            If Not e.Cancelled AndAlso e.Error Is Nothing Then
                LblTitleProgress.Text = "Download Completed!"
                BtnCancel.Text = "Close"
            Else
                LblTitleProgress.Text = "Download Failed :("
                BtnCancel.Text = "Close"
                Movieo.ShowPopupOk("Unable to download movie.", e.Error.InnerException.Message, Me)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Bytes to Megabytes by Creator
    Dim DoubleBytes As Double
    Public Function FormatBytes(ByVal BytesCaller As ULong) As String
        Try
            Select Case BytesCaller
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(BytesCaller / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(BytesCaller / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(BytesCaller / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(BytesCaller / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = BytesCaller 'bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function

    Private Sub CButton2_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles BtnCancel.ClickButtonArea
        Try
            client.CancelAsync()
            client.Dispose()
            Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextDownloadLocation_Click(sender As Object, e As EventArgs) Handles TextDownloadLocation.Click
        Movieo.ShowFile(TextDownloadLocation.Text)
    End Sub
End Class