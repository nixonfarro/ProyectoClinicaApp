Imports FontAwesome.Sharp
Public Class FormPrincipal

    Private BtnActual As IconButton
    Private LeftBorderBtn As Panel
    Private SubFormulario As Form
    Private tipo_acceso As String

    Private Sub HideSubMenu()
        PSubMenuAdmin.Visible = False
        PSubMenuReportes.Visible = False

    End Sub

    Private Sub ShowSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            HideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False

        End If
    End Sub
    Public Sub New(tipo_acceso_ As String)
        'Inicializamos el tipo de acceso obtenido como parametro. Donde se tendra como tipo
        'de acceso ADMINISTRADOR e INVITADO
        Me.tipo_acceso = tipo_acceso_





        InitializeComponent()




        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LeftBorderBtn = New Panel With {
            .Size = New Size(3, 42)
        }
        PnIzquierdo.Controls.Add(LeftBorderBtn)

    End Sub
    Private Sub ActivateButton(SenderBtn As Object, customcolor As Color)
        If SenderBtn IsNot Nothing Then
            ButtonOff()
            'Creacion de los cambios para el boton
            BtnActual = CType(SenderBtn, IconButton)
            BtnActual.BackColor = Color.FromArgb(245, 222, 0)
            BtnActual.ForeColor = Color.FromArgb(245, 63, 0)
            BtnActual.IconColor = Color.FromArgb(245, 63, 0)
            BtnActual.TextAlign = ContentAlignment.MiddleCenter
            'BtnActual.ImageAlign = ContentAlignment.MiddleCenter
            BtnActual.TextImageRelation = TextImageRelation.TextBeforeImage
            'Cambios para el Borde y el icono principal
            LeftBorderBtn.BackColor = customcolor
            LeftBorderBtn.Visible = False
            LeftBorderBtn.BringToFront()
            LeftBorderBtn.Location = New Point(0, BtnActual.Location.Y)
            IPTitulo.IconChar = BtnActual.IconChar
            IPTitulo.IconColor = Color.ForestGreen
            LTitulo.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub ButtonOff()
        If BtnActual IsNot Nothing Then
            'Codigo para la desactivacion de los cambio
            BtnActual.BackColor = Color.White
            BtnActual.ForeColor = Color.Black
            BtnActual.IconColor = Color.Black
            BtnActual.TextAlign = ContentAlignment.MiddleLeft
            BtnActual.ImageAlign = ContentAlignment.MiddleCenter
            BtnActual.TextImageRelation = TextImageRelation.ImageBeforeText


        End If
    End Sub

    'Para abrir un formulario
    Private Sub OpenForm(Hijo As Form)
        If SubFormulario IsNot Nothing Then
            SubFormulario.Close()
        End If
        SubFormulario = Hijo
        Hijo.TopLevel = False
        Hijo.FormBorderStyle = FormBorderStyle.None
        Hijo.Dock = DockStyle.Fill


        PNBase.Controls.Add(Hijo)
        PNBase.Tag = Hijo
        Hijo.BringToFront()
        Hijo.Show()

    End Sub

    Private Sub IBAdmin_Click(sender As Object, e As EventArgs) Handles IBAdmin.Click
        ShowSubMenu(PSubMenuAdmin)

    End Sub
    Private Sub IBReportes_Click_1(sender As Object, e As EventArgs) Handles IBReportes.Click
        ShowSubMenu(PSubMenuReportes)
    End Sub

    Private Sub IBRegistro_Click(sender As Object, e As EventArgs)
        ShowSubMenu(PSubMenuAdmin)

    End Sub


    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub



    Private Sub IBGestionTrabajador_Click(sender As Object, e As EventArgs) Handles IBGestionTrabajador.Click
        ActivateButton(sender, PaletaRGB.Color5)
        If tipo_acceso.Equals("ADMINISTRADOR") Then
            MessageBox.Show(".:: ACCESO ACEPTADO -- NIVEL DE ACCESO: " & tipo_acceso)
            OpenForm(New FormGestionTrabajador)
            LTitulo.Text = IBGestionTrabajador.Text
        Else
            MessageBox.Show(".:: ACCESO DENEGADO::.  -- NIVEL DE ACCESO: " & tipo_acceso)
        End If

    End Sub

    Private Sub IBGestionPaciente_Click(sender As Object, e As EventArgs) Handles IBGestionPaciente.Click

        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormRegistroPaciente)
        LTitulo.Text = IBGestionPaciente.Text
    End Sub


    Private Sub GestionarUsuarios_Click(sender As Object, e As EventArgs) Handles GestionarUsuarios.Click

        ActivateButton(sender, PaletaRGB.Color5)
        If tipo_acceso.Equals("ADMINISTRADOR") Then
            MessageBox.Show(".:: ACCESO ACEPTADO -- NIVEL DE ACCESO: " & tipo_acceso)
            OpenForm(New FormMenuElejirGestionUsuarios)
            LTitulo.Text = GestionarUsuarios.Text
        Else
            MessageBox.Show(".:: ACCESO DENEGADO::.  -- NIVEL DE ACCESO: " & tipo_acceso)
        End If

    End Sub

    Private Sub IBRegistrarCitaMedica_Click_1(sender As Object, e As EventArgs) Handles IBRegistrarCitaMedica.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormRegistrarCitaMedica(Me.tipo_acceso))
        LTitulo.Text = IBRegistrarCitaMedica.Text
    End Sub

    Private Sub BTNActualizarServicioClinico_Click(sender As Object, e As EventArgs) Handles BTNActualizarServicioClinico.Click
        ActivateButton(sender, PaletaRGB.Color5)
        If tipo_acceso.Equals("ADMINISTRADOR") Then
            MessageBox.Show(".:: ACCESO ACEPTADO -- NIVEL DE ACCESO: " & tipo_acceso)
            OpenForm(New FormActualizarServicioClinico)
            LTitulo.Text = BTNActualizarServicioClinico.Text
        Else
            MessageBox.Show(".:: ACCESO DENEGADO::.  -- NIVEL DE ACCESO: " & tipo_acceso)
        End If

    End Sub

    Private Sub btnReportServiciosClinicos_Click(sender As Object, e As EventArgs) Handles btnReportServiciosClinicos.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormReportesServiciosClinicos)
        LTitulo.Text = btnReportServiciosClinicos.Text
    End Sub

    Private Sub btnReportCitasMedicas_Click(sender As Object, e As EventArgs) Handles btnReportCitasMedicas.Click
        ActivateButton(sender, PaletaRGB.Color5)
        OpenForm(New FormReporteCitas)
        LTitulo.Text = btnReportCitasMedicas.Text
    End Sub
End Class