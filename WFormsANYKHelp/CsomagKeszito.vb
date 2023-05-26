Imports System.IO.Compression


Public Class CsomagKeszito
    Dim NyomiExt As String
    Dim ClickedTextBox As String = String.Empty
    Dim SelectedNyomtatvany As String = String.Empty
    Const MaxSizeKR As Long = 300 * 1024 * 1024 '300 MB byte-ban számolva
    'Const MaxSizeKRBrowsersending As Long = 50 * 1000 * 1000 'Tapasztalat alapján a legnagyobb, még böngészővel beküldhető KR mérete, efölött az ÁNYK-féle WS-t kell használni
    'Kihagytam egyelőre, mert változik!
    Dim UgytorzsTabla As New TorzsAdatbazisDataSet.Ugytorzs_rogzitoDataTable
    Dim Ugytorzs_rogzitoTableAdapter As New TorzsAdatbazisDataSetTableAdapters.Ugytorzs_rogzitoTableAdapter
    Dim ugyszamosszes As String() = {String.Empty}
    Const EvszamErtek = 1
    Const LajstromszamErtek = 2
    Const UgycsoportErtek = 0

    Public Sub New(XMLVagyENYK As String)

        InitializeComponent()

        If Screen.PrimaryScreen.WorkingArea.Height < 756 Then Me.WindowState = FormWindowState.Maximized
        Me.NyomiListaFeldolgTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet1.NyomiListaFeldolg)

        Ugytorzs_rogzitoTableAdapter.Fill(UgytorzsTabla)

        If XMLVagyENYK.Contains("XML") Then NyomiExt = "xml" Else NyomiExt = "frm.enyk"
        If MyLoader.pnlHivatalikapu.Enabled Then btnHKPFeltoltes.Visible = True Else btnHKPFeltoltes.Visible = False
        If MyLoader.pnlPerkapu.Enabled Then btnPKPFeltoltes.Visible = True Else btnPKPFeltoltes.Visible = False
        If MyLoader.pnlUgyfelkapu.Enabled Then btnUKPFeltoltes.Visible = True Else btnUKPFeltoltes.Visible = False
        If NyomiExt = "xml" Then tbXMLPath.ReadOnly = True Else tbXMLPath.ReadOnly = False
        cbxZipTorles.Checked = My.Settings.ZipFajlTorol
        If cbZipped.Checked = False Then cbxZipTorles.Checked = False
        tbDirectoryNyomtatvanyok.Text = My.Settings.mappaANYKmentes
        LoadFilesToListView()

    End Sub
    Private Sub LoadFilesToListView()
        Try
            If Not Directory.Exists(Path.GetDirectoryName(tbDirectoryNyomtatvanyok.Text)) Then Exit Sub
        Catch ex As Exception
            Exit Sub
        End Try
        lvNyomiLista.Items.Clear()
        Dim myFilter As String = String.Empty
        Dim listeditems2 As New List(Of lvFilesforCsomagKeszito)
        Dim listeditems As New List(Of KeyValuePair(Of String, Date))
        myFilter = "*." & NyomiExt
        Dim FileList As String() = Directory.GetFiles(tbDirectoryNyomtatvanyok.Text, myFilter)
        For Each filenev In FileList
            Dim fi As New FileInfo(filenev)
            If fi.Length < (10 * 1024 * 1024) Then
                Try
                    Dim xelem As XElement = XElement.Load(filenev)
                    Dim xns As XNamespace = "http://iop.gov.hu/2007/01/nyk/altalanosnyomtatvany"
                    Dim nyomtatvanytipus As IEnumerable(Of XElement) = From el In xelem.Descendants Where el.Name.Namespace = xns And el.Name.LocalName = "nyomtatvanyok" Select el
                    If nyomtatvanytipus.Count > 0 Or xelem.Name.Namespace = xns And xelem.Name.LocalName = "nyomtatvanyok" Then
                        Dim megjegyzesString = LoadDatafromKRandXKR.GetMegjegyzes(filenev)
                        Dim newlvItem As New lvFilesforCsomagKeszito
                        If megjegyzesString.StartsWith("{*}") Then
                            newlvItem.FileName = Path.GetFileName(filenev)
                            newlvItem.FileLastWriteDate = fi.LastWriteTime
                            megjegyzesString = megjegyzesString.Remove(0, 3)
                            newlvItem.XMLName = megjegyzesString.Split("{!}").First
                            newlvItem.BekuldoNeve = megjegyzesString.Split("{!}").Last
                            newlvItem.EperHelperMade = True
                            listeditems2.Add(newlvItem)
                        Else
                            If cbxEperHelper.Checked = True Then Continue For
                            newlvItem.FileName = Path.GetFileName(filenev)
                            newlvItem.FileLastWriteDate = fi.LastWriteTime
                            newlvItem.EperHelperMade = False
                            listeditems2.Add(newlvItem)
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
        Next

        listeditems2.Sort(Function(x, y) DateTime.Compare(x.FileLastWriteDate, y.FileLastWriteDate))
        listeditems2.Reverse()
        lvEperHelper.Width = 30
        lvNyomiListaName.Width = 215
        lvXmlNev.Width = 107
        lvNyomiListaLastWritten.Width = 135

        For Each listitem As lvFilesforCsomagKeszito In listeditems2
            Dim litem As New ListViewItem
            If listitem.EperHelperMade Then litem.Text = "X"
            Dim filename As New ListViewItem.ListViewSubItem
            filename.Text = listitem.FileName
            Dim lastwritedate As New ListViewItem.ListViewSubItem
            lastwritedate.Text = listitem.FileLastWriteDate
            Dim xmlname As New ListViewItem.ListViewSubItem
            xmlname.Text = listitem.XMLName
            litem.SubItems.Add(filename)
            litem.SubItems.Add(xmlname)
            litem.SubItems.Add(lastwritedate)
            lvNyomiLista.Items.Add(litem)
        Next
        'For Each item As KeyValuePair(Of String, Date) In listeditems
        'Dim litem As New ListViewItem
        'litem.Text = item.Key
        'Dim lastwritedate As New ListViewItem.ListViewSubItem
        'lastwritedate.Text = item.Value.ToString
        'litem.SubItems.Add(lastwritedate)
        'lvNyomiLista.Items.Add(litem)
        'Next

        If lvNyomiLista.Items.Count > 0 Then SelectedNyomtatvany = lvNyomiLista.Items(0).SubItems(1).Text
    End Sub

    Private Sub LoadAdatokFromSelectedNyomi()
        If Not SelectedNyomtatvany Is Nothing AndAlso SelectedNyomtatvany <> String.Empty Then
            Dim PathAdd As String = tbDirectoryNyomtatvanyok.Text & Path.DirectorySeparatorChar
            tbNyomtatvanyNeve.Text = LoadDatafromKRandXKR.extractNYA(PathAdd & SelectedNyomtatvany)
            tbCimzettSzervNeve.Text = LoadDatafromKRandXKR.extractParameterek(PathAdd & SelectedNyomtatvany, tbNyomtatvanyNeve.Text, "birosag")
            tbAlperes.Text = LoadDatafromKRandXKR.extractParameterek(PathAdd & SelectedNyomtatvany, tbNyomtatvanyNeve.Text, "alperes")
            tbFelperes.Text = LoadDatafromKRandXKR.extractParameterek(PathAdd & SelectedNyomtatvany, tbNyomtatvanyNeve.Text, "felperes")
            ugyszamosszes = LoadDatafromKRandXKR.extractUgyszam(PathAdd & SelectedNyomtatvany, tbNyomtatvanyNeve.Text)
            If ugyszamosszes(UgycsoportErtek) = String.Empty AndAlso ugyszamosszes(EvszamErtek) = String.Empty AndAlso ugyszamosszes(LajstromszamErtek) = String.Empty Then
                tbUgyszam.Text = String.Empty
            Else
                tbUgyszam.Text = ugyszamosszes(UgycsoportErtek) + "/" + ugyszamosszes(LajstromszamErtek) + "/" + ugyszamosszes(EvszamErtek) + "."
            End If
            Dim shortdateString = LoadDatafromKRandXKR.extractParameterek(PathAdd & SelectedNyomtatvany, tbNyomtatvanyNeve.Text, "datumleirva")
            If shortdateString = String.Empty Then tbUtolsoMentes.Text = String.Empty : Exit Sub
            If shortdateString.Length = 8 Then tbUtolsoMentes.Text = shortdateString.Substring(0, 4) & "." & shortdateString.Substring(4, 2) & "." & shortdateString.Substring(6, 2) Else tbUtolsoMentes.Text = ""
            'My.Computer.FileSystem.GetFileInfo(PathAdd & SelectedNyomtatvany).LastWriteTime.ToShortDateString
        End If
    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click

        Me.Close()
    End Sub

    Private Sub cbZipped_CheckedChanged(sender As Object, e As EventArgs) Handles cbZipped.CheckedChanged
        If cbZipped.Checked = False Then
            tbZipFajlnev.Visible = False
            lblZipFajlNev.Visible = False
            cbxZipTorles.Visible = False
        Else
            tbZipFajlnev.Visible = True
            lblZipFajlNev.Visible = True
            cbxZipTorles.Visible = True

        End If
    End Sub
