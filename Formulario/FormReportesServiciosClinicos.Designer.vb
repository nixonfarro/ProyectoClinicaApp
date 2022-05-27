<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportesServiciosClinicos
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CLÍNICA_ALFONSO_UGARTEDataSet = New ClinicaApp.CLÍNICA_ALFONSO_UGARTEDataSet()
        Me.Servicio_clinicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Servicio_clinicoTableAdapter = New ClinicaApp.CLÍNICA_ALFONSO_UGARTEDataSetTableAdapters.Servicio_clinicoTableAdapter()
        CType(Me.CLÍNICA_ALFONSO_UGARTEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servicio_clinicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetClinica"
        ReportDataSource1.Value = Me.Servicio_clinicoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ClinicaApp.ReportServiciosClinicos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1275, 565)
        Me.ReportViewer1.TabIndex = 0
        '
        'CLÍNICA_ALFONSO_UGARTEDataSet
        '
        Me.CLÍNICA_ALFONSO_UGARTEDataSet.DataSetName = "CLÍNICA_ALFONSO_UGARTEDataSet"
        Me.CLÍNICA_ALFONSO_UGARTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Servicio_clinicoBindingSource
        '
        Me.Servicio_clinicoBindingSource.DataMember = "Servicio_clinico"
        Me.Servicio_clinicoBindingSource.DataSource = Me.CLÍNICA_ALFONSO_UGARTEDataSet
        '
        'Servicio_clinicoTableAdapter
        '
        Me.Servicio_clinicoTableAdapter.ClearBeforeFill = True
        '
        'FormReportesServiciosClinicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 565)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportesServiciosClinicos"
        Me.Text = "Reporte servicios clinicos"
        CType(Me.CLÍNICA_ALFONSO_UGARTEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servicio_clinicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Servicio_clinicoBindingSource As BindingSource
    Friend WithEvents CLÍNICA_ALFONSO_UGARTEDataSet As CLÍNICA_ALFONSO_UGARTEDataSet
    Friend WithEvents Servicio_clinicoTableAdapter As CLÍNICA_ALFONSO_UGARTEDataSetTableAdapters.Servicio_clinicoTableAdapter
End Class
