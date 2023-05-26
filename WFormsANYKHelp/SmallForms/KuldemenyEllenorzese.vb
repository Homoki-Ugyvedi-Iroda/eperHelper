Public Class KuldemenyEllenorzese
    Public Sub New()

        InitializeComponent()
        mbLenyomat.Text = ""
        tbPDFIgazolas.Text = ""
        tbCelFajl.Text = ""

    End Sub

    Private Sub btnTallozCelfajlt_Click(sender As Object, e As EventArgs) Handles btnTallozCelfajlt.Click
        Dim OpenCelFajl As New OpenFileDialog
        Dim dialogresult As New DialogResult
        OpenCelFajl.Filter = "Minden fájl (*.*)| *.*"
        dialogresult = OpenCelFajl.ShowDialog()
        If dialogresult = DialogResult.OK AndAlso File.Exists(OpenCelFajl.FileName) Then
            'Dim fi As New FileInfo(OpenCelFajl.FileName)
            'If fi.Length > 150 * 1024 * 1024 Then
            '            Dim hibauzenet = "A megadott célfájl túl nagy!"
            'MyLoader.AddLogBook(Fnc.igazolasbeolvasas, hibauzenet, LogTip.err)
            '            MsgBox(hibauzenet, MsgBoxStyle.Critical)
            'End If
            tbCelFajl.Text = OpenCelFajl.FileName
        End If
    End Sub

    Private Sub mbLenyomat_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mbLenyomat.Validating
        mbLenyomat.Text = mbLenyomat.Text.ToLower
        If IsHex(mbLenyomat.Text) = False Then
            ErrorProvider1.SetError(mbLenyomat, "Csak hexadecimális értékeket adjon meg (azaz szám és 'a'-tól 'f' karakterig betű)!")
            mbLenyomat.Text = String.Empty
        Else
            ErrorProvider1.SetError(mbLenyomat, String.Empty)
        End If
    End Sub

    Private Sub btnTallozIgazolast_Click(sender As Object, e As EventArgs) Handles btnTallozIgazolast.Click
        Dim OpenIgazolas As New OpenFileDialog
        Dim dialogresult As New DialogResult
        Dim ErtekKiolvas As String = String.Empty

        OpenIgazolas.Filter = "PDF fájl (*.pdf)| *.pdf"
        dialogresult = OpenIgazolas.ShowDialog()
        If dialogresult = DialogResult.OK AndAlso File.Exists(OpenIgazolas.FileName) Then
            Dim fi As New FileInfo(OpenIgazolas.FileName)
            If fi.Length > 10 * 1024 * 1024 Then
                Dim hibauzenet = "A megadott fájl túl nagy ahhoz, hogy igazolásfájl legyen (10 MB fölött)!"
                MyLoader.AddLogBook(Fnc.igazolasbeolvasas, hibauzenet, LogTip.err)
                MsgBox(hibauzenet, MsgBoxStyle.Critical)
                Exit Sub
            End If


            Try
                    Dim IgazolasStr As String() = File.ReadAllLines(OpenIgazolas.FileName)
                    For Each line As String In IgazolasStr
                        If line.Contains("<ig:DokHash>") Then
                            line = line.Replace("<ig:DokHash>", String.Empty)
                            ErtekKiolvas = line.Replace("</ig:DokHash>", String.Empty)
                        End If
                    Next
                Catch ex As Exception
                    Dim hibauzenet = "A megadott igazolás fájl nem található vagy más okból nem nyitható meg!"
                    MyLoader.AddLogBook(Fnc.igazolasbeolvasas, hibauzenet, LogTip.err)
                    MsgBox(hibauzenet, MsgBoxStyle.Critical)
                End Try
                If ErtekKiolvas <> String.Empty Then
                    mbLenyomat.Text = ErtekKiolvas.ToLower
                    tbPDFIgazolas.Text = OpenIgazolas.FileName
                Else
                    Dim hibauzenet2 = "A megadott igazolás fájlból nem tudtuk kiolvasni a dokumentum lenyomatot. Próbálja meg a PDF fájl beolvasása után kimásolni a 'Dokumentum elektronikus lenyomata (Hash hexadecimális formában)' értéket és másolja be ezen ablak első mezőjébe!"
                    MyLoader.AddLogBook(Fnc.igazolasbeolvasas, hibauzenet2, LogTip.err)
                    MsgBox(hibauzenet2, MsgBoxStyle.Critical)
                End If
            End If
    End Sub

    Private Sub mbLenyomat_GotFocus(sender As Object, e As MouseEventArgs) Handles mbLenyomat.MouseClick
        Dim sendername As MaskedTextBox = DirectCast(sender, MaskedTextBox)
        sendername.SelectionStart = 0
    End Sub

    Private Sub btnElvet_Click(sender As Object, e As EventArgs) Handles btnElvet.Click
        mbLenyomat.Text = ""
        tbPDFIgazolas.Text = ""
        tbCelFajl.Text = ""
        Me.Close()
    End Sub

    Private Sub btnEllenoriz_Click(sender As Object, e As EventArgs) Handles btnEllenoriz.Click
        Dim HashCelFajl As String = String.Empty
        Dim uzenet As String = String.Empty

        If mbLenyomat.Text = String.Empty Or tbCelFajl.Text = String.Empty Then Exit Sub
        If Not File.Exists(tbCelFajl.Text) Then Exit Sub
        Try
            HashCelFajl = Sha256HashGenerator(tbCelFajl.Text)
        Catch ex As Exception
            Dim hibauzenet = "A célfájl nem olvasható: " & tbCelFajl.Text
            MsgBox(hibauzenet, MsgBoxStyle.Critical)
            MyLoader.AddLogBook(Fnc.igazolasbeolvasas, hibauzenet, LogTip.err)
        End Try
        If HashCelFajl = String.Empty Then Exit Sub
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase
        If comparer.Compare(mbLenyomat.Text, HashCelFajl) = 0 Then
            uzenet = "A megadott fájl azonos a kiválasztott igazolásban vagy lenyomat szerinti fájllal, azaz valóban ez az igazolás szerint megküldött fájl!" & Environment.NewLine & "(" & Path.GetFileName(tbCelFajl.Text) & IIf(tbPDFIgazolas.Text <> String.Empty, " összevetve: " & tbPDFIgazolas.Text, String.Empty) & ")"
            MsgBox(uzenet, MsgBoxStyle.OkOnly)
            MyLoader.AddLogBook(Fnc.igazolasbeolvasas, uzenet, LogTip.siker)
        Else
            uzenet = "A megadott fájl NEM azonos a kiválasztott igazolásban vagy lenyomat szerinti fájllal, azaz NEM ez a kiválasztott igazolás szerint megküldött fájl!" & Environment.NewLine & "(" & Path.GetFileName(tbCelFajl.Text) & IIf(tbPDFIgazolas.Text <> String.Empty, " összevetve: " & tbPDFIgazolas.Text, String.Empty) & ")"
            MsgBox(uzenet, MsgBoxStyle.Critical)
            MyLoader.AddLogBook(Fnc.igazolasbeolvasas, uzenet, LogTip.err)
        End If
    End Sub
End Class