Public Class Form3
    ' Codigo para mover la ventana.
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
    ' fin del codigo.
    Private Sub TotalRegistros()
        sSQL = "SELECT COUNT(*) AS totalRegistros FROM tArticulo;"
        oComando.CommandText = sSQL
        oConexion.Open()
        lblTotalRegistros.Text = "Total de Registros: " & oComando.ExecuteScalar
        oConexion.Close()
    End Sub
    Private Sub LimpiarControles()
        txtcodiArti.Text = ""
        txtdescripArti.Text = ""
        txtstockArti.Text = ""
        cmbclaseArti.Text = ""
        cmbalmaArti.Text = ""
        txtprecioUArti.Text = ""
    End Sub
    Private Sub LlenarGrid()
        Select Case cmbBuscarPor.SelectedIndex
            Case 0
                sSQL = "SELECT codiArti, descripArti FROM tArticulo ORDER BY codiArti;"
            Case 1
                sSQL = "SELECT codiArti, descripArti FROM tArticulo ORDER BY descripArti;"
        End Select
        dgvArticulo.Rows.Clear()
        oComando.CommandText = sSQL
        oConexion.Open()
        oDataReader = oComando.ExecuteReader
        While oDataReader.Read()
            dgvArticulo.Rows.Add(oDataReader("codiArti"), oDataReader("descripArti"))
        End While
        oConexion.Close()
    End Sub

    Private Sub MostrarArticulo()
        sSQL = "SELECT * FROM tArticulo WHERE codiArti = '" & dgvArticulo.CurrentRow.Cells.Item(0).Value & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        oDataReader = oComando.ExecuteReader
        If oDataReader.Read() Then
            txtcodiArti.Text = oDataReader("codiArti")
            txtdescripArti.Text = oDataReader("descripArti")
            txtstockArti.Text = oDataReader("stockArti")
            cmbclaseArti.Text = oDataReader("claseArti")
            cmbalmaArti.Text = oDataReader("almaArti")
            txtprecioUArti.Text = oDataReader("precioUArti")
        End If
        oConexion.Close()
    End Sub

    Private Sub frmArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbBuscarPor.SelectedIndex = 0
        LlenarGrid()
        TotalRegistros()
    End Sub

    Private Sub cmbBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBuscarPor.SelectedIndexChanged
        LlenarGrid()
        txtBuscar.Focus()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            MostrarArticulo()
        End If
    End Sub

    Private Sub ubicaFilaGrid(ByVal nombreCampo As String, ByVal sTexto As String)
        Dim Fila As DataGridViewRow
        For Each Fila In dgvArticulo.Rows
            If LCase(Fila.Cells(nombreCampo).Value) Like LCase(sTexto & "*") Then
                Fila.Selected = True
                dgvArticulo.FirstDisplayedScrollingRowIndex = Fila.Index
                dgvArticulo.CurrentCell = dgvArticulo.Rows(Fila.Index).Cells(0)
                Exit For
            End If
        Next
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If cmbBuscarPor.SelectedIndex = 0 Then ubicaFilaGrid("codiArti", txtBuscar.Text)
        If cmbBuscarPor.SelectedIndex = 1 Then ubicaFilaGrid("descripArti", txtBuscar.Text)
    End Sub

    Private Sub dgvArticulo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArticulo.CellContentClick
        MostrarArticulo()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        LimpiarControles()
        txtcodiArti.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim iExiste As Integer

        sSQL = "SELECT COUNT(*) FROM tArticulo WHERE codiArti = '" & txtcodiArti.Text & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        iExiste = oComando.ExecuteScalar
        oConexion.Close()

        If iExiste = 1 And Len(txtdescripArti.Text) > 0 Then
            sSQL = "UPDATE tArticulo SET descripArti = '" & txtdescripArti.Text & "', stockArti = " & txtstockArti.Text & ", claseArti = '" & cmbclaseArti.Text & "', almaArti = '" & cmbalmaArti.Text & "', precioUArti = " & txtprecioUArti.Text & " WHERE codiArti = '" & txtcodiArti.Text & "';"
            oComando.CommandText = sSQL
            oConexion.Open()
            oComando.ExecuteReader()
            oConexion.Close()
            LlenarGrid()
        ElseIf iExiste = 0 And Len(txtcodiArti.Text) = 4 And Len(txtdescripArti.Text) > 0 Then
            sSQL = "INSERT INTO tArticulo VALUES ('" & txtcodiArti.Text & "','" & txtdescripArti.Text & "'," & Val(txtstockArti.Text) & ",'" & cmbclaseArti.Text & "','" & cmbalmaArti.Text & "'," & Val(txtprecioUArti.Text) & ");"
            oComando.CommandText = sSQL
            oConexion.Open()
            oComando.ExecuteReader()
            oConexion.Close()
            LlenarGrid()
            ubicaFilaGrid("codiArti", txtcodiArti.Text)
        End If
        TotalRegistros()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iExiste As Integer
        sSQL = "SELECT COUNT(*) FROM tDetallePedido WHERE codiArti = '" & txtcodiArti.Text & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        iExiste = oComando.ExecuteScalar
        oConexion.Close()

        If iExiste = 0 Then
            sSQL = "DELETE FROM tArticulo WHERE codiArti = '" & txtcodiArti.Text & "';"
            oComando.CommandText = sSQL
            oConexion.Open()
            iExiste = oComando.ExecuteScalar
            oConexion.Close()
            LlenarGrid()
            LimpiarControles()
        Else
            MsgBox("El Articulo, tiene pedidos asignados", MsgBoxStyle.Exclamation)
        End If
        txtBuscar.Focus()
        TotalRegistros()
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form2.Show()

    End Sub


    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()

    End Sub

    Private Sub SalirToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rArticulo.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class