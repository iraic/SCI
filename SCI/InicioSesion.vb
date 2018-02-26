Imports MySql.Data.MySqlClient

Public Class InicioSesion

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Dim conUser As New MySqlConnection(servidor)
        Dim comUser As New MySqlCommand
        Dim idrUser As MySqlDataReader

        conUser.Open()
        comUser.Connection = conUser
        comUser.CommandText = "select * from usuarios where user='" & ListBox1.Items(ListBox1.SelectedIndex) & "'"
        idrUser = comUser.ExecuteReader
        If idrUser.Read Then
            If idrUser.Item(1).ToString = TxtPass.Text Then
                user = idrUser.Item(0).ToString
                conUser.Close()
                Principal.Show()
                Me.Close()
            Else
                conUser.Close()
                MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical)
            End If
        Else
            conUser.Close()
            MsgBox("El usuario no existe", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() & "\conexion.txt") Then
            Dim f As New IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory() & "\conexion.txt")
            G.servidor = "Server=" & f.ReadLine & ";Database=sci;Uid=root;Password="
            f.Close()
        End If

        Dim conUser As New MySqlConnection(servidor)
        Dim comUser As New MySqlCommand
        Dim idrUser As MySqlDataReader

        conUser.Open()
        comUser.Connection = conUser
        comUser.CommandText = "select user from usuarios"
        idrUser = comUser.ExecuteReader
        ListBox1.Items.Clear()
        While idrUser.Read
            ListBox1.Items.Add(idrUser.Item(0))
        End While
        conUser.Close()

        ListBox1.SelectedIndex = 0
        TxtPass.Focus()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TxtPass.Focus()
    End Sub
End Class
