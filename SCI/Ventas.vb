Public Class Ventas
    Dim total As Double = 0

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Format(Now, "dd-MM-yyy hh:mm")
        txtNota.Text = G.secuencia("notas", "idNota")
        G.llenarCombo("SELECT CONCAT(idFormaPago, '" & separador & "', Nombre) as pago FROM formaspago  WHERE Status='A'", cbxFormaPago)
        cbxFormaPago.SelectedIndex = 0
    End Sub

    Private Sub txtArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtArticulo.TextChanged
        seleccionar()

    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        agregar()
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            total = total - Val(DataGridView1.SelectedRows(0).Cells("Subtotal").Value)
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            txtTotal.Text = Format(total, "0.00")
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(13) Then
            'Dim reg As DataRow = Nothing
            'If G.leerFila("select idArticulo,Codigo,Nombre,PVenta,Cantidad from articulos where Codigo='" & txtCodigo.Text & "'", reg) Then
            '    If Val(reg(4).ToString) > 0 Then
            '        Dim subtotal As Double
            '        subtotal = Val(reg(3).ToString)
            '        total = total + subtotal
            '        DataGridView1.Rows.Add(reg(0).ToString, reg(1).ToString, reg(2).ToString, reg(3).ToString, 1, reg(3).ToString)
            '        txtTotal.Text = Format(total, "0.00")
            '        txtArticulo.Text = ""
            '        txtCodigo.Text = ""
            '    End If
            'End If
            txtArticulo.Text = G.leerCadena("articulos", "idArticulo", "Codigo='" & txtCodigo.Text & "'")
            seleccionar()
            agregar()
            txtCodigo.Text = ""
        End If
    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus
        txtArticulo.Text = G.leerCadena("articulos", "idArticulo", "Codigo='" & txtCodigo.Text & "'")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim op As String = ""
        Dim ops() As String

        If DataGridView1.Rows.Count < 1 Or Val(txtSuPago.Text) < Val(txtTotal.Text) Then
            MsgBox("No hay artículos o el pago no es suficiente")
            Exit Sub
        End If
        txtNota.Text = G.secuencia("notas", "idNota")

        For Each reg As DataGridViewRow In DataGridView1.Rows
            op = op & "INSERT INTO notasdetalle(idNota,idArticulo,Precio,Cantidad,Descuento) VALUES(" & _
                    "" & txtNota.Text & "," & _
                    "" & reg.Cells("Clave").Value & "," & _
                    "" & reg.Cells("Precio").Value & "," & _
                    "" & reg.Cells("Cantidad").Value & "," & _
                    "" & reg.Cells("Descuento").Value & ");"
            op = op & "UPDATE articulos SET cantidad=cantidad-" & reg.Cells("Cantidad").Value & " WHERE idArticulo=" & reg.Cells("Clave").Value & ";"

        Next
        op = op & "INSERT INTO notas(idNota,Fecha,Total,Paga,idFormaPago,User,Status) VALUES(" & _
                     "" & txtNota.Text & "," & _
                     "'" & Format(Now, "yyy-MM-dd hh:mm:ss") & "'," & _
                     "" & txtTotal.Text & "," & _
                     "" & txtSuPago.Text & "," & _
                     "" & cbxFormaPago.SelectedItem.ToString.Substring(0, cbxFormaPago.SelectedItem.ToString.IndexOf(separador)) & "," & _
                     "'" & G.user & "','A')"
        ops = op.Split(";")
        If G.transaccion(ops) Then
            txtFecha.Text = Format(Now, "dd-MM-yyy hh:mm")
            'PrintPreviewDialog1.Document = PrintDocument1
            'PrintPreviewDialog1.ShowDialog()
            PrintDocument1.Print()
            PrintDocument1.Print()
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
        If G.leerFila("select idArticulo,Codigo,Nombre,PVenta,Cantidad from articulos where idArticulo=" & txtArticulo.Text, reg) Then
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
            Dim desemp As Integer = Val(G.leerCadena("valores", "valor", "Nombre='DescuentoEmpleados'"))
            Dim descuento As Double = 0
            subtotal = Val(txtPrecio.Text) * Val(txtCantidad.Text)

            If CheckBox1.Checked Then
                descuento = subtotal * (desemp / 100)
                subtotal = subtotal - descuento
            End If

            For Each reg As DataGridViewRow In DataGridView1.Rows
                If reg.Cells("Clave").Value = txtArticulo.Text Then
                    existe = True
                    Dim cant As Integer = Val(reg.Cells("Cantidad").Value) + Val(txtCantidad.Text)

                    If Val(lblCantidad.Text) < cant Then
                        MsgBox("No hay articulos suficientes en existencia")
                        Exit Sub
                    End If

                    reg.Cells("Cantidad").Value = cant
                    reg.Cells("Subtotal").Value = Val(reg.Cells("Subtotal").Value) + subtotal
                End If
            Next
            If Not existe Then
                DataGridView1.Rows.Add(txtArticulo.Text, txtCodigo.Text, txtNombre.Text, Val(txtPrecio.Text), Val(txtCantidad.Text), Format(subtotal, "0.00"), lblCantidad.Text, descuento)
            End If
            total = total + subtotal
            txtTotal.Text = Format(total, "0.00")
            txtArticulo.Text = ""
        Else
            MsgBox("No existe el artículo")
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim reng As Integer = 10
        Dim nreng As Integer = 0
        e.Graphics.DrawString(G.empresa, lblCantidad.Font, Brushes.Black, 1, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString(G.direccion, lblCantidad.Font, Brushes.Black, 1, nreng * reng) : nreng = nreng + 2
        e.Graphics.DrawString("Fecha:  " & txtFecha.Text, lblCantidad.Font, Brushes.Black, 1, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString("No ticket venta:  " & txtNota.Text, lblCantidad.Font, Brushes.Black, 200, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString("----------------------------------------------------------------------", lblCantidad.Font, Brushes.Black, 1, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString("Atiende:   " & G.user, lblCantidad.Font, Brushes.Black, 10, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString("----------------------------------------------------------------------", lblCantidad.Font, Brushes.Black, 1, nreng * reng) : nreng = nreng + 1

        e.Graphics.DrawString("Cantidad", lblCantidad.Font, Brushes.Black, 1, nreng * reng)
        e.Graphics.DrawString("Desccripción", lblCantidad.Font, Brushes.Black, 70, nreng * reng)
        e.Graphics.DrawString("Subtotal", lblCantidad.Font, Brushes.Black, 220, nreng * reng) : nreng = nreng + 1

        For Each reg As DataGridViewRow In DataGridView1.Rows
            e.Graphics.DrawString(reg.Cells("Cantidad").Value, lblCantidad.Font, Brushes.Black, 1, nreng * reng)
            If reg.Cells("Nombre").Value.ToString.Length > 21 Then
                e.Graphics.DrawString(reg.Cells("Nombre").Value.ToString.Substring(0, 20), lblCantidad.Font, Brushes.Black, 70, nreng * reng)
            Else
                e.Graphics.DrawString(reg.Cells("Nombre").Value.ToString, lblCantidad.Font, Brushes.Black, 70, nreng * reng)
            End If

            e.Graphics.DrawString(reg.Cells("Subtotal").Value, lblCantidad.Font, Brushes.Black, 220, nreng * reng) : nreng = nreng + 1
        Next
        e.Graphics.DrawString("----------------------------------------------------------------------", lblCantidad.Font, Brushes.Black, 1, nreng * reng) : nreng = nreng + 1

        e.Graphics.DrawString("Total:", lblCantidad.Font, Brushes.Black, 100, nreng * reng)
        e.Graphics.DrawString(txtTotal.Text, lblCantidad.Font, Brushes.Black, 200, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString("Su pago:", lblCantidad.Font, Brushes.Black, 100, nreng * reng)
        e.Graphics.DrawString(txtSuPago.Text, lblCantidad.Font, Brushes.Black, 200, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString("Cambio:", lblCantidad.Font, Brushes.Black, 100, nreng * reng)
        e.Graphics.DrawString(txtCambio.Text, lblCantidad.Font, Brushes.Black, 200, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString("----------------------------------------------------------------------", lblCantidad.Font, Brushes.Black, 1, nreng * reng) : nreng = nreng + 1
        e.Graphics.DrawString("Gracias por su preferencia", lblCantidad.Font, Brushes.Black, 50, nreng * reng) : nreng = nreng + 1
    End Sub

    Private Sub txtSuPago_TextChanged(sender As Object, e As EventArgs) Handles txtSuPago.TextChanged
        txtCambio.Text = Format(Val(txtSuPago.Text) - Val(txtTotal.Text), "0.00")
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        txtCambio.Text = Format(Val(txtSuPago.Text) - Val(txtTotal.Text), "0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SeleccionaArticulo.ShowDialog()
        If SeleccionaArticulo.idArticulo <> "" Then
            txtArticulo.Text = SeleccionaArticulo.idArticulo
            txtNombre.Text = SeleccionaArticulo.Nombre
        End If
        SeleccionaArticulo.Close()
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        txtArticulo.Text = ""
        txtCodigo.Focus()
    End Sub
End Class