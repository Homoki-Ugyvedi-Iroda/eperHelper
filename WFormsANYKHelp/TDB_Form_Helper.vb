Public Class TDB_Form_Helper
    Friend Shared Function SzuletesiIdoValidal(Input As String) As String
        Dim Ev As String = Microsoft.VisualBasic.Left(Input, 4)
        Dim Honap As String = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Mid(Input, 5), 2)
        Dim Nap As String = Microsoft.VisualBasic.Right(Input, 2)
        If CInt(Honap) > 12 Then Honap = "12"
        If CInt(Nap) > 28 Then
            Dim TestDate As Date
            Try
                TestDate = Microsoft.VisualBasic.DateValue(Ev & "." & Honap & "." & Nap)
            Catch
                If TestDate = DateTime.MinValue Then Nap = Replace(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.DateSerial(CInt(Ev), CInt(Honap + 1), 0), 3), ".", "")
            End Try

        End If
        Return Ev & Honap & Nap
    End Function

End Class
