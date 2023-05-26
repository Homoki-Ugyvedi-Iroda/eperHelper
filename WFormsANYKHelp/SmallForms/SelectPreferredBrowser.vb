Public Class SelectPreferredBrowser
    Public Sub New()

        InitializeComponent()
        Select Case My.Settings.BrowserPreferred
            Case "Microsoft Edge"
                Me.Edge.Checked = True
            Case "Google Chrome"
                Me.Chrome.Checked = True
            Case "Mozilla Firefox"
                Me.Firefox.Checked = True
        End Select
        Dim browserek = Kapukezelo.GetBrowserInstalled
        If Not browserek.ContainsKey("Mozilla Firefox") Then Me.Firefox.Enabled = False Else Firefox.Enabled = True
        If Not browserek.ContainsKey("Microsoft Edge") Then Me.Edge.Enabled = False Else Me.Edge.Enabled = True
        If Not browserek.ContainsKey("Google Chrome") Then Chrome.Enabled = False Else Chrome.Enabled = True
    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Edge.Checked Then My.Settings.BrowserPreferred = "Microsoft Edge"
        If Chrome.Checked Then My.Settings.BrowserPreferred = "Google Chrome"
        If Firefox.Checked Then My.Settings.BrowserPreferred = "Mozilla Firefox"
        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click
        Me.Close()
    End Sub
End Class