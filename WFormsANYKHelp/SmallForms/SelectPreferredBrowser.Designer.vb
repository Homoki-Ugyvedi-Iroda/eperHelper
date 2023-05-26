<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPreferredBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectPreferredBrowser))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnElvet = New System.Windows.Forms.Button()
        Me.MagyarázatPrefBrowser = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Firefox = New System.Windows.Forms.RadioButton()
        Me.Chrome = New System.Windows.Forms.RadioButton()
        Me.Edge = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnElvet, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MagyarázatPrefBrowser, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.74194!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(184, 315)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(8, 279)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnElvet
        '
        Me.btnElvet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnElvet.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnElvet.Location = New System.Drawing.Point(100, 279)
        Me.btnElvet.Name = "btnElvet"
        Me.btnElvet.Size = New System.Drawing.Size(75, 23)
        Me.btnElvet.TabIndex = 1
        Me.btnElvet.Text = "Elvet"
        Me.btnElvet.UseVisualStyleBackColor = True
        '
        'MagyarázatPrefBrowser
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.MagyarázatPrefBrowser, 2)
        Me.MagyarázatPrefBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MagyarázatPrefBrowser.Location = New System.Drawing.Point(3, 3)
        Me.MagyarázatPrefBrowser.Multiline = True
        Me.MagyarázatPrefBrowser.Name = "MagyarázatPrefBrowser"
        Me.MagyarázatPrefBrowser.ReadOnly = True
        Me.MagyarázatPrefBrowser.Size = New System.Drawing.Size(178, 117)
        Me.MagyarázatPrefBrowser.TabIndex = 2
        Me.MagyarázatPrefBrowser.Text = resources.GetString("MagyarázatPrefBrowser.Text")
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.Firefox)
        Me.GroupBox1.Controls.Add(Me.Chrome)
        Me.GroupBox1.Controls.Add(Me.Edge)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 137)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Firefox
        '
        Me.Firefox.AutoSize = True
        Me.Firefox.Dock = System.Windows.Forms.DockStyle.Top
        Me.Firefox.Enabled = False
        Me.Firefox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Firefox.Location = New System.Drawing.Point(3, 58)
        Me.Firefox.Name = "Firefox"
        Me.Firefox.Size = New System.Drawing.Size(172, 21)
        Me.Firefox.TabIndex = 2
        Me.Firefox.Text = "Mozilla Firefox"
        Me.Firefox.UseVisualStyleBackColor = True
        Me.Firefox.Visible = False
        '
        'Chrome
        '
        Me.Chrome.AutoSize = True
        Me.Chrome.Checked = True
        Me.Chrome.Dock = System.Windows.Forms.DockStyle.Top
        Me.Chrome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Chrome.Location = New System.Drawing.Point(3, 37)
        Me.Chrome.Name = "Chrome"
        Me.Chrome.Size = New System.Drawing.Size(172, 21)
        Me.Chrome.TabIndex = 1
        Me.Chrome.TabStop = True
        Me.Chrome.Text = "Google Chrome"
        Me.Chrome.UseVisualStyleBackColor = True
        '
        'Edge
        '
        Me.Edge.AutoSize = True
        Me.Edge.Dock = System.Windows.Forms.DockStyle.Top
        Me.Edge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Edge.Location = New System.Drawing.Point(3, 16)
        Me.Edge.Name = "Edge"
        Me.Edge.Size = New System.Drawing.Size(172, 21)
        Me.Edge.TabIndex = 0
        Me.Edge.Text = "Microsoft Edge"
        Me.Edge.UseVisualStyleBackColor = True
        '
        'SelectPreferredBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 315)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelectPreferredBrowser"
        Me.ShowIcon = False
        Me.Text = "Kedvenc böngésző kiválasztása"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnElvet As Button
    Friend WithEvents MagyarázatPrefBrowser As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Edge As RadioButton
    Friend WithEvents Firefox As RadioButton
    Friend WithEvents Chrome As RadioButton
End Class
