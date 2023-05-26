Imports <xmlns="http://www.apeh.hu/abev/csatolmanyok/2007/01">
Imports <xmlns:CST="http://www.apeh.hu/abev/csatolmanyok/2007/01">
Imports <xmlns:abev="http://iop.gov.hu/2006/01/boritek">

Public Class KRExtractForm
    Public Sub New()

        InitializeComponent()
        Me.tbFolderToExtractTo.Text = My.Settings.mappaExtract
        Me.tbFileToExtract.Text = My.Settings.mappaLefuzes
        TempDecryptPassw = ""
        TempDecryptKeyPath = ""
        CheckSecretKey()

    End Sub

    Private Sub CheckSecretKey()
        If My.Settings.DecryptKeyPath = "" And TempDecryptKeyPath = "" Then
            lblTitkKulcs.Text = "Nincsen alapértelmezett kulcs választva"
            btnSecretKeyChooser.Text = "Kiválaszt"
            Me.btnKicsomagol.Enabled = False
        End If
        If TempDecryptKeyPath <> "" Then
            Me.lblTitkKulcs.Text = Path.GetFileNameWithoutExtension(TempDecryptKeyPath)
            Me.btnKicsomagol.Enabled = True
        End If
        If My.Settings.DecryptKeyPath <> "" And TempDecryptKeyPath = "" Then
            lblTitkKulcs.Text = "Alapértelmezett titkosítókulccsal (" & Path.GetFileName(My.Settings.DecryptKeyPath) & ")"
            btnSecretKeyChooser.Text = "Más kulccsal"
            Me.btnKicsomagol.Enabled = True
        End If
    End Sub

    Private Sub btnBrowseFileToExtract_Click(sender As Object, e As EventArgs) Handles btnBrowseFileToExtract.Click
        Dim CSTDialog As New OpenFileDialog
        Dim dialogresult As New DialogResult
        Dim sendername As String = DirectCast(sender, Button).Name
        Dim sendervalue As String = String.Empty
        CSTDialog.Filter = "KR fájl (*.kr)| *.kr"
        sendervalue = tbFileToExtract.Text
        If System.IO.Directory.Exists(sendervalue) Then CSTDialog.InitialDirectory = sendervalue
        If System.IO.File.Exists(sendervalue) Then
            CSTDialog.InitialDirectory = Path.GetDirectoryName(sendervalue)
            CSTDialog.FileName = sendervalue
        End If
        dialogresult = CSTDialog.ShowDialog()
        If dialogresult = DialogResult.OK Then
            If CSTDialog.FileName.ToLower.EndsWith(".cst") Or CSTDialog.FileName.ToLower.EndsWith(".kr") Then
                Me.tbFileToExtract.Text = CSTDialog.FileName
                ErrorProvider1.SetError(tbFileToExtract, "")
            Else
                ErrorProvider1.SetError(tbFileToExtract, "A kiválasztott fájl kiterjesztése nem .kr.")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnBrowseFolderToExtractTo_Click(sender As Object, e As EventArgs) Handles btnBrowseFolderToExtractTo.Click
        Dim dirSelected As String = ""
        dirSelected = MappaBeállító.ValasszKonyvtarat(Me.tbFolderToExtractTo.Text)
        If dirSelected <> "" Then tbFolderToExtractTo.Text = dirSelected
    End Sub

    Friend Function GetCSTPathFromKR(FileToCheck As String) As String
        Dim xelem As XElement = XElement.Load(FileToCheck)
        Dim XMLFileNev As IEnumerable(Of XElement) = From el In xelem.<abev:Boritek>.<abev:Fejlec>.<abev:FileNev> Select el
        Dim CSTFileNev As IEnumerable(Of XElement) = From el In xelem.<abev:Boritek>.<abev:Fejlec>.<abev:CsatolmanyInfo>.<abev:FileNev> Select el
        Dim response As String = XMLFileNev.Value & "_" & "csatolmanyai" & Path.DirectorySeparatorChar & CSTFileNev.Value
        If response <> "_csatolmanyai" & Path.DirectorySeparatorChar Then Return response Else Return ""
    End Function

    Private Sub btnSecretKeyChooser_Click(sender As Object, e As EventArgs) Handles btnSecretKeyChooser.Click
        If My.Settings.DecryptKeyPath = "" Then
            Forms.TitkositoKulcsBeallitasa.ShowDialog()
            Forms.TitkositoKulcsBeallitasa.Close()
        Else
            Dim result As New DialogResult
            result = Forms.DecryptChooser.ShowDialog()
            Forms.DecryptChooser.Close()
            If result = DialogResult.Cancel Then
                TempDecryptKeyPath = ""
                TempDecryptPassw = ""
            End If
        End If
        CheckSecretKey()
    End Sub
    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        tbFolderToExtractTo.Text = Path.GetDirectoryName(tbFileToExtract.Text)
    End Sub

    Private Sub tbFileToExtract_DragDrop(sender As Object, e As DragEventArgs) Handles tbFileToExtract.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each filenametoproc In files
            If File.Exists(filenametoproc) And Path.GetExtension(filenametoproc) = ".kr" Then
                tbFileToExtract.Text = filenametoproc
                Exit Sub
            End If
        Next
    End Sub

    Private Sub tbFileToExtract_DragEnter(sender As Object, e As DragEventArgs) Handles tbFileToExtract.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub Bezár_Click(sender As Object, e As EventArgs) Handles Bezár.Click
        Me.Close()
    End Sub


    Private Sub btnKicsomagol_Click(sender As Object, e As EventArgs) Handles btnKicsomagol.Click
        If (System.IO.Directory.Exists(Me.tbFolderToExtractTo.Text)) And (System.IO.File.Exists(Me.tbFileToExtract.Text)) Then
            If Path.GetExtension(Me.tbFileToExtract.Text).ToLower = ".kr" Then KRkicsomagol(Me.tbFileToExtract.Text, Me.tbFolderToExtractTo.Text)
        End If
    End Sub

    Friend Sub KRkicsomagol(FileToExtract As String, DirectoryToExtractTo As String)
        Dim logtipus As String = String.Empty
        Dim jelszo As String = String.Empty
        Dim seckey As String = String.Empty

        Me.Cursor = Cursors.WaitCursor
        If File.Exists(TempDecryptKeyPath) Then
            seckey = TempDecryptKeyPath
            If TempDecryptPassw <> "" Then
                jelszo = TempDecryptPassw
            Else
                Forms.Passwbox.ShowDialog()
                Forms.Passwbox.Close()
                If TempDecryptPassw = "" Then
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
        Else
            If My.Settings.DecryptKeyPath <> "" Then seckey = My.Settings.DecryptKeyPath
            If My.Settings.PkeyPassw <> "" Then jelszo = Kapukezelo.Decrypt(My.Settings.PkeyPassw, "PkeyPassw")
            If jelszo = String.Empty Then
                Forms.Passwbox.ShowDialog()
                Forms.Passwbox.Close()
                If TempDecryptPassw = String.Empty Then
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    jelszo = TempDecryptPassw
                End If
            End If
        End If

        Dim kriptowrapperprocess As New Process
        SetKrProc(kriptowrapperprocess)
        kriptowrapperprocess.StartInfo.CreateNoWindow = True
        kriptowrapperprocess.StartInfo.Arguments = KriptoWrapper & " -cmd=parse " & "-file=" & Chr(34) & tbFileToExtract.Text & Chr(34) & " -dir=" & Chr(34) & DirectoryToExtractTo & Chr(34) & " -secretkey=" & Chr(34) & seckey & Chr(34) & " -jelszo=" & Chr(34) & jelszo & Chr(34)
        kriptowrapperprocess.Start()
        Dim ErrorString = kriptowrapperprocess.StandardError.ReadToEnd()
        Dim OutputString = kriptowrapperprocess.StandardOutput.ReadToEnd
        File.WriteAllText(MyLog & ".errorlog", ErrorString)
        File.WriteAllText(MyLog & ".outputlog", OutputString)
        kriptowrapperprocess.WaitForExit(1000)
        Dim outputneve As String = LoadDatafromKRandXKR.extractKRFileNev(FileToExtract)
        Dim uzenet As String = String.Empty
        If outputneve = String.Empty Then
            uzenet = "A kicsomagolás nem sikerült, a megadott fájl tartalmában nem tűnik valódi KR fájlnak, nem olvasható ki belőle a nyomtatvány neve"
            logtipus = LogTip.err
            GoTo Kilep
        End If
        Try
            uzenet = OutputString
            If uzenet.Contains("Siker:") And File.Exists(DirectoryToExtractTo & Path.DirectorySeparatorChar & outputneve) Then
                uzenet = "Sikeres kicsomagolása KR-nek (" & outputneve & ")"
                logtipus = LogTip.siker
            Else
                If uzenet.Contains("missing symmetric key") Then uzenet = "A kicsomagolás nem sikerült: nem megfelelő kititkosító kulcs!"
                If uzenet.Contains("Hiba (parser)") Then uzenet = "A kicsomagolás nem sikerült:" & uzenet.Replace("Hiba (parser)", String.Empty)
                logtipus = LogTip.err
                End If
        Catch ex As Exception
            uzenet = "A kicsomagolás nem sikerült, nincsen visszajelzés a KriptoWrapper funkciótól"
            logtipus = LogTip.err
        End Try
        kriptowrapperprocess.Close()
        If Not kriptowrapperprocess Is Nothing Then kriptowrapperprocess.Dispose()
        If logtipus = LogTip.err Then GoTo Kilep

        Dim outputCST As String = DirectoryToExtractTo & Path.DirectorySeparatorChar & outputneve & "_csatolmanyai" & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(outputneve) & ".cst"
        Dim outputXML As String = DirectoryToExtractTo & Path.DirectorySeparatorChar & outputneve
        Dim outputPDF As String = DirectoryToExtractTo & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(outputneve) & ".pdf"
        If File.Exists(outputCST) And cbCSTex.Checked Then
            CSTExtractForm.CSTkicsomagol(outputCST, DirectoryToExtractTo)
        End If
        If File.Exists(outputXML) And cbXMLPDF.Checked Then
            PDFprint.extractPDF(outputXML, outputPDF)
        End If

