Imports System.IO.Compression
Imports System.Text.RegularExpressions

Public Class RegisztraciosAblak
    Private Const MK As String = "yMnNyJnLzsLWw8uay9bPycnC1prCyM/Wmc3JyJjMmsrMz8uYAAA"
    Public Sub New()

        InitializeComponent()
        Me.RichTextBox1.Rtf = My.Resources.strRegisztraciosTxtRtf

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        'MyLoader.Show()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If NoInternet = True Then
            MsgBox("Jelenleg nincs internet hozzáférése. A regisztrációhoz elengedhetetlen, hogy legyen internet hozzáférése", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim rc As Long
        Dim resultRegSzoveg As String = String.Empty
        Dim hanyadikprobalkozasMSecnel As Integer = 0
        Dim ProcessedCode = RegInputMaskedTextBox.Text.Replace("_", String.Empty)
        ProcessedCode = ProcessedCode.Replace("-", String.Empty)
        ProcessedCode = ProcessedCode.Replace(" ", String.Empty)
        If ProcessedCode = String.Empty Then
            MsgBox("A megadott regisztrációs kulcs üres!")
            Exit Sub
        End If

        Dim res As DialogResult
        res = MsgBox("Biztos, hogy regisztrál ezzel a számmal: " & RegInputMaskedTextBox.Text & "? Ha sikeres a regisztráció, azzal végleg ehhez a hálózati adapterhez köti a felhasználási jogát!", MsgBoxStyle.OkCancel)
        If res = MsgBoxResult.Cancel Then Exit Sub

        Dim sikereseperReg As Boolean = False
        '#If MACCHECKBYMSEC = "N" Then
        'Összegyűjteni a MAC címeket
        'Dim macaddresses As String() = getAllMacAddresses().ToArray
        '#End If

        Using WSReg As New RegSrv.eperHelperRegWS_ifClient
            Dim result As String = String.Empty
            Try
                '#If Not MACCHECKBYMSEC = "N" Then
                result = WSReg.RegisterCode(ProcessedCode)
                If Strings.Left(result, 8) = "Sikeres " Then sikereseperReg = True
                '#Else
                'result = WSReg.RegisterCodewMAC(ProcessedCode, macaddresses)
                'If result = False Then 
                '                sikereseperReg = False
                'resultRegSzoveg += "Hálózati kártya cím regisztrációs hiba! Forduljon az ügyfélszolgálathoz"
                'End If
                '#End If
            Catch ex As Exception
                MsgBox("Regisztrációs hiba! " & ex.Message, MsgBoxStyle.Critical)
                resultRegSzoveg += "Regisztrációs hiba (eperHelper oldal): " & ex.Message
            End Try
        End Using
        If sikereseperReg = False Then
            RegisztralatlanValtozat()
            MyLoader.AddLogBook(Fnc.cfg, resultRegSzoveg, LogTip.err)
            Me.Close()
            Exit Sub
        End If
        MyLoader.AddLogBook(Fnc.cfg, "(eperHelper oldali regisztrációs rész OK)", LogTip.norm)
        If File.Exists(XRegPath) Then CheckandArchiveFile(XRegPath)
MicrosecRegRetry:
        hanyadikprobalkozasMSecnel += 1
        rc = SharedXSignSession.Register(unproc(MK), XRegPath, "https://srv.e-szigno.hu/cgi-bin/registration.cgi")
        Dim regellenorzott As Boolean = CheckRegFajl(XRegPath)
        If rc = 0 AndAlso regellenorzott Then
            resultRegSzoveg = "Regisztráció sikeres " & RegInputMaskedTextBox.Text & " kóddal! A regisztrációs állományról készítsen biztonsági másolatot! " & Environment.NewLine & "Bemásolva a következő helyre: " & XRegPath
            MyLoader.AddLogBook(Fnc.eal, resultRegSzoveg, LogTip.siker)
            Dim RegSikeresAblak As New RegMsgBoxwOtherlabels(XRegPath, ProcessedCode)
            Dim resultregablak As New DialogResult
            resultregablak = RegSikeresAblak.ShowDialog
            If resultregablak = DialogResult.Yes Then 'feltöltést kértek!
                Dim filetoupload As String = zippeldRegFajlt(XRegPath)
                If filetoupload <> ":hiba:" Then
                    Dim regfileinfozipped As New FileInfo(filetoupload)
                    Dim regfilesizezipped As Long = regfileinfozipped.Length
                    If regfileinfozipped.Length > 65535 Then
                        Dim resultregfeltoltsiker = "Regisztrációs fájl feltöltése sikertelen. A regisztrált fájl mérete túl nagy a feltöltéshez:" & regfileinfozipped.Length & Environment.NewLine &
                                "Készítsen a saját gépén biztonsági másolatot erről a fájlról: " & XRegPath
                        MyLoader.AddLogBook(Fnc.cfg, resultregfeltoltsiker, LogTip.err)
                        MsgBox(resultregfeltoltsiker, MsgBoxStyle.Critical)
                    End If
                    Using WSReg As New RegSrv.eperHelperRegWS_ifClient
                        Dim resultWSreg As String = String.Empty
                        Try
                            resultWSreg = WSReg.UploadRegBak(TknUploadRegBak, ProcessedCode, File.ReadAllBytes(filetoupload))
                            MsgBox("A feltöltés sikeres", MsgBoxStyle.OkOnly)
                            MyLoader.AddLogBook(Fnc.cfg, "A feltöltés sikeres", LogTip.siker)
                        Catch ex As Exception
                            MsgBox("A feltöltés sikertelen: " & ex.Message)
                        End Try
                    End Using
                End If
            End If
            RegisztraltValtozat()
        Else
            resultRegSzoveg = "Regisztráció sikertelen. (hibakód: m:" & rc & "|t:" & regellenorzott & "|e:" & sikereseperReg & "|re:" & hanyadikprobalkozasMSecnel & ")"
            If sikereseperReg And rc <> 0 Then
                Dim result As New MsgBoxResult
                result = MsgBox("Hiba a Microsec regisztráció során." & Environment.NewLine & "Ha hálózati vagy más, az Ön oldalán felmerülő hiba okozta ezt, próbálja újra a Microsec regisztrációt!" _
                                & Environment.NewLine & "Ha továbbra sem sikerül, két napon belül forduljon az eperHelper ügyfélszolgálathoz!", MsgBoxStyle.RetryCancel)
                If result = MsgBoxResult.Retry Then GoTo MicrosecRegRetry
            End If
            MyLoader.AddLogBook(Fnc.eal, resultRegSzoveg, LogTip.err)
            RegisztralatlanValtozat()
        End If
        Me.Close()
    End Sub

    Private Sub MaskedTextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RegInputMaskedTextBox.Validating
        ErrorProvider1.BlinkStyle = False
        RegInputMaskedTextBox.Text = RegInputMaskedTextBox.Text.Replace(" ", String.Empty)
        RegInputMaskedTextBox.Text = RegInputMaskedTextBox.Text.Replace("_", String.Empty)
        If RegInputMaskedTextBox.Text.Length < 6 Then
            RegInputMaskedTextBox.Text = String.Empty
            ErrorProvider1.SetError(Me.RegInputMaskedTextBox, "Minden mezőt töltsön ki!")
        Else ErrorProvider1.SetError(Me.RegInputMaskedTextBox, String.Empty)
        End If
    End Sub

    Private Sub MaskedTextBox1_mouseclick(sender As Object, e As MouseEventArgs) Handles RegInputMaskedTextBox.MouseClick
        Dim mesender = DirectCast(sender, MaskedTextBox)
        mesender.SelectionStart = 0
    End Sub


    Private Function Change(Input As Byte()) As Byte()
        Dim size = Input.Length + 1
        Dim sybyte() As Byte = New Byte(size) {}
        Dim i As Integer = 0
        For Each A As Byte In Input
            sybyte(i) = A Xor 251
            i += 1
        Next
        Return sybyte
    End Function

    Private Function unproc(Input As String) As String
        Dim origbase As String = Input & "="
        Dim origbyte As Byte() = System.Convert.FromBase64String(origbase)
        Dim op As Byte() = New Byte() {}
        op = Change(origbyte)
        Dim back = System.Text.Encoding.UTF8.GetString(op)
        back = Strings.Left(back, back.Length - 4)
        Return back
    End Function

End Class