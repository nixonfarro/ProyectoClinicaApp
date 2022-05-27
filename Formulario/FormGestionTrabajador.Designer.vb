<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestionTrabajador
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnActualizarEmpleado = New System.Windows.Forms.Button()
        Me.btnIngresarGestionTrabajador = New System.Windows.Forms.Button()
        Me.btnEliminarGestionTrabajador = New System.Windows.Forms.Button()
        Me.txtDetalleTrabajador = New System.Windows.Forms.TextBox()
        Me.cbTipoEmpleado = New System.Windows.Forms.ComboBox()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNacimientoTrabajador = New System.Windows.Forms.DateTimePicker()
        Me.txtCorreoTrabajador = New System.Windows.Forms.TextBox()
        Me.txtDireccionTrabajador = New System.Windows.Forms.TextBox()
        Me.txtCelularTrabajador = New System.Windows.Forms.TextBox()
        Me.txtDniTrabajador = New System.Windows.Forms.TextBox()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgTrabajadores = New System.Windows.Forms.DataGridView()
        Me.btnGuardarGestionTrabajador = New System.Windows.Forms.Button()
        Me.btnCancelarRegistroTra = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.btnActualizarEmpleado)
        Me.Panel1.Controls.Add(Me.btnIngresarGestionTrabajador)
        Me.Panel1.Controls.Add(Me.btnEliminarGestionTrabajador)
        Me.Panel1.Controls.Add(Me.txtDetalleTrabajador)
        Me.Panel1.Controls.Add(Me.cbTipoEmpleado)
        Me.Panel1.Controls.Add(Me.cbArea)
        Me.Panel1.Controls.Add(Me.cbSexo)
        Me.Panel1.Controls.Add(Me.DTPFechaNacimientoTrabajador)
        Me.Panel1.Controls.Add(Me.txtCorreoTrabajador)
        Me.Panel1.Controls.Add(Me.txtDireccionTrabajador)
        Me.Panel1.Controls.Add(Me.txtCelularTrabajador)
        Me.Panel1.Controls.Add(Me.txtDniTrabajador)
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
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 327)
        Me.Panel1.TabIndex = 0
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
        'btnIngresarGestionTrabajador
        '
        Me.btnIngresarGestionTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarGestionTrabajador.ForeColor = System.Drawing.Color.Teal
        Me.btnIngresarGestionTrabajador.Location = New System.Drawing.Point(788, 252)
        Me.btnIngresarGestionTrabajador.Name = "btnIngresarGestionTrabajador"
        Me.btnIngresarGestionTrabajador.Size = New System.Drawing.Size(149, 56)
        Me.btnIngresarGestionTrabajador.TabIndex = 15
        Me.btnIngresarGestionTrabajador.Text = "Ingresar en tabla"
        Me.btnIngresarGestionTrabajador.UseVisualStyleBackColor = True
        '
        'btnEliminarGestionTrabajador
        '
        Me.btnEliminarGestionTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarGestionTrabajador.ForeColor = System.Drawing.Color.Red
        Me.btnEliminarGestionTrabajador.Location = New System.Drawing.Point(788, 161)
        Me.btnEliminarGestionTrabajador.Name = "btnEliminarGestionTrabajador"
        Me.btnEliminarGestionTrabajador.Size = New System.Drawing.Size(149, 56)
        Me.btnEliminarGestionTrabajador.TabIndex = 14
        Me.btnEliminarGestionTrabajador.Text = "Eliminar Fila"
        Me.btnEliminarGestionTrabajador.UseVisualStyleBackColor = True
        '
        'txtDetalleTrabajador
        '
        Me.txtDetalleTrabajador.Location = New System.Drawing.Point(535, 99)
        Me.txtDetalleTrabajador.Name = "txtDetalleTrabajador"
        Me.txtDetalleTrabajador.Size = New System.Drawing.Size(153, 22)
        Me.txtDetalleTrabajador.TabIndex = 13
        '
        'cbTipoEmpleado
        '
        Me.cbTipoEmpleado.FormattingEnabled = True
        Me.cbTipoEmpleado.Location = New System.Drawing.Point(531, 162)
        Me.cbTipoEmpleado.Name = "cbTipoEmpleado"
        Me.cbTipoEmpleado.Size = New System.Drawing.Size(157, 24)
        Me.cbTipoEmpleado.TabIndex = 12
        '
        'cbArea
        '
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(531, 50)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(157, 24)
        Me.cbArea.TabIndex = 11
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(531, 12)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(157, 24)
        Me.cbSexo.TabIndex = 10
        '
        'DTPFechaNacimientoTrabajador
        '
        Me.DTPFechaNacimientoTrabajador.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaNacimientoTrabajador.Location = New System.Drawing.Point(189, 161)
        Me.DTPFechaNacimientoTrabajador.Name = "DTPFechaNacimientoTrabajador"
        Me.DTPFechaNacimientoTrabajador.Size = New System.Drawing.Size(137, 22)
        Me.DTPFechaNacimientoTrabajador.TabIndex = 9
        '
        'txtCorreoTrabajador
        '
        Me.txtCorreoTrabajador.Location = New System.Drawing.Point(531, 260)
        Me.txtCorreoTrabajador.Name = "txtCorreoTrabajador"
        Me.txtCorreoTrabajador.Size = New System.Drawing.Size(157, 22)
        Me.txtCorreoTrabajador.TabIndex = 8
        '
        'txtDireccionTrabajador
        '
        Me.txtDireccionTrabajador.Location = New System.Drawing.Point(531, 206)
        Me.txtDireccionTrabajador.Name = "txtDireccionTrabajador"
        Me.txtDireccionTrabajador.Size = New System.Drawing.Size(157, 22)
        Me.txtDireccionTrabajador.TabIndex = 7
        '
        'txtCelularTrabajador
        '
        Me.txtCelularTrabajador.Location = New System.Drawing.Point(189, 252)
        Me.txtCelularTrabajador.Name = "txtCelularTrabajador"
        Me.txtCelularTrabajador.Size = New System.Drawing.Size(137, 22)
        Me.txtCelularTrabajador.TabIndex = 6
        '
        'txtDniTrabajador
        '
        Me.txtDniTrabajador.Location = New System.Drawing.Point(189, 214)
        Me.txtDniTrabajador.Name = "txtDniTrabajador"
        Me.txtDniTrabajador.Size = New System.Drawing.Size(137, 22)
        Me.txtDniTrabajador.TabIndex = 5
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(158, 100)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(168, 22)
        Me.txtApellidoMaterno.TabIndex = 3
        '
        'txtApellidoPaternoTrabajador
        '
        Me.txtApellidoPaternoTrabajador.Location = New System.Drawing.Point(155, 52)
        Me.txtApellidoPaternoTrabajador.Name = "txtApellidoPaternoTrabajador"
        Me.txtApellidoPaternoTrabajador.Size = New System.Drawing.Size(171, 22)
        Me.txtApellidoPaternoTrabajador.TabIndex = 2
        '
        'txtNombreTrabajador
        '
        Me.txtNombreTrabajador.Location = New System.Drawing.Point(155, 10)
        Me.txtNombreTrabajador.Name = "txtNombreTrabajador"
        Me.txtNombreTrabajador.Size = New System.Drawing.Size(171, 22)
        Me.txtNombreTrabajador.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 100)
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
        Me.Label12.Location = New System.Drawing.Point(400, 161)
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
        Me.Label11.Location = New System.Drawing.Point(400, 101)
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
        Me.Label10.Location = New System.Drawing.Point(401, 54)
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
        Me.Label9.Location = New System.Drawing.Point(400, 12)
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
        Me.Label8.Location = New System.Drawing.Point(397, 262)
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
        Me.Label7.Location = New System.Drawing.Point(397, 206)
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
        Me.Label6.Location = New System.Drawing.Point(13, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Celular:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 161)
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
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'dgTrabajadores
        '
        Me.dgTrabajadores.AllowUserToAddRows = False
        Me.dgTrabajadores.AllowUserToOrderColumns = True
        Me.dgTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTrabajadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTrabajadores.Location = New System.Drawing.Point(0, 327)
        Me.dgTrabajadores.Name = "dgTrabajadores"
        Me.dgTrabajadores.RowHeadersWidth = 51
        Me.dgTrabajadores.RowTemplate.Height = 24
        Me.dgTrabajadores.Size = New System.Drawing.Size(997, 301)
        Me.dgTrabajadores.TabIndex = 1
        '
        'btnGuardarGestionTrabajador
        '
        Me.btnGuardarGestionTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarGestionTrabajador.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnGuardarGestionTrabajador.Location = New System.Drawing.Point(845, 3)
        Me.btnGuardarGestionTrabajador.Name = "btnGuardarGestionTrabajador"
        Me.btnGuardarGestionTrabajador.Size = New System.Drawing.Size(140, 39)
        Me.btnGuardarGestionTrabajador.TabIndex = 2
        Me.btnGuardarGestionTrabajador.Text = "Guardar"
        Me.btnGuardarGestionTrabajador.UseVisualStyleBackColor = True
        '
        'btnCancelarRegistroTra
        '
        Me.btnCancelarRegistroTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarRegistroTra.Location = New System.Drawing.Point(3, 0)
        Me.btnCancelarRegistroTra.Name = "btnCancelarRegistroTra"
        Me.btnCancelarRegistroTra.Size = New System.Drawing.Size(109, 38)
        Me.btnCancelarRegistroTra.TabIndex = 3
        Me.btnCancelarRegistroTra.Text = "Cancelar"
        Me.btnCancelarRegistroTra.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancelarRegistroTra)
        Me.Panel2.Controls.Add(Me.btnGuardarGestionTrabajador)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 577)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 51)
        Me.Panel2.TabIndex = 4
        '
        'FormGestionTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 628)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgTrabajadores)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormGestionTrabajador"
        Me.Text = "FormGestionAdministrador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCorreoTrabajador As TextBox
    Friend WithEvents txtDireccionTrabajador As TextBox
    Friend WithEvents txtCelularTrabajador As TextBox
    Friend WithEvents txtDniTrabajador As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtApellidoPaternoTrabajador As TextBox
    Friend WithEvents txtNombreTrabajador As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DTPFechaNacimientoTrabajador As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents txtDetalleTrabajador As TextBox
    Friend WithEvents cbTipoEmpleado As ComboBox
    Friend WithEvents cbArea As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dgTrabajadores As DataGridView
    Friend WithEvents btnIngresarGestionTrabajador As Button
    Friend WithEvents btnEliminarGestionTrabajador As Button
    Friend WithEvents btnGuardarGestionTrabajador As Button
    Friend WithEvents btnCancelarRegistroTra As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnActualizarEmpleado As Button
End Class
