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
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(40, 606)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(116, 33)
        Me.BtnCerrar.TabIndex = 19
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnRealizarVenta
        '
        Me.BtnRealizarVenta.Location = New System.Drawing.Point(341, 561)
        Me.BtnRealizarVenta.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnRealizarVenta.Name = "BtnRealizarVenta"
        Me.BtnRealizarVenta.Size = New System.Drawing.Size(116, 59)
        Me.BtnRealizarVenta.TabIndex = 18
        Me.BtnRealizarVenta.Text = "Realizar Venta"
        Me.BtnRealizarVenta.UseVisualStyleBackColor = True
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToAddRows = False
        Me.DgvProductos.AllowUserToDeleteRows = False
        Me.DgvProductos.AllowUserToResizeColumns = False
        Me.DgvProductos.AllowUserToResizeRows = False
        Me.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Location = New System.Drawing.Point(40, 135)
        Me.DgvProductos.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DgvProductos.MultiSelect = False
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductos.Size = New System.Drawing.Size(721, 160)
        Me.DgvProductos.TabIndex = 15
        '
        'DgvProductosSeleccionados
        '
        Me.DgvProductosSeleccionados.AllowUserToAddRows = False
        Me.DgvProductosSeleccionados.AllowUserToDeleteRows = False
        Me.DgvProductosSeleccionados.AllowUserToResizeColumns = False
        Me.DgvProductosSeleccionados.AllowUserToResizeRows = False
        Me.DgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductosSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Id, Me.Nombre, Me.Precio, Me.Cantidad, Me.Total})
        Me.DgvProductosSeleccionados.Location = New System.Drawing.Point(40, 345)
        Me.DgvProductosSeleccionados.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DgvProductosSeleccionados.MultiSelect = False
        Me.DgvProductosSeleccionados.Name = "DgvProductosSeleccionados"
        Me.DgvProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductosSeleccionados.Size = New System.Drawing.Size(721, 138)
        Me.DgvProductosSeleccionados.TabIndex = 30
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
        'LblEmpleado
        '
        Me.LblEmpleado.AutoSize = True
        Me.LblEmpleado.Location = New System.Drawing.Point(37, 29)
        Me.LblEmpleado.Name = "LblEmpleado"
        Me.LblEmpleado.Size = New System.Drawing.Size(0, 19)
        Me.LblEmpleado.TabIndex = 31
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(686, 90)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 33)
        Me.BtnBuscar.TabIndex = 36
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(40, 92)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(640, 27)
        Me.TxtBuscar.TabIndex = 37
        '
        'NudCantidad
        '
        Me.NudCantidad.Location = New System.Drawing.Point(581, 304)
        Me.NudCantidad.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.NudCantidad.Name = "NudCantidad"
        Me.NudCantidad.Size = New System.Drawing.Size(55, 27)
        Me.NudCantidad.TabIndex = 38
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(646, 302)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(115, 33)
        Me.BtnAgregar.TabIndex = 39
        Me.BtnAgregar.Text = "Agregar Producto"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(686, 503)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 33)
        Me.BtnEliminar.TabIndex = 40
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnDisminuir
        '
        Me.BtnDisminuir.Location = New System.Drawing.Point(592, 503)
        Me.BtnDisminuir.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnDisminuir.Name = "BtnDisminuir"
        Me.BtnDisminuir.Size = New System.Drawing.Size(75, 33)
        Me.BtnDisminuir.TabIndex = 41
        Me.BtnDisminuir.Text = "Disminuir"
        Me.BtnDisminuir.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Location = New System.Drawing.Point(500, 503)
        Me.BtnAñadir.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(75, 33)
        Me.BtnAñadir.TabIndex = 42
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(101, 507)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 27)
        Me.TxtTotal.TabIndex = 43
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(42, 511)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(46, 19)
        Me.LblTotal.TabIndex = 44
        Me.LblTotal.Text = "TOTAL :"
        '
        'CmbTipo
        '
        Me.CmbTipo.DisplayMember = "H,M"
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Consolas", "VideoJuegos"})
        Me.CmbTipo.Location = New System.Drawing.Point(40, 53)
        Me.CmbTipo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(121, 27)
        Me.CmbTipo.TabIndex = 45
        Me.CmbTipo.ValueMember = "0,1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(355, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 33)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "HACER VENTA"
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(800, 656)
        Me.Controls.Add(Me.Label2)
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
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Label2 As Label
End Class
