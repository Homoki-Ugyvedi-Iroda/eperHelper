Public Class RegTableShow
    Public Sub New(dt As DataTable)

        ' This call is required by the designer.
        InitializeComponent()
        Dim SBind As New BindingSource
        Me.DataGridView1.AutoGenerateColumns = True
        SBind.DataSource = dt
        Me.DataGridView1.DataSource = SBind
        Me.DataGridView1.Refresh()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class