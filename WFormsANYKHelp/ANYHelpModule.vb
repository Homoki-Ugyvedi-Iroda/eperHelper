Imports System.IO.Compression
Imports System.Net.NetworkInformation
Imports <xmlns:reg="https://www.microsec.hu/registration#">
Imports <xmlns:ds="http://www.w3.org/2000/09/xmldsig#">
Imports System.Threading
Imports System.Security.Cryptography.X509Certificates
Imports System.Runtime.InteropServices
Imports XSign4COMLib
Imports System.Text
Imports System.Xml

Module ANYHelpModule
    Public MyLoader As Loader
    Public SharedXSignSession As New XSign4COMLib.XSignSession
    Public XRegPath As String = String.Empty
    Public XSignWorkDir As String = String.Empty
    Public XSignLogPath As String = String.Empty
    Friend eroforrasok As String = String.Empty
    Friend nyomtatvanyok As String = String.Empty
    Public DecSep As String = String.Empty
    Friend MindenElerhetoNyomtatvanyList As New List(Of String)
    Friend CsakTelepitettbolUjabbNyomtatvanyList As New List(Of String)
    Friend ElerhetobolUjabbNyomtatvanyList As New List(Of String)
    Public Const JavaDLURL As String = "https://www.java.com/en/"
    Public Const JavaDLDirectURL As String = "http://javadl.oracle.com/webapps/download/AutoDL?BundleId=216403" '2016.11.06
    Public Const ANYKDLURL As String = "http://www.nav.gov.hu/data/cms36637/abevjava_install.jar"
    Public Const abevjavaindito As String = "abevjava_start.bat"
    Public countersuccess As Integer = 0
    Public counterfailed As Integer = 0
    Public hibastetel As New List(Of String)
    Friend MindenElerhetoNyomtatvanyToDL As New DataTable
    Friend CsakTelepitettbolUjabbNyomtatvanyToDL As New DataTable
    Friend ElerhetobolUjabbNyomtatvanyToDL As New DataTable
    Public NoInternet As Boolean
    Friend AlairoCert As New Certs
    Friend TSCert As New Certs
    'Friend OCSPCert As New Certs
    Friend TempDecryptKeyPath As String = String.Empty
    Friend TempDecryptPassw As String = String.Empty
    Friend KRCST_PassPath As String = String.Empty
    Friend KRCST_FileExtracted As String = String.Empty
    Friend KRCST_FilesListed() As String
    Public MyLog As String = String.Empty
    Friend ListToDisplay As String = String.Empty
    Friend HibaListToDisplay As String = String.Empty
    Friend TelepitettNyomtatvanyok As New DataTable
    Friend TorzstipusDisplay() As String = {"Természetes személy", "Cég", "Egyéb szervezet", "Ügyvédi iroda", "Egyéni ügyvéd", "Egyéb jogi képviselő", "Jogtanácsos", "Egyéni vállalkozó"}
    Friend KitoltPass() As String
    Friend JavaPath As String = Chr(34) & GetJavaHome() & Chr(34)
    Friend KriptoWrapper As String = "-jar " & Chr(34) & Directory.GetCurrentDirectory & Path.DirectorySeparatorChar & "KriptoWrapper.jar" & Chr(34)
    Friend ParamTextFile As String
    Friend NincsenAlairoTanusitvany As Boolean = False
    Friend Const supportmailaddress As String = "eperhelper@arconsult.hu"
    Friend Const TknUploadRegBak = "vCAj5dGq"
    Private Const TknCheckMac = "!84P%W*s5Y74ZeB"
    Private RegChecked As Boolean = False
    Friend MicrosecTSAUrl As String = "https://tsa.e-szigno.hu/tsa"
    Friend MicrosecTSAUrlTeszt As String = "https://teszt.e-szigno.hu/tsa"
    Friend MicrosecBTSAUrl As String = "https://btsa.e-szigno.hu/tsa"
    Friend MicrosecBTSAUrlTeszt As String = "https://bteszt.e-szigno.hu/tsa"
    Const XS_REV_CHECK_OCSP_CRL = 3
    Friend NemelerhetoOBH As Boolean = False
    Friend NyomiWebURL As String = "http://birosag.hu/allampolgaroknak/nyomtatvanyok-urlapokoldalon"

    Structure Certs
        Friend Thumbprint As String
        Friend CommonName As String
        Friend Type As String
    End Structure

    Structure Fajl
        Const TDB = "TorzsAdatbazis.mdb"
        'Const ImpMDB = "importalashoz.mdb"
        'Const Nyomt = "nyomtatvany.xml"
        Const XSignReg = "server_reg.xml"

    End Structure
    Enum LoginType
        HttpRequest = 0
        WebLogin = 1
    End Enum
    Enum CertTypes As Byte
        alairas = 0
        autent_TS = 1
        'autent_OCSP = 2
    End Enum
    Enum Adószámhiba As Byte
        OK = 0
        EllenorzoSzam = 1
        AFAKod = 2
        TeruletiKod = 3
        Hossz = 4

    End Enum
    Enum SecretInfoKapu
        UKPUName
        PKPUName
        HKPUName
        UKPPassw
        PKPPassw
        HKPPassw
    End Enum
    Enum SablonTelepitettOption
        MindenElerhetot = 0
        CsakUjabbElerhetot = 1
        CsakUjabbEsTelepitveElozmeny = 2
        ProgrambanElerhetot = 3
        Semmit = 4
    End Enum
    Enum TDBTabla
        TSZ = 0
        CEG = 1
        ESZ = 2
        EV = 3
        ÜI_JK = 4
        EÜ_JK = 5
        JT_JK = 6
        EGYEB_JK = 7
    End Enum

    Enum TorzsTipus_rogzito
        Term_szemely = 1
        Ceg = 2
        Egyeb_szervezet = 3
        Ugyvedi_iroda = 4
        Egyeni_ugyvedi = 5
        Egyeb_jogi_kvo = 6
        Jogtanacsos = 7
        EV = 8
        Ugytorzs = 9
    End Enum

    Enum Kapu
        UKP = 0
        PKP = 1
        HKP = 2
    End Enum

    Enum TSAuth
        BTSA = 0
        TSA = 1
    End Enum

    Structure Fnc
        Const cfg = "Konfiguráció"
        Const eal = "Elektronikus aláírás"
        Const nyomdl = "Nyomtatványok letöltése"
        Const web = "Web"
        Const nyomt = "Nyomtatás"
        Const extr = "Kicsomagolás"
        Const xml = "Nyomtatvány kitöltése"
        Const db = "Törzsadatbázis"
        Const bekuldes = "Beküldés"
        Const igazolasbeolvasas = "Küldemény ellenőrzése"
    End Structure
    Structure LogTip
        Const err = "hiba"
        Const siker = "siker"
        Const norm = "egyéb"
    End Structure


    Sub Main()
#If Debug Then
        My.Settings.Reset()
#End If
        Application.EnableVisualStyles()
        MyLoader = New Loader
        CheckSettingsFolders()
        SetMyLog()
        'SetDebugger()
        MyLoader.AddLogBook(Fnc.cfg, "Program elindult, verziószám: " & GetMyAppVersion() & "; OS verziószám: " & Environment.OSVersion.Version.ToString, LogTip.norm)

        If Not CheckOS() Then
            MsgBox("A program és az ÁNYK Is csak Windows Vista SP2 vagy újabb operációs rendszeren fut megbízhatóan. Az Ön rendszere:  " & Environment.OSVersion.ToString & ". A program leáll.", MsgBoxStyle.Critical)
            MyLoader.AddLogBook(Fnc.cfg, "Nem megfelelő operációs rendszer (" & Environment.OSVersion.Version.ToString & ").", LogTip.err)
            SharedXSignSession = Nothing
            QuitMe()
        End If
#If ARCONSULT = "Y" Then
        If File.Exists(My.Settings.ARCONSULTSettings) Then
            Try
                SettingsBackup.Import(My.Settings.ARCONSULTSettings)
                MyLoader.AddLogBook(Fnc.cfg, "Arconsult felhasználói beállítások sikeresen importálva", LogTip.norm)
                File.Delete(My.Settings.ARCONSULTSettings)
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.cfg, "Arconsult felhasználói beállítások importálási hiba:" & ex.Message, LogTip.err)
            End Try
        Else
            MyLoader.AddLogBook(Fnc.cfg, "Arconsult felhasználói beállítások hiányoznak (c:\eperhelper_data\eperelper_settings.xml)", LogTip.norm)
        End If
        My.Settings.UKPPassw = String.Empty
        My.Settings.UKPUName = String.Empty
        My.Settings.PKPPassw = String.Empty
        My.Settings.PKPUName = String.Empty
        My.Settings.HKPPassw = String.Empty
        My.Settings.HKPUName = String.Empty
        My.Settings.Save()
        MyLoader.CheckUKP()
        MyLoader.CheckHKP()
        MyLoader.CheckPKP()
        My.Settings.PkeyPassw = Kapukezelo.Encrypt(My.Settings.ARCONSULTtitkjelszo, "PkeyPassw")
        MyLoader.AddLogBook(Fnc.cfg, "Arconsult titkosító jelszó beállítva, kapujelszavak törölve", LogTip.norm)
#End If

        Try
            If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
                If My.Application.Deployment.IsFirstRun Then FirstRunner()
            Else
                If My.Settings.DbgFirstRun Then FirstRunner()
            End If
        Catch ex As System.Deployment.Application.InvalidDeploymentException
            If My.Settings.DbgFirstRun Then FirstRunner()
        End Try
#Region "Beállítása globális változóknak#1"
        CreateTDB()
        Dim DataDir As String = String.Empty
        If My.Settings.TDBDirectory = String.Empty Then DataDir = Settings.AccessibleUserSettings & Path.DirectorySeparatorChar Else DataDir = Settings.TDBDirectory & Path.DirectorySeparatorChar
        If Not File.Exists(DataDir & Fajl.TDB) Then
            Dim result = MsgBox("A TorzsAdatbazis.mdb nem található a megadott könyvtárban (" & DataDir & "). " & Environment.NewLine & "Visszaállítsam az alapértelmezett könyvtárat, és ha nincsen ott adatbázis, az üres adatbázist (IGEN) vagy " & Environment.NewLine & "kiválasztja Ön a helyes könyvtárat (NEM)?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                CreateTDB()
                My.Settings.TDBDirectory = String.Empty
                My.Settings.Save()
                DataDir = Settings.AccessibleUserSettings & Path.DirectorySeparatorChar
            Else
                MyLoader.TorzsadatChange_Click()
            End If
        End If
        AppDomain.CurrentDomain.SetData("DataDirectory", DataDir)
        DecSep = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        MyLoader.StripVersion.Text = GetMyAppVersion()
#If Not Debug Then
        SettingsUpgrade()
#End If

#End Region
        MyLoader.Show()
        InitRegeperHelperEszigno()
        'Trace.WriteLine("InitRegeperHelperEszigno finish")
        AlairoCert.Type = CertTypes.alairas
        TSCert.Type = CertTypes.autent_TS
        'OCSPCert.Type = CertTypes.autent_OCSP
        LoadAlairofromSettings()
        'Trace.WriteLine("LoadAlairofromSettings finish")
        LoadTSfromSettings()
        'Trace.WriteLine("LoadTSfromSettings finish")
        'If My.Settings.OCSPCertDefault <> "" Then LoadCert(OCSPCert)

        If My.Settings.TSURL.Replace(vbCrLf, String.Empty).Trim <> String.Empty Then
            Dim response = SharedXSignSession.SetTimeStampURLs(My.Settings.TSURL)
            If response = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyeg URL beállítva korábbi adatokból", LogTip.norm)
        End If
        If My.Settings.TSUN <> "" And My.Settings.TSPW <> "" Then
            Dim response = SharedXSignSession.SetDefaultBasicAuth(Kapukezelo.Decrypt(My.Settings.TSUN, "TSUN"), Kapukezelo.Decrypt(My.Settings.TSPW, "TSPW"))
            If response = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyegzős felhasználónév&jelszó XSign4COMban beállítva", LogTip.norm)
        End If
        CheckSetSigLevel()
        CheckInternetwLabelChange()
        MyLoader.TimerCheckInet2minutes.Start() '2 percenként
        RunJavaCheck()
        RunANYKCheck()

#Region "ÁNYK nyomtatványok betöltése"
        If My.Settings.mappaANYKfuttatas <> String.Empty Then
            'A My.Settings.mappaANYKfuttatas nem lehet String.Empty a ConfigANYKfuttatasfromANYKCfgFile sor miatt, amit CheckAnykInstalledBasedonMySettingsANYKfuttatas() hív meg, amit RunANYKCheck() hív meg. Ez az "If" biztonságból maradt itt, pl. ha ÁNYK nincsen telepítve
            eroforrasok = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "eroforrasok" & Path.DirectorySeparatorChar
            nyomtatvanyok = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "nyomtatvanyok" & Path.DirectorySeparatorChar
            RunANYKParamNyomCheck()
            SajatTitkositoCheck()
        End If

#End Region
        Try
            Application.Run(MyLoader)
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.cfg, "Egyéb felső szintű hiba: " & ex.Message, LogTip.err)
        End Try

    End Sub
    Sub SettingsUpgrade()
        If My.Settings.UpgradeRequired Then
            My.Settings.Upgrade()
            My.Settings.UpgradeRequired = False
            My.Settings.Save()
        End If
    End Sub

    Friend Function CheckOS() As Boolean
        Dim OS As Version = Environment.OSVersion.Version
        Dim VistaSP2 As New Version("6.0.6002")
        If OS.CompareTo(VistaSP2) > 0 Then Return True Else Return False
    End Function
    Sub CheckSettingsFolders()
        Dim settings() = {"AccessibleUserSettings", "mappaLefuzes", "mappaExtract", "mappaXMLmegnyitas", "mappaANYKfuttatas", "mappaANYKadat", "mappaANYKmentes", "mappaANYKkuldendo", "mappaANYKelkuldott"}
        For Each line In settings
            If Not Directory.Exists(CallByName(My.Settings, line, CallType.Get)) Then CallByName(My.Settings, line, CallType.Set, String.Empty)
        Next
        If String.IsNullOrWhiteSpace(My.Settings.AccessibleUserSettings) Then SetAccessibleUserPath()
        If String.IsNullOrWhiteSpace(My.Settings.mappaXMLmegnyitas) Then My.Settings.mappaXMLmegnyitas = CheckLefuzesXMLmegnyitasExists()
        If String.IsNullOrWhiteSpace(My.Settings.mappaLefuzes) Then My.Settings.mappaLefuzes = CheckLefuzesXMLmegnyitasExists()
        If String.IsNullOrWhiteSpace(My.Settings.mappaExtract) Then My.Settings.mappaExtract = CheckExtractMappa()
        My.Settings.Save()

    End Sub
    Function CheckLefuzesXMLmegnyitasExists() As String
        Dim LefuzesXMLmegnyitas As String = Path.Combine(My.Settings.AccessibleUserSettings, "Lefuzes")
        If Not Directory.Exists(LefuzesXMLmegnyitas) Then
            Try
                Directory.CreateDirectory(LefuzesXMLmegnyitas)
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.cfg, "Alapértelmezett lefűzési/XML nyitási könyvtár beállítási/írási hiba. Az alapkönyvtárat állítjuk be.", LogTip.err)
                LefuzesXMLmegnyitas = My.Settings.AccessibleUserSettings
            End Try
        End If
        Return LefuzesXMLmegnyitas
    End Function
    Function CheckExtractMappa() As String
        Dim ExtractMappa As String = Path.Combine(My.Settings.AccessibleUserSettings, "Kicsomagolt")
        If Not Directory.Exists(ExtractMappa) Then
            Try
                Directory.CreateDirectory(ExtractMappa)
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.cfg, "Alapértelmezett kicsomagolási könyvtár beállítási/írási hiba. Az alapkönyvtárat állítjuk be.", LogTip.err)
                ExtractMappa = My.Settings.AccessibleUserSettings
            End Try
        End If
        Return ExtractMappa
    End Function


    Sub SetMyLog()
        Dim logdir As String = My.Settings.AccessibleUserSettings & Path.DirectorySeparatorChar & "Log"
        If Not Directory.Exists(logdir) Then
            Try
                System.IO.Directory.CreateDirectory(logdir)
            Catch ex As Exception
                Dim uzenet1 = "Log könyvtár megnyitási hiba: " & logdir & ": " & ex.Message
                MyLoader.AddLogBook(Fnc.cfg, uzenet1, LogTip.err)
                MsgBox(uzenet1, MsgBoxStyle.Critical & MsgBoxStyle.OkOnly)
            End Try
        End If
        MyLog = logdir & Path.DirectorySeparatorChar & "eperHelperLogBook" & Now.ToString("yyMMdd") & ".txt"
        MyLoader.AddLogBook(Fnc.cfg, "Logfájl beállítva: " & MyLog, LogTip.norm)
        Dim FileColl = System.IO.Directory.GetFiles(Path.GetDirectoryName(MyLog), "eperHelperLogBook*.txt*")
        For Each file In FileColl
            Dim fi As New FileInfo(file)
            If fi.CreationTime < Now.AddDays(-5) Then
                Try
                    fi.Delete()
                Catch ex As Exception
                    MyLoader.AddLogBook(Fnc.cfg, "Régi logfájl törlése sikertelen: " & fi.FullName & MyLog, LogTip.err)
                End Try
            End If
        Next
    End Sub
    Sub FirstRunner()
        SetAddRemoveProgramsIcon()
        MyLoader.AddLogBook(Fnc.cfg, "Első beállítások rögzítésének megkezdése", LogTip.norm)
        'SetAccessibleUserPath()
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            My.Settings.DbgFirstRun = False
            My.Settings.Save()
        End If

    End Sub
    Public Function SetAddRemoveProgramsIcon() As Boolean
        Dim iName As String = "eper_helper_button_32x32_rgb_v1.ico" '
        Dim aName As String = My.Application.Info.AssemblyName '      
        Try
            Dim iconSourcePath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, iName)
            If Not System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then Return False ' ClickOnce check
            If Not System.Deployment.Application.ApplicationDeployment.CurrentDeployment.IsFirstRun Then Return False
            If Not File.Exists(iconSourcePath) Then Return False
            Dim myUninstallKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Uninstall")
            Dim mySubKeyNames As String() = myUninstallKey.GetSubKeyNames()
            For i As Integer = 0 To mySubKeyNames.Length Step 1
                Dim myKey As Microsoft.Win32.RegistryKey = myUninstallKey.OpenSubKey(mySubKeyNames(i), True)
                Dim myValue As Object = myKey.GetValue("DisplayName")
                If (myValue IsNot Nothing And myValue.ToString() = aName) Then
                    myKey.SetValue("DisplayIcon", iconSourcePath)
                    Return True
                End If
            Next i
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Sub CreateTDB()
        Dim db1Path As String = My.Settings.AccessibleUserSettings & Path.DirectorySeparatorChar & Fajl.TDB
        If Not File.Exists(My.Settings.AccessibleUserSettings & Path.DirectorySeparatorChar & Fajl.TDB) Then
            WriteResourceToFile(db1Path, My.Resources.TorzsAdatbazis)
            MyLoader.AddLogBook(Fnc.db, "Üres törzsadatbázis bemásolva a " & My.Settings.AccessibleUserSettings & " könyvtárba.", LogTip.norm)
        End If
    End Sub

    Sub SetAccessibleUserPath()
        Dim TempAccessibleUserSettings As String
        TempAccessibleUserSettings = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            TempAccessibleUserSettings += System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
        Else
            TempAccessibleUserSettings += "eperHelper"
        End If
        Dim Kiiras As Boolean
        If MyLog <> "" Then Kiiras = True

        If Directory.Exists(TempAccessibleUserSettings) Then
            My.Settings.AccessibleUserSettings = TempAccessibleUserSettings
            My.Settings.DbgFirstRun = False
            My.Settings.Save()
            MyLoader.AddLogBook(Fnc.cfg, "Látható beállítási könyvtárként rögzítve a " & TempAccessibleUserSettings, LogTip.siker)
            Exit Sub
        End If
        Try
            MkDir(TempAccessibleUserSettings)
            My.Settings.AccessibleUserSettings = TempAccessibleUserSettings
            My.Settings.DbgFirstRun = False
            My.Settings.Save()
            MyLoader.AddLogBook(Fnc.cfg, "Látható beállítási könyvtárként rögzítve a " & TempAccessibleUserSettings, LogTip.siker)
        Catch ex As System.Security.SecurityException
            MyLoader.AddLogBook(Fnc.cfg, "Jogosultság hiánya miatt nem sikerült a látható beállításokat tartalmazó könyvtárat ide rögzíteni: " & TempAccessibleUserSettings, LogTip.err)
