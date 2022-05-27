<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarUsuarioEmpleado
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
        Me.txtDniEmpleado = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.btnRegistrarUsuario = New System.Windows.Forms.Button()
        Me.txtpassEmpleado = New System.Windows.Forms.TextBox()
        Me.txtUsuarioEmpleado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.txtDniEmpleado)
        Me.Panel1.Controls.Add(Me.txtNombreEmpleado)
        Me.Panel1.Controls.Add(Me.btnRegistrarUsuario)
        Me.Panel1.Controls.Add(Me.txtpassEmpleado)
        Me.Panel1.Controls.Add(Me.txtUsuarioEmpleado)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 248)
        Me.Panel1.TabIndex = 1
        '
        'txtDniEmpleado
        '
        Me.txtDniEmpleado.Enabled = False
        Me.txtDniEmpleado.Location = New System.Drawing.Point(451, 25)
        Me.txtDniEmpleado.Name = "txtDniEmpleado"
        Me.txtDniEmpleado.Size = New System.Drawing.Size(163, 22)
        Me.txtDniEmpleado.TabIndex = 16
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(187, 25)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(163, 22)
        Me.txtNombreEmpleado.TabIndex = 16
        '
        'btnRegistrarUsuario
        '
        Me.btnRegistrarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarUsuario.ForeColor = System.Drawing.Color.Teal
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(427, 136)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(153, 64)
        Me.btnRegistrarUsuario.TabIndex = 15
        Me.btnRegistrarUsuario.Text = "Registrar Usuario"
        Me.btnRegistrarUsuario.UseVisualStyleBackColor = True
        '
        'txtpassEmpleado
        '
        Me.txtpassEmpleado.Location = New System.Drawing.Point(179, 178)
        Me.txtpassEmpleado.Name = "txtpassEmpleado"
        Me.txtpassEmpleado.Size = New System.Drawing.Size(171, 22)
        Me.txtpassEmpleado.TabIndex = 2
        '
        'txtUsuarioEmpleado
        '
        Me.txtUsuarioEmpleado.Location = New System.Drawing.Point(179, 136)
        Me.txtUsuarioEmpleado.Name = "txtUsuarioEmpleado"
        Me.txtUsuarioEmpleado.Size = New System.Drawing.Size(171, 22)
        Me.txtUsuarioEmpleado.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(402, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DNI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'FormRegistrarUsuarioEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 248)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormRegistrarUsuarioEmpleado"
        Me.Text = "Registrar Usuario de Empleado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegistrarUsuario As Button
    Friend WithEvents txtpassEmpleado As TextBox
    Friend WithEvents txtUsuarioEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDniEmpleado As TextBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
