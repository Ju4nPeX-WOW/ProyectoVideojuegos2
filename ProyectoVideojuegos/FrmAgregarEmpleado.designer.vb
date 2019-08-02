<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarEmpleado
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
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRut = New System.Windows.Forms.Label()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtDV = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtRut = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtCorreo.ForeColor = System.Drawing.Color.Black
        Me.TxtCorreo.Location = New System.Drawing.Point(176, 252)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(503, 33)
        Me.TxtCorreo.TabIndex = 26
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.LblEmail.ForeColor = System.Drawing.Color.DarkRed
        Me.LblEmail.Location = New System.Drawing.Point(102, 252)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(65, 25)
        Me.LblEmail.TabIndex = 25
        Me.LblEmail.Text = "Correo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(382, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "-"
        '
        'LblRut
        '
        Me.LblRut.AutoSize = True
        Me.LblRut.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.LblRut.ForeColor = System.Drawing.Color.DarkRed
        Me.LblRut.Location = New System.Drawing.Point(102, 128)
        Me.LblRut.Name = "LblRut"
        Me.LblRut.Size = New System.Drawing.Size(42, 25)
        Me.LblRut.TabIndex = 23
        Me.LblRut.Text = "Rut :"
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.LblApellidos.ForeColor = System.Drawing.Color.DarkRed
        Me.LblApellidos.Location = New System.Drawing.Point(390, 188)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(84, 25)
        Me.LblApellidos.TabIndex = 22
        Me.LblApellidos.Text = "Apellidos : "
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.LblNombre.ForeColor = System.Drawing.Color.DarkRed
        Me.LblNombre.Location = New System.Drawing.Point(102, 188)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(68, 25)
        Me.LblNombre.TabIndex = 21
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtDV
        '
        Me.TxtDV.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtDV.ForeColor = System.Drawing.Color.Black
        Me.TxtDV.Location = New System.Drawing.Point(408, 125)
        Me.TxtDV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDV.Name = "TxtDV"
        Me.TxtDV.Size = New System.Drawing.Size(35, 33)
        Me.TxtDV.TabIndex = 20
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtApellidos.ForeColor = System.Drawing.Color.Black
        Me.TxtApellidos.Location = New System.Drawing.Point(480, 185)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(199, 33)
        Me.TxtApellidos.TabIndex = 19
        '
        'TxtRut
        '
        Me.TxtRut.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtRut.ForeColor = System.Drawing.Color.Black
        Me.TxtRut.Location = New System.Drawing.Point(176, 125)
        Me.TxtRut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.Size = New System.Drawing.Size(199, 33)
        Me.TxtRut.TabIndex = 18
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtNombre.ForeColor = System.Drawing.Color.Black
        Me.TxtNombre.Location = New System.Drawing.Point(176, 185)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(199, 33)
        Me.TxtNombre.TabIndex = 17
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.DarkRed
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(410, 323)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(122, 48)
        Me.BtnCerrar.TabIndex = 16
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.DarkRed
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(282, 323)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(122, 48)
        Me.BtnAceptar.TabIndex = 15
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(726, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(74, 418)
        Me.Panel2.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 418)
        Me.Panel1.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(285, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 42)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "AGREGAR EMPLEADO"
        '
        'FrmAgregarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 418)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblRut)
        Me.Controls.Add(Me.LblApellidos)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtDV)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtRut)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgregarEmpleado"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblRut As Label
    Friend WithEvents LblApellidos As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtDV As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtRut As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
