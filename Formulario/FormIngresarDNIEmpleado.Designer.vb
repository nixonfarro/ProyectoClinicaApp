<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIngresarDNIEmpleado
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
        Me.btnAceptarDNIEmpleado = New System.Windows.Forms.Button()
        Me.txtDniEmpleado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.btnAceptarDNIEmpleado)
        Me.Panel1.Controls.Add(Me.txtDniEmpleado)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 209)
        Me.Panel1.TabIndex = 1
        '
        'btnAceptarDNIEmpleado
        '
        Me.btnAceptarDNIEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarDNIEmpleado.ForeColor = System.Drawing.Color.Teal
        Me.btnAceptarDNIEmpleado.Location = New System.Drawing.Point(459, 112)
        Me.btnAceptarDNIEmpleado.Name = "btnAceptarDNIEmpleado"
        Me.btnAceptarDNIEmpleado.Size = New System.Drawing.Size(112, 51)
        Me.btnAceptarDNIEmpleado.TabIndex = 21
        Me.btnAceptarDNIEmpleado.Text = "Aceptar"
        Me.btnAceptarDNIEmpleado.UseVisualStyleBackColor = True
        '
        'txtDniEmpleado
        '
        Me.txtDniEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDniEmpleado.ForeColor = System.Drawing.Color.Black
        Me.txtDniEmpleado.Location = New System.Drawing.Point(238, 62)
        Me.txtDniEmpleado.Name = "txtDniEmpleado"
        Me.txtDniEmpleado.Size = New System.Drawing.Size(207, 28)
        Me.txtDniEmpleado.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(234, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Ingrese DNI:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.ClinicaApp.My.Resources.Resources.empleado01
        Me.PictureBox2.Location = New System.Drawing.Point(47, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(171, 133)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'FormIngresarDNIEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 209)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormIngresarDNIEmpleado"
        Me.Text = "Registrar Usuario de Empleado:"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDniEmpleado As TextBox
    Friend WithEvents btnAceptarDNIEmpleado As Button
End Class
