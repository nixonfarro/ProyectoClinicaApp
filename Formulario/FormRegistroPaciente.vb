Imports CapaEntidad
Imports CapaNegocio
Public Class FormRegistroPaciente
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim idPaciente As Integer
    Dim auxIdPaciente As Integer
    Dim dt As DataTable

    Private Sub FormRegistroPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt = objNegocio.Neg_obtenerTotalClientes
        Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
        idPaciente = CInt(row("ID"))
        auxIdPaciente = idPaciente

        Me.dgPaciente.Columns.Add("id", "ID")
        Me.dgPaciente.Columns.Add("nombre", "Nombre")
        Me.dgPaciente.Columns.Add("Apaterno", "Apellido Paterno")
        Me.dgPaciente.Columns.Add("Amaterno", "Apellido Materno")
        Me.dgPaciente.Columns.Add("Fnacimiento", "Fecha Nacimiento")
        Me.dgPaciente.Columns.Add("dni", "DNI")
        Me.dgPaciente.Columns.Add("celular", "Celular")
        Me.dgPaciente.Columns.Add("sexo", "Sexo")
        Me.dgPaciente.Columns.Add("detalle", "Detalle")
        Me.dgPaciente.Columns.Add("direccion", "direccion")
        Me.dgPaciente.Columns.Add("correo", "Correo")

        'llenar en cbSexo
        Me.cbSexo.Items.Add("MASCULINO")
        Me.cbSexo.Items.Add("FEMENINO")


    End Sub

    Private Sub btnCancelarRegistroPa_Click(sender As Object, e As EventArgs) Handles btnCancelarRegistroPa.Click
        dgPaciente.Rows.Clear()
    End Sub

    Private Sub btnGuardarPaciente_Click(sender As Object, e As EventArgs) Handles btnGuardarPaciente.Click
        Dim verificacion As Integer
        verificacion = -1
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila In dgPaciente.Rows
                objEntidad.id_paciente = Convert.ToInt32(fila.Cells("id").Value)
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

                objEntidad.detalle = Convert.ToString(fila.Cells("detalle").Value)
                objEntidad.direccion = Convert.ToString(fila.Cells("direccion").Value)
                objEntidad.correo = Convert.ToString(fila.Cells("correo").Value)

                verificacion = objNegocio.Neg_RegistrarPaciente(objEntidad)

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If verificacion <> -1 Then

            MessageBox.Show("Se agrego correctamente todos los registros")

        Else
            MessageBox.Show("Error de Ingreso")

        End If
        dgPaciente.Rows.Clear()

    End Sub

    Public row As Integer
    Private Sub dgPaciente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPaciente.CellClick
        row = 0
        row = dgPaciente.CurrentCell.RowIndex.ToString()
    End Sub
    Private Sub btnEliminarPaciente_Click(sender As Object, e As EventArgs) Handles btnEliminarPaciente.Click
        Me.dgPaciente.Rows.RemoveAt(row)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim auxContador As Integer

        Try
            Me.idPaciente = Me.auxIdPaciente
            auxContador = auxIdPaciente

            For Each fila In dgPaciente.Rows
                auxContador = auxContador + 1
                fila.Cells("id").Value = auxContador

            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnIngresarPaciente_Click(sender As Object, e As EventArgs) Handles btnIngresarPaciente.Click
        Me.idPaciente = Me.idPaciente + 1

        Me.dgPaciente.Rows.Add(Me.idPaciente, txtNombrePaciente.Text, txtApellidoPaternoPaciente.Text, txtApellidoMaterno.Text, Me.DTPFechaNacimientoPaciente.Value, txtDniPaciente.Text, txtCelularPaciente.Text, cbSexo.SelectedItem, txtDetallePaciente.Text, txtDireccionPaciente.Text, txtCorreoPaciente.Text)
        Me.txtNombrePaciente.Text = ""
        Me.txtApellidoPaternoPaciente.Text = ""
        Me.txtApellidoMaterno.Text = ""
        Me.txtDniPaciente.Text = ""
        Me.txtCelularPaciente.Text = ""
        Me.txtDetallePaciente.Text = ""
        Me.txtDireccionPaciente.Text = ""
        Me.txtCorreoPaciente.Text = ""
    End Sub
End Class