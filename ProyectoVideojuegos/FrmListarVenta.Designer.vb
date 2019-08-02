<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarVenta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.DgvVentas = New System.Windows.Forms.DataGridView()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(371, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 33)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "VENTAS"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(70, 476)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 19)
        Me.LblID.TabIndex = 19
        Me.LblID.Visible = False
        '
        'DgvVentas
        '
        Me.DgvVentas.AllowUserToAddRows = False
        Me.DgvVentas.AllowUserToDeleteRows = False
        Me.DgvVentas.AllowUserToResizeColumns = False
        Me.DgvVentas.AllowUserToResizeRows = False
        Me.DgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Location = New System.Drawing.Point(36, 84)
        Me.DgvVentas.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DgvVentas.MultiSelect = False
        Me.DgvVentas.Name = "DgvVentas"
        Me.DgvVentas.ReadOnly = True
        Me.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVentas.Size = New System.Drawing.Size(721, 255)
        Me.DgvVentas.TabIndex = 17
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCerrar.Location = New System.Drawing.Point(356, 374)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(117, 72)
        Me.BtnCerrar.TabIndex = 21
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmListarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.DgvVentas)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListarVenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmListarVenta"
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents LblID As Label
    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents BtnCerrar As Button
End Class