Kilep:
        MyLoader.AddLogBook(Fnc.cfg, uzenet, logtipus)
        MsgBox(uzenet, MsgBoxStyle.OkOnly)
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub btnBetekint_Click(sender As Object, e As EventArgs) Handles btnBetekint.Click
        If (System.IO.Directory.Exists(Me.tbFolderToExtractTo.Text)) And (System.IO.File.Exists(Me.tbFileToExtract.Text)) Then
            If Path.GetExtension(Me.tbFileToExtract.Text).ToLower = ".cst" Then CSTbetekint(Me.tbFileToExtract.Text)
            If Path.GetExtension(Me.tbFileToExtract.Text).ToLower = ".kr" Then KRbetekint(Me.tbFileToExtract.Text)
        End If
    End Sub

    Private Sub CSTbetekint(FileToExtract As String)
        Me.Cursor = Cursors.WaitCursor
        Dim TempFile = Path.GetFileNameWithoutExtension(Path.GetTempFileName)
        Dim TempDir = Path.GetTempPath & TempFile
        System.IO.Directory.CreateDirectory(TempDir)

        CSTExtractForm.CSTkicsomagol(FileToExtract, TempDir)

        KRCST_PassPath = TempDir
        KRCST_FileExtracted = tbFileToExtract.Text
        Me.Cursor = Cursors.Default

        Forms.KRviewer.ShowDialog(Me)
        System.IO.Directory.Delete(TempDir, True)
    End Sub
    Private Sub KRbetekint(FileToExtract As String)
        Me.Cursor = Cursors.WaitCursor
        Dim TempFile = Path.GetFileNameWithoutExtension(Path.GetTempFileName)
        Dim TempDir = Path.GetTempPath & TempFile
        Dim ExtractedXML = String.Empty
        System.IO.Directory.CreateDirectory(TempDir)

        KRkicsomagol(FileToExtract, TempDir)

        KRCST_PassPath = TempDir
        KRCST_FileExtracted = tbFileToExtract.Text
        Try
            ExtractedXML = System.IO.Directory.GetFiles(TempDir, "*.xml")(0)
        Catch ex As Exception
            Dim uzenet = "Kicsomagolási hiba (betekintés)"
            MsgBox(uzenet)
            MyLoader.AddLogBook(Fnc.extr, uzenet, LogTip.err)
            Exit Sub
        End Try
        'CSTExtractForm.CSTkicsomagol(ExtractedXML & "_csatolmanyai" & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(ExtractedXML) & ".cst", TempDir)
        Me.Cursor = Cursors.Default

        Forms.KRviewer.ShowDialog(Me)
        Forms.KRviewer.Close()
        System.IO.Directory.Delete(TempDir, True)
    End Sub


End Class