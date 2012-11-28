Imports System.Data.SqlClient

Module ModuloConexion
    Dim sConn As String = "Server = .; DataBase = Roctron2; Integrated Security = True"
    Public oConexion As New SqlConnection(sConn)
    Public sSQL As String
    Public oComando As New SqlCommand(sSQL, oConexion)
    Public oDataReader As SqlDataReader
End Module

Public Class form2
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
    Private Sub MostrarVendedor()

        sSQL = "SELECT apeVende + ' ' + nombreVende as datosVende FROM tVendedor ORDER BY apeVende;"

        cmbnombreVende.Items.Clear()

        oComando.CommandText = sSQL
        oConexion.Open()
        oDataReader = oComando.ExecuteReader
        While oDataReader.Read()
            cmbnombreVende.Items.Add(oDataReader("datosvende"))
        End While
        oConexion.Close()
    End Sub
    Private Sub TotalRegistros()
        sSQL = "SELECT COUNT(*) AS totalRegistros FROM tCliente;"
        oComando.CommandText = sSQL
        oConexion.Open()
        lblTotalRegistros.Text = "Total de Registros: " & oComando.ExecuteScalar
        oConexion.Close()
    End Sub
    Private Sub LimpiarControles()
        txtcodiClien.Text = ""
        txtnombreClien.Text = ""
        txtdirecClien.Text = ""
        txtciudadClien.Text = ""
        txtbalanClien.Text = ""
        txtlimiCreClien.Text = ""
        cmbnombreVende.Text = ""
    End Sub
    Private Sub LlenarGrid()
        Select Case cmbBuscarPor.SelectedIndex
            Case 0
                sSQL = "SELECT codiClien, nombreClien FROM tCliente ORDER BY codiClien;"
            Case 1
                sSQL = "SELECT codiClien, nombreClien FROM tCliente ORDER BY nombreClien;"
        End Select
        dgvCliente.Rows.Clear()
        oComando.CommandText = sSQL
        oConexion.Open()
        oDataReader = oComando.ExecuteReader
        While oDataReader.Read()
            dgvCliente.Rows.Add(oDataReader("codiClien"), oDataReader("nombreClien"))
        End While
        oConexion.Close()
    End Sub
    Private Sub MostrarCliente()
        sSQL = "SELECT * FROM tCliente inner join  tVendedor on tVendedor.codiVende = tCliente.codiVende WHERE codiClien = '" & dgvCliente.CurrentRow.Cells.Item(0).Value & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        oDataReader = oComando.ExecuteReader
        If oDataReader.Read() Then
            txtcodiClien.Text = oDataReader("codiClien")
            txtnombreClien.Text = oDataReader("nombreClien")
            txtdirecClien.Text = oDataReader("direcClien")
            txtciudadClien.Text = oDataReader("ciudadClien")
            txtbalanClien.Text = oDataReader("balanClien")
            txtlimiCreClien.Text = oDataReader("limiCreClien")
            cmbnombreVende.Text = oDataReader("nombreVende") & " " & oDataReader("apeVende")
        End If
        oConexion.Close()
    End Sub
    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbBuscarPor.SelectedIndex = 0
        LlenarGrid()
        MostrarVendedor()
        TotalRegistros()
    End Sub
    Private Sub cmbBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBuscarPor.SelectedIndexChanged
        LlenarGrid()
        txtBuscar.Focus()
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            MostrarCliente()
        End If
    End Sub
    Private Sub ubicaFilaGrid(ByVal nombreCampo As String, ByVal sTexto As String)
        Dim Fila As DataGridViewRow
        For Each Fila In dgvCliente.Rows
            If LCase(Fila.Cells(nombreCampo).Value) Like LCase(sTexto & "*") Then
                Fila.Selected = True
                dgvCliente.FirstDisplayedScrollingRowIndex = Fila.Index
                dgvCliente.CurrentCell = dgvCliente.Rows(Fila.Index).Cells(0)
                Exit For
            End If
        Next
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If cmbBuscarPor.SelectedIndex = 0 Then ubicaFilaGrid("codiClien", txtBuscar.Text)
        If cmbBuscarPor.SelectedIndex = 1 Then ubicaFilaGrid("nombreClien", txtBuscar.Text)
    End Sub
    Private Sub dgvCliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCliente.CellContentClick
        MostrarCliente()
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        LimpiarControles()
        txtcodiClien.Focus()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim iExiste As Integer

        sSQL = "SELECT COUNT(*) AS existeClien FROM tCliente WHERE codiClien = '" & txtcodiClien.Text & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        iExiste = oComando.ExecuteScalar
        oConexion.Close()

        Dim iVendedor As Integer
        sSQL = "SELECT codiVende from tVendedor where apeVende + ' ' + nombreVende = '" & cmbnombreVende.Text & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        iVendedor = oComando.ExecuteScalar
        oConexion.Close()

        If iExiste = 1 And Len(txtnombreClien.Text) > 0 Then
            sSQL = "UPDATE tCliente SET nombreClien = '" & Replace(txtnombreClien.Text, "'", "''") & "', direcClien = '" & txtdirecClien.Text & "', ciudadClien = '" & txtciudadClien.Text & "', balanClien = " & txtbalanClien.Text & ",  limiCreClien = " & txtlimiCreClien.Text & ", codiVende = " & iVendedor & " WHERE codiClien = '" & txtcodiClien.Text & "';"
            oComando.CommandText = sSQL
            oConexion.Open()
            oComando.ExecuteReader()
            oConexion.Close()
            LlenarGrid()
            ubicaFilaGrid("codiClien", txtcodiClien.Text)
        ElseIf iExiste = 0 And Len(txtcodiClien.Text) = 3 And Len(txtnombreClien.Text) > 0 Then
            sSQL = "INSERT INTO tCliente VALUES ('" & txtcodiClien.Text & "','" & Replace(txtnombreClien.Text, "'", "''") & "','" & txtdirecClien.Text & "','" & txtciudadClien.Text & "'," & Val(txtbalanClien.Text) & "," & Val(txtlimiCreClien.Text) & ",'" & iVendedor & "');"
            oComando.CommandText = sSQL
            oConexion.Open()
            oComando.ExecuteReader()
            oConexion.Close()
            LlenarGrid()
            ubicaFilaGrid("codiClien", txtcodiClien.Text)
        End If
        TotalRegistros()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iExiste As Integer
        sSQL = "SELECT COUNT(*) FROM tPedido WHERE codiClien = '" & txtcodiClien.Text & "';"
        oComando.CommandText = sSQL
        oConexion.Open()
        iExiste = oComando.ExecuteScalar
        oConexion.Close()

        If iExiste = 0 Then
            sSQL = "DELETE FROM tCliente WHERE codiClien = '" & txtcodiClien.Text & "';"
            oComando.CommandText = sSQL
            oConexion.Open()
            iExiste = oComando.ExecuteScalar
            oConexion.Close()
            LlenarGrid()
            LimpiarControles()
        Else
            MsgBox("El Cliente, tiene pedidos asignados", MsgBoxStyle.Exclamation)
        End If
        txtBuscar.Focus()
        TotalRegistros()
    End Sub
    Private Sub form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()

    End Sub


    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()

    End Sub

    Private Sub SalirToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rCliente.Show()

    End Sub

    Private Sub cmbnombreVende_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnombreVende.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class