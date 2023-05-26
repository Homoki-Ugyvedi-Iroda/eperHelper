<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kitolt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kitolt))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblValasszakisablontipust = New System.Windows.Forms.Label()
        Me.dgFRMENYKValaszto = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgTorzsValaszto = New System.Windows.Forms.DataGridView()
        Me.dgTorzs_Lap = New DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn()
        Me.dgSzemelytipusNeve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KitKatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NyomtatvanyAdatokDataSet = New homoki.eperhelper.NyomtatvanyAdatokDataSet()
        Me.dgSzemelyValaszto = New System.Windows.Forms.DataGridView()
        Me.TorzsAdatbazisDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TorzsAdatbazisDataSet = New homoki.eperhelper.TorzsAdatbazisDataSet()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTorol = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnAddSzemelytoList = New System.Windows.Forms.Button()
        Me.btnAddSzemelytoTDB = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNyomKivalasztott = New System.Windows.Forms.Label()
        Me.tbNyomKivalasztott = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbBekuldo = New System.Windows.Forms.ComboBox()
        Me.tbSzures = New System.Windows.Forms.TextBox()
        Me.btnImportraMent = New System.Windows.Forms.Button()
        Me.btnBezarImportNelkul = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFajlnev = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddBekuldotoTDB = New System.Windows.Forms.Button()
        Me.btnKivalaszt = New System.Windows.Forms.Button()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgUgyvalaszto = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ugyszám_ugycsoport_resze = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElsorendufelperesNeveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElsorendualperesNeveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UgytargyaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UgytorzsrogzitoBindingSourceX = New System.Windows.Forms.BindingSource(Me.components)
        Me.lvKivalasztottak = New System.Windows.Forms.ListView()
        Me.lvR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvNeve = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvTorzsTabla = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddUgy = New System.Windows.Forms.Button()
        Me.TermszemelyrogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Term_szemely_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Term_szemely_rogzitoTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TorzstablatipusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FrissKitKatTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.OsszesitettMDFbolTableAdapter()
        Me.EgyebjogikvorogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Egyeb_jogi_kvo_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Egyeb_jogi_kvo_rogzitoTableAdapter()
        Me.EgyebszervezetrogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Egyeb_szervezet_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Egyeb_szervezet_rogzitoTableAdapter()
        Me.EgyeniugyvedirogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Egyeni_ugyvedi_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Egyeni_ugyvedi_rogzitoTableAdapter()
        Me.EVrogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EV_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.EV_rogzitoTableAdapter()
        Me.JogtanacsosrogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jogtanacsos_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Jogtanacsos_rogzitoTableAdapter()
        Me.UgyvediirodarogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ugyvedi_iroda_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Ugyvedi_iroda_rogzitoTableAdapter()
        Me.CegrogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ceg_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Ceg_rogzitoTableAdapter()
        Me.Ugytorzs_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Ugytorzs_rogzitoTableAdapter()
        Me.NyomiListaTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.NyomiListaTableAdapter()
        Me.NyomiListaFeldolgTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.NyomiListaFeldolgTableAdapter()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UgyszámugycsoportreszeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgFRMENYKValaszto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgTorzsValaszto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KitKatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NyomtatvanyAdatokDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSzemelyValaszto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorzsAdatbazisDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.dgUgyvalaszto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UgytorzsrogzitoBindingSourceX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermszemelyrogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EgyebjogikvorogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EgyebszervezetrogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EgyeniugyvedirogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVrogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JogtanacsosrogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UgyvediirodarogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CegrogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblValasszakisablontipust, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgFRMENYKValaszto, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnImportraMent, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBezarImportNelkul, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.25771!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.93266!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.79461!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.48822!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.416656!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1007, 717)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblValasszakisablontipust
        '
        Me.lblValasszakisablontipust.AutoSize = True
        Me.lblValasszakisablontipust.Location = New System.Drawing.Point(3, 3)
        Me.lblValasszakisablontipust.Margin = New System.Windows.Forms.Padding(3)
        Me.lblValasszakisablontipust.Name = "lblValasszakisablontipust"
        Me.lblValasszakisablontipust.Size = New System.Drawing.Size(215, 13)
        Me.lblValasszakisablontipust.TabIndex = 3
        Me.lblValasszakisablontipust.Text = "Válassza ki a kitölteni kívánt sablon típusát!"
        '
        'dgFRMENYKValaszto
        '
        Me.dgFRMENYKValaszto.AllowUserToAddRows = False
        Me.dgFRMENYKValaszto.AllowUserToDeleteRows = False
        Me.dgFRMENYKValaszto.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgFRMENYKValaszto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgFRMENYKValaszto, 3)
        Me.dgFRMENYKValaszto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFRMENYKValaszto.Location = New System.Drawing.Point(6, 30)
        Me.dgFRMENYKValaszto.Margin = New System.Windows.Forms.Padding(6)
        Me.dgFRMENYKValaszto.MultiSelect = False
        Me.dgFRMENYKValaszto.Name = "dgFRMENYKValaszto"
        Me.dgFRMENYKValaszto.ReadOnly = True
        Me.dgFRMENYKValaszto.Size = New System.Drawing.Size(999, 123)
        Me.dgFRMENYKValaszto.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgTorzsValaszto, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgSzemelyValaszto, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 219)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(441, 359)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'dgTorzsValaszto
        '
        Me.dgTorzsValaszto.AllowUserToAddRows = False
        Me.dgTorzsValaszto.AllowUserToDeleteRows = False
        Me.dgTorzsValaszto.AutoGenerateColumns = False
        Me.dgTorzsValaszto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgTorzs_Lap, Me.dgSzemelytipusNeve})
        Me.dgTorzsValaszto.DataSource = Me.KitKatBindingSource
        Me.dgTorzsValaszto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTorzsValaszto.Location = New System.Drawing.Point(3, 3)
        Me.dgTorzsValaszto.MultiSelect = False
        Me.dgTorzsValaszto.Name = "dgTorzsValaszto"
        Me.dgTorzsValaszto.ReadOnly = True
        Me.dgTorzsValaszto.RowHeadersWidth = 5
        Me.dgTorzsValaszto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTorzsValaszto.Size = New System.Drawing.Size(435, 209)
        Me.dgTorzsValaszto.TabIndex = 0
        '
        'dgTorzs_Lap
        '
        Me.dgTorzs_Lap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgTorzs_Lap.DataPropertyName = "Lap"
        Me.dgTorzs_Lap.FillWeight = 39.0863!
        Me.dgTorzs_Lap.HeaderText = "Lap"
        Me.dgTorzs_Lap.Name = "dgTorzs_Lap"
        Me.dgTorzs_Lap.ReadOnly = True
        Me.dgTorzs_Lap.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dgSzemelytipusNeve
        '
        Me.dgSzemelytipusNeve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgSzemelytipusNeve.DataPropertyName = "Neve"
        Me.dgSzemelytipusNeve.FillWeight = 60.9137!
        Me.dgSzemelytipusNeve.HeaderText = "Személy típusa"
        Me.dgSzemelytipusNeve.Name = "dgSzemelytipusNeve"
        Me.dgSzemelytipusNeve.ReadOnly = True
        '
        'KitKatBindingSource
        '
        Me.KitKatBindingSource.DataMember = "NyomiLista"
        Me.KitKatBindingSource.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'NyomtatvanyAdatokDataSet
        '
        Me.NyomtatvanyAdatokDataSet.DataSetName = "NyomtatvanyAdatokDataSet"
        Me.NyomtatvanyAdatokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgSzemelyValaszto
        '
        Me.dgSzemelyValaszto.AllowUserToAddRows = False
        Me.dgSzemelyValaszto.AllowUserToDeleteRows = False
        Me.dgSzemelyValaszto.AutoGenerateColumns = False
        Me.dgSzemelyValaszto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgSzemelyValaszto.ColumnHeadersHeight = 30
        Me.dgSzemelyValaszto.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        Me.dgSzemelyValaszto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSzemelyValaszto.Location = New System.Drawing.Point(3, 218)
        Me.dgSzemelyValaszto.MultiSelect = False
        Me.dgSzemelyValaszto.Name = "dgSzemelyValaszto"
        Me.dgSzemelyValaszto.ReadOnly = True
        Me.dgSzemelyValaszto.RowHeadersWidth = 5
        Me.dgSzemelyValaszto.Size = New System.Drawing.Size(435, 138)
        Me.dgSzemelyValaszto.TabIndex = 1
        '
        'TorzsAdatbazisDataSetBindingSource
        '
        Me.TorzsAdatbazisDataSetBindingSource.DataSource = Me.TorzsAdatbazisDataSet
        Me.TorzsAdatbazisDataSetBindingSource.Position = 0
        '
        'TorzsAdatbazisDataSet
        '
        Me.TorzsAdatbazisDataSet.DataSetName = "TorzsAdatbazisDataSet"
        Me.TorzsAdatbazisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnTorol, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnDown, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnUp, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAddSzemelytoList, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAddSzemelytoTDB, 0, 7)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(450, 219)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(69, 359)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'btnTorol
        '
        Me.btnTorol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTorol.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTorol.Location = New System.Drawing.Point(40, 109)
        Me.btnTorol.Name = "btnTorol"
        Me.btnTorol.Size = New System.Drawing.Size(22, 22)
        Me.btnTorol.TabIndex = 3
        Me.btnTorol.Text = "╳"
        Me.btnTorol.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.AutoSize = True
        Me.btnDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDown.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(40, 144)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(22, 23)
        Me.btnDown.TabIndex = 4
        Me.btnDown.Text = "↓"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.AutoSize = True
        Me.btnUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUp.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(40, 74)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(22, 23)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "↑"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnAddSzemelytoList
        '
        Me.btnAddSzemelytoList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAddSzemelytoList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.SetColumnSpan(Me.btnAddSzemelytoList, 2)
        Me.btnAddSzemelytoList.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAddSzemelytoList.Location = New System.Drawing.Point(3, 230)
        Me.btnAddSzemelytoList.Name = "btnAddSzemelytoList"
        Me.btnAddSzemelytoList.Size = New System.Drawing.Size(62, 33)
        Me.btnAddSzemelytoList.TabIndex = 0
        Me.btnAddSzemelytoList.Text = "➔"
        Me.btnAddSzemelytoList.UseVisualStyleBackColor = True
        '
        'btnAddSzemelytoTDB
        '
        Me.btnAddSzemelytoTDB.Font = New System.Drawing.Font("Segoe UI Symbol", 6.0!)
        Me.btnAddSzemelytoTDB.Location = New System.Drawing.Point(3, 320)
        Me.btnAddSzemelytoTDB.Name = "btnAddSzemelytoTDB"
        Me.btnAddSzemelytoTDB.Size = New System.Drawing.Size(22, 19)
        Me.btnAddSzemelytoTDB.TabIndex = 1
        Me.btnAddSzemelytoTDB.Text = "✚"
        Me.btnAddSzemelytoTDB.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.lblNyomKivalasztott, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tbNyomKivalasztott, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(525, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(483, 18)
        Me.TableLayoutPanel4.TabIndex = 15
        '
        'lblNyomKivalasztott
        '
        Me.lblNyomKivalasztott.AutoSize = True
        Me.lblNyomKivalasztott.Location = New System.Drawing.Point(3, 3)
        Me.lblNyomKivalasztott.Margin = New System.Windows.Forms.Padding(3)
        Me.lblNyomKivalasztott.Name = "lblNyomKivalasztott"
        Me.lblNyomKivalasztott.Size = New System.Drawing.Size(178, 12)
        Me.lblNyomKivalasztott.TabIndex = 14
        Me.lblNyomKivalasztott.Text = "Kiválasztott sablon neve és verziója:"
        '
        'tbNyomKivalasztott
        '
        Me.tbNyomKivalasztott.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNyomKivalasztott.Location = New System.Drawing.Point(187, 3)
        Me.tbNyomKivalasztott.Name = "tbNyomKivalasztott"
        Me.tbNyomKivalasztott.ReadOnly = True
        Me.tbNyomKivalasztott.Size = New System.Drawing.Size(293, 20)
        Me.tbNyomKivalasztott.TabIndex = 15
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cbBekuldo, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.tbSzures, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 162)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(441, 51)
        Me.TableLayoutPanel5.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(3, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Beküldő személy:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Szűrés"
        '
        'cbBekuldo
        '
        Me.cbBekuldo.DataSource = Me.TorzsAdatbazisDataSet.Term_szemely_rogzito
        Me.cbBekuldo.DisplayMember = "Teljes név"
        Me.cbBekuldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbBekuldo.FormattingEnabled = True
        Me.cbBekuldo.Location = New System.Drawing.Point(98, 28)
        Me.cbBekuldo.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.cbBekuldo.Name = "cbBekuldo"
        Me.cbBekuldo.Size = New System.Drawing.Size(338, 21)
        Me.cbBekuldo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cbBekuldo, "Válassza ki a nyomtatványt beküldő személyt!")
        Me.cbBekuldo.ValueMember = "ID"
        '
        'tbSzures
        '
        Me.tbSzures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSzures.Location = New System.Drawing.Point(98, 3)
        Me.tbSzures.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.tbSzures.MaxLength = 20
        Me.tbSzures.Name = "tbSzures"
        Me.tbSzures.Size = New System.Drawing.Size(338, 20)
        Me.tbSzures.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbSzures, "Szűrjön a nyomtatványok körében a leírás vagy a kód (pl. P23) egy részletével")
        '
        'btnImportraMent
        '
        Me.btnImportraMent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnImportraMent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnImportraMent.Location = New System.Drawing.Point(335, 679)
        Me.btnImportraMent.Name = "btnImportraMent"
        Me.btnImportraMent.Size = New System.Drawing.Size(109, 30)
        Me.btnImportraMent.TabIndex = 3
        Me.btnImportraMent.Text = "Importálásra mentés"
        Me.btnImportraMent.UseVisualStyleBackColor = True
        '
        'btnBezarImportNelkul
        '
        Me.btnBezarImportNelkul.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBezarImportNelkul.Location = New System.Drawing.Point(525, 682)
        Me.btnBezarImportNelkul.Name = "btnBezarImportNelkul"
        Me.btnBezarImportNelkul.Size = New System.Drawing.Size(75, 23)
        Me.btnBezarImportNelkul.TabIndex = 4
        Me.btnBezarImportNelkul.Text = "Bezár"
        Me.btnBezarImportNelkul.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel6, 3)
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tbFajlnev, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 584)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.18605!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.81395!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1005, 84)
        Me.TableLayoutPanel6.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel6.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(694, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'tbFajlnev
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.tbFajlnev, 2)
        Me.tbFajlnev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbFajlnev.Location = New System.Drawing.Point(3, 40)
        Me.tbFajlnev.Name = "tbFajlnev"
        Me.tbFajlnev.Size = New System.Drawing.Size(664, 20)
        Me.tbFajlnev.TabIndex = 1
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnAddBekuldotoTDB, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.btnKivalaszt, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(450, 162)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.86956!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.13044!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(68, 49)
        Me.TableLayoutPanel7.TabIndex = 19
        '
        'btnAddBekuldotoTDB
        '
        Me.btnAddBekuldotoTDB.Font = New System.Drawing.Font("Segoe UI Symbol", 6.0!)
        Me.btnAddBekuldotoTDB.Location = New System.Drawing.Point(0, 29)
        Me.btnAddBekuldotoTDB.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddBekuldotoTDB.Name = "btnAddBekuldotoTDB"
        Me.btnAddBekuldotoTDB.Size = New System.Drawing.Size(22, 19)
        Me.btnAddBekuldotoTDB.TabIndex = 1
        Me.btnAddBekuldotoTDB.Text = "✚"
        Me.ToolTip1.SetToolTip(Me.btnAddBekuldotoTDB, "Nyissa meg a természetes személyek törzsadatbázisát")
        Me.btnAddBekuldotoTDB.UseVisualStyleBackColor = True
        '
        'btnKivalaszt
        '
        Me.btnKivalaszt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKivalaszt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnKivalaszt.Location = New System.Drawing.Point(1, 1)
        Me.btnKivalaszt.Margin = New System.Windows.Forms.Padding(1, 1, 1, 4)
        Me.btnKivalaszt.Name = "btnKivalaszt"
        Me.btnKivalaszt.Size = New System.Drawing.Size(66, 24)
        Me.btnKivalaszt.TabIndex = 0
        Me.btnKivalaszt.Text = "Kiválaszt"
        Me.ToolTip1.SetToolTip(Me.btnKivalaszt, "Kiválasztja a fent kijelölt sablont")
        Me.btnKivalaszt.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.dgUgyvalaszto, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.lvKivalasztottak, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnAddUgy, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(525, 162)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel8, 2)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.43243!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.56757!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(483, 416)
        Me.TableLayoutPanel8.TabIndex = 21
        '
        'dgUgyvalaszto
        '
        Me.dgUgyvalaszto.AllowUserToAddRows = False
        Me.dgUgyvalaszto.AllowUserToDeleteRows = False
        Me.dgUgyvalaszto.AutoGenerateColumns = False
        Me.dgUgyvalaszto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgUgyvalaszto.ColumnHeadersHeight = 25
        Me.dgUgyvalaszto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.BirosagkivalasztasaDataGridViewTextBoxColumn1, Me.Ugyszám_ugycsoport_resze, Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn1, Me.UgyszamevszamreszeDataGridViewTextBoxColumn1, Me.ElsorendufelperesNeveDataGridViewTextBoxColumn, Me.ElsorendualperesNeveDataGridViewTextBoxColumn, Me.UgytargyaDataGridViewTextBoxColumn})
        Me.TableLayoutPanel8.SetColumnSpan(Me.dgUgyvalaszto, 2)
        Me.dgUgyvalaszto.DataSource = Me.UgytorzsrogzitoBindingSourceX
        Me.dgUgyvalaszto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUgyvalaszto.Location = New System.Drawing.Point(3, 22)
        Me.dgUgyvalaszto.MultiSelect = False
        Me.dgUgyvalaszto.Name = "dgUgyvalaszto"
        Me.dgUgyvalaszto.ReadOnly = True
        Me.dgUgyvalaszto.RowHeadersVisible = False
        Me.dgUgyvalaszto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUgyvalaszto.Size = New System.Drawing.Size(477, 122)
        Me.dgUgyvalaszto.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.dgUgyvalaszto, "Ha a nyomtatványban meglévő és törzsként rögzített ügy adatait szeretné megjelení" &
        "teni, itt válassza ki")
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Visible = False
        '
        'BirosagkivalasztasaDataGridViewTextBoxColumn1
        '
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn1.DataPropertyName = "Birosag_kivalasztasa"
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn1.HeaderText = "Bság"
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn1.Name = "BirosagkivalasztasaDataGridViewTextBoxColumn1"
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Ugyszám_ugycsoport_resze
        '
        Me.Ugyszám_ugycsoport_resze.DataPropertyName = "Ugyszám_ugycsoport_resze"
        Me.Ugyszám_ugycsoport_resze.HeaderText = "Ücs."
        Me.Ugyszám_ugycsoport_resze.Name = "Ugyszám_ugycsoport_resze"
        Me.Ugyszám_ugycsoport_resze.ReadOnly = True
        Me.Ugyszám_ugycsoport_resze.Width = 35
        '
        'UgyszamlajstromszamreszeDataGridViewTextBoxColumn1
        '
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn1.DataPropertyName = "Ugyszam_lajstromszam_resze"
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn1.HeaderText = "Ügysz."
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn1.Name = "UgyszamlajstromszamreszeDataGridViewTextBoxColumn1"
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UgyszamevszamreszeDataGridViewTextBoxColumn1
        '
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn1.DataPropertyName = "Ugyszam_evszam_resze"
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn1.HeaderText = "Év"
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn1.Name = "UgyszamevszamreszeDataGridViewTextBoxColumn1"
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ElsorendufelperesNeveDataGridViewTextBoxColumn
        '
        Me.ElsorendufelperesNeveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ElsorendufelperesNeveDataGridViewTextBoxColumn.DataPropertyName = "Elsorendu_felperes neve"
        Me.ElsorendufelperesNeveDataGridViewTextBoxColumn.HeaderText = "Felperes"
        Me.ElsorendufelperesNeveDataGridViewTextBoxColumn.Name = "ElsorendufelperesNeveDataGridViewTextBoxColumn"
        Me.ElsorendufelperesNeveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ElsorendualperesNeveDataGridViewTextBoxColumn
        '
        Me.ElsorendualperesNeveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ElsorendualperesNeveDataGridViewTextBoxColumn.DataPropertyName = "Elsorendu_alperes neve"
        Me.ElsorendualperesNeveDataGridViewTextBoxColumn.HeaderText = "Alperes"
        Me.ElsorendualperesNeveDataGridViewTextBoxColumn.Name = "ElsorendualperesNeveDataGridViewTextBoxColumn"
        Me.ElsorendualperesNeveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UgytargyaDataGridViewTextBoxColumn
        '
        Me.UgytargyaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UgytargyaDataGridViewTextBoxColumn.DataPropertyName = "Ugy_targya"
        Me.UgytargyaDataGridViewTextBoxColumn.HeaderText = "Tárgy"
        Me.UgytargyaDataGridViewTextBoxColumn.Name = "UgytargyaDataGridViewTextBoxColumn"
        Me.UgytargyaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UgytorzsrogzitoBindingSourceX
        '
        Me.UgytorzsrogzitoBindingSourceX.DataMember = "Ugytorzs_rogzito"
        Me.UgytorzsrogzitoBindingSourceX.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        '
        'lvKivalasztottak
        '
        Me.lvKivalasztottak.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvR, Me.lvLap, Me.lvNeve, Me.lvTorzsTabla, Me.lvID})
        Me.TableLayoutPanel8.SetColumnSpan(Me.lvKivalasztottak, 2)
        Me.lvKivalasztottak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvKivalasztottak.FullRowSelect = True
        Me.lvKivalasztottak.Location = New System.Drawing.Point(3, 150)
        Me.lvKivalasztottak.Name = "lvKivalasztottak"
        Me.lvKivalasztottak.ShowGroups = False
        Me.lvKivalasztottak.Size = New System.Drawing.Size(477, 263)
        Me.lvKivalasztottak.TabIndex = 2
        Me.lvKivalasztottak.UseCompatibleStateImageBehavior = False
        Me.lvKivalasztottak.View = System.Windows.Forms.View.Details
        '
        'lvR
        '
        Me.lvR.Text = "R"
        Me.lvR.Width = 40
        '
        'lvLap
        '
        Me.lvLap.DisplayIndex = 4
        Me.lvLap.Text = "Lap"
        Me.lvLap.Width = 277
        '
        'lvNeve
        '
        Me.lvNeve.DisplayIndex = 1
        Me.lvNeve.Text = "Neve"
        Me.lvNeve.Width = 147
        '
        'lvTorzsTabla
        '
        Me.lvTorzsTabla.DisplayIndex = 2
        Me.lvTorzsTabla.Text = "Tábla"
        Me.lvTorzsTabla.Width = 0
        '
        'lvID
        '
        Me.lvID.DisplayIndex = 3
        Me.lvID.Text = "ID"
        Me.lvID.Width = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Ha korábbi ügyhöz kapcsolódik, ügy kiválasztása"
        '
        'btnAddUgy
        '
        Me.btnAddUgy.Font = New System.Drawing.Font("Segoe UI Symbol", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUgy.Location = New System.Drawing.Point(456, 0)
        Me.btnAddUgy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddUgy.Name = "btnAddUgy"
        Me.btnAddUgy.Size = New System.Drawing.Size(22, 19)
        Me.btnAddUgy.TabIndex = 23
        Me.btnAddUgy.Text = "✚"
        Me.btnAddUgy.UseVisualStyleBackColor = True
        '
        'Term_szemely_rogzitoTableAdapter
        '
        Me.Term_szemely_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NevDataGridViewTextBoxColumn
        '
        Me.NevDataGridViewTextBoxColumn.DataPropertyName = "Nev"
        Me.NevDataGridViewTextBoxColumn.HeaderText = "Nev"
        Me.NevDataGridViewTextBoxColumn.Name = "NevDataGridViewTextBoxColumn"
        '
        'TorzstablatipusDataGridViewTextBoxColumn
        '
        Me.TorzstablatipusDataGridViewTextBoxColumn.DataPropertyName = "Torzstabla_tipus"
        Me.TorzstablatipusDataGridViewTextBoxColumn.HeaderText = "Torzstabla_tipus"
        Me.TorzstablatipusDataGridViewTextBoxColumn.Name = "TorzstablatipusDataGridViewTextBoxColumn"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrissKitKatTableAdapter
        '
        Me.FrissKitKatTableAdapter.ClearBeforeFill = True
        '
        'EgyebjogikvorogzitoBindingSource
        '
        Me.EgyebjogikvorogzitoBindingSource.DataMember = "Egyeb_jogi_kvo_rogzito"
        Me.EgyebjogikvorogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        '
        'Egyeb_jogi_kvo_rogzitoTableAdapter
        '
        Me.Egyeb_jogi_kvo_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'EgyebszervezetrogzitoBindingSource
        '
        Me.EgyebszervezetrogzitoBindingSource.DataMember = "Egyeb_szervezet_rogzito"
        Me.EgyebszervezetrogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        '
        'Egyeb_szervezet_rogzitoTableAdapter
        '
        Me.Egyeb_szervezet_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'EgyeniugyvedirogzitoBindingSource
        '
        Me.EgyeniugyvedirogzitoBindingSource.DataMember = "Egyeni_ugyvedi_rogzito"
        Me.EgyeniugyvedirogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        '
        'Egyeni_ugyvedi_rogzitoTableAdapter
        '
        Me.Egyeni_ugyvedi_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'EVrogzitoBindingSource
        '
        Me.EVrogzitoBindingSource.DataMember = "EV_rogzito"
        Me.EVrogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        '
        'EV_rogzitoTableAdapter
        '
        Me.EV_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'JogtanacsosrogzitoBindingSource
        '
        Me.JogtanacsosrogzitoBindingSource.DataMember = "Jogtanacsos_rogzito"
        Me.JogtanacsosrogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        '
        'Jogtanacsos_rogzitoTableAdapter
        '
        Me.Jogtanacsos_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'UgyvediirodarogzitoBindingSource
        '
        Me.UgyvediirodarogzitoBindingSource.DataMember = "Ugyvedi_iroda_rogzito"
        Me.UgyvediirodarogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        '
        'Ugyvedi_iroda_rogzitoTableAdapter
        '
        Me.Ugyvedi_iroda_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'CegrogzitoBindingSource
        '
        Me.CegrogzitoBindingSource.DataMember = "Ceg_rogzito"
        Me.CegrogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSetBindingSource
        '
        'Ceg_rogzitoTableAdapter
        '
        Me.Ceg_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'Ugytorzs_rogzitoTableAdapter
        '
        Me.Ugytorzs_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'NyomiListaTableAdapter
        '
        Me.NyomiListaTableAdapter.ClearBeforeFill = True
        '
        'NyomiListaFeldolgTableAdapter
        '
        Me.NyomiListaFeldolgTableAdapter.ClearBeforeFill = True
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 3
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        Me.ID.Width = 3
        '
        'BirosagkivalasztasaDataGridViewTextBoxColumn
        '
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn.DataPropertyName = "Birosag_kivalasztasa"
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn.HeaderText = "Bíróság"
        Me.BirosagkivalasztasaDataGridViewTextBoxColumn.Name = "BirosagkivalasztasaDataGridViewTextBoxColumn"
        '
        'UgyszámugycsoportreszeDataGridViewTextBoxColumn
        '
        Me.UgyszámugycsoportreszeDataGridViewTextBoxColumn.DataPropertyName = "Ugyszám_ugycsoport_resze"
        Me.UgyszámugycsoportreszeDataGridViewTextBoxColumn.HeaderText = "Ügycs."
        Me.UgyszámugycsoportreszeDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.UgyszámugycsoportreszeDataGridViewTextBoxColumn.Name = "UgyszámugycsoportreszeDataGridViewTextBoxColumn"
        Me.UgyszámugycsoportreszeDataGridViewTextBoxColumn.Width = 40
        '
        'UgyszamlajstromszamreszeDataGridViewTextBoxColumn
        '
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn.DataPropertyName = "Ugyszam_lajstromszam_resze"
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn.HeaderText = "Lajstromsz."
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn.Name = "UgyszamlajstromszamreszeDataGridViewTextBoxColumn"
        Me.UgyszamlajstromszamreszeDataGridViewTextBoxColumn.Width = 60
        '
        'UgyszamevszamreszeDataGridViewTextBoxColumn
        '
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn.DataPropertyName = "Ugyszam_evszam_resze"
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn.HeaderText = "Év"
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn.Name = "UgyszamevszamreszeDataGridViewTextBoxColumn"
        Me.UgyszamevszamreszeDataGridViewTextBoxColumn.Width = 40
        '
        'Kitolt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1007, 717)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1012, 756)
        Me.Name = "Kitolt"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Új nyomtatvány (ENYK) törzsadatból"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgFRMENYKValaszto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgTorzsValaszto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KitKatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NyomtatvanyAdatokDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSzemelyValaszto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorzsAdatbazisDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.dgUgyvalaszto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UgytorzsrogzitoBindingSourceX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermszemelyrogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EgyebjogikvorogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EgyebszervezetrogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EgyeniugyvedirogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVrogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JogtanacsosrogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UgyvediirodarogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CegrogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblValasszakisablontipust As Label
    Friend WithEvents TorzsAdatbazisDataSet As TorzsAdatbazisDataSet
    Friend WithEvents TermszemelyrogzitoBindingSource As BindingSource
    Friend WithEvents Term_szemely_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Term_szemely_rogzitoTableAdapter
    Friend WithEvents NyomtatvanyAdatokDataSet As NyomtatvanyAdatokDataSet
    Friend WithEvents TorzsAdatbazisDataSetBindingSource As BindingSource
    Friend WithEvents lblNyomKivalasztott As Label
    Friend WithEvents btnImportraMent As Button
    Friend WithEvents dgFRMENYKValaszto As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgTorzsValaszto As DataGridView
    Friend WithEvents dgSzemelyValaszto As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnTorol As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnAddSzemelytoList As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents tbNyomKivalasztott As TextBox
    Friend WithEvents btnKivalaszt As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbBekuldo As ComboBox
    Friend WithEvents tbSzures As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NevDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TorzstablatipusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnBezarImportNelkul As Button
    Friend WithEvents btnAddSzemelytoTDB As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btnAddBekuldotoTDB As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgNev As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents dgSzemelyTipusa As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents KitKatBindingSource As BindingSource
    Friend WithEvents FrissKitKatTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.OsszesitettMDFbolTableAdapter
    Friend WithEvents KitkatNevDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents TorzstablaTipusNeveDataGridViewTextBoxColumn As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents dgTorzs_Tablatipus As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents EgyebjogikvorogzitoBindingSource As BindingSource
    Friend WithEvents Egyeb_jogi_kvo_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Egyeb_jogi_kvo_rogzitoTableAdapter
    Friend WithEvents EgyebszervezetrogzitoBindingSource As BindingSource
    Friend WithEvents Egyeb_szervezet_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Egyeb_szervezet_rogzitoTableAdapter
    Friend WithEvents EgyeniugyvedirogzitoBindingSource As BindingSource
    Friend WithEvents Egyeni_ugyvedi_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Egyeni_ugyvedi_rogzitoTableAdapter
    Friend WithEvents EVrogzitoBindingSource As BindingSource
    Friend WithEvents EV_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.EV_rogzitoTableAdapter
    Friend WithEvents JogtanacsosrogzitoBindingSource As BindingSource
    Friend WithEvents Jogtanacsos_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Jogtanacsos_rogzitoTableAdapter
    'Friend WithEvents TermszemelyrogzitoBindingSource1 As BindingSource
    Friend WithEvents UgyvediirodarogzitoBindingSource As BindingSource
    Friend WithEvents Ugyvedi_iroda_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Ugyvedi_iroda_rogzitoTableAdapter
    Friend WithEvents CegrogzitoBindingSource As BindingSource
    Friend WithEvents Ceg_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Ceg_rogzitoTableAdapter
    'Friend WithEvents UgytorzsrogzitoBindingSource As BindingSource
    Friend WithEvents Ugytorzs_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Ugytorzs_rogzitoTableAdapter
    Friend WithEvents NyomiListaTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.NyomiListaTableAdapter
    Friend WithEvents NyomiListaFeldolgTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.NyomiListaFeldolgTableAdapter
    Friend WithEvents UgytorzsrogzitoBindingSourceX As BindingSource
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents dgUgyvalaszto As DataGridView
    Friend WithEvents lvKivalasztottak As ListView
    Friend WithEvents lvR As ColumnHeader
    Friend WithEvents lvLap As ColumnHeader
    Friend WithEvents lvNeve As ColumnHeader
    Friend WithEvents lvTorzsTabla As ColumnHeader
    Friend WithEvents lvID As ColumnHeader
    Friend WithEvents dgTorzs_Lap As DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents dgSzemelytipusNeve As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents BirosagkivalasztasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UgyszámugycsoportreszeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UgyszamlajstromszamreszeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UgyszamevszamreszeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFajlnev As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BirosagkivalasztasaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Ugyszám_ugycsoport_resze As DataGridViewTextBoxColumn
    Friend WithEvents UgyszamlajstromszamreszeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UgyszamevszamreszeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ElsorendufelperesNeveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ElsorendualperesNeveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UgytargyaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddUgy As Button
End Class
