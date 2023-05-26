Public Class PDFprint
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.tbSourceFile.Text = My.Settings.mappaXMLmegnyitas
        Me.tbTargetFile.Text = My.Settings.mappaExtract
        btnOpen.Visible = False

    End Sub

    Private Sub btnSourceFile_Click(sender As Object, e As EventArgs) Handles btnSourceFile.Click
        Dim PDFDialog As New OpenFileDialog
        Dim dialogresult As New DialogResult
        Dim sendervalue As String = tbSourceFile.Text
        PDFDialog.Filter = "XML fájl (*.xml)| *.xml|XKR fájl (*.xkr) | *.xkr"
        If System.IO.File.Exists(sendervalue) Then
            PDFDialog.InitialDirectory = System.IO.Path.GetDirectoryName(sendervalue)
            PDFDialog.FileName = sendervalue
        ElseIf System.IO.Directory.Exists(sendervalue) Then
            PDFDialog.InitialDirectory = sendervalue
        End If
        dialogresult = PDFDialog.ShowDialog()
        If dialogresult = DialogResult.OK Then
            If PDFDialog.FileName.ToLower.EndsWith(".xml") Or PDFDialog.FileName.ToLower.EndsWith(".xkr") Then
                tbSourceFile.Text = PDFDialog.FileName
                ErrorProvider1.SetError(tbSourceFile, "")
            Else
                ErrorProvider1.SetError(tbSourceFile, "A kiválasztott fájl nem .xml vagy .xkr kiterjesztésű")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub tbSourceFile_TextChanged(sender As Object, e As EventArgs) Handles tbSourceFile.TextChanged
        If tbTargetFile.Text = "" Then tbTargetFile.Text = Path.GetDirectoryName(tbSourceFile.Text) & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(tbSourceFile.Text) & ".PDF"
        tbTargetFile.Text = Path.GetDirectoryName(tbTargetFile.Text) & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(tbSourceFile.Text) & ".PDF"
    End Sub

    Private Sub btnTargetFile_Click(sender As Object, e As EventArgs) Handles btnTargetFile.Click
        Dim PDFDialog As New SaveFileDialog
        PDFDialog.Title = "Válassza ki a cél PDF fájl könyvtárát vagy írja be a fájlnevet!"
        '!Ell:  mentési ablak futásakor kér nevet? be lehet írni csak könyvtárat?
        Dim dialogresult As New DialogResult
        Dim sendervalue As String = tbTargetFile.Text
        PDFDialog.Filter = "PDF fájl (*.pdf)| *.pdf"
        If System.IO.File.Exists(sendervalue) Then
            PDFDialog.InitialDirectory = System.IO.Path.GetDirectoryName(sendervalue)
            PDFDialog.FileName = sendervalue
        End If
        dialogresult = PDFDialog.ShowDialog()
        If dialogresult = DialogResult.OK Then
            tbTargetFile.Text = Path.GetDirectoryName(PDFDialog.FileName) & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(PDFDialog.FileName) & ".pdf"
        End If

    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        tbTargetFile.Text = Path.GetDirectoryName(tbSourceFile.Text) & Path.DirectorySeparatorChar & Path.GetFileName(tbTargetFile.Text)
    End Sub

    Private Sub btnBezár_Click(sender As Object, e As EventArgs) Handles btnBezár.Click
        Me.Close()
        Forms.PDFprint.Close()

    End Sub

    Shared Function extractPDF(srcfile As String, targetfile As String) As Boolean
        Dim response As Boolean = False
        Dim uzenet = String.Empty
        Dim logtipus = String.Empty
        Dim CfgFile = My.Settings.mappaANYKadat & Path.DirectorySeparatorChar & ReadParamText(ParamTextFile, "prop.usr.settings") & Path.DirectorySeparatorChar & "settings.enyk"
        Dim abevjavabat = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "abevjava_start.bat"
        Dim nyomtatasbejegyzesek = ReadParamText(CfgFile, "printer.print.settings.kozos")
        If nyomtatasbejegyzesek <> "0" Then
            ChangeParamText(CfgFile, "printer.print.settings.kozos", "0", , "windows-1250")
        End If

        If Not File.Exists(abevjavabat) Then
            Dim uzenet0 As String = "A program nem találja az ÁNYK indításához szükséges abevjava futtató indító fájlt (abevjava_start.bat), kérem telepítse újra az ÁNYK-t!"
            MyLoader.AddLogBook(Fnc.cfg, uzenet0, LogTip.err)
            MsgBox(uzenet0, MsgBoxStyle.Critical & MsgBoxStyle.OkOnly)
            Return False
        End If

        Dim abevprocess As New Process
        abevprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        abevprocess.StartInfo.FileName = abevjavabat
        abevprocess.StartInfo.WorkingDirectory = Path.GetDirectoryName(abevjavabat)
        abevprocess.StartInfo.RedirectStandardError = True
        abevprocess.StartInfo.RedirectStandardOutput = True

        Dim temppdf As String = String.Empty
        Dim pdfoutputlog As String = MyLog & ".PDFoutputlog"
        Dim talalgassPDFnevet As Boolean = False

        If File.Exists(pdfoutputlog) Then
            Try
                File.Delete(pdfoutputlog)
            Catch ex As Exception
                'Debug.WriteLine("*PDF* A " & pdfoutputlog & " nevű fájl nyitva lehet, ezért nem tudtam törölni, és ezért esetleg nem találja meg a kimeneti PDF-et sem!")
            End Try
        End If
        abevprocess.StartInfo.UseShellExecute = False
        abevprocess.StartInfo.Arguments = Chr(34) & "cmd:pdf.print.xml.silent " & srcfile & ";" & pdfoutputlog & ";" & Chr(34)
        abevprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        abevprocess.Start()
        Dim OutputString = abevprocess.StandardOutput.ReadToEnd()
        Dim errorString = abevprocess.StandardError.ReadToEnd()
        Dim finished As Boolean = abevprocess.WaitForExit(33000)

        If finished = False Then
            Threading.Thread.Sleep(5000)
            talalgassPDFnevet = True
            Trace.WriteLine("*PDF* A PDF készítési folyamat 5 mp után sem fejeződött be: " & pdfoutputlog & "." & Environment.NewLine)
        End If

        If Not File.Exists(pdfoutputlog) Then
            talalgassPDFnevet = True
            Trace.WriteLine("*PDF* A PDFoutputlog nem található. Keresett: " & pdfoutputlog & "." & Environment.NewLine)
        End If

        temppdf = GetPDFFileNamefromOutputStringofANYK(pdfoutputlog)
        Trace.WriteLine("*PDF* Az átmásolandó ÁNYK forrásfájl neve: " & temppdf & Environment.NewLine & "A forrásfájl nevét tartalmazó fájl neve: " & pdfoutputlog)
        If temppdf <> String.Empty Then
            If File.Exists(temppdf) Then response = MozgasdPDFet(temppdf, targetfile)
            If response = True Then
                logtipus = LogTip.siker
                uzenet = "Sikeres PDF-é alakítás: " & targetfile
                GoTo extractPDFvege
            Else
                logtipus = LogTip.err
                uzenet = "A PDF-re alakítás sikerült, de a másolás nem (pl. létező fájl a célban, amit nem írt fölül), így a PDF maradt az eredeti naplókönyvtárban (" & temppdf & ")"
                GoTo extractPDFvege
            End If
        Else
            uzenet = "A PDF fájlnevet nem tudtam kiolvasni a pdf output logból"
            Dim param1 = ReadParamText(ParamTextFile, "prop.usr.naplo")
            Dim param2 = ReadParamText(ParamTextFile, "prop.usr.root")
            Dim temppdf1 = param1 & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(srcfile) & ".pdf"
            Dim temppdf2 = param2 & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(srcfile) & ".pdf"
            Dim KeresettPDF As String = String.Empty
            If File.Exists(temppdf1) Or param1 = param2 Then KeresettPDF = temppdf1
            If File.Exists(temppdf2) And Not File.Exists(temppdf1) Then KeresettPDF = temppdf2
            If Not File.Exists(temppdf1) AndAlso Not File.Exists(temppdf2) Then
                logtipus = LogTip.err
                uzenet = "A PDF-é alakítás nem sikerült. Nem találtam a PDF fájlt a " & param1 & "[prop.usr.naplo]" & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(srcfile) & "[=srcfile neve].pdf útvonalon, sem a " & param2 & "[prop.usr.root\naplo] útvonalon."
                response = False
                GoTo extractPDFvege
            End If
            response = MozgasdPDFet(KeresettPDF, targetfile)
            If response = True Then
                logtipus = LogTip.siker
                uzenet += "Sikeres PDF-é alakítás (fájlnév találgatással): " & targetfile
                GoTo extractPDFvege
            Else
                logtipus = LogTip.err
                uzenet += "A PDF-re alakítás sikerült, de a másolás nem (létező fájl a célban?), így a PDF maradt az eredeti naplókönyvtárban (" & KeresettPDF & ")"
                response = False
            End If
        End If

