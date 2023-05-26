<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passwbox
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnElvet = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mbDecryptPasswNow = New System.Windows.Forms.TextBox()
        Me.mbDecryptPasswNowConfirm = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnElvet, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.mbDecryptPasswNow, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.mbDecryptPasswNowConfirm, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(529, 87)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kititkosításhoz használt (privát titkosító) kulcs jelszava"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(149, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Erősítse meg a jelszót"
        '
        'btnElvet
        '
        Me.btnElvet.Location = New System.Drawing.Point(272, 55)
        Me.btnElvet.Name = "btnElvet"
        Me.btnElvet.Size = New System.Drawing.Size(75, 23)
        Me.btnElvet.TabIndex = 22
        Me.btnElvet.Text = "Elvet"
        Me.btnElvet.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(191, 55)
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
        'mbDecryptPasswNow
        '
        Me.mbDecryptPasswNow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mbDecryptPasswNow.Location = New System.Drawing.Point(272, 3)
        Me.mbDecryptPasswNow.MaxLength = 40
        Me.mbDecryptPasswNow.Name = "mbDecryptPasswNow"
        Me.mbDecryptPasswNow.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mbDecryptPasswNow.Size = New System.Drawing.Size(254, 20)
        Me.mbDecryptPasswNow.TabIndex = 23
        Me.mbDecryptPasswNow.UseSystemPasswordChar = True
        '
        'mbDecryptPasswNowConfirm
        '
        Me.mbDecryptPasswNowConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mbDecryptPasswNowConfirm.Location = New System.Drawing.Point(272, 29)
        Me.mbDecryptPasswNowConfirm.MaxLength = 40
        Me.mbDecryptPasswNowConfirm.Name = "mbDecryptPasswNowConfirm"
        Me.mbDecryptPasswNowConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mbDecryptPasswNowConfirm.Size = New System.Drawing.Size(254, 20)
        Me.mbDecryptPasswNowConfirm.TabIndex = 24
        Me.mbDecryptPasswNowConfirm.UseSystemPasswordChar = True
        '
        'Passwbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(529, 87)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Passwbox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Adja meg a kititkosításhoz használandó jelszót!"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents TableLayoutPanel1 As TableLayoutPanel
    Protected WithEvents Label4 As Label
    Protected WithEvents btnOK As Button
    Protected WithEvents Label9 As Label
    Protected WithEvents btnElvet As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents mbDecryptPasswNow As TextBox
    Friend WithEvents mbDecryptPasswNowConfirm As TextBox
End Class
