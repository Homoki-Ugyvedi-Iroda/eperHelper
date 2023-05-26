<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Csomagolas_alatt_short_message
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Csomagolás folyamatban ..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(0, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(507, 61)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A csomag méreteitől és a számítógéptől függően a becsomagolás percekig, akár órák" &
    "ig is eltarthat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ekkora összes fájlméretnél ([x]) ez egy Core i5-3570 asztali PC" &
    "-n [y] időt vesz igénybe."
        '
        'Csomagolas_alatt_short_message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 92)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Csomagolas_alatt_short_message"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Public Sub New(totalsize As Long)

        ' This call is required by the designer.
        InitializeComponent()
        Dim KRBuildPerformanceTable As New SortedDictionary(Of Long, String)
        KRBuildPerformanceTable.Add(5 * 1024 * 1024, "8 másodpercet")
        KRBuildPerformanceTable.Add(10 * 1024 * 1024, "39 másodpercet")
        KRBuildPerformanceTable.Add(20 * 1024 * 1024, "46 másodpercet")
        KRBuildPerformanceTable.Add(30 * 1024 * 1024, "49 másodpercet")
        KRBuildPerformanceTable.Add(40 * 1024 * 1024, "1 perc 5 másodpercet")
        KRBuildPerformanceTable.Add(50 * 1024 * 1024, "1 perc 22 másodpercet")
        KRBuildPerformanceTable.Add(60 * 1024 * 1024, "1 perc 37 másodpercet")
        KRBuildPerformanceTable.Add(70 * 1024 * 1024, "1 perc 54 másodpercet")
        KRBuildPerformanceTable.Add(80 * 1024 * 1024, "2 perc 8 másodpercet")
        KRBuildPerformanceTable.Add(90 * 1024 * 1024, "2 perc 26 másodpercet")
        KRBuildPerformanceTable.Add(100 * 1024 * 1024, "2 perc 45 másodpercet")
        KRBuildPerformanceTable.Add(120 * 1024 * 1024, "3 perc 16 másodpercet")
        KRBuildPerformanceTable.Add(125 * 1024 * 1024, "3 perc 19 másodpercet")
        KRBuildPerformanceTable.Add(150 * 1024 * 1024, "4 perc 8 másodpercet")
        KRBuildPerformanceTable.Add(System.Int64.MaxValue - 1, "4 perc 8 másodpercnél is többet")

        Dim time As Long = KRBuildPerformanceTable.Keys.First(Function(size) size >= totalsize)
        Me.Label2.Text = Me.Label2.Text.Replace("[x]", GetFileSizeFormatted(totalsize))
        Me.Label2.Text = Me.Label2.Text.Replace("[y]", KRBuildPerformanceTable.Item(time))
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class

