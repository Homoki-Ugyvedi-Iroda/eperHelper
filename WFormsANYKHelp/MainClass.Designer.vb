<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loader))
        Me.StatusStripLoader = New System.Windows.Forms.StatusStrip()
        Me.StripVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.InternetImg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusLogBookExport = New System.Windows.Forms.ToolStripStatusLabel()
        Me.HelpProviderLoader = New System.Windows.Forms.HelpProvider()
        Me.LogBook = New System.Windows.Forms.ListView()
        Me.ColumnDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnSender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnMessage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimerCheckInet2minutes = New System.Windows.Forms.Timer(Me.components)
        Me.Ribbon = New System.Windows.Forms.Ribbon()
        Me.Regisztráció = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.Súgó = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.Névjegy = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonSeparator1 = New System.Windows.Forms.RibbonSeparator()
        Me.Kilép = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.tabKészít = New System.Windows.Forms.RibbonTab()
        Me.pnlTörzsadattalkitölt = New System.Windows.Forms.RibbonPanel()
        Me.Ujnyomtatvanytorzsadattal = New System.Windows.Forms.RibbonButton()
        Me.pnlKRbeküldésrecsomagol = New System.Windows.Forms.RibbonPanel()
        Me.csomagenykbol = New System.Windows.Forms.RibbonButton()
        Me.csomagxmlbol = New System.Windows.Forms.RibbonButton()
        Me.pnlSablonFrissítés = New System.Windows.Forms.RibbonPanel()
        Me.sablonfrissitegyszer = New System.Windows.Forms.RibbonButton()
        Me.rbtnEperHelper = New System.Windows.Forms.RibbonButton()
        Me.All = New System.Windows.Forms.RibbonButton()
        Me.AllStartRefresh = New System.Windows.Forms.RibbonCheckBox()
        Me.Fresh = New System.Windows.Forms.RibbonButton()
        Me.FresherthanInstalled = New System.Windows.Forms.RibbonButton()
        Me.Indításkorfrissít = New System.Windows.Forms.RibbonButton()
        Me.rbnLabel = New System.Windows.Forms.RibbonLabel()
        Me.rbcbProgramSupportedRefresh = New System.Windows.Forms.RibbonCheckBox()
        Me.FreshStartRefresh = New System.Windows.Forms.RibbonCheckBox()
        Me.FresherthanInstalledStartRefresh = New System.Windows.Forms.RibbonCheckBox()
        Me.btnListázniRibbonbol = New System.Windows.Forms.RibbonButton()
        Me.pnlBeallitasSigTS = New System.Windows.Forms.RibbonPanel()
        Me.btnBeallitasSigTSEncr = New System.Windows.Forms.RibbonButton()
        Me.SetDefCert = New System.Windows.Forms.RibbonButton()
        Me.Titkosítókulcspár = New System.Windows.Forms.RibbonButton()
        Me.Archívidőbélyeg = New System.Windows.Forms.RibbonCheckBox()
        Me.deleteSettings = New System.Windows.Forms.RibbonButton()
        Me.btnAlairoPrgAtvetel = New System.Windows.Forms.RibbonButton()
        Me.tabNyit = New System.Windows.Forms.RibbonTab()
        Me.pnlMegtekintesANYKban = New System.Windows.Forms.RibbonPanel()
        Me.openxmlxkr = New System.Windows.Forms.RibbonButton()
        Me.openenyk = New System.Windows.Forms.RibbonButton()
        Me.csatolmannyalbemasol = New System.Windows.Forms.RibbonButton()
        Me.pnlPDFnyomtatvanybol = New System.Windows.Forms.RibbonPanel()
        Me.btnPDFnyomtatvanybol = New System.Windows.Forms.RibbonButton()
        Me.pnlExtract = New System.Windows.Forms.RibbonPanel()
        Me.extractkr = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton27 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton()
        Me.extractCST = New System.Windows.Forms.RibbonButton()
        Me.tabKapukezelés = New System.Windows.Forms.RibbonTab()
        Me.pnlUgyfelkapu = New System.Windows.Forms.RibbonPanel()
        Me.ukincoming = New System.Windows.Forms.RibbonButton()
        Me.ukupload = New System.Windows.Forms.RibbonButton()
        Me.uknew = New System.Windows.Forms.RibbonButton()
        Me.pnlPerkapu = New System.Windows.Forms.RibbonPanel()
        Me.pkpincoming = New System.Windows.Forms.RibbonButton()
        Me.pkpupload = New System.Windows.Forms.RibbonButton()
        Me.pkpadmin = New System.Windows.Forms.RibbonButton()
        Me.pnlHivatalikapu = New System.Windows.Forms.RibbonPanel()
        Me.hkpincoming = New System.Windows.Forms.RibbonButton()
        Me.hkpupload = New System.Windows.Forms.RibbonButton()
        Me.pnlUNamePassw = New System.Windows.Forms.RibbonPanel()
        Me.passwrecord = New System.Windows.Forms.RibbonButton()
        Me.passwexport = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnKuldEllenorzese = New System.Windows.Forms.RibbonButton()
        Me.tabTörzsadatok = New System.Windows.Forms.RibbonTab()
        Me.pnlTörzsadatokrögzítésekarbantartása = New System.Windows.Forms.RibbonPanel()
        Me.personkarb = New System.Windows.Forms.RibbonButton()
        Me.TSZ = New System.Windows.Forms.RibbonButton()
        Me.Ceg = New System.Windows.Forms.RibbonButton()
        Me.ESZ = New System.Windows.Forms.RibbonButton()
        Me.EV = New System.Windows.Forms.RibbonButton()
        Me.jkvkarb = New System.Windows.Forms.RibbonButton()
        Me.JK_UI = New System.Windows.Forms.RibbonButton()
        Me.JK_EU = New System.Windows.Forms.RibbonButton()
        Me.JK_JT = New System.Windows.Forms.RibbonButton()
        Me.JK_EJK = New System.Windows.Forms.RibbonButton()
        Me.Ügy = New System.Windows.Forms.RibbonButton()
        Me.Egyebtorzsadatok = New System.Windows.Forms.RibbonButton()
        Me.pnlTörzsadatimportálása = New System.Windows.Forms.RibbonPanel()
        Me.importonce = New System.Windows.Forms.RibbonButton()
        Me.importrepeat = New System.Windows.Forms.RibbonButton()
        Me.sample = New System.Windows.Forms.RibbonButton()
        Me.MintaCSV = New System.Windows.Forms.RibbonButton()
        Me.MintaMDB = New System.Windows.Forms.RibbonButton()
        Me.teszt = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton3 = New System.Windows.Forms.RibbonButton()
        Me.rbTörzsadat = New System.Windows.Forms.RibbonPanel()
        Me.btnTorzsadatChange = New System.Windows.Forms.RibbonButton()
        Me.tabEgyébbeállítás = New System.Windows.Forms.RibbonTab()
        Me.pnlNotifications = New System.Windows.Forms.RibbonPanel()
        Me.cbNoJava = New System.Windows.Forms.RibbonCheckBox()
        Me.cbNoSecretKey = New System.Windows.Forms.RibbonCheckBox()
        Me.pnlBackupsettings = New System.Windows.Forms.RibbonPanel()
        Me.savesettings = New System.Windows.Forms.RibbonButton()
        Me.RibbonButtonList1 = New System.Windows.Forms.RibbonButtonList()
        Me.loadsettings = New System.Windows.Forms.RibbonButton()
        Me.passwprint = New System.Windows.Forms.RibbonButton()
        Me.passwdeleteall = New System.Windows.Forms.RibbonButton()
        Me.btnRegFajl = New System.Windows.Forms.RibbonButton()
        Me.pnlOtherSettings = New System.Windows.Forms.RibbonPanel()
        Me.btnFoldersettings = New System.Windows.Forms.RibbonButton()
        Me.ÁNYKmentes = New System.Windows.Forms.RibbonButton()
        Me.ÁNYKroot = New System.Windows.Forms.RibbonButton()
        Me.Extract = New System.Windows.Forms.RibbonButton()
        Me.SentFile = New System.Windows.Forms.RibbonButton()
        Me.KRpost = New System.Windows.Forms.RibbonButton()
        Me.XKRXCZTársít = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.ÁNYKoszlopoknyitáshoz = New System.Windows.Forms.RibbonButton()
        Me.btnAVDHesKapuNoticeKi = New System.Windows.Forms.RibbonButton()
        Me.SetPreferredBrowser = New System.Windows.Forms.RibbonButton()
        Me.anykmappavissza = New System.Windows.Forms.RibbonButton()
        Me.tochange = New System.Windows.Forms.RibbonButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCloseJava = New System.Windows.Forms.Button()
        Me.gbeperHelpersupportedAll = New System.Windows.Forms.RadioButton()
        Me.gbAll = New System.Windows.Forms.RadioButton()
        Me.gbFresh = New System.Windows.Forms.RadioButton()
        Me.gbFresherthanInstalled = New System.Windows.Forms.RadioButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PanelJava = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPanelJava = New System.Windows.Forms.Label()
        Me.PanelJavaJobboldal = New System.Windows.Forms.Panel()
        Me.btnRecheckJava = New System.Windows.Forms.Button()
        Me.cbNoWarnJava = New System.Windows.Forms.CheckBox()
        Me.btnInstallJava = New System.Windows.Forms.Button()
        Me.PanelANYK = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelANYKJobboldal = New System.Windows.Forms.Panel()
        Me.btnRecheckANYK = New System.Windows.Forms.Button()
        Me.cbNoWarnANYK = New System.Windows.Forms.CheckBox()
        Me.btnCloseANYK = New System.Windows.Forms.Button()
        Me.btnInstallANYK = New System.Windows.Forms.Button()
        Me.lblPanelANYK = New System.Windows.Forms.Label()
        Me.PanelNyomtatvany = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPanelNyomtatvany = New System.Windows.Forms.Label()
        Me.PanelOBHJobboldal = New System.Windows.Forms.Panel()
        Me.btnListazPanelbol = New System.Windows.Forms.Button()
        Me.btnCloseNyomtatvany = New System.Windows.Forms.Button()
        Me.btnTelepit = New System.Windows.Forms.Button()
        Me.gbNyomtatvany = New System.Windows.Forms.GroupBox()
        Me.StatusStripLoader.SuspendLayout()
        Me.PanelJava.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelJavaJobboldal.SuspendLayout()
        Me.PanelANYK.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanelANYKJobboldal.SuspendLayout()
        Me.PanelNyomtatvany.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.PanelOBHJobboldal.SuspendLayout()
        Me.gbNyomtatvany.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStripLoader
        '
        Me.StatusStripLoader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StripVersion, Me.InternetImg, Me.ProgressBar1, Me.StatusLogBookExport})
        Me.StatusStripLoader.Location = New System.Drawing.Point(3, 717)
        Me.StatusStripLoader.MaximumSize = New System.Drawing.Size(400, 0)
        Me.StatusStripLoader.Name = "StatusStripLoader"
        Me.StatusStripLoader.Size = New System.Drawing.Size(400, 22)
        Me.StatusStripLoader.SizingGrip = False
        Me.StatusStripLoader.Stretch = False
        Me.StatusStripLoader.TabIndex = 0
        Me.StatusStripLoader.Text = "StatusStripLoader"
        '
        'StripVersion
        '
        Me.StripVersion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.StripVersion.Name = "StripVersion"
        Me.StripVersion.Size = New System.Drawing.Size(292, 17)
        Me.StripVersion.Text = "{My.Application.Deployment.CurrentVersion.ToString}"
        Me.StripVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StripVersion.ToolTipText = "A program jelenlegi verziószáma"
        '
        'InternetImg
        '
        Me.InternetImg.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.InternetImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InternetImg.Name = "InternetImg"
        Me.InternetImg.Size = New System.Drawing.Size(0, 17)
        Me.InternetImg.Text = "InternetImg"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(50, 16)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.ToolTipText = "Letöltési vagy kapu csatlakozási folyamat jelzése"
        '
        'StatusLogBookExport
        '
        Me.StatusLogBookExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StatusLogBookExport.Image = CType(resources.GetObject("StatusLogBookExport.Image"), System.Drawing.Image)
        Me.StatusLogBookExport.Name = "StatusLogBookExport"
        Me.StatusLogBookExport.Size = New System.Drawing.Size(16, 17)
        Me.StatusLogBookExport.Text = "StatusLogBookExport"
        Me.StatusLogBookExport.ToolTipText = "Exportálja az alkalmazásnapló tartalmát (hibakereséshez) és a teljes képernyőt le" &
    "menti"
        '
        'LogBook
        '
        Me.LogBook.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LogBook.BackColor = System.Drawing.SystemColors.Control
        Me.LogBook.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnDate, Me.ColumnSender, Me.ColumnType, Me.ColumnMessage})
        Me.LogBook.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogBook.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LogBook.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LogBook.GridLines = True
        Me.LogBook.Location = New System.Drawing.Point(3, 477)
        Me.LogBook.MultiSelect = False
        Me.LogBook.Name = "LogBook"
        Me.LogBook.ShowGroups = False
        Me.LogBook.Size = New System.Drawing.Size(1002, 240)
        Me.LogBook.TabIndex = 1
        Me.LogBook.UseCompatibleStateImageBehavior = False
        Me.LogBook.View = System.Windows.Forms.View.Details
        '
        'ColumnDate
        '
        Me.ColumnDate.Text = "Idő"
        Me.ColumnDate.Width = 110
        '
        'ColumnSender
        '
        Me.ColumnSender.Text = "Funkció"
        Me.ColumnSender.Width = 132
        '
        'ColumnType
        '
        Me.ColumnType.Text = "Típus"
        Me.ColumnType.Width = 45

        '
        'ColumnMessage
        '
        Me.ColumnMessage.Text = "Üzenet"
        Me.ColumnMessage.Width = 670
        '
        'TimerCheckInet2minutes
        '
        Me.TimerCheckInet2minutes.Interval = 120000
        '
        'Ribbon
        '
        Me.Ribbon.Cursor = System.Windows.Forms.Cursors.Default
        Me.Ribbon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon.Location = New System.Drawing.Point(3, 3)
        Me.Ribbon.Minimized = False
        Me.Ribbon.Name = "Ribbon"
        '
        '
        '
        Me.Ribbon.OrbDropDown.BorderRoundness = 8
        Me.Ribbon.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon.OrbDropDown.MenuItems.Add(Me.Regisztráció)
        Me.Ribbon.OrbDropDown.MenuItems.Add(Me.Súgó)
        Me.Ribbon.OrbDropDown.MenuItems.Add(Me.Névjegy)
        Me.Ribbon.OrbDropDown.MenuItems.Add(Me.RibbonSeparator1)
        Me.Ribbon.OrbDropDown.MenuItems.Add(Me.Kilép)
        Me.Ribbon.OrbDropDown.Name = ""
        Me.Ribbon.OrbDropDown.Size = New System.Drawing.Size(527, 251)
        Me.Ribbon.OrbDropDown.TabIndex = 0
        Me.Ribbon.OrbImage = Nothing
        Me.Ribbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon.OrbText = "Regisztráció, súgó, kilépés"
        '
        '
        '
        Me.Ribbon.QuickAcessToolbar.Text = "QAT"
        Me.Ribbon.QuickAcessToolbar.Value = "teszt"
        Me.Ribbon.QuickAcessToolbar.Visible = False
        Me.Ribbon.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon.Size = New System.Drawing.Size(1002, 144)
        Me.Ribbon.TabIndex = 5
        Me.Ribbon.Tabs.Add(Me.tabKészít)
        Me.Ribbon.Tabs.Add(Me.tabNyit)
        Me.Ribbon.Tabs.Add(Me.tabKapukezelés)
        Me.Ribbon.Tabs.Add(Me.tabTörzsadatok)
        Me.Ribbon.Tabs.Add(Me.tabEgyébbeállítás)
        Me.Ribbon.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon.Text = "Ribbon"
        Me.Ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Halloween
        '
        'Regisztráció
        '
        Me.Regisztráció.AltKey = "r"
        Me.Regisztráció.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.Regisztráció.Image = CType(resources.GetObject("Regisztráció.Image"), System.Drawing.Image)
        Me.Regisztráció.SmallImage = CType(resources.GetObject("Regisztráció.SmallImage"), System.Drawing.Image)
        Me.Regisztráció.Text = "Regisztráció"
        '
        'Súgó
        '
        Me.Súgó.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.Súgó.Image = CType(resources.GetObject("Súgó.Image"), System.Drawing.Image)
        Me.Súgó.SmallImage = CType(resources.GetObject("Súgó.SmallImage"), System.Drawing.Image)
        Me.Súgó.Text = "Súgó"
        '
        'Névjegy
        '
        Me.Névjegy.AltKey = ""
        Me.Névjegy.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.Névjegy.Image = CType(resources.GetObject("Névjegy.Image"), System.Drawing.Image)
        Me.Névjegy.SmallImage = CType(resources.GetObject("Névjegy.SmallImage"), System.Drawing.Image)
        Me.Névjegy.Text = "Névjegy"
        '
        'Kilép
        '
        Me.Kilép.AltKey = "k"
        Me.Kilép.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.Kilép.Image = CType(resources.GetObject("Kilép.Image"), System.Drawing.Image)
        Me.Kilép.SmallImage = CType(resources.GetObject("Kilép.SmallImage"), System.Drawing.Image)
        Me.Kilép.Text = "Kilép"
        '
        'tabKészít
        '
        Me.tabKészít.Panels.Add(Me.pnlTörzsadattalkitölt)
        Me.tabKészít.Panels.Add(Me.pnlKRbeküldésrecsomagol)
        Me.tabKészít.Panels.Add(Me.pnlSablonFrissítés)
        Me.tabKészít.Panels.Add(Me.pnlBeallitasSigTS)
        Me.tabKészít.Text = "Készít"
        '
        'pnlTörzsadattalkitölt
        '
        Me.pnlTörzsadattalkitölt.Items.Add(Me.Ujnyomtatvanytorzsadattal)
        Me.pnlTörzsadattalkitölt.Text = ""
        '
        'Ujnyomtatvanytorzsadattal
        '
        Me.Ujnyomtatvanytorzsadattal.Image = CType(resources.GetObject("Ujnyomtatvanytorzsadattal.Image"), System.Drawing.Image)
        Me.Ujnyomtatvanytorzsadattal.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Ujnyomtatvanytorzsadattal.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.Ujnyomtatvanytorzsadattal.SmallImage = CType(resources.GetObject("Ujnyomtatvanytorzsadattal.SmallImage"), System.Drawing.Image)
        Me.Ujnyomtatvanytorzsadattal.Text = "Új nyomtatvány törzsadatból"
        Me.Ujnyomtatvanytorzsadattal.ToolTip = "Készítsen új ÁNYK nyomtatványt a Törzsadatbázisában kitöltött adatokkal (lásd Tör" &
    "zsadatok karbantartása)"
        '
        'pnlKRbeküldésrecsomagol
        '
        Me.pnlKRbeküldésrecsomagol.Items.Add(Me.csomagenykbol)
        Me.pnlKRbeküldésrecsomagol.Items.Add(Me.csomagxmlbol)
        Me.pnlKRbeküldésrecsomagol.Text = "KR beküldésre: csatolmány+aláírás"
        '
        'csomagenykbol
        '
        Me.csomagenykbol.Image = CType(resources.GetObject("csomagenykbol.Image"), System.Drawing.Image)
        Me.csomagenykbol.SmallImage = CType(resources.GetObject("csomagenykbol.SmallImage"), System.Drawing.Image)
        Me.csomagenykbol.Text = "Csomag ENYK-ből"
        Me.csomagenykbol.ToolTip = "Az ÁNYK-ban kitöltött és elmentett ENYK-végű nyomtatványból készítsen KR csomagot" &
    " és küldje be"
        '
        'csomagxmlbol
        '
        Me.csomagxmlbol.Image = CType(resources.GetObject("csomagxmlbol.Image"), System.Drawing.Image)
        Me.csomagxmlbol.SmallImage = CType(resources.GetObject("csomagxmlbol.SmallImage"), System.Drawing.Image)
        Me.csomagxmlbol.Text = "Csomag XML-ből"
        Me.csomagxmlbol.ToolTip = "Az ÁNYK-ban korábban elkészített XML vagy XKR nyomtatványból készítsen KR csomago" &
    "t és küldje be"
        '
        'pnlSablonFrissítés
        '
        Me.pnlSablonFrissítés.Items.Add(Me.sablonfrissitegyszer)
        Me.pnlSablonFrissítés.Items.Add(Me.Indításkorfrissít)
        Me.pnlSablonFrissítés.Items.Add(Me.btnListázniRibbonbol)
        Me.pnlSablonFrissítés.Text = "Elérhető sablonok frissítése"
        '
        'sablonfrissitegyszer
        '
        Me.sablonfrissitegyszer.DropDownItems.Add(Me.rbtnEperHelper)
        Me.sablonfrissitegyszer.DropDownItems.Add(Me.All)
        Me.sablonfrissitegyszer.DropDownItems.Add(Me.Fresh)
        Me.sablonfrissitegyszer.DropDownItems.Add(Me.FresherthanInstalled)
        Me.sablonfrissitegyszer.Image = CType(resources.GetObject("sablonfrissitegyszer.Image"), System.Drawing.Image)
        Me.sablonfrissitegyszer.SmallImage = CType(resources.GetObject("sablonfrissitegyszer.SmallImage"), System.Drawing.Image)
        Me.sablonfrissitegyszer.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.sablonfrissitegyszer.Text = "Egyszeri frissítés"
        Me.sablonfrissitegyszer.ToolTip = "Ellenőrizze a gépén telepített OBH-s nyomtatványsablonokat, hogy a legfrissebbek-" &
    "e"
        '
        'rbtnEperHelper
        '
        Me.rbtnEperHelper.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.rbtnEperHelper.Image = CType(resources.GetObject("rbtnEperHelper.Image"), System.Drawing.Image)
        Me.rbtnEperHelper.SmallImage = CType(resources.GetObject("rbtnEperHelper.SmallImage"), System.Drawing.Image)
        Me.rbtnEperHelper.Text = "Minden, amit az eperHelperben kitölthet"
        Me.rbtnEperHelper.ToolTip = "Töltse le az összes olyan nyomtatványsablont, amit az eperHelper kitöltésnél támo" &
    "gat"
        Me.rbtnEperHelper.Value = ""
        '
        'All
        '
        Me.All.AltKey = "m"
        Me.All.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.All.DropDownItems.Add(Me.AllStartRefresh)
        Me.All.Image = CType(resources.GetObject("All.Image"), System.Drawing.Image)
        Me.All.SmallImage = CType(resources.GetObject("All.SmallImage"), System.Drawing.Image)
        Me.All.Text = "Minden elérhető verzió (régi is)"
        Me.All.ToolTip = "Ez a régi nyomtatványsablon verziókat is letölti, ami hasznos lehet, ha régi verz" &
    "iójú sablonok alapján készült nyomtatványt szeretnénk olvasni"
        '
        'AllStartRefresh
        '
        Me.AllStartRefresh.CheckedGroup = "startfresh"
        Me.AllStartRefresh.Text = "Minden elérhető verzió (régi is)"
        Me.AllStartRefresh.ToolTip = "Ez a régi nyomtatványsablon verziókat is letölti, ami hasznos lehet, ha régi verz" &
    "iójú sablonok alapján készült nyomtatványt szeretnénk olvasni"
        '
        'Fresh
        '
        Me.Fresh.AltKey = "f"
        Me.Fresh.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.Fresh.Image = CType(resources.GetObject("Fresh.Image"), System.Drawing.Image)
        Me.Fresh.SmallImage = CType(resources.GetObject("Fresh.SmallImage"), System.Drawing.Image)
        Me.Fresh.Text = "Összes legfrissebb verzió"
        Me.Fresh.ToolTip = "Ha nem akarunk régi verziójú nyomtatványokat olvasni"
        '
        'FresherthanInstalled
        '
        Me.FresherthanInstalled.AltKey = "t"
        Me.FresherthanInstalled.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.FresherthanInstalled.Image = CType(resources.GetObject("FresherthanInstalled.Image"), System.Drawing.Image)
        Me.FresherthanInstalled.SmallImage = CType(resources.GetObject("FresherthanInstalled.SmallImage"), System.Drawing.Image)
        Me.FresherthanInstalled.Text = "Már telepítettből elérhető új verzió"
        Me.FresherthanInstalled.ToolTip = "Csak a már telepített sablonokból keresi meg, hogy van-e újabb verzió"
        '
        'Indításkorfrissít
        '
        Me.Indításkorfrissít.DropDownItems.Add(Me.rbnLabel)
        Me.Indításkorfrissít.DropDownItems.Add(Me.rbcbProgramSupportedRefresh)
        Me.Indításkorfrissít.DropDownItems.Add(Me.AllStartRefresh)
        Me.Indításkorfrissít.DropDownItems.Add(Me.FreshStartRefresh)
        Me.Indításkorfrissít.DropDownItems.Add(Me.FresherthanInstalledStartRefresh)
        Me.Indításkorfrissít.Image = CType(resources.GetObject("Indításkorfrissít.Image"), System.Drawing.Image)
        Me.Indításkorfrissít.SmallImage = CType(resources.GetObject("Indításkorfrissít.SmallImage"), System.Drawing.Image)
        Me.Indításkorfrissít.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.Indításkorfrissít.Text = "Indításkor frissít"
        Me.Indításkorfrissít.ToolTip = "Állítsa be, hogy az eperHelper automatikusan ellenőrizze induláskor az OBH által " &
    "közzétett sablonokat"
        '
        'rbnLabel
        '
        Me.rbnLabel.Text = "Minden indításkor frissítse az alábbi sablonokat"
        '
        'rbcbProgramSupportedRefresh
        '
        Me.rbcbProgramSupportedRefresh.CheckedGroup = "startfresh"
        Me.rbcbProgramSupportedRefresh.Text = "Mindent, amit az eperHelperben kitölthet"
        Me.rbcbProgramSupportedRefresh.ToolTip = "Töltse le az összes olyan nyomtatványsablont, amit az eperHelper kitöltésnél támo" &
    "gat"
        '
        'FreshStartRefresh
        '
        Me.FreshStartRefresh.CheckedGroup = "startfresh"
        Me.FreshStartRefresh.Text = "Összes legfrissebb verzió"
        Me.FreshStartRefresh.ToolTip = "Ha nem akarunk régi verziójú nyomtatványokat olvasni"
        '
        'FresherthanInstalledStartRefresh
        '
        Me.FresherthanInstalledStartRefresh.CheckedGroup = "startfresh"
        Me.FresherthanInstalledStartRefresh.Text = "Már telepítettből elérhető új verzió"
        Me.FresherthanInstalledStartRefresh.ToolTip = "Csak a már telepített sablonokból keresi meg, hogy van-e újabb verzió"
        '
        'btnListázniRibbonbol
        '
        Me.btnListázniRibbonbol.Image = CType(resources.GetObject("btnListázniRibbonbol.Image"), System.Drawing.Image)
        Me.btnListázniRibbonbol.SmallImage = CType(resources.GetObject("btnListázniRibbonbol.SmallImage"), System.Drawing.Image)
        Me.btnListázniRibbonbol.Text = "Új sablonok listája"
        Me.btnListázniRibbonbol.ToolTip = "Itt nézheti meg a korábban letöltött ellenőrzések szerint elérhető sablonok listá" &
    "ját, és azt a listát is, hogy melyek letöltése során merült fel hiba"
        '
        'pnlBeallitasSigTS
        '
        Me.pnlBeallitasSigTS.Items.Add(Me.btnBeallitasSigTSEncr)
        Me.pnlBeallitasSigTS.Items.Add(Me.btnAlairoPrgAtvetel)
        Me.pnlBeallitasSigTS.Text = "Aláírás, időbélyeg, titkosító kulcs"
        '
        'btnBeallitasSigTSEncr
        '
        Me.btnBeallitasSigTSEncr.DropDownItems.Add(Me.SetDefCert)
        Me.btnBeallitasSigTSEncr.DropDownItems.Add(Me.Titkosítókulcspár)
        Me.btnBeallitasSigTSEncr.DropDownItems.Add(Me.Archívidőbélyeg)
        Me.btnBeallitasSigTSEncr.DropDownItems.Add(Me.deleteSettings)
        Me.btnBeallitasSigTSEncr.Image = CType(resources.GetObject("btnBeallitasSigTSEncr.Image"), System.Drawing.Image)
        Me.btnBeallitasSigTSEncr.SmallImage = CType(resources.GetObject("btnBeallitasSigTSEncr.SmallImage"), System.Drawing.Image)
        Me.btnBeallitasSigTSEncr.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.btnBeallitasSigTSEncr.Text = "Beállítások"
        Me.btnBeallitasSigTSEncr.ToolTip = "A KR csomaghoz szükséges e-aláíró és időbélyegző tanúsítványok beállítása, és a s" &
    "aját beadvány olvasához is szükséges titkosító kulcsok létrehozása, beállítása"
        '
        'SetDefCert
        '
        Me.SetDefCert.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.SetDefCert.Image = CType(resources.GetObject("SetDefCert.Image"), System.Drawing.Image)
        Me.SetDefCert.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.SetDefCert.SmallImage = CType(resources.GetObject("SetDefCert.SmallImage"), System.Drawing.Image)
        Me.SetDefCert.Text = "Aláíró és időbélyeg tanúsítvány"
        Me.SetDefCert.ToolTip = "Itt állíthatja be az aláíró és időbélyeg tanúsítványokat"
        '
        'Titkosítókulcspár
        '
        Me.Titkosítókulcspár.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.Titkosítókulcspár.Image = CType(resources.GetObject("Titkosítókulcspár.Image"), System.Drawing.Image)
        Me.Titkosítókulcspár.SmallImage = CType(resources.GetObject("Titkosítókulcspár.SmallImage"), System.Drawing.Image)
        Me.Titkosítókulcspár.Text = "Titkosító kulcspár"
        Me.Titkosítókulcspár.ToolTip = "Ha a saját, beküldött KR-csomagunkat is szeretnénk tudni kititkosítani, itt állít" &
    "sunk be egy saját titkosító kulcspárat."
        '
        'Archívidőbélyeg
        '
        Me.Archívidőbélyeg.Checked = True
        Me.Archívidőbélyeg.Text = "Archív időbélyeg"
        Me.Archívidőbélyeg.ToolTip = "Archív időbélyeget helyezzen-e el a létrehozott aktákon (így 10 évig tudjuk önmag" &
    "ában is biztosítani a megőrzési időt, de ez plusz időbélyeget fog igényelnil)"
        '
        'deleteSettings
        '
        Me.deleteSettings.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.deleteSettings.Image = CType(resources.GetObject("deleteSettings.Image"), System.Drawing.Image)
        Me.deleteSettings.SmallImage = CType(resources.GetObject("deleteSettings.SmallImage"), System.Drawing.Image)
        Me.deleteSettings.Text = "Tanúsítványok beállításának törlése"
        Me.deleteSettings.ToolTip = "A beállított tanúsítványokat felejtse el az eperHelper"
        '
        'btnAlairoPrgAtvetel
        '
        Me.btnAlairoPrgAtvetel.Image = CType(resources.GetObject("btnAlairoPrgAtvetel.Image"), System.Drawing.Image)
        Me.btnAlairoPrgAtvetel.MinimumSize = New System.Drawing.Size(120, 0)
        Me.btnAlairoPrgAtvetel.SmallImage = CType(resources.GetObject("btnAlairoPrgAtvetel.SmallImage"), System.Drawing.Image)
        Me.btnAlairoPrgAtvetel.Text = "Beállítás import aláíró programból"
        Me.btnAlairoPrgAtvetel.ToolTip = "Kísérelje meg a telepített Microsec e-Szignó vagy Netlock MOKKA alkalmazásban lév" &
    "ő egyes beállítások átvételét"
        '
        'tabNyit
        '
        Me.tabNyit.Panels.Add(Me.pnlMegtekintesANYKban)
        Me.tabNyit.Panels.Add(Me.pnlPDFnyomtatvanybol)
        Me.tabNyit.Panels.Add(Me.pnlExtract)
        Me.tabNyit.Text = "Megnyit, kicsomagol"
        '
        'pnlMegtekintesANYKban
        '
        Me.pnlMegtekintesANYKban.Items.Add(Me.openxmlxkr)
        Me.pnlMegtekintesANYKban.Items.Add(Me.openenyk)
        Me.pnlMegtekintesANYKban.Items.Add(Me.csatolmannyalbemasol)
        Me.pnlMegtekintesANYKban.Text = "Megtekintés ÁNYK-ban"
        '
        'openxmlxkr
        '
        Me.openxmlxkr.AltKey = "x"
        Me.openxmlxkr.Image = CType(resources.GetObject("openxmlxkr.Image"), System.Drawing.Image)
        Me.openxmlxkr.SmallImage = CType(resources.GetObject("openxmlxkr.SmallImage"), System.Drawing.Image)
        Me.openxmlxkr.Text = "XML/XKR nyomtatvány"
        Me.openxmlxkr.ToolTip = "Az ÁNYK segítségével nyissa meg az ÁNYK által olvasható XML vagy XKR dokumentumok" &
    "at (az ÁNYK-ban a véglegesített nyomtatványokat jelölik ilyen kiterjesztéssel)"
        '
        'openenyk
        '
        Me.openenyk.AltKey = "e"
        Me.openenyk.Image = CType(resources.GetObject("openenyk.Image"), System.Drawing.Image)
        Me.openenyk.SmallImage = CType(resources.GetObject("openenyk.SmallImage"), System.Drawing.Image)
        Me.openenyk.Text = "ENYK nyomtatvány"
        Me.openenyk.ToolTip = "Az ÁNYK segítségével nyissa meg az ÁNYK által olvasható ENYK-végű állományokat (a" &
    "z ÁNYK-ban tipikusan ezek a módosítható, nem véglegesített dokumentumok)"
        '
        'csatolmannyalbemasol
        '
        Me.csatolmannyalbemasol.Enabled = False
        Me.csatolmannyalbemasol.Image = CType(resources.GetObject("csatolmannyalbemasol.Image"), System.Drawing.Image)
        Me.csatolmannyalbemasol.SmallImage = CType(resources.GetObject("csatolmannyalbemasol.SmallImage"), System.Drawing.Image)
        Me.csatolmannyalbemasol.Text = "Csatolmánnyal bemásol módosításra ÁNYK-ba"
        Me.csatolmannyalbemasol.ToolTip = "A kijelölt mappából a félkész nyomtatványt bemásolja az ÁNYK mentési könyvtárába " &
    "(így az az ÁNYK-val módosítható, beküldhető)"
        Me.csatolmannyalbemasol.Visible = False
        '
        'pnlPDFnyomtatvanybol
        '
        Me.pnlPDFnyomtatvanybol.Items.Add(Me.btnPDFnyomtatvanybol)
        Me.pnlPDFnyomtatvanybol.Text = ""
        '
        'btnPDFnyomtatvanybol
        '
        Me.btnPDFnyomtatvanybol.AltKey = "p"
        Me.btnPDFnyomtatvanybol.Image = CType(resources.GetObject("btnPDFnyomtatvanybol.Image"), System.Drawing.Image)
        Me.btnPDFnyomtatvanybol.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnPDFnyomtatvanybol.SmallImage = CType(resources.GetObject("btnPDFnyomtatvanybol.SmallImage"), System.Drawing.Image)
        Me.btnPDFnyomtatvanybol.Text = "PDF készítése nyomtatványból"
        Me.btnPDFnyomtatvanybol.ToolTip = "Az ÁNYK-ból olvasható XML-ből vagy XKR-ből készítsen bárhonnan olvasható PDF-et (" &
    "ha az adott XML/XKR-hez tartozó sablon telepítve van a gépére)"
        '
        'pnlExtract
        '
        Me.pnlExtract.Items.Add(Me.extractkr)
        Me.pnlExtract.Items.Add(Me.extractCST)
        Me.pnlExtract.Text = ""
        '
        'extractkr
        '
        Me.extractkr.AltKey = "k"
        Me.extractkr.DropDownItems.Add(Me.RibbonButton27)
        Me.extractkr.DropDownItems.Add(Me.RibbonButton2)
        Me.extractkr.Image = CType(resources.GetObject("extractkr.Image"), System.Drawing.Image)
        Me.extractkr.MinimumSize = New System.Drawing.Size(140, 0)
        Me.extractkr.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.extractkr.SmallImage = CType(resources.GetObject("extractkr.SmallImage"), System.Drawing.Image)
        Me.extractkr.Text = "KR kicsomagolása, betekintés"
        Me.extractkr.ToolTip = "Ha rendelkezik a megfelelő kititkosító kulccsal, nyissa meg és olvassa a KR csoma" &
    "got"
        '
        'RibbonButton27
        '
        Me.RibbonButton27.Image = CType(resources.GetObject("RibbonButton27.Image"), System.Drawing.Image)
        Me.RibbonButton27.SmallImage = CType(resources.GetObject("RibbonButton27.SmallImage"), System.Drawing.Image)
        Me.RibbonButton27.Text = "RibbonButton27"
        '
        'RibbonButton2
        '
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Text = "RibbonButton2"
        '
        'extractCST
        '
        Me.extractCST.Image = CType(resources.GetObject("extractCST.Image"), System.Drawing.Image)
        Me.extractCST.MinimumSize = New System.Drawing.Size(140, 0)
        Me.extractCST.SmallImage = CType(resources.GetObject("extractCST.SmallImage"), System.Drawing.Image)
        Me.extractCST.Text = "CST kicsomagolása, betekintés"
        Me.extractCST.ToolTip = "A kicsomagolt KR csomagban néha egy CST dokumentumot találhatunk. Nézzen bele a C" &
    "ST-be vagy csomagolja ki azt ezzel a menüponttal"
        '
        'tabKapukezelés
        '
        Me.tabKapukezelés.Panels.Add(Me.pnlUgyfelkapu)
        Me.tabKapukezelés.Panels.Add(Me.pnlPerkapu)
        Me.tabKapukezelés.Panels.Add(Me.pnlHivatalikapu)
        Me.tabKapukezelés.Panels.Add(Me.pnlUNamePassw)
        Me.tabKapukezelés.Panels.Add(Me.RibbonPanel1)
        Me.tabKapukezelés.Text = "Kapukezelés"
        '
        'pnlUgyfelkapu
        '
        Me.pnlUgyfelkapu.Items.Add(Me.ukincoming)
        Me.pnlUgyfelkapu.Items.Add(Me.ukupload)
        Me.pnlUgyfelkapu.Items.Add(Me.uknew)
        Me.pnlUgyfelkapu.Text = "Ügyfélkapu"
        '
        'ukincoming
        '
        Me.ukincoming.AltKey = "ub"
        Me.ukincoming.Image = CType(resources.GetObject("ukincoming.Image"), System.Drawing.Image)
        Me.ukincoming.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.ukincoming.SmallImage = CType(resources.GetObject("ukincoming.SmallImage"), System.Drawing.Image)
        Me.ukincoming.Text = "Beérkezett"
        Me.ukincoming.ToolTip = "Nyissa meg az ügyfélkapu beérkezett dokumentumok mappáját (ha már beállította a h" &
    "elyes felhasználónevét és jelszavát)"
        '
        'ukupload
        '
        Me.ukupload.AltKey = "uf"
        Me.ukupload.Image = CType(resources.GetObject("ukupload.Image"), System.Drawing.Image)
        Me.ukupload.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.ukupload.SmallImage = CType(resources.GetObject("ukupload.SmallImage"), System.Drawing.Image)
        Me.ukupload.Text = "Feltöltéshez megnyit"
        Me.ukupload.ToolTip = "Nyissa meg böngészőben az ügyfélkapu feltöltés célját szolgáló mappáját (figyelem" &
    ", maximum kb. 50 MB tölthető föl csak így!)"
        '
        'uknew
        '
        Me.uknew.Image = CType(resources.GetObject("uknew.Image"), System.Drawing.Image)
        Me.uknew.SmallImage = CType(resources.GetObject("uknew.SmallImage"), System.Drawing.Image)
        Me.uknew.Text = "Új igényléséről"
        Me.uknew.ToolTip = "Itt olvassan részletesebb információt arról a NISZ-től, hogy miként nyithat új üg" &
    "yfélkaput"
        '
        'pnlPerkapu
        '
        Me.pnlPerkapu.Items.Add(Me.pkpincoming)
        Me.pnlPerkapu.Items.Add(Me.pkpupload)
        Me.pnlPerkapu.Items.Add(Me.pkpadmin)
        Me.pnlPerkapu.Text = "Perkapu"
        '
        'pkpincoming
        '
        Me.pkpincoming.AltKey = "pb"
        Me.pkpincoming.Image = CType(resources.GetObject("pkpincoming.Image"), System.Drawing.Image)
        Me.pkpincoming.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.pkpincoming.SmallImage = CType(resources.GetObject("pkpincoming.SmallImage"), System.Drawing.Image)
        Me.pkpincoming.Text = "Beérkezett"
        Me.pkpincoming.ToolTip = "Nyissa meg a perkapu beérkezett dokumentumok mappáját (ha már beállította a helye" &
    "s perkapu és ügyfélkapu felhasználónevét és jelszavát)"
        '
        'pkpupload
        '
        Me.pkpupload.AltKey = "pf"
        Me.pkpupload.Image = CType(resources.GetObject("pkpupload.Image"), System.Drawing.Image)
        Me.pkpupload.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.pkpupload.SmallImage = CType(resources.GetObject("pkpupload.SmallImage"), System.Drawing.Image)
        Me.pkpupload.Text = "Feltöltéshez megnyit"
        Me.pkpupload.ToolTip = "Nyissa meg böngészőben a perkapu feltöltés célját szolgáló mappáját (figyelem, ma" &
    "ximum kb. 50 MB tölthető föl csak így!)"
        '
        'pkpadmin
        '
        Me.pkpadmin.Image = CType(resources.GetObject("pkpadmin.Image"), System.Drawing.Image)
        Me.pkpadmin.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.pkpadmin.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.pkpadmin.SmallImage = CType(resources.GetObject("pkpadmin.SmallImage"), System.Drawing.Image)
        Me.pkpadmin.Text = "Létrehoz, adminisztrál"
        Me.pkpadmin.ToolTip = "Nyissa meg az adott ügyfélkapu felhasználóhoz tartozó perkapu adminisztrációs old" &
    "alát (perkapu létrehozása, törlése, új ügykezelő felvétele stb.)"
        '
        'pnlHivatalikapu
        '
        Me.pnlHivatalikapu.Items.Add(Me.hkpincoming)
        Me.pnlHivatalikapu.Items.Add(Me.hkpupload)
        Me.pnlHivatalikapu.Text = "Hivatali kapu"
        '
        'hkpincoming
        '
        Me.hkpincoming.AltKey = "hb"
        Me.hkpincoming.Image = CType(resources.GetObject("hkpincoming.Image"), System.Drawing.Image)
        Me.hkpincoming.SmallImage = CType(resources.GetObject("hkpincoming.SmallImage"), System.Drawing.Image)
        Me.hkpincoming.Text = "Beérkezett"
        Me.hkpincoming.ToolTip = "Nyissa meg a hivatali kapu beérkezett dokumentumok mappáját (ha már beállította a" &
    " helyes hivatali kapu és ügyfélkapu felhasználónevét és jelszavát)"
        '
        'hkpupload
        '
        Me.hkpupload.AltKey = "hf"
        Me.hkpupload.Image = CType(resources.GetObject("hkpupload.Image"), System.Drawing.Image)
        Me.hkpupload.SmallImage = CType(resources.GetObject("hkpupload.SmallImage"), System.Drawing.Image)
        Me.hkpupload.Text = "Feltöltéshez megnyit"
        Me.hkpupload.ToolTip = "Nyissa meg böngészőben a hivatali kapu feltöltés célját szolgáló mappáját (figyel" &
    "em, maximum kb. 50 MB tölthető föl csak így!)"
        '
        'pnlUNamePassw
        '
        Me.pnlUNamePassw.Items.Add(Me.passwrecord)
        Me.pnlUNamePassw.Items.Add(Me.passwexport)
        Me.pnlUNamePassw.Text = "Kapus felhasználónév és jelszó"
        '
        'passwrecord
        '
        Me.passwrecord.AltKey = "r"
        Me.passwrecord.Image = CType(resources.GetObject("passwrecord.Image"), System.Drawing.Image)
        Me.passwrecord.MinimumSize = New System.Drawing.Size(90, 0)
        Me.passwrecord.SmallImage = CType(resources.GetObject("passwrecord.SmallImage"), System.Drawing.Image)
        Me.passwrecord.Text = "Hitelesítési adatok"
        Me.passwrecord.ToolTip = "A kapuk használatához szükséges felhasználóneveket és jelszavakat rögzíthetjük. (" &
    "Titkosított formában tárolja a program, csak ugyanazon Windows felhasználónál le" &
    "sz visszaolvasható)"
        '
        'passwexport
        '
        Me.passwexport.AltKey = "e"
        Me.passwexport.Enabled = False
        Me.passwexport.Image = CType(resources.GetObject("passwexport.Image"), System.Drawing.Image)
        Me.passwexport.SmallImage = CType(resources.GetObject("passwexport.SmallImage"), System.Drawing.Image)
        Me.passwexport.Text = "Exportál (olvasható)"
        Me.passwexport.ToolTipTitle = "A gombbal exportálja a kapuval kapcsolatos felhasználóneveket és jelszavakat egy " &
    "olvasható szövegfájlba"
        Me.passwexport.Visible = False
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.btnKuldEllenorzese)
        Me.RibbonPanel1.Text = ""
        '
        'btnKuldEllenorzese
        '
        Me.btnKuldEllenorzese.Image = Global.homoki.eperhelper.My.Resources.Resources.StatusAnnotations_Help_and_inconclusive_16xLG_color
        Me.btnKuldEllenorzese.SmallImage = CType(resources.GetObject("btnKuldEllenorzese.SmallImage"), System.Drawing.Image)
        Me.btnKuldEllenorzese.Text = "Kapun küldött dokumentum ellenőrzése"
        Me.btnKuldEllenorzese.ToolTip = "Ha vitatott, hogy milyen dokumentumot is kapott meg a központi rendszeren, ezzel " &
    "ellenőrizheti a PDF-es igazolás szerinti kód (ún. SHA1 lenyomat) és egy konkrét " &
    "fájl azonosságát"
        '
        'tabTörzsadatok
        '
        Me.tabTörzsadatok.Panels.Add(Me.pnlTörzsadatokrögzítésekarbantartása)
        Me.tabTörzsadatok.Panels.Add(Me.pnlTörzsadatimportálása)
        Me.tabTörzsadatok.Panels.Add(Me.rbTörzsadat)
        Me.tabTörzsadatok.Text = "Törzsadatok karbantartása"
        '
        'pnlTörzsadatokrögzítésekarbantartása
        '
        Me.pnlTörzsadatokrögzítésekarbantartása.Items.Add(Me.personkarb)
        Me.pnlTörzsadatokrögzítésekarbantartása.Items.Add(Me.jkvkarb)
        Me.pnlTörzsadatokrögzítésekarbantartása.Items.Add(Me.Ügy)
        Me.pnlTörzsadatokrögzítésekarbantartása.Items.Add(Me.Egyebtorzsadatok)
        Me.pnlTörzsadatokrögzítésekarbantartása.Text = "Törzsadatok rögzítése, karbantartása"
        '
        'personkarb
        '
        Me.personkarb.AltKey = "n"
        Me.personkarb.DropDownItems.Add(Me.TSZ)
        Me.personkarb.DropDownItems.Add(Me.Ceg)
        Me.personkarb.DropDownItems.Add(Me.ESZ)
        Me.personkarb.DropDownItems.Add(Me.EV)
        Me.personkarb.Image = CType(resources.GetObject("personkarb.Image"), System.Drawing.Image)
        Me.personkarb.SmallImage = CType(resources.GetObject("personkarb.SmallImage"), System.Drawing.Image)
        Me.personkarb.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.personkarb.Text = "Nem jogi képviselők"
        Me.personkarb.ToolTip = resources.GetString("personkarb.ToolTip")
        '
        'TSZ
        '
        Me.TSZ.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.TSZ.Image = CType(resources.GetObject("TSZ.Image"), System.Drawing.Image)
        Me.TSZ.SmallImage = CType(resources.GetObject("TSZ.SmallImage"), System.Drawing.Image)
        Me.TSZ.Text = "Természetes személy"
        '
        'Ceg
        '
        Me.Ceg.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.Ceg.Image = CType(resources.GetObject("Ceg.Image"), System.Drawing.Image)
        Me.Ceg.SmallImage = CType(resources.GetObject("Ceg.SmallImage"), System.Drawing.Image)
        Me.Ceg.Text = "Cég"
        '
        'ESZ
        '
        Me.ESZ.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.ESZ.Image = CType(resources.GetObject("ESZ.Image"), System.Drawing.Image)
        Me.ESZ.SmallImage = CType(resources.GetObject("ESZ.SmallImage"), System.Drawing.Image)
        Me.ESZ.Text = "Egyéb szervezet"
        Me.ESZ.ToolTip = "Például civil szervezetek, költségvetési szervek, kamarák "
        '
        'EV
        '
        Me.EV.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.EV.Image = CType(resources.GetObject("EV.Image"), System.Drawing.Image)
        Me.EV.SmallImage = CType(resources.GetObject("EV.SmallImage"), System.Drawing.Image)
        Me.EV.Text = "Egyéni vállalkozó"
        '
        'jkvkarb
        '
        Me.jkvkarb.AltKey = "j"
        Me.jkvkarb.DropDownItems.Add(Me.JK_UI)
        Me.jkvkarb.DropDownItems.Add(Me.JK_EU)
        Me.jkvkarb.DropDownItems.Add(Me.JK_JT)
        Me.jkvkarb.DropDownItems.Add(Me.JK_EJK)
        Me.jkvkarb.Image = CType(resources.GetObject("jkvkarb.Image"), System.Drawing.Image)
        Me.jkvkarb.SmallImage = CType(resources.GetObject("jkvkarb.SmallImage"), System.Drawing.Image)
        Me.jkvkarb.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.jkvkarb.Text = "Jogi képviselők"
        Me.jkvkarb.ToolTip = "Itt rögzíthet jogi képviselőkkel kapcsolatos bejegyzéseket törzsadatként (hogy má" &
    "skor ne kelljen még egyszer megadni)"
        '
        'JK_UI
        '
        Me.JK_UI.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.JK_UI.Image = CType(resources.GetObject("JK_UI.Image"), System.Drawing.Image)
        Me.JK_UI.SmallImage = CType(resources.GetObject("JK_UI.SmallImage"), System.Drawing.Image)
        Me.JK_UI.Text = "Ügyvédi iroda"
        '
        'JK_EU
        '
        Me.JK_EU.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.JK_EU.Image = CType(resources.GetObject("JK_EU.Image"), System.Drawing.Image)
        Me.JK_EU.SmallImage = CType(resources.GetObject("JK_EU.SmallImage"), System.Drawing.Image)
        Me.JK_EU.Text = "Ügyvéd (nem irodai tag)"
        '
        'JK_JT
        '
        Me.JK_JT.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.JK_JT.Image = CType(resources.GetObject("JK_JT.Image"), System.Drawing.Image)
        Me.JK_JT.SmallImage = CType(resources.GetObject("JK_JT.SmallImage"), System.Drawing.Image)
        Me.JK_JT.Text = "Jogtanácsos"
        '
        'JK_EJK
        '
        Me.JK_EJK.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.JK_EJK.Image = CType(resources.GetObject("JK_EJK.Image"), System.Drawing.Image)
        Me.JK_EJK.SmallImage = CType(resources.GetObject("JK_EJK.SmallImage"), System.Drawing.Image)
        Me.JK_EJK.Text = "Egyéb jogi képviselő"
        '
        'Ügy
        '
        Me.Ügy.Image = CType(resources.GetObject("Ügy.Image"), System.Drawing.Image)
        Me.Ügy.SmallImage = CType(resources.GetObject("Ügy.SmallImage"), System.Drawing.Image)
        Me.Ügy.Text = "Ügyek"
        Me.Ügy.ToolTip = "Itt olyan ügyek alap adatait rögzítheti, amelyeket újból szeretne használni (pl. " &
    "ügyszám és hozzá tartozó bíróság, elsőrendű peres felek neve stb.)"
        '
        'Egyebtorzsadatok
        '
        Me.Egyebtorzsadatok.Image = CType(resources.GetObject("Egyebtorzsadatok.Image"), System.Drawing.Image)
        Me.Egyebtorzsadatok.SmallImage = CType(resources.GetObject("Egyebtorzsadatok.SmallImage"), System.Drawing.Image)
        Me.Egyebtorzsadatok.Text = "Egyéb törzsadatok"
        Me.Egyebtorzsadatok.ToolTip = "Egyelőre az eperHelperrel kitöltendő új nyomtatványok keltezését adhatja meg itt"
        '
        'pnlTörzsadatimportálása
        '
        Me.pnlTörzsadatimportálása.Items.Add(Me.importonce)
        Me.pnlTörzsadatimportálása.Items.Add(Me.importrepeat)
        Me.pnlTörzsadatimportálása.Items.Add(Me.sample)
        Me.pnlTörzsadatimportálása.Items.Add(Me.teszt)
        Me.pnlTörzsadatimportálása.Items.Add(Me.RibbonButton3)
        Me.pnlTörzsadatimportálása.Text = "Törzsadat importálása"
        '
        'importonce
        '
        Me.importonce.AltKey = "i"
        Me.importonce.Image = CType(resources.GetObject("importonce.Image"), System.Drawing.Image)
        Me.importonce.SmallImage = CType(resources.GetObject("importonce.SmallImage"), System.Drawing.Image)
        Me.importonce.Text = "Egyszeri CSV-ből"
        Me.importonce.ToolTip = "Próbálja meg az adott formátumú szöveges ún. CSV fájlok tartalmát beimportálni az" &
    " eperHelper törzsadatbázisába"
        '
        'importrepeat
        '
        Me.importrepeat.Image = CType(resources.GetObject("importrepeat.Image"), System.Drawing.Image)
        Me.importrepeat.SmallImage = CType(resources.GetObject("importrepeat.SmallImage"), System.Drawing.Image)
        Me.importrepeat.Text = "Rendszeres CSV-ből"
        Me.importrepeat.Visible = False
        '
        'sample
        '
        Me.sample.DropDownItems.Add(Me.MintaCSV)
        Me.sample.DropDownItems.Add(Me.MintaMDB)
        Me.sample.Image = CType(resources.GetObject("sample.Image"), System.Drawing.Image)
        Me.sample.SmallImage = CType(resources.GetObject("sample.SmallImage"), System.Drawing.Image)
        Me.sample.Text = "Üres minták mentése"
        Me.sample.ToolTip = resources.GetString("sample.ToolTip")
        '
        'MintaCSV
        '
        Me.MintaCSV.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.MintaCSV.Image = CType(resources.GetObject("MintaCSV.Image"), System.Drawing.Image)
        Me.MintaCSV.SmallImage = CType(resources.GetObject("MintaCSV.SmallImage"), System.Drawing.Image)
        Me.MintaCSV.Text = "Minta CSV-k"
        '
        'MintaMDB
        '
        Me.MintaMDB.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.MintaMDB.Image = CType(resources.GetObject("MintaMDB.Image"), System.Drawing.Image)
        Me.MintaMDB.SmallImage = CType(resources.GetObject("MintaMDB.SmallImage"), System.Drawing.Image)
        Me.MintaMDB.Text = "Minta Access (MDB)"
        '
        'teszt
        '
        Me.teszt.Enabled = False
        Me.teszt.Image = CType(resources.GetObject("teszt.Image"), System.Drawing.Image)
        Me.teszt.SmallImage = CType(resources.GetObject("teszt.SmallImage"), System.Drawing.Image)
        Me.teszt.Text = "tesztfunkciókra"
        Me.teszt.Visible = False
        '
        'RibbonButton3
        '
        Me.RibbonButton3.Enabled = False
        Me.RibbonButton3.Image = CType(resources.GetObject("RibbonButton3.Image"), System.Drawing.Image)
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = "Törlése"
        Me.RibbonButton3.Visible = False
        '
        'rbTörzsadat
        '
        Me.rbTörzsadat.Items.Add(Me.btnTorzsadatChange)
        Me.rbTörzsadat.Text = ""
        '
        'btnTorzsadatChange
        '
        Me.btnTorzsadatChange.Image = Global.homoki.eperhelper.My.Resources.Resources.enum_16xLG
        Me.btnTorzsadatChange.SmallImage = CType(resources.GetObject("btnTorzsadatChange.SmallImage"), System.Drawing.Image)
        Me.btnTorzsadatChange.Text = "Másik törzsadatbázis"
        Me.btnTorzsadatChange.ToolTip = "Az alap törzsadatbázis helyett kiválaszthat egy másik törzsadatbázist. Csak akkor" &
    " tegye, ha azonos szerkezetű és formátumú az új adatbázis is!"
        '
        'tabEgyébbeállítás
        '
        Me.tabEgyébbeállítás.Panels.Add(Me.pnlNotifications)
        Me.tabEgyébbeállítás.Panels.Add(Me.pnlBackupsettings)
        Me.tabEgyébbeállítás.Panels.Add(Me.pnlOtherSettings)
        Me.tabEgyébbeállítás.Text = "Egyéb beállítások"
        '
        'pnlNotifications
        '
        Me.pnlNotifications.Items.Add(Me.cbNoJava)
        Me.pnlNotifications.Items.Add(Me.cbNoSecretKey)
        Me.pnlNotifications.Text = "Figyelmeztetések"
        '
        'cbNoJava
        '
        Me.cbNoJava.AltKey = "j"
        Me.cbNoJava.Text = "Nincsen Java és ÁNYK"
        Me.cbNoJava.ToolTip = "Kapcsolja ki vagy vissza az eperHelper indulásakor megjelenő figyelmeztetést arró" &
    "l, hogy az ÁNYK vagy a Java nincsen telepítve a gépre, így az eperHelper sem tud" &
    " teljes értékű lenni"
        '
        'cbNoSecretKey
        '
        Me.cbNoSecretKey.AltKey = "t"
        Me.cbNoSecretKey.Text = "Titkosító kulcs hiányzik"
        Me.cbNoSecretKey.ToolTip = "Kapcsolja ki vagy be azt a figyelmeztetést, hogy az eperHelper nem talált a bekül" &
    "dendő KR fájlok későbbi saját megnyitásához szükséges (saját) titkosító kulcsot"
        '
        'pnlBackupsettings
        '
        Me.pnlBackupsettings.Items.Add(Me.savesettings)
        Me.pnlBackupsettings.Items.Add(Me.loadsettings)
        Me.pnlBackupsettings.Items.Add(Me.passwprint)
        Me.pnlBackupsettings.Items.Add(Me.passwdeleteall)
        Me.pnlBackupsettings.Items.Add(Me.btnRegFajl)
        Me.pnlBackupsettings.Text = "Beállítások biztonsági mentése"
        '
        'savesettings
        '
        Me.savesettings.AltKey = "m"
        Me.savesettings.DropDownItems.Add(Me.RibbonButtonList1)
        Me.savesettings.Image = CType(resources.GetObject("savesettings.Image"), System.Drawing.Image)
        Me.savesettings.SmallImage = CType(resources.GetObject("savesettings.SmallImage"), System.Drawing.Image)
        Me.savesettings.Text = "Beállítások mentése"
        Me.savesettings.ToolTip = "Itt biztonsági célból elmentheti az eperHelper beállításait egy XML-fájlba, hogy " &
    "később (pl. újratelepítés esetén) a beállításokat könnyen visszaállíthassa"
        '
        'RibbonButtonList1
        '
        Me.RibbonButtonList1.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.RibbonButtonList1.FlowToBottom = False
        Me.RibbonButtonList1.ItemsSizeInDropwDownMode = New System.Drawing.Size(7, 5)
        Me.RibbonButtonList1.Text = "RibbonButtonList1"
        '
        'loadsettings
        '
        Me.loadsettings.Image = CType(resources.GetObject("loadsettings.Image"), System.Drawing.Image)
        Me.loadsettings.SmallImage = CType(resources.GetObject("loadsettings.SmallImage"), System.Drawing.Image)
        Me.loadsettings.Text = "Beállítások betöltése"
        Me.loadsettings.ToolTip = "Ezzel töltheti vissza a másik parancssal elmentett XML-fájlból az eperHelper beál" &
    "lításait"
        '
        'passwprint
        '
        Me.passwprint.AltKey = "n"
        Me.passwprint.Image = CType(resources.GetObject("passwprint.Image"), System.Drawing.Image)
        Me.passwprint.SmallImage = CType(resources.GetObject("passwprint.SmallImage"), System.Drawing.Image)
        Me.passwprint.Text = "Jelszavak kinyomtatása"
        Me.passwprint.ToolTip = "Olvasható formában biztonsági célból kinyomtathatja a beállított jelszavakat. Fig" &
    "yelem! Egy felhasználó csak egyszer teheti meg, utána újból be kell írnia a jels" &
    "zavakat, ha ismét ki akarja nyomtatni!"
        '
        'passwdeleteall
        '
        Me.passwdeleteall.Image = CType(resources.GetObject("passwdeleteall.Image"), System.Drawing.Image)
        Me.passwdeleteall.SmallImage = CType(resources.GetObject("passwdeleteall.SmallImage"), System.Drawing.Image)
        Me.passwdeleteall.Text = "Jelszavak törlése"
        Me.passwdeleteall.ToolTip = "Biztonsági okból szükségesnek tarthatja (pl. más hozzáfér ugyanahhoz a géphez)."
        '
        'btnRegFajl
        '
        Me.btnRegFajl.Image = CType(resources.GetObject("btnRegFajl.Image"), System.Drawing.Image)
        Me.btnRegFajl.SmallImage = CType(resources.GetObject("btnRegFajl.SmallImage"), System.Drawing.Image)
        Me.btnRegFajl.Text = "Reg.fájl mentése"
        '
        'pnlOtherSettings
        '
        Me.pnlOtherSettings.Items.Add(Me.btnFoldersettings)
        Me.pnlOtherSettings.Items.Add(Me.XKRXCZTársít)
        Me.pnlOtherSettings.Items.Add(Me.ÁNYKoszlopoknyitáshoz)
        Me.pnlOtherSettings.Items.Add(Me.btnAVDHesKapuNoticeKi)
        Me.pnlOtherSettings.Items.Add(Me.SetPreferredBrowser)
        Me.pnlOtherSettings.Text = "Egyéb beállítások"
        '
        'btnFoldersettings
        '
        Me.btnFoldersettings.DropDownItems.Add(Me.ÁNYKmentes)
        Me.btnFoldersettings.DropDownItems.Add(Me.ÁNYKroot)
        Me.btnFoldersettings.DropDownItems.Add(Me.Extract)
        Me.btnFoldersettings.DropDownItems.Add(Me.SentFile)
        Me.btnFoldersettings.DropDownItems.Add(Me.KRpost)
        Me.btnFoldersettings.Image = CType(resources.GetObject("btnFoldersettings.Image"), System.Drawing.Image)
        Me.btnFoldersettings.SmallImage = CType(resources.GetObject("btnFoldersettings.SmallImage"), System.Drawing.Image)
        Me.btnFoldersettings.Text = "Mappák beállítása"
        Me.btnFoldersettings.ToolTip = "Ezzel beállíthatja a program által használt egyes mappákat"
        '
        'ÁNYKmentes
        '
        Me.ÁNYKmentes.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.ÁNYKmentes.Image = CType(resources.GetObject("ÁNYKmentes.Image"), System.Drawing.Image)
        Me.ÁNYKmentes.SmallImage = CType(resources.GetObject("ÁNYKmentes.SmallImage"), System.Drawing.Image)
        Me.ÁNYKmentes.Text = "ÁNYK félkész sablon mentése"
        '
        'ÁNYKroot
        '
        Me.ÁNYKroot.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.ÁNYKroot.Image = CType(resources.GetObject("ÁNYKroot.Image"), System.Drawing.Image)
        Me.ÁNYKroot.SmallImage = CType(resources.GetObject("ÁNYKroot.SmallImage"), System.Drawing.Image)
        Me.ÁNYKroot.Text = "ÁNYK futtatása"
        '
        'Extract
        '
        Me.Extract.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.Extract.Image = CType(resources.GetObject("Extract.Image"), System.Drawing.Image)
        Me.Extract.SmallImage = CType(resources.GetObject("Extract.SmallImage"), System.Drawing.Image)
        Me.Extract.Text = "Kicsomagolási cél"
        '
        'SentFile
        '
        Me.SentFile.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.SentFile.Image = CType(resources.GetObject("SentFile.Image"), System.Drawing.Image)
        Me.SentFile.SmallImage = CType(resources.GetObject("SentFile.SmallImage"), System.Drawing.Image)
        Me.SentFile.Text = "Készítettek megőrzése"
        '
        'KRpost
        '
        Me.KRpost.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.KRpost.Image = CType(resources.GetObject("KRpost.Image"), System.Drawing.Image)
        Me.KRpost.SmallImage = CType(resources.GetObject("KRpost.SmallImage"), System.Drawing.Image)
        Me.KRpost.Text = "KR feladása"
        '
        'XKRXCZTársít
        '
        Me.XKRXCZTársít.DropDownItems.Add(Me.RibbonButton1)
        Me.XKRXCZTársít.Image = CType(resources.GetObject("XKRXCZTársít.Image"), System.Drawing.Image)
        Me.XKRXCZTársít.MinimumSize = New System.Drawing.Size(75, 0)
        Me.XKRXCZTársít.SmallImage = CType(resources.GetObject("XKRXCZTársít.SmallImage"), System.Drawing.Image)
        Me.XKRXCZTársít.Text = "XKR és XCZ társítása ÁNYKval"
        Me.XKRXCZTársít.ToolTip = "Ha szeretné az operációs rendszerből hívhatóan megnyitni az XKR és XCZ dokumentum" &
    "okat, és ez valamiért az ÁNYK telepítése után mégsem működik, próbálja ki ezt."
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'ÁNYKoszlopoknyitáshoz
        '
        Me.ÁNYKoszlopoknyitáshoz.Image = CType(resources.GetObject("ÁNYKoszlopoknyitáshoz.Image"), System.Drawing.Image)
        Me.ÁNYKoszlopoknyitáshoz.SmallImage = CType(resources.GetObject("ÁNYKoszlopoknyitáshoz.SmallImage"), System.Drawing.Image)
        Me.ÁNYKoszlopoknyitáshoz.Text = "ÁNYK nyitási oszlopsorrend"
        Me.ÁNYKoszlopoknyitáshoz.ToolTip = "A nyomtatványok megnyitásánál használt alapértelmezett ÁNYK oszlopsorrend e-perhe" &
    "z igazítása (ne adószám stb. legyen az első oszlop, hanem fájlnév stb.)"
        '
        'btnAVDHesKapuNoticeKi
        '
        Me.btnAVDHesKapuNoticeKi.Image = CType(resources.GetObject("btnAVDHesKapuNoticeKi.Image"), System.Drawing.Image)
        Me.btnAVDHesKapuNoticeKi.SmallImage = CType(resources.GetObject("btnAVDHesKapuNoticeKi.SmallImage"), System.Drawing.Image)
        Me.btnAVDHesKapuNoticeKi.Text = "AVDH és kapu figyelmeztetések ki"
        Me.btnAVDHesKapuNoticeKi.ToolTip = "Ezzel kikapcsolhatja az összes olyan figyelmeztetést az ÁNYK-ban, ami arra vonatk" &
    "ozik, hogy az adott sablont perkapu útján is be lehet küldeni vagy AVDH-val hite" &
    "lesíthető"
        '
        'SetPreferredBrowser
        '
        Me.SetPreferredBrowser.Image = Global.homoki.eperhelper.My.Resources.Resources.browsericons
        Me.SetPreferredBrowser.SmallImage = CType(resources.GetObject("SetPreferredBrowser.SmallImage"), System.Drawing.Image)
        Me.SetPreferredBrowser.Text = "Böngésző"
        Me.SetPreferredBrowser.ToolTip = resources.GetString("SetPreferredBrowser.ToolTip")
        '
        'anykmappavissza
        '
        Me.anykmappavissza.Image = CType(resources.GetObject("anykmappavissza.Image"), System.Drawing.Image)
        Me.anykmappavissza.SmallImage = CType(resources.GetObject("anykmappavissza.SmallImage"), System.Drawing.Image)
        Me.anykmappavissza.Text = "ÁNYK mentési mappa vissza alapbeállításba"
        Me.anykmappavissza.ToolTip = resources.GetString("anykmappavissza.ToolTip")
        '
        'tochange
        '
        Me.tochange.Image = CType(resources.GetObject("tochange.Image"), System.Drawing.Image)
        Me.tochange.SmallImage = CType(resources.GetObject("tochange.SmallImage"), System.Drawing.Image)
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 7000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'btnCloseJava
        '
        Me.btnCloseJava.AutoSize = True
        Me.btnCloseJava.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCloseJava.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCloseJava.Location = New System.Drawing.Point(0, 23)
        Me.btnCloseJava.Name = "btnCloseJava"
        Me.btnCloseJava.Size = New System.Drawing.Size(245, 23)
        Me.btnCloseJava.TabIndex = 6
        Me.btnCloseJava.Text = "Figyelmeztetés bezárása"
        Me.ToolTip1.SetToolTip(Me.btnCloseJava, "A figyelmeztetés bezárása (újból megnyithatja az Egyéb beállítások oldalon belül)" &
        "")
        Me.btnCloseJava.UseVisualStyleBackColor = True
        '
        'gbeperHelpersupportedAll
        '
        Me.gbeperHelpersupportedAll.AutoSize = True
        Me.gbeperHelpersupportedAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.gbeperHelpersupportedAll.Checked = True
        Me.gbeperHelpersupportedAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbeperHelpersupportedAll.Location = New System.Drawing.Point(3, 16)
        Me.gbeperHelpersupportedAll.Name = "gbeperHelpersupportedAll"
        Me.gbeperHelpersupportedAll.Size = New System.Drawing.Size(238, 17)
        Me.gbeperHelpersupportedAll.TabIndex = 8
        Me.gbeperHelpersupportedAll.TabStop = True
        Me.gbeperHelpersupportedAll.Text = "Mindent, amit az eperHelperben kitölthet"
        Me.ToolTip1.SetToolTip(Me.gbeperHelpersupportedAll, "Töltse le az összes olyan nyomtatványsablont, amit az eperHelper kitöltésnél támo" &
        "gat")
        Me.gbeperHelpersupportedAll.UseVisualStyleBackColor = True
        '
        'gbAll
        '
        Me.gbAll.AutoSize = True
        Me.gbAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.gbAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbAll.Location = New System.Drawing.Point(3, 33)
        Me.gbAll.Name = "gbAll"
        Me.gbAll.Size = New System.Drawing.Size(238, 17)
        Me.gbAll.TabIndex = 20
        Me.gbAll.Text = "Minden elérhető verzió (régi is)"
        Me.ToolTip1.SetToolTip(Me.gbAll, "Régi verziókon kiadott nyomtatványok beolvasásához hasznos!")
        Me.gbAll.UseVisualStyleBackColor = True
        '
        'gbFresh
        '
        Me.gbFresh.AutoSize = True
        Me.gbFresh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.gbFresh.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbFresh.Location = New System.Drawing.Point(3, 50)
        Me.gbFresh.Name = "gbFresh"
        Me.gbFresh.Size = New System.Drawing.Size(238, 17)
        Me.gbFresh.TabIndex = 21
        Me.gbFresh.Text = "Összes legfrissebb verzió"
        Me.ToolTip1.SetToolTip(Me.gbFresh, "Csak a legfrissebb nyomtatványverziókat telepíti, a régieket nem.")
        Me.gbFresh.UseVisualStyleBackColor = True
        '
        'gbFresherthanInstalled
        '
        Me.gbFresherthanInstalled.AutoSize = True
        Me.gbFresherthanInstalled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.gbFresherthanInstalled.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbFresherthanInstalled.Location = New System.Drawing.Point(3, 67)
        Me.gbFresherthanInstalled.Name = "gbFresherthanInstalled"
        Me.gbFresherthanInstalled.Size = New System.Drawing.Size(238, 17)
        Me.gbFresherthanInstalled.TabIndex = 22
        Me.gbFresherthanInstalled.Text = "Már telepítettből elérhető új verzió"
        Me.ToolTip1.SetToolTip(Me.gbFresherthanInstalled, "Csak azokat a legfrissebb nyomtatványokat telepíti, amelyekből már van a gépre te" &
        "lepítve egy korábbi verzió")
        Me.gbFresherthanInstalled.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Kapu adatok exportálása nyomtatóra"
        '
        'PanelJava
        '
        Me.PanelJava.AutoSize = True
        Me.PanelJava.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelJava.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelJava.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelJava.Location = New System.Drawing.Point(3, 147)
        Me.PanelJava.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelJava.Name = "PanelJava"
        Me.PanelJava.Size = New System.Drawing.Size(1002, 106)
        Me.PanelJava.TabIndex = 6
        Me.PanelJava.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblPanelJava, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelJavaJobboldal, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1002, 106)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'lblPanelJava
        '
        Me.lblPanelJava.AutoSize = True
        Me.lblPanelJava.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPanelJava.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPanelJava.Location = New System.Drawing.Point(3, 3)
        Me.lblPanelJava.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPanelJava.Name = "lblPanelJava"
        Me.lblPanelJava.Size = New System.Drawing.Size(597, 100)
        Me.lblPanelJava.TabIndex = 0
        Me.lblPanelJava.Text = resources.GetString("lblPanelJava.Text")
        Me.lblPanelJava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelJavaJobboldal
        '
        Me.PanelJavaJobboldal.Controls.Add(Me.btnRecheckJava)
        Me.PanelJavaJobboldal.Controls.Add(Me.cbNoWarnJava)
        Me.PanelJavaJobboldal.Controls.Add(Me.btnCloseJava)
        Me.PanelJavaJobboldal.Controls.Add(Me.btnInstallJava)
        Me.PanelJavaJobboldal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelJavaJobboldal.Location = New System.Drawing.Point(754, 3)
        Me.PanelJavaJobboldal.Name = "PanelJavaJobboldal"
        Me.PanelJavaJobboldal.Size = New System.Drawing.Size(245, 100)
        Me.PanelJavaJobboldal.TabIndex = 10
        '
        'btnRecheckJava
        '
        Me.btnRecheckJava.AutoSize = True
        Me.btnRecheckJava.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecheckJava.Location = New System.Drawing.Point(0, 46)
        Me.btnRecheckJava.Name = "btnRecheckJava"
        Me.btnRecheckJava.Size = New System.Drawing.Size(245, 23)
        Me.btnRecheckJava.TabIndex = 9
        Me.btnRecheckJava.Text = "Ellenőrizze újból"
        Me.btnRecheckJava.UseVisualStyleBackColor = True
        '
        'cbNoWarnJava
        '
        Me.cbNoWarnJava.AutoSize = True
        Me.cbNoWarnJava.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbNoWarnJava.Location = New System.Drawing.Point(0, 83)
        Me.cbNoWarnJava.Margin = New System.Windows.Forms.Padding(1)
        Me.cbNoWarnJava.Name = "cbNoWarnJava"
        Me.cbNoWarnJava.Size = New System.Drawing.Size(245, 17)
        Me.cbNoWarnJava.TabIndex = 7
        Me.cbNoWarnJava.Text = "Ne figyelmeztessen többet erre"
        Me.cbNoWarnJava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbNoWarnJava.UseVisualStyleBackColor = True
        '
        'btnInstallJava
        '
        Me.btnInstallJava.AutoSize = True
        Me.btnInstallJava.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInstallJava.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInstallJava.Location = New System.Drawing.Point(0, 0)
        Me.btnInstallJava.Name = "btnInstallJava"
        Me.btnInstallJava.Size = New System.Drawing.Size(245, 23)
        Me.btnInstallJava.TabIndex = 5
        Me.btnInstallJava.Text = "Java telepítést letöltő oldal megnyitása"
        Me.btnInstallJava.UseVisualStyleBackColor = True
        '
        'PanelANYK
        '
        Me.PanelANYK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelANYK.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelANYK.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelANYK.Location = New System.Drawing.Point(3, 253)
        Me.PanelANYK.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelANYK.Name = "PanelANYK"
        Me.PanelANYK.Size = New System.Drawing.Size(1002, 106)
        Me.PanelANYK.TabIndex = 7
        Me.PanelANYK.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanelANYKJobboldal, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPanelANYK, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1002, 106)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'PanelANYKJobboldal
        '
        Me.PanelANYKJobboldal.Controls.Add(Me.btnRecheckANYK)
        Me.PanelANYKJobboldal.Controls.Add(Me.cbNoWarnANYK)
        Me.PanelANYKJobboldal.Controls.Add(Me.btnCloseANYK)
        Me.PanelANYKJobboldal.Controls.Add(Me.btnInstallANYK)
        Me.PanelANYKJobboldal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelANYKJobboldal.Location = New System.Drawing.Point(754, 3)
        Me.PanelANYKJobboldal.Name = "PanelANYKJobboldal"
        Me.PanelANYKJobboldal.Size = New System.Drawing.Size(245, 100)
        Me.PanelANYKJobboldal.TabIndex = 14
        '
        'btnRecheckANYK
        '
        Me.btnRecheckANYK.AutoSize = True
        Me.btnRecheckANYK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRecheckANYK.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecheckANYK.Location = New System.Drawing.Point(0, 46)
        Me.btnRecheckANYK.Name = "btnRecheckANYK"
        Me.btnRecheckANYK.Size = New System.Drawing.Size(245, 23)
        Me.btnRecheckANYK.TabIndex = 13
        Me.btnRecheckANYK.Text = "Ellenőrizze újból"
        Me.btnRecheckANYK.UseVisualStyleBackColor = True
        '
        'cbNoWarnANYK
        '
        Me.cbNoWarnANYK.AutoSize = True
        Me.cbNoWarnANYK.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbNoWarnANYK.Location = New System.Drawing.Point(0, 83)
        Me.cbNoWarnANYK.Margin = New System.Windows.Forms.Padding(1)
        Me.cbNoWarnANYK.Name = "cbNoWarnANYK"
        Me.cbNoWarnANYK.Size = New System.Drawing.Size(245, 17)
        Me.cbNoWarnANYK.TabIndex = 12
        Me.cbNoWarnANYK.Text = "Ne figyelmeztessen többet erre"
        Me.cbNoWarnANYK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbNoWarnANYK.UseVisualStyleBackColor = True
        '
        'btnCloseANYK
        '
        Me.btnCloseANYK.AutoSize = True
        Me.btnCloseANYK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCloseANYK.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCloseANYK.Location = New System.Drawing.Point(0, 23)
        Me.btnCloseANYK.Name = "btnCloseANYK"
        Me.btnCloseANYK.Size = New System.Drawing.Size(245, 23)
        Me.btnCloseANYK.TabIndex = 11
        Me.btnCloseANYK.Text = "Figyelmeztetés bezárása"
        Me.btnCloseANYK.UseVisualStyleBackColor = True
        '
        'btnInstallANYK
        '
        Me.btnInstallANYK.AutoSize = True
        Me.btnInstallANYK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInstallANYK.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInstallANYK.Location = New System.Drawing.Point(0, 0)
        Me.btnInstallANYK.Name = "btnInstallANYK"
        Me.btnInstallANYK.Size = New System.Drawing.Size(245, 23)
        Me.btnInstallANYK.TabIndex = 10
        Me.btnInstallANYK.Text = "ÁNYK telepítést letöltő oldal megnyitása"
        Me.btnInstallANYK.UseVisualStyleBackColor = True
        '
        'lblPanelANYK
        '
        Me.lblPanelANYK.AutoSize = True
        Me.lblPanelANYK.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPanelANYK.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPanelANYK.Location = New System.Drawing.Point(3, 3)
        Me.lblPanelANYK.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPanelANYK.Name = "lblPanelANYK"
        Me.lblPanelANYK.Size = New System.Drawing.Size(540, 100)
        Me.lblPanelANYK.TabIndex = 10
        Me.lblPanelANYK.Text = "A program használja az ÁNYK programot, de úgy tűnik, hogy az nincsen vagy hibásan" &
    " van telepítve erre a gépre." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Újra)telepítsük az ÁNYK-t vagy csak az ÁNYK nélkü" &
    "l is futó funkciókat használja?"
        Me.lblPanelANYK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelNyomtatvany
        '
        Me.PanelNyomtatvany.AutoSize = True
        Me.PanelNyomtatvany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelNyomtatvany.Controls.Add(Me.TableLayoutPanel3)
        Me.PanelNyomtatvany.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNyomtatvany.Location = New System.Drawing.Point(3, 359)
        Me.PanelNyomtatvany.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelNyomtatvany.Name = "PanelNyomtatvany"
        Me.PanelNyomtatvany.Size = New System.Drawing.Size(1002, 106)
        Me.PanelNyomtatvany.TabIndex = 8
        Me.PanelNyomtatvany.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblPanelNyomtatvany, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PanelOBHJobboldal, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.gbNyomtatvany, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1002, 106)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'lblPanelNyomtatvany
        '
        Me.lblPanelNyomtatvany.AutoSize = True
        Me.lblPanelNyomtatvany.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPanelNyomtatvany.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPanelNyomtatvany.Location = New System.Drawing.Point(3, 3)
        Me.lblPanelNyomtatvany.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPanelNyomtatvany.Name = "lblPanelNyomtatvany"
        Me.lblPanelNyomtatvany.Size = New System.Drawing.Size(391, 100)
        Me.lblPanelNyomtatvany.TabIndex = 14
        Me.lblPanelNyomtatvany.Text = "A telepített nyomtatványokhoz képest az OBH újabb nyomtatványokat tett közzé." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Le" &
    " kívánja valamelyiket tölteni?"
        Me.lblPanelNyomtatvany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelOBHJobboldal
        '
        Me.PanelOBHJobboldal.Controls.Add(Me.btnListazPanelbol)
        Me.PanelOBHJobboldal.Controls.Add(Me.btnCloseNyomtatvany)
        Me.PanelOBHJobboldal.Controls.Add(Me.btnTelepit)
        Me.PanelOBHJobboldal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelOBHJobboldal.Location = New System.Drawing.Point(754, 3)
        Me.PanelOBHJobboldal.Name = "PanelOBHJobboldal"
        Me.PanelOBHJobboldal.Size = New System.Drawing.Size(245, 100)
        Me.PanelOBHJobboldal.TabIndex = 18
        '
        'btnListazPanelbol
        '
        Me.btnListazPanelbol.AutoSize = True
        Me.btnListazPanelbol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnListazPanelbol.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListazPanelbol.Location = New System.Drawing.Point(0, 46)
        Me.btnListazPanelbol.Name = "btnListazPanelbol"
        Me.btnListazPanelbol.Size = New System.Drawing.Size(245, 23)
        Me.btnListazPanelbol.TabIndex = 17
        Me.btnListazPanelbol.Text = "Kilistázza elérhető nyomtatványokat"
        Me.btnListazPanelbol.UseVisualStyleBackColor = True
        '
        'btnCloseNyomtatvany
        '
        Me.btnCloseNyomtatvany.AutoSize = True
        Me.btnCloseNyomtatvany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCloseNyomtatvany.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCloseNyomtatvany.Location = New System.Drawing.Point(0, 23)
        Me.btnCloseNyomtatvany.Name = "btnCloseNyomtatvany"
        Me.btnCloseNyomtatvany.Size = New System.Drawing.Size(245, 23)
        Me.btnCloseNyomtatvany.TabIndex = 19
        Me.btnCloseNyomtatvany.Text = "Figyelmeztetés bezárása"
        Me.btnCloseNyomtatvany.UseVisualStyleBackColor = True
        '
        'btnTelepit
        '
        Me.btnTelepit.AutoSize = True
        Me.btnTelepit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTelepit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTelepit.Location = New System.Drawing.Point(0, 0)
        Me.btnTelepit.Name = "btnTelepit"
        Me.btnTelepit.Size = New System.Drawing.Size(245, 23)
        Me.btnTelepit.TabIndex = 20
        Me.btnTelepit.Text = "Letölt és telepít"
        Me.btnTelepit.UseVisualStyleBackColor = True
        '
        'gbNyomtatvany
        '
        Me.gbNyomtatvany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbNyomtatvany.Controls.Add(Me.gbFresherthanInstalled)
        Me.gbNyomtatvany.Controls.Add(Me.gbFresh)
        Me.gbNyomtatvany.Controls.Add(Me.gbAll)
        Me.gbNyomtatvany.Controls.Add(Me.gbeperHelpersupportedAll)
        Me.gbNyomtatvany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbNyomtatvany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbNyomtatvany.Location = New System.Drawing.Point(504, 3)
        Me.gbNyomtatvany.Name = "gbNyomtatvany"
        Me.gbNyomtatvany.Size = New System.Drawing.Size(244, 100)
        Me.gbNyomtatvany.TabIndex = 15
        Me.gbNyomtatvany.TabStop = False
        '
        'Loader
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1008, 742)
        Me.Controls.Add(Me.PanelNyomtatvany)
        Me.Controls.Add(Me.PanelANYK)
        Me.Controls.Add(Me.PanelJava)
        Me.Controls.Add(Me.Ribbon)
        Me.Controls.Add(Me.LogBook)
        Me.Controls.Add(Me.StatusStripLoader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1012, 756)
        Me.Name = "Loader"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eperHelper"
        Me.StatusStripLoader.ResumeLayout(False)
        Me.StatusStripLoader.PerformLayout()
        Me.PanelJava.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelJavaJobboldal.ResumeLayout(False)
        Me.PanelJavaJobboldal.PerformLayout()
        Me.PanelANYK.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.PanelANYKJobboldal.ResumeLayout(False)
        Me.PanelANYKJobboldal.PerformLayout()
        Me.PanelNyomtatvany.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.PanelOBHJobboldal.ResumeLayout(False)
        Me.PanelOBHJobboldal.PerformLayout()
        Me.gbNyomtatvany.ResumeLayout(False)
        Me.gbNyomtatvany.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStripLoader As StatusStrip
    Friend WithEvents StripVersion As ToolStripStatusLabel
    Friend WithEvents HelpProviderLoader As HelpProvider
    Friend WithEvents InternetImg As ToolStripStatusLabel
    Friend WithEvents StatusLogBookExport As ToolStripStatusLabel

    Public Sub New()

        InitializeComponent()
        If My.Settings.ErtesitNincsJava = False Then Me.cbNoJava.Checked = False Else Me.cbNoJava.Checked = True
        If My.Settings.ErtesitNincsPkey = False Then Me.cbNoSecretKey.Checked = False Else Me.cbNoSecretKey.Checked = True

        If My.Settings.ErtesitVanNyomtatvany = 2 Then Me.gbFresherthanInstalled.Checked = True
        If My.Settings.ErtesitVanNyomtatvany = 1 Then Me.gbFresh.Checked = True
        If My.Settings.ErtesitVanNyomtatvany = 0 Then Me.gbAll.Checked = True
        If My.Settings.ErtesitVanNyomtatvany = 3 Then Me.gbeperHelpersupportedAll.Checked = True


    End Sub

    Friend WithEvents LogBook As ListView
    Friend WithEvents ColumnDate As ColumnHeader
    Friend WithEvents ColumnSender As ColumnHeader
    Friend WithEvents ColumnMessage As ColumnHeader
    Friend WithEvents ColumnType As ColumnHeader
    Friend WithEvents TimerCheckInet2minutes As Timer
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents Ribbon As Ribbon
    Friend WithEvents Súgó As RibbonOrbMenuItem
    Friend WithEvents tabKészít As RibbonTab
    Friend WithEvents tabNyit As RibbonTab
    Friend WithEvents tabTörzsadatok As RibbonTab
    Friend WithEvents tabKapukezelés As RibbonTab
    Friend WithEvents tabEgyébbeállítás As RibbonTab
    Friend WithEvents RibbonSeparator1 As RibbonSeparator
    Friend WithEvents Kilép As RibbonOrbMenuItem
    Friend WithEvents pnlNotifications As RibbonPanel
    Friend WithEvents cbNoJava As RibbonCheckBox
    Friend WithEvents cbNoSecretKey As RibbonCheckBox
    Friend WithEvents pnlBackupsettings As RibbonPanel
    Friend WithEvents savesettings As RibbonButton
    Friend WithEvents loadsettings As RibbonButton
    Friend WithEvents RibbonButtonList1 As RibbonButtonList
    Friend WithEvents pnlOtherSettings As RibbonPanel
    Friend WithEvents btnFoldersettings As RibbonButton
    Friend WithEvents pnlUgyfelkapu As RibbonPanel
    Friend WithEvents pnlPerkapu As RibbonPanel
    Friend WithEvents pnlHivatalikapu As RibbonPanel
    Friend WithEvents ukincoming As RibbonButton
    Friend WithEvents ukupload As RibbonButton
    Friend WithEvents uknew As RibbonButton
    Friend WithEvents pkpincoming As RibbonButton
    Friend WithEvents pkpupload As RibbonButton
    Friend WithEvents pkpadmin As RibbonButton
    Friend WithEvents hkpincoming As RibbonButton
    Friend WithEvents hkpupload As RibbonButton
    Friend WithEvents pnlTörzsadatokrögzítésekarbantartása As RibbonPanel
    Friend WithEvents pnlTörzsadatimportálása As RibbonPanel
    Friend WithEvents importonce As RibbonButton
    Friend WithEvents importrepeat As RibbonButton
    Friend WithEvents sample As RibbonButton
    Friend WithEvents MintaCSV As RibbonButton
    Friend WithEvents pnlTörzsadattalkitölt As RibbonPanel
    Friend WithEvents pnlKRbeküldésrecsomagol As RibbonPanel
    Friend WithEvents pnlMegtekintesANYKban As RibbonPanel
    Friend WithEvents openxmlxkr As RibbonButton
    Friend WithEvents openenyk As RibbonButton
    Friend WithEvents pnlPDFnyomtatvanybol As RibbonPanel
    Friend WithEvents pnlExtract As RibbonPanel
    Friend WithEvents Ujnyomtatvanytorzsadattal As RibbonButton
    Friend WithEvents MintaMDB As RibbonButton
    Friend WithEvents personkarb As RibbonButton
    Friend WithEvents jkvkarb As RibbonButton
    Friend WithEvents Regisztráció As RibbonOrbMenuItem
    Friend WithEvents csomagenykbol As RibbonButton
    Friend WithEvents csomagxmlbol As RibbonButton
    'Friend WithEvents pnlÁNYKkisegítés As RibbonPanel
    Friend WithEvents anykmappavissza As RibbonButton
    Friend WithEvents btnPDFnyomtatvanybol As RibbonButton
    Friend WithEvents extractkr As RibbonButton
    Friend WithEvents RibbonButton27 As RibbonButton
    Friend WithEvents pnlUNamePassw As RibbonPanel
    Friend WithEvents passwrecord As RibbonButton
    Friend WithEvents passwexport As RibbonButton
    Friend WithEvents passwprint As RibbonButton
    Friend WithEvents TSZ As RibbonButton
    Friend WithEvents Ceg As RibbonButton
    Friend WithEvents ESZ As RibbonButton
    Friend WithEvents EV As RibbonButton
    Friend WithEvents JK_UI As RibbonButton
    Friend WithEvents JK_EU As RibbonButton
    Friend WithEvents JK_JT As RibbonButton
    Friend WithEvents JK_EJK As RibbonButton
    Friend WithEvents Névjegy As RibbonOrbMenuItem
    Friend WithEvents ÁNYKmentes As RibbonButton
    Friend WithEvents ÁNYKroot As RibbonButton
    Friend WithEvents Extract As RibbonButton
    Friend WithEvents SentFile As RibbonButton
    Friend WithEvents KRpost As RibbonButton
    Friend WithEvents sablonfrissitegyszer As RibbonButton
    Friend WithEvents All As RibbonButton
    Friend WithEvents Fresh As RibbonButton
    Friend WithEvents FresherthanInstalled As RibbonButton
    Friend WithEvents csatolmannyalbemasol As RibbonButton
    Friend WithEvents pnlSablonFrissítés As RibbonPanel
    Friend WithEvents AllStartRefresh As RibbonCheckBox
    Friend WithEvents FreshStartRefresh As RibbonCheckBox
    Friend WithEvents FresherthanInstalledStartRefresh As RibbonCheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlBeallitasSigTS As RibbonPanel
    Friend WithEvents SetDefCert As RibbonButton
    Friend WithEvents btnBeallitasSigTSEncr As RibbonButton
    Friend WithEvents tochange As RibbonButton
    Friend WithEvents Indításkorfrissít As RibbonButton
    Friend WithEvents Archívidőbélyeg As RibbonCheckBox
    Friend WithEvents Titkosítókulcspár As RibbonButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents XKRXCZTársít As RibbonButton
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents ÁNYKoszlopoknyitáshoz As RibbonButton
    Friend WithEvents PanelJava As Panel
    Friend WithEvents lblPanelJava As Label
    Public WithEvents btnRecheckJava As Button
    Protected WithEvents cbNoWarnJava As CheckBox
    Protected WithEvents btnCloseJava As Button
    Public WithEvents btnInstallJava As Button
    Friend WithEvents PanelANYK As Panel
    Friend WithEvents lblPanelANYK As Label
    Public WithEvents btnRecheckANYK As Button
    Protected WithEvents cbNoWarnANYK As CheckBox
    Public WithEvents btnInstallANYK As Button
    Protected WithEvents btnCloseANYK As Button
    Friend WithEvents PanelNyomtatvany As Panel
    Friend WithEvents lblPanelNyomtatvany As Label
    Friend WithEvents gbNyomtatvany As GroupBox
    Friend WithEvents PanelANYKJobboldal As Panel
    Friend WithEvents PanelOBHJobboldal As Panel
    Protected WithEvents btnCloseNyomtatvany As Button
    Public WithEvents btnListazPanelbol As Button
    Friend WithEvents PanelJavaJobboldal As Panel
    Friend WithEvents btnTelepit As Button
    Friend WithEvents passwdeleteall As RibbonButton
    Friend WithEvents btnAlairoPrgAtvetel As RibbonButton
    Friend WithEvents rbnLabel As RibbonLabel
    Friend WithEvents btnListázniRibbonbol As RibbonButton
    Friend WithEvents RibbonButton2 As RibbonButton
    Friend WithEvents extractCST As RibbonButton
    Friend WithEvents deleteSettings As RibbonButton
    Friend WithEvents btnAVDHesKapuNoticeKi As RibbonButton
    Friend WithEvents teszt As RibbonButton
    Friend WithEvents Ügy As RibbonButton
    Friend WithEvents Egyebtorzsadatok As RibbonButton
    Friend WithEvents RibbonButton3 As RibbonButton
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents btnKuldEllenorzese As RibbonButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents gbeperHelpersupportedAll As RadioButton
    Friend WithEvents rbtnEperHelper As RibbonButton
    Friend WithEvents rbcbProgramSupportedRefresh As RibbonCheckBox
    Friend WithEvents gbFresherthanInstalled As RadioButton
    Friend WithEvents gbFresh As RadioButton
    Friend WithEvents gbAll As RadioButton
    Friend WithEvents rbTörzsadat As RibbonPanel
    Friend WithEvents btnTorzsadatChange As RibbonButton
    Friend WithEvents btnRegFajl As RibbonButton
    Friend WithEvents SetPreferredBrowser As RibbonButton
End Class
