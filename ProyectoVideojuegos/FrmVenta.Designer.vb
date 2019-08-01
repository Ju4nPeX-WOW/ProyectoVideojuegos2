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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.NudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnDisminuir = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DgvProductos.Size = New System.Drawing.Size(721, 109)
        Me.DgvProductos.TabIndex = 15
        '
        'DgvProductosSeleccionados
        '
        Me.DgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductosSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Id, Me.Nombre, Me.Precio, Me.Cantidad, Me.Total})
        Me.DgvProductosSeleccionados.Location = New System.Drawing.Point(40, 236)
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
        Me.NudCantidad.Location = New System.Drawing.Point(581, 208)
        Me.NudCantidad.Name = "NudCantidad"
        Me.NudCantidad.Size = New System.Drawing.Size(55, 20)
        Me.NudCantidad.TabIndex = 38
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(646, 207)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(115, 23)
        Me.BtnAgregar.TabIndex = 39
        Me.BtnAgregar.Text = "Agregar Producto"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(686, 344)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 40
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnDisminuir
        '
        Me.BtnDisminuir.Location = New System.Drawing.Point(592, 344)
        Me.BtnDisminuir.Name = "BtnDisminuir"
        Me.BtnDisminuir.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisminuir.TabIndex = 41
        Me.BtnDisminuir.Text = "Disminuir"
        Me.BtnDisminuir.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Location = New System.Drawing.Point(500, 344)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.BtnAñadir.TabIndex = 42
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(101, 347)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 43
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(42, 350)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(48, 13)
        Me.LblTotal.TabIndex = 44
        Me.LblTotal.Text = "TOTAL :"
        '
        'CmbTipo
        '
        Me.CmbTipo.DisplayMember = "H,M"
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(40, 20)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CmbTipo.TabIndex = 45
        Me.CmbTipo.ValueMember = "0,1"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnDisminuir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.NudCantidad)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnBuscar)
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
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents NudCantidad As NumericUpDown
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnDisminuir As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
