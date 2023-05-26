Public Class TitkositoKulcsBeallitasa
    Public Sub New()

        InitializeComponent()
        If My.Settings.DecryptKeyPath <> String.Empty Then tbDecryptPathNow.Text = My.Settings.DecryptKeyPath
        If My.Settings.EncryptKeyPath <> String.Empty Then tbEncryptPathNow.Text = My.Settings.EncryptKeyPath
        If My.Settings.PkeyPassw <> String.Empty Then mbDecryptPasswNow.Text = Kapukezelo.Decrypt(My.Settings.PkeyPassw, "PkeyPassw")
        tbNewKeyPairFolder.Text = My.Settings.AccessibleUserSettings
        Select Case My.Settings.AtvegyeANYKbolTitkositot
            Case "Yes"
                cbxAtvegyeANYKboltitkositot.Checked = True
            Case "No", String.Empty
                cbxAtvegyeANYKboltitkositot.Checked = False
        End Select

    End Sub

    Private Sub btnBezar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Public Sub btnCreateNewKeyPair_Click(sender As Object, e As EventArgs) Handles btnCreateNewKeyPair.Click

        If Not Directory.Exists(tbNewKeyPairFolder.Text) Or mbDecryptPasswNew.Text = String.Empty Or tbNewKeyPairName.Text = String.Empty Then Exit Sub
        Dim logtipus As String = String.Empty
        Dim jelszo As String = mbDecryptPasswNew.Text
        Dim pubkey As String = tbNewKeyPairFolder.Text & Path.DirectorySeparatorChar & tbNewKeyPairName.Text & "_pub.asc"
        Dim seckey As String = tbNewKeyPairFolder.Text & Path.DirectorySeparatorChar & tbNewKeyPairName.Text & "_priv.asc"

        Dim krtitokprocess As New Process
        SetKrProc(krtitokprocess)
        krtitokprocess.StartInfo.Arguments = KriptoWrapper & " -cmd=keygen " & "-jelszo=" & Chr(34) & jelszo & Chr(34) & " -keypairname=" & Chr(34) & tbNewKeyPairName.Text & Chr(34) & " -secretkeyname=" & Chr(34) & seckey & Chr(34) & " -publickeyname=" & Chr(34) & pubkey & Chr(34)
        krtitokprocess.Start()
        'Dim ErrorString = krtitokprocess.StandardError.ReadToEnd()
        Dim OutputString = krtitokprocess.StandardOutput.ReadToEnd()
        'File.WriteAllText(MyLog & ".errorlog", ErrorString)
        'File.WriteAllText(MyLog & ".outputlog", OutputString)
        krtitokprocess.WaitForExit(1000)

        Dim uzenet As String = String.Empty
        If krtitokprocess.ExitCode = 0 Then
            uzenet = "Sikeres titkosító kulcspár generálás."
            My.Settings.DecryptKeyPath = seckey
            My.Settings.EncryptKeyPath = pubkey
            My.Settings.PkeyPassw = Kapukezelo.Encrypt(jelszo, "PkeyPassw")
            My.Settings.Save()
            logtipus = LogTip.siker
            tbDecryptPathNow.Text = seckey
            tbEncryptPathNow.Text = pubkey
            mbDecryptPasswNow.Text = jelszo
            tbNewKeyPairFolder.Text = ""
            tbNewKeyPairName.Text = ""
            mbDecryptPasswNew.Text = ""
            mbDecryptPasswNewConfirm.Text = ""
        Else
            uzenet = OutputString
            If uzenet.Contains("Hiba (keygen): nem jó a megadott útvonalak egyike!") Then
                uzenet = "A titkosító kulcspár generálása nem sikerült: nem jó a megadott útvonalak egyike!"
            ElseIf uzenet.Contains("Hiba (keygen): kititkosító kulcs értelmezési hiba!") Then
                uzenet = "A titkosító üzenet generálása nem sikerült, mert a kititkosító kulcs nem volt értelmezhető, hibakód: " & uzenet
            Else uzenet = "A titkosító üzenet generálása nem sikerült, hibakód: " & uzenet
            End If
            logtipus = LogTip.err
        End If
        krtitokprocess.Close()
        If Not krtitokprocess Is Nothing Then krtitokprocess.Dispose()
        MyLoader.AddLogBook(Fnc.cfg, uzenet, logtipus)
        MsgBox(uzenet, MsgBoxStyle.OkOnly)

    End Sub

    Private Sub mbDecryptPasswNow_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mbDecryptPasswNew.Validating, mbDecryptPasswNewConfirm.Validating, mbDecryptPasswNow.Validating, mbDecryptPasswNowConfirm.Validating
        Dim sendingTbox = DirectCast(sender, TextBox)
        Dim senderctrl = DirectCast(sender, Control)
        Dim ErrorMsg As String = String.Empty
        ErrorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProvider1.SetError(senderctrl, String.Empty)
        If sendingTbox.Name = "mbDecryptPasswNewConfirm" And sendingTbox.Text <> Me.mbDecryptPasswNew.Text Then
            ErrorProvider2.SetError(mbDecryptPasswNew, "A két jelszó nem egyezik!")
            sendingTbox.Text = ""
        Else
            ErrorProvider2.SetError(mbDecryptPasswNew, String.Empty)
        End If
        If sendingTbox.Name = "mbDecryptPasswNowConfirm" And sendingTbox.Text <> Me.mbDecryptPasswNow.Text Then
            sendingTbox.Text = ""
            ErrorProvider2.SetError(mbDecryptPasswNow, "A két jelszó nem egyezik!")
        Else
            ErrorProvider2.SetError(mbDecryptPasswNow, String.Empty)
        End If

    End Sub


    Public Sub btnDecryptEncryptPathNow_Click(sender As Object, e As EventArgs) Handles btnEncryptPathNow.Click, btnDecryptPathNow.Click
        Dim sendername = DirectCast(sender, Button)
        Dim filtername As String = String.Empty
        Dim mitvalasztneve As String = String.Empty
        Dim checkvalpath As String = String.Empty
        Dim settingsname As String = String.Empty
        Dim tbname As String = String.Empty
        If sendername.Name = "btnEncryptPathNow" Then
            filtername = "pub.asc"
            mitvalasztneve = "betitkosításhoz használt nyilvános"
            settingsname = "EncryptKeyPath"
            checkvalpath = My.Settings.EncryptKeyPath
        Else
            filtername = "prv.asc"
            mitvalasztneve = "kititkosításhoz használt privát"
            checkvalpath = My.Settings.DecryptKeyPath
            settingsname = "DecryptKeyPath"
        End If
        Dim dialogresult As New DialogResult
        Dim ValasztottFajl = String.Empty
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "ASC-fájl|*_" & filtername
        openFileDialog1.Title = "Válassza ki a " & mitvalasztneve & " kulcsot!"
        openFileDialog1.RestoreDirectory = True
        If File.Exists(checkvalpath) Then
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(checkvalpath)
            openFileDialog1.FileName = checkvalpath
        End If
        openFileDialog1.DefaultExt = "asc"
        dialogresult = openFileDialog1.ShowDialog()
        If dialogresult = DialogResult.OK Then
            ValasztottFajl = openFileDialog1.FileName
            CallByName(My.Settings, settingsname, CallType.Set, ValasztottFajl)
            My.Settings.Save()
            MyLoader.AddLogBook(Fnc.cfg, "A " & mitvalasztneve & " kulcs kiválasztva: " & ValasztottFajl, LogTip.siker)
            tbEncryptPathNow.Text = My.Settings.EncryptKeyPath
            tbDecryptPathNow.Text = My.Settings.DecryptKeyPath
        End If
    End Sub

    Private Sub tbNewKeyPairName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNewKeyPairName.Validating
        tbNewKeyPairName.Text = CleanPathandFileName(tbNewKeyPairName.Text)
    End Sub

    Public Sub btnNewKeyPairFolder_Click(sender As Object, e As EventArgs) Handles btnNewKeyPairFolder.Click
        Dim dialogresult As New DialogResult
        Dim ValasztottFajl = String.Empty
        Dim openFolderDialog1 As New FolderBrowserDialog()
        If Directory.Exists(tbNewKeyPairFolder.Text) Then openFolderDialog1.SelectedPath = tbNewKeyPairFolder.Text
        openFolderDialog1.Description = "Válassza ki azt a könyvtárat, ahol elhelyezzük a létrehozandó kulcspárat!"
        dialogresult = openFolderDialog1.ShowDialog
        If dialogresult = DialogResult.OK Then
            tbNewKeyPairFolder.Text = openFolderDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click
        My.Settings.Reload()
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If mbDecryptPasswNow.Text <> String.Empty And My.Settings.PkeyPassw = String.Empty Then
            My.Settings.PkeyPassw = Kapukezelo.Encrypt(mbDecryptPasswNow.Text, "PkeyPassw")
            My.Settings.Save()
        End If

        If mbDecryptPasswNow.Text <> Kapukezelo.Decrypt(My.Settings.PkeyPassw, "PkeyPassw") Then
            My.Settings.PkeyPassw = Kapukezelo.Encrypt(mbDecryptPasswNow.Text, "PkeyPassw")
            My.Settings.Save()
        End If
        If tbEncryptPathNow.Text = String.Empty Then
            My.Settings.EncryptKeyPath = String.Empty
            MyLoader.AddLogBook(Fnc.cfg, "A kiválasztott betitkosító kulcs törölve", LogTip.norm)
            My.Settings.Save()
        End If
        If tbDecryptPathNow.Text = String.Empty Then
            My.Settings.DecryptKeyPath = String.Empty
            MyLoader.AddLogBook(Fnc.cfg, "A kiválasztott kititkosító kulcs törölve", LogTip.norm)
            My.Settings.Save()
        End If

        Me.Close()
    End Sub

    Private Sub Passw_GotFocus(sender As Object, e As MouseEventArgs)
        Dim mesender = DirectCast(sender, TextBox)
        mesender.SelectionStart = 0
    End Sub

    Private Sub tbDragEnter(sender As Object, e As DragEventArgs) Handles tbEncryptPathNow.DragEnter, tbDecryptPathNow.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub


    Private Sub tbDragDrop(sender As Object, e As DragEventArgs) Handles tbEncryptPathNow.DragDrop, tbDecryptPathNow.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim tbToUse As TextBox = CType(sender, TextBox)
        For Each filenametoproc In files
            If File.Exists(filenametoproc) And Path.GetExtension(filenametoproc) = ".asc" Then
                tbToUse.Text = filenametoproc
                Exit Sub
            End If
        Next
    End Sub

    Private Sub btnTorlesKulcsok_Click(sender As Object, e As EventArgs) Handles btnTorlesKulcsok.Click
        Me.tbDecryptPathNow.Text = String.Empty
        Me.tbEncryptPathNow.Text = String.Empty
    End Sub

    Private Sub cbxAtvegyeANYKboltitkositot_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAtvegyeANYKboltitkositot.CheckedChanged
        If cbxAtvegyeANYKboltitkositot.Checked Then My.Settings.AtvegyeANYKbolTitkositot = "Yes" Else My.Settings.AtvegyeANYKbolTitkositot = "No"
        My.Settings.Save()
    End Sub


End Class