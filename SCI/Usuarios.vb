
Public Class Usuarios
    '******************************'
    Dim dgsql As String = "SELECT * FROM usuarios"
    Dim cbsql As String = "SELECT CONCAT(roles.idRol, '" & separador & "', roles.Nombre) as Privilegios FROM roles"
    '******************************'

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G.llenarGrid(dgsql, DataGridView1)
        G.llenarCombo(cbsql, cbxRol)
        txtRegistro.Text = Format(Now, "dd-MM-yyy")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not validarControles() Then
            Exit Sub
        End If
        Dim tabla As String
        Dim campos As String
        '******************************'
        tabla = "usuarios"
        campos = "'" & txtUser.Text & "'"
        campos = campos & ",MD5('" & txtPass.Text & "')"
        campos = campos & "," & cbxRol.Text.Substring(0, cbxRol.Text.IndexOf(separador))
        campos = campos & ",'" & txtNombre.Text & "'"
        campos = campos & ",'" & txtDir.Text & "'"
        campos = campos & ",'" & txtTel.Text & "'"
        campos = campos & ",'" & txtMail.Text & "'"
        campos = campos & ",'" & txtFace.Text & "'"
        campos = campos & ",'" & cbxStatus.Text.Chars(0) & "'"
        campos = campos & ",'" & Format(Now, "yyy-MM-dd hh:mm:ss") & "'"
        campos = campos & ",'" & txtObs.Text & "',0"

        'G.guardaImagen("ufotos", "User", "'" & txtUser.Text & "'", "Foto", PictureBox1.Image)
        'G.guardaImagen("uhuellas", "User", "'" & txtUser.Text & "'", "Huella", PictureBox2.Image)
        'If Label12.Text <> "" Then G.modificar("uhuellas", "idHuella=" & Label12.Text, "User='" & txtUser.Text & "'")

        '******************************'
        If G.agregar(tabla, campos) Then limpiar()
        G.llenarGrid(dgsql, DataGridView1)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridView1.SelectedRows.Count < 1 Then
            MsgBox("Debe seleccionar al menos un registro de la lista", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim campoKey As String = DataGridView1.SelectedRows(0).Cells("User").Value
        '******************************'
        If campoKey = "admin" Then
            MsgBox("No se puede eliminar el admin", MsgBoxStyle.Critical)
            '******************************'
            Exit Sub
        End If
        If MsgBox("Esta seguro que desea eliminar a: " & campoKey, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '******************************'
            Dim ops(2) As String
            ops(0) = "DELETE FROM ufotos WHERE User='" & campoKey & "'"
            ops(1) = "DELETE FROM uhuellas WHERE User='" & campoKey & "'"
            ops(2) = "DELETE FROM usuarios WHERE User='" & campoKey & "'"
            If G.transaccion(ops) Then limpiar()

            '******************************'
            G.llenarGrid(dgsql, DataGridView1)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not validarControles() Then
            Exit Sub
        End If
        Dim tabla As String
        Dim campos As String
        Dim condicion As String
        '******************************'
        tabla = "usuarios"
        condicion = "User='" & txtUser.Text & "'"

        campos = "Pass=MD5('" & txtPass.Text & "')"
        campos = campos & ",idRol=" & cbxRol.Text.Substring(0, cbxRol.Text.IndexOf(separador))
        campos = campos & ",Nombre='" & txtNombre.Text & "'"
        campos = campos & ",Dir='" & txtDir.Text & "'"
        campos = campos & ",Tel='" & txtTel.Text & "'"
        campos = campos & ",Mail='" & txtMail.Text & "'"
        campos = campos & ",Facebook='" & txtFace.Text & "'"
        campos = campos & ",Status='" & cbxStatus.Text.Chars(0) & "'"
        campos = campos & ",Obs='" & txtObs.Text & "'"

        'G.guardaImagen("ufotos", "User", "'" & txtUser.Text & "'", "Foto", PictureBox1.Image)
        'G.guardaImagen("uhuellas", "User", "'" & txtUser.Text & "'", "Huella", PictureBox2.Image)
        'If Label12.Text <> "" Then G.modificar("uhuellas", "idHuella=" & Label12.Text, "User='" & txtUser.Text & "'")

        txtUser.Enabled = True
        '******************************'
        If G.modificar(tabla, campos, condicion) Then limpiar()
        G.llenarGrid(dgsql, DataGridView1)
        btnModificar.Enabled = False
        btnEliminar.Enabled = True
        btnAgregar.Enabled = True
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim dt As DataRow = Nothing
        If DataGridView1.SelectedRows.Count < 1 Then
            MsgBox("Debe seleccionar al menos un registro de la lista", MsgBoxStyle.Critical)
            Exit Sub
        End If
        '******************************'
        If G.leerFila("SELECT * FROM usuarios WHERE User='" & DataGridView1.SelectedRows(0).Cells("User").Value & "'", dt) Then
            txtUser.Text = dt(0).ToString
            txtPass.Text = dt(1).ToString
            cbxRol.SelectedIndex = cbxRol.FindString(dt(2).ToString)
            txtNombre.Text = dt(3).ToString
            txtDir.Text = dt(4).ToString
            txtTel.Text = dt(5).ToString
            txtMail.Text = dt(6).ToString
            txtFace.Text = dt(7).ToString
            cbxStatus.SelectedIndex = cbxStatus.FindString(dt(8).ToString)
            txtObs.Text = dt(9).ToString
            txtRegistro.Text = dt(10).ToString
            'PictureBox1.Image = leerImagen("ufotos", "foto", "User='" & dt(0).ToString & "'")
            'PictureBox2.Image = leerImagen("uhuellas", "huella", "User='" & dt(0).ToString & "'")

            'Label12.Text = G.leerCadena("uhuellas", "idHuella", "User='" & dt(0).ToString & "'")

            txtUser.Enabled = False
            '******************************'
            btnModificar.Enabled = True
            btnEliminar.Enabled = False
            btnAgregar.Enabled = False
            btnDetener.Enabled = True
        End If
    End Sub


    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles cbxRol.GotFocus
        G.llenarCombo(cbsql, cbxRol)
    End Sub

    '******************************'
    Private Function validarControles() As Boolean
        validarControles = True
        If txtUser.Text = "" Or txtPass.Text = "" Or cbxRol.Text = "" Or cbxStatus.Text = "" Then
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Critical)
            validarControles = False
        End If
        If txtPass.Text <> txtConf.Text Then
            MsgBox("Las constraseñas no coinciden", MsgBoxStyle.Critical)
            validarControles = False
        End If
    End Function

    Private Sub limpiar()
        txtUser.Text = ""
        txtPass.Text = ""
        txtNombre.Text = ""
        txtDir.Text = ""
        txtTel.Text = ""
        txtMail.Text = ""
        txtFace.Text = ""
        txtObs.Text = ""
        txtRegistro.Text = ""
        'PictureBox1.Image = PictureBox3.Image
        'PictureBox2.Image = PictureBox4.Image
    End Sub
    '******************************'
    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress, txtConf.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    'Private Sub btnFoto_Click(sender As Object, e As EventArgs)
    '    CapturaFoto.ShowDialog()
    '    Me.PictureBox1.Image = CapturaFoto.PictureBox2.Image
    '    CapturaFoto.Close()
    'End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        limpiar()
        txtUser.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = True
        btnAgregar.Enabled = True
        btnDetener.Enabled = False
    End Sub


    'Private Sub btnHuella_Click(sender As Object, e As EventArgs)
    '    If Label12.Text <> "" Then
    '        CapturarHuella.nueva = False
    '        CapturarHuella.id = Val(Label12.Text)
    '    End If
    '    CapturarHuella.ShowDialog()
    '    If CapturarHuella.id >= 0 Then
    '        Me.PictureBox2.Image = CapturarHuella.PictureBox1.Image
    '        Label12.Text = CapturarHuella.id
    '    End If
    '    CapturarHuella.Close()
    'End Sub

End Class