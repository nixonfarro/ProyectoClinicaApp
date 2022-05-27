<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteCitas
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
        Me.CLÍNICA_ALFONSO_UGARTEDataSet1 = New ClinicaApp.CLÍNICA_ALFONSO_UGARTEDataSet1()
        Me.CitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitaTableAdapter = New ClinicaApp.CLÍNICA_ALFONSO_UGARTEDataSet1TableAdapters.CitaTableAdapter()
        CType(Me.CLÍNICA_ALFONSO_UGARTEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CitaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ClinicaApp.ReportCitasMedicas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1413, 673)
        Me.ReportViewer1.TabIndex = 0
        '
        'CLÍNICA_ALFONSO_UGARTEDataSet1
        '
        Me.CLÍNICA_ALFONSO_UGARTEDataSet1.DataSetName = "CLÍNICA_ALFONSO_UGARTEDataSet1"
        Me.CLÍNICA_ALFONSO_UGARTEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CitaBindingSource
        '
        Me.CitaBindingSource.DataMember = "Cita"
        Me.CitaBindingSource.DataSource = Me.CLÍNICA_ALFONSO_UGARTEDataSet1
        '
        'CitaTableAdapter
        '
        Me.CitaTableAdapter.ClearBeforeFill = True
        '
        'FormReporteCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 673)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReporteCitas"
        Me.Text = "FormReporteCitas"
        CType(Me.CLÍNICA_ALFONSO_UGARTEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CitaBindingSource As BindingSource
    Friend WithEvents CLÍNICA_ALFONSO_UGARTEDataSet1 As CLÍNICA_ALFONSO_UGARTEDataSet1
    Friend WithEvents CitaTableAdapter As CLÍNICA_ALFONSO_UGARTEDataSet1TableAdapters.CitaTableAdapter
End Class
