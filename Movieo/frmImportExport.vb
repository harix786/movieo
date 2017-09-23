Imports System.IO

Public Class frmImportExport


#Region "Base"

    Private Sub frmImportExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set position/size of window
        Top = Movieo.ClientRectangle.Top + 23
        Left = Movieo.ClientRectangle.Left
        Size = Movieo.ClientSize

        cmboboxImportFrom.SelectedIndex = 0
        cmboboxImportTo.SelectedIndex = 0
        cmboboxExportFrom.SelectedIndex = 0
    End Sub

    'Prevent lag on scroll
    Private Sub MyBase_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        sender.Update()
    End Sub

#End Region

#Region "Close Window"

    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles meClose.MouseMove
        Try
            meClose.Image = My.Resources.PopupCloseH
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles meClose.MouseLeave
        Try
            meClose.Image = My.Resources.PopupCloseL
        Catch ex As Exception
        End Try
    End Sub

    Private Sub meClose_Click(sender As Object, e As EventArgs) Handles meClose.Click
        My.Settings.Save()
        Close()
    End Sub

#End Region

#Region "Tabs"

    Private Sub headerImport_Click(sender As Object, e As EventArgs) Handles headerImport.Click
        Tab.SelectedTab = tabImport
    End Sub

    Private Sub headerExport_Click(sender As Object, e As EventArgs) Handles headerExport.Click
        Tab.SelectedTab = tabExport
    End Sub

    Private Sub LblAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles headerExport.MouseMove, headerImport.MouseMove
        sender.ForeColor = SelectedTabColour
    End Sub

    Private Sub LblAbout_MouseLeave(sender As Object, e As EventArgs) Handles headerExport.MouseLeave, headerImport.MouseLeave
        If sender IsNot CurrentTab Then sender.ForeColor = NonSelectedTabColour
    End Sub

    Dim CurrentTab As Object = tabImport
    Dim SelectedTabColour As Color = Color.FromArgb(172, 180, 191)
    Dim NonSelectedTabColour As Color = Color.FromArgb(86, 98, 115)

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            CurrentTab = headerImport
            headerImport.ForeColor = SelectedTabColour
            headerExport.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 1 Then
            CurrentTab = headerExport
            headerImport.ForeColor = NonSelectedTabColour
            headerExport.ForeColor = SelectedTabColour
        End If
    End Sub

#End Region

#Region "Import"

    Private Sub cmboLblImportFrom_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboLblImportFrom.ClickButtonArea
        cmboboxImportFrom.DroppedDown = True
    End Sub

    Private Sub cmboboxWatchedMovies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxImportFrom.SelectedIndexChanged
        cmboLblImportFrom.Text = cmboboxImportFrom.SelectedItem.ToString
    End Sub

    Private Sub cmboLblImportTo_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboLblImportTo.ClickButtonArea
        cmboboxImportTo.DroppedDown = True
    End Sub

    Private Sub cmboboxImportTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxImportTo.SelectedIndexChanged
        cmboLblImportTo.Text = cmboboxImportTo.SelectedItem.ToString
    End Sub

    Dim fileToImportPath As String = ""

    Private Sub btnImportChooseFile_Click(sender As Object, e As EventArgs) Handles btnImportChooseFile.Click
        Dim a As New OpenFileDialog
        a.Title = "Open"
        a.Filter = "CSV File|*.csv"

        If a.ShowDialog = DialogResult.OK Then
            lblImportFile.Text = a.SafeFileName
            fileToImportPath = a.FileName
        End If
    End Sub

    Private Sub btnFormSubmit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnStartImporting.ClickButtonArea
        If fileToImportPath = "" Then
            lblImportFile.Text = "Please choose a file"
        Else
            If cmboboxImportFrom.SelectedIndex = 0 AndAlso cmboboxImportTo.SelectedIndex = 0 Then
                ImportIMDb(Movieo.listWatchList)
            ElseIf cmboboxImportFrom.SelectedIndex = 0 AndAlso cmboboxImportTo.SelectedIndex = 1 Then
                ImportIMDb(Movieo.listSeenList)
            ElseIf cmboboxImportFrom.SelectedIndex = 0 AndAlso cmboboxImportTo.SelectedIndex = 2 Then
                ImportIMDb(Movieo.listBlackList)
            End If
        End If
    End Sub

    Private Sub btnStartImporting_MouseMove(sender As Object, e As EventArgs) Handles btnStartImporting.MouseMove, btnStartImporting.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnStartImporting_MouseLeave(sender As Object, e As EventArgs) Handles btnStartImporting.MouseLeave, btnStartImporting.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(86, 98, 115)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    Private Sub ImportIMDb(itemsList As List(Of String))
        Try
            Dim MyReader As New FileIO.TextFieldParser(fileToImportPath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim currentRow As String()
            While Not MyReader.EndOfData()
                Try
                    currentRow = MyReader.ReadFields()
                    If Not currentRow(5) = "Title" Then
                        Dim movieTitle = currentRow(5)
                        Dim movieYear = currentRow(11)
                        Dim movieTitleYear As String = movieTitle + " (" + movieYear + ")"
                        Movieo.accessList(itemsList, movieTitleYear)
                    End If
                Catch
                End Try
            End While
            lblImportFile.Text = "IMDb List Imported!"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReadCustomCSV(itemsList As List(Of String))
        Dim fileReader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(fileToImportPath)
        Dim stringReader As String = fileReader.ReadLine()

        For Each movieItem As String In stringReader
            Dim fields = movieItem.Split(""""c)
            Dim quote = """"c
            Dim movieTitle As String = fields(5).Trim(quote)
            Dim movieYear As String = fields(11).Trim(quote)
            Dim movieTitleAndYear As String = movieTitle + " (" + movieYear + ")"
            Movieo.accessList(itemsList, movieTitleAndYear)
        Next
    End Sub

#End Region

#Region "Export"

    Private Sub btnStartExporting_MouseMove(sender As Object, e As EventArgs) Handles btnStartExporting.MouseMove, btnStartExporting.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnStartExporting_MouseLeave(sender As Object, e As EventArgs) Handles btnStartExporting.MouseLeave, btnStartExporting.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(86, 98, 115)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    Private Sub btnStartExporting_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnStartExporting.ClickButtonArea
        If cmboboxExportFrom.SelectedIndex = 0 Then
            ExportList(Movieo.listWatchList)
        ElseIf cmboboxExportFrom.SelectedIndex = 1 Then
            ExportList(Movieo.listSeenList)
        ElseIf cmboboxExportFrom.SelectedIndex = 2 Then
            ExportList(Movieo.listBlackList)
        End If
    End Sub

    Public Sub ExportList(itemsList As List(Of String))
        Dim a As New SaveFileDialog
        a.Title = "Save"

        If a.ShowDialog() = DialogResult.OK Then
            Dim BuildList As New Text.StringBuilder()
            For Each MovieItem As String In itemsList
                BuildList.AppendLine(MovieItem)
            Next
            File.WriteAllText(a.FileName + cmboboxExportFrom.SelectedItem.ToString + ".txt", BuildList.ToString())
        End If
    End Sub

#End Region

End Class