Kivalaszt:
            Dim Res = MsgBox("A felhasználó által is látható beállításokat és fájlokat tartalmazó könyvtárat nem tudtuk létrehozni a " & TempAccessibleUserSettings & " könyvtárban. Enélkül a program nem futhat. Kérem válasszon ki egy olyan könyvtárat, amelyhez van írási joga!", MsgBoxStyle.OkCancel)
            If Res = vbOK Then
                Dim UDir As New System.Windows.Forms.FolderBrowserDialog()
                Dim UDirResult As New Boolean
                UDir.ShowNewFolderButton = True
                UDir.Description = "Válassza ki, hogy melyik könyvtárba helyezi el a felhasználói beállításokat és fájlokat!"
                UDir.RootFolder = Environment.SpecialFolder.MyDocuments
                UDirResult = UDir.ShowDialog()
                If UDirResult = True Then
                    TempAccessibleUserSettings = UDir.SelectedPath
                    MyLoader.AddLogBook(Fnc.cfg, "Látható beállítási könyvtárként rögzítve a " & TempAccessibleUserSettings, LogTip.norm)
                    My.Settings.AccessibleUserSettings = TempAccessibleUserSettings
                    My.Settings.DbgFirstRun = False
                    My.Settings.Save()
                Else GoTo Kivalaszt
                End If
                If Res = vbCancel Then
                    MsgBox("E könyvtár beállítása nélkül nem fogja tudni a programot használni. A program leáll.", MessageBoxButtons.OK)
                    MyLoader.AddLogBook(Fnc.cfg, "Jogosultság vagy kiválasztott könyvtár hiánya miatt nem sikerült a látható beállításokat tartalmazó könyvtárat rögzíteni", LogTip.err)
                    QuitMe()
                End If
            End If
        End Try
    End Sub


#Region "EszignoReg"
    Sub InitRegeperHelperEszigno()
        Dim LogPathSet As New Boolean, MicrosecInitialized As New Boolean
        LogPathSet = EszigLogPathBeallitasa()
        MicrosecInitialized = EszigInitBeallitasa()
        'A Microsec-féle inicializáció teszt tanúsítvány vagy más Microsec adta regisztráció esetén is sikeres lehet, ezért kell külön is ellenőrizni kell, nem elég arra hagyatkozni, hogy inicializált-e az eszigno automata
        Dim regCheckresult As Boolean = CheckRegFajl(XRegPath)
        If regCheckresult = False Then
            RegisztralatlanValtozat()
#If Not ARCONSULT = "Y" And Not DEBUG Then
            Forms.RegisztraciosAblak.ShowDialog(MyLoader)
            Forms.RegisztraciosAblak.Close()
            MicrosecInitialized = EszigInitBeallitasa()
            regCheckresult = CheckRegFajl(XRegPath)
#End If

        End If
#If ARCONSULT = "Y" Then
        MyLoader.AddLogBook(Fnc.eal, "Arconsult oktatási változat, oktatási üzemmód", LogTip.norm)
        MyLoader.Text = "Arconsult oktatási változat!"
        MyLoader.Ribbon.OrbText = "Súgó, kilépés"
#End If
#If OKTATASI = "Y" Then
        MyLoader.AddLogBook(Fnc.eal, "Bemutató változat", LogTip.norm)
        MyLoader.Text = "Homoki Ügyvédi Iroda bemutató változat"
        MyLoader.Ribbon.OrbText = "Súgó, kilépés"
#End If
#If DEBUG Then
        MyLoader.AddLogBook(Fnc.eal, "Debug változat", LogTip.norm)
#End If
#If Not DEBUG And ARCONSULT <> "Y" And OKTATASI <> "Y" Then
        Dim uzenet = String.Empty
        If MicrosecInitialized = False Or regCheckresult = False Then
            If My.Settings.Regisztrált = False Then uzenet = Environment.NewLine & "Az Ön programja nincsen regisztrálva. Kérem regisztráljon." & Environment.NewLine &
            "Regisztráció hiányában a programot csak csökkentett értékű demó módban tudja használni." & Environment.NewLine & "NE HASZNÁLJA A DEMÓ VERZIÓT BÍRÓSÁGI BEKÜLDÉSRE!" & Environment.NewLine &
            "(Ha Ön szerint már regisztrált ezen a számítógépen vagy hálókártyán, kattintson a program alján, bal oldalon lévő könyv ikonra és ezáltal küldje el a naplófájlt a támogatást nyújtó cégnek!)"
            If My.Settings.Regisztrált = True Then uzenet = Environment.NewLine & "A megváltozott hálózati kártya vagy számítógép miatt a programot újra kell regisztrálnia!" & Environment.NewLine &
                "Regisztráció hiányában a programot csak csökkentett értékű demó módban tudja használni." & Environment.NewLine & "NE HASZNÁLJA A DEMÓ VERZIÓT BÍRÓSÁGI BEKÜLDÉSRE!" & Environment.NewLine &
                    "Ha Ön szerint nem változott a hálózati kártya vagy a számítógép, kattintson a program alján, bal oldalon lévő könyv ikonra és ezáltal küldje el a naplófájlt a támogatást nyújtó cégnek!"
            MsgBox(uzenet, MsgBoxStyle.Critical)
            MyLoader.AddLogBook(Fnc.cfg, uzenet, LogTip.err)
            MsgBox("Demó változatban nem tud KR-t kitömöríteni, a kitöltés csak 'DEMO' felirattal tölti ki az iratot, csak teszt aláírással és időbélyeggel tudja a hitelesítést elvégezni (beküldendő csomag)." & Environment.NewLine &
                   "DEMÓ VÁLTOZATHOZ NEM NYÚJTUNK TÁMOGATÁST." & Environment.NewLine &
                   "A teszteléshez adjon meg egy természetes személy adatot a 'Törzsadatok karbantartása' menüpontban, majd próbálja ki a többi elérhető menüpontot.")
            'SharedXSignSession = Nothing
            'QuitMe()
        Else
            MyLoader.AddLogBook(Fnc.eal, "Regisztrációs fájl létezik, éles változat", LogTip.norm)
            RegisztraltValtozat()
        End If
#End If

    End Sub

    Private Function EszigLogPathBeallitasa() As Boolean
        Dim resp As Long = 0
        If Not String.IsNullOrWhiteSpace(Settings.AccessibleUserSettings) Then
            XSignLogPath = Settings.AccessibleUserSettings + Path.DirectorySeparatorChar + "Log" + Path.DirectorySeparatorChar + "XSign4Com.log"
        Else
            Throw New System.Exception("Nincsen AccessibleUserSettings beállítva.")
            Return False
        End If
        'Először logpath és regisztrációs path beállítása
        Try
            resp = SharedXSignSession.SetLogFilePath(XSignLogPath)
            If resp = 0 Then
                Return True
            Else
                MyLoader.AddLogBook(Fnc.eal, "XSign4COM.dll logpath beállítási hiba (javasoljuk a Windowsból való ki- és bejelentkezést és utána ismét megpróbálni! (hibakód:  " & resp & ")", LogTip.err)
                Return False
            End If
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.eal, "Esetleg kétszer fut párhuzamosan a program? Nem fog tudni aláírni! XSign4COM.dll naplóbeállítási hiba: " & ex.Message, LogTip.err)
            Return False
        End Try
    End Function

    Private Sub CheckRegFileandSettingOrExit()
        If File.Exists(XRegPath) And My.Settings.Regisztrált = True Then Exit Sub
        Dim uzenet = "Hiányzik a regisztrációs fájl (server_reg.xml) a program felhasználói könyvtárából (" & My.Settings.AccessibleUserSettings & ")" & Environment.NewLine & "Regisztráció hiányában a programot nem tudja használni." & Environment.NewLine & "A program leáll!"
        MsgBox(uzenet, MsgBoxStyle.Critical)
        MyLoader.AddLogBook(Fnc.cfg, uzenet, LogTip.err)
        SharedXSignSession = Nothing
        QuitMe()
    End Sub
    Private Function EszigInitBeallitasa() As Boolean
        Dim resp As Long = 0
        XSignWorkDir = Path.GetTempPath()
        If Not String.IsNullOrWhiteSpace(Settings.AccessibleUserSettings) Then
            XRegPath = Settings.AccessibleUserSettings + Path.DirectorySeparatorChar + Fajl.XSignReg
        Else
            Throw New System.Exception("Nincsen AccessibleUserSettings beállítva.")
            Return False
        End If
        If Not File.Exists(XRegPath) Then
            RegisztralatlanValtozat()
            WriteResourceToFile(XRegPath, System.Text.Encoding.Default.GetBytes(My.Resources.server_reg))
            Try
                resp = XsignInitialize(XSignWorkDir, XRegPath)
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.eal, "XSign4COM.dll inicializálási hiba: " & ex.Message, LogTip.err)
            End Try
#If Not DEBUG And Not ARCONSULT = "Y" Then
            Forms.RegisztraciosAblak.ShowDialog(MyLoader)
            Forms.RegisztraciosAblak.Close()
#End If

        Else
            Try
                resp = XsignInitialize(XSignWorkDir, XRegPath)
                'Trace.WriteLine("van_reg_Xsigninitalize:" & resp)
#If Not DEBUG Then
                'Egyelőre azért nem állítom be, mert nem csak a minősített tanúsítványt kínálja föl, illetve a minősített időbélyeget a Pp. sem követeli meg. Fejleszthető: csak az aláíró tanúsítványnál csak a minősítettet listázza ki
                'Dim resp2 = SharedXSignSession.SetSigRequirementsLevel(1)
                'If resp2 <> 0 Then MyLoader.AddLogBook(Fnc.eal, "Minősített tanúsítvány megkövetelése ismeretlen hiba miatt nem érvényesül (" & resp2 & ")", LogTip.err)
#End If
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.eal, "XSign4COM.dll inicializálási hiba: " & ex.Message, LogTip.err)
            End Try
        End If
        If resp <> 0 Then
            RegisztralatlanValtozat()
            Return False
        Else
            Return True
        End If

    End Function

    Private Function XsignInitialize(XSignWorkDir As String, XRegPath As String) As Integer
        Dim resp = SharedXSignSession.Initialize(XSignWorkDir, XRegPath)
        'Trace.WriteLine("workdir=" & XSignWorkDir)
        If resp = 8 Or resp = 15 Then MyLoader.AddLogBook(Fnc.cfg, "XSign4COM.dll inicializálási hiba vagy a Microsec szerinti regisztráció nem megfelelő (pl. megváltozott hálózati kártya cím, módosított regisztrációs fájl) " & resp & "|" & GetAdaptersInfoClass.GetAllMacAddressesfromGASingle, LogTip.err)
        If resp <> 8 And resp <> 0 And resp <> 15 Then MyLoader.AddLogBook(Fnc.cfg, "Egyéb XSign4COM.dll inicializálási hiba (" & resp & ")", LogTip.err)
        Return resp
    End Function

    Friend Sub CheckSetSigLevel()
#If Not DEBUG Then
        Dim resp As Integer = 0
        If My.Settings.Regisztrált = False Then
            MyLoader.Archívidőbélyeg.Checked = False
            resp = SharedXSignSession.SetXAdESType(3) 'SetSignatureLevel(2)
            'Trace.WriteLine("CheckSetSigLevel/resp[Reg_false]=" & resp)
            MyLoader.AddLogBook(Fnc.eal, "Nem regisztrált változat, így teszt tanúsítványokkal is csak XAdES-T típusú aláírás hozható létre, ezért a XAdES-A típusú aláírás nem lett beállítva", LogTip.norm)
            Exit Sub
        End If

        If My.Settings.Regisztrált = True AndAlso My.Settings.ArchivTS Then
            MyLoader.Archívidőbélyeg.Checked = True
            resp = SharedXSignSession.SetXAdESType(7) 'SetSignatureLevel(8)
            'Trace.WriteLine("CheckSetSigLevel/resp[Reg_true]=" & resp)
            If resp <> 0 Then
                MyLoader.AddLogBook(Fnc.eal, "Archív időbélyeg beállítási hiba (" & resp & "), ezért XAdES-A típusú aláírás nem lett beállítva", LogTip.err)
            Else
                Try
                    Dim resp2 = SharedXSignSession.SetRevocationCheckingMode(XS_REV_CHECK_OCSP_CRL)
                    If resp2 <> 0 Then MyLoader.AddLogBook(Fnc.eal, "Visszavonás ellenőrzés beállítási hiba, archív aláírást nem tud létrehozni", LogTip.err)
                    Exit Sub
                Catch ex As Exception
                    MyLoader.AddLogBook(Fnc.eal, "Visszavonás ellenőrzés beállítási hiba, archív aláírást nem tud létrehozni", LogTip.err)
                    Exit Sub
                End Try
                MyLoader.AddLogBook(Fnc.eal, "Archív időbélyeg beállítva, a program XAdES-A típusú aláírást hoz létre, ami egy KR csomagonként további két időbélyeget fog elhasználni", LogTip.norm)
            End If
        Else
            MyLoader.Archívidőbélyeg.Checked = False
            resp = SharedXSignSession.SetXAdESType(3) 'SetSignatureLevel(2)
            MyLoader.AddLogBook(Fnc.eal, "XAdES-T típusú típusú aláírás lett beállítva", LogTip.norm)
        End If
#End If
#If ARCONSULT = "Y" Or DEBUG Then
        MyLoader.Archívidőbélyeg.Checked = False
        SharedXSignSession.SetXAdESType(3) 'SetSignatureLevel(2)
        MyLoader.AddLogBook(Fnc.eal, "Oktatási vagy debug változat, így teszt tanúsítványokkal is csak XAdES-T típusú aláírás hozható létre, ezért a XAdES-A típusú aláírás nem lett beállítva", LogTip.norm)
#End If

#If OKTATASI = "Y" Then
        SharedXSignSession.SetXAdESType(3) 'SetSignatureLevel(2)
        MyLoader.Archívidőbélyeg.Checked = False
        MyLoader.AddLogBook(Fnc.eal, "Bemutató változat, így teszt tanúsítványokkal is csak XAdES-T típusú aláírás hozható létre, ezért a XAdES-A típusú aláírás nem lett beállítva", LogTip.norm)
