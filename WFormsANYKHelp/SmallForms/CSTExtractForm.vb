Imports <xmlns="http://www.apeh.hu/abev/csatolmanyok/2007/01">
Imports ICSharpCode.SharpZipLib.BZip2
Imports System.Xml

Public Class CSTExtractForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.tbFolderToExtractTo.Text = My.Settings.mappaExtract
        Me.tbFileToExtract.Text = My.Settings.mappaLefuzes
        TempDecryptPassw = ""
        TempDecryptKeyPath = ""

    End Sub

    Private Sub btnBrowseFileToExtract_Click(sender As Object, e As EventArgs) Handles btnBrowseFileToExtract.Click
        Dim CSTDialog As New OpenFileDialog
        Dim dialogresult As New DialogResult
        Dim sendervalue As String = String.Empty
        CSTDialog.Filter = "CST fájl (*.cst) | *.cst"
        sendervalue = tbFileToExtract.Text
        If System.IO.Directory.Exists(sendervalue) Then CSTDialog.InitialDirectory = sendervalue
        If System.IO.File.Exists(sendervalue) Then CSTDialog.FileName = sendervalue
        dialogresult = CSTDialog.ShowDialog()
        If dialogresult = DialogResult.OK Then
            If CSTDialog.FileName.ToLower.EndsWith(".cst") Then
                Me.tbFileToExtract.Text = CSTDialog.FileName
                ErrorProvider1.SetError(tbFileToExtract, "")
            Else
                ErrorProvider1.SetError(tbFileToExtract, "A kiválasztott fájl kiterjesztése nem .cst.")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Bezár_Click(sender As Object, e As EventArgs) Handles Bezár.Click
        Me.Close()
    End Sub

    Private Sub btnBrowseFolderToExtractTo_Click(sender As Object, e As EventArgs) Handles btnBrowseFolderToExtractTo.Click
        Dim dirSelected As String = ""
        dirSelected = MappaBeállító.ValasszKonyvtarat(Me.tbFolderToExtractTo.Text)
        If dirSelected <> "" Then tbFolderToExtractTo.Text = dirSelected
    End Sub

    Private Sub btnKicsomagol_Click(sender As Object, e As EventArgs) Handles btnKicsomagol.Click
        If (System.IO.Directory.Exists(Me.tbFolderToExtractTo.Text)) And (System.IO.File.Exists(Me.tbFileToExtract.Text)) Then
            If Path.GetExtension(Me.tbFileToExtract.Text).ToLower = ".cst" Then CSTkicsomagol(Me.tbFileToExtract.Text, Me.tbFolderToExtractTo.Text)
        End If
    End Sub

    Friend Shared Sub BuildCST(CsatES3File As String, ES3LenyomFile As String, outputCST As String, Optional CsatES3FileMegjegyzes As String = "", Optional CsatES3FileTipus As String = "", Optional Bzipped As Boolean = False)

        Dim iso88592enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("iso-8859-2")
        Dim tempname As String = Path.GetTempFileName
        If CsatES3File <> String.Empty Then
            Using writer As StreamWriter = New StreamWriter(outputCST, False, iso88592enc)
                writer.WriteLine("<?xml version=""1.0"" encoding=""iso-8859-2""?>")
                writer.WriteLine("<csatolmanyok xmlns=""http://www.apeh.hu/abev/csatolmanyok/2007/01"">")
                writer.WriteLine(" <nyomtatvany azonosito=""1"">")
                writer.WriteLine("  <csatolmanyinformaciok>")
                writer.WriteLine("     <csatolmanyokszama>2</csatolmanyokszama>")
                writer.WriteLine("    <nyomtatvanyfile>" & outputCST & "</nyomtatvanyfile>")
                writer.WriteLine("    <fileinformaciok>")
                writer.WriteLine("      <fileinformacio azonosito=""1"">")
                writer.WriteLine("        <filenev>" & Path.GetFileName(CsatES3File) & "</filenev>")
                writer.WriteLine("        <megjegyzes>" & CsatES3FileMegjegyzes & "</megjegyzes>")
                writer.WriteLine("        <tipus> " & CsatES3FileTipus & "</tipus>")
                writer.WriteLine("      </fileinformacio>")
                writer.WriteLine("        <fileinformacio azonosito=""2"">")
                writer.WriteLine("        <filenev>" & Path.GetFileName(ES3LenyomFile) & "</filenev>")
                writer.WriteLine("        <megjegyzes>" & ".es3" & "</megjegyzes>")
                writer.WriteLine("        <tipus> " & "Hitelesített csatolmány lenyomat" & "</tipus>")
                writer.WriteLine("      </fileinformacio>")
                writer.WriteLine("    </fileinformaciok>")
                writer.WriteLine("  </csatolmanyinformaciok>")
                writer.WriteLine("  <csatolmanyfileok>")
                writer.Write("    <csatolmanyfile azonosito=""1"">")
                writer.Flush()
                writer.Close()
            End Using
            ConvertLargeFileFromBinaryToBase64(CsatES3File, tempname)
            Dim lenyomatb64 = Convert.ToBase64String(File.ReadAllBytes(ES3LenyomFile))
            Dim lezaro As String = "</csatolmanyfile>" & Environment.NewLine & "<csatolmanyfile azonosito=" & Chr(34) & "2" & Chr(34) & ">" & lenyomatb64 & "</csatolmanyfile>" & Environment.NewLine & "</csatolmanyfileok>" & Environment.NewLine & "</nyomtatvany>" & Environment.NewLine & "</csatolmanyok>"
            Using b64File As FileStream = File.Open(tempname, FileMode.Open)
                Using fsWriter As New FileStream(outputCST, FileMode.Append, FileAccess.Write)
                    b64File.CopyTo(fsWriter)
                    Using strWriter As New StreamWriter(fsWriter)
                        strWriter.Write(lezaro)
                    End Using
                End Using
            End Using
            Try
                File.Delete(tempname)
            Catch ex As Exception
            End Try
        End If
        If CsatES3File = String.Empty Then
            Using writer As StreamWriter = New StreamWriter(outputCST, False, iso88592enc)
                writer.WriteLine("<?xml version=""1.0"" encoding=""iso-8859-2""?>")
                writer.WriteLine("<csatolmanyok xmlns=""http://www.apeh.hu/abev/csatolmanyok/2007/01"">")
                writer.WriteLine(" <nyomtatvany azonosito=""1"">")
                writer.WriteLine("  <csatolmanyinformaciok>")
                writer.WriteLine("     <csatolmanyokszama>1</csatolmanyokszama>")
                writer.WriteLine("    <nyomtatvanyfile>" & outputCST & "</nyomtatvanyfile>")
                writer.WriteLine("    <fileinformaciok>")
                writer.WriteLine("      <fileinformacio azonosito=""1"">")
                writer.WriteLine("        <filenev>" & Path.GetFileName(ES3LenyomFile) & "</filenev>")
                writer.WriteLine("        <megjegyzes>" & ".es3" & "</megjegyzes>")
                writer.WriteLine("        <tipus> " & "Hitelesített csatolmány lenyomat" & "</tipus>")
                writer.WriteLine("      </fileinformacio>")
                writer.WriteLine("    </fileinformaciok>")
                writer.WriteLine("  </csatolmanyinformaciok>")
                writer.WriteLine("  <csatolmanyfileok>")
                writer.Write("    <csatolmanyfile azonosito=""1"">")
                writer.Flush()
                writer.Close()
            End Using
            Dim lenyomatb64 = Convert.ToBase64String(File.ReadAllBytes(ES3LenyomFile))
            Dim lezaro As String = lenyomatb64 & "</csatolmanyfile>" & Environment.NewLine & "</csatolmanyfileok>" & Environment.NewLine & "</nyomtatvany>" & Environment.NewLine & "</csatolmanyok>"
            Using fsWriter As New FileStream(outputCST, FileMode.Append, FileAccess.Write)
                Using strWriter As New StreamWriter(fsWriter)
                    strWriter.Write(lezaro)
                End Using
            End Using
        End If

        If Bzipped = True Then Bzip(outputCST)
    End Sub

    Friend Shared Sub Bzip(filein As String)
        Dim tempname As String = Path.GetTempFileName
        Dim fsInputFile As FileStream, fsBZ2Archive As FileStream
        fsInputFile = File.OpenRead(filein)
        fsBZ2Archive = File.Create(tempname)
        BZip2.Compress(fsInputFile, fsBZ2Archive, 4026)
        fsInputFile.Close()
        fsBZ2Archive.Close()
        If File.Exists(tempname) Then
            Try
                File.Delete(filein)
                File.Copy(tempname, filein)
            Catch ex As Exception
                MsgBox("CST célfájlt nem tudtam tömöríteni:" & ex.Message)
            End Try
            Try
                File.Delete(tempname)
            Catch ex As Exception
            End Try
        End If

    End Sub
    Friend Shared Sub ConvertLargeFileFromBinaryToBase64(filein As String, fileout As String)
        Using fs As FileStream = File.Open(fileout, FileMode.Create)
            Using cs = New Security.Cryptography.CryptoStream(fs, New Security.Cryptography.ToBase64Transform(), Security.Cryptography.CryptoStreamMode.Write)
                Using fi = File.Open(filein, FileMode.Open)
                    fi.CopyTo(cs)
                End Using
            End Using
        End Using
    End Sub

    Friend Shared Sub ConvertLargeFileFromBase64ToBinary(filein As String, fileout As String)
        Using fs As FileStream = File.Open(fileout, FileMode.Create)
            Using cs = New Security.Cryptography.CryptoStream(fs, New Security.Cryptography.FromBase64Transform, Security.Cryptography.CryptoStreamMode.Write)
                Using fi = File.Open(filein, FileMode.Open)
                    fi.CopyTo(cs)
                End Using
            End Using
        End Using
    End Sub

    Friend Shared Function ProcessCsat(CSTFajlneve As String, IndexNumber As String, FileToExtract As String, WhereTo As String) As Boolean
        Dim buffer(4096) As Byte
        Dim readBytes As Integer = 0
        Dim response As Boolean = False

        Dim tempname As String = Path.GetTempFileName
        Using reader As XmlReader = XmlReader.Create(CSTFajlneve)
            While reader.Read()
                If reader.NodeType = XmlNodeType.Element AndAlso reader.Name = "csatolmanyfile" Then
                    Dim index As String = reader.GetAttribute("azonosito").ToString
                    If index = IndexNumber Then
                        Using writer As XmlWriter = XmlWriter.Create(tempname)
                            writer.WriteNode(reader, False)
                        End Using
                    End If
                End If
            End While
            If File.Exists(WhereTo & Path.DirectorySeparatorChar & Path.GetFileName(FileToExtract)) Then
                Dim dialogresult As New DialogResult
                dialogresult = MsgBox("A kicsomagolandó fájlnév már az adott könyvtárban létezik (" & WhereTo & Path.DirectorySeparatorChar & Path.GetFileName(FileToExtract) & ") Felülírhatja a program?", MsgBoxStyle.YesNo)
                If dialogresult = MsgBoxResult.Yes Then
                    Try
                        File.Delete(WhereTo & Path.DirectorySeparatorChar & Path.GetFileName(FileToExtract))
                    Catch ex As Exception
                        MsgBox("Nem sikerült törölni (nyitott fájl?. Félbehagyja a program a kicsomagolást")
                        Return False
                    End Try
                Else
                    MsgBox("Félbehagyja a program a kicsomagolást.")
                    Return False
                End If

            End If
        End Using
        DeleteNodeBytes(tempname)
        ConvertLargeFileFromBase64ToBinary(tempname, WhereTo & Path.DirectorySeparatorChar & Path.GetFileName(FileToExtract))
        If File.Exists(tempname) Then File.Delete(tempname)
        If File.Exists(WhereTo & Path.DirectorySeparatorChar & Path.GetFileName(FileToExtract)) Then response = True
        Return response
    End Function

    Friend Shared Sub DeleteNodeBytes(FileName As String)

        'A Node-ból az utolsó 17 byte-ot törölni
        Dim fi As FileInfo = New FileInfo(FileName)
        Using fs As FileStream = fi.Open(FileAccess.ReadWrite)
            Dim bytesToDelete As Long = 17
            fs.SetLength(fi.Length - bytesToDelete)
            fs.Close()
        End Using

        'A Node első 127 byte-ját törölni
        Using fs As FileStream = fi.Open(FileAccess.ReadWrite)
            Dim byteArray() As Byte
            ReDim byteArray(123)
            For i As Integer = 0 To 123
                byteArray(i) = &H20
            Next

            fs.Seek(0, SeekOrigin.Begin)
            fs.Write(byteArray, 0, 124)
            'Next
            fs.Close()
        End Using

    End Sub


    Friend Shared Function CheckandUncompressBz(FileToExtract As String) As Boolean
        Dim text As String
        Dim result As Boolean = False
        Dim tempname As String = Path.GetTempFileName

        Using reader As New IO.BinaryReader(New IO.StreamReader(FileToExtract).BaseStream)
            Dim bytes() As Byte = reader.ReadBytes(3)
            text = System.Text.ASCIIEncoding.ASCII.GetString(bytes)
        End Using

        If text = "BZh" Then
            'valid file
            Dim fsBZ2Archive As FileStream
            Using fsInputFile = File.OpenRead(FileToExtract)
                fsBZ2Archive = File.OpenWrite(tempname)
                BZip2.Decompress(fsInputFile, fsBZ2Archive)
                fsInputFile.Close()
            End Using
            fsBZ2Archive.Close()
            If File.Exists(tempname) Then
                Try
                    File.Delete(FileToExtract)
                    File.Copy(tempname, FileToExtract)
                    MyLoader.AddLogBook(Fnc.extr, FileToExtract & " nevű fájl bzippelt CST volt, kitömörítve azonos néven", LogTip.norm)
                Catch ex As Exception
                    MsgBox("CST célfájlt nem tudtam kitömöríteni:" & ex.Message)
                End Try
                Try
                    File.Delete(tempname)
                    result = True
                Catch ex As Exception
                End Try
            End If
        Else
            If text = "<?x" Then result = True
        End If
        Return result
    End Function


    Friend Function CSTkicsomagol(FileToExtract As String, DirectoryToExtractTo As String) As Boolean
        Dim response As Boolean = False
        Me.Cursor = Cursors.WaitCursor
        If CheckandUncompressBz(FileToExtract) = False Then
            Me.Cursor = Cursors.Default
            Dim uzenet = "A megadott CST fájl (" & FileToExtract & " nem ismerhető fel CST-ként."
            MyLoader.AddLogBook(Fnc.extr, uzenet, LogTip.err)
            MsgBox(uzenet)
            Return False
        End If

        Dim tempname As String = Path.GetTempFileName
        Dim CsatiFajlNevek As New Dictionary(Of Integer, String)

        Using reader As XmlReader = XmlReader.Create(FileToExtract)
            reader.MoveToContent()
            'Fájlnevek és azonosítók beolvasása
            While reader.Read()
                If reader.NodeType = XmlNodeType.Element AndAlso reader.Name = "fileinformacio" Then
                    Dim index As Integer = CType(reader.GetAttribute("azonosito").ToString, Integer)
                    reader.ReadToDescendant("filenev")
                    Dim content = reader.ReadElementContentAsString()
                    CsatiFajlNevek.Add(index, content)
                End If
            End While

        End Using
        Dim osszessikeres As Integer = 0
        For Each item As KeyValuePair(Of Integer, String) In CsatiFajlNevek
            If ProcessCsat(FileToExtract, item.Key.ToString, item.Value, DirectoryToExtractTo) = True Then osszessikeres += 1
        Next

        MyLoader.AddLogBook(Fnc.extr, "Kicsomagolva a " + DirectoryToExtractTo + " mappába " & osszessikeres & " db. fájl a " & CsatiFajlNevek.Count & " db-ból", LogTip.norm)
        If osszessikeres > 0 Then response = True

        Me.Cursor = Cursors.Default
        Return response
    End Function

    Private Sub btnBetekint_Click(sender As Object, e As EventArgs) Handles btnBetekint.Click
        If (System.IO.Directory.Exists(Me.tbFolderToExtractTo.Text)) And (System.IO.File.Exists(Me.tbFileToExtract.Text)) Then
            If Path.GetExtension(Me.tbFileToExtract.Text).ToLower = ".cst" Then CSTbetekint(Me.tbFileToExtract.Text)
        End If
    End Sub

    Private Sub CSTbetekint(FileToExtract As String)
        Me.Cursor = Cursors.WaitCursor
        Dim TempFile = Path.GetFileNameWithoutExtension(Path.GetTempFileName)
        Dim TempDir = Path.GetTempPath & TempFile
        System.IO.Directory.CreateDirectory(TempDir)

        CSTkicsomagol(FileToExtract, TempDir)

        KRCST_PassPath = TempDir
        KRCST_FileExtracted = tbFileToExtract.Text
        Me.Cursor = Cursors.Default

        Forms.KRviewer.ShowDialog(Me)
        System.IO.Directory.Delete(TempDir, True)
    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        tbFolderToExtractTo.Text = Path.GetDirectoryName(tbFileToExtract.Text)
    End Sub


    Private Sub tbFileToExtract_DragDrop(sender As Object, e As DragEventArgs) Handles tbFileToExtract.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each filenametoproc In files
            If File.Exists(filenametoproc) And Path.GetExtension(filenametoproc) = ".cst" Then
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
End Class