Public Class DecryptChooser
    Private Sub btnDecryptPathNow_Click(sender As Object, e As EventArgs) Handles btnDecryptPathNow.Click
        Dim filtername As String = String.Empty
        Dim mitvalasztneve As String = String.Empty
        Dim checkvalpath As String = String.Empty
        Dim settingsname As String = String.Empty
        Dim tbname As String = String.Empty
        filtername = "prv.asc"
        mitvalasztneve = "kititkosításhoz használt privát"
        settingsname = "DecryptKeyPath"
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
            TempDecryptKeyPath = openFileDialog1.FileName
            MyLoader.AddLogBook(Fnc.cfg, "A " & mitvalasztneve & " kulcs kiválasztva: " & TempDecryptKeyPath, LogTip.siker)
            tbDecryptPathNow.Text = TempDecryptKeyPath
        End If
    End Sub

    Private Sub mbDecryptPasswNow_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mbDecryptPasswNow.Validating, mbDecryptPasswNowConfirm.Validating
        Dim sendingTbox = DirectCast(sender, TextBox)
        Dim senderctrl = DirectCast(sender, Control)
        Dim ErrorMsg As String = String.Empty
        ErrorProvider1.SetError(senderctrl, String.Empty)
        If sendingTbox.Name = "mbDecryptPasswNowConfirm" And sendingTbox.Text <> Me.mbDecryptPasswNow.Text Then
            sendingTbox.Text = ""
            ErrorProvider2.SetError(mbDecryptPasswNow, "A két jelszó nem egyezik!")
        Else
            ErrorProvider2.SetError(mbDecryptPasswNow, String.Empty)
        End If

    End Sub

    Private Sub mbDecryptPasswNow_MouseClicked(sender As Object, e As MouseEventArgs) Handles mbDecryptPasswNow.MouseClick
        Dim mesender = DirectCast(sender, TextBox)
        mesender.SelectionStart = 0
    End Sub

    Private Sub mbDecryptPasswNowConfirm_MouseClicked(sender As Object, e As MouseEventArgs) Handles mbDecryptPasswNowConfirm.MouseClick
        Dim mesender = DirectCast(sender, TextBox)
        mesender.SelectionStart = 0
    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If File.Exists(TempDecryptKeyPath) Then
            ErrorProvider1.SetError(tbDecryptPathNow, "")
            TempDecryptPassw = mbDecryptPasswNow.Text
            DialogResult = DialogResult.OK
        End If
        If File.Exists(TempDecryptKeyPath) = False Then
            ErrorProvider1.SetError(tbDecryptPathNow, "Hiányzó kititkosítókulcs!")
            Exit Sub
        End If
        Me.Close()
    End Sub


    Private Sub tbDragEnter(sender As Object, e As DragEventArgs) Handles tbDecryptPathNow.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub


    Private Sub tbDragDrop(sender As Object, e As DragEventArgs) Handles tbDecryptPathNow.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim tbToUse As TextBox = CType(sender, TextBox)
        For Each filenametoproc In files
            If File.Exists(filenametoproc) And Path.GetExtension(filenametoproc) = ".asc" Then
                tbToUse.Text = filenametoproc
                Exit Sub
            End If
        Next
    End Sub


End Class