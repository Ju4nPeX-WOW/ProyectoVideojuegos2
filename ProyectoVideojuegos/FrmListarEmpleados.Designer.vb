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
        Me.LblID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AllowUserToDeleteRows = False
        Me.DgvEmpleados.AllowUserToResizeColumns = False
        Me.DgvEmpleados.AllowUserToResizeRows = False
        Me.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Location = New System.Drawing.Point(35, 67)
        Me.DgvEmpleados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgvEmpleados.MultiSelect = False
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleados.Size = New System.Drawing.Size(721, 219)
        Me.DgvEmpleados.TabIndex = 0
        '
        'BtnModificar
        '
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnModificar.Location = New System.Drawing.Point(587, 301)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 34)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminar.Location = New System.Drawing.Point(681, 301)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 34)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAceptar.Location = New System.Drawing.Point(487, 534)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(117, 49)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCerrar.Location = New System.Drawing.Point(639, 534)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(117, 49)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(65, 316)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 19)
        Me.LblID.TabIndex = 15
        Me.LblID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(352, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 33)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "EMPLEADOS"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtCorreo.ForeColor = System.Drawing.Color.Black
        Me.TxtCorreo.Location = New System.Drawing.Point(188, 476)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(503, 33)
        Me.TxtCorreo.TabIndex = 36
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.LblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblEmail.Location = New System.Drawing.Point(114, 476)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(65, 25)
        Me.LblEmail.TabIndex = 35
        Me.LblEmail.Text = "Correo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(394, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "-"
        '
        'LblRut
        '
        Me.LblRut.AutoSize = True
        Me.LblRut.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.LblRut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblRut.Location = New System.Drawing.Point(114, 352)
        Me.LblRut.Name = "LblRut"
        Me.LblRut.Size = New System.Drawing.Size(42, 25)
        Me.LblRut.TabIndex = 33
        Me.LblRut.Text = "Rut :"
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.LblApellidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblApellidos.Location = New System.Drawing.Point(402, 412)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(84, 25)
        Me.LblApellidos.TabIndex = 32
        Me.LblApellidos.Text = "Apellidos : "
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNombre.Location = New System.Drawing.Point(114, 412)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(68, 25)
        Me.LblNombre.TabIndex = 31
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtDV
        '
        Me.TxtDV.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtDV.ForeColor = System.Drawing.Color.Black
        Me.TxtDV.Location = New System.Drawing.Point(420, 349)
        Me.TxtDV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDV.Name = "TxtDV"
        Me.TxtDV.Size = New System.Drawing.Size(35, 33)
        Me.TxtDV.TabIndex = 30
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtApellidos.ForeColor = System.Drawing.Color.Black
        Me.TxtApellidos.Location = New System.Drawing.Point(492, 409)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(199, 33)
        Me.TxtApellidos.TabIndex = 29
        '
        'TxtRut
        '
        Me.TxtRut.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtRut.ForeColor = System.Drawing.Color.Black
        Me.TxtRut.Location = New System.Drawing.Point(188, 349)
        Me.TxtRut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.Size = New System.Drawing.Size(199, 33)
        Me.TxtRut.TabIndex = 28
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.TxtNombre.ForeColor = System.Drawing.Color.Black
        Me.TxtNombre.Location = New System.Drawing.Point(188, 409)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(199, 33)
        Me.TxtNombre.TabIndex = 27
        '
        'FrmListarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(800, 613)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.DgvEmpleados)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmListarEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents LblID As Label
    Friend WithEvents Label2 As Label
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
End Class
