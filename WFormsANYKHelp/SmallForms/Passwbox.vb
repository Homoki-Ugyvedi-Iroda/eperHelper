Public Class Passwbox
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        mbDecryptPasswNow.Clear()
        mbDecryptPasswNowConfirm.Clear()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If mbDecryptPasswNow.Text <> "" Then
            TempDecryptPassw = mbDecryptPasswNow.Text
            DialogResult = DialogResult.OK
            Me.Close()
        Else Exit Sub
        End If
    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub mbDecryptPasswNowConfirm_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mbDecryptPasswNowConfirm.Validating, mbDecryptPasswNow.Validating
        Dim sendingTbox = DirectCast(sender, TextBox)
        Dim senderctrl = DirectCast(sender, Control)
        Dim ErrorMsg As String = String.Empty
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProvider1.SetError(senderctrl, String.Empty)
        If sendingTbox.Name = "mbDecryptPasswNowConfirm" And sendingTbox.Text <> Me.mbDecryptPasswNow.Text Then
            sendingTbox.Text = ""
            ErrorProvider2.SetError(mbDecryptPasswNow, "A két jelszó nem egyezik!")
        Else
            ErrorProvider2.SetError(mbDecryptPasswNow, String.Empty)
        End If

    End Sub

    Private Sub mbDecryptPasswNow_GotFocus(sender As Object, e As MouseEventArgs)
        Dim mesender = DirectCast(sender, TextBox)
        mesender.SelectionStart = 0
    End Sub

    Private Sub mbDecryptPasswNowConfirm_GotFocus(sender As Object, e As MouseEventArgs)
        Dim mesender = DirectCast(sender, TextBox)
        mesender.SelectionStart = 0
    End Sub


    Private Sub Passwbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mbDecryptPasswNow.Clear()
        mbDecryptPasswNowConfirm.Clear()
        '#1 hiba?
    End Sub


End Class