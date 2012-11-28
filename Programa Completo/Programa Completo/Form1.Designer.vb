<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManteniminto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnVendedores = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'Form2ToolStripMenuItem
        '
        Me.Form2ToolStripMenuItem.Name = "Form2ToolStripMenuItem"
        Me.Form2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Form2ToolStripMenuItem.Text = "form2"
        '
        'Form3ToolStripMenuItem
        '
        Me.Form3ToolStripMenuItem.Name = "Form3ToolStripMenuItem"
        Me.Form3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Form3ToolStripMenuItem.Text = "form3"
        '
        'Form4ToolStripMenuItem
        '
        Me.Form4ToolStripMenuItem.Name = "Form4ToolStripMenuItem"
        Me.Form4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Form4ToolStripMenuItem.Text = "form4"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'btnClientes
        '
        Me.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClientes.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClientes.Location = New System.Drawing.Point(0, 116)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(180, 34)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnVendedores
        '
        Me.btnVendedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVendedores.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVendedores.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendedores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVendedores.Location = New System.Drawing.Point(0, 162)
        Me.btnVendedores.Name = "btnVendedores"
        Me.btnVendedores.Size = New System.Drawing.Size(180, 34)
        Me.btnVendedores.TabIndex = 2
        Me.btnVendedores.Text = "Vendedores"
        Me.btnVendedores.UseVisualStyleBackColor = False
        '
        'btnArticulos
        '
        Me.btnArticulos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnArticulos.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnArticulos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnArticulos.Location = New System.Drawing.Point(0, 69)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(180, 34)
        Me.btnArticulos.TabIndex = 4
        Me.btnArticulos.Text = "Articulos"
        Me.btnArticulos.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.Menu.AllowDrop = True
        Me.Menu.BackColor = System.Drawing.Color.Gray
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(284, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(-3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Menu - Roctron"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Programa_Completo.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(203, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 195)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Programa_Completo.My.Resources.Resources._Exit
        Me.Button1.Location = New System.Drawing.Point(430, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 57)
        Me.Button1.TabIndex = 6
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmManteniminto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(500, 255)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.btnVendedores)
        Me.Controls.Add(Me.btnClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManteniminto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "l"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnVendedores As System.Windows.Forms.Button
    Friend WithEvents btnArticulos As System.Windows.Forms.Button
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
