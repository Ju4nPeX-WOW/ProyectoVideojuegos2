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
        Me.SuspendLayout()
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(113, 200)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(175, 20)
        Me.TxtCorreo.TabIndex = 26
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(60, 203)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(44, 13)
        Me.LblEmail.TabIndex = 25
        Me.LblEmail.Text = "Correo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "-"
        '
        'LblRut
        '
        Me.LblRut.AutoSize = True
        Me.LblRut.Location = New System.Drawing.Point(60, 165)
        Me.LblRut.Name = "LblRut"
        Me.LblRut.Size = New System.Drawing.Size(30, 13)
        Me.LblRut.TabIndex = 23
        Me.LblRut.Text = "Rut :"
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Location = New System.Drawing.Point(276, 120)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(58, 13)
        Me.LblApellidos.TabIndex = 22
        Me.LblApellidos.Text = "Apellidos : "
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(60, 120)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 21
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtDV
        '
        Me.TxtDV.Location = New System.Drawing.Point(267, 165)
        Me.TxtDV.Name = "TxtDV"
        Me.TxtDV.Size = New System.Drawing.Size(21, 20)
        Me.TxtDV.TabIndex = 20
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(340, 117)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(159, 20)
        Me.TxtApellidos.TabIndex = 19
        '
        'TxtRut
        '
        Me.TxtRut.Location = New System.Drawing.Point(113, 165)
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.Size = New System.Drawing.Size(135, 20)
        Me.TxtRut.TabIndex = 18
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(113, 117)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(135, 20)
        Me.TxtNombre.TabIndex = 17
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(676, 277)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 16
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(582, 277)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 15
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmAgregarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "FrmAgregarEmpleado"
        Me.Text = "FrmAgregarEmpleado"
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
End Class
