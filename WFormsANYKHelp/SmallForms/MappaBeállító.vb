Public Class MappaBeállító
    Public Sub New()

        InitializeComponent()
        Me.tbOwn.Text = My.Settings.AccessibleUserSettings
        Me.tbLefuzesMod.Text = My.Settings.mappaLefuzes
        Me.tbExtractMod.Text = My.Settings.mappaExtract
        Me.tbXMLmegnyitasMod.Text = My.Settings.mappaXMLmegnyitas
        RunOtherANYKFolderSettingsCheck() 'Frissíti az ÁNYK aktuális konfigurációs paraméterei szerintire azokat a konfigurációs adatokat, amelyek az ÁNYK-ra épülnek
        Me.tbANYKfuttatas.Text = My.Settings.mappaANYKfuttatas
        Me.tbANYKadatMod.Text = My.Settings.mappaANYKadat
        Me.tbANYKmentes.Text = My.Settings.mappaANYKmentes
        Me.tbANYKkuldendo.Text = My.Settings.mappaANYKkuldendo
        Me.tbANYKkuldott.Text = My.Settings.mappaANYKelkuldott
    End Sub



    Private Sub btnMegnezAlap_Click(sender As Object, e As EventArgs) Handles btnAlap.Click
        OpenExplorerwPath(My.Settings.AccessibleUserSettings)
    End Sub

    Private Sub btnMegnyitroot_Click(sender As Object, e As EventArgs) Handles btnroot.Click
        OpenExplorerwPath(My.Settings.mappaANYKfuttatas)
    End Sub

    Private Sub btnMegnyitANYKmentes_Click(sender As Object, e As EventArgs) Handles btnMegnyitANYKmentes.Click
        OpenExplorerwPath(My.Settings.mappaANYKmentes)
    End Sub

    Friend Shared Function ValasszKonyvtarat(Optional Alap As String = "") As String
        Dim dialogresult As New DialogResult
        Dim ValasztottFajl = String.Empty
        Dim openFolderDialog1 As New FolderBrowserDialog()
        If System.IO.Directory.Exists(Alap) Then openFolderDialog1.SelectedPath = Alap
        dialogresult = openFolderDialog1.ShowDialog
        If Not dialogresult = DialogResult.OK Then Return String.Empty
        ValasztottFajl = openFolderDialog1.SelectedPath
        Return ValasztottFajl
    End Function

    Private Sub Bezár_Click(sender As Object, e As EventArgs) Handles Bezár.Click
        Me.Close()
    End Sub

    Private Sub btnANYKkuldendo_Click(sender As Object, e As EventArgs) Handles btnANYKkuldendo.Click
        OpenExplorerwPath(My.Settings.mappaANYKkuldendo)
    End Sub

    Private Sub btnKuldott_Click(sender As Object, e As EventArgs) Handles btnKuldott.Click
        OpenExplorerwPath(My.Settings.mappaANYKelkuldott)
    End Sub

    Private Sub SaveSettingsandRefresh()
        My.Settings.Save()
        Me.tbLefuzesMod.Text = My.Settings.mappaLefuzes
        Me.tbExtractMod.Text = My.Settings.mappaExtract
        Me.tbXMLmegnyitasMod.Text = My.Settings.mappaXMLmegnyitas
        Me.tbANYKadatMod.Text = My.Settings.mappaANYKadat
    End Sub
    Private Sub btnMisc_Click(sender As Object, e As EventArgs) Handles btnANYKadatMod.Click, btnExtractMod.Click, btnLefuzesMod.Click, btnXMLmegnyitasMod.Click
        Dim sendername As Button = DirectCast(sender, Button)
        Dim tbname As String = "tb" & sendername.Name.Substring(3)
        Dim sendervalue As TextBox = CallByName(Me, tbname, CallType.Get)
        Dim setname As String = ""

        Select Case sendername.Name
            Case "btnANYKadatMod"
                setname = "mappaANYKadat"
            Case "btnExtractMod"
                setname = "mappaExtract"
            Case "btnLefuzesMod"
                setname = "mappaLefuzes"
            Case "btnXMLmegnyitasMod"
                setname = "mappaXMLmegnyitas"
        End Select
        Dim SelectedPath As String
        SelectedPath = ValasszKonyvtarat(CallByName(My.Settings, setname, CallType.Get))
        If SelectedPath = String.Empty Or Not Directory.Exists(SelectedPath) Then Exit Sub

        Select Case sendername.Name
            Case "btnANYKadatMod"
                tbANYKadatMod.Text = SelectedPath
                Dim Result As New DialogResult
                Result = MsgBox("Valóban áthelyezi a teljes ÁNYK adatmappát annak minden alkönyvtárával együtt? Nem visszafordítható. Ne legyen nyitva ÁNYK! Kattintson az OK-ra, ha áthelyezzük!", MsgBoxStyle.OkCancel)
                If Result = DialogResult.OK Then

                    My.Settings.mappaANYKadat = SelectedPath
                    If File.Exists(ParamTextFile) Then
                        My.Settings.mappaANYKmentes = SelectedPath & Path.DirectorySeparatorChar & ReadParamText(ParamTextFile, "prop.usr.saves").Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
                        ChangeParamText(ParamTextFile, "prop.usr.root", SelectedPath.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar), False, "windows-1250")
                        ChangeParamText(ParamTextFile, "prop.usr.saves", My.Settings.mappaANYKmentes.Replace(SelectedPath & Path.DirectorySeparatorChar, ""), False, "windows-1250")
                    End If
                    If Directory.Exists(SelectedPath) Then
                        Try
                            CopyDirectory(My.Settings.mappaANYKadat, SelectedPath)
                            Directory.Delete(My.Settings.mappaANYKadat, True)
                        Catch
                        End Try
                        MyLoader.AddLogBook(Fnc.cfg, "ÁNYK adat könyvtár sikeres áthelyezve a " & SelectedPath & " könyvtárba.", LogTip.siker)
                    End If
                End If
            Case "btnExtractMod"
                tbExtractMod.Text = SelectedPath
            Case "btnLefuzesMod"
                tbLefuzesMod.Text = SelectedPath
            Case "btnXMLmegnyitasMod"
                tbXMLmegnyitasMod.Text = SelectedPath
        End Select

        CallByName(My.Settings, setname, CallType.Set, SelectedPath)
        SaveSettingsandRefresh()

        If Directory.Exists(sendervalue.Text) = True And CallByName(My.Settings, setname, CallType.Get) = sendervalue.Text Then Exit Sub
        If Directory.Exists(sendervalue.Text) = True And CallByName(My.Settings, setname, CallType.Get) <> sendervalue.Text Then
            'Ha beírta kézzel az új könyvtárat, és az létező könyvtár, de nem azonos a beállítás szerintivel, akkor beállítja és kilép
            CallByName(My.Settings, setname, CallType.Set, sendervalue.Text)
            SaveSettingsandRefresh()
            Exit Sub
        End If
        If sendervalue.Text = "" Then Exit Sub

        If (Not System.IO.Directory.Exists(sendervalue.Text)) And System.IO.Directory.Exists(System.IO.Directory.GetParent(sendervalue.Text).ToString) Then
            Dim dirinfo As New DirectoryInfo(sendervalue.Text)
            Dim dialogresult As New DialogResult
            dialogresult = MsgBox("Nem létezik a \" & dirinfo.Name & " nevű alkönyvtár. Létrehozzam és kijelöljem?", MsgBoxStyle.Critical & MsgBoxStyle.YesNo)
            If dialogresult = vbOK Then
                System.IO.Directory.CreateDirectory(sendervalue.Text)
                CallByName(My.Settings, setname, CallType.Set, sendervalue.Text)
                SaveSettingsandRefresh()
                Exit Sub
            Else
                Dim parentpath As String = dirinfo.Parent.FullName.ToString
                CallByName(My.Settings, setname, CallType.Set, parentpath)
                SaveSettingsandRefresh()
                Exit Sub
            End If
        End If
    End Sub

    Public Sub CopyDirectory(ByVal sourcePath As String, ByVal destinationPath As String)
        Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(sourcePath)

        ' If the destination folder don't exist then create it
        If Not System.IO.Directory.Exists(destinationPath) Then
            System.IO.Directory.CreateDirectory(destinationPath)
        End If

        Dim fileSystemInfo As System.IO.FileSystemInfo
        For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
            Dim destinationFileName As String =
            System.IO.Path.Combine(destinationPath, fileSystemInfo.Name)

            ' Now check whether its a file or a folder and take action accordingly
            If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                System.IO.File.Copy(fileSystemInfo.FullName, destinationFileName, True)
            Else
                ' Recursively call the mothod to copy all the neste folders
                CopyDirectory(fileSystemInfo.FullName, destinationFileName)
            End If
        Next
    End Sub

    Private Sub btnLefuzesOpen_Click(sender As Object, e As EventArgs) Handles btnLefuzesOpen.Click
        OpenExplorerwPath(My.Settings.mappaLefuzes)
    End Sub

    Private Sub btnExtractOpen_Click(sender As Object, e As EventArgs) Handles btnExtractOpen.Click
        OpenExplorerwPath(My.Settings.mappaExtract)
    End Sub

    Private Sub btnKRCSTXMLmegnyitasOpen_Click(sender As Object, e As EventArgs) Handles btnXMLmegnyitasOpen.Click
        OpenExplorerwPath(My.Settings.mappaXMLmegnyitas)
    End Sub

    Private Sub btnANYKadatOpen_Click(sender As Object, e As EventArgs) Handles btnANYKadatOpen.Click
        OpenExplorerwPath(My.Settings.mappaANYKadat)
    End Sub

    Private Sub btnUserAccessibleFolderSettings(sender As Object, e As EventArgs) Handles btnSetAccessibleSettings.Click
        Dim SelectedPath As String
        SelectedPath = ValasszKonyvtarat(My.Settings.AccessibleUserSettings)
        If SelectedPath = String.Empty Then Exit Sub

        Dim Result As New DialogResult
        Result = MsgBox("Valóban módosítja a jelen program teljes, felhasználó számára elérhető könyvtárának útvonalát? Az áthelyezés után a program kilép, újraindítást igényel." & Environment.NewLine &
                            "A program megpróbálja kilépés előtt áthelyezni a korábbi útvonalról a törzsadatbázist és a regisztrációs fájlt, de csak ha a célkönyvtárban nincsen ilyen nevű fájl." _
                            , MsgBoxStyle.YesNo)
        If Result = DialogResult.No Then Exit Sub
        Dim currentdir = My.Settings.AccessibleUserSettings
        My.Settings.AccessibleUserSettings = SelectedPath
        My.Settings.Save()
        tbOwn.Text = SelectedPath
        If Not File.Exists(SelectedPath & Path.DirectorySeparatorChar & Fajl.TDB) Then
            Try
                File.Copy(currentdir & Path.DirectorySeparatorChar & Fajl.TDB, SelectedPath & Path.DirectorySeparatorChar & Fajl.TDB)
            Catch ex As Exception
                MsgBox("Másolási hiba! Lehet, hogy nincsen írási jog a célkönyvtárba. A törzsadatbázist nem másolta át a program", MsgBoxStyle.Critical)
            End Try
        Else
            MyLoader.AddLogBook(Fnc.cfg, "A célkönyvtár tartalmazott törzsadatbázist", LogTip.norm)
        End If
        If Not File.Exists(SelectedPath & Path.DirectorySeparatorChar & Fajl.XSignReg) Then
            Try
                File.Copy(currentdir & Path.DirectorySeparatorChar & Fajl.XSignReg, SelectedPath & Path.DirectorySeparatorChar & Fajl.XSignReg)
            Catch ex As Exception
                MsgBox("Másolási hiba! Lehet, hogy nincsen írási jog a célkönyvtárba. A regisztrációs fájlt nem másolta át a program", MsgBoxStyle.Critical)
            End Try
        Else
            MyLoader.AddLogBook(Fnc.cfg, "A célkönyvtár tartalmazott regisztrációs fájlt", LogTip.norm)
        End If

        MyLoader.AddLogBook(Fnc.cfg, "Beállítva látható felhasználói könyvtárként: " & SelectedPath, LogTip.siker)
        Application.Exit()
    End Sub
End Class