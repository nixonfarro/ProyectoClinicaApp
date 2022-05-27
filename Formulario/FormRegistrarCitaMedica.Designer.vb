<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarCitaMedica
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
        Me.btnBuscarCliente = New FontAwesome.Sharp.IconButton()
        Me.btnBuscarEmpleado = New FontAwesome.Sharp.IconButton()
        Me.btnBuscarCitaMedica = New System.Windows.Forms.Button()
        Me.btnIngresarRegistroCita = New System.Windows.Forms.Button()
        Me.btnEliminarRegistroCita = New System.Windows.Forms.Button()
        Me.txtDetalleCita = New System.Windows.Forms.TextBox()
        Me.cbTipoServicio = New System.Windows.Forms.ComboBox()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.DTPFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtDniCliente = New System.Windows.Forms.TextBox()
        Me.txtPrecioServicio = New System.Windows.Forms.TextBox()
        Me.txtdniEmpleado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgCitas = New System.Windows.Forms.DataGridView()
        Me.btnCancelarRegistroCita = New System.Windows.Forms.Button()
        Me.btnGuardarRegistroCita = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.btnBuscarCliente)
        Me.Panel1.Controls.Add(Me.btnBuscarEmpleado)
        Me.Panel1.Controls.Add(Me.btnBuscarCitaMedica)
        Me.Panel1.Controls.Add(Me.btnIngresarRegistroCita)
        Me.Panel1.Controls.Add(Me.btnEliminarRegistroCita)
        Me.Panel1.Controls.Add(Me.txtDetalleCita)
        Me.Panel1.Controls.Add(Me.cbTipoServicio)
        Me.Panel1.Controls.Add(Me.cbArea)
        Me.Panel1.Controls.Add(Me.DTPFechaAtencion)
        Me.Panel1.Controls.Add(Me.txtNombreCliente)
        Me.Panel1.Controls.Add(Me.txtNombreEmpleado)
        Me.Panel1.Controls.Add(Me.txtDniCliente)
        Me.Panel1.Controls.Add(Me.txtPrecioServicio)
        Me.Panel1.Controls.Add(Me.txtdniEmpleado)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 327)
        Me.Panel1.TabIndex = 1
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscarCliente.IconColor = System.Drawing.Color.Black
        Me.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscarCliente.IconSize = 40
        Me.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCliente.Location = New System.Drawing.Point(429, 68)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(160, 42)
        Me.btnBuscarCliente.TabIndex = 16
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscarEmpleado.IconColor = System.Drawing.Color.Black
        Me.btnBuscarEmpleado.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscarEmpleado.IconSize = 40
        Me.btnBuscarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(429, 3)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(160, 42)
        Me.btnBuscarEmpleado.TabIndex = 16
        Me.btnBuscarEmpleado.Text = "Buscar"
        Me.btnBuscarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'btnBuscarCitaMedica
        '
        Me.btnBuscarCitaMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCitaMedica.ForeColor = System.Drawing.Color.Teal
        Me.btnBuscarCitaMedica.Location = New System.Drawing.Point(1013, 15)
        Me.btnBuscarCitaMedica.Name = "btnBuscarCitaMedica"
        Me.btnBuscarCitaMedica.Size = New System.Drawing.Size(179, 56)
        Me.btnBuscarCitaMedica.TabIndex = 15
        Me.btnBuscarCitaMedica.Text = "Buscar Cita Medica"
        Me.btnBuscarCitaMedica.UseVisualStyleBackColor = True
        '
        'btnIngresarRegistroCita
        '
        Me.btnIngresarRegistroCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarRegistroCita.ForeColor = System.Drawing.Color.Teal
        Me.btnIngresarRegistroCita.Location = New System.Drawing.Point(1013, 252)
        Me.btnIngresarRegistroCita.Name = "btnIngresarRegistroCita"
        Me.btnIngresarRegistroCita.Size = New System.Drawing.Size(179, 56)
        Me.btnIngresarRegistroCita.TabIndex = 15
        Me.btnIngresarRegistroCita.Text = "Ingresar tabla"
        Me.btnIngresarRegistroCita.UseVisualStyleBackColor = True
        '
        'btnEliminarRegistroCita
        '
        Me.btnEliminarRegistroCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRegistroCita.ForeColor = System.Drawing.Color.Red
        Me.btnEliminarRegistroCita.Location = New System.Drawing.Point(1013, 161)
        Me.btnEliminarRegistroCita.Name = "btnEliminarRegistroCita"
        Me.btnEliminarRegistroCita.Size = New System.Drawing.Size(179, 56)
        Me.btnEliminarRegistroCita.TabIndex = 14
        Me.btnEliminarRegistroCita.Text = "Eliminar Fila"
        Me.btnEliminarRegistroCita.UseVisualStyleBackColor = True
        '
        'txtDetalleCita
        '
        Me.txtDetalleCita.Location = New System.Drawing.Point(154, 240)
        Me.txtDetalleCita.Name = "txtDetalleCita"
        Me.txtDetalleCita.Size = New System.Drawing.Size(344, 22)
        Me.txtDetalleCita.TabIndex = 13
        '
        'cbTipoServicio
        '
        Me.cbTipoServicio.FormattingEnabled = True
        Me.cbTipoServicio.Location = New System.Drawing.Point(817, 142)
        Me.cbTipoServicio.Name = "cbTipoServicio"
        Me.cbTipoServicio.Size = New System.Drawing.Size(157, 24)
        Me.cbTipoServicio.TabIndex = 11
        '
        'cbArea
        '
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(150, 142)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(157, 24)
        Me.cbArea.TabIndex = 11
        '
        'DTPFechaAtencion
        '
        Me.DTPFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaAtencion.Location = New System.Drawing.Point(194, 195)
        Me.DTPFechaAtencion.Name = "DTPFechaAtencion"
        Me.DTPFechaAtencion.Size = New System.Drawing.Size(137, 22)
        Me.DTPFechaAtencion.TabIndex = 9
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Enabled = False
        Me.txtNombreCliente.Location = New System.Drawing.Point(803, 80)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(168, 22)
        Me.txtNombreCliente.TabIndex = 3
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(803, 15)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(171, 22)
        Me.txtNombreEmpleado.TabIndex = 2
        '
        'txtDniCliente
        '
        Me.txtDniCliente.Location = New System.Drawing.Point(242, 78)
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(171, 22)
        Me.txtDniCliente.TabIndex = 1
        '
        'txtPrecioServicio
        '
        Me.txtPrecioServicio.Enabled = False
        Me.txtPrecioServicio.Location = New System.Drawing.Point(817, 189)
        Me.txtPrecioServicio.Name = "txtPrecioServicio"
        Me.txtPrecioServicio.Size = New System.Drawing.Size(109, 22)
        Me.txtPrecioServicio.TabIndex = 1
        '
        'txtdniEmpleado
        '
        Me.txtdniEmpleado.Location = New System.Drawing.Point(242, 13)
        Me.txtdniEmpleado.Name = "txtdniEmpleado"
        Me.txtdniEmpleado.Size = New System.Drawing.Size(171, 22)
        Me.txtdniEmpleado.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(645, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(779, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "S/."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(621, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Precio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(621, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo Servicio clinico"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(19, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Detalle Cita:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(20, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Area:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha de atencion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ingrese Dni de Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(645, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Dni de Empleado:"
        '
        'dgCitas
        '
        Me.dgCitas.AllowUserToAddRows = False
        Me.dgCitas.AllowUserToOrderColumns = True
        Me.dgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCitas.Location = New System.Drawing.Point(0, 327)
        Me.dgCitas.Name = "dgCitas"
        Me.dgCitas.RowHeadersWidth = 51
        Me.dgCitas.RowTemplate.Height = 24
        Me.dgCitas.Size = New System.Drawing.Size(1204, 341)
        Me.dgCitas.TabIndex = 2
        '
        'btnCancelarRegistroCita
        '
        Me.btnCancelarRegistroCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarRegistroCita.Location = New System.Drawing.Point(12, 16)
        Me.btnCancelarRegistroCita.Name = "btnCancelarRegistroCita"
        Me.btnCancelarRegistroCita.Size = New System.Drawing.Size(109, 38)
        Me.btnCancelarRegistroCita.TabIndex = 5
        Me.btnCancelarRegistroCita.Text = "Cancelar"
        Me.btnCancelarRegistroCita.UseVisualStyleBackColor = True
        '
        'btnGuardarRegistroCita
        '
        Me.btnGuardarRegistroCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarRegistroCita.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnGuardarRegistroCita.Location = New System.Drawing.Point(1052, 15)
        Me.btnGuardarRegistroCita.Name = "btnGuardarRegistroCita"
        Me.btnGuardarRegistroCita.Size = New System.Drawing.Size(140, 39)
        Me.btnGuardarRegistroCita.TabIndex = 4
        Me.btnGuardarRegistroCita.Text = "Registrar"
        Me.btnGuardarRegistroCita.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancelarRegistroCita)
        Me.Panel2.Controls.Add(Me.btnGuardarRegistroCita)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 610)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1204, 58)
        Me.Panel2.TabIndex = 6
        '
        'FormRegistrarCitaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 668)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgCitas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormRegistrarCitaMedica"
        Me.Text = "Registrar Cita Medica"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnIngresarRegistroCita As Button
    Friend WithEvents btnEliminarRegistroCita As Button
    Friend WithEvents txtDetalleCita As TextBox
    Friend WithEvents cbArea As ComboBox
    Friend WithEvents DTPFechaAtencion As DateTimePicker
    Friend WithEvents txtdniEmpleado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgCitas As DataGridView
    Friend WithEvents btnCancelarRegistroCita As Button
    Friend WithEvents btnGuardarRegistroCita As Button
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscarEmpleado As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBuscarCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents txtPrecioServicio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTipoServicio As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDniCliente As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBuscarCitaMedica As Button
End Class
