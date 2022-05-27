Public Class FormMenuElejirGestionUsuarios
    Dim elejirGestionUsuarios As String

    Private Sub btnUsuariosCliente_Click(sender As Object, e As EventArgs) Handles btnUsuariosCliente.Click
        elejirGestionUsuarios = "GESTIONAR_USUARIOS_CLIENTE"
        Dim formGestionUsuarios As New FormGestionUsuarios(elejirGestionUsuarios)
        Call formGestionUsuarios.Show()

    End Sub

    Private Sub btnUsuariosEmpleado_Click(sender As Object, e As EventArgs) Handles btnUsuariosEmpleado.Click
        elejirGestionUsuarios = "GESTIONAR_USUARIOS_EMPLEADO"
        Dim formGestionUsuarios As New FormGestionUsuarios(elejirGestionUsuarios)
        Call formGestionUsuarios.Show()
    End Sub
End Class