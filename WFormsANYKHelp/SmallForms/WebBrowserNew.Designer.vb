<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowserNew
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
        Me.WebBrowserNewCtrl = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowserNewCtrl
        '
        Me.WebBrowserNewCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserNewCtrl.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserNewCtrl.Margin = New System.Windows.Forms.Padding(1)
        Me.WebBrowserNewCtrl.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.WebBrowserNewCtrl.Name = "WebBrowserNewCtrl"
        Me.WebBrowserNewCtrl.Size = New System.Drawing.Size(1024, 768)
        Me.WebBrowserNewCtrl.TabIndex = 0
        '
        'WebBrowserNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(996, 717)
        Me.Controls.Add(Me.WebBrowserNewCtrl)
        Me.Name = "WebBrowserNew"
        Me.ShowIcon = False
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents WebBrowserNewCtrl As WebBrowser

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SetBrowserFeatureControl()
        Me.WebBrowserNewCtrl.ScriptErrorsSuppressed = True
        If Screen.PrimaryScreen.WorkingArea.Height < 756 Then Me.WindowState = FormWindowState.Maximized

    End Sub
End Class
