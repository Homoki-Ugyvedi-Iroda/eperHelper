<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DecryptChooser
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDecryptPathNow = New System.Windows.Forms.Button()
        Me.tbDecryptPathNow = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mbDecryptPasswNow = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mbDecryptPasswNowConfirm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnElvet = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDecryptPathNow, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbDecryptPathNow, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.mbDecryptPasswNow, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.mbDecryptPasswNowConfirm, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 12)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(780, 160)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kititkosításhoz használt (privát titkosító) kulcs jelszava"
        '
        'btnDecryptPathNow
        '
        Me.btnDecryptPathNow.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDecryptPathNow.Location = New System.Drawing.Point(648, 24)
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
        Me.tbDecryptPathNow.Location = New System.Drawing.Point(295, 22)
        Me.tbDecryptPathNow.MaxLength = 300
        Me.tbDecryptPathNow.MinimumSize = New System.Drawing.Size(330, 4)
        Me.tbDecryptPathNow.Name = "tbDecryptPathNow"
        Me.tbDecryptPathNow.Size = New System.Drawing.Size(330, 20)
        Me.tbDecryptPathNow.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kititkosításhoz használt (privát titkosító) kulcs elérhetősége"
        '
        'mbDecryptPasswNow
        '
        Me.mbDecryptPasswNow.Location = New System.Drawing.Point(295, 57)
        Me.mbDecryptPasswNow.MinimumSize = New System.Drawing.Size(250, 4)
        Me.mbDecryptPasswNow.Name = "mbDecryptPasswNow"
        Me.mbDecryptPasswNow.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mbDecryptPasswNow.Size = New System.Drawing.Size(250, 20)
        Me.mbDecryptPasswNow.TabIndex = 4
        Me.mbDecryptPasswNow.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Kicsomagoláshoz egyedi beállítások"
        '
        'mbDecryptPasswNowConfirm
        '
        Me.mbDecryptPasswNowConfirm.Location = New System.Drawing.Point(295, 83)
        Me.mbDecryptPasswNowConfirm.MinimumSize = New System.Drawing.Size(250, 4)
        Me.mbDecryptPasswNowConfirm.Name = "mbDecryptPasswNowConfirm"
        Me.mbDecryptPasswNowConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mbDecryptPasswNowConfirm.Size = New System.Drawing.Size(250, 20)
        Me.mbDecryptPasswNowConfirm.TabIndex = 5
        Me.mbDecryptPasswNowConfirm.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(172, 86)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Erősítse meg a jelszót"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.btnElvet)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(295, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 48)
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'DecryptChooser
        '
        Me.AcceptButton = Me.btnOK
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(780, 160)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "DecryptChooser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Más kititkosító kulcs választása"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents TableLayoutPanel1 As TableLayoutPanel
    Protected WithEvents Label4 As Label
    Protected WithEvents btnDecryptPathNow As Button
    Protected WithEvents tbDecryptPathNow As TextBox
    Protected WithEvents Label2 As Label
    Protected WithEvents mbDecryptPasswNow As TextBox
    Protected WithEvents Label5 As Label
    Protected WithEvents mbDecryptPasswNowConfirm As TextBox
    Protected WithEvents Label9 As Label
    Protected WithEvents Panel1 As Panel
    Protected WithEvents btnElvet As Button
    Protected WithEvents btnOK As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
