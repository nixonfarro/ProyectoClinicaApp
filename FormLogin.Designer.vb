<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LLogin = New System.Windows.Forms.Label()
        Me.PBLogin = New System.Windows.Forms.PictureBox()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.LPassword = New System.Windows.Forms.Label()
        Me.LUser = New System.Windows.Forms.Label()
        Me.BLoginCancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PBLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LLogin
        '
        Me.LLogin.AutoSize = True
        Me.LLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLogin.ForeColor = System.Drawing.Color.LightGray
        Me.LLogin.Location = New System.Drawing.Point(164, 71)
        Me.LLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLogin.Name = "LLogin"
        Me.LLogin.Size = New System.Drawing.Size(139, 29)
        Me.LLogin.TabIndex = 1
        Me.LLogin.Text = "Bienvenido"
        '
        'PBLogin
        '
        Me.PBLogin.Image = Global.ClinicaApp.My.Resources.Resources.WhatsApp_Image_2022_05_23_at_12_17_39_AM
        Me.PBLogin.Location = New System.Drawing.Point(123, 124)
        Me.PBLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.PBLogin.Name = "PBLogin"
        Me.PBLogin.Size = New System.Drawing.Size(215, 211)
        Me.PBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBLogin.TabIndex = 7
        Me.PBLogin.TabStop = False
        '
        'BLogin
        '
        Me.BLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BLogin.FlatAppearance.BorderSize = 0
        Me.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLogin.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.ForeColor = System.Drawing.Color.White
        Me.BLogin.Location = New System.Drawing.Point(33, 586)
        Me.BLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(140, 59)
        Me.BLogin.TabIndex = 12
        Me.BLogin.Text = "Iniciar Sesión"
        Me.BLogin.UseVisualStyleBackColor = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.ForeColor = System.Drawing.Color.White
        Me.txtpass.Location = New System.Drawing.Point(57, 490)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(341, 15)
        Me.txtpass.TabIndex = 11
        '
        'txtusuario
        '
        Me.txtusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusuario.ForeColor = System.Drawing.Color.White
        Me.txtusuario.Location = New System.Drawing.Point(57, 401)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(341, 15)
        Me.txtusuario.TabIndex = 10
        '
        'LPassword
        '
        Me.LPassword.AutoSize = True
        Me.LPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPassword.ForeColor = System.Drawing.Color.LightGray
        Me.LPassword.Location = New System.Drawing.Point(52, 466)
        Me.LPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(100, 20)
        Me.LPassword.TabIndex = 9
        Me.LPassword.Text = "Contraseña:"
        '
        'LUser
        '
        Me.LUser.AutoSize = True
        Me.LUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUser.ForeColor = System.Drawing.Color.LightGray
        Me.LUser.Location = New System.Drawing.Point(52, 377)
        Me.LUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LUser.Name = "LUser"
        Me.LUser.Size = New System.Drawing.Size(72, 20)
        Me.LUser.TabIndex = 8
        Me.LUser.Text = "Usuario:"
        '
        'BLoginCancelar
        '
        Me.BLoginCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BLoginCancelar.FlatAppearance.BorderSize = 0
        Me.BLoginCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLoginCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLoginCancelar.ForeColor = System.Drawing.Color.White
        Me.BLoginCancelar.Location = New System.Drawing.Point(258, 586)
        Me.BLoginCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BLoginCancelar.Name = "BLoginCancelar"
        Me.BLoginCancelar.Size = New System.Drawing.Size(140, 59)
        Me.BLoginCancelar.TabIndex = 14
        Me.BLoginCancelar.Text = "Cerrar"
        Me.BLoginCancelar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 50)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 677)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 15)
        Me.Panel2.TabIndex = 17
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(258, 535)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(128, 17)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿No tiene usuario?"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 692)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BLoginCancelar)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.LPassword)
        Me.Controls.Add(Me.LUser)
        Me.Controls.Add(Me.PBLogin)
        Me.Controls.Add(Me.LLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormLogin"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PBLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LLogin As Label
    Friend WithEvents PBLogin As PictureBox
    Friend WithEvents BLogin As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents LPassword As Label
    Friend WithEvents LUser As Label
    Friend WithEvents BLoginCancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
