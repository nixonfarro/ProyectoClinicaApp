Imports CapaEntidad
Imports CapaNegocio
Public Class FormRegistrarCitaMedica
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim idEmpleado As Integer
    Dim idCliente As Integer
    Dim idcita As Integer
    Dim auxidcita As Integer
    Dim tipo_acceso As String

    Public Sub New(tipo_acceso_ As String)
        Me.tipo_acceso = tipo_acceso_
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FormRegistrarCitaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrara datos en cbArea

        Me.cbArea.DataSource = objNegocio.Neg_ListarArea
        Me.cbArea.ValueMember = "id_tipo_area"
        Me.cbArea.DisplayMember = "nombre_tipo_area"

        'mostrara datos en cbTipoServicio
        Me.cbTipoServicio.DataSource = objNegocio.Neg_listarServiciosClinicos
        Me.cbTipoServicio.ValueMember = "id_servicio_clinico"
        Me.cbTipoServicio.DisplayMember = "nombre_servicio"



        Dim dtaux As DataTable
        dtaux = objNegocio.Neg_obtenerTotalTablaCita
        Dim row As DataRow = dtaux.Rows(dtaux.Rows.Count - 1)
        idcita = CInt(row("ID"))
        auxidcita = idcita

        Me.dgCitas.Columns.Add("id", "ID")
        Me.dgCitas.Columns.Add("id_empleado", "ID empleado")
        Me.dgCitas.Columns.Add("id_cliente", "ID Cliente")
        Me.dgCitas.Columns.Add("id_tipo_area", "ID TIPO AREA")
        Me.dgCitas.Columns.Add("fecha_atencion", "Fecha Atencion")
        Me.dgCitas.Columns.Add("detalle_cita", "Detalle")
        Me.dgCitas.Columns.Add("id_servicio_clinico", "ID  Servicio clinico")
        Me.dgCitas.Columns.Add("precio", "Precio")



    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        Dim dni As Integer
        Dim dt As DataTable

        dni = Convert.ToInt32(Me.txtdniEmpleado.Text)

        dt = objNegocio.Neg_buscarEmpleadoDNI(dni)


        If dt IsNot Nothing Then
            MessageBox.Show(" Se encontro DNI")
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
            idEmpleado = CInt(row("id_empleado"))
            Me.txtNombreEmpleado.Text = CStr(row("nombre"))

        Else
            MessageBox.Show("NO SE ENCONTRO DNI, INTENTE OTRA VEZ")
        End If


    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim dni As Integer
        Dim dt As DataTable
        dni = Convert.ToInt32(Me.txtDniCliente.Text)
        dt = objNegocio.Neg_buscarClienteDNI(dni)

        If dt IsNot Nothing Then
            MessageBox.Show(" Se encontro DNI")
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
            idCliente = CInt(row("id_cliente"))
            Me.txtNombreCliente.Text = CStr(row("nombre"))

        Else

            MessageBox.Show("NO SE ENCONTRO DNI, INTENTE OTRA VEZ")
        End If



    End Sub

    Private Sub btnIngresarRegistroCita_Click(sender As Object, e As EventArgs) Handles btnIngresarRegistroCita.Click
        Me.idcita = Me.idcita + 1
        Me.dgCitas.Rows.Add(Me.idcita, Me.idEmpleado, Me.idCliente, Me.cbArea.SelectedValue, Me.DTPFechaAtencion.Value, txtDetalleCita.Text, Me.cbTipoServicio.SelectedValue, txtPrecioServicio.Text)

        Me.txtdniEmpleado.Text = ""
        Me.txtDniCliente.Text = ""
        Me.txtDetalleCita.Text = ""
        Me.txtNombreEmpleado.Text = ""
        Me.txtNombreCliente.Text = ""
        Me.txtPrecioServicio.Text = ""

        Me.idEmpleado = 0
        Me.idCliente = 0
    End Sub


    Public row As Integer
    Private Sub dgCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCitas.CellClick
        row = 0
        row = dgCitas.CurrentCell.RowIndex.ToString()
    End Sub



    Private Sub btnEliminarRegistroCita_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistroCita.Click
        Me.dgCitas.Rows.RemoveAt(row)
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim auxContador As Integer

        Try
            Me.idcita = Me.auxidcita
            auxContador = auxidcita

            For Each fila In dgCitas.Rows
                auxContador = auxContador + 1
                fila.Cells("id").Value = auxContador
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardarRegistroCita_Click(sender As Object, e As EventArgs) Handles btnGuardarRegistroCita.Click
        Dim verificacion As Integer
        verificacion = -1
        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try
            For Each fila In dgCitas.Rows
                objEntidad.id_cita = Convert.ToInt32(fila.Cells("id").Value)
                objEntidad.id_empleado = Convert.ToInt32(fila.Cells("id_empleado").Value)
                objEntidad.id_cliente = Convert.ToInt32(fila.Cells("id_cliente").Value)
                objEntidad.id_tipo_area = Convert.ToInt32(fila.Cells("id_tipo_area").Value)
                objEntidad.fecha_atencion = Convert.ToDateTime(fila.Cells("fecha_atencion").Value)
                objEntidad.detalle_cita = Convert.ToString(fila.Cells("detalle_cita").Value)
                objEntidad.id_servicio_clinico = Convert.ToInt32(fila.Cells("id_servicio_clinico").Value)

                verificacion = objNegocio.Neg_RegistrarCita(objEntidad)

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If verificacion <> -1 Then

            MessageBox.Show("Se agrego correctamente todos los registros")

        Else
            MessageBox.Show("Error de Ingreso")

        End If
        dgCitas.Rows.Clear()
    End Sub

    Private Sub btnCancelarRegistroCita_Click(sender As Object, e As EventArgs) Handles btnCancelarRegistroCita.Click
        dgCitas.Rows.Clear()
    End Sub

    Private Sub cbTipoServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoServicio.SelectedIndexChanged
        Dim dtaux As DataTable
        Dim aux As Integer
        Dim result As Boolean = Int32.TryParse(cbTipoServicio.SelectedValue.ToString, aux)
        If result Then
            dtaux = objNegocio.Neg_obtenerServicioClinico(aux)
            Dim row As DataRow = dtaux.Rows(dtaux.Rows.Count - 1)
            txtPrecioServicio.Text = CStr(row("precio"))
        Else

        End If





    End Sub

    Private Sub btnBuscarCitaMedica_Click(sender As Object, e As EventArgs) Handles btnBuscarCitaMedica.Click
        Dim FormBuscarCita As New FormBuscarCitaMedica(Me.tipo_acceso)
        Call FormBuscarCita.Show()
    End Sub
End Class