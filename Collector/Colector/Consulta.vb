Public Class Consulta

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ColectoresConsTableAdapter.Fill(Me.ColectorDataSet.ColectoresCons)

    End Sub
End Class