Imports Microsoft.VisualBasic.CallType
Public Class KapuUserNamePasswForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim kaputipusok = [Enum].GetNames(GetType(SecretInfoKapu))
        For Each kaputipus In kaputipusok
            Dim tempcontent As String = CallByName(My.Settings, kaputipus, CallType.Get)
            If tempcontent <> "" Then Me.TableLayoutPanel3UNamePassForm.Controls(kaputipus).Text = Kapukezelo.Decrypt(tempcontent, kaputipus)
        Next

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        RecordNamePass()
        Close()
    End Sub

    Private Sub Bezár_Click(sender As Object, e As EventArgs) Handles Bezár.Click
        Me.Close()
    End Sub
    Private Sub RecordNamePass()
        Dim EnDecDict As New Dictionary(Of String, String)

        For Each ctrl As Control In TableLayoutPanel3UNamePassForm.Controls
            If (TypeOf (ctrl) Is TextBox) Or (TypeOf (ctrl) Is MaskedTextBox) Then
                If ctrl.Text <> String.Empty Then CallByName(My.Settings, ctrl.Name, CallType.Set, Kapukezelo.Encrypt(ctrl.Text, ctrl.Name))
                If ctrl.Text = String.Empty Then CallByName(My.Settings, ctrl.Name, CallType.Set, String.Empty)
            End If
        Next
        My.Settings.Save()

        MyLoader.AddLogBook(Fnc.web, "Felhasználónév és jelszó rögzítése", LogTip.norm)

        MyLoader.CheckUKP()
        MyLoader.CheckPKP()
        MyLoader.CheckHKP()

    End Sub

    Private Sub UName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PKPUName.Validating, HKPUName.Validating
        Dim sCtrl As Control = DirectCast(sender, Control)
        Dim sendingTbox = Nothing
        sendingTbox = DirectCast(sender, TextBox)
        Dim ErrorMsg As String = String.Empty

        Dim engkarakter As String = String.Empty
        Dim m As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(sendingTbox.Text, "([^A-Za-z0-9])+")
        ErrorProvider1.BlinkStyle = False
        If (m.Success) = True Then
            sendingTbox.Text = ""
            ErrorProvider1.SetError(sCtrl, "Meg nem engedett karakter a névben! (Csak ékezet nélküli betű és szám)")
        Else
            ErrorProvider1.SetError(sCtrl, String.Empty)
        End If
    End Sub

    Private Sub UKPPassw_GotFocus(sender As Object, e As MouseEventArgs) Handles UKPPassw.MouseClick, PKPPassw.MouseClick, HKPPassw.MouseClick
        Dim sendername As MaskedTextBox = DirectCast(sender, MaskedTextBox)
        sendername.SelectionStart = 0
    End Sub

End Class