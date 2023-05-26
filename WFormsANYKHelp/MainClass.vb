Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Imports <xmlns:reg="https://www.microsec.hu/registration#">
Imports <xmlns:ds="http://www.w3.org/2000/09/xmldsig#">
Imports System.Net.NetworkInformation
Imports System.ComponentModel
Imports System.IO.Compression

Public Class Loader
    Dim DLoadProgress As Progress(Of Integer)

    Private Sub StatusLogBookExport_Click(sender As Object, e As EventArgs) Handles StatusLogBookExport.Click
        Dim ssPath = Path.GetDirectoryName(MyLog)
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        If Path.GetDirectoryName(MyLog) Is Nothing Or MyLog = String.Empty Then Exit Sub
        If Not File.Exists(MyLog) Then Exit Sub
        Dim screenshotfilename As String = ssPath & Path.DirectorySeparatorChar & Now.ToString("yyyyMMdd") & "_ssh.png"
        Try
            screenshot.Save(screenshotfilename, Imaging.ImageFormat.Png)
            MyLoader.AddLogBook(Fnc.cfg, "Teljes képernyő lementve a log könyvtárba a " & Path.GetFileName(screenshotfilename), LogTip.siker)
            screenshot.Dispose()
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.cfg, "Képernyőmentés sikertelen", LogTip.err)
        End Try
        'Nem működik, mert nincsenek lezárva a naplófájlok, meg nehézkes így beküldeni
        Dim zipname As String = String.Empty
        Try
            Dim dirtozip As String = Path.GetDirectoryName(MyLog)
            zipname = Directory.GetParent(MyLog).ToString & Path.DirectorySeparatorChar & "ZipLog" & Now.ToString("yyyyMMdd") & ".zip"
            Using fileStream = New FileStream(zipname, FileMode.CreateNew)
                Using archive = New ZipArchive(fileStream, ZipArchiveMode.Create, True)
                    For Each Logfile As String In My.Computer.FileSystem.GetFiles(ssPath, FileIO.SearchOption.SearchTopLevelOnly, "eperHelperLogBook*.txt*")
                        Dim zipArchiveEntry = archive.CreateEntryFromFile(Logfile, Path.GetFileName(Logfile), CompressionLevel.Fastest)
                    Next
                    Dim zipArchiveEntry2 = archive.CreateEntryFromFile(screenshotfilename, Path.GetFileName(screenshotfilename), CompressionLevel.Fastest)
                End Using
            End Using
            MyLoader.AddLogBook(Fnc.cfg, "A naplófájlokat és képernyőmentést elmentettem betömörítve a " & zipname & " nevű fájlba.", LogTip.siker)
        Catch ex As System.IO.IOException
            Dim uzenet = "Az elkészült zip fájlba nem tudtam betömöríteni egy vagy több fájlt"
            MyLoader.AddLogBook(Fnc.xml, uzenet, LogTip.err)
            MsgBox(uzenet, MsgBoxStyle.Critical)
        End Try
        If File.Exists(zipname) Then
            Try
                Clipboard.SetDataObject(zipname, False, 5, 200)
                MsgBox("Most megnyílik az alapértelmezett levelezőprogramja. Illessze be az elkészült zippelt naplófájlt. A naplófájl neve a vágólapra másolva (azaz csatolmány beillesztése parancs után elég a Ctrl+V-t megnyomni)")
            Catch
                MsgBox("Most megnyílik az alapértelmezett levelezőprogramja. Illessze be a levélbe a " & zipname & " fájlnevű csatolmányt, és küldje el.")
            End Try

            Dim proc As New System.Diagnostics.Process
            proc.StartInfo.FileName = "mailto:" & supportmailaddress & "?subject=eperHelper hibabejelentes&body=A következő a hibaüzenethez tartozó napló"
            proc.Start()
        End If
    End Sub


    Private Sub InternetImg_Click(sender As Object, e As EventArgs) Handles InternetImg.Click
        CheckInternetwLabelChange()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerCheckInet2minutes.Tick
        CheckInternetwLabelChange()
    End Sub

    Private Sub InternetImg_MouseDown(sender As Object, e As MouseEventArgs) Handles InternetImg.MouseDown
        InternetImg.ImageAlign = ContentAlignment.BottomRight
    End Sub

    Private Sub InternetImg_MouseUp(sender As Object, e As MouseEventArgs) Handles InternetImg.MouseUp
        InternetImg.ImageAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub StatusLogBookExport_MouseDown(sender As Object, e As MouseEventArgs) Handles StatusLogBookExport.MouseDown
        StatusLogBookExport.ImageAlign = ContentAlignment.BottomRight
    End Sub

    Private Sub StatusLogBookExport_MouseUp(sender As Object, e As MouseEventArgs) Handles StatusLogBookExport.MouseUp
        StatusLogBookExport.ImageAlign = ContentAlignment.MiddleCenter
    End Sub

    Sub AddLogBook(LFunction As String, LMess As String, LCat As String)
        Dim ItemToAdd As New ListViewItem(Now.ToLocalTime.ToString)
        ItemToAdd.SubItems.Add(LFunction)
        ItemToAdd.SubItems.Add(LCat)
        ItemToAdd.SubItems.Add(LMess)
        If ItemToAdd.SubItems(2).Text = LogTip.err Then ItemToAdd.ForeColor = Color.Red
        If ItemToAdd.SubItems(2).Text = LogTip.siker Then ItemToAdd.ForeColor = Color.ForestGreen
        Me.LogBook.Items.Add(ItemToAdd).EnsureVisible()
        Try
            Using sw As StreamWriter = File.AppendText(MyLog)
                sw.WriteLine(ItemToAdd.SubItems(0).Text & " ; " & ItemToAdd.SubItems(1).Text & "; " & Chr(34) & ItemToAdd.SubItems(3).Text & Chr(34) & " ; " & ItemToAdd.SubItems(2).Text)
            End Using
        Catch ex As Exception
        End Try


    End Sub



    Private Sub Loader_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SharedXSignSession = Nothing
        Application.ExitThread()
        Application.Exit()
    End Sub

    Private Sub Kilép_Click(sender As Object, e As EventArgs) Handles Kilép.Click
        SharedXSignSession = Nothing
        Application.ExitThread()
        Application.Exit()
    End Sub



    Private Sub Névjegy_Click(sender As Object, e As EventArgs) Handles Névjegy.Click
        Forms.Névjegy.ShowDialog()
        Forms.Névjegy.Close()
    End Sub


    Private Sub passwrecord_Click(sender As Object, e As EventArgs) Handles passwrecord.Click
        Forms.KapuUserNamePasswForm.ShowDialog()
        Forms.KapuUserNamePasswForm.Dispose()
    End Sub

    Private Sub passwexport_Click(sender As Object, e As EventArgs) Handles passwexport.Click
        Kapukezelo.ExportKapu()
    End Sub

    Private Sub passwprint_Click(sender As Object, e As EventArgs) Handles passwprint.Click
        If My.Settings.PasswPrinted = True Then Exit Sub
        PrintDialog1.Document = PrintDocument1
        Dim result As DialogResult = PrintDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Try
                PrintDocument1.Print()
                My.Settings.PasswPrinted = True
                MyLoader.AddLogBook(Fnc.nyomt, "Jelszavak kinyomtatva", LogTip.norm)
                MyLoader.passwprint.Enabled = False
            Catch ex As Exception
                MsgBox("Nyomtatási hiba miatt nem lett kinyomtatva.")
                MyLoader.AddLogBook(Fnc.nyomt, "Nyomtatási hiba", LogTip.err)
            End Try
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printfont As New System.Drawing.Font("Courier New", 11, FontStyle.Regular)
        Dim linesPerPage = e.MarginBounds.Height / printfont.GetHeight(e.Graphics)
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim OutputStr = Kapukezelo.ExportKapuDataToStr()
        e.Graphics.DrawString(OutputStr, printfont, Brushes.Black, leftMargin, topMargin, New StringFormat())

    End Sub


    Private Sub ukincoming_Click(sender As Object, e As EventArgs) Handles ukincoming.Click
        Dim kapus As New Kapukezelo
        kapus.LoginUKP_beerkezett()
        kapus = Nothing
    End Sub
    Private Sub pkpincoming_Click(sender As Object, e As EventArgs) Handles pkpincoming.Click
        Dim kapus As New Kapukezelo
        kapus.LoginPKP_beerkezett()
        kapus = Nothing
    End Sub

    Private Sub hkpincoming_Click(sender As Object, e As EventArgs) Handles hkpincoming.Click
        Dim kapus As New Kapukezelo
        kapus.LoginHKP_beerkezett()
        kapus = Nothing
    End Sub

    Private Sub ukupload_Click(sender As Object, e As EventArgs) Handles ukupload.Click
        Dim kapus As New Kapukezelo
        kapus.LoginUKP_feltoltes()
        kapus = Nothing
        'Esetleg rögtön dispose?
    End Sub

    Private Sub uknew_Click(sender As Object, e As EventArgs) Handles uknew.Click
        Dim kapus As New Kapukezelo
        kapus.NavigateToTarget_wWebBrowser("https://ugyfelkapu.magyarorszag.hu/regisztracio")
    End Sub


    Private Sub pkpupload_Click(sender As Object, e As EventArgs) Handles pkpupload.Click
        Dim kapus As New Kapukezelo
        kapus.LoginPKP_feltoltes()
        kapus = Nothing
    End Sub

    Private Sub pkpadmin_Click(sender As Object, e As EventArgs) Handles pkpadmin.Click
        Dim kapus As New Kapukezelo
        kapus.LoginPKP_admin()
        kapus = Nothing
    End Sub

    Private Sub hkpupload_Click(sender As Object, e As EventArgs) Handles hkpupload.Click
        Dim kapus As New Kapukezelo
        kapus.LoginHKP_feltoltes()
        kapus = Nothing
    End Sub

    Private Sub NoReg_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NoJava_Click(sender As Object, e As EventArgs) Handles cbNoJava.Click
        If cbNoJava.Checked Then My.Settings.ErtesitNincsJava = True Else My.Settings.ErtesitNincsJava = False
    End Sub

    Private Sub NoSecretKey_Click(sender As Object, e As EventArgs) Handles cbNoSecretKey.Click
        If cbNoSecretKey.Checked Then My.Settings.ErtesitNincsPkey = True Else My.Settings.ErtesitNincsPkey = False
    End Sub

    Private Sub savesettings_Click(sender As Object, e As EventArgs) Handles savesettings.Click
        Dim dialogresult As New DialogResult
        Dim ValasztottFajl = String.Empty
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "XML-fájl|*.xml"
        saveFileDialog1.Title = "Válassza ki, hogy hova és milyen néven menti a program beállításait!"
        saveFileDialog1.RestoreDirectory = True
        If Directory.Exists(My.Settings.AccessibleUserSettings) Then
            saveFileDialog1.InitialDirectory = My.Settings.AccessibleUserSettings
            saveFileDialog1.FileName = saveFileDialog1.InitialDirectory & Path.DirectorySeparatorChar & Environment.UserName & "EperkapuBeallitas.xml"
        End If
        saveFileDialog1.DefaultExt = "xml"
        dialogresult = saveFileDialog1.ShowDialog()
        If dialogresult = DialogResult.OK Then
            ValasztottFajl = saveFileDialog1.FileName
            If File.Exists(ValasztottFajl) Then
                Try
                    File.Delete(ValasztottFajl)
                Catch ex As Exception
                    MyLoader.AddLogBook(Fnc.cfg, "A megadott fájl már létezik és a program nem tudja felülírni: " & ValasztottFajl, LogTip.err)
                    Exit Sub
                End Try
            End If
            SettingsBackup.Export(ValasztottFajl)
            MyLoader.AddLogBook(Fnc.cfg, "Felhasználói beállítások sikeresen exportálva a " & ValasztottFajl & " nevű fájlba", LogTip.siker)
        End If
    End Sub

    Private Sub loadsettings_Click(sender As Object, e As EventArgs) Handles loadsettings.Click
        Dim dialogresult As New DialogResult
        Dim ValasztottFajl = String.Empty
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "XML-fájl|*.xml"
        openFileDialog1.Title = "Válassza ki, hogy honnan tölti be a program beállításait!"
        openFileDialog1.RestoreDirectory = True
        If Directory.Exists(My.Settings.AccessibleUserSettings) Then
            openFileDialog1.InitialDirectory = My.Settings.AccessibleUserSettings
            openFileDialog1.FileName = openFileDialog1.InitialDirectory & Path.DirectorySeparatorChar & Environment.UserName & "EperkapuBeallitas.xml"
        End If
        openFileDialog1.DefaultExt = "xml"
        dialogresult = openFileDialog1.ShowDialog()
        If dialogresult = DialogResult.OK Then
            ValasztottFajl = openFileDialog1.FileName
            SettingsBackup.Import(ValasztottFajl)
            MyLoader.AddLogBook(Fnc.cfg, "Felhasználói beállítások sikeresen importálva a " & ValasztottFajl & " nevű fájlból", LogTip.siker)
        End If
    End Sub


    Private Sub btnFoldersettings_Click(sender As Object, e As EventArgs) Handles btnFoldersettings.Click
        Dim fldr As New MappaBeállító
        fldr.ShowDialog()
        fldr.Dispose()
    End Sub

    Private Sub XKRXCZTársít_Click(sender As Object, e As EventArgs) Handles XKRXCZTársít.Click
        CheckandRegExt(".xkr", "XKR File", "anyk_xkr", """" & My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "abevjava_start_import.bat" & """ ""%1""", My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "abevjava.ico")
        CheckandRegExt(".xcz", "XCZ File", "anyk_xcz", """" & My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "abevjava_start_import.bat" & """ ""%1""", My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "abevjava.ico")
    End Sub

    Private Sub ÁNYKoszlopoknyitáshoz_Click(sender As Object, e As EventArgs) Handles ÁNYKoszlopoknyitáshoz.Click
        Dim TargetFile = My.Settings.mappaANYKadat & Path.DirectorySeparatorChar & ReadParamText(ParamTextFile, "prop.usr.settings") & Path.DirectorySeparatorChar & "settings.enyk"
        Dim hiba As String = "Nem tudta a program megnyitni a " & TargetFile & " fájlt, ÁNYK telepítés hiba vagy még telepítés óta nem indította el egyszer sem az ÁNYK-t"
        If TargetFile = String.Empty Then
            MyLoader.AddLogBook(Fnc.cfg, hiba, LogTip.err)
            MsgBox(hiba, MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim SettingsFile As String() = Nothing
        Try
            SettingsFile = System.IO.File.ReadAllLines(TargetFile)
        Catch ex As Exception
            hiba = "A szükséges konfigurációs fájlt a program nem találta, így nem tudta átírni (settings.enyk). ÁNYK telepítési hiba!"
            MyLoader.AddLogBook(Fnc.cfg, hiba, LogTip.err)
            Exit Sub
        End Try
        Dim OutputFile As New List(Of String)
        Dim epergateexists As Boolean
        Dim sb As New System.Text.StringBuilder
        For Each line As String In SettingsFile
            'átvizsgálja, hogy az oszlopokat beállító sorok NE kerüljenek át az új beállításfájlba
            If Not line.Contains("tablefilter_abev_open_panel_open.col_") Then OutputFile.Add(line)
            If line.Contains("gui.epergate=true") Then epergateexists = True
            'ellenőrzi, hogy a perkapu menüpont megjelenítése be van-e állítva
        Next
        If epergateexists = False Then OutputFile.Add("gui.epergate=true" & ControlChars.CrLf)
        For Each s As String In OutputFile
            sb.AppendLine(s)
        Next
        Try
            Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            System.IO.File.WriteAllText(TargetFile, sb.ToString & My.Resources.oszlopparamok, utf8WithoutBom)
            MyLoader.AddLogBook(Fnc.cfg, "Sikeresen módosítva az oszlopok felépítése a konfigurációs fájlban: " & TargetFile, LogTip.siker)
        Catch ex As System.IO.DirectoryNotFoundException
            hiba = "A szükséges konfigurációs fájlt a program nem találta, így nem tudta átírni (settings.enyk). ÁNYK telepítési hiba!"
            MyLoader.AddLogBook(Fnc.cfg, hiba, LogTip.err)
        End Try

    End Sub

    Private Sub btnRecheck_Click(sender As Object, e As EventArgs) Handles btnRecheckJava.Click
        If CheckJavaRegistry() = True Then
            MyLoader.lblPanelJava.Text = "Telepítés sikeres!"
            MyLoader.AddLogBook(Fnc.cfg, "32 bites, 1.8 verzió fölötti Java VM telepítve", LogTip.norm)
            PanelJava.Hide()
            RunANYKCheck()
        Else
            MyLoader.lblPanelJava.Text = "Java telepítése sikertelen! " & My.Resources.strJavaHianyzik
            ANYKDisabled()
        End If
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstallJava.Click
        Dim WebBrowserNew1 As New WebBrowser
        WebBrowserNew1.Navigate(JavaDLURL, True)
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnCloseJava.Click
        MyLoader.AddLogBook(Fnc.cfg, "Nincsen Java vagy ÁNYK telepítve, folytatás", LogTip.norm)
        PanelJava.Hide()
    End Sub

    Private Sub cbNoWarn_CheckedChanged(sender As Object, e As EventArgs) Handles cbNoWarnJava.CheckedChanged
        If cbNoWarnJava.Checked Then My.Settings.ErtesitNincsJava = False
        If Not cbNoWarnJava.Checked Then My.Settings.ErtesitNincsJava = True
        My.Settings.Save()
    End Sub

    Private Sub btnInstallANYK_Click(sender As Object, e As EventArgs) Handles btnInstallANYK.Click
        Dim WebBrowserNew1 As New WebBrowser
        WebBrowserNew1.Navigate(ANYKDLURL, True)
    End Sub

    Private Sub btnRecheckANYK_Click(sender As Object, e As EventArgs) Handles btnRecheckANYK.Click
        If ANYKfuttat() = True Then
            MyLoader.lblPanelANYK.Text = "ÁNYK telepítése sikeres!"
            MyLoader.AddLogBook(Fnc.cfg, "ÁNYK telepítve", LogTip.norm)
            ANYKEnabled()
            PanelANYK.Hide()
        Else
            MyLoader.lblPanelJava.Text = "ÁNYK telepítése sikertelen! " & My.Resources.strANYKHianyzik
            ANYKDisabled()
        End If
    End Sub
    Private Function ANYKfuttat() As Boolean
        Dim response As Boolean = CheckAnykInstalledNoCfg()
        Dim abevjavabat = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & abevjavaindito
        If response = False Or Not File.Exists(abevjavabat) Then
            Dim uzenet0 As String = "A program nem találja az ÁNYK indításához szükséges abevjava futtató start fájlt, telepítési hiba merülhetett föl, vagy még nem telepítette az ÁNYK-t."
            MyLoader.AddLogBook(Fnc.cfg, uzenet0, LogTip.err)
            MsgBox(uzenet0, MsgBoxStyle.Critical & MsgBoxStyle.OkOnly)
            Return False
        End If
        Dim abevprocess As New System.Diagnostics.Process
        MsgBox("Az újonnan telepített ÁNYK beállítások biztos befejezése miatt elindítja a program az ÁNYK-t. Indulás után bezárhatja az ÁNYK-t!", MsgBoxStyle.OkOnly)
        abevprocess.StartInfo.UseShellExecute = False
        abevprocess.StartInfo.WorkingDirectory = Path.GetDirectoryName(abevjavabat)
        abevprocess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        abevprocess.StartInfo.FileName = abevjavabat
        abevprocess.Start()
        abevprocess.WaitForExit(3000)
        abevprocess.Close()
        abevprocess.Dispose()
        Return True
    End Function
    Private Sub btnCloseANYK_Click(sender As Object, e As EventArgs) Handles btnCloseANYK.Click
        MyLoader.AddLogBook(Fnc.cfg, "Nincsen Java vagy ÁNYK telepítve, folytatás", LogTip.norm)
        PanelANYK.Hide()
    End Sub

    Private Sub cbNoWarnANYK_CheckedChanged(sender As Object, e As EventArgs) Handles cbNoWarnANYK.CheckedChanged
        If Me.cbNoWarnANYK.Checked Then My.Settings.JavaDisabled = False
        If Not Me.cbNoWarnANYK.Checked Then My.Settings.JavaDisabled = True
        My.Settings.Save()
    End Sub

    Private Sub btnCloseNyomtatvany_Click(sender As Object, e As EventArgs) Handles btnCloseNyomtatvany.Click
        PanelNyomtatvany.Hide()
    End Sub

    Private Sub btnTelepitesListaz_Click(sender As Object, e As EventArgs) Handles btnTelepit.Click, btnListazPanelbol.Click
        Dim sendername As Button = CType(sender, Button)
        Dim mittoltok As String = String.Empty
        Dim dialogpopup As Boolean = False
        Dim XMLResponse As String = LetoltesNyomtatvanyTabla("OBHGEPI")
        Dim datatoload As New DataTable
        Dim MitFrissitsen As New SablonTelepitettOption
        If MyLoader.gbAll.Checked Then
            MitFrissitsen = SablonTelepitettOption.MindenElerhetot
        End If
        If MyLoader.gbFresh.Checked Then
            MitFrissitsen = SablonTelepitettOption.CsakUjabbElerhetot
        End If
        If MyLoader.gbFresherthanInstalled.Checked Then
            MitFrissitsen = SablonTelepitettOption.CsakUjabbEsTelepitveElozmeny
        End If
        If MyLoader.gbeperHelpersupportedAll.Checked Then
            MitFrissitsen = SablonTelepitettOption.ProgrambanElerhetot
        End If
        If XMLResponse <> "" Then
            datatoload = NyomXMLandTelepitettCompare(XMLResponse, MitFrissitsen)
            Dim elerhetolista As New List(Of String)
            elerhetolista = ElerhetoEllenorzese(datatoload)
            If elerhetolista.Count > 0 Then
                If sendername.Name = "btnTelepit" Then DownloadNyomtatvanyfromTable(datatoload)
                If sendername.Name = "btnListazPanelbol" Then
                    Dim listastring As String = String.Join(Environment.NewLine, elerhetolista)
                    Dim hibalistastring As String = String.Empty
                    If Not hibastetel Is Nothing Then hibalistastring = String.Join(Environment.NewLine, hibastetel)
                    If listastring <> "" Then
                        ListToDisplay = listastring '& Environment.NewLine & "Ebből szerver hiba miatt nem tölthető le: " _
                        '& hibalistastring
                        HibaListToDisplay = hibalistastring
                        Forms.NyomiLista.ShowDialog()
                        NyomiLista.Dispose()
                    End If
                End If
            End If
        Else
            Dim weboldal As String = "http://birosag.hu/ekapcsolattartas/elektronikus-kapcsolattartas-az-egyes-ugyfajtakban"
            Dim hibauzenet = "A frissítési forrás nem hozzáférhető. Próbálja meg a " & weboldal & " oldalon ellenőrizni, hogy van-e új nyomtatvány"
            MyLoader.AddLogBook(Fnc.cfg, hibauzenet, LogTip.err)
            Dim dialogresult As New DialogResult
            dialogresult = MsgBox(hibauzenet & Environment.NewLine & "Megnyissam az oldalt?", MsgBoxStyle.YesNo)
            If dialogresult = DialogResult.Yes Then
                Process.Start(weboldal)
            End If
        End If
        'TelepitettNyomtatvanyok = PopulateTelepitettNyomtatvanyok()
    End Sub

    Friend Async Sub DLoadMain(DataTabletoDL As DataTable)

        Dim TotalCnt = DataTabletoDL.Rows.Count
        MyLoader.ProgressBar1.Maximum = TotalCnt
        MyLoader.ProgressBar1.Step = 1
        MyLoader.ProgressBar1.Value = 0
        If TotalCnt <= 0 Then TotalCnt = 1
        Dim progressTarget As Action(Of Integer)
        Dim response As String = String.Empty
        progressTarget = AddressOf ReportProgress
        DLoadProgress = New Progress(Of Integer)(progressTarget)
        MyLoader.PanelNyomtatvany.Hide()
        For Each row As Data.DataRow In DataTabletoDL.Rows
            If row("sourcejar") <> String.Empty Then Await DLoadAsync(row("sourcejar"), TotalCnt, DLoadProgress, row("name").ToString, row("ver").ToString)
        Next
        If counterfailed > 0 Then MyLoader.AddLogBook(Fnc.nyomdl, "Nyomtatványok letöltésekor " & counterfailed & ". db hiba az OBH által közzétett frissítési listához képest. A hibák okáról lásd az 'Új sablonok listája' menüpontot!", LogTip.err)
        If TotalCnt - counterfailed > 0 Then MyLoader.AddLogBook(Fnc.nyomdl, "Sikeresen letöltve " & TotalCnt - counterfailed & " db. nyomtatvány", LogTip.siker)
        MyLoader.ProgressBar1.Value = 0
        TelepitettNyomtatvanyok = PopulateTelepitettNyomtatvanyok()
    End Sub

    Private Async Function DLoadAsync(AddressToDownload As String, TotalCnt As Integer, ByVal myProgress As IProgress(Of Integer), nyominame As String, nyomiver As String) As Task(Of String)

        Dim webClient As New WebDownload
        Dim TextToDisplay As String = nyominame & "_" & nyomiver
        Dim siker As Boolean = False

        webClient.Timeout = 5000
        webClient.TempName = Path.GetTempFileName
        Try
            Dim foundfiles As New List(Of String)
            Await webClient.DownloadFileTaskAsync(New Uri(AddressToDownload), webClient.TempName)
            foundfiles = GetFromJarAll(webClient.TempName, "*.tem.enyk", nyomtatvanyok, True)
            For Each filefound In foundfiles
                'keresett nyomtatvány neve és verziója
                'letöltött nyomtatvány neve és verziója
                Dim mroot As XDocument = XDocument.Load(filefound)
                Dim mchildList As IEnumerable(Of XElement) = From el In mroot...<DOCINFO> Select el
                For Each e As XElement In mchildList
                    If e.@name = nyominame And e.@ver = nyomiver Then
                        siker = True
                    End If
                Next
            Next
            If siker = False Then AddressToDownload = "Bár a frissítési listán még le nem töltött sablon szerepel, de a közzétett JAR állomány nem tartalmazza a megadott sablont: " & TextToDisplay & " (" & AddressToDownload & ")"
        Catch ex As Exception
            If Not myProgress Is Nothing Then myProgress.Report(countersuccess + counterfailed)
            If ex.Message.ToString.Contains("404") Then AddressToDownload = "Nem található nyomtatvány: " & TextToDisplay & " (" & AddressToDownload & ")"
            siker = False
        End Try
        If siker = True Then
            countersuccess += 1
            File.Delete(webClient.TempName)
            If Not myProgress Is Nothing Then myProgress.Report(countersuccess + counterfailed)
            Return "siker"
        Else
            counterfailed += 1
            If hibastetel Is Nothing Then
                hibastetel = New List(Of String)
                hibastetel.Add(AddressToDownload)
            Else
                hibastetel.Add(AddressToDownload)
            End If
            If Not myProgress Is Nothing Then myProgress.Report(countersuccess + counterfailed)
            Return "sikertelen"
        End If

    End Function

    Private Sub ReportProgress(counter As Integer)
        MyLoader.ProgressBar1.PerformStep()
    End Sub

    Private Sub MainClass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim response As DialogResult
            response = MsgBox("Biztosan ki akar lépni a programból?", MsgBoxStyle.YesNo)
            If response = DialogResult.Yes Then
                Me.Hide()
                SharedXSignSession = Nothing
                SharedXSignSession = Nothing
                Application.ExitThread()
                Application.Exit()
            End If
        End If
    End Sub
    Friend Function CheckUKP() As Boolean
        If My.Settings.UKPUName <> String.Empty And My.Settings.UKPPassw <> String.Empty And NoInternet = False Then
            MyLoader.pnlUgyfelkapu.Enabled = True
            Return True
        Else
            MyLoader.pnlUgyfelkapu.Enabled = False
            Return False
        End If
    End Function
    Friend Function CheckHKP() As Boolean
        If My.Settings.HKPUName <> String.Empty And My.Settings.HKPPassw <> String.Empty And My.Settings.UKPUName <> String.Empty And My.Settings.UKPPassw <> String.Empty And NoInternet = False Then
            MyLoader.pnlHivatalikapu.Enabled = True
            Return True
        Else
            MyLoader.pnlHivatalikapu.Enabled = False
            Return False
        End If

    End Function
    Friend Function CheckPKP() As Boolean
        If My.Settings.PKPUName <> String.Empty And My.Settings.PKPPassw <> String.Empty And My.Settings.UKPUName <> String.Empty And My.Settings.UKPPassw <> String.Empty And NoInternet = False Then
            MyLoader.pnlPerkapu.Enabled = True
            Return True
        Else
            MyLoader.pnlPerkapu.Enabled = False
            Return False
        End If

    End Function

    Private Sub Titkosítókulcspár_Click(sender As Object, e As EventArgs) Handles Titkosítókulcspár.Click
        TitkositoKulcsBeallitasa.ShowDialog()
        TitkositoKulcsBeallitasa.Close()
    End Sub

    Private Sub ReadSigTSExternal_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub SetDefCert_Click(sender As Object, e As EventArgs) Handles SetDefCert.Click
        Forms.DefSigCert.ShowDialog()
        Forms.DefSigCert.Dispose()
    End Sub

    Private Sub passwdeleteall_Click(sender As Object, e As EventArgs) Handles passwdeleteall.Click
        Dim dialogresult As New DialogResult
        dialogresult = MsgBox("Biztos benne, hogy az összes jelszót és felhasználónevet törölni kívánja a programból (kapu, titkosító kulcs és időbélyeg hozzáférés)? (Ezeket újból be kell állítania)", MsgBoxStyle.YesNo)
        If dialogresult = DialogResult.No Then Exit Sub Else PasswordDeleteAllShared()
    End Sub
    Private Function LoadRegistryValue(alaput As String, value As String) As String
        Dim tempBA As Byte() = Nothing
        LoadRegistryValue = String.Empty
        Try
            tempBA = My.Computer.Registry.GetValue(alaput, value, Nothing)
            If tempBA IsNot Nothing Then
                Array.Reverse(tempBA, 0, tempBA.Length)
                LoadRegistryValue = BitConverter.ToString(tempBA).ToLower.Replace("-", "")
            End If

        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.eal, "Regisztrációs kulcs beolvasási hiba (LoadRegistryValue", LogTip.err)
            Return Nothing
        End Try
        Return LoadRegistryValue

    End Function
    Private Sub btnAlairoPrgAtvetel_Click(sender As Object, e As EventArgs) Handles btnAlairoPrgAtvetel.Click
        'Van-e eszigon telepítve?
        Dim TS = My.Settings.TSURL.Trim.Replace(vbLf, String.Empty).Replace(vbCr, String.Empty).Replace(vbCrLf, String.Empty)
        If TS <> String.Empty Then
            Dim valasz As New MsgBoxResult
            valasz = MsgBox("Úgy tűnik, hogy Önnek be van már állítva időbélyeg. Hozzáadjam az importált értéket a meglévő értékekhez?", MsgBoxStyle.YesNo)
            If valasz = MsgBoxResult.No Then Exit Sub
        End If

        Dim alaput As String = "SOFTWARE\Microsec\e-Szigno\3.0\"
        Dim elotet As String = "HKEY_CURRENT_USER\"
        Dim regkey
        Try
            regkey = My.Computer.Registry.CurrentUser.OpenSubKey(alaput)
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.eal, "Regisztrációs kulcs beolvasási hiba (alaput)", LogTip.err)
            Exit Sub
        End Try
        Dim naploEszig As Long = 0
        CheckNetlock()
        If regkey Is Nothing Then
            Dim uzenet As String = "Nem találtam telepítve az e-Szignó alkalmazást"
            MyLoader.AddLogBook(Fnc.eal, uzenet, LogTip.norm)
            Exit Sub
        End If
        alaput = elotet & alaput

        'Dim Eszig_OCSPCertDefault = LoadRegistryValue(alaput, "DefaultOCSPCertSerial")
        Dim Eszig_SignCertDefault = LoadRegistryValue(alaput, "DefaultSigningCertSerial")
        Dim Eszig_TSACertDefault = LoadRegistryValue(alaput, "DefaultTimeStampCertSerial")

        Dim Eszig_TSAURL
        Try
            Eszig_TSAURL = My.Computer.Registry.GetValue(alaput, "TimestampURL", Nothing)
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.eal, "Regisztrációs kulcs beolvasási hiba (tstampURL)", LogTip.err)
            Exit Sub
        End Try
        If Eszig_TSAURL IsNot Nothing Then
            If Eszig_TSAURL.ToString.Trim.Replace(vbCrLf, "") <> String.Empty Then
                My.Settings.TSURL = Eszig_TSAURL + " " & My.Settings.TSURL
                Dim response = SharedXSignSession.SetTimeStampURLs(My.Settings.TSURL)
                If response = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyeg URL beállítva e-Szignóból", LogTip.norm) Else MyLoader.AddLogBook(Fnc.eal, "Időbélyeg URL kiolvasva e-Szignóból, de a program XSign4COMban nem tudja beállítani", LogTip.err)
            End If
        Else
            MyLoader.AddLogBook(Fnc.eal, "A beállítani kívánt e-Szignó időbélyeg URL üres", LogTip.norm)
        End If

        '  If Eszig_OCSPCertDefault <> String.Empty Then
        ' Dim tempcertthmb As String = VanIlyenCertbySerial(Eszig_OCSPCertDefault)
        'If tempcertthmb <> String.Empty Then
        'OCSPCert.Thumbprint = tempcertthmb
        'OCSPCert.CommonName = VanIlyenCertbyThumb(tempcertthmb)
        'My.Settings.OCSPCertDefault = tempcertthmb
        'naploEszig = SharedXSignSession.SetDefaultOCSPAuthCert(0, tempcertthmb)
        'If naploEszig = 0 Then MyLoader.AddLogBook(Fnc.eal, "OCSP tanúsítvány sikeresen beállítva", LogTip.norm) Else MyLoader.AddLogBook(Fnc.eal, "OCSP tanúsítvány megvan, de XSign4COM.dll beállítási hiba", LogTip.err)
        'End If
        'End If
        If Eszig_SignCertDefault <> String.Empty Then
            Dim tempcertthmb As String = VanIlyenCertbySerial(Eszig_SignCertDefault)
            If tempcertthmb <> String.Empty Then
                AlairoCert.Thumbprint = tempcertthmb
                AlairoCert.CommonName = VanIlyenCertbyThumb(tempcertthmb)
                My.Settings.SignCertDefault = tempcertthmb
                naploEszig = SharedXSignSession.SetDefaultSigningCert(0, tempcertthmb)
                If naploEszig = 0 Then MyLoader.AddLogBook(Fnc.eal, "Aláíró tanúsítvány sikeresen beállítva", LogTip.norm) Else MyLoader.AddLogBook(Fnc.eal, "Aláíró tanúsítvány megvan, de XSign4COM.dll beállítási hiba", LogTip.err)
            End If
        End If

        If Eszig_TSACertDefault <> String.Empty Then
            Dim tempcertthmb As String = VanIlyenCertbySerial(Eszig_TSACertDefault)
            If tempcertthmb <> String.Empty Then
                TSCert.Thumbprint = tempcertthmb
                TSCert.CommonName = VanIlyenCertbyThumb(tempcertthmb)
                My.Settings.TSACertDefault = tempcertthmb
                naploEszig = SharedXSignSession.SetDefaultTSAuthCert(0, tempcertthmb)
                If naploEszig = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyeg kiválasztó tanúsítvány sikeresen beállítva", LogTip.norm) Else MyLoader.AddLogBook(Fnc.eal, "Időbélyeg kiválasztó tanúsítvány megvan, de XSign4COM.dll beállítási hiba", LogTip.err)
            End If
        End If
        My.Settings.Save()
        CheckTSURLMicrosec()


    End Sub

    Private Sub CheckNetlock()
        Dim netlockURL As String = NetlockTSURL()
        If netlockURL <> String.Empty Then
            My.Settings.TSURL = netlockURL + " " + My.Settings.TSURL
            My.Settings.Save()
            Dim response = SharedXSignSession.SetTimeStampURLs(My.Settings.TSURL)
            If response = 0 Then
                MyLoader.AddLogBook(Fnc.eal, "Időbélyeg URL beállítva Netlock MOKKÁból", LogTip.norm)
            Else
                MyLoader.AddLogBook(Fnc.eal, "Időbélyeg URL kiolvasva a Netlock MOKKÁból, de a program XSign4COMban nem tudja beállítani", LogTip.err)
            End If
        End If
    End Sub
    Private Function NetlockTSURL() As String
        Dim netlockut As String = "SOFTWARE\Classes\MOKKAdosszie\Shell\Open\Command"
        Dim elerhetosegeXMLnek As String = String.Empty
        Dim response As String = String.Empty
        Dim regkeyNL As Microsoft.Win32.RegistryKey = Nothing
        Dim NetlockPath As String = String.Empty
        Dim regkeyMsg As String = String.Empty

        Try
            regkeyNL = My.Computer.Registry.LocalMachine.OpenSubKey(netlockut)
            NetlockPath = regkeyNL.GetValue(Nothing).ToString.Replace(Chr(34), String.Empty)
            elerhetosegeXMLnek = Path.GetDirectoryName(NetlockPath)
            If elerhetosegeXMLnek <> String.Empty Then elerhetosegeXMLnek = elerhetosegeXMLnek & Path.DirectorySeparatorChar & "mokka.admin.xml"
            regkeyMsg = "*Netlock TSURL debug adatok - regkey: " & NetlockPath & " ; " & elerhetosegeXMLnek
            MyLoader.AddLogBook(Fnc.eal, regkeyMsg, LogTip.norm)
        Catch ex As Exception
            regkeyMsg = "Nem találtam telepítve Netlock alkalmazást (regkey: " & netlockut & " ; " & NetlockPath & ")"
            MyLoader.AddLogBook(Fnc.eal, regkeyMsg, LogTip.norm)
        End Try

        If File.Exists(elerhetosegeXMLnek) Then
            Try
                '    Dim xdoc = XDocument.Load(elerhetosegeXMLnek)
                'For Each e As XElement In xdoc.Elements
                'If e.Name = "edIdobelyegURL_Text" Then
                'response = e.Value.ToString
                'End If
                '       Next
                Dim xdoc As String() = File.ReadAllLines(elerhetosegeXMLnek, System.Text.Encoding.UTF8)

                For Each line As String In xdoc
                    If line.Contains("<edIdobelyegURL_Text>") Then
                        response = line.Replace("<edIdobelyegURL_Text>", String.empty).Replace("</edIdobelyegURL_Text>", String.empty)
                        response = response.Replace(Environment.NewLine, String.Empty)
                        response = response.Trim
                        Exit For
                    End If
                Next
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.eal, ex.Message, LogTip.err)
            End Try
        End If

        Return response
    End Function

    Private Sub AllStartRefresh_CheckBoxCheckChanged(sender As Object, e As EventArgs) Handles AllStartRefresh.CheckBoxCheckChanged, FreshStartRefresh.CheckBoxCheckChanged, FresherthanInstalledStartRefresh.CheckBoxCheckChanged, rbcbProgramSupportedRefresh.CheckBoxCheckChanged
        If AllStartRefresh.Checked Then
            My.Settings.ErtesitVanNyomtatvany = 0
            FreshStartRefresh.Checked = False
            FresherthanInstalledStartRefresh.Checked = False
            rbcbProgramSupportedRefresh.Checked = False
        End If
        If FreshStartRefresh.Checked Then
            My.Settings.ErtesitVanNyomtatvany = 1
            AllStartRefresh.Checked = False
            FresherthanInstalledStartRefresh.Checked = False
            rbcbProgramSupportedRefresh.Checked = False
        End If
        If FresherthanInstalledStartRefresh.Checked Then
            My.Settings.ErtesitVanNyomtatvany = 2
            FreshStartRefresh.Checked = False
            AllStartRefresh.Checked = False
            rbcbProgramSupportedRefresh.Checked = False
        End If
        If rbcbProgramSupportedRefresh.Checked Then
            My.Settings.ErtesitVanNyomtatvany = 3
            FreshStartRefresh.Checked = False
            FresherthanInstalledStartRefresh.Checked = False
            AllStartRefresh.Checked = False
        End If
        If Not AllStartRefresh.Checked And Not FreshStartRefresh.Checked And Not FresherthanInstalledStartRefresh.Checked And Not rbcbProgramSupportedRefresh.Checked Then My.Settings.ErtesitVanNyomtatvany = 4
        My.Settings.Save()
    End Sub
    Private Sub DownLoad_Click(sender As Object, e As EventArgs) Handles All.Click, Fresh.Click, FresherthanInstalled.Click, rbtnEperHelper.Click
        Dim sendername As RibbonButton = CType(sender, RibbonButton)
        Dim mittoltok As String = String.Empty
        Dim datatoload As New DataTable
        Dim MitFrissitsen As New SablonTelepitettOption
        'PopulateTelepitettNyomtatvanyok()
        Select Case sendername.Text
            Case "Minden elérhető verzió (régi is)"
                mittoltok = "minden elérhető nyomtatványverzió, régiek is"
                MitFrissitsen = SablonTelepitettOption.MindenElerhetot
            Case "Összes legfrissebb verzió"
                mittoltok = "az elérhető frissebb nyomtatványverziók, nem telepített is"
                MitFrissitsen = SablonTelepitettOption.CsakUjabbElerhetot
            Case "Már telepítettből elérhető új verzió"
                mittoltok = "a telepítettből elérhető újabb nyomtatványverziók"
                MitFrissitsen = SablonTelepitettOption.CsakUjabbEsTelepitveElozmeny
            Case "Minden, amit az eperHelperben kitölthet"
                mittoltok = "az eperHelper által támogatott nyomtatványsablonok, minden verzió"
                MitFrissitsen = SablonTelepitettOption.ProgrambanElerhetot
        End Select
        Dim XMLResponse As String = LetoltesNyomtatvanyTabla("OBHGEPI")

        If XMLResponse = "" Then MyLoader.AddLogBook(Fnc.cfg, "A frissítési forrás nem hozzáférhető", LogTip.norm)
        If XMLResponse <> "" Then
            datatoload = NyomXMLandTelepitettCompare(XMLResponse, MitFrissitsen)
            If datatoload.Rows.Count > 0 Then DownloadNyomtatvanyfromTable(datatoload)
            If datatoload.Rows.Count <= 0 Then MyLoader.AddLogBook(Fnc.cfg, "Az OBHGEPI nyomtatványból az elérhető verziók telepítve vannak (" & mittoltok & ")", LogTip.norm)
        End If
        'TelepitettNyomtatvanyok = PopulateTelepitettNyomtatvanyok()
    End Sub

    Private Sub anykmappavissza_Click(sender As Object, e As EventArgs) Handles anykmappavissza.Click
        ANYKMappaVisszaSub()
    End Sub

    Private Sub extractkr_Click(sender As Object, e As EventArgs) Handles extractkr.Click
        Forms.KRExtractForm.ShowDialog()
        Forms.KRExtractForm.Close()
    End Sub

    Private Sub btnPDFnyomtatvanybol_Click(sender As Object, e As EventArgs) Handles btnPDFnyomtatvanybol.Click
        Forms.PDFprint.ShowDialog()
        Forms.PDFprint.Close()

    End Sub



    Private Sub openenyk_Click(sender As Object, e As EventArgs) Handles openenyk.Click
        Forms.ENYKnyito.ShowDialog()
        Forms.ENYKnyito.Close()
    End Sub

    Private Sub openxmlxkr_Click(sender As Object, e As EventArgs) Handles openxmlxkr.Click
        Forms.XMLXKRnyito.ShowDialog()
        Forms.XMLXKRnyito.Close()
    End Sub

    Private Sub btnListázniRibbonból_Click(sender As Object, e As EventArgs) Handles btnListázniRibbonbol.Click
        'MyLoader.ProgressBar1.Value = 0
        Dim dialogpopup As Boolean = False
        Dim XMLResponse As String = LetoltesNyomtatvanyTabla("OBHGEPI")
        Dim datatoload As New DataTable
        Dim MitFrissitsen As SablonTelepitettOption
        Select Case My.Settings.ErtesitVanNyomtatvany
            Case 0
                MitFrissitsen = SablonTelepitettOption.MindenElerhetot
            Case 1
                MitFrissitsen = SablonTelepitettOption.CsakUjabbElerhetot
            Case 2
                MitFrissitsen = SablonTelepitettOption.CsakUjabbEsTelepitveElozmeny
            Case 3
                MitFrissitsen = SablonTelepitettOption.ProgrambanElerhetot
            Case Else
                MitFrissitsen = SablonTelepitettOption.Semmit
        End Select

        MyLoader.AddLogBook(Fnc.cfg, "Összevetem a telepített és az 'indításkori frissítés' opcióban megadott minta szerint elérhető nyomtatványok listáját (" & MitFrissitsen & ").", LogTip.norm)
        If XMLResponse <> "" Then
            datatoload = NyomXMLandTelepitettCompare(XMLResponse, MitFrissitsen)
            Dim elerhetolista As New List(Of String)
            elerhetolista = ElerhetoEllenorzese(datatoload)
            If elerhetolista.Count > 0 Then
                Dim listastring As String = String.Join(Environment.NewLine, elerhetolista)
                Dim hibalistastring As String = String.Empty
                If Not hibastetel Is Nothing Then hibalistastring = String.Join(Environment.NewLine, hibastetel)
                If listastring <> "" Then
                    ListToDisplay = listastring
                    HibaListToDisplay = hibalistastring
                    Forms.NyomiLista.ShowDialog()
                    NyomiLista.Dispose()
                End If
            ElseIf elerhetolista.Count = 0 Then
                MyLoader.AddLogBook(Fnc.cfg, "Az összevetés eredménye: " & [Enum].Parse(GetType(SablonTelepitettOption), MitFrissitsen, True).ToString & " szerint NINCSEN új, nem telepített nyomtatvány.", LogTip.norm)
            End If
        Else
            Dim weboldal As String = "http://birosag.hu/ekapcsolattartas/elektronikus-kapcsolattartas-az-egyes-ugyfajtakban"
            Dim hibauzenet = "A frissítési forrás nem hozzáférhető. Próbálja meg a " & weboldal & " oldalon ellenőrizni, hogy van-e új nyomtatvány"
            MyLoader.AddLogBook(Fnc.cfg, hibauzenet, LogTip.err)
            Dim dialogresult As New DialogResult
            dialogresult = MsgBox(hibauzenet & Environment.NewLine & "Megnyissam az oldalt?", MsgBoxStyle.YesNo)
            If dialogresult = DialogResult.Yes Then
                Process.Start(weboldal)
            End If
        End If

    End Sub

    Private Sub extractCST_Click(sender As Object, e As EventArgs) Handles extractCST.Click
        Forms.CSTExtractForm.ShowDialog()
        Forms.CSTExtractForm.Close()
    End Sub

    Private Sub Ceg_Click(sender As Object, e As EventArgs) Handles Ceg.Click
        Forms.TDB_Ceg.ShowDialog()
        Forms.TDB_Ceg.Close()
    End Sub

    Private Sub TSZ_Click(sender As Object, e As EventArgs) Handles TSZ.Click
        Forms.TDB_TESZ.ShowDialog()
        Forms.TDB_TESZ.Close()

    End Sub

    Private Sub JK_UI_Click(sender As Object, e As EventArgs) Handles JK_UI.Click
        Forms.TDB_UI.ShowDialog()
        Forms.TDB_UI.Close()

    End Sub

    Private Sub ESZ_Click(sender As Object, e As EventArgs) Handles ESZ.Click
        Forms.TDB_ESZ.ShowDialog()
        Forms.TDB_ESZ.Close()
    End Sub

    Private Sub EV_Click(sender As Object, e As EventArgs) Handles EV.Click
        Forms.TDB_EV.ShowDialog()
        Forms.TDB_EV.Close()
    End Sub

    Private Sub JK_EU_Click(sender As Object, e As EventArgs) Handles JK_EU.Click
        Forms.TDB_EU.ShowDialog()
        Forms.TDB_EU.Close()

    End Sub

    Private Sub JK_JT_Click(sender As Object, e As EventArgs) Handles JK_JT.Click
        Forms.TDB_JT.ShowDialog()
        Forms.TDB_JT.Close()

    End Sub

    Private Sub JK_EJK_Click(sender As Object, e As EventArgs) Handles JK_EJK.Click
        Forms.TDB_EJKV.ShowDialog()
        Forms.TDB_EJKV.Close()
    End Sub

    Private Sub Ujnyomtatvanytorzsadattal_Click(sender As Object, e As EventArgs) Handles Ujnyomtatvanytorzsadattal.Click
        Forms.Kitolt.ShowDialog()
        Forms.Kitolt.Close()
    End Sub

    Private Sub CsomagKeszito(sender As Object, e As EventArgs) Handles csomagenykbol.Click, csomagxmlbol.Click
        Dim senderclick As RibbonButton = CType(sender, RibbonButton)
        Dim CsomagKuldo As New CsomagKeszito(senderclick.Text)
        CsomagKuldo.ShowDialog()
        CsomagKuldo.Close()
    End Sub

    Private Sub Archívidőbélyeg_CheckBoxCheckChanged(sender As Object, e As EventArgs) Handles Archívidőbélyeg.CheckBoxCheckChanged
        If Me.Archívidőbélyeg.Checked = True Then My.Settings.ArchivTS = True Else My.Settings.ArchivTS = False
        My.Settings.Save()
        CheckSetSigLevel()
    End Sub

    Private Sub importonce_Click(sender As Object, e As EventArgs) Handles importonce.Click
        Forms.CsvImport.ShowDialog()
        Forms.CsvImport.Close()

    End Sub

    Private Sub MintaMDB_Click(sender As Object, e As EventArgs) Handles MintaMDB.Click
        Dim Hova As String = MappaBeállító.ValasszKonyvtarat
        Dim outputfajl As String = Hova & Path.DirectorySeparatorChar & "TorzsAdatbazis_ures.mdb"
        Dim uzenet As String = String.Empty
        Dim sikeresseg As String = String.Empty
        Try
            If Hova <> "" Then WriteResourceToFile(outputfajl, My.Resources.ures_csv)
            uzenet = "Az üres adatbázis kimásolva TorzsAdatbazis_ures.mdb néven a " & Hova & " könyvtárba. Ha kitöltötte pl. Access-ben, helyezze az " & My.Settings.AccessibleUserSettings & "\ könyvtárba TorzsAdatbazis.mdb néven, felülírva a jelenlegit."
            sikeresseg = LogTip.norm
        Catch ex As Exception
            uzenet = "Nem sikerült a minta MDB adatbázis fájl bemásolása (nincsen írási joga a megadott útvonalon?)"
            sikeresseg = LogTip.err
        End Try
        MsgBox(uzenet)
        MyLoader.AddLogBook(Fnc.db, uzenet, sikeresseg)

    End Sub

    Private Sub deleteSettings_Click(sender As Object, e As EventArgs) Handles deleteSettings.Click
        My.Settings.OCSPCertDefault = ""
        My.Settings.TSACertDefault = ""
        My.Settings.SignCertDefault = ""
        Forms.DefSigCert.tbSigCert.Text = String.Empty
        Forms.DefSigCert.tbTSCert.Text = String.Empty
        My.Settings.Save()
    End Sub

    Private Sub btn_AVDH_kapuNoticeKi(sender As Object, e As EventArgs) Handles btnAVDHesKapuNoticeKi.Click
        Dim dialogresult As New DialogResult
        dialogresult = MsgBox("Biztosan ki akarja kapcsolni az összes letöltött nyomtatványa esetén a perkapus és AVDH-s benyújtással kapcsolatos figyelmeztetést?", MsgBoxStyle.YesNo)
        If dialogresult = DialogResult.No Or dialogresult = Nothing Then Exit Sub
        Dim fullstring As String = ","
        For Each item As DataRow In PopulateTelepitettNyomtatvanyok.Rows
            fullstring += item("name") & ","
        Next
        Dim TargetFile = My.Settings.mappaANYKadat & Path.DirectorySeparatorChar & ReadParamText(ParamTextFile, "prop.usr.settings") & Path.DirectorySeparatorChar

        Try
            File.WriteAllText(TargetFile & "avdh.info", fullstring)
            File.WriteAllText(TargetFile & "epos.info", fullstring)
            MyLoader.AddLogBook(Fnc.cfg, "Az összes letöltött nyomtatvány esetén kikapcsolva a perkapus és AVDH-s benyújtás lehetőségével kapcsolatos figyelmeztetés", LogTip.norm)
        Catch ex As System.IO.DirectoryNotFoundException
            MyLoader.AddLogBook(Fnc.cfg, "A szükséges fájlokat tartalmazó mappát a program nem találta, így nem tudta átírni (avdh.info, epos.info). ÁNYK telepítési hiba!", LogTip.err)
        End Try
    End Sub

    Private Sub csatolmannyalbemasol_Click(sender As Object, e As EventArgs) Handles csatolmannyalbemasol.Click
        '!Még nem implementált
    End Sub

    Private Sub Regisztráció_Click(sender As Object, e As EventArgs) Handles Regisztráció.Click
        Forms.RegisztraciosAblak.ShowDialog()
        Forms.RegisztraciosAblak.Close()
    End Sub

    Private Sub Súgó_Click(sender As Object, e As EventArgs) Handles Súgó.Click
        Dim sugo As String = Path.Combine(Directory.GetCurrentDirectory(), "eperHelper_felhasznaloi_kezikonyv.pdf")

        Try
            Process.Start(sugo)
        Catch
            MyLoader.AddLogBook(Fnc.cfg, "Súgó fájlt nem találja a program itt: " & Directory.GetCurrentDirectory, LogTip.err)

        End Try
    End Sub


    Private Sub sample_Click(sender As Object, e As EventArgs) Handles sample.Click
        Dim Hova As String = MappaBeállító.ValasszKonyvtarat
        Dim outputfajl As String = Hova & Path.DirectorySeparatorChar & "csv_mintak.zip"
        Dim uzenet As String = String.Empty
        Dim sikeresseg As String = String.Empty
        Try
            If Hova <> "" Then WriteResourceToFile(outputfajl, My.Resources.ures_csv)
            System.IO.Compression.ZipFile.ExtractToDirectory(outputfajl, Hova)
            File.Delete(outputfajl)
            uzenet = "A minta CSV fájlok kitömörítve a " & Hova & " könyvtárban (Ceg_rogzito.csv stb. néven)"
            sikeresseg = LogTip.norm
        Catch ex As Exception
            uzenet = "Nem sikerült a minta CSV fájlok kitömörítése (már létezik azonos nevű fájl a könyvtárban vagy nincsen írási joga a megadott útvonalon?)"
            sikeresseg = LogTip.err
        End Try
        MsgBox(uzenet)
        MyLoader.AddLogBook(Fnc.db, uzenet, sikeresseg)
    End Sub

    Private Sub Ügy_Click(sender As Object, e As EventArgs) Handles Ügy.Click
        TDB_Ugy.ShowDialog()
        TDB_Ugy.Close()
    End Sub

    Private Sub Egyebtorzsadatok_Click(sender As Object, e As EventArgs) Handles Egyebtorzsadatok.Click
        TDB_Other.ShowDialog()
        TDB_Other.Close()
    End Sub

    Private Sub btnKuldEllenorzese_Click(sender As Object, e As EventArgs) Handles btnKuldEllenorzese.Click
        KuldemenyEllenorzese.ShowDialog()
        KuldemenyEllenorzese.Close()
    End Sub

    Private Sub lblPanelJava_Click(sender As Object, e As EventArgs) Handles lblPanelJava.Click

    End Sub

    Private Sub btnAccessibleUserSettingsFolder_Click(sender As Object, e As EventArgs)
        Dim valasz_jelszo = InputBox("Jelszó?", "Arconsult speciális funkcióhoz hozzáférés - jelszóvédett")
        Dim valasz_mappa As String = String.Empty
        If valasz_jelszo = "info@arconsult.hu" Then valasz_mappa = InputBox("Megadni kívánt látható mappa neve?", "Látható mappa beállítása (újraindítást igényel)") Else Exit Sub
        If Directory.Exists(valasz_mappa) = False Then
            MsgBox("A megadott könyvtár nem létezik!")
            Exit Sub
        End If
        My.Settings.AccessibleUserSettings = valasz_mappa
        My.Settings.Save()
        MyLoader.AddLogBook(Fnc.cfg, "Beállítva látható felhasználói könyvtárként: " & valasz_mappa, LogTip.siker)
        Application.Exit()
    End Sub

    Friend Sub TorzsadatChange_Click() Handles btnTorzsadatChange.Click
        Dim result = MsgBox("Ha a kijelölés után a megadott helyen nincsen törzsadatbázis, nem fogja tudni a programot futtatni!", MsgBoxStyle.OkCancel)
        If result = MsgBoxResult.Cancel Then Exit Sub
        Dim SelectedPath As String = MappaBeállító.ValasszKonyvtarat(My.Settings.AccessibleUserSettings)
        If SelectedPath = String.Empty Then Exit Sub
        Dim currentdir = My.Settings.TDBDirectory
        If currentdir = String.Empty Then currentdir = My.Settings.AccessibleUserSettings
        My.Settings.TDBDirectory = SelectedPath
        My.Settings.Save()
        If Not File.Exists(SelectedPath & Path.DirectorySeparatorChar & Fajl.TDB) Then
            Dim result2 = MsgBox("Átmásolja a program az új könyvtárba a jelenlegi törzsadatbázist?", MsgBoxStyle.YesNo)
            If result2 = MsgBoxResult.Yes Then
                Try
                    File.Copy(currentdir & Path.DirectorySeparatorChar & Fajl.TDB, SelectedPath & Path.DirectorySeparatorChar & Fajl.TDB)
                Catch ex As Exception
                    MsgBox("Másolási hiba! Lehet, hogy nincsen írási jog a célkönyvtárba. Az adatbázist nem másolta át a program", MsgBoxStyle.Critical)
                End Try
            End If
        End If
        Dim uzenet = "Beállítva törzsadatbázis könyvtárként: " & SelectedPath
        If File.Exists(SelectedPath & Path.DirectorySeparatorChar & Fajl.TDB) Then uzenet += Environment.NewLine & "A célkönyvtárban már van törzsadatbázis fájl, ezért a program nem végez másolást"
        MsgBox(uzenet, MsgBoxStyle.OkOnly)
        MyLoader.AddLogBook(Fnc.cfg, uzenet, LogTip.siker)
        AppDomain.CurrentDomain.SetData("DataDirectory", SelectedPath & Path.DirectorySeparatorChar)
    End Sub

    Private Sub btnRegFajl_Click(sender As Object, e As EventArgs) Handles btnRegFajl.Click
        If NoInternet = True Then
            MsgBox("Jelenleg nincs internet hozzáférése", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim code As String = InputBox("Sikeres feltöltés esetén a regisztrációs fájlt a regisztrációs kódjához kapcsolódóan eltárolhatja egy magyarországi szerveren" & Environment.NewLine & "A regisztrációs fájlt szükség esetén (azonosítás után) az eperHelper ügyfélszolgálata elküldi Önnek." & Environment.NewLine &
            "A tárolt regisztrációs állományt az ügyfélszolgálat kérésre bármikor törli." & Environment.NewLine & Environment.NewLine & "Adja meg a regisztrációs kódját, amelyhez rögzíteni szeretné a regisztrációs állományt!", "Regisztráció feltöltése szerverre")
        Dim ProcessedCode = code.Replace("-", String.Empty).ToUpper
        If code = String.Empty Then Exit Sub
        Dim filetoupload As String = zippeldRegFajlt(XRegPath)
        If filetoupload <> ":hiba:" Then
            Dim regfileinfozipped As New FileInfo(filetoupload)
            Dim regfilesizezipped As Long = regfileinfozipped.Length
            If regfileinfozipped.Length > 65535 Then
                Dim resultregfeltoltsiker = "Regisztrációs fájl feltöltése sikertelen. A regisztrált fájl mérete túl nagy a feltöltéshez:" & regfileinfozipped.Length & Environment.NewLine &
                    "Készítsen a saját gépén biztonsági másolatot erről a fájlról: " & XRegPath
                MyLoader.AddLogBook(Fnc.cfg, resultregfeltoltsiker, LogTip.err)
                MsgBox(resultregfeltoltsiker, MsgBoxStyle.Critical)
            End If
            Using WSReg As New RegSrv.eperHelperRegWS_ifClient
                Dim resultWSreg As String = String.Empty
                Try
                    resultWSreg = WSReg.UploadRegBak(TknUploadRegBak, ProcessedCode, File.ReadAllBytes(filetoupload))
                    MsgBox("A feltöltés sikeres", MsgBoxStyle.OkOnly)
                Catch ex As Exception
                    MsgBox("A feltöltés sikertelen: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub teszt_Click(sender As Object, e As EventArgs) Handles teszt.Click
        MsgBox(My.Settings.KeltezesHelye)
    End Sub

    Private Sub SetPreferredBrowser_Click(sender As Object, e As EventArgs) Handles SetPreferredBrowser.Click
        Forms.SelectPreferredBrowser.ShowDialog()
    End Sub
End Class
