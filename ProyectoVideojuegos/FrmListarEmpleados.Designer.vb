<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListarEmpleados
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
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtRut = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtDV = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.LblRut = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LblID = New System.Windows.Forms.Label()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Location = New System.Drawing.Point(35, 26)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.Size = New System.Drawing.Size(721, 150)
        Me.DgvEmpleados.TabIndex = 0
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(587, 195)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(681, 195)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(587, 401)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(681, 401)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(118, 241)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(135, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtRut
        '
        Me.TxtRut.Location = New System.Drawing.Point(118, 289)
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.Size = New System.Drawing.Size(135, 20)
        Me.TxtRut.TabIndex = 6
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(345, 241)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(159, 20)
        Me.TxtApellidos.TabIndex = 7
        '
        'TxtDV
        '
        Me.TxtDV.Location = New System.Drawing.Point(272, 289)
        Me.TxtDV.Name = "TxtDV"
        Me.TxtDV.Size = New System.Drawing.Size(21, 20)
        Me.TxtDV.TabIndex = 8
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(65, 244)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 9
        Me.LblNombre.Text = "Nombre:"
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Location = New System.Drawing.Point(281, 244)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(58, 13)
        Me.LblApellidos.TabIndex = 10
        Me.LblApellidos.Text = "Apellidos : "
        '
        'LblRut
        '
        Me.LblRut.AutoSize = True
        Me.LblRut.Location = New System.Drawing.Point(65, 289)
        Me.LblRut.Name = "LblRut"
        Me.LblRut.Size = New System.Drawing.Size(30, 13)
        Me.LblRut.TabIndex = 11
        Me.LblRut.Text = "Rut :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "-"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(65, 327)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(44, 13)
        Me.LblEmail.TabIndex = 13
        Me.LblEmail.Text = "Correo :"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(118, 324)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(175, 20)
        Me.TxtCorreo.TabIndex = 14
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(65, 216)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 13)
        Me.LblID.TabIndex = 15
        Me.LblID.Visible = False
        '
        'FrmListarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblID)
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
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.DgvEmpleados)
        Me.Name = "FrmListarEmpleados"
        Me.Text = "ListarEmpleados"
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtRut As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtDV As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellidos As Label
    Friend WithEvents LblRut As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LblID As Label
End Class
