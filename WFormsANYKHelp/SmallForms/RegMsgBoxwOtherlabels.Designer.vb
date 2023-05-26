<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegMsgBoxwOtherlabels
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbTajekoztatasMsgBox = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnFeltolt = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbTajekoztatasMsgBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnFeltolt, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 561)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbTajekoztatasMsgBox
        '
        Me.lbTajekoztatasMsgBox.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lbTajekoztatasMsgBox, 2)
        Me.lbTajekoztatasMsgBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbTajekoztatasMsgBox.Location = New System.Drawing.Point(8, 8)
        Me.lbTajekoztatasMsgBox.Margin = New System.Windows.Forms.Padding(8)
        Me.lbTajekoztatasMsgBox.Name = "lbTajekoztatasMsgBox"
        Me.lbTajekoztatasMsgBox.Size = New System.Drawing.Size(268, 13)
        Me.lbTajekoztatasMsgBox.TabIndex = 2
        Me.lbTajekoztatasMsgBox.Text = "xxxx"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOK.AutoSize = True
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(175, 528)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(10)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Bezár"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnFeltolt
        '
        Me.btnFeltolt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFeltolt.AutoSize = True
        Me.btnFeltolt.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnFeltolt.Location = New System.Drawing.Point(27, 528)
        Me.btnFeltolt.Margin = New System.Windows.Forms.Padding(10)
        Me.btnFeltolt.Name = "btnFeltolt"
        Me.btnFeltolt.Size = New System.Drawing.Size(88, 23)
        Me.btnFeltolt.TabIndex = 1
        Me.btnFeltolt.Text = "Feltölt és bezár"
        Me.btnFeltolt.UseVisualStyleBackColor = True
        '
        'RegMsgBoxwOtherlabels
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(284, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(600, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 600)
        Me.Name = "RegMsgBoxwOtherlabels"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sikeres regisztráció"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnFeltolt As Button
    Friend WithEvents lbTajekoztatasMsgBox As Label
End Class
