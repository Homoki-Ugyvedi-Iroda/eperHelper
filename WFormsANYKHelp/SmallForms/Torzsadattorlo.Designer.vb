<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Torzsadattorlo
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTorolEgyet = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxRecord = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnTorolEgyet, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMaxRecord, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(334, 269)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnTorolEgyet
        '
        Me.btnTorolEgyet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTorolEgyet.Location = New System.Drawing.Point(3, 218)
        Me.btnTorolEgyet.Name = "btnTorolEgyet"
        Me.btnTorolEgyet.Size = New System.Drawing.Size(227, 20)
        Me.btnTorolEgyet.TabIndex = 0
        Me.btnTorolEgyet.Text = "Törölje a kiválasztott rekordot"
        Me.btnTorolEgyet.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(3, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 22)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Törölje az összes rekordot az adott törzsben"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(236, 244)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 22)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Kilép"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(227, 209)
        Me.ListBox1.TabIndex = 3
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(236, 218)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(95, 20)
        Me.NumericUpDown1.TabIndex = 4
        '
        'lblMaxRecord
        '
        Me.lblMaxRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMaxRecord.AutoSize = True
        Me.lblMaxRecord.Location = New System.Drawing.Point(236, 202)
        Me.lblMaxRecord.Name = "lblMaxRecord"
        Me.lblMaxRecord.Size = New System.Drawing.Size(19, 13)
        Me.lblMaxRecord.TabIndex = 5
        Me.lblMaxRecord.Text = "(0)"
        '
        'Torzsadattorlo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(334, 269)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Torzsadattorlo"
        Me.ShowIcon = False
        Me.Text = "Törzsadatok törlése beolvasás nélkül"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnTorolEgyet As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblMaxRecord As Label
End Class
