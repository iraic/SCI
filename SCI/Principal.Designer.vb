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
        Me.InevntariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtileríasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InevntariosToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ResportesToolStripMenuItem, Me.UtileríasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InevntariosToolStripMenuItem
        '
        Me.InevntariosToolStripMenuItem.Name = "InevntariosToolStripMenuItem"
        Me.InevntariosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InevntariosToolStripMenuItem.Text = "Inventario"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ResportesToolStripMenuItem
        '
        Me.ResportesToolStripMenuItem.Name = "ResportesToolStripMenuItem"
        Me.ResportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ResportesToolStripMenuItem.Text = "Reportes"
        '
        'UtileríasToolStripMenuItem
        '
        Me.UtileríasToolStripMenuItem.Name = "UtileríasToolStripMenuItem"
        Me.UtileríasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.UtileríasToolStripMenuItem.Text = "Utilerías"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 459)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Sistema de Control de Inventarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InevntariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtileríasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
