Imports MySql.Data.MySqlClient

Public Class Compra

    Dim total As Double = 0

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Format(Now, "dd-MM-yyy hh:mm")
        txtCompra.Text = G.secuencia("compras", "idCompra")
    End Sub

    Private Sub txtArticulo_TextChanged(sender As Object, e As EventArgs)
        seleccionar()

    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs)
        agregar()
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs)
        If DataGridView1.SelectedRows.Count > 0 Then
            total = total - Val(DataGridView1.SelectedRows(0).Cells("Subtotal").Value)
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            txtTotal.Text = Format(total, "0.00")
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then

            txtArticulo.Text = G.leerCadena("articulos", "idArticulo", "Codigo='" & txtCodigo.Text & "'")
            seleccionar()
            txtCantidad.Text = ""
            txtCantidad.Focus()
            'agregar()
            'txtCodigo.Text = ""
        End If
    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs)
        txtArticulo.Text = G.leerCadena("articulos", "idArticulo", "Codigo='" & txtCodigo.Text & "'")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        Dim op As String = ""
        Dim ops() As String

        If DataGridView1.Rows.Count < 1 Then
            MsgBox("No hay artículos")
            Exit Sub
        End If
        txtCompra.Text = G.secuencia("compras", "idCompra")

        For Each reg As DataGridViewRow In DataGridView1.Rows
            op = op & "INSERT INTO comprasdetalle(idCompra,idArticulo,Precio,Cantidad) VALUES(" & _
                    "" & txtCompra.Text & "," & _
                    "" & reg.Cells("Clave").Value & "," & _
                    "" & reg.Cells("Precio").Value & "," & _
                    "" & reg.Cells("Cantidad").Value & ");"
            op = op & "UPDATE articulos SET PCompra=" & reg.Cells("Precio").Value & ", cantidad=cantidad+" & reg.Cells("Cantidad").Value & " WHERE idArticulo=" & reg.Cells("Clave").Value & ";"

        Next
        op = op & "INSERT INTO compras(idCompra,Fecha,Total,User,Status) VALUES(" & _
                     "" & txtCompra.Text & "," & _
                     "'" & Format(Now, "yyy-MM-dd hh:mm:ss") & "'," & _
                     "" & txtTotal.Text & "," & _
                     "'" & G.user & "','A')"
        ops = op.Split(";")
        If G.transaccion(ops) Then
            txtFecha.Text = Format(Now, "dd-MM-yyy hh:mm")
            limpiar()
        End If
    End Sub

    Sub limpiar()
        DataGridView1.Rows.Clear()
        total = 0
        txtTotal.Text = Format(total, "0.00")
        txtArticulo.Text = ""
    End Sub

    Sub seleccionar()
        Dim reg As DataRow = Nothing
        If G.leerFila("select idArticulo,Codigo,Nombre,PCompra,Cantidad from articulos where idArticulo=" & txtArticulo.Text, reg) Then
            txtCodigo.Text = reg(1).ToString
            txtNombre.Text = reg(2).ToString
            txtPrecio.Text = reg(3).ToString
            lblCantidad.Text = reg(4).ToString
            txtCantidad.Text = "1"
            txtSubtotal.Text = reg(3).ToString
        Else
            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtPrecio.Text = ""
            lblCantidad.Text = ""
            txtCantidad.Text = "1"
        End If
    End Sub

    Sub agregar()
        If txtNombre.Text <> "" And txtPrecio.Text <> "" And txtCantidad.Text <> "" Then
            Dim subtotal As Double
            Dim existe As Boolean = False

            subtotal = Val(txtPrecio.Text) * Val(txtCantidad.Text)

            For Each reg As DataGridViewRow In DataGridView1.Rows
                If reg.Cells("Clave").Value = txtArticulo.Text Then
                    existe = True
                    Dim cant As Integer = Val(reg.Cells("Cantidad").Value) + Val(txtCantidad.Text)

                    reg.Cells("Cantidad").Value = cant
                    reg.Cells("Subtotal").Value = Val(reg.Cells("Subtotal").Value) + subtotal
                End If
            Next
            If Not existe Then
                DataGridView1.Rows.Add(txtArticulo.Text, txtCodigo.Text, txtNombre.Text, Val(txtPrecio.Text), Val(txtCantidad.Text), Format(subtotal, "0.00"))
            End If
            total = total + subtotal
            txtTotal.Text = Format(total, "0.00")
            txtArticulo.Text = ""
        Else
            MsgBox("No existe el artículo")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        SeleccionaArticulo.ShowDialog()
        If SeleccionaArticulo.idArticulo <> "" Then
            txtArticulo.Text = SeleccionaArticulo.idArticulo
            txtNombre.Text = SeleccionaArticulo.Nombre
        End If
        SeleccionaArticulo.Close()
    End Sub
End Class