#Region "lvCsatolmanyok"

    Private Sub lvCsatolmanyok_DragDrop(sender As Object, e As DragEventArgs) Handles lvCsatolmanyok.DragDrop
        If tbNyomtatvanyNeve.Text = "OBHGEPI_P28" Or tbNyomtatvanyNeve.Text = "OBHGEPI_D01" Then MsgBox("P28-as vagy D01 nyomtatványhoz nem csatolhat csatolmányt. Válasszon más nyomtatványtípust!") : Exit Sub
        For Each litem As String In e.Data.GetData(DataFormats.FileDrop)
            If AddItemtolvCsatolmanyok(litem) = False Then e.Effect = DragDropEffects.None
        Next
        UpdateSize()
    End Sub

    Private Sub lvCsatolmanyok_DragEnter(sender As Object, e As DragEventArgs) Handles lvCsatolmanyok.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Function AddItemtolvCsatolmanyok(FileToAdd As String) As Boolean
        Dim response As Boolean = False
        Dim ext = Path.GetExtension(FileToAdd)
        Dim sizeorig As String = My.Computer.FileSystem.GetFileInfo(FileToAdd).Length.ToString
        Dim sizestr = GetFileSizeFormatted(CType(sizeorig, Long))
        If GetFileExtValid(ext) Then
            Dim listitem As New ListViewItem
            listitem.Text = FileToAdd
            Dim lsizestr As New ListViewItem.ListViewSubItem
            lsizestr.Text = sizestr
            lsizestr.Name = "sizestr"
            Dim lsizeorig As New ListViewItem.ListViewSubItem
            lsizeorig.Text = sizeorig
            lsizeorig.Name = "sizeorig"
            listitem.SubItems.AddRange({lsizestr, lsizeorig})
            lvCsatolmanyok.Items.Add(listitem)
            response = True
        Else
            response = False
        End If
        lvCsatolmanyok.Refresh()
        Return response
    End Function

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        MoveListItem(-1)
    End Sub

    Private Sub btnTorol_Click(sender As Object, e As EventArgs) Handles btnTorol.Click
        For Each lvitem As ListViewItem In lvCsatolmanyok.SelectedItems
            lvitem.Remove()
        Next
        UpdateSize()
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        MoveListItem(1)
    End Sub

    Private Sub MoveListItem(Merre As Integer)
        If lvCsatolmanyok.SelectedItems Is Nothing Then Exit Sub
        For Each KivalasztottItem As ListViewItem In lvCsatolmanyok.SelectedItems
            Dim currentIndex As Integer = KivalasztottItem.Index
            Dim item As ListViewItem = lvCsatolmanyok.Items(currentIndex)
            Dim target As Integer = currentIndex + Merre
            If target < lvCsatolmanyok.Items.Count And target > -1 Then
                lvCsatolmanyok.Items.RemoveAt(currentIndex)
                lvCsatolmanyok.Items.Insert(currentIndex + Merre, item)
            End If
        Next
    End Sub

    Private Sub btnTallozCsatolmany_Click(sender As Object, e As EventArgs) Handles btnTallozCsatolmany.Click
        If tbNyomtatvanyNeve.Text = "OBHGEPI_P28" Or tbNyomtatvanyNeve.Text = "OBHGEPI_D01" Then MsgBox("P28-as és D01 nyomtatványhoz nem csatolhat csatolmányt. Válasszon más nyomtatványtípust!") : Exit Sub

        Dim dialogresult As New DialogResult
        Dim opFileDialog1 As New OpenFileDialog()
        opFileDialog1.Filter = "Bíróság által engedélyezett|*.DOSSIER; *.DOSSZIE; *.EAK; *.ES3; *.ET3; *.ETV; *.NSACK; *.PDF; *.FIZIG; *.ASIC; *.ODT; *.DOC; *.DOCX; *.JPEG; *.JPG; *.PNG; *.BMP; *.MP3; *.WAV; *.AVI; *.MP4; *.MPEG"
        opFileDialog1.Title = "Válassza ki a csatolmányokat"
        opFileDialog1.Multiselect = True
        opFileDialog1.RestoreDirectory = True
        Try
            If Directory.Exists(My.Settings.mappaXMLmegnyitas) Then opFileDialog1.InitialDirectory = My.Settings.mappaXMLmegnyitas
        Catch ex As Exception
        End Try
        dialogresult = opFileDialog1.ShowDialog()
        If dialogresult = DialogResult.OK Then
            For Each file As String In opFileDialog1.FileNames
                AddItemtolvCsatolmanyok(file)
            Next
        End If
        UpdateSize()
    End Sub

    Function GetFileExtValid(ext As String) As Boolean
        Dim HelyesKiterjesztes As String() = {"DOSSIER", "DOSSZIE", "EAK", "ES3", "ET3", "ETV", "NSACK", "PDF", "FIZIG", "ASIC", "ODT", "DOC", "DOCX", "JPEG", "JPG", "PNG", "BMP", "MP3", "WAV", "AVI", "MP4", "MPEG"}
        If HelyesKiterjesztes.Contains(ext.ToUpper.Replace(".", ""), StringComparer.CurrentCultureIgnoreCase) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub lvNyomiLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvNyomiLista.SelectedIndexChanged
        'Beolvassa adatokat róla
        If lvNyomiLista.SelectedItems.Count = 0 Then Exit Sub
        SelectedNyomtatvany = lvNyomiLista.SelectedItems(0).SubItems(1).Text
        LoadAdatokFromSelectedNyomi()

        If NyomiExt = "frm.enyk" Then
            Dim megjegyzesbolXMLNev As String = lvNyomiLista.SelectedItems(0).SubItems(2).Text
            If megjegyzesbolXMLNev = String.Empty Then
                Dim Valasz = FajlnevetFromNyomtatvany()
                If Valasz <> "" Then Me.tbXMLPath.Text = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & Valasz & ".xml"
            Else
                If Not megjegyzesbolXMLNev.EndsWith(".xml") Then megjegyzesbolXMLNev += ".xml"
                Me.tbXMLPath.Text = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & CleanPathandFileName(megjegyzesbolXMLNev)
            End If
        Else
            tbXMLPath.Text = tbDirectoryNyomtatvanyok.Text & Path.DirectorySeparatorChar & SelectedNyomtatvany
        End If
        tbXMLPath_Validating(Nothing, Nothing)
        If SelectedNyomtatvany.Contains("P0") Or SelectedNyomtatvany.Contains("G0") Or SelectedNyomtatvany.Contains("K0") Or SelectedNyomtatvany.Contains("M0") Or SelectedNyomtatvany.Contains("FM") Then cbxUgytorzsbe.Checked = True Else cbxUgytorzsbe.Checked = False
    End Sub
    Private Function GetTotalSize() As Long
        Dim totalsizeorig As Integer = 0
        For Each lvitem As ListViewItem In lvCsatolmanyok.Items
            Dim lvSizeOrig As String = lvitem.SubItems("sizeorig").Text
            totalsizeorig += lvSizeOrig
        Next
        Return totalsizeorig
    End Function

    Private Sub UpdateSize()
        Dim largestsizeorig As Integer = 0
        Dim totalsizeorig As Integer = GetTotalSize()

        For Each lvitem As ListViewItem In lvCsatolmanyok.Items
            Dim lvSizeOrig As String = lvitem.SubItems("sizeorig").Text
            If lvSizeOrig > largestsizeorig Then largestsizeorig = lvSizeOrig
        Next
        tbLegnagyobbCsatolmanyMerete.Text = GetFileSizeFormatted(largestsizeorig)
        If largestsizeorig >= 124780544 Then lblLegnagyobb.ForeColor = Color.Red Else lblLegnagyobb.ForeColor = Color.Black
        tbOsszesCsatolmanyMerete.Text = GetFileSizeFormatted(totalsizeorig)
        If totalsizeorig >= CInt(MaxSizeKR / 1.399) Then lblOsszes.ForeColor = Color.Red Else lblOsszes.ForeColor = Color.Black
        '139,9% a tapasztalatok szerint az a méretnövekedés, ami egy PDF-ből KR lesz - tehát ha a 300 MB/139,9%-át meghaladja az összes csomag méret, és az PDF, akkor várhatóan a végső KR is meghaladja a 3000 MB-ot.)
    End Sub

