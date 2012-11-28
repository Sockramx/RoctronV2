Public Class rPedido

    Private Sub rPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbPremiereProductsDataSet.tPedido' Puede moverla o quitarla según sea necesario.
        Me.tPedidoTableAdapter.Fill(Me.dbPremiereProductsDataSet.tPedido)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class