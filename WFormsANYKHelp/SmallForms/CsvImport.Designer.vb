<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CsvImport
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbCSVneve = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgBetekinto = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMegnyit = New System.Windows.Forms.Button()
        Me.btnTallóz = New System.Windows.Forms.Button()
        Me.btnKilép = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TorzsAdatbazisDataSet = New homoki.eperhelper.TorzsAdatbazisDataSet()
        Me.Ceg_rogzitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ceg_rogzitoTableAdapter = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.Ceg_rogzitoTableAdapter()
        Me.TableAdapterManager = New homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.TableAdapterManager()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgBetekinto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ceg_rogzitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.tbCSVneve, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgBetekinto, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLoad, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMegnyit, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTallóz, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnKilép, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(791, 307)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tbCSVneve
        '
        Me.tbCSVneve.Location = New System.Drawing.Point(3, 22)
        Me.tbCSVneve.MinimumSize = New System.Drawing.Size(200, 23)
        Me.tbCSVneve.Name = "tbCSVneve"
        Me.tbCSVneve.ReadOnly = True
        Me.tbCSVneve.Size = New System.Drawing.Size(200, 20)
        Me.tbCSVneve.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Betölteni kívánt CSV fájl"
        '
        'dgBetekinto
        '
        Me.dgBetekinto.AllowUserToAddRows = False
        Me.dgBetekinto.AllowUserToDeleteRows = False
        Me.dgBetekinto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgBetekinto, 2)
        Me.dgBetekinto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBetekinto.Location = New System.Drawing.Point(3, 122)
        Me.dgBetekinto.Name = "dgBetekinto"
        Me.dgBetekinto.ReadOnly = True
        Me.dgBetekinto.Size = New System.Drawing.Size(785, 150)
        Me.dgBetekinto.TabIndex = 4
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLoad.Location = New System.Drawing.Point(65, 279)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Betölt"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 65)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Használandó beállítások:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- UTF-8 kódolás" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- minta menüpontban megadott fájlnevek" &
    " és fejlécek első sorban" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- """" elválasztójel mezők között" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- pontosvessző (;) el" &
    "választás a mezők között"
        '
        'btnMegnyit
        '
        Me.btnMegnyit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMegnyit.AutoSize = True
        Me.btnMegnyit.Location = New System.Drawing.Point(88, 51)
        Me.btnMegnyit.Name = "btnMegnyit"
        Me.btnMegnyit.Size = New System.Drawing.Size(115, 23)
        Me.btnMegnyit.TabIndex = 2
        Me.btnMegnyit.Text = "Megnyit betekintésre"
        Me.btnMegnyit.UseVisualStyleBackColor = True
        '
        'btnTallóz
        '
        Me.btnTallóz.Location = New System.Drawing.Point(209, 22)
        Me.btnTallóz.Name = "btnTallóz"
        Me.btnTallóz.Size = New System.Drawing.Size(75, 23)
        Me.btnTallóz.TabIndex = 7
        Me.btnTallóz.Text = "Tallóz"
        Me.btnTallóz.UseVisualStyleBackColor = True
        '
        'btnKilép
        '
        Me.btnKilép.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnKilép.Location = New System.Drawing.Point(713, 279)
        Me.btnKilép.Name = "btnKilép"
        Me.btnKilép.Size = New System.Drawing.Size(75, 23)
        Me.btnKilép.TabIndex = 8
        Me.btnKilép.Text = "Kilép"
        Me.btnKilép.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TorzsAdatbazisDataSet
        '
        Me.TorzsAdatbazisDataSet.DataSetName = "TorzsAdatbazisDataSet"
        Me.TorzsAdatbazisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ceg_rogzitoBindingSource
        '
        Me.Ceg_rogzitoBindingSource.DataMember = "Ceg_rogzito"
        Me.Ceg_rogzitoBindingSource.DataSource = Me.TorzsAdatbazisDataSet
        '
        'Ceg_rogzitoTableAdapter
        '
        Me.Ceg_rogzitoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Ceg_rogzitoTableAdapter = Me.Ceg_rogzitoTableAdapter
        Me.TableAdapterManager.Egyeb_jogi_kvo_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Egyeb_szervezet_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Egyeni_ugyvedi_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.EV_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Jogtanacsos_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Term_szemely_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Ugytorzs_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.Ugyvedi_iroda_rogzitoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = homoki.eperhelper.TorzsAdatbazisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CsvImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(791, 307)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "CsvImport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "CSV fájl beolvasása meglévő törzsadatbázisba"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgBetekinto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorzsAdatbazisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ceg_rogzitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbCSVneve As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMegnyit As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents dgBetekinto As DataGridView
    Friend WithEvents btnTallóz As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TorzsAdatbazisDataSet As TorzsAdatbazisDataSet
    Friend WithEvents Ceg_rogzitoBindingSource As BindingSource
    Friend WithEvents Ceg_rogzitoTableAdapter As TorzsAdatbazisDataSetTableAdapters.Ceg_rogzitoTableAdapter
    Friend WithEvents TableAdapterManager As TorzsAdatbazisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnKilép As Button
End Class
