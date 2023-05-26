Imports System.Net

Public Class WebDownload
    Inherits WebClient
    Public Property TempName As String
    Public Property Timeout() As Integer
        Get
            Return m_Timeout
        End Get
        Set
            m_Timeout = Value
        End Set
    End Property
    Private m_Timeout As Integer
    Public Sub New()
        Me.New(60000)
    End Sub

    Public Sub New(timeout As Integer)
        Me.Timeout = timeout
    End Sub
    Protected Overrides Function GetWebRequest(address As Uri) As WebRequest
        Dim request = MyBase.GetWebRequest(address)
        If request IsNot Nothing Then
            request.Timeout = Me.Timeout
        End If
        Return request
    End Function

    Friend Function DownloadFileTask(uri As Uri, tempName As String) As Task
        Return MyBase.DownloadFileTaskAsync(uri, tempName)
    End Function
End Class