Public Class FormReportesServiciosClinicos
    Private Sub FormReportesServiciosClinicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CLÍNICA_ALFONSO_UGARTEDataSet.Servicio_clinico' Puede moverla o quitarla según sea necesario.
        Me.Servicio_clinicoTableAdapter.Fill(Me.CLÍNICA_ALFONSO_UGARTEDataSet.Servicio_clinico)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class