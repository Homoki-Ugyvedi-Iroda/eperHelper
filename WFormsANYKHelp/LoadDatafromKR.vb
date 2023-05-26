Imports System.IO
Imports System.Text
Imports <xmlns:NYOM="http://iop.gov.hu/2007/01/nyk/altalanosnyomtatvany">
Imports <xmlns:abev="http://iop.gov.hu/2006/01/boritek">

Public Class LoadDatafromKRandXKR

    Public Shared Function extractKRCimzettSzervezet(KRPathtoProc As String) As String
        'Dim xelem As XElement = XElement.Load(KRPathtoProc)
        'Dim KRazonosito As IEnumerable(Of XElement) = From el In xelem.<abev:Fejlec>.<abev:Cimzett> Select el
        'Return KRazonosito.Value
        Dim value As String = String.Empty
        Using xr = New Xml.XmlTextReader(KRPathtoProc)
            While xr.Read()
                If xr.NodeType = Xml.XmlNodeType.Element And xr.Name = "abev:Cimzett" Then value = xr.ReadElementContentAsString : Exit While
            End While
        End Using
        Return value
    End Function

    Public Shared Function extractKRDokTipusAzonosito(KRPathtoProc As String) As String
        'Dim xelem As XElement = XElement.Load(KRPathtoProc)
        'Dim KRazonosito As IEnumerable(Of XElement) = From el In xelem.<abev:Fejlec>.<abev:DokTipusAzonosito> Select el
        'Return KRazonosito.Value
        Dim value As String = String.Empty
        Using xr = New Xml.XmlTextReader(KRPathtoProc)
            While xr.Read()
                If xr.NodeType = Xml.XmlNodeType.Element And xr.Name = "abev:DokTipusAzonosito" Then value = xr.ReadElementContentAsString : Exit While
            End While
        End Using
        Return value

    End Function

    Public Shared Function extractKRDokTipusLeiras(KRPathtoProc As String) As String
        'Dim xelem As XElement = XElement.Load(KRPathtoProc)
        'Dim KRazonosito As IEnumerable(Of XElement) = From el In xelem.<abev:Fejlec>.<abev:DokTipusLeiras> Select el
        'Return KRazonosito.Value
        Dim value As String = String.Empty
        Using xr = New Xml.XmlTextReader(KRPathtoProc)
            While xr.Read()
                If xr.NodeType = Xml.XmlNodeType.Element And xr.Name = "abev:DokTipusLeiras" Then value = xr.ReadElementContentAsString : Exit While
            End While
        End Using
        Return value
    End Function

    Public Shared Function extractKRDokTipusVerzio(KRPathtoProc As String) As String
        'Dim xelem As XElement = XElement.Load(KRPathtoProc)
        'Dim KRazonosito As IEnumerable(Of XElement) = From el In xelem.<abev:Fejlec>.<abev:DokTipusVerzio> Select el
        'Return KRazonosito.Value
        Dim value As String = String.Empty
        Using xr = New Xml.XmlTextReader(KRPathtoProc)
            While xr.Read()
                If xr.NodeType = Xml.XmlNodeType.Element And xr.Name = "abev:DokTipusVerzio" Then value = xr.ReadElementContentAsString : Exit While
            End While
        End Using
        Return value

    End Function
    Public Shared Function extractKRFileNev(KRPathtoProc As String) As String
        Dim value As String = String.Empty
        Using xr = New Xml.XmlTextReader(KRPathtoProc)
            Try
                While xr.Read()
                    If xr.NodeType = Xml.XmlNodeType.Element And xr.Name = "abev:FileNev" Then value = xr.ReadElementContentAsString : Exit While
                End While
            Catch ex As Exception
                value = ""
            End Try
        End Using
        Return value
    End Function

    Public Shared Function extractNYA(XMLPathtoProc As String) As String
        Dim returnvalue As String = String.Empty
        Try
            Dim xelem As XElement = XElement.Load(XMLPathtoProc)
            Dim nyomtatvanyazonosito As IEnumerable(Of XElement) = From el In xelem...<NYOM:nyomtatvany>.<NYOM:nyomtatvanyinformacio>.<NYOM:nyomtatvanyazonosito> Select el
            If nyomtatvanyazonosito.Count > 0 Then returnvalue = nyomtatvanyazonosito(0).Value
        Catch ex As Exception
        End Try
        Return returnvalue
    End Function

    Public Shared Function extractNYV(XMLPathtoProc As String) As String
        Dim returnvalue As String = String.Empty
        Try
            Dim xelem As XElement = XElement.Load(XMLPathtoProc)
            Dim nyomtatvanyverzio As IEnumerable(Of XElement) = From el In xelem...<NYOM:nyomtatvany>.<NYOM:nyomtatvanyinformacio>.<NYOM:nyomtatvanyverzio> Select el
            If nyomtatvanyverzio.Count > 0 Then returnvalue = nyomtatvanyverzio(0).Value
        Catch ex As Exception
        End Try
        Return returnvalue

    End Function

    Public Shared Function GetMegjegyzes(XMLPathtoProc As String) As String
        Dim returnvalue As String = String.Empty
        Try
            Dim xelem As XElement = XElement.Load(XMLPathtoProc)
            Dim megjegyzes As IEnumerable(Of XElement) = From el In xelem...<NYOM:nyomtatvany>.<NYOM:nyomtatvanyinformacio>.<NYOM:megjegyzes> Select el
            If megjegyzes.Count > 0 Then returnvalue = megjegyzes(0).Value
        Catch ex As Exception
        End Try
        Return returnvalue
    End Function

    Public Shared Function extractParameterek(XMLPathtoProc As String, NyomTipus As String, tipus As String) As String
        Dim valuestartswith As String = String.Empty
        Dim valueendswith As String = String.Empty
        Dim FRM_ENYK As Boolean
        Dim ValasztoStr As String = String.Empty
        If XMLPathtoProc.Contains(".frm.enyk") Then FRM_ENYK = True
        Dim returnvalue As String = String.Empty
        Dim OsszMDF As New NyomtatvanyAdatokDataSet.OsszesitettMDFbolDataTable
        Dim TAD As New NyomtatvanyAdatokDataSetTableAdapters.OsszesitettMDFbolTableAdapter
        TAD.Fill(OsszMDF)

        Select Case tipus
            Case "alperes"
                ValasztoStr = "(BelsoID='alapElsoRA' Or BelsoID LIKE '%apTermNev%' Or BelsoID LIKE '%apSzervNev%' Or BelsoID LIKE '%apCegNev%' Or BelsoID LIKE '%apEgyeniVallNev%')"
            Case "felperes"
                ValasztoStr = "(BelsoID='alapElsoRF' Or BelsoID LIKE '%$KERELM%' Or BelsoID LIKE '%fpTermNev%' Or BelsoID LIKE '%fpSzervNev%' Or BelsoID LIKE '%fpCegNev%' Or BelsoID LIKE '%fpEgyeniVallNev%')"
            Case "datumleirva"
                ValasztoStr = "(BelsoID='alapKeltDatum' Or BelsoID = 'IRAT_KELTE')"
            Case "birosag"
                ValasztoStr = "(BelsoID='BIROSAG' Or BelsoID='alapBirosag')"
            Case "targya"
                ValasztoStr = "(BelsoID='alapUgytargy')"
        End Select

        Try
            Dim foundrows() As DataRow = OsszMDF.Select("Nyomtatvany='" & NyomTipus & "' And Not Eazon='' And " & ValasztoStr)
            Dim valuetocheck As String = String.Empty
            Dim xelem As XElement = Nothing
            Dim APNev As IEnumerable(Of XElement) = Nothing

            For Each row In foundrows
                valuetocheck = row("Eazon")
                If Not valuetocheck.Contains("XXXX") Then
                    If FRM_ENYK = True Then valuetocheck = "0_" & valuetocheck
                    xelem = XElement.Load(XMLPathtoProc)
                    APNev = From el In xelem...<NYOM:nyomtatvany>.<NYOM:mezok>.<NYOM:mezo> Where el.Attribute("eazon").Value.Equals(valuetocheck) Select el
                    If APNev.Count > 0 Then returnvalue = APNev(0).Value
                Else
                    valuestartswith = Split(valuetocheck, "XXXX")(0)
                    valueendswith = Split(valuetocheck, "XXXX")(1)
                    If FRM_ENYK = True Then valuestartswith = "0_" & valuestartswith
                    xelem = XElement.Load(XMLPathtoProc)
                    APNev = From el In xelem...<NYOM:nyomtatvany>.<NYOM:mezok>.<NYOM:mezo> Where el.Attribute("eazon").Value.StartsWith(valuestartswith) And el.Attribute("eazon").Value.EndsWith(valueendswith) Select el
                    If APNev.Count > 0 Then returnvalue = APNev(0).Value
                End If
            Next
        Catch ex As Exception
        End Try
        Return returnvalue
    End Function

    Public Shared Function extractUgyszam(XMLPathtoProc As String, NyomTipus As String) As String()

        Dim valuestartswith As String = String.Empty
        Dim valueendswith As String = String.Empty
        Dim FRM_ENYK As Boolean
        Dim ValasztoStr As String = String.Empty
        If XMLPathtoProc.Contains(".frm.enyk") Then FRM_ENYK = True
        Dim returnvalue As String() = {String.Empty, String.Empty, String.Empty}
        Dim OsszMDF As New NyomtatvanyAdatokDataSet.OsszesitettMDFbolDataTable
        Dim TAD As New NyomtatvanyAdatokDataSetTableAdapters.OsszesitettMDFbolTableAdapter
        TAD.Fill(OsszMDF)
        returnvalue(0) = ReturnValuefromXML(NyomTipus, "(BelsoID='alapUgyCs' Or BelsoID='JEL$UGYSZAM')", FRM_ENYK, XMLPathtoProc, OsszMDF)
        returnvalue(1) = ReturnValuefromXML(NyomTipus, "(BelsoID='alapUgyEv' Or BelsoID='EV$UGYSZAM')", FRM_ENYK, XMLPathtoProc, OsszMDF)
        returnvalue(2) = ReturnValuefromXML(NyomTipus, "(BelsoID='alapUgySzam' Or BelsoID='SZAM$UGYSZAM')", FRM_ENYK, XMLPathtoProc, OsszMDF)
        Return returnvalue
    End Function
    Public Shared Function ReturnValuefromXML(NyomTipus As String, ValasztoStr As String, FRM_ENYK As Boolean, XMLPathtoProc As String, OsszMDF As NyomtatvanyAdatokDataSet.OsszesitettMDFbolDataTable) As String

        Dim foundrows() As DataRow = OsszMDF.Select("Nyomtatvany='" & NyomTipus & "' And Not Eazon='' And " & ValasztoStr)
        Dim valuetocheck As String = String.Empty
        Dim returnvalue As String = String.Empty
        If foundrows.Count > 0 Then valuetocheck = foundrows(0)("Eazon")
        If FRM_ENYK = True Then valuetocheck = "0_" & valuetocheck
        Dim APNev As IEnumerable(Of XElement) = Nothing
        Try
            Dim xelem As XElement = XElement.Load(XMLPathtoProc)
            APNev = From el In xelem...<NYOM:nyomtatvany>.<NYOM:mezok>.<NYOM:mezo> Where el.Attribute("eazon").Value.Equals(valuetocheck) Select el
            If APNev.Count > 0 Then returnvalue = APNev(0).Value
        Catch ex As Exception
        End Try
        Return returnvalue
    End Function

End Class
