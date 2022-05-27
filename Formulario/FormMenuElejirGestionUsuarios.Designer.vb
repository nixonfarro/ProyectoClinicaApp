<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuElejirGestionUsuarios
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUsuariosCliente = New System.Windows.Forms.Button()
        Me.btnUsuariosEmpleado = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnUsuariosCliente)
        Me.Panel1.Controls.Add(Me.btnUsuariosEmpleado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 312)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.ClinicaApp.My.Resources.Resources.empleado01
        Me.PictureBox2.Location = New System.Drawing.Point(356, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(171, 133)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.ClinicaApp.My.Resources.Resources.cliente
        Me.PictureBox1.Location = New System.Drawing.Point(78, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnUsuariosCliente
        '
        Me.btnUsuariosCliente.BackColor = System.Drawing.Color.White
        Me.btnUsuariosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuariosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosCliente.ForeColor = System.Drawing.Color.Teal
        Me.btnUsuariosCliente.Location = New System.Drawing.Point(56, 192)
        Me.btnUsuariosCliente.Name = "btnUsuariosCliente"
        Me.btnUsuariosCliente.Size = New System.Drawing.Size(171, 70)
        Me.btnUsuariosCliente.TabIndex = 16
        Me.btnUsuariosCliente.Text = "Usuarios de Clientes"
        Me.btnUsuariosCliente.UseVisualStyleBackColor = False
        '
        'btnUsuariosEmpleado
        '
        Me.btnUsuariosEmpleado.BackColor = System.Drawing.Color.White
        Me.btnUsuariosEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuariosEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosEmpleado.ForeColor = System.Drawing.Color.Teal
        Me.btnUsuariosEmpleado.Location = New System.Drawing.Point(356, 192)
        Me.btnUsuariosEmpleado.Name = "btnUsuariosEmpleado"
        Me.btnUsuariosEmpleado.Size = New System.Drawing.Size(199, 70)
        Me.btnUsuariosEmpleado.TabIndex = 16
        Me.btnUsuariosEmpleado.Text = "Usuarios de Empleados"
        Me.btnUsuariosEmpleado.UseVisualStyleBackColor = False
        '
        'FormMenuElejirGestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 312)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMenuElejirGestionUsuarios"
        Me.Text = "Selecionar Gestionar Usuarios:"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUsuariosCliente As Button
    Friend WithEvents btnUsuariosEmpleado As Button
End Class
