Public Class TDB_Ceg

    Private Sub TDB_Ceg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CegformaTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Cegforma)
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Hozzáférési hiba! A törzsadatbázis nem érhető el!", MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Me.Kepviselo_minosegeTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Kepviselo_minosege)
        Me.HelysegTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Helyseg)
        Me.TitulusTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Titulus)
        Me.Orszag_koddalTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Orszag_koddal)
        Me.KozteruletTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Kozterulet)
        Me.RogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ceg_rogzito)
        Me.ToolStrip_Cég.Visible = False
        If Me.MyBindingSource.Current Is Nothing Then
            Me.TableLayoutPanel1.Enabled = False
        Else
            Me.TableLayoutPanel1.Enabled = True
        End If
        ErrorProvider1.Clear()
        If Screen.PrimaryScreen.WorkingArea.Height < 756 Then Me.WindowState = FormWindowState.Maximized
        AddCustomSource
    End Sub

    Private Sub MyBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MyBindingSource.CurrentChanged
        If Me.MyBindingSource.Current Is Nothing Then
            Me.TableLayoutPanel1.Enabled = False
        Else
            Me.TableLayoutPanel1.Enabled = True
        End If
    End Sub

    Private Sub ToolStrip_Ügyvéd_Click(sender As Object, e As EventArgs) Handles ToolStrip_Ügyvéd.Click
        Me.Dispose()
        Forms.TDB_EU.ShowDialog()
    End Sub

    Private Sub ToolStrip_Jogtanácsos_Click(sender As Object, e As EventArgs) Handles ToolStrip_Jogtanácsos.Click
        Me.Dispose()
        Forms.TDB_JT.ShowDialog()
    End Sub

    Private Sub ToolStrip_Egyébjogiképviselő_Click(sender As Object, e As EventArgs) Handles ToolStrip_Egyébjogiképviselő.Click
        Me.Dispose()
        Forms.TDB_EJKV.ShowDialog()
    End Sub

    Private Sub ToolStrip_Üi_Click(sender As Object, e As EventArgs) Handles ToolStrip_Üi.Click
        Me.Dispose()
        Forms.TDB_UI.ShowDialog()

    End Sub
    Private Sub ToolStrip_EV_Click(sender As Object, e As EventArgs) Handles ToolStrip_EV.Click
        Me.Dispose()
        Forms.TDB_EV.ShowDialog()

    End Sub
    Private Sub ToolStrip_ESZ_Click(sender As Object, e As EventArgs) Handles ToolStrip_ESZ.Click
        Me.Dispose()
        Forms.TDB_ESZ.ShowDialog()

    End Sub
    Private Sub ToolStrip_Termsz_Click(sender As Object, e As EventArgs) Handles ToolStrip_Termsz.Click
        Me.Dispose()
        Forms.TDB_TESZ.ShowDialog()
    End Sub
    Private Sub btnBezaresMent_Click(sender As Object, e As EventArgs) Handles btnBezaresMent.Click
        Me.Validate()
        Me.MyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TorzsAdatbazisDataSet)
        Me.Refresh()
        Dim IDStr As String = Me.IDTextBox.Text
        If IDStr = "-1" Then
            Dim lastrow As DataRow() = Me.TorzsAdatbazisDataSet.Ceg_rogzito.Select("ID=Max(ID)")
            Dim idint As Integer = lastrow(0)("ID")
            idint += 1
            IDStr = CStr(idint)
        End If
        Dim TeljesNevStr As String = Me.Cég_neveTextBox.Text
        '(New System.Windows.Forms.Binding("Text", Me.MyBindingSource, "ID", True)
        KitoltPass = {IDStr, TeljesNevStr}

        Me.Close()
    End Sub

    Private Sub btnBezarNemMent_Click(sender As Object, e As EventArgs) Handles btnBezarNemMent.Click
        Me.Close()
    End Sub

    Private Sub Elérhetőségek_E_mail_címTextBox_Validating(sender As Object, e As EventArgs) Handles Elérhetőségek_E_mail_címTextBox.Validating
        If Not EmailValid(Me.Elérhetőségek_E_mail_címTextBox.Text) Then
            ErrorProvider1.SetError(sender, "Az emailcímnek tartalmaznia kell pontot ('.') és '@' jelet.")
            Me.Elérhetőségek_E_mail_címTextBox.Text = ""
        Else
            ErrorProvider1.Clear()
        End If
    End Sub
    Private Sub IrszámIgazitas(sender As Object, e As EventArgs) Handles Székhely_IrányítószámComboBox.Validating
        Dim senderbox As ComboBox = CType(sender, ComboBox)
        'If senderbox.Items.Count = 0 Or Székhely_Település_neveComboBox.Items.Count = 0 Or senderbox.Text = "" Or senderbox.Text Is DBNull.Value Then Exit Sub

        Dim IrszamStr As String = Strings.Left(senderbox.Text, 4)
        Dim IrszamInt As Integer
        If IrszamStr = "" Then Exit Sub
        Try
            IrszamInt = CType(IrszamStr, Integer)
        Catch ex As System.InvalidCastException
            senderbox.Text = ""
            senderbox.SelectedValue = DBNull.Value
            Exit Sub
        End Try

        Dim row As DataRow = NyomtatvanyAdatokDataSet.Helyseg.Select("Irszam = " & IrszamInt).FirstOrDefault
        If row Is Nothing Then
            senderbox.SelectedValue = DBNull.Value
            senderbox.Text = ""
        End If
        If Not row Is Nothing Then
            Székhely_Település_neveComboBox.SelectedValue = row.Item("Helyseg")
        End If
    End Sub
    Private Sub Település_neveComboBox_Change(sender As Object, e As EventArgs) Handles Székhely_Település_neveComboBox.Validating
        Dim senderbox As ComboBox = CType(sender, ComboBox)
        'If senderbox.Items.Count = 0 Or Székhely_IrányítószámComboBox.Items.Count = 0 Then Exit Sub
        Dim row As DataRow = NyomtatvanyAdatokDataSet.Helyseg.Select("Helyseg = " & "'" & senderbox.SelectedValue & "'").FirstOrDefault
        If row Is Nothing Then
            senderbox.Text = ""
            senderbox.SelectedValue = DBNull.Value
            Exit Sub
        End If
        If Not row Is Nothing Then
            senderbox.SelectedValue = row.Item("Helyseg")
            If Strings.Left(Székhely_IrányítószámComboBox.SelectedValue, 3) <> Strings.Left(row.Item("Irszam"), 3) And Strings.Left(row.Item("Irszam"), 1) <> "1" Then Székhely_IrányítószámComboBox.SelectedValue = row.Item("Irszam")
        End If
    End Sub

    Private Sub AdószámMaskedBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AdószámMaskedBox.Validating
        Dim result As Adószámhiba = ANYHelpModule.AdószámValidator(AdószámMaskedBox.Text)
        Dim hibaszoveg As String = String.Empty
        Select Case result
            Case Adószámhiba.Hossz
                hibaszoveg = "Hibás adószám: nem megfelelő adószám hossz!"
            Case Adószámhiba.EllenorzoSzam
                hibaszoveg = "Hibás adószám: ellenőrzőszám hiba!"
            Case Adószámhiba.AFAKod
                hibaszoveg = "Hibás adószám: áfakód hiba!"
            Case Adószámhiba.TeruletiKod
                hibaszoveg = "Hibás adószám: területi kód hiba!"
        End Select
        If hibaszoveg <> String.Empty Then
            AdószámMaskedBox.Text = String.Empty
            ErrorProvider1.SetError(AdószámMaskedBox, hibaszoveg)
        Else
            ErrorProvider1.SetError(AdószámMaskedBox, String.Empty)
        End If
    End Sub

    Private Sub CégjegyzékszámMaskedBox_MouseClick(sender As Object, e As MouseEventArgs) Handles Fizetési_számlaszámMaskedBox.MouseClick, CégjegyzékszámMaskedBox.MouseClick, AdószámMaskedBox.MouseClick
        Dim mesender = DirectCast(sender, MaskedTextBox)
        mesender.SelectionStart = 0
    End Sub

    Private Sub Fizetési_számlaszámMaskedBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Fizetési_számlaszámMaskedBox.Validating
        If Fizetési_számlaszámMaskedBox.Text.Length < 16 Then
            ErrorProvider1.SetError(Fizetési_számlaszámMaskedBox, "Nem megfelelő hossz")
        Else
            ErrorProvider1.SetError(Fizetési_számlaszámMaskedBox, "")
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        ResetComboBox()
        ErrorProvider1.Clear()
    End Sub

    Private Sub ResetComboBox()
        For Each ctrl As Control In Me.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                Dim cbox As ComboBox
                cbox = CType(ctrl, ComboBox)
                cbox.Text = ""
            End If
        Next
    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim Answer As MsgBoxResult
        Answer = MsgBox("Biztosan törli a rekordot?", vbYesNo)
        If Answer = vbYes And MyBindingSource.Current IsNot Nothing Then MyBindingSource.RemoveCurrent()
    End Sub
    Private Sub BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TorzsAdatbazisDataSet)
        AddCustomSource()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case (Keys.PageDown)
                MyBindingNavigator.MoveNextItem.PerformClick()
            Case (Keys.PageUp)
                MyBindingNavigator.MovePreviousItem.PerformClick()
            Case (Keys.Up)
                If ActiveControl.GetType IsNot GetType(ComboBox) Then Me.SelectNextControl(ActiveControl, False, True, True, True)
                'Különben a föl-le gomb módosítja is egyúttal a ComboBox értékét
            Case (Keys.Down)
                If ActiveControl.GetType IsNot GetType(ComboBox) Then Me.SelectNextControl(ActiveControl, True, True, True, True)
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Cég_neveTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Cég_neveTextBox.Validating
        If Cég_neveTextBox.Text.EndsWith(" Kft.") Then CégformaComboBox.SelectedValue = "Korlátolt felelősségű társaság"
        If Cég_neveTextBox.Text.EndsWith(" Bt.") Then CégformaComboBox.SelectedValue = "Betéti társaság"
        If Cég_neveTextBox.Text.EndsWith(" Nyrt.") Then CégformaComboBox.SelectedValue = "Nyilvánosan működő részvénytársaság"
        If Cég_neveTextBox.Text.EndsWith(" Zrt.") Then CégformaComboBox.SelectedValue = "Zártkörűen működő részvénytársaság"

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        ErrorProvider1.Clear()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        ErrorProvider1.Clear()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        ErrorProvider1.Clear()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        ErrorProvider1.Clear()
    End Sub

    Private Sub btnKeres_Click(sender As Object, e As EventArgs) Handles btnKeres.Click
        Dim IDtoGo As Integer = GetResultsfromPersonDT(TorzsAdatbazisDataSet.Ceg_rogzito, tbKereso.Text)
        If IDtoGo = 0 Then Exit Sub
        Try
            MyBindingSource.Position = MyBindingSource.Find("ID", IDtoGo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AddCustomSource()
        Dim fullnevlist As New List(Of String)
        For Each drow In Me.TorzsAdatbazisDataSet.Ceg_rogzito
            If drow.Cég_neve IsNot Nothing AndAlso Not IsDBNull(drow.Cég_neve) AndAlso Not String.IsNullOrWhiteSpace(drow.Cég_neve) Then fullnevlist.Add(drow.Cég_neve)
        Next
        fullnevlist = fullnevlist.Distinct.ToList
        fullnevlist.Sort()
        Dim ac As New AutoCompleteStringCollection
        ac.AddRange(fullnevlist.ToArray)
        tbKereso.AutoCompleteCustomSource = ac
    End Sub

End Class