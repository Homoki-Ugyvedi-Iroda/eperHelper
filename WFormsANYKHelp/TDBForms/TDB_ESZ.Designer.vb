<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TDB_ESZ
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
        Dim Fizetési_számlaszámLabel As System.Windows.Forms.Label
        Dim Elérhetőségek_TelefonszámLabel As System.Windows.Forms.Label
        Dim Elérhetőségek_FaxszámLabel As System.Windows.Forms.Label
        Dim Elérhetőségek_E_mail_címLabel As System.Windows.Forms.Label
        Dim Székhely_IrányítószámLabel As System.Windows.Forms.Label
        Dim Székhely_Település_neveLabel As System.Windows.Forms.Label
        Dim Székhely_Közterület_neveLabel As System.Windows.Forms.Label
        Dim Székhely_Közterület_jellegeLabel As System.Windows.Forms.Label
        Dim Székhely_HázszámLabel As System.Windows.Forms.Label
        Dim Székhely_ÉpületLabel As System.Windows.Forms.Label
        Dim Székhely_LépcsőházLabel As System.Windows.Forms.Label
        Dim Székhely_EmeletLabel As System.Windows.Forms.Label
        Dim Székhely_AjtóLabel As System.Windows.Forms.Label
        Dim Cég_neveLabel As System.Windows.Forms.Label
        Dim CégjegyzékszámLabel As System.Windows.Forms.Label
        Dim Külföldi_cím_OrszágLabel As System.Windows.Forms.Label
        Dim Külföldi_cím_IrányítószámLabel As System.Windows.Forms.Label
        Dim Külföldi_cím_Település_neveLabel As System.Windows.Forms.Label
        Dim Külföldi_cím_További_cím_adatokLabel As System.Windows.Forms.Label
        Dim Képviselői_minőségeLabel As System.Windows.Forms.Label
        Dim AdószámLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TDB_ESZ))
        Me.MyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TorzsAdatbazisDataSet = New homoki.eperhelper.TorzsAdatbazisDataSet()
        Me.KepviselominosegeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NyomtatvanyAdatokDataSet = New homoki.eperhelper.NyomtatvanyAdatokDataSet()
        Me.OrszagkoddalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CegformaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KozteruletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelysegBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Egyeb_szervezet_rogzitoTableAdapter()
        Me.TableAdapterManager = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.TableAdapterManager()
        Me.MyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip_Cég = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_ESZ = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_EV = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip_Termsz = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.btnBezaresMent = New System.Windows.Forms.Button()
        Me.btnBezarNemMent = New System.Windows.Forms.Button()
        Me.Elérhetőségek_TelefonszámTextBox = New System.Windows.Forms.TextBox()
        Me.Elérhetőségek_FaxszámTextBox = New System.Windows.Forms.TextBox()
        Me.Elérhetőségek_E_mail_címTextBox = New System.Windows.Forms.TextBox()
        Me.Székhely_IrányítószámComboBox = New System.Windows.Forms.ComboBox()
        Me.Székhely_Település_neveComboBox = New System.Windows.Forms.ComboBox()
        Me.HelysegBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Székhely_Közterület_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Székhely_Közterület_jellegeComboBox = New System.Windows.Forms.ComboBox()
        Me.Székhely_HázszámTextBox = New System.Windows.Forms.TextBox()
        Me.Székhely_ÉpületTextBox = New System.Windows.Forms.TextBox()
        Me.Székhely_LépcsőházTextBox = New System.Windows.Forms.TextBox()
        Me.Székhely_EmeletTextBox = New System.Windows.Forms.TextBox()
        Me.Székhely_AjtóTextBox = New System.Windows.Forms.TextBox()
        Me.Cég_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Külföldi_cím_OrszágComboBox = New System.Windows.Forms.ComboBox()
        Me.Külföldi_cím_IrányítószámTextBox = New System.Windows.Forms.TextBox()
        Me.Külföldi_cím_Település_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Külföldi_cím_További_cím_adatokTextBox = New System.Windows.Forms.TextBox()
        Me.Képviselői_minőségeComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NyilvántartásiszámTextBox = New System.Windows.Forms.TextBox()
        Me.AdószámMaskedBox = New System.Windows.Forms.MaskedTextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Fizetési_számlaszámLabel = New System.Windows.Forms.Label()
        Elérhetőségek_TelefonszámLabel = New System.Windows.Forms.Label()
        Elérhetőségek_FaxszámLabel = New System.Windows.Forms.Label()
        Elérhetőségek_E_mail_címLabel = New System.Windows.Forms.Label()
        Székhely_IrányítószámLabel = New System.Windows.Forms.Label()
        Székhely_Település_neveLabel = New System.Windows.Forms.Label()
        Székhely_Közterület_neveLabel = New System.Windows.Forms.Label()
        Székhely_Közterület_jellegeLabel = New System.Windows.Forms.Label()
        Székhely_HázszámLabel = New System.Windows.Forms.Label()
        Székhely_ÉpületLabel = New System.Windows.Forms.Label()
        Székhely_LépcsőházLabel = New System.Windows.Forms.Label()
        Székhely_EmeletLabel = New System.Windows.Forms.Label()
        Székhely_AjtóLabel = New System.Windows.Forms.Label()
        Cég_neveLabel = New System.Windows.Forms.Label()
        CégjegyzékszámLabel = New System.Windows.Forms.Label()
        Külföldi_cím_OrszágLabel = New System.Windows.Forms.Label()
        Külföldi_cím_IrányítószámLabel = New System.Windows.Forms.Label()
        Külföldi_cím_Település_neveLabel = New System.Windows.Forms.Label()
        Külföldi_cím_További_cím_adatokLabel = New System.Windows.Forms.Label()
        Képviselői_minőségeLabel = New System.Windows.Forms.Label()
        AdószámLabel = New System.Windows.Forms.Label()
        CType(Me.MyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KepviselominosegeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NyomtatvanyAdatokDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrszagkoddalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CegformaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KozteruletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HelysegBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyBindingNavigator.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HelysegBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fizetési_számlaszámLabel
        '
        Fizetési_számlaszámLabel.AutoSize = True
        Fizetési_számlaszámLabel.Location = New System.Drawing.Point(3, 130)
        Fizetési_számlaszámLabel.Name = "Fizetési_számlaszámLabel"
        Fizetési_számlaszámLabel.Size = New System.Drawing.Size(104, 13)
        Fizetési_számlaszámLabel.TabIndex = 32
        Fizetési_számlaszámLabel.Text = "Fizetési számlaszám:"
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
        'Székhely_IrányítószámLabel
        '
        Székhely_IrányítószámLabel.AutoSize = True
        Székhely_IrányítószámLabel.Location = New System.Drawing.Point(501, 25)
        Székhely_IrányítószámLabel.Name = "Székhely_IrányítószámLabel"
        Székhely_IrányítószámLabel.Size = New System.Drawing.Size(118, 13)
        Székhely_IrányítószámLabel.TabIndex = 9
        Székhely_IrányítószámLabel.Text = "Székhely/Irányítószám:"
        '
        'Székhely_Település_neveLabel
        '
        Székhely_Település_neveLabel.AutoSize = True
        Székhely_Település_neveLabel.Location = New System.Drawing.Point(501, 50)
        Székhely_Település_neveLabel.Name = "Székhely_Település_neveLabel"
        Székhely_Település_neveLabel.Size = New System.Drawing.Size(131, 13)
        Székhely_Település_neveLabel.TabIndex = 11
        Székhely_Település_neveLabel.Text = "Székhely/Település neve:"
        '
        'Székhely_Közterület_neveLabel
        '
        Székhely_Közterület_neveLabel.AutoSize = True
        Székhely_Közterület_neveLabel.Location = New System.Drawing.Point(501, 75)
        Székhely_Közterület_neveLabel.Name = "Székhely_Közterület_neveLabel"
        Székhely_Közterület_neveLabel.Size = New System.Drawing.Size(132, 13)
        Székhely_Közterület_neveLabel.TabIndex = 13
        Székhely_Közterület_neveLabel.Text = "Székhely/Közterület neve:"
        '
        'Székhely_Közterület_jellegeLabel
        '
        Székhely_Közterület_jellegeLabel.AutoSize = True
        Székhely_Közterület_jellegeLabel.Location = New System.Drawing.Point(501, 100)
        Székhely_Közterület_jellegeLabel.Name = "Székhely_Közterület_jellegeLabel"
        Székhely_Közterület_jellegeLabel.Size = New System.Drawing.Size(138, 13)
        Székhely_Közterület_jellegeLabel.TabIndex = 15
        Székhely_Közterület_jellegeLabel.Text = "Székhely/Közterület jellege:"
        '
        'Székhely_HázszámLabel
        '
        Székhely_HázszámLabel.AutoSize = True
        Székhely_HázszámLabel.Location = New System.Drawing.Point(501, 125)
        Székhely_HázszámLabel.Name = "Székhely_HázszámLabel"
        Székhely_HázszámLabel.Size = New System.Drawing.Size(101, 13)
        Székhely_HázszámLabel.TabIndex = 17
        Székhely_HázszámLabel.Text = "Székhely/Házszám:"
        '
        'Székhely_ÉpületLabel
        '
        Székhely_ÉpületLabel.AutoSize = True
        Székhely_ÉpületLabel.Location = New System.Drawing.Point(501, 150)
        Székhely_ÉpületLabel.Name = "Székhely_ÉpületLabel"
        Székhely_ÉpületLabel.Size = New System.Drawing.Size(88, 13)
        Székhely_ÉpületLabel.TabIndex = 19
        Székhely_ÉpületLabel.Text = "Székhely/Épület:"
        '
        'Székhely_LépcsőházLabel
        '
        Székhely_LépcsőházLabel.AutoSize = True
        Székhely_LépcsőházLabel.Location = New System.Drawing.Point(501, 175)
        Székhely_LépcsőházLabel.Name = "Székhely_LépcsőházLabel"
        Székhely_LépcsőházLabel.Size = New System.Drawing.Size(110, 13)
        Székhely_LépcsőházLabel.TabIndex = 21
        Székhely_LépcsőházLabel.Text = "Székhely/Lépcsőház:"
        '
        'Székhely_EmeletLabel
        '
        Székhely_EmeletLabel.AutoSize = True
        Székhely_EmeletLabel.Location = New System.Drawing.Point(501, 200)
        Székhely_EmeletLabel.Name = "Székhely_EmeletLabel"
        Székhely_EmeletLabel.Size = New System.Drawing.Size(90, 13)
        Székhely_EmeletLabel.TabIndex = 23
        Székhely_EmeletLabel.Text = "Székhely/Emelet:"
        '
        'Székhely_AjtóLabel
        '
        Székhely_AjtóLabel.AutoSize = True
        Székhely_AjtóLabel.Location = New System.Drawing.Point(501, 225)
        Székhely_AjtóLabel.Name = "Székhely_AjtóLabel"
        Székhely_AjtóLabel.Size = New System.Drawing.Size(76, 13)
        Székhely_AjtóLabel.TabIndex = 25
        Székhely_AjtóLabel.Text = "Székhely/Ajtó:"
        '
        'Cég_neveLabel
        '
        Cég_neveLabel.AutoSize = True
        Cég_neveLabel.Location = New System.Drawing.Point(3, 25)
        Cég_neveLabel.Name = "Cég_neveLabel"
        Cég_neveLabel.Size = New System.Drawing.Size(126, 13)
        Cég_neveLabel.TabIndex = 26
        Cég_neveLabel.Text = "Szervezet megnevezése:"
        '
        'CégjegyzékszámLabel
        '
        CégjegyzékszámLabel.AutoSize = True
        CégjegyzékszámLabel.Location = New System.Drawing.Point(3, 50)
        CégjegyzékszámLabel.Name = "CégjegyzékszámLabel"
        CégjegyzékszámLabel.Size = New System.Drawing.Size(100, 13)
        CégjegyzékszámLabel.TabIndex = 30
        CégjegyzékszámLabel.Text = "Nyilvántartási szám:"
        '
        'Külföldi_cím_OrszágLabel
        '
        Külföldi_cím_OrszágLabel.AutoSize = True
        Külföldi_cím_OrszágLabel.Location = New System.Drawing.Point(501, 250)
        Külföldi_cím_OrszágLabel.Name = "Külföldi_cím_OrszágLabel"
        Külföldi_cím_OrszágLabel.Size = New System.Drawing.Size(103, 13)
        Külföldi_cím_OrszágLabel.TabIndex = 38
        Külföldi_cím_OrszágLabel.Text = "Külföldi cím/Ország:"
        '
        'Külföldi_cím_IrányítószámLabel
        '
        Külföldi_cím_IrányítószámLabel.AutoSize = True
        Külföldi_cím_IrányítószámLabel.Location = New System.Drawing.Point(501, 275)
        Külföldi_cím_IrányítószámLabel.Name = "Külföldi_cím_IrányítószámLabel"
        Külföldi_cím_IrányítószámLabel.Size = New System.Drawing.Size(130, 13)
        Külföldi_cím_IrányítószámLabel.TabIndex = 40
        Külföldi_cím_IrányítószámLabel.Text = "Külföldi cím/Irányítószám:"
        '
        'Külföldi_cím_Település_neveLabel
        '
        Külföldi_cím_Település_neveLabel.AutoSize = True
        Külföldi_cím_Település_neveLabel.Location = New System.Drawing.Point(501, 300)
        Külföldi_cím_Település_neveLabel.Name = "Külföldi_cím_Település_neveLabel"
        Külföldi_cím_Település_neveLabel.Size = New System.Drawing.Size(143, 13)
        Külföldi_cím_Település_neveLabel.TabIndex = 42
        Külföldi_cím_Település_neveLabel.Text = "Külföldi cím/Település neve:"
        '
        'Külföldi_cím_További_cím_adatokLabel
        '
        Külföldi_cím_További_cím_adatokLabel.AutoSize = True
        Külföldi_cím_További_cím_adatokLabel.Location = New System.Drawing.Point(501, 325)
        Külföldi_cím_További_cím_adatokLabel.Name = "Külföldi_cím_További_cím_adatokLabel"
        Külföldi_cím_További_cím_adatokLabel.Size = New System.Drawing.Size(166, 13)
        Külföldi_cím_További_cím_adatokLabel.TabIndex = 44
        Külföldi_cím_További_cím_adatokLabel.Text = "Külföldi cím/További cím adatok:"
        '
        'Képviselői_minőségeLabel
        '
        Képviselői_minőségeLabel.AutoSize = True
        Képviselői_minőségeLabel.Location = New System.Drawing.Point(3, 225)
        Képviselői_minőségeLabel.Name = "Képviselői_minőségeLabel"
        Képviselői_minőségeLabel.Size = New System.Drawing.Size(106, 13)
        Képviselői_minőségeLabel.TabIndex = 46
        Képviselői_minőségeLabel.Text = "Képviselői minősége:"
        '
        'AdószámLabel
        '
        AdószámLabel.AutoSize = True
        AdószámLabel.Location = New System.Drawing.Point(3, 75)
        AdószámLabel.Name = "AdószámLabel"
        AdószámLabel.Size = New System.Drawing.Size(53, 13)
        AdószámLabel.TabIndex = 46
        AdószámLabel.Text = "Adószám:"
        '
        'MyBindingSource
        '
        Me.MyBindingSource.DataMember = "Egyeb_szervezet_rogzito"
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
        'CegformaBindingSource
        '
        Me.CegformaBindingSource.DataMember = "Cegforma"
        Me.CegformaBindingSource.DataSource = Me.NyomtatvanyAdatokDataSet
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
        Me.TableAdapterManager.Egyeb_szervezet_rogzitoTableAdapter = Me.RogzitoTableAdapter
        Me.TableAdapterManager.Egyeni_ugyvedi_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.EV_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Jogtanacsos_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Term_szemely_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Ugytorzs_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Ugyvedi_iroda_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MyBindingNavigator
        '
        Me.MyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MyBindingNavigator.BindingSource = Me.MyBindingSource
        Me.MyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MyBindingNavigator.CountItemFormat = "/{0}"
        Me.MyBindingNavigator.DeleteItem = Nothing
        Me.MyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem, Me.ToolStripSeparator4, Me.ToolStrip_Cég, Me.ToolStrip_ESZ, Me.ToolStrip_EV, Me.ToolStripSeparator3, Me.ToolStrip_Termsz, Me.ToolStripSeparator2, Me.ToolStrip_Üi, Me.ToolStrip_Ügyvéd, Me.ToolStrip_Jogtanácsos, Me.ToolStrip_Egyébjogiképviselő, Me.ToolStripSeparator1, Me.tbKereso, Me.btnKeres})
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Új hozzáadása"
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.btnKeres.BackColor = System.Drawing.SystemColors.Control
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
        'btnBezaresMent
        '
        Me.btnBezaresMent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBezaresMent.AutoSize = True
        Me.btnBezaresMent.Location = New System.Drawing.Point(331, 678)
        Me.btnBezaresMent.Name = "btnBezaresMent"
        Me.btnBezaresMent.Size = New System.Drawing.Size(84, 23)
        Me.btnBezaresMent.TabIndex = 19
        Me.btnBezaresMent.Text = "Bezár és ment"
        Me.btnBezaresMent.UseVisualStyleBackColor = True
        '
        'btnBezarNemMent
        '
        Me.btnBezarNemMent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBezarNemMent.Location = New System.Drawing.Point(585, 678)
        Me.btnBezarNemMent.Name = "btnBezarNemMent"
        Me.btnBezarNemMent.Size = New System.Drawing.Size(75, 23)
        Me.btnBezarNemMent.TabIndex = 20
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
        Me.Elérhetőségek_TelefonszámTextBox.TabIndex = 16
        '
        'Elérhetőségek_FaxszámTextBox
        '
        Me.Elérhetőségek_FaxszámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Elérhetőségek/Faxszám", True))
        Me.Elérhetőségek_FaxszámTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Elérhetőségek_FaxszámTextBox.Location = New System.Drawing.Point(750, 603)
        Me.Elérhetőségek_FaxszámTextBox.MaxLength = 25
        Me.Elérhetőségek_FaxszámTextBox.Name = "Elérhetőségek_FaxszámTextBox"
        Me.Elérhetőségek_FaxszámTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Elérhetőségek_FaxszámTextBox.TabIndex = 17
        '
        'Elérhetőségek_E_mail_címTextBox
        '
        Me.Elérhetőségek_E_mail_címTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Elérhetőségek/E-mail cím", True))
        Me.Elérhetőségek_E_mail_címTextBox.Location = New System.Drawing.Point(750, 628)
        Me.Elérhetőségek_E_mail_címTextBox.MaxLength = 50
        Me.Elérhetőségek_E_mail_címTextBox.Name = "Elérhetőségek_E_mail_címTextBox"
        Me.Elérhetőségek_E_mail_címTextBox.Size = New System.Drawing.Size(216, 20)
        Me.Elérhetőségek_E_mail_címTextBox.TabIndex = 18
        '
        'Székhely_IrányítószámComboBox
        '
        Me.Székhely_IrányítószámComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Székhely_IrányítószámComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Székhely_IrányítószámComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Székhely/Irányítószám", True))
        Me.Székhely_IrányítószámComboBox.DataSource = Me.HelysegBindingSource
        Me.Székhely_IrányítószámComboBox.DisplayMember = "Irszam"
        Me.Székhely_IrányítószámComboBox.Location = New System.Drawing.Point(750, 28)
        Me.Székhely_IrányítószámComboBox.MaxLength = 100
        Me.Székhely_IrányítószámComboBox.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Székhely_IrányítószámComboBox.Name = "Székhely_IrányítószámComboBox"
        Me.Székhely_IrányítószámComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Székhely_IrányítószámComboBox.TabIndex = 3
        Me.Székhely_IrányítószámComboBox.ValueMember = "Irszam"
        '
        'Székhely_Település_neveComboBox
        '
        Me.Székhely_Település_neveComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Székhely_Település_neveComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Székhely_Település_neveComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Székhely/Település neve", True))
        Me.Székhely_Település_neveComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Székhely/Település neve", True))
        Me.Székhely_Település_neveComboBox.DataSource = Me.HelysegBindingSource2
        Me.Székhely_Település_neveComboBox.DisplayMember = "Helyseg"
        Me.Székhely_Település_neveComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Székhely_Település_neveComboBox.Location = New System.Drawing.Point(750, 53)
        Me.Székhely_Település_neveComboBox.MaxLength = 25
        Me.Székhely_Település_neveComboBox.Name = "Székhely_Település_neveComboBox"
        Me.Székhely_Település_neveComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Székhely_Település_neveComboBox.TabIndex = 4
        Me.Székhely_Település_neveComboBox.ValueMember = "Helyseg"
        '
        'HelysegBindingSource2
        '
        Me.HelysegBindingSource2.AllowNew = False
        Me.HelysegBindingSource2.DataMember = "Helyseg"
        Me.HelysegBindingSource2.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'Székhely_Közterület_neveTextBox
        '
        Me.Székhely_Közterület_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Székhely/Közterület neve", True))
        Me.Székhely_Közterület_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Székhely_Közterület_neveTextBox.Location = New System.Drawing.Point(750, 78)
        Me.Székhely_Közterület_neveTextBox.MaxLength = 25
        Me.Székhely_Közterület_neveTextBox.Name = "Székhely_Közterület_neveTextBox"
        Me.Székhely_Közterület_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Székhely_Közterület_neveTextBox.TabIndex = 5
        '
        'Székhely_Közterület_jellegeComboBox
        '
        Me.Székhely_Közterület_jellegeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Székhely_Közterület_jellegeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Székhely_Közterület_jellegeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Székhely/Közterület jellege", True))
        Me.Székhely_Közterület_jellegeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Székhely/Közterület jellege", True))
        Me.Székhely_Közterület_jellegeComboBox.DataSource = Me.KozteruletBindingSource
        Me.Székhely_Közterület_jellegeComboBox.DisplayMember = "Nev"
        Me.Székhely_Közterület_jellegeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Székhely_Közterület_jellegeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Székhely_Közterület_jellegeComboBox.DropDownWidth = 250
        Me.Székhely_Közterület_jellegeComboBox.Location = New System.Drawing.Point(750, 103)
        Me.Székhely_Közterület_jellegeComboBox.MaxLength = 40
        Me.Székhely_Közterület_jellegeComboBox.Name = "Székhely_Közterület_jellegeComboBox"
        Me.Székhely_Közterület_jellegeComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Székhely_Közterület_jellegeComboBox.TabIndex = 6
        Me.Székhely_Közterület_jellegeComboBox.ValueMember = "Nev"
        '
        'Székhely_HázszámTextBox
        '
        Me.Székhely_HázszámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Székhely/Házszám", True))
        Me.Székhely_HázszámTextBox.Location = New System.Drawing.Point(750, 128)
        Me.Székhely_HázszámTextBox.MaxLength = 10
        Me.Székhely_HázszámTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Székhely_HázszámTextBox.Name = "Székhely_HázszámTextBox"
        Me.Székhely_HázszámTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Székhely_HázszámTextBox.TabIndex = 7
        '
        'Székhely_ÉpületTextBox
        '
        Me.Székhely_ÉpületTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Székhely/Épület", True))
        Me.Székhely_ÉpületTextBox.Location = New System.Drawing.Point(750, 153)
        Me.Székhely_ÉpületTextBox.MaxLength = 10
        Me.Székhely_ÉpületTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Székhely_ÉpületTextBox.Name = "Székhely_ÉpületTextBox"
        Me.Székhely_ÉpületTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Székhely_ÉpületTextBox.TabIndex = 8
        '
        'Székhely_LépcsőházTextBox
        '
        Me.Székhely_LépcsőházTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Székhely/Lépcsőház", True))
        Me.Székhely_LépcsőházTextBox.Location = New System.Drawing.Point(750, 178)
        Me.Székhely_LépcsőházTextBox.MaxLength = 10
        Me.Székhely_LépcsőházTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Székhely_LépcsőházTextBox.Name = "Székhely_LépcsőházTextBox"
        Me.Székhely_LépcsőházTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Székhely_LépcsőházTextBox.TabIndex = 9
        '
        'Székhely_EmeletTextBox
        '
        Me.Székhely_EmeletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Székhely/Emelet", True))
        Me.Székhely_EmeletTextBox.Location = New System.Drawing.Point(750, 203)
        Me.Székhely_EmeletTextBox.MaxLength = 10
        Me.Székhely_EmeletTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Székhely_EmeletTextBox.Name = "Székhely_EmeletTextBox"
        Me.Székhely_EmeletTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Székhely_EmeletTextBox.TabIndex = 10
        '
        'Székhely_AjtóTextBox
        '
        Me.Székhely_AjtóTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Székhely/Ajtó", True))
        Me.Székhely_AjtóTextBox.Location = New System.Drawing.Point(750, 228)
        Me.Székhely_AjtóTextBox.MaxLength = 10
        Me.Székhely_AjtóTextBox.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Székhely_AjtóTextBox.Name = "Székhely_AjtóTextBox"
        Me.Székhely_AjtóTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Székhely_AjtóTextBox.TabIndex = 11
        '
        'Cég_neveTextBox
        '
        Me.Cég_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Szervezet megnevezése", True))
        Me.Cég_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cég_neveTextBox.Location = New System.Drawing.Point(252, 28)
        Me.Cég_neveTextBox.MaxLength = 100
        Me.Cég_neveTextBox.Name = "Cég_neveTextBox"
        Me.Cég_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Cég_neveTextBox.TabIndex = 0
        '
        'Külföldi_cím_OrszágComboBox
        '
        Me.Külföldi_cím_OrszágComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Külföldi_cím_OrszágComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Külföldi_cím_OrszágComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Külföldi cím/Ország", True))
        Me.Külföldi_cím_OrszágComboBox.DataSource = Me.OrszagkoddalBindingSource
        Me.Külföldi_cím_OrszágComboBox.DisplayMember = "OrszágkódNévvel"
        Me.Külföldi_cím_OrszágComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Külföldi_cím_OrszágComboBox.Location = New System.Drawing.Point(750, 253)
        Me.Külföldi_cím_OrszágComboBox.MaxLength = 10
        Me.Külföldi_cím_OrszágComboBox.Name = "Külföldi_cím_OrszágComboBox"
        Me.Külföldi_cím_OrszágComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Külföldi_cím_OrszágComboBox.TabIndex = 12
        Me.Külföldi_cím_OrszágComboBox.ValueMember = "Országkód"
        '
        'Külföldi_cím_IrányítószámTextBox
        '
        Me.Külföldi_cím_IrányítószámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Külföldi cím/Irányítószám", True))
        Me.Külföldi_cím_IrányítószámTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Külföldi_cím_IrányítószámTextBox.Location = New System.Drawing.Point(750, 278)
        Me.Külföldi_cím_IrányítószámTextBox.MaxLength = 15
        Me.Külföldi_cím_IrányítószámTextBox.Name = "Külföldi_cím_IrányítószámTextBox"
        Me.Külföldi_cím_IrányítószámTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Külföldi_cím_IrányítószámTextBox.TabIndex = 13
        '
        'Külföldi_cím_Település_neveTextBox
        '
        Me.Külföldi_cím_Település_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Külföldi cím/Település neve", True))
        Me.Külföldi_cím_Település_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Külföldi_cím_Település_neveTextBox.Location = New System.Drawing.Point(750, 303)
        Me.Külföldi_cím_Település_neveTextBox.MaxLength = 25
        Me.Külföldi_cím_Település_neveTextBox.Name = "Külföldi_cím_Település_neveTextBox"
        Me.Külföldi_cím_Település_neveTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Külföldi_cím_Település_neveTextBox.TabIndex = 14
        '
        'Külföldi_cím_További_cím_adatokTextBox
        '
        Me.Külföldi_cím_További_cím_adatokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Külföldi cím/További cím adatok", True))
        Me.Külföldi_cím_További_cím_adatokTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Külföldi_cím_További_cím_adatokTextBox.Location = New System.Drawing.Point(750, 328)
        Me.Külföldi_cím_További_cím_adatokTextBox.MaxLength = 100
        Me.Külföldi_cím_További_cím_adatokTextBox.Name = "Külföldi_cím_További_cím_adatokTextBox"
        Me.Külföldi_cím_További_cím_adatokTextBox.Size = New System.Drawing.Size(243, 20)
        Me.Külföldi_cím_További_cím_adatokTextBox.TabIndex = 15
        '
        'Képviselői_minőségeComboBox
        '
        Me.Képviselői_minőségeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Képviselői_minőségeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Képviselői_minőségeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MyBindingSource, "Képviselői minősége", True))
        Me.Képviselői_minőségeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Képviselői minősége", True))
        Me.Képviselői_minőségeComboBox.DataSource = Me.KepviselominosegeBindingSource
        Me.Képviselői_minőségeComboBox.DisplayMember = "Neve"
        Me.Képviselői_minőségeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Képviselői_minőségeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Képviselői_minőségeComboBox.Location = New System.Drawing.Point(252, 228)
        Me.Képviselői_minőségeComboBox.Name = "Képviselői_minőségeComboBox"
        Me.Képviselői_minőségeComboBox.Size = New System.Drawing.Size(243, 21)
        Me.Képviselői_minőségeComboBox.TabIndex = 2
        Me.Képviselői_minőségeComboBox.ValueMember = "Neve"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(AdószámLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Képviselői_minőségeLabel, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Képviselői_minőségeComboBox, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Külföldi_cím_További_cím_adatokLabel, 2, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Külföldi_cím_További_cím_adatokTextBox, 3, 13)
        Me.TableLayoutPanel1.Controls.Add(Külföldi_cím_Település_neveLabel, 2, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Külföldi_cím_Település_neveTextBox, 3, 12)
        Me.TableLayoutPanel1.Controls.Add(Külföldi_cím_IrányítószámLabel, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Külföldi_cím_IrányítószámTextBox, 3, 11)
        Me.TableLayoutPanel1.Controls.Add(Külföldi_cím_OrszágLabel, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Külföldi_cím_OrszágComboBox, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.NyilvántartásiszámTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Cég_neveLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Cég_neveTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Székhely_AjtóLabel, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_AjtóTextBox, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Székhely_EmeletLabel, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_EmeletTextBox, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Székhely_LépcsőházLabel, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_LépcsőházTextBox, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Székhely_ÉpületLabel, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_ÉpületTextBox, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Székhely_HázszámLabel, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_HázszámTextBox, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Székhely_Közterület_jellegeLabel, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_Közterület_jellegeComboBox, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Székhely_Közterület_neveLabel, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_Közterület_neveTextBox, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Székhely_Település_neveLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_Település_neveComboBox, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Székhely_IrányítószámLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Székhely_IrányítószámComboBox, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Elérhetőségek_E_mail_címTextBox, 3, 25)
        Me.TableLayoutPanel1.Controls.Add(Me.Elérhetőségek_FaxszámTextBox, 3, 24)
        Me.TableLayoutPanel1.Controls.Add(Me.Elérhetőségek_TelefonszámTextBox, 3, 23)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBezarNemMent, 2, 26)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBezaresMent, 1, 26)
        Me.TableLayoutPanel1.Controls.Add(Elérhetőségek_E_mail_címLabel, 2, 25)
        Me.TableLayoutPanel1.Controls.Add(Elérhetőségek_FaxszámLabel, 2, 24)
        Me.TableLayoutPanel1.Controls.Add(Elérhetőségek_TelefonszámLabel, 2, 23)
        Me.TableLayoutPanel1.Controls.Add(CégjegyzékszámLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AdószámMaskedBox, 1, 3)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(996, 717)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NyilvántartásiszámTextBox
        '
        Me.NyilvántartásiszámTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Nyilvántartási száma", True))
        Me.NyilvántartásiszámTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NyilvántartásiszámTextBox.Location = New System.Drawing.Point(252, 53)
        Me.NyilvántartásiszámTextBox.MaxLength = 20
        Me.NyilvántartásiszámTextBox.Name = "NyilvántartásiszámTextBox"
        Me.NyilvántartásiszámTextBox.Size = New System.Drawing.Size(243, 20)
        Me.NyilvántartásiszámTextBox.TabIndex = 1
        '
        'AdószámMaskedBox
        '
        Me.AdószámMaskedBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.AdószámMaskedBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "Adószám", True))
        Me.AdószámMaskedBox.Location = New System.Drawing.Point(252, 78)
        Me.AdószámMaskedBox.Mask = "00000000-0-00"
        Me.AdószámMaskedBox.Name = "AdószámMaskedBox"
        Me.AdószámMaskedBox.Size = New System.Drawing.Size(86, 20)
        Me.AdószámMaskedBox.TabIndex = 47
        Me.AdószámMaskedBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(3, 666)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 48
        Me.IDTextBox.Visible = False
        '
        'TDB_ESZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(996, 717)
        Me.Controls.Add(Me.MyBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1012, 756)
        Me.Name = "TDB_ESZ"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Egyéb szervezet - Törzsadatbázis kitöltő"
        CType(Me.MyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KepviselominosegeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NyomtatvanyAdatokDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrszagkoddalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CegformaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KozteruletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HelysegBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyBindingNavigator.ResumeLayout(False)
        Me.MyBindingNavigator.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HelysegBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TorzsAdatbazisDataSet As TorzsAdatbazisDataSet
    Friend WithEvents MyBindingSource As BindingSource
    Friend WithEvents RogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Egyeb_szervezet_rogzitoTableAdapter
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
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
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
    Friend WithEvents Cég_neveTextBox As TextBox
    Friend WithEvents Székhely_AjtóTextBox As TextBox
    Friend WithEvents Székhely_EmeletTextBox As TextBox
    Friend WithEvents Székhely_LépcsőházTextBox As TextBox
    Friend WithEvents Székhely_ÉpületTextBox As TextBox
    Friend WithEvents Székhely_HázszámTextBox As TextBox
    Friend WithEvents Székhely_Közterület_jellegeComboBox As ComboBox
    Friend WithEvents Székhely_Közterület_neveTextBox As TextBox
    Friend WithEvents Székhely_Település_neveComboBox As ComboBox
    Friend WithEvents Székhely_IrányítószámComboBox As ComboBox
    Friend WithEvents Elérhetőségek_E_mail_címTextBox As TextBox
    Friend WithEvents Elérhetőségek_FaxszámTextBox As TextBox
    Friend WithEvents Elérhetőségek_TelefonszámTextBox As TextBox
    Friend WithEvents btnBezarNemMent As Button
    Friend WithEvents btnBezaresMent As Button
    Friend WithEvents NyilvántartásiszámTextBox As TextBox
    Friend WithEvents HelysegBindingSource2 As BindingSource
    Friend WithEvents AdószámMaskedBox As MaskedTextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents btnKeres As ToolStripButton
    Friend WithEvents tbKereso As ToolStripTextBox
End Class
