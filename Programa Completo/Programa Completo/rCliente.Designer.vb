<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbPremiereProductsDataSet = New Programa_Completo.dbPremiereProductsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tClienteTableAdapter = New Programa_Completo.dbPremiereProductsDataSetTableAdapters.tClienteTableAdapter()
        CType(Me.tClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbPremiereProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tClienteBindingSource
        '
        Me.tClienteBindingSource.DataMember = "tCliente"
        Me.tClienteBindingSource.DataSource = Me.dbPremiereProductsDataSet
        '
        'dbPremiereProductsDataSet
        '
        Me.dbPremiereProductsDataSet.DataSetName = "dbPremiereProductsDataSet"
        Me.dbPremiereProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tClienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_Completo.rpClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(26, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(613, 340)
        Me.ReportViewer1.TabIndex = 0
        '
        'tClienteTableAdapter
        '
        Me.tClienteTableAdapter.ClearBeforeFill = True
        '
        'rCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 380)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rCliente"
        Me.Text = "rCliente"
        CType(Me.tClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbPremiereProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbPremiereProductsDataSet As Programa_Completo.dbPremiereProductsDataSet
    Friend WithEvents tClienteTableAdapter As Programa_Completo.dbPremiereProductsDataSetTableAdapters.tClienteTableAdapter
End Class
