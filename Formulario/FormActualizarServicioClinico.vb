Imports CapaEntidad
Imports CapaNegocio
Public Class FormActualizarServicioClinico
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim id_servicio_clinico As Integer = -1
    Dim id_tipo_servicio As Integer = -1
    Private Sub FormActualizarServicioClinico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgServicioClinico.DataSource = objNegocio.Neg_listarServiciosClinicos
        'mostrara datos en cbTipoServicio
        Me.cbTipoServicio.DataSource = objNegocio.Neg_listarServiciosClinicos
        Me.cbTipoServicio.ValueMember = "id_servicio_clinico"
        Me.cbTipoServicio.DisplayMember = "nombre_servicio"

        Me.cbEstadoServicio.Items.Add("ACTIVO")
        Me.cbEstadoServicio.Items.Add("INACTIVO")
    End Sub

    Private Sub dgServicioClinico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgServicioClinico.CellClick
        Me.id_tipo_servicio = CInt(dgServicioClinico.SelectedCells(0).Value)
        Me.id_servicio_clinico = CInt(dgServicioClinico.SelectedCells(2).Value)
        Me.DTPFechaServicio.Value = Convert.ToDateTime(dgServicioClinico.SelectedCells(4).Value.ToString)
        Me.txtPrecioServicio.Text = CStr(dgServicioClinico.SelectedCells(7).Value)

    End Sub

    Private Sub btnActualizarServicioClinico_Click(sender As Object, e As EventArgs) Handles btnActualizarServicioClinico.Click
        Dim verificar As Integer = -1

        If Me.id_servicio_clinico <> -1 And Me.id_tipo_servicio <> -1 Then
            Try
                objEntidad.id_servicio_clinico = Me.id_servicio_clinico
                objEntidad.id_tipo_servicio = Me.cbTipoServicio.SelectedValue
                objEntidad.fecha_servicio = Me.DTPFechaServicio.Value
                objEntidad.estado_pago_servicio = 1

                If cbEstadoServicio.SelectedItem.Equals("ACTIVO") Then
                    objEntidad.estado_servicio = 1
                ElseIf cbEstadoServicio.SelectedItem.Equals("INACTIVO") Then
                    objEntidad.estado_servicio = 0
                End If
                objEntidad.precio = Convert.ToDouble(txtPrecioServicio.Text)

                verificar = objNegocio.Neg_actualizarServicioClinico(objEntidad)

            Catch ex As Exception

            End Try

            If verificar <> -1 Then
                MessageBox.Show("SE ACTUALIZO CORRECTAMENTE")
                Me.dgServicioClinico.DataSource = objNegocio.Neg_listarServiciosClinicos
            Else
                MessageBox.Show("ERROR EN ACTUALIZAR")
            End If

        Else
            MessageBox.Show("DEBE SELECCIONAR UNA FILA")
        End If

    End Sub
End Class