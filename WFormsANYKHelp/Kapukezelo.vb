Imports System.Collections.Specialized
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Threading
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Edge
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.Support.UI
Imports Microsoft.Win32

Friend Class Kapukezelo
    Const INTERNET_COOKIE_HTTPONLY As Integer = &H2000
    Dim UKPLoginString As String = ""
    Dim URL_GateGovHu As String = "https://gate.gov.hu/sso/ap/ApServlet"
    Dim Uri_GateGovHu As Uri = New Uri("https://gate.gov.hu/sso/ap/ApServlet")
    Dim URL_UKP_Internal_Transfer As String = "https://gate.gov.hu/sso/InterSiteTransfer?TARGET=&PARTNER="
    Dim URL_UKP_Internal_Transfer2 As String = "https://gate.gov.hu/sso/InterSiteTransfer?TARGET=https://ugyfelkapu.magyarorszag.hu/szolgaltatasok/tarhely/beerkezett&PARTNER=mohu"
    Dim URL_PKP_Belepes As String = "https://ugyfelkapu.magyarorszag.hu/eperkapu/belepes"
    Dim URL_HKP_Belepes As String = "https://ugyfelkapu.magyarorszag.hu/hivatalikapu/belepes"

    Dim URL_PKP_Belepes2 As String = "https://ugyfelkapu.magyarorszag.hu/eperkapu/belepes/EperkapuLoginWindow?id=frmUKLogin&struts.portlet.mode=view&dynamicAttributes=%7B%7D&struts.portlet.action=%2FEperkapuLogin%2FEperkapuLogin%2FprocessLogin&templateDir=custom&theme=simple&action=d&windowstate=normal&mode=view"
    Dim URL_HKP_Belepes2 As String = "https://ugyfelkapu.magyarorszag.hu/hivatalikapu/belepes/HKPLoginWindow?id=frmUKLogin&struts.portlet.mode=view&dynamicAttributes=%7B%7D&struts.portlet.action=%2FHKPLogin%2FHKPLogin%2FprocessLogin&templateDir=custom&theme=simple&action=d&windowstate=normal&mode=view"
    Dim URL_UKP_Beerkezett As String = "https://ugyfelkapu.magyarorszag.hu/szolgaltatasok/tarhely/beerkezett"
    Dim URL_PKP_Beerkezett As String = "https://ugyfelkapu.magyarorszag.hu/eperkapu/dokumentumok"
    Dim URL_HKP_Beerkezett As String = "https://ugyfelkapu.magyarorszag.hu/hivatalikapu/dokumentumok" 'Még nem teszteltem!
    Dim URL_UKP_Kuldes As String = "https://ugyfelkapu.magyarorszag.hu/szolgaltatasok/dokumentumfeltoltes" '"https://ugyfelkapu.magyarorszag.hu/szolgaltatasok/dokumentumfeltoltes/egyszerusitett 
    Dim URL_PKP_Kuldes As String = "https://ugyfelkapu.magyarorszag.hu/eperkapu/feltoltes"
    Dim Uri_PKP_Kuldes As Uri = New Uri("https://ugyfelkapu.magyarorszag.hu/eperkapu/feltoltes")
    Dim URL_HKP_Kuldes As String = "https://ugyfelkapu.magyarorszag.hu/hivatalikapu/feltoltes"
    Dim URL_UKP_Logout As String = "https://gate.gov.hu/sso/ap/logout?partnerid=mohu"
    Dim URL_PKP_Logout As String = "https://ugyfelkapu.magyarorszag.hu/eperkapu/dokumentumok/LogoutEperkapuWindow?logoutmethod=logout&struts.portlet.mode=view&struts.portlet.action=%2Flogouteperkapu%2Flogouteperkapu%2FlogoutEperkapu&action=d&windowstate=normal&mode=view"
    Dim URL_PKP_Feltoltes As String = "https://ugyfelkapu.magyarorszag.hu/eperkapu/feltoltes?targetServiceName=hkp/fajlFeltoltesHtml"
    Dim Uri_PKP_Feltoltes As Uri = New Uri("https://ugyfelkapu.magyarorszag.hu/eperkapu/feltoltes?targetServiceName=hkp/fajlFeltoltesHtml")


    'ALT? https://ugyfelkapu.magyarorszag.hu/mohu_portlet_frame/auth/SSOLogout
    'ALT? https://ugyfelkapu.magyarorszag.hu/kilepes
    'Jelszó beállítása: https://ugyfelkapu.magyarorszag.hu/eperkapu/beallitasok HTTP/1.1

    Dim GateGovJar As New CookieContainer
    Dim SSOJar As New CookieContainer
    Dim GateGovCookie As New Net.Cookie
    Dim UKPSzolgCookie As New Net.Cookie
    Dim SSOCookie As New Net.Cookie
    '    Dim UKPName As String
    'Dim UKPPassw As String
    'Dim PKPName As String
    'Dim PKPPassw As String

    Enum BrowserType
        None = 0
        Google = 1
        FF = 2
        Edge = 3
    End Enum

    Enum Irany
        DL = 0
        UL = 1
    End Enum


    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function InternetSetCookie(lpszUrlName As String, lpszCookieName As String, lpszCookieData As String) As Boolean
    End Function

    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function InternetSetCookieEx(lpszUrlName As String, lpszCookieName As String, lpszCookieData As String, dwFlags As Integer, lpReserved As IntPtr) As Boolean
    End Function

    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function InternetGetCookieEx(pchURL As String, pchCookieName As String, pchCookieData As StringBuilder, ByRef pcchCookieData As UInteger, dwFlags As Integer, lpReserved As IntPtr) As Boolean
    End Function
    Friend Sub WriteRespToFile(FileName As String, From As Stream)
        Using bw As New BinaryWriter(File.Open(FileName, FileMode.Create))
            From.CopyTo(bw.BaseStream)
            '            bw.Close()
        End Using
    End Sub


    Friend Sub LoginUKP_beerkezett()
        'webBrowser.Navigate("javascript:void((function(){var a,b,c,e,f;f=0;a=document.cookie.split('; ');for(e=0;e<a.length&&a[e];e++){f++;for(b='.'+location.host;b;b=b.replace(/^(?:%5C.|[^%5C.]+)/,'')){for(c=location.pathname;c;c=c.replace(/.$/,'')){document.cookie=(a[e]+'; domain='+b+'; path='+c+'; expires='+new Date((new Date()).getTime()-1e11).toGMTString());}}}})())"
        NavigateToTarget_wWebDriver(Kapu.UKP, Iranyban:=Irany.DL)
    End Sub

    Friend Sub LoginPKP_beerkezett()
        NavigateToTarget_wWebDriver(Kapu.PKP, Iranyban:=Irany.DL)
    End Sub

    Friend Sub LoginHKP_beerkezett()
        NavigateToTarget_wWebDriver(Kapu.HKP, Iranyban:=Irany.DL)
    End Sub

    Friend Sub LoginHttpRequest_wWebBrowser_feltoltes_fajllal(KapuTipus As Kapu, Mit As String)
        If Not File.Exists(Mit) Then
            Dim hibauzenet = "Megadott fájl nem létezik"
            MsgBox(hibauzenet)
            MyLoader.AddLogBook(Fnc.web, hibauzenet, LogTip.err)
            Exit Sub
        End If

        Dim TargetURL = String.Empty
        LoginUKP()
        If Me.UKPLoginString = "Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava" Then Exit Sub
        If KapuTipus = Kapu.PKP Or KapuTipus = Kapu.HKP Then
            If LoginPKPHKP_wHttpRequest(KapuTipus) = False Then Exit Sub
            If KapuTipus = Kapu.PKP Then TargetURL = URL_PKP_Kuldes Else TargetURL = URL_HKP_Kuldes

        ElseIf KapuTipus = Kapu.UKP Then
            TargetURL = URL_UKP_Kuldes
        End If
        'Hibakeresés ÜKP jelszóval?
        Dim CookieStr As String
        CookieStr = UKPSzolgCookie.ToString() + ";"
        InternetSetCookieEx(TargetURL, Nothing, CookieStr, 0, 0)
        CookieStr = SSOCookie.ToString() + "; "
        InternetSetCookieEx(TargetURL, Nothing, CookieStr, 0, 0)
        Dim NewWeb As New WebBrowserNew
        NewWeb.Size = New Size(1024, 768)
        NewWeb.Show()
        NewWeb.WebBrowserNewCtrl.Navigate(TargetURL, False)
        NewWeb.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Try
            While NewWeb.WebBrowserNewCtrl.ReadyState <> WebBrowserReadyState.Complete
                System.Windows.Forms.Application.DoEvents()
            End While
        Catch ex As Exception
        End Try
        Dim document As System.Windows.Forms.HtmlDocument = Nothing
        Try
            document = NewWeb.WebBrowserNewCtrl.Document
        Catch ex As Exception
        End Try
        If KapuTipus = Kapu.UKP And Not IsNothing(document) Then
            Dim elementcollect As HtmlElementCollection = document.Body.GetElementsByTagName("button")
            For Each el As HtmlElement In elementcollect
                If el.InnerText = "Kiválaszt" Then el.InvokeMember("click")
            Next
        ElseIf KapuTipus = Kapu.PKP Or KapuTipus = Kapu.HKP And Not IsNothing(document) Then
            Dim elementcollect As HtmlElementCollection = document.Body.GetElementsByTagName("input")
            For Each el As HtmlElement In elementcollect
                If el.Id = "feltoltendoFajl" And el.Name = "feltoltendoFajl" Then
                    el.InvokeMember("click")
                End If
            Next
        Else
        End If

    End Sub



    Public Delegate Function AsyncMethodCaller(ByVal elem As HtmlElement,
        <Out> ByRef threadId As Integer) As String


    Friend Sub LoginUKP_feltoltes()
        'Me.UKPLoginString = String.Empty
        'LoginUKP()
        'If Me.UKPLoginString <> String.Empty Then Exit Sub '"Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava" Then Exit Sub
        NavigateToTarget_wWebDriver(Kapu.UKP, Iranyban:=Irany.UL)
        'NavigateToTarget_wWebBrowser(URL_UKP_Kuldes)
    End Sub

    Friend Sub LoginPKP_feltoltes()
        'Me.UKPLoginString = String.Empty
        'LoginUKP()
        'If Me.UKPLoginString <> String.Empty Then Exit Sub ' "Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava" Then Exit Sub
        'If LoginPKPHKP_wHttpRequest(Kapu.PKP) = True Then NavigateToTarget_wWebBrowser(URL_PKP_Kuldes)
        NavigateToTarget_wWebDriver(Kapu.PKP, Iranyban:=Irany.UL)
    End Sub


    Friend Sub LoginHKP_feltoltes()
        'Me.UKPLoginString = String.Empty
        'LoginUKP()
        'If Me.UKPLoginString <> String.Empty Then Exit Sub '"Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava" 
        'If LoginPKPHKP_wHttpRequest(Kapu.HKP) = True Then NavigateToTarget_wWebBrowser(URL_HKP_Kuldes)
        NavigateToTarget_wWebDriver(Kapu.HKP, Iranyban:=Irany.UL)
    End Sub

    Friend Sub LoginPKP_admin()
        Dim PKPadminaddress = "https://tarhely.gov.hu/adminisztracio"
        Dim PKPadminJAR As New CookieContainer
        MyLoader.ProgressBar1.Value = 0
        MyLoader.ProgressBar1.Maximum = 40
        MyLoader.ProgressBar1.Step = 10
        MyLoader.ProgressBar1.PerformStep()

        LoginUKP()
        If Me.UKPLoginString = "Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava" Then Exit Sub
        Dim R1 = New HttpReqResUKP(New Uri(PKPadminaddress), mJar:=Nothing, AllowAutoRedirect:=0, HostHeader:="tarhely.gov.hu")
        R1.GetHttp()
        R1.GetResponse()
        Dim RedirectedUri As Uri = R1.RedirectUri
        PKPadminJAR = R1.GetAllCookie(New Uri("https://tarhely.gov.hu"))
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "Átirányítás PKP admin#1", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()

        R1 = New HttpReqResUKP(RedirectedUri, mJar:=GateGovJar, AllowAutoRedirect:=0, HostHeader:="gate.gov.hu")
        R1.GetHttp()
        R1.GetResponse()
        RedirectedUri = R1.RedirectUri
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "Átirányítás PKP admin#2", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()

        R1 = New HttpReqResUKP(RedirectedUri, mJar:=GateGovJar, AllowAutoRedirect:=0, HostHeader:="gate.gov.hu")
        R1.GetHttp()
        R1.GetResponse()
        RedirectedUri = R1.RedirectUri
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "Átirányítás PKP admin#3", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()

        R1 = New HttpReqResUKP(RedirectedUri, mJar:=PKPadminJAR, AllowAutoRedirect:=0, HostHeader:="tarhely.gov.hu")
        R1.GetHttp()
        R1.GetResponse()
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "Megnyitás", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()

        Dim CookieColl As CookieCollection
        Dim CookieStr As String = String.Empty
        CookieColl = PKPadminJAR.GetCookies(New Uri("https://tarhely.gov.hu"))
        For Each cookie In CookieColl
            CookieStr = cookie.ToString() + "; "
            InternetSetCookieEx(PKPadminaddress, Nothing, CookieStr, 0, 0)
        Next
        'Csere!

        Dim NewWeb As New WebBrowserNew
        NewWeb.Size = New Size(1024, 768)
        NewWeb.Show()
        NewWeb.WebBrowserNewCtrl.Navigate(PKPadminaddress, False)
    End Sub

    Private Sub LoginUKP()
        UKPSzolgCookie = New Net.Cookie
        SSOCookie = New Net.Cookie
        Dim UKPName As String = Kapukezelo.Decrypt(My.Settings.UKPUName, "UKPUName")
        Dim UKPPassw As String = Kapukezelo.Decrypt(My.Settings.UKPPassw, "UKPPassw")

        If UKPName = "" Or UKPPassw = "" Then
            KapuUserNamePasswForm.ShowDialog(Me)
            If UKPName = "" Or UKPPassw = "" Then
                Dim hiba = "Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava (nincsen rögzítve felhasználónév vagy jelszó)"
                MyLoader.AddLogBook(Fnc.web, hiba, LogTip.err)
                Exit Sub
            End If
        End If


        Dim R1 As New HttpReqResUKP(Uri_GateGovHu, RefererHeader:=URL_GateGovHu)
        R1.GetHttp()
        R1.GetResponse()
        If R1.GetResponse Is Nothing Then
            Dim hiba = "Ismeretlen hiba miatt a bejelentkezés sikertelen"
            MyLoader.AddLogBook(Fnc.web, hiba, LogTip.err)
            Me.UKPLoginString = hiba
            Exit Sub
        End If
        GateGovCookie = R1.GetFirstCookie(Uri_GateGovHu)
        GateGovJar.Add(GateGovCookie)
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "gate.gov.hu cookie rendben", LogTip.norm)
        MyLoader.ProgressBar1.Value = 0
        MyLoader.ProgressBar1.Maximum = 60
        MyLoader.ProgressBar1.Step = 10
        MyLoader.ProgressBar1.PerformStep()

        R1 = New HttpReqResUKP(Uri_GateGovHu, mJar:=GateGovJar, AllowAutoRedirect:=0, RefererHeader:=URL_GateGovHu)
        Dim qryString As String = String.Empty
        qryString = "partnerid=&target=&felhasznaloNev=" & UrlEncodeforKapu(UKPName) & "&jelszo=" & UrlEncodeforKapu(UKPPassw)
        R1.PostHttp(qryString)
        R1.GetResponse()
        If R1.GetResponse Is Nothing Then
            Dim hiba = "Ismeretlen hiba miatt a bejelentkezés sikertelen"
            MyLoader.AddLogBook(Fnc.web, hiba, LogTip.err)
            MyLoader.ProgressBar1.Value = 0
            Me.UKPLoginString = hiba
            Exit Sub
        End If

        Dim ResponseText As String
        Using reader = New System.IO.StreamReader(R1.ResponseSt.GetResponseStream, Encoding.UTF8)
            ResponseText = reader.ReadToEnd()
        End Using
        If ResponseText.Contains("Sikertelen bejelentkezés!") Then
            Dim hiba = "Hibás az ügyfélkapu megadott/beállított felhasználóneve vagy jelszava"
            MyLoader.AddLogBook(Fnc.web, hiba, LogTip.err)
            MyLoader.ProgressBar1.Value = 0
            Me.UKPLoginString = hiba
            Exit Sub

        End If
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "Az ügyfélkapus felhasználónév (" & UKPName & ") és a hozzá tartozó jelszó elfogadva", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()

        R1 = New HttpReqResUKP(New Uri(URL_GateGovHu), GateGovJar, False)
        R1.GetHttp()
        R1.GetResponse()
        R1.GetResponse.Close()

        R1 = New HttpReqResUKP(New Uri(URL_UKP_Internal_Transfer), mJar:=GateGovJar, AllowAutoRedirect:=0) '#4-#5
        R1.GetHttp()
        R1.GetResponse()

        Dim RedirectedUri As Uri = R1.RedirectUri
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "Átirányítás#1", LogTip.norm)
        R1 = New HttpReqResUKP(RedirectedUri, mJar:=Nothing, AllowAutoRedirect:=0) '#6
        R1.GetHttp()
        R1.GetResponse()
        UKPSzolgCookie = R1.GetFirstCookie(New Uri("https://ugyfelkapu.magyarorszag.hu"))
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "Ügyfélkapu cookie OK", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()

        R1 = New HttpReqResUKP(New Uri(URL_UKP_Internal_Transfer2), GateGovJar, False) '#7
        R1.GetHttp()
        R1.GetResponse()
        RedirectedUri = R1.RedirectUri
        R1.GetResponse.Close()
        MyLoader.AddLogBook(Fnc.web, "Átirányítás#2", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()

        SSOJar.Add(UKPSzolgCookie)
        R1 = New HttpReqResUKP(RedirectedUri, mJar:=SSOJar, AllowAutoRedirect:=0, HostHeader:="ugyfelkapu.magyarorszag.hu")
        'eredeti > R1 = New HttpReqResUKP(RedirectedUri, mJar:=GateGovJar, AllowAutoRedirect:=0, HostHeader:="ugyfelkapu.magyarorszag.hu")
        R1.GetHttp()
        MyLoader.AddLogBook(Fnc.web, "Ügyfélkapu bejelentkezés sikeres", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()
        R1.GetResponse()
        SSOCookie = R1.GetFirstCookie(New Uri("https://ugyfelkapu.magyarorszag.hu"))
        SSOJar.Add(SSOCookie)
        MyLoader.AddLogBook(Fnc.web, "SSO cookie OK, ügyfélkapu megnyitható", LogTip.siker)
        MyLoader.ProgressBar1.PerformStep()

        RedirectedUri = R1.RedirectUri
        R1.GetResponse.Close()
        'Me.UKPLoginString = RedirectedUri.ToString

    End Sub

    Public Shared Function GetGlobalCookies(uri As String) As String
        Dim datasize As UInteger = 1024
        Dim cookieData As New StringBuilder(CInt(datasize))
        If InternetGetCookieEx(uri, Nothing, cookieData, datasize, INTERNET_COOKIE_HTTPONLY, IntPtr.Zero) AndAlso cookieData.Length > 0 Then
            Return cookieData.ToString().Replace(";"c, ","c)
        Else
            Return Nothing
        End If
    End Function

    Private Function LoginPKPHKP_wHttpRequest(Optional KapuType As Kapu = Kapu.PKP) As Boolean
        Dim KapuUName As String = String.Empty
        Dim KapuPassw As String = String.Empty
        Dim Belepes1Cim As String = String.Empty
        Dim Belepes2Cim As String = String.Empty
        Dim KapuName As String = String.Empty

        'Itt dönti el, hogy a megadott paraméter szerint Perkapuba vagy Hivatali kapuba próbáljon-e meg belépni
        Select Case KapuType
            Case Kapu.PKP
                Belepes1Cim = URL_PKP_Belepes
                Belepes2Cim = URL_PKP_Belepes2
                KapuUName = Kapukezelo.Decrypt(My.Settings.PKPUName, "PKPUName")
                KapuPassw = Kapukezelo.Decrypt(My.Settings.PKPPassw, "PKPPassw")
                KapuName = "perkapu"
            Case Kapu.HKP
                Belepes1Cim = URL_HKP_Belepes
                Belepes2Cim = URL_HKP_Belepes2
                KapuUName = Kapukezelo.Decrypt(My.Settings.HKPUName, "HKPUName")
                KapuPassw = Kapukezelo.Decrypt(My.Settings.HKPPassw, "HKPPassw")
                KapuName = "hivatali kapu"
        End Select

        If KapuUName = "" Or KapuPassw = "" Then
            KapuUserNamePasswForm.ShowDialog(Me)
            If KapuUName = "" Or KapuPassw = "" Then
                Return False
            End If
        End If

        Dim loginsuccess As Boolean = False
        loginsuccess = LoginPKPHttpRequest(Belepes1Cim, Belepes2Cim, KapuUName, KapuPassw, KapuName)
        Return loginsuccess

    End Function

    Friend Function LoginPKPHttpRequest(Belepes1Cim As String, Belepes2Cim As String, KapuUName As String, KapuPassw As String, KapuName As String) As Boolean
        Dim R1 = New HttpReqResUKP(New Uri(Belepes1Cim), SSOJar, AllowAutoRedirect:=0, HostHeader:="ugyfelkapu.magyarorszag.hu", RefererHeader:=URL_UKP_Beerkezett)
        R1.GetHttp()
        R1.GetResponse()
        MyLoader.ProgressBar1.Value = 0
        MyLoader.ProgressBar1.Maximum = 30
        MyLoader.ProgressBar1.Step = 10
        MyLoader.AddLogBook(Fnc.web, "Kapu belépési cím #1 megérkezett", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()
        R1.GetResponse.Close()

        R1 = New HttpReqResUKP(New Uri(Belepes2Cim), SSOJar, AllowAutoRedirect:=0, HostHeader:="ugyfelkapu.magyarorszag.hu", RefererHeader:=Belepes1Cim)
        Dim qryString As String = String.Empty
        qryString = "partnerid=&target=&officeName=" & UrlEncodeforKapu(KapuUName) & "&password=" & UrlEncodeforKapu(KapuPassw)
        R1.PostHttp(qryString)
        R1.GetResponse()
        MyLoader.AddLogBook(Fnc.web, "Kapu belépési cím #2", LogTip.norm)
        MyLoader.ProgressBar1.PerformStep()

        Dim Response2Text As String
        Using reader = New System.IO.StreamReader(R1.ResponseSt.GetResponseStream, Encoding.UTF8)
            Response2Text = reader.ReadToEnd()
        End Using
        R1.GetResponse.Close()

        If Response2Text.Contains("Sikertelen bejelentkezés!") Then
            Dim hiba As String = "Hibás a megadott " & KapuName & " (rövid) név vagy jelszó!"
            MsgBox(hiba, MsgBoxStyle.Critical)
            MyLoader.AddLogBook(Fnc.web, hiba, LogTip.err)
            Return False

        End If
        MyLoader.AddLogBook(Fnc.web, "A " & KapuName & " bejelentkezés sikeres!", LogTip.siker)
        MyLoader.ProgressBar1.PerformStep()
        Return True
    End Function

    Friend Sub NavigateToTarget_wWebBrowser(URL As String)
        Dim CookieStr As String
        CookieStr = UKPSzolgCookie.ToString() + ";"
        InternetSetCookieEx(URL, Nothing, CookieStr, 0, 0)
        CookieStr = SSOCookie.ToString() + "; "
        InternetSetCookieEx(URL, Nothing, CookieStr, 0, 0)
        Dim NewWeb As New WebBrowserNew
        NewWeb.Size = New Size(1024, 768)
        NewWeb.Show()
        NewWeb.WebBrowserNewCtrl.Navigate(URL, False) 'String.Empty, Nothing, "User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; rv:11.0) like Gecko")

        NewWeb.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    Friend Sub NavigateToTarget_wWebDriver(TargetKapu As Kapu, Iranyban As Irany, Optional MilyenFajlt As String = "")
        Dim TargetUrl As String = String.Empty
        Dim BrowserToUse = Kapukezelo.BrowserToUse
        Dim KapuUName As String = String.Empty
        Dim KapuPassw As String = String.Empty
        Me.UKPLoginString = String.Empty '#1
        LoginUKP() '#2
        If Me.UKPLoginString <> String.Empty Then Exit Sub '#3

        If BrowserToUse = BrowserType.None Then
            If Iranyban = Irany.DL And TargetKapu = Kapu.UKP Then
                If Me.UKPLoginString = "Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava" Then Exit Sub
                NavigateToTarget_wWebBrowser(URL_UKP_Beerkezett)
                Exit Sub
            ElseIf Iranyban = Irany.DL And Not TargetKapu = Kapu.UKP Then
                If Me.UKPLoginString = "Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava" Then Exit Sub

                If LoginPKPHKP_wHttpRequest(TargetKapu) = False Then Exit Sub
                If TargetKapu = Kapu.PKP Then TargetUrl = URL_PKP_Beerkezett Else TargetKapu = URL_HKP_Beerkezett
                NavigateToTarget_wWebBrowser(TargetUrl)
                Exit Sub
            Else
                Dim hibauzenet = "A felküldésre használható kapu automatikus megnyitása Windows 10 alatti gépen csak Firefox vagy Chrome böngészővel működik, Internet Explorerrel ezt nem tudja a program automatizálni."
                MsgBox(hibauzenet, MsgBoxStyle.Critical)
                MyLoader.AddLogBook(Fnc.web, hibauzenet, LogTip.err)
                Exit Sub
            End If
        End If
        Dim DriverToGo As IWebDriver = Nothing
        Try
            DriverToGo = Kapukezelo.GetDriver(BrowserToUse)
        Catch ex As Exception
        End Try
        BelepesCookieval(DriverToGo)'#4

        'BelepesUKPval(DriverToGo)
        If IsNothing(DriverToGo) Then Exit Sub

        If TargetKapu = Kapu.UKP Then
            If MilyenFajlt <> String.Empty Or Iranyban = Irany.UL Then UploadwWebDriver(MilyenFajlt, DriverToGo, TargetKapu) Else DriverToGo.Navigate.GoToUrl(URL_UKP_Beerkezett)
            MsgBox("Ha befejezte a kapu kezelését, kattintson az OK gombra itt!" & Environment.NewLine & "(Addig nem tud új ablakot megnyitni)", MsgBoxStyle.ApplicationModal & MsgBoxStyle.OkOnly)
            Try
                DriverToGo.Quit()
            Catch
            End Try
            Exit Sub
        End If

        If TargetKapu = Kapu.PKP Then
            TargetUrl = URL_PKP_Beerkezett
            KapuUName = Kapukezelo.Decrypt(My.Settings.PKPUName, "PKPUName")
            KapuPassw = Kapukezelo.Decrypt(My.Settings.PKPPassw, "PKPPassw")
        ElseIf TargetKapu = Kapu.HKP Then
            TargetUrl = URL_HKP_Beerkezett
            KapuUName = Kapukezelo.Decrypt(My.Settings.HKPUName, "HKPUName")
            KapuPassw = Kapukezelo.Decrypt(My.Settings.HKPPassw, "HKPPassw")
        End If

        If KapuUName = "" Or KapuPassw = "" Then
            KapuUserNamePasswForm.ShowDialog(Me)
            If KapuUName = "" Or KapuPassw = "" Then
                Try
                    DriverToGo.Quit()
                Catch ex As Exception
                End Try
                Exit Sub
            End If
        End If
        Try

            Dim wait As New WebDriverWait(DriverToGo, TimeSpan.FromSeconds(10))

            If Not IsNothing(DriverToGo) Then DriverToGo.Navigate().GoToUrl(TargetUrl)
            Try
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("fldUser")))
            Catch ex As Exception
                ExitwError(DriverToGo, "Weboldal betöltési hiba (perkapu neve)")
                Exit Sub
            End Try

            Dim offname = DriverToGo.FindElement(By.Id("fldUser"))
            offname.SendKeys(KapuUName)

            Try
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("fldPass")))
            Catch ex As Exception
                ExitwError(DriverToGo, "Weboldal betöltési hiba (perkapu jelszó)")
                Exit Sub
            End Try
            Dim passname = DriverToGo.FindElement(By.Id("fldPass"))
            passname.SendKeys(KapuPassw)

            Try
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("btnUKLogin")))
            Catch ex As Exception
                ExitwError(DriverToGo, "Weboldal betöltési hiba (perkapu login gomb)")
                Exit Sub

            End Try
            Dim sendit = DriverToGo.FindElement(By.Id("btnUKLogin"))
            sendit.Click()
            Thread.Sleep(1500)
        Catch ex As Exception
        End Try

        If MilyenFajlt <> String.Empty Or Iranyban = Irany.UL Then UploadwWebDriver(MilyenFajlt, DriverToGo, TargetKapu)
        MsgBox("Ha befejezte a kapu kezelését, kattintson az OK gombra itt!" & Environment.NewLine & "(Addig nem tud új ablakot megnyitni)", MsgBoxStyle.ApplicationModal & MsgBoxStyle.OkOnly)
        If Not IsNothing(DriverToGo) Then
            Try
                DriverToGo.Quit()
            Catch
            End Try

        End If
    End Sub
    Private Sub ExitwError(DriverToGo As IWebDriver, Msg As String)
        If Not IsNothing(DriverToGo) Then DriverToGo.Quit()
        Dim uzenet = Msg
        MyLoader.AddLogBook(Fnc.web, uzenet, LogTip.err)
    End Sub
    Private Sub BelepesCookieval(DriverToGo As IWebDriver)
        If Me.UKPLoginString <> String.Empty Or UKPSzolgCookie.Name = String.Empty Or SSOCookie.Name = String.Empty Then
            DriverToGo.Navigate().GoToUrl("https://www.magyarorszag.hu")
            Try
                DriverToGo.Manage.Cookies.DeleteAllCookies()
            Catch ex As Exception
            End Try
            Dim hibauzenet = "Az ügyfélkapu bejelentkezés nem volt sikeres!"
            MsgBox(hibauzenet, MsgBoxStyle.Critical & MsgBoxStyle.ApplicationModal)
            MyLoader.AddLogBook(Fnc.web, hibauzenet, LogTip.err)
            Try
                DriverToGo.Quit()
            Catch ex As Exception
            End Try
            Exit Sub
        End If
        Try
            DriverToGo.Navigate().GoToUrl("https://ugyfelkapu.magyarorszag.hu")
        Catch ex As System.Net.WebException
            MyLoader.AddLogBook(Fnc.web, "Weboldal megnyitási hiba: " & ex.Message, LogTip.err)
        Catch ex2 As Exception
            MyLoader.AddLogBook(Fnc.web, "Weboldal megnyitási egyéb hiba: " & ex2.GetType.ToString & " " & ex2.Message, LogTip.err)
        End Try
        Dim selencookie As OpenQA.Selenium.Cookie = New OpenQA.Selenium.Cookie(UKPSzolgCookie.Name, UKPSzolgCookie.Value, domain:=UKPSzolgCookie.Domain, path:=UKPSzolgCookie.Path, expiry:=Now.AddMonths(1))
        Try
            DriverToGo.Manage.Cookies.AddCookie(selencookie)
            selencookie = New OpenQA.Selenium.Cookie(SSOCookie.Name, SSOCookie.Value, domain:=SSOCookie.Domain, path:=SSOCookie.Path, expiry:=Now.AddMonths(1))
            DriverToGo.Manage.Cookies.AddCookie(selencookie)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BelepesUKPval(DriverToGo As IWebDriver)
        If IsNothing(DriverToGo) Then Exit Sub
        Dim elemtoclick As IWebElement = Nothing
        Dim UKPUName = Kapukezelo.Decrypt(My.Settings.UKPUName, "UKPUName")
        Dim UKPPassw = Kapukezelo.Decrypt(My.Settings.UKPPassw, "UKPPassw")
        Dim wait
        Try
            wait = New WebDriverWait(DriverToGo, TimeSpan.FromSeconds(10))
        Catch ex As Exception
            Try
                If Not IsNothing(DriverToGo) Then DriverToGo.Quit()
            Catch ex1 As Exception
            End Try
            Exit Sub
        End Try

        If String.IsNullOrEmpty(UKPUName) Or String.IsNullOrEmpty(UKPPassw) Then
            ExitwError(DriverToGo, "Ügyfélkapu felhasználónév vagy jelszó nincsen megadva")
            Exit Sub
        End If

        If IsNothing(DriverToGo) Then
            MsgBox("Hiba miat nem sikerült a böngészőt megnyitni", MsgBoxStyle.ApplicationModal & MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Try
            DriverToGo.Navigate.GoToUrl(URL_GateGovHu)
        Catch ex As Exception
            MsgBox("Hiba miat nem sikerült a böngészőt megnyitni", MsgBoxStyle.ApplicationModal & MsgBoxStyle.OkOnly)
            Exit Sub
        End Try

        Try
            'wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id=""fldUser""]")))
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("fldUser")))
        Catch ex As Exception
            ExitwError(DriverToGo, "Weboldal betöltési hiba (ügyfélkapu neve mező)")
            Exit Sub
        End Try

        Dim offname = DriverToGo.FindElement(By.Id("fldUser"))
        offname.SendKeys(UKPUName)
        Try
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("fldPass")))
        Catch ex As Exception
            ExitwError(DriverToGo, "Weboldal betöltési hiba (ügyfélkapu jelszó mező)")
            Exit Sub
        End Try
        Dim passname = DriverToGo.FindElement(By.Id("fldPass"))
        passname.SendKeys(UKPPassw)

        Dim UKPLoginBtn As String = "//*[@id=""frmUKLogin""]/fieldset/span[3]/input"
        Try
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(UKPLoginBtn)))
        Catch ex As Exception
            ExitwError(DriverToGo, "Weboldal betöltési hiba (ügyfélkapu login gomb)")
            Exit Sub
        End Try

        For i As Integer = 0 To 1
            Try
                elemtoclick = DriverToGo.FindElement(By.XPath(UKPLoginBtn))
                elemtoclick.Click()
                Exit For
            Catch ex As Exception
            End Try
        Next

    End Sub

    Private Sub UploadwWebDriver(MilyenFajlt As String, DriverToGo As IWebDriver, TargetKapu As Kapu)
        Dim TargetUrl = String.Empty
        Select Case TargetKapu
            Case Kapu.UKP
                TargetUrl = URL_UKP_Kuldes
            Case Kapu.PKP
                TargetUrl = URL_PKP_Kuldes
            Case Kapu.HKP
                TargetUrl = URL_HKP_Kuldes
        End Select
        Dim wait As New WebDriverWait(DriverToGo, TimeSpan.FromSeconds(10))
        DriverToGo.Navigate().GoToUrl(TargetUrl)

        Dim elemtoclick As IWebElement = Nothing

        Select Case TargetKapu
            Case Kapu.UKP
                'elemtoclick = DriverToGo.FindElement(By.XPath("//*[@id=""upload""]/div[2]/button[1]"))
                For i As Integer = 0 To 1
                    Try
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id=""upload""]/div[2]/button[1]")))
                        elemtoclick = DriverToGo.FindElement(By.XPath("//*[@id=""upload""]/div[2]/button[1]"))
                        'elemtoclick = DriverToGo.FindElement(By.Id("upload"))
                        elemtoclick.Click()
                        Exit For
                        Catch ex As Exception
                        End Try
                Next
            Case Kapu.PKP, Kapu.HKP
                'elemList = DriverToGo.FindElements(By.TagName("input")) '
                For i As Integer = 0 To 1
                    Try
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("feltoltendoFajl")))
                        elemtoclick = DriverToGo.FindElement(By.Id("feltoltendoFajl"))
                        elemtoclick.Click()
                        Exit For
                    Catch ex As Exception
                    End Try
                Next
        End Select


    End Sub


    Private Shared Function GetDriver(Type As BrowserType) As IWebDriver
        Dim options As DriverOptions = Nothing
        Dim service As DriverService = Nothing
        Dim driver As IWebDriver = Nothing

        Select Case Type
            Case BrowserType.FF
                Try
                    options = New FirefoxOptions()
                    service = FirefoxDriverService.CreateDefaultService()
                    'service.SuppressInitialDiagnosticInformation = False
                    service.HideCommandPromptWindow = True
                    driver = New FirefoxDriver(service:=service, options:=options, commandTimeout:=TimeSpan.FromSeconds(20))
                Catch ex As Exception
                End Try
            Case BrowserType.Google
                Try
                    options = New ChromeOptions()
                    service = ChromeDriverService.CreateDefaultService()
                    'service.SuppressInitialDiagnosticInformation = False
                    service.HideCommandPromptWindow = True
                    driver = New ChromeDriver(service:=service, options:=options)
                Catch ex As Exception
                End Try

            Case BrowserType.Edge
                Try
                    options = New EdgeOptions
                    service = EdgeDriverService.CreateDefaultService()
                    service.HideCommandPromptWindow = True
                    driver = New EdgeDriver(service:=service, options:=options)
                Catch ex As Exception
                End Try
        End Select
        If Not IsNothing(driver) Then
            Return driver
            Try
                driver.Quit()
            Catch ex As Exception
            End Try
        Else Return Nothing
        End If
    End Function

    Shared Function BrowserToUse() As BrowserType

        Dim BrowsersInstalled = Kapukezelo.GetBrowserInstalled
        Select Case My.Settings.BrowserPreferred
            Case "Google Chrome"
                If BrowsersInstalled.ContainsKey("Google Chrome") Then BrowserToUse = BrowserType.Google
            Case "Mozilla Firefox"
                If BrowsersInstalled.ContainsKey("Mozilla Firefox") Then BrowserToUse = BrowserType.FF
            Case "Microsoft Edge"
                If BrowsersInstalled.ContainsKey("Microsoft Edge") Then BrowserToUse = BrowserType.Edge
            Case Else
                If BrowsersInstalled.ContainsKey("Microsoft Edge") Then BrowserToUse = BrowserType.Edge
                If BrowsersInstalled.ContainsKey("Mozilla Firefox") Then BrowserToUse = BrowserType.FF
                If BrowsersInstalled.ContainsKey("Google Chrome") Then BrowserToUse = BrowserType.Google
        End Select
        If BrowserToUse = BrowserType.Edge Then
            Dim orig As String = "MicrosoftWebDriver.exe"
            If File.Exists(orig) Then
                Try
                    File.Delete(orig)
                Catch ex As Exception
                    MyLoader.AddLogBook(Fnc.web, "MicrosoftWebDriver.exe törlési hiba (" & ex.Message & ")", LogTip.norm)
                End Try
            End If
            Dim source As String = "MicrosoftWebDriver_"
            Select Case Environment.OSVersion.Version.Build
                Case "15063"
                    source += "15063" & ".exe"
                Case "14393"
                    source += "14393" & ".exe"
                Case "10586"
                    source += "10586" & ".exe"
                Case "10240"
                    source += "10240" & ".exe"
                Case Else
                    Dim hibauzenet = "Az Ön Windows 10 verziója " & "(" & Environment.OSVersion.Version.Build.ToString & ") meghajtásához nem tartalmazza a program a WebDrivert. Jelezze az ügyfélszolgálatnak, addig Google Chrome vagy Firefoxot használhat csak a program."
                    If BrowsersInstalled.ContainsKey("Mozilla Firefox") Then BrowserToUse = BrowserType.FF
                    If BrowsersInstalled.ContainsKey("Google Chrome") Then BrowserToUse = BrowserType.Google
            End Select
            If File.Exists(source) Then
                Try
                    File.Copy(source, orig)
                Catch ex As Exception
                    MyLoader.AddLogBook(Fnc.web, "MicrosoftWebDriver.exe másolási hiba (" & ex.Message & ")", LogTip.norm)
                End Try
            End If
        End If

        If IsNothing(BrowserToUse) Then BrowserToUse = BrowserType.None
        Return BrowserToUse
    End Function

    Shared Function GetBrowserInstalled() As Dictionary(Of String, String)
        'forrás: http://www.rhizohm.net/irhetoric/post/2009/04/03/0a-Finding-All-Installed-Browsers-in-Windows-XP-and-Vista-ndash3b-beware-64bit!0a-.aspx alapján
        Dim browserKeys As RegistryKey
        Dim response As New Dictionary(Of String, String)

        Try
            browserKeys = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Clients\StartMenuInternet")
            If browserKeys Is Nothing Then
                browserKeys = Registry.LocalMachine.OpenSubKey("SOFTWARE\Clients\StartMenuInternet")
            End If
        Catch ex As Exception
            MyLoader.AddLogBook(Fnc.web, "Browser registry entry nem találja", LogTip.err)
            Return response
        End Try

        Dim browserNames As String() = browserKeys.GetSubKeyNames()
        For i As Integer = 0 To browserNames.Length - 1
            Dim browserKey As RegistryKey = browserKeys.OpenSubKey(browserNames(i))
            Dim browserKeyPath As RegistryKey = browserKey.OpenSubKey("shell\open\command")
            response.Add(browserKey.GetValue(Nothing).ToString, browserKeyPath.GetValue(Nothing).ToString)
        Next
        If Environment.OSVersion.Version.Major.ToString = 10 Then
            response.Add("Microsoft Edge", "MicrosoftWebDriver_" & Environment.OSVersion.Version.Build.ToString & ".exe")
        End If
        Return response
    End Function


    Public Shared Function Encrypt(password As String, salt As String) As String
        Dim passwordBytes As Byte() = Encoding.Unicode.GetBytes(password)
        Dim saltBytes As Byte() = Encoding.Unicode.GetBytes(salt)

        Dim cipherBytes As Byte() = ProtectedData.Protect(passwordBytes, saltBytes, DataProtectionScope.CurrentUser)
        Return Convert.ToBase64String(cipherBytes)
    End Function

    Public Shared Function Decrypt(cipher As String, salt As String) As String
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipher)
        Dim saltBytes As Byte() = Encoding.Unicode.GetBytes(salt)

        If cipher <> String.Empty Then
            Try
                Dim passwordBytes As Byte() = ProtectedData.Unprotect(cipherBytes, saltBytes, DataProtectionScope.CurrentUser)
                Return Encoding.Unicode.GetString(passwordBytes)
            Catch ex As Exception
                Dim saltdekod As String = String.Empty
                Select Case Strings.Left(salt, 3)
                    Case "UKP"
                        saltdekod = "Ügyfélkapu"
                    Case "PKP"
                        saltdekod = "Perkapu"
                    Case "HKP"
                        saltdekod = "Hivatali kapu"
                    Case "TSU"
                        saltdekod = "Időbélyeg szolgáltatási felhasználónév"
                    Case "TSP"
                        saltdekod = "Időbélyeg szolgáltatási jelszó"
                End Select
                If Strings.Right(salt, 5) = "UName" Then saltdekod += " felhasználónév" Else saltdekod += " jelszó"
