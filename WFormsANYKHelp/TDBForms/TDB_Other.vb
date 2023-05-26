Public Class TDB_Other
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If My.Settings.KeltezesHelye <> String.Empty Then Me.tbKeltezesHelye.Text = My.Settings.KeltezesHelye
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Me.tbKeltezesHelye.Text <> String.Empty Then
            My.Settings.KeltezesHelye = Me.tbKeltezesHelye.Text
            My.Settings.Save()
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click
        Me.Close()
    End Sub
End Class