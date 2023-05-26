<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KodBeado
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tbFelirat = New System.Windows.Forms.TextBox()
        Me.tbCodeList = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFelirat, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCodeList, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(208, 527)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.AutoSize = True
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(15, 489)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(15)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(64, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Betölt"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(119, 489)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Elvet"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tbFelirat
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbFelirat, 2)
        Me.tbFelirat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbFelirat.Location = New System.Drawing.Point(3, 3)
        Me.tbFelirat.Multiline = True
        Me.tbFelirat.Name = "tbFelirat"
        Me.tbFelirat.ReadOnly = True
        Me.tbFelirat.Size = New System.Drawing.Size(202, 67)
        Me.tbFelirat.TabIndex = 2
        Me.tbFelirat.Text = "Másolja be a betölteni kívánt kódokat." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Az egyes kódokat enter válassza el!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Csak" &
    " az angol ábécé nagybetűje szerepeljen benne."
        '
        'tbCodeList
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbCodeList, 2)
        Me.tbCodeList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCodeList.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbCodeList.Location = New System.Drawing.Point(3, 76)
        Me.tbCodeList.MaxLength = 120000
        Me.tbCodeList.Multiline = True
        Me.tbCodeList.Name = "tbCodeList"
        Me.tbCodeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCodeList.Size = New System.Drawing.Size(202, 395)
        Me.tbCodeList.TabIndex = 3
        '
        'KodBeado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 527)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "KodBeado"
        Me.Text = "Licenckód rögzítő"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tbFelirat As TextBox
    Friend WithEvents tbCodeList As TextBox
End Class
