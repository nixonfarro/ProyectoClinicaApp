Imports CapaEntidad
Imports CapaNegocio
Imports System.Runtime.InteropServices
Public Class FormLogin
#Region "Form Behaviors"


    'Definir variables globales; estas van despues de la linea de inherits
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio

    Private Sub BLoginCancelar_Click(sender As Object, e As EventArgs) Handles BLoginCancelar.Click
        End
    End Sub


    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Dim dt As New DataTable
        Dim datarow As DataRow
        Dim tipo_acceso As String

        objEntidad.Usuario = txtusuario.Text
        objEntidad.Password = txtpass.Text

        dt = objNegocio.Neg_Login(objEntidad)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show(".::INICIO DE SESION COMPLETADA::..")
            datarow = dt.Rows(dt.Rows.Count - 1)
            tipo_acceso = CStr(datarow("nombre_tipo_usuario"))
            Dim VentanaPrincipal As New FormPrincipal(tipo_acceso)

            Call VentanaPrincipal.Show()

            Me.Hide()

        Else
            MessageBox.Show("ERROR. Debe verificar usuario o contraseña")

        End If

    End Sub



#End Region






#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub



    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub FormLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

#Region "customize Controls"
    Private Sub CustomizeComponents()
        Me.txtusuario.AutoSize = False
        txtusuario.Size = New Size(260, 35)

        txtpass.AutoSize = False
        txtpass.Size = New Size(260, 35)
        txtpass.UseSystemPasswordChar = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim formMenuTipoPersona As New FormMenuTipoPersona
        Call formMenuTipoPersona.Show()
        Me.Hide()
    End Sub

#End Region
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        CustomizeComponents()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

End Class



