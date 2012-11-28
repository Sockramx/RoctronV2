Public Class frmManteniminto
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
    Private Sub frmManteniminto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArticulos.Click
        Form3.Show()
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        form2.Show()
    End Sub

    Private Sub btnVendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendedores.Click
        Form5.Show()
    End Sub

    Private Sub Form1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()

    End Sub

    Private Sub Form2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form2.Show()

    End Sub

   
    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()
    End Sub
    Private Sub SalirToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End

    End Sub
End Class
