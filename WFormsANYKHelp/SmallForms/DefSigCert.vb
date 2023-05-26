Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Public Class DefSigCert
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        FillupLBfromString()
        tbTSUN.Text = Kapukezelo.Decrypt(My.Settings.TSUN, "TSUN")
        Dim ideiglenes = Kapukezelo.Decrypt(My.Settings.TSPW, "TSPW")
        If ideiglenes <> "" Then tbTSPW.Text = ideiglenes : tbTSPWIsm.Text = ideiglenes
        Me.tbSigCert.Text = AlairoCert.CommonName
        Me.tbTSCert.Text = TSCert.CommonName
        'Me.tbOCSPCert.Text = OCSPCert.CommonName
    End Sub

    Private Sub FillupLBfromString()
        Dim tsurlarray() As String = Split(My.Settings.TSURL, " ")
        For Each tetel As String In tsurlarray
            lbTSURL.Items.Add(tetel)
        Next
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'A beállított értékeket elmenti
        Dim tsurlvissza As String = String.Empty
        For Each item As String In lbTSURL.Items
            tsurlvissza += item + " "
        Next
        If Not tsurlvissza Is Nothing Then
            My.Settings.TSURL = tsurlvissza
            Dim response = SharedXSignSession.SetTimeStampURLs(My.Settings.TSURL)
            If response = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyeg URL beállítva", LogTip.norm)
            My.Settings.Save()
        End If

        If tbTSUN.Text = String.Empty Or tbTSPW.Text = String.Empty Then
            My.Settings.TSUN = Kapukezelo.Encrypt(String.Empty, "TSUN")
            MyLoader.AddLogBook(Fnc.eal, "Időbélyegzős felhasználónév törölve", LogTip.norm)
            My.Settings.TSPW = Kapukezelo.Encrypt(String.Empty, "TSPW")
            MyLoader.AddLogBook(Fnc.eal, "Időbélyegzős jelszó törölve", LogTip.norm)
            Dim response As Integer = SharedXSignSession.SetDefaultBasicAuth("", "")
            If response = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyeg jelszó & felhasználónév XSignból beállítva", LogTip.norm)
            My.Settings.Save()
        End If

        If tbTSUN.Text <> String.Empty Then
            If tbTSUN.Text <> Kapukezelo.Decrypt(My.Settings.TSUN, "TSUN") Or tbTSPW.Text <> Kapukezelo.Decrypt(My.Settings.TSPW, "TSPW") Then
                If tbTSPW.Text <> tbTSPWIsm.Text Then
                    MsgBox("Nem azonos a két megadott jelszó, nem menti el a program az új adatokat")
                    Exit Sub
                End If
                My.Settings.TSUN = Kapukezelo.Encrypt(tbTSUN.Text, "TSUN")
                MyLoader.AddLogBook(Fnc.eal, "Időbélyegzős felhasználónév rögzítve", LogTip.norm)
                My.Settings.TSPW = Kapukezelo.Encrypt(tbTSPW.Text, "TSPW")
                MyLoader.AddLogBook(Fnc.eal, "Időbélyegzős jelszó rögzítve", LogTip.norm)
                Dim response As Integer = SharedXSignSession.SetDefaultBasicAuth(tbTSUN.Text, tbTSPW.Text)
                If response = 0 Then MyLoader.AddLogBook(Fnc.eal, "Időbélyeg jelszó & felhasználónév XSignban beállítva", LogTip.norm)
                My.Settings.Save()
            End If
        End If


        If My.Settings.SignCertDefault <> AlairoCert.Thumbprint Then
            My.Settings.SignCertDefault = AlairoCert.Thumbprint
            My.Settings.Save()
            LoadCertIntoXSign(AlairoCert)
            MyLoader.AddLogBook(Fnc.eal, "A " & AlairoCert.CommonName & " nevű, " & " aláíró típusú tanúsítvány kiválasztva.", LogTip.norm)
        End If

        If My.Settings.TSACertDefault <> TSCert.Thumbprint Then
            My.Settings.TSACertDefault = TSCert.Thumbprint
            My.Settings.Save()
            LoadCertIntoXSign(TSCert)
            MyLoader.AddLogBook(Fnc.eal, "A " & TSCert.CommonName & " nevű, " & " időbélyeg autentikációs tanúsítvány kiválasztva.", LogTip.norm)
        End If
        CheckTSURLMicrosec
        Me.Close()
    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click
        LoadAlairofromSettings()
        LoadTSfromSettings()
        Me.Close()
    End Sub

    Private Sub btnChooseSigCert_Click(sender As Object, e As EventArgs) Handles btnChooseSigCert.Click
        ChooseCertAndLoadItToxxxCert(CertTypes.alairas)
        If LoadCertIntoXSign(AlairoCert) = True Then
            Me.tbSigCert.Text = AlairoCert.CommonName
        End If
    End Sub
    Private Sub btnChooseTSCert_Click(sender As Object, e As EventArgs) Handles btnChooseTSCert.Click
        ChooseCertAndLoadItToxxxCert(CertTypes.autent_TS)
        'Me.tbTSCert.Text = TSCert.CommonName
        If LoadCertIntoXSign(TSCert) = True Then Me.tbTSCert.Text = TSCert.CommonName
    End Sub

    Private Sub ChooseCertAndLoadItToxxxCert(Mit As Byte)
        Dim stype As String = String.Empty
        Dim fname As String = String.Empty
        Dim sname As String = String.Empty
        Select Case Mit
            Case CertTypes.alairas
                stype = "aláíró"
                fname = "tbSigCert.Text"
            Case CertTypes.autent_TS
                stype = "időbélyeg autentikációs"
                fname = "tbTSCert.Text"
                'Case CertTypes.autent_OCSP
                '   stype = "OCSP autentikációs"
                '  fname = "tbOCSPCert.Text"
                ' sname = "OCSPCertDefault"
        End Select

        Dim store As New X509Store(StoreName.My, StoreLocation.CurrentUser)
        store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)
        Dim fcollection As X509Certificate2Collection = CType(store.Certificates.Find(X509FindType.FindByTimeValid, DateTime.Now, False), X509Certificate2Collection)

        Dim szukitett_collection As New X509Certificate2Collection

        If Mit = CertTypes.alairas Then szukitett_collection = CType(fcollection.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.NonRepudiation, False), X509Certificate2Collection)
        If Mit = CertTypes.autent_TS Then ' Or Mit = CertTypes.autent_OCSP Or 
            For Each x509 As X509Certificate2 In fcollection
                Dim i As Integer = 0
                For Each ext In x509.Extensions
                    i += 1
                    Dim eku = TryCast(ext, X509EnhancedKeyUsageExtension)
                    If eku IsNot Nothing Then
                        For Each oid In eku.EnhancedKeyUsages
                            If oid.Value = "1.3.6.1.5.5.7.3.2" Then szukitett_collection.Add(x509)
                        Next
                    End If
                Next
            Next
        End If

        If szukitett_collection.Count = 0 Then
            Dim uzenet = "Nincsen " & stype & " tanúsítvány telepítve!"
            MsgBox(uzenet)
            MyLoader.AddLogBook(Fnc.eal, uzenet, LogTip.err)
            Exit Sub
        End If

        fcollection = Nothing
        Dim scollection As X509Certificate2Collection = X509Certificate2UI.SelectFromCollection(szukitett_collection, "Tanúsítvány kiválasztása", "Válassza ki az alapértelmezett " & stype & " tanúsítványt", X509SelectionFlag.SingleSelection)
        If scollection Is Nothing Or scollection.Count = 0 Then Exit Sub
        Dim thumbprint As String = scollection.Item(0).Thumbprint.ToString.ToLower
        thumbprint = ANYHelpModule.ReformatThumbprintWithSpaces(thumbprint)
        Try
            Dim commonname As String = GetCommonNameSubject(scollection.Item(0).Subject.ToString)
            Select Case Mit
                Case CertTypes.alairas
                    AlairoCert.CommonName = commonname
                    AlairoCert.Thumbprint = thumbprint
                Case CertTypes.autent_TS
                    TSCert.CommonName = commonname
                    TSCert.Thumbprint = thumbprint
                    '    Case CertTypes.autent_OCSP
                    '       OCSPCert.CommonName = commonname
                    '      OCSPCert.Thumbprint = thumbprint
                    '     LoadCert(OCSPCert)
            End Select
            scollection.Item(0).Reset()
        Catch cExcept As CryptographicException
            Trace.WriteLine("#3")
        End Try
        store.Close()
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        MoveListItem(-1)
    End Sub

    Private Sub MoveListItem(Merre As Integer)
        If lbTSURL.SelectedItem Is Nothing OrElse lbTSURL.SelectedIndex < 0 Then Exit Sub
        Dim ujlistIndex As Integer = Merre + lbTSURL.SelectedIndex
        If ujlistIndex < 0 OrElse ujlistIndex >= lbTSURL.Items.Count Then Exit Sub
        Dim selected As Object = lbTSURL.SelectedItem
        lbTSURL.Items.Remove(selected)
        lbTSURL.Items.Insert(ujlistIndex, selected)
        lbTSURL.SetSelected(ujlistIndex, True)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        MoveListItem(1)
    End Sub

    Private Sub btnTorol_Click(sender As Object, e As EventArgs) Handles btnTorol.Click
        If lbTSURL.SelectedItem Is Nothing Then Exit Sub
        lbTSURL.Items.Remove(lbTSURL.SelectedItem)
    End Sub

    Private Sub btnHozzáad_Click(sender As Object, e As EventArgs) Handles btnHozzáad.Click
        Dim inputURL As String = InputBox("Adja meg a kívánt URL értéket!", "URL tétel rögzítése")
        Dim celindex As Integer = 0
        If lbTSURL.SelectedIndex < 1 Then celindex = 0 Else celindex = lbTSURL.SelectedIndex
        Dim testURL As Uri
        If inputURL <> "" Then
            Try
                testURL = New Uri(inputURL)
                lbTSURL.Items.Insert(celindex, inputURL)
                lbTSURL.SelectedIndex = celindex
            Catch ex As Exception
                MsgBox("A megadott érték nem URL")
            End Try
        End If
    End Sub


    Private Sub TSPWIsm_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbTSPWIsm.Validating
        If tbTSPWIsm.Text <> tbTSPW.Text Then ErrorProvider1.SetError(tbTSPWIsm, "A megadott jelszavak nem egyeznek!") Else ErrorProvider1.SetError(tbTSPWIsm, "")
    End Sub

    'Private Sub btnChooseOCSPCert_Click(sender As Object, e As EventArgs)
    '   CertChooser(CertTypes.autent_OCSP)
    'Me.tbOCSPCert.Text = OCSPCert.CommonName
    'End Sub


    Private Sub btnTorolSig_Click(sender As Object, e As EventArgs) Handles btnTorolSig.Click
        Me.tbSigCert.Text = String.Empty
        AlairoCert.Thumbprint = String.Empty
        AlairoCert.CommonName = String.Empty
        My.Settings.SignCertDefault = String.Empty
        My.Settings.Save()
        LoadCertIntoXSign(AlairoCert)

    End Sub

    'Private Sub btnTorolOCSP_Click(sender As Object, e As EventArgs)
    'Me.tbOCSPCert.Text = String.Empty
    '   OCSPCert.Thumbprint = String.Empty
    '  OCSPCert.CommonName = String.Empty
    ' My.Settings.OCSPCertDefault = String.Empty
    'My.Settings.Save()
    'LoadCert(OCSPCert)

    '    End Sub

    Private Sub btnTSTorol_Click(sender As Object, e As EventArgs) Handles btnTSTorol.Click
        Me.tbTSCert.Text = String.Empty
        TSCert.Thumbprint = String.Empty
        TSCert.CommonName = String.Empty
        My.Settings.TSACertDefault = String.Empty
        My.Settings.Save()
        LoadCertIntoXSign(TSCert)

    End Sub

End Class