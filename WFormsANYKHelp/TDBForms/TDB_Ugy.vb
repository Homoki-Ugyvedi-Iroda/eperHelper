Public Class TDB_Ugy

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Ugytorzs_rogzitoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Ugytorzs_rogzitoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Ugytorzs_rogzitoBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.TorzsAdatbazisDataSet)
        Me.Ugytorzs_rogzitoTableAdapter.Update(Me.TorzsAdatbazisDataSet.Ugytorzs_rogzito)
        AddCustomSource()
    End Sub

    Private Sub TDB_Ugy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fullnevlist As New List(Of String)

        Me.UgycsoportTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Ugycsoport)
        Me.BirosagokTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.Birosagok)
        Me.Ugytorzs_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ugytorzs_rogzito)
        Me.Ceg_rogzitoTableAdapter1.Fill(Me.TorzsAdatbazisDataSet.Ceg_rogzito)
        Me.Term_szemely_rogzitoTableAdapter1.Fill(Me.TorzsAdatbazisDataSet.Term_szemely_rogzito)
        Me.Egyeb_szervezet_rogzitoTableAdapter1.Fill(Me.TorzsAdatbazisDataSet.Egyeb_szervezet_rogzito)
        Me.EV_rogzitoTableAdapter1.Fill(Me.TorzsAdatbazisDataSet.EV_rogzito)

        If Me.Ugytorzs_rogzitoBindingSource.Current Is Nothing Then
            Me.TableLayoutPanel1.Enabled = False
        Else
            Me.TableLayoutPanel1.Enabled = True
        End If
        For Each drow In Me.TorzsAdatbazisDataSet.Ceg_rogzito
            If Not IsNothing(drow.Cég_neve) AndAlso Not IsDBNull(drow.Cég_neve) AndAlso Not String.IsNullOrWhiteSpace(drow.Cég_neve) Then fullnevlist.Add(drow.Cég_neve)
        Next
        For Each drow In Me.TorzsAdatbazisDataSet.Egyeb_szervezet_rogzito
            If Not IsNothing(drow.Szervezet_megnevezése) AndAlso Not IsDBNull(drow.Szervezet_megnevezése) AndAlso Not String.IsNullOrWhiteSpace(drow.Szervezet_megnevezése) Then fullnevlist.Add(drow.Szervezet_megnevezése)
        Next
        For Each drow In Me.TorzsAdatbazisDataSet.EV_rogzito
            If drow.Név IsNot Nothing AndAlso Not IsDBNull(drow.Név) AndAlso Not String.IsNullOrWhiteSpace(drow.Név) Then fullnevlist.Add(drow.Név)
        Next
        For Each drow In Me.TorzsAdatbazisDataSet.Term_szemely_rogzito
            If drow.Teljes_név IsNot Nothing AndAlso Not IsDBNull(drow.Teljes_név) AndAlso Not String.IsNullOrWhiteSpace(drow.Teljes_név) Then fullnevlist.Add(drow.Teljes_név)
        Next
        For Each drow In Me.TorzsAdatbazisDataSet.Ugytorzs_rogzito
            If drow.Elsorendu_alperes_neve IsNot Nothing AndAlso Not IsDBNull(drow.Elsorendu_alperes_neve) AndAlso Not String.IsNullOrWhiteSpace(drow.Elsorendu_alperes_neve) Then fullnevlist.Add(drow.Elsorendu_alperes_neve)
            If drow.Elsorendu_felperes_neve IsNot Nothing AndAlso Not IsDBNull(drow.Elsorendu_felperes_neve) AndAlso Not String.IsNullOrWhiteSpace(drow.Elsorendu_felperes_neve) Then fullnevlist.Add(drow.Elsorendu_felperes_neve)
        Next
        fullnevlist = fullnevlist.Distinct.ToList
        fullnevlist.Sort()
        Dim ac As New AutoCompleteStringCollection
        ac.AddRange(fullnevlist.ToArray)
        Elsorendu_alperes_neveTextBox.AutoCompleteCustomSource = ac
        Elsorendu_felperes_neveTextBox.AutoCompleteCustomSource = ac

        AddCustomSource()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Validate()
        Me.Ugytorzs_rogzitoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TorzsAdatbazisDataSet)
        Try
            Dim IDStr As String = String.Empty
            Dim IDcurrent = CInt(Me.IDTextBox.Text)
            If IDcurrent < 0 Then
                Dim lastrow As DataRow() = Me.TorzsAdatbazisDataSet.Ugytorzs_rogzito.Select("ID=Max(ID)")
                Dim idint As Integer = lastrow(0)("ID")
                idint += 1
                IDStr = CStr(idint)
            Else IDStr = CStr(IDcurrent)
            End If

            Dim Nevek As New List(Of String)
            'Nevek.Add(Viselt_név_TitulusComboBox.Text) 'Mivel csak az FPK24-nél és csak az adós megnevezésénél van benne a teljes névben a titulus is, minden más esetben, legyen szó felperes stb., van külön titulus mező is
            KitoltPass = {IDStr, String.Empty}
        Catch
        End Try

        Me.Close()
    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click
        Me.Close()
    End Sub

    Private Sub ResetComboBox()
        Me.Birosag_kivalasztasaComboBox.Text = ""
        Me.Ugyszám_ugycsoport_reszeComboBox.Text = ""
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Ugytorzs_rogzitoBindingSource.AddNew()
        ResetComboBox()
    End Sub

    Private Sub TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Ugyszam_evszam_reszeTextBox.Validating, Ugyszam_lajstromszam_reszeTextBox.Validating

        Dim senderbox = CType(sender, TextBox)
        If senderbox.Text = "" Then Exit Sub
        Try
            Dim teszt = CType(senderbox.Text, Integer)
        Catch ex As Exception
            senderbox.Text = ""
        End Try
    End Sub

    Private Sub Ugytorzs_rogzitoBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Ugytorzs_rogzitoBindingSource.CurrentChanged
        If Me.Ugytorzs_rogzitoBindingSource.Current Is Nothing Then
            Me.TableLayoutPanel1.Enabled = False
        Else
            Me.TableLayoutPanel1.Enabled = True
        End If
    End Sub

    Private Sub btnKeres_Click(sender As Object, e As EventArgs) Handles btnKeres.Click
        Dim IDtoGo As Integer = GetResultsfromPersonDT(TorzsAdatbazisDataSet.Ugytorzs_rogzito, tbKereso.Text)
        If IDtoGo = 0 Then Exit Sub
        Try
            Ugytorzs_rogzitoBindingSource.Position = Ugytorzs_rogzitoBindingSource.Find("ID", IDtoGo)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub AddCustomSource()
        Dim fullnevlistCsakUgyben As New List(Of String)
        Me.Ugytorzs_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ugytorzs_rogzito)
        For Each drow In Me.TorzsAdatbazisDataSet.Ugytorzs_rogzito
            If Not IsNothing(drow.Elsorendu_alperes_neve) AndAlso Not IsDBNull(drow.Elsorendu_alperes_neve) AndAlso Not String.IsNullOrWhiteSpace(drow.Elsorendu_alperes_neve) Then fullnevlistCsakUgyben.Add(drow.Elsorendu_alperes_neve)
            If Not IsNothing(drow.Elsorendu_felperes_neve) AndAlso Not IsDBNull(drow.Elsorendu_felperes_neve) AndAlso Not String.IsNullOrWhiteSpace(drow.Elsorendu_felperes_neve) Then fullnevlistCsakUgyben.Add(drow.Elsorendu_felperes_neve)
        Next
        fullnevlistCsakUgyben = fullnevlistCsakUgyben.Distinct.ToList
        fullnevlistCsakUgyben.Sort()
        Dim ac As New AutoCompleteStringCollection
        ac.AddRange(fullnevlistCsakUgyben.ToArray)
        tbKereso.AutoCompleteCustomSource = ac

    End Sub
End Class