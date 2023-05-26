Imports System.IO
Imports System.Net
Imports System.Text

Friend Class HttpReqResUKP
    Private request As HttpWebRequest
    Private response As HttpWebResponse

    Public Function GetResponse() As HttpWebResponse
        Try
            response = DirectCast(request.GetResponse, HttpWebResponse)
            ResponseSt = response
            Return response
        Catch ex As System.Net.WebException
            MsgBox("Internet kapcsolati hiba vagy a webkiszolgáló nem válaszol. Kérem ellenőrizze az internet kapcsolat működőképességét, esetleg próbálja meg a weboldalhoz való újbóli csatlakozást.", MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
    Public URL_GateGovHu As String = "https://gate.gov.hu/sso/ap/ApServlet"

    Friend Property mJar As CookieContainer
    Friend Property TargetUri As Uri
    Friend Property ResponseSt As HttpWebResponse = Nothing
    Friend Sub New(TargetUri As Uri)
        request = DirectCast(HttpWebRequest.Create(TargetUri), HttpWebRequest)
    End Sub
    Friend Sub New(TargetUri As Uri, Optional ByRef mJar As CookieContainer = Nothing, Optional AllowAutoRedirect As Byte = 50, Optional HostHeader As String = "", Optional RefererHeader As String = "https://gate.gov.hu/sso/ap/ApServlet", Optional ContentType As String = "application/x-www-form-urlencoded", Optional Accept As String = "text/html, application/xhtml+xml, image/jxr, */*")
        '    Optional UserAgent As String = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko",
        MyClass.New(TargetUri)
        request.ContentType = ContentType
        request.Accept = Accept
        If mJar IsNot Nothing Then request.CookieContainer = mJar
        If AllowAutoRedirect = 0 Then request.AllowAutoRedirect = False
        If AllowAutoRedirect > 0 Then
            request.AllowAutoRedirect = True
            request.MaximumAutomaticRedirections = AllowAutoRedirect
        End If

        request.Referer = RefererHeader
        request.KeepAlive = True
        If HostHeader <> "" Then request.Host = HostHeader
        'request.UserAgent = UserAgent
        request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko"
        request.Headers.Add("Accept-Encoding", "gzip, deflate")
        request.Headers.Add("Accept-Language", "hu-HU")
    End Sub
    Friend Function RedirectUri() As Uri
        Return New Uri(response.Headers("Location"))
    End Function
    Friend Sub GetHttp()
        request.Method = "GET"
    End Sub

    Friend Sub PostHttp(postdata As String)
        request.Method = "POST"
        Dim postBytes As Byte() = Encoding.Default.GetBytes(postdata)
        request.ContentLength = postBytes.Length
        Using postStream As Stream = request.GetRequestStream()
            postStream.Write(postBytes, 0, postBytes.Length)
            postStream.Flush()
        End Using
    End Sub

    Friend Function GetFirstCookie(Domain As Uri) As Cookie
        If response Is Nothing Then
            Return Nothing

        End If
        Dim mCook As String = response.GetResponseHeader("Set-Cookie")
        Dim mCookie As New Cookie
        mCook = mCook.Replace(" ", "")
        mCook = mCook.Split(";"c).First
        Dim Pos = Microsoft.VisualBasic.Strings.InStr(mCook, "=")
        Dim cName = Microsoft.VisualBasic.Strings.Left(mCook, Pos - 1)
        Dim cValue = Microsoft.VisualBasic.Strings.Right(mCook, mCook.Length - Pos)
        mCookie = New Cookie(cName, cValue, "/", Domain.Host)
        Return mCookie

    End Function
    Friend Function GetAllCookie(Domain As Uri) As CookieContainer
        Dim reprs As String = String.Empty
        Dim NewJar As New CookieContainer
        If response Is Nothing Then
            Return Nothing
        End If
        For Each myheader In response.Headers.GetValues("Set-Cookie")
            'MsgBox(myheader.ToString)
            Dim mCookie As New Cookie
            myheader = myheader.Replace(" ", "")
            myheader = myheader.Split(";"c).First
            Dim Pos = Microsoft.VisualBasic.Strings.InStr(myheader, "=")
            Dim cName = Microsoft.VisualBasic.Strings.Left(myheader, Pos - 1)
            Dim cValue = Microsoft.VisualBasic.Strings.Right(myheader, myheader.Length - Pos)
            Try
                mCookie = New Cookie(cName, cValue, "/", Domain.Host)
            Catch
            End Try
            If mCookie IsNot Nothing Then NewJar.Add(mCookie)
        Next
        If NewJar IsNot Nothing Then Return NewJar Else Return Nothing
    End Function

End Class