#End If
    End Sub

    Friend Function CheckRegFajl(XRegPath As String) As Boolean
        'False = nem megfelelő a regisztrációs fájl (pl. teszt állomány vagy más alkalmazáshoz készült) vagy az abban foglalt MAC cím nem megfelelő
        Dim ForeignDossier As XSign4COMLib.XSignForeignDossier
        Dim FSignature As XSign4COMLib.XSignSignature
        If Not File.Exists(XRegPath) Then Return False

        'Dim rc As Long

        SharedXSignSession.SetWorkSilent(2)
        Dim root As XDocument = XDocument.Load(XRegPath)
        'Dim childList2 As IEnumerable(Of XElement) = From el In root.<reg:Subscription>.<reg:SignedData> Where el.@isRegistered = "true" Select el
        If Not root.<reg:Subscription>.<reg:SignedData>.@isRegistered = "true" Then
            MyLoader.AddLogBook(Fnc.cfg, "Regisztrációs hiba: regisztrációs fájl szerint nem regisztrált", LogTip.err)
            Return False
        End If
        If Not root.<reg:Subscription>.<reg:SignedData>.<reg:UserNotice>.Value.Contains("Rendszer: EperHelper") Then
            MyLoader.AddLogBook(Fnc.cfg, "Regisztrációs hiba: regisztrációs fájl szerint nem EperHelperre vonatkozik a regisztráció", LogTip.err)
            Return False
        End If
        If Not root.<reg:Subscription>.<reg:SignedData>.<reg:UserNotice>.Value.Contains("Szoftverfejlesztő: Homoki Ügyvédi Iroda") Then
            MyLoader.AddLogBook(Fnc.cfg, "Regisztrációs hiba: regisztrációs fájl szerint nem a Homoki Ügyvédi Iroda a fejlesztő", LogTip.err)
            Return False
        End If
        '#If MACCHECKBYMSEC = "Y" Then
        If CheckMACfromEszig(root) = False Then

            Return False
        End If
        '#End If

        'A regisztrációs fájl szerint nem regisztrált
        ForeignDossier = SharedXSignSession.OpenForeignDossier(XRegPath)

        If ForeignDossier Is Nothing Then Return False
        FSignature = ForeignDossier.GetFirstSignature

        Try
            Dim valresult = FSignature.Validate()
            If valresult <> 0 Then
                MyLoader.AddLogBook(Fnc.cfg, "Regisztrációs hiba: regisztrációs fájl aláírása érvénytelen (módosíthatták)!", LogTip.err)
                Return False
            End If

        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.cfg, "Regisztrációs hiba: regisztrációs fájl aláírása érvénytelen! (módosíthatták)", LogTip.err)
            Return False
            'A regisztrációs fájlon az aláírás érvénytelen
        End Try
        If FSignature.GetTitle = "Microsec Ltd. - e-Szigno Automata Registered Licence" Then
            Return True
        Else
            MyLoader.AddLogBook(Fnc.cfg, "Regisztrációs hiba: regisztrációs fájlt nem a Microsec Ltd. - e-Szigno Automata Registered Licence írta alá", LogTip.err)
            Return False
        End If

    End Function

    Friend Function CheckMACfromEszig(root As XDocument) As Boolean
        'Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Dim MACsFull As List(Of String) = GetAdaptersInfoClass.getAllMacAddressesGA

        Dim MACstimmt As Boolean = False

        Dim childList As IEnumerable(Of XElement) =
                From el In root...<reg:MAC> Select el
        For Each e As XElement In childList
            Dim interim As String = ""
            interim = Strings.Replace(e, ":", "").ToUpper
            MyLoader.AddLogBook(Fnc.cfg, "Az elérhető regisztrációs fájl szerinti cím: " & interim, LogTip.norm)
            For Each em In MACsFull
                If em.ToUpper = interim Then
                    MACstimmt = True
                End If
                'If em.ToUpper = "F079595F90AD" Then MACstimmt = True
            Next
        Next
        If MACstimmt = True Then
            MyLoader.AddLogBook(Fnc.cfg, "Regisztrációs fájl szerinti hálókártya címet megtaláltuk", LogTip.norm)
            Return True
        Else
            MyLoader.AddLogBook(Fnc.cfg, "Regisztrációs fájl szerinti hálókártya címet nem találtuk. Elérhető címek: " & GetAdaptersInfoClass.GetAllMacAddressesfromGASingle, LogTip.err)
            Return False
        End If

    End Function



    Friend Sub RegisztraltValtozat()
        MyLoader.Text = "Regisztrált változat"
        My.Settings.Regisztrált = True
        MyLoader.Regisztráció.Enabled = False
        MyLoader.Ribbon.OrbText = "Súgó, kilépés"
        My.Settings.Save()

        'MyLoader.pnlKRbeküldésrecsomagol.Enabled = True
        'MyLoader.pnlTörzsadattalkitölt.Enabled = True
        'MyLoader.pnlBeallitasSigTS.Enabled = True
        MyLoader.extractkr.Enabled = True

    End Sub

    Friend Sub RegisztralatlanValtozat()
        My.Settings.Regisztrált = False
        My.Settings.Save()
        MyLoader.Text = "Nem regisztrált, demó változat!"
        MyLoader.Regisztráció.Enabled = True
        MyLoader.Ribbon.OrbText = "Regisztráció, súgó, kilépés"
#If Not DEBUG Then
        'MyLoader.pnlKRbeküldésrecsomagol.Enabled = False
        'MyLoader.pnlTörzsadattalkitölt.Enabled = False
        MyLoader.extractkr.Enabled = False
#End If


    End Sub

    Friend Function VanIlyenCertbySerial(Serial As String) As String
        Dim store As New X509Store(StoreName.My, StoreLocation.CurrentUser)
        store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)
        Dim fcollection As X509Certificate2Collection = CType(store.Certificates.Find(X509FindType.FindBySerialNumber, Serial, True), X509Certificate2Collection)
        If fcollection.Count = 0 Then
            Return String.Empty
        Else
            Return ReformatThumbprintWithSpaces(fcollection.Item(0).Thumbprint.ToString)
        End If
    End Function

    Friend Function VanIlyenCertbyThumb(Thumbprint As String) As String
        Dim store As New X509Store(StoreName.My, StoreLocation.CurrentUser)
        Dim result As String = String.Empty
        Dim thumbprintofind As String = Thumbprint.Replace(" ", String.Empty).ToUpper
        store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)
        'Dim fcollection As X509Certificate2Collection = CType(store.Certificates.Find(X509FindType.FindByThumbprint, Thumbprint, True), X509Certificate2Collection)
        For Each cert In store.Certificates
            If cert.Thumbprint.Replace(" ", String.Empty).ToUpper = thumbprintofind Then
                result = GetCommonNameSubject(cert.Subject.ToString)
            End If
        Next
        'If fcollection.Count = 0 Then
        'store.Close()
        'Return String.Empty
        'Else
        '= GetCommonNameSubject(fcollection.Item(0).Subject.ToString)
        store.Close()
        Return result
        'End If
    End Function

    Friend Function IssuedByMicrosec(Thumbprint As String) As Boolean
        Dim store As New X509Store(StoreName.My, StoreLocation.CurrentUser)
        Dim thumbprintofind As String = Thumbprint.Replace(" ", String.Empty).ToUpper
        store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)
        Dim fcollection As X509Certificate2Collection = CType(store.Certificates.Find(X509FindType.FindByThumbprint, thumbprintofind, True), X509Certificate2Collection)

        If fcollection.Count = 0 Then
            store.Close()
            Return False
        End If

        Dim result = fcollection.Item(0).Issuer.ToString
        If result.Contains("Microsec") Or result.Contains("e-Szigno") Then
            store.Close()
            Return True
        Else
            Return False
        End If
    End Function


    Friend Function LoadCertIntoXSign(ByRef Mit As Certs) As Boolean
        Dim KivalasztottTipusNeve As String = String.Empty

#If Not DEBUG And ARCONSULT <> "Y" Then
        If My.Settings.Regisztrált = False Then Return True
#End If
        Select Case Mit.Type
            Case CertTypes.alairas
                KivalasztottTipusNeve = "aláíró"
            Case CertTypes.autent_TS
                KivalasztottTipusNeve = "időbélyeg szolg. autentikációs"
                'Case CertTypes.autent_OCSP
                '   what = "OCSP szolg. autentikációs"
        End Select

        Dim response As Integer = 1
        If Mit.Thumbprint = String.Empty Then
            MyLoader.AddLogBook(Fnc.eal, "Nincsen kiválasztva betöltendő tanúsítvány", LogTip.err)
            Return False
        End If
        Dim CertNeve As String = VanIlyenCertbyThumb(Mit.Thumbprint)
        If CertNeve = String.Empty Then
            Dim uzenet0 As String = String.Empty
            If My.Settings.Regisztrált = False Then uzenet0 = " Teszt használat esetén ellenőrizze, hogy a kiválasztott tanúsítvány Microsec-féle teszt CA tanúsítvány-e!"
            uzenet0 += " A betölteni kért " & KivalasztottTipusNeve & " típusú tanúsítvány nem található a gépen, így nem állítható be: " & Mit.Thumbprint
            MyLoader.AddLogBook(Fnc.eal, uzenet0, LogTip.err)
            Return False
        End If
        Mit.CommonName = CertNeve
        'Trace.WriteLine("Mit.CommonName = CertNeve=" & Mit.CommonName & "/" & Mit.Thumbprint)
        Select Case Mit.Type
            Case CertTypes.alairas
                response = SharedXSignSession.SetDefaultSigningCert(0, Mit.Thumbprint)
            Case CertTypes.autent_TS
                response = SharedXSignSession.SetDefaultTSAuthCert(0, Mit.Thumbprint)
                'Case CertTypes.autent_OCSP
                '   response = SharedXSignSession.SetDefaultOCSPAuthCert(0, Mit.Thumbprint)
        End Select

        If response = 0 Then
            MyLoader.AddLogBook(Fnc.eal, "A " & Mit.CommonName & " nevű, " & KivalasztottTipusNeve & " típusú tanúsítvány kiválasztva", LogTip.norm)
            Return True
        Else
            Dim uzenet = CType(response, String)
            If response = 2 Or response = 15 Then
                If Mit.Type = CertTypes.alairas Then NincsenAlairoTanusitvany = True Else NincsenAlairoTanusitvany = False
                If My.Settings.Regisztrált = False Then
                    uzenet = "nem teszt tanúsítványt használna teszt regisztráció esetén?"
                Else
                    uzenet = "teszt időbélyeg tanúsítványt használna éles regisztrációhoz? (kód:" & response & ")"
                End If

            End If
            If response = 8 Then uzenet = "aláíró folyamat "
            MyLoader.AddLogBook(Fnc.eal, "Az " & KivalasztottTipusNeve & " típusú tanúsítvány kiválasztásakor hibaüzenet (" & uzenet & ")", LogTip.err)
            Mit.CommonName = String.Empty
            Mit.Thumbprint = String.Empty

            Return False
        End If
    End Function

    Friend Function GetCommonNameSubject(subjectText As String) As String
        Dim subjectitems() = Split(subjectText, ", ")
        Dim response As String = String.Empty
        Dim CName As String = String.Empty
        For Each subjectitem As String In subjectitems
            If Strings.Left(subjectitem, 3) = "CN=" Then response = subjectitem.Substring(3)
        Next
        Return response
    End Function
    Sub LoadAlairofromSettings()
        If String.IsNullOrEmpty(My.Settings.SignCertDefault) Then
            'Trace.WriteLine("LoadAlairofromSettings_NullEmpty_signcertdef")
            Exit Sub
        End If

        Dim CertNeve As String = VanIlyenCertbyThumb(My.Settings.SignCertDefault)
        'Trace.WriteLine("LoadAlairofromSettings_VanIlyenCertbyThumb_alairo")
        If CertNeve = String.Empty Then
            Dim uzenet0 As String = String.Empty
            If My.Settings.Regisztrált = False Then uzenet0 = "Ellenőrizze, hogy esetleg nem teszt tanúsítványt használ-e teszt regisztráció esetén!"
            uzenet0 += "A betölteni kért aláíró típusú tanúsítvány nem található a gépen, így nem állítható be: " & My.Settings.SignCertDefault
            MyLoader.AddLogBook(Fnc.eal, uzenet0, LogTip.err)
        Else
            AlairoCert.CommonName = CertNeve
            AlairoCert.Thumbprint = My.Settings.SignCertDefault
        End If
        'Trace.WriteLine("PRE_LoadCertIntoXSign-alairocert")

        LoadCertIntoXSign(AlairoCert)

    End Sub

    Sub LoadTSfromSettings()
        If String.IsNullOrEmpty(My.Settings.TSACertDefault) Then Exit Sub
        Dim CertNeve As String = VanIlyenCertbyThumb(My.Settings.TSACertDefault)
        'Trace.WriteLine("VanIlyenCertbyThumb_TS")
        If CertNeve = String.Empty Then
            Dim uzenet0 As String = String.Empty
            If My.Settings.Regisztrált = False Then uzenet0 += "Ellenőrizze, hogy esetleg nem teszt tanúsítványt használ-e teszt regisztráció esetén!"
            uzenet0 += "A betölteni kért időbélyeg autentikációs típusú tanúsítvány nem található a gépen, így nem állítható be: " & My.Settings.TSACertDefault
            MyLoader.AddLogBook(Fnc.eal, uzenet0, LogTip.err)
        Else
            TSCert.CommonName = CertNeve
            TSCert.Thumbprint = My.Settings.TSACertDefault
        End If
        'Trace.WriteLine("PRE_LoadCertIntoXSign-ts_cert")

        LoadCertIntoXSign(TSCert)
    End Sub

    Sub CheckTSURLMicrosec()
        'TS jelszó vagy felhasználónév nincsen beállítva, de TSACert igen
        Dim jelszo As String = Kapukezelo.Decrypt(My.Settings.TSPW, "TSPW")
        Dim felhnev As String = Kapukezelo.Decrypt(My.Settings.TSUN, "TSUN")
        Dim MicrosecBocsatottaKi As Boolean = IssuedByMicrosec(My.Settings.TSACertDefault)
        Dim TSURLtipus As Integer = TSAURLfirst()
        If (String.IsNullOrEmpty(jelszo) Or
            String.IsNullOrEmpty(felhnev) AndAlso
            Not String.IsNullOrEmpty(My.Settings.TSACertDefault)) AndAlso
            MicrosecBocsatottaKi AndAlso
            TSURLtipus > 1 Then
            Dim response As MsgBoxResult = MsgBox("Microsec autentikációs tanúsítványt választott, de az időbélyeg URL nem ennek megfelelő." & Environment.NewLine & "Előfordulhat, hogy nem kap időbélyeget az eaktára. Beállítsa a program a megfelelő időbélyeg URL-t?", MsgBoxStyle.YesNo)
            If response = MsgBoxResult.Yes Then InsertTSUrlFirst(TSURLtipus, True)
        End If
        'és a TS URL-ben az első nem a TSA vagy a teszt.e-szigno.hu/tsa, akkor ezt jelzi, és jóváhagyás esetén gondoskodik róla, hogy a tsa legyen legelöl
        'TSACert nincsen beállítva, de TS jelszó és felhasználónév igen

        If String.IsNullOrEmpty(My.Settings.TSACertDefault) AndAlso Not String.IsNullOrEmpty(jelszo) Or
            Not String.IsNullOrEmpty(felhnev) AndAlso TSURLtipus < 2 Then
            Dim response As MsgBoxResult = MsgBox("Időbélyeg felhasználónevet vagy jelszót állított be, de időbélyeg tanúsítványt nem, ugyanakkor az első időbélyeg URL üres vagy a Microsec tanúsítvány alapú időbélyeg URL-je." & Environment.NewLine & "Előfordulhat, hogy nem kap időbélyeget az eaktára. Beállítsa a program a megfelelő időbélyeg URL-t?", MsgBoxStyle.YesNo)
            If response = MsgBoxResult.Yes Then InsertTSUrlFirst(TSURLtipus, False)
        End If
        '        If String.IsNullOrEmpty(My.Settings.TSACertDefault) AndAlso Not String.IsNullOrEmpty(jelszo) Or Not String.IsNullOrEmpty(felhnev) Then

    End Sub
    Function TSAURLfirst() As Integer
        Dim tsurlarray() As String = Split(My.Settings.TSURL, " ")
        Dim Keress As String = String.Empty
        If tsurlarray(0).Contains(MicrosecTSAUrl) Then Return 0
        If tsurlarray(0).Contains(MicrosecTSAUrlTeszt) Then Return 1
        If tsurlarray(0).Contains(MicrosecBTSAUrl) Then Return 2
        If tsurlarray(0).Contains(MicrosecBTSAUrlTeszt) Then Return 3
        If String.IsNullOrEmpty(tsurlarray(0).Replace(" ", "")) Then Return 4
        Return 5
    End Function

    Sub InsertTSUrlFirst(Hova As Integer, Cert As Boolean)
        Dim tsURLlist As New List(Of String)(My.Settings.TSURL.Split(" "c))
        Dim MitKeress As String = String.Empty
        Dim MireCsereld As String = String.Empty

        Select Case Hova
            Case 0
                MitKeress = MicrosecTSAUrl
                MireCsereld = MicrosecBTSAUrl
            Case 1
                MitKeress = MicrosecTSAUrlTeszt
                MireCsereld = MicrosecBTSAUrlTeszt
            Case 2
                MitKeress = MicrosecBTSAUrl
                MireCsereld = MicrosecTSAUrl
            Case 3
                MitKeress = MicrosecBTSAUrlTeszt
                MireCsereld = MicrosecTSAUrlTeszt
            Case 4 'Ha üres a TSURL
                If Cert = True Then My.Settings.TSURL = MicrosecTSAUrl
                If Cert = False Then My.Settings.TSURL = MicrosecBTSAUrl
                Dim response = SharedXSignSession.SetTimeStampURLs(My.Settings.TSURL)
                If response = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyeg URL beállítva", LogTip.norm)
                My.Settings.Save()
                Exit Sub
            Case 5
                If Cert = True Then
                    MitKeress = MicrosecTSAUrl
                    MireCsereld = MicrosecBTSAUrl
                Else
                    MitKeress = MicrosecBTSAUrl
                    MireCsereld = MicrosecTSAUrl
                End If
        End Select

        Dim HolVanMost = tsURLlist.IndexOf(MireCsereld)
        If HolVanMost >= 0 Then tsURLlist.RemoveAt(HolVanMost)
        tsURLlist.Insert(0, MireCsereld)

        Dim tsURLvissza As String = String.Empty
        For Each item As String In tsURLlist
            tsURLvissza += item + " "
        Next
        If Not tsURLvissza Is Nothing Then
            My.Settings.TSURL = tsURLvissza
            Dim response = SharedXSignSession.SetTimeStampURLs(My.Settings.TSURL)
            If response = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyeg URL beállítva", LogTip.norm)
            My.Settings.Save()
        End If

    End Sub


