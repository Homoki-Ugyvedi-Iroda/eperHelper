Public Class XMLXKRnyito
    Public Sub New()
        InitializeComponent()
        tbSourceFile.Text = My.Settings.mappaXMLmegnyitas & Path.DirectorySeparatorChar
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
    Private Sub btnOpenView_Click(sender As Object, e As EventArgs) Handles btnOpenView.Click
        If CheckFileExists() = True Then abevjavaNyitas("cmd:show.xml", tbSourceFile.Text)
    End Sub

    Private Sub btnSourceFile_Click(sender As Object, e As EventArgs) Handles btnSourceFile.Click
        Dim OpenXMLXKRDialog As New OpenFileDialog
        Dim dialogresult As New DialogResult
        OpenXMLXKRDialog.Filter = "XML fájl (*.xml)| *.xml|XKR fájl (*.xkr) | *.xkr"
        If File.Exists(tbSourceFile.Text) Then
            OpenXMLXKRDialog.InitialDirectory = System.IO.Path.GetDirectoryName(tbSourceFile.Text)
        ElseIf System.IO.Directory.Exists(tbSourceFile.Text) Then
            OpenXMLXKRDialog.InitialDirectory = tbSourceFile.Text
        Else
            OpenXMLXKRDialog.InitialDirectory = My.Settings.mappaXMLmegnyitas
        End If

        dialogresult = OpenXMLXKRDialog.ShowDialog()
        If dialogresult = DialogResult.OK Then tbSourceFile.Text = OpenXMLXKRDialog.FileName
    End Sub

    Private Sub btnBezár_Click(sender As Object, e As EventArgs) Handles btnBezár.Click
        Me.Close()
    End Sub


    Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click
        tbSourceFile.Text = My.Settings.mappaExtract & Path.DirectorySeparatorChar & Path.GetFileName(tbSourceFile.Text)
    End Sub

    Private Sub btnmappaLefuzes_Click(sender As Object, e As EventArgs) Handles btnmappaLefuzes.Click
        tbSourceFile.Text = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & Path.GetFileName(tbSourceFile.Text)
    End Sub

    Private Sub btnXMLmegnyitasi_Click(sender As Object, e As EventArgs) Handles btnXMLmegnyitasi.Click
        tbSourceFile.Text = My.Settings.mappaXMLmegnyitas & Path.DirectorySeparatorChar & Path.GetFileName(tbSourceFile.Text)
    End Sub

    Private Sub btnOpenEdit_Click(sender As Object, e As EventArgs) Handles btnOpenEdit.Click
        If CheckFileExists() = True Then abevjavaNyitas("cmd:open.xml", tbSourceFile.Text)
    End Sub

    Private Sub tbDragDrop(sender As Object, e As DragEventArgs) Handles tbSourceFile.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each filenametoproc In files
            If File.Exists(filenametoproc) Then
                If Path.GetExtension(filenametoproc) = ".xkr" Or Path.GetExtension(filenametoproc) = ".xml" Then tbSourceFile.Text = filenametoproc
                Exit Sub
            End If
        Next
    End Sub

    Private Sub tbDragEnter(sender As Object, e As DragEventArgs) Handles tbSourceFile.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub btnANYKdigitalisalairas_Click(sender As Object, e As EventArgs) Handles btnANYKdigitalisalairas.Click
        tbSourceFile.Text = Directory.GetParent(My.Settings.mappaANYKkuldendo).ToString & Path.DirectorySeparatorChar & "digitalis_alairas" & Path.DirectorySeparatorChar & Path.GetFileName(tbSourceFile.Text)
    End Sub
End Class