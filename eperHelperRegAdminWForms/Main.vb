Imports System.IO
Imports System.IO.Compression

Public Class Main
    Private Const TknUploadRegBak = "vCAj5dGq"
    Private Const TknDownloadRegBak = "F5UjCn"
    Private Const TknInvalidate = "s7uNaVeI"
    Private Const TknCheckCodeUsable = "qd4dBGzT"
    Private Const TknStatusCheck = "73GDf9C9"
    Private Const TknDumpFullDT = "dqS54SnC"
    Private Const TknListRegsInPeriod = "gqXN49Jd"
    Private Const TknDeleteById = "8zuZ6zdvxA2x"
    Private Const TknSetOtherState = "3TjEywaQS9Z9"
    Private Const TknDeleteRegBakbyCode = "ptp4roQOBX"

    Public Sub New()

        InitializeComponent()
        dtpStart.MinDate = DateTime.MinValue
        dtpEndDate.MinDate = DateTime.MinValue
        dtpRegDateTimeSet.CustomFormat = "yyyy.MM.dd. HH:mm:ss"
        'dátumokat lekérdezésnél csak napra kérdezzük
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            tbStatus.AppendText(wsreg.StatusCheck(TknStatusCheck))
        End Using
        Label1.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As New MsgBoxResult
        result = MsgBox("Biztos ki akar lépni?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then Application.Exit()
    End Sub


    Private Sub mtbKód_MouseClicked(sender As Object, e As MouseEventArgs) Handles mtbKod.MouseClick, mtbKodID.MouseClick
        Dim sendername As MaskedTextBox = DirectCast(sender, MaskedTextBox)
        sendername.SelectionStart = 0
    End Sub

    Private Sub btnFrissitStatus_Click(sender As Object, e As EventArgs) Handles btnFrissitStatus.Click
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            tbStatus.AppendText(Environment.NewLine & wsreg.StatusCheck(TknStatusCheck))
        End Using
    End Sub

    Private Sub btnCodeCheck_Click(sender As Object, e As EventArgs) Handles btnCodeCheck.Click
        If mtbKod.Text = String.Empty Or mtbKod.Text.Length < 6 Then MsgBox("Nem adott meg (teljes) kódot!", MsgBoxStyle.Critical) : Exit Sub
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                tbStatus.AppendText(wsreg.CheckCodeUsable(TknCheckCodeUsable, mtbKod.Text))
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            Finally

            End Try
        End Using
    End Sub

    Private Sub btnCodeInvalidate_Click(sender As Object, e As EventArgs) Handles btnCodeInvalidate.Click
        If mtbKod.Text = String.Empty Or mtbKod.Text.Length < 6 Then MsgBox("Nem adott meg (teljes) kódot!", MsgBoxStyle.Critical) : Exit Sub
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                tbStatus.AppendText(wsreg.InvalidateCodebyCode(TknInvalidate, mtbKod.Text))
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub btnCodeUsed_Click(sender As Object, e As EventArgs) Handles btnCodeUsed.Click
        If mtbKod.Text = String.Empty Or mtbKod.Text.Length < 6 Then MsgBox("Nem adott meg (teljes) kódot!", MsgBoxStyle.Critical) : Exit Sub
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                tbStatus.AppendText(wsreg.RegisterCode(mtbKod.Text))
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub btnCodeRegFileDownload_Click(sender As Object, e As EventArgs) Handles btnCodeRegFileDownload.Click, btnCodeIdRegFileDownload.Click
        Dim senderbtn = CType(sender, Button)
        If mtbKod.Text = String.Empty And senderbtn.Name = "btnCodeRegFileDownload" Then
            MsgBox("Nem adott meg kódot!", MsgBoxStyle.Critical)
            If mtbKod.Text.Length < 6 Then MsgBox("Nem adott meg elég hosszú kódot", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If mtbKodID.Text = String.Empty And senderbtn.Name = "btnCodeIdRegFileDownload" Then MsgBox("Nem adott meg kód azonostót!", MsgBoxStyle.Critical) : Exit Sub
        Dim KodID As Integer = 0

        Dim bytarr As Byte() = Nothing
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If senderbtn.Name = "btnCodeRegFileDownload" Then bytarr = wsreg.DownloadRegBak(TknDownloadRegBak, mtbKod.Text)
                If senderbtn.Name = "btnCodeIdRegFileDownload" Then
                    Try
                        KodID = CType(mtbKodID.Text, Integer)
                    Catch
                        tbStatus.AppendText("A megadott kód hibás (nem szám)")
                        Exit Sub
                    End Try
                    bytarr = wsreg.DownloadRegBakbyId(TknDownloadRegBak, KodID)
                End If
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
        If IsNothing(bytarr) Then
            Exit Sub
        End If
        If bytarr.Length = 0 Then
            Exit Sub
        End If
        Dim regfajlzippelveneve As String = SaveRegFilePath()
        If regfajlzippelveneve = String.Empty Then tbStatus.AppendText(Environment.NewLine & "Nem adott meg fájlnevet") : Exit Sub
        If File.Exists(regfajlzippelveneve) Then
            Dim result As MsgBoxResult = MsgBox("A megadott fájl már létezik. Felülírhatom?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Try
                    File.Delete(regfajlzippelveneve)
                Catch ex As Exception
                    tbStatus.AppendText(Environment.NewLine & "Létező fájl miatt a lementés félbeszakítva")
                    Exit Sub
                End Try
            End If
        End If

        If File.Exists(Path.GetFileNameWithoutExtension(regfajlzippelveneve) & ".xml") Then
            Dim result As MsgBoxResult = MsgBox("A megadott fájl kitömörített létezik. Felülírhatom?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Try
                    File.Delete(regfajlzippelveneve)
                Catch ex As Exception
                    tbStatus.AppendText(Environment.NewLine & "Létező fájl miatt a lementés félbeszakítva")
                    Exit Sub
                End Try
            End If
        End If
        Try
            File.WriteAllBytes(regfajlzippelveneve, bytarr)
        Catch ex As Exception
            tbStatus.AppendText(Environment.NewLine & "A zippelt regisztrációs fájlt nem tudta a program lementeni (írásvédett meghajtó?)")
            Exit Sub
        End Try
        Try
            Dim ziptest As System.IO.Compression.ZipArchive = System.IO.Compression.ZipFile.OpenRead(regfajlzippelveneve)
        Catch ex As InvalidDataException
            tbStatus.AppendText(Environment.NewLine & "Figyelem! A lementett fájl nem tűnik érvényes zip fájlnak.")
        End Try
        tbStatus.AppendText(Environment.NewLine & "Sikeresen lementve a zip fájl a következő néven: " & regfajlzippelveneve)
        System.Windows.Forms.Clipboard.SetText(regfajlzippelveneve)
        MsgBox("A regisztrációs fájl neve a vágólapra másolva")

    End Sub

    Private Function SaveRegFilePath()
        Dim dialogresult As New DialogResult
        Dim ValasztottFajl = String.Empty
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "*.zip|ZIP"
        saveFileDialog1.Title = "Hova mentsem le a regisztrációs fájlt?"
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = "server_reg.zip"
        saveFileDialog1.DefaultExt = "zip"
        dialogresult = saveFileDialog1.ShowDialog()
        If dialogresult = DialogResult.OK Then ValasztottFajl = saveFileDialog1.FileName
        If System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(ValasztottFajl)) Then
            If Path.GetExtension(ValasztottFajl).ToLower <> ".zip" Then ValasztottFajl += ".zip"
            Return ValasztottFajl
        Else
            Return String.Empty
        End If
    End Function

    Private Sub btnCodeRegFileDelete_Click(sender As Object, e As EventArgs) Handles btnCodeRegFileDelete.Click
        If mtbKod.Text = String.Empty Or mtbKod.Text.Length < 6 Then MsgBox("Nem adott meg (teljes) kódot!", MsgBoxStyle.Critical) : Exit Sub
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.DeleteRegBakbyCode(TknDeleteRegBakbyCode, mtbKod.Text) Then tbStatus.AppendText(Environment.NewLine & mtbKod.Text & " kód szerinti regisztrációs fájlt sikeresen töröltük a nyilvántartásból.") Else tbStatus.AppendText(Environment.NewLine & mtbKod.Text & " kód esetén nincsen regisztrációs fájl tárolva.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCodeIdDelete_Click(sender As Object, e As EventArgs) Handles btnCodeIdDelete.Click
        Dim KodID As Integer = KodItCheck()
        If KodItCheck() = -1 Then MsgBox("Nem adott meg kód azonosítót!", MsgBoxStyle.Critical) : Exit Sub
        Dim result As New MsgBoxResult
        result = MsgBox("Biztos törölni akarja?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.No Then Exit Sub

        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.DeletebyId(TknDeleteById, KodID) Then tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító sikeresen törölve a nyilvántartásból.") Else tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító nem található vagy már törölve.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using

    End Sub

    Private Function KodItCheck() As Integer
        If mtbKodID.Text = String.Empty Then Return -1
        Try
            KodItCheck = CType(mtbKodID.Text, Integer)
        Catch
            Return -1
        End Try
        Return KodItCheck
    End Function

    Private Sub btnCodeIdInvalidate_Click(sender As Object, e As EventArgs) Handles btnCodeIdInvalidate.Click
        Dim KodID As Integer = KodItCheck()
        If KodItCheck() = -1 Then MsgBox("Nem adott meg kód azonosítót!", MsgBoxStyle.Critical) : Exit Sub

        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.SetOtherState(TknSetOtherState, KodID, 4) Then tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító érvénytelenítve.") Else tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító nem található.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCodeIdRevalidate_Click(sender As Object, e As EventArgs) Handles btnCodeIdRevalidate.Click
        Dim KodID As Integer = KodItCheck()
        If KodItCheck() = -1 Then MsgBox("Nem adott meg kód azonosítót!", MsgBoxStyle.Critical) : Exit Sub

        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.SetOtherState(TknSetOtherState, KodID, 3) Then tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító újból érvényessé téve.") Else tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító nem található.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCodeIdUsed_Click(sender As Object, e As EventArgs) Handles btnCodeIdUsed.Click
        Dim KodID As Integer = KodItCheck()
        If KodItCheck() = -1 Then MsgBox("Nem adott meg kód azonosítót!", MsgBoxStyle.Critical) : Exit Sub

        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.SetOtherState(TknSetOtherState, KodID, 2) Then tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító felhasználttá téve.") Else tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító nem található.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCodeIdReuse_Click(sender As Object, e As EventArgs) Handles btnCodeIdReuse.Click
        Dim KodID As Integer = KodItCheck()
        If KodItCheck() = -1 Then MsgBox("Nem adott meg kód azonosítót!", MsgBoxStyle.Critical) : Exit Sub

        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.SetOtherState(TknSetOtherState, KodID, 1) Then tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító újból nem használttá téve.") Else tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító nem található.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub btnCodeIdRegFileDelete_Click(sender As Object, e As EventArgs) Handles btnCodeIdRegFileDelete.Click
        Dim KodID As Integer = KodItCheck()
        If KodItCheck() = -1 Then MsgBox("Nem adott meg kód azonosítót!", MsgBoxStyle.Critical) : Exit Sub

        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.SetOtherState(TknSetOtherState, KodID, 1) Then tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító szerinti regisztrációs fájlt sikeresen töröltük a nyilvántartásból.") Else tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító nem található.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCodeIdSetRegDateDelete_Click(sender As Object, e As EventArgs) Handles btnCodeIdSetRegDateDelete.Click
        Dim KodID As Integer = KodItCheck()
        If KodItCheck() = -1 Then MsgBox("Nem adott meg kód azonosítót!", MsgBoxStyle.Critical) : Exit Sub

        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.SetRegDate(TknSetOtherState, KodID, DateTime.MinValue) Then tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító szerinti regisztrációs dátumot töröltük.") Else tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító nem található.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCodeIdSetRegDateTime_Click(sender As Object, e As EventArgs) Handles btnCodeIdSetRegDateTime.Click
        Dim KodID As Integer = KodItCheck()
        If KodItCheck() = -1 Then MsgBox("Nem adott meg kód azonosítót!", MsgBoxStyle.Critical) : Exit Sub

        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                If wsreg.SetRegDate(TknSetOtherState, KodID, dtpRegDateTimeSet.Value.ToUniversalTime) Then tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító szerinti regisztrációs dátumot átírtuk " & dtpRegDateTimeSet.Value.ToUniversalTime & "-ra.") Else tbStatus.AppendText(Environment.NewLine & mtbKodID.Text & " kódazonosító nem található.")
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnUjKodFeltoltese_Click(sender As Object, e As EventArgs) Handles btnUjKodFeltoltese.Click
        Dim showKodDlg As New KodBeado
        showKodDlg.ShowDialog()
        showKodDlg.Close()
    End Sub

    Private Sub btnRegTableDGVShow_Click(sender As Object, e As EventArgs) Handles btnRegTableDGVShow.Click
        Dim ds As New DataSet
        Dim xmlstring As String = String.Empty
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                xmlstring = wsreg.DumpFullDT(TknDumpFullDT)
                ds.ReadXml(New StringReader(xmlstring))
            Catch ex As Xml.XmlException
                tbStatus.AppendText(Environment.NewLine & "adattábla beolvasási hiba: " & ex.Message)
            Catch ex2 As Exception
                tbStatus.AppendText(Environment.NewLine & ex2.Message)
            End Try
        End Using
        Dim Betekinto As New RegTableShow(ds.Tables(0))
        Betekinto.ShowDialog()

    End Sub

    Private Sub btnLekerdezRegisztraciok_Click(sender As Object, e As EventArgs) Handles btnLekerdezRegisztraciok.Click
        Dim reply As String = String.Empty
        Using wsreg As New RegSrv.eperHelperRegWS_ifClient
            Try
                reply = wsreg.ListRegsInPeriod(TknListRegsInPeriod, dtpStart.Value, dtpEndDate.Value)
                tbStatus.AppendText(Environment.NewLine & reply)
                System.Windows.Forms.Clipboard.SetText(reply)
                MsgBox("Bemásoltam a vágólapra is a lekérdezés eredményét!" & Environment.NewLine & "Használjon fix távolságú betűtípust", MsgBoxStyle.OkOnly)
            Catch ex As Exception
                tbStatus.AppendText(Environment.NewLine & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnMACChange_Click(sender As Object, e As EventArgs) Handles btnMACChange.Click
        Dim showMACupload As New MacBeado
        showMACupload.Code = mtbKod.Text
        showMACupload.ShowDialog()
        showMACupload.Close()
    End Sub
End Class
