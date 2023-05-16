

Partial Public Class ColectorDataSet
    Partial Class colectoresDataTable

    End Class

    Partial Class ColectoresConsDataTable

        Private Sub ColectoresConsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PrecintoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
