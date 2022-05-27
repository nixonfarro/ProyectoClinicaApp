Imports CapaEntidad
Imports CapaNegocio
Public Class FormBuscarCitaMedica
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim idEmpleado As Integer = -1
    Dim idCliente As Integer = -1
    Dim idCita As Integer = -1
    Dim tipo_acceso As String

    Public Sub New(tipo_acceso_ As String)
        Me.tipo_acceso = tipo_acceso_

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub dgCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCitas.CellClick
        Dim dt As DataTable
        idEmpleado = CInt(dgCitas.SelectedCells(1).Value)
        idCita = CInt(dgCitas.SelectedCells(0).Value)

        dt = objNegocio.Neg_mostrarEmpleadoPorID(idEmpleado)
        If dt IsNot Nothing Then
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
            txtNombreEmpleado.Text = CStr(row("nombre"))
            Me.txtApellidosEmpleado.Text = CStr(row("apellido_paterno"))
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim dni As Integer
        Dim dt As DataTable
        dni = Convert.ToInt32(Me.txtDniCliente.Text)
        dt = objNegocio.Neg_listarCitasPorDniCliente(dni)

        If dt IsNot Nothing Then
            MessageBox.Show(" Se encontro DNI- Mostrar las citas del cliente")
            dgCitas.DataSource = dt

        Else

            MessageBox.Show("NO SE ENCONTRO DNI, INTENTE OTRA VEZ")
        End If
    End Sub

    Private Sub btnAnularCitaMedica_Click(sender As Object, e As EventArgs) Handles btnAnularCitaMedica.Click
        If tipo_acceso.Equals("INVITADO") Then
            MessageBox.Show(".:: ACCESO DENEGADO::.  -- NIVEL DE ACCESO: " & tipo_acceso)
        ElseIf tipo_acceso.Equals("ADMINISTRADOR") Then

            MessageBox.Show(".:: ACCESO ACEPTADO::.  -- NIVEL DE ACCESO: " & tipo_acceso)
            Dim verificacion As Integer = -1
            If Me.idCita <> -1 Then
                Try
                    verificacion = objNegocio.Neg_anularCitaMedica(Me.idCita)

                Catch ex As Exception

                End Try

                If verificacion <> -1 Then
                    MessageBox.Show("SE ANULO CORRECTAMENTE LA CITA")
                Else
                    MessageBox.Show("ERROR EN ELIMINAR")
                End If
            End If
        End If


    End Sub

End Class