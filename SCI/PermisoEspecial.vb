Public Class PermisoEspecial
    Public pe As String = ""
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reg As DataRow = Nothing
        If G.leerFila("SELECT idRol FROM usuarios WHERE User='" & TextBox1.Text & "' and Pass=MD5('" & TextBox2.Text & "')", reg) Then
            If G.leerFila("SELECT Permisos FROM roles WHERE idRol='" & reg(0).ToString & "'", reg) Then
                pe = reg(0).ToString
                Me.Hide()
            End If
        End If
    End Sub
End Class