#End Region
#Region "Internet ellenőrzése"
    Friend Sub CheckInternetwLabelChange()
        If CheckInternet() = False Then
            MyLoader.InternetImg.Image = My.Resources.StatusAnnotations_Critical_16xLG_color
            InternetDisabled()
        Else
            MyLoader.InternetImg.Image = My.Resources.StatusAnnotations_Complete_and_ok_16xLG_color
            InternetEnabled()
            '#If MACCHECKBYMSEC = "N" Then
            'If RegChecked = True Then Exit Sub
            'If My.Settings.Regisztrált = False Then Exit Sub
            'Using WSReg As New RegSrv.eperHelperRegWS_ifClient
            '            Dim result As Boolean = False
            'Try
            '            result = WSReg.CheckMac(TknCheckMac, getAllMacAddresses)
            'If result = True Then MyLoader.AddLogBook(Fnc.cfg, "Sikeres hálózati kártya ellenőrzés", LogTip.norm)
            '            If result = False Then
            'Dim uzenet = "A regisztrációkor rögzített hálózati kártya nem található a futtató számítógépen! A program kilép" 
            '            MyLoader.AddLogBook(Fnc.cfg, uzenet, LogTip.err)
            'MsgBox(uzenet, MsgBoxStyle.Critical)
            '            Application.ExitThread()
            'Application.Exit(0)
            '        End If
            'Catch ex As Exception
            '            Dim uzenet2 = "Hálózati kártya ellenőrzési hiba! " & ex.Message
            'MyLoader.AddLogBook(Fnc.cfg, uzenet, LogTip.err)
            '            End Try
            'End Using
            '#End If
        End If
    End Sub
    Friend Function CheckInternet() As Boolean
        Try
            Using client = New System.Net.WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.cfg, "Internet hozzáférési hiba", LogTip.err)
            Return False
        End Try
    End Function

    Friend Sub InternetEnabled()
        '[Engedélyezések Internet megléte esetén]
        'TODO: Időbélyegzés enabled!
        NoInternet = False
        MyLoader.pnlSablonFrissítés.Enabled = True
        MyLoader.CheckUKP()
        MyLoader.CheckPKP()
        MyLoader.CheckHKP()
    End Sub
    Friend Sub InternetDisabled()
        '[Lockolások Internet hiánya esetén]
        'TODO: Időbélyegzés enabled!
        MyLoader.pnlSablonFrissítés.Enabled = False
        NoInternet = True
        MyLoader.pnlUgyfelkapu.Enabled = False
        MyLoader.pnlPerkapu.Enabled = False
        MyLoader.pnlHivatalikapu.Enabled = False
    End Sub

#End Region

