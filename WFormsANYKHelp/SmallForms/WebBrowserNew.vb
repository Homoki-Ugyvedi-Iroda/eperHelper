Public Class WebBrowserNew
    Private Sub SetBrowserFeatureControlKey(feature As String, appName As String, value As UInt32)
        Using key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey([String].Concat("Software\Microsoft\Internet Explorer\Main\FeatureControl\", feature), Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
            key.SetValue(appName, value, Microsoft.Win32.RegistryValueKind.DWord)
        End Using
    End Sub

    Private Sub SetBrowserFeatureControl()
        ' http://msdn.microsoft.com/en-us/library/ee330720(v=vs.85).aspx

        ' FeatureControl settings are per-process
        Dim fileName = System.IO.Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName)

        ' make the control is not running inside Visual Studio Designer
        If [String].Compare(fileName, "devenv.exe", True) = 0 OrElse [String].Compare(fileName, "XDesProc.exe", True) = 0 Then
            Return
        End If

        'SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", fileName, GetBrowserEmulationMode())
        SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", fileName, 11001)

        ' Webpages containing standards-based !DOCTYPE directives are displayed in IE10 Standards mode.
        'SetBrowserFeatureControlKey("FEATURE_AJAX_CONNECTIONEVENTS", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_MANAGE_SCRIPT_CIRCULAR_REFS", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_DOMSTORAGE ", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_GPU_RENDERING ", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_IVIEWOBJECTDRAW_DMLT9_WITH_GDI  ", fileName, 0)
        'SetBrowserFeatureControlKey("FEATURE_DISABLE_LEGACY_COMPRESSION", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_LOCALMACHINE_LOCKDOWN", fileName, 0)
        'SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_OBJECT", fileName, 0)
        'SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_SCRIPT", fileName, 0)
        'SetBrowserFeatureControlKey("FEATURE_DISABLE_NAVIGATION_SOUNDS", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_SCRIPTURL_MITIGATION", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_SPELLCHECKING", fileName, 0)
        'SetBrowserFeatureControlKey("FEATURE_STATUS_BAR_THROTTLING", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_TABBED_BROWSING", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_VALIDATE_NAVIGATE_URL", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_WEBOC_DOCUMENT_ZOOM", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_WEBOC_POPUPMANAGEMENT", fileName, 0)
        'SetBrowserFeatureControlKey("FEATURE_WEBOC_MOVESIZECHILD", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_ADDON_MANAGEMENT", fileName, 0)
        'SetBrowserFeatureControlKey("FEATURE_WEBSOCKET", fileName, 1)
        'SetBrowserFeatureControlKey("FEATURE_WINDOW_RESTRICTIONS ", fileName, 0)
        'SetBrowserFeatureControlKey("FEATURE_XMLHTTP", fileName, 1)
    End Sub

    Private Function GetBrowserEmulationMode() As UInt32
        Dim browserVersion As Integer = 7
        Using ieKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer", Microsoft.Win32.RegistryKeyPermissionCheck.ReadSubTree, System.Security.AccessControl.RegistryRights.QueryValues)
            Dim version = ieKey.GetValue("svcVersion")
            If version Is Nothing Then
                version = ieKey.GetValue("Version")
                If version Is Nothing Then
                    Throw New ApplicationException("Microsoft Internet Explorer is required!")
                End If
            End If
            Integer.TryParse(version.ToString().Split("."c)(0), browserVersion)
        End Using

        Dim mode As UInt32 = 11000
        ' Internet Explorer 11. Webpages containing standards-based !DOCTYPE directives are displayed in IE11 Standards mode. Default value for Internet Explorer 11.
        Select Case browserVersion
            Case 7
                mode = 7000
                ' Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode. Default value for applications hosting the WebBrowser Control.
                Exit Select
            Case 8
                mode = 8000
                ' Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode. Default value for Internet Explorer 8
                Exit Select
            Case 9
                mode = 9000
                ' Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode. Default value for Internet Explorer 9.
                Exit Select
            Case 10
                mode = 10000
                ' Internet Explorer 10. Webpages containing standards-based !DOCTYPE directives are displayed in IE10 mode. Default value for Internet Explorer 10.
                Exit Select
            Case Else
                ' use IE11 mode by default
                Exit Select
        End Select

        Return mode
    End Function

End Class