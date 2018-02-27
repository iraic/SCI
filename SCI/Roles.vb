Public Class Roles
    '******************************'
    Dim tabla As String = "roles"
    Dim campoKey As String = "idRol"
    Dim cbsql As String = "SELECT CONCAT(idPermiso, '" & separador & "', Nombre) as permiso FROM permisos"
    '******************************'
    Dim dgsql As String = "SELECT * FROM " & tabla
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G.llenarGrid(dgsql, DataGridView1)
        G.llenarCombo(cbsql, cbxPermiso)
        txtRol.Text = G.secuencia(tabla, campoKey)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not validarControles() Then
            Exit Sub
        End If
        Dim campos As String
        '******************************'
        campos = txtRol.Text & ",'" & txtNombre.Text & "','"
        For Each p As Object In lbxPermisos.Items
            campos = campos & p.ToString.Substring(0, p.ToString.IndexOf(separador) + 1)
        Next
        campos = campos & "'"
        '******************************'
        If G.agregar(tabla, campos) Then _
        limpiar()
        G.llenarGrid(dgsql, DataGridView1)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridView1.SelectedRows.Count < 1 Then
            MsgBox("Debe seleccionar al menos un registro de la lista", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim valorKey As String = DataGridView1.SelectedRows(0).Cells(campoKey).Value
        '******************************'
        If valorKey = "0" Then
            MsgBox("No se puede eliminar el Administrador", MsgBoxStyle.Critical)
            '******************************'
            Exit Sub
        End If
        If MsgBox("Esta seguro que desea eliminar el registro: " & valorKey, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim condicion As String
            '******************************'
            condicion = campoKey & "=" & valorKey
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
        campos = "Nombre='" & txtNombre.Text & "', Permisos='"
        For Each p As Object In lbxPermisos.Items
            campos = campos & p.ToString.Substring(0, p.ToString.IndexOf(separador) + 1)
        Next
        campos = campos & "'"
        condicion = campoKey & "=" & txtRol.Text
        txtRol.Enabled = True
        '******************************'
        If G.modificar(tabla, campos, condicion) Then _
        limpiar()
        G.llenarGrid(dgsql, DataGridView1)
        btnModificar.Enabled = False
        btnEliminar.Enabled = True
        btnAgregar.Enabled = True
        btnDetener.Enabled = False
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim dt As DataRow = Nothing
        If DataGridView1.SelectedRows.Count < 1 Then
            MsgBox("Debe seleccionar al menos un registro de la lista", MsgBoxStyle.Critical)
            Exit Sub
        End If
        '******************************'
        txtRol.Text = DataGridView1.SelectedRows(0).Cells(campoKey).Value
        txtNombre.Text = DataGridView1.SelectedRows(0).Cells("Nombre").Value
        Dim lp() As String
        lp = DataGridView1.SelectedRows(0).Cells("Permisos").Value.ToString.Split(separador)
        lbxPermisos.Items.Clear()
        For Each p As String In lp
            If cbxPermiso.FindString(p & separador) >= 0 Then
                lbxPermisos.Items.Add(cbxPermiso.Items(cbxPermiso.FindString(p & separador)))
            End If
        Next
        txtRol.Enabled = False
        '******************************'
        btnModificar.Enabled = True
        btnEliminar.Enabled = False
        btnAgregar.Enabled = False
        btnDetener.Enabled = True
    End Sub


    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs)
        G.llenarCombo(cbsql, cbxPermiso)
    End Sub

    '******************************'
    Private Function validarControles() As Boolean
        validarControles = True
        If txtRol.Text = "" Or txtNombre.Text = "" Or lbxPermisos.Items.Count < 1 Then
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Critical)
            validarControles = False
        End If

    End Function

    Private Sub limpiar()
        txtRol.Text = G.secuencia(tabla, campoKey)
        txtNombre.Text = ""
        lbxPermisos.Items.Clear()
    End Sub
    '******************************'

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        If cbxPermiso.Text <> "" And lbxPermisos.FindString(cbxPermiso.Text) < 0 Then _
            lbxPermisos.Items.Add(cbxPermiso.Text)
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        If lbxPermisos.SelectedIndex >= 0 Then
            lbxPermisos.Items.RemoveAt(lbxPermisos.SelectedIndex)
        Else
            If lbxPermisos.Items.Count > 0 Then
                lbxPermisos.Items.RemoveAt(lbxPermisos.Items.Count - 1)
            End If
        End If
    End Sub
    '******************************'
    Private Sub txtRol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRol.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = G.separador Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        txtRol.Text = G.secuencia(tabla, campoKey)
    End Sub
'******************************'

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        limpiar()
        txtRol.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = True
        btnAgregar.Enabled = True
        btnDetener.Enabled = False
    End Sub

End Class