Public Class FormMenuTipoPersona
    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim formIngresarDNIEmpleado As New FormIngresarDNIEmpleado
        Call formIngresarDNIEmpleado.Show()
        Me.Hide()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Dim formregistrarUsuarioCliente As New FormRegistrarUsuarioCliente
        formregistrarUsuarioCliente.Show()
        Me.Hide()
    End Sub
End Class