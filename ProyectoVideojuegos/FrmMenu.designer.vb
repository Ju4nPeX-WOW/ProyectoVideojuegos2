<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HacerVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JuegosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarJuegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarJuegosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarConsolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarConsolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarConsolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarConsolasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentaToolStripMenuItem, Me.JuegosToolStripMenuItem, Me.ConsolasToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ConsolasToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 37)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(56, 27)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(164, 28)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HacerVentaToolStripMenuItem, Me.ListarVentasToolStripMenuItem})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(56, 27)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'HacerVentaToolStripMenuItem
        '
        Me.HacerVentaToolStripMenuItem.Name = "HacerVentaToolStripMenuItem"
        Me.HacerVentaToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.HacerVentaToolStripMenuItem.Text = "Hacer venta"
        '
        'ListarVentasToolStripMenuItem
        '
        Me.ListarVentasToolStripMenuItem.Name = "ListarVentasToolStripMenuItem"
        Me.ListarVentasToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.ListarVentasToolStripMenuItem.Text = "Listar ventas"
        '
        'JuegosToolStripMenuItem
        '
        Me.JuegosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarJuegoToolStripMenuItem, Me.ListarJuegosToolStripMenuItem})
        Me.JuegosToolStripMenuItem.Name = "JuegosToolStripMenuItem"
        Me.JuegosToolStripMenuItem.Size = New System.Drawing.Size(66, 27)
        Me.JuegosToolStripMenuItem.Text = "Juegos"
        '
        'AgregarJuegoToolStripMenuItem
        '
        Me.AgregarJuegoToolStripMenuItem.Name = "AgregarJuegoToolStripMenuItem"
        Me.AgregarJuegoToolStripMenuItem.Size = New System.Drawing.Size(168, 28)
        Me.AgregarJuegoToolStripMenuItem.Text = "Agregar juego"
        '
        'ListarJuegosToolStripMenuItem
        '
        Me.ListarJuegosToolStripMenuItem.Name = "ListarJuegosToolStripMenuItem"
        Me.ListarJuegosToolStripMenuItem.Size = New System.Drawing.Size(168, 28)
        Me.ListarJuegosToolStripMenuItem.Text = "Listar juegos"
        '
        'ConsolasToolStripMenuItem
        '
        Me.ConsolasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarCategoriaToolStripMenuItem, Me.ListarCategoriaToolStripMenuItem})
        Me.ConsolasToolStripMenuItem.Name = "ConsolasToolStripMenuItem"
        Me.ConsolasToolStripMenuItem.Size = New System.Drawing.Size(90, 27)
        Me.ConsolasToolStripMenuItem.Text = "Categorias"
        '
        'AgregarCategoriaToolStripMenuItem
        '
        Me.AgregarCategoriaToolStripMenuItem.Name = "AgregarCategoriaToolStripMenuItem"
        Me.AgregarCategoriaToolStripMenuItem.Size = New System.Drawing.Size(194, 28)
        Me.AgregarCategoriaToolStripMenuItem.Text = "Agregar categoria"
        '
        'ListarCategoriaToolStripMenuItem
        '
        Me.ListarCategoriaToolStripMenuItem.Name = "ListarCategoriaToolStripMenuItem"
        Me.ListarCategoriaToolStripMenuItem.Size = New System.Drawing.Size(194, 28)
        Me.ListarCategoriaToolStripMenuItem.Text = "Listar categoria"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEmpleadosToolStripMenuItem, Me.ListarEmpleadosToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(90, 27)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AgregarEmpleadosToolStripMenuItem
        '
        Me.AgregarEmpleadosToolStripMenuItem.Name = "AgregarEmpleadosToolStripMenuItem"
        Me.AgregarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.AgregarEmpleadosToolStripMenuItem.Text = "Agregar empleados"
        '
        'ListarEmpleadosToolStripMenuItem
        '
        Me.ListarEmpleadosToolStripMenuItem.Name = "ListarEmpleadosToolStripMenuItem"
        Me.ListarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.ListarEmpleadosToolStripMenuItem.Text = "Listar empleados"
        '
        'ConsolasToolStripMenuItem1
        '
        Me.ConsolasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarConsolToolStripMenuItem, Me.ModificarConsolaToolStripMenuItem, Me.EliminarConsolaToolStripMenuItem, Me.ListarConsolasToolStripMenuItem})
        Me.ConsolasToolStripMenuItem1.Name = "ConsolasToolStripMenuItem1"
        Me.ConsolasToolStripMenuItem1.Size = New System.Drawing.Size(78, 27)
        Me.ConsolasToolStripMenuItem1.Text = "Consolas"
        '
        'AgregarConsolToolStripMenuItem
        '
        Me.AgregarConsolToolStripMenuItem.Name = "AgregarConsolToolStripMenuItem"
        Me.AgregarConsolToolStripMenuItem.Size = New System.Drawing.Size(191, 28)
        Me.AgregarConsolToolStripMenuItem.Text = "Agregar consola"
        '
        'ModificarConsolaToolStripMenuItem
        '
        Me.ModificarConsolaToolStripMenuItem.Name = "ModificarConsolaToolStripMenuItem"
        Me.ModificarConsolaToolStripMenuItem.Size = New System.Drawing.Size(191, 28)
        Me.ModificarConsolaToolStripMenuItem.Text = "Modificar consola"
        '
        'EliminarConsolaToolStripMenuItem
        '
        Me.EliminarConsolaToolStripMenuItem.Name = "EliminarConsolaToolStripMenuItem"
        Me.EliminarConsolaToolStripMenuItem.Size = New System.Drawing.Size(191, 28)
        Me.EliminarConsolaToolStripMenuItem.Text = "Eliminar consola"
        '
        'ListarConsolasToolStripMenuItem
        '
        Me.ListarConsolasToolStripMenuItem.Name = "ListarConsolasToolStripMenuItem"
        Me.ListarConsolasToolStripMenuItem.Size = New System.Drawing.Size(191, 28)
        Me.ListarConsolasToolStripMenuItem.Text = "Listar consolas"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1200, 749)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.Name = "FrmMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsolasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JuegosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HacerVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarJuegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarJuegosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsolasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarConsolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarConsolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarConsolasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarConsolaToolStripMenuItem As ToolStripMenuItem
End Class
