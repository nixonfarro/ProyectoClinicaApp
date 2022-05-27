Public Class FormReporteCitas
    Private Sub FormReporteCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CLÍNICA_ALFONSO_UGARTEDataSet1.Cita' Puede moverla o quitarla según sea necesario.
        Me.CitaTableAdapter.Fill(Me.CLÍNICA_ALFONSO_UGARTEDataSet1.Cita)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class