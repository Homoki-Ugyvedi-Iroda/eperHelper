
' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class eperHelperRegClass
    Implements eperHelperRegWS_if
    Private Const TknUploadRegBak = "vCAj5dGq"
    Private Const TknDownloadRegBak = "F5UjCn"
    Private Const TknInvalidate = "s7uNaVeI"
    Private Const TknCheckCodeUsable = "qd4dBGzT"
    Private Const TknStatusCheck = "73GDf9C9"
    Private Const TknDumpFullDT = "dqS54SnC"
    Private Const TknUploadNewCode = "mE4cSV2U"
    Private Const TknListRegsInPeriod = "gqXN49Jd"
    Private Const TknDeleteById = "8zuZ6zdvxA2x"
    Private Const TknSetOtherState = "3TjEywaQS9Z9"
    Private Const TknDeleteRegBakbyCode = "ptp4roQOBX"
    Private Const TknCheckMac = "!84P%W*s5Y74ZeB"


    Public Sub New()
    End Sub
#Region "Protected Functions"

    Protected Function FindCode(ByVal Code As String, ByRef db As DataSetRegistration.RegistrationEntryDataTable, FindInvalidated As Boolean, FindUsed As Boolean) As DataSetRegistration.RegistrationEntryRow
        Dim CodeRows() As DataSetRegistration.RegistrationEntryRow = db.Select("Code = '" & Code & "'")
        'Throw New Exception(CodeRows.Count)
        If CodeRows.Count < 1 Then
            Throw New Exception("A megadott kód nem található (" & Code & ")(a)")
            Return Nothing
        End If
        If CodeRows.Count > 1 Then
            Dim HanyIlyenJoSorVan As Integer = 0
            Dim celRow As DataSetRegistration.RegistrationEntryRow = Nothing
            For Each row As DataSetRegistration.RegistrationEntryRow In CodeRows
                If row.Used = FindUsed And row.Invalidated = FindInvalidated Then HanyIlyenJoSorVan += 1
                celRow = row
            Next
            If HanyIlyenJoSorVan > 1 Then
                Throw New Exception("Adatbázis hiba: több azonos kód is található az adatbázisban. Jelezze a hibát a támogatónak!")
                Return celRow
            ElseIf HanyIlyenJoSorVan = 1 Then
                Return celRow
            End If
        End If
        If CodeRows.Count = 1 And CodeRows.First.Used = FindUsed And CodeRows.First.Invalidated = FindInvalidated Then
            Return CodeRows.First
        Else
            If CodeRows.First.Used And Not FindUsed Then Throw New Exception("A megadott kódot már felhasználták")
            If Not CodeRows.First.Used And FindUsed Then Throw New Exception("A megadott kód még nincsen felhasználva")
            If CodeRows.First.Invalidated And Not FindInvalidated Then Throw New Exception("A megadott kód érvénytelen")
            If Not CodeRows.First.Invalidated And FindInvalidated Then Throw New Exception("A megadott kód nem érvénytelen")
            Return Nothing
        End If
        Throw New Exception("Egyéb hiba kódkeresés során")
    End Function

    Protected Function FindCodeAll(ByVal Code As String, ByRef db As DataSetRegistration.RegistrationEntryDataTable) As DataSetRegistration.RegistrationEntryRow()
        Dim CodeRows() As DataSetRegistration.RegistrationEntryRow = db.Select("Code = '" & Code & "'")
        If CodeRows.Count < 1 Then
            Throw New Exception("A megadott kód nem található (" & Code & ")(b)")
            Return Nothing
        End If
        Return CodeRows
        Throw New Exception("Egyéb hiba kódkeresés során (FindCodeAll)")
    End Function


    Protected Function checkRegSrvFile(row As DataSetRegistration.RegistrationEntryRow) As Boolean
        If IsNothing(row.RegSrvFile) Then Return False
        If IsDBNull(row.RegSrvFile) Then Return False
        If row.RegSrvFile.Length = 0 Then Return False
        Return True
    End Function

    Protected Function SerializeDT(dt As DataTable) As String
        '        Dim serializer = New System.Xml.Serialization.XmlSerializer(GetType(DataTable))
        Dim sw As New IO.StringWriter()
        '      serializer.Serialize(sw, dt)
        dt.WriteXml(sw)
        Return sw.ToString
    End Function
