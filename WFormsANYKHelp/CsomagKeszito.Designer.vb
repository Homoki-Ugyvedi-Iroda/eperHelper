<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CsomagKeszito
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CsomagKeszito))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblElkeszultKR_csomag = New System.Windows.Forms.TableLayoutPanel()
        Me.btnUKPANYKWSfeltoltes = New System.Windows.Forms.Button()
        Me.btnPKPANYKWSfeltoltes = New System.Windows.Forms.Button()
        Me.btnUKPFeltoltes = New System.Windows.Forms.Button()
        Me.btnPKPFeltoltes = New System.Windows.Forms.Button()
        Me.btnHKPFeltoltes = New System.Windows.Forms.Button()
        Me.btnKapuAdatMegadasa = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnKeszit = New System.Windows.Forms.Button()
        Me.btnElvet = New System.Windows.Forms.Button()
        Me.lblIndit = New System.Windows.Forms.Label()
        Me.lblStatusz = New System.Windows.Forms.Label()
        Me.cbxUgytorzsbe = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbZipped = New System.Windows.Forms.CheckBox()
        Me.cbSajatTitkosito = New System.Windows.Forms.CheckBox()
        Me.lblZipFajlNev = New System.Windows.Forms.Label()
        Me.tbZipFajlnev = New System.Windows.Forms.TextBox()
        Me.cbxZipTorles = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnTorol = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnTallozCsatolmany = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbLegnagyobbCsatolmanyMerete = New System.Windows.Forms.TextBox()
        Me.lblOsszes = New System.Windows.Forms.Label()
        Me.lblLegnagyobb = New System.Windows.Forms.Label()
        Me.tbOsszesCsatolmanyMerete = New System.Windows.Forms.TextBox()
        Me.btnCsatNyit = New System.Windows.Forms.Button()
        Me.lvCsatolmanyok = New System.Windows.Forms.ListView()
        Me.lvCsatolmanyNeve = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvMeret = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvValodiMeret = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbXMLPath = New System.Windows.Forms.TextBox()
        Me.tbES3NyomiLenyomiPath = New System.Windows.Forms.TextBox()
        Me.tbES3CsatolmanyPath = New System.Windows.Forms.TextBox()
        Me.tbKRboritekNeve = New System.Windows.Forms.TextBox()
        Me.btnLefuzesiMappakTallózó = New System.Windows.Forms.Button()
        Me.btnLefuzes = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbUgyszam = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnANYKmentesibol = New System.Windows.Forms.Button()
        Me.btnNyomiLefuzesibol = New System.Windows.Forms.Button()
        Me.btnNyomiXMLmegnyitasibol = New System.Windows.Forms.Button()
        Me.tbNyomtatvanyNeve = New System.Windows.Forms.TextBox()
        Me.tbCimzettSzervNeve = New System.Windows.Forms.TextBox()
        Me.tbUgyszam = New System.Windows.Forms.TextBox()
        Me.tbUtolsoMentes = New System.Windows.Forms.TextBox()
        Me.tbFelperes = New System.Windows.Forms.TextBox()
        Me.tbAlperes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxEperHelper = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNyomtatvanyTalloz = New System.Windows.Forms.Button()
        Me.tbDirectoryNyomtatvanyok = New System.Windows.Forms.TextBox()
        Me.lvNyomiLista = New System.Windows.Forms.ListView()
        Me.lvEperHelper = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvNyomiListaName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvXmlNev = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvNyomiListaLastWritten = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NyomiListaFeldolgTableAdapter = New homoki.eperhelper.NyomtatvanyAdatokDataSetTableAdapters.NyomiListaFeldolgTableAdapter()
        Me.NyomtatvanyAdatokDataSet1 = New homoki.eperhelper.NyomtatvanyAdatokDataSet()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblElkeszultKR_csomag.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.NyomtatvanyAdatokDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblElkeszultKR_csomag, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lvCsatolmanyok, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.18244!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.67352!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.00137!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.133059!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(996, 717)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tblElkeszultKR_csomag
        '
        Me.tblElkeszultKR_csomag.ColumnCount = 3
        Me.tblElkeszultKR_csomag.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblElkeszultKR_csomag.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblElkeszultKR_csomag.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblElkeszultKR_csomag.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblElkeszultKR_csomag.Controls.Add(Me.btnUKPANYKWSfeltoltes, 0, 1)
        Me.tblElkeszultKR_csomag.Controls.Add(Me.btnPKPANYKWSfeltoltes, 0, 1)
        Me.tblElkeszultKR_csomag.Controls.Add(Me.btnUKPFeltoltes, 0, 0)
        Me.tblElkeszultKR_csomag.Controls.Add(Me.btnPKPFeltoltes, 1, 0)
        Me.tblElkeszultKR_csomag.Controls.Add(Me.btnHKPFeltoltes, 2, 0)
        Me.tblElkeszultKR_csomag.Controls.Add(Me.btnKapuAdatMegadasa, 2, 1)
        Me.tblElkeszultKR_csomag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblElkeszultKR_csomag.Location = New System.Drawing.Point(501, 598)
        Me.tblElkeszultKR_csomag.Name = "tblElkeszultKR_csomag"
        Me.tblElkeszultKR_csomag.RowCount = 2
        Me.tblElkeszultKR_csomag.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblElkeszultKR_csomag.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblElkeszultKR_csomag.Size = New System.Drawing.Size(492, 116)
        Me.tblElkeszultKR_csomag.TabIndex = 2
        Me.tblElkeszultKR_csomag.Visible = False
        '
        'btnUKPANYKWSfeltoltes
        '
        Me.btnUKPANYKWSfeltoltes.AutoSize = True
        Me.btnUKPANYKWSfeltoltes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUKPANYKWSfeltoltes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUKPANYKWSfeltoltes.Location = New System.Drawing.Point(174, 68)
        Me.btnUKPANYKWSfeltoltes.Margin = New System.Windows.Forms.Padding(10)
        Me.btnUKPANYKWSfeltoltes.Name = "btnUKPANYKWSfeltoltes"
        Me.btnUKPANYKWSfeltoltes.Size = New System.Drawing.Size(144, 38)
        Me.btnUKPANYKWSfeltoltes.TabIndex = 3
        Me.btnUKPANYKWSfeltoltes.Text = "Ügyfélkapu feltöltés ÁNYK-val"
        Me.ToolTip1.SetToolTip(Me.btnUKPANYKWSfeltoltes, "Az ÁNYK funkcióját meghívja a program, és a sikeres beküldésnél kapott KR kódot b" &
        "eírja az ügytörzsbe, ha a beadványt új ügy adataként elmenti")
        Me.btnUKPANYKWSfeltoltes.UseVisualStyleBackColor = True
        '
        'btnPKPANYKWSfeltoltes
        '
        Me.btnPKPANYKWSfeltoltes.AutoSize = True
        Me.btnPKPANYKWSfeltoltes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPKPANYKWSfeltoltes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPKPANYKWSfeltoltes.Location = New System.Drawing.Point(10, 68)
        Me.btnPKPANYKWSfeltoltes.Margin = New System.Windows.Forms.Padding(10)
        Me.btnPKPANYKWSfeltoltes.Name = "btnPKPANYKWSfeltoltes"
        Me.btnPKPANYKWSfeltoltes.Size = New System.Drawing.Size(144, 38)
        Me.btnPKPANYKWSfeltoltes.TabIndex = 4
        Me.btnPKPANYKWSfeltoltes.Text = "ÁNYK megnyitása PKP/HKP feltöltéshez"
        Me.ToolTip1.SetToolTip(Me.btnPKPANYKWSfeltoltes, resources.GetString("btnPKPANYKWSfeltoltes.ToolTip"))
        Me.btnPKPANYKWSfeltoltes.UseVisualStyleBackColor = True
        '
        'btnUKPFeltoltes
        '
        Me.btnUKPFeltoltes.AutoSize = True
        Me.btnUKPFeltoltes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUKPFeltoltes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUKPFeltoltes.Location = New System.Drawing.Point(10, 10)
        Me.btnUKPFeltoltes.Margin = New System.Windows.Forms.Padding(10)
        Me.btnUKPFeltoltes.Name = "btnUKPFeltoltes"
        Me.btnUKPFeltoltes.Size = New System.Drawing.Size(144, 38)
        Me.btnUKPFeltoltes.TabIndex = 0
        Me.btnUKPFeltoltes.Text = "Ügyfélkapu feltöltés böngészővel"
        Me.ToolTip1.SetToolTip(Me.btnUKPFeltoltes, "A böngészős feltöltés kb. 120 MB-ig működik. A kapott KR kódot írja be kézzel az " &
        "ügytörzs adatbázisba, így egyszerűen megtalálhatja, hogy a bírósági visszaigazol" &
        "ás mire vonatkozik.")
        Me.btnUKPFeltoltes.UseVisualStyleBackColor = True
        '
        'btnPKPFeltoltes
        '
        Me.btnPKPFeltoltes.AutoSize = True
        Me.btnPKPFeltoltes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPKPFeltoltes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPKPFeltoltes.Location = New System.Drawing.Point(174, 10)
        Me.btnPKPFeltoltes.Margin = New System.Windows.Forms.Padding(10)
        Me.btnPKPFeltoltes.Name = "btnPKPFeltoltes"
        Me.btnPKPFeltoltes.Size = New System.Drawing.Size(144, 38)
        Me.btnPKPFeltoltes.TabIndex = 1
        Me.btnPKPFeltoltes.Text = "Perkapu feltöltés böngészővel"
        Me.ToolTip1.SetToolTip(Me.btnPKPFeltoltes, "A böngészős feltöltés kb. 120 MB-ig működik. A kapott KR kódot írja be kézzel az " &
        "ügytörzs adatbázisba, így egyszerűen megtalálhatja, hogy a bírósági visszaigazol" &
        "ás mire vonatkozik.")
        Me.btnPKPFeltoltes.UseVisualStyleBackColor = True
        '
        'btnHKPFeltoltes
        '
        Me.btnHKPFeltoltes.AutoSize = True
        Me.btnHKPFeltoltes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHKPFeltoltes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHKPFeltoltes.Location = New System.Drawing.Point(338, 10)
        Me.btnHKPFeltoltes.Margin = New System.Windows.Forms.Padding(10)
        Me.btnHKPFeltoltes.Name = "btnHKPFeltoltes"
        Me.btnHKPFeltoltes.Size = New System.Drawing.Size(144, 38)
        Me.btnHKPFeltoltes.TabIndex = 2
        Me.btnHKPFeltoltes.Text = "Hivatali kapu feltöltés böngészővel"
        Me.ToolTip1.SetToolTip(Me.btnHKPFeltoltes, "A böngészős feltöltés kb. 120 MB-ig működik. A kapott KR kódot írja be kézzel az " &
        "ügytörzs adatbázisba, így egyszerűen megtalálhatja, hogy a bírósági visszaigazol" &
        "ás mire vonatkozik.")
        Me.btnHKPFeltoltes.UseVisualStyleBackColor = True
        '
        'btnKapuAdatMegadasa
        '
        Me.btnKapuAdatMegadasa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKapuAdatMegadasa.AutoSize = True
        Me.btnKapuAdatMegadasa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnKapuAdatMegadasa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnKapuAdatMegadasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnKapuAdatMegadasa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnKapuAdatMegadasa.Location = New System.Drawing.Point(347, 75)
        Me.btnKapuAdatMegadasa.Name = "btnKapuAdatMegadasa"
        Me.btnKapuAdatMegadasa.Size = New System.Drawing.Size(125, 23)
        Me.btnKapuAdatMegadasa.TabIndex = 5
        Me.btnKapuAdatMegadasa.Text = "Kapu adatok rögzítése"
        Me.ToolTip1.SetToolTip(Me.btnKapuAdatMegadasa, "A jelen ablak elhagyása nélkül rögzítheti az ügyfél-, per- és hivatali kapu adato" &
        "kat")
        Me.btnKapuAdatMegadasa.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnKeszit, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnElvet, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblIndit, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblStatusz, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.cbxUgytorzsbe, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 598)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.36585!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.63415!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(492, 116)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'btnKeszit
        '
        Me.btnKeszit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeszit.Location = New System.Drawing.Point(208, 75)
        Me.btnKeszit.Name = "btnKeszit"
        Me.btnKeszit.Size = New System.Drawing.Size(75, 30)
        Me.btnKeszit.TabIndex = 0
        Me.btnKeszit.Text = "Indít"
        Me.btnKeszit.UseVisualStyleBackColor = True
        '
        'btnElvet
        '
        Me.btnElvet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnElvet.Location = New System.Drawing.Point(372, 75)
        Me.btnElvet.Name = "btnElvet"
        Me.btnElvet.Size = New System.Drawing.Size(75, 30)
        Me.btnElvet.TabIndex = 1
        Me.btnElvet.Text = "Elvet"
        Me.btnElvet.UseVisualStyleBackColor = True
        '
        'lblIndit
        '
        Me.lblIndit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIndit.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.lblIndit, 2)
        Me.lblIndit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblIndit.Location = New System.Drawing.Point(3, 48)
        Me.lblIndit.Margin = New System.Windows.Forms.Padding(3)
        Me.lblIndit.Name = "lblIndit"
        Me.lblIndit.Size = New System.Drawing.Size(195, 13)
        Me.lblIndit.TabIndex = 0
        Me.lblIndit.Text = "E-akták és KR csomag készítése"
        '
        'lblStatusz
        '
        Me.lblStatusz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatusz.AutoSize = True
        Me.lblStatusz.Location = New System.Drawing.Point(331, 51)
        Me.lblStatusz.Name = "lblStatusz"
        Me.lblStatusz.Size = New System.Drawing.Size(0, 13)
        Me.lblStatusz.TabIndex = 3
        '
        'cbxUgytorzsbe
        '
        Me.cbxUgytorzsbe.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.cbxUgytorzsbe, 2)
        Me.cbxUgytorzsbe.Location = New System.Drawing.Point(3, 3)
        Me.cbxUgytorzsbe.Name = "cbxUgytorzsbe"
        Me.cbxUgytorzsbe.Size = New System.Drawing.Size(251, 17)
        Me.cbxUgytorzsbe.TabIndex = 7
        Me.cbxUgytorzsbe.Text = "Elmentse a beadvány adatait új ügy adataként?"
        Me.cbxUgytorzsbe.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel4, 2)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 297.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cbZipped, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbSajatTitkosito, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblZipFajlNev, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tbZipFajlnev, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbxZipTorles, 2, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 547)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(990, 45)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'cbZipped
        '
        Me.cbZipped.AutoSize = True
        Me.cbZipped.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbZipped.Checked = True
        Me.cbZipped.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbZipped.Location = New System.Drawing.Point(260, 3)
        Me.cbZipped.Name = "cbZipped"
        Me.TableLayoutPanel4.SetRowSpan(Me.cbZipped, 2)
        Me.cbZipped.Size = New System.Drawing.Size(291, 30)
        Me.cbZipped.TabIndex = 1
        Me.cbZipped.Text = "Bezippelve tegyem le együtt a fájlokat a célkönyvtárba (XML+ES3+KR)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " és a KR kiv" &
    "ételével töröljem a bezippelteket?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.cbZipped, "Készítsek ")
        Me.cbZipped.UseVisualStyleBackColor = True
        '
        'cbSajatTitkosito
        '
        Me.cbSajatTitkosito.AutoSize = True
        Me.cbSajatTitkosito.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbSajatTitkosito.Checked = True
        Me.cbSajatTitkosito.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSajatTitkosito.Location = New System.Drawing.Point(3, 3)
        Me.cbSajatTitkosito.Name = "cbSajatTitkosito"
        Me.TableLayoutPanel4.SetRowSpan(Me.cbSajatTitkosito, 2)
        Me.cbSajatTitkosito.Size = New System.Drawing.Size(208, 30)
        Me.cbSajatTitkosito.TabIndex = 0
        Me.cbSajatTitkosito.Text = "Saját titkosító kulcs hozzáadása?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(beküldött irat saját kicsomagolásához)"
        Me.ToolTip1.SetToolTip(Me.cbSajatTitkosito, resources.GetString("cbSajatTitkosito.ToolTip"))
        Me.cbSajatTitkosito.UseVisualStyleBackColor = True
        '
        'lblZipFajlNev
        '
        Me.lblZipFajlNev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblZipFajlNev.AutoSize = True
        Me.lblZipFajlNev.Location = New System.Drawing.Point(576, 3)
        Me.lblZipFajlNev.Margin = New System.Windows.Forms.Padding(3)
        Me.lblZipFajlNev.Name = "lblZipFajlNev"
        Me.lblZipFajlNev.Size = New System.Drawing.Size(74, 13)
        Me.lblZipFajlNev.TabIndex = 4
        Me.lblZipFajlNev.Text = "Zip fájlt hova?"
        Me.ToolTip1.SetToolTip(Me.lblZipFajlNev, "Kattintson ide, ha máshova mentse el a program a zip fájlt")
        '
        'tbZipFajlnev
        '
        Me.tbZipFajlnev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbZipFajlnev.Location = New System.Drawing.Point(656, 3)
        Me.tbZipFajlnev.Name = "tbZipFajlnev"
        Me.tbZipFajlnev.Size = New System.Drawing.Size(331, 20)
        Me.tbZipFajlnev.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbZipFajlnev, "Melyik könyvtárba fűzzem le a lefűzendő fájlokat (XML, ES3 és KR fájlokat) együtt" &
        " tartalmazó zip fájlt? A fájl neve azonos lesz a KR csomag nevével, csak a kiter" &
        "jesztése lesz ZIP.")
        '
        'cbxZipTorles
        '
        Me.cbxZipTorles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxZipTorles.AutoSize = True
        Me.cbxZipTorles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TableLayoutPanel4.SetColumnSpan(Me.cbxZipTorles, 2)
        Me.cbxZipTorles.Location = New System.Drawing.Point(557, 25)
        Me.cbxZipTorles.Name = "cbxZipTorles"
        Me.cbxZipTorles.Size = New System.Drawing.Size(275, 17)
        Me.cbxZipTorles.TabIndex = 5
        Me.cbxZipTorles.Text = "A zip fájlba mentett fájlokat (KR kivételével) töröljem?"
        Me.ToolTip1.SetToolTip(Me.cbxZipTorles, "A kényelmesebb használat érdekében a ZIP-be egyébként is lefűzött fájlokat javaso" &
        "ljuk törölni. A KR fájlt nem fogja törölni annak ellenére, hogy a zipben szerepe" &
        "l, mert azt be kell még küldeni")
        Me.cbxZipTorles.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.btnDown, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.btnTorol, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.btnUp, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnTallozCsatolmany, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.btnCsatNyit, 1, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(501, 324)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.83721!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.02325!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(492, 217)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'btnDown
        '
        Me.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDown.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(3, 165)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(22, 22)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "↓"
        Me.ToolTip1.SetToolTip(Me.btnDown, "Ezzel változtathatja a csatolmányok sorrendjét")
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnTorol
        '
        Me.btnTorol.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTorol.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTorol.Location = New System.Drawing.Point(3, 103)
        Me.btnTorol.Name = "btnTorol"
        Me.btnTorol.Size = New System.Drawing.Size(22, 22)
        Me.btnTorol.TabIndex = 1
        Me.btnTorol.Text = "╳"
        Me.ToolTip1.SetToolTip(Me.btnTorol, "Törli a csatolmányt a leendő csatolmányaktából (az eredeti fájl nem lesz törölve!" &
        ")")
        Me.btnTorol.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnUp.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(3, 19)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(22, 22)
        Me.btnUp.TabIndex = 0
        Me.btnUp.Text = "↑"
        Me.ToolTip1.SetToolTip(Me.btnUp, "Ezzel változtathatja a csatolmányok sorrendjét")
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnTallozCsatolmany
        '
        Me.btnTallozCsatolmany.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTallozCsatolmany.AutoSize = True
        Me.btnTallozCsatolmany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTallozCsatolmany.Location = New System.Drawing.Point(31, 102)
        Me.btnTallozCsatolmany.Name = "btnTallozCsatolmany"
        Me.btnTallozCsatolmany.Size = New System.Drawing.Size(127, 23)
        Me.btnTallozCsatolmany.TabIndex = 3
        Me.btnTallozCsatolmany.Text = "Csatolmányok tallózása"
        Me.btnTallozCsatolmany.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel5.SetColumnSpan(Me.TableLayoutPanel6, 2)
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48936!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51064!))
        Me.TableLayoutPanel6.Controls.Add(Me.tbLegnagyobbCsatolmanyMerete, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lblOsszes, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblLegnagyobb, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tbOsszesCsatolmanyMerete, 1, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(28, 136)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(470, 81)
        Me.TableLayoutPanel6.TabIndex = 13
        '
        'tbLegnagyobbCsatolmanyMerete
        '
        Me.tbLegnagyobbCsatolmanyMerete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbLegnagyobbCsatolmanyMerete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLegnagyobbCsatolmanyMerete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbLegnagyobbCsatolmanyMerete.Location = New System.Drawing.Point(194, 0)
        Me.tbLegnagyobbCsatolmanyMerete.Margin = New System.Windows.Forms.Padding(0)
        Me.tbLegnagyobbCsatolmanyMerete.Name = "tbLegnagyobbCsatolmanyMerete"
        Me.tbLegnagyobbCsatolmanyMerete.ReadOnly = True
        Me.tbLegnagyobbCsatolmanyMerete.Size = New System.Drawing.Size(276, 13)
        Me.tbLegnagyobbCsatolmanyMerete.TabIndex = 12
        '
        'lblOsszes
        '
        Me.lblOsszes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOsszes.AutoSize = True
        Me.lblOsszes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblOsszes.Location = New System.Drawing.Point(62, 40)
        Me.lblOsszes.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOsszes.Name = "lblOsszes"
        Me.lblOsszes.Size = New System.Drawing.Size(132, 13)
        Me.lblOsszes.TabIndex = 9
        Me.lblOsszes.Text = "Összes csatolmány mérete"
        '
        'lblLegnagyobb
        '
        Me.lblLegnagyobb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLegnagyobb.AutoSize = True
        Me.lblLegnagyobb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblLegnagyobb.Location = New System.Drawing.Point(37, 0)
        Me.lblLegnagyobb.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLegnagyobb.Name = "lblLegnagyobb"
        Me.lblLegnagyobb.Size = New System.Drawing.Size(157, 13)
        Me.lblLegnagyobb.TabIndex = 10
        Me.lblLegnagyobb.Text = "Legnagyobb csatolmány mérete"
        '
        'tbOsszesCsatolmanyMerete
        '
        Me.tbOsszesCsatolmanyMerete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbOsszesCsatolmanyMerete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbOsszesCsatolmanyMerete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbOsszesCsatolmanyMerete.Location = New System.Drawing.Point(194, 40)
        Me.tbOsszesCsatolmanyMerete.Margin = New System.Windows.Forms.Padding(0)
        Me.tbOsszesCsatolmanyMerete.Name = "tbOsszesCsatolmanyMerete"
        Me.tbOsszesCsatolmanyMerete.ReadOnly = True
        Me.tbOsszesCsatolmanyMerete.Size = New System.Drawing.Size(276, 13)
        Me.tbOsszesCsatolmanyMerete.TabIndex = 11
        '
        'btnCsatNyit
        '
        Me.btnCsatNyit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCsatNyit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCsatNyit.Location = New System.Drawing.Point(31, 65)
        Me.btnCsatNyit.Name = "btnCsatNyit"
        Me.btnCsatNyit.Size = New System.Drawing.Size(150, 22)
        Me.btnCsatNyit.TabIndex = 14
        Me.btnCsatNyit.Text = "Kijelölt csatolmányba betekintés"
        Me.btnCsatNyit.UseVisualStyleBackColor = True
        '
        'lvCsatolmanyok
        '
        Me.lvCsatolmanyok.AllowDrop = True
        Me.lvCsatolmanyok.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvCsatolmanyNeve, Me.lvMeret, Me.lvValodiMeret})
        Me.lvCsatolmanyok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCsatolmanyok.FullRowSelect = True
        Me.lvCsatolmanyok.Location = New System.Drawing.Point(3, 324)
        Me.lvCsatolmanyok.Name = "lvCsatolmanyok"
        Me.lvCsatolmanyok.Size = New System.Drawing.Size(492, 217)
        Me.lvCsatolmanyok.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lvCsatolmanyok, resources.GetString("lvCsatolmanyok.ToolTip"))
        Me.lvCsatolmanyok.UseCompatibleStateImageBehavior = False
        Me.lvCsatolmanyok.View = System.Windows.Forms.View.Details
        '
        'lvCsatolmanyNeve
        '
        Me.lvCsatolmanyNeve.Text = "Fájlnév"
        Me.lvCsatolmanyNeve.Width = 344
        '
        'lvMeret
        '
        Me.lvMeret.Text = "Méret"
        Me.lvMeret.Width = 149
        '
        'lvValodiMeret
        '
        Me.lvValodiMeret.Text = "Byte"
        Me.lvValodiMeret.Width = 0
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel7, 2)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.4689!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.32536!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.20574!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label5, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label6, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.Label8, 1, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.tbXMLPath, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.tbES3NyomiLenyomiPath, 2, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.tbES3CsatolmanyPath, 2, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.tbKRboritekNeve, 2, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.btnLefuzesiMappakTallózó, 3, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.btnLefuzes, 3, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 169)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 4
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(990, 149)
        Me.TableLayoutPanel7.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Hova és milyen néven fűzzem le az alábbi elkészült fájlokat?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "XML"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(241, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ES3 nyomtatványlenyomat akta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(241, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ES3 csatolmányakta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(241, 114)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "KR borítékcsomag"
        '
        'tbXMLPath
        '
        Me.tbXMLPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbXMLPath.Location = New System.Drawing.Point(436, 3)
        Me.tbXMLPath.Name = "tbXMLPath"
        Me.tbXMLPath.Size = New System.Drawing.Size(397, 20)
        Me.tbXMLPath.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbXMLPath, "Az XML a végleges (ÁNYK-val nem módosítható), géppel olvasható, de még nem titkos" &
        "ított nyomtatványokat jelenti")
        '
        'tbES3NyomiLenyomiPath
        '
        Me.tbES3NyomiLenyomiPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbES3NyomiLenyomiPath.Location = New System.Drawing.Point(436, 40)
        Me.tbES3NyomiLenyomiPath.Name = "tbES3NyomiLenyomiPath"
        Me.tbES3NyomiLenyomiPath.Size = New System.Drawing.Size(397, 20)
        Me.tbES3NyomiLenyomiPath.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tbES3NyomiLenyomiPath, "A Pp. szerint a beküldéshez nem csak a csatolmányt, magát a nyomtatványt is hitel" &
        "esíteni kell. Ez lesz a nyomtatvány lenyomat akta")
        '
        'tbES3CsatolmanyPath
        '
        Me.tbES3CsatolmanyPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbES3CsatolmanyPath.Location = New System.Drawing.Point(436, 77)
        Me.tbES3CsatolmanyPath.Name = "tbES3CsatolmanyPath"
        Me.tbES3CsatolmanyPath.Size = New System.Drawing.Size(397, 20)
        Me.tbES3CsatolmanyPath.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbES3CsatolmanyPath, "Ebben szerepelnek majd az alábbi ablakba behúzott csatolmányok, egy ES3 e-aktába " &
        "csomagolva és aláírva")
        '
        'tbKRboritekNeve
        '
        Me.tbKRboritekNeve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbKRboritekNeve.Location = New System.Drawing.Point(436, 114)
        Me.tbKRboritekNeve.Name = "tbKRboritekNeve"
        Me.tbKRboritekNeve.Size = New System.Drawing.Size(397, 20)
        Me.tbKRboritekNeve.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbKRboritekNeve, "A KR borítékcsomag a bírósági beküldésre alkalmas, a címzést és a titkosított tar" &
        "talmat is magába foglaló csomag")
        '
        'btnLefuzesiMappakTallózó
        '
        Me.btnLefuzesiMappakTallózó.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLefuzesiMappakTallózó.Location = New System.Drawing.Point(875, 81)
        Me.btnLefuzesiMappakTallózó.Name = "btnLefuzesiMappakTallózó"
        Me.btnLefuzesiMappakTallózó.Size = New System.Drawing.Size(75, 23)
        Me.btnLefuzesiMappakTallózó.TabIndex = 5
        Me.btnLefuzesiMappakTallózó.Text = "Tallóz"
        Me.btnLefuzesiMappakTallózó.UseVisualStyleBackColor = True
        '
        'btnLefuzes
        '
        Me.btnLefuzes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLefuzes.AutoSize = True
        Me.btnLefuzes.Location = New System.Drawing.Point(867, 44)
        Me.btnLefuzes.Name = "btnLefuzes"
        Me.btnLefuzes.Size = New System.Drawing.Size(91, 23)
        Me.btnLefuzes.TabIndex = 4
        Me.btnLefuzes.Text = "Lefűzési mappa"
        Me.btnLefuzes.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.25852!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.84369!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.89779!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbUgyszam, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnANYKmentesibol, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNyomiLefuzesibol, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNyomiXMLmegnyitasibol, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tbNyomtatvanyNeve, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbCimzettSzervNeve, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tbUgyszam, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tbUtolsoMentes, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tbFelperes, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tbAlperes, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxEperHelper, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(501, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(492, 160)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(145, 2)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nyomtatvány neve"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(145, 21)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Címzett szerv"
        Me.ToolTip1.SetToolTip(Me.Label11, "OBHGEPI esetén a címzett bíróság")
        '
        'lbUgyszam
        '
        Me.lbUgyszam.AutoSize = True
        Me.lbUgyszam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbUgyszam.Location = New System.Drawing.Point(145, 50)
        Me.lbUgyszam.Margin = New System.Windows.Forms.Padding(2)
        Me.lbUgyszam.Name = "lbUgyszam"
        Me.lbUgyszam.Size = New System.Drawing.Size(50, 13)
        Me.lbUgyszam.TabIndex = 3
        Me.lbUgyszam.Text = "Ügyszám"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(145, 79)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Keltezése"
        '
        'btnANYKmentesibol
        '
        Me.btnANYKmentesibol.AutoSize = True
        Me.btnANYKmentesibol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnANYKmentesibol.Location = New System.Drawing.Point(3, 22)
        Me.btnANYKmentesibol.Name = "btnANYKmentesibol"
        Me.btnANYKmentesibol.Size = New System.Drawing.Size(97, 23)
        Me.btnANYKmentesibol.TabIndex = 0
        Me.btnANYKmentesibol.Text = "ÁNYK mentésből"
        Me.ToolTip1.SetToolTip(Me.btnANYKmentesibol, "Az ÁNYK mentési mappából listázza a program a beküldhető nyomtatványokat")
        Me.btnANYKmentesibol.UseVisualStyleBackColor = True
        '
        'btnNyomiLefuzesibol
        '
        Me.btnNyomiLefuzesibol.AutoSize = True
        Me.btnNyomiLefuzesibol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNyomiLefuzesibol.Location = New System.Drawing.Point(3, 51)
        Me.btnNyomiLefuzesibol.Name = "btnNyomiLefuzesibol"
        Me.btnNyomiLefuzesibol.Size = New System.Drawing.Size(68, 23)
        Me.btnNyomiLefuzesibol.TabIndex = 1
        Me.btnNyomiLefuzesibol.Text = "Lefűzésből"
        Me.ToolTip1.SetToolTip(Me.btnNyomiLefuzesibol, "A mappák beállítása menüpontban alapértelmezett lefűzésre kijelölt mappából listá" &
        "zza a program a beküldhető nyomtatványokat")
        Me.btnNyomiLefuzesibol.UseVisualStyleBackColor = True
        '
        'btnNyomiXMLmegnyitasibol
        '
        Me.btnNyomiXMLmegnyitasibol.AutoSize = True
        Me.btnNyomiXMLmegnyitasibol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNyomiXMLmegnyitasibol.Location = New System.Drawing.Point(3, 80)
        Me.btnNyomiXMLmegnyitasibol.Name = "btnNyomiXMLmegnyitasibol"
        Me.btnNyomiXMLmegnyitasibol.Size = New System.Drawing.Size(105, 23)
        Me.btnNyomiXMLmegnyitasibol.TabIndex = 2
        Me.btnNyomiXMLmegnyitasibol.Text = "XML megnyitásiból"
        Me.ToolTip1.SetToolTip(Me.btnNyomiXMLmegnyitasibol, "A mappák beállítása során az alapértelmezett XML megnyitási mappából listázza a p" &
        "rogram a beküldhető nyomtatványokat")
        Me.btnNyomiXMLmegnyitasibol.UseVisualStyleBackColor = True
        '
        'tbNyomtatvanyNeve
        '
        Me.tbNyomtatvanyNeve.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNyomtatvanyNeve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNyomtatvanyNeve.Location = New System.Drawing.Point(253, 3)
        Me.tbNyomtatvanyNeve.Name = "tbNyomtatvanyNeve"
        Me.tbNyomtatvanyNeve.ReadOnly = True
        Me.tbNyomtatvanyNeve.Size = New System.Drawing.Size(236, 13)
        Me.tbNyomtatvanyNeve.TabIndex = 9
        '
        'tbCimzettSzervNeve
        '
        Me.tbCimzettSzervNeve.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCimzettSzervNeve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCimzettSzervNeve.Location = New System.Drawing.Point(253, 22)
        Me.tbCimzettSzervNeve.Name = "tbCimzettSzervNeve"
        Me.tbCimzettSzervNeve.ReadOnly = True
        Me.tbCimzettSzervNeve.Size = New System.Drawing.Size(236, 13)
        Me.tbCimzettSzervNeve.TabIndex = 10
        '
        'tbUgyszam
        '
        Me.tbUgyszam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUgyszam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbUgyszam.Location = New System.Drawing.Point(253, 51)
        Me.tbUgyszam.Name = "tbUgyszam"
        Me.tbUgyszam.ReadOnly = True
        Me.tbUgyszam.Size = New System.Drawing.Size(236, 13)
        Me.tbUgyszam.TabIndex = 11
        '
        'tbUtolsoMentes
        '
        Me.tbUtolsoMentes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUtolsoMentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbUtolsoMentes.Location = New System.Drawing.Point(253, 80)
        Me.tbUtolsoMentes.Name = "tbUtolsoMentes"
        Me.tbUtolsoMentes.ReadOnly = True
        Me.tbUtolsoMentes.Size = New System.Drawing.Size(236, 13)
        Me.tbUtolsoMentes.TabIndex = 12
        '
        'tbFelperes
        '
        Me.tbFelperes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbFelperes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbFelperes.Location = New System.Drawing.Point(253, 109)
        Me.tbFelperes.Name = "tbFelperes"
        Me.tbFelperes.ReadOnly = True
        Me.tbFelperes.Size = New System.Drawing.Size(236, 13)
        Me.tbFelperes.TabIndex = 13
        '
        'tbAlperes
        '
        Me.tbAlperes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAlperes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbAlperes.Location = New System.Drawing.Point(253, 128)
        Me.tbAlperes.Name = "tbAlperes"
        Me.tbAlperes.ReadOnly = True
        Me.tbAlperes.Size = New System.Drawing.Size(236, 13)
        Me.tbAlperes.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Felp. v. kérelmező"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Alperes"
        '
        'cbxEperHelper
        '
        Me.cbxEperHelper.AutoSize = True
        Me.cbxEperHelper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxEperHelper.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.cbxEperHelper.Location = New System.Drawing.Point(3, 109)
        Me.cbxEperHelper.Name = "cbxEperHelper"
        Me.TableLayoutPanel2.SetRowSpan(Me.cbxEperHelper, 2)
        Me.cbxEperHelper.Size = New System.Drawing.Size(137, 48)
        Me.cbxEperHelper.TabIndex = 17
        Me.cbxEperHelper.Text = "Csak az e programmal készülteket mutassa?"
        Me.cbxEperHelper.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnNyomtatvanyTalloz, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.tbDirectoryNyomtatvanyok, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lvNyomiLista, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.18987!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.81013!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(492, 160)
        Me.TableLayoutPanel8.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Nyomtatvány kiválasztása"
        Me.ToolTip1.SetToolTip(Me.Label9, "Válassza ki a becsomagolni kívánt nyomtatványt! Az alábbi listában először a legf" &
        "rissebben elkészült nyomtatványok szerepelnek")
        '
        'btnNyomtatvanyTalloz
        '
        Me.btnNyomtatvanyTalloz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNyomtatvanyTalloz.Location = New System.Drawing.Point(415, 2)
        Me.btnNyomtatvanyTalloz.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNyomtatvanyTalloz.Name = "btnNyomtatvanyTalloz"
        Me.btnNyomtatvanyTalloz.Size = New System.Drawing.Size(75, 20)
        Me.btnNyomtatvanyTalloz.TabIndex = 0
        Me.btnNyomtatvanyTalloz.Text = "Tallóz"
        Me.ToolTip1.SetToolTip(Me.btnNyomtatvanyTalloz, "Válassza ki, hogy mely könyvtárból keresse a program a KR-be becsomagolható kíván" &
        "t nyomtatvány (ENYK vagy XML) fájlokat")
        Me.btnNyomtatvanyTalloz.UseVisualStyleBackColor = True
        '
        'tbDirectoryNyomtatvanyok
        '
        Me.tbDirectoryNyomtatvanyok.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbDirectoryNyomtatvanyok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDirectoryNyomtatvanyok.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbDirectoryNyomtatvanyok.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tbDirectoryNyomtatvanyok.Location = New System.Drawing.Point(139, 3)
        Me.tbDirectoryNyomtatvanyok.Name = "tbDirectoryNyomtatvanyok"
        Me.tbDirectoryNyomtatvanyok.ReadOnly = True
        Me.tbDirectoryNyomtatvanyok.Size = New System.Drawing.Size(234, 11)
        Me.tbDirectoryNyomtatvanyok.TabIndex = 14
        Me.tbDirectoryNyomtatvanyok.Text = "Inaktív"
        '
        'lvNyomiLista
        '
        Me.lvNyomiLista.AllowColumnReorder = True
        Me.lvNyomiLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvEperHelper, Me.lvNyomiListaName, Me.lvXmlNev, Me.lvNyomiListaLastWritten})
        Me.TableLayoutPanel8.SetColumnSpan(Me.lvNyomiLista, 3)
        Me.lvNyomiLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNyomiLista.FullRowSelect = True
        Me.lvNyomiLista.Location = New System.Drawing.Point(3, 27)
        Me.lvNyomiLista.MultiSelect = False
        Me.lvNyomiLista.Name = "lvNyomiLista"
        Me.lvNyomiLista.Size = New System.Drawing.Size(486, 130)
        Me.lvNyomiLista.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.lvNyomiLista, "Prg = a nyomtatvány ebben a programban készült-e. Megnevezés=Ha kitöltéskor a nyo" &
        "mtatványnak egy nevet adott, itt láthatja azt a nevet")
        Me.lvNyomiLista.UseCompatibleStateImageBehavior = False
        Me.lvNyomiLista.View = System.Windows.Forms.View.Details
        '
        'lvEperHelper
        '
        Me.lvEperHelper.Text = "Prg"
        Me.lvEperHelper.Width = 30
        '
        'lvNyomiListaName
        '
        Me.lvNyomiListaName.Text = "Fájlneve"
        Me.lvNyomiListaName.Width = 215
        '
        'lvXmlNev
        '
        Me.lvXmlNev.Text = "Megnevezés"
        Me.lvXmlNev.Width = 107
        '
        'lvNyomiListaLastWritten
        '
        Me.lvNyomiListaLastWritten.Text = "Utoljára módosítva"
        Me.lvNyomiListaLastWritten.Width = 135
        '
        'NyomiListaFeldolgTableAdapter
        '
        Me.NyomiListaFeldolgTableAdapter.ClearBeforeFill = True
        '
        'NyomtatvanyAdatokDataSet1
        '
        Me.NyomtatvanyAdatokDataSet1.DataSetName = "NyomtatvanyAdatokDataSet"
        Me.NyomtatvanyAdatokDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CsomagKeszito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 717)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1012, 756)
        Me.Name = "CsomagKeszito"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KR csomag készítése"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblElkeszultKR_csomag.ResumeLayout(False)
        Me.tblElkeszultKR_csomag.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.NyomtatvanyAdatokDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tblElkeszultKR_csomag As TableLayoutPanel
    Friend WithEvents btnUKPFeltoltes As Button
    Friend WithEvents btnPKPFeltoltes As Button
    Friend WithEvents btnHKPFeltoltes As Button
    Friend WithEvents lblStatusz As Label
    Friend WithEvents btnKeszit As Button
    Friend WithEvents btnElvet As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents cbZipped As CheckBox
    Friend WithEvents cbSajatTitkosito As CheckBox
    Friend WithEvents tbZipFajlnev As TextBox
    Friend WithEvents lblZipFajlNev As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnDown As Button
    Friend WithEvents btnTorol As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnTallozCsatolmany As Button
    Friend WithEvents lblOsszes As Label
    Friend WithEvents lblLegnagyobb As Label
    Friend WithEvents tbOsszesCsatolmanyMerete As TextBox
    Friend WithEvents tbLegnagyobbCsatolmanyMerete As TextBox
    Friend WithEvents lvCsatolmanyok As ListView
    Friend WithEvents lvCsatolmanyNeve As ColumnHeader
    Friend WithEvents lvMeret As ColumnHeader
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbXMLPath As TextBox
    Friend WithEvents tbES3NyomiLenyomiPath As TextBox
    Friend WithEvents tbES3CsatolmanyPath As TextBox
    Friend WithEvents tbKRboritekNeve As TextBox
    Friend WithEvents btnLefuzes As Button
    Friend WithEvents btnLefuzesiMappakTallózó As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbUgyszam As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnANYKmentesibol As Button
    Friend WithEvents btnNyomiLefuzesibol As Button
    Friend WithEvents btnNyomiXMLmegnyitasibol As Button
    Friend WithEvents tbNyomtatvanyNeve As TextBox
    Friend WithEvents tbCimzettSzervNeve As TextBox
    Friend WithEvents tbUgyszam As TextBox
    Friend WithEvents tbUtolsoMentes As TextBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNyomtatvanyTalloz As Button
    Friend WithEvents lvValodiMeret As ColumnHeader
    Friend WithEvents tbDirectoryNyomtatvanyok As TextBox
    Friend WithEvents NyomtatvanyAdatokDataSet1 As NyomtatvanyAdatokDataSet
    Friend WithEvents tbFelperes As TextBox
    Friend WithEvents NyomiListaFeldolgTableAdapter As NyomtatvanyAdatokDataSetTableAdapters.NyomiListaFeldolgTableAdapter
    Friend WithEvents btnUKPANYKWSfeltoltes As Button
    Friend WithEvents btnPKPANYKWSfeltoltes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lvNyomiLista As ListView
    Friend WithEvents lvNyomiListaName As ColumnHeader
    Friend WithEvents lvNyomiListaLastWritten As ColumnHeader
    Friend WithEvents lvEperHelper As ColumnHeader
    Friend WithEvents lvXmlNev As ColumnHeader
    Friend WithEvents cbxZipTorles As CheckBox
    Friend WithEvents cbxUgytorzsbe As CheckBox
    Friend WithEvents lblIndit As Label
    Friend WithEvents tbAlperes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxEperHelper As CheckBox
    Friend WithEvents btnKapuAdatMegadasa As Button
    Friend WithEvents btnCsatNyit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
