Imports CapaEntidad
Imports CapaNegocio
Public Class FormIngresarDNIEmpleado
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Private Sub btnAceptarDNIEmpleado_Click(sender As Object, e As EventArgs) Handles btnAceptarDNIEmpleado.Click
        Dim dni As Integer
        Dim dt As DataTable
        dni = Convert.ToInt32(txtDniEmpleado.Text)
        dt = objNegocio.Neg_buscarEmpleadoDNI(dni)

        If dt IsNot Nothing Then
            MessageBox.Show(" Se encontro DNI")
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

            objEntidad.id_persona = CInt(row("id_persona"))
            objEntidad.dni = CInt(row("dni"))
            objEntidad.nombre = CStr(row("nombre"))

            Dim formRegistrarUsuarioEmpleado As New FormRegistrarUsuarioEmpleado(objEntidad)
            Call formRegistrarUsuarioEmpleado.Show()

            Me.Hide()

        Else

            MessageBox.Show("NO SE ENCONTRO DNI, INTENTE OTRA VEZ")

        End If
    End Sub


End Class