#Region "JavaEllenorzes"

    Friend Sub RunJavaCheck()
        Dim CheckJavaRegistrySuccess As Boolean = False
        CheckJavaRegistrySuccess = CheckJavaRegistry()
        If CheckJavaRegistrySuccess = True Then
            MyLoader.AddLogBook(Fnc.cfg, "32 bites, 1.8 verzió fölötti Java VM telepítve (adatok registryből)", LogTip.norm)
            ANYKEnabled()
            JavaPath = GetJavaHome()
        Else
            Dim JavaVersionfromCmd As Version = JavaVersionCmd()
            If JavaVersionfromCmd.Major.ToString = "0" Then
                MyLoader.AddLogBook(Fnc.cfg, "Java VM úgy tűnik, hogy nincsen telepítve (sem registryből, sem pathból)", LogTip.err)
                If My.Settings.ErtesitNincsJava = True Then
                    MyLoader.PanelJava.Show()
                    ANYKDisabled()
                    Exit Sub
                End If
                If JavaVersionfromCmd > New Version("1.8") Then
                    MyLoader.AddLogBook(Fnc.cfg, "1.8 verzió fölötti Java VM telepítve (adatok pathból)", LogTip.norm)
                    ANYKEnabled()
                    JavaPath = GetJavaHome()
                End If
            End If
        End If
    End Sub

    Friend Function GetJavaHome() As String
        Dim JavaHome As String = String.Empty
        Dim readValue As Object
        Dim RegPath As String = String.Empty

        If System.Environment.Is64BitOperatingSystem Then
            RegPath = "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\JavaSoft\Java Runtime Environment"
        Else RegPath = "HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Runtime Environment"
        End If
        readValue = My.Computer.Registry.GetValue(RegPath, "CurrentVersion", Nothing)
        If Not String.IsNullOrEmpty(readValue) Then
            Try
                JavaHome = My.Computer.Registry.GetValue(RegPath + "\" + readValue, "JavaHome", Nothing)
            Catch ex As Exception
            End Try
            If JavaHome = "" Then JavaHome = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & Path.DirectorySeparatorChar & "Oracle" & Path.DirectorySeparatorChar & "Java" & Path.DirectorySeparatorChar & "javapath"
        Else
            JavaHome = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & Path.DirectorySeparatorChar & "Oracle" & Path.DirectorySeparatorChar & "Java" & Path.DirectorySeparatorChar & "javapath"
        End If

        Dim JavaByStdInstallPlace = JavaHome & Path.DirectorySeparatorChar & "bin" & Path.DirectorySeparatorChar & "java.exe"
        If File.Exists(JavaByStdInstallPlace) Then
            JavaHome = JavaByStdInstallPlace
        Else
            JavaHome = ""
        End If
        Return JavaHome
    End Function

    Friend Function CheckJavaRegistry() As Boolean
        Dim readValue As Object
        readValue = CheckHKLMJREVersion()

        If readValue Is Nothing Then
            Dim path = Environment.GetEnvironmentVariable("path")
            MyLoader.AddLogBook(Fnc.cfg, "Java nincsen telepítve", LogTip.norm)
            Return False
        End If

        Dim thisVersion As New Version(readValue)
        If thisVersion < New Version("1.8") Then
            MyLoader.AddLogBook(Fnc.cfg, "Telepített Java verzió 1.8 alatti", LogTip.norm)
            Return False
        Else
            Return True
        End If

    End Function

    Friend Function CheckHKLMJREVersion() As Object
        Dim readValue As Object
        Dim RegPath As String = ""

        If System.Environment.Is64BitOperatingSystem Then
            RegPath = "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\JavaSoft\Java Runtime Environment"
        Else RegPath = "HKEY_LOCAL_MACHINE\SOFTWARE\JavaSoft\Java Runtime Environment"
        End If
        readValue = My.Computer.Registry.GetValue(RegPath, "CurrentVersion", Nothing)
        Return readValue
    End Function

    Friend Function JavaVersionCmd() As Version
        Dim ok As Boolean = False
        Dim process As New Process()
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.Arguments = "/c """ + "java -version " + """"
        process.Start()
        Dim ErrorString = process.StandardError.ReadLine
        process.WaitForExit()
        ok = (process.ExitCode = 0)
        process.Close()
        Dim response As String = ErrorString.Replace(Chr(34), String.Empty).Replace("java version", "").Replace("_", ".")
        'Trace.WriteLine("JavaVersionResponse=" & response)
        Dim resVer As New Version
        Try
            resVer = New Version(response)
        Catch ex As Exception
        End Try
        Return resVer

    End Function


#End Region

#Region "ÁNYK ellenőrzés"


    Friend Sub ANYKEnabled()
        My.Settings.JavaDisabled = False
        My.Settings.Save()
        MyLoader.pnlExtract.Enabled = True
#If Not DEBUG Then
        If My.Settings.Regisztrált = False Then MyLoader.extractkr.Enabled = False
#End If
        MyLoader.pnlKRbeküldésrecsomagol.Enabled = True
        MyLoader.pnlExtract.Enabled = True
        MyLoader.pnlMegtekintesANYKban.Enabled = True
        MyLoader.pnlPDFnyomtatvanybol.Enabled = True
        MyLoader.pnlMegtekintesANYKban.Enabled = True
        MyLoader.sablonfrissitegyszer.Enabled = True
        'MyLoader.Ujnyomtatvanytorzsadattal.Enabled = True
        MyLoader.btnListázniRibbonbol.Enabled = True
        MyLoader.XKRXCZTársít.Enabled = True
        MyLoader.ÁNYKoszlopoknyitáshoz.Enabled = True
        MyLoader.btnAVDHesKapuNoticeKi.Enabled = True

        eroforrasok = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "eroforrasok" & Path.DirectorySeparatorChar
        nyomtatvanyok = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "nyomtatvanyok" & Path.DirectorySeparatorChar

    End Sub

    Friend Sub ANYKDisabled()
        My.Settings.JavaDisabled = True
        My.Settings.Save()
        MyLoader.pnlKRbeküldésrecsomagol.Enabled = False
        MyLoader.pnlExtract.Enabled = False
        MyLoader.pnlMegtekintesANYKban.Enabled = False
        MyLoader.pnlPDFnyomtatvanybol.Enabled = False
        MyLoader.pnlMegtekintesANYKban.Enabled = False
        MyLoader.sablonfrissitegyszer.Enabled = False
        'MyLoader.Ujnyomtatvanytorzsadattal.Enabled = False
        MyLoader.btnListázniRibbonbol.Enabled = False
        MyLoader.XKRXCZTársít.Enabled = False
        MyLoader.ÁNYKoszlopoknyitáshoz.Enabled = False
        MyLoader.btnAVDHesKapuNoticeKi.Enabled = False
    End Sub

    Friend Sub RunANYKCheck()
        Dim ANYKfuttatofromcfg As String = True
        Dim ANYKInstalled As Boolean = False
        If (My.Settings.JavaDisabled = True) And (My.Settings.ErtesitNincsJava = False) Then
            ANYKDisabled()
            Exit Sub
        End If
        'Továbbengedés=ANYKfuttatas=exists & correct, ANYCfgDir=exists & correct
        'If Not Directory.Exists(My.Settings.ANYKCfgDir) Then My.Settings.ANYKCfgDir = "" : My.Settings.Save()
        'If Not File.Exists(My.Settings.ANYKCfgDir & Path.DirectorySeparatorChar & "abevjavapath.cfg") Then My.Settings.ANYKCfgDir = "" : My.Settings.Save()
        'If My.Settings.ANYKCfgDir = "" Then
        ResetANYKSettings()
        'Trace.WriteLine("ResetANYKSettings")
        ANYKInstalled = CheckAnykInstalledNoCfg()
        'ANYKCfgDir csak akkor nincsen innentől beállítva, ha nincsen telepítve sem
        If ANYKInstalled = False Then
            'Nincsen telepítve az ÁNYK
            'Ha be volt már eddig állítva az, hogy ne jelezze, akkor már az elején kilépett
            MyLoader.PanelANYK.Show()
            ANYKDisabled()
            Exit Sub
            'Ha telepítette és az újraellenőrzés sikeres volt, akkor a JavaDisabled False lesz, és már be van állítva az ANYKCfgDir és a futtató is [CheckAnykInstalledNoCfg alapján].
        End If
        CheckAnykInstalledBasedonMySettingsANYKfuttatas()
        'Trace.WriteLine("CheckAnykInstalledBasedonMySettingsANYKfuttatas")
        'Ha My.Settings.ANYKCfgDir üres, de az ANYKInstalled=True a CheckAnyInstalledNoCfg alapján, így feltételezhetjük, hogy helyes az ANYKCfgDir és a futtató tartalma is
        ParamTextFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & Path.DirectorySeparatorChar & ".abevjava" & Path.DirectorySeparatorChar & Environment.UserName & ".enyk"
        RunOtherANYKFolderSettingsCheck()
        'Trace.WriteLine("RunOtherANYKFolderSettingsCheck")
        MyLoader.AddLogBook(Fnc.cfg, "ÁNYK konfiguráció beállítva", LogTip.norm)
        ANYKmemoryFix()
    End Sub
    Private Sub ResetANYKSettings()
        My.Settings.ANYK_abevjavapath_cfg_Dir = ""
        My.Settings.mappaANYKadat = ""
        My.Settings.mappaANYKfuttatas = ""
        My.Settings.mappaANYKmentes = ""
        My.Settings.mappaANYKkuldendo = ""
        My.Settings.mappaANYKelkuldott = ""
    End Sub
    Friend Function CheckAnykInstalledNoCfg() As Boolean
        'Ha True a válasz = van egy My.Settings.ANYKCfgDir és a futtató is, és mindkettő helyes, mert oda telepitve van az ÁNYK két fő fájlja
        'Ha False a válasz = nem talált konfigurációs fájlt a beállítások alapján - feltételezi, hogy azért, mert nincsen odatelepítve az ÁNYK

        Dim result As Boolean = False
        Dim WindirCfgFile As String = Environ("WINDIR") & Path.DirectorySeparatorChar & "abevjavapath.cfg"
        Dim ANYKPathWinDir As String = GetANYKRootPathfromDir(WindirCfgFile)
        '^Ha admin joggal telepítjük, ide, ebbe a fájlba teszi a futtatási root könyvtárát. Ez azt is jelenti, hogy root joggal fut az egész ÁNYK (felhasználható még a Registry-knél?)
        Dim UserCfgFile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & Path.DirectorySeparatorChar & ".abevjava" & Path.DirectorySeparatorChar & "abevjavapath.cfg"
        Dim ANYKPathUsers As String = GetANYKRootPathfromDir(UserCfgFile)

        Dim ANYKPathReg As String = GetANYKRootPathfromReg()
        '^Erre általában nincsen szükség, mert ezt csak a telepítés utáni társítás .vbs társítja be. Azonban az ÁNYK törlésekor ezt általában nem távolítják el, így ott maradhat akkor is, ha már nincsen az ÁNYK telepítve.
        'Csak akkor hívjuk, ha az így megadott könyvtárban még elérhető az abevjava_start.bat és az abevjava.jar, és egyébként valamiért sem a Windir, sem a Users szerinti ÁNYK nem érhető el.
        'Az ÁNYK ilyenkor is képes elindulni, bár ilyenkor a korábbi konfigurációs beállítások elveszhetnek.

        If ANYKPathUsers <> String.Empty AndAlso ANYKInstalledInThisDirectory(ANYKPathUsers) Then
            My.Settings.mappaANYKfuttatas = ANYKPathUsers
            My.Settings.ANYK_abevjavapath_cfg_Dir = Path.GetDirectoryName(UserCfgFile)
            My.Settings.Save()
            Return True
        End If

        If ANYKPathWinDir <> String.Empty AndAlso ANYKInstalledInThisDirectory(ANYKPathWinDir) Then
            My.Settings.mappaANYKfuttatas = ANYKPathWinDir
            My.Settings.ANYK_abevjavapath_cfg_Dir = Path.GetDirectoryName(WindirCfgFile)
            My.Settings.Save()
            Return True
        End If

        If ANYKPathReg <> String.Empty AndAlso ANYKInstalledInThisDirectory(ANYKPathReg) Then
            My.Settings.mappaANYKfuttatas = ANYKPathReg
            My.Settings.ANYK_abevjavapath_cfg_Dir = Path.GetDirectoryName(UserCfgFile)
            '^Ez esetben az ÁNYK indításakor fog csak létrejönni a konfigurációs fájl, addig az alapértelmezett lesz minden érték
            My.Settings.Save()
            Return True
        End If
        Return False

    End Function
    Friend Function GetANYKRootPathfromDir(CfgFile As String) As String
        Dim result As String = ""
        Try
            result = ReadParamText(CfgFile, "abevjava.path")
        Catch ex As Exception
        End Try
        Return result
    End Function
    Friend Function GetANYKRootPathfromReg() As String
        Dim RegPath As String = ""
        Dim readValue As String = ""
        Dim ANYKPath As String = ""
        RegPath = "HKEY_CURRENT_USER\Software\Classes\anyk_xkr\shell\open\command\"
        readValue = My.Computer.Registry.GetValue(RegPath, Nothing, Nothing)
        If readValue IsNot Nothing Then
            Dim TempStr() As String = readValue.Split(""""c)
            ANYKPath = TempStr(1)
            ANYKPath = Path.GetDirectoryName(ANYKPath)
        End If
        Return ANYKPath
    End Function
    Friend Function ANYKInstalledInThisDirectory(CheckPath As String) As Boolean
        If ((File.Exists(CheckPath & Path.DirectorySeparatorChar & abevjavaindito) And (File.Exists(CheckPath & Path.DirectorySeparatorChar & "abevjava.jar")))) Then Return True Else Return False
    End Function
    Friend Sub RunOtherANYKFolderSettingsCheck()
        'Biztosítja, hogy a My.Settings-ben az elérhető és ellenőrizhető könyvtárak vannak megadva. Ha nem, frissíti.
        'Először ellenőrizzük, hogy be van-e állítva a My.Settingsben.
        'Ha be van állítva, és az ÁNYK beállítás is lekérdezhető és működik, de a kettő nem azonos, akkor töltse be az ÁNYK config szerinti tartalmat
        'Ha nincsen beállítva a My.Settings, és az ÁNYK sem kérdezhető le, akkor alapértelmezett fájlneveket beállít (csak a program számára)
        Dim ANYKadatFromANYKCfg As String = String.Empty, ANYKmentesFromCfg As String = String.Empty, ANYKkuldendoFromEnviron As String = String.Empty, ANYKElkuldottFromEnviron As String = String.Empty
        Dim ANYKKuldendoFromeKuldes As String = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "eKuldes" & Path.DirectorySeparatorChar & "KR" & Path.DirectorySeparatorChar & "kuldendo"
        Dim ANYKElkuldottFromeKuldes As String = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "eKuldes" & Path.DirectorySeparatorChar & "KR" & Path.DirectorySeparatorChar & "elkuldott"
        Dim ANYKadatDefault As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & Path.DirectorySeparatorChar & "abevjava"
        'Trace.WriteLine("ANYKadatDefault=" & ANYKadatDefault)
        Dim ANYKmentesDefault As String = ANYKadatDefault & Path.DirectorySeparatorChar & "mentesek"

        If File.Exists(ParamTextFile) Then
            ANYKadatFromANYKCfg = ReadParamText(ParamTextFile, "prop.usr.root", EncodingUsed:=Text.Encoding.Default)
            ANYKmentesFromCfg = ANYKadatFromANYKCfg & Path.DirectorySeparatorChar & ReadParamText(ParamTextFile, "prop.usr.saves", EncodingUsed:=Text.Encoding.Default)
            'Trace.WriteLine("ANYKmentesFromCfg=" & ANYKmentesFromCfg)
            Dim KRDIR As String = String.Empty
            Try
                KRDIR = Environment.GetEnvironmentVariable("KRDIR").Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar) & Path.DirectorySeparatorChar
            Catch ex As Exception
                KRDIR = ANYKadatDefault & Path.DirectorySeparatorChar
            End Try
            ANYKkuldendoFromEnviron = KRDIR & ReadParamText(ParamTextFile, "prop.usr.ds_dest", EncodingUsed:=Text.Encoding.Default).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
            ANYKElkuldottFromEnviron = KRDIR & ReadParamText(ParamTextFile, "prop.usr.ds_sent", EncodingUsed:=Text.Encoding.Default).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
            ANYKkuldendoFromEnviron = KRDIR & ReadParamText(ParamTextFile, "prop.usr.ds_dest", EncodingUsed:=Text.Encoding.Default).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
            ANYKElkuldottFromEnviron = KRDIR & ReadParamText(ParamTextFile, "prop.usr.ds_sent", EncodingUsed:=Text.Encoding.Default).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
        End If

        If Directory.Exists(ANYKadatFromANYKCfg) Then
            My.Settings.mappaANYKadat = ANYKadatFromANYKCfg
        ElseIf Directory.Exists(ANYKadatDefault) Then
            MyLoader.AddLogBook(Fnc.cfg, "Hiányzó paraméter fájl vagy az ott meghatározott könyvtár nem létezik (data; " & ParamTextFile & "; " & ANYKadatFromANYKCfg & "), alapértelmezett beállítást próbálok alkalmazni", LogTip.err)
            My.Settings.mappaANYKadat = ANYKadatDefault

        Else
            MyLoader.AddLogBook(Fnc.cfg, "Nem találtam létező adatkönyvtárat! A program hibásan fog működni! Telepítse újra az ÁNYK-t vagy hozza létre kézzel az alábbi könyvtárat:" & ANYKadatDefault, LogTip.err)
        End If

        If Directory.Exists(ANYKmentesFromCfg) Then
            My.Settings.mappaANYKmentes = ANYKmentesFromCfg
        ElseIf Directory.Exists(ANYKmentesDefault) Then
            MyLoader.AddLogBook(Fnc.cfg, "Hiányzó paraméter fájl vagy az ott meghatározott könyvtár nem létezik (mentes; " & ParamTextFile & "; " & ANYKmentesFromCfg & "), alapértelmezett beállítást próbálok alkalmazni", LogTip.err)
            My.Settings.mappaANYKmentes = ANYKmentesDefault
        Else
            MyLoader.AddLogBook(Fnc.cfg, "Nem találtam létező mentési könyvtárat! A program hibásan fog működni! Telepítse újra az ÁNYK-t vagy hozza létre kézzel az alábbi könyvtárat:" & ANYKmentesDefault, LogTip.err)
        End If

        If Directory.Exists(ANYKkuldendoFromEnviron) Then
            My.Settings.mappaANYKkuldendo = ANYKkuldendoFromEnviron
        ElseIf Directory.Exists(ANYKKuldendoFromeKuldes) Then
            MyLoader.AddLogBook(Fnc.cfg, "Hiányzó környezeti beállítás vagy az ott meghatározott könyvtár nem létezik (kuldendo; " & ParamTextFile & "; " & ANYKkuldendoFromEnviron & "), alapértelmezett beállítást próbálok alkalmazni", LogTip.err)
            My.Settings.mappaANYKkuldendo = ANYKKuldendoFromeKuldes
        Else
            MyLoader.AddLogBook(Fnc.cfg, "Nem találtam létező kuldendo könyvtárat! A program hibásan fog működni! Telepítse újra az ÁNYK-t vagy hozza létre kézzel az alábbi könyvtárat:" & ANYKkuldendoFromEnviron, LogTip.err)
        End If

        If Directory.Exists(ANYKElkuldottFromEnviron) Then
            My.Settings.mappaANYKelkuldott = ANYKElkuldottFromEnviron

        ElseIf Directory.Exists(ANYKElkuldottFromeKuldes) Then
            MyLoader.AddLogBook(Fnc.cfg, "Hiányzó környezeti beállítás vagy az ott meghatározott könyvtár nem létezik (elkuldott; " & ParamTextFile & "; " & ANYKElkuldottFromEnviron & "), alapértelmezett beállítást próbálok alkalmazni", LogTip.err)
            My.Settings.mappaANYKelkuldott = ANYKElkuldottFromeKuldes

        Else
            MyLoader.AddLogBook(Fnc.cfg, "Nem találtam létező kuldendo könyvtárat! A program hibásan fog működni! Telepítse újra az ÁNYK-t vagy hozza létre kézzel az alábbi könyvtárat:" & ANYKElkuldottFromEnviron, LogTip.err)
        End If

        My.Settings.Save()
    End Sub

    Friend Function CheckAnykInstalledBasedonMySettingsANYKfuttatas() As Boolean
        Dim result As Boolean = False
        'Először azt ellenőrzi, hogy van-e ÁNYK futtató könyvtár megadva. Ha igen, ellenőrzi, hogy ott van-e az ÁNYK két fájlja telepítve. Ha igen, visszaadja, hogy "True".
        'Ha csak Cfg van vagy nem jó a futtató, akkor törli a futtató beállítást, és az ÁNYK-ból megpróbálja kinyerni a futtathatót, és ha a kinyert futtatható ott van, visszaadja, hogy True
        'Ha hibás az ÁNYK config is, akkor CheckAnykInstalledNoCfg(), ha az sem vezet eredményre, akkor hibajelzéssel kilép.
        If My.Settings.mappaANYKfuttatas = String.Empty Or ANYKInstalledInThisDirectory(My.Settings.mappaANYKfuttatas) = False Then
            result = ConfigANYKfuttatasfromANYKCfgFile()
            If result = False Then DirSettingError() : QuitMe()
        End If
        Return True
    End Function

    Sub DirSettingError()
        Dim hiba As String = "Könyvtárbeállítási hiba. Cfg=" & My.Settings.ANYK_abevjavapath_cfg_Dir & " . Futtató=" & My.Settings.mappaANYKfuttatas
        MyLoader.AddLogBook(Fnc.cfg, hiba, LogTip.err)
        MsgBox(hiba & ". Az alkalmazás kilép.")
    End Sub
    Function ConfigANYKfuttatasfromANYKCfgFile() As Boolean
        My.Settings.mappaANYKfuttatas = ReadParamText(My.Settings.ANYK_abevjavapath_cfg_Dir & Path.DirectorySeparatorChar & "abevjavapath.cfg", "abevjava.path")
        If My.Settings.mappaANYKfuttatas <> "" And ANYKInstalledInThisDirectory(My.Settings.mappaANYKfuttatas) Then
            My.Settings.Save()
            Return True
        Else
            Return CheckAnykInstalledNoCfg()
        End If
    End Function


    Friend Sub RunANYKParamNyomCheck()
        Dim dialogpopup As Boolean = False
        '        Trace.WriteLine("#1")
        If My.Settings.ErtesitVanNyomtatvany = 0 Then MyLoader.AllStartRefresh.Checked = True Else MyLoader.AllStartRefresh.Checked = False
        If My.Settings.ErtesitVanNyomtatvany = 1 Then MyLoader.FreshStartRefresh.Checked = True Else MyLoader.FreshStartRefresh.Checked = False
        If My.Settings.ErtesitVanNyomtatvany = 2 Then MyLoader.FresherthanInstalledStartRefresh.Checked = True Else MyLoader.FresherthanInstalledStartRefresh.Checked = False
        If My.Settings.ErtesitVanNyomtatvany = 3 Then MyLoader.rbcbProgramSupportedRefresh.Checked = True Else MyLoader.rbcbProgramSupportedRefresh.Checked = False
        'Trace.WriteLine("#2")
        If My.Settings.ErtesitVanNyomtatvany > 3 Or My.Settings.ErtesitVanNyomtatvany < 0 Then Exit Sub
        '       Trace.WriteLine("#3")
        Dim Mit As SablonTelepitettOption = My.Settings.ErtesitVanNyomtatvany
        'Trace.WriteLine("#4: " & Mit.ToString)
        Dim mittoltok As String = String.Empty
        Dim NyomtatvanyToDL As New DataTable
        Dim XMLResponse As String = LetoltesNyomtatvanyTabla("OBHGEPI")
        'Trace.WriteLine("#11")
        If XMLResponse <> "" Then
            If My.Settings.ErtesitVanNyomtatvany = 0 Then
                mittoltok = "minden elérhető nyomtatványverzió, régiek Is"
            End If
            If My.Settings.ErtesitVanNyomtatvany = 1 Then
                'Mit = SablonTelepitettOption.CsakUjabbElerhetot
                mittoltok = "az elérhető frissebb nyomtatványverziók"
            End If
            If My.Settings.ErtesitVanNyomtatvany = 2 Then
                'Mit = SablonTelepitettOption.CsakUjabbEsTelepitveElozmeny
                mittoltok = "a telepítettből elérhető újabb nyomtatványverziók"
            End If
            If My.Settings.ErtesitVanNyomtatvany = 3 Then
                'Mit = SablonTelepitettOption.ProgrambanElerhetot
                mittoltok = "a telepítettből elérhető újabb nyomtatványverziók"
            End If
            'Trace.WriteLine("#12")
            NyomtatvanyToDL = NyomXMLandTelepitettCompare(XMLResponse, My.Settings.ErtesitVanNyomtatvany) 'Vagy Mit?

            If ElerhetoEllenorzese(NyomtatvanyToDL).Count > 0 Then dialogpopup = True
        End If
        If XMLResponse = String.Empty Then
            Dim uzenet As String = "A frissítési forrás nem hozzáférhető. Próbálja meg a " & NyomiWebURL & " címen ellenőrizni"
            MyLoader.AddLogBook(Fnc.cfg, uzenet, LogTip.err)
        End If
        If dialogpopup = False And XMLResponse <> "" Then MyLoader.AddLogBook(Fnc.cfg, "Az OBHGEPI nyomtatványból az elérhető verziók telepítve vannak (" & mittoltok & ")", LogTip.norm)
        If dialogpopup = True Then MyLoader.PanelNyomtatvany.Show()
        'Egyéb szervezeteket ide kell írni, ha majd letöltjük
    End Sub

    Friend Sub ANYKMappaVisszaSub()
        'Ha nem tartalmaz _tmp_-t az ÁNYK mentési mappa, lépjen ki, ne állítson helyre semmit
        Dim root As String = ReadParamText(ParamTextFile, "prop.usr.root", EncodingUsed:=Text.Encoding.Default)
        If Not My.Settings.mappaANYKmentes.Contains("_tmp_") And Not root.Contains("_tmp_") Then Exit Sub
        If My.Settings.mappaANYKmentesBackup = String.Empty Then Exit Sub

        Dim ANYKadatFromANYKCfg As String = ReadParamText(ParamTextFile, "prop.usr.root", EncodingUsed:=Text.Encoding.Default)
        Dim nowDir As String = ANYKadatFromANYKCfg.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar) & Path.DirectorySeparatorChar & ReadParamText(ParamTextFile, "prop.usr.saves", EncodingUsed:=Text.Encoding.Default).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
        If My.Settings.mappaANYKmentesBackup <> nowDir And Directory.Exists(My.Settings.mappaANYKmentesBackup) Then
            If Not Directory.Exists(root) Then
                MyLoader.AddLogBook(Fnc.cfg, "Hiba: a beolvasott root könyvtár nem található: " & root, LogTip.err)
                RunOtherANYKFolderSettingsCheck()
            End If
            Dim tolose As String = root.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar) & Path.DirectorySeparatorChar
            Dim value As String = Strings.Replace(My.Settings.mappaANYKmentesBackup, tolose, String.Empty)
            Dim valasz As Boolean = ChangeParamText(ParamTextFile, "prop.usr.saves", value, False, "windows-1250")
            If valasz = True Then MyLoader.AddLogBook(Fnc.cfg, "Sikeresen visszamódosítva az ÁNYK mentési mappa " & nowDir & "-ről " & My.Settings.mappaANYKmentesBackup & "-re (" & value & ")", LogTip.siker) Else MyLoader.AddLogBook(Fnc.cfg, "Nem sikerült az ÁNYK mentési mappát visszaállítani " & nowDir & "-ről " & My.Settings.mappaANYKmentesBackup & "-re (" & value & ")", LogTip.err)
        Else
            Dim valasz As Boolean = ChangeParamText(ParamTextFile, "prop.usr.saves", "mentesek", False, "windows-1250")
            If valasz = True Then MyLoader.AddLogBook(Fnc.cfg, "Sikeresen visszamódosítva az ÁNYK mentési mappa " & nowDir & "-ről mentesek-re", LogTip.siker) Else MyLoader.AddLogBook(Fnc.cfg, "Nem sikerült az ÁNYK mentési mappát visszaállítani " & nowDir & "-ről mentesek-re", LogTip.err)
            My.Settings.mappaANYKmentes = root.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar) & Path.DirectorySeparatorChar & "mentesek"
        End If
        My.Settings.mappaANYKmentesBackup = ""
        My.Settings.Save()
        Try
            Directory.Delete(nowDir)
        Catch ex As Exception
        End Try
    End Sub

    Friend Function LetoltesNyomtatvanyTabla(Ki As String) As String
        'Trace.WriteLine("#5: LetoltesNyomtatvanyTabla" & Ki)
        Dim LatestResFile As String
        LatestResFile = LatestResources(Ki)
        If Ki = "OBHGEPI" And LatestResFile = "" Then
            WriteResourceToFile(eroforrasok & Ki & "Resources_v1.4.jar", OBHGEPIResources_v1_4)
            MyLoader.AddLogBook(Fnc.cfg, "Nem volt telepítve az " & Ki & "Resources_v1.4.jar a megadott könyvtárba (" & eroforrasok & ").Bemásolva", LogTip.siker)
            LatestResFile = eroforrasok & Ki & "Resources_v1.4.jar"
        End If
        Dim OBHorginfo As String = Path.GetTempFileName
        GetFromJarAll(LatestResFile, "orginfo.xml", OBHorginfo)
        Dim UpdateURL As String = GetParamFromXML(OBHorginfo, "updateurl")
        Try
            File.Delete(OBHorginfo)
        Catch ex As Exception
        End Try
        'Trace.WriteLine("#9")
        Dim XMLResponse As String = DownloadUpdateXML(UpdateURL)
        'Trace.WriteLine("#10")
        Return XMLResponse
    End Function

    Friend Function ElerhetoEllenorzese(datatable As DataTable) As List(Of String)
        Dim response As Boolean = False
        Dim telepList As New List(Of String)
        If datatable.Rows.Count > 0 Then
            response = True
            For Each row In datatable.Rows
                telepList.Add(row("name") + "_v" + (row("ver").ToString))
            Next
        End If
        Return telepList
    End Function

    Friend Function LatestResources(Ki As String) As String
        Dim FileColl As String()
        Dim FileList As New List(Of String)
        Dim FileListSng As New List(Of Version)
        'Trace.WriteLine("#6B: " & eroforrasok & "; Ki=" & Ki)
        FileColl = System.IO.Directory.GetFiles(eroforrasok, Ki & "Resources*.jar")
        FileList = FileColl.ToList
        'Trace.WriteLine("#7: " & Strings.Join(FileColl, ", "))
        For Each line In FileList
            'Trace.WriteLine("#7/A:" & line)
            line = Path.GetFileNameWithoutExtension(line)
            'Trace.WriteLine("#7/B:" & line)
            line = line.Replace(Ki & "Resources_v", "")
            Try
                FileListSng.Add(New Version(line))
            Catch ex As Exception
            End Try
        Next
        FileListSng.Sort()
        If FileListSng.Count > 0 Then Return eroforrasok & Ki & "Resources_v" & FileListSng.Last.ToString & ".jar" Else Return ""
        'Trace.WriteLine("#8")
    End Function

    Friend Function GetParamFromXML(XMLFile As String, AttributeName As String)
        Dim root As XDocument = XDocument.Load(XMLFile)
        If AttributeName = "updateurl" Then
            Dim childList As IEnumerable(Of XElement) =
            From el In root.<szervezet> Where el.@updateurl <> Nothing Select el
            If childList.ToArray.Length = 0 Then Return "" Else Return childList.First.@updateurl
        ElseIf AttributeName = "certfilename" Then
            Dim childList As IEnumerable(Of XElement) =
            From el In root.<szervezet> Where el.@certfilename <> Nothing Select el
            If childList.ToArray.Length = 0 Then Return "" Else Return childList.First.@certfilename
        Else Return ""
        End If
    End Function
    'Sub CreateandPopulateTelepitettNyomtatvanyok()
    '   TelepitettNyomtatvanyok = New DataTable("TelepitettNyomtatvanyok")
    '  TelepitettNyomtatvanyok = PopulateTelepitettNyomtatvanyok()
    'End Sub
    Function CreateTelepitettNyomtatvanyokDT() As DataTable
        Dim Result As New DataTable
        Dim dc0 As New DataColumn("filename", GetType(String))
        Dim dc1 As New DataColumn("org", GetType(String))
        Dim dc2 As New DataColumn("name", GetType(String))
        Dim dc3 As New DataColumn("ver", GetType(Version))
        Dim dc4 As New DataColumn("info", GetType(String))
        Dim dc5 As New DataColumn("category", GetType(String))
        Dim dc6 As New DataColumn("sourcejar", GetType(String))
        Result.Columns.Add(dc0)
        Result.Columns.Add(dc1)
        Result.Columns.Add(dc2)
        Result.Columns.Add(dc3)
        Result.Columns.Add(dc4)
        Result.Columns.Add(dc5)
        Result.Columns.Add(dc6)
        Return Result
    End Function

    Function PopulateTelepitettNyomtatvanyok() As DataTable
        Dim kezdet As TimeSpan = Now.TimeOfDay
        Dim FileList As List(Of String) = System.IO.Directory.GetFiles(nyomtatvanyok, "OBHGEPI_*.tem.enyk").ToList
        Dim ReturnTable As New DataTable
        ReturnTable = CreateTelepitettNyomtatvanyokDT()

        For Each toProc In FileList
            Dim mroot As XDocument = XDocument.Load(toProc)
            Dim mchildList As IEnumerable(Of XElement) = From el In mroot...<DOCINFO> Select el
            For Each e As XElement In mchildList
                Dim workRow As DataRow = ReturnTable.NewRow()
                'workRow("filename") = toProc
                workRow("org") = e.@org
                workRow("name") = e.@name
                workRow("ver") = New Version(e.@ver)
                workRow("info") = e.@info
                workRow("category") = e.@category
                workRow("sourcejar") = ""
                ReturnTable.Rows.Add(workRow)
            Next
            '            ReturnTable.AcceptChanges()
        Next
        ReturnTable.DefaultView.Sort = "name ASC, ver DESC"
        'ReturnTable.AcceptChanges()

        Dim vege As TimeSpan = Now.TimeOfDay
        Dim diff As TimeSpan = vege - kezdet
        MyLoader.AddLogBook(Fnc.nyomdl, "Nyomtatványsablonok frissítése befejeződött: " & diff.ToString, LogTip.norm)
        MyLoader.ProgressBar1.Value = 0

        Return ReturnTable
    End Function
    Friend Function NyomXMLandTelepitettCompare(XMLString As String, MitFrissitsen As SablonTelepitettOption) As DataTable
        'Trace.WriteLine("#20")

        If TelepitettNyomtatvanyok.Rows.Count = 0 Then TelepitettNyomtatvanyok = PopulateTelepitettNyomtatvanyok()

        Dim LetolthetoNyomtatvanyok As DataTable = LetolthetoNyomfromXML(XMLString)
        LetolthetoNyomtatvanyok.DefaultView.Sort = "name ASC, ver DESC"
        'LetolthetoNyomtatvanyok.AcceptChanges()

        Dim kezdet As TimeSpan = Now.TimeOfDay
        'Trace.WriteLine("#21")

        Dim HighestVersionLetoltheto As DataTable = HighestVersion(LetolthetoNyomtatvanyok)
        'Trace.WriteLine("#22")
        HighestVersionLetoltheto.CaseSensitive = False
        Dim HighestVersionTelepitett As DataTable = HighestVersion(TelepitettNyomtatvanyok)
        'Trace.WriteLine("#23")

        Dim foundTelepitettinLetolthetoRows() As Data.DataRow
        'Trace.WriteLine("#24")

        Dim foundLetolthetoinTelepitettRows() As Data.DataRow
        'Trace.WriteLine("#25")

        Dim ReturnLetoltendoRows As DataTable = CreateTelepitettNyomtatvanyokDT() 'A letöltendőket kell, hogy majd tartalmazza
        '        Trace.WriteLine("#26")

        If MitFrissitsen = SablonTelepitettOption.CsakUjabbEsTelepitveElozmeny Then
            '           Trace.WriteLine("#27")

            'Csak a már telepített sablonokat hasonlítsa össze a letölthető sablonokkal, és csak azt tölti le, ami egy már telepítettnél újabb
            For Each row As DataRow In HighestVersionTelepitett.Rows
                foundLetolthetoinTelepitettRows = HighestVersionLetoltheto.Select("name = '" & row("name") & "'")
                If foundLetolthetoinTelepitettRows.Count > 0 Then
                    Dim workRow As DataRow = ReturnLetoltendoRows.NewRow()
                    workRow = foundLetolthetoinTelepitettRows.First
                    If workRow("ver") > row("ver") Then ReturnLetoltendoRows.ImportRow(workRow)
                End If
            Next
        End If

        If MitFrissitsen = SablonTelepitettOption.CsakUjabbElerhetot Then
            'Trace.WriteLine("#28")

            'A még nem telepített sablonokat is gyűjtse ki, de csak a legújabbakat
            For Each highestletolthetoRow As DataRow In HighestVersionLetoltheto.Rows
                foundTelepitettinLetolthetoRows = HighestVersionTelepitett.Select("name = '" & highestletolthetoRow("name") & "'")
                If foundTelepitettinLetolthetoRows.Count = 0 Then
                    Dim workRow As DataRow = ReturnLetoltendoRows.NewRow()
                    ReturnLetoltendoRows.ImportRow(highestletolthetoRow)
                    'Ha a letölthetők legmagasabb verziójában van olyan nevű sablon, ami nincsen telepítve, akkor töltse le
                End If
                If foundTelepitettinLetolthetoRows.Count > 0 Then
                    Dim workRow As DataRow = ReturnLetoltendoRows.NewRow()
                    workRow = foundTelepitettinLetolthetoRows.First
                    If highestletolthetoRow("ver") > workRow("ver") Then ReturnLetoltendoRows.ImportRow(workRow)
                    'Ha a letölthetők legmagasabb verziójában újabb verziójú van a telepítettnél, töltse le 
                End If
            Next
        End If

        If MitFrissitsen = SablonTelepitettOption.MindenElerhetot Or MitFrissitsen = SablonTelepitettOption.ProgrambanElerhetot Then
            'Trace.WriteLine("#29")

            Dim nyomilistafeldolgTA = New NyomtatvanyAdatokDataSetTableAdapters.NyomiListaFeldolgTableAdapter()
            Dim nyomilistafeldolgDT As New NyomtatvanyAdatokDataSet.NyomiListaFeldolgDataTable
            nyomilistafeldolgTA.Fill(nyomilistafeldolgDT)

            For Each letolthetorow As DataRow In LetolthetoNyomtatvanyok.Rows
                Dim selectkód = "Nyomtatvany = '" & letolthetorow("name") & "'"
                If MitFrissitsen = SablonTelepitettOption.ProgrambanElerhetot And nyomilistafeldolgDT.Select(selectkód).Count = 0 Then Continue For
                foundTelepitettinLetolthetoRows = TelepitettNyomtatvanyok.Select("name = '" & letolthetorow("name") & "'")
                If foundTelepitettinLetolthetoRows.Count = 0 Then
                    'Dim workRow As DataRow = ReturnLetoltendoRows.NewRow()
                    ReturnLetoltendoRows.ImportRow(letolthetorow)
                End If
                If foundTelepitettinLetolthetoRows.Count = 1 Then
                    Dim foundtelinletolthetrowver = foundTelepitettinLetolthetoRows(0)("ver")
                    If letolthetorow("ver") <> foundtelinletolthetrowver Then
                        ReturnLetoltendoRows.ImportRow(letolthetorow)
                    End If
                End If

                If foundTelepitettinLetolthetoRows.Count > 2 Then
                    'Dim workRow As DataRow = ReturnLetoltendoRows.NewRow()
                    Dim foundtherow As Boolean = False
                    For Each vizsgaltTelepitettfoundrow In foundTelepitettinLetolthetoRows
                        If letolthetorow("ver") = vizsgaltTelepitettfoundrow("ver") Then foundtherow = True
                    Next
                    If foundtherow = False Then
                        ReturnLetoltendoRows.ImportRow(letolthetorow)
                    End If
                End If
            Next
        End If
        'Trace.WriteLine("#30")

        ReturnLetoltendoRows.AcceptChanges()
        Dim vege As TimeSpan = Now.TimeOfDay
        Dim diff As TimeSpan = vege - kezdet
        MyLoader.AddLogBook(Fnc.nyomdl, "XML-beli és telepített nyomtatványok összehasonlításának időtartam: " & diff.ToString, LogTip.norm)

        Return ReturnLetoltendoRows
    End Function

    Friend Function HighestVersion(Input As DataTable) As DataTable
        'Trace.WriteLine("#26a")

        Dim result As DataTable = CreateTelepitettNyomtatvanyokDT() 'TelepitettNyomtatvanyok.Clone
        Dim foundRows() As Data.DataRow
        Dim distinctView As New DataView(Input)
        Dim distinctTable As DataTable = distinctView.ToTable(True, "name")
        For Each distnamerow As DataRow In distinctTable.Rows
            foundRows = Input.Select("name = '" & distnamerow("name") & "'")
            Dim workRow As DataRow = foundRows.First
            If workRow IsNot Nothing Then result.ImportRow(workRow)
            'result.AcceptChanges()
        Next
        'result.AcceptChanges()
        Return result
    End Function
    Friend Function LetolthetoNyomfromXML(XMLFile As String) As DataTable

        Dim Result As DataTable = CreateTelepitettNyomtatvanyokDT() 'TelepitettNyomtatvanyok.Clone
        Dim root As XDocument = XDocument.Parse(XMLFile)
        Dim childList As IEnumerable(Of XElement) = From el In root.<adat>.<nyomtatvany> Select el
        For Each NyomtatvanyEl In childList
            Dim workRow As DataRow = Result.NewRow()
            Dim javUrl As String = NyomtatvanyEl.<url>.Value
            If javUrl.Last = "/" Then javUrl = javUrl.Substring(0, javUrl.Length - 1)
            'Pl. az OBH tévesen tesz a végére is egy / jelet, így enélkül nem másolható össze az url és a files/file értéke
            'workRow("filename") = Strip(nyomtatvany_el.<files>.<file>.Value, "/", False).Replace(".jar", ".tem.enyk") 'Nem lehet a teljes filenev, mert az csak a jar-ból derül ki egyértelműen, nem követ az OBH egyértelmű szóhasználatot az összes nyomtatványánál
            workRow("org") = NyomtatvanyEl.<szervezet>.Value
            workRow("name") = NyomtatvanyEl.<rovidnev>.Value
            workRow("ver") = New Version(NyomtatvanyEl.<verzio>.Value)
            workRow("info") = NyomtatvanyEl.<elnevezes>.Value
            workRow("category") = NyomtatvanyEl.<kategoria>.Value 'Egyelőre ez hibásan mindenhol "Template" az OBH esetén
            workRow("sourcejar") = javUrl & NyomtatvanyEl.<files>.<file>.Value
            Result.Rows.Add(workRow)

        Next
        'Result.AcceptChanges()
        Return Result
    End Function

    Friend Function DownloadUpdateXML(TargetStr As String) As String
        Dim kezdet As TimeSpan = Now.TimeOfDay
        Dim webClient As New WebDownload
        Dim result As String = String.Empty
        webClient.Encoding = System.Text.Encoding.UTF8
        webClient.Timeout = 3000
        Try
            result = webClient.DownloadString(TargetStr)
            NemelerhetoOBH = False
        Catch ex As Exception
            Dim hibauzenet As String
            NemelerhetoOBH = True
            Dim figyelmeztetes As String = "Figyelem! Lehet, hogy lejárt nyomtatványt készít majd a programmal!"
            If ex.Message.Contains("Forbidden.") Then
                hibauzenet = "Az OBH szervere a megadott címen nem érhető el frissítés végett. A nyomtatványsablonok frissességét a szerver hibájából nem ellenőrizhette a program." & vbCrLf & figyelmeztetes
                MyLoader.AddLogBook(Fnc.nyomdl, hibauzenet, LogTip.err)
                MsgBox(hibauzenet, MsgBoxStyle.Critical)
            Else
                hibauzenet = "Az OBH szervere hiba miatt nem érhető el frissítés végett. A nyomtatványsablnok frissességét a program nem tudta ellenőrizni." & vbCrLf & figyelmeztetes
                MyLoader.AddLogBook(Fnc.nyomdl, hibauzenet, LogTip.err)
                MsgBox(hibauzenet, MsgBoxStyle.Critical)
            End If
            result = ""
        End Try
        Dim vege As TimeSpan = Now.TimeOfDay
        Dim diff As TimeSpan = vege - kezdet
        MyLoader.AddLogBook(Fnc.nyomdl, "Frissítési XML letöltése OBHGEPI-rol - időtartam: " & diff.ToString, LogTip.norm)
        Return result
    End Function


    Friend Sub DownloadNyomtatvanyfromTable(DataTableToDL As DataTable)
        countersuccess = 0
        counterfailed = 0
        hibastetel.Clear()

        Dim dlcount = DataTableToDL.Rows.Count
        If dlcount <> 0 Then
            MyLoader.AddLogBook(Fnc.nyomdl, "Nyomtatványok letöltése megkezdődött: összesen " & dlcount & " db. nyomtatvány" & IIf(dlcount > 30, ", kérjük türelmét", ""), LogTip.siker)
            MyLoader.DLoadMain(DataTableToDL)
        End If
    End Sub
