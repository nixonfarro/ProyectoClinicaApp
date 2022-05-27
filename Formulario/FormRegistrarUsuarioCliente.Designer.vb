<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarUsuarioCliente
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
        Me.btnIngresarPaciente = New System.Windows.Forms.Button()
        Me.txtDetallePaciente = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNacimientoPaciente = New System.Windows.Forms.DateTimePicker()
        Me.txtCorreoPaciente = New System.Windows.Forms.TextBox()
        Me.txtDireccionPaciente = New System.Windows.Forms.TextBox()
        Me.txtCelularPaciente = New System.Windows.Forms.TextBox()
        Me.txtDniPaciente = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaternoPaciente = New System.Windows.Forms.TextBox()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUsuarioCliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPasswordCliente = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.btnIngresarPaciente)
        Me.Panel1.Controls.Add(Me.txtDetallePaciente)
        Me.Panel1.Controls.Add(Me.cbSexo)
        Me.Panel1.Controls.Add(Me.DTPFechaNacimientoPaciente)
        Me.Panel1.Controls.Add(Me.txtPasswordCliente)
        Me.Panel1.Controls.Add(Me.txtUsuarioCliente)
        Me.Panel1.Controls.Add(Me.txtCorreoPaciente)
        Me.Panel1.Controls.Add(Me.txtDireccionPaciente)
        Me.Panel1.Controls.Add(Me.txtCelularPaciente)
        Me.Panel1.Controls.Add(Me.txtDniPaciente)
        Me.Panel1.Controls.Add(Me.txtApellidoMaterno)
        Me.Panel1.Controls.Add(Me.txtApellidoPaternoPaciente)
        Me.Panel1.Controls.Add(Me.txtNombrePaciente)
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 328)
        Me.Panel1.TabIndex = 2
        '
        'btnIngresarPaciente
        '
        Me.btnIngresarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarPaciente.ForeColor = System.Drawing.Color.Teal
        Me.btnIngresarPaciente.Location = New System.Drawing.Point(788, 37)
        Me.btnIngresarPaciente.Name = "btnIngresarPaciente"
        Me.btnIngresarPaciente.Size = New System.Drawing.Size(112, 56)
        Me.btnIngresarPaciente.TabIndex = 15
        Me.btnIngresarPaciente.Text = "REGISTRAR"
        Me.btnIngresarPaciente.UseVisualStyleBackColor = True
        '
        'txtDetallePaciente
        '
        Me.txtDetallePaciente.Location = New System.Drawing.Point(535, 52)
        Me.txtDetallePaciente.Name = "txtDetallePaciente"
        Me.txtDetallePaciente.Size = New System.Drawing.Size(153, 22)
        Me.txtDetallePaciente.TabIndex = 13
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(531, 12)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(157, 24)
        Me.cbSexo.TabIndex = 10
        '
        'DTPFechaNacimientoPaciente
        '
        Me.DTPFechaNacimientoPaciente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaNacimientoPaciente.Location = New System.Drawing.Point(189, 161)
        Me.DTPFechaNacimientoPaciente.Name = "DTPFechaNacimientoPaciente"
        Me.DTPFechaNacimientoPaciente.Size = New System.Drawing.Size(137, 22)
        Me.DTPFechaNacimientoPaciente.TabIndex = 9
        '
        'txtCorreoPaciente
        '
        Me.txtCorreoPaciente.Location = New System.Drawing.Point(535, 154)
        Me.txtCorreoPaciente.Name = "txtCorreoPaciente"
        Me.txtCorreoPaciente.Size = New System.Drawing.Size(157, 22)
        Me.txtCorreoPaciente.TabIndex = 8
        '
        'txtDireccionPaciente
        '
        Me.txtDireccionPaciente.Location = New System.Drawing.Point(535, 100)
        Me.txtDireccionPaciente.Name = "txtDireccionPaciente"
        Me.txtDireccionPaciente.Size = New System.Drawing.Size(157, 22)
        Me.txtDireccionPaciente.TabIndex = 7
        '
        'txtCelularPaciente
        '
        Me.txtCelularPaciente.Location = New System.Drawing.Point(189, 252)
        Me.txtCelularPaciente.Name = "txtCelularPaciente"
        Me.txtCelularPaciente.Size = New System.Drawing.Size(137, 22)
        Me.txtCelularPaciente.TabIndex = 6
        '
        'txtDniPaciente
        '
        Me.txtDniPaciente.Location = New System.Drawing.Point(189, 214)
        Me.txtDniPaciente.Name = "txtDniPaciente"
        Me.txtDniPaciente.Size = New System.Drawing.Size(137, 22)
        Me.txtDniPaciente.TabIndex = 5
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(158, 100)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(168, 22)
        Me.txtApellidoMaterno.TabIndex = 3
        '
        'txtApellidoPaternoPaciente
        '
        Me.txtApellidoPaternoPaciente.Location = New System.Drawing.Point(155, 52)
        Me.txtApellidoPaternoPaciente.Name = "txtApellidoPaternoPaciente"
        Me.txtApellidoPaternoPaciente.Size = New System.Drawing.Size(171, 22)
        Me.txtApellidoPaternoPaciente.TabIndex = 2
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(155, 10)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(171, 22)
        Me.txtNombrePaciente.TabIndex = 1
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(400, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Detalle:"
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
        Me.Label8.Location = New System.Drawing.Point(401, 156)
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
        Me.Label7.Location = New System.Drawing.Point(401, 100)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(401, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Usuario:"
        '
        'txtUsuarioCliente
        '
        Me.txtUsuarioCliente.Location = New System.Drawing.Point(535, 195)
        Me.txtUsuarioCliente.Name = "txtUsuarioCliente"
        Me.txtUsuarioCliente.Size = New System.Drawing.Size(157, 22)
        Me.txtUsuarioCliente.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(401, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Contraseña:"
        '
        'txtPasswordCliente
        '
        Me.txtPasswordCliente.Location = New System.Drawing.Point(535, 252)
        Me.txtPasswordCliente.Name = "txtPasswordCliente"
        Me.txtPasswordCliente.Size = New System.Drawing.Size(157, 22)
        Me.txtPasswordCliente.TabIndex = 8
        '
        'FormRegistrarUsuarioCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 328)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormRegistrarUsuarioCliente"
        Me.Text = "Registrar Usuario Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnIngresarPaciente As Button
    Friend WithEvents txtDetallePaciente As TextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents DTPFechaNacimientoPaciente As DateTimePicker
    Friend WithEvents txtCorreoPaciente As TextBox
    Friend WithEvents txtDireccionPaciente As TextBox
    Friend WithEvents txtCelularPaciente As TextBox
    Friend WithEvents txtDniPaciente As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtApellidoPaternoPaciente As TextBox
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPasswordCliente As TextBox
    Friend WithEvents txtUsuarioCliente As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
End Class
