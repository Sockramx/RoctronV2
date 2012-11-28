<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbclaseArti = New System.Windows.Forms.ComboBox()
        Me.cmbalmaArti = New System.Windows.Forms.ComboBox()
        Me.txtprecioUArti = New System.Windows.Forms.TextBox()
        Me.txtstockArti = New System.Windows.Forms.TextBox()
        Me.txtdescripArti = New System.Windows.Forms.TextBox()
        Me.txtcodiArti = New System.Windows.Forms.TextBox()
        Me.dgvArticulo = New System.Windows.Forms.DataGridView()
        Me.codiArti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripArti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalRegistros.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblTotalRegistros.Location = New System.Drawing.Point(46, 472)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(96, 13)
        Me.lblTotalRegistros.TabIndex = 39
        Me.lblTotalRegistros.Text = "Total de Registros:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Location = New System.Drawing.Point(190, 410)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(114, 31)
        Me.btnGuardar.TabIndex = 37
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
        Me.btnNuevo.Location = New System.Drawing.Point(70, 410)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(114, 31)
        Me.btnNuevo.TabIndex = 36
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(140, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Buscar por:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(12, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Precio Unitario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(12, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Almacén:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(12, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Clase:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(12, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Stock:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(12, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(12, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Código"
        '
        'cmbclaseArti
        '
        Me.cmbclaseArti.FormattingEnabled = True
        Me.cmbclaseArti.Items.AddRange(New Object() {"Of", "Po", "Ju", "Cd"})
        Me.cmbclaseArti.Location = New System.Drawing.Point(92, 305)
        Me.cmbclaseArti.Name = "cmbclaseArti"
        Me.cmbclaseArti.Size = New System.Drawing.Size(111, 21)
        Me.cmbclaseArti.TabIndex = 28
        '
        'cmbalmaArti
        '
        Me.cmbalmaArti.FormattingEnabled = True
        Me.cmbalmaArti.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbalmaArti.Location = New System.Drawing.Point(92, 332)
        Me.cmbalmaArti.Name = "cmbalmaArti"
        Me.cmbalmaArti.Size = New System.Drawing.Size(111, 21)
        Me.cmbalmaArti.TabIndex = 27
        '
        'txtprecioUArti
        '
        Me.txtprecioUArti.Location = New System.Drawing.Point(92, 359)
        Me.txtprecioUArti.MaxLength = 10
        Me.txtprecioUArti.Name = "txtprecioUArti"
        Me.txtprecioUArti.Size = New System.Drawing.Size(111, 20)
        Me.txtprecioUArti.TabIndex = 26
        '
        'txtstockArti
        '
        Me.txtstockArti.Location = New System.Drawing.Point(92, 279)
        Me.txtstockArti.MaxLength = 25
        Me.txtstockArti.Name = "txtstockArti"
        Me.txtstockArti.Size = New System.Drawing.Size(111, 20)
        Me.txtstockArti.TabIndex = 25
        '
        'txtdescripArti
        '
        Me.txtdescripArti.Location = New System.Drawing.Point(80, 252)
        Me.txtdescripArti.MaxLength = 25
        Me.txtdescripArti.Name = "txtdescripArti"
        Me.txtdescripArti.Size = New System.Drawing.Size(205, 20)
        Me.txtdescripArti.TabIndex = 24
        '
        'txtcodiArti
        '
        Me.txtcodiArti.Location = New System.Drawing.Point(58, 217)
        Me.txtcodiArti.MaxLength = 4
        Me.txtcodiArti.Name = "txtcodiArti"
        Me.txtcodiArti.Size = New System.Drawing.Size(100, 20)
        Me.txtcodiArti.TabIndex = 23
        '
        'dgvArticulo
        '
        Me.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codiArti, Me.descripArti})
        Me.dgvArticulo.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvArticulo.Location = New System.Drawing.Point(92, 87)
        Me.dgvArticulo.MultiSelect = False
        Me.dgvArticulo.Name = "dgvArticulo"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvArticulo.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulo.Size = New System.Drawing.Size(325, 110)
        Me.dgvArticulo.TabIndex = 22
        '
        'codiArti
        '
        Me.codiArti.HeaderText = "Código"
        Me.codiArti.Name = "codiArti"
        Me.codiArti.Width = 50
        '
        'descripArti
        '
        Me.descripArti.HeaderText = "Descripción"
        Me.descripArti.Name = "descripArti"
        Me.descripArti.Width = 120
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(282, 43)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 21
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.FormattingEnabled = True
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Código", "Descripción"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(197, 43)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(79, 21)
        Me.cmbBuscarPor.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(502, 28)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Articulo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Programa_Completo.My.Resources.Resources.Cancel
        Me.Button2.Location = New System.Drawing.Point(471, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 28)
        Me.Button2.TabIndex = 49
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(502, 494)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTotalRegistros)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbclaseArti)
        Me.Controls.Add(Me.cmbalmaArti)
        Me.Controls.Add(Me.txtprecioUArti)
        Me.Controls.Add(Me.txtstockArti)
        Me.Controls.Add(Me.txtdescripArti)
        Me.Controls.Add(Me.txtcodiArti)
        Me.Controls.Add(Me.dgvArticulo)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Articulo"
        CType(Me.dgvArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalRegistros As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbclaseArti As System.Windows.Forms.ComboBox
    Friend WithEvents cmbalmaArti As System.Windows.Forms.ComboBox
    Friend WithEvents txtprecioUArti As System.Windows.Forms.TextBox
    Friend WithEvents txtstockArti As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripArti As System.Windows.Forms.TextBox
    Friend WithEvents txtcodiArti As System.Windows.Forms.TextBox
    Friend WithEvents dgvArticulo As System.Windows.Forms.DataGridView
    Friend WithEvents codiArti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripArti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmbBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
