Public Class rArticulo

    Private Sub rArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbPremiereProductsDataSet.tArticulo' Puede moverla o quitarla según sea necesario.
        Me.tArticuloTableAdapter.Fill(Me.dbPremiereProductsDataSet.tArticulo)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class