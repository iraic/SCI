Public Class SeleccionaArticulo
    Public idArticulo As String = ""
    Public Nombre As String = ""

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then
            idArticulo = DataGridView1.SelectedRows(0).Cells("idArticulo1").Value
            Nombre = DataGridView1.SelectedRows(0).Cells("Nombre1").Value
        End If
        Me.Hide()
    End Sub

    Private Sub SeleccionaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G.llenarGrid("SELECT idArticulo, Nombre FROM articulos WHERE status='A'", DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            idArticulo = DataGridView1.SelectedRows(0).Cells("idArticulo1").Value
            Nombre = DataGridView1.SelectedRows(0).Cells("Nombre1").Value
        End If
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        idArticulo = ""
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        G.llenarGrid("SELECT idArticulo, Nombre FROM clientes WHERE status='A' and idArticulo=" & TextBox1.Text, DataGridView1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        G.llenarGrid("SELECT idArticulo, Nombre FROM clientes WHERE status='A' and Nombre LIKE '%" & TextBox1.Text & "%'", DataGridView1)
    End Sub

End Class