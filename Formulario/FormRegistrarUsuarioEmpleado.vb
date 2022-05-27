Imports CapaEntidad
Imports CapaNegocio
Public Class FormRegistrarUsuarioEmpleado
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim idPersona As Integer


    Public Sub New(_objEntidad As CpEntidad)
        'obtenemos el tipo de usuario logeado 
        InitializeComponent()
        Me.txtNombreEmpleado.Text = _objEntidad.nombre
        Me.txtDniEmpleado.Text = Convert.ToString(_objEntidad.dni)
        idPersona = _objEntidad.id_persona

    End Sub

    Private Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        Dim verificacion As Integer
        verificacion = -1

        Try
            objEntidad.id_persona = Me.idPersona
            'SE DEFINIRA EL TIPO DE USUARIO PARA EL EMPLEADO COMO INVITADO, SE PUEDE CAMBIAR EL 
            'TIPO DE UN USUARIO EN GESTION DE USUARIOS SIEMPRE Y CUANDO SEA EL ADMINISTRADOR
            objEntidad.id_tipo_usuario = 2
            objEntidad.Usuario = Me.txtUsuarioEmpleado.Text
            objEntidad.Password = Me.txtpassEmpleado.Text

            verificacion = objNegocio.Neg_RegistrarUsuario(objEntidad)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If verificacion <> -1 Then

            MessageBox.Show("Se Registro correctamente su Usuario, Volviendo a la ventana de LOGIN")
            Dim formLogin As New FormLogin
            Call formLogin.Show()

            Me.Hide()

        Else
            MessageBox.Show("Error de Registro")

        End If
    End Sub


End Class