#End Region


    Public Function RegisterCode(ByVal Code As String) As String Implements eperHelperRegWS_if.RegisterCode
        If Code = String.Empty Then
            Throw New FaultException("Nem adott meg kódot")
            Return Nothing
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Code = Code.Trim
        Dim valasz As Integer = 0
        Dim foundrow As DataSetRegistration.RegistrationEntryRow = Nothing
        Try
            foundrow = FindCode(Code, db, FindInvalidated:=False, FindUsed:=False)
            If Not IsNothing(foundrow) Then
                foundrow.Used = True
                Try
                    foundrow.regdate = CType(Now, DateTime)
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
            Throw New FaultException(ex.Message)
            Return Nothing
        End Try

        Try
            ta.Update(db)
            Return "Sikeres regisztráció (regisztrált kód: " & Code & ")"
        Catch ex As Exception
            Throw New FaultException("A rögzítés sikertelen (adatbázis hiba) - " & ex.Message)
        End Try
    End Function

    Public Function DeleteRegBakbyCode(Token As String, Code As String) As Boolean Implements eperHelperRegWS_if.DeleteRegBakbyCode
        If Not Token = TknDeleteRegBakbyCode Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        If Code = String.Empty Then
            Throw New FaultException("Nem adott meg kódot")
            Return Nothing
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Code = Code.Trim
        Dim valasz As Boolean = False
        Dim foundrows As DataSetRegistration.RegistrationEntryRow() = {Nothing}
        Try
            foundrows = FindCodeAll(Code, db)
            For Each foundrow As DataSetRegistration.RegistrationEntryRow In foundrows
                If checkRegSrvFile(foundrow) Then foundrow.RegSrvFile = {}
                valasz = True
            Next
            ta.Update(db)
            Return valasz
        Catch ex As Exception
            Throw New FaultException(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function UploadRegBak(ByVal Token As String, ByVal Code As String, ByVal ServerRegXmlZipped As Byte()) As String Implements eperHelperRegWS_if.UploadRegBak
        If Not Token = TknUploadRegBak Then 
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        If IsNothing(ServerRegXmlZipped) Then
            Throw New FaultException("Nincs meg a feltöltendő fájl")
            Return Nothing
        End If
        If Code = String.Empty Then
            Throw New FaultException("Nem adott meg kódot")
            Return Nothing
        End If

        If ServerRegXmlZipped.Length > 65535 Then
            Throw New FaultException("Túl nagy a megadott fájl mérete (max. 65535 byte)")
            Return Nothing 'Ennél nagyobbat csak streamben lehetne, de itt zippelt 10-50 KB-os xml fájlokról van szó
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Code = Code.Trim
        Dim foundrow As DataSetRegistration.RegistrationEntryRow = Nothing
        Try
            foundrow = FindCode(Code, db, FindInvalidated:=False, FindUsed:=True)
            If Not IsNothing(foundrow) Then foundrow.RegSrvFile = ServerRegXmlZipped 'Itt menti be a megfelelő rekordba a byte()-ot
        Catch ex As Exception
            Throw New FaultException(ex.Message)
            Return Nothing
        End Try
        Try
            ta.Update(db) 'Itt rögzíti a módosított rekordot az adatbázisban
            Return "Sikeres rögzítés (érintett kód: " & Code & ")"
        Catch ex As Exception
            Throw New FaultException("A rögzítés sikertelen (adatbázis hiba) - " & ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function DownloadRegBak(Token As String, Code As String) As Byte() Implements eperHelperRegWS_if.DownloadRegBak
        If Not Token = TknDownloadRegBak Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        If Code = String.Empty Then
            Throw New FaultException("Nem adott meg kódot")
            Return Nothing
        End If

        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Code = Code.Trim
        Dim foundrows As DataSetRegistration.RegistrationEntryRow() = {Nothing}
        Try
            foundrows = FindCodeAll(Code, db)
            If foundrows.Count = 1 Then
                If checkRegSrvFile(foundrows.First) Then
                    Return foundrows.First.RegSrvFile 'Itt adja vissza a megfelelő rekordból a byte()-ot
                Else
                    Throw New FaultException("A megadott kódhoz nem lett regisztrációs fájl rögzítve")
                    Return Nothing
                End If
            End If
            If foundrows.Count > 1 Then
                'Ha több talált kód is van, akkor az utolsót adja vissza, amelyiknek van regisztrációs fájlja lementve, ha ebből is több van, azt adja le, amelyik már használt kódhoz tartozik, egyébként ha ilyen nincsen, az utolsó bármelyiket, aminek van fájlja lementve
                Dim returnrow As DataSetRegistration.RegistrationEntryRow = Nothing
                For Each foundrow As DataSetRegistration.RegistrationEntryRow In foundrows
                    If foundrow.Used And checkRegSrvFile(foundrow) Then returnrow = foundrow
                Next
                If checkRegSrvFile(returnrow) Then Return returnrow.RegSrvFile
            Else
                Dim returnrow As DataSetRegistration.RegistrationEntryRow = Nothing
                For Each foundrow As DataSetRegistration.RegistrationEntryRow In foundrows
                    If checkRegSrvFile(foundrow) Then returnrow = foundrow
                Next
                If checkRegSrvFile(returnrow) Then
                    Return returnrow.RegSrvFile
                Else
                    Throw New FaultException("A megadott kódhoz nem lett regisztrációs fájl rögzítve")
                    Return Nothing
                End If
            End If
        Catch ex As Exception
            Throw New FaultException(ex.Message)
            Return Nothing
        End Try
        Throw New FaultException("Egyéb hiba")
        Return Nothing
    End Function

    Public Function DownloadRegBakbyId(Token As String, Id As Integer) As Byte() Implements eperHelperRegWS_if.DownloadRegBakbyId
        If Not Token = TknDownloadRegBak Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        If Id = 0 Then
            Throw New FaultException("Nem adott meg kódot")
            Return Nothing
        End If

        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)

        Dim foundrow As DataSetRegistration.RegistrationEntryRow = db.FindById(Id)
        If IsNothing(foundrow) Then
            Throw New FaultException("Nem létező ID")
            Return Nothing
        End If

        If checkRegSrvFile(foundrow) Then
            Return foundrow.RegSrvFile 'Itt adja vissza a megfelelő rekordból a byte()-ot
        Else
            Throw New FaultException("A megadott kódhoz nem lett regisztrációs fájl rögzítve")
            Return Nothing
        End If
        Throw New FaultException("Egyéb hiba")
        Return Nothing
    End Function

    Public Function InvalidateCodeByCode(Token As String, Code As String) As String Implements eperHelperRegWS_if.InvalidateCodebyCode
        If Not Token = TknInvalidate Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        If Code = String.Empty Then
            Throw New FaultException("Nem adott meg kódot")
            Return Nothing
        End If

        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Code = Code.Trim
        Dim foundrows As DataSetRegistration.RegistrationEntryRow() = {Nothing}
        Try
            foundrows = FindCodeAll(Code, db)
            For Each foundrow As DataSetRegistration.RegistrationEntryRow In foundrows
                foundrow.Invalidated = True 'Itt menti be a megfelelő rekordba az érvénytelenítést
            Next
        Catch ex As Exception
            Throw New FaultException(ex.Message)
            Return Nothing
        End Try
        Try
            ta.Update(db) 'Itt rögzíti a módosított rekordot az adatbázisban
            Return "Sikeres érvénytelenítés (érintett kód: " & Code & ")"
        Catch ex As Exception
            Throw New FaultException("Az érvénytelenítés rögzítése sikertelen (adatbázis hiba) - " & ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function CheckCodeUsable(Token As String, Code As String) As String Implements eperHelperRegWS_if.CheckCodeUsable
        If Not Token = TknCheckCodeUsable Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        If Code = String.Empty Then
            Throw New FaultException("Nem adott meg kódot")
            Return Nothing
        End If

        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Code = Code.Trim
        Dim foundrows As DataSetRegistration.RegistrationEntryRow() = Nothing
        Dim notfound As String = "Az ellenőrizendő kód nem található"
        Try
            foundrows = FindCodeAll(Code, db)
            Dim strB As New StringBuilder
            For Each foundrow As DataSetRegistration.RegistrationEntryRow In foundrows
                Dim regdatum As String = String.Empty
                If Not IsDBNull(foundrow.regdate) And Not IsNothing(foundrow.regdate) Then regdatum = foundrow.regdate.ToString Else regdatum = "(üres)"
                Dim regsrvfajl As String = String.Empty
                If checkRegSrvFile(foundrow) Then regsrvfajl = "van" Else regsrvfajl = "(üres)"
                strB.AppendFormat(Environment.NewLine & "Kód: {0}. Használt: {1}. Érvénytelen: {2}. Regisztráció dátuma: {3}. Regisztrációs fájl feltöltve: {4}. Id: {5}. MAC: {6}", foundrow.Code.Trim, foundrow.Used.ToString, foundrow.Invalidated.ToString, regdatum, regsrvfajl, foundrow.Id.ToString, "") ', foundrow.MAC)
            Next
            If strB.Length > 0 Then
                Return strB.ToString
            Else
                Throw New FaultException(notfound)
                Return Nothing
            End If
        Catch ex As Exception
            Throw New FaultException(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function StatusCheck(Token As String) As String Implements eperHelperRegWS_if.StatusCheck
        If Not Token = TknStatusCheck Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Dim qryCodeTotal As String = db.Rows.Count
        Dim qryCodeFree As String = db.Select("Invalidated = False AND Used = False").Count
        Dim qryCodeInvalid As String = db.Select("Invalidated = True").Count
        Dim summasize As Integer = 0
        For Each row As DataSetRegistration.RegistrationEntryRow In db.Rows
            If checkRegSrvFile(row) Then summasize += row.RegSrvFile.Length
        Next
        summasize = summasize / 1024 / 1024
        Dim qryRegBakSize As String = summasize.ToString & " MB"
        Dim qryLastReg As String = String.Empty
        db.DefaultView.Sort = "regdate DESC"
        Dim dv As DataView = db.DefaultView
        Dim lastrow As DataSetRegistration.RegistrationEntryRow = Nothing
        If dv.ToTable.Rows.Count > 0 Then
            lastrow = db.FindById(dv.ToTable.Rows(0)("Id"))
            If Not IsNothing(lastrow.regdate) And Not IsDBNull(lastrow.regdate) Then
                qryLastReg = lastrow.regdate.ToString & "=" & lastrow.Code
            End If
        Else
            qryLastReg = "(nem volt még regisztráció)"
        End If

        Dim valasz As New StringBuilder
        valasz.AppendLine("Összes kód száma: " & qryCodeTotal)
        valasz.AppendLine("Ebből szabad: " & qryCodeFree)
        valasz.AppendLine("Összes kódból érvénytelen: " & qryCodeInvalid)
        valasz.AppendLine("Regisztrációs mentések összes mérete: " & qryRegBakSize)
        valasz.AppendLine("Utolsó regisztráció időpontja: " & qryLastReg)
        Return valasz.ToString
    End Function
    Public Function DumpFullDT(Token As String) As String Implements eperHelperRegWS_if.DumpFullDT
        'RegSrvFile nélkül visszaadja a teljes regisztrációs táblát
        If Not Token = TknDumpFullDT Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If

        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)

        Dim valaszDT As New DataTable
        Try
            valaszDT.TableName = "RegSrvTabla"
            valaszDT = db.Copy
            valaszDT.Columns.Remove("RegSrvFile")
        Catch ex As Exception
            Throw New FaultException("Egyéb hiba miatt nem lehetett a teljes táblát visszaadni#1")
        End Try
        If IsNothing(valaszDT) Then
            Throw New FaultException("Egyéb hiba miatt nem lehetett a teljes táblát visszaadni#2")
            Return Nothing
        Else
            If valaszDT.Rows.Count < 1 Then Return Nothing
            Return SerializeDT(valaszDT)
        End If
    End Function

    Public Function UploadNewCode(Token As String, CodeList As List(Of String)) As String Implements eperHelperRegWS_if.UploadNewCode
        If Not Token = TknUploadNewCode Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        Dim valaszDT As New DataTable

        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)

        Dim i As Integer = 0
        Dim latestid As Integer = 0
        For Each newcode As String In CodeList
            If newcode = String.Empty Then Continue For
            Dim workRow As DataSetRegistration.RegistrationEntryRow = db.NewRegistrationEntryRow
            workRow.Code = newcode
            workRow.regdate = DateTime.MinValue
            workRow.RegSrvFile = {}
            workRow.Used = False
            workRow.Invalidated = False
            db.AddRegistrationEntryRow(workRow)
            i += 1
        Next
        If i > 0 Then
            Try
                ta.Update(db)
                db.DefaultView.Sort = "Id DESC"
                Dim dv As DataView = db.DefaultView
                Dim lastrow As DataSetRegistration.RegistrationEntryRow = Nothing
                latestid = dv.ToTable.Rows(0)("Id")
                Return "Sikeresen rögzítve: " & i & " kód (új id-k: " & CType(latestid - i + 1, String) & "-" & latestid & ")"
            Catch ex As Exception
                Throw New FaultException("Adatbázis frissítési hiba. A kódok nem lettek lementve")
                Return Nothing
            End Try
        End If
        Return 0
    End Function

    Public Function ListRegsInPeriod(Token As String, StartDate As Date, EndDate As Date) As String Implements eperHelperRegWS_if.ListRegsInPeriod
        If Not Token = TknListRegsInPeriod Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        If EndDate = Date.MinValue Then EndDate = Now
        Dim valaszDT As New DataTable
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)

        'Dim StartDateSQL = String.Format(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat, "#{0}#", StartDate)
        'Dim EndDateSQL = String.Format(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat, "#{0}#", StartDate.AddDays(1))
        Dim rowsfiltered As DataSetRegistration.RegistrationEntryDataTable = db.Copy
        For Each row As DataSetRegistration.RegistrationEntryRow In rowsfiltered
            If row.Used = False Then row.Delete() : Continue For
            If row.regdate < StartDate Then row.Delete() : Continue For
            If row.regdate >= EndDate Then row.Delete()
        Next
        rowsfiltered.AcceptChanges()
        'Dim rows As DataSetRegistration.RegistrationEntryRow() = rowsfiltered.Select("regdate >= " & StartDateSQL & " AND regdate < " & EndDateSQL)
        If rowsfiltered.Count < 1 Then
            Throw New FaultException("Nem volt regisztráció a két megadott dátum között")
            Return Nothing
        End If
        Dim osszervenytelen As Integer = 0
        Dim strbuild As New StringBuilder
        strbuild.AppendFormat("Kód       |Dátum és idő         |Használt?|Érvénytelenített?|RegSrvFájl?")
        strbuild.AppendLine()
        For Each row As DataSetRegistration.RegistrationEntryRow In rowsfiltered.Rows
            Dim blnRegSrvFájl As Boolean = False
            If checkRegSrvFile(row) Then blnRegSrvFájl = True
            strbuild.AppendFormat("{0,6}|{1,21}|{2,9}|{3,17}|{4,5}", row.Code, row.regdate, row.Used, row.Invalidated, blnRegSrvFájl)
            strbuild.AppendLine()
            If row.Invalidated = True Then osszervenytelen += 1
        Next
        If rowsfiltered.Count < 1 Then Return "Nem lett ezen időtartam alatt egy kód sem regisztrálva"
        strbuild.AppendFormat("Összesen regisztrálva lett {0}. db. kód, amelyből mostanáig {1}. db. érvénytelenített", rowsfiltered.Count, osszervenytelen.ToString)
        Return strbuild.ToString
    End Function

    Public Function DeletebyId(Token As String, IdToDelete As Integer) As Boolean Implements eperHelperRegWS_if.DeletebyId
        If Not Token = TknDeleteById Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Dim foundrow As DataSetRegistration.RegistrationEntryRow = db.FindById(IdToDelete)
        If IsNothing(foundrow) Then
            Throw New FaultException("Nem létező ID")
            Return False
        End If
        Try
            'foundrow.Delete()
            'ta.Update(db)
            ta.Delete(foundrow.Id)
            Return True
        Catch ex As Exception
            Throw New FaultException("Adatbázis törlési hiba. A kód nem lett törölve")
            Return Nothing
        End Try
        Return False
    End Function

    Public Function SetOtherState(Token As String, IdToChange As Integer, Operation As Integer) As Boolean Implements eperHelperRegWS_if.SetOtherState
        If Not Token = TknSetOtherState Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Dim foundrow As DataSetRegistration.RegistrationEntryRow = db.FindById(IdToChange)
        If IsNothing(foundrow) Then
            Throw New FaultException("Nem létező ID")
            Return False
        End If
        Try
            Select Case Operation
                Case 1
                    foundrow.Used = False
                Case 2
                    foundrow.Used = True
                Case 3
                    foundrow.Invalidated = False
                Case 4
                    foundrow.Invalidated = True
                Case 5
                    foundrow.RegSrvFile = {}
            End Select

            'foundrow.AcceptChanges()
            ta.Update(db)
            Return True
        Catch ex As Exception
            Throw New FaultException("Adatbázis módosítási hiba. A kód nem lett módosítva")
            Return Nothing
        End Try
        Return False
    End Function

    Public Function SetRegDate(Token As String, IdToChange As Integer, WhenRegistered As DateTime) As Boolean Implements eperHelperRegWS_if.SetRegDate
        If Not Token = TknSetOtherState Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Dim foundrow As DataSetRegistration.RegistrationEntryRow = db.FindById(IdToChange)
        If IsNothing(foundrow) Then
            Throw New FaultException("Nem létező ID")
            Return False
        End If
        Try
            foundrow.regdate = WhenRegistered
            'foundrow.AcceptChanges()
            ta.Update(db)
            Return True
        Catch ex As Exception
            Throw New FaultException("Adatbázis módosítási hiba. A kód nem lett módosítva")
            Return Nothing
        End Try
        Return False
    End Function


    Public Function CheckMac(Token As String, macAddresses As String()) As Boolean Implements eperHelperRegWS_if.CheckMac
        For Each lineBekuldott In macAddresses
            'For Each lineregisztralt In foundrow.MAC
            'If lineBekuldott = lineregisztralt Then Return True
            'Next
        Next
        Return False
    End Function

    Public Function RegisterCodewMAC(Code As String, macAddresses As String()) As Boolean Implements eperHelperRegWS_if.RegisterCodewMAC
        If Code = String.Empty Then
            Throw New FaultException("Nem adott meg kódot")
            Return False
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Code = Code.Trim
        Dim valasz As Integer = 0
        Dim foundrow As DataSetRegistration.RegistrationEntryRow = Nothing
        Try
            foundrow = FindCode(Code, db, FindInvalidated:=False, FindUsed:=True)
            If Not IsNothing(foundrow) Then
                'foundrow.MAC = macAddresses
            End If
        Catch ex As Exception
            Throw New FaultException(ex.Message)
            Return False
        End Try

        Try
            ta.Update(db)
            Return True
        Catch ex As Exception
            Throw New FaultException("A rögzítés sikertelen (adatbázis hiba) - " & ex.Message)
        End Try
        Return False
    End Function

    Public Function ChangeCodewMAC(Token As String, Code As String, macAddresses As String()) As Boolean Implements eperHelperRegWS_if.ChangeCodewMAC
        If Not Token = TknCheckMac Then
            Throw New FaultException("Token hiba")
            Return Nothing
        End If
        If Code = String.Empty Then
            Throw New FaultException("Nem adott meg kódot")
            Return Nothing
        End If
        Dim db As New DataSetRegistration.RegistrationEntryDataTable
        Dim ta As New DataSetRegistrationTableAdapters.RegistrationEntryTableAdapter
        ta.Fill(db)
        Code = Code.Trim
        Dim valasz As Boolean = False
        Dim foundrows As DataSetRegistration.RegistrationEntryRow() = {Nothing}
        Try
            foundrows = FindCodeAll(Code, db)
            For Each foundrow As DataSetRegistration.RegistrationEntryRow In foundrows
                'foundrow.MAC = macAddresses
                valasz = True
                ta.Update(db)
            Next
            Return valasz
        Catch ex As Exception
            Throw New FaultException(ex.Message)
            Return Nothing
        End Try
        Return False
    End Function

End Class
