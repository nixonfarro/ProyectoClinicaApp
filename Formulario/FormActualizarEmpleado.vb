Imports CapaEntidad
Imports CapaNegocio
Public Class FormActualizarEmpleado
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim idEmpleado As Integer = -1
    Dim idpersona As Integer = -1

    Private Sub FormActualizarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'llenar en cbSexo
        Me.cbSexo.Items.Add("MASCULINO")
        Me.cbSexo.Items.Add("FEMENINO")

        'mostrara datos en cbArea

        Me.cbArea.DataSource = objNegocio.Neg_ListarArea
        Me.cbArea.ValueMember = "id_tipo_area"
        Me.cbArea.DisplayMember = "nombre_tipo_area"

        'mostrara datos en cbTipoEmpleados
        Me.cbTipoEmpleado.DataSource = objNegocio.Neg_ListarTipoTrabajador
        Me.cbTipoEmpleado.ValueMember = "id_tipo_empleado"
        Me.cbTipoEmpleado.DisplayMember = "nombre_tipo_empleado"
    End Sub
    Private Sub btnBuscarDniEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarDniEmpleado.Click
        Dim dni As Integer
        Dim dt As DataTable

        dni = Convert.ToInt32(Me.txtDNIEmpleado.Text)

        dt = objNegocio.Neg_buscarEmpleadoDNI(dni)


        If dt IsNot Nothing Then
            MessageBox.Show(" Se encontro DNI")
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
            idEmpleado = CInt(row("id_empleado"))
            Me.idpersona = CInt(row("id_persona"))
            Me.txtNombreTrabajador.Text = CStr(row("nombre"))
            Me.txtApellidoPaternoTrabajador.Text = CStr(row("apellido_paterno"))
            Me.txtApellidoMaterno.Text = CStr(row("apellido_materno"))
            Me.DTPFechaNacimientoTrabajador.Value = Convert.ToDateTime(row("fecha_nacimiento"))
            Me.txtCelularTrabajador.Text = CStr(row("celular"))
            Me.txtDetalleTrabajador.Text = CStr(row("detalle"))
            Me.txtDireccionTrabajador.Text = CStr(row("direcccion"))
            Me.txtCorreoTrabajador.Text = CStr(row("correo"))


        Else
            MessageBox.Show("NO SE ENCONTRO DNI, INTENTE OTRA VEZ")
        End If
    End Sub

    Private Sub btnActualizarEmpleado_Click(sender As Object, e As EventArgs) Handles btnActualizarEmpleado.Click
        Dim verificacion As Integer
        verificacion = -1
        If Me.idEmpleado <> -1 And Me.idpersona Then
            Try
                objEntidad.id_persona = Me.idpersona
                objEntidad.id_empleado = Me.idEmpleado
                objEntidad.nombre = Me.txtNombreTrabajador.Text
                objEntidad.apellido_paterno = Me.txtApellidoPaternoTrabajador.Text
                objEntidad.apellido_materno = Me.txtApellidoMaterno.Text
                objEntidad.fecha_nacimiento = Me.DTPFechaNacimientoTrabajador.Value
                objEntidad.dni = Convert.ToInt32(Me.txtDNIEmpleado.Text)
                objEntidad.celular = Convert.ToInt32(Me.txtCelularTrabajador.Text)
                If Me.cbSexo.SelectedItem.Equals("MACULINO") Then
                    objEntidad.sexo = 0
                ElseIf Me.cbSexo.SelectedItem.Equals("FEMENINO") Then
                    objEntidad.sexo = 1

                End If

                objEntidad.id_area = Me.cbArea.SelectedValue
                objEntidad.detalle = Me.txtDetalleTrabajador.Text
                objEntidad.id_tipo_empleado = Me.cbTipoEmpleado.SelectedValue
                objEntidad.direccion = Me.txtDireccionTrabajador.Text
                objEntidad.correo = Me.txtCorreoTrabajador.Text

                verificacion = objNegocio.Neg_actualizarEmpleado(objEntidad)

            Catch ex As Exception

            End Try
            If verificacion <> -1 Then

                MessageBox.Show("Se actualizo Correctamente al empleado")
            Else
                MessageBox.Show("Error de actualizar")

            End If
        End If
    End Sub
End Class