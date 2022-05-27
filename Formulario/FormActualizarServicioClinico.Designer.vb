<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActualizarServicioClinico
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
        Me.dgServicioClinico = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbEstadoServicio = New System.Windows.Forms.ComboBox()
        Me.btnActualizarServicioClinico = New System.Windows.Forms.Button()
        Me.cbTipoServicio = New System.Windows.Forms.ComboBox()
        Me.DTPFechaServicio = New System.Windows.Forms.DateTimePicker()
        Me.txtPrecioServicio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgServicioClinico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgServicioClinico
        '
        Me.dgServicioClinico.AllowUserToAddRows = False
        Me.dgServicioClinico.AllowUserToOrderColumns = True
        Me.dgServicioClinico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicioClinico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgServicioClinico.Location = New System.Drawing.Point(0, 290)
        Me.dgServicioClinico.Name = "dgServicioClinico"
        Me.dgServicioClinico.RowHeadersWidth = 51
        Me.dgServicioClinico.RowTemplate.Height = 24
        Me.dgServicioClinico.Size = New System.Drawing.Size(956, 253)
        Me.dgServicioClinico.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.cbEstadoServicio)
        Me.Panel1.Controls.Add(Me.btnActualizarServicioClinico)
        Me.Panel1.Controls.Add(Me.cbTipoServicio)
        Me.Panel1.Controls.Add(Me.DTPFechaServicio)
        Me.Panel1.Controls.Add(Me.txtPrecioServicio)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 290)
        Me.Panel1.TabIndex = 3
        '
        'cbEstadoServicio
        '
        Me.cbEstadoServicio.FormattingEnabled = True
        Me.cbEstadoServicio.Location = New System.Drawing.Point(243, 165)
        Me.cbEstadoServicio.Name = "cbEstadoServicio"
        Me.cbEstadoServicio.Size = New System.Drawing.Size(157, 24)
        Me.cbEstadoServicio.TabIndex = 16
        '
        'btnActualizarServicioClinico
        '
        Me.btnActualizarServicioClinico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarServicioClinico.ForeColor = System.Drawing.Color.Teal
        Me.btnActualizarServicioClinico.Location = New System.Drawing.Point(662, 19)
        Me.btnActualizarServicioClinico.Name = "btnActualizarServicioClinico"
        Me.btnActualizarServicioClinico.Size = New System.Drawing.Size(179, 56)
        Me.btnActualizarServicioClinico.TabIndex = 15
        Me.btnActualizarServicioClinico.Text = "Actualizar Servicio Clinico"
        Me.btnActualizarServicioClinico.UseVisualStyleBackColor = True
        '
        'cbTipoServicio
        '
        Me.cbTipoServicio.FormattingEnabled = True
        Me.cbTipoServicio.Location = New System.Drawing.Point(243, 32)
        Me.cbTipoServicio.Name = "cbTipoServicio"
        Me.cbTipoServicio.Size = New System.Drawing.Size(157, 24)
        Me.cbTipoServicio.TabIndex = 11
        '
        'DTPFechaServicio
        '
        Me.DTPFechaServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaServicio.Location = New System.Drawing.Point(243, 92)
        Me.DTPFechaServicio.Name = "DTPFechaServicio"
        Me.DTPFechaServicio.Size = New System.Drawing.Size(157, 22)
        Me.DTPFechaServicio.TabIndex = 9
        '
        'txtPrecioServicio
        '
        Me.txtPrecioServicio.Location = New System.Drawing.Point(270, 214)
        Me.txtPrecioServicio.Name = "txtPrecioServicio"
        Me.txtPrecioServicio.Size = New System.Drawing.Size(130, 22)
        Me.txtPrecioServicio.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(232, 218)
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
        Me.Label7.Location = New System.Drawing.Point(74, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estado servicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(67, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo Servicio clinico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(67, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha de servicio:"
        '
        'FormActualizarServicioClinico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 543)
        Me.Controls.Add(Me.dgServicioClinico)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormActualizarServicioClinico"
        Me.Text = "Actualizar Servicio Clinico"
        CType(Me.dgServicioClinico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgServicioClinico As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnActualizarServicioClinico As Button
    Friend WithEvents cbTipoServicio As ComboBox
    Friend WithEvents DTPFechaServicio As DateTimePicker
    Friend WithEvents txtPrecioServicio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEstadoServicio As ComboBox
    Friend WithEvents Label1 As Label
End Class
