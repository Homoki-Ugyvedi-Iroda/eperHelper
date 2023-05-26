<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSTExtractForm
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnKicsomagol = New System.Windows.Forms.Button()
        Me.btnBetekint = New System.Windows.Forms.Button()
        Me.Bezár = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbFileToExtract = New System.Windows.Forms.TextBox()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowseFolderToExtractTo = New System.Windows.Forms.Button()
        Me.tbFolderToExtractTo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBrowseFileToExtract = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnKicsomagol
        '
        Me.btnKicsomagol.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnKicsomagol.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnKicsomagol.Location = New System.Drawing.Point(282, 23)
        Me.btnKicsomagol.Margin = New System.Windows.Forms.Padding(5, 5, 5, 15)
        Me.btnKicsomagol.MaximumSize = New System.Drawing.Size(75, 30)
        Me.btnKicsomagol.MinimumSize = New System.Drawing.Size(50, 25)
        Me.btnKicsomagol.Name = "btnKicsomagol"
        Me.btnKicsomagol.Size = New System.Drawing.Size(75, 30)
        Me.btnKicsomagol.TabIndex = 0
        Me.btnKicsomagol.Text = "Kicsomagol"
        Me.btnKicsomagol.UseVisualStyleBackColor = True
        '
        'btnBetekint
        '
        Me.btnBetekint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBetekint.Location = New System.Drawing.Point(438, 23)
        Me.btnBetekint.Margin = New System.Windows.Forms.Padding(5, 5, 5, 15)
        Me.btnBetekint.Name = "btnBetekint"
        Me.btnBetekint.Size = New System.Drawing.Size(75, 30)
        Me.btnBetekint.TabIndex = 1
        Me.btnBetekint.Text = "Betekint"
        Me.btnBetekint.UseVisualStyleBackColor = True
        '
        'Bezár
        '
        Me.Bezár.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Bezár.Location = New System.Drawing.Point(608, 23)
        Me.Bezár.Margin = New System.Windows.Forms.Padding(5, 5, 5, 15)
        Me.Bezár.MinimumSize = New System.Drawing.Size(50, 30)
        Me.Bezár.Name = "Bezár"
        Me.Bezár.Size = New System.Drawing.Size(50, 30)
        Me.Bezár.TabIndex = 6
        Me.Bezár.Text = "Bezár"
        Me.Bezár.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnBetekint, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Bezár, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnKicsomagol, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 83)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(713, 68)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'tbFileToExtract
        '
        Me.tbFileToExtract.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFileToExtract.Location = New System.Drawing.Point(209, 22)
        Me.tbFileToExtract.MaxLength = 300
        Me.tbFileToExtract.Name = "tbFileToExtract"
        Me.tbFileToExtract.Size = New System.Drawing.Size(365, 20)
        Me.tbFileToExtract.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbFileToExtract, "Válassza ki a kitömörítendő KR vagy CST kiterjesztésű állományt.")
        '
        'btnSource
        '
        Me.btnSource.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSource.Location = New System.Drawing.Point(117, 3)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(83, 23)
        Me.btnSource.TabIndex = 7
        Me.btnSource.Text = "Forráshoz"
        Me.ToolTip1.SetToolTip(Me.btnSource, "A célkönyvtár a forrásfájllal azonos könyvtár legyen")
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kicsomagolni kívánt fájl"
        '
        'btnBrowseFolderToExtractTo
        '
        Me.btnBrowseFolderToExtractTo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBrowseFolderToExtractTo.Location = New System.Drawing.Point(592, 52)
        Me.btnBrowseFolderToExtractTo.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.btnBrowseFolderToExtractTo.MaximumSize = New System.Drawing.Size(50, 25)
        Me.btnBrowseFolderToExtractTo.Name = "btnBrowseFolderToExtractTo"
        Me.btnBrowseFolderToExtractTo.Size = New System.Drawing.Size(50, 23)
        Me.btnBrowseFolderToExtractTo.TabIndex = 8
        Me.btnBrowseFolderToExtractTo.Text = "Tallóz"
        Me.btnBrowseFolderToExtractTo.UseVisualStyleBackColor = True
        '
        'tbFolderToExtractTo
        '
        Me.tbFolderToExtractTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFolderToExtractTo.Location = New System.Drawing.Point(209, 51)
        Me.tbFolderToExtractTo.MaxLength = 300
        Me.tbFolderToExtractTo.Name = "tbFolderToExtractTo"
        Me.tbFolderToExtractTo.Size = New System.Drawing.Size(365, 20)
        Me.tbFolderToExtractTo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Célkönyvtár"
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
        Me.Label1.Size = New System.Drawing.Size(713, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Válassza ki a kicsomagolni kívánt fájlt és a célkönyvtárat!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSource)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 26)
        Me.Panel1.TabIndex = 9
        '
        'btnBrowseFileToExtract
        '
        Me.btnBrowseFileToExtract.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBrowseFileToExtract.Location = New System.Drawing.Point(592, 22)
        Me.btnBrowseFileToExtract.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.btnBrowseFileToExtract.MaximumSize = New System.Drawing.Size(50, 25)
        Me.btnBrowseFileToExtract.Name = "btnBrowseFileToExtract"
        Me.btnBrowseFileToExtract.Size = New System.Drawing.Size(50, 23)
        Me.btnBrowseFileToExtract.TabIndex = 7
        Me.btnBrowseFileToExtract.Text = "Tallóz"
        Me.btnBrowseFileToExtract.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBrowseFolderToExtractTo, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFolderToExtractTo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFileToExtract, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBrowseFileToExtract, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(716, 151)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'CSTExtractForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(716, 151)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(732, 190)
        Me.Name = "CSTExtractForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "CSTExtractForm"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSource As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBrowseFolderToExtractTo As Button
    Friend WithEvents tbFolderToExtractTo As TextBox
    Friend WithEvents tbFileToExtract As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBrowseFileToExtract As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnBetekint As Button
    Friend WithEvents Bezár As Button
    Friend WithEvents btnKicsomagol As Button
End Class
