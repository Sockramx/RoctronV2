Public Class rVendedores

    Private Sub rVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbPremiereProductsDataSet.tVendedor' Puede moverla o quitarla según sea necesario.
        Me.tVendedorTableAdapter.Fill(Me.dbPremiereProductsDataSet.tVendedor)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class