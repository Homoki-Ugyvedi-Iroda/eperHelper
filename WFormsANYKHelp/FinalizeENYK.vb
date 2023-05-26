Public Class FinalizeENYK

    Friend Shared Function ConvertENYKtoXML(InputFileNeve As String, OutputFileNeve As String) As Boolean
        If String.IsNullOrWhiteSpace(InputFileNeve) Or String.IsNullOrWhiteSpace(OutputFileNeve) Then Return False
        Trace.WriteLine("ENYK->XML véglegesítés megpróbálása: input=" & InputFileNeve & "; output=" & OutputFileNeve)
        Dim xdoc As XDocument
        Try
            xdoc = XDocument.Load(InputFileNeve)
        Catch ex As Exception
            Dim hibauzenet = "A megadott nyomtatványt nem tudjuk a program nem tudja betölteni, mert nem létezik vagy hibás az XML fájl"
            MsgBox(hibauzenet)
            MyLoader.AddLogBook(Fnc.xml, hibauzenet, LogTip.err)
            Return False
        End Try
        Dim firstChild As XElement = xdoc.Root.Elements().Last
        If IsNothing(firstChild) Then
            Dim hibauzenet = "Hibás az XML fájl - nincsen benne a keresett elem (Root.Elements.Last)"
            MsgBox(hibauzenet)
            MyLoader.AddLogBook(Fnc.xml, hibauzenet, LogTip.err)
            Return False
        End If

        If IsNothing(xdoc.Declaration) Then
            Dim hibauzenet = "Hibás az XML fájl - nincsen benne a keresett elem (Declaration)"
            MyLoader.AddLogBook(Fnc.xml, hibauzenet, LogTip.err)
            Return False
        End If

        Dim output As New XDocument(New XDeclaration(xdoc.Declaration), firstChild)
        Dim xmlns As XNamespace = "http://iop.gov.hu/2007/01/nyk/altalanosnyomtatvany"
        xdoc = Nothing
        If IsNothing(output.Root.Name.LocalName) Then
            Trace.WriteLine("Nem létező output.Root.Name.LocalName")
        End If

        output.Root.Name = xmlns + output.Root.Name.LocalName
        output.Root.SetAttributeValue("template", Nothing)
        output.Root.SetAttributeValue("name", Nothing)
        output.Root.SetAttributeValue("id", Nothing)

        Dim rovidelnev = output.Element(xmlns + "nyomtatvanyok").Element(xmlns + "nyomtatvany").Element(xmlns + "mezok").Elements(xmlns + "mezo")
        If rovidelnev.Count > 1 Then
            For i = rovidelnev.Count - 1 To 0 Step -1
                Dim eazon As String = rovidelnev(i).Attribute("eazon").Value
                Dim nazon As String = String.Empty
                Dim splitazon() As String = eazon.Split("_")
                If splitazon(1).Length = 4 Then
                    rovidelnev(i).Remove()
                    Continue For
                End If
                If splitazon(1).Contains("XXXX") Then
                    Dim ideiglenes_integer = CType(splitazon(0), Integer) + 1
                    splitazon(0) = ideiglenes_integer.ToString
                    nazon = splitazon(1).Replace("XXXX", potol4re(splitazon(0)))
                Else
                    nazon = splitazon(1)
                End If
                Try
                    rovidelnev(i).SetAttributeValue("eazon", nazon)
                Catch ex As Exception
                    Trace.WriteLine("rovidelnev(i).SetAttributeValue('eazon', nazon) hiba")
                End Try
            Next
        Else
            Trace.WriteLine("FinalizeENYK: rovidelnev.Count<1")
        End If

        Dim orig As XElement = output.Element(xmlns + "nyomtatvanyok").Element(xmlns + "nyomtatvany").Element(xmlns + "mezok")
        Dim ujmezonev As XElement = SortChildElements(orig)
        If IsNothing(ujmezonev) Then
            Dim hibauzenet = "Szortirozási hiba (üres eredmény)"
                Trace.WriteLine("XML készítés hibaüzenet =" & hibauzenet)
            End If
        orig.ReplaceWith(ujmezonev)
        Try
            output.Element(xmlns + "nyomtatvanyok").Element(xmlns + "nyomtatvany").Element(xmlns + "nyomtatvanyinformacio").Element(xmlns + "megjegyzes").SetValue("")
        Catch ex As Exception
            Trace.WriteLine("output.Elements#1")
        End Try
        Try
            output.Element(xmlns + "nyomtatvanyok").Element(xmlns + "nyomtatvany").SetAttributeValue("sn", Nothing)
        Catch ex As Exception
            Trace.WriteLine("output.Elements#2")
        End Try

        Dim abev As XElement = output.Element(xmlns + "nyomtatvanyok").Element(xmlns + "abev")
        Dim prgverzio As String = abev.Element(xmlns + "programverzio").Value
        Try
            abev.Elements().Remove
        Catch ex As Exception
            Trace.WriteLine("abev.Elements().Remove")
        End Try
        abev.Add(New XElement(xmlns + "hibakszama", "0"))
        abev.Add(New XElement(xmlns + "hash", "Piller KFT                              "))
        abev.Add(New XElement(xmlns + "programverzio", prgverzio))
        Dim hashValue As String = getSHA1Hash(output.ToString)
        abev.Element(xmlns + "hash").SetValue(hashValue)

        Try
            If File.Exists(OutputFileNeve) Then File.Delete(OutputFileNeve)
            Using writer = New Xml.XmlTextWriter(OutputFileNeve, New System.Text.UTF8Encoding(False))
                output.Save(writer)
            End Using
        Catch ex As Exception
            Dim hibauzenet = "A megadott névre (" & OutputFileNeve & ") nem tudjuk lementeni az elkészült XML-t. Van írási joga?"
            MsgBox(hibauzenet)
            MyLoader.AddLogBook(Fnc.xml, hibauzenet, LogTip.err)
            Return False
        End Try
        Return True
    End Function

    Shared Sub CsatszamIgazitas(InputFileNeve As String, CsatSzama As Integer)
        If InputFileNeve = String.Empty Then Exit Sub
        Dim xdoc As XDocument
        Try
            xdoc = XDocument.Load(InputFileNeve)
        Catch ex As Exception
            Dim hibauzenet = "A megadott nyomtatványt nem tudjuk a program nem tudja betölteni, mert nem létezik vagy hibás az XML fájl"
            MsgBox(hibauzenet)
            MyLoader.AddLogBook(Fnc.xml, hibauzenet, LogTip.err)
            Exit Sub
        End Try

        Dim xmlns As XNamespace = "http://iop.gov.hu/2007/01/nyk/altalanosnyomtatvany"
        Dim nyomtatvanyazonosito = xdoc.Element(xmlns + "nyomtatvanyok").Element(xmlns + "nyomtatvany").Element(xmlns + "nyomtatvanyinformacio").Element(xmlns + "nyomtatvanyazonosito").Value.ToString
        Dim dtCsatSzama As New NyomtatvanyAdatokDataSet.OsszesitettMDFbolDataTable
        Dim taOsszesitettMDFbol As New NyomtatvanyAdatokDataSetTableAdapters.OsszesitettMDFbolTableAdapter
        taOsszesitettMDFbol.Fill(dtCsatSzama)
        Dim mi_a_csatolmany_belsoIDje() As DataRow = dtCsatSzama.Select("Nyomtatvany='" & nyomtatvanyazonosito & "' AND BelsoID='alapCsatSzama'")
        If mi_a_csatolmany_belsoIDje.Count = 0 Then Exit Sub 'Pl. APK-s mellékleteknél nem tudja a program automatizálni a csatolmányszámot, nem is írja be
        Dim selectCsatSzamEAzon = String.Empty
        selectCsatSzamEAzon = mi_a_csatolmany_belsoIDje.First.Item("Eazon")
        Dim csatszamelement = xdoc.Element(xmlns + "nyomtatvanyok").Element(xmlns + "nyomtatvany").Element(xmlns + "mezok").Elements(xmlns + "mezo")
        For Each mezov In csatszamelement
            If mezov.Attribute("eazon").Value = selectCsatSzamEAzon Then
                mezov.Value = CsatSzama
            End If
        Next
        Try
            xdoc.Save(InputFileNeve)
        Catch ex As Exception
            Trace.WriteLine("CsatszamIgazitas xdoc.Save hiba: " & ex.Message & "(fajlneve=" & InputFileNeve & ")")
        End Try
    End Sub

    Shared Function potol4re(text As String) As String
        For i = 1 To 4 - text.Length
            text = "0" + text
        Next
        Return text
    End Function

    Shared Function getSHA1Hash(ByVal strToHash As String) As String

        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function

    Shared Function getSHA256Hash(ByVal strToHash As String) As String

        Dim sha256Obj As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha256Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function


    Shared Function SortChildElements(ByVal element As XElement) As XElement
        Try
            Return New XElement(
            element.Name,
            element.Attributes,
            element.Nodes.Where(Function(node) Not TypeOf node Is XElement),
            From child In element.Elements
            Order By child.@eazon Ascending
            Select SortChildElements(child))
        Catch ex As Exception
            Trace.WriteLine("XML hiba: SortChildElements:" & ex.Message)
            Return Nothing
        End Try
    End Function


End Class
