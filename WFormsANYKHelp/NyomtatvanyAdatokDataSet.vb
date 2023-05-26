

Partial Public Class NyomtatvanyAdatokDataSet
    Partial Public Class KozteruletDataTable
        Private Sub KozteruletDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NevColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
