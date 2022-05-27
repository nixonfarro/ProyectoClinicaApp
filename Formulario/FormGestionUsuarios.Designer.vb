<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionUsuarios
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
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnActualizarUsuario = New System.Windows.Forms.Button()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPasswordGU = New System.Windows.Forms.TextBox()
        Me.txtUsuarioGU = New System.Windows.Forms.TextBox()
        Me.cbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.cbDni = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToOrderColumns = True
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUsuarios.Location = New System.Drawing.Point(0, 338)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.RowHeadersWidth = 51
        Me.dgUsuarios.RowTemplate.Height = 24
        Me.dgUsuarios.Size = New System.Drawing.Size(1018, 241)
        Me.dgUsuarios.TabIndex = 4
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PanelBotones.Controls.Add(Me.btnEliminarUsuario)
        Me.PanelBotones.Controls.Add(Me.btnActualizarUsuario)
        Me.PanelBotones.Controls.Add(Me.btnAgregarUsuario)
        Me.PanelBotones.Controls.Add(Me.btnNuevoUsuario)
        Me.PanelBotones.Controls.Add(Me.txtNombre)
        Me.PanelBotones.Controls.Add(Me.txtPasswordGU)
        Me.PanelBotones.Controls.Add(Me.txtUsuarioGU)
        Me.PanelBotones.Controls.Add(Me.cbTipoUsuario)
        Me.PanelBotones.Controls.Add(Me.cbDni)
        Me.PanelBotones.Controls.Add(Me.Label3)
        Me.PanelBotones.Controls.Add(Me.Label6)
        Me.PanelBotones.Controls.Add(Me.Label5)
        Me.PanelBotones.Controls.Add(Me.Label1)
        Me.PanelBotones.Controls.Add(Me.Label2)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBotones.Location = New System.Drawing.Point(0, 0)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(1018, 338)
        Me.PanelBotones.TabIndex = 3
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarUsuario.ForeColor = System.Drawing.Color.Crimson
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(882, 264)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(112, 56)
        Me.btnEliminarUsuario.TabIndex = 16
        Me.btnEliminarUsuario.Text = "Eliminar"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'btnActualizarUsuario
        '
        Me.btnActualizarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarUsuario.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnActualizarUsuario.Location = New System.Drawing.Point(882, 192)
        Me.btnActualizarUsuario.Name = "btnActualizarUsuario"
        Me.btnActualizarUsuario.Size = New System.Drawing.Size(112, 56)
        Me.btnActualizarUsuario.TabIndex = 16
        Me.btnActualizarUsuario.Text = "Actualizar"
        Me.btnActualizarUsuario.UseVisualStyleBackColor = True
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarUsuario.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(882, 107)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(112, 56)
        Me.btnAgregarUsuario.TabIndex = 16
        Me.btnAgregarUsuario.Text = "Agregar"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(882, 34)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(112, 56)
        Me.btnNuevoUsuario.TabIndex = 16
        Me.btnNuevoUsuario.Text = "Nuevo"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(608, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 22)
        Me.txtNombre.TabIndex = 3
        '
        'txtPasswordGU
        '
        Me.txtPasswordGU.Location = New System.Drawing.Point(178, 264)
        Me.txtPasswordGU.Name = "txtPasswordGU"
        Me.txtPasswordGU.Size = New System.Drawing.Size(224, 22)
        Me.txtPasswordGU.TabIndex = 3
        '
        'txtUsuarioGU
        '
        Me.txtUsuarioGU.Location = New System.Drawing.Point(178, 178)
        Me.txtUsuarioGU.Name = "txtUsuarioGU"
        Me.txtUsuarioGU.Size = New System.Drawing.Size(224, 22)
        Me.txtUsuarioGU.TabIndex = 3
        '
        'cbTipoUsuario
        '
        Me.cbTipoUsuario.FormattingEnabled = True
        Me.cbTipoUsuario.Location = New System.Drawing.Point(178, 103)
        Me.cbTipoUsuario.Name = "cbTipoUsuario"
        Me.cbTipoUsuario.Size = New System.Drawing.Size(224, 24)
        Me.cbTipoUsuario.TabIndex = 2
        '
        'cbDni
        '
        Me.cbDni.FormattingEnabled = True
        Me.cbDni.Location = New System.Drawing.Point(178, 32)
        Me.cbDni.Name = "cbDni"
        Me.cbDni.Size = New System.Drawing.Size(224, 24)
        Me.cbDni.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(444, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DNI :"
        '
        'FormGestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 579)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.PanelBotones)
        Me.Name = "FormGestionUsuarios"
        Me.Text = "FormGestionUsuarios"
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBotones.ResumeLayout(False)
        Me.PanelBotones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgUsuarios As DataGridView
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents btnActualizarUsuario As Button
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents btnNuevoUsuario As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPasswordGU As TextBox
    Friend WithEvents txtUsuarioGU As TextBox
    Friend WithEvents cbTipoUsuario As ComboBox
    Friend WithEvents cbDni As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
