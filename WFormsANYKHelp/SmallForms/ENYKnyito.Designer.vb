<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ENYKnyito
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSourceFile = New System.Windows.Forms.TextBox()
        Me.btnSourceFile = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnXMLmegnyitasi = New System.Windows.Forms.Button()
        Me.btnANYKmappa = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnBezár = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbSourceFile, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSourceFile, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(672, 113)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(672, 123)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Megnyitandó fájl"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(666, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Válassza ki a megnyitandó félkész ÁNYK állományt (.FRM.ENYK)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbSourceFile
        '
        Me.tbSourceFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSourceFile.Location = New System.Drawing.Point(209, 33)
        Me.tbSourceFile.MaxLength = 300
        Me.tbSourceFile.Name = "tbSourceFile"
        Me.tbSourceFile.Size = New System.Drawing.Size(365, 20)
        Me.tbSourceFile.TabIndex = 2
        '
        'btnSourceFile
        '
        Me.btnSourceFile.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSourceFile.Location = New System.Drawing.Point(592, 33)
        Me.btnSourceFile.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.btnSourceFile.MaximumSize = New System.Drawing.Size(50, 25)
        Me.btnSourceFile.Name = "btnSourceFile"
        Me.btnSourceFile.Size = New System.Drawing.Size(50, 23)
        Me.btnSourceFile.TabIndex = 7
        Me.btnSourceFile.Text = "Tallóz"
        Me.btnSourceFile.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnXMLmegnyitasi)
        Me.Panel2.Controls.Add(Me.btnANYKmappa)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 58)
        Me.Panel2.TabIndex = 10
        '
        'btnXMLmegnyitasi
        '
        Me.btnXMLmegnyitasi.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnXMLmegnyitasi.Location = New System.Drawing.Point(3, 3)
        Me.btnXMLmegnyitasi.Name = "btnXMLmegnyitasi"
        Me.btnXMLmegnyitasi.Size = New System.Drawing.Size(166, 25)
        Me.btnXMLmegnyitasi.TabIndex = 8
        Me.btnXMLmegnyitasi.Text = "Alap megnyitási könyvtárból"
        Me.btnXMLmegnyitasi.UseVisualStyleBackColor = True
        '
        'btnANYKmappa
        '
        Me.btnANYKmappa.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnANYKmappa.Location = New System.Drawing.Point(3, 32)
        Me.btnANYKmappa.Name = "btnANYKmappa"
        Me.btnANYKmappa.Size = New System.Drawing.Size(166, 25)
        Me.btnANYKmappa.TabIndex = 7
        Me.btnANYKmappa.Text = "ÁNYK mentési könyvtárból"
        Me.btnANYKmappa.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnOpen)
        Me.Panel3.Controls.Add(Me.btnBezár)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(209, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 58)
        Me.Panel3.TabIndex = 11
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.AutoSize = True
        Me.btnOpen.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOpen.Location = New System.Drawing.Point(98, 21)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(5, 15, 5, 5)
        Me.btnOpen.MaximumSize = New System.Drawing.Size(75, 30)
        Me.btnOpen.MinimumSize = New System.Drawing.Size(50, 25)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 30)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Szerkeszt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnBezár
        '
        Me.btnBezár.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBezár.Location = New System.Drawing.Point(184, 21)
        Me.btnBezár.Margin = New System.Windows.Forms.Padding(15, 15, 5, 10)
        Me.btnBezár.MaximumSize = New System.Drawing.Size(75, 30)
        Me.btnBezár.MinimumSize = New System.Drawing.Size(50, 30)
        Me.btnBezár.Name = "btnBezár"
        Me.btnBezár.Size = New System.Drawing.Size(65, 30)
        Me.btnBezár.TabIndex = 6
        Me.btnBezár.Text = "Bezár"
        Me.btnBezár.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ENYKnyito
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(672, 123)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ENYKnyito"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Félkész ÁNYK nyomtatvány (FRM.ENYK) megnyitása"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnANYKmappa As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnBezár As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSourceFile As TextBox
    Friend WithEvents btnSourceFile As Button
    Friend WithEvents btnXMLmegnyitasi As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