#End Region

    Private Function RovidBsag(Input As String) As String
        Dim Output As String = String.Empty
        Input.Replace("Járásbíróság", "JB")
        Input.Replace("Törvényszék", "TSZ")
        Input.Replace("Ítélőtábla", "IT")
        Input.Replace("Közigazgatási és Munkaügyi Bíróság", "KMUB")
        Input.Replace("Környéki", "K")
        Input.Replace("Budai Központi Kerületi Bíróság", "BKKB")
        Input.Replace("Pesti Központi Kerületi Bíróság", "PKKB")
        Input.Replace("Székesfehérvár", "Szfvár")
        Input.Replace("Zalaegerszeg", "Zeg")
        Input.Replace("II. és III. Kerületi", "II_IIIK")
        Input.Replace("IV. és XV. Kerületi", "IV_XVK")
        Input.Replace("XVIII. és XIX. Kerületi", "XVIII_XIXK")
        Input.Replace("XX./, XXI. és XXIII. Kerületi", "XX_XXI_XXIIIK")
        Input.Replace(" ", "_")
        Return Input
    End Function

    Private Function FajlnevetFromNyomtatvany() As String
        Dim response As String = String.Empty
        If tbUgyszam.Text <> "./." Then response = tbUgyszam.Text.Replace(".", "").Replace("/", "")
        If tbFelperes.Text <> "" Then response += IIf(response <> "", "_" & tbFelperes.Text, tbFelperes.Text)
        If tbAlperes.Text <> "" Then response += IIf(response <> "", "_" & tbAlperes.Text, tbAlperes.Text)
        If tbCimzettSzervNeve.Text <> "" Then response += IIf(response <> "", "_" & RovidBsag(tbCimzettSzervNeve.Text), RovidBsag(tbCimzettSzervNeve.Text))
        If tbNyomtatvanyNeve.Text <> "" Then response += IIf(response <> "", "_" & tbNyomtatvanyNeve.Text.Replace("OBHGEPI_", ""), tbNyomtatvanyNeve.Text.Replace("OBHGEPI_", ""))
        If tbUtolsoMentes.Text <> "" Then
            Dim ShortDateString = tbUtolsoMentes.Text.Replace(".", "")
            response += IIf(response <> "", "-" & ShortDateString, ShortDateString)
        End If
        response = Strings.Left(CleanPathandFileName(response), 100)
        'response = SanitizeforKR(response)
        response = response.Replace("__", "_")
        response = response.Replace(".", "")
        response = response.Replace(" ", "")
        response = response.Replace("-", "")

        Return response
    End Function

    Private Sub btnANYKmentesibol_Click(sender As Object, e As EventArgs) Handles btnANYKmentesibol.Click
        tbDirectoryNyomtatvanyok.Text = My.Settings.mappaANYKmentes
        LoadFilesToListView()
    End Sub

    Private Sub btnNyomiLefuzesibol_Click(sender As Object, e As EventArgs) Handles btnNyomiLefuzesibol.Click
        tbDirectoryNyomtatvanyok.Text = My.Settings.mappaLefuzes
        LoadFilesToListView()
    End Sub

    Private Sub btnNyomiXMLmegnyitasibol_Click(sender As Object, e As EventArgs) Handles btnNyomiXMLmegnyitasibol.Click
        tbDirectoryNyomtatvanyok.Text = My.Settings.mappaXMLmegnyitas
        LoadFilesToListView()
    End Sub

    Private Sub btnNyomtatvanyTalloz_Click(sender As Object, e As EventArgs) Handles btnNyomtatvanyTalloz.Click
        Dim SelectedPath As String = MappaBeállító.ValasszKonyvtarat(tbDirectoryNyomtatvanyok.Text)
        If SelectedPath <> "" Then
            tbDirectoryNyomtatvanyok.Text = SelectedPath
            LoadFilesToListView()
        End If
    End Sub


    Private Function ChooseSavedFile(StartPath As String, StartName As String, Felirat As String, Filter As String, DefExt As String) As String
        If StartPath <> String.Empty AndAlso StartPath.Last = Path.DirectorySeparatorChar Then StartPath = Strings.Left(StartPath, StartPath.Length - 1)
        Dim dialogresult As New DialogResult
        Dim ValasztottFajl = String.Empty
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = Filter
        saveFileDialog1.Title = Felirat
        saveFileDialog1.RestoreDirectory = True
        Try
            If Directory.Exists(StartPath) Then saveFileDialog1.InitialDirectory = StartPath
        Catch ex As Exception
        End Try

        saveFileDialog1.DefaultExt = DefExt
        saveFileDialog1.FileName = StartPath & Path.DirectorySeparatorChar & StartName
        dialogresult = saveFileDialog1.ShowDialog()
        If dialogresult <> DialogResult.OK Then Return String.Empty
        ValasztottFajl = saveFileDialog1.FileName
        Try
            If Directory.Exists(Path.GetDirectoryName(ValasztottFajl)) Then Return ValasztottFajl Else Return String.Empty
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Sub btnLefuzes_Click(sender As Object, e As EventArgs) Handles btnLefuzes.Click
        Dim GetFName As String = String.Empty
        Select Case ClickedTextBox
            Case "tbXMLPath", ""
                GetFName = Path.GetFileName(tbXMLPath.Text)
                tbXMLPath.Text = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & GetFName
            Case "tbKRboritekNeve"
                GetFName = Path.GetFileName(tbKRboritekNeve.Text)
                tbKRboritekNeve.Text = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & GetFName
            Case "tbES3NyomiLenyomiPath"
                GetFName = Path.GetFileName(tbES3NyomiLenyomiPath.Text)
                tbES3NyomiLenyomiPath.Text = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & GetFName
            Case "tbES3CsatolmanyPath"
                GetFName = Path.GetFileName(tbES3CsatolmanyPath.Text)
                tbES3CsatolmanyPath.Text = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & GetFName
        End Select
    End Sub

    Private Sub btnLefuzesiMappakTallózó_Click(sender As Object, e As EventArgs) Handles btnLefuzesiMappakTallózó.Click
        Dim SelectedPath As String = String.Empty
        Try
            Select Case ClickedTextBox
                Case "tbXMLPath", ""
                    SelectedPath = ChooseSavedFile(Path.GetDirectoryName(tbXMLPath.Text), Path.GetFileName(tbXMLPath.Text), "Hova fűzzem le az elkészült XML fájlokat?", "*.xml|XML", "xml")
                    If SelectedPath <> "" Then tbXMLPath.Text = SelectedPath
                Case "tbKRboritekNeve"
                    SelectedPath = ChooseSavedFile(Path.GetDirectoryName(tbKRboritekNeve.Text), Path.GetFileName(tbKRboritekNeve.Text), "Hova fűzzem le az elkészült KR borítékcsomagot?", "*.kr|KR boríték", "kr")
                    If SelectedPath <> "" Then tbKRboritekNeve.Text = SelectedPath
                Case "tbES3NyomiLenyomiPath"
                    SelectedPath = ChooseSavedFile(Path.GetDirectoryName(tbES3NyomiLenyomiPath.Text), Path.GetFileName(tbES3NyomiLenyomiPath.Text), "Hova fűzzem le a nyomtatvány lenyomatáról készült e-aktát?", "*.es3|ES3", "es3")
                    If SelectedPath <> "" Then tbES3NyomiLenyomiPath.Text = SelectedPath
                Case "tbES3CsatolmanyPath"
                    SelectedPath = ChooseSavedFile(Path.GetDirectoryName(tbES3CsatolmanyPath.Text), Path.GetFileName(tbES3CsatolmanyPath.Text), "Hova fűzzem le a csatolmányokról készült e-aktát?", "*.es3|ES3", "es3")
                    If SelectedPath <> "" Then tbES3CsatolmanyPath.Text = SelectedPath
            End Select
        Catch ex As Exception
        End Try

    End Sub


    Private Function PotoldKiMappavalHaCsakFajlNev(BemenoNev As String) As String
        Dim KimenoNev As String = String.Empty
        Try
            If String.IsNullOrWhiteSpace(Path.GetDirectoryName(BemenoNev)) Then
                KimenoNev = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & Path.GetFileName(BemenoNev)
            ElseIf Path.GetDirectoryName(BemenoNev) = Path.DirectorySeparatorChar Then
                KimenoNev = My.Settings.mappaLefuzes & Path.DirectorySeparatorChar & Path.GetFileName(BemenoNev)
            Else
                KimenoNev = BemenoNev
            End If
        Catch ex As Exception
            Return BemenoNev
        End Try
        Return KimenoNev

    End Function
    Private Sub tbXMLPath_Validating(sender As Object, e As EventArgs) Handles tbXMLPath.Validating
        If String.IsNullOrWhiteSpace(tbXMLPath.Text) Then Exit Sub
        Dim selectionpos = tbXMLPath.SelectionStart
        Dim tisztitottXMLNev As String = CleanPathandFileName(tbXMLPath.Text)
        If tbXMLPath.ReadOnly = True AndAlso tbXMLPath.Text <> tisztitottXMLNev Then
            Dim uzenet = "A kiválasztott XML fájl útvonalában meg nem engedett karaktereket vannak ("""",',&,<,>,:), ezért a beküldött XML fájlt nem fogja tudni olvasni az OBH. Kitisztíthatom a fájlnevet a célzott XML átnevezésével?"
            Dim reply As MsgBoxResult = MsgBox(uzenet, MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.Yes Then
                Try
                    Rename(tbXMLPath.Text, tisztitottXMLNev)
                Catch ex As Exception
                    Dim uzenet2 = "Átnevezési hiba! A kijelölt fájl vagy már nem elérhető vagy más alkalmazásban van nyitva. Indítsa el újra ezt a menüpontot"
                    MsgBox(uzenet2, MsgBoxStyle.Critical)
                    MyLoader.AddLogBook(Fnc.xml, uzenet2, LogTip.err)
                    Exit Sub
                End Try
            End If
            MyLoader.AddLogBook(Fnc.xml, "Sikeresen átnevezve a " & tbXMLPath.Text & " fájl " & tisztitottXMLNev & " névre", LogTip.norm)
            tbXMLPath.Text = tisztitottXMLNev
        Else
            If tbXMLPath.Text <> tisztitottXMLNev Then tbXMLPath.Text = tisztitottXMLNev
        End If

        tbXMLPath.Text = PotoldKiMappavalHaCsakFajlNev(tbXMLPath.Text)

        Dim GetFNamewoExt As String = GetENYKorXMLFileNameWithoutExtension(tbXMLPath.Text)

        Dim defDir As String = GetDefDirName(tbXMLPath.Text)

        tbKRboritekNeve.Text = defDir & Path.DirectorySeparatorChar & GetFNamewoExt & ".kr"
        tbES3CsatolmanyPath.Text = defDir & Path.DirectorySeparatorChar & GetFNamewoExt & "_csatolmanyok.es3"
        tbES3NyomiLenyomiPath.Text = defDir & Path.DirectorySeparatorChar & GetFNamewoExt & "_lenyomat.es3"
        tbZipFajlnev.Text = defDir & Path.DirectorySeparatorChar & GetFNamewoExt & "_bekuldott.zip"

        If selectionpos > 0 Then tbXMLPath.SelectionStart = selectionpos

        Try
            If Path.GetExtension(tbXMLPath.Text).ToLower <> ".xml" Then tbXMLPath.Text += ".xml"
        Catch ex As Exception
        End Try


    End Sub
    Private Function GetENYKorXMLFileNameWithoutExtension(InputNev As String) As String
        If Path.GetExtension(InputNev).ToLower = ".enyk" Then Return Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(InputNev)) Else Return Path.GetFileNameWithoutExtension(InputNev)
    End Function
    Private Function GetDefDirName(InputNev) As String

        If String.IsNullOrWhiteSpace(InputNev) Then
            GetDefDirName = My.Settings.mappaLefuzes
        Else
            GetDefDirName = Path.GetDirectoryName(InputNev)
            If String.IsNullOrWhiteSpace(GetDefDirName) Then GetDefDirName = My.Settings.mappaLefuzes
        End If
        'Azért kétszer hívom meg, mert ha az InputNev Null vagy üres, akkor hibaüzenetet ad a Path.GetDirectoryName
        Return GetDefDirName

    End Function

    Private Function CheckXML(filename As String) As String
        Dim parancs As String = "cmd:check.xml.silent"
        Dim anyklog As String = Path.GetDirectoryName(MyLog) & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(MyLog) & "_err_anyk.xml"
        If File.Exists(anyklog) Then
            Try
                File.Delete(anyklog)
            Catch ex As Exception
                anyklog = Path.GetDirectoryName(MyLog) & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(MyLog) & Now.ToShortDateString & "_err_anyk.xml"
            End Try
        End If
        Dim param As String = filename & ";" & anyklog
        abevjavaNyitas(parancs, param)
        Dim response As String
        If Not File.Exists(anyklog) Then
            Return String.Empty
        End If
        response = File.ReadAllText(anyklog, System.Text.Encoding.Default)
        Dim responsesplit() As String = Split(response, Environment.NewLine)
        response = String.Empty
        For Each line As String In responsesplit
            If line.ToLower.Contains("hiba") And Not line.ToLower.Contains("csatolt fájlok száma") And Not line.ToLower.Contains("ajánlott") Then response += line & Environment.NewLine
        Next
        Try
            File.Delete(anyklog)
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.bekuldes, "ÁNYK chexxml log fájl törlési hiba (nem fejeződött be?)", LogTip.norm)
        End Try
        Return response
    End Function

    Private Sub btnKeszit_Click(sender As Object, e As EventArgs) Handles btnKeszit.Click
        Dim hibauzenet As String = String.Empty
        Dim uzenet As String = String.Empty
        If tbXMLPath.Text = String.Empty Or tbKRboritekNeve.Text = String.Empty Or tbES3NyomiLenyomiPath.Text = String.Empty Or tbNyomtatvanyNeve.Text = String.Empty Then Exit Sub
        Dim result As Boolean = False

        If NemelerhetoOBH = True Then
            Dim FigyelmeztetesOBHElNemErheto As String = "Figyelem! A program nem tudta automatikusan ellenőrizni, hogy mi a legfrissebb elérhető verzió az OBH szerverén, mert az OBH szervere nem volt elérhető." & vbCrLf &
                "A kijelölt nyomtatványban használt verzió a " & tbNyomtatvanyNeve.Text & " nyomtatványból a gépén:  " & LoadDatafromKRandXKR.extractNYV(tbXMLPath.Text) & vbCrLf & vbCrLf &
                "Próbálja meg külön, a böngészővel ellenőrizni az OBH weboldalán (www.birosag.hu), hogy mi a közzétett legutolsó, elérhető verzió ebből, hátha van újabb." & vbCrLf & "Rossz verzió használata esetén a beadvány elutasítását kockáztatja!" & vbCrLf &
                "Biztosan el akarja készíteni a nyomtatványból a csomagot?"
            Dim resp As MsgBoxResult = MsgBoxResult.No
            resp = MsgBox(FigyelmeztetesOBHElNemErheto, MsgBoxStyle.YesNo)
            If resp = MsgBoxResult.No Then
                MyLoader.AddLogBook(Fnc.xml, "OBH szerver el nem érhetősége miatt készítés félbeszakítva", LogTip.err)
                Exit Sub
            End If
        End If

        If NyomiExt = "frm.enyk" Then
            Dim inputfajl As String = tbDirectoryNyomtatvanyok.Text & Path.DirectorySeparatorChar & SelectedNyomtatvany
            result = FinalizeENYK.ConvertENYKtoXML(inputfajl, tbXMLPath.Text)
            If result = False Then
                hibauzenet = "Vagy nem adott meg nyomtatványt, vagy nem adott meg minimum szükséges fájlnevet."
                MyLoader.AddLogBook(Fnc.xml, hibauzenet, LogTip.err)
                MsgBox(hibauzenet)
                Exit Sub
            End If
        End If
        If Not File.Exists(tbXMLPath.Text) Then
            hibauzenet = "A megadott XML fájl (" & tbXMLPath.Text & ") nem létezik vagy nem készült el."
            MyLoader.AddLogBook(Fnc.xml, hibauzenet, LogTip.err)
            MsgBox(hibauzenet)
            Exit Sub
        End If

        Dim EllenorzesEredmenye As String = CheckXML(tbXMLPath.Text)
        If EllenorzesEredmenye <> "" Then
            Dim dialogresult As New DialogResult
            hibauzenet = "Az ellenőrzés szerint "
            If EllenorzesEredmenye.Contains("súlyos") Then hibauzenet += "SÚLYOSAN "
            hibauzenet += "hibás az XML fájl."
            MyLoader.AddLogBook(Fnc.xml, hibauzenet & ":" & EllenorzesEredmenye, LogTip.err)
            Dim dgboxSzoveg = hibauzenet & Environment.NewLine & EllenorzesEredmenye
            If EllenorzesEredmenye.Contains("súlyos") Then
                MsgBox(dgboxSzoveg, MsgBoxStyle.Critical, "XML ellenőrzési hiba")
                Exit Sub
            Else
                dialogresult = MsgBox(dgboxSzoveg & Environment.NewLine & "Folytassa a program a benyújtást? Elutasítást kockáztat!", MsgBoxStyle.YesNo)
                If dialogresult = MsgBoxResult.No Then Exit Sub
            End If
        Else
            uzenet = "XML fájl ellenőrzése nem talált a csatolmányi darabszámon kívüli hibát"
            MyLoader.AddLogBook(Fnc.xml, uzenet, LogTip.siker)
        End If

        If lvCsatolmanyok.Items.Count = 0 Then FinalizeENYK.CsatszamIgazitas(tbXMLPath.Text, 0)

        Me.Cursor = Cursors.WaitCursor

        Dim NincsIsCsatolmany As Boolean = False
        If lvCsatolmanyok.Items.Count = 0 Then
            NincsIsCsatolmany = True
            tbES3CsatolmanyPath.Text = String.Empty
        End If

        'For Each item As ListViewItem In lvCsatolmanyok.Items
        'Dim ext = Path.GetExtension(item.Text).ToLower
        'If ext <> ".es3" And ext <> ".et3" And ext <> ".asic" And ext <> ".dossier" And ext <> ".dosszie" Then MuszajAlairni = True
        'Next
        'Ezt csak akkor érdemes kiterjeszteni, ha a több ES3 kezelését is biztosítja a program! Ekkor be kell állítani az ES3 aláírás nélküli funkciót is.

        Dim resultES3 As Boolean
        'If MuszajAlairni = True Then
        If NincsIsCsatolmany = False Then
            resultES3 = CsatolmanyokLetrehozasaesAlairasa(tbES3CsatolmanyPath.Text, lvCsatolmanyok.Items)
            If resultES3 = True Then
                MyLoader.AddLogBook(Fnc.eal, "A csatolmányok ES3 e-aktája sikeresen létrejött a " & tbES3CsatolmanyPath.Text & " útvonalon", LogTip.siker)
            Else
                MyLoader.AddLogBook(Fnc.eal, "Hiba miatt a csatolmányok ES3 e-aktája nem jött létre a " & tbES3CsatolmanyPath.Text & " útvonalon", LogTip.err)
                If NincsenAlairoTanusitvany = True Then MsgBox("Nincsen kiválasztva aláíró tanúsítvány, így nem hozható létre az aláírt csatolmány!", MsgBoxStyle.Critical) Else MsgBox("Aláírási hiba! Aláírt csatolmányok hiányában a KR-készítés művelete sikertelen!", MsgBoxStyle.Critical)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        resultES3 = LenyomatLetrehozasaAlairasa(tbES3NyomiLenyomiPath.Text, tbXMLPath.Text)
        If resultES3 = True Then
            MyLoader.AddLogBook(Fnc.eal, "A megadott XML lenyomata és aláírt ES3 e-aktája sikeresen létrejött a " & tbES3NyomiLenyomiPath.Text & " útvonalon", LogTip.siker)
        Else
            MyLoader.AddLogBook(Fnc.eal, "Hiba miatt az XML lenyomat aláírt ES3 e-aktája nem jött létre a " & tbES3NyomiLenyomiPath.Text & " útvonalon", LogTip.err)
            If NincsenAlairoTanusitvany = True Then MsgBox("Nincsen kiválasztva aláíró tanúsítvány, így nem hozható létre az aláírt nyomtatvány!", MsgBoxStyle.Critical) Else MsgBox("Aláírási hiba! Aláírt nyomtatvány hiányában a KR-készítés művelete sikertelen!", MsgBoxStyle.Critical)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        MyLoader.ProgressBar1.Style = ProgressBarStyle.Marquee
        MyLoader.ProgressBar1.MarqueeAnimationSpeed = 30
        Dim splash As New Csomagolas_alatt_short_message(GetTotalSize)
        splash.StartPosition = FormStartPosition.CenterScreen
        'Me.Hide()
        splash.Show()
        Dim CSTFileNevToCreate As String = String.Empty
        CSTFileNevToCreate = Path.GetTempPath & Path.GetFileNameWithoutExtension(tbXMLPath.Text) & ".cst"
        Dim Bzipped As Boolean
        If GetTotalSize() > 1024 * 1024 * 40 Then Bzipped = True '40 MB össz méret fölött már tömörít
        Try
            CSTExtractForm.BuildCST(tbES3CsatolmanyPath.Text, tbES3NyomiLenyomiPath.Text, CSTFileNevToCreate, "ES3-ba foglalva az összes melléklet", tbNyomtatvanyNeve.Text, Bzipped)
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.xml, "CST hiba: " & ex.Message, LogTip.err)
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try
        If Not File.Exists(CSTFileNevToCreate) Then
            hibauzenet = "CST fájl létrehozása hibás"
            MyLoader.AddLogBook(Fnc.xml, hibauzenet, LogTip.err)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        uzenet = "CST fájl létrehozása sikeres: " & CSTFileNevToCreate
        MyLoader.AddLogBook(Fnc.xml, uzenet, LogTip.siker)
        splash.Refresh()
        Dim CimzettSzervNeve As String
        Dim TempASCFileNeve = Path.GetTempFileName
        If tbNyomtatvanyNeve.Text.Contains("MUK_K01") Then
            CimzettSzervNeve = "MUK"
        Else
            Dim Cimzettdr As DataRow = Me.NyomtatvanyAdatokDataSet1.NyomiListaFeldolg.Select("Nyomtatvany='" & tbNyomtatvanyNeve.Text & "'").First
            CimzettSzervNeve = Cimzettdr("Hivk_rovidneve").ToString
        End If
        Dim keycontent As String = LoadPubKeyAscfromJar(CimzettSzervNeve)
        File.WriteAllText(TempASCFileNeve, keycontent)

        Dim KRTempCreate As String = String.Empty
        KRTempCreate = Path.GetTempPath & Path.GetFileNameWithoutExtension(tbXMLPath.Text) & ".kr"

        Dim OutputString As String = KRCreate(CimzettSzervNeve, CSTFileNevToCreate, TempASCFileNeve, KRTempCreate)
        splash.Close()

        If File.Exists(tbKRboritekNeve.Text) Then
            If File.Exists(tbKRboritekNeve.Text & ".bak") Then
                Try
                    File.Delete(tbKRboritekNeve.Text & ".bak")
                Catch ex As Exception
                End Try
            End If
            Try
                File.Move(tbKRboritekNeve.Text, tbKRboritekNeve.Text & ".bak")
            Catch ex As Exception
            End Try
        End If
        Try
            System.IO.File.Move(KRTempCreate, tbKRboritekNeve.Text)
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.bekuldes, "Az ideiglenes KR fájlt (" & KRTempCreate & ") nem tudtam átnevezni a végleges KR-fájl nevére (" & tbKRboritekNeve.Text & ")", LogTip.err)
        End Try

        hibauzenet = "KR boríték létrehozása sikertelen: " & tbKRboritekNeve.Text

        If Not OutputString.Contains("Siker:") Or Not File.Exists(tbKRboritekNeve.Text) Then
            MyLoader.AddLogBook(Fnc.xml, "ÁNYK hiba: " & hibauzenet & OutputString, LogTip.err)
            Exit Sub
        End If

        MyLoader.AddLogBook(Fnc.xml, "KR-boríték sikeresen létrehozva: " & tbKRboritekNeve.Text, LogTip.siker)
        Me.btnElvet.Text = "Bezár"
        Dim SikeresCsomag As New BekuldesRichTextForm
        SikeresCsomag.RichTextBox.Rtf = My.Resources.strSikeresCsomagRTF
        SikeresCsomag.ShowDialog()
        SikeresCsomag.Dispose()
        tblElkeszultKR_csomag.Visible = True

        If MyLoader.pnlHivatalikapu.Enabled Then
            btnHKPFeltoltes.Visible = True
            btnPKPANYKWSfeltoltes.Visible = True
        Else
            btnHKPFeltoltes.Visible = False
            If MyLoader.pnlPerkapu.Enabled = False Then btnPKPANYKWSfeltoltes.Visible = False
        End If

        If MyLoader.pnlPerkapu.Enabled Then
            btnPKPFeltoltes.Visible = True
            btnPKPANYKWSfeltoltes.Visible = True
        Else
            btnPKPFeltoltes.Visible = False
        End If

        If MyLoader.pnlUgyfelkapu.Enabled Then
            btnUKPFeltoltes.Visible = True
            btnUKPANYKWSfeltoltes.Visible = True
        Else
            btnUKPFeltoltes.Visible = False
            btnUKPANYKWSfeltoltes.Visible = False
        End If

        If btnPKPANYKWSfeltoltes.Visible = False AndAlso btnUKPANYKWSfeltoltes.Visible = False AndAlso btnHKPFeltoltes.Visible = False AndAlso btnUKPFeltoltes.Visible = False AndAlso btnPKPFeltoltes.Visible = False Then
            Dim NincsenKapuAdatMegadva As New BekuldesRichTextForm
            If NoInternet = False Then
                NincsenKapuAdatMegadva.RichTextBox.Rtf = "{\rtf1\ansi\ansicpg1250\deff0\nouicompat\deflang1038{\fonttbl{\f0\fnil\fcharset238 Microsoft Sans Serif;}{\f1\fnil\fcharset0 Microsoft Sans Serif;}}
{\colortbl ;\red255\green255\blue255;} {\*\generator Riched20 10.0.14393}\viewkind4\uc1 \pard\sa200\sl276\slmult1\qj\highlight1\f0\fs19\lang14 Nem adott meg kapu jelszavakat, \f1\'edgy e men\'fcpontb\'f3l most nem tudja bek\'fcldeni az elk\'e9sz\'fclt KR csomagot.\par
\f0\lang1038 Kattintson a jobb als\'f3 sarokban l\'e9v\'f5 '\b Kapu adatok r\'f6gz\'edt\'e9se\b0 ' gombra vagy bez\'e1r\'e1s ut\'e1n k\f1\lang14\'fcldje be \f0\lang1038 k\'e9s\'f5bb \f1\lang14 a KR csomagot annak mapp\'e1j\'e1b\'f3l (\f0\lang1038 " & tbKRboritekNeve.Text.Replace("\", "\\") & "\f1\lang14 ) a \b b\'f6ng\'e9sz\f0\'f5 \b0\lang1038 seg\'edts\'e9g\'e9vel \f1\lang14 (\f0\lang1038 l\'e1sd 'K\f1\lang14 apukezel\'e9s\f0\lang1038 '\f1\lang14 ) vagy az \b\'c1NYK seg\'edts\'e9g\'e9vel\b0 .\f0\lang1038  (Ez ut\'f3bbi esetben el\'f5bb mentse \'e1t k\'e9zzel az elk\'e9sz\'fclt \f1\lang14 KR csomagot az \'c1NYK k\'fcldend\f0\'f5 mapp\f1\'e1ba\f0\lang1038 , azaz ide: " & My.Settings.mappaANYKkuldendo.Replace("\", "\\") & " )\highlight0\f3\fs22\lang14\par}"
                NincsenKapuAdatMegadva.ShowDialog()
                NincsenKapuAdatMegadva.Dispose()
            Else MsgBox("Nincsen Internet kapcsolat! Küldje be a fájlneveket a Kapukezelés menüpontból, ha már lesz Internet kapcsolata", MsgBoxStyle.Critical)
            End If
            'ANYKMappaVisszaSub()
        End If
        If cbxUgytorzsbe.Checked = True Then
            Ugytorzs_rogzitoTableAdapter.Insert(tbCimzettSzervNeve.Text, ugyszamosszes(UgycsoportErtek), ugyszamosszes(LajstromszamErtek), ugyszamosszes(EvszamErtek), tbFelperes.Text, tbAlperes.Text, LoadDatafromKRandXKR.extractParameterek(tbXMLPath.Text, tbNyomtatvanyNeve.Text, "targya"), Path.GetFileName(tbKRboritekNeve.Text), "")
            Ugytorzs_rogzitoTableAdapter.Update(UgytorzsTabla)
        End If

        If cbZipped.Checked Then ZipOutput(NincsIsCsatolmany)
        Try
            If CSTFileNevToCreate <> String.Empty Then File.Delete(CSTFileNevToCreate)
            File.Delete(TempASCFileNeve)
            Dim lenkr As Long = FileSystem.FileLen(tbKRboritekNeve.Text)
            If lenkr > MaxSizeKR Then
                uzenet = "Az elkészült KR fájl nem küldhető be per/hivatali/ügyfélkapu útján, a mérete eléri vagy meghaladja a 300 MB-ot."
                MyLoader.AddLogBook(Fnc.xml, uzenet, LogTip.err)
                MsgBox(uzenet, MsgBoxStyle.Critical)
                Dim result2 As New DialogResult
                result2 = MsgBox("Törölhetem a KR fájlt? (" & tbKRboritekNeve.Text & ")", MsgBoxStyle.YesNo)
                If result2 = MsgBoxResult.Yes Then
                    Try
                        File.Delete(tbKRboritekNeve.Text)
                    Catch ex As Exception
                        MsgBox("A törölni kívánt KR fájl nem található vagy nincsen jogosultsága a törléshez (" & tbKRboritekNeve.Text & ")", MsgBoxStyle.Critical)
                    End Try
                End If
                tblElkeszultKR_csomag.Visible = False
            End If
            'If lenkr > MaxSizeKRBrowsersending Then
            'uzenet = "Az elkészült KR fájlt nem javasoljuk böngésző útján beküldeni, mert a mérete eléri vagy meghaladja azt a méretet, amit böngészővel feltölthet. Javasoljuk az ÁNYK útján beküldeni a csomagot."
            '            MyLoader.AddLogBook(Fnc.xml, uzenet, LogTip.err)
            '           MsgBox(uzenet, MsgBoxStyle.Critical)
            '          btnPKPFeltoltes.Visible = False
            '         btnHKPFeltoltes.Visible = False
            '        btnUKPFeltoltes.Visible = False
            '       End If
        Catch Ex As System.IO.IOException
            MyLoader.AddLogBook(Fnc.xml, "Hiányzó vagy még nyitott fájl: " & Ex.Message, LogTip.err)
        End Try

    End Sub
    Private Sub ZipOutput(NincsIsCsatolmany As Boolean)
        Dim uzenet = String.Empty
        Dim zipName = tbZipFajlnev.Text
        If File.Exists(tbZipFajlnev.Text) Then
            Dim resp As DialogResult = MsgBox("A megadott útvonalon már létezik egy ilyen fájl: " & tbZipFajlnev.Text & ". Felülírhatom?", MsgBoxStyle.YesNo, "Már létezik ilyen nevű fájl")
            If resp = DialogResult.Yes Then
                Try
                    File.Delete(tbZipFajlnev.Text)
                Catch ex As Exception
                    MyLoader.AddLogBook(Fnc.bekuldes, "A kijelölt zip fájl más alkalmazásban nyitva van, így a program nem tudja felülírni azt, a kért zip fájl nem jött létre: " & tbZipFajlnev.Text, LogTip.err)
                    Exit Sub
                End Try
            Else
                Exit Sub
            End If
        End If
        Using newFile As ZipArchive = ZipFile.Open(tbZipFajlnev.Text, ZipArchiveMode.Create)
            Try
                newFile.CreateEntryFromFile(tbXMLPath.Text, Path.GetFileName(tbXMLPath.Text))
                If NincsIsCsatolmany = False Then newFile.CreateEntryFromFile(tbES3CsatolmanyPath.Text, Path.GetFileName(tbES3CsatolmanyPath.Text))
                newFile.CreateEntryFromFile(tbES3NyomiLenyomiPath.Text, Path.GetFileName(tbES3NyomiLenyomiPath.Text))
                newFile.CreateEntryFromFile(tbKRboritekNeve.Text, Path.GetFileName(tbKRboritekNeve.Text))
                'newFile.CreateEntryFromFile(CSTToCreate, Path.GetFileName(CSTToCreate)) <-CST-t külön nem zippelünk
            Catch ex As System.IO.IOException
                uzenet = "Az elkészült zip fájlba nem tudtam betömöríteni egy vagy több fájlt"
                MyLoader.AddLogBook(Fnc.xml, uzenet, LogTip.err)
                MsgBox(uzenet, MsgBoxStyle.Critical)
            End Try
        End Using

        If File.Exists(tbZipFajlnev.Text) And cbxZipTorles.Checked = True Then
            MyLoader.AddLogBook(Fnc.xml, "Elkészült a beküldésnél használt fájlokat tartalmazó zip állomány: " & tbZipFajlnev.Text & " A zipbe került fájlokat a KR kivételével törölte a program.", LogTip.siker)
            Try
                Using ZipFileProc As ZipArchive = ZipFile.OpenRead(tbZipFajlnev.Text)
                    Dim tempzipentry = ZipFileProc.GetEntry(Path.GetFileName(tbXMLPath.Text))
                    If Not tempzipentry Is Nothing Then
                        File.Delete(tbXMLPath.Text)
                    End If
                    tempzipentry = ZipFileProc.GetEntry(Path.GetFileName(Path.GetFileName(tbES3CsatolmanyPath.Text)))
                    If Not tempzipentry Is Nothing And NincsIsCsatolmany = False Then
                        File.Delete(tbES3CsatolmanyPath.Text)
                    End If
                    tempzipentry = ZipFileProc.GetEntry(Path.GetFileName(Path.GetFileName(tbES3NyomiLenyomiPath.Text)))
                    If Not tempzipentry Is Nothing Then
                        File.Delete(tbES3NyomiLenyomiPath.Text)
                    End If
                End Using
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.xml, "A zipen kívüli állományok egyike törlésénél hiba: " & tbXMLPath.Text & "; " & tbES3CsatolmanyPath.Text & "; " & tbES3NyomiLenyomiPath.Text, LogTip.err)
            End Try
        ElseIf File.Exists(tbZipFajlnev.Text) And cbxZipTorles.Checked = False Then
            MyLoader.AddLogBook(Fnc.xml, "Elkészült a beküldésnél használt fájlokat tartalmazó zip állomány: " & tbZipFajlnev.Text & " A zipbe került fájlokat nem törölte a program.", LogTip.siker)
        ElseIf Not File.Exists(tbZipFajlnev.Text) Then
            MyLoader.AddLogBook(Fnc.xml, "Nem készült el a beküldésnél használt fájlokat tartalmazó zip állomány: " & tbZipFajlnev.Text, LogTip.err)
        End If
    End Sub

    Friend Function UgytorzsbeMent() As Boolean
        Dim response As Boolean = False

        Return response
    End Function
    Friend Function IsFileLocked(file As FileInfo) As Boolean
        'source = http://stackoverflow.com/questions/876473/is-there-a-way-to-check-if-a-file-is-in-use/937558#937558
        Dim stream As FileStream = Nothing

        Try
            stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None)
        Catch generatedExceptionName As IOException
            'the file is unavailable because it is:
            'still being written to
            'or being processed by another thread
            'or does not exist (has already been processed)
            Return True
        Finally
            If stream IsNot Nothing Then
                stream.Close()
            End If
        End Try

        'file is not locked
        Return False
    End Function


    Friend Function LoadPubKeyAscfromJar(pCimzett As String) As String
        Dim EroforrasJarFileDirectory As String = eroforrasok
        Dim LatestJarResource As String = String.Empty

        Try
            If Not Directory.Exists(EroforrasJarFileDirectory) Then MsgBox("Nincsen eroforrasok könyvtár beállítáva") : Return String.Empty
        Catch ex As Exception
            Return String.Empty
        End Try
        LatestJarResource = LatestResources(pCimzett)
        Dim tempname As String = Path.GetTempFileName
        Dim tempname2 As String = Path.GetTempFileName
        Dim certname As String = String.Empty
        Dim response As String = String.Empty
        If File.Exists(LatestJarResource) Then
            Using JarFiletoProc As ZipArchive = ZipFile.OpenRead(LatestJarResource)
                'certname = String.Empty
                Dim tempzipentry As ZipArchiveEntry = JarFiletoProc.GetEntry("orginfo.xml")
                tempzipentry.ExtractToFile((tempname), True)
            End Using
            certname = GetParamFromXML(tempname, "certfilename")
            File.Delete(tempname)
            Using JarFiletoProc As ZipArchive = ZipFile.OpenRead(LatestJarResource)
                Dim tempzipentry = JarFiletoProc.GetEntry(certname)
                If Not tempzipentry Is Nothing Then
                    tempzipentry.ExtractToFile(tempname2, True)
                End If
            End Using

            If File.Exists(tempname2) Then
                response = File.ReadAllText(tempname2)
                File.Delete(tempname2)
            End If
        Else
            Dim uzenet = "Nem találta a program az erőforrásfájlt a " & pCimzett & "-hez! (Olyan nyomtatványt akart kitölteni, ami még nincsen a gépére telepítve."
            MsgBox(uzenet, MsgBoxStyle.Critical)
            MyLoader.AddLogBook(Fnc.bekuldes, uzenet, LogTip.err)
            Return String.Empty
            '!Letöltése ennek automatikusan?

        End If
        LatestJarResource = Nothing
        Return response
    End Function
    Private Function StartES3Letrehozas(ES3Path As String) As XSignDossier

        SharedXSignSession.SetWorkSilent(1)
        CheckSetSigLevel()
        If File.Exists(ES3Path) Then
            Dim resp As DialogResult = MsgBox("A megadott útvonalon már létezik egy fájl: " & ES3Path & ". Felülírhatom?", MsgBoxStyle.YesNo, "Már létezik ilyen nevű fájl")
            If resp = DialogResult.Yes Then File.Delete(ES3Path) Else Return Nothing
        End If
        Dim ES3DosszieToCreate As XSignDossier = SharedXSignSession.NewDossier
        If My.Settings.Regisztrált = True AndAlso My.Settings.TSURL.Trim.Replace(Environment.NewLine, "") = "" Then
            Dim uzenet = "Hiba: nincsen időbélyeg szolgáltató beállítva. Folytassam az e-akta létrehozását? Ez esetben a beadvány érvényes lehet, de csak addig, amíg a használt aláíró tanúsítványt vissza nem vonják vagy le nem jár"
            If TShibakezeles(uzenet) = False Then Return Nothing
            'Else
            'If (Kapukezelo.Decrypt(My.Settings.TSUN, "TSUN") = String.Empty Or Kapukezelo.Decrypt(My.Settings.TSPW, "TSPW") = String.Empty) And My.Settings.TSACertDefault = String.Empty Then
            '            Dim uzenet = "Hiba: nincsen sem időbélyeg szolgáltató autentikációs tanúsítvány, sem időbélyeg szolgáltató felhasználónév és jelszó beállítva. Folytassam az e-akta létrehozását? Ez esetben a beadvány érvényes lehet, de csak addig, amíg a használt aláíró tanúsítványt vissza nem vonják vagy le nem jár"
            'If TShibakezeles(uzenet) = False Then Return Nothing
            'End If
        End If
        Return ES3DosszieToCreate

    End Function
    Friend Function TShibakezeles(uzenet As String) As Boolean
        Dim response As Boolean = False
        Dim dialogresult As DialogResult = MsgBox(uzenet, MsgBoxStyle.YesNo)
        If dialogresult = MsgBoxResult.No Then
            MyLoader.AddLogBook(Fnc.eal, "Időbélyeg szolgáltató hiánya miatt az e-akta létrehozása megszakadt", LogTip.err)
            Return False
        End If
        If dialogresult = MsgBoxResult.Yes Then
            SharedXSignSession.SetXAdESType(2)
            MyLoader.AddLogBook(Fnc.eal, "Időbélyeg szolgáltató hiánya miatt XAdES-EPES típusú, nem időbélyegzett aláírást hoz létre a program", LogTip.err)
            response = True
        End If
        Return response
    End Function
    Friend Function CsatolmanyokLetrehozasaesAlairasa(ES3Path As String, lvItems As ListView.ListViewItemCollection) As Boolean
        Dim log As Integer = 0
        Dim signdoc As New XSignDocument
        Dim signature As New XSignSignature
        Dim csatolmanyES3 As XSignDossier = StartES3Letrehozas(ES3Path)
        If csatolmanyES3 Is Nothing Then
            MyLoader.AddLogBook(Fnc.eal, "Csatolmány ES3 létrehozási hiba (1)", LogTip.err)
            Return False
        End If

        For Each item As ListViewItem In lvItems
            signdoc = csatolmanyES3.InsertDocument(item.Text)
            If signdoc Is Nothing Then
                Dim uzenet As String = "Nem sikerült ES3 e-aktába illeszteni a következő fájlt: " & item.Text
                MyLoader.AddLogBook(Fnc.eal, uzenet, LogTip.err)
            End If
        Next

        Dim metamap As New XSignMetadataMap
        '<dc:description><%= tbFelperes.Text %> felperes <%= tbAlperes.Text %> ellen</dc:description>
        Dim DCCMet = <?xml version='1.0' encoding='UTF-8'?>
                     <mireg:metadata xmlns:dc='http://purl.org/dc/elements/1.1/' xmlns:dcterms='http://purl.org/dc/terms/'
                         xmlns:mireg='http://mireg.org/schema/1.0/'
                         schemaLocation='http://mireg.org/schema/1.0/ https://www.microsec.hu/ds/metadata.xsd' about='#Object0'>
                         <mireg:mireg>
                             <dc:title>Beadvány</dc:title>
                             <dc:creator></dc:creator>
                             <dc:subject><%= tbES3CsatolmanyPath.Text %></dc:subject>
                             <dc:description><%= tbFelperes.Text & " fp " & tbAlperes.Text & " ap " %></dc:description>
                             <dc:publisher></dc:publisher>
                             <dc:contributor></dc:contributor>
                             <dc:identifier><%= tbUgyszam.Text %> címzett: <%= tbCimzettSzervNeve.Text %></dc:identifier>
                             <dcterms:conformsTo>Bírósággal való elektronikus kapcsolattartás</dcterms:conformsTo>
                             <dc:date><%= Now.ToShortDateString %></dc:date>
                             <dc:type><%= tbNyomtatvanyNeve.Text %></dc:type>
                             <dc:format>A4</dc:format>
                         </mireg:mireg>
                     </mireg:metadata>
        metamap.PutKeyAndValue("Metadata", DCCMet.ToString)
        csatolmanyES3.SetCustomMetadata(metamap)
#If Not DEBUG And ARCONSULT <> "Y" Then
        If My.Settings.Regisztrált = False Then
            csatolmanyES3.Save(ES3Path)
            MyLoader.AddLogBook(Fnc.eal, "Demó üzemmód miatt az ES3 aláírás nélkül elmentve", LogTip.norm)
            Return True
        End If
#End If
        signature = csatolmanyES3.Sign()
        If signature Is Nothing Then
            Dim uzenet As String = "Nem sikerült az ES3 aktát aláírni: " & ES3Path
            MyLoader.AddLogBook(Fnc.eal, uzenet, LogTip.err)
            Return False
        End If
        Dim idobelyegezett = signature.GetXadesType
        If idobelyegezett < 3 Then EllTimeStampHiany()
        csatolmanyES3.Save(ES3Path)
        CheckSetSigLevel()
        Return True
    End Function

    Private Sub EllTimeStampHiany()
        If My.Settings.TSURL.Trim.Replace(Environment.NewLine, String.Empty) = String.Empty Then Exit Sub
        If Kapukezelo.Decrypt(My.Settings.TSUN, "TSUN") = String.Empty Then Exit Sub
        If Kapukezelo.Decrypt(My.Settings.TSPW, "TSPW") = String.Empty Then Exit Sub
        If Not My.Settings.TSACertDefault = String.Empty Then Exit Sub
        Dim uzenet As String = "Az időbélyeg létrehozásához szükséges adatokat beállította, de időbélyeg mégsem jött létre. Ellenőrizze az időbélyeg beállításokat! Az időbélyeg nem érvényességi feltétel, ha az aláíráshoz használt tanúsítvány érvényességének lejárta előtt ellenőrzi a bíróság a beadványát."
        MyLoader.AddLogBook(Fnc.eal, uzenet, LogTip.err)

    End Sub

    Friend Function LenyomatLetrehozasaAlairasa(ES3Path As String, SourceFile As String) As Boolean
        '2. Elkészíti a lenyomatot az XML-ből és aláírja
        Dim log As Integer = 0
        Dim signdoc As New XSignDocument
        Dim signature As New XSignSignature
        Dim lenyomatES3 As XSignDossier = StartES3Letrehozas(ES3Path)
        If lenyomatES3 Is Nothing Then
            MyLoader.AddLogBook(Fnc.eal, "Lenyomat ES3 létrehozási hiba (1)", LogTip.err)
            Return False
        End If

        Dim XMLasString = File.ReadAllText(SourceFile).ToLower
        Dim hashsha256 As String = FinalizeENYK.getSHA256Hash(XMLasString)
        Dim lenyomatStr1 = "<document xmlns=" & Chr(34) & "http://nisz.hu/anykAttachment/1.0" & Chr(34) & "><fileName>"
        Dim lenyomatStr2 = "</fileName><hashAlgorithm>SHA-256</hashAlgorithm><hash>"
        Dim lenyomatStr3 = "</hash></document>"
        Dim LenyomatToWrite As String = lenyomatStr1 + SourceFile + lenyomatStr2 + hashsha256 + lenyomatStr3
        Dim LenyomatFajlNeve As String = Path.GetFileNameWithoutExtension(SourceFile) & "_lenyomat.xml"
        Dim TempDir As String = Path.GetTempPath
        Dim FullPathLenyomi As String = TempDir & Path.DirectorySeparatorChar & LenyomatFajlNeve
        If File.Exists(FullPathLenyomi) Then File.Delete(FullPathLenyomi)
        File.WriteAllText(FullPathLenyomi, LenyomatToWrite, System.Text.Encoding.UTF8)

        signdoc = lenyomatES3.InsertDocument(FullPathLenyomi)
        If signdoc Is Nothing Then
            Return False
        End If

        Dim metamap As New XSignMetadataMap
        Dim DCCMet = <?xml version='1.0' encoding='UTF-8'?>
                     <mireg:metadata xmlns:dc='http://purl.org/dc/elements/1.1/' xmlns:dcterms='http://purl.org/dc/terms/'
                         xmlns:mireg='http://mireg.org/schema/1.0/'
                         schemaLocation='http://mireg.org/schema/1.0/ https://www.microsec.hu/ds/metadata.xsd' about='#Object0'>
                         <mireg:mireg>
                             <dc:title>Hitelesített csatolmány lenyomat (aláírt XML)</dc:title>
                             <dc:creator></dc:creator>
                             <dc:subject><%= tbES3NyomiLenyomiPath.Text %></dc:subject>
                             <dc:description><%= tbFelperes.Text & "fp " & tbAlperes.Text & "ap" %></dc:description>
                             <dc:publisher><%= SourceFile %></dc:publisher>
                             <dc:contributor><%= Path.GetFileName(FullPathLenyomi) %></dc:contributor>
                             <dc:identifier><%= tbUgyszam.Text %> címzett: <%= tbCimzettSzervNeve.Text %></dc:identifier>
                             <dcterms:conformsTo>Bírósággal való elektronikus kapcsolattartás</dcterms:conformsTo>
                             <dc:date><%= Now.ToShortDateString %></dc:date>
                             <dc:type><%= tbNyomtatvanyNeve.Text %></dc:type>
                             <dc:format>A4</dc:format>
                         </mireg:mireg>
                     </mireg:metadata>
        metamap.PutKeyAndValue("Metadata", DCCMet.ToString)
        lenyomatES3.SetCustomMetadata(metamap)

#If Not DEBUG And ARCONSULT <> "Y" Then
        If My.Settings.Regisztrált = False Then
            lenyomatES3.Save(ES3Path)
            MyLoader.AddLogBook(Fnc.eal, "Demó üzemmód miatt az ES3 aláírás nélkül elmentve", LogTip.norm)
            Return True
        End If
#End If

        signature = lenyomatES3.Sign()
        If signature Is Nothing Then
            Dim uzenet As String = "Nem sikerült aláírni az ES3 aktáját (" & ES3Path & ") ennek a lenyomatnak: " & FullPathLenyomi
            MyLoader.AddLogBook(Fnc.eal, uzenet, LogTip.err)
            Return False
        End If
        Dim idobelyegezett = signature.GetXadesType
        If idobelyegezett < 3 Then EllTimeStampHiany()
        lenyomatES3.Save(ES3Path)
        File.Delete(FullPathLenyomi)

        Return True
    End Function

    Private Sub btnFeltoltes_Click(sender As Object, e As EventArgs) Handles btnUKPFeltoltes.Click, btnPKPFeltoltes.Click, btnHKPFeltoltes.Click
        Dim sendername As Button = CType(sender, Button)
        Dim namestring As String = sendername.Name
        Dim kaputipus As New Kapu
        namestring = namestring.Replace("btn", "")
        namestring = namestring.Replace("Feltoltes", "")
        Select Case namestring
            Case "UKP"
                kaputipus = Kapu.UKP
            Case "HKP"
                kaputipus = Kapu.HKP
            Case "PKP"
                kaputipus = Kapu.PKP
        End Select
        Dim kapukezeloablak As New Kapukezelo
        'kapukezeloablak.LoginHttpRequest_wWebBrowser_feltoltes_fajllal(kaputipus, tbKRboritekNeve.Text)

        Try
            Clipboard.SetDataObject(tbKRboritekNeve.Text, False, 5, 200)
        Catch ex As Exception
        End Try
        kapukezeloablak.NavigateToTarget_wWebDriver(kaputipus, 1, tbKRboritekNeve.Text)
    End Sub


    Private Function SanitizeforKR(input As String) As String
        Dim response As String = String.Empty
        Dim PathName As String = Path.GetDirectoryName(input)
        Dim ExtensionName As String = Path.GetExtension(input)
        Dim filename As String = Path.GetFileNameWithoutExtension(input)
        response = filename.Replace("ő", "o")
        response = response.Replace(".", "")
        response = response.Replace("Ő", "O")
        response = response.Replace("ű", "u")
        response = response.Replace("Ű", "U")
        response = response.Replace(" ", "_")
        response = response.Replace("$", "_")
        response = response.Replace("!", "_")
        response = response.Replace("=", "_")
        response = response.Replace("%", "_")
        response = response.Replace("+", "_")
        response = response.Replace("-", "_")
        response = PathName & Path.DirectorySeparatorChar & response & ExtensionName
        Return response
    End Function

    Private Sub melyiket(sender As Object, e As EventArgs) Handles tbXMLPath.Click, tbKRboritekNeve.Click, tbES3NyomiLenyomiPath.Click, tbES3CsatolmanyPath.Click
        Dim senderboxname As String = CType(sender, TextBox).Name
        ClickedTextBox = senderboxname
    End Sub

    Private Sub btnPKPANYKWSfeltoltes_Click(sender As Object, e As EventArgs) Handles btnPKPANYKWSfeltoltes.Click
        Dim PKPFigyelmeztetes As New BekuldesRichTextForm
        PKPFigyelmeztetes.RichTextBox.Rtf = My.Resources.strPKPFigyelmeztetesRTF
        PKPFigyelmeztetes.ShowDialog()
        PKPFigyelmeztetes.Dispose()
        RunOtherANYKFolderSettingsCheck()
        If My.Settings.mappaANYKkuldendo = String.Empty Then
            Dim hibauzenetnincskuldendo As String = "Az ÁNYK-ban beállított ÁNYK küldendő mappa (" & My.Settings.mappaANYKkuldendo & ") nem létezik. Enélkül az ÁNYK-val nem fog tudni beküldeni KR csomagot! Telepítse újra az ÁNYK-t és a felhasználói beállításoknál adjon meg egy létező küldési mappát."
            MyLoader.AddLogBook(Fnc.cfg, hibauzenetnincskuldendo, LogTip.err)
            MsgBox(hibauzenetnincskuldendo, MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim celfajl As String = String.Empty
        Try
            celfajl = My.Settings.mappaANYKkuldendo & Path.DirectorySeparatorChar & Path.GetFileName(tbKRboritekNeve.Text)
            File.Copy(tbKRboritekNeve.Text, celfajl, True)
            Try
                Clipboard.SetDataObject(tbKRboritekNeve.Text, False, 5, 200)
            Catch ex As Exception
            End Try
            abevjavacsaknyitas(Path.GetFileName(tbKRboritekNeve.Text))
        Catch ex As Exception
            Dim uzenet = "Fájlmásolási hiba! (cél:" & celfajl & ")"
            MyLoader.AddLogBook(Fnc.bekuldes, uzenet, LogTip.err)
            MsgBox(uzenet, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub abevjavacsaknyitas(CelfajlNeve As String)
        Dim abevjavabat = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "abevjava_start.bat"
        If Not File.Exists(abevjavabat) Then
            Dim uzenet0 As String = "A program nem találja az ÁNYK indításához szükséges abevjava futtató start fájlt, kérem telepítse újra az ÁNYK-t!"
            MyLoader.AddLogBook(Fnc.cfg, uzenet0, LogTip.err)
            MsgBox(uzenet0, MsgBoxStyle.Critical & MsgBoxStyle.OkOnly)
        End If
        Dim abevprocess As New System.Diagnostics.Process
        abevprocess.StartInfo.UseShellExecute = False
        Try
            abevprocess.StartInfo.WorkingDirectory = Path.GetDirectoryName(abevjavabat)
        Catch ex As Exception
        End Try
        abevprocess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        abevprocess.StartInfo.FileName = abevjavabat
        abevprocess.Start()
        MyLoader.AddLogBook(Fnc.bekuldes, "Az ÁNYK megnyitása", LogTip.norm)

        If tbKRboritekNeve.Text = My.Settings.mappaANYKelkuldott & Path.DirectorySeparatorChar & CelfajlNeve Then Exit Sub
        'Ha az eredeti KR fájl is az elküldött könyvtárba került, a törlési rutint átlépi

        Dim dialogresult As New DialogResult
        dialogresult = MsgBox("Ha elkészült a feltöltés és bezárta az ÁNYK-t, és törölni kívánja az ÁNYK elküldött könyvtárból a KR másolatát, kattintson az Igen gombra, ellenkező esetben a Nem gombra ", MsgBoxStyle.YesNo)
        If dialogresult = MsgBoxResult.Yes Then
            abevprocess.Close()
            abevprocess.Dispose()
            Try
                File.Delete(My.Settings.mappaANYKelkuldott & Path.DirectorySeparatorChar & CelfajlNeve)
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.bekuldes, "A törlendő fájlt az ÁNYK elküldött mappában nem találtuk vagy az írási jogosultság hiányzik (" & CelfajlNeve & ")", LogTip.err)
            End Try
        End If
    End Sub

    Private Sub btnUKPANYKWSfeltoltes_Click(sender As Object, e As EventArgs) Handles btnUKPANYKWSfeltoltes.Click
        Dim parancs As String = "cmd:bekuldes.kr.silent"
        Dim hibauzenetnincskuldendo As String = String.Empty
        If My.Settings.mappaANYKkuldendo = String.Empty Then
            hibauzenetnincskuldendo = "Az ÁNYK-ban beállított ÁNYK küldendő mappa (" & My.Settings.mappaANYKkuldendo & ") nem létezik. Enélkül az ÁNYK-val nem fog tudni beküldeni KR csomagot! Telepítse újra az ÁNYK-t és a felhasználói beállításoknál adjon meg egy létező küldési mappát."
            MyLoader.AddLogBook(Fnc.cfg, hibauzenetnincskuldendo, LogTip.err)
            MsgBox(hibauzenetnincskuldendo, MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim anyklog As String = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(MyLog) & "_res.txt"
        Dim celfajl As String = My.Settings.mappaANYKkuldendo & Path.DirectorySeparatorChar & Path.GetFileName(tbKRboritekNeve.Text)
        Try
            File.Copy(tbKRboritekNeve.Text, celfajl, True)
        Catch Ex As Exception
        End Try

        Dim paramfajl As String = Path.GetFileNameWithoutExtension(Path.GetTempFileName) & ".txt"
        Dim forrasStrUName As String = Kapukezelo.Decrypt(My.Settings.UKPUName, "UKPUName")
        Dim forrasStrPassw As String = Kapukezelo.Decrypt(My.Settings.UKPPassw, "UKPPassw")
        If forrasStrUName = "" Or forrasStrPassw = "" Then
            Dim uzenet0 = "Nincsen rögzítve ügyfélkapu jelszó vagy felhasználónév, ezért nem lehet így feltölteni. Rögzítse ezeket az adatokat és próbálja újra"
            MyLoader.AddLogBook(Fnc.cfg, uzenet0, LogTip.err)
            MsgBox(uzenet0, MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim bytUName As Byte() = System.Text.Encoding.UTF8.GetBytes(forrasStrUName)
        Dim bytPassw As Byte() = System.Text.Encoding.UTF8.GetBytes(forrasStrPassw)
        Dim base64Str As String = Convert.ToBase64String(bytUName) & ":" & Convert.ToBase64String(bytPassw)

        File.WriteAllText(My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & paramfajl, base64Str)
        Dim param As String = Path.GetFileName(celfajl) & ";" & paramfajl & ";" & Path.GetFileName(anyklog)

        Dim abevjavabat = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "abevjava_start.bat"
        If Not File.Exists(abevjavabat) Then
            Dim uzenet0 As String = "A program nem találja az ÁNYK indításához szükséges abevjava futtató start fájlt, kérem telepítse újra az ÁNYK-t!"
            MyLoader.AddLogBook(Fnc.cfg, uzenet0, LogTip.err)
            MsgBox(uzenet0, MsgBoxStyle.Critical & MsgBoxStyle.OkOnly)
        End If
        Dim abevprocess As New System.Diagnostics.Process
        abevprocess.StartInfo.UseShellExecute = False
        Try
            abevprocess.StartInfo.WorkingDirectory = Path.GetDirectoryName(abevjavabat)
        Catch ex As Exception
        End Try
        abevprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        abevprocess.StartInfo.FileName = abevjavabat
        abevprocess.StartInfo.Arguments = Chr(34) & parancs & " " & param & Chr(34)
        abevprocess.StartInfo.RedirectStandardOutput = True
        abevprocess.StartInfo.RedirectStandardError = True

        abevprocess.Start()
        Dim OutputString = abevprocess.StandardOutput.ReadToEnd()
        Dim errorString = abevprocess.StandardError.ReadToEnd()
        abevprocess.WaitForExit()
        abevprocess.Close()
        abevprocess.Dispose()
        Dim response As String
        If Not File.Exists(anyklog) Then
            Exit Sub
        End If

        response = File.ReadAllText(anyklog, System.Text.Encoding.Default)
        Dim responsesplit() As String = Split(response, vbLf)
        Dim counter As Integer = 0
        Dim siker As Boolean = False
        For Each line As String In responsesplit
            If line.Contains("RESULT:ERROR") Then
                response = responsesplit(counter + 2)
            End If
            If line.Contains("RESULT:SUCCESS") Then
                response = line.Replace("RESULT:SUCCESS:ESZ:", String.Empty).Replace(vbLf, String.Empty).Trim
                siker = True
                Exit For
            End If
            counter += 1
        Next
        Dim uzenet As String = String.Empty
        Dim naplosiker As String = String.Empty
        If siker = True Then
            uzenet = "A beküldés sikerült. Az érkeztetési szám: " & response
            naplosiker = "siker"
            If cbxUgytorzsbe.Checked = True Then RogzitsErkeztetestUgytorzsbe(response)
        Else
            uzenet = "A beküldés nem sikerült. Az ÁNYK elküldendő könyvtárból törlöm a KR fájlt (az eredetit nem törlöm). Hibaüzenet: & " & response
            naplosiker = "hiba"
            Try
                File.Delete(celfajl)
            Catch ex As Exception

            End Try
        End If
        MyLoader.AddLogBook(Fnc.bekuldes, uzenet, naplosiker)
        MsgBox(uzenet)
        Try
            File.Delete(anyklog)
            File.Delete(My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & paramfajl)
        Catch ex As Exception
        End Try

        If tbKRboritekNeve.Text = My.Settings.mappaANYKelkuldott & Path.DirectorySeparatorChar & celfajl Then Exit Sub
        'Ha az eredeti KR fájl is az elküldött könyvtárba került, a törlési rutint átlépi

        DialogResult = MsgBox("Törölhetem az ÁNYK elküldött könyvtárból a KR másolatát? Ha igen, kattintson az Igen gombra, ellenkező esetben a Nem gombra ", MsgBoxStyle.YesNo)
        If DialogResult = MsgBoxResult.Yes Then
            Try
                File.Delete(My.Settings.mappaANYKelkuldott & Path.DirectorySeparatorChar & Path.GetFileName(celfajl))
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.bekuldes, "A törlendő fájlt az ÁNYK elküldött mappában nem találtuk vagy az írási jogosultság hiányzik (" & celfajl & ")", LogTip.err)
            End Try
        End If


    End Sub

    Private Sub cbxEperHelper_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEperHelper.CheckedChanged
        LoadFilesToListView()
    End Sub

    Private Sub RogzitsErkeztetestUgytorzsbe(erkeztetesiszam As String)
        Dim drow() As DataRow = UgytorzsTabla.Select("Elso_beadvany_KR_neve='" & Path.GetFileName(tbKRboritekNeve.Text) & "'")
        If drow.First IsNot Nothing Then
            drow(0)("Elso_beadvany_erkeztetesi_szama") = erkeztetesiszam
        End If
        Ugytorzs_rogzitoTableAdapter.Update(UgytorzsTabla)
    End Sub
    Private Sub cbxZipTorles_CheckedChanged(sender As Object, e As EventArgs) Handles cbxZipTorles.CheckedChanged
        My.Settings.ZipFajlTorol = cbxZipTorles.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnKapuAdatMegadasa_Click(sender As Object, e As EventArgs) Handles btnKapuAdatMegadasa.Click
        Forms.KapuUserNamePasswForm.ShowDialog()
        Forms.KapuUserNamePasswForm.Dispose()
        If MyLoader.pnlHivatalikapu.Enabled Then
            btnHKPFeltoltes.Visible = True
            btnPKPANYKWSfeltoltes.Visible = True
        Else
            btnHKPFeltoltes.Visible = False
        End If
        If MyLoader.pnlPerkapu.Enabled Then
            btnPKPFeltoltes.Visible = True
            btnPKPANYKWSfeltoltes.Visible = True
        Else
            btnPKPFeltoltes.Visible = False
        End If
        If MyLoader.pnlUgyfelkapu.Enabled Then
            btnUKPFeltoltes.Visible = True
            btnUKPANYKWSfeltoltes.Visible = True
        Else
            btnUKPFeltoltes.Visible = False
            btnUKPANYKWSfeltoltes.Visible = False
        End If

    End Sub

    Private Sub btnCsatNyit_Click(sender As Object, e As EventArgs) Handles btnCsatNyit.Click
        If lvCsatolmanyok.SelectedItems.Count = 1 Then
            Dim filetoopen = lvCsatolmanyok.SelectedItems.Item(0).Text
            If File.Exists(filetoopen) Then
                Try
                    System.Diagnostics.Process.Start(filetoopen)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub tbZipFajlnev_Mod(sender As Object, e As EventArgs) Handles tbZipFajlnev.Click
        Dim zpath As String = String.Empty
        Try
            If tbZipFajlnev.Text <> String.Empty Then zpath = Path.GetDirectoryName(tbZipFajlnev.Text)
        Catch ex As Exception
            Try
                If tbKRboritekNeve.Text <> String.Empty Then zpath = Path.GetDirectoryName(tbKRboritekNeve.Text)
            Catch ex2 As Exception
                zpath = My.Settings.mappaLefuzes
            End Try
        End Try
        Dim result As String = String.Empty
        Try
            result = ChooseSavedFile(Path.GetDirectoryName(zpath), Path.GetFileNameWithoutExtension(tbKRboritekNeve.Text) & ".zip", "Válassza ki a cél zip fájl helyét", "*.zip|ZIP", "zip")
        Catch ex As Exception
            result = ChooseSavedFile("", Path.GetFileNameWithoutExtension(tbKRboritekNeve.Text) & ".zip", "Válassza ki a cél zip fájl helyét", "*.zip|ZIP", "zip")
        End Try
        If result <> String.Empty Then tbZipFajlnev.Text = result
    End Sub

    Private Sub tbZipFajlnev_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbZipFajlnev.Validating
        Try
            Directory.Exists(Path.GetDirectoryName(tbZipFajlnev.Text))
        Catch ex As Exception
            tbZipFajlnev.Text = String.Empty
        End Try
    End Sub

    Private Function KRCreate(CimzettNeve As String, CSTFileNeve As String, ASCFajlNeve As String, OutputKRFileNeve As String) As String
        Dim uzenet1 = "Boríték létrehozása (titkosítása) megkezdődött."
        MyLoader.AddLogBook(Fnc.xml, uzenet1, LogTip.norm)

        Dim kriptowrapperprocess As New Process
        SetKrProc(kriptowrapperprocess)
        kriptowrapperprocess.StartInfo.CreateNoWindow = True

        Dim doktleiras = tbNyomtatvanyNeve.Text


        Dim arguments As String = KriptoWrapper & " -cmd=build " & "-cimzett=" & Chr(34) & CimzettNeve & Chr(34) & " -dokta=" & Chr(34) & tbNyomtatvanyNeve.Text & Chr(34) &
            " -doktleir=" & Chr(34) & doktleiras & Chr(34) & " -doktv=" & Chr(34) & LoadDatafromKRandXKR.extractNYV(tbXMLPath.Text) & Chr(34) &
            " -cst=" & Chr(34) & CSTFileNeve & Chr(34) & " -xml=" & Chr(34) & tbXMLPath.Text & Chr(34) & " -kr=" & Chr(34) & OutputKRFileNeve & Chr(34) & " -asc=" & Chr(34) & ASCFajlNeve & Chr(34)
        If Me.cbSajatTitkosito.Checked = True And My.Settings.EncryptKeyPath <> String.Empty Then arguments += " -oasc=" & Chr(34) & My.Settings.EncryptKeyPath & Chr(34)

        kriptowrapperprocess.StartInfo.Arguments = arguments
        kriptowrapperprocess.Start()
        kriptowrapperprocess.WaitForExit()

        Dim OutputString = kriptowrapperprocess.StandardOutput.ReadToEnd()
        File.AppendAllText(MyLog & "KRoutput.txt", OutputString)

        Me.Cursor = Cursors.Default
        MyLoader.ProgressBar1.Style = ProgressBarStyle.Continuous
        kriptowrapperprocess.Close()
        Me.Show()
        If Not kriptowrapperprocess Is Nothing Then kriptowrapperprocess.Dispose()
        Return OutputString

    End Function

    Private Sub tbXMLPath_TextChanged(sender As Object, e As EventArgs) Handles tbXMLPath.TextChanged
        If tbXMLPath.ReadOnly Then Exit Sub
        If String.IsNullOrWhiteSpace(tbXMLPath.Text) Then Exit Sub
        Dim selectionpos = tbXMLPath.SelectionStart
        Dim tisztitottXMLNev As String = CleanPathandFileName(tbXMLPath.Text)
        If tbXMLPath.Text <> tisztitottXMLNev Then tbXMLPath.Text = tisztitottXMLNev
        If selectionpos > 0 Then tbXMLPath.SelectionStart = selectionpos

    End Sub

    Private Sub tbKRBoritekNeve_TextChanged(sender As Object, e As EventArgs) Handles tbKRboritekNeve.TextChanged
        Dim selectionpos = tbKRboritekNeve.SelectionStart
        tbKRboritekNeve.Text = CleanPathandFileName(tbKRboritekNeve.Text)
        tbKRboritekNeve.Text = SanitizeforKR(tbKRboritekNeve.Text)

        If selectionpos > 0 Then tbKRboritekNeve.SelectionStart = selectionpos
    End Sub

    Private Sub tbKRboritekNeve_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbKRboritekNeve.Validating
        Try
            If Path.GetExtension(tbKRboritekNeve.Text).ToLower <> ".kr" Then tbKRboritekNeve.Text += ".kr"
        Catch ex As Exception
        End Try
    End Sub


End Class