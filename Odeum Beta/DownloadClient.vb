Imports System.ComponentModel
Imports System.Net

Public Class DownloadClient
    Private Sub DownloadClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 28
        Left = 0
        Size = New Size(Movieo.Size.Width, Movieo.Size.Height - Movieo.AppTitle.Size.Height)
        BtnCancel.Text = "Cancel"
    End Sub

    Dim client As WebClient = New WebClient

    Public Sub DownloadMovie(MovieLink As String, MovieTitle As String, MovieYear As String, MovieExtension As String)
        Try
            Dim DownloadDirectory As String = Movieo.DownloadLocation + MovieTitle + " (" + MovieYear + ")." + MovieExtension
            TextDownloadLocation.Text = DownloadDirectory
            My.Settings.TempMovieTitleYear = MovieTitle + " "
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            client.DownloadFileAsync(New Uri(MovieLink), DownloadDirectory)
            LblMovie.Text = "Downloading: " + MovieTitle
        Catch ex As Exception
            Movieo.ShowPopupError("Unable to download movie.", ex.Message)
        End Try
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
            Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
            Dim percentage As Double = bytesIn / totalBytes * 100

            Progress.Value = Int32.Parse(Math.Truncate(percentage).ToString())

            LblMovie.Text = "Downloading " + My.Settings.TempMovieTitleYear + "(" + Progress.Value.ToString + "%)"
            Dim SmallFormat As String = FormatBytes(e.BytesReceived).ToString
            Dim RemovedKB As String = SmallFormat.Substring(0, SmallFormat.Length - 3)
            TextDownloadSize.Text = RemovedKB + "/" + FormatBytes(e.TotalBytesToReceive)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        If e.Cancelled = False Then
            LblMovie.Text = "Download Completed!"
            BtnCancel.Text = "Close"
        End If
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
                    DoubleBytes = BytesCaller ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function

    Private Sub CButton2_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles BtnCancel.ClickButtonArea
        client.CancelAsync()
        client.Dispose()
        Close()
    End Sub

End Class