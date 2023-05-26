Public Class TDB_JT
    Dim CsaladnevList As New List(Of String), ElsoUtonevList As New List(Of String), TovabbiUtonevList As New List(Of String)

    Private Sub TDB_JT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.HelysegTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Helyseg)
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Hozzáférési hiba! A törzsadatbázis nem érhető el!", MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Me.TitulusTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Titulus)
        Me.KozteruletTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Kozterulet)
        Me.RogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Jogtanacsos_rogzito)
        Me.ToolStrip_Jogtanácsos.Visible = False
        If Me.MyBindingSource.Current Is Nothing Then
            Me.TableLayoutPanel1.Enabled = False
        Else
            Me.TableLayoutPanel1.Enabled = True
        End If
        If Screen.PrimaryScreen.WorkingArea.Height < 756 Then Me.WindowState = FormWindowState.Maximized

        Dim CsalNev, ElsoUtNev, TovUtNev
        Dim TermszemelyTableAdapter As New TorzsAdatbazisDataSetTableAdapters.Term_szemely_rogzitoTableAdapter
        TermszemelyTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Term_szemely_rogzito)
        For Each drow In Me.TorzsAdatbazisDataSet.Term_szemely_rogzito
            CsalNev = drow._Viselt_név_Családi_név
            ElsoUtNev = drow._Viselt_név_Első_utónév
            TovUtNev = drow._Viselt_név_További_utónevek
            If Not IsNothing(CsalNev) AndAlso Not IsDBNull(CsalNev) AndAlso Not String.IsNullOrWhiteSpace(CsalNev) Then CsaladnevList.Add(CsalNev)
            If Not IsNothing(ElsoUtNev) AndAlso Not IsDBNull(ElsoUtNev) AndAlso Not String.IsNullOrWhiteSpace(ElsoUtNev) Then ElsoUtonevList.Add(ElsoUtNev)
            If Not IsNothing(TovUtNev) AndAlso Not IsDBNull(TovUtNev) AndAlso Not String.IsNullOrWhiteSpace(TovUtNev) Then TovabbiUtonevList.Add(TovUtNev)
        Next
        CsaladnevList = CsaladnevList.Distinct.ToList
        CsaladnevList.Sort()
        ElsoUtonevList = ElsoUtonevList.Distinct.ToList
        ElsoUtonevList.Sort()
        TovabbiUtonevList = TovabbiUtonevList.Distinct.ToList
        TovabbiUtonevList.Sort()

        Dim ACCsalNev As New AutoCompleteStringCollection
        ACCsalNev.AddRange(CsaladnevList.ToArray)
        Viselt_név_Családi_névTextBox.AutoCompleteCustomSource = ACCsalNev

        Dim ACElsoUtNev As New AutoCompleteStringCollection
        ACElsoUtNev.AddRange(ElsoUtonevList.ToArray)
        Viselt_név_Első_utónévTextBox.AutoCompleteCustomSource = ACElsoUtNev

        Dim ACTovUtNev As New AutoCompleteStringCollection
        ACTovUtNev.AddRange(TovabbiUtonevList.ToArray)
        Viselt_név_További_utónevekTextBox.AutoCompleteCustomSource = ACTovUtNev


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

    Private Sub ToolStrip_Termsz_Click(sender As Object, e As EventArgs) Handles ToolStrip_Termsz.Click
        Me.Dispose()
        Forms.TDB_TESZ.ShowDialog()
    End Sub
    Private Sub btnBezaresMent_Click(sender As Object, e As EventArgs) Handles btnBezaresMent.Click
        Me.Validate()
        Me.MyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TorzsAdatbazisDataSet)
        Me.Refresh()

        Dim IDStr = Me.IDTextBox.Text
        If IDStr = "-1" Then
            Dim lastrow As DataRow() = Me.TorzsAdatbazisDataSet.Jogtanacsos_rogzito.Select("ID=Max(ID)")
            Dim idint As Integer = lastrow(0)("ID")
            idint += 1
            IDStr = CStr(idint)
        End If

        Dim TeljesNevStr As String = String.Empty
        Dim Nevek As New List(Of String)
        'Nevek.Add(Viselt_név_TitulusComboBox.Text)
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

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        ResetComboBox()
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


    Private Sub IrszámLeft_Igazitas(sender As Object, e As EventArgs) Handles Állandólakcím_IrányítószámComboBox.Validating
        Dim senderbox As ComboBox = CType(sender, ComboBox)
        'If senderbox.Items.Count = 0 Or Állandólakcím_Település_neveComboBox.Items.Count = 0 Or senderbox.Text = "" Or senderbox.Text Is DBNull.Value Then Exit Sub

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
            Állandólakcím_Település_neveComboBox.SelectedValue = row.Item("Helyseg")
        End If
    End Sub
    Private Sub Település_neveComboBox_Leave(sender As Object, e As EventArgs) Handles Állandólakcím_Település_neveComboBox.Validating
        Dim senderbox As ComboBox = CType(sender, ComboBox)
        'If senderbox.Items.Count = 0 Or Állandólakcím_Település_neveComboBox.Items.Count = 0 Then Exit Sub
        'If senderbox.SelectedValue = "" Or senderbox.SelectedValue Is DBNull.Value Then Exit Sub
        Dim row As DataRow = NyomtatvanyAdatokDataSet.Helyseg.Select("Helyseg = " & "'" & senderbox.SelectedValue & "'").FirstOrDefault
        If row Is Nothing Then
            senderbox.Text = ""
            senderbox.SelectedValue = DBNull.Value
            Exit Sub
        End If
        If Not row Is Nothing Then
            senderbox.SelectedValue = row.Item("Helyseg")
            If Strings.Left(Állandólakcím_IrányítószámComboBox.SelectedValue, 1) <> Strings.Left(row.Item("Irszam"), 1) Then Állandólakcím_IrányítószámComboBox.SelectedValue = row.Item("Irszam")
        End If
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

End Class