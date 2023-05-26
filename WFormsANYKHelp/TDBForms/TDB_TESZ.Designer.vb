<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TDB_TESZ
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
        Dim AdóazonosítóLabel As System.Windows.Forms.Label
        Dim Elérhetőségek_TelefonszámLabel As System.Windows.Forms.Label
        Dim Elérhetőségek_FaxszámLabel As System.Windows.Forms.Label
        Dim Elérhetőségek_E_mail_címLabel As System.Windows.Forms.Label
        Dim Állandólakcím_Közterület_neveLabel As System.Windows.Forms.Label
        Dim Állandólakcím_HázszámLabel As System.Windows.Forms.Label
        Dim Állandólakcím_ÉpületLabel As System.Windows.Forms.Label
        Dim Állandólakcím_LépcsőházLabel As System.Windows.Forms.Label
        Dim Állandólakcím_EmeletLabel As System.Windows.Forms.Label
        Dim Állandólakcím_AjtóLabel As System.Windows.Forms.Label
        Dim Külföldi_cím_OrszágLabel As System.Windows.Forms.Label
        Dim Külföldi_cím_IrányítószámLabel As System.Windows.Forms.Label
        Dim Külföldi_cím_Település_neveLabel As System.Windows.Forms.Label
        Dim Külföldi_cím_További_cím_adatokLabel As System.Windows.Forms.Label
        Dim Képviselői_minőségeLabel As System.Windows.Forms.Label
        Dim Viselt_név_TitulusLabel As System.Windows.Forms.Label
        Dim Viselt_név_Családi_névLabel As System.Windows.Forms.Label
        Dim Viselt_név_Első_utónévLabel As System.Windows.Forms.Label
        Dim Viselt_név_További_utónevekLabel As System.Windows.Forms.Label
        Dim Születési_név_Családi_névLabel As System.Windows.Forms.Label
        Dim Születési_név_Első_utónévLabel As System.Windows.Forms.Label
        Dim Születési_név_További_utónevekLabel As System.Windows.Forms.Label
        Dim Anyja_neve_Családi_névLabel As System.Windows.Forms.Label
        Dim Anyja_neve_Első_utónévLabel As System.Windows.Forms.Label
        Dim Anyja_neve_További_utónevekLabel As System.Windows.Forms.Label
        Dim Születési_ország_neveLabel As System.Windows.Forms.Label
        Dim Születési_település_neveLabel As System.Windows.Forms.Label
        Dim Születési_idejeLabel As System.Windows.Forms.Label
        Dim Munkahely_neveLabel As System.Windows.Forms.Label
        Dim Levelezési_címe_Közterület_neveLabel As System.Windows.Forms.Label
        Dim Levelezési_címe_HázszámLabel As System.Windows.Forms.Label
        Dim Levelezési_címe_ÉpületLabel As System.Windows.Forms.Label
        Dim Levelezési_címe_LépcsőházLabel As System.Windows.Forms.Label
        Dim Levelezési_címe_EmeletLabel As System.Windows.Forms.Label
        Dim Levelezési_címe_AjtóLabel As System.Windows.Forms.Label
        Dim Teljes_neveLabel As System.Windows.Forms.Label
        Dim Állandó_lakcíme_IrányítószámLabel As System.Windows.Forms.Label
        Dim Állandó_lakcíme_Település_neveLabel As System.Windows.Forms.Label
        Dim Levelezési_címe_Település_neveLabel As System.Windows.Forms.Label
        Dim Állandó_lakcím_Közterület_jellegeLabel As System.Windows.Forms.Label
        Dim Levelezési_címe_Közterület_jellegeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TDB_TESZ))
        Me.MyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TorzsAdatbazisDataSet = New homoki.eperhelper.TorzsAdatbazisDataSet()
        Me.KepviselominosegeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NyomtatvanyAdatokDataSet = New homoki.eperhelper.NyomtatvanyAdatokDataSet()
        Me.OrszagkoddalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KozteruletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelysegBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Term_szemely_rogzitoTableAdapter()
        Me.TableAdapterManager = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.TableAdapterManager()
        Me.MyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip_Cég = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_ESZ = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_EV = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Termsz = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Üi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Ügyvéd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Jogtanácsos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Egyébjogiképviselő = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbKereso = New System.Windows.Forms.ToolStripTextBox()
        Me.btnKeres = New System.Windows.Forms.ToolStripButton()
        Me.KozteruletTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.KozteruletTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TitulusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitulusTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.TitulusTableAdapter()
        Me.HelysegTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.HelysegTableAdapter()
        Me.CegformaTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.CegformaTableAdapter()
        Me.Kepviselo_minosegeTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.Kepviselo_minosegeTableAdapter()
        Me.Orszag_koddalTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.Orszag_koddalTableAdapter()
        Me.AdóazonosítóMaskedBox = New System.Windows.Forms.MaskedTextBox()
        Me.btnBezaresMent = New System.Windows.Forms.Button()
        Me.btnBezarNemMent = New System.Windows.Forms.Button()
        Me.Elérhetőségek_TelefonszámTextBox = New System.Windows.Forms.TextBox()
        Me.Elérhetőségek_FaxszámTextBox = New System.Windows.Forms.TextBox()
        Me.Elérhetőségek_E_mail_címTextBox = New System.Windows.Forms.TextBox()
        Me.Állandólakcím_Közterület_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Állandólakcím_HázszámTextBox = New System.Windows.Forms.TextBox()
        Me.Állandólakcím_ÉpületTextBox = New System.Windows.Forms.TextBox()
        Me.Állandólakcím_LépcsőházTextBox = New System.Windows.Forms.TextBox()
        Me.Állandólakcím_EmeletTextBox = New System.Windows.Forms.TextBox()
        Me.Állandólakcím_AjtóTextBox = New System.Windows.Forms.TextBox()
        Me.Külföldi_cím_OrszágComboBox = New System.Windows.Forms.ComboBox()
        Me.Külföldi_cím_IrányítószámTextBox = New System.Windows.Forms.TextBox()
        Me.Külföldi_cím_Település_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Külföldi_cím_További_cím_adatokTextBox = New System.Windows.Forms.TextBox()
        Me.Képviselői_minőségeComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Levelezési_címe_Közterület_jellegeComboBox = New System.Windows.Forms.ComboBox()
        Me.KozteruletBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Állandólakcím_Közterület_jellegeComboBox = New System.Windows.Forms.ComboBox()
        Me.Levelezési_címe_Település_neveComboBox = New System.Windows.Forms.ComboBox()
        Me.HelyisegBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Állandólakcím_Település_neveComboBox = New System.Windows.Forms.ComboBox()
        Me.HelyisegBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Teljes_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Levelezési_címe_AjtóTextBox = New System.Windows.Forms.TextBox()
        Me.Levelezési_címe_EmeletTextBox = New System.Windows.Forms.TextBox()
        Me.Levelezési_címe_LépcsőházTextBox = New System.Windows.Forms.TextBox()
        Me.Levelezési_címe_ÉpületTextBox = New System.Windows.Forms.TextBox()
        Me.Levelezési_címe_HázszámTextBox = New System.Windows.Forms.TextBox()
        Me.Levelezési_címe_Közterület_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Viselt_név_További_utónevekTextBox = New System.Windows.Forms.TextBox()
        Me.Viselt_név_Első_utónévTextBox = New System.Windows.Forms.TextBox()
        Me.Viselt_név_Családi_névTextBox = New System.Windows.Forms.TextBox()
        Me.Viselt_név_TitulusComboBox = New System.Windows.Forms.ComboBox()
        Me.Munkahely_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Születési_idejeMaskedBox = New System.Windows.Forms.MaskedTextBox()
        Me.Születési_település_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Születési_ország_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Anyja_neve_További_utónevekTextBox = New System.Windows.Forms.TextBox()
        Me.Anyja_neve_Első_utónévTextBox = New System.Windows.Forms.TextBox()
        Me.Anyja_neve_Családi_névTextBox = New System.Windows.Forms.TextBox()
        Me.Születési_név_További_utónevekTextBox = New System.Windows.Forms.TextBox()
        Me.Születési_név_Első_utónévTextBox = New System.Windows.Forms.TextBox()
        Me.Születési_név_Családi_névTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCopyÁllandóLevbe = New System.Windows.Forms.Button()
        Me.Levelezési_címe_IrányítószámLabel = New System.Windows.Forms.Label()
        Me.Levelezési_címe_IrányítószámComboBox = New System.Windows.Forms.ComboBox()
        Me.HelyisegBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Állandólakcím_IrányítószámComboBox = New System.Windows.Forms.ComboBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        AdóazonosítóLabel = New System.Windows.Forms.Label()
        Elérhetőségek_TelefonszámLabel = New System.Windows.Forms.Label()
        Elérhetőségek_FaxszámLabel = New System.Windows.Forms.Label()
        Elérhetőségek_E_mail_címLabel = New System.Windows.Forms.Label()
        Állandólakcím_Közterület_neveLabel = New System.Windows.Forms.Label()
        Állandólakcím_HázszámLabel = New System.Windows.Forms.Label()
        Állandólakcím_ÉpületLabel = New System.Windows.Forms.Label()
        Állandólakcím_LépcsőházLabel = New System.Windows.Forms.Label()
        Állandólakcím_EmeletLabel = New System.Windows.Forms.Label()
        Állandólakcím_AjtóLabel = New System.Windows.Forms.Label()
        Külföldi_cím_OrszágLabel = New System.Windows.Forms.Label()
        Külföldi_cím_IrányítószámLabel = New System.Windows.Forms.Label()
        Külföldi_cím_Település_neveLabel = New System.Windows.Forms.Label()
        Külföldi_cím_További_cím_adatokLabel = New System.Windows.Forms.Label()
        Képviselői_minőségeLabel = New System.Windows.Forms.Label()
        Viselt_név_TitulusLabel = New System.Windows.Forms.Label()
        Viselt_név_Családi_névLabel = New System.Windows.Forms.Label()
        Viselt_név_Első_utónévLabel = New System.Windows.Forms.Label()
        Viselt_név_További_utónevekLabel = New System.Windows.Forms.Label()
        Születési_név_Családi_névLabel = New System.Windows.Forms.Label()
        Születési_név_Első_utónévLabel = New System.Windows.Forms.Label()
        Születési_név_További_utónevekLabel = New System.Windows.Forms.Label()
        Anyja_neve_Családi_névLabel = New System.Windows.Forms.Label()
        Anyja_neve_Első_utónévLabel = New System.Windows.Forms.Label()
        Anyja_neve_További_utónevekLabel = New System.Windows.Forms.Label()
        Születési_ország_neveLabel = New System.Windows.Forms.Label()
        Születési_település_neveLabel = New System.Windows.Forms.Label()
        Születési_idejeLabel = New System.Windows.Forms.Label()
        Munkahely_neveLabel = New System.Windows.Forms.Label()
        Levelezési_címe_Közterület_neveLabel = New System.Windows.Forms.Label()
        Levelezési_címe_HázszámLabel = New System.Windows.Forms.Label()
        Levelezési_címe_ÉpületLabel = New System.Windows.Forms.Label()
        Levelezési_címe_LépcsőházLabel = New System.Windows.Forms.Label()
        Levelezési_címe_EmeletLabel = New System.Windows.Forms.Label()
        Levelezési_címe_AjtóLabel = New System.Windows.Forms.Label()
        Teljes_neveLabel = New System.Windows.Forms.Label()
        Állandó_lakcíme_IrányítószámLabel = New System.Windows.Forms.Label()
        Állandó_lakcíme_Település_neveLabel = New System.Windows.Forms.Label()
        Levelezési_címe_Település_neveLabel = New System.Windows.Forms.Label()
        Állandó_lakcím_Közterület_jellegeLabel = New System.Windows.Forms.Label()
        Levelezési_címe_Közterület_jellegeLabel = New System.Windows.Forms.Label()
        CType(Me.MyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KepviselominosegeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NyomtatvanyAdatokDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrszagkoddalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KozteruletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HelysegBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyBindingNavigator.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.KozteruletBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HelyisegBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HelyisegBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.HelyisegBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdóazonosítóLabel
        '
        AdóazonosítóLabel.AutoSize = True
        AdóazonosítóLabel.Location = New System.Drawing.Point(3, 450)
        AdóazonosítóLabel.Name = "AdóazonosítóLabel"
        AdóazonosítóLabel.Size = New System.Drawing.Size(89, 13)
        AdóazonosítóLabel.TabIndex = 36
        AdóazonosítóLabel.Text = "Adóazonosító jel:"
        '
        'Elérhetőségek_TelefonszámLabel
        '
        Elérhetőségek_TelefonszámLabel.AutoSize = True
        Elérhetőségek_TelefonszámLabel.Location = New System.Drawing.Point(501, 575)
        Elérhetőségek_TelefonszámLabel.Name = "Elérhetőségek_TelefonszámLabel"
        Elérhetőségek_TelefonszámLabel.Size = New System.Drawing.Size(143, 13)
        Elérhetőségek_TelefonszámLabel.TabIndex = 6
        Elérhetőségek_TelefonszámLabel.Text = "Elérhetőségek/Telefonszám:"
        '
        'Elérhetőségek_FaxszámLabel
        '
        Elérhetőségek_FaxszámLabel.AutoSize = True
        Elérhetőségek_FaxszámLabel.Location = New System.Drawing.Point(501, 600)
        Elérhetőségek_FaxszámLabel.Name = "Elérhetőségek_FaxszámLabel"
        Elérhetőségek_FaxszámLabel.Size = New System.Drawing.Size(124, 13)
        Elérhetőségek_FaxszámLabel.TabIndex = 7
        Elérhetőségek_FaxszámLabel.Text = "Elérhetőségek/Faxszám:"
        '
        'Elérhetőségek_E_mail_címLabel
        '
        Elérhetőségek_E_mail_címLabel.AutoSize = True
        Elérhetőségek_E_mail_címLabel.Location = New System.Drawing.Point(501, 625)
        Elérhetőségek_E_mail_címLabel.Name = "Elérhetőségek_E_mail_címLabel"
        Elérhetőségek_E_mail_címLabel.Size = New System.Drawing.Size(132, 13)
        Elérhetőségek_E_mail_címLabel.TabIndex = 8
        Elérhetőségek_E_mail_címLabel.Text = "Elérhetőségek/E-mail cím:"
        '
        'Állandólakcím_Közterület_neveLabel
        '
        Állandólakcím_Közterület_neveLabel.AutoSize = True
        Állandólakcím_Közterület_neveLabel.Location = New System.Drawing.Point(501, 75)
        Állandólakcím_Közterület_neveLabel.Name = "Állandólakcím_Közterület_neveLabel"
        Állandólakcím_Közterület_neveLabel.Size = New System.Drawing.Size(159, 13)
        Állandólakcím_Közterület_neveLabel.TabIndex = 13
        Állandólakcím_Közterület_neveLabel.Text = "Állandó lakcím/Közterület neve:"
        '
        'Állandólakcím_HázszámLabel
        '
        Állandólakcím_HázszámLabel.AutoSize = True
        Állandólakcím_HázszámLabel.Location = New System.Drawing.Point(501, 125)
        Állandólakcím_HázszámLabel.Name = "Állandólakcím_HázszámLabel"
        Állandólakcím_HázszámLabel.Size = New System.Drawing.Size(128, 13)
        Állandólakcím_HázszámLabel.TabIndex = 17
        Állandólakcím_HázszámLabel.Text = "Állandó lakcím/Házszám:"
        '
        'Állandólakcím_ÉpületLabel
        '
        Állandólakcím_ÉpületLabel.AutoSize = True
        Állandólakcím_ÉpületLabel.Location = New System.Drawing.Point(501, 150)
        Állandólakcím_ÉpületLabel.Name = "Állandólakcím_ÉpületLabel"
        Állandólakcím_ÉpületLabel.Size = New System.Drawing.Size(115, 13)
        Állandólakcím_ÉpületLabel.TabIndex = 19
        Állandólakcím_ÉpületLabel.Text = "Állandó lakcím/Épület:"
        '
        'Állandólakcím_LépcsőházLabel
        '
        Állandólakcím_LépcsőházLabel.AutoSize = True
        Állandólakcím_LépcsőházLabel.Location = New System.Drawing.Point(501, 175)
        Állandólakcím_LépcsőházLabel.Name = "Állandólakcím_LépcsőházLabel"
        Állandólakcím_LépcsőházLabel.Size = New System.Drawing.Size(137, 13)
        Állandólakcím_LépcsőházLabel.TabIndex = 21
        Állandólakcím_LépcsőházLabel.Text = "Állandó lakcím/Lépcsőház:"
        '
        'Állandólakcím_EmeletLabel
        '
        Állandólakcím_EmeletLabel.AutoSize = True
        Állandólakcím_EmeletLabel.Location = New System.Drawing.Point(501, 200)
        Állandólakcím_EmeletLabel.Name = "Állandólakcím_EmeletLabel"
        Állandólakcím_EmeletLabel.Size = New System.Drawing.Size(117, 13)
        Állandólakcím_EmeletLabel.TabIndex = 23
        Állandólakcím_EmeletLabel.Text = "Állandó lakcím/Emelet:"
        '
        'Állandólakcím_AjtóLabel
        '
        Állandólakcím_AjtóLabel.AutoSize = True
        Állandólakcím_AjtóLabel.Location = New System.Drawing.Point(501, 225)
        Állandólakcím_AjtóLabel.Name = "Állandólakcím_AjtóLabel"
        Állandólakcím_AjtóLabel.Size = New System.Drawing.Size(103, 13)
        Állandólakcím_AjtóLabel.TabIndex = 25
        Állandólakcím_AjtóLabel.Text = "Állandó lakcím/Ajtó:"
        '
        'Külföldi_cím_OrszágLabel
        '
        Külföldi_cím_OrszágLabel.AutoSize = True
        Külföldi_cím_OrszágLabel.Location = New System.Drawing.Point(501, 475)
        Külföldi_cím_OrszágLabel.Name = "Külföldi_cím_OrszágLabel"
        Külföldi_cím_OrszágLabel.Size = New System.Drawing.Size(103, 13)
        Külföldi_cím_OrszágLabel.TabIndex = 38
        Külföldi_cím_OrszágLabel.Text = "Külföldi cím/Ország:"
        '
        'Külföldi_cím_IrányítószámLabel
        '
        Külföldi_cím_IrányítószámLabel.AutoSize = True
        Külföldi_cím_IrányítószámLabel.Location = New System.Drawing.Point(501, 500)
        Külföldi_cím_IrányítószámLabel.Name = "Külföldi_cím_IrányítószámLabel"
        Külföldi_cím_IrányítószámLabel.Size = New System.Drawing.Size(130, 13)
        Külföldi_cím_IrányítószámLabel.TabIndex = 40
        Külföldi_cím_IrányítószámLabel.Text = "Külföldi cím/Irányítószám:"
        '
        'Külföldi_cím_Település_neveLabel
        '
        Külföldi_cím_Település_neveLabel.AutoSize = True
        Külföldi_cím_Település_neveLabel.Location = New System.Drawing.Point(501, 525)
        Külföldi_cím_Település_neveLabel.Name = "Külföldi_cím_Település_neveLabel"
        Külföldi_cím_Település_neveLabel.Size = New System.Drawing.Size(143, 13)
        Külföldi_cím_Település_neveLabel.TabIndex = 42
        Külföldi_cím_Település_neveLabel.Text = "Külföldi cím/Település neve:"
        '
        'Külföldi_cím_További_cím_adatokLabel
        '
        Külföldi_cím_További_cím_adatokLabel.AutoSize = True
        Külföldi_cím_További_cím_adatokLabel.Location = New System.Drawing.Point(501, 550)
        Külföldi_cím_További_cím_adatokLabel.Name = "Külföldi_cím_További_cím_adatokLabel"
        Külföldi_cím_További_cím_adatokLabel.Size = New System.Drawing.Size(166, 13)
        Külföldi_cím_További_cím_adatokLabel.TabIndex = 44
        Külföldi_cím_További_cím_adatokLabel.Text = "Külföldi cím/További cím adatok:"
        '
        'Képviselői_minőségeLabel
        '
        Képviselői_minőségeLabel.AutoSize = True
        Képviselői_minőségeLabel.Location = New System.Drawing.Point(3, 425)
        Képviselői_minőségeLabel.Name = "Képviselői_minőségeLabel"
        Képviselői_minőségeLabel.Size = New System.Drawing.Size(106, 13)
        Képviselői_minőségeLabel.TabIndex = 46
        Képviselői_minőségeLabel.Text = "Képviselői minősége:"
        '
        'Viselt_név_TitulusLabel
        '
        Viselt_név_TitulusLabel.AutoSize = True
        Viselt_név_TitulusLabel.Location = New System.Drawing.Point(3, 25)
        Viselt_név_TitulusLabel.Name = "Viselt_név_TitulusLabel"
        Viselt_név_TitulusLabel.Size = New System.Drawing.Size(41, 13)
        Viselt_név_TitulusLabel.TabIndex = 46
        Viselt_név_TitulusLabel.Text = "Titulus:"
        '
        'Viselt_név_Családi_névLabel
        '
        Viselt_név_Családi_névLabel.AutoSize = True
        Viselt_név_Családi_névLabel.Location = New System.Drawing.Point(3, 50)
        Viselt_név_Családi_névLabel.Name = "Viselt_név_Családi_névLabel"
        Viselt_név_Családi_névLabel.Size = New System.Drawing.Size(116, 13)
        Viselt_név_Családi_névLabel.TabIndex = 47
        Viselt_név_Családi_névLabel.Text = "Viselt név/Családi név:"
        '
        'Viselt_név_Első_utónévLabel
        '
        Viselt_név_Első_utónévLabel.AutoSize = True
        Viselt_név_Első_utónévLabel.Location = New System.Drawing.Point(3, 75)
        Viselt_név_Első_utónévLabel.Name = "Viselt_név_Első_utónévLabel"
        Viselt_név_Első_utónévLabel.Size = New System.Drawing.Size(117, 13)
        Viselt_név_Első_utónévLabel.TabIndex = 48
        Viselt_név_Első_utónévLabel.Text = "Viselt név/Első utónév:"
        '
        'Viselt_név_További_utónevekLabel
        '
        Viselt_név_További_utónevekLabel.AutoSize = True
        Viselt_név_További_utónevekLabel.Location = New System.Drawing.Point(3, 100)
        Viselt_név_További_utónevekLabel.Name = "Viselt_név_További_utónevekLabel"
        Viselt_név_További_utónevekLabel.Size = New System.Drawing.Size(148, 13)
        Viselt_név_További_utónevekLabel.TabIndex = 49
        Viselt_név_További_utónevekLabel.Text = "Viselt név/További utónevek:"
        '
        'Születési_név_Családi_névLabel
        '
        Születési_név_Családi_névLabel.AutoSize = True
        Születési_név_Családi_névLabel.Location = New System.Drawing.Point(3, 150)
        Születési_név_Családi_névLabel.Name = "Születési_név_Családi_névLabel"
        Születési_név_Családi_névLabel.Size = New System.Drawing.Size(133, 13)
        Születési_név_Családi_névLabel.TabIndex = 50
        Születési_név_Családi_névLabel.Text = "Születési név/Családi név:"
        '
        'Születési_név_Első_utónévLabel
        '
        Születési_név_Első_utónévLabel.AutoSize = True
        Születési_név_Első_utónévLabel.Location = New System.Drawing.Point(3, 175)
        Születési_név_Első_utónévLabel.Name = "Születési_név_Első_utónévLabel"
        Születési_név_Első_utónévLabel.Size = New System.Drawing.Size(134, 13)
        Születési_név_Első_utónévLabel.TabIndex = 51
        Születési_név_Első_utónévLabel.Text = "Születési név/Első utónév:"
        '
        'Születési_név_További_utónevekLabel
        '
        Születési_név_További_utónevekLabel.AutoSize = True
        Születési_név_További_utónevekLabel.Location = New System.Drawing.Point(3, 200)
        Születési_név_További_utónevekLabel.Name = "Születési_név_További_utónevekLabel"
        Születési_név_További_utónevekLabel.Size = New System.Drawing.Size(165, 13)
        Születési_név_További_utónevekLabel.TabIndex = 52
        Születési_név_További_utónevekLabel.Text = "Születési név/További utónevek:"
        '
        'Anyja_neve_Családi_névLabel
        '
        Anyja_neve_Családi_névLabel.AutoSize = True
        Anyja_neve_Családi_névLabel.Location = New System.Drawing.Point(3, 225)
        Anyja_neve_Családi_névLabel.Name = "Anyja_neve_Családi_névLabel"
        Anyja_neve_Családi_névLabel.Size = New System.Drawing.Size(123, 13)
        Anyja_neve_Családi_névLabel.TabIndex = 53
        Anyja_neve_Családi_névLabel.Text = "Anyja neve/Családi név:"
        '
        'Anyja_neve_Első_utónévLabel
        '
        Anyja_neve_Első_utónévLabel.AutoSize = True
        Anyja_neve_Első_utónévLabel.Location = New System.Drawing.Point(3, 250)
        Anyja_neve_Első_utónévLabel.Name = "Anyja_neve_Első_utónévLabel"
        Anyja_neve_Első_utónévLabel.Size = New System.Drawing.Size(124, 13)
        Anyja_neve_Első_utónévLabel.TabIndex = 54
        Anyja_neve_Első_utónévLabel.Text = "Anyja neve/Első utónév:"
        '
        'Anyja_neve_További_utónevekLabel
        '
        Anyja_neve_További_utónevekLabel.AutoSize = True
        Anyja_neve_További_utónevekLabel.Location = New System.Drawing.Point(3, 275)
        Anyja_neve_További_utónevekLabel.Name = "Anyja_neve_További_utónevekLabel"
        Anyja_neve_További_utónevekLabel.Size = New System.Drawing.Size(155, 13)
        Anyja_neve_További_utónevekLabel.TabIndex = 56
        Anyja_neve_További_utónevekLabel.Text = "Anyja neve/További utónevek:"
        '
        'Születési_ország_neveLabel
        '
        Születési_ország_neveLabel.AutoSize = True
        Születési_ország_neveLabel.Location = New System.Drawing.Point(3, 300)
        Születési_ország_neveLabel.Name = "Születési_ország_neveLabel"
        Születési_ország_neveLabel.Size = New System.Drawing.Size(113, 13)
        Születési_ország_neveLabel.TabIndex = 58
        Születési_ország_neveLabel.Text = "Születési ország neve:"
        '
        'Születési_település_neveLabel
        '
        Születési_település_neveLabel.AutoSize = True
        Születési_település_neveLabel.Location = New System.Drawing.Point(3, 325)
        Születési_település_neveLabel.Name = "Születési_település_neveLabel"
        Születési_település_neveLabel.Size = New System.Drawing.Size(124, 13)
        Születési_település_neveLabel.TabIndex = 60
        Születési_település_neveLabel.Text = "Születési település neve:"
        '
        'Születési_idejeLabel
        '
        Születési_idejeLabel.AutoSize = True
        Születési_idejeLabel.Location = New System.Drawing.Point(3, 350)
        Születési_idejeLabel.Name = "Születési_idejeLabel"
        Születési_idejeLabel.Size = New System.Drawing.Size(77, 13)
        Születési_idejeLabel.TabIndex = 62
        Születési_idejeLabel.Text = "Születési ideje:"
        '
        'Munkahely_neveLabel
        '
        Munkahely_neveLabel.AutoSize = True
        Munkahely_neveLabel.Location = New System.Drawing.Point(3, 375)
        Munkahely_neveLabel.Name = "Munkahely_neveLabel"
        Munkahely_neveLabel.Size = New System.Drawing.Size(89, 13)
        Munkahely_neveLabel.TabIndex = 64
        Munkahely_neveLabel.Text = "Munkahely neve:"
        '
        'Levelezési_címe_Közterület_neveLabel
        '
        Levelezési_címe_Közterület_neveLabel.AutoSize = True
        Levelezési_címe_Közterület_neveLabel.Location = New System.Drawing.Point(501, 300)
        Levelezési_címe_Közterület_neveLabel.Name = "Levelezési_címe_Közterület_neveLabel"
        Levelezési_címe_Közterület_neveLabel.Size = New System.Drawing.Size(160, 13)
        Levelezési_címe_Közterület_neveLabel.TabIndex = 70
        Levelezési_címe_Közterület_neveLabel.Text = "Levelezési cím/Közterület neve:"
        '
        'Levelezési_címe_HázszámLabel
        '
        Levelezési_címe_HázszámLabel.AutoSize = True
        Levelezési_címe_HázszámLabel.Location = New System.Drawing.Point(501, 350)
        Levelezési_címe_HázszámLabel.Name = "Levelezési_címe_HázszámLabel"
        Levelezési_címe_HázszámLabel.Size = New System.Drawing.Size(129, 13)
        Levelezési_címe_HázszámLabel.TabIndex = 74
        Levelezési_címe_HázszámLabel.Text = "Levelezési cím/Házszám:"
        '
        'Levelezési_címe_ÉpületLabel
        '
        Levelezési_címe_ÉpületLabel.AutoSize = True
        Levelezési_címe_ÉpületLabel.Location = New System.Drawing.Point(501, 375)
        Levelezési_címe_ÉpületLabel.Name = "Levelezési_címe_ÉpületLabel"
        Levelezési_címe_ÉpületLabel.Size = New System.Drawing.Size(116, 13)
        Levelezési_címe_ÉpületLabel.TabIndex = 76
        Levelezési_címe_ÉpületLabel.Text = "Levelezési cím/Épület:"
        '
        'Levelezési_címe_LépcsőházLabel
        '
        Levelezési_címe_LépcsőházLabel.AutoSize = True
        Levelezési_címe_LépcsőházLabel.Location = New System.Drawing.Point(501, 400)
        Levelezési_címe_LépcsőházLabel.Name = "Levelezési_címe_LépcsőházLabel"
        Levelezési_címe_LépcsőházLabel.Size = New System.Drawing.Size(138, 13)
        Levelezési_címe_LépcsőházLabel.TabIndex = 78
        Levelezési_címe_LépcsőházLabel.Text = "Levelezési cím/Lépcsőház:"
        '
        'Levelezési_címe_EmeletLabel
        '
        Levelezési_címe_EmeletLabel.AutoSize = True
        Levelezési_címe_EmeletLabel.Location = New System.Drawing.Point(501, 425)
        Levelezési_címe_EmeletLabel.Name = "Levelezési_címe_EmeletLabel"
        Levelezési_címe_EmeletLabel.Size = New System.Drawing.Size(118, 13)
        Levelezési_címe_EmeletLabel.TabIndex = 80
        Levelezési_címe_EmeletLabel.Text = "Levelezési cím/Emelet:"
        '
        'Levelezési_címe_AjtóLabel
        '
        Levelezési_címe_AjtóLabel.AutoSize = True
        Levelezési_címe_AjtóLabel.Location = New System.Drawing.Point(501, 450)
        Levelezési_címe_AjtóLabel.Name = "Levelezési_címe_AjtóLabel"
        Levelezési_címe_AjtóLabel.Size = New System.Drawing.Size(104, 13)
        Levelezési_címe_AjtóLabel.TabIndex = 82
        Levelezési_címe_AjtóLabel.Text = "Levelezési cím/Ajtó:"
        '
        'Teljes_neveLabel
        '
        Teljes_neveLabel.AutoSize = True
        Teljes_neveLabel.Location = New System.Drawing.Point(3, 125)
        Teljes_neveLabel.Name = "Teljes_neveLabel"
        Teljes_neveLabel.Size = New System.Drawing.Size(59, 13)
        Teljes_neveLabel.TabIndex = 84
        Teljes_neveLabel.Text = "Teljes név:"
        '
        'Állandó_lakcíme_IrányítószámLabel
        '
        Állandó_lakcíme_IrányítószámLabel.AutoSize = True
        Állandó_lakcíme_IrányítószámLabel.Location = New System.Drawing.Point(501, 25)
        Állandó_lakcíme_IrányítószámLabel.Name = "Állandó_lakcíme_IrányítószámLabel"
        Állandó_lakcíme_IrányítószámLabel.Size = New System.Drawing.Size(150, 13)
        Állandó_lakcíme_IrányítószámLabel.TabIndex = 85
        Állandó_lakcíme_IrányítószámLabel.Text = "Állandó lakcím//Irányítószám:"
        '
        'Állandó_lakcíme_Település_neveLabel
        '
        Állandó_lakcíme_Település_neveLabel.AutoSize = True
        Állandó_lakcíme_Település_neveLabel.Location = New System.Drawing.Point(501, 50)
        Állandó_lakcíme_Település_neveLabel.Name = "Állandó_lakcíme_Település_neveLabel"
        Állandó_lakcíme_Település_neveLabel.Size = New System.Drawing.Size(163, 13)
        Állandó_lakcíme_Település_neveLabel.TabIndex = 87
        Állandó_lakcíme_Település_neveLabel.Text = "Állandó lakcím//Település neve:"
        '
        'Levelezési_címe_Település_neveLabel
        '
        Levelezési_címe_Település_neveLabel.AutoSize = True
        Levelezési_címe_Település_neveLabel.Location = New System.Drawing.Point(501, 275)
        Levelezési_címe_Település_neveLabel.Name = "Levelezési_címe_Település_neveLabel"
        Levelezési_címe_Település_neveLabel.Size = New System.Drawing.Size(159, 13)
        Levelezési_címe_Település_neveLabel.TabIndex = 88
        Levelezési_címe_Település_neveLabel.Text = "Levelezési cím/Település neve:"
        '
        'Állandó_lakcím_Közterület_jellegeLabel
        '
        Állandó_lakcím_Közterület_jellegeLabel.AutoSize = True
        Állandó_lakcím_Közterület_jellegeLabel.Location = New System.Drawing.Point(501, 100)
        Állandó_lakcím_Közterület_jellegeLabel.Name = "Állandó_lakcím_Közterület_jellegeLabel"
        Állandó_lakcím_Közterület_jellegeLabel.Size = New System.Drawing.Size(165, 13)
        Állandó_lakcím_Közterület_jellegeLabel.TabIndex = 89
        Állandó_lakcím_Közterület_jellegeLabel.Text = "Állandó lakcím/Közterület jellege:"
        '
        'Levelezési_címe_Közterület_jellegeLabel
        '
        Levelezési_címe_Közterület_jellegeLabel.AutoSize = True
        Levelezési_címe_Közterület_jellegeLabel.Location = New System.Drawing.Point(501, 325)
        Levelezési_címe_Közterület_jellegeLabel.Name = "Levelezési_címe_Közterület_jellegeLabel"
        Levelezési_címe_Közterület_jellegeLabel.Size = New System.Drawing.Size(166, 13)
        Levelezési_címe_Közterület_jellegeLabel.TabIndex = 90
        Levelezési_címe_Közterület_jellegeLabel.Text = "Levelezési cím/Közterület jellege:"
        '
        'MyBindingSource
        '
        Me.MyBindingSource.DataMember = "Term_szemely_rogzito"
        Me.MyBindingSource.DataSource = Me.TorzsAdatbazisDataSet
        '
        'TorzsAdatbazisDataSet
        '
        Me.TorzsAdatbazisDataSet.DataSetName = "TorzsAdatbazisDataSet"
        Me.TorzsAdatbazisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KepviselominosegeBindingSource
        '
        Me.KepviselominosegeBindingSource.DataMember = "Kepviselo_minosege"
        Me.KepviselominosegeBindingSource.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'NyomtatvanyAdatokDataSet
        '
        Me.NyomtatvanyAdatokDataSet.DataSetName = "NyomtatvanyAdatokDataSet"
        Me.NyomtatvanyAdatokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrszagkoddalBindingSource
        '
        Me.OrszagkoddalBindingSource.DataMember = "Orszag_koddal"
        Me.OrszagkoddalBindingSource.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'KozteruletBindingSource
        '
        Me.KozteruletBindingSource.AllowNew = False
        Me.KozteruletBindingSource.DataMember = "Kozterulet"
        Me.KozteruletBindingSource.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'HelysegBindingSource
        '
        Me.HelysegBindingSource.AllowNew = False
        Me.HelysegBindingSource.DataMember = "Helyseg"
        Me.HelysegBindingSource.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'RogzitoTableAdapter
        '
        Me.RogzitoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Ceg_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Egyeb_jogi_kvo_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Egyeb_szervezet_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Egyeni_ugyvedi_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.EV_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Jogtanacsos_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Term_szemely_rogzitoTableAdapter = Me.RogzitoTableAdapter
        Me.TableAdapterManager.Ugytorzs_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Ugyvedi_iroda_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MyBindingNavigator
        '
        Me.MyBindingNavigator.AddNewItem = Nothing
        Me.MyBindingNavigator.BindingSource = Me.MyBindingSource
        Me.MyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MyBindingNavigator.CountItemFormat = "/{0}"
        Me.MyBindingNavigator.DeleteItem = Nothing
        Me.MyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem, Me.ToolStripSeparator4, Me.ToolStrip_Cég, Me.ToolStrip_ESZ, Me.ToolStrip_EV, Me.ToolStrip_Termsz, Me.ToolStrip_Üi, Me.ToolStrip_Ügyvéd, Me.ToolStrip_Jogtanácsos, Me.ToolStrip_Egyébjogiképviselő, Me.ToolStripSeparator1, Me.tbKereso, Me.btnKeres})
        Me.MyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MyBindingNavigator.Name = "MyBindingNavigator"
        Me.MyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MyBindingNavigator.Size = New System.Drawing.Size(996, 25)
        Me.MyBindingNavigator.TabIndex = 1
        Me.MyBindingNavigator.Text = "MyBindingNavigator"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(26, 22)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Össze rekord számas"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Első rekordra"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Előző rekordra"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Jelenlegi pozíció"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Következő rekordra"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Utolsó rekordra"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Új hozzáadása"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Töröl"
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorSaveItem.Text = "Adat elmentése"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip_Cég
        '
        Me.ToolStrip_Cég.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStrip_Cég.Image = CType(resources.GetObject("ToolStrip_Cég.Image"), System.Drawing.Image)
        Me.ToolStrip_Cég.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_Cég.Name = "ToolStrip_Cég"
        Me.ToolStrip_Cég.Size = New System.Drawing.Size(32, 22)
        Me.ToolStrip_Cég.Text = "Cég"
        '
        'ToolStrip_ESZ
        '
        Me.ToolStrip_ESZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStrip_ESZ.Image = CType(resources.GetObject("ToolStrip_ESZ.Image"), System.Drawing.Image)
        Me.ToolStrip_ESZ.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStrip_ESZ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_ESZ.Name = "ToolStrip_ESZ"
        Me.ToolStrip_ESZ.Size = New System.Drawing.Size(59, 22)
        Me.ToolStrip_ESZ.Text = "Egyéb sz."
        Me.ToolStrip_ESZ.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStrip_EV
        '
        Me.ToolStrip_EV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStrip_EV.Image = CType(resources.GetObject("ToolStrip_EV.Image"), System.Drawing.Image)
        Me.ToolStrip_EV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_EV.Name = "ToolStrip_EV"
        Me.ToolStrip_EV.Size = New System.Drawing.Size(24, 22)
        Me.ToolStrip_EV.Text = "EV"
        '
        'ToolStrip_Termsz
        '
        Me.ToolStrip_Termsz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStrip_Termsz.Image = CType(resources.GetObject("ToolStrip_Termsz.Image"), System.Drawing.Image)
        Me.ToolStrip_Termsz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_Termsz.Name = "ToolStrip_Termsz"
        Me.ToolStrip_Termsz.Size = New System.Drawing.Size(54, 22)
        Me.ToolStrip_Termsz.Text = "Term.sz."
        '
        'ToolStrip_Üi
        '
        Me.ToolStrip_Üi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStrip_Üi.Image = CType(resources.GetObject("ToolStrip_Üi.Image"), System.Drawing.Image)
        Me.ToolStrip_Üi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_Üi.Name = "ToolStrip_Üi"
        Me.ToolStrip_Üi.Size = New System.Drawing.Size(28, 22)
        Me.ToolStrip_Üi.Text = "Ü.i."
        '
        'ToolStrip_Ügyvéd
        '
        Me.ToolStrip_Ügyvéd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStrip_Ügyvéd.Image = CType(resources.GetObject("ToolStrip_Ügyvéd.Image"), System.Drawing.Image)
        Me.ToolStrip_Ügyvéd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_Ügyvéd.Name = "ToolStrip_Ügyvéd"
        Me.ToolStrip_Ügyvéd.Size = New System.Drawing.Size(51, 22)
        Me.ToolStrip_Ügyvéd.Text = "Ügyvéd"
        '
        'ToolStrip_Jogtanácsos
        '
        Me.ToolStrip_Jogtanácsos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStrip_Jogtanácsos.Image = CType(resources.GetObject("ToolStrip_Jogtanácsos.Image"), System.Drawing.Image)
        Me.ToolStrip_Jogtanácsos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_Jogtanácsos.Name = "ToolStrip_Jogtanácsos"
        Me.ToolStrip_Jogtanácsos.Size = New System.Drawing.Size(75, 22)
        Me.ToolStrip_Jogtanácsos.Text = "Jogtanácsos"
        '
        'ToolStrip_Egyébjogiképviselő
        '
        Me.ToolStrip_Egyébjogiképviselő.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStrip_Egyébjogiképviselő.Image = CType(resources.GetObject("ToolStrip_Egyébjogiképviselő.Image"), System.Drawing.Image)
        Me.ToolStrip_Egyébjogiképviselő.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrip_Egyébjogiképviselő.Name = "ToolStrip_Egyébjogiképviselő"
        Me.ToolStrip_Egyébjogiképviselő.Size = New System.Drawing.Size(84, 22)
        Me.ToolStrip_Egyébjogiképviselő.Text = "Egyéb jogi kv."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbKereso
        '
        Me.tbKereso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbKereso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbKereso.BackColor = System.Drawing.Color.Linen
        Me.tbKereso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKereso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbKereso.Name = "tbKereso"
        Me.tbKereso.Size = New System.Drawing.Size(100, 25)
        '
        'btnKeres
        '
        Me.btnKeres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnKeres.Image = CType(resources.GetObject("btnKeres.Image"), System.Drawing.Image)
        Me.btnKeres.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnKeres.Name = "btnKeres"
        Me.btnKeres.Size = New System.Drawing.Size(49, 22)
        Me.btnKeres.Text = "keresés"
        '
        'KozteruletTableAdapter
        '
        Me.KozteruletTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TitulusBindingSource
        '
        Me.TitulusBindingSource.AllowNew = False
        Me.TitulusBindingSource.DataMember = "Titulus"
        Me.TitulusBindingSource.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'TitulusTableAdapter
        '
        Me.TitulusTableAdapter.ClearBeforeFill = True
        '
        'HelysegTableAdapter
        '
        Me.HelysegTableAdapter.ClearBeforeFill = True
        '
        'CegformaTableAdapter
        '
        Me.CegformaTableAdapter.ClearBeforeFill = True
        '
        'Kepviselo_minosegeTableAdapter
        '
        Me.Kepviselo_minosegeTableAdapter.ClearBeforeFill = True
        '
        'Orszag_koddalTableAdapter
        '
        Me.Orszag_koddalTableAdapter.ClearBeforeFill = True
        '
        'AdóazonosítóMaskedBox
        '
        Me.AdóazonosítóMaskedBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.AdóazonosítóMaskedBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Adóazonosító jel", True))
        Me.AdóazonosítóMaskedBox.Location = New System.Drawing.Point(252, 453)
        Me.AdóazonosítóMaskedBox.Mask = "0000000000"
        Me.AdóazonosítóMaskedBox.Name = "AdóazonosítóMaskedBox"
        Me.AdóazonosítóMaskedBox.Size = New System.Drawing.Size(86, 20)
        Me.AdóazonosítóMaskedBox.TabIndex = 16
        Me.AdóazonosítóMaskedBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btnBezaresMent
        '
        Me.btnBezaresMent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBezaresMent.AutoSize = True
        Me.btnBezaresMent.Location = New System.Drawing.Point(331, 678)
        Me.btnBezaresMent.Name = "btnBezaresMent"
        Me.btnBezaresMent.Size = New System.Drawing.Size(84, 23)
        Me.btnBezaresMent.TabIndex = 42
        Me.btnBezaresMent.Text = "Bezár és ment"
        Me.btnBezaresMent.UseVisualStyleBackColor = True
        '
        'btnBezarNemMent
        '
        Me.btnBezarNemMent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBezarNemMent.Location = New System.Drawing.Point(585, 678)
        Me.btnBezarNemMent.Name = "btnBezarNemMent"
        Me.btnBezarNemMent.Size = New System.Drawing.Size(75, 23)
        Me.btnBezarNemMent.TabIndex = 43
        Me.btnBezarNemMent.Text = "Elvet"
        Me.btnBezarNemMent.UseVisualStyleBackColor = True
        '
        'Elérhetőségek_TelefonszámTextBox
        '
        Me.Elérhetőségek_TelefonszámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Elérhetőségek/Telefonszám", True))
        Me.Elérhetőségek_TelefonszámTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Elérhetőségek_TelefonszámTextBox.Location = New System.Drawing.Point(750, 578)
        Me.Elérhetőségek_TelefonszámTextBox.MaxLength = 25
        Me.Elérhetőségek_TelefonszámTextBox.Name = "Elérhetőségek_TelefonszámTextBox"
        Me.Elérhetőségek_TelefonszámTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Elérhetőségek_TelefonszámTextBox.TabIndex = 39
        '
        'Elérhetőségek_FaxszámTextBox
        '
        Me.Elérhetőségek_FaxszámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Elérhetőségek/Faxszám", True))
        Me.Elérhetőségek_FaxszámTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Elérhetőségek_FaxszámTextBox.Location = New System.Drawing.Point(750, 603)
        Me.Elérhetőségek_FaxszámTextBox.MaxLength = 25
        Me.Elérhetőségek_FaxszámTextBox.Name = "Elérhetőségek_FaxszámTextBox"
        Me.Elérhetőségek_FaxszámTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Elérhetőségek_FaxszámTextBox.TabIndex = 40
        '
        'Elérhetőségek_E_mail_címTextBox
        '
        Me.Elérhetőségek_E_mail_címTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Elérhetőségek/E-mail cím", True))
        Me.Elérhetőségek_E_mail_címTextBox.Location = New System.Drawing.Point(750, 628)
        Me.Elérhetőségek_E_mail_címTextBox.MaxLength = 50
        Me.Elérhetőségek_E_mail_címTextBox.Name = "Elérhetőségek_E_mail_címTextBox"
        Me.Elérhetőségek_E_mail_címTextBox.Size = New System.Drawing.Size(216, 20)
        Me.Elérhetőségek_E_mail_címTextBox.TabIndex = 41
        '
        'Állandólakcím_Közterület_neveTextBox
        '
        Me.Állandólakcím_Közterület_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Állandó lakcím/Közterület neve", True))
        Me.Állandólakcím_Közterület_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Állandólakcím_Közterület_neveTextBox.Location = New System.Drawing.Point(750, 78)
        Me.Állandólakcím_Közterület_neveTextBox.MaxLength = 25
        Me.Állandólakcím_Közterület_neveTextBox.Name = "Állandólakcím_Közterület_neveTextBox"
        Me.Állandólakcím_Közterület_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Állandólakcím_Közterület_neveTextBox.TabIndex = 19
        '
        'Állandólakcím_HázszámTextBox
        '
        Me.Állandólakcím_HázszámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Állandó lakcím/Házszám", True))
        Me.Állandólakcím_HázszámTextBox.Location = New System.Drawing.Point(750, 128)
        Me.Állandólakcím_HázszámTextBox.MaxLength = 10
        Me.Állandólakcím_HázszámTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_HázszámTextBox.Name = "Állandólakcím_HázszámTextBox"
        Me.Állandólakcím_HázszámTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_HázszámTextBox.TabIndex = 21
        '
        'Állandólakcím_ÉpületTextBox
        '
        Me.Állandólakcím_ÉpületTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Állandó lakcím/Épület", True))
        Me.Állandólakcím_ÉpületTextBox.Location = New System.Drawing.Point(750, 153)
        Me.Állandólakcím_ÉpületTextBox.MaxLength = 10
        Me.Állandólakcím_ÉpületTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_ÉpületTextBox.Name = "Állandólakcím_ÉpületTextBox"
        Me.Állandólakcím_ÉpületTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_ÉpületTextBox.TabIndex = 22
        '
        'Állandólakcím_LépcsőházTextBox
        '
        Me.Állandólakcím_LépcsőházTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Állandó lakcím/Lépcsőház", True))
        Me.Állandólakcím_LépcsőházTextBox.Location = New System.Drawing.Point(750, 178)
        Me.Állandólakcím_LépcsőházTextBox.MaxLength = 10
        Me.Állandólakcím_LépcsőházTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_LépcsőházTextBox.Name = "Állandólakcím_LépcsőházTextBox"
        Me.Állandólakcím_LépcsőházTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_LépcsőházTextBox.TabIndex = 23
        '
        'Állandólakcím_EmeletTextBox
        '
        Me.Állandólakcím_EmeletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Állandó lakcím/Emelet", True))
        Me.Állandólakcím_EmeletTextBox.Location = New System.Drawing.Point(750, 203)
        Me.Állandólakcím_EmeletTextBox.MaxLength = 10
        Me.Állandólakcím_EmeletTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_EmeletTextBox.Name = "Állandólakcím_EmeletTextBox"
        Me.Állandólakcím_EmeletTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_EmeletTextBox.TabIndex = 24
        '
        'Állandólakcím_AjtóTextBox
        '
        Me.Állandólakcím_AjtóTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Állandó lakcím/Ajtó", True))
        Me.Állandólakcím_AjtóTextBox.Location = New System.Drawing.Point(750, 228)
        Me.Állandólakcím_AjtóTextBox.MaxLength = 10
        Me.Állandólakcím_AjtóTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_AjtóTextBox.Name = "Állandólakcím_AjtóTextBox"
        Me.Állandólakcím_AjtóTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Állandólakcím_AjtóTextBox.TabIndex = 25
        '
        'Külföldi_cím_OrszágComboBox
        '
        Me.Külföldi_cím_OrszágComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Külföldi_cím_OrszágComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Külföldi_cím_OrszágComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Külföldi cím/Ország", True))
        Me.Külföldi_cím_OrszágComboBox.DataSource = Me.OrszagkoddalBindingSource
        Me.Külföldi_cím_OrszágComboBox.DisplayMember = "OrszágkódNévvel"
        Me.Külföldi_cím_OrszágComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Külföldi_cím_OrszágComboBox.Location = New System.Drawing.Point(750, 478)
        Me.Külföldi_cím_OrszágComboBox.MaxLength = 10
        Me.Külföldi_cím_OrszágComboBox.Name = "Külföldi_cím_OrszágComboBox"
        Me.Külföldi_cím_OrszágComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Külföldi_cím_OrszágComboBox.TabIndex = 35
        Me.Külföldi_cím_OrszágComboBox.ValueMember = "Országkód"
        '
        'Külföldi_cím_IrányítószámTextBox
        '
        Me.Külföldi_cím_IrányítószámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Külföldi cím/Irányítószám", True))
        Me.Külföldi_cím_IrányítószámTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Külföldi_cím_IrányítószámTextBox.Location = New System.Drawing.Point(750, 503)
        Me.Külföldi_cím_IrányítószámTextBox.MaxLength = 15
        Me.Külföldi_cím_IrányítószámTextBox.Name = "Külföldi_cím_IrányítószámTextBox"
        Me.Külföldi_cím_IrányítószámTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Külföldi_cím_IrányítószámTextBox.TabIndex = 36
        '
        'Külföldi_cím_Település_neveTextBox
        '
        Me.Külföldi_cím_Település_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Külföldi cím/Település neve", True))
        Me.Külföldi_cím_Település_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Külföldi_cím_Település_neveTextBox.Location = New System.Drawing.Point(750, 528)
        Me.Külföldi_cím_Település_neveTextBox.MaxLength = 25
        Me.Külföldi_cím_Település_neveTextBox.Name = "Külföldi_cím_Település_neveTextBox"
        Me.Külföldi_cím_Település_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Külföldi_cím_Település_neveTextBox.TabIndex = 37
        '
        'Külföldi_cím_További_cím_adatokTextBox
        '
        Me.Külföldi_cím_További_cím_adatokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Külföldi cím/További cím adatok", True))
        Me.Külföldi_cím_További_cím_adatokTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Külföldi_cím_További_cím_adatokTextBox.Location = New System.Drawing.Point(750, 553)
        Me.Külföldi_cím_További_cím_adatokTextBox.MaxLength = 100
        Me.Külföldi_cím_További_cím_adatokTextBox.Name = "Külföldi_cím_További_cím_adatokTextBox"
        Me.Külföldi_cím_További_cím_adatokTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Külföldi_cím_További_cím_adatokTextBox.TabIndex = 38
        '
        'Képviselői_minőségeComboBox
        '
        Me.Képviselői_minőségeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Képviselői_minőségeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Képviselői_minőségeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Képviselői minősége", True))
        Me.Képviselői_minőségeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Képviselői minősége", True))
        Me.Képviselői_minőségeComboBox.DataSource = Me.KepviselominosegeBindingSource
        Me.Képviselői_minőségeComboBox.DisplayMember = "Neve"
        Me.Képviselői_minőségeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Képviselői_minőségeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Képviselői_minőségeComboBox.Location = New System.Drawing.Point(252, 428)
        Me.Képviselői_minőségeComboBox.Name = "Képviselői_minőségeComboBox"
        Me.Képviselői_minőségeComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Képviselői_minőségeComboBox.TabIndex = 15
        Me.Képviselői_minőségeComboBox.ValueMember = "Neve"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Levelezési_címe_Közterület_jellegeLabel, 2, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_Közterület_jellegeComboBox, 3, 13)
        Me.TableLayoutPanel1.Controls.Add(Állandó_lakcím_Közterület_jellegeLabel, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_Közterület_jellegeComboBox, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Levelezési_címe_Település_neveLabel, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_Település_neveComboBox, 3, 11)
        Me.TableLayoutPanel1.Controls.Add(Állandó_lakcíme_Település_neveLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_Település_neveComboBox, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Állandó_lakcíme_IrányítószámLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Teljes_neveLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Teljes_neveTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Levelezési_címe_AjtóLabel, 2, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_AjtóTextBox, 3, 18)
        Me.TableLayoutPanel1.Controls.Add(Levelezési_címe_EmeletLabel, 2, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_EmeletTextBox, 3, 17)
        Me.TableLayoutPanel1.Controls.Add(Levelezési_címe_LépcsőházLabel, 2, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_LépcsőházTextBox, 3, 16)
        Me.TableLayoutPanel1.Controls.Add(Levelezési_címe_ÉpületLabel, 2, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_ÉpületTextBox, 3, 15)
        Me.TableLayoutPanel1.Controls.Add(Levelezési_címe_HázszámLabel, 2, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_HázszámTextBox, 3, 14)
        Me.TableLayoutPanel1.Controls.Add(Levelezési_címe_Közterület_neveLabel, 2, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_Közterület_neveTextBox, 3, 12)
        Me.TableLayoutPanel1.Controls.Add(Viselt_név_További_utónevekLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Viselt_név_További_utónevekTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Viselt_név_Első_utónévLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Viselt_név_Első_utónévTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Viselt_név_Családi_névLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Viselt_név_Családi_névTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Viselt_név_TitulusLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Viselt_név_TitulusComboBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Képviselői_minőségeComboBox, 1, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.Külföldi_cím_További_cím_adatokTextBox, 3, 22)
        Me.TableLayoutPanel1.Controls.Add(Külföldi_cím_Település_neveLabel, 2, 21)
        Me.TableLayoutPanel1.Controls.Add(Me.Külföldi_cím_Település_neveTextBox, 3, 21)
        Me.TableLayoutPanel1.Controls.Add(Külföldi_cím_IrányítószámLabel, 2, 20)
        Me.TableLayoutPanel1.Controls.Add(Me.Külföldi_cím_IrányítószámTextBox, 3, 20)
        Me.TableLayoutPanel1.Controls.Add(Külföldi_cím_OrszágLabel, 2, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.Külföldi_cím_OrszágComboBox, 3, 19)
        Me.TableLayoutPanel1.Controls.Add(Állandólakcím_AjtóLabel, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_AjtóTextBox, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Állandólakcím_EmeletLabel, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_EmeletTextBox, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Állandólakcím_LépcsőházLabel, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_LépcsőházTextBox, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Állandólakcím_ÉpületLabel, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_ÉpületTextBox, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Állandólakcím_HázszámLabel, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_HázszámTextBox, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Állandólakcím_Közterület_neveLabel, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_Közterület_neveTextBox, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Elérhetőségek_E_mail_címTextBox, 3, 25)
        Me.TableLayoutPanel1.Controls.Add(Me.Elérhetőségek_FaxszámTextBox, 3, 24)
        Me.TableLayoutPanel1.Controls.Add(Me.Elérhetőségek_TelefonszámTextBox, 3, 23)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBezarNemMent, 2, 26)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBezaresMent, 1, 26)
        Me.TableLayoutPanel1.Controls.Add(Elérhetőségek_E_mail_címLabel, 2, 25)
        Me.TableLayoutPanel1.Controls.Add(Elérhetőségek_FaxszámLabel, 2, 24)
        Me.TableLayoutPanel1.Controls.Add(Elérhetőségek_TelefonszámLabel, 2, 23)
        Me.TableLayoutPanel1.Controls.Add(AdóazonosítóLabel, 0, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.AdóazonosítóMaskedBox, 1, 18)
        Me.TableLayoutPanel1.Controls.Add(Külföldi_cím_További_cím_adatokLabel, 2, 22)
        Me.TableLayoutPanel1.Controls.Add(Munkahely_neveLabel, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.Munkahely_neveTextBox, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.Születési_idejeMaskedBox, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Születési_település_neveTextBox, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Születési_idejeLabel, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Születési_település_neveLabel, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Születési_ország_neveTextBox, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Születési_ország_neveLabel, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Anyja_neve_További_utónevekTextBox, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Anyja_neve_További_utónevekLabel, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Anyja_neve_Első_utónévLabel, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Anyja_neve_Első_utónévTextBox, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Anyja_neve_Családi_névLabel, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Anyja_neve_Családi_névTextBox, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Születési_név_További_utónevekLabel, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Születési_név_További_utónevekTextBox, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Születési_név_Első_utónévLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Születési_név_Első_utónévTextBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Születési_név_Családi_névLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Születési_név_Családi_névTextBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Képviselői_minőségeLabel, 0, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Levelezési_címe_IrányítószámComboBox, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Állandólakcím_IrányítószámComboBox, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 0, 26)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 27
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.624143!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.21262!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(996, 717)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Levelezési_címe_Közterület_jellegeComboBox
        '
        Me.Levelezési_címe_Közterület_jellegeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Levelezési_címe_Közterület_jellegeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Levelezési_címe_Közterület_jellegeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Levelezési cím/Közterület jellege", True))
        Me.Levelezési_címe_Közterület_jellegeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Levelezési cím/Közterület jellege", True))
        Me.Levelezési_címe_Közterület_jellegeComboBox.DataSource = Me.KozteruletBindingSource2
        Me.Levelezési_címe_Közterület_jellegeComboBox.DisplayMember = "Nev"
        Me.Levelezési_címe_Közterület_jellegeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Levelezési_címe_Közterület_jellegeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Levelezési_címe_Közterület_jellegeComboBox.Location = New System.Drawing.Point(750, 328)
        Me.Levelezési_címe_Közterület_jellegeComboBox.MaxLength = 40
        Me.Levelezési_címe_Közterület_jellegeComboBox.Name = "Levelezési_címe_Közterület_jellegeComboBox"
        Me.Levelezési_címe_Közterület_jellegeComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Levelezési_címe_Közterület_jellegeComboBox.TabIndex = 29
        Me.Levelezési_címe_Közterület_jellegeComboBox.ValueMember = "Nev"
        '
        'KozteruletBindingSource2
        '
        Me.KozteruletBindingSource2.AllowNew = False
        Me.KozteruletBindingSource2.DataMember = "Kozterulet"
        Me.KozteruletBindingSource2.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'Állandólakcím_Közterület_jellegeComboBox
        '
        Me.Állandólakcím_Közterület_jellegeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Állandólakcím_Közterület_jellegeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Állandólakcím_Közterület_jellegeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Állandó lakcím/Közterület jellege", True))
        Me.Állandólakcím_Közterület_jellegeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Állandó lakcím/Közterület jellege", True))
        Me.Állandólakcím_Közterület_jellegeComboBox.DataSource = Me.KozteruletBindingSource
        Me.Állandólakcím_Közterület_jellegeComboBox.DisplayMember = "Nev"
        Me.Állandólakcím_Közterület_jellegeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Állandólakcím_Közterület_jellegeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Állandólakcím_Közterület_jellegeComboBox.Location = New System.Drawing.Point(750, 103)
        Me.Állandólakcím_Közterület_jellegeComboBox.MaxLength = 40
        Me.Állandólakcím_Közterület_jellegeComboBox.Name = "Állandólakcím_Közterület_jellegeComboBox"
        Me.Állandólakcím_Közterület_jellegeComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Állandólakcím_Közterület_jellegeComboBox.TabIndex = 20
        Me.Állandólakcím_Közterület_jellegeComboBox.ValueMember = "Nev"
        '
        'Levelezési_címe_Település_neveComboBox
        '
        Me.Levelezési_címe_Település_neveComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Levelezési_címe_Település_neveComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Levelezési_címe_Település_neveComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Levelezési cím/Település neve", True))
        Me.Levelezési_címe_Település_neveComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Levelezési cím/Település neve", True))
        Me.Levelezési_címe_Település_neveComboBox.DataSource = Me.HelyisegBindingSource4
        Me.Levelezési_címe_Település_neveComboBox.DisplayMember = "Helyseg"
        Me.Levelezési_címe_Település_neveComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Levelezési_címe_Település_neveComboBox.Location = New System.Drawing.Point(750, 278)
        Me.Levelezési_címe_Település_neveComboBox.MaxLength = 25
        Me.Levelezési_címe_Település_neveComboBox.Name = "Levelezési_címe_Település_neveComboBox"
        Me.Levelezési_címe_Település_neveComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Levelezési_címe_Település_neveComboBox.TabIndex = 27
        Me.Levelezési_címe_Település_neveComboBox.ValueMember = "Helyseg"
        '
        'HelyisegBindingSource4
        '
        Me.HelyisegBindingSource4.AllowNew = False
        Me.HelyisegBindingSource4.DataMember = "Helyseg"
        Me.HelyisegBindingSource4.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'Állandólakcím_Település_neveComboBox
        '
        Me.Állandólakcím_Település_neveComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Állandólakcím_Település_neveComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Állandólakcím_Település_neveComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Állandó lakcím/Település neve", True))
        Me.Állandólakcím_Település_neveComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Állandó lakcím/Település neve", True))
        Me.Állandólakcím_Település_neveComboBox.DataSource = Me.HelyisegBindingSource3
        Me.Állandólakcím_Település_neveComboBox.DisplayMember = "Helyseg"
        Me.Állandólakcím_Település_neveComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Állandólakcím_Település_neveComboBox.Location = New System.Drawing.Point(750, 53)
        Me.Állandólakcím_Település_neveComboBox.MaxLength = 25
        Me.Állandólakcím_Település_neveComboBox.Name = "Állandólakcím_Település_neveComboBox"
        Me.Állandólakcím_Település_neveComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Állandólakcím_Település_neveComboBox.TabIndex = 18
        Me.Állandólakcím_Település_neveComboBox.ValueMember = "Helyseg"
        '
        'HelyisegBindingSource3
        '
        Me.HelyisegBindingSource3.AllowNew = False
        Me.HelyisegBindingSource3.DataMember = "Helyseg"
        Me.HelyisegBindingSource3.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'Teljes_neveTextBox
        '
        Me.Teljes_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Teljes név", True))
        Me.Teljes_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Teljes_neveTextBox.Location = New System.Drawing.Point(252, 128)
        Me.Teljes_neveTextBox.MaxLength = 100
        Me.Teljes_neveTextBox.Name = "Teljes_neveTextBox"
        Me.Teljes_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Teljes_neveTextBox.TabIndex = 4
        '
        'Levelezési_címe_AjtóTextBox
        '
        Me.Levelezési_címe_AjtóTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Levelezési cím/Ajtó", True))
        Me.Levelezési_címe_AjtóTextBox.Location = New System.Drawing.Point(750, 453)
        Me.Levelezési_címe_AjtóTextBox.MaxLength = 10
        Me.Levelezési_címe_AjtóTextBox.Name = "Levelezési_címe_AjtóTextBox"
        Me.Levelezési_címe_AjtóTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Levelezési_címe_AjtóTextBox.TabIndex = 34
        '
        'Levelezési_címe_EmeletTextBox
        '
        Me.Levelezési_címe_EmeletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Levelezési cím/Emelet", True))
        Me.Levelezési_címe_EmeletTextBox.Location = New System.Drawing.Point(750, 428)
        Me.Levelezési_címe_EmeletTextBox.MaxLength = 10
        Me.Levelezési_címe_EmeletTextBox.Name = "Levelezési_címe_EmeletTextBox"
        Me.Levelezési_címe_EmeletTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Levelezési_címe_EmeletTextBox.TabIndex = 33
        '
        'Levelezési_címe_LépcsőházTextBox
        '
        Me.Levelezési_címe_LépcsőházTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Levelezési cím/Lépcsőház", True))
        Me.Levelezési_címe_LépcsőházTextBox.Location = New System.Drawing.Point(750, 403)
        Me.Levelezési_címe_LépcsőházTextBox.MaxLength = 10
        Me.Levelezési_címe_LépcsőházTextBox.Name = "Levelezési_címe_LépcsőházTextBox"
        Me.Levelezési_címe_LépcsőházTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Levelezési_címe_LépcsőházTextBox.TabIndex = 32
        '
        'Levelezési_címe_ÉpületTextBox
        '
        Me.Levelezési_címe_ÉpületTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Levelezési cím/Épület", True))
        Me.Levelezési_címe_ÉpületTextBox.Location = New System.Drawing.Point(750, 378)
        Me.Levelezési_címe_ÉpületTextBox.MaxLength = 10
        Me.Levelezési_címe_ÉpületTextBox.Name = "Levelezési_címe_ÉpületTextBox"
        Me.Levelezési_címe_ÉpületTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Levelezési_címe_ÉpületTextBox.TabIndex = 31
        '
        'Levelezési_címe_HázszámTextBox
        '
        Me.Levelezési_címe_HázszámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Levelezési cím/Házszám", True))
        Me.Levelezési_címe_HázszámTextBox.Location = New System.Drawing.Point(750, 353)
        Me.Levelezési_címe_HázszámTextBox.MaxLength = 10
        Me.Levelezési_címe_HázszámTextBox.Name = "Levelezési_címe_HázszámTextBox"
        Me.Levelezési_címe_HázszámTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Levelezési_címe_HázszámTextBox.TabIndex = 30
        '
        'Levelezési_címe_Közterület_neveTextBox
        '
        Me.Levelezési_címe_Közterület_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Levelezési cím/Közterület neve", True))
        Me.Levelezési_címe_Közterület_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Levelezési_címe_Közterület_neveTextBox.Location = New System.Drawing.Point(750, 303)
        Me.Levelezési_címe_Közterület_neveTextBox.MaxLength = 25
        Me.Levelezési_címe_Közterület_neveTextBox.Name = "Levelezési_címe_Közterület_neveTextBox"
        Me.Levelezési_címe_Közterület_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Levelezési_címe_Közterület_neveTextBox.TabIndex = 28
        '
        'Viselt_név_További_utónevekTextBox
        '
        Me.Viselt_név_További_utónevekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Viselt név/További utónevek", True))
        Me.Viselt_név_További_utónevekTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viselt_név_További_utónevekTextBox.Location = New System.Drawing.Point(252, 103)
        Me.Viselt_név_További_utónevekTextBox.MaxLength = 40
        Me.Viselt_név_További_utónevekTextBox.Name = "Viselt_név_További_utónevekTextBox"
        Me.Viselt_név_További_utónevekTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Viselt_név_További_utónevekTextBox.TabIndex = 3
        '
        'Viselt_név_Első_utónévTextBox
        '
        Me.Viselt_név_Első_utónévTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Viselt név/Első utónév", True))
        Me.Viselt_név_Első_utónévTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viselt_név_Első_utónévTextBox.Location = New System.Drawing.Point(252, 78)
        Me.Viselt_név_Első_utónévTextBox.MaxLength = 40
        Me.Viselt_név_Első_utónévTextBox.Name = "Viselt_név_Első_utónévTextBox"
        Me.Viselt_név_Első_utónévTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Viselt_név_Első_utónévTextBox.TabIndex = 2
        '
        'Viselt_név_Családi_névTextBox
        '
        Me.Viselt_név_Családi_névTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Viselt név/Családi név", True))
        Me.Viselt_név_Családi_névTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viselt_név_Családi_névTextBox.Location = New System.Drawing.Point(252, 53)
        Me.Viselt_név_Családi_névTextBox.MaxLength = 50
        Me.Viselt_név_Családi_névTextBox.Name = "Viselt_név_Családi_névTextBox"
        Me.Viselt_név_Családi_névTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Viselt_név_Családi_névTextBox.TabIndex = 1
        '
        'Viselt_név_TitulusComboBox
        '
        Me.Viselt_név_TitulusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Titulus", True))
        Me.Viselt_név_TitulusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Titulus", True))
        Me.Viselt_név_TitulusComboBox.DataSource = Me.TitulusBindingSource
        Me.Viselt_név_TitulusComboBox.DisplayMember = "Nev"
        Me.Viselt_név_TitulusComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viselt_név_TitulusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Viselt_név_TitulusComboBox.Location = New System.Drawing.Point(252, 28)
        Me.Viselt_név_TitulusComboBox.MaxLength = 10
        Me.Viselt_név_TitulusComboBox.Name = "Viselt_név_TitulusComboBox"
        Me.Viselt_név_TitulusComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Viselt_név_TitulusComboBox.TabIndex = 0
        Me.Viselt_név_TitulusComboBox.ValueMember = "Nev"
        '
        'Munkahely_neveTextBox
        '
        Me.Munkahely_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Munkahely neve", True))
        Me.Munkahely_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Munkahely_neveTextBox.Location = New System.Drawing.Point(252, 378)
        Me.Munkahely_neveTextBox.MaxLength = 100
        Me.Munkahely_neveTextBox.Name = "Munkahely_neveTextBox"
        Me.Munkahely_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Munkahely_neveTextBox.TabIndex = 14
        '
        'Születési_idejeMaskedBox
        '
        Me.Születési_idejeMaskedBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Születési ideje", True))
        Me.Születési_idejeMaskedBox.Location = New System.Drawing.Point(252, 353)
        Me.Születési_idejeMaskedBox.Mask = "0000.00.00"
        Me.Születési_idejeMaskedBox.Name = "Születési_idejeMaskedBox"
        Me.Születési_idejeMaskedBox.Size = New System.Drawing.Size(86, 20)
        Me.Születési_idejeMaskedBox.TabIndex = 13
        Me.Születési_idejeMaskedBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Születési_település_neveTextBox
        '
        Me.Születési_település_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Születési település neve", True))
        Me.Születési_település_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Születési_település_neveTextBox.Location = New System.Drawing.Point(252, 328)
        Me.Születési_település_neveTextBox.MaxLength = 25
        Me.Születési_település_neveTextBox.Name = "Születési_település_neveTextBox"
        Me.Születési_település_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Születési_település_neveTextBox.TabIndex = 12
        '
        'Születési_ország_neveTextBox
        '
        Me.Születési_ország_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Születési ország neve", True))
        Me.Születési_ország_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Születési_ország_neveTextBox.Location = New System.Drawing.Point(252, 303)
        Me.Születési_ország_neveTextBox.MaxLength = 40
        Me.Születési_ország_neveTextBox.Name = "Születési_ország_neveTextBox"
        Me.Születési_ország_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Születési_ország_neveTextBox.TabIndex = 11
        '
        'Anyja_neve_További_utónevekTextBox
        '
        Me.Anyja_neve_További_utónevekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Anyja neve/További utónevek", True))
        Me.Anyja_neve_További_utónevekTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Anyja_neve_További_utónevekTextBox.Location = New System.Drawing.Point(252, 278)
        Me.Anyja_neve_További_utónevekTextBox.MaxLength = 40
        Me.Anyja_neve_További_utónevekTextBox.Name = "Anyja_neve_További_utónevekTextBox"
        Me.Anyja_neve_További_utónevekTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Anyja_neve_További_utónevekTextBox.TabIndex = 10
        '
        'Anyja_neve_Első_utónévTextBox
        '
        Me.Anyja_neve_Első_utónévTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Anyja neve/Első utónév", True))
        Me.Anyja_neve_Első_utónévTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Anyja_neve_Első_utónévTextBox.Location = New System.Drawing.Point(252, 253)
        Me.Anyja_neve_Első_utónévTextBox.MaxLength = 40
        Me.Anyja_neve_Első_utónévTextBox.Name = "Anyja_neve_Első_utónévTextBox"
        Me.Anyja_neve_Első_utónévTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Anyja_neve_Első_utónévTextBox.TabIndex = 9
        '
        'Anyja_neve_Családi_névTextBox
        '
        Me.Anyja_neve_Családi_névTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Anyja neve/Családi név", True))
        Me.Anyja_neve_Családi_névTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Anyja_neve_Családi_névTextBox.Location = New System.Drawing.Point(252, 228)
        Me.Anyja_neve_Családi_névTextBox.MaxLength = 50
        Me.Anyja_neve_Családi_névTextBox.Name = "Anyja_neve_Családi_névTextBox"
        Me.Anyja_neve_Családi_névTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Anyja_neve_Családi_névTextBox.TabIndex = 8
        '
        'Születési_név_További_utónevekTextBox
        '
        Me.Születési_név_További_utónevekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Születési név/További utónevek", True))
        Me.Születési_név_További_utónevekTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Születési_név_További_utónevekTextBox.Location = New System.Drawing.Point(252, 203)
        Me.Születési_név_További_utónevekTextBox.MaxLength = 40
        Me.Születési_név_További_utónevekTextBox.Name = "Születési_név_További_utónevekTextBox"
        Me.Születési_név_További_utónevekTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Születési_név_További_utónevekTextBox.TabIndex = 7
        '
        'Születési_név_Első_utónévTextBox
        '
        Me.Születési_név_Első_utónévTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Születési név/Első utónév", True))
        Me.Születési_név_Első_utónévTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Születési_név_Első_utónévTextBox.Location = New System.Drawing.Point(252, 178)
        Me.Születési_név_Első_utónévTextBox.MaxLength = 40
        Me.Születési_név_Első_utónévTextBox.Name = "Születési_név_Első_utónévTextBox"
        Me.Születési_név_Első_utónévTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Születési_név_Első_utónévTextBox.TabIndex = 6
        '
        'Születési_név_Családi_névTextBox
        '
        Me.Születési_név_Családi_névTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Születési név/Családi név", True))
        Me.Születési_név_Családi_névTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Születési_név_Családi_névTextBox.Location = New System.Drawing.Point(252, 153)
        Me.Születési_név_Családi_névTextBox.MaxLength = 50
        Me.Születési_név_Családi_névTextBox.Name = "Születési_név_Családi_névTextBox"
        Me.Születési_név_Családi_névTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Születési_név_Családi_névTextBox.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCopyÁllandóLevbe)
        Me.Panel1.Controls.Add(Me.Levelezési_címe_IrányítószámLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(499, 251)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 23)
        Me.Panel1.TabIndex = 85
        '
        'btnCopyÁllandóLevbe
        '
        Me.btnCopyÁllandóLevbe.AutoSize = True
        Me.btnCopyÁllandóLevbe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCopyÁllandóLevbe.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCopyÁllandóLevbe.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnCopyÁllandóLevbe.Location = New System.Drawing.Point(195, 0)
        Me.btnCopyÁllandóLevbe.Name = "btnCopyÁllandóLevbe"
        Me.btnCopyÁllandóLevbe.Size = New System.Drawing.Size(52, 23)
        Me.btnCopyÁllandóLevbe.TabIndex = 0
        Me.btnCopyÁllandóLevbe.Text = "Másold be!"
        Me.btnCopyÁllandóLevbe.UseVisualStyleBackColor = True
        '
        'Levelezési_címe_IrányítószámLabel
        '
        Me.Levelezési_címe_IrányítószámLabel.AutoSize = True
        Me.Levelezési_címe_IrányítószámLabel.Location = New System.Drawing.Point(0, 3)
        Me.Levelezési_címe_IrányítószámLabel.Name = "Levelezési_címe_IrányítószámLabel"
        Me.Levelezési_címe_IrányítószámLabel.Size = New System.Drawing.Size(143, 13)
        Me.Levelezési_címe_IrányítószámLabel.TabIndex = 0
        Me.Levelezési_címe_IrányítószámLabel.Text = "Levelezési cím/Irányítószám"
        '
        'Levelezési_címe_IrányítószámComboBox
        '
        Me.Levelezési_címe_IrányítószámComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Levelezési_címe_IrányítószámComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Levelezési_címe_IrányítószámComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Levelezési cím/Irányítószám", True))
        Me.Levelezési_címe_IrányítószámComboBox.DataSource = Me.HelyisegBindingSource2
        Me.Levelezési_címe_IrányítószámComboBox.DisplayMember = "Irszam"
        Me.Levelezési_címe_IrányítószámComboBox.FormattingEnabled = True
        Me.Levelezési_címe_IrányítószámComboBox.Location = New System.Drawing.Point(750, 253)
        Me.Levelezési_címe_IrányítószámComboBox.Name = "Levelezési_címe_IrányítószámComboBox"
        Me.Levelezési_címe_IrányítószámComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Levelezési_címe_IrányítószámComboBox.TabIndex = 26
        Me.Levelezési_címe_IrányítószámComboBox.ValueMember = "Irszam"
        '
        'HelyisegBindingSource2
        '
        Me.HelyisegBindingSource2.AllowNew = False
        Me.HelyisegBindingSource2.DataMember = "Helyseg"
        Me.HelyisegBindingSource2.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'Állandólakcím_IrányítószámComboBox
        '
        Me.Állandólakcím_IrányítószámComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Állandólakcím_IrányítószámComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Állandólakcím_IrányítószámComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Állandó lakcím/Irányítószám", True))
        Me.Állandólakcím_IrányítószámComboBox.DataSource = Me.HelysegBindingSource
        Me.Állandólakcím_IrányítószámComboBox.DisplayMember = "Irszam"
        Me.Állandólakcím_IrányítószámComboBox.FormattingEnabled = True
        Me.Állandólakcím_IrányítószámComboBox.Location = New System.Drawing.Point(750, 28)
        Me.Állandólakcím_IrányítószámComboBox.Name = "Állandólakcím_IrányítószámComboBox"
        Me.Állandólakcím_IrányítószámComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Állandólakcím_IrányítószámComboBox.TabIndex = 17
        Me.Állandólakcím_IrányítószámComboBox.ValueMember = "Irszam"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(3, 666)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 91
        Me.IDTextBox.Visible = False
        '
        'TDB_TESZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(996, 717)
        Me.Controls.Add(Me.MyBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1012, 756)
        Me.Name = "TDB_TESZ"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Természetes személy - Törzsadatbázis kitöltő"
        CType(Me.MyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KepviselominosegeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NyomtatvanyAdatokDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrszagkoddalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KozteruletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HelysegBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyBindingNavigator.ResumeLayout(False)
        Me.MyBindingNavigator.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.KozteruletBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HelyisegBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HelyisegBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.HelyisegBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TorzsAdatbazisDataSet As TorzsAdatbazisDataSet
    Friend WithEvents MyBindingSource As BindingSource
    Friend WithEvents RogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Term_szemely_rogzitoTableAdapter
    Friend WithEvents TableAdapterManager As TorzsAdatbazisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MyBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents KozteruletBindingSource As BindingSource
    Friend WithEvents NyomtatvanyAdatokDataSet As NyomtatvanyAdatokDataSet
    Friend WithEvents KozteruletTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.KozteruletTableAdapter

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TitulusBindingSource As BindingSource
    Friend WithEvents TitulusTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.TitulusTableAdapter
    Friend WithEvents HelysegBindingSource As BindingSource
    Friend WithEvents HelysegTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.HelysegTableAdapter
    Friend WithEvents ToolStrip_ESZ As ToolStripButton
    Friend WithEvents CegformaBindingSource As BindingSource
    Friend WithEvents CegformaTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.CegformaTableAdapter
    Friend WithEvents KepviselominosegeBindingSource As BindingSource
    Friend WithEvents Kepviselo_minosegeTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.Kepviselo_minosegeTableAdapter
    Friend WithEvents ToolStrip_EV As ToolStripButton
    Friend WithEvents ToolStrip_Termsz As ToolStripButton
    Friend WithEvents ToolStrip_Üi As ToolStripButton
    Friend WithEvents ToolStrip_Cég As ToolStripButton
    Friend WithEvents ToolStrip_Ügyvéd As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStrip_Jogtanácsos As ToolStripButton
    Friend WithEvents ToolStrip_Egyébjogiképviselő As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OrszagkoddalBindingSource As BindingSource
    Friend WithEvents Orszag_koddalTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.Orszag_koddalTableAdapter
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Képviselői_minőségeComboBox As ComboBox
    Friend WithEvents Külföldi_cím_További_cím_adatokTextBox As TextBox
    Friend WithEvents Külföldi_cím_Település_neveTextBox As TextBox
    Friend WithEvents Külföldi_cím_IrányítószámTextBox As TextBox
    Friend WithEvents Külföldi_cím_OrszágComboBox As ComboBox
    Friend WithEvents Állandólakcím_AjtóTextBox As TextBox
    Friend WithEvents Állandólakcím_EmeletTextBox As TextBox
    Friend WithEvents Állandólakcím_LépcsőházTextBox As TextBox
    Friend WithEvents Állandólakcím_ÉpületTextBox As TextBox
    Friend WithEvents Állandólakcím_HázszámTextBox As TextBox
    Friend WithEvents Állandólakcím_Közterület_neveTextBox As TextBox
    Friend WithEvents Elérhetőségek_E_mail_címTextBox As TextBox
    Friend WithEvents Elérhetőségek_FaxszámTextBox As TextBox
    Friend WithEvents Elérhetőségek_TelefonszámTextBox As TextBox
    Friend WithEvents btnBezarNemMent As Button
    Friend WithEvents btnBezaresMent As Button
    Friend WithEvents AdóazonosítóMaskedBox As MaskedTextBox
    Friend WithEvents Teljes_neveTextBox As TextBox

    Friend WithEvents Levelezési_címe_IrányítószámLabel As Label
    Friend WithEvents Levelezési_címe_AjtóTextBox As TextBox
    Friend WithEvents Levelezési_címe_EmeletTextBox As TextBox
    Friend WithEvents Levelezési_címe_LépcsőházTextBox As TextBox
    Friend WithEvents Levelezési_címe_ÉpületTextBox As TextBox
    Friend WithEvents Levelezési_címe_HázszámTextBox As TextBox
    Friend WithEvents Levelezési_címe_Közterület_neveTextBox As TextBox
    Friend WithEvents Viselt_név_További_utónevekTextBox As TextBox
    Friend WithEvents Viselt_név_Első_utónévTextBox As TextBox
    Friend WithEvents Viselt_név_Családi_névTextBox As TextBox
    Friend WithEvents Viselt_név_TitulusComboBox As ComboBox
    Friend WithEvents Munkahely_neveTextBox As TextBox
    Friend WithEvents Születési_idejeMaskedBox As MaskedTextBox
    Friend WithEvents Születési_település_neveTextBox As TextBox
    Friend WithEvents Születési_ország_neveTextBox As TextBox
    Friend WithEvents Anyja_neve_További_utónevekTextBox As TextBox
    Friend WithEvents Anyja_neve_Első_utónévTextBox As TextBox
    Friend WithEvents Anyja_neve_Családi_névTextBox As TextBox
    Friend WithEvents Születési_név_További_utónevekTextBox As TextBox
    Friend WithEvents Születési_név_Első_utónévTextBox As TextBox
    Friend WithEvents Születési_név_Családi_névTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCopyÁllandóLevbe As Button
    Friend WithEvents Levelezési_címe_Közterület_jellegeComboBox As ComboBox
    Friend WithEvents Állandólakcím_Közterület_jellegeComboBox As ComboBox
    Friend WithEvents Levelezési_címe_Település_neveComboBox As ComboBox
    Friend WithEvents Állandólakcím_Település_neveComboBox As ComboBox
    Friend WithEvents KozteruletBindingSource2 As BindingSource
    Friend WithEvents HelyisegBindingSource2 As BindingSource
    Friend WithEvents Levelezési_címe_IrányítószámComboBox As ComboBox
    Friend WithEvents Állandólakcím_IrányítószámComboBox As ComboBox
    Friend WithEvents HelyisegBindingSource4 As BindingSource
    Friend WithEvents HelyisegBindingSource3 As BindingSource
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents btnKeres As ToolStripButton
    Friend WithEvents tbKereso As ToolStripTextBox
End Class
