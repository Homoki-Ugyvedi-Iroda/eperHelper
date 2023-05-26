Imports Microsoft.Win32
Imports System.IO
Imports System.Text
'Imports <xmlns:CST="http://www.apeh.hu/abev/csatolmanyok/2007/01">
Imports ICSharpCode.SharpZipLib.BZip2
Imports System.Security.Cryptography

Public Class CSTPacker
    Inherits csatolmanyok
    Public Shared Property CSTTargetName As String
    Public Sub New()
    End Sub
    Public Shared Sub add(ByRef CsatFileInformacio As csatolmanyinformaciok, ByRef CsatFileok As csatolmanyfileok, FullPathFile As String, Tipus As String, Optional Megjegyzes As String = "")

        Dim nFileInfo As New fileinformacio
        nFileInfo.azonosito = CStr(CsatFileInformacio.csatolmanyokszama + 1)
        nFileInfo.filenev = Path.GetFileName(FullPathFile)
        nFileInfo.megjegyzes = Megjegyzes
        nFileInfo.tipus = Tipus

        If IsNothing(CsatFileInformacio.fileinformaciok) Then Array.Resize(CsatFileInformacio.fileinformaciok, 1) Else Array.Resize(CsatFileInformacio.fileinformaciok, CsatFileInformacio.fileinformaciok.Length + 1)
        CsatFileInformacio.fileinformaciok(CsatFileInformacio.fileinformaciok.Length - 1) = nFileInfo
        CsatFileInformacio.csatolmanyokszama = CsatFileInformacio.fileinformaciok.Length

        Dim nCsatFile As New csatolmanyfileokCsatolmanyfile
        nCsatFile.azonosito = nFileInfo.azonosito
        Try
            Dim tempname As String = Path.GetTempFileName
            ConvertLargeFile(FullPathFile, tempname)
            nCsatFile.Value = System.IO.File.ReadAllText(tempname)
            File.Delete(tempname)
        Catch ex1 As System.OutOfMemoryException
            MsgBox("Túl kevés a memória a csatolmány létrehozásához")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If IsNothing(CsatFileok.csatolmanyfile) Then Array.Resize(CsatFileok.csatolmanyfile, 1) Else Array.Resize(CsatFileok.csatolmanyfile, CsatFileok.csatolmanyfile.Length + 1)
        CsatFileok.csatolmanyfile(CsatFileok.csatolmanyfile.Length - 1) = nCsatFile
        nCsatFile = Nothing

    End Sub

    Friend Shared Sub ConvertLargeFile(filein As String, fileout As String)
        Using fs As FileStream = File.Open(fileout, FileMode.Create)
            Using cs = New CryptoStream(fs, New ToBase64Transform(), CryptoStreamMode.Write)
                Using fi = File.Open(filein, FileMode.Open)
                    fi.CopyTo(cs)
                End Using
            End Using
        End Using
    End Sub

    Public Shared Sub delete(ByRef CsatinfoNev As csatolmanyinformaciok, ByRef CsatFileok As csatolmanyfileok, Azonosito As String)
        Dim tCsatinfoNev As List(Of fileinformacio) = CsatinfoNev.fileinformaciok.ToList
        Dim tCsatFileok As List(Of csatolmanyfileokCsatolmanyfile) = CsatFileok.csatolmanyfile.ToList
        For X = tCsatinfoNev.Count - 1 To 0 Step -1
            If tCsatinfoNev(X).azonosito = Azonosito Then tCsatinfoNev.RemoveAt(X)
        Next
        For X = tCsatFileok.Count - 1 To 0 Step -1
            If tCsatFileok(X).azonosito = Azonosito Then tCsatFileok.RemoveAt(X)
        Next
        CsatinfoNev.fileinformaciok = tCsatinfoNev.ToArray
        CsatinfoNev.csatolmanyokszama = CsatinfoNev.fileinformaciok.Length
        CsatFileok.csatolmanyfile = tCsatFileok.ToArray
    End Sub

    Public Shared Sub writeOut(csati As csatolmanyok, FileOut As String, Optional BZipped As Boolean = False)
        Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(csatolmanyok))
        'Itt van egy managed binding hiba, aminek exception-ölését kikapcsoltam
        Using writer As New StreamWriter(FileOut)
            Try
                serializer.Serialize(writer, csati)
            Catch ex As Exception
                MsgBox("Hiba! " + ex.Message)
            End Try
        End Using

        If BZipped = True Then
            Dim tempname As String = Path.GetTempFileName
            Dim fsInputFile As FileStream, fsBZ2Archive As FileStream
            fsInputFile = File.OpenRead(FileOut)
            fsBZ2Archive = File.Create(tempname)
            BZip2.Compress(fsInputFile, fsBZ2Archive, 4026)
            fsInputFile.Close()
            fsBZ2Archive.Close()
            If File.Exists(tempname) Then
                Try
                    File.Delete(FileOut)
                    File.Copy(tempname, FileOut)
                Catch ex As Exception
                    MsgBox("CST célfájlt nem tudtam tömöríteni:" & ex.Message)
                End Try
                Try
                    File.Delete(tempname)
                Catch ex As Exception
                End Try
            End If
        End If

    End Sub
    Public Shared Function CreateCST(pCSTTargetName As String, ByRef CsatinfoNev As csatolmanyinformaciok, ByRef CsatFileok As csatolmanyfileok) As csatolmanyok
        Dim fnyomi As New nyomtatvany
        fnyomi.azonosito = "1"

        If IsNothing(CsatinfoNev.csatolmanyokszama) Then CsatinfoNev.csatolmanyokszama = "0"
        If Not IsNothing(CsatFileok.csatolmanyfile) And Not IsNothing(CsatinfoNev.csatolmanyokszama) Then CsatinfoNev.csatolmanyokszama = CStr(Math.Max(CsatinfoNev.csatolmanyokszama, CsatFileok.csatolmanyfile.Length))

        CsatinfoNev.nyomtatvanyfile = Path.GetFileName(pCSTTargetName)
        'CSTTargetName = pCSTTargetName
        fnyomi.csatolmanyinformaciok = CsatinfoNev
        fnyomi.csatolmanyfileok = CsatFileok.csatolmanyfile

        Dim csati As New csatolmanyok
        csati.nyomtatvany = {fnyomi}
        Return csati
    End Function

End Class
