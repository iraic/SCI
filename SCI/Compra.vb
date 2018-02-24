Imports MySql.Data.MySqlClient

Public Class Compra

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nuevo()

        dtpFecha.Text = Now.ToShortDateString

        Dim con As New MySqlConnection(cadenaConexion)
        Dim com As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim recFolio As Integer = 0
        con.Open()
        com.Connection = con
        com.CommandText = "select max(usuFolio from tabUsuarios where usuUser='" & sesUser & "'"
        dr = com.ExecuteReader
        If dr.Read Then
            recFolio = dr.Item(0)
        End If
        con.Close()

        recFolio = recFolio + 1
        TextBox1.Text = recFolio
    End Sub
End Class