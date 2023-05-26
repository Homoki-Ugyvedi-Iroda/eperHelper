<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NyomiLista
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
        Me.btnBezár = New System.Windows.Forms.Button()
        Me.tbListaAvailable = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbHibalista = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBezár
        '
        Me.btnBezár.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBezár.AutoSize = True
        Me.btnBezár.Location = New System.Drawing.Point(217, 333)
        Me.btnBezár.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.btnBezár.MinimumSize = New System.Drawing.Size(50, 25)
        Me.btnBezár.Name = "btnBezár"
        Me.btnBezár.Size = New System.Drawing.Size(50, 25)
        Me.btnBezár.TabIndex = 0
        Me.btnBezár.Text = "Bezár"
        Me.btnBezár.UseVisualStyleBackColor = True
        '
        'tbListaAvailable
        '
        Me.tbListaAvailable.AcceptsReturn = True
        Me.tbListaAvailable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbListaAvailable.Location = New System.Drawing.Point(3, 3)
        Me.tbListaAvailable.Multiline = True
        Me.tbListaAvailable.Name = "tbListaAvailable"
        Me.tbListaAvailable.ReadOnly = True
        Me.tbListaAvailable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbListaAvailable.Size = New System.Drawing.Size(478, 191)
        Me.tbListaAvailable.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbHibalista, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbListaAvailable, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBezár, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(484, 373)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'tbHibalista
        '
        Me.tbHibalista.AcceptsReturn = True
        Me.tbHibalista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbHibalista.Location = New System.Drawing.Point(3, 200)
        Me.tbHibalista.Multiline = True
        Me.tbHibalista.Name = "tbHibalista"
        Me.tbHibalista.ReadOnly = True
        Me.tbHibalista.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbHibalista.Size = New System.Drawing.Size(478, 104)
        Me.tbHibalista.TabIndex = 2
        Me.tbHibalista.Text = "(Csak az első letöltés után)"
        '
        'NyomiLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(484, 373)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "NyomiLista"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Elérhető nyomtatványok listája"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBezár As Button
    Friend WithEvents tbListaAvailable As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbHibalista As TextBox
End Class
