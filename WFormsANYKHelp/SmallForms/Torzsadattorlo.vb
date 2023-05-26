Public Class Torzsadattorlo
    Private Sub Torzsadattorlo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim names = [Enum].GetNames(GetType(TorzsTipus_rogzito))
        For Each EnumName In names
            ListBox1.Items.Add(EnumName)
        Next


    End Sub

    Private Sub btnTorolEgyet_Click(sender As Object, e As EventArgs) Handles btnTorolEgyet.Click
        If ListBox1.SelectedItems.Count > 0 Then

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItems.Count > 0 Then

        End If
    End Sub


End Class