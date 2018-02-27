Public Class DatosEmpresa

    Private Sub DatosEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reg As DataRow = Nothing
        If G.leerFila("select * from empresa where id=1", reg) Then
            TextBox1.Text = reg("Nombre").ToString
            TextBox2.Text = reg("Calle").ToString
            TextBox3.Text = reg("No").ToString
            TextBox4.Text = reg("Colonia").ToString
            TextBox5.Text = reg("Telefono").ToString
            TextBox6.Text = reg("Ciudad").ToString
            TextBox7.Text = reg("Horario").ToString
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        G.modificar("empresa", "Nombre='" & TextBox1.Text & "',Calle='" & TextBox2.Text & "',No='" & TextBox3.Text & "',Colonia='" & TextBox4.Text & "',Telefono='" & TextBox5.Text & "',Ciudad='" & TextBox6.Text & "',Horario='" & TextBox7.Text & "'", "id=1")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.Close()
    End Sub
End Class