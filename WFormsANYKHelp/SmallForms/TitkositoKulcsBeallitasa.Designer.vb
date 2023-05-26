<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TitkositoKulcsBeallitasa
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
        Me.tbNewKeyPairName = New System.Windows.Forms.TextBox()
        Me.tbNewKeyPairFolder = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDecryptPathNow = New System.Windows.Forms.Button()
        Me.tbDecryptPathNow = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbEncryptPathNow = New System.Windows.Forms.TextBox()
        Me.btnEncryptPathNow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNewKeyPairFolder = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnElvet = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCreateNewKeyPair = New System.Windows.Forms.Button()
        Me.btnTorlesKulcsok = New System.Windows.Forms.Button()
        Me.cbxAtvegyeANYKboltitkositot = New System.Windows.Forms.CheckBox()
        Me.mbDecryptPasswNow = New System.Windows.Forms.TextBox()
        Me.mbDecryptPasswNowConfirm = New System.Windows.Forms.TextBox()
        Me.mbDecryptPasswNew = New System.Windows.Forms.TextBox()
        Me.mbDecryptPasswNewConfirm = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbNewKeyPairName, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNewKeyPairFolder, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDecryptPathNow, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbDecryptPathNow, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbEncryptPathNow, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEncryptPathNow, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNewKeyPairFolder, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCreateNewKeyPair, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTorlesKulcsok, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxAtvegyeANYKboltitkositot, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.mbDecryptPasswNow, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.mbDecryptPasswNowConfirm, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.mbDecryptPasswNew, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.mbDecryptPasswNewConfirm, 1, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 385)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tbNewKeyPairName
        '
        Me.tbNewKeyPairName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNewKeyPairName.Location = New System.Drawing.Point(318, 190)
        Me.tbNewKeyPairName.MaxLength = 60
        Me.tbNewKeyPairName.MinimumSize = New System.Drawing.Size(330, 4)
        Me.tbNewKeyPairName.Name = "tbNewKeyPairName"
        Me.tbNewKeyPairName.Size = New System.Drawing.Size(330, 20)
        Me.tbNewKeyPairName.TabIndex = 7
        '
        'tbNewKeyPairFolder
        '
        Me.tbNewKeyPairFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNewKeyPairFolder.Location = New System.Drawing.Point(318, 216)
        Me.tbNewKeyPairFolder.MaxLength = 300
        Me.tbNewKeyPairFolder.MinimumSize = New System.Drawing.Size(330, 4)
        Me.tbNewKeyPairFolder.Name = "tbNewKeyPairFolder"
        Me.tbNewKeyPairFolder.Size = New System.Drawing.Size(330, 20)
        Me.tbNewKeyPairFolder.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kititkosításhoz használt (privát titkosító) kulcs jelszava"
        '
        'btnDecryptPathNow
        '
        Me.btnDecryptPathNow.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDecryptPathNow.Location = New System.Drawing.Point(670, 60)
        Me.btnDecryptPathNow.Margin = New System.Windows.Forms.Padding(20, 5, 15, 5)
        Me.btnDecryptPathNow.MaximumSize = New System.Drawing.Size(120, 25)
        Me.btnDecryptPathNow.MinimumSize = New System.Drawing.Size(120, 25)
        Me.btnDecryptPathNow.Name = "btnDecryptPathNow"
        Me.btnDecryptPathNow.Size = New System.Drawing.Size(120, 25)
        Me.btnDecryptPathNow.TabIndex = 3
        Me.btnDecryptPathNow.Text = "Tallóz"
        Me.btnDecryptPathNow.UseVisualStyleBackColor = True
        '
        'tbDecryptPathNow
        '
        Me.tbDecryptPathNow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDecryptPathNow.Location = New System.Drawing.Point(318, 58)
        Me.tbDecryptPathNow.MaxLength = 300
        Me.tbDecryptPathNow.MinimumSize = New System.Drawing.Size(330, 4)
        Me.tbDecryptPathNow.Name = "tbDecryptPathNow"
        Me.tbDecryptPathNow.ReadOnly = True
        Me.tbDecryptPathNow.Size = New System.Drawing.Size(330, 20)
        Me.tbDecryptPathNow.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kititkosításhoz használt (privát titkosító) kulcs elérhetősége"
        '
        'tbEncryptPathNow
        '
        Me.tbEncryptPathNow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbEncryptPathNow.Location = New System.Drawing.Point(318, 23)
        Me.tbEncryptPathNow.MaxLength = 300
        Me.tbEncryptPathNow.MinimumSize = New System.Drawing.Size(330, 4)
        Me.tbEncryptPathNow.Name = "tbEncryptPathNow"
        Me.tbEncryptPathNow.ReadOnly = True
        Me.tbEncryptPathNow.Size = New System.Drawing.Size(330, 20)
        Me.tbEncryptPathNow.TabIndex = 0
        '
        'btnEncryptPathNow
        '
        Me.btnEncryptPathNow.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEncryptPathNow.Location = New System.Drawing.Point(670, 25)
        Me.btnEncryptPathNow.Margin = New System.Windows.Forms.Padding(20, 5, 15, 5)
        Me.btnEncryptPathNow.MaximumSize = New System.Drawing.Size(120, 25)
        Me.btnEncryptPathNow.MinimumSize = New System.Drawing.Size(120, 25)
        Me.btnEncryptPathNow.Name = "btnEncryptPathNow"
        Me.btnEncryptPathNow.Size = New System.Drawing.Size(120, 25)
        Me.btnEncryptPathNow.TabIndex = 1
        Me.btnEncryptPathNow.Text = "Tallóz"
        Me.btnEncryptPathNow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Betitkosításhoz használt (publikus titkosító) kulcs elérhetősége"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Jelenlegi beállítások"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Új titkosító kulcspár létrehozása"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Új titkosító kulcspár mappája"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 251)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Új kititkosító kulcs jelszava"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 190)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Új titkosító kulcspár neve (_priv/pub.asc)"
        '
        'btnNewKeyPairFolder
        '
        Me.btnNewKeyPairFolder.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNewKeyPairFolder.Location = New System.Drawing.Point(670, 218)
        Me.btnNewKeyPairFolder.Margin = New System.Windows.Forms.Padding(20, 5, 15, 5)
        Me.btnNewKeyPairFolder.MaximumSize = New System.Drawing.Size(120, 25)
        Me.btnNewKeyPairFolder.MinimumSize = New System.Drawing.Size(120, 25)
        Me.btnNewKeyPairFolder.Name = "btnNewKeyPairFolder"
        Me.btnNewKeyPairFolder.Size = New System.Drawing.Size(120, 25)
        Me.btnNewKeyPairFolder.TabIndex = 9
        Me.btnNewKeyPairFolder.Text = "Tallóz"
        Me.btnNewKeyPairFolder.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(195, 125)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Erősítse meg a jelszót"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(195, 280)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Erősítse meg a jelszót"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.btnElvet)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(318, 332)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 50)
        Me.Panel1.TabIndex = 24
        '
        'btnElvet
        '
        Me.btnElvet.Location = New System.Drawing.Point(175, 18)
        Me.btnElvet.Name = "btnElvet"
        Me.btnElvet.Size = New System.Drawing.Size(75, 23)
        Me.btnElvet.TabIndex = 1
        Me.btnElvet.Text = "Elvet"
        Me.btnElvet.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(93, 18)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCreateNewKeyPair
        '
        Me.btnCreateNewKeyPair.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCreateNewKeyPair.Location = New System.Drawing.Point(73, 303)
        Me.btnCreateNewKeyPair.Name = "btnCreateNewKeyPair"
        Me.btnCreateNewKeyPair.Size = New System.Drawing.Size(169, 23)
        Me.btnCreateNewKeyPair.TabIndex = 12
        Me.btnCreateNewKeyPair.Text = "Új titkosító kulcspár létrehozása"
        Me.btnCreateNewKeyPair.UseVisualStyleBackColor = True
        '
        'btnTorlesKulcsok
        '
        Me.btnTorlesKulcsok.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnTorlesKulcsok.AutoSize = True
        Me.btnTorlesKulcsok.Location = New System.Drawing.Point(700, 93)
        Me.btnTorlesKulcsok.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.btnTorlesKulcsok.Name = "btnTorlesKulcsok"
        Me.btnTorlesKulcsok.Size = New System.Drawing.Size(89, 23)
        Me.btnTorlesKulcsok.TabIndex = 5
        Me.btnTorlesKulcsok.Text = "Kulcsok törlése"
        Me.btnTorlesKulcsok.UseVisualStyleBackColor = True
        '
        'cbxAtvegyeANYKboltitkositot
        '
        Me.cbxAtvegyeANYKboltitkositot.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbxAtvegyeANYKboltitkositot, 3)
        Me.cbxAtvegyeANYKboltitkositot.Location = New System.Drawing.Point(7, 148)
        Me.cbxAtvegyeANYKboltitkositot.Margin = New System.Windows.Forms.Padding(7, 3, 3, 3)
        Me.cbxAtvegyeANYKboltitkositot.Name = "cbxAtvegyeANYKboltitkositot"
        Me.cbxAtvegyeANYKboltitkositot.Size = New System.Drawing.Size(719, 17)
        Me.cbxAtvegyeANYKboltitkositot.TabIndex = 26
        Me.cbxAtvegyeANYKboltitkositot.Text = "Indításkor átvegye a program az ÁNYK-ból az ott beállított titkosító kulcsokat, h" &
    "a itt nincsen beállítva kulcs? (Megváltoztatása újraindítást igényel!)"
        Me.cbxAtvegyeANYKboltitkositot.UseVisualStyleBackColor = True
        '
        'mbDecryptPasswNow
        '
        Me.mbDecryptPasswNow.Location = New System.Drawing.Point(318, 93)
        Me.mbDecryptPasswNow.MaxLength = 40
        Me.mbDecryptPasswNow.Name = "mbDecryptPasswNow"
        Me.mbDecryptPasswNow.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mbDecryptPasswNow.Size = New System.Drawing.Size(250, 20)
        Me.mbDecryptPasswNow.TabIndex = 4
        Me.mbDecryptPasswNow.UseSystemPasswordChar = True
        '
        'mbDecryptPasswNowConfirm
        '
        Me.mbDecryptPasswNowConfirm.Location = New System.Drawing.Point(318, 122)
        Me.mbDecryptPasswNowConfirm.MaxLength = 40
        Me.mbDecryptPasswNowConfirm.Name = "mbDecryptPasswNowConfirm"
        Me.mbDecryptPasswNowConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mbDecryptPasswNowConfirm.Size = New System.Drawing.Size(250, 20)
        Me.mbDecryptPasswNowConfirm.TabIndex = 6
        Me.mbDecryptPasswNowConfirm.UseSystemPasswordChar = True
        '
        'mbDecryptPasswNew
        '
        Me.mbDecryptPasswNew.Location = New System.Drawing.Point(318, 251)
        Me.mbDecryptPasswNew.MaxLength = 40
        Me.mbDecryptPasswNew.Name = "mbDecryptPasswNew"
        Me.mbDecryptPasswNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mbDecryptPasswNew.Size = New System.Drawing.Size(250, 20)
        Me.mbDecryptPasswNew.TabIndex = 10
        Me.mbDecryptPasswNew.UseSystemPasswordChar = True
        '
        'mbDecryptPasswNewConfirm
        '
        Me.mbDecryptPasswNewConfirm.Location = New System.Drawing.Point(318, 277)
        Me.mbDecryptPasswNewConfirm.MaxLength = 40
        Me.mbDecryptPasswNewConfirm.Name = "mbDecryptPasswNewConfirm"
        Me.mbDecryptPasswNewConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mbDecryptPasswNewConfirm.Size = New System.Drawing.Size(250, 20)
        Me.mbDecryptPasswNewConfirm.TabIndex = 11
        Me.mbDecryptPasswNewConfirm.UseSystemPasswordChar = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'TitkositoKulcsBeallitasa
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(794, 385)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(810, 390)
        Me.Name = "TitkositoKulcsBeallitasa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saját titkosító kulcsok beállítása"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents ErrorProvider1 As ErrorProvider
    Protected WithEvents ErrorProvider2 As ErrorProvider
    Protected WithEvents TableLayoutPanel1 As TableLayoutPanel
    Protected WithEvents tbEncryptPathNow As TextBox
    Protected WithEvents btnEncryptPathNow As Button
    Protected WithEvents Label4 As Label
    Protected WithEvents btnDecryptPathNow As Button
    Protected WithEvents tbDecryptPathNow As TextBox
    Protected WithEvents Label2 As Label
    Protected WithEvents Label1 As Label
    Protected WithEvents Label3 As Label
    Protected WithEvents Label5 As Label
    Protected WithEvents tbNewKeyPairName As TextBox
    Protected WithEvents tbNewKeyPairFolder As TextBox
    Protected WithEvents Label6 As Label
    Protected WithEvents Label7 As Label
    Protected WithEvents Label8 As Label
    Protected WithEvents btnNewKeyPairFolder As Button
    Protected WithEvents Label9 As Label
    Protected WithEvents Label10 As Label
    Protected WithEvents Panel1 As Panel
    Protected WithEvents btnElvet As Button
    Protected WithEvents btnOK As Button
    Protected WithEvents btnCreateNewKeyPair As Button
    Friend WithEvents btnTorlesKulcsok As Button
    Friend WithEvents cbxAtvegyeANYKboltitkositot As CheckBox
    Friend WithEvents mbDecryptPasswNow As TextBox
    Friend WithEvents mbDecryptPasswNowConfirm As TextBox
    Friend WithEvents mbDecryptPasswNew As TextBox
    Friend WithEvents mbDecryptPasswNewConfirm As TextBox
End Class
