Public Class Kitolt
    Dim KitoltNyomtatvanyDSource As New BindingSource
    Dim KitoltTorzsDSource As New BindingSource
    Dim OsszesLapnev As List(Of String)
    Dim SelUgyRow As Integer = -1
    Dim SelTorzsRow As Integer = -1
    Dim SelSzemelyRow As Integer = -1
    Dim ValtoDemo As Integer = 0

    Private Sub Kitolt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Screen.PrimaryScreen.WorkingArea.Height < 756 Then Me.WindowState = FormWindowState.Maximized
        Me.NyomtatvanyAdatokDataSet.NyomiListaFeldolg.Clear()
        Me.NyomtatvanyAdatokDataSet.NyomiLista.Clear()
        KitoltNyomtatvanyDSource.Filter = ""
        Me.NyomtatvanyAdatokDataSet.EnforceConstraints = False
        Me.TorzsAdatbazisDataSet.EnforceConstraints = False

        Try
            Me.NyomiListaTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.NyomiLista)
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Hozzáférési hiba! A törzsadatbázis nem érhető el!", MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Me.NyomiListaFeldolgTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.NyomiListaFeldolg)
        Me.Ugytorzs_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ugytorzs_rogzito)
        Me.Ceg_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ceg_rogzito)
        Me.Ugyvedi_iroda_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ugyvedi_iroda_rogzito)
        Me.Jogtanacsos_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Jogtanacsos_rogzito)
        Me.EV_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.EV_rogzito)
        Me.Egyeni_ugyvedi_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Egyeni_ugyvedi_rogzito)
        Me.Egyeb_szervezet_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Egyeb_szervezet_rogzito)
        Me.Egyeb_jogi_kvo_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Egyeb_jogi_kvo_rogzito)
        Me.FrissKitKatTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.OsszesitettMDFbol)
        Me.Term_szemely_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Term_szemely_rogzito)
        tbSzures.Text = String.Empty
        LoadandSetColumns()
        If My.Settings.DefaultKitoltoID > -1 Then
            Try
                cbBekuldo.SelectedValue = My.Settings.DefaultKitoltoID
            Catch ex As Exception
            End Try
        End If
        dgTorzsValaszto.ClearSelection()
        dgUgyvalaszto.ClearSelection()
        dgSzemelyValaszto.ClearSelection()
        dgTorzsValaszto.Enabled = False
        dgSzemelyValaszto.Enabled = False
        dgUgyvalaszto.Enabled = False
        btnImportraMent.Enabled = False
        OsszesLapnev = FrissitLapnev()

    End Sub
    Private Function FrissitLapnev() As List(Of String)

        Dim dt As DataTable = NyomtatvanyAdatokDataSet.NyomiLista
        dt = dt.DefaultView.ToTable(True, "Lap")
        Dim result As New List(Of String)
        For Each drow As DataRow In dt.Rows
            result.Add(drow(0))
        Next
        Return result
    End Function

    Private Sub LoadandSetColumns()
        Dim dgFRMENYKView As New DataTable
        'Dim distinctTelepitettNyomtatvanyListDT As DataTable = PopulateTelepitettNyomtatvanyok.DefaultView.ToTable(True, {"name"})
        If TelepitettNyomtatvanyok.Rows.Count = 0 Then TelepitettNyomtatvanyok = PopulateTelepitettNyomtatvanyok()
        If TelepitettNyomtatvanyok.Rows.Count = 0 Then
            MsgBox("Nincsen a gépére egy OBHGEPI típusú (bírósági) ÁNYK nyomtatványsablon sem telepítve, így nem tud nyomtatványt kitölteni sem.", MsgBoxStyle.Critical)
        End If
        Dim distinctTelepitettNyomtatvanyListDT As DataTable = TelepitettNyomtatvanyok.DefaultView.ToTable(True, {"name"})

        Dim distinctstringofTelepitettNyomtatvanyList As String = String.Empty
        Dim sb As New System.Text.StringBuilder()
        For Each row As DataRow In distinctTelepitettNyomtatvanyListDT.Rows
            sb.Append("'" & row(0) & "', ")
        Next
        If sb.Length > 1 Then distinctstringofTelepitettNyomtatvanyList = sb.ToString.Substring(0, sb.Length - 2)

        Me.NyomtatvanyAdatokDataSet.NyomiListaFeldolg.Columns.Clear()
        Try
            Me.NyomiListaFeldolgTableAdapter.Fill(Me.NyomtatvanyAdatokDataSet.NyomiListaFeldolg)
        Catch ex As Exception
        End Try
        dgFRMENYKView = Me.NyomtatvanyAdatokDataSet.NyomiListaFeldolg

        dgFRMENYKView.Columns("Hivk_rovidneve").SetOrdinal(0)
        dgFRMENYKView.Columns("Ny_kat").SetOrdinal(1)
        dgFRMENYKView.Columns("Nyomtatvany").SetOrdinal(2)
        dgFRMENYKView.Columns("Hivk_rovidneve").ColumnName = "Közzétevő"
        dgFRMENYKView.Columns("Ny_kat").ColumnName = "Kategória"
        dgFRMENYKView.Columns("Nyomtatvany").ColumnName = "Kód"
        dgFRMENYKView.Columns("Ny_leiras").ColumnName = "Leírás"
        If distinctstringofTelepitettNyomtatvanyList <> String.Empty Then
            Dim selectkód As String = "Kód IN (" & distinctstringofTelepitettNyomtatvanyList & ")"
            dgFRMENYKView.DefaultView.RowFilter = selectkód
            dgFRMENYKView = dgFRMENYKView.DefaultView.ToTable
        Else
            dgFRMENYKView = dgFRMENYKView.Clone
        End If
        KitoltNyomtatvanyDSource.DataSource = dgFRMENYKView

        'dgFRMENYKView.Dispose()
        SetColumns()

    End Sub
    Private Sub SetColumns()
        'Kozzetevo

        If dgFRMENYKValaszto.DataSource Is Nothing Then Me.dgFRMENYKValaszto.Columns.Clear()
        Me.dgFRMENYKValaszto.AutoGenerateColumns = True
        Me.dgFRMENYKValaszto.DataSource = KitoltNyomtatvanyDSource
        Me.dgFRMENYKValaszto.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgFRMENYKValaszto.RowHeadersWidth = 5

        Me.dgFRMENYKValaszto.Columns(0).FillWeight = 15.0!
        Me.dgFRMENYKValaszto.Columns(0).MinimumWidth = 30
        Me.dgFRMENYKValaszto.Columns(0).ReadOnly = True
        Me.dgFRMENYKValaszto.Columns(0).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        Me.dgFRMENYKValaszto.Columns(0).AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        '
        'Nyomkat
        '

        dgFRMENYKValaszto.Columns(1).FillWeight = 15.0!
        dgFRMENYKValaszto.Columns(1).MinimumWidth = 10
        dgFRMENYKValaszto.Columns(1).ReadOnly = True
        dgFRMENYKValaszto.Columns(1).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        dgFRMENYKValaszto.Columns(1).AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

        '
        'Kód
        '
        dgFRMENYKValaszto.Columns(2).FillWeight = 20.0!
        dgFRMENYKValaszto.Columns(2).MinimumWidth = 50
        dgFRMENYKValaszto.Columns(2).ReadOnly = True
        dgFRMENYKValaszto.Columns(2).HeaderCell = New DataGridViewAutoFilter.DataGridViewAutoFilterColumnHeaderCell
        dgFRMENYKValaszto.Columns(2).AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

        '
        'verzio
        '
        '
        dgFRMENYKValaszto.Columns(3).FillWeight = 70.0!
        dgFRMENYKValaszto.Columns(3).MinimumWidth = 250
        dgFRMENYKValaszto.Columns(3).ReadOnly = True
        dgFRMENYKValaszto.Columns(3).AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill

        Me.dgFRMENYKValaszto.Refresh()

    End Sub
    Private Sub btnBezarImportNelkul_Click(sender As Object, e As EventArgs) Handles btnBezarImportNelkul.Click
        If cbBekuldo.SelectedIndex > -1 Then
            My.Settings.DefaultKitoltoID = cbBekuldo.SelectedValue
            My.Settings.Save()
        End If

        Me.tbNyomKivalasztott.SelectedText = ""
        Me.dgFRMENYKValaszto.ClearSelection()
        Me.dgTorzsValaszto.ClearSelection()
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub tbSzures_TextChanged(sender As Object, e As EventArgs) Handles tbSzures.TextChanged
        KitoltNyomtatvanyDSource.Filter = "Leírás Like '%" & tbSzures.Text & "%'"
        If KitoltNyomtatvanyDSource.Count = 0 Then KitoltNyomtatvanyDSource.Filter = "Kód LIKE '%" & tbSzures.Text & "%'"
    End Sub
    Private Sub RefreshSzemelyek()
        Me.Ceg_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ceg_rogzito)
        Me.Ugyvedi_iroda_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ugyvedi_iroda_rogzito)
        Me.Jogtanacsos_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Jogtanacsos_rogzito)
        Me.EV_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.EV_rogzito)
        Me.Egyeni_ugyvedi_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Egyeni_ugyvedi_rogzito)
        Me.Egyeb_szervezet_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Egyeb_szervezet_rogzito)
        Me.Egyeb_jogi_kvo_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Egyeb_jogi_kvo_rogzito)
        Me.Term_szemely_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Term_szemely_rogzito)
        cbBekuldo.DataSource = Me.TorzsAdatbazisDataSet.Term_szemely_rogzito
        dgSzemelyValaszto.DataSource = Me.TorzsAdatbazisDataSetBindingSource
    End Sub
    Private Sub btnAddSzemely_Click(sender As Object, e As EventArgs) Handles btnAddSzemelytoTDB.Click, btnAddBekuldotoTDB.Click
        Dim senderbtn As Button = CType(sender, Button)
        'A kiválasztott személytípus szerinti Form-ot nyissa meg, vegye vissza a legutolsó létrehozott személy ID-ját
        Dim Tipus As String = "Természetes személy"
        If dgTorzsValaszto.SelectedRows.Count > 0 And senderbtn.Name <> "btnAddBekuldotoTDB" Then Tipus = dgTorzsValaszto.SelectedRows(0).Cells("dgSzemelytipusNeve").Value.ToString()
        Dim FncNameToCall As String = String.Empty
        If Tipus = String.Empty Then Exit Sub
        If senderbtn.Name = "btnAddSzemelytoTDB" Then FncNameToCall = GetSzemelyTipusTDBForm(Tipus) Else FncNameToCall = "TDB_TESZ"
        KitoltPass = Nothing
        Dim TDBType As Object = CallByName(Forms, FncNameToCall, CallType.Get)
        TDBType.ShowDialog(Me)
        'Me.Kitolt_Load(Me, Nothing)
        RefreshSzemelyek()
        If KitoltPass Is Nothing Then Exit Sub

        If KitoltPass(0) <> "" Then
            If senderbtn.Name = "btnAddSzemelytoTDB" Then
                For Each item As DataGridViewRow In dgSzemelyValaszto.Rows
                    If item.Cells.Count = 0 Then Continue For
                    If item.Cells(0).Value.ToString = KitoltPass(0) Then
                        item.Selected = True
                        If tbNyomKivalasztott.Text <> String.Empty Then dgSzemelyValaszto.FirstDisplayedScrollingRowIndex = dgSzemelyValaszto.SelectedRows(0).Index
                        Exit For
                    End If
                Next
            End If
            If senderbtn.Name = "btnAddBekuldotoTDB" Then
                Try
                    cbBekuldo.SelectedValue = CInt(KitoltPass(0))
                Catch ex As Exception
                    cbBekuldo.SelectedIndex = -1
                End Try
                If KitoltPass(1) <> "" Then cbBekuldo.Text = KitoltPass(1)
            End If
        End If
    End Sub
    Private Function GetImpIDSet(Nyomtatvany As String, LapNeve As String, SzemelyTipus As String) As DataRow()
        Dim dr() As DataRow = Me.NyomtatvanyAdatokDataSet.OsszesitettMDFbol.Select("Nyomtatvany='" & Nyomtatvany & "'" & " And Lap='" & LapNeve & "' And TorzstablaID='" & GetTorzstablaIDbySzemelyTipus(SzemelyTipus) & "'")
        Return dr
    End Function
    Private Sub btnImportraMent_Click(sender As Object, e As EventArgs) Handles btnImportraMent.Click
        Dim CelNyomtatvany = tbNyomKivalasztott.Text
        Dim Bekuldo As Integer = -1
        If cbBekuldo.SelectedValue IsNot Nothing Then Bekuldo = cbBekuldo.SelectedValue
        Dim TextToWrite() As String = {String.Empty}
        Dim str As New StringWriter

        str.WriteLine("$ny_azon=" & CelNyomtatvany)
        str.WriteLine("$sorok_száma=9999")
        str.WriteLine("$d_lapok_száma=9999")
        str.WriteLine("$d_lap1=")
        str.WriteLine("$info={*}" & tbFajlnev.Text & "{!}" & cbBekuldo.Text)

        'személyi törzsadatok és OsszesitettMDF adatai alapján adja meg az értékeket a beküldőre
        If Bekuldo > -1 Then WriteBekuldoData(str)
        GetNyomtatvanySpecifikusAdatok(str)


        'személyi törzsadatok és OsszesitettMDF adatai alapján adja meg az értékeket a beküldőn kívüli személyekre is
        For Each item As ListViewItem In lvKivalasztottak.Items
            Dim foundrowOsszMDF() As DataRow = GetImpIDSet(tbNyomKivalasztott.Text, item.SubItems("lvLap").Text, item.SubItems("lvTorzsTabla").Text)

            'Szűrje ki azokat a sorokat az OsszMDF táblából, amelyek azonos nyomtatványon, azonos lapra és azonos személytípusra vonatkoznak (valószínűleg ebből csak egy lesz)
            Dim dtTorzsDB As DataTable = CallByName(Me.TorzsAdatbazisDataSet, GetSzemelyTipusTAName(item.SubItems("lvTorzsTabla").Text), CallType.Get)

            Dim rowtoLoad() As DataRow = dtTorzsDB.Select("ID='" & item.SubItems("lvID").Text & "'")
            'Megvan az összes ImpID, ami az adott nyomtatvány adott lapján az adott típusú személynél szóba jöhet.
            For Each columnTorzsAdattabla As DataColumn In dtTorzsDB.Columns
                If IsDBNull(rowtoLoad(0)(columnTorzsAdattabla)) Or rowtoLoad(0)(columnTorzsAdattabla) Is Nothing Then Continue For
                Dim MilyenErteketVegyenFel = rowtoLoad(0)(columnTorzsAdattabla)
                For Each rowOsszMDF As DataRow In foundrowOsszMDF
                    '=Milyen ID-jű személy értékeit kell rögzíteni
                    Dim HanyadikIlyenLapEz = item.Text
                    'Ha a törzsadat szerinti adott ID-jű egyénre vonatkozó oszlop bármely neve azonos az adott lap és törzstábla típus szerint elérhető egyik "Fieldname" mező értékével, akkor írjon egy sort pluszban a végén kiírandó tömbbe
                    CheckFieldswCorrespondingTDB(columnTorzsAdattabla.ColumnName, rowtoLoad(0), rowOsszMDF, HanyadikIlyenLapEz, MilyenErteketVegyenFel, str)

                    'Ha bármilyen jogi képviselő típusú lapot kitöltünk, akkor beírja a jogi képviselet formáját és a bejelentett képviselet típusút is (ha ez az adat az adott nyomtatványra rögzítve van az adatbázisban)
                    If rowOsszMDF("BelsoID").Contains("JogiKepForma") Then WriteString(rowOsszMDF("ImpID"), item.SubItems("lvTorzsTabla").Text, str, HanyadikIlyenLapEz)
                    If rowOsszMDF("BelsoID").Contains("FORMA$JOGIKEPV") Then WriteString(rowOsszMDF("ImpID"), item.SubItems("lvTorzsTabla").Text.ToLower, str, HanyadikIlyenLapEz)

                    'Ha a "hanyadik felperest képviseled?" jellegű jogi képviselőre vonatkozó sorszám adatot rögzíteni lehet az űrlapon, és csak egy felperes van, akkor automatikusan írja be az összes felperesi jogi képviselőnél, hogy az egyes számú felperes képviseli
                    If rowOsszMDF("BelsoID").Contains("fpjk1") And GetHanyVanaLapbol("Felperesek") = 1 Then WriteString(rowOsszMDF("ImpID"), "true", str, HanyadikIlyenLapEz)

                Next
                CheckFieldsLapLevel(columnTorzsAdattabla.ColumnName, MilyenErteketVegyenFel, item.SubItems("lvLap").Text, item.Text, str)
                MilyenErteketVegyenFel = String.Empty
            Next
        Next

        'Importálandó fájl lementése
        ImpFajlLementese(str)

        If cbBekuldo.SelectedValue IsNot Nothing Then
            My.Settings.DefaultKitoltoID = cbBekuldo.SelectedValue
            My.Settings.Save()
        End If

        'Nem törölhetjük a menteshelyenevvel fájlt (az imp fájlt), hiszen nem fejezi be a záráskor az importálást.
        'Try
        'File.Delete(MentesHelyeNevvel)
        'Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(Path.GetDirectoryName(MentesHelyeNevvel), FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)
        '        Catch ex As Exception
        'End Try
    End Sub
    Private Sub GetNyomtatvanySpecifikusAdatok(str As StringWriter)

        If tbNyomKivalasztott.Text = "OBHGEPI_P15" Then WriteString("2259", "Elfogadom", str)
        'P15-nél az első oldalon el kell fogadni a perbehívást, csak akkor válik aktívvá a többi lap. Az alábbiak az adatai a mezőnek: 0A0001D010A, 2259 imp, alapElfogad. Ennek kell az értékének "Elfogadom"-nak lennie.

        If tbNyomKivalasztott.Text = "OBHGEPI_P13" Then
            If GetHanyVanaLapbol("Új személy bejelentése") > 0 Then WriteString("2096", "X", str)
            If GetHanyVanaLapbol("Visszavonás") > 0 Then WriteString("2098", "X", str)
        End If

        'If tbNyomKivalasztott.Text = "OBHGEPI_K01" Or tbNyomKivalasztott.Text = "OBHGEPI_M01" Then
        'WriteString("1738", "", str)
        'End If
        If (tbNyomKivalasztott.Text = "OBHGEPI_P21" Or tbNyomKivalasztott.Text = "OBHGEPI_P24") AndAlso GetHanyVanaLapbol("Jogi képviselő vagy pártfogó ügyvéd") > 0 Then
            WriteString("1972", "Nem, most kívánom bejelenteni.", str)
        End If
        'P21-nél csak akkor kell beadni jogi képviselőt, ha akkor akarjuk bejelenteni, azaz ha az 1.11 mező értéke "Nem, most kívánom bejelenteni." 1.11 adatai: 0A0001D018A, alapJogikep, 1972 imp.
        'P24-nél csak akkor kell beadni jogi képviselőt, ha akkor akarjuk bejelenteni, azaz ha az 1.8 mező értéke "Nem, most kívánom bejelenteni." 1.8 adatai: 0A0001D013AalapJogikep,1972 imp.

        Dim foundrowOsszMDF() As DataRow = Me.NyomtatvanyAdatokDataSet.OsszesitettMDFbol.Select("Nyomtatvany='" & tbNyomKivalasztott.Text & "'")
        For Each row As DataRow In foundrowOsszMDF
            If IsDBNull(row("ImpID")) Then row("ImpID") = String.Empty
            Select Case row("BelsoID")
                Case "alapKeltDatum"
                    WriteString(row("ImpID"), Now.ToString("yyyyMMdd"), str)
                Case "IRAT_KELTE"
                    WriteString(row("ImpID"), Now.ToString("yyyyMMdd"), str)
                Case "alapKeltHely"
                    If My.Settings.KeltezesHelye <> String.Empty Then WriteString(row("ImpID"), My.Settings.KeltezesHelye, str)
                Case "TELEPULES"
                    If My.Settings.KeltezesHelye <> String.Empty Then WriteString(row("ImpID"), My.Settings.KeltezesHelye, str)
                Case "alapCsatSzama"
                    WriteString(row("ImpID"), "1", str)
                Case "alapSzovegMegadas"
                    WriteString(row("ImpID"), "Mellékletként csatolva", str)
                Case "alapApSzama"
                    Dim AlperesekSzama = GetHanyVanaLapbol("Alperes") + GetHanyVanaLapbol("Alperesek")
                    If tbNyomKivalasztott.Text = "OBHGEPI_M01" Then AlperesekSzama = AlperesekSzama + 1
                    WriteString(row("ImpID"), AlperesekSzama.ToString, str)
                Case "alapFpSzama"
                    Dim FelperesekSzama = GetHanyVanaLapbol("Felperes") + GetHanyVanaLapbol("Felperesek")
                    WriteString(row("ImpID"), FelperesekSzama.ToString, str)
            End Select
            If dgUgyvalaszto.SelectedRows.Count = 1 Then
                Try
                    Select Case row("BelsoID")
                        Case "BIROSAG", "alapBirosag"
                            If Not IsDBNull(dgUgyvalaszto.SelectedRows(0).Cells(1).Value) Then WriteString(row("ImpID"), dgUgyvalaszto.SelectedRows(0).Cells(1).Value, str)
                    'Case "JEL$UGYSZAM" '<- ezt nem töltöm ki, mert mindig a nyomtatványban ki van töltve
                        Case "alapUgyCs"
                            If Not IsDBNull(dgUgyvalaszto.SelectedRows(0).Cells(2).Value) Then WriteString(row("ImpID"), dgUgyvalaszto.SelectedRows(0).Cells(2).Value, str)
                        Case "SZAM$UGYSZAM", "alapUgySzam"
                            If Not IsDBNull(dgUgyvalaszto.SelectedRows(0).Cells(3).Value) Then WriteString(row("ImpID"), dgUgyvalaszto.SelectedRows(0).Cells(3).Value, str)
                        Case "EV$UGYSZAM", "alapUgyEv"
                            If Not IsDBNull(dgUgyvalaszto.SelectedRows(0).Cells(4).Value) Then WriteString(row("ImpID"), dgUgyvalaszto.SelectedRows(0).Cells(4).Value, str)
                        Case "alapElsoRF"
                            If Not IsDBNull(dgUgyvalaszto.SelectedRows(0).Cells(5).Value) Then WriteString(row("ImpID"), dgUgyvalaszto.SelectedRows(0).Cells(5).Value, str)
                        Case "alapElsoRA", "NEVE$ADOS"
                            If Not IsDBNull(dgUgyvalaszto.SelectedRows(0).Cells(6).Value) Then WriteString(row("ImpID"), dgUgyvalaszto.SelectedRows(0).Cells(6).Value, str)
                        Case "alapUgytargy"
                            If Not IsDBNull(dgUgyvalaszto.SelectedRows(0).Cells(7).Value) Then WriteString(row("ImpID"), dgUgyvalaszto.SelectedRows(0).Cells(7).Value, str)
                    End Select
                Catch ex As Exception
                    MyLoader.AddLogBook(Fnc.xml, "A megadott ügy törzsadatok közül az egyik hibás", LogTip.err)
                End Try
            End If
        Next
    End Sub


    Private Sub WriteBekuldoData(ByRef str As StringWriter)
        Dim foundrowOsszMDF() As DataRow = Me.NyomtatvanyAdatokDataSet.OsszesitettMDFbol.Select("Nyomtatvany='" & tbNyomKivalasztott.Text & "' AND TorzstablaID='1'")
        Dim dtTorzsDB As DataTable = Me.TorzsAdatbazisDataSet.Term_szemely_rogzito
        Dim rowtoLoad() As DataRow = Nothing

        If cbBekuldo.SelectedValue IsNot Nothing Then rowtoLoad = dtTorzsDB.Select("ID='" & cbBekuldo.SelectedValue & "'")
        'Gyűjtse ki az összes ImpID-t, ami az adott nyomtatvány adott lapján az adott beküldőnél szóba jöhet.
        For Each columnTorzsAdattabla As DataColumn In dtTorzsDB.Columns
            For Each rowOsszMDF As DataRow In foundrowOsszMDF
                If IsDBNull(rowOsszMDF("Fieldname")) Then Continue For
                Dim MilyenErteketVegyenFel = rowtoLoad(0)(columnTorzsAdattabla)
                If columnTorzsAdattabla.ColumnName = rowOsszMDF("Fieldname") AndAlso rowOsszMDF("BelsoID").Contains("BEKULDO") Then
                    If Not MilyenErteketVegyenFel Is Nothing And Not IsDBNull(MilyenErteketVegyenFel) Then WriteString(rowOsszMDF("ImpID"), MilyenErteketVegyenFel, str)
                End If
            Next
        Next
    End Sub

    Private Sub CheckFieldsLapLevel(TorzsAdatTableColumn As String, MilyenErteketVegyenFel As String, LapNeve As String, HanyadikDinamikusLapon As Integer, ByRef str As StringWriter)

        Dim rowNyomtatvanyDBs() As DataRow = Me.NyomtatvanyAdatokDataSet.OsszesitettMDFbol.Select("Nyomtatvany='" & tbNyomKivalasztott.Text & "'" & " And Lap='" & LapNeve & "'")
        If rowNyomtatvanyDBs.Count = 0 Then Exit Sub
        Dim result As String = String.Empty
        For Each rowNyomtatvanyDB As DataRow In rowNyomtatvanyDBs
            If TorzsAdatTableColumn = "Külföldi cím/További cím adatok" AndAlso rowNyomtatvanyDB("BelsoID").Contains("Tov3") And MilyenErteketVegyenFel <> String.Empty Then
                'Ha "Külföldi cím/További cím adatok" mezőt töltünk ki, akkor töltsünk ki az adott laphoz tartozó "Tov3" mező ImpID=true értékét is
                WriteString(rowNyomtatvanyDB("ImpID"), "true", str, HanyadikDinamikusLapon)
                Continue For
            End If
            If TorzsAdatTableColumn = "Viselt név/Családi név" AndAlso rowNyomtatvanyDB("BelsoID") = "TIPUS1$KERELMEZO" Then
                WriteString(rowNyomtatvanyDB("ImpID"), "X", str)
                Continue For
            End If
            If TorzsAdatTableColumn = "Viselt név/Családi név" AndAlso rowNyomtatvanyDB("BelsoID").ToString.EndsWith("Term") Then
                WriteString(rowNyomtatvanyDB("ImpID"), "true", str, HanyadikDinamikusLapon)
                Continue For
            End If
            If rowNyomtatvanyDB("BelsoID").Contains("BejKepTipus") Then
                WriteString(rowNyomtatvanyDB("ImpID"), "Jogi képviselő", str, HanyadikDinamikusLapon)
                Continue For
            End If
            If rowNyomtatvanyDB("BelsoID").ToString.EndsWith("Tipus") Then
                Dim IrandoErtek As String = String.Empty
                Select Case TorzsAdatTableColumn
                    Case = "Cég neve"
                        IrandoErtek = "Cég"
                    Case = "Viselt név/Családi név"
                        IrandoErtek = "Természetes személy"
                    Case = "Szervezet megnevezése"
                        IrandoErtek = "Egyéb szervezet"
                    Case = "Egyéni vállalkozó igazolvány száma"
                        IrandoErtek = "Egyéni vállalkozó"
                End Select
                If IrandoErtek <> String.Empty Then
                    WriteString(rowNyomtatvanyDB("ImpID"), IrandoErtek, str, HanyadikDinamikusLapon:=HanyadikDinamikusLapon)
                End If
            End If
        Next
    End Sub
    Private Sub CheckFieldswCorrespondingTDB(TorzsAdatTableColumn As String, rowfromTDB As DataRow, rowNyomtatvanyDB As DataRow, Sorrend As Integer, TargetValue As String, ByRef str As StringWriter)
        If IsDBNull(rowNyomtatvanyDB("Fieldname")) Then Exit Sub

        Dim MilyenErteketVegyenFel = TargetValue

        If rowNyomtatvanyDB("BelsoID").Contains("BEKULDO") Then Exit Sub

        If TorzsAdatTableColumn.Contains("Anyja neve") AndAlso rowNyomtatvanyDB("Fieldname") = "Anyja neve" Then
            MilyenErteketVegyenFel = rowfromTDB("Anyja neve/Családi név") & " " & rowfromTDB("Anyja neve/Első utónév") & " " & rowfromTDB("Anyja neve/További utónevek")
            WriteString(rowNyomtatvanyDB("ImpID"), MilyenErteketVegyenFel, str, Sorrend)
            Exit Sub
        End If

        If TorzsAdatTableColumn.Contains("Születési név") AndAlso rowNyomtatvanyDB("Fieldname") = "Születési név/Családi név" AndAlso Not rowNyomtatvanyDB("BelsoID").Contains("$KERELMSZ") Then
            MilyenErteketVegyenFel = rowfromTDB("Születési név/Családi név") & " " & rowfromTDB("Születési név/Első utónév") & " " & rowfromTDB("Születési név/További utónevek")
            WriteString(rowNyomtatvanyDB("ImpID"), MilyenErteketVegyenFel, str, Sorrend)
            Exit Sub
        End If

        If TorzsAdatTableColumn = "Fizetési számlaszám" AndAlso rowNyomtatvanyDB("BelsoID").Contains("CegSzlaSzam") Then
            Dim Elso8 As String = Strings.Left(rowfromTDB("Fizetési számlaszám"), 8)
            WriteString(rowNyomtatvanyDB("ImpID"), Elso8, str, Sorrend)
            Exit Sub
        End If

        If TorzsAdatTableColumn = "Fizetési számlaszám" AndAlso rowNyomtatvanyDB("BelsoID").Contains("CegAlSzlaSzam") Then
            Dim Masodik16 As String = rowfromTDB("Fizetési számlaszám").Remove(0, 8).Replace("-", "")
            WriteString(rowNyomtatvanyDB("ImpID"), Masodik16, str, Sorrend)
            Exit Sub
        End If

        If rowNyomtatvanyDB("BelsoID").Contains("$KERELMSZ") AndAlso (rowNyomtatvanyDB("BelsoID").ToString.StartsWith("VISELT_") Or rowNyomtatvanyDB("BelsoID") = "ELOTAG$KERELMSZ") Then
            If TorzsAdatTableColumn = rowNyomtatvanyDB("Fieldname") Then WriteString(rowNyomtatvanyDB("ImpID"), MilyenErteketVegyenFel, str, Sorrend)
            Exit Sub
        End If

        If TorzsAdatTableColumn.Contains("Családi név") AndAlso rowNyomtatvanyDB("BelsoID") = "jkUNev" And Me.tbNyomKivalasztott.Text = "OBHGEPI_P12" Then
            MilyenErteketVegyenFel = IIf(rowfromTDB("Titulus") = "", "", " ") & rowfromTDB("Családi név") & " " & rowfromTDB("Első utónév") & " " & rowfromTDB("További utónevek")
            WriteString(rowNyomtatvanyDB("ImpID"), MilyenErteketVegyenFel, str, Sorrend)
            Exit Sub
        End If
        If TorzsAdatTableColumn.Contains("Elérhetőségek/Telefonszám") AndAlso (tbNyomKivalasztott.Text.Contains("_FPK-") Or tbNyomKivalasztott.Text.Contains("_APK-")) Then
            If MilyenErteketVegyenFel.StartsWith("36") Or MilyenErteketVegyenFel.StartsWith("06") Then MilyenErteketVegyenFel = MilyenErteketVegyenFel.Remove(0, 2)
            Exit Sub
        End If

        'Minden más esetben az alapszabály az, hogy ha megegyezik a Torzsadat oszlopának neve az OsszesitettMDFbol tábla Fieldname-ével, akkor azt vegye át

        If TorzsAdatTableColumn = rowNyomtatvanyDB("Fieldname") Then
            WriteString(rowNyomtatvanyDB("ImpID"), MilyenErteketVegyenFel, str, Sorrend)
        End If
    End Sub

    Private Sub WriteString(ImpID As String, Value As String, ByRef str As StringWriter, Optional HanyadikDinamikusLapon As Integer = 0)
