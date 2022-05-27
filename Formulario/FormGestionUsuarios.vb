Imports CapaEntidad
Imports CapaNegocio
Public Class FormGestionUsuarios
    Dim gestionUsuarios As String
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim idusuario As Integer = -1

    Public Sub New(elejirGestionUsuarios As String)
        'obtenemos el tipo de usuario logeado 
        InitializeComponent()
        gestionUsuarios = elejirGestionUsuarios

    End Sub

    Private Sub FormGestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbTipoUsuario.DataSource = objNegocio.Neg_ListarTipoUsuario
        Me.cbTipoUsuario.ValueMember = "id_tipo_usuario"
        Me.cbTipoUsuario.DisplayMember = "nombre_tipo_usuario"

        If gestionUsuarios.Equals("GESTIONAR_USUARIOS_CLIENTE") Then
            Me.Text = "GESTIONAR USUARIOS DE CLIENTES"
            Me.cbDni.DataSource = objNegocio.Neg_listarClientes
            Me.cbDni.ValueMember = "id_persona"
            Me.cbDni.DisplayMember = "dni"

            dgUsuarios.DataSource = objNegocio.Neg_listarClientesUsuarios

        ElseIf gestionUsuarios.Equals("GESTIONAR_USUARIOS_EMPLEADO") Then
            Me.Text = "GESTIONAR USUARIOS DE EMPLEADOS"
            Me.cbDni.DataSource = objNegocio.Neg_listarEmpleados
            Me.cbDni.ValueMember = "id_persona"
            Me.cbDni.DisplayMember = "dni"

            dgUsuarios.DataSource = objNegocio.Neg_listarEmpleadosUsuarios
        End If
    End Sub

    Private Sub cbDni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDni.SelectedIndexChanged
        Dim dtaux As DataTable
        Dim aux As Integer

        Dim result As Boolean = Int32.TryParse(cbDni.SelectedValue.ToString, aux)

        If result Then
            dtaux = objNegocio.Neg_obtenerDatosPersonaPorID(aux)
            Dim row As DataRow = dtaux.Rows(dtaux.Rows.Count - 1)
            Me.txtNombre.Text = CStr(row("nombre"))
        End If

    End Sub

    Private Sub btnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click
        txtUsuarioGU.Text = ""
        txtPasswordGU.Text = ""
        Me.idusuario = -1
    End Sub

    Private Sub limpiar()
        txtUsuarioGU.Text = ""
        txtPasswordGU.Text = ""
        Me.idusuario = -1
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Dim verificacion As Integer
        verificacion = -1

        If txtUsuarioGU.Equals("") And txtPasswordGU.Equals("") Then
            MessageBox.Show("..::Debe ingresar usuario o contraseña::..")
        Else
            Try
                objEntidad.id_persona = cbDni.SelectedValue
                objEntidad.id_tipo_usuario = cbTipoUsuario.SelectedValue
                objEntidad.Usuario = txtUsuarioGU.Text
                objEntidad.Password = txtPasswordGU.Text

                verificacion = objNegocio.Neg_RegistrarUsuario(objEntidad)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            If verificacion <> -1 Then

                MessageBox.Show("Se Registro Correctamente al usuario")

                If gestionUsuarios.Equals("GESTIONAR_USUARIOS_CLIENTE") Then

                    dgUsuarios.DataSource = objNegocio.Neg_listarClientesUsuarios
                ElseIf gestionUsuarios.Equals("GESTIONAR_USUARIOS_EMPLEADO") Then
                    dgUsuarios.DataSource = objNegocio.Neg_listarEmpleadosUsuarios


                End If
                Call limpiar()
            Else
                MessageBox.Show("Error de Ingreso")

            End If

        End If
    End Sub

    Private Sub btnActualizarUsuario_Click(sender As Object, e As EventArgs) Handles btnActualizarUsuario.Click
        If Me.idusuario <> -1 Then
            Dim verificacion As Integer
            verificacion = -1
            If txtUsuarioGU.Equals("") And txtPasswordGU.Equals("") Then
                MessageBox.Show("..::Debe ingresar usuario o contraseña::..")
            Else
                Try
                    objEntidad.id_usuario = Me.idusuario
                    objEntidad.id_persona = cbDni.SelectedValue
                    objEntidad.id_tipo_usuario = cbTipoUsuario.SelectedValue
                    objEntidad.Usuario = txtUsuarioGU.Text
                    objEntidad.Password = txtPasswordGU.Text

                    verificacion = objNegocio.Neg_ActualizarUsuario(objEntidad)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                If verificacion <> -1 Then

                    MessageBox.Show("Se actualizo Correctamente al usuario")

                    If gestionUsuarios.Equals("GESTIONAR_USUARIOS_CLIENTE") Then

                        dgUsuarios.DataSource = objNegocio.Neg_listarClientesUsuarios
                    ElseIf gestionUsuarios.Equals("GESTIONAR_USUARIOS_EMPLEADO") Then
                        dgUsuarios.DataSource = objNegocio.Neg_listarEmpleadosUsuarios


                    End If
                    Call limpiar()
                Else
                    MessageBox.Show("Error de actualizar")

                End If
            End If
        Else
            MessageBox.Show("SELECCIONE UNA FILA DE LA TABLA")

        End If




    End Sub

    Private Sub dgUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellClick
        Me.idusuario = CInt(dgUsuarios.SelectedCells(8).Value)
        Me.txtUsuarioGU.Text = dgUsuarios.SelectedCells(5).Value.ToString
        Me.txtPasswordGU.Text = dgUsuarios.SelectedCells(6).Value.ToString
    End Sub

    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        If Me.idusuario <> -1 Then
            Dim verificacion As Integer
            verificacion = -1

            Try
                verificacion = objNegocio.Neg_EliminarUsuario(Me.idusuario)

            Catch ex As Exception

            End Try
            If verificacion <> -1 Then

                MessageBox.Show("Se elimino Correctamente al usuario")
                If gestionUsuarios.Equals("GESTIONAR_USUARIOS_CLIENTE") Then

                    dgUsuarios.DataSource = objNegocio.Neg_listarClientesUsuarios
                ElseIf gestionUsuarios.Equals("GESTIONAR_USUARIOS_EMPLEADO") Then
                    dgUsuarios.DataSource = objNegocio.Neg_listarEmpleadosUsuarios


                End If

                Call limpiar()

            Else
                MessageBox.Show("Error de Ingreso")

            End If

        Else
            MessageBox.Show("SELECCIONE UNA FILA DE LA TABLA")

        End If

    End Sub
End Class