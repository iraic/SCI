Public Class Principal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub InevntariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InevntariosToolStripMenuItem.Click
        Inventario.MdiParent = Me
        Inventario.Show()
    End Sub
End Class