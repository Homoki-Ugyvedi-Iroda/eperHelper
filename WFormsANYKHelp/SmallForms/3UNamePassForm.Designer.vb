<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KapuUserNamePasswForm
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
        Me.TableLayoutPanel3UNamePassForm = New System.Windows.Forms.TableLayoutPanel()
        Me.HKPUName = New System.Windows.Forms.TextBox()
        Me.PKPUName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Bezár = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.UKPPassw = New System.Windows.Forms.MaskedTextBox()
        Me.PKPPassw = New System.Windows.Forms.MaskedTextBox()
        Me.HKPPassw = New System.Windows.Forms.MaskedTextBox()
        Me.UKPUName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel3UNamePassForm.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3UNamePassForm
        '
        Me.TableLayoutPanel3UNamePassForm.AutoSize = True
        Me.TableLayoutPanel3UNamePassForm.ColumnCount = 4
        Me.TableLayoutPanel3UNamePassForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3UNamePassForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3UNamePassForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3UNamePassForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.HKPUName, 1, 7)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.PKPUName, 1, 4)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Bezár, 2, 9)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.OK, 1, 9)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.UKPPassw, 1, 2)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.PKPPassw, 1, 5)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.HKPPassw, 1, 8)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.UKPUName, 1, 1)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel3UNamePassForm.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel3UNamePassForm.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3UNamePassForm.Name = "TableLayoutPanel3UNamePassForm"
        Me.TableLayoutPanel3UNamePassForm.RowCount = 10
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3UNamePassForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3UNamePassForm.Size = New System.Drawing.Size(354, 288)
        Me.TableLayoutPanel3UNamePassForm.TabIndex = 0
        '
        'HKPUName
        '
        Me.TableLayoutPanel3UNamePassForm.SetColumnSpan(Me.HKPUName, 2)
        Me.HKPUName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorProvider1.SetIconPadding(Me.HKPUName, 1)
        Me.HKPUName.Location = New System.Drawing.Point(96, 179)
        Me.HKPUName.MaxLength = 10
        Me.HKPUName.Name = "HKPUName"
        Me.HKPUName.Size = New System.Drawing.Size(231, 20)
        Me.HKPUName.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.HKPUName, "Itt adja meg a hivatali kapu nevét (rövid nevét)")
        '
        'PKPUName
        '
        Me.TableLayoutPanel3UNamePassForm.SetColumnSpan(Me.PKPUName, 2)
        Me.PKPUName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorProvider1.SetIconPadding(Me.PKPUName, 1)
        Me.PKPUName.Location = New System.Drawing.Point(96, 103)
        Me.PKPUName.MaxLength = 50
        Me.PKPUName.Name = "PKPUName"
        Me.PKPUName.Size = New System.Drawing.Size(231, 20)
        Me.PKPUName.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.PKPUName, "Itt adja meg a perkapus felhasználónevét, azaz a perkapu rövid nevét")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 2, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ügyfélkapu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 2, 3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Perkapu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 2, 3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hivatali kapu"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(3)
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Felhasználónév"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(3)
        Me.Label5.Size = New System.Drawing.Size(42, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jelszó"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 103)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(3)
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Rövid neve"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 179)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(3)
        Me.Label8.Size = New System.Drawing.Size(68, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Rövid neve"
        '
        'Bezár
        '
        Me.Bezár.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bezár.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bezár.Location = New System.Drawing.Point(180, 260)
        Me.Bezár.Margin = New System.Windows.Forms.Padding(5)
        Me.Bezár.Name = "Bezár"
        Me.Bezár.Size = New System.Drawing.Size(75, 23)
        Me.Bezár.TabIndex = 7
        Me.Bezár.Text = "Bezár"
        Me.Bezár.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Location = New System.Drawing.Point(98, 260)
        Me.OK.Margin = New System.Windows.Forms.Padding(5)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(72, 23)
        Me.OK.TabIndex = 6
        Me.OK.Text = "OK"
        Me.ToolTip1.SetToolTip(Me.OK, "A fenti adatokat a program titkosítva tárolja a gépen, de emiatt csak ugyanazon f" &
        "elhasználó fogja tudni visszaolvasni.")
        Me.OK.UseVisualStyleBackColor = True
        '
        'UKPPassw
        '
        Me.TableLayoutPanel3UNamePassForm.SetColumnSpan(Me.UKPPassw, 2)
        Me.UKPPassw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorProvider1.SetIconPadding(Me.UKPPassw, 1)
        Me.UKPPassw.Location = New System.Drawing.Point(96, 53)
        Me.UKPPassw.Name = "UKPPassw"
        Me.UKPPassw.Size = New System.Drawing.Size(231, 20)
        Me.UKPPassw.TabIndex = 1
        Me.UKPPassw.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.UKPPassw.UseSystemPasswordChar = True
        '
        'PKPPassw
        '
        Me.TableLayoutPanel3UNamePassForm.SetColumnSpan(Me.PKPPassw, 2)
        Me.PKPPassw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorProvider1.SetIconPadding(Me.PKPPassw, 1)
        Me.PKPPassw.Location = New System.Drawing.Point(96, 129)
        Me.PKPPassw.Name = "PKPPassw"
        Me.PKPPassw.Size = New System.Drawing.Size(231, 20)
        Me.PKPPassw.TabIndex = 3
        Me.PKPPassw.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.PKPPassw.UseSystemPasswordChar = True
        '
        'HKPPassw
        '
        Me.TableLayoutPanel3UNamePassForm.SetColumnSpan(Me.HKPPassw, 2)
        Me.HKPPassw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorProvider1.SetIconPadding(Me.HKPPassw, 1)
        Me.HKPPassw.Location = New System.Drawing.Point(96, 205)
        Me.HKPPassw.Name = "HKPPassw"
        Me.HKPPassw.Size = New System.Drawing.Size(231, 20)
        Me.HKPPassw.TabIndex = 5
        Me.HKPPassw.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.HKPPassw.UseSystemPasswordChar = True
        '
        'UKPUName
        '
        Me.TableLayoutPanel3UNamePassForm.SetColumnSpan(Me.UKPUName, 2)
        Me.UKPUName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorProvider1.SetIconPadding(Me.UKPUName, 1)
        Me.UKPUName.Location = New System.Drawing.Point(96, 27)
        Me.UKPUName.MaxLength = 150
        Me.UKPUName.Name = "UKPUName"
        Me.UKPUName.Size = New System.Drawing.Size(231, 20)
        Me.UKPUName.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.UKPUName, "Itt adja meg az ügyfélkapu felhasználónevét")
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(3)
        Me.Label7.Size = New System.Drawing.Size(42, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Jelszó"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 205)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(3)
        Me.Label9.Size = New System.Drawing.Size(42, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Jelszó"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'KapuUserNamePasswForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.Bezár
        Me.ClientSize = New System.Drawing.Size(354, 288)
        Me.Controls.Add(Me.TableLayoutPanel3UNamePassForm)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(370, 327)
        Me.Name = "KapuUserNamePasswForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Felhasználónév és jelszavak rögzítése"
        Me.TableLayoutPanel3UNamePassForm.ResumeLayout(False)
        Me.TableLayoutPanel3UNamePassForm.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel3UNamePassForm As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Bezár As Button
    Friend WithEvents OK As Button
    Friend WithEvents HKPUName As TextBox
    Friend WithEvents PKPUName As TextBox
    Friend WithEvents UKPPassw As MaskedTextBox
    Friend WithEvents PKPPassw As MaskedTextBox
    Friend WithEvents HKPPassw As MaskedTextBox
    Friend WithEvents UKPUName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
