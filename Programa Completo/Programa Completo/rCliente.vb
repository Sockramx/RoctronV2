Public Class rCliente

    Private Sub rCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbPremiereProductsDataSet.tCliente' Puede moverla o quitarla según sea necesario.
        Me.tClienteTableAdapter.Fill(Me.dbPremiereProductsDataSet.tCliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class