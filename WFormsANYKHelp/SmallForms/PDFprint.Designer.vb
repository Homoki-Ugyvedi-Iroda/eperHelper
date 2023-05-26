<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDFprint
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTargetFile = New System.Windows.Forms.Button()
        Me.tbTargetFile = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnBezár = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AllowDrop = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbSourceFile, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSourceFile, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTargetFile, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbTargetFile, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(649, 132)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PDF-é alakítandó fájl (XML, XKR)"
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
        Me.Label1.Size = New System.Drawing.Size(643, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Válassza ki a PDF-é alakítandó fájlt és a célkönyvtárat (vagy fájlnevet)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbSourceFile
        '
        Me.tbSourceFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSourceFile.Location = New System.Drawing.Point(209, 22)
        Me.tbSourceFile.MaxLength = 300
        Me.tbSourceFile.Name = "tbSourceFile"
        Me.tbSourceFile.Size = New System.Drawing.Size(365, 20)
        Me.tbSourceFile.TabIndex = 2
        '
        'btnSourceFile
        '
        Me.btnSourceFile.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSourceFile.Location = New System.Drawing.Point(592, 22)
        Me.btnSourceFile.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.btnSourceFile.MaximumSize = New System.Drawing.Size(50, 25)
        Me.btnSourceFile.Name = "btnSourceFile"
        Me.btnSourceFile.Size = New System.Drawing.Size(50, 23)
        Me.btnSourceFile.TabIndex = 7
        Me.btnSourceFile.Text = "Tallóz"
        Me.btnSourceFile.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSource)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 20)
        Me.Panel1.TabIndex = 9
        '
        'btnSource
        '
        Me.btnSource.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSource.Location = New System.Drawing.Point(117, 0)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(83, 20)
        Me.btnSource.TabIndex = 7
        Me.btnSource.Text = "Forráshoz"
        Me.btnSource.UseVisualStyleBackColor = True
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
        'btnTargetFile
        '
        Me.btnTargetFile.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTargetFile.Location = New System.Drawing.Point(592, 51)
        Me.btnTargetFile.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.btnTargetFile.MaximumSize = New System.Drawing.Size(50, 25)
        Me.btnTargetFile.Name = "btnTargetFile"
        Me.btnTargetFile.Size = New System.Drawing.Size(50, 23)
        Me.btnTargetFile.TabIndex = 8
        Me.btnTargetFile.Text = "Tallóz"
        Me.btnTargetFile.UseVisualStyleBackColor = True
        '
        'tbTargetFile
        '
        Me.tbTargetFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTargetFile.Location = New System.Drawing.Point(209, 51)
        Me.tbTargetFile.MaxLength = 300
        Me.tbTargetFile.Name = "tbTargetFile"
        Me.tbTargetFile.Size = New System.Drawing.Size(365, 20)
        Me.tbTargetFile.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnOpen)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 52)
        Me.Panel2.TabIndex = 10
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(117, 15)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 30)
        Me.btnOpen.TabIndex = 7
        Me.btnOpen.Text = "Megnyit"
        Me.btnOpen.UseVisualStyleBackColor = True
        Me.btnOpen.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnPDF)
        Me.Panel3.Controls.Add(Me.btnBezár)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(209, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 52)
        Me.Panel3.TabIndex = 11
        '
        'btnPDF
        '
        Me.btnPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPDF.AutoSize = True
        Me.btnPDF.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnPDF.Location = New System.Drawing.Point(98, 15)
        Me.btnPDF.Margin = New System.Windows.Forms.Padding(5, 15, 5, 5)
        Me.btnPDF.MaximumSize = New System.Drawing.Size(75, 30)
        Me.btnPDF.MinimumSize = New System.Drawing.Size(50, 25)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(75, 30)
        Me.btnPDF.TabIndex = 0
        Me.btnPDF.Text = "Átalakít"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'btnBezár
        '
        Me.btnBezár.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBezár.Location = New System.Drawing.Point(184, 15)
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
        'PDFprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(649, 132)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PDFprint"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "PDFprint"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSourceFile As TextBox
    Friend WithEvents btnSourceFile As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSource As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTargetFile As Button
    Friend WithEvents tbTargetFile As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPDF As Button
    Friend WithEvents btnBezár As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnOpen As Button
End Class
