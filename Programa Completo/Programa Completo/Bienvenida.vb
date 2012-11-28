Public Class Bienvenida
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
    Dim contador As Byte = 4
    Private Sub Bienvenida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Opacity -= 0.07
            If Me.Opacity = 0.0 Then
                Me.Hide()
                frmManteniminto.Show()
                Timer1.Enabled = False
            End If
        Else
            ProgressBar1.Value += 4
            If ProgressBar1.Value = contador Then
                Label1.Text = "INICIANDO ....."
            Else
                If ProgressBar1.Value = contador + 16 Then
                    Label1.Text = ""
                    contador += 20
                End If
                If ProgressBar1.Value = 28 Then
                    Label2.Text = ""
                End If
            End If
        End If
    End Sub
End Class