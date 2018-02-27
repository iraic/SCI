Public Class Articulos
    '******************************'
    Dim tabla As String = "inventario"
    Dim campoKey As String = "clave"
    '******************************'
    Dim dgsql As String = "SELECT * FROM " & tabla

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G.llenarGrid(dgsql, DataGridView1)
        G.llenarCombo("SELECT CONCAT(idCategoria, '" & separador & "', Nombre) as Cate FROM categorias where status='A'", cbxCategoria)
        G.llenarCombo("SELECT CONCAT(idUnidad, '" & separador & "', Nombre) as Cate FROM unidades where status='A'", cbxUnidad)
        txtArticulo.Text = G.secuencia("articulos", "idArticulo")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not validarControles() Then
            Exit Sub
        End If

        Dim campos As String
        '******************************'
        campos = txtArticulo.Text & ",'" & txtCodigo.Text & "','" & txtNombre.Text & "'," & Val(cbxCategoria.Text) & ",'" & txtDesc.Text & "','" & txtMarca.Text & "'," & Val(cbxUnidad.Text) & "," & Val(txtCantidad.Text) & "," & Val(txtCompra.Text) & "," & Val(txtVenta.Text) & "," & Val(txtMin.Text) & "," & Val(txtMax.Text) & ",'A'"
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
            condicion = campoKey & "=" & DataGridView1.SelectedRows(0).Cells(campoKey).Value
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
        campos = "Codigo='" & txtCodigo.Text & "',Nombre='" & txtNombre.Text & "',idCategoria=" & Val(cbxCategoria.Text) & ",Descripcion='" & txtDesc.Text & "',Marca='" & txtMarca.Text & "',idUnidad=" & Val(cbxUnidad.Text) & ",Cantidad=" & txtCantidad.Text & ",PCompra=" & txtCompra.Text & ",PVenta=" & txtVenta.Text & ",Min=" & txtMin.Text & ",Max=" & txtMax.Text
        condicion = campoKey & "=" & txtArticulo.Text
        txtArticulo.Enabled = True
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
        txtArticulo.Text = DataGridView1.SelectedRows(0).Cells(campoKey).Value
        txtCodigo.Text = DataGridView1.SelectedRows(0).Cells("Codigo").Value
        txtNombre.Text = DataGridView1.SelectedRows(0).Cells("Nombre").Value
        cbxCategoria.SelectedIndex = cbxCategoria.FindString(DataGridView1.SelectedRows(0).Cells("idCategoria").Value)
        txtDesc.Text = Val(DataGridView1.SelectedRows(0).Cells("Descripcion").Value)
        txtMarca.Text = Val(DataGridView1.SelectedRows(0).Cells("Marca").Value)
        cbxUnidad.SelectedIndex = cbxUnidad.FindString(DataGridView1.SelectedRows(0).Cells("idUnidad").Value)
        txtCantidad.Text = Val(DataGridView1.SelectedRows(0).Cells("Cantidad").Value)
        txtCompra.Text = Val(DataGridView1.SelectedRows(0).Cells("PCompra").Value)
        txtVenta.Text = Val(DataGridView1.SelectedRows(0).Cells("PVenta").Value)
        txtMin.Text = Val(DataGridView1.SelectedRows(0).Cells("Min").Value)
        txtMax.Text = Val(DataGridView1.SelectedRows(0).Cells("Max").Value)

        txtArticulo.Enabled = False
        '******************************'
        btnModificar.Enabled = True
        btnEliminar.Enabled = False
        btnAgregar.Enabled = False
        btnDetener.Enabled = True
    End Sub

    '******************************'
    Private Function validarControles() As Boolean
        validarControles = True
        If txtArticulo.Text = "" Or txtNombre.Text = "" Then
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Critical)
            validarControles = False
        End If

    End Function

    Private Sub limpiar()
        txtArticulo.Text = G.secuencia("articulos", "idArticulo")
        txtNombre.Text = ""
        txtDesc.Text = ""
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        limpiar()
        txtArticulo.Enabled = True
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
            condicion = campoKey & "=" & valorKey
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
        condicion = campoKey & "=" & valorKey
        G.modificar(tabla, "Status='A'", condicion)
        G.llenarGrid(dgsql, DataGridView1)
    End Sub
End Class