﻿Public Class AUnidades

    '******************************'
    Dim tabla As String = "unidades"
    Dim campoKey As String = "idUnidad"
    '******************************'
    Dim dgsql As String = "SELECT * FROM " & tabla
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G.llenarGrid(dgsql, DataGridView1)
        txtUnidad.Text = G.secuencia(tabla, campoKey)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not validarControles() Then
            Exit Sub
        End If

        Dim campos As String
        '******************************'
        campos = "'" & txtUnidad.Text & "','" & txtNombre.Text & "'," & txtValor.Text & ",'A'"
        '******************************'
        If G.agregar(tabla, campos) Then limpiar()
        G.llenarGrid(dgsql, DataGridView1)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridView1.SelectedRows.Count < 1 Then
            MsgBox("Debe seleccionar al menos un registro de la lista", MsgBoxStyle.Critical)
            Exit Sub
        End If
        '******************************'
        If MsgBox("Esta seguro que desea eliminar el registro: " & DataGridView1.SelectedRows(0).Cells(campoKey).Value & " podría afectar el funcionamiento", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim condicion As String
            '******************************'
            condicion = campoKey & "='" & DataGridView1.SelectedRows(0).Cells(campoKey).Value & "'"
            '******************************'
            If G.eliminar(tabla, condicion) Then _
            limpiar()
            G.llenarGrid(dgsql, DataGridView1)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not validarControles() Then
            Exit Sub
        End If
        Dim campos As String
        Dim condicion As String
        '******************************'
        campos = "Descripcion='" & txtNombre.Text & "', valor=" & txtValor.Text
        condicion = campoKey & "='" & txtUnidad.Text & "'"
        txtUnidad.Enabled = True
        '******************************'
        If G.modificar(tabla, campos, condicion) Then
            limpiar()
            G.llenarGrid(dgsql, DataGridView1)
            btnModificar.Enabled = False
            btnEliminar.Enabled = True
            btnAgregar.Enabled = True
            btnDetener.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim dt As DataRow = Nothing
        If DataGridView1.SelectedRows.Count < 1 Then
            MsgBox("Debe seleccionar al menos un registro de la lista", MsgBoxStyle.Critical)
            Exit Sub
        End If
        '******************************'
        txtUnidad.Text = DataGridView1.SelectedRows(0).Cells(campoKey).Value
        txtNombre.Text = DataGridView1.SelectedRows(0).Cells("Nombre").Value
        txtValor.Text = Val(DataGridView1.SelectedRows(0).Cells("Valor").Value)
        txtUnidad.Enabled = False
        '******************************'
        btnModificar.Enabled = True
        btnEliminar.Enabled = False
        btnAgregar.Enabled = False
        btnDetener.Enabled = True
    End Sub

    '******************************'
    Private Function validarControles() As Boolean
        validarControles = True
        If txtUnidad.Text = "" Or txtNombre.Text = "" Then
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Critical)
            validarControles = False
        End If

    End Function

    Private Sub limpiar()
        txtUnidad.Text = G.secuencia(tabla, campoKey)
        txtNombre.Text = ""
        txtValor.Text = ""
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        limpiar()
        txtUnidad.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = True
        btnAgregar.Enabled = True
        btnDetener.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If DataGridView1.SelectedRows.Count < 1 Then
            MsgBox("Debe seleccionar al menos un registro de la lista", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim valorKey As String = DataGridView1.SelectedRows(0).Cells(campoKey).Value

        If MsgBox("Esta seguro que desea cancelar el registro: " & valorKey, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim condicion As String
            condicion = campoKey & "='" & valorKey & "'"
            G.modificar(tabla, "Status='C'", condicion)
            G.llenarGrid(dgsql, DataGridView1)
        End If
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        If DataGridView1.SelectedRows.Count < 1 Then
            MsgBox("Debe seleccionar al menos un registro de la lista", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim valorKey As String = DataGridView1.SelectedRows(0).Cells(campoKey).Value

        Dim condicion As String
        condicion = campoKey & "='" & valorKey & "'"
        G.modificar(tabla, "Status='A'", condicion)
        G.llenarGrid(dgsql, DataGridView1)
    End Sub

    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        txtUnidad.Text = G.secuencia(tabla, campoKey)
    End Sub
End Class