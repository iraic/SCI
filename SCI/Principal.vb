Public Class Principal


    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not permisos.Contains("0000-") Then
                For Each m As ToolStripMenuItem In MenuStrip1.Items
                    If permisos.Contains(m.Tag) Then
                        m.Visible = True
                    Else
                        m.Visible = False
                    End If
                    For Each n As ToolStripItem In m.DropDownItems
                        If permisos.Contains(n.Tag) Then
                            n.Visible = True
                        Else
                            n.Visible = False
                        End If
                    Next
                Next
                'For Each b As Object In ToolStrip1.Items
                '    If permisos.Contains(b.Tag) Then
                '        b.Enabled = True
                '    Else
                '        b.Enabled = False
                '    End If
                'Next
            End If
        Catch
            MsgBox(Err.Number & ":" & Err.Description)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Usuarios.MdiParent = Me
        Usuarios.Show()
    End Sub

    Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
        Roles.MdiParent = Me
        Roles.Show()
    End Sub

    Private Sub DatosDeLaEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeLaEmpresaToolStripMenuItem.Click
        DatosEmpresa.MdiParent = Me
        DatosEmpresa.Show()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        Articulos.MdiParent = Me
        Articulos.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        ACategorias.MdiParent = Me
        ACategorias.Show()
    End Sub

    Private Sub UnidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesToolStripMenuItem.Click
        AUnidades.MdiParent = Me
        AUnidades.Show()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraToolStripMenuItem.Click
        Compras.MdiParent = Me
        Compras.Show()
    End Sub

    Private Sub ConsultarComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarComprasToolStripMenuItem.Click
        ConsultaCompras.MdiParent = Me
        ConsultaCompras.Show()
    End Sub

    Private Sub NotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaToolStripMenuItem.Click
        Ventas.MdiParent = Me
        Ventas.Show()
    End Sub

    Private Sub ConsultarNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarNotasToolStripMenuItem.Click
        ConsultaVentas.MdiParent = Me
        ConsultaVentas.Show()
    End Sub

    Private Sub ListadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadosToolStripMenuItem.Click
        Listados.MdiParent = Me
        Listados.Show()
    End Sub
End Class