Imports MySql.Data.MySqlClient

Public Class Inventario

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Producto.MdiParent = Principal
        Producto.Show()
        Producto.BringToFront()
    End Sub

    Sub actualizaGrid(Optional orden As String = "clave asc")
        Module1.llenarGrid("select clave, nombre, existencia, precio from inventario order by " & orden, DataGridView1)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        
        If DataGridView1.SelectedRows.Count > 0 Then
            Producto.MdiParent = Principal
            Producto.Show()
            Producto.BringToFront()
            Producto.modifica(DataGridView1.SelectedRows(0).Cells(0).Value)
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            If MsgBox("Esta seguro de eliminar", MsgBoxStyle.YesNo) = vbYes Then
                Dim conexion As New MySqlConnection(servidor)
                Dim comando As New MySqlCommand
                conexion.Open()
                comando.Connection = conexion
                comando.CommandText = "DELETE FROM inventario WHERE clave='" & DataGridView1.SelectedRows(0).Cells(0).Value & "'"
                If comando.ExecuteNonQuery() Then

                Else
                    MsgBox("Error al realizar la operación")
                End If
                conexion.Close()
                actualizaGrid()
            End If
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizaGrid()
    End Sub
End Class