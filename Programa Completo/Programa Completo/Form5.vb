Public Class Form5
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
        sSQL = "SELECT COUNT(*) AS totalRegistros FROM tVendedor;"
        oComando.CommandText = sSQL
        oConexion.Open()
        lblTotalRegistros.Text = "Total de Registros: " & oComando.ExecuteScalar
        oConexion.Close()
    End Sub

    Private Sub LimpiarControles()
        txtcodiVende.Text = ""
        txtapeVende.Text = ""
        txtnombreVende.Text = ""
        txtdirecVende.Text = ""
        txtciudadVende.Text = ""
        txtcomiToVende.Text = ""
        txtporCoVende.Text = ""
    End Sub

    Private Sub LlenarGrid()
        Select Case cmbBuscarPor.SelectedIndex
            Case 0
                sSQL = "SELECT codiVende, apeVende, nombreVende FROM tVendedor ORDER BY codiVende;"
            Case 1
                sSQL = "SELECT codiVende, apeVende, nombreVende FROM tVendedor ORDER BY apeVende;"
            Case 2
                sSQL = "SELECT codiVende, apeVende, nombreVende FROM tVendedor ORDER BY nombreVende;"
        End Select
        dgvVendedor.Rows.Clear()
        oComando.CommandText = sSQL
        oConexion.Open()
        oDataReader = oComando.ExecuteReader
        While oDataReader.Read()
            dgvVendedor.Rows.Add(oDataReader("codiVende"), oDataReader("apeVende"), oDataReader("nombreVende"))
        End While
        oConexion.Close()
    End Sub

    Private Sub MostrarVendedor()
        sSQL = "SELECT * FROM tVendedor WHERE codiVende = '" & dgvVendedor.CurrentRow.Cells.Item(0).Value & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        oDataReader = oComando.ExecuteReader
        If oDataReader.Read() Then
            txtcodiVende.Text = oDataReader("codiVende")
            txtapeVende.Text = oDataReader("apeVende")
            txtnombreVende.Text = oDataReader("nombreVende")
            txtdirecVende.Text = oDataReader("direcVende")
            txtciudadVende.Text = oDataReader("ciudadVende")
            txtcomiToVende.Text = oDataReader("comiToVende")
            txtporCoVende.Text = oDataReader("porCoVende")
        End If
        oConexion.Close()
    End Sub


    Private Sub frmVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            MostrarVendedor()
        End If
    End Sub

    Private Sub ubicaFilaGrid(ByVal nombreCampo As String, ByVal sTexto As String)
        Dim Fila As DataGridViewRow
        For Each Fila In dgvVendedor.Rows
            If LCase(Fila.Cells(nombreCampo).Value) Like LCase(sTexto & "*") Then
                Fila.Selected = True
                dgvVendedor.FirstDisplayedScrollingRowIndex = Fila.Index
                dgvVendedor.CurrentCell = dgvVendedor.Rows(Fila.Index).Cells(0)
                Exit For
            End If
        Next
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If cmbBuscarPor.SelectedIndex = 0 Then ubicaFilaGrid("codiVende", txtBuscar.Text)
        If cmbBuscarPor.SelectedIndex = 1 Then ubicaFilaGrid("apeVende", txtBuscar.Text)
        If cmbBuscarPor.SelectedIndex = 2 Then ubicaFilaGrid("nombreVende", txtBuscar.Text)
    End Sub

    Private Sub dgvVendedor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVendedor.CellContentClick
        MostrarVendedor()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        LimpiarControles()
        txtcodiVende.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim iExiste As Integer

        sSQL = "SELECT COUNT(*) FROM tVendedor WHERE codiVende = '" & txtcodiVende.Text & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        iExiste = oComando.ExecuteScalar
        oConexion.Close()

        If iExiste = 1 And Len(txtapeVende.Text) > 0 And Len(txtnombreVende.Text) > 0 Then
            sSQL = "UPDATE tVendedor SET apeVende = '" & txtapeVende.Text & "', nombreVende = '" & txtnombreVende.Text & "', direcVende = '" & txtdirecVende.Text & "', ciudadVende = '" & txtciudadVende.Text & "', comiToVende = " & txtcomiToVende.Text & ", porCoVende = " & txtporCoVende.Text & " WHERE codiVende = '" & txtcodiVende.Text & "';"
            oComando.CommandText = sSQL
            oConexion.Open()
            oComando.ExecuteReader()
            oConexion.Close()
            LlenarGrid()
            ubicaFilaGrid("codiVende", txtcodiVende.Text)
        ElseIf iExiste = 0 And Len(txtcodiVende.Text) = 2 And Len(txtapeVende.Text) > 0 And Len(txtnombreVende.Text) > 0 Then
            sSQL = "INSERT INTO tVendedor VALUES ('" & txtcodiVende.Text & "','" & txtapeVende.Text & "','" & txtnombreVende.Text & "','" & txtdirecVende.Text & "','" & txtciudadVende.Text & "'," & Val(txtcomiToVende.Text) & "," & Val(txtporCoVende.Text) & ");"
            oComando.CommandText = sSQL
            oConexion.Open()
            oComando.ExecuteReader()
            oConexion.Close()
            LlenarGrid()
            ubicaFilaGrid("codiVende", txtcodiVende.Text)
        End If
        TotalRegistros()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iExiste As Integer
        sSQL = "SELECT COUNT(*) FROM tCliente WHERE codiVende = '" & txtcodiVende.Text & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        iExiste = oComando.ExecuteScalar
        oConexion.Close()

        If iExiste = 0 Then
            sSQL = "DELETE FROM tVendedor WHERE codiVende = '" & txtcodiVende.Text & "';"
            oComando.CommandText = sSQL
            oConexion.Open()
            iExiste = oComando.ExecuteScalar
            oConexion.Close()
            LlenarGrid()
            LimpiarControles()
        Else
            MsgBox("El Vendedor, tiene clientes asignados", MsgBoxStyle.Exclamation)
        End If
        txtBuscar.Focus()
        TotalRegistros()

    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()

    End Sub

    Private Sub Form2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form2.Show()

    End Sub



    Private Sub SalirToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rVendedores.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class