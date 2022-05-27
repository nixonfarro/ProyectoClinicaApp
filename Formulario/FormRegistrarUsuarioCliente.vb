Imports CapaEntidad
Imports CapaNegocio
Public Class FormRegistrarUsuarioCliente
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim idPaciente As Integer
    Dim dt As DataTable
    Private Sub FormRegistrarUsuarioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = objNegocio.Neg_obtenerTotalClientes
        Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
        idPaciente = CInt(row("ID"))

        'llenar en cbSexo
        Me.cbSexo.Items.Add("MASCULINO")
        Me.cbSexo.Items.Add("FEMENINO")
    End Sub

    Private Sub btnIngresarPaciente_Click(sender As Object, e As EventArgs) Handles btnIngresarPaciente.Click
        Dim verificacion As Integer
        verificacion = -1
        Dim newIdPaciente As Integer
        newIdPaciente = Me.idPaciente + 1

        Try
            objEntidad.id_paciente = newIdPaciente
            objEntidad.nombre = txtNombrePaciente.Text
            objEntidad.apellido_paterno = txtApellidoPaternoPaciente.Text
            objEntidad.apellido_materno = txtApellidoMaterno.Text
            objEntidad.fecha_nacimiento = DTPFechaNacimientoPaciente.Value
            objEntidad.dni = Convert.ToInt32(txtDniPaciente.Text)
            objEntidad.celular = Convert.ToInt32(txtCelularPaciente.Text)
            If Me.cbSexo.SelectedItem.Equals("MASCULINO") Then
                objEntidad.sexo = 0
            ElseIf Me.cbSexo.SelectedItem.Equals("FEMENINO") Then
                objEntidad.sexo = 1
            End If

            objEntidad.detalle = txtDetallePaciente.Text
            objEntidad.direccion = txtDireccionPaciente.Text
            objEntidad.correo = txtCorreoPaciente.Text
            objEntidad.id_tipo_usuario = 2
            objEntidad.Usuario = txtUsuarioCliente.Text
            objEntidad.Password = txtPasswordCliente.Text

            verificacion = objNegocio.Neg_registrarUsuarioCliente(objEntidad)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If verificacion <> -1 Then

            MessageBox.Show("Se registro correctamente, volviendo a la ventana LOGIN ")
            Dim formLogin As New FormLogin
            Call formLogin.Show()

            Me.Hide()

        Else
            MessageBox.Show("Error de registro")

        End If



    End Sub
End Class