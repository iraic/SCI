Imports MySql.Data.MySqlClient

Public Class InicioSesion

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click

        If validarUsuario(ListBox1.Items(ListBox1.SelectedIndex), TxtPass.Text) Then
            user = ListBox1.Items(ListBox1.SelectedIndex)
            If G.leerPermisos() Then
                Principal.Show()
                Me.Close()
            Else
                MsgBox("El usuario no tiene ningún permiso", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Error: el usuario no existe o la contraseña es incorrecta", MsgBoxStyle.Critical, "Error")
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

    Private Function validarUsuario(user As String, pass As String) As Boolean
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand("SELECT idRol FROM usuarios WHERE User='" & user & "' and Pass=MD5('" & pass & "')", con)
        Dim dr As MySqlDataReader
        con.Open()
        dr = com.ExecuteReader
        If dr.Read Then
            validarUsuario = True
        Else
            validarUsuario = False
        End If
        con.Close()
    End Function

End Class
