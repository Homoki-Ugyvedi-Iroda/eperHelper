<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TDB_Ugy
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
        Dim Birosag_kivalasztasaLabel As System.Windows.Forms.Label
        Dim Ugyszám_ugycsoport_reszeLabel As System.Windows.Forms.Label
        Dim Ugyszam_lajstromszam_reszeLabel As System.Windows.Forms.Label
        Dim Ugyszam_evszam_reszeLabel As System.Windows.Forms.Label
        Dim Elsorendu_felperes_neveLabel As System.Windows.Forms.Label
        Dim Elsorendu_alperes_neveLabel As System.Windows.Forms.Label
        Dim Ugy_targyaLabel As System.Windows.Forms.Label
        Dim Elso_beadvany_KR_neveLabel As System.Windows.Forms.Label
        Dim Elso_beadvany_erkeztetesi_szamaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TDB_Ugy))
        Me.TorzsAdatbazisDataSet = New homoki.eperhelper.TorzsAdatbazisDataSet()
        Me.Ugytorzs_rogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ugytorzs_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Ugytorzs_rogzitoTableAdapter()
        Me.TableAdapterManager = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.TableAdapterManager()
        Me.Ceg_rogzitoTableAdapter1 = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Ceg_rogzitoTableAdapter()
        Me.Egyeb_szervezet_rogzitoTableAdapter1 = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Egyeb_szervezet_rogzitoTableAdapter()
        Me.EV_rogzitoTableAdapter1 = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.EV_rogzitoTableAdapter()
        Me.Term_szemely_rogzitoTableAdapter1 = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Term_szemely_rogzitoTableAdapter()
        Me.Ugytorzs_rogzitoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Ugytorzs_rogzitoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbKereso = New System.Windows.Forms.ToolStripTextBox()
        Me.btnKeres = New System.Windows.Forms.ToolStripButton()
        Me.Birosag_kivalasztasaComboBox = New System.Windows.Forms.ComboBox()
        Me.NyomtatvanyAdatokDataSet = New homoki.eperhelper.NyomtatvanyAdatokDataSet()
        Me.Ugyszám_ugycsoport_reszeComboBox = New System.Windows.Forms.ComboBox()
        Me.Ugyszam_lajstromszam_reszeTextBox = New System.Windows.Forms.TextBox()
        Me.Ugyszam_evszam_reszeTextBox = New System.Windows.Forms.TextBox()
        Me.Elsorendu_felperes_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Elsorendu_alperes_neveTextBox = New System.Windows.Forms.TextBox()
        Me.Ugy_targyaTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Elso_beadvany_erkeztetesi_szamaTextBox = New System.Windows.Forms.TextBox()
        Me.Elso_beadvany_KR_neveTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnElvet = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.BirosagokTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.BirosagokTableAdapter()
        Me.UgycsoportTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.UgycsoportTableAdapter()
        Me.UgycsoportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Birosag_kivalasztasaLabel = New System.Windows.Forms.Label()
        Ugyszám_ugycsoport_reszeLabel = New System.Windows.Forms.Label()
        Ugyszam_lajstromszam_reszeLabel = New System.Windows.Forms.Label()
        Ugyszam_evszam_reszeLabel = New System.Windows.Forms.Label()
        Elsorendu_felperes_neveLabel = New System.Windows.Forms.Label()
        Elsorendu_alperes_neveLabel = New System.Windows.Forms.Label()
        Ugy_targyaLabel = New System.Windows.Forms.Label()
        Elso_beadvany_KR_neveLabel = New System.Windows.Forms.Label()
        Elso_beadvany_erkeztetesi_szamaLabel = New System.Windows.Forms.Label()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ugytorzs_rogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ugytorzs_rogzitoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ugytorzs_rogzitoBindingNavigator.SuspendLayout()
        CType(Me.NyomtatvanyAdatokDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.UgycsoportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Birosag_kivalasztasaLabel
        '
        Birosag_kivalasztasaLabel.AutoSize = True
        Birosag_kivalasztasaLabel.Location = New System.Drawing.Point(3, 0)
        Birosag_kivalasztasaLabel.Name = "Birosag_kivalasztasaLabel"
        Birosag_kivalasztasaLabel.Size = New System.Drawing.Size(105, 13)
        Birosag_kivalasztasaLabel.TabIndex = 1
        Birosag_kivalasztasaLabel.Text = "Bíróság kiválasztása" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Ugyszám_ugycsoport_reszeLabel
        '
        Ugyszám_ugycsoport_reszeLabel.AutoSize = True
        Ugyszám_ugycsoport_reszeLabel.Location = New System.Drawing.Point(3, 27)
        Ugyszám_ugycsoport_reszeLabel.Name = "Ugyszám_ugycsoport_reszeLabel"
        Ugyszám_ugycsoport_reszeLabel.Size = New System.Drawing.Size(133, 13)
        Ugyszám_ugycsoport_reszeLabel.TabIndex = 3
        Ugyszám_ugycsoport_reszeLabel.Text = "Ügyszám ügycsoport része"
        '
        'Ugyszam_lajstromszam_reszeLabel
        '
        Ugyszam_lajstromszam_reszeLabel.AutoSize = True
        Ugyszam_lajstromszam_reszeLabel.Location = New System.Drawing.Point(3, 54)
        Ugyszam_lajstromszam_reszeLabel.Name = "Ugyszam_lajstromszam_reszeLabel"
        Ugyszam_lajstromszam_reszeLabel.Size = New System.Drawing.Size(140, 13)
        Ugyszam_lajstromszam_reszeLabel.TabIndex = 5
        Ugyszam_lajstromszam_reszeLabel.Text = "Ügyszám lajstromszám része" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Ugyszam_evszam_reszeLabel
        '
        Ugyszam_evszam_reszeLabel.AutoSize = True
        Ugyszam_evszam_reszeLabel.Location = New System.Drawing.Point(3, 80)
        Ugyszam_evszam_reszeLabel.Name = "Ugyszam_evszam_reszeLabel"
        Ugyszam_evszam_reszeLabel.Size = New System.Drawing.Size(117, 13)
        Ugyszam_evszam_reszeLabel.TabIndex = 7
        Ugyszam_evszam_reszeLabel.Text = "Ügyszám évszám része" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Elsorendu_felperes_neveLabel
        '
        Elsorendu_felperes_neveLabel.AutoSize = True
        Elsorendu_felperes_neveLabel.Location = New System.Drawing.Point(3, 106)
        Elsorendu_felperes_neveLabel.Name = "Elsorendu_felperes_neveLabel"
        Elsorendu_felperes_neveLabel.Size = New System.Drawing.Size(121, 13)
        Elsorendu_felperes_neveLabel.TabIndex = 9
        Elsorendu_felperes_neveLabel.Text = "Elsőrendű felperes neve" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Elsorendu_alperes_neveLabel
        '
        Elsorendu_alperes_neveLabel.AutoSize = True
        Elsorendu_alperes_neveLabel.Location = New System.Drawing.Point(3, 132)
        Elsorendu_alperes_neveLabel.Name = "Elsorendu_alperes_neveLabel"
        Elsorendu_alperes_neveLabel.Size = New System.Drawing.Size(118, 13)
        Elsorendu_alperes_neveLabel.TabIndex = 11
        Elsorendu_alperes_neveLabel.Text = "Elsőrendű alperes neve" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Ugy_targyaLabel
        '
        Ugy_targyaLabel.AutoSize = True
        Ugy_targyaLabel.Location = New System.Drawing.Point(3, 210)
        Ugy_targyaLabel.Name = "Ugy_targyaLabel"
        Ugy_targyaLabel.Size = New System.Drawing.Size(58, 13)
        Ugy_targyaLabel.TabIndex = 13
        Ugy_targyaLabel.Text = "Ügy tárgya" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Elso_beadvany_KR_neveLabel
        '
        Elso_beadvany_KR_neveLabel.AutoSize = True
        Elso_beadvany_KR_neveLabel.Location = New System.Drawing.Point(3, 158)
        Elso_beadvany_KR_neveLabel.Name = "Elso_beadvany_KR_neveLabel"
        Elso_beadvany_KR_neveLabel.Size = New System.Drawing.Size(122, 13)
        Elso_beadvany_KR_neveLabel.TabIndex = 16
        Elso_beadvany_KR_neveLabel.Text = "Első beadvány KR neve"
        '
        'Elso_beadvany_erkeztetesi_szamaLabel
        '
        Elso_beadvany_erkeztetesi_szamaLabel.AutoSize = True
        Elso_beadvany_erkeztetesi_szamaLabel.Location = New System.Drawing.Point(3, 184)
        Elso_beadvany_erkeztetesi_szamaLabel.Name = "Elso_beadvany_erkeztetesi_szamaLabel"
        Elso_beadvany_erkeztetesi_szamaLabel.Size = New System.Drawing.Size(132, 13)
        Elso_beadvany_erkeztetesi_szamaLabel.TabIndex = 17
        Elso_beadvany_erkeztetesi_szamaLabel.Text = "Első KR-érkeztetési száma"
        '
        'TorzsAdatbazisDataSet
        '
        Me.TorzsAdatbazisDataSet.DataSetName = "TorzsAdatbazisDataSet"
        Me.TorzsAdatbazisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ugytorzs_rogzitoBindingSource
        '
        Me.Ugytorzs_rogzitoBindingSource.DataMember = "Ugytorzs_rogzito"
        Me.Ugytorzs_rogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSet
        '
        'Ugytorzs_rogzitoTableAdapter
        '
        Me.Ugytorzs_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Ceg_rogzitoTableAdapter = Me.Ceg_rogzitoTableAdapter1
        Me.TableAdapterManager.Egyeb_jogi_kvo_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Egyeb_szervezet_rogzitoTableAdapter = Me.Egyeb_szervezet_rogzitoTableAdapter1
        Me.TableAdapterManager.Egyeni_ugyvedi_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.EV_rogzitoTableAdapter = Me.EV_rogzitoTableAdapter1
        Me.TableAdapterManager.Jogtanacsos_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Term_szemely_rogzitoTableAdapter = Me.Term_szemely_rogzitoTableAdapter1
        Me.TableAdapterManager.Ugytorzs_rogzitoTableAdapter = Me.Ugytorzs_rogzitoTableAdapter
        Me.TableAdapterManager.Ugyvedi_iroda_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Ceg_rogzitoTableAdapter1
        '
        Me.Ceg_rogzitoTableAdapter1.ClearBeforeFill = True
        '
        'Egyeb_szervezet_rogzitoTableAdapter1
        '
        Me.Egyeb_szervezet_rogzitoTableAdapter1.ClearBeforeFill = True
        '
        'EV_rogzitoTableAdapter1
        '
        Me.EV_rogzitoTableAdapter1.ClearBeforeFill = True
        '
        'Term_szemely_rogzitoTableAdapter1
        '
        Me.Term_szemely_rogzitoTableAdapter1.ClearBeforeFill = True
        '
        'Ugytorzs_rogzitoBindingNavigator
        '
        Me.Ugytorzs_rogzitoBindingNavigator.AddNewItem = Nothing
        Me.Ugytorzs_rogzitoBindingNavigator.BindingSource = Me.Ugytorzs_rogzitoBindingSource
        Me.Ugytorzs_rogzitoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Ugytorzs_rogzitoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Ugytorzs_rogzitoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Ugytorzs_rogzitoBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.tbKereso, Me.btnKeres})
        Me.Ugytorzs_rogzitoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Ugytorzs_rogzitoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Ugytorzs_rogzitoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Ugytorzs_rogzitoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Ugytorzs_rogzitoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Ugytorzs_rogzitoBindingNavigator.Name = "Ugytorzs_rogzitoBindingNavigator"
        Me.Ugytorzs_rogzitoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Ugytorzs_rogzitoBindingNavigator.Size = New System.Drawing.Size(571, 25)
        Me.Ugytorzs_rogzitoBindingNavigator.TabIndex = 0
        Me.Ugytorzs_rogzitoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Összesen hány rekord van"
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
        'Ugytorzs_rogzitoBindingNavigatorSaveItem
        '
        Me.Ugytorzs_rogzitoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ugytorzs_rogzitoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Ugytorzs_rogzitoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Ugytorzs_rogzitoBindingNavigatorSaveItem.Name = "Ugytorzs_rogzitoBindingNavigatorSaveItem"
        Me.Ugytorzs_rogzitoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Ugytorzs_rogzitoBindingNavigatorSaveItem.Text = "Adat elmentése"
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
        Me.btnKeres.Size = New System.Drawing.Size(77, 22)
        Me.btnKeres.Text = "név keresése"
        '
        'Birosag_kivalasztasaComboBox
        '
        Me.Birosag_kivalasztasaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Birosag_kivalasztasaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Birosag_kivalasztasaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Birosag_kivalasztasa", True))
        Me.Birosag_kivalasztasaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Ugytorzs_rogzitoBindingSource, "Birosag_kivalasztasa", True))
        Me.Birosag_kivalasztasaComboBox.DataSource = Me.NyomtatvanyAdatokDataSet.Birosagok
        Me.Birosag_kivalasztasaComboBox.DisplayMember = "Neve"
        Me.Birosag_kivalasztasaComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Birosag_kivalasztasaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Birosag_kivalasztasaComboBox.Location = New System.Drawing.Point(166, 3)
        Me.Birosag_kivalasztasaComboBox.Name = "Birosag_kivalasztasaComboBox"
        Me.Birosag_kivalasztasaComboBox.Size = New System.Drawing.Size(402, 21)
        Me.Birosag_kivalasztasaComboBox.TabIndex = 0
        Me.Birosag_kivalasztasaComboBox.ValueMember = "Neve"
        '
        'NyomtatvanyAdatokDataSet
        '
        Me.NyomtatvanyAdatokDataSet.DataSetName = "NyomtatvanyAdatokDataSet"
        Me.NyomtatvanyAdatokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ugyszám_ugycsoport_reszeComboBox
        '
        Me.Ugyszám_ugycsoport_reszeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Ugyszám_ugycsoport_reszeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Ugyszám_ugycsoport_reszeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Ugyszám_ugycsoport_resze", True))
        Me.Ugyszám_ugycsoport_reszeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Ugytorzs_rogzitoBindingSource, "Ugyszám_ugycsoport_resze", True))
        Me.Ugyszám_ugycsoport_reszeComboBox.DataSource = Me.NyomtatvanyAdatokDataSet.Ugycsoport
        Me.Ugyszám_ugycsoport_reszeComboBox.DisplayMember = "UgycsopNevKoddal"
        Me.Ugyszám_ugycsoport_reszeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ugyszám_ugycsoport_reszeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ugyszám_ugycsoport_reszeComboBox.Location = New System.Drawing.Point(166, 30)
        Me.Ugyszám_ugycsoport_reszeComboBox.Name = "Ugyszám_ugycsoport_reszeComboBox"
        Me.Ugyszám_ugycsoport_reszeComboBox.Size = New System.Drawing.Size(402, 21)
        Me.Ugyszám_ugycsoport_reszeComboBox.TabIndex = 1
        Me.Ugyszám_ugycsoport_reszeComboBox.ValueMember = "Ugycsoport_kodja"
        '
        'Ugyszam_lajstromszam_reszeTextBox
        '
        Me.Ugyszam_lajstromszam_reszeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Ugyszam_lajstromszam_resze", True))
        Me.Ugyszam_lajstromszam_reszeTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ugyszam_lajstromszam_reszeTextBox.Location = New System.Drawing.Point(166, 57)
        Me.Ugyszam_lajstromszam_reszeTextBox.MaxLength = 6
        Me.Ugyszam_lajstromszam_reszeTextBox.Name = "Ugyszam_lajstromszam_reszeTextBox"
        Me.Ugyszam_lajstromszam_reszeTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Ugyszam_lajstromszam_reszeTextBox.TabIndex = 2
        '
        'Ugyszam_evszam_reszeTextBox
        '
        Me.Ugyszam_evszam_reszeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Ugyszam_evszam_resze", True))
        Me.Ugyszam_evszam_reszeTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ugyszam_evszam_reszeTextBox.Location = New System.Drawing.Point(166, 83)
        Me.Ugyszam_evszam_reszeTextBox.MaxLength = 4
        Me.Ugyszam_evszam_reszeTextBox.Name = "Ugyszam_evszam_reszeTextBox"
        Me.Ugyszam_evszam_reszeTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Ugyszam_evszam_reszeTextBox.TabIndex = 3
        '
        'Elsorendu_felperes_neveTextBox
        '
        Me.Elsorendu_felperes_neveTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Elsorendu_felperes_neveTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Elsorendu_felperes_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Elsorendu_felperes neve", True))
        Me.Elsorendu_felperes_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Elsorendu_felperes_neveTextBox.Location = New System.Drawing.Point(166, 109)
        Me.Elsorendu_felperes_neveTextBox.MaxLength = 50
        Me.Elsorendu_felperes_neveTextBox.Name = "Elsorendu_felperes_neveTextBox"
        Me.Elsorendu_felperes_neveTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Elsorendu_felperes_neveTextBox.TabIndex = 4
        '
        'Elsorendu_alperes_neveTextBox
        '
        Me.Elsorendu_alperes_neveTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Elsorendu_alperes_neveTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Elsorendu_alperes_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Elsorendu_alperes neve", True))
        Me.Elsorendu_alperes_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Elsorendu_alperes_neveTextBox.Location = New System.Drawing.Point(166, 135)
        Me.Elsorendu_alperes_neveTextBox.MaxLength = 50
        Me.Elsorendu_alperes_neveTextBox.Name = "Elsorendu_alperes_neveTextBox"
        Me.Elsorendu_alperes_neveTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Elsorendu_alperes_neveTextBox.TabIndex = 5
        '
        'Ugy_targyaTextBox
        '
        Me.Ugy_targyaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Ugy_targya", True))
        Me.Ugy_targyaTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ugy_targyaTextBox.Location = New System.Drawing.Point(166, 213)
        Me.Ugy_targyaTextBox.MaxLength = 50
        Me.Ugy_targyaTextBox.Name = "Ugy_targyaTextBox"
        Me.Ugy_targyaTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Ugy_targyaTextBox.TabIndex = 8
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.72154!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.27846!))
        Me.TableLayoutPanel1.Controls.Add(Elso_beadvany_erkeztetesi_szamaLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Elso_beadvany_erkeztetesi_szamaTextBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Elso_beadvany_KR_neveLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Elso_beadvany_KR_neveTextBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Birosag_kivalasztasaLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Ugy_targyaLabel, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Birosag_kivalasztasaComboBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Ugy_targyaTextBox, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Ugyszám_ugycsoport_reszeLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Elsorendu_alperes_neveTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Elsorendu_alperes_neveLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Elsorendu_felperes_neveTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Ugyszám_ugycsoport_reszeComboBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Ugyszam_lajstromszam_reszeLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Elsorendu_felperes_neveLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Ugyszam_lajstromszam_reszeTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Ugyszam_evszam_reszeLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Ugyszam_evszam_reszeTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 0, 9)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(571, 333)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'Elso_beadvany_erkeztetesi_szamaTextBox
        '
        Me.Elso_beadvany_erkeztetesi_szamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Elso_beadvany_erkeztetesi_szama", True))
        Me.Elso_beadvany_erkeztetesi_szamaTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Elso_beadvany_erkeztetesi_szamaTextBox.Location = New System.Drawing.Point(166, 187)
        Me.Elso_beadvany_erkeztetesi_szamaTextBox.MaxLength = 27
        Me.Elso_beadvany_erkeztetesi_szamaTextBox.Name = "Elso_beadvany_erkeztetesi_szamaTextBox"
        Me.Elso_beadvany_erkeztetesi_szamaTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Elso_beadvany_erkeztetesi_szamaTextBox.TabIndex = 7
        '
        'Elso_beadvany_KR_neveTextBox
        '
        Me.Elso_beadvany_KR_neveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "Elso_beadvany_KR_neve", True))
        Me.Elso_beadvany_KR_neveTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Elso_beadvany_KR_neveTextBox.Location = New System.Drawing.Point(166, 161)
        Me.Elso_beadvany_KR_neveTextBox.MaxLength = 255
        Me.Elso_beadvany_KR_neveTextBox.Name = "Elso_beadvany_KR_neveTextBox"
        Me.Elso_beadvany_KR_neveTextBox.Size = New System.Drawing.Size(402, 20)
        Me.Elso_beadvany_KR_neveTextBox.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnElvet, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(166, 239)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(402, 91)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.Location = New System.Drawing.Point(48, 65)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(105, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Bezár és elment"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnElvet
        '
        Me.btnElvet.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnElvet.Location = New System.Drawing.Point(264, 65)
        Me.btnElvet.Name = "btnElvet"
        Me.btnElvet.Size = New System.Drawing.Size(75, 23)
        Me.btnElvet.TabIndex = 1
        Me.btnElvet.Text = "Elvet"
        Me.btnElvet.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ugytorzs_rogzitoBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(3, 239)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 18
        '
        'BirosagokTableAdapter
        '
        Me.BirosagokTableAdapter.ClearBeforeFill = True
        '
        'UgycsoportTableAdapter
        '
        Me.UgycsoportTableAdapter.ClearBeforeFill = True
        '
        'UgycsoportBindingSource
        '
        Me.UgycsoportBindingSource.DataMember = "Ugycsoport"
        Me.UgycsoportBindingSource.DataSource = Me.NyomtatvanyAdatokDataSet
        '
        'TDB_Ugy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 358)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Ugytorzs_rogzitoBindingNavigator)
        Me.Name = "TDB_Ugy"
        Me.ShowIcon = False
        Me.Text = "Ügyek"
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ugytorzs_rogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ugytorzs_rogzitoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ugytorzs_rogzitoBindingNavigator.ResumeLayout(False)
        Me.Ugytorzs_rogzitoBindingNavigator.PerformLayout()
        CType(Me.NyomtatvanyAdatokDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.UgycsoportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TorzsAdatbazisDataSet As TorzsAdatbazisDataSet
    Friend WithEvents Ugytorzs_rogzitoBindingSource As BindingSource
    Friend WithEvents Ugytorzs_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Ugytorzs_rogzitoTableAdapter
    Friend WithEvents TableAdapterManager As TorzsAdatbazisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Ugytorzs_rogzitoBindingNavigator As BindingNavigator
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
    Friend WithEvents Ugytorzs_rogzitoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Birosag_kivalasztasaComboBox As ComboBox
    Friend WithEvents Ugyszám_ugycsoport_reszeComboBox As ComboBox
    Friend WithEvents Ugyszam_lajstromszam_reszeTextBox As TextBox
    Friend WithEvents Ugyszam_evszam_reszeTextBox As TextBox
    Friend WithEvents Elsorendu_felperes_neveTextBox As TextBox
    Friend WithEvents Elsorendu_alperes_neveTextBox As TextBox

    Friend WithEvents Ugy_targyaTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnElvet As Button
    Friend WithEvents NyomtatvanyAdatokDataSet As NyomtatvanyAdatokDataSet
    Friend WithEvents BirosagokTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.BirosagokTableAdapter
    Friend WithEvents UgycsoportTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.UgycsoportTableAdapter
    Friend WithEvents Elso_beadvany_erkeztetesi_szamaTextBox As TextBox
    Friend WithEvents Elso_beadvany_KR_neveTextBox As TextBox
    Friend WithEvents Ceg_rogzitoTableAdapter1 As TorzsAdatbazisDataSetTableAdapters.Ceg_rogzitoTableAdapter
    Friend WithEvents Egyeb_szervezet_rogzitoTableAdapter1 As TorzsAdatbazisDataSetTableAdapters.Egyeb_szervezet_rogzitoTableAdapter
    Friend WithEvents EV_rogzitoTableAdapter1 As TorzsAdatbazisDataSetTableAdapters.EV_rogzitoTableAdapter
    Friend WithEvents Term_szemely_rogzitoTableAdapter1 As TorzsAdatbazisDataSetTableAdapters.Term_szemely_rogzitoTableAdapter
    Friend WithEvents UgycsoportBindingSource As BindingSource
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tbKereso As ToolStripTextBox
    Friend WithEvents btnKeres As ToolStripButton
End Class
