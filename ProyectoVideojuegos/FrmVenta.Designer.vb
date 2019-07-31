<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVenta
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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnRealizarVenta = New System.Windows.Forms.Button()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.DgvProductosSeleccionados = New System.Windows.Forms.DataGridView()
        Me.LblEmpleado = New System.Windows.Forms.Label()
        Me.LblRut = New System.Windows.Forms.Label()
        Me.TxtRut = New System.Windows.Forms.TextBox()
        Me.TxtDV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.NudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnDisminuir = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnTotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(40, 415)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(116, 23)
        Me.BtnCerrar.TabIndex = 19
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnRealizarVenta
        '
        Me.BtnRealizarVenta.Location = New System.Drawing.Point(341, 384)
        Me.BtnRealizarVenta.Name = "BtnRealizarVenta"
        Me.BtnRealizarVenta.Size = New System.Drawing.Size(116, 40)
        Me.BtnRealizarVenta.TabIndex = 18
        Me.BtnRealizarVenta.Text = "Realizar Venta"
        Me.BtnRealizarVenta.UseVisualStyleBackColor = True
        '
        'DgvProductos
        '
        Me.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Location = New System.Drawing.Point(40, 92)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.Size = New System.Drawing.Size(721, 76)
        Me.DgvProductos.TabIndex = 15
        '
        'DgvProductosSeleccionados
        '
        Me.DgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductosSeleccionados.Location = New System.Drawing.Point(40, 203)
        Me.DgvProductosSeleccionados.Name = "DgvProductosSeleccionados"
        Me.DgvProductosSeleccionados.Size = New System.Drawing.Size(721, 94)
        Me.DgvProductosSeleccionados.TabIndex = 30
        '
        'LblEmpleado
        '
        Me.LblEmpleado.AutoSize = True
        Me.LblEmpleado.Location = New System.Drawing.Point(37, 20)
        Me.LblEmpleado.Name = "LblEmpleado"
        Me.LblEmpleado.Size = New System.Drawing.Size(0, 13)
        Me.LblEmpleado.TabIndex = 31
        '
        'LblRut
        '
        Me.LblRut.AutoSize = True
        Me.LblRut.Location = New System.Drawing.Point(271, 23)
        Me.LblRut.Name = "LblRut"
        Me.LblRut.Size = New System.Drawing.Size(30, 13)
        Me.LblRut.TabIndex = 32
        Me.LblRut.Text = "Rut :"
        '
        'TxtRut
        '
        Me.TxtRut.Location = New System.Drawing.Point(307, 20)
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.Size = New System.Drawing.Size(109, 20)
        Me.TxtRut.TabIndex = 33
        '
        'TxtDV
        '
        Me.TxtDV.Location = New System.Drawing.Point(438, 20)
        Me.TxtDV.Name = "TxtDV"
        Me.TxtDV.Size = New System.Drawing.Size(19, 20)
        Me.TxtDV.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(422, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "-"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(686, 62)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 36
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(40, 63)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(640, 20)
        Me.TxtBuscar.TabIndex = 37
        '
        'NudCantidad
        '
        Me.NudCantidad.Location = New System.Drawing.Point(581, 175)
        Me.NudCantidad.Name = "NudCantidad"
        Me.NudCantidad.Size = New System.Drawing.Size(55, 20)
        Me.NudCantidad.TabIndex = 38
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(646, 174)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(115, 23)
        Me.BtnAgregar.TabIndex = 39
        Me.BtnAgregar.Text = "Agregar Producto"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(686, 311)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 40
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnDisminuir
        '
        Me.BtnDisminuir.Location = New System.Drawing.Point(592, 311)
        Me.BtnDisminuir.Name = "BtnDisminuir"
        Me.BtnDisminuir.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisminuir.TabIndex = 41
        Me.BtnDisminuir.Text = "Disminuir"
        Me.BtnDisminuir.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Location = New System.Drawing.Point(500, 311)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.BtnAñadir.TabIndex = 42
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnTotal
        '
        Me.BtnTotal.Location = New System.Drawing.Point(101, 314)
        Me.BtnTotal.Name = "BtnTotal"
        Me.BtnTotal.Size = New System.Drawing.Size(100, 20)
        Me.BtnTotal.TabIndex = 43
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(42, 317)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(48, 13)
        Me.LblTotal.TabIndex = 44
        Me.LblTotal.Text = "TOTAL :"
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.BtnTotal)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnDisminuir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.NudCantidad)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDV)
        Me.Controls.Add(Me.TxtRut)
        Me.Controls.Add(Me.LblRut)
        Me.Controls.Add(Me.LblEmpleado)
        Me.Controls.Add(Me.DgvProductosSeleccionados)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnRealizarVenta)
        Me.Controls.Add(Me.DgvProductos)
        Me.Name = "FrmVenta"
        Me.Text = "Venta"
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnRealizarVenta As Button
    Friend WithEvents DgvProductos As DataGridView
    Friend WithEvents DgvProductosSeleccionados As DataGridView
    Friend WithEvents LblEmpleado As Label
    Friend WithEvents LblRut As Label
    Friend WithEvents TxtRut As TextBox
    Friend WithEvents TxtDV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents NudCantidad As NumericUpDown
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnDisminuir As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnTotal As TextBox
    Friend WithEvents LblTotal As Label
End Class
