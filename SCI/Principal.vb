Public Class Principal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub InevntariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InevntariosToolStripMenuItem.Click
        Inventario.MdiParent = Me
        Inventario.Show()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema de Control de Inventarios:" & sesUser
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Compra.MdiParent = Me
        Compra.Show()
    End Sub
End Class