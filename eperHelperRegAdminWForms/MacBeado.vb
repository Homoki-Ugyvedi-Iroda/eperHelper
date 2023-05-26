Public Class MacBeado
    Private Const TknCheckMac = "!84P%W*s5Y74ZeB"
    Public Property Code As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Me.Code = String.Empty Then Exit Sub
        tbMacList.Text = tbMacList.Text.Replace("-", String.Empty)
        tbMacList.Text = tbMacList.Text.Replace(":", String.Empty)
        tbMacList.Text = System.Text.RegularExpressions.Regex.Replace(tbMacList.Text, "[^A-Fa-f0-9]", String.Empty).ToUpper
        Dim MacListOutput As New List(Of String)(tbMacList.Text.Split(Environment.NewLine))
        Dim valasz As String = String.Empty
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                valasz = wsreg.ChangeCodewMAC(TknCheckMac, Code, MacListOutput.ToArray)
            Catch ex As Exception
            End Try
        End Using
        If valasz = False Then MsgBox("Nem sikerült a MAC kódok módosítása", MsgBoxStyle.OkOnly)
        If valasz = True Then MsgBox(valasz, MsgBoxStyle.OkOnly)
    End Sub

End Class