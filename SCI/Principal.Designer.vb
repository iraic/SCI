<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.InventariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtileriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DatosDeLaEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventariosToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ResportesToolStripMenuItem, Me.UtileriasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(881, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventariosToolStripMenuItem
        '
        Me.InventariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem, Me.ToolStripSeparator1, Me.CategoriasToolStripMenuItem, Me.UnidadesToolStripMenuItem})
        Me.InventariosToolStripMenuItem.Name = "InventariosToolStripMenuItem"
        Me.InventariosToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.InventariosToolStripMenuItem.Tag = "1000"
        Me.InventariosToolStripMenuItem.Text = "Inventario"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ArticulosToolStripMenuItem.Tag = "1100"
        Me.ArticulosToolStripMenuItem.Text = "Artículos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        Me.ToolStripSeparator1.Tag = "9100"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CategoriasToolStripMenuItem.Tag = "1200"
        Me.CategoriasToolStripMenuItem.Text = "Categorías"
        '
        'UnidadesToolStripMenuItem
        '
        Me.UnidadesToolStripMenuItem.Name = "UnidadesToolStripMenuItem"
        Me.UnidadesToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.UnidadesToolStripMenuItem.Tag = "1300"
        Me.UnidadesToolStripMenuItem.Text = "Unidades"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompraToolStripMenuItem, Me.ConsultarComprasToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ComprasToolStripMenuItem.Tag = "2000"
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.CompraToolStripMenuItem.Tag = "2100"
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'ConsultarComprasToolStripMenuItem
        '
        Me.ConsultarComprasToolStripMenuItem.Name = "ConsultarComprasToolStripMenuItem"
        Me.ConsultarComprasToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.ConsultarComprasToolStripMenuItem.Tag = "2200"
        Me.ConsultarComprasToolStripMenuItem.Text = "Consultar compras"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotaToolStripMenuItem, Me.ConsultarNotasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.VentasToolStripMenuItem.Tag = "3000"
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'NotaToolStripMenuItem
        '
        Me.NotaToolStripMenuItem.Name = "NotaToolStripMenuItem"
        Me.NotaToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.NotaToolStripMenuItem.Tag = "3100"
        Me.NotaToolStripMenuItem.Text = "Nota"
        '
        'ConsultarNotasToolStripMenuItem
        '
        Me.ConsultarNotasToolStripMenuItem.Name = "ConsultarNotasToolStripMenuItem"
        Me.ConsultarNotasToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ConsultarNotasToolStripMenuItem.Tag = "3200"
        Me.ConsultarNotasToolStripMenuItem.Text = "Consultar Notas"
        '
        'ResportesToolStripMenuItem
        '
        Me.ResportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadosToolStripMenuItem})
        Me.ResportesToolStripMenuItem.Name = "ResportesToolStripMenuItem"
        Me.ResportesToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ResportesToolStripMenuItem.Tag = "4000"
        Me.ResportesToolStripMenuItem.Text = "Reportes"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ListadosToolStripMenuItem.Tag = "4100"
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'UtileriasToolStripMenuItem
        '
        Me.UtileriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.PermisosToolStripMenuItem, Me.ToolStripSeparator2, Me.DatosDeLaEmpresaToolStripMenuItem})
        Me.UtileriasToolStripMenuItem.Name = "UtileriasToolStripMenuItem"
        Me.UtileriasToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.UtileriasToolStripMenuItem.Tag = "5000"
        Me.UtileriasToolStripMenuItem.Text = "Utilerías"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.UsuariosToolStripMenuItem.Tag = "5100"
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.PermisosToolStripMenuItem.Tag = "5200"
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(218, 6)
        Me.ToolStripSeparator2.Tag = "9100"
        '
        'DatosDeLaEmpresaToolStripMenuItem
        '
        Me.DatosDeLaEmpresaToolStripMenuItem.Name = "DatosDeLaEmpresaToolStripMenuItem"
        Me.DatosDeLaEmpresaToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.DatosDeLaEmpresaToolStripMenuItem.Tag = "5300"
        Me.DatosDeLaEmpresaToolStripMenuItem.Text = "Datos de la empresa"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Tag = "9000"
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 565)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.Text = "Sistema de Control de Inventarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InventariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtileriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarNotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DatosDeLaEmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
