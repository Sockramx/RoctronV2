<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtporCoVende = New System.Windows.Forms.TextBox()
        Me.txtcomiToVende = New System.Windows.Forms.TextBox()
        Me.txtciudadVende = New System.Windows.Forms.TextBox()
        Me.txtdirecVende = New System.Windows.Forms.TextBox()
        Me.txtnombreVende = New System.Windows.Forms.TextBox()
        Me.txtapeVende = New System.Windows.Forms.TextBox()
        Me.dgvVendedor = New System.Windows.Forms.DataGridView()
        Me.codiVende = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apeVende = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreVende = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtcodiVende = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(119, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Buscar por:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(304, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Porcentaje de Comision:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(304, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Comision Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(21, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Ciudad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(9, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(18, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(18, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(18, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Codigo"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Location = New System.Drawing.Point(215, 383)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(102, 34)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Location = New System.Drawing.Point(107, 383)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(102, 34)
        Me.btnNuevo.TabIndex = 32
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtporCoVende
        '
        Me.txtporCoVende.Location = New System.Drawing.Point(436, 287)
        Me.txtporCoVende.MaxLength = 4
        Me.txtporCoVende.Name = "txtporCoVende"
        Me.txtporCoVende.Size = New System.Drawing.Size(96, 20)
        Me.txtporCoVende.TabIndex = 31
        '
        'txtcomiToVende
        '
        Me.txtcomiToVende.Location = New System.Drawing.Point(436, 261)
        Me.txtcomiToVende.MaxLength = 8
        Me.txtcomiToVende.Name = "txtcomiToVende"
        Me.txtcomiToVende.Size = New System.Drawing.Size(96, 20)
        Me.txtcomiToVende.TabIndex = 30
        '
        'txtciudadVende
        '
        Me.txtciudadVende.Location = New System.Drawing.Point(77, 335)
        Me.txtciudadVende.MaxLength = 15
        Me.txtciudadVende.Name = "txtciudadVende"
        Me.txtciudadVende.Size = New System.Drawing.Size(199, 20)
        Me.txtciudadVende.TabIndex = 29
        '
        'txtdirecVende
        '
        Me.txtdirecVende.Location = New System.Drawing.Point(77, 309)
        Me.txtdirecVende.MaxLength = 15
        Me.txtdirecVende.Name = "txtdirecVende"
        Me.txtdirecVende.Size = New System.Drawing.Size(199, 20)
        Me.txtdirecVende.TabIndex = 28
        '
        'txtnombreVende
        '
        Me.txtnombreVende.Location = New System.Drawing.Point(77, 283)
        Me.txtnombreVende.MaxLength = 15
        Me.txtnombreVende.Name = "txtnombreVende"
        Me.txtnombreVende.Size = New System.Drawing.Size(133, 20)
        Me.txtnombreVende.TabIndex = 27
        '
        'txtapeVende
        '
        Me.txtapeVende.Location = New System.Drawing.Point(77, 254)
        Me.txtapeVende.MaxLength = 15
        Me.txtapeVende.Name = "txtapeVende"
        Me.txtapeVende.Size = New System.Drawing.Size(133, 20)
        Me.txtapeVende.TabIndex = 26
        '
        'dgvVendedor
        '
        Me.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codiVende, Me.apeVende, Me.nombreVende})
        Me.dgvVendedor.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvVendedor.Location = New System.Drawing.Point(76, 80)
        Me.dgvVendedor.MultiSelect = False
        Me.dgvVendedor.Name = "dgvVendedor"
        Me.dgvVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVendedor.Size = New System.Drawing.Size(332, 140)
        Me.dgvVendedor.TabIndex = 25
        '
        'codiVende
        '
        Me.codiVende.HeaderText = "Codigo"
        Me.codiVende.Name = "codiVende"
        Me.codiVende.Width = 50
        '
        'apeVende
        '
        Me.apeVende.HeaderText = "Apellido"
        Me.apeVende.Name = "apeVende"
        Me.apeVende.Width = 120
        '
        'nombreVende
        '
        Me.nombreVende.HeaderText = "Nombre"
        Me.nombreVende.Name = "nombreVende"
        Me.nombreVende.Width = 120
        '
        'txtcodiVende
        '
        Me.txtcodiVende.Location = New System.Drawing.Point(77, 226)
        Me.txtcodiVende.MaxLength = 2
        Me.txtcodiVende.Name = "txtcodiVende"
        Me.txtcodiVende.Size = New System.Drawing.Size(62, 20)
        Me.txtcodiVende.TabIndex = 24
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(323, 46)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(68, 20)
        Me.txtBuscar.TabIndex = 23
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.FormattingEnabled = True
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Codigo", "Apellido", "Nombre"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(196, 44)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(89, 21)
        Me.cmbBuscarPor.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(538, 28)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Vendedor"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(349, 338)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(75, 13)
        Me.lblTotalRegistros.TabIndex = 47
        Me.lblTotalRegistros.Text = "TotalRegistros"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Programa_Completo.My.Resources.Resources.Cancel
        Me.Button2.Location = New System.Drawing.Point(507, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 28)
        Me.Button2.TabIndex = 48
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(538, 453)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblTotalRegistros)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtporCoVende)
        Me.Controls.Add(Me.txtcomiToVende)
        Me.Controls.Add(Me.txtciudadVende)
        Me.Controls.Add(Me.txtdirecVende)
        Me.Controls.Add(Me.txtnombreVende)
        Me.Controls.Add(Me.txtapeVende)
        Me.Controls.Add(Me.dgvVendedor)
        Me.Controls.Add(Me.txtcodiVende)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Vendedor"
        CType(Me.dgvVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtporCoVende As System.Windows.Forms.TextBox
    Friend WithEvents txtcomiToVende As System.Windows.Forms.TextBox
    Friend WithEvents txtciudadVende As System.Windows.Forms.TextBox
    Friend WithEvents txtdirecVende As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreVende As System.Windows.Forms.TextBox
    Friend WithEvents txtapeVende As System.Windows.Forms.TextBox
    Friend WithEvents dgvVendedor As System.Windows.Forms.DataGridView
    Friend WithEvents codiVende As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apeVende As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreVende As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtcodiVende As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmbBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRegistros As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
