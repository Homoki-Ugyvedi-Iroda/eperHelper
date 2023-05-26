Public Class NyomiLista
    Public Sub New()

        InitializeComponent()
        Me.tbListaAvailable.Text = ListToDisplay
        Me.tbHibalista.Text = "Hibalista: " & Environment.NewLine & HibaListToDisplay
        Me.Text = "Elérhető nyomtatványok listája a közzétett frissítési lista szerint: " & Me.tbListaAvailable.Lines.Count

    End Sub


    Private Sub btnBezár_Click(sender As Object, e As EventArgs) Handles btnBezár.Click
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class