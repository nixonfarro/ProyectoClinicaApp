<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PNBorde = New System.Windows.Forms.Panel()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.PnIzquierdo = New System.Windows.Forms.Panel()
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.PSubMenuReportes = New System.Windows.Forms.Panel()
        Me.btnReportCitasMedicas = New FontAwesome.Sharp.IconButton()
        Me.btnReportServiciosClinicos = New FontAwesome.Sharp.IconButton()
        Me.IBReportes = New FontAwesome.Sharp.IconButton()
        Me.PSubMenuAdmin = New System.Windows.Forms.Panel()
        Me.BTNActualizarServicioClinico = New FontAwesome.Sharp.IconButton()
        Me.GestionarUsuarios = New FontAwesome.Sharp.IconButton()
        Me.IBRegistrarCitaMedica = New FontAwesome.Sharp.IconButton()
        Me.IBGestionPaciente = New FontAwesome.Sharp.IconButton()
        Me.IBGestionTrabajador = New FontAwesome.Sharp.IconButton()
        Me.IBAdmin = New FontAwesome.Sharp.IconButton()
        Me.PLogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.PTitulo = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.IPTitulo = New FontAwesome.Sharp.IconPictureBox()
        Me.PNBase = New System.Windows.Forms.Panel()
        Me.PBCentral = New System.Windows.Forms.PictureBox()
        Me.PNBorde.SuspendLayout()
        Me.PnIzquierdo.SuspendLayout()
        Me.PMenu.SuspendLayout()
        Me.PSubMenuReportes.SuspendLayout()
        Me.PSubMenuAdmin.SuspendLayout()
        Me.PLogo.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PTitulo.SuspendLayout()
        CType(Me.IPTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNBase.SuspendLayout()
        CType(Me.PBCentral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNBorde
        '
        Me.PNBorde.Controls.Add(Me.LUsuario)
        Me.PNBorde.Controls.Add(Me.BSalir)
        Me.PNBorde.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNBorde.Location = New System.Drawing.Point(0, 703)
        Me.PNBorde.Margin = New System.Windows.Forms.Padding(4)
        Me.PNBorde.Name = "PNBorde"
        Me.PNBorde.Size = New System.Drawing.Size(1464, 34)
        Me.PNBorde.TabIndex = 1
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.Location = New System.Drawing.Point(17, 9)
        Me.LUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(0, 17)
        Me.LUsuario.TabIndex = 1
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(1325, 4)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(100, 28)
        Me.BSalir.TabIndex = 0
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'PnIzquierdo
        '
        Me.PnIzquierdo.Controls.Add(Me.PMenu)
        Me.PnIzquierdo.Controls.Add(Me.PLogo)
        Me.PnIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnIzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.PnIzquierdo.Margin = New System.Windows.Forms.Padding(4)
        Me.PnIzquierdo.Name = "PnIzquierdo"
        Me.PnIzquierdo.Size = New System.Drawing.Size(351, 703)
        Me.PnIzquierdo.TabIndex = 2
        '
        'PMenu
        '
        Me.PMenu.AutoScroll = True
        Me.PMenu.Controls.Add(Me.PSubMenuReportes)
        Me.PMenu.Controls.Add(Me.IBReportes)
        Me.PMenu.Controls.Add(Me.PSubMenuAdmin)
        Me.PMenu.Controls.Add(Me.IBAdmin)
        Me.PMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PMenu.Location = New System.Drawing.Point(0, 74)
        Me.PMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(347, 629)
        Me.PMenu.TabIndex = 3
        '
        'PSubMenuReportes
        '
        Me.PSubMenuReportes.Controls.Add(Me.btnReportCitasMedicas)
        Me.PSubMenuReportes.Controls.Add(Me.btnReportServiciosClinicos)
        Me.PSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSubMenuReportes.Location = New System.Drawing.Point(0, 379)
        Me.PSubMenuReportes.Margin = New System.Windows.Forms.Padding(4)
        Me.PSubMenuReportes.Name = "PSubMenuReportes"
        Me.PSubMenuReportes.Size = New System.Drawing.Size(347, 103)
        Me.PSubMenuReportes.TabIndex = 5
        '
        'btnReportCitasMedicas
        '
        Me.btnReportCitasMedicas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportCitasMedicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportCitasMedicas.IconChar = FontAwesome.Sharp.IconChar.FileSignature
        Me.btnReportCitasMedicas.IconColor = System.Drawing.Color.Black
        Me.btnReportCitasMedicas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportCitasMedicas.Location = New System.Drawing.Point(0, 52)
        Me.btnReportCitasMedicas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReportCitasMedicas.Name = "btnReportCitasMedicas"
        Me.btnReportCitasMedicas.Size = New System.Drawing.Size(347, 51)
        Me.btnReportCitasMedicas.TabIndex = 1
        Me.btnReportCitasMedicas.Text = "Citas Medicas"
        Me.btnReportCitasMedicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportCitasMedicas.UseVisualStyleBackColor = True
        '
        'btnReportServiciosClinicos
        '
        Me.btnReportServiciosClinicos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportServiciosClinicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportServiciosClinicos.IconChar = FontAwesome.Sharp.IconChar.FileSignature
        Me.btnReportServiciosClinicos.IconColor = System.Drawing.Color.Black
        Me.btnReportServiciosClinicos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportServiciosClinicos.Location = New System.Drawing.Point(0, 0)
        Me.btnReportServiciosClinicos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReportServiciosClinicos.Name = "btnReportServiciosClinicos"
        Me.btnReportServiciosClinicos.Size = New System.Drawing.Size(347, 52)
        Me.btnReportServiciosClinicos.TabIndex = 0
        Me.btnReportServiciosClinicos.Text = "Servicios Clinicos"
        Me.btnReportServiciosClinicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportServiciosClinicos.UseVisualStyleBackColor = True
        '
        'IBReportes
        '
        Me.IBReportes.BackColor = System.Drawing.Color.LightSeaGreen
        Me.IBReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBReportes.ForeColor = System.Drawing.Color.White
        Me.IBReportes.IconChar = FontAwesome.Sharp.IconChar.FolderPlus
        Me.IBReportes.IconColor = System.Drawing.Color.Black
        Me.IBReportes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IBReportes.Location = New System.Drawing.Point(0, 327)
        Me.IBReportes.Margin = New System.Windows.Forms.Padding(4)
        Me.IBReportes.Name = "IBReportes"
        Me.IBReportes.Size = New System.Drawing.Size(347, 52)
        Me.IBReportes.TabIndex = 4
        Me.IBReportes.Text = "Reportes"
        Me.IBReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBReportes.UseVisualStyleBackColor = False
        '
        'PSubMenuAdmin
        '
        Me.PSubMenuAdmin.Controls.Add(Me.BTNActualizarServicioClinico)
        Me.PSubMenuAdmin.Controls.Add(Me.GestionarUsuarios)
        Me.PSubMenuAdmin.Controls.Add(Me.IBRegistrarCitaMedica)
        Me.PSubMenuAdmin.Controls.Add(Me.IBGestionPaciente)
        Me.PSubMenuAdmin.Controls.Add(Me.IBGestionTrabajador)
        Me.PSubMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PSubMenuAdmin.Location = New System.Drawing.Point(0, 55)
        Me.PSubMenuAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.PSubMenuAdmin.Name = "PSubMenuAdmin"
        Me.PSubMenuAdmin.Size = New System.Drawing.Size(347, 272)
        Me.PSubMenuAdmin.TabIndex = 1
        '
        'BTNActualizarServicioClinico
        '
        Me.BTNActualizarServicioClinico.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNActualizarServicioClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNActualizarServicioClinico.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.BTNActualizarServicioClinico.IconColor = System.Drawing.Color.Black
        Me.BTNActualizarServicioClinico.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTNActualizarServicioClinico.IconSize = 40
        Me.BTNActualizarServicioClinico.Location = New System.Drawing.Point(0, 214)
        Me.BTNActualizarServicioClinico.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNActualizarServicioClinico.Name = "BTNActualizarServicioClinico"
        Me.BTNActualizarServicioClinico.Size = New System.Drawing.Size(347, 58)
        Me.BTNActualizarServicioClinico.TabIndex = 5
        Me.BTNActualizarServicioClinico.Text = "Actualizar Servicio Clinico"
        Me.BTNActualizarServicioClinico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNActualizarServicioClinico.UseVisualStyleBackColor = True
        '
        'GestionarUsuarios
        '
        Me.GestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.GestionarUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarUsuarios.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.GestionarUsuarios.IconColor = System.Drawing.Color.Black
        Me.GestionarUsuarios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.GestionarUsuarios.IconSize = 40
        Me.GestionarUsuarios.Location = New System.Drawing.Point(0, 156)
        Me.GestionarUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.GestionarUsuarios.Name = "GestionarUsuarios"
        Me.GestionarUsuarios.Size = New System.Drawing.Size(347, 58)
        Me.GestionarUsuarios.TabIndex = 4
        Me.GestionarUsuarios.Text = "Gestionar Usuarios"
        Me.GestionarUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GestionarUsuarios.UseVisualStyleBackColor = True
        '
        'IBRegistrarCitaMedica
        '
        Me.IBRegistrarCitaMedica.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBRegistrarCitaMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBRegistrarCitaMedica.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.IBRegistrarCitaMedica.IconColor = System.Drawing.Color.Black
        Me.IBRegistrarCitaMedica.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBRegistrarCitaMedica.IconSize = 40
        Me.IBRegistrarCitaMedica.Location = New System.Drawing.Point(0, 104)
        Me.IBRegistrarCitaMedica.Margin = New System.Windows.Forms.Padding(4)
        Me.IBRegistrarCitaMedica.Name = "IBRegistrarCitaMedica"
        Me.IBRegistrarCitaMedica.Size = New System.Drawing.Size(347, 52)
        Me.IBRegistrarCitaMedica.TabIndex = 3
        Me.IBRegistrarCitaMedica.Text = "Gestionar Cita Medica"
        Me.IBRegistrarCitaMedica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBRegistrarCitaMedica.UseVisualStyleBackColor = True
        '
        'IBGestionPaciente
        '
        Me.IBGestionPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBGestionPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBGestionPaciente.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.IBGestionPaciente.IconColor = System.Drawing.Color.Black
        Me.IBGestionPaciente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBGestionPaciente.IconSize = 40
        Me.IBGestionPaciente.Location = New System.Drawing.Point(0, 52)
        Me.IBGestionPaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.IBGestionPaciente.Name = "IBGestionPaciente"
        Me.IBGestionPaciente.Size = New System.Drawing.Size(347, 52)
        Me.IBGestionPaciente.TabIndex = 1
        Me.IBGestionPaciente.Text = "Registro Paciente"
        Me.IBGestionPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBGestionPaciente.UseVisualStyleBackColor = True
        '
        'IBGestionTrabajador
        '
        Me.IBGestionTrabajador.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBGestionTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBGestionTrabajador.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.IBGestionTrabajador.IconColor = System.Drawing.Color.Black
        Me.IBGestionTrabajador.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBGestionTrabajador.IconSize = 40
        Me.IBGestionTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.IBGestionTrabajador.Margin = New System.Windows.Forms.Padding(4)
        Me.IBGestionTrabajador.Name = "IBGestionTrabajador"
        Me.IBGestionTrabajador.Size = New System.Drawing.Size(347, 52)
        Me.IBGestionTrabajador.TabIndex = 0
        Me.IBGestionTrabajador.Text = "Registro Trabajador"
        Me.IBGestionTrabajador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBGestionTrabajador.UseVisualStyleBackColor = True
        '
        'IBAdmin
        '
        Me.IBAdmin.BackColor = System.Drawing.Color.LightSeaGreen
        Me.IBAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.IBAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBAdmin.ForeColor = System.Drawing.Color.White
        Me.IBAdmin.IconChar = FontAwesome.Sharp.IconChar.Clipboard
        Me.IBAdmin.IconColor = System.Drawing.Color.Black
        Me.IBAdmin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBAdmin.IconSize = 40
        Me.IBAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IBAdmin.Location = New System.Drawing.Point(0, 0)
        Me.IBAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.IBAdmin.Name = "IBAdmin"
        Me.IBAdmin.Size = New System.Drawing.Size(347, 55)
        Me.IBAdmin.TabIndex = 0
        Me.IBAdmin.Text = "Administracion"
        Me.IBAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IBAdmin.UseVisualStyleBackColor = False
        '
        'PLogo
        '
        Me.PLogo.Controls.Add(Me.Label1)
        Me.PLogo.Controls.Add(Me.PBLogo)
        Me.PLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogo.Location = New System.Drawing.Point(0, 0)
        Me.PLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(351, 74)
        Me.PLogo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGO"
        '
        'PBLogo
        '
        Me.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBLogo.Image = Global.ClinicaApp.My.Resources.Resources.WhatsApp_Image_2022_05_23_at_12_16_56_AM
        Me.PBLogo.Location = New System.Drawing.Point(0, 0)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(351, 74)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBLogo.TabIndex = 0
        Me.PBLogo.TabStop = False
        '
        'PTitulo
        '
        Me.PTitulo.Controls.Add(Me.LTitulo)
        Me.PTitulo.Controls.Add(Me.IPTitulo)
        Me.PTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitulo.Location = New System.Drawing.Point(351, 0)
        Me.PTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.PTitulo.Name = "PTitulo"
        Me.PTitulo.Size = New System.Drawing.Size(1113, 70)
        Me.PTitulo.TabIndex = 3
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(87, 25)
        Me.LTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(0, 17)
        Me.LTitulo.TabIndex = 1
        '
        'IPTitulo
        '
        Me.IPTitulo.BackColor = System.Drawing.Color.White
        Me.IPTitulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IPTitulo.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IPTitulo.IconColor = System.Drawing.SystemColors.ControlText
        Me.IPTitulo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IPTitulo.IconSize = 59
        Me.IPTitulo.Location = New System.Drawing.Point(11, 4)
        Me.IPTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.IPTitulo.Name = "IPTitulo"
        Me.IPTitulo.Size = New System.Drawing.Size(68, 59)
        Me.IPTitulo.TabIndex = 0
        Me.IPTitulo.TabStop = False
        '
        'PNBase
        '
        Me.PNBase.Controls.Add(Me.PBCentral)
        Me.PNBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNBase.Location = New System.Drawing.Point(351, 70)
        Me.PNBase.Margin = New System.Windows.Forms.Padding(4)
        Me.PNBase.Name = "PNBase"
        Me.PNBase.Size = New System.Drawing.Size(1113, 633)
        Me.PNBase.TabIndex = 4
        '
        'PBCentral
        '
        Me.PBCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBCentral.Location = New System.Drawing.Point(0, 0)
        Me.PBCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PBCentral.Name = "PBCentral"
        Me.PBCentral.Size = New System.Drawing.Size(1113, 633)
        Me.PBCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBCentral.TabIndex = 0
        Me.PBCentral.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1464, 737)
        Me.Controls.Add(Me.PNBase)
        Me.Controls.Add(Me.PTitulo)
        Me.Controls.Add(Me.PnIzquierdo)
        Me.Controls.Add(Me.PNBorde)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClinicaApp"
        Me.TopMost = True
        Me.PNBorde.ResumeLayout(False)
        Me.PNBorde.PerformLayout()
        Me.PnIzquierdo.ResumeLayout(False)
        Me.PMenu.ResumeLayout(False)
        Me.PSubMenuReportes.ResumeLayout(False)
        Me.PSubMenuAdmin.ResumeLayout(False)
        Me.PLogo.ResumeLayout(False)
        Me.PLogo.PerformLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PTitulo.ResumeLayout(False)
        Me.PTitulo.PerformLayout()
        CType(Me.IPTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNBase.ResumeLayout(False)
        CType(Me.PBCentral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PNBorde As Panel
    Friend WithEvents PnIzquierdo As Panel
    Friend WithEvents LUsuario As Label
    Friend WithEvents BSalir As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents PLogo As Panel
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents PTitulo As Panel
    Friend WithEvents LTitulo As Label
    Friend WithEvents IPTitulo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PNBase As Panel
    Friend WithEvents PBCentral As PictureBox

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenu()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PMenu As Panel
    Friend WithEvents PSubMenuReportes As Panel
    Friend WithEvents btnReportCitasMedicas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReportServiciosClinicos As FontAwesome.Sharp.IconButton
    Friend WithEvents IBReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents PSubMenuAdmin As Panel
    Friend WithEvents IBGestionPaciente As FontAwesome.Sharp.IconButton
    Friend WithEvents IBGestionTrabajador As FontAwesome.Sharp.IconButton
    Friend WithEvents IBAdmin As FontAwesome.Sharp.IconButton
    Friend WithEvents IBRegistrarCitaMedica As FontAwesome.Sharp.IconButton
    Friend WithEvents GestionarUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents BTNActualizarServicioClinico As FontAwesome.Sharp.IconButton
End Class