#End Region

#Region "TitkositoKezelese"
    Friend Sub SajatTitkositoCheck()
        Dim KrTitokUserCfgFile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & Path.DirectorySeparatorChar & ".krtitok.ini"
        If File.Exists(KrTitokUserCfgFile) Then
            Dim ANYKEncryptKeyPath = ReadParamText(KrTitokUserCfgFile, "SAJAT_NYILVANOS_KULCS", True, EncodingUsed:=Text.Encoding.Default)
            Dim ANYKDecryptKeyPath = ReadParamText(KrTitokUserCfgFile, "SAJAT_TITKOS_KULCS", True, EncodingUsed:=Text.Encoding.Default)
            If File.Exists(My.Settings.EncryptKeyPath) Then
                If My.Settings.EncryptKeyPath <> ANYKEncryptKeyPath Then
                    MyLoader.AddLogBook(Fnc.cfg, "Eltérő saját borítékBEtitkosító kulcs van beállítva az ÁNYK-ban és programban is, mindkettő létezik - a program a saját beállítást használja)", LogTip.norm)
                Else
                    MyLoader.AddLogBook(Fnc.cfg, "Azonos saját borítékBEtitkosító kulcs van beállítva az ÁNYK-ban és programban is, mindkettő létezik", LogTip.norm)
                End If
            End If
            If Not File.Exists(My.Settings.EncryptKeyPath) And File.Exists(ANYKEncryptKeyPath) Then
                If My.Settings.AtvegyeANYKbolTitkositot = "Yes" Then
                    My.Settings.EncryptKeyPath = ANYKEncryptKeyPath
                    MyLoader.AddLogBook(Fnc.cfg, "saját borítékBEtitkosító kulcs használata beállítva ÁNYK-ban, de nincsen a programban, az ÁNYK-s kulcs létezik, a program a beállítást átvette", LogTip.norm)
                End If
                If My.Settings.AtvegyeANYKbolTitkositot = String.Empty Then
                    Dim dialogresult As New DialogResult
                    dialogresult = MsgBox("A programban nincsen beállítva BEtitkosító kulcs, de az ÁNYK-ban be van ilyen kulcs állítva. Átvegyem a beállítást? (A választ a program megjegyzi, a Készít/Beállítások/Titkosító kulcs menüben tudja később módosítani.)", MsgBoxStyle.YesNo)
                    If dialogresult = MsgBoxResult.Yes Then
                        My.Settings.EncryptKeyPath = ANYKEncryptKeyPath
                        My.Settings.AtvegyeANYKbolTitkositot = "Yes"
                        MyLoader.AddLogBook(Fnc.cfg, "saját borítékBEtitkosító kulcs használata beállítva ÁNYK-ban, de nincsen a programban, az ÁNYK-s kulcs létezik, a program a beállítást átvette", LogTip.norm)
                    Else
                        My.Settings.AtvegyeANYKbolTitkositot = "No"
                    End If
                End If
            End If

            If Not File.Exists(My.Settings.EncryptKeyPath) And Not File.Exists(ANYKEncryptKeyPath) Then
                My.Settings.EncryptKeyPath = ""
                MyLoader.AddLogBook(Fnc.cfg, "Sem a programban, sem ÁNYK-ban nincsen beállítva saját borítékBEtitkosító kulcs, a beküldött KR borítékokat csak a fogadó tudja olvasni", LogTip.norm)
            End If


            If File.Exists(My.Settings.DecryptKeyPath) Then
                If My.Settings.DecryptKeyPath <> ANYKDecryptKeyPath Then
                    MyLoader.AddLogBook(Fnc.cfg, "Eltérő borítékKItitkosító kulcs van beállítva az ÁNYK-ban és programban is, mindkettő létezik - a program a saját beállítást használja)", LogTip.norm)
                Else
                    MyLoader.AddLogBook(Fnc.cfg, "Azonos borítékKItitkosító kulcs van beállítva az ÁNYK-ban és programban is, mindkettő létezik", LogTip.norm)
                End If
            End If
            If Not File.Exists(My.Settings.DecryptKeyPath) And File.Exists(ANYKDecryptKeyPath) Then
                If My.Settings.AtvegyeANYKbolTitkositot = "Yes" Then
                    My.Settings.DecryptKeyPath = ANYKDecryptKeyPath
                    MyLoader.AddLogBook(Fnc.cfg, "borítékKItitkosító kulcs használata beállítva ÁNYK-ban, de nincsen a programban, az ÁNYK-s kulcs létezik, a program a beállítást átvette", LogTip.norm)
                End If
                If My.Settings.AtvegyeANYKbolTitkositot = String.Empty Then
                    Dim dialogresult As New DialogResult
                    dialogresult = MsgBox("A programban nincsen beállítva KItitkosító kulcs, de az ÁNYK-ban be van ilyen kulcs állítva. Átvegyem a beállítást? (A választ a program megjegyzi, a Készít/Beállítások/Titkosító kulcs menüben tudja később módosítani.)", MsgBoxStyle.YesNo)
                    If dialogresult = MsgBoxResult.Yes Then
                        My.Settings.EncryptKeyPath = ANYKDecryptKeyPath
                        My.Settings.AtvegyeANYKbolTitkositot = "Yes"
                        MyLoader.AddLogBook(Fnc.cfg, "saját borítékKItitkosító kulcs használata beállítva ÁNYK-ban, de nincsen a programban, az ÁNYK-s kulcs létezik, a program a beállítást átvette", LogTip.norm)
                    Else
                        My.Settings.AtvegyeANYKbolTitkositot = "No"
                    End If
                End If
            End If

            If Not File.Exists(My.Settings.DecryptKeyPath) And Not File.Exists(ANYKDecryptKeyPath) Then
                My.Settings.DecryptKeyPath = ""
                MyLoader.AddLogBook(Fnc.cfg, "Sem a programban, sem ÁNYK-ban nincsen beállítva borítékKItitkosító kulcs", LogTip.norm)
            End If
        Else
            If File.Exists(My.Settings.EncryptKeyPath) Then
                MyLoader.AddLogBook(Fnc.cfg, "Saját borítékBEtitkosító kulcs használata beállítva a programban", LogTip.norm)
            Else
                My.Settings.EncryptKeyPath = ""
                MyLoader.AddLogBook(Fnc.cfg, "Sem a programban, sem ÁNYK-ban nincsen beállítva saját borítékBEtitkosító kulcs, a beküldött KR borítékokat csak a fogadó tudja olvasni", LogTip.norm)
            End If
            If File.Exists(My.Settings.DecryptKeyPath) Then
                MyLoader.AddLogBook(Fnc.cfg, "borítékKItitkosító kulcs használata beállítva a programban", LogTip.norm)
            Else
                My.Settings.DecryptKeyPath = ""
                MyLoader.AddLogBook(Fnc.cfg, "Sem a programban, sem ÁNYK-ban nincsen beállítva borítékKItitkosító kulcs, a beküldött KR borítékokat csak a fogadó tudja olvasni", LogTip.norm)
            End If
        End If
        My.Settings.Save()
    End Sub

    Friend Function CheckSajatKITitkosito() As Boolean
        If Not File.Exists(My.Settings.DecryptKeyPath) Then
            If My.Settings.DecryptKeyPath <> "" Then My.Settings.DecryptKeyPath = ""
            Return False
        End If
        If File.Exists(My.Settings.DecryptKeyPath) And My.Settings.PkeyPassw <> "" Then Return True Else Return False
    End Function
    Friend Function CheckSajatBETitkosito() As Boolean
        If Not File.Exists(My.Settings.EncryptKeyPath) Then
            If My.Settings.EncryptKeyPath <> "" Then My.Settings.EncryptKeyPath = ""
            Return False
        End If
        If File.Exists(My.Settings.EncryptKeyPath) Then Return True Else Return False
    End Function
    Function KrTitokToString(input As String) As String
        input = input.Replace("\\u", "*")
        input = input.Replace("\\U", Chr(34))
        input = input.Replace("\:", ":")
        input = input.Replace("\\", "\")
        Do Until input.IndexOf("\u") = -1
            Dim pos = InStr(input, "\u")
            Dim karkod = input.Substring(pos + 1, 4)
            Dim replkod As String = String.Empty
            Try
                replkod = ChrW(CInt("&H" & karkod))
                input = Microsoft.VisualBasic.Replace(input, "\u" & karkod, replkod, 1, 1)
            Catch ex As Exception
            End Try
        Loop
        input = input.Replace("*", "\u")
        input = input.Replace(Chr(34), "\U")
        Return input
    End Function

    Function StringToKrTitok(input As String) As String
        Dim output As String = String.Empty
        input = input.Replace("\", "\\")
        input = input.Replace(":", "\:")
        For Each character As Char In input
            If AscW(character) > 127 Then
                Dim intval = Convert.ToInt32(character)
                output += "\u" & intval.ToString("X4")
            Else
                output += character
            End If
        Next
        Return output
    End Function

#End Region

#Region "XMLXKRnyitas"
    Friend Sub abevjavaNyitas(parancs As String, source As String)
        Dim abevjavabat = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & abevjavaindito
        If Not File.Exists(abevjavabat) Then
            Dim uzenet0 As String = "A program nem találja az ÁNYK indításához szükséges abevjava futtató start fájlt, kérem telepítse újra az ÁNYK-t!"
            MyLoader.AddLogBook(Fnc.cfg, uzenet0, LogTip.err)
            MsgBox(uzenet0, MsgBoxStyle.Critical & MsgBoxStyle.OkOnly)
        End If
        Dim abevprocess As New System.Diagnostics.Process
        abevprocess.StartInfo.UseShellExecute = False
        abevprocess.StartInfo.WorkingDirectory = Path.GetDirectoryName(abevjavabat)
        abevprocess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        abevprocess.StartInfo.FileName = abevjavabat
        abevprocess.StartInfo.Arguments = Chr(34) & parancs & " " & source & Chr(34)
        abevprocess.Start()
        'Dim OutputString = abevprocess.StandardOutput.ReadToEnd()
        abevprocess.Close()
        abevprocess.Dispose()
        MyLoader.AddLogBook(Fnc.cfg, "Az ÁNYK-ban megnyitása a " & source & " fájl", LogTip.norm)
    End Sub

#End Region


#Region "Egyéb"
    Friend Function GetMyAppVersion() As String
        Dim VerString As String = ""
        Try
            If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then VerString = My.Application.Deployment.CurrentVersion.ToString Else VerString = "(DBG)_" & Now.ToShortDateString
        Catch ex As Exception
            VerString = "(DBG)_" & Now.ToShortDateString
        End Try
        Return VerString
    End Function


    Friend Sub CheckForShortcut()
        'Menüből hívható legyen!
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            Dim code As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Dim company As String = String.Empty
            Dim description As String = String.Empty
            If (Attribute.IsDefined(code, GetType(Reflection.AssemblyCompanyAttribute))) Then
                Dim ascompany As Reflection.AssemblyCompanyAttribute =
                    CType(Attribute.GetCustomAttribute(code,
                    GetType(Reflection.AssemblyCompanyAttribute)), Reflection.AssemblyCompanyAttribute)
                company = ascompany.Company
            End If
            Dim ShortName = code.GetName.Name
            If (Attribute.IsDefined(code, GetType(Reflection.AssemblyDescriptionAttribute))) Then
                Dim asdescription As Reflection.AssemblyDescriptionAttribute =
                    CType(Attribute.GetCustomAttribute(code,
                    GetType(Reflection.AssemblyDescriptionAttribute)), Reflection.AssemblyDescriptionAttribute)
                description = asdescription.Description
            End If
            Dim shortcutName As String = String.Empty
            Dim desktopPath As String = String.Empty
            If (company.Length > 0 AndAlso description.Length > 0) Then
                desktopPath = String.Concat(
                                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                    System.IO.Path.DirectorySeparatorChar, description, ".appref-ms")
                shortcutName = String.Concat(
                                    Environment.GetFolderPath(Environment.SpecialFolder.Programs),
                                    System.IO.Path.DirectorySeparatorChar, company, System.IO.Path.DirectorySeparatorChar, description, ".appref-ms")
                'Nem tesztelt ág!
            ElseIf (description.Length > 0 And company.Length = 0) Then
                desktopPath = String.Concat(
                                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                  System.IO.Path.DirectorySeparatorChar, description, ".appref-ms")
                shortcutName = String.Concat(
                                    Environment.GetFolderPath(Environment.SpecialFolder.Programs),
                                   System.IO.Path.DirectorySeparatorChar, description, System.IO.Path.DirectorySeparatorChar, description, ".appref-ms")
                'Nem tesztelt ág!
            ElseIf (description.Length = 0 And company.Length > 0) Then
                desktopPath = String.Concat(
                                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop), System.IO.Path.DirectorySeparatorChar, ShortName, ".appref-ms")
                shortcutName = String.Concat(
                                    Environment.GetFolderPath(Environment.SpecialFolder.Programs),
                                    System.IO.Path.DirectorySeparatorChar, company, System.IO.Path.DirectorySeparatorChar, ShortName, ".appref-ms")
                'Nem tesztelt ág!
            ElseIf (description.Length = 0 And company.Length = 0) Then
                desktopPath = String.Concat(
                                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop), System.IO.Path.DirectorySeparatorChar, ShortName, ".appref-ms")
                shortcutName = String.Concat(
                                    Environment.GetFolderPath(Environment.SpecialFolder.Programs),
                                    System.IO.Path.DirectorySeparatorChar, ShortName, System.IO.Path.DirectorySeparatorChar, ShortName, ".appref-ms")
            End If
            System.IO.File.Copy(shortcutName, desktopPath, True)
        End If
    End Sub
    Friend Sub CheckandArchiveFile(FileName As String)
        Try
            If My.Settings.Regisztrált = True Then FileSystem.Rename(FileName, FileName & CleanPathandFileName(Now.ToLocalTime.ToString).Replace(".", "") & ".bak") Else File.Delete(FileName)
        Catch ex As Exception
        End Try
    End Sub

    Friend Function CleanPathandFileName(pathorfileName As String) As String
        If IsNothing(pathorfileName) OrElse pathorfileName = String.Empty OrElse pathorfileName = Path.DirectorySeparatorChar OrElse pathorfileName = Path.AltDirectorySeparatorChar Then Return String.Empty
        Dim output As String = String.Empty
        output = Path.GetInvalidPathChars().Aggregate(pathorfileName, Function(current, c) current.Replace(c.ToString(), String.Empty))
        Dim outputkonyvtar = Path.GetDirectoryName(output)
        If outputkonyvtar <> String.Empty Then outputkonyvtar += Path.DirectorySeparatorChar
        Dim outputfileneve As String = Path.GetFileName(output)
        outputfileneve = Path.GetInvalidFileNameChars().Aggregate(outputfileneve, Function(current, c) current.Replace(c.ToString(), String.Empty)).Replace("&", "").Replace("'", "")
        Return outputkonyvtar & outputfileneve
    End Function
    Friend Function Strip(Input As String, StripChar As Char, Before As Boolean) As String
        Dim index As Integer = Input.LastIndexOf(StripChar)
        If index > 0 Then
            If Before Then Input = Input.Substring(0, index)
            If Not Before Then
                index += 1
                Input = Input.Substring(index, Input.Length - index)
            End If
        End If
        Return Input
    End Function
    Friend Function ReadParamText(ParamFile As String, ParamToRead As String, Optional KRTITOK As Boolean = False, Optional EncodingUsed As Text.Encoding = Nothing) As String
        If IsNothing(EncodingUsed) Then EncodingUsed = Text.Encoding.UTF8
        Dim newline As String = ""
        Dim result As String = ""
        Try
            If File.Exists(ParamFile) Then
                Using reader As StreamReader = New StreamReader(ParamFile, EncodingUsed)
                    Do While reader.Peek() >= 0
                        newline = reader.ReadLine()
                        If Trim(Strip(newline, "=", True)) = ParamToRead Then
                            result = Trim(Strip(newline, "=", False))
                        End If
                    Loop
                End Using
            End If
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.cfg, "Paraméterfájl beolvasási hiba:" & ParamFile & " paraméter=" & ParamToRead, LogTip.err)
            Return String.Empty
        End Try
        If KRTITOK = True Then
            result = KrTitokToString(result)
        Else
            result = result.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
        End If
        Return result
    End Function

    Friend Function GetLatestFolderName(FullName As String) As String
        FullName = FullName.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
        If Strings.Right(FullName, 1) <> Path.DirectorySeparatorChar Then FullName += Path.DirectorySeparatorChar
        Return Path.GetFileName(Path.GetDirectoryName(FullName))
    End Function

    Friend Function ChangeParamText(FileToWrite As String, ParamToWrite As String, NewValue As String, Optional KRTITOK As Boolean = False, Optional EncodingName As String = "") As Boolean
        Dim oldText As String()
        Dim result As Boolean
        If KRTITOK = True Then ParamToWrite = StringToKrTitok(ParamToWrite)
        If File.Exists(FileToWrite) Then
            If EncodingName = "windows-1250" Or EncodingName = "iso-8859-2" Then
                oldText = File.ReadAllLines(FileToWrite, System.Text.Encoding.Default)
            Else
                oldText = File.ReadAllLines(FileToWrite, System.Text.Encoding.UTF8)
            End If

            Dim arrindex As Integer = 4
            For Each line In oldText
                Dim oldParam = Trim(Strip(line, "=", True))
                If oldParam = ParamToWrite Then
                    Dim oldValue = Trim(Strip(line, "=", False))
                    arrindex = Array.IndexOf(oldText, line)
                    line = oldParam & "=" & NewValue
                    oldText(arrindex) = line
                    result = True
                End If
            Next
            If result = True Then
                Try
                    'File.Delete(FileToWrite)
                    If EncodingName = "windows-1250" Or EncodingName = "iso-8859-2" Then
                        File.WriteAllBytes(FileToWrite, EncodeString(oldText, EncodingName))
                    Else
                        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                        File.WriteAllLines(FileToWrite, oldText, utf8WithoutBom)
                    End If
                Catch ex As Exception
                    MsgBox("Írási hiba.")
                    MyLoader.AddLogBook(Fnc.cfg, "Írási hiba az ÁNYK paraméterek ideiglenes megváltoztatása esetén", LogTip.err)
                    result = False
                End Try
            End If
        End If

        Return result
    End Function

    Function EncodeString(ByRef SourceData As String, ByRef CharSet As String) As Byte()
        Dim bSourceData As Byte() = System.Text.Encoding.Default.GetBytes(SourceData)
        Dim OutEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding(CharSet)
        Return System.Text.Encoding.Convert(System.Text.Encoding.Default, OutEncoding, bSourceData)
    End Function


    Function EncodeString(ByRef SourceData As String(), ByRef CharSet As String) As Byte()
        Dim SourceDataStr As String = Strings.Join(SourceData, Environment.NewLine)
        Dim bSourceData As Byte() = System.Text.Encoding.Default.GetBytes(SourceDataStr)
        Dim OutEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding(CharSet)
        Return System.Text.Encoding.Convert(System.Text.Encoding.Default, OutEncoding, bSourceData)
    End Function

    Friend Sub WriteResourceToFile(TargetFile As String, Resourcefile As Byte())
        Dim hiba As String = "Nem tudta a program megírni a " & TargetFile & " fájlt"
        Try
            System.IO.File.WriteAllBytes(TargetFile, Resourcefile)
        Catch
            MyLoader.AddLogBook(Fnc.cfg, hiba, LogTip.err)
        End Try
        If Not File.Exists(TargetFile) Then MyLoader.AddLogBook(Fnc.cfg, hiba, LogTip.err)
    End Sub

    Friend Function ReformatThumbprintWithSpaces(InputString As String) As String
        Dim Orig As String = InputString
        Dim uzenet As String = String.Empty
        For i As Integer = 2 To 60 Step 2
            InputString = InputString.Insert(i, " ")
            i += 1
        Next
        InputString = Strings.Left(InputString, 59)
        uzenet = "tbprint: input ='" & Orig & Environment.NewLine & "processed='" & InputString & "'/len=" & InputString.Length & "'" & Environment.NewLine & "shorterprocessed='" & StrToHex(InputString)
        Return InputString
    End Function

    Friend Function GetFromJarAll(JarFileToProcess As String, JarFileToExtract As String, TargetFileOrFolder As String, Optional NamefromZip As Boolean = False) As List(Of String)
        Dim IsTargetFile As Boolean = True
        Dim foundlist As New List(Of String)
        If TargetFileOrFolder.Last = Path.DirectorySeparatorChar Then
            IsTargetFile = False
        Else
            If System.IO.Directory.Exists(TargetFileOrFolder) Then IsTargetFile = False
        End If
        If File.Exists(JarFileToProcess) Then
            Try
                Using JarFileProcessed As ZipArchive = ZipFile.OpenRead(JarFileToProcess)
                    JarFileToExtract = JarFileToExtract.Replace("*", "")
                    JarFileToExtract = JarFileToExtract.Replace("?", "")
                    Dim found As Boolean
                    Dim filefoundpath As String = String.Empty
                    For Each entry As ZipArchiveEntry In JarFileProcessed.Entries
                        If entry.Name.Contains(JarFileToExtract) Then
                            found = True
                            Using zipstream As DeflateStream = entry.Open
                                Using ms As New MemoryStream()
                                    Dim ziptobytearray As Byte()
                                    zipstream.CopyTo(ms)
                                    ziptobytearray = ms.ToArray()
                                    If NamefromZip = False And IsTargetFile = True Then System.IO.File.WriteAllBytes(TargetFileOrFolder, ziptobytearray)
                                    If NamefromZip = True And IsTargetFile = True Then
                                        filefoundpath = Path.GetDirectoryName(TargetFileOrFolder) & Path.DirectorySeparatorChar & entry.Name
                                        System.IO.File.WriteAllBytes(filefoundpath, ziptobytearray)
                                        foundlist.Add(filefoundpath)
                                    End If
                                    If IsTargetFile = False Then
                                        filefoundpath = TargetFileOrFolder & Path.DirectorySeparatorChar & entry.Name
                                        System.IO.File.WriteAllBytes(filefoundpath, ziptobytearray)
                                        foundlist.Add(filefoundpath)
                                    End If
                                End Using
                            End Using
                        End If
                    Next
                    If found = False Then MyLoader.AddLogBook(Fnc.cfg, "A megadott kicsomagolandó fájl (" & JarFileToExtract & ") nem érhető el a megadott, létező JAR fájlban (" & JarFileToProcess & ").", LogTip.err)
                End Using
            Catch ex As System.IO.InvalidDataException
                'Trace.WriteLine("Hibás zip fájl:" & JarFileToProcess)
            End Try
        Else MyLoader.AddLogBook(Fnc.cfg, "A megadott feldolgozandó JAR fájl (" & JarFileToProcess & ") nem létezik", LogTip.err)
        End If
        Return foundlist
    End Function

    Friend Sub OpenExplorerwPath(PathtoOpen As String)
        If Not Directory.Exists(PathtoOpen) = True Then Exit Sub
        Dim Proc As String = "Explorer.exe"
        Dim Args As String = ControlChars.Quote & PathtoOpen & ControlChars.Quote
        Process.Start(Proc, Args)
    End Sub


    Friend Function CheckandRegExt(ext As String, des As String, prgid As String, OpenCommand As String, IconPath As String, Optional Overwrite As Boolean = True) As Boolean
        Dim readValueHKCU As Object
        Dim readValueHKLM As Object
        Dim readValue As Object = Nothing
        Dim HKCUCorrect As Boolean = False
        Dim IconPathVerif As String = String.Empty
        Dim response As Boolean = False

        If File.Exists(IconPath) Then IconPathVerif = IconPath
        readValueHKCU = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Classes\" & prgid & "\shell\open\command\", "", Nothing)
        readValueHKLM = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\" & prgid & "\shell\open\command\", "", Nothing)
        If readValueHKCU IsNot Nothing Then
            readValue = readValueHKCU
            HKCUCorrect = True
        End If
        If readValueHKLM IsNot Nothing And HKCUCorrect = False Then readValue = readValueHKLM
        If readValue IsNot Nothing And Overwrite = False Then response = False
        If readValue IsNot Nothing And Overwrite = True Then
            Dim rewriteresult As Boolean = ReWriteRegistry(ext, des, prgid, OpenCommand, HKCUCorrect, IconPathVerif)
            If rewriteresult = False Then
                rewriteresult = ReWriteRegistry(ext, des, prgid, OpenCommand, False, IconPathVerif)
                If rewriteresult = False Then
                    MyLoader.AddLogBook(Fnc.cfg, "Nem sikerült az " & ext & " társítása az ÁNYK-val", LogTip.err)
                    response = False
                End If
            Else
                HKCUCorrect = False
                MyLoader.AddLogBook(Fnc.cfg, "Sikerült az " & ext & " társítása az ÁNYK-val", LogTip.siker)
                response = True
            End If
        End If
        If readValue Is Nothing Then
            Dim rewriteresult As Boolean = False
            rewriteresult = ReWriteRegistry(ext, des, prgid, OpenCommand, False, IconPathVerif)
            If rewriteresult = False Then
                rewriteresult = ReWriteRegistry(ext, des, prgid, OpenCommand, True, IconPathVerif)
                If rewriteresult = False Then response = False
            Else
                MyLoader.AddLogBook(Fnc.cfg, "Sikerült az " & ext & " társítása az ÁNYK-val", LogTip.siker)
                response = True
            End If
        End If
        Return response
    End Function

    Friend Function ReWriteRegistry(ext As String, des As String, prgid As String, OpenCommand As String, HKCUCorrect As Boolean, IconPathVerif As String) As Boolean
        Dim defPath As String = ""
        If HKCUCorrect = True Then defPath = "HKEY_CURRENT_USER\Software\Classes\" Else defPath = "HKEY_CLASSES_ROOT\"
        Try
            My.Computer.Registry.SetValue(defPath & ext & "\", "", prgid, Microsoft.Win32.RegistryValueKind.String)
            'jogosultságunk van?
            My.Computer.Registry.SetValue(defPath & prgid & "\", "", des, Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue(defPath & prgid & "\Shell\", "Open", "", Microsoft.Win32.RegistryValueKind.String)
            If IconPathVerif <> "" Then
                My.Computer.Registry.SetValue(defPath & prgid & "\DefaultIcon\", "", IconPathVerif, Microsoft.Win32.RegistryValueKind.String)
            Else
                MyLoader.AddLogBook(Fnc.cfg, "Hibás a megadott ikon, nem tudtam ikonképet társítani a " & ext & " kiterjesztéshez", LogTip.err)
            End If
            My.Computer.Registry.SetValue(defPath & prgid & "\Shell\Open\Command\", "", OpenCommand, Microsoft.Win32.RegistryValueKind.String)
            Return True
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.cfg, "Társítási hiba: " & defPath, LogTip.err)
            Return False
        End Try
        'Még esetleg itt? HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.xkr
    End Function

    Public Function GetTeljesNevDef(Nevlista As List(Of String)) As String
        Dim response As String = String.Empty
        For Each elem In Nevlista
            If response <> "" And elem <> "" Then response += " " & elem
            If response = "" And elem <> "" Then response += elem
        Next
        Return response
    End Function
    Public Function GetFileSizeFormatted(FileLength As Long) As String
        Dim DoubleBytes As Double
        If FileLength = 0 Then Return ""
        Dim SizeType As String = ""
        Try
            Select Case FileLength
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(FileLength / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(FileLength / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(FileLength / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(FileLength / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = FileLength ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function
    <DllImport("Shlwapi.dll", CharSet:=CharSet.Auto)>
    Public Function StrFormatByteSize(fileSize As Long, <MarshalAs(UnmanagedType.LPTStr)> buffer As System.Text.StringBuilder, bufferSize As Integer) As Int32
    End Function

    <DllImport("iphlpapi.dll", EntryPoint:="GetAdaptersInfo", CharSet:=CharSet.Ansi)>
    Public Function GetAdaptersInfo(
     ByVal pAdapterInfo As IntPtr,
     ByRef pBufOutLen As UInt64) As Int32
    End Function


    Public Function ToFileSizeApi(fileSize As Long) As String
        Dim sb As New System.Text.StringBuilder(20)
        StrFormatByteSize(fileSize, sb, 20)
        Return sb.ToString()
    End Function

    Public Sub SetKrProc(ByRef procName As Process)
        procName.StartInfo.UseShellExecute = False
        procName.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        procName.StartInfo.RedirectStandardError = True
        procName.StartInfo.RedirectStandardOutput = True
        procName.StartInfo.FileName = JavaPath
    End Sub
    Public Sub SetDebugger()
        ' Create a file for output named TestFile.txt.
        ' Create a new text writer using the output stream, and add it to
        ' the trace listeners. 
        Dim logfile As String = String.Empty
        If My.Settings.AccessibleUserSettings = "" Then logfile = "C:\Users\Pubic\Documents\DebugHP.txt" Else logfile = My.Settings.AccessibleUserSettings & Path.DirectorySeparatorChar & "Log" & Path.DirectorySeparatorChar & "DebugHP.txt"
        Dim myTextListener As New TextWriterTraceListener(logfile)
        'Debug.Listeners.Add(myTextListener)
        'Debug.AutoFlush = True

        Trace.Listeners.Add(myTextListener)
        Trace.AutoFlush = True
    End Sub
    Public Function EmailValid(Elerhetoseg As String) As Boolean
        If (Elerhetoseg.Contains("@") And Elerhetoseg.Contains(".")) Then Return True Else Return False
    End Function

    Public Function IsHex(chars As IEnumerable(Of Char)) As Boolean
        'Forrás: http://stackoverflow.com/questions/223832/check-a-string-to-see-if-all-characters-are-hexadecimal-values

        Dim isHex1 As Boolean
        For Each c As Char In chars
            isHex1 = ((c >= "0"c AndAlso c <= "9"c) OrElse (c >= "a"c AndAlso c <= "f"c) OrElse (c >= "A"c AndAlso c <= "F"c))
            If Not isHex1 Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function Sha256HashGenerator(ByVal FileName As String)
        Dim HashValueBA() As Byte = Nothing
        Dim sBuilder As New System.Text.StringBuilder()

        Using fileStream As FileStream = File.OpenRead(FileName)
            Dim hash = Security.Cryptography.SHA256.Create()
            fileStream.Position = 0
            HashValueBA = hash.ComputeHash(fileStream)
        End Using
        Dim i As Integer
        For i = 0 To HashValueBA.Length - 1
            sBuilder.Append(HashValueBA(i).ToString("x2"))
        Next i
        Return sBuilder.ToString
    End Function

    Friend Sub PasswordDeleteAllShared()

        My.Settings.UKPUName = String.Empty
        My.Settings.UKPPassw = String.Empty
        My.Settings.PKPUName = String.Empty
        My.Settings.PKPPassw = String.Empty
        My.Settings.HKPUName = String.Empty
        My.Settings.HKPPassw = String.Empty
        My.Settings.TSUN = String.Empty
        My.Settings.TSPW = String.Empty
        My.Settings.PasswPrinted = False
        My.Settings.Save()
        MyLoader.CheckUKP()
        MyLoader.CheckPKP()
        MyLoader.CheckHKP()
        MyLoader.passwprint.Enabled = True
    End Sub

    Friend Function TeruletiAdohatosagKodEllenorzo(Kod As Byte) As Boolean
        Dim response As Boolean = True
        If Kod < 2 Then response = False
        If Kod > 51 Then response = False
        If Kod = 21 Then response = False
        If Kod > 44 And Kod < 51 Then response = False
        Return response
    End Function

    Friend Function AdószámValidator(Adoszam As String) As Adószámhiba
        If Adoszam.Length <> 11 Then
            Return Adószámhiba.Hossz
        End If

        Dim TorzsSzamEllenorzoNelkul = Strings.Left(Adoszam, 7)
        Dim EllenorzoSzamTxtBox = Strings.Mid(Adoszam, 8, 1)
        Dim AFAkod = Strings.Mid(Adoszam, 9, 1)
        Dim TeruletiAdohatosagKod = Strings.Mid(Adoszam, 10, 2)
        Dim Szorzo(7) As Byte
        Szorzo(1) = 9
        Szorzo(2) = 7
        Szorzo(3) = 3
        Szorzo(4) = 1
        Szorzo(5) = 9
        Szorzo(6) = 7
        Szorzo(7) = 3

        Dim Osszeg As Integer
        Dim I As Byte
        For I = 1 To 7
            Osszeg = Osszeg + (Szorzo(I) * CInt(TorzsSzamEllenorzoNelkul.Substring(I - 1, 1)))
        Next
        Dim Ellenorzo As Integer = 10 - (CInt(Osszeg.ToString.Substring(Osszeg.ToString.Length - 1)))
        If Ellenorzo = 10 Then Ellenorzo = 0
        If EllenorzoSzamTxtBox <> Ellenorzo.ToString Then
            Return Adószámhiba.EllenorzoSzam
        Else
            Try
                Dim AFAkodByte As Byte = CByte(AFAkod)
                If AFAkodByte < 1 And AFAkodByte > 5 Then Return Adószámhiba.AFAKod
            Catch ex As Exception
                Return Adószámhiba.AFAKod
            End Try
            Try
                Dim TeruletiAdohatosagKodByte = CByte(TeruletiAdohatosagKod)
                If TeruletiAdohatosagKodEllenorzo(TeruletiAdohatosagKodByte) = False Then Return Adószámhiba.TeruletiKod
            Catch ex As Exception
                Return Adószámhiba.TeruletiKod
            End Try
        End If
        Return Adószámhiba.OK

    End Function

    Public Function StrToHex(ByVal Data As String) As String

        Dim sVal As String
        Dim sHex As String = ""
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1, Data.Length - 1)
            sHex = sHex & sVal
        End While
        Return sHex
    End Function

    Friend Sub ANYKmemoryFix()
        Dim MaxPhysMem As Long = System.Math.Round(My.Computer.Info.TotalPhysicalMemory / (1024 * 1024))
        Dim maxmemheapANYKengedi As Integer = 0
        If MaxPhysMem < 2049 Then maxmemheapANYKengedi = 1023 Else maxmemheapANYKengedi = 1024
        Dim setenv As String = String.Empty
        Dim hibauzenet As String = "Az ÁNYK memóriafogalását nem tudta a program átállítani, próbálja meg az ÁNYK Szerviz/Beállítások menüpontjában (alul) átállítani"

        Try
            setenv = My.Settings.mappaANYKfuttatas & Path.DirectorySeparatorChar & "setenv.bat"
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.cfg, hibauzenet & ". Hiányzik a setenv.bat!", LogTip.err)
            Exit Sub
        End Try
        Dim memparam = "@SET MEMORY_OPTS"
        Dim minmem As Integer = 0
        Dim maxmem As Integer = 0
        If File.Exists(setenv) Then
            Dim memsetting = ReadParamText(setenv, memparam)
            Try
                minmem = CType(Split(memsetting, "-")(1).Replace("Xms", String.Empty).Replace("m", String.Empty), Integer)
                maxmem = CType(Split(memsetting, "-")(2).Replace("Xmx", String.Empty).Replace("m", String.Empty), Integer)
            Catch ex As Exception
                'Nem tudta beolvasni a meglévő értékeket, ezért vakon átírja és nem ellenőrzi
            End Try
            Try
                If minmem < 512 Or maxmem < maxmemheapANYKengedi Then
                    ChangeParamText(setenv, memparam, "-Xms512m -Xmx" & maxmemheapANYKengedi & "m")
                    MyLoader.AddLogBook(Fnc.cfg, "Az ÁNYK memóriafogalását átállította a program min. 512, max." & maxmemheapANYKengedi & " MB-ra", LogTip.norm)
                Else
                    MyLoader.AddLogBook(Fnc.cfg, "Az ÁNYK memóriafogalása már most is min. 512 MB és maximum " & maxmemheapANYKengedi, LogTip.norm)
                End If
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.cfg, hibauzenet, LogTip.err)
            End Try
        End If
    End Sub


    Friend Function zippeldRegFajlt(Mit As String) As String
        If Mit = String.Empty Then Return String.Empty
        Dim hova As String = Path.GetTempFileName
        If File.Exists(hova) Then File.Delete(hova)
        Using newFile As ZipArchive = ZipFile.Open(hova, ZipArchiveMode.Create)
            Try
                newFile.CreateEntryFromFile(Mit, Path.GetFileName(Mit))
            Catch ex As Exception
                Return ":hiba:"
            End Try
        End Using
        Return hova
    End Function
    Public Sub QuitMe()
        Application.ExitThread()
        If System.Windows.Forms.Application.MessageLoop Then Application.Exit() Else Environment.Exit(1)
    End Sub

    Friend Function GetResultsfromPersonDT(inputTable As DataTable, inputText As String) As Integer
        Dim IDtoGo As Integer = 0
        Dim FieldType As String = String.Empty
        If TypeOf inputTable Is TorzsAdatbazisDataSet.Ceg_rogzitoDataTable Then FieldType = "[Cég neve]"
        If TypeOf inputTable Is TorzsAdatbazisDataSet.Term_szemely_rogzitoDataTable Then FieldType = "[Teljes név]"
        If TypeOf inputTable Is TorzsAdatbazisDataSet.Egyeb_szervezet_rogzitoDataTable Then FieldType = "[Szervezet megnevezése]"
        If TypeOf inputTable Is TorzsAdatbazisDataSet.EV_rogzitoDataTable Then FieldType = "Név"
        If TypeOf inputTable Is TorzsAdatbazisDataSet.Ugytorzs_rogzitoDataTable Then FieldType = "[Elsorendu_felperes neve]"
        Dim StartSearchString As String = String.Empty

        If inputText.First = "&" Then
            StartSearchString = " LIKE '"
            inputText = inputText.Substring(1)
        Else
            StartSearchString = " LIKE '%"
        End If

        If String.IsNullOrWhiteSpace(inputText) Then Return 0
        Dim param = FieldType & StartSearchString & inputText & "%'"
        Dim foundrows() = inputTable.Select(param)
        If foundrows.Count > 0 Then Return foundrows(0)("ID")
        If foundrows.Count = 0 AndAlso TypeOf inputTable Is TorzsAdatbazisDataSet.Ugytorzs_rogzitoDataTable Then
            Dim foundrows2() As TorzsAdatbazisDataSet.Ugytorzs_rogzitoRow = inputTable.Select("[Elsorendu_alperes neve]" & StartSearchString & inputText & "%'")
            If foundrows2.Count > 0 Then Return foundrows2(0)("ID")
        End If
        Return 0

    End Function

#End Region
End Module

