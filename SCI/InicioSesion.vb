Public Class InicioSesion

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        If TxtPass.Text = "" Then
            Principal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedIndex = 0
        TxtPass.Focus()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TxtPass.Focus()
    End Sub
End Class
