Imports CapaEntidad
Imports CapaNegocio
Public Class FormGestionTrabajador
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim idEmpleado As Integer
    Dim auxIdEmpleado As Integer
    Dim dt As DataTable



    Private Sub FormGestionTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'obtener el ultimo ID del trabajador
        dt = objNegocio.Neg_obtenerTotalTablaEmpleado


        Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
        idEmpleado = CInt(row("ID"))
        auxIdEmpleado = idEmpleado







        'cargar nombres de las columnas
        Me.dgTrabajadores.Columns.Add("id", "ID")
        Me.dgTrabajadores.Columns.Add("nombre", "Nombre")
        Me.dgTrabajadores.Columns.Add("Apaterno", "Apellido Paterno")
        Me.dgTrabajadores.Columns.Add("Amaterno", "Apellido Materno")
        Me.dgTrabajadores.Columns.Add("Fnacimiento", "Fecha Nacimiento")
        Me.dgTrabajadores.Columns.Add("dni", "DNI")
        Me.dgTrabajadores.Columns.Add("celular", "Celular")
        Me.dgTrabajadores.Columns.Add("sexo", "Sexo")
        Me.dgTrabajadores.Columns.Add("area", "Area")
        Me.dgTrabajadores.Columns.Add("detalle", "Detalle")
        Me.dgTrabajadores.Columns.Add("tipoEmpleado", "TipoEmpleado")
        Me.dgTrabajadores.Columns.Add("direccion", "direccion")
        Me.dgTrabajadores.Columns.Add("correo", "Correo")



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

    Private Sub btnGuardarGestionTrabajador_Click(sender As Object, e As EventArgs) Handles btnGuardarGestionTrabajador.Click
        Dim verificacion As Integer
        verificacion = -1
        Dim fila As DataGridViewRow = New DataGridViewRow()


        Try
            For Each fila In dgTrabajadores.Rows
                objEntidad.id_empleado = Convert.ToInt32(fila.Cells("id").Value)
                objEntidad.nombre = Convert.ToString(fila.Cells("nombre").Value)
                objEntidad.apellido_paterno = Convert.ToString(fila.Cells("Apaterno").Value)
                objEntidad.apellido_materno = Convert.ToString(fila.Cells("Amaterno").Value)
                objEntidad.fecha_nacimiento = Convert.ToDateTime(fila.Cells("Fnacimiento").Value)
                objEntidad.dni = Convert.ToInt32(fila.Cells("dni").Value)
                objEntidad.celular = Convert.ToInt32(fila.Cells("celular").Value)
                If Convert.ToString(fila.Cells("sexo").Value).Equals("MACULINO") Then
                    objEntidad.sexo = 0
                ElseIf Convert.ToString(fila.Cells("sexo").Value).Equals("FEMENINO") Then
                    objEntidad.sexo = 1

                End If

                objEntidad.id_area = Convert.ToInt32(fila.Cells("area").Value)
                objEntidad.detalle = Convert.ToString(fila.Cells("detalle").Value)
                objEntidad.id_tipo_empleado = Convert.ToInt32(fila.Cells("tipoEmpleado").Value)
                objEntidad.direccion = Convert.ToString(fila.Cells("direccion").Value)
                objEntidad.correo = Convert.ToString(fila.Cells("correo").Value)

                verificacion = objNegocio.Neg_RegistrarEmpleado(objEntidad)

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If verificacion <> -1 Then

            MessageBox.Show("Se agrego correctamente todos los registros")

        Else
            MessageBox.Show("Error de Ingreso")

        End If
        dgTrabajadores.Rows.Clear()


    End Sub

    Private Sub btnIngresarGestionTrabajador_Click(sender As Object, e As EventArgs) Handles btnIngresarGestionTrabajador.Click

        Me.idEmpleado = Me.idEmpleado + 1

        Me.dgTrabajadores.Rows.Add(Me.idEmpleado, txtNombreTrabajador.Text, txtApellidoPaternoTrabajador.Text, txtApellidoMaterno.Text, Me.DTPFechaNacimientoTrabajador.Value, txtDniTrabajador.Text, txtCelularTrabajador.Text, cbSexo.SelectedItem, Me.cbArea.SelectedValue, txtDetalleTrabajador.Text, cbTipoEmpleado.SelectedValue, txtDireccionTrabajador.Text, txtCorreoTrabajador.Text)
        Me.txtNombreTrabajador.Text = ""
        Me.txtApellidoPaternoTrabajador.Text = ""
        Me.txtApellidoMaterno.Text = ""
        Me.txtDniTrabajador.Text = ""
        Me.txtCelularTrabajador.Text = ""
        Me.txtDetalleTrabajador.Text = ""
        Me.txtDireccionTrabajador.Text = ""
        Me.txtCorreoTrabajador.Text = ""


    End Sub
    Public row As Integer
    Private Sub dgTrabajadores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTrabajadores.CellClick
        row = 0
        row = dgTrabajadores.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub btnEliminarGestionTrabajador_Click(sender As Object, e As EventArgs) Handles btnEliminarGestionTrabajador.Click
        Me.dgTrabajadores.Rows.RemoveAt(row)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim auxContador As Integer

        Try
            Me.idEmpleado = Me.auxIdEmpleado
            auxContador = auxIdEmpleado

            For Each fila In dgTrabajadores.Rows
                auxContador = auxContador + 1
                fila.Cells("id").Value = auxContador

            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelarRegistroTra_Click(sender As Object, e As EventArgs) Handles btnCancelarRegistroTra.Click
        dgTrabajadores.Rows.Clear()
    End Sub

    Private Sub btnActualizarEmpleado_Click(sender As Object, e As EventArgs) Handles btnActualizarEmpleado.Click
        Dim formActualizarEmpleado As New FormActualizarEmpleado
        Call formActualizarEmpleado.Show()
    End Sub
End Class