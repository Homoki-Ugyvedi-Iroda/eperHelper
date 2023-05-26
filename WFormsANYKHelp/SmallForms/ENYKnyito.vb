Public Class ENYKnyito
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        tbSourceFile.Text = My.Settings.mappaXMLmegnyitas & Path.DirectorySeparatorChar

    End Sub

    Private Sub btnBezár_Click(sender As Object, e As EventArgs) Handles btnBezár.Click
        Me.Close()
    End Sub

    Private Sub btnSourceFile_Click(sender As Object, e As EventArgs) Handles btnSourceFile.Click
        Dim OpenXMLXKRDialog As New OpenFileDialog
        Dim dialogresult As New DialogResult
        OpenXMLXKRDialog.Filter = "ENYK fájl (*.enyk)| *.enyk" '"XML fájl (*.xml)| *.xml|XKR fájl (*.xkr) | *.xkr"
        If File.Exists(tbSourceFile.Text) Then
            OpenXMLXKRDialog.InitialDirectory = System.IO.Path.GetDirectoryName(tbSourceFile.Text)
        ElseIf System.IO.Directory.Exists(tbSourceFile.Text) Then
            OpenXMLXKRDialog.InitialDirectory = tbSourceFile.Text
        Else
            OpenXMLXKRDialog.InitialDirectory = My.Settings.mappaXMLmegnyitas
        End If
        dialogresult = OpenXMLXKRDialog.ShowDialog()
        If dialogresult = DialogResult.OK AndAlso File.Exists(OpenXMLXKRDialog.FileName) Then tbSourceFile.Text = OpenXMLXKRDialog.FileName
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If CheckFileExists() = True Then abevjavaNyitas("cmd:file.open", tbSourceFile.Text)
    End Sub

    Private Sub btnANYKmappa_Click(sender As Object, e As EventArgs) Handles btnANYKmappa.Click
        tbSourceFile.Text = My.Settings.mappaANYKmentes & Path.DirectorySeparatorChar & Path.GetFileName(tbSourceFile.Text)
    End Sub

    Private Sub btnXMLmegnyitasi_Click(sender As Object, e As EventArgs) Handles btnXMLmegnyitasi.Click
        tbSourceFile.Text = My.Settings.mappaXMLmegnyitas & Path.DirectorySeparatorChar & Path.GetFileName(tbSourceFile.Text)
    End Sub
    Private Function CheckFileExists()
        If File.Exists(tbSourceFile.Text) Then
            ErrorProvider1.SetError(tbSourceFile, "")
            Return True
        Else
            If Not File.Exists(tbSourceFile.Text) Then ErrorProvider1.SetError(tbSourceFile, "A kijelölt fájl nem létezik.")
            If Path.GetFileName(tbSourceFile.Text) = "" Then ErrorProvider1.SetError(tbSourceFile, "Nem jelölte ki a megnyitni kívánt fájlt.")
            Return False
        End If
    End Function

    Private Sub tbDragDrop(sender As Object, e As DragEventArgs) Handles tbSourceFile.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each filenametoproc In files
            If File.Exists(filenametoproc) Then
                If Path.GetExtension(filenametoproc) = ".enyk" Then tbSourceFile.Text = filenametoproc
                Exit Sub
            End If
        Next
    End Sub

    Private Sub tbDragEnter(sender As Object, e As DragEventArgs) Handles tbSourceFile.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub


End Class