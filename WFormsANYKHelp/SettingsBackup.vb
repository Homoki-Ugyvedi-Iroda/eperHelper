Imports System.Configuration
Imports System.Xml.XPath

Public Class SettingsBackup
    Private Sub New()
    End Sub

    Friend Shared Sub Import(ByVal settingsFilePath As String)
        If Not File.Exists(settingsFilePath) Then
            Throw New FileNotFoundException()
        End If
        Dim appSettings = My.MySettings.Default
        Try
            Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
            Dim appSettingsXmlName As String = My.MySettings.Default.Context("GroupName").ToString()
            ' returns "MyApplication.Properties.Settings"     
            ' Open settings file as XML     
            Dim import__1 = XDocument.Load(settingsFilePath)
            ' Get the whole XML inside the settings node     
            Dim settings = import__1.XPathSelectElements("//" & appSettingsXmlName)
            config.GetSectionGroup("userSettings").Sections(appSettingsXmlName).SectionInformation.SetRawXml(settings.[Single]().ToString())
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("userSettings")
            appSettings.Reload()
        Catch generatedExceptionName As Exception
            MyLoader.AddLogBook(Fnc.cfg, "Nem sikerült a beállítások beolvasása", LogTip.err)
            appSettings.Reload()
        End Try
    End Sub

    Friend Shared Sub Export(ByVal settingsFilePath As String)
        My.MySettings.Default.Save()
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
        config.SaveAs(settingsFilePath)
    End Sub

End Class
