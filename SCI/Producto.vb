Imports MySql.Data.MySqlClient

Public Class Producto
    Dim modificar As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection(cadenaConexion)
        Dim com As New MySqlCommand
        con.Open()
        com.Connection = con
        If modificar Then
            com.CommandText = "UPDATE inventario SET codigo='" & TextCodigo.Text & "',nombre='" & TextNombre.Text & "',unidad='" & TextUnidad.Text & "',factor=" & TextFactor.Text & ",precio=" & TextPrecio.Text & ",existencia=" & TextExistencia.Text & ",min=" & TextMin.Text & ",max=" & TextMax.Text & " WHERE clave='" & TextClave.Text & "'"
        Else
            com.CommandText = "INSERT INTO inventario(clave,codigo,nombre,unidad,factor,precio,existencia,min,max) VALUES('" & TextClave.Text & "','" & TextCodigo.Text & "','" & TextNombre.Text & "','" & TextUnidad.Text & "'," & TextFactor.Text & "," & TextPrecio.Text & "," & TextExistencia.Text & "," & TextMin.Text & "," & TextMax.Text & ")"
        End If
        com.ExecuteNonQuery()
        TextClave.Text = ""
        TextCodigo.Text = ""
        TextNombre.Text = ""
        TextUnidad.Text = ""
        TextFactor.Text = ""
        TextPrecio.Text = ""
        TextExistencia.Text = ""
        TextMin.Text = ""
        TextMax.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Inventario.Visible Then
            Inventario.actualizaGrid()
        End If
        Me.Close()
    End Sub

    Sub modifica(clave As String)
        Dim con As New MySqlConnection(cadenaConexion)
        Dim com As New MySqlCommand
        Dim dr As MySqlDataReader

        con.Open()
        com.Connection = con
        com.CommandText = "select clave,codigo,nombre,unidad,factor,precio,existencia,min,max from inventario where clave='" & clave & "'"
        dr = com.ExecuteReader
        If dr.Read Then
            modificar = True
            TextClave.Text = dr.Item(0).ToString
            TextCodigo.Text = dr.Item(1).ToString
            TextNombre.Text = dr.Item(2).ToString
            TextUnidad.Text = dr.Item(3).ToString
            TextFactor.Text = dr.Item(4).ToString
            TextPrecio.Text = dr.Item(5).ToString
            TextExistencia.Text = dr.Item(6).ToString
            TextMin.Text = dr.Item(7).ToString
            TextMax.Text = dr.Item(8).ToString

            TextClave.ReadOnly = True
        End If
        con.Close()
    End Sub

End Class