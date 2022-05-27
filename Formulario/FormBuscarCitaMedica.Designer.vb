<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarCitaMedica
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
        Me.dgCitas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarCliente = New FontAwesome.Sharp.IconButton()
        Me.btnAnularCitaMedica = New System.Windows.Forms.Button()
        Me.txtApellidosEmpleado = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtDniCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCitas
        '
        Me.dgCitas.AllowUserToAddRows = False
        Me.dgCitas.AllowUserToOrderColumns = True
        Me.dgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCitas.Location = New System.Drawing.Point(0, 220)
        Me.dgCitas.Name = "dgCitas"
        Me.dgCitas.RowHeadersWidth = 51
        Me.dgCitas.RowTemplate.Height = 24
        Me.dgCitas.Size = New System.Drawing.Size(1243, 392)
        Me.dgCitas.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.btnBuscarCliente)
        Me.Panel1.Controls.Add(Me.btnAnularCitaMedica)
        Me.Panel1.Controls.Add(Me.txtApellidosEmpleado)
        Me.Panel1.Controls.Add(Me.txtNombreEmpleado)
        Me.Panel1.Controls.Add(Me.txtDniCliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1243, 220)
        Me.Panel1.TabIndex = 3
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscarCliente.IconColor = System.Drawing.Color.Black
        Me.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscarCliente.IconSize = 40
        Me.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCliente.Location = New System.Drawing.Point(490, 24)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(160, 42)
        Me.btnBuscarCliente.TabIndex = 16
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnAnularCitaMedica
        '
        Me.btnAnularCitaMedica.BackColor = System.Drawing.Color.MintCream
        Me.btnAnularCitaMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnularCitaMedica.ForeColor = System.Drawing.Color.Red
        Me.btnAnularCitaMedica.Location = New System.Drawing.Point(1026, 24)
        Me.btnAnularCitaMedica.Name = "btnAnularCitaMedica"
        Me.btnAnularCitaMedica.Size = New System.Drawing.Size(179, 56)
        Me.btnAnularCitaMedica.TabIndex = 15
        Me.btnAnularCitaMedica.Text = "Anular Cita Medica"
        Me.btnAnularCitaMedica.UseVisualStyleBackColor = False
        '
        'txtApellidosEmpleado
        '
        Me.txtApellidosEmpleado.Enabled = False
        Me.txtApellidosEmpleado.Location = New System.Drawing.Point(743, 143)
        Me.txtApellidosEmpleado.Name = "txtApellidosEmpleado"
        Me.txtApellidosEmpleado.Size = New System.Drawing.Size(232, 22)
        Me.txtApellidosEmpleado.TabIndex = 3
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(743, 104)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(232, 22)
        Me.txtNombreEmpleado.TabIndex = 3
        '
        'txtDniCliente
        '
        Me.txtDniCliente.Location = New System.Drawing.Point(257, 39)
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(196, 22)
        Me.txtDniCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(585, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(585, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre Empleado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ingrese Dni de Cliente:"
        '
        'FormBuscarCitaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 612)
        Me.Controls.Add(Me.dgCitas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormBuscarCitaMedica"
        Me.Text = "FormBuscarCitaMedica"
        CType(Me.dgCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgCitas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscarCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAnularCitaMedica As Button
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents txtDniCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellidosEmpleado As TextBox
    Friend WithEvents Label1 As Label
End Class
