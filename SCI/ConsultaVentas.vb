﻿Public Class ConsultaVentas

    Private Sub ConsultaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G.llenarGrid("select * from notas order by idNota desc", DataGridView1)
        If G.permisos.Contains("94-") Or G.permisos.Contains("0-") Then
            btnCancelar.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            G.llenarGrid("select * from notasdetalle where idNota=" & DataGridView1.SelectedRows(0).Cells(0).Value, DataGridView2)
        End If
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        G.modificar("notas", "status='C'", "idNota=" & DataGridView1.SelectedRows(0).Cells(0).Value)
        G.llenarGrid("select * from notas", DataGridView1)
    End Sub

End Class