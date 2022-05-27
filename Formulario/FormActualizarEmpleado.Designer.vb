<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActualizarEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarDniEmpleado = New FontAwesome.Sharp.IconButton()
        Me.txtDNIEmpleado = New System.Windows.Forms.TextBox()
        Me.btnActualizarEmpleado = New System.Windows.Forms.Button()
        Me.txtDetalleTrabajador = New System.Windows.Forms.TextBox()
        Me.cbTipoEmpleado = New System.Windows.Forms.ComboBox()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNacimientoTrabajador = New System.Windows.Forms.DateTimePicker()
        Me.txtCorreoTrabajador = New System.Windows.Forms.TextBox()
        Me.txtDireccionTrabajador = New System.Windows.Forms.TextBox()
        Me.txtCelularTrabajador = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaternoTrabajador = New System.Windows.Forms.TextBox()
        Me.txtNombreTrabajador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.btnBuscarDniEmpleado)
        Me.Panel1.Controls.Add(Me.txtDNIEmpleado)
        Me.Panel1.Controls.Add(Me.btnActualizarEmpleado)
        Me.Panel1.Controls.Add(Me.txtDetalleTrabajador)
        Me.Panel1.Controls.Add(Me.cbTipoEmpleado)
        Me.Panel1.Controls.Add(Me.cbArea)
        Me.Panel1.Controls.Add(Me.cbSexo)
        Me.Panel1.Controls.Add(Me.DTPFechaNacimientoTrabajador)
        Me.Panel1.Controls.Add(Me.txtCorreoTrabajador)
        Me.Panel1.Controls.Add(Me.txtDireccionTrabajador)
        Me.Panel1.Controls.Add(Me.txtCelularTrabajador)
        Me.Panel1.Controls.Add(Me.txtApellidoMaterno)
        Me.Panel1.Controls.Add(Me.txtApellidoPaternoTrabajador)
        Me.Panel1.Controls.Add(Me.txtNombreTrabajador)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 393)
        Me.Panel1.TabIndex = 1
        '
        'btnBuscarDniEmpleado
        '
        Me.btnBuscarDniEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDniEmpleado.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscarDniEmpleado.IconColor = System.Drawing.Color.Black
        Me.btnBuscarDniEmpleado.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscarDniEmpleado.IconSize = 40
        Me.btnBuscarDniEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarDniEmpleado.Location = New System.Drawing.Point(370, 11)
        Me.btnBuscarDniEmpleado.Name = "btnBuscarDniEmpleado"
        Me.btnBuscarDniEmpleado.Size = New System.Drawing.Size(139, 42)
        Me.btnBuscarDniEmpleado.TabIndex = 18
        Me.btnBuscarDniEmpleado.Text = "Buscar"
        Me.btnBuscarDniEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarDniEmpleado.UseVisualStyleBackColor = True
        '
        'txtDNIEmpleado
        '
        Me.txtDNIEmpleado.Location = New System.Drawing.Point(160, 21)
        Me.txtDNIEmpleado.Name = "txtDNIEmpleado"
        Me.txtDNIEmpleado.Size = New System.Drawing.Size(171, 22)
        Me.txtDNIEmpleado.TabIndex = 17
        '
        'btnActualizarEmpleado
        '
        Me.btnActualizarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarEmpleado.ForeColor = System.Drawing.Color.Teal
        Me.btnActualizarEmpleado.Location = New System.Drawing.Point(788, 54)
        Me.btnActualizarEmpleado.Name = "btnActualizarEmpleado"
        Me.btnActualizarEmpleado.Size = New System.Drawing.Size(149, 68)
        Me.btnActualizarEmpleado.TabIndex = 16
        Me.btnActualizarEmpleado.Text = "Actualizar Empleado"
        Me.btnActualizarEmpleado.UseVisualStyleBackColor = True
        '
        'txtDetalleTrabajador
        '
        Me.txtDetalleTrabajador.Location = New System.Drawing.Point(540, 151)
        Me.txtDetalleTrabajador.Name = "txtDetalleTrabajador"
        Me.txtDetalleTrabajador.Size = New System.Drawing.Size(153, 22)
        Me.txtDetalleTrabajador.TabIndex = 13
        '
        'cbTipoEmpleado
        '
        Me.cbTipoEmpleado.FormattingEnabled = True
        Me.cbTipoEmpleado.Location = New System.Drawing.Point(536, 214)
        Me.cbTipoEmpleado.Name = "cbTipoEmpleado"
        Me.cbTipoEmpleado.Size = New System.Drawing.Size(157, 24)
        Me.cbTipoEmpleado.TabIndex = 12
        '
        'cbArea
        '
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(536, 102)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(157, 24)
        Me.cbArea.TabIndex = 11
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(536, 64)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(157, 24)
        Me.cbSexo.TabIndex = 10
        '
        'DTPFechaNacimientoTrabajador
        '
        Me.DTPFechaNacimientoTrabajador.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaNacimientoTrabajador.Location = New System.Drawing.Point(194, 213)
        Me.DTPFechaNacimientoTrabajador.Name = "DTPFechaNacimientoTrabajador"
        Me.DTPFechaNacimientoTrabajador.Size = New System.Drawing.Size(137, 22)
        Me.DTPFechaNacimientoTrabajador.TabIndex = 9
        '
        'txtCorreoTrabajador
        '
        Me.txtCorreoTrabajador.Location = New System.Drawing.Point(536, 312)
        Me.txtCorreoTrabajador.Name = "txtCorreoTrabajador"
        Me.txtCorreoTrabajador.Size = New System.Drawing.Size(157, 22)
        Me.txtCorreoTrabajador.TabIndex = 8
        '
        'txtDireccionTrabajador
        '
        Me.txtDireccionTrabajador.Location = New System.Drawing.Point(536, 258)
        Me.txtDireccionTrabajador.Name = "txtDireccionTrabajador"
        Me.txtDireccionTrabajador.Size = New System.Drawing.Size(157, 22)
        Me.txtDireccionTrabajador.TabIndex = 7
        '
        'txtCelularTrabajador
        '
        Me.txtCelularTrabajador.Location = New System.Drawing.Point(194, 267)
        Me.txtCelularTrabajador.Name = "txtCelularTrabajador"
        Me.txtCelularTrabajador.Size = New System.Drawing.Size(137, 22)
        Me.txtCelularTrabajador.TabIndex = 6
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(163, 152)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(168, 22)
        Me.txtApellidoMaterno.TabIndex = 3
        '
        'txtApellidoPaternoTrabajador
        '
        Me.txtApellidoPaternoTrabajador.Location = New System.Drawing.Point(160, 104)
        Me.txtApellidoPaternoTrabajador.Name = "txtApellidoPaternoTrabajador"
        Me.txtApellidoPaternoTrabajador.Size = New System.Drawing.Size(171, 22)
        Me.txtApellidoPaternoTrabajador.TabIndex = 2
        '
        'txtNombreTrabajador
        '
        Me.txtNombreTrabajador.Location = New System.Drawing.Point(160, 62)
        Me.txtNombreTrabajador.Name = "txtNombreTrabajador"
        Me.txtNombreTrabajador.Size = New System.Drawing.Size(171, 22)
        Me.txtNombreTrabajador.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(405, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Tipo Empleado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(405, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Detalle:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(406, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Area:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(405, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sexo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(402, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Correo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(402, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Dirección:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Celular:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha de nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(18, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Ingrese DNI :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'FormActualizarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 393)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormActualizarEmpleado"
        Me.Text = "Actualizar Empleado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnActualizarEmpleado As Button
    Friend WithEvents txtDetalleTrabajador As TextBox
    Friend WithEvents cbTipoEmpleado As ComboBox
    Friend WithEvents cbArea As ComboBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents DTPFechaNacimientoTrabajador As DateTimePicker
    Friend WithEvents txtCorreoTrabajador As TextBox
    Friend WithEvents txtDireccionTrabajador As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtApellidoPaternoTrabajador As TextBox
    Friend WithEvents txtNombreTrabajador As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDNIEmpleado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnBuscarDniEmpleado As FontAwesome.Sharp.IconButton
    Friend WithEvents txtCelularTrabajador As TextBox
    Friend WithEvents Label6 As Label
End Class
