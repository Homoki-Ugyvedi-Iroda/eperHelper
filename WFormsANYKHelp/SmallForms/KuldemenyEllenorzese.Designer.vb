<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KuldemenyEllenorzese
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbPDFIgazolas = New System.Windows.Forms.TextBox()
        Me.btnTallozIgazolast = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCelFajl = New System.Windows.Forms.TextBox()
        Me.btnTallozCelfajlt = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnElvet = New System.Windows.Forms.Button()
        Me.btnEllenoriz = New System.Windows.Forms.Button()
        Me.mbLenyomat = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.tbPDFIgazolas, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTallozIgazolast, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCelFajl, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTallozCelfajlt, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.mbLenyomat, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(495, 189)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tbPDFIgazolas
        '
        Me.tbPDFIgazolas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPDFIgazolas.Location = New System.Drawing.Point(3, 67)
        Me.tbPDFIgazolas.Name = "tbPDFIgazolas"
        Me.tbPDFIgazolas.ReadOnly = True
        Me.tbPDFIgazolas.Size = New System.Drawing.Size(400, 20)
        Me.tbPDFIgazolas.TabIndex = 5
        '
        'btnTallozIgazolast
        '
        Me.btnTallozIgazolast.Location = New System.Drawing.Point(409, 67)
        Me.btnTallozIgazolast.Name = "btnTallozIgazolast"
        Me.btnTallozIgazolast.Size = New System.Drawing.Size(75, 23)
        Me.btnTallozIgazolast.TabIndex = 6
        Me.btnTallozIgazolast.Text = "Tallóz"
        Me.btnTallozIgazolast.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ellenőrző lenyomat begépelése"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ellenőrző lenyomat beolvasása PDF igazolásból"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ellenőrzés tárgyát képező fájl"
        '
        'tbCelFajl
        '
        Me.tbCelFajl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCelFajl.Location = New System.Drawing.Point(3, 115)
        Me.tbCelFajl.Name = "tbCelFajl"
        Me.tbCelFajl.ReadOnly = True
        Me.tbCelFajl.Size = New System.Drawing.Size(400, 20)
        Me.tbCelFajl.TabIndex = 10
        '
        'btnTallozCelfajlt
        '
        Me.btnTallozCelfajlt.Location = New System.Drawing.Point(409, 115)
        Me.btnTallozCelfajlt.Name = "btnTallozCelfajlt"
        Me.btnTallozCelfajlt.Size = New System.Drawing.Size(75, 23)
        Me.btnTallozCelfajlt.TabIndex = 11
        Me.btnTallozCelfajlt.Text = "Tallóz"
        Me.btnTallozCelfajlt.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnElvet, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEllenoriz, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 144)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(400, 42)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'btnElvet
        '
        Me.btnElvet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnElvet.Location = New System.Drawing.Point(262, 9)
        Me.btnElvet.Name = "btnElvet"
        Me.btnElvet.Size = New System.Drawing.Size(75, 23)
        Me.btnElvet.TabIndex = 3
        Me.btnElvet.Text = "Elvet"
        Me.btnElvet.UseVisualStyleBackColor = True
        '
        'btnEllenoriz
        '
        Me.btnEllenoriz.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEllenoriz.Location = New System.Drawing.Point(62, 9)
        Me.btnEllenoriz.Name = "btnEllenoriz"
        Me.btnEllenoriz.Size = New System.Drawing.Size(75, 23)
        Me.btnEllenoriz.TabIndex = 2
        Me.btnEllenoriz.Text = "Ellenőriz"
        Me.btnEllenoriz.UseVisualStyleBackColor = True
        '
        'mbLenyomat
        '
        Me.mbLenyomat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mbLenyomat.Location = New System.Drawing.Point(3, 22)
        Me.mbLenyomat.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mbLenyomat.Name = "mbLenyomat"
        Me.mbLenyomat.Size = New System.Drawing.Size(400, 20)
        Me.mbLenyomat.TabIndex = 13
        Me.mbLenyomat.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'KuldemenyEllenorzese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(495, 189)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "KuldemenyEllenorzese"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Dokumentum lenyomatok ellenőrzése"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnEllenoriz As Button
    Friend WithEvents btnElvet As Button
    Friend WithEvents tbPDFIgazolas As TextBox
    Friend WithEvents btnTallozIgazolast As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCelFajl As TextBox
    Friend WithEvents btnTallozCelfajlt As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents mbLenyomat As MaskedTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
