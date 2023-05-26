Imports CoreTechs.Common.Text

Public Class CsvImport
    Dim masolatDataTable As DataTable
    Private Sub btnTallóz_Click(sender As Object, e As EventArgs) Handles btnTallóz.Click
        Dim dialogresult As New DialogResult
        Dim CSVDialog As New OpenFileDialog
        Dim sendervalue As String = tbCSVneve.Text
        Dim TorzsTablaNevek As New List(Of String)
        Dim names = [Enum].GetNames(GetType(TorzsTipus_rogzito))
        For Each EnumName In names
            TorzsTablaNevek.Add(EnumName & "_rogzito.csv")
        Next

        CSVDialog.Filter = "CSV fájl (*.csv)| *.csv"
        If System.IO.File.Exists(sendervalue) Then
            CSVDialog.InitialDirectory = System.IO.Path.GetDirectoryName(sendervalue)
            CSVDialog.FileName = sendervalue
        End If
        dialogresult = CSVDialog.ShowDialog()
        If dialogresult = DialogResult.OK Then
            If TorzsTablaNevek.Contains(Path.GetFileName(CSVDialog.FileName), StringComparer.CurrentCultureIgnoreCase) Then
                tbCSVneve.Text = CSVDialog.FileName
                ErrorProvider1.SetError(tbCSVneve, "")
            Else
                ErrorProvider1.SetError(tbCSVneve, "A kiválasztott fájlnév nem a mintákban megadott (pl. Ceg_rogzito.csv)!")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnMegnyit_Click(sender As Object, e As EventArgs) Handles btnMegnyit.Click
        Dim mString As String = String.Empty
        Dim tempDataTable As New DataTable
        Dim reader As StringReader = Nothing
        Try

            Select Case Path.GetFileNameWithoutExtension(tbCSVneve.Text)
                Case "Ceg_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.Ceg_rogzito.Clone
                Case "Egyeb_jogi_kvo_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.Egyeb_jogi_kvo_rogzito.Clone
                Case "Egyeb_szervezet_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.Egyeb_szervezet_rogzito.Clone
                Case "Egyeni_ugyvedi_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.Egyeni_ugyvedi_rogzito.Clone
                Case "EV_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.EV_rogzito.Clone
                Case "Jogtanacsos_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.Jogtanacsos_rogzito.Clone
                Case "Term_szemely_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.Term_szemely_rogzito.Clone
                Case "Ugyvedi_iroda_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.Ugyvedi_iroda_rogzito.Clone
                Case "Ugytorzs_rogzito"
                    masolatDataTable = TorzsAdatbazisDataSet.Ugytorzs_rogzito.Clone
            End Select
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Hozzáférési hiba! A törzsadatbázis nem érhető el!", MsgBoxStyle.Critical)
            Exit Sub
        End Try
        If tbCSVneve.Text <> String.Empty Then
            Try
                Dim strLoaded As String = File.ReadAllText(tbCSVneve.Text, System.Text.Encoding.UTF8)
                reader = New StringReader(strLoaded)
            Catch ex As Exception
                MsgBox("Betöltési hiba (nem megfelelő fájl?). Hibaüzenet: " & ex.Message)
            End Try
        Else
            Exit Sub
        End If
        Using it = reader.ReadCsvWithHeader(StringComparer.CurrentCultureIgnoreCase, ";"c).GetEnumerator()

            If Not it.MoveNext() Then Exit Sub

            For Each k In it.Current.Keys
                tempDataTable.Columns.Add(k)
            Next

            Do
                Dim row = tempDataTable.NewRow()
                For Each k In it.Current.Keys
                    row(k) = it.Current(k)
                Next
                tempDataTable.Rows.Add(row)
            Loop While it.MoveNext()
        End Using

        Dim i As Integer = 0
        Dim hibas As Integer = 0
        For Each row As DataRow In tempDataTable.Rows
            i += 1
            Try
                masolatDataTable.ImportRow(row)
            Catch ex As Exception
                MsgBox("Hiba a " & CStr(i) & " sor olvasása során, kihagyva")
                hibas += 1
            End Try
        Next
        Dim uzenet As String
        If hibas <> 0 Then
            uzenet = "A " & tempDataTable.Rows.Count & " sorból " & hibas & " db. hibásan lett beolvasva."
        Else
            uzenet = "Sikeresen beolvasva " & tempDataTable.Rows.Count & " sor."
        End If
        MyLoader.AddLogBook(Fnc.db, uzenet, IIf(hibas = 0, LogTip.siker, LogTip.err))
        If masolatDataTable.Rows.Count <> 0 Then
            dgBetekinto.AutoGenerateColumns = True
            dgBetekinto.Columns.Clear()
            dgBetekinto.DataSource = masolatDataTable
            dgBetekinto.Refresh()
        End If

    End Sub


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Kiválasztott típusnak megfelelő DataTable-be betöltse
        If masolatDataTable Is Nothing Then MsgBox("Még nem töltött be CSV fájlt!") : Exit Sub
        If masolatDataTable.Rows.Count = 0 Then MsgBox("Még nem töltött be CSV fájlt!") : Exit Sub
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim newdt As New DataTable

        con.ConnectionString = Global.homoki.eperhelper.My.MySettings.Default.TorzsadatokConnectionString
        con.Open()

        Dim MDBadapter As New OleDb.OleDbDataAdapter

        Dim SqlAlap As String = String.Empty
        Dim Qmark As String = String.Empty
        For Each colname As DataColumn In masolatDataTable.Columns
            If SqlAlap <> "" Then
                SqlAlap += ", [" & colname.ColumnName & "]"
                Qmark += ", ?"
            Else
                SqlAlap = "[" & colname.ColumnName & "]"
                Qmark = "?"
            End If
        Next
        Dim Sql As String = "SELECT " & SqlAlap & " FROM " & Path.GetFileNameWithoutExtension(tbCSVneve.Text)

        cmd = New OleDb.OleDbCommand(Sql, con)
        MDBadapter.SelectCommand = cmd

        'MDBadapter.InsertCommand = cmd
        Dim oledbCommandBuilder As New OleDb.OleDbCommandBuilder(MDBadapter)
        oledbCommandBuilder.QuotePrefix = "["
        oledbCommandBuilder.QuoteSuffix = "]"
        MDBadapter.InsertCommand = oledbCommandBuilder.GetInsertCommand()
        MDBadapter.UpdateCommand = oledbCommandBuilder.GetUpdateCommand()
        MDBadapter.Fill(newdt)

        For Each drow As DataRow In masolatDataTable.Rows
            newdt.NewRow()
            newdt.ImportRow(drow)
        Next

        'cmd.ExecuteNonQuery()
        Dim uzenet As String = String.Empty
        Dim sikeresseg As String = String.Empty
        Try
            'MDBadapter.Update(newdt)
            MDBadapter.Update(masolatDataTable)
            uzenet = "Sikeresen frissítve."
            sikeresseg = LogTip.siker
        Catch ex As Exception
            uzenet = "Frissítés nem sikerült."
            sikeresseg = LogTip.err
        End Try
        MyLoader.AddLogBook(Fnc.db, uzenet, sikeresseg)
        MsgBox(uzenet)
        con.Close()
        Me.Close()


    End Sub

    Private Sub btnKilép_Click(sender As Object, e As EventArgs) Handles btnKilép.Click
        Me.Close()
    End Sub
End Class