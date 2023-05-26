Public Class TDB_TESZ
    Private Sub TDB_TESZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Kepviselo_minosegeTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Kepviselo_minosege)
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Hozzáférési hiba! A törzsadatbázis nem érhető el!", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        Me.HelysegTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Helyseg)
        Me.TitulusTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Titulus)
        Me.Orszag_koddalTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Orszag_koddal)
        Me.KozteruletTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Kozterulet)
        Me.RogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Term_szemely_rogzito)
        Me.ToolStrip_Termsz.Visible = False
        If Me.MyBindingSource.Current Is Nothing Then
            Me.TableLayoutPanel1.Enabled = False
        Else
            Me.TableLayoutPanel1.Enabled = True
        End If
        If Screen.PrimaryScreen.WorkingArea.Height < 756 Then Me.WindowState = FormWindowState.Maximized

        AddCustomSource()

    End Sub
    Private Sub MyBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MyBindingSource.CurrentChanged
        If Me.MyBindingSource.Current Is Nothing Then
            Me.TableLayoutPanel1.Enabled = False
        Else
            Me.TableLayoutPanel1.Enabled = True
        End If
    End Sub

    Private Sub Cég_Click(sender As Object, e As EventArgs) Handles ToolStrip_Cég.Click
        Me.Dispose()
        Forms.TDB_Ceg.ShowDialog()
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


    Private Sub btnBezaresMent_Click(sender As Object, e As EventArgs) Handles btnBezaresMent.Click
        Me.Validate()
        Me.MyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TorzsAdatbazisDataSet)
        Me.Refresh()

        Dim TeljesNevStr As String = String.Empty
        Dim IDStr = Me.IDTextBox.Text
        If IDStr = "-1" Then
            Dim lastrow As DataRow() = Me.TorzsAdatbazisDataSet.Term_szemely_rogzito.Select("ID=Max(ID)")
            Dim idint As Integer = lastrow(0)("ID")
            idint += 1
            IDStr = CStr(idint)
        End If

        Dim Nevek As New List(Of String)
        'Nevek.Add(Viselt_név_TitulusComboBox.Text) 'Mivel csak az FPK24-nél és csak az adós megnevezésénél van benne a teljes névben a titulus is, minden más esetben, legyen szó felperes stb., van külön titulus mező is
        Nevek.Add(Viselt_név_Családi_névTextBox.Text)
        Nevek.Add(Viselt_név_Első_utónévTextBox.Text)
        Nevek.Add(Viselt_név_További_utónevekTextBox.Text)
        TeljesNevStr = GetTeljesNevDef(Nevek)
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



    Private Sub Adóazonosító_jel_validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AdóazonosítóMaskedBox.Validating
        If AdóazonosítóMaskedBox.Text.Length <> 10 Then
            AdóazonosítóMaskedBox.Text = ""
            ErrorProvider1.SetError(AdóazonosítóMaskedBox, "Nem megfelelő adóazonosító hossz!")
            Exit Sub
        End If
        Dim n As Integer = 0
        For i As Integer = 0 To 8
            n += (i + 1) * (Convert.ToInt16(AdóazonosítóMaskedBox.Text(i).ToString()))
        Next
        Dim nl As Integer = n Mod 11
        If nl = 10 Then nl = 0
        Dim b As Integer
        b = Convert.ToInt16(AdóazonosítóMaskedBox.Text(9).ToString())
        If nl <> b Then
            AdóazonosítóMaskedBox.Text = String.Empty
            ErrorProvider1.SetError(AdóazonosítóMaskedBox, "Hibás adóazonosító jel")
            Exit Sub
        End If
        ErrorProvider1.SetError(AdóazonosítóMaskedBox, "")
    End Sub

    Private Sub ResetComboBox()
        For Each ctrl As Control In Me.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                Dim cbox As ComboBox
                cbox = CType(ctrl, ComboBox)
                cbox.Text = ""
            End If
        Next
        Me.Teljes_neveTextBox.Text = ""
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

    Private Sub Születési_idejeMaskedBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Születési_idejeMaskedBox.Validating
        Születési_idejeMaskedBox.Text = Születési_idejeMaskedBox.Text.Replace(".", "")
        Születési_idejeMaskedBox.Text = Születési_idejeMaskedBox.Text.Replace("/", "")
        Dim Ev As String = Microsoft.VisualBasic.Left(Születési_idejeMaskedBox.Text, 4)
        Dim Honap As String = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Mid(Születési_idejeMaskedBox.Text, 5), 2)
        Dim Nap As String = Microsoft.VisualBasic.Right(Születési_idejeMaskedBox.Text, 2)
        If Ev = String.Empty Or Honap = String.Empty Or Nap = String.Empty Then Exit Sub
        If CInt(Honap) > 12 Then Honap = "12"
        If CInt(Nap) > 28 Then
            Dim TestDate As Date
            Try
                TestDate = Microsoft.VisualBasic.DateValue(Ev & "." & Honap & "." & Nap)
            Catch
                If TestDate = DateTime.MinValue Then Nap = Replace(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.DateSerial(CInt(Ev), CInt(Honap + 1), 0), 3), ".", "")
            End Try

        End If
        Születési_idejeMaskedBox.Text = Ev & Honap & Nap
    End Sub

    Private Sub Viselt_név_TitulusComboBox_TextChanged(sender As Object, e As EventArgs) Handles Viselt_név_TitulusComboBox.TextChanged, Viselt_név_Családi_névTextBox.TextChanged, Viselt_név_Első_utónévTextBox.TextChanged, Viselt_név_További_utónevekTextBox.TextChanged
        GetTeljesNev()
    End Sub

    Private Sub GetTeljesNev()
        Dim Nevek As New List(Of String)
        'Nevek.Add(Viselt_név_TitulusComboBox.Text)
        Nevek.Add(Viselt_név_Családi_névTextBox.Text)
        Nevek.Add(Viselt_név_Első_utónévTextBox.Text)
        Nevek.Add(Viselt_név_További_utónevekTextBox.Text)
        Dim TeljesNev As String = GetTeljesNevDef(Nevek)
        If TeljesNev <> "" Then Teljes_neveTextBox.Text = Strings.Left(TeljesNev, 100)
    End Sub

    Private Sub IrszámIgazitas(sender As Object, e As EventArgs) Handles Állandólakcím_IrányítószámComboBox.Validating, Levelezési_címe_IrányítószámComboBox.Validating
        Dim senderbox As ComboBox = CType(sender, ComboBox)
        If senderbox.Items.Count = 0 Then Exit Sub
        If Állandólakcím_Település_neveComboBox.Items.Count = 0 Then Exit Sub
        If Levelezési_címe_Település_neveComboBox.Items.Count = 0 Then Exit Sub

        Dim sendername As String = Strings.Left(senderbox.Name, 3)
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
            If sendername = "Áll" Then
                Állandólakcím_Település_neveComboBox.SelectedValue = row.Item("Helyseg")
            End If
            If sendername = "Lev" Then
                Levelezési_címe_Település_neveComboBox.SelectedValue = row.Item("Helyseg")
            End If
        End If
    End Sub
    Private Sub Település_neveComboBox_Change(sender As Object, e As EventArgs) Handles Állandólakcím_Település_neveComboBox.Validating, Levelezési_címe_Település_neveComboBox.Validating
        Dim senderbox As ComboBox = CType(sender, ComboBox)
        If senderbox.Items.Count = 0 Then Exit Sub
        If Állandólakcím_Település_neveComboBox.Items.Count = 0 Then Exit Sub
        If Levelezési_címe_Település_neveComboBox.Items.Count = 0 Then Exit Sub

        Dim sendername As String = Strings.Left(senderbox.Name, 3)
        'If senderbox.SelectedValue = "" Or senderbox.SelectedValue Is DBNull.Value Then Exit Sub
        Dim row As DataRow = NyomtatvanyAdatokDataSet.Helyseg.Select("Helyseg = " & "'" & senderbox.SelectedValue & "'").FirstOrDefault
        If row Is Nothing Then
            senderbox.Text = ""
            senderbox.SelectedValue = DBNull.Value
            Exit Sub
        End If
        If Not row Is Nothing Then
            If sendername = "Áll" Then
                If Strings.Left(Állandólakcím_IrányítószámComboBox.SelectedValue, 3) <> Strings.Left(row.Item("Irszam"), 3) And Strings.Left(row.Item("Irszam"), 1) <> "1" Then Állandólakcím_IrányítószámComboBox.SelectedValue = row.Item("Irszam")

            End If
            If sendername = "Lev" Then
                If Strings.Left(Levelezési_címe_IrányítószámComboBox.SelectedValue, 3) <> Strings.Left(row.Item("Irszam"), 3) And Strings.Left(row.Item("Irszam"), 1) <> "1" Then Levelezési_címe_IrányítószámComboBox.SelectedValue = row.Item("Irszam")
            End If
        End If

    End Sub



    Private Sub btnCopyÁllandóLevbe_Click(sender As Object, e As EventArgs) Handles btnCopyÁllandóLevbe.Click
        Try
            Me.Levelezési_címe_AjtóTextBox.Text = Me.Állandólakcím_AjtóTextBox.Text
        Catch
        End Try
        Try
            Me.Levelezési_címe_EmeletTextBox.Text = Me.Állandólakcím_EmeletTextBox.Text
        Catch
        End Try
        Try
            Me.Levelezési_címe_Közterület_neveTextBox.Text = Me.Állandólakcím_Közterület_neveTextBox.Text
        Catch
        End Try
        Try
            Me.Levelezési_címe_Közterület_jellegeComboBox.Text = Me.Állandólakcím_Közterület_jellegeComboBox.Text
        Catch ex As Exception
        End Try
        Try
            Me.Levelezési_címe_LépcsőházTextBox.Text = Me.Állandólakcím_LépcsőházTextBox.Text
        Catch
        End Try
        Try
            Me.Levelezési_címe_HázszámTextBox.Text = Me.Állandólakcím_HázszámTextBox.Text
        Catch ex As Exception
        End Try
        Try
            Me.Levelezési_címe_ÉpületTextBox.Text = Me.Állandólakcím_ÉpületTextBox.Text
        Catch ex As Exception
        End Try
        Try
            Me.Levelezési_címe_Település_neveComboBox.Text = Me.Állandólakcím_Település_neveComboBox.Text
        Catch
        End Try
        Try
            Me.Levelezési_címe_IrányítószámComboBox.SelectedValue = Me.Állandólakcím_IrányítószámComboBox.SelectedValue
            'Me.Levelezési_címe_IrányítószámComboBox.Text = Me.Állandólakcím_IrányítószámComboBox.Text
        Catch
        End Try
    End Sub

    Private Sub Születési_idejeMaskedBox_MouseClick(sender As Object, e As MouseEventArgs) Handles Születési_idejeMaskedBox.MouseClick, AdóazonosítóMaskedBox.MouseClick
        Dim mesender = DirectCast(sender, MaskedTextBox)
        mesender.SelectionStart = 0
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

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        MyBindingSource.AddNew()
        ResetComboBox()
    End Sub

    Private Sub btnKeres_Click(sender As Object, e As EventArgs) Handles btnKeres.Click
        Dim IDtoGo As Integer = GetResultsfromPersonDT(TorzsAdatbazisDataSet.Term_szemely_rogzito, tbKereso.Text)
        If IDtoGo <> 0 Then
            Try
                MyBindingSource.Position = MyBindingSource.Find("ID", IDtoGo)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub AddCustomSource()
        Dim fullnevlist As New List(Of String)
        For Each drow In Me.TorzsAdatbazisDataSet.Term_szemely_rogzito
            If drow.Teljes_név IsNot Nothing AndAlso Not IsDBNull(drow.Teljes_név) AndAlso Not String.IsNullOrWhiteSpace(drow.Teljes_név) Then fullnevlist.Add(drow.Teljes_név)
        Next
        fullnevlist = fullnevlist.Distinct.ToList
        fullnevlist.Sort()
        Dim ac As New AutoCompleteStringCollection
        ac.AddRange(fullnevlist.ToArray)
        tbKereso.AutoCompleteCustomSource = ac
    End Sub

End Class