#If Not ARCONSULT = "Y" Then
                Dim uzenet As String = saltdekod + " beolvasási hiba! A hibát az okozhatta, hogy a beállításokat más felhasználó olvasta be (más gépen), mint ahova eredetileg létrehozták, vagy sérült a beállításokat tartalmazó fájl. A jelszavakat és felhasználóneveket törlöm. Adja meg újból az adatot a megfelelő menüpontban!"
                ANYHelpModule.PasswordDeleteAllShared()
                My.Settings.Save()
                MsgBox(uzenet)
                MyLoader.AddLogBook(Fnc.cfg, uzenet, LogTip.err)
#End If
                Return ""
            End Try
        Else Return ""
        End If
    End Function
    Friend Shared Function ExportKapuDataToStr() As String
        Dim OutputStr As String = String.Empty
        If My.Settings.UKPUName <> "" Then OutputStr += "Ügyfélkapu felhasználónév: " & Kapukezelo.Decrypt(My.Settings.UKPUName, "UKPUName") & Environment.NewLine
        If My.Settings.UKPPassw <> "" Then OutputStr += "Ügyfélkapu jelszó: " & Kapukezelo.Decrypt(My.Settings.UKPPassw, "UKPPassw") & Environment.NewLine
        If My.Settings.PKPUName <> "" Then OutputStr += "Perkapu felhasználónév: " & Kapukezelo.Decrypt(My.Settings.PKPUName, "PKPUName") & Environment.NewLine
        If My.Settings.PKPPassw <> "" Then OutputStr += "Perkapu jelszó: " & Kapukezelo.Decrypt(My.Settings.PKPPassw, "PKPPassw") & Environment.NewLine
        If My.Settings.HKPUName <> "" Then OutputStr += "Hivatali kapu felhasználónév: " & Kapukezelo.Decrypt(My.Settings.HKPUName, "HKPUName") & Environment.NewLine
        If My.Settings.HKPPassw <> "" Then OutputStr += "Hivatali kapu jelszó: " & Kapukezelo.Decrypt(My.Settings.HKPPassw, "HKPPassw") & Environment.NewLine
        If My.Settings.PkeyPassw <> "" Then OutputStr += "Saját kititkosító kulcshoz jelszó: " & Kapukezelo.Decrypt(My.Settings.PkeyPassw, "PkeyPassw") & Environment.NewLine
        If My.Settings.TSUN <> "" Then OutputStr += "Időbélyeg hozzáférési felhasználónév: " & Kapukezelo.Decrypt(My.Settings.TSUN, "TSUN") & Environment.NewLine
        If My.Settings.TSPW <> "" Then OutputStr += "Időbélyeg hozzáférési jelszó: " & Kapukezelo.Decrypt(My.Settings.TSPW, "TSPW") & Environment.NewLine
        Return OutputStr
    End Function

    Friend Shared Sub ExportKapu()
        Dim dialogresult As New DialogResult
        Dim ValasztottFajl = String.Empty
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim OutputStr As String = Kapukezelo.ExportKapuDataToStr
        saveFileDialog1.Filter = "Szöveges fájl|*.txt"
        saveFileDialog1.Title = "Válassza ki, hogy hova és milyen néven menti az exportált felhasználónév és jelszó gyűjteményt!"
        saveFileDialog1.RestoreDirectory = True
        If Directory.Exists(My.Settings.AccessibleUserSettings) Then
            saveFileDialog1.InitialDirectory = My.Settings.AccessibleUserSettings
            saveFileDialog1.FileName = saveFileDialog1.InitialDirectory & System.IO.Path.DirectorySeparatorChar & Environment.UserName & "_kapu.txt"
        End If
        saveFileDialog1.DefaultExt = "txt"
        dialogresult = saveFileDialog1.ShowDialog()
        If dialogresult = DialogResult.OK Then
            ValasztottFajl = saveFileDialog1.FileName
            File.WriteAllText(ValasztottFajl, OutputStr, System.Text.Encoding.UTF8)
        End If
    End Sub


    Public Shared Function SupressCookiePersist() As Boolean
        ' 3 = INTERNET_SUPPRESS_COOKIE_PERSIST 
        ' 81 = INTERNET_OPTION_SUPPRESS_BEHAVIOR
        Return SetOption(81, 3)
    End Function

    Public Shared Function EndBrowserSession() As Boolean
            ' 42 = INTERNET_OPTION_END_BROWSER_SESSION 
            Return SetOption(42, Nothing)
        End Function

    Private Shared Function SetOption(settingCode As Integer, [option] As System.Nullable(Of Integer)) As Boolean
        Dim optionPtr As IntPtr = IntPtr.Zero
        Dim size As Integer = 0
        If [option].HasValue Then
            size = 4
            optionPtr = Marshal.AllocCoTaskMem(size)
            Marshal.WriteInt32(optionPtr, [option].Value)
        End If

        Dim success As Boolean = InternetSetOption(0, settingCode, optionPtr, size)

        If optionPtr <> IntPtr.Zero Then
            Marshal.Release(optionPtr)
        End If
        Return success
    End Function

    <DllImport("wininet.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
        Private Shared Function InternetSetOption(hInternet As Integer, dwOption As Integer, lpBuffer As IntPtr, dwBufferLength As Integer) As Boolean
        End Function

    Private Function UrlEncodeforKapu(Input As String) As String
        'Dim responseUrlEncodeNormal As String = String.Empty
        'responseUrlEncodeNormal = Web.HttpUtility.UrlEncode(Input)
        'UrlEncodeforKapu = JavUrlforKapu(responseUrlEncodeNormal)
        UrlEncodeforKapu = System.Net.WebUtility.UrlEncode(Input)
        UrlEncodeforKapu.Replace("!", "%21")
        UrlEncodeforKapu.Replace("(", "%28")
        UrlEncodeforKapu.Replace(")", "%29")
        Return UrlEncodeforKapu
    End Function
    Private Function JavUrlforKapu(Input As String) As String
        JavUrlforKapu = String.Empty
        For i = 0 To Input.Length - 1
            If Input(i) = "%" Then
                JavUrlforKapu += Input.Substring(i, 3).ToUpper
                i += 2
            Else JavUrlforKapu += Input(i)
            End If
        Next
    End Function

    Friend Sub FeltoltesPKP(FileName As String)
        'Nem működik!


        If File.Exists(FileName) And System.IO.Path.GetExtension(FileName) = ".kr" Then
            Dim CimzettStr As String = LoadDatafromKRandXKR.extractKRCimzettSzervezet(FileName)
            Dim DoktipusAzonosito As String = LoadDatafromKRandXKR.extractKRDokTipusAzonosito(FileName)
            Dim DoktipusLeiras As String = LoadDatafromKRandXKR.extractKRDokTipusLeiras(FileName)
            Dim kiir As String = "Feltöltsem az alapértelmezett perkapuba (" & Kapukezelo.Decrypt(My.Settings.PKPUName, "PKPUName") & ") a következő KR-csomagot?"
            kiir += "Címzett: " & CimzettStr & Environment.NewLine
            kiir += "Dokumentum azonosítója: " & DoktipusAzonosito & Environment.NewLine
            kiir += "Dokumentum leírása: " & DoktipusLeiras & Environment.NewLine
            kiir += "XML nyomtatványfájl neve: " & LoadDatafromKRandXKR.extractKRFileNev(FileName)
            Dim dialogresult As New DialogResult
            dialogresult = MsgBox(kiir, MsgBoxStyle.YesNo)
            If dialogresult = MsgBoxResult.No Then Exit Sub

            LoginUKP()
            If Me.UKPLoginString = "Hibás az ügyfélkapu megadott felhasználóneve vagy jelszava" Then
                MyLoader.AddLogBook(Fnc.web, Me.UKPLoginString, LogTip.err)
                Exit Sub
            End If
            If Not LoginPKPHKP_wHttpRequest(Kapu.PKP) Then
                MyLoader.AddLogBook(Fnc.web, "Nem sikerült a perkapuba belépni", LogTip.err)
                Exit Sub
            End If
            'Dim FeltoltoPrep As New HttpReqResUKP(TargetUri:=New Uri("https://ugyfelkapu.magyarorszag.hu/mohu_portlet_krportlet/applet/bcprov-ext-jdk15on-1.54.jar"), mJar:=SSOJar, UserAgent:="Mozilla/4.0 (Windows 10 10.0) Java/1.8.0_101", Accept:="text/html, image/gif, image/jpeg, *; q=.2, */*; q=.2", ContentType:="application/x-java-archive")
            'FeltoltoPrep.GetHttp()
            'FeltoltoPrep.GetResponse()
            'WriteRespToFile("D:\tmp\bcprov-ext-jdk15on-1.54.jar", FeltoltoPrep.ResponseSt.GetResponseStream)

            'Dim FeltP2 = DirectCast(HttpWebRequest.Create("https://ugyfelkapu.magyarorszag.hu/mohu_portlet_krportlet/ui/office"), HttpWebRequest)
            'FeltP2.ContentType = "application/x-java-serialized-object"
            'FeltP2.CookieContainer = SSOJar
            'FeltP2.KeepAlive = True
            'FeltP2.UserAgent = "Mozilla/5.0 (Windows 10 10.0) Java/1.8.0_101"
            'FeltP2.Accept = "text/html, image/gif, image/jpeg, *; q=.2, */*; q=.2"
            'FeltP2.Headers.Add("function", "getShortnames")

            'Dim KRSessionCookie As New Cookie("JSESSIONID", UKPSzolgCookie.Value, "/", "ugyfelkapu.magyarorszag.hu")
            'NavigateToTarget(URL_PKP_Kuldes)

            Dim KRUploadJar As New CookieContainer
            'KRUploadJar.Add(KRSessionCookie)
            KRUploadJar.Add(SSOCookie)
            KRUploadJar.Add(UKPSzolgCookie)
            Dim R1 As New HttpReqResUKP(Uri_PKP_Kuldes, KRUploadJar, 5, "ugyfelkapu.magyarorszag.hu", "https://ugyfelkapu.magyarorszag.hu/eperkapu/dokumentumok",, "text/html, application/xhtml+xml, image/jxr, */*")
            '            Trace.WriteLine("R1TargetUri: " + R1.TargetUri.ToString)
            R1.GetHttp()
            R1.GetResponse()
            R1.GetResponse.Close()
            Dim bndry As String = "---------------------------7e026b1a120872"
            Dim FeltoltoReq As New HttpReqResUKP(Uri_PKP_Feltoltes, KRUploadJar, 0, "ugyfelkapu.magyarorszag.hu", "https://ugyfelkapu.magyarorszag.hu/eperkapu/feltoltes", "multipart/form-data; boundary=" & bndry, "text/html, application/xhtml+xml, image/jxr, */*")

            Dim felsb As New StringBuilder
            bndry += Environment.NewLine & "Content-Disposition: form-data; name=" & Chr(34)
            felsb.Append(bndry).AppendLine("fajlFeltoltesEredmenyek" & Chr(34)).AppendLine.AppendLine()
            felsb.Append(bndry).AppendLine("feltoltendoFajl" & Chr(34) & "; filename=" & Chr(34) & System.IO.Path.GetFileName(FileName) & Chr(34))
            felsb.AppendLine("Content-Type: application/octet-stream" & Environment.NewLine)
            Try
                ' Open the file using a stream reader.
                Using sr As New StreamReader(FileName)
                    Dim line As String
                    line = sr.ReadToEnd()
                    felsb.AppendLine(line)
                End Using
            Catch e As Exception
                MsgBox("Hiányzik a megadott KR-fájl!")
                Console.WriteLine(e.Message)
            End Try
            felsb.AppendLine(bndry).AppendLine("cimzettHivatalRovidNev").AppendLine.AppendLine(CimzettStr)
            felsb.AppendLine(bndry).AppendLine("dokumentumTipusAzon").AppendLine.AppendLine(DoktipusAzonosito)
            felsb.AppendLine(bndry).AppendLine("dokumentumTipusLeiras").AppendLine.AppendLine(DoktipusLeiras)
            felsb.AppendLine(bndry).AppendLine("trcode").AppendLine.AppendLine("3")

            'felsb.Append(bndry).AppendLine("request-copy" & Chr(34)).AppendLine.AppendLine("true")
            'felsb.Append(bndry).AppendLine("request-encryptedresponse" & Chr(34)).AppendLine.AppendLine("false")
            'felsb.Append(bndry).AppendLine("notification" & Chr(34)).AppendLine.AppendLine("mailbox")
            felsb.AppendLine("-----------------------------7e026b1a120872--")
            '---------------------------7e035f16120872
            '            Content-Disposition: Form-Data; name="cimzettHivatalRovidNev"

            'HOMOKIUI
            '-----------------------------7e035f16120872
            'Content-Disposition: Form-Data; name="dokumentumTipusAzon"

            '            MUK_K01
            '-----------------------------7e035f16120872
            'Content-Disposition: Form-Data; name="dokumentumTipusLeiras"

            '            MUK_K01
            '-----------------------------7e035f16120872
            'Content-Disposition: Form-Data; name="trcode"

            FeltoltoReq.PostHttp(felsb.ToString)
            FeltoltoReq.GetResponse()
            Dim ResponseText As String
            Using reader = New System.IO.StreamReader(FeltoltoReq.ResponseSt.GetResponseStream, Encoding.UTF8)
                ResponseText = reader.ReadToEnd()
            End Using
            'If ResponseText.Contains("Sikertelen bejelentkezés!") Then
            'Dim hiba = "Hibás az ügyfélkapu megadott/beállított felhasználóneve vagy jelszava"
            FeltoltoReq.GetResponse.Close()
            'MyLoader.AddLogBook(Fnc.web, "gate.gov.hu cookie rendben", LogTip.norm)


            'Válasz? Visszajelzés?
        End If
    End Sub

End Class