#If Not DEBUG And Not ARCONSULT = "Y" Then
        If My.Settings.Regisztrált = False AndAlso (Value <> "X" AndAlso Value <> "true") Then
            If ValtoDemo Mod 2 = 0 Then
                Value = "*DEMO*"
            End If
        End If

        ValtoDemo += 1
#End If
        If HanyadikDinamikusLapon = 0 Then str.WriteLine(ImpID & "=" & Value) Else str.WriteLine(ImpID & "[" & HanyadikDinamikusLapon & "]=" & Value)
    End Sub
    Private Function GetSzemelyTipusTAName(ValasztottSzemelyTipus As String) As String
        Dim DMB As String = "_rogzito"
        Select Case ValasztottSzemelyTipus
            Case "Természetes személy"
                DMB = "Term_szemely" + DMB
            Case "Cég"
                DMB = "Ceg" + DMB
            Case "Egyéb szervezet"
                DMB = "Egyeb_szervezet" + DMB
            Case "Ügyvédi iroda"
                DMB = "Ugyvedi_iroda" + DMB
            Case "Egyéni ügyvéd"
                DMB = "Egyeni_ugyvedi" + DMB
            Case "Egyéb jogi képviselő"
                DMB = "Egyeb_jogi_kvo" + DMB
            Case "Jogtanácsos"
                DMB = "Jogtanacsos" + DMB
            Case "Egyéni vállalkozó"
                DMB = "EV" + DMB
        End Select
        Return DMB
    End Function

    Private Function GetSzemelyTipusTAName(ValasztottSzemelyTipus As Integer) As String
        Dim DMB As String = "_rogzito"
        Select Case ValasztottSzemelyTipus
            Case 1
                DMB = "Term_szemely" + DMB
            Case 2
                DMB = "Ceg" + DMB
            Case 3
                DMB = "Egyeb_szervezet" + DMB
            Case 4
                DMB = "Ugyvedi_iroda" + DMB
            Case 5
                DMB = "Egyeni_ugyvedi" + DMB
            Case 6
                DMB = "Egyeb_jogi_kvo" + DMB
            Case 7
                DMB = "Jogtanacsos" + DMB
            Case 8
                DMB = "EV" + DMB
        End Select
        Return DMB
    End Function

    Private Function GetTorzstablaIDbySzemelyTipus(ValasztottSzemelyTipus As String) As Integer
        Dim DMB As Integer
        Select Case ValasztottSzemelyTipus
            Case "Természetes személy"
                DMB = 1
            Case "Cég"
                DMB = 2
            Case "Egyéb szervezet"
                DMB = 3
            Case "Ügyvédi iroda"
                DMB = 4
            Case "Egyéni ügyvéd"
                DMB = 5
            Case "Egyéb jogi képviselő"
                DMB = 6
            Case "Jogtanácsos"
                DMB = 7
            Case "Egyéni vállalkozó"
                DMB = 8
        End Select
        Return DMB
    End Function


    Private Function GetSzemelyTipusTDBForm(ValasztottSzemelyTipus As String) As String
        Dim DMB As String = "TDB_"
        Select Case ValasztottSzemelyTipus
            Case "Természetes személy"
                DMB += "TESZ"
            Case "Cég"
                DMB += "Ceg"
            Case "Egyéb szervezet"
                DMB += "ESZ"
            Case "Ügyvédi iroda"
                DMB += "UI"
            Case "Egyéni ügyvéd"
                DMB += "EU"
            Case "Egyéb jogi képviselő"
                DMB += "EJKV"
            Case "Jogtanácsos"
                DMB += "JT"
            Case "Egyéni vállalkozó"
                DMB += "EV"
        End Select
        Return DMB
    End Function

    Private Sub dgTorzsValaszto_SelectionChanged(sender As Object, e As EventArgs) Handles dgTorzsValaszto.SelectionChanged
        If dgTorzsValaszto.SelectedRows.Count > 0 And tbNyomKivalasztott.Text <> "" Then
            dgSzemelyValaszto.DataMember = ""
            dgSzemelyValaszto.Refresh()
            Dim ValasztottSzemelyTipus As String = dgTorzsValaszto.SelectedRows(0).Cells("dgSzemelytipusNeve").Value.ToString
            Dim DMB As String = String.Empty 'BindingSource"
            DMB = GetSzemelyTipusTAName(ValasztottSzemelyTipus)
            dgSzemelyValaszto.Columns.Clear()
            Me.dgSzemelyValaszto.AutoGenerateColumns = True
            dgSzemelyValaszto.DataMember = DMB
            dgSzemelyValaszto.Refresh()
            Me.dgSzemelyValaszto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            SelSzemelyRow = 0
            If dgSzemelyValaszto.Rows.Count > 0 Then dgSzemelyValaszto.Rows(0).Selected = True
        End If

        'Cél: a dgSzemelyValasztoban az a tábla jelenjenek meg, amelyek a kiválasztott sor dgSzemelyTipusa [Torzstabla_tipus]-ának megfelelnek. 
        '1. A dgSzemelyValasztoba esetleg beírt módosításokat mentse el
        '2. dgSzemelyValaszto DataMember módosítása
    End Sub

    Private Sub btnAddSzemelytoList_Click(sender As Object, e As EventArgs) Handles btnAddSzemelytoList.Click
        'Cél: kerüljön át lvKivalasztottak-ba: dgTorzsValaszto/dgNev [Nev] => lvSzerepkör 
        '[azaz Add.ListViewItem.Text=xxx -- index?]; 
        'dgSzemelyValaszto/ Név v. Teljes név => lvNeve 
        '[Add.ListViewItem.[azonos előző indexszel].ListViewSubItem.Text =""]
        'lVKivalasztottak/TorzsTabla és ID-t is kitölteni!
        Dim ValasztottSzemelyNeve As String = String.Empty
        If dgSzemelyValaszto.SelectedRows.Count < 1 Or tbNyomKivalasztott.Text = "" Or dgTorzsValaszto.SelectedRows Is Nothing Then Exit Sub
        For Each cell As DataGridViewCell In dgSzemelyValaszto.SelectedRows(0).Cells
            Dim oszlopneve = dgSzemelyValaszto.Columns.Item(cell.ColumnIndex).Name
            Select Case oszlopneve
                Case "Titulus", "Családi név", "Első utónév", "Ügyvéd/Titulus", "Jogtanácsos/Titulus", "Egyéb jogi képviselő/Titulus", "Viselt név/Családi név", "Viselt név/Első utónév", "Ügyvéd/Családi név", "Jogtanácsos/Családi név", "Egyéb jogi képviselő/Családi név", "Ügyvéd/Első utónév", "Jogtanácsos/Első utónév", "Egyéb jogi képviselő/Első utónév"
                    ValasztottSzemelyNeve = Strings.LTrim(ValasztottSzemelyNeve) + cell.Value.ToString + " "
                Case "Cég neve", "Szervezet megnevezése", "Ügyvédi iroda neve", "Név"
                    ValasztottSzemelyNeve = cell.Value.ToString
                    Exit For
                Case "Teljes név"
                    If cell.Value.ToString <> "" Then ValasztottSzemelyNeve = cell.Value.ToString
                    Exit For
            End Select
        Next
        If ValasztottSzemelyNeve <> "" And dgTorzsValaszto.SelectedRows.Count > 0 Then
            Dim LapCsoportNeve As String = dgTorzsValaszto.SelectedRows(0).Cells(0).Value.ToString()
            Dim Nevbe As New ListViewItem
            Dim Lapnev As New ListViewItem.ListViewSubItem
            Dim Szemelynev As New ListViewItem.ListViewSubItem
            Dim Torzstabla As New ListViewItem.ListViewSubItem
            Dim ID As New ListViewItem.ListViewSubItem
            Dim HanyadikLenne As Integer = GetHanyVanaLapbol(LapCsoportNeve) + 1
            If (LapCsoportNeve = "Alapadatok" Or LapCsoportNeve = "Adós" Or LapCsoportNeve = "Szakértő adatai") AndAlso HanyadikLenne > 1 Then
                MsgBox("Az adott laptípusból (" & LapCsoportNeve & ") egy nyomtatványon belül legfeljebb egy lapot tölthet ki.")
                Exit Sub
            End If
            Nevbe.Text = HanyadikLenne.ToString
            Lapnev.Name = "lvLap"
            Lapnev.Text = LapCsoportNeve
            Szemelynev.Name = "lvNeve"
            Szemelynev.Text = ValasztottSzemelyNeve
            Torzstabla.Name = "lvTorzsTabla"
            Torzstabla.Text = dgTorzsValaszto.SelectedRows(0).Cells(1).Value.ToString
            ID.Name = "lvID"
            ID.Text = dgSzemelyValaszto.SelectedRows(0).Cells(0).Value.ToString
            Nevbe.SubItems.AddRange({Lapnev, Szemelynev, Torzstabla, ID})
            lvKivalasztottak.Items.Add(Nevbe)

            'For Each indgSzem As DataGridViewCell In dgTorzsValaszto.SelectedRows(0).Cells
            '            MsgBox("columnindex=" & indgSzem.ColumnIndex & indgSzem.Value.ToString)
            '           Next

        End If

    End Sub
    Private Function GetHanyVanaLapbol(LapNeve As String) As Integer
        Dim result As Byte = 0
        For Each lvitem As ListViewItem In lvKivalasztottak.Items
            If lvitem.SubItems("lvLap").Text = LapNeve Then result += 1
        Next
        Return result
    End Function
    Private Sub btnTorol_Click(sender As Object, e As EventArgs) Handles btnTorol.Click
        'A kijelölt ListViewItem-et törölje az lvKivalasztottakból
        For Each lvitem As ListViewItem In lvKivalasztottak.SelectedItems
            lvitem.Remove()
        Next
        ReOrderLvItems()
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        MoveListItem(-1)
    End Sub
    Private Sub ReOrderLvItems()
        Dim MelyikbolHanyVan As New Dictionary(Of String, Integer)

        For Each lvitem As ListViewItem In lvKivalasztottak.Items
            Dim lvitemlap As String = lvitem.SubItems("lvLap").Text
            Dim currentindex As Integer
            If lvitemlap <> String.Empty Then
                If MelyikbolHanyVan.TryGetValue(lvitemlap, currentindex) Then
                    MelyikbolHanyVan(lvitemlap) = currentindex + 1
                Else
                    MelyikbolHanyVan.Add(lvitemlap, 1)
                End If
                lvitem.Text = MelyikbolHanyVan(lvitemlap)
            End If
        Next

    End Sub
    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        MoveListItem(1)
    End Sub
    Private Sub MoveListItem(Merre As Integer)
        If lvKivalasztottak.SelectedItems Is Nothing Then Exit Sub
        For Each KivalasztottItem As ListViewItem In lvKivalasztottak.SelectedItems
            Dim currentIndex As Integer = KivalasztottItem.Index
            Dim item As ListViewItem = lvKivalasztottak.Items(currentIndex)
            Dim target As Integer = currentIndex + Merre
            If target < lvKivalasztottak.Items.Count And target > -1 Then
                lvKivalasztottak.Items.RemoveAt(currentIndex)
                lvKivalasztottak.Items.Insert(currentIndex + Merre, item)
            End If
        Next
        ReOrderLvItems()
    End Sub
    Private Sub ChangedgTorzsValaszto(Kivalasztott As String)
        tbNyomKivalasztott.Text = Kivalasztott
        If dgTorzsValaszto.Enabled = False Then dgTorzsValaszto.Enabled = True
        If dgSzemelyValaszto.Enabled = False Then dgSzemelyValaszto.Enabled = True
        If dgUgyvalaszto.Enabled = False Then dgUgyvalaszto.Enabled = True
        If btnImportraMent.Enabled = False Then btnImportraMent.Enabled = True

        dgTorzs_Lap.FilteringEnabled = False
        dgTorzs_Lap.FilteringEnabled = True
        dgTorzsValaszto.DataSource.Filter = "Nyomtatvany='" & Kivalasztott & "'"
        'If dgTorzsValaszto.RowCount = 0 Then dgTorzsValaszto.DataSource.Filter = ""
    End Sub

    Private Sub btnKivalaszt_Click(sender As Object, e As EventArgs) Handles btnKivalaszt.Click
        If dgFRMENYKValaszto.SelectedRows.Count < 1 Then Exit Sub
        Dim Kivalasztott As String = dgFRMENYKValaszto.SelectedRows(0).Cells("Kód").Value.ToString
        If Kivalasztott = tbNyomKivalasztott.Text Then Exit Sub
        If lvKivalasztottak.Items.Count = 0 Then ChangedgTorzsValaszto(Kivalasztott)
        If lvKivalasztottak.Items.Count > 0 Then
            Dim dialogres As New DialogResult
            dialogres = MsgBox("Új sablon kiválasztása esetén a már eddig kiválasztott szerepkörök és személytípusok elveszhetnek! Folytatja?", MsgBoxStyle.YesNo)
            If dialogres = MsgBoxResult.Yes Then
                lvKivalasztottak.Items.Clear()
                ChangedgTorzsValaszto(Kivalasztott)
            End If
        End If
    End Sub

    Private Sub ImpFajlLementese(str As StringWriter)
        Dim MentesFajlNeve As String = String.Empty
        Dim MentesHelyeNevvel As String = String.Empty
        Dim MentesPath As String = ImpKonyvtarEllenorzese()
        MentesFajlNeve = Now.ToString("yyyyMMddHHmmssFFFF") & ".imp"
        'Alapból egy Imp_tmp nevű könyvtárba teszi az importálandó fájlokat, és ott törli az egy napnál régebbi *.imp fájlt, de ha ez valamiért nem működik, a futtatási könyvtárba helyezi el.
        If MentesPath <> String.Empty Then MentesHelyeNevvel = MentesPath & Path.DirectorySeparatorChar & MentesFajlNeve Else MentesHelyeNevvel = Path.GetFullPath(MentesFajlNeve)

        File.WriteAllBytes(MentesHelyeNevvel, EncodeString(str.ToString, "windows-1250"))
        MyLoader.AddLogBook(Fnc.cfg, "Import fájl lementve ide: " & MentesHelyeNevvel, LogTip.norm)
        abevjavaNyitas("cmd:file.import", MentesHelyeNevvel)

    End Sub

    Private Function ImpKonyvtarEllenorzese() As String
        Dim impdir As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "eperHelper", "Imp_tmp")
        If Not Directory.Exists(impdir) Then
            Try
                System.IO.Directory.CreateDirectory(impdir)
            Catch ex As Exception
                Dim uzenet1 = "Import könyvtár megnyitási hiba: " & impdir & ": " & ex.Message
                MyLoader.AddLogBook(Fnc.cfg, uzenet1, LogTip.err)
                MsgBox(uzenet1, MsgBoxStyle.Critical & MsgBoxStyle.OkOnly)
                impdir = ""
            End Try
        Else
        End If
        Dim FileColl = System.IO.Directory.GetFiles(Path.GetDirectoryName(impdir), "*.imp")
        For Each file In FileColl
            Dim fi As New FileInfo(file)
            Try
                If fi.LastAccessTime < Now.AddDays(-1) Then fi.Delete()
            Catch ex As Exception
                MyLoader.AddLogBook(Fnc.cfg, "Régi import fájl törlése sikertelen: " & fi.FullName & MyLog, LogTip.err)
            End Try
        Next
        Return impdir
    End Function

    Private Sub Kitolt_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Closing
        tbNyomKivalasztott.Text = ""
    End Sub

    Private Sub dgUgyvalaszto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUgyvalaszto.CellClick
        Dim dgv As DataGridView = TryCast(sender, DataGridView)
        If dgv.CurrentRow Is Nothing Then Exit Sub
        If dgv.CurrentRow.Selected And dgv.CurrentRow.Index = SelUgyRow Then
            dgv.CurrentRow.Selected = False
            SelUgyRow = -1
        Else
            dgv.CurrentRow.Selected = True
            SelUgyRow = dgv.CurrentRow.Index
        End If
    End Sub

    Private Sub dgTorzsValaszto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTorzsValaszto.CellClick
        Dim dgv As DataGridView = TryCast(sender, DataGridView)
        If dgv.CurrentRow Is Nothing Then Exit Sub
        If dgv.CurrentRow.Selected And dgv.CurrentRow.Index = SelTorzsRow Then
            dgv.CurrentRow.Selected = False
            SelTorzsRow = -1
        Else
            dgv.CurrentRow.Selected = True
            SelTorzsRow = dgv.CurrentRow.Index
        End If
    End Sub

    Private Sub dgSzemelyValaszto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSzemelyValaszto.CellClick
        Dim dgv As DataGridView = TryCast(sender, DataGridView)
        If dgv.CurrentRow Is Nothing Then Exit Sub
        If dgv.CurrentRow.Index = SelSzemelyRow Then
            dgv.CurrentRow.Selected = False
            SelSzemelyRow = -1
        Else
            dgv.CurrentRow.Selected = True
            SelSzemelyRow = dgv.CurrentRow.Index
        End If
    End Sub

    Private Sub btnAddUgy_Click(sender As Object, e As EventArgs) Handles btnAddUgy.Click
        Forms.TDB_Ugy.ShowDialog(Me)
        Me.Ugytorzs_rogzitoTableAdapter.Fill(Me.TorzsAdatbazisDataSet.Ugytorzs_rogzito)
        dgUgyvalaszto.DataSource = Me.UgytorzsrogzitoBindingSourceX

        If KitoltPass Is Nothing Then Exit Sub
        If KitoltPass(0) <> "" Then
            For Each item As DataGridViewRow In dgUgyvalaszto.Rows
                If item.Cells.Count = 0 Then Continue For
                If item.Cells(0).Value.ToString = KitoltPass(0) Then
                    item.Selected = True
                    Try
                        If tbNyomKivalasztott.Text <> String.Empty Then dgUgyvalaszto.FirstDisplayedScrollingRowIndex = dgUgyvalaszto.SelectedRows(0).Index
                    Catch ex As Exception
                    End Try
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub tbFajlnev_TextChanged(sender As Object, e As EventArgs) Handles tbFajlnev.TextChanged
        tbFajlnev.Text = CleanPathandFileName(tbFajlnev.Text)
    End Sub
End Class