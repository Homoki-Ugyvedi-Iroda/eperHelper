Public Class KodBeado
    Private Const TknUploadNewCode = "mE4cSV2U"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        tbCodeList.Text = tbCodeList.Text.Replace("-", String.Empty)
        tbCodeList.Text = System.Text.RegularExpressions.Regex.Replace(tbCodeList.Text, "[^A-Za-z]", String.Empty).ToUpper
        Dim CodeListOutput As New List(Of String)(tbCodeList.Text.Split(Environment.NewLine))
        Dim valasz As String = String.Empty
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                valasz = wsreg.UploadNewCode(TknUploadNewCode, CodeListOutput.ToArray)
            Catch ex As Exception
                valasz = ex.Message
            End Try
        End Using
        If valasz = "0" Then MsgBox("Nem töltött fel egy kódot sem a program", MsgBoxStyle.OkOnly)
        If valasz <> String.Empty Then MsgBox(valasz, MsgBoxStyle.OkOnly)
    End Sub

End Class