extractPDFvege:

        abevprocess.Close()
        If Not abevprocess Is Nothing Then abevprocess.Dispose()
        MyLoader.AddLogBook(Fnc.cfg, uzenet, logtipus)
        If nyomtatasbejegyzesek <> "0" Then
            Try
                ChangeParamText(CfgFile, "printer.print.settings.kozos", nyomtatasbejegyzesek, , "windows-1250")
            Catch ex As Exception
                MsgBox("PDF beállítási hiba!")
            End Try
        End If
        Return response
    End Function

    Private Shared Function MozgasdPDFet(temppdffile As String, targetfile As String) As Boolean
        If File.Exists(targetfile) Then
            Dim dialogresult As New DialogResult
            dialogresult = MsgBox("A program felülírja a már létező, azonos nevű fájlt?", MsgBoxStyle.YesNo)
            If dialogresult = DialogResult.Yes Then File.Delete(targetfile) Else Return False
        End If
        Try
            System.IO.File.Move(temppdffile, targetfile)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        If Not File.Exists(tbSourceFile.Text) Then
            ErrorProvider1.SetError(tbSourceFile, "A megadott forrásfájl nem létezik!")
            Exit Sub
        Else
            ErrorProvider1.SetError(tbSourceFile, "")
        End If

        If Not Directory.Exists(Path.GetDirectoryName(tbTargetFile.Text)) Then
            ErrorProvider1.SetError(tbSourceFile, "A megadott célkönyvtár nem létezik!")
            Exit Sub
        Else
            ErrorProvider1.SetError(tbSourceFile, "")
        End If
        Dim uzenet As String = String.Empty
        Me.Hide()

        If extractPDF(tbSourceFile.Text, tbTargetFile.Text) = True Then
            btnOpen.Visible = True
        End If
        Me.Show()
        btnOpen.PerformClick()
    End Sub
    Shared Function GetPDFFileNamefromOutputStringofANYK(FileToRead As String) As String
        Dim newline As String = String.Empty
        Dim result As String = String.Empty
        Dim hibaresult As String = String.Empty
        Try
            If New FileInfo(FileToRead).Length > 0 Then
                Using reader As StreamReader = File.OpenText(FileToRead)

                    Do While reader.Peek() >= 0
                        newline = reader.ReadLine()
                        If Path.GetExtension(newline).ToLower = ".pdf" Then
                            If Not File.Exists(newline) Then
                                MyLoader.AddLogBook(Fnc.extr, "A megadott PDF fájl nem létezik a gépen: " & newline, LogTip.norm)
                            Else
                                result = newline
                                Exit Do
                            End If
                        End If
                    Loop
                End Using
            Else
                Try
                    Dim uzenet As String = "ÁNYK PDF-készítés hiba (hossz 0): " & File.ReadAllText(FileToRead & "_hiba").Replace(Environment.NewLine, "").Trim
                    MyLoader.AddLogBook(Fnc.extr, uzenet, LogTip.err)
                Catch ex As Exception
                    MyLoader.AddLogBook(Fnc.extr, "Egyéb ÁNYK PDF-készítési hiba", LogTip.err)
                End Try
            End If
        Catch
            Try
                Dim uzenet As String = "ÁNYK PDF-készítés hiba: " & File.ReadAllText(FileToRead & "_hiba").Replace(Environment.NewLine, " ")
                MyLoader.AddLogBook(Fnc.extr, uzenet, LogTip.err)
                MsgBox(uzenet, MsgBoxStyle.Critical)
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.extr, "Egyéb ÁNYK PDF-készítési hiba", LogTip.err)
            End Try
        End Try
        Return result
    End Function

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If tbTargetFile.Text <> "" Then
            Try
                System.Diagnostics.Process.Start(tbTargetFile.Text)
            Catch ex As Exception
            End Try
        End If
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


End Class