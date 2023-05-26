<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KRviewer
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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lvKRCSTViewer = New System.Windows.Forms.ListView()
        Me.Fájlnév = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Méret = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Típus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fullname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblWhatisViewed = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnOpen.Location = New System.Drawing.Point(667, 41)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 25)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Megnyit"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCopy.Location = New System.Drawing.Point(667, 72)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 25)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Kimásol"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.Location = New System.Drawing.Point(667, 121)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 25)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Bezár"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lvKRCSTViewer
        '
        Me.lvKRCSTViewer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Fájlnév, Me.Méret, Me.Típus, Me.Fullname})
        Me.lvKRCSTViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvKRCSTViewer.Location = New System.Drawing.Point(3, 23)
        Me.lvKRCSTViewer.Name = "lvKRCSTViewer"
        Me.TableLayoutPanel1.SetRowSpan(Me.lvKRCSTViewer, 3)
        Me.lvKRCSTViewer.Size = New System.Drawing.Size(606, 135)
        Me.lvKRCSTViewer.TabIndex = 0
        Me.lvKRCSTViewer.UseCompatibleStateImageBehavior = False
        Me.lvKRCSTViewer.View = System.Windows.Forms.View.Details
        '
        'Fájlnév
        '
        Me.Fájlnév.Text = "Név"
        Me.Fájlnév.Width = 297
        '
        'Méret
        '
        Me.Méret.Text = "Méret"
        Me.Méret.Width = 70
        '
        'Típus
        '
        Me.Típus.Text = "Típus"
        Me.Típus.Width = 40
        '
        'Fullname
        '
        Me.Fullname.Text = "Teljes fájlnév"
        Me.Fullname.Width = 371
        '
        'lblWhatisViewed
        '
        Me.lblWhatisViewed.Location = New System.Drawing.Point(3, 3)
        Me.lblWhatisViewed.Margin = New System.Windows.Forms.Padding(3)
        Me.lblWhatisViewed.Name = "lblWhatisViewed"
        Me.lblWhatisViewed.Size = New System.Drawing.Size(39, 13)
        Me.lblWhatisViewed.TabIndex = 4
        Me.lblWhatisViewed.Text = "Label1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.88889!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.11111!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvKRCSTViewer, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCopy, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOpen, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWhatisViewed, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(797, 161)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'KRviewer
        '
        Me.AcceptButton = Me.btnOpen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(797, 161)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(530, 200)
        Me.Name = "KRviewer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "KR/CST betekintő"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lvKRCSTViewer As ListView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblWhatisViewed As Label
    Friend WithEvents Fájlnév As ColumnHeader
    Friend WithEvents Méret As ColumnHeader
    Friend WithEvents Típus As ColumnHeader
    Friend WithEvents Fullname As ColumnHeader
End Class
