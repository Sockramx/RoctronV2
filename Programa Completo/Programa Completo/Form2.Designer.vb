<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        Me.cmbnombreVende = New System.Windows.Forms.ComboBox()
        Me.txtlimiCreClien = New System.Windows.Forms.TextBox()
        Me.txtbalanClien = New System.Windows.Forms.TextBox()
        Me.txtciudadClien = New System.Windows.Forms.TextBox()
        Me.txtdirecClien = New System.Windows.Forms.TextBox()
        Me.txtnombreClien = New System.Windows.Forms.TextBox()
        Me.txtcodiClien = New System.Windows.Forms.TextBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.codiClien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreClien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmbBuscarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(118, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Buscar por:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(110, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Vendedor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(309, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Límite de Crédito:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(309, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Balance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(25, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Ciudad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(13, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(13, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(12, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Código"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(215, 384)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(106, 33)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(103, 384)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(106, 33)
        Me.btnNuevo.TabIndex = 33
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblTotalRegistros.Location = New System.Drawing.Point(12, 433)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(96, 13)
        Me.lblTotalRegistros.TabIndex = 32
        Me.lblTotalRegistros.Text = "Total de Registros:"
        '
        'cmbnombreVende
        '
        Me.cmbnombreVende.FormattingEnabled = True
        Me.cmbnombreVende.Location = New System.Drawing.Point(185, 348)
        Me.cmbnombreVende.Name = "cmbnombreVende"
        Me.cmbnombreVende.Size = New System.Drawing.Size(214, 21)
        Me.cmbnombreVende.TabIndex = 31
        '
        'txtlimiCreClien
        '
        Me.txtlimiCreClien.Location = New System.Drawing.Point(415, 305)
        Me.txtlimiCreClien.MaxLength = 10
        Me.txtlimiCreClien.Name = "txtlimiCreClien"
        Me.txtlimiCreClien.Size = New System.Drawing.Size(111, 20)
        Me.txtlimiCreClien.TabIndex = 30
        '
        'txtbalanClien
        '
        Me.txtbalanClien.Location = New System.Drawing.Point(415, 279)
        Me.txtbalanClien.MaxLength = 10
        Me.txtbalanClien.Name = "txtbalanClien"
        Me.txtbalanClien.Size = New System.Drawing.Size(111, 20)
        Me.txtbalanClien.TabIndex = 29
        '
        'txtciudadClien
        '
        Me.txtciudadClien.Location = New System.Drawing.Point(87, 309)
        Me.txtciudadClien.MaxLength = 15
        Me.txtciudadClien.Name = "txtciudadClien"
        Me.txtciudadClien.Size = New System.Drawing.Size(214, 20)
        Me.txtciudadClien.TabIndex = 28
        '
        'txtdirecClien
        '
        Me.txtdirecClien.Location = New System.Drawing.Point(87, 283)
        Me.txtdirecClien.MaxLength = 15
        Me.txtdirecClien.Name = "txtdirecClien"
        Me.txtdirecClien.Size = New System.Drawing.Size(214, 20)
        Me.txtdirecClien.TabIndex = 27
        '
        'txtnombreClien
        '
        Me.txtnombreClien.Location = New System.Drawing.Point(88, 257)
        Me.txtnombreClien.MaxLength = 30
        Me.txtnombreClien.Name = "txtnombreClien"
        Me.txtnombreClien.Size = New System.Drawing.Size(214, 20)
        Me.txtnombreClien.TabIndex = 26
        '
        'txtcodiClien
        '
        Me.txtcodiClien.Location = New System.Drawing.Point(88, 224)
        Me.txtcodiClien.MaxLength = 3
        Me.txtcodiClien.Name = "txtcodiClien"
        Me.txtcodiClien.Size = New System.Drawing.Size(81, 20)
        Me.txtcodiClien.TabIndex = 25
        '
        'dgvCliente
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCliente.BackgroundColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codiClien, Me.nombreClien})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCliente.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvCliente.Location = New System.Drawing.Point(86, 96)
        Me.dgvCliente.MultiSelect = False
        Me.dgvCliente.Name = "dgvCliente"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvCliente.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(313, 112)
        Me.dgvCliente.TabIndex = 24
        '
        'codiClien
        '
        Me.codiClien.HeaderText = "Código"
        Me.codiClien.Name = "codiClien"
        Me.codiClien.Width = 50
        '
        'nombreClien
        '
        Me.nombreClien.HeaderText = "Nombre"
        Me.nombreClien.Name = "nombreClien"
        Me.nombreClien.Width = 120
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(280, 53)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(119, 20)
        Me.txtBuscar.TabIndex = 23
        '
        'cmbBuscarPor
        '
        Me.cmbBuscarPor.BackColor = System.Drawing.SystemColors.Window
        Me.cmbBuscarPor.FormattingEnabled = True
        Me.cmbBuscarPor.Items.AddRange(New Object() {"Código", "Nombre"})
        Me.cmbBuscarPor.Location = New System.Drawing.Point(185, 53)
        Me.cmbBuscarPor.Name = "cmbBuscarPor"
        Me.cmbBuscarPor.Size = New System.Drawing.Size(86, 21)
        Me.cmbBuscarPor.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 28)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Programa_Completo.My.Resources.Resources.Cancel
        Me.Button2.Location = New System.Drawing.Point(508, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 28)
        Me.Button2.TabIndex = 49
        Me.Button2.UseVisualStyleBackColor = True
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(538, 455)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblTotalRegistros)
        Me.Controls.Add(Me.cmbnombreVende)
        Me.Controls.Add(Me.txtlimiCreClien)
        Me.Controls.Add(Me.txtbalanClien)
        Me.Controls.Add(Me.txtciudadClien)
        Me.Controls.Add(Me.txtdirecClien)
        Me.Controls.Add(Me.txtnombreClien)
        Me.Controls.Add(Me.txtcodiClien)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmbBuscarPor)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Cliente"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblTotalRegistros As System.Windows.Forms.Label
    Friend WithEvents cmbnombreVende As System.Windows.Forms.ComboBox
    Friend WithEvents txtlimiCreClien As System.Windows.Forms.TextBox
    Friend WithEvents txtbalanClien As System.Windows.Forms.TextBox
    Friend WithEvents txtciudadClien As System.Windows.Forms.TextBox
    Friend WithEvents txtdirecClien As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreClien As System.Windows.Forms.TextBox
    Friend WithEvents txtcodiClien As System.Windows.Forms.TextBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents codiClien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreClien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmbBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
