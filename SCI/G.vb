Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Module G
    Public servidor As String = "Server=localhost;Database=sci;Uid=root;Password="
    Public hCache As Integer

    Public user As String
    Public rol As String
    Public permisos As String
    Public separador As String = "-"
    Public caja As Integer

    Public empresa As String
    Public direccion As String
    'Public lectorH As New zkemkeeper.CZKEM
    'Public estadoL As Integer = 0
    'Public estadoL2 As Integer = 0


    Public Function leerPermisos()
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand
        Dim dr As MySqlDataReader
        leerPermisos = False
        con.Open()
        com.Connection = con
        com.CommandText = "SELECT roles.Nombre,roles.Permisos FROM usuarios,roles WHERE usuarios.idRol=roles.idRol and usuarios.User='" & user & "'"
        dr = com.ExecuteReader
        If dr.Read Then
            G.rol = dr.Item(0)
            G.permisos = dr.Item(1)
            leerPermisos = True
        End If
        con.Close()
    End Function

    Public Sub llenarGrid(sql As String, dg As DataGridView)
        Try
            Dim con As New MySqlConnection(G.servidor)
            Dim ada As New MySqlDataAdapter(sql, con)
            Dim dt As New DataTable
            dt.Clear()
            ada.Fill(dt)
            dg.DataSource = dt
            dg.Refresh()
        Catch
        End Try
    End Sub


    Public Sub llenarCombo(sql As String, cb As ComboBox)
        Try
            Dim con As New MySqlConnection(G.servidor)
            Dim com As New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader
            con.Open()
            dr = com.ExecuteReader
            cb.Items.Clear()
            While dr.Read
                cb.Items.Add(dr.Item(0).ToString)
            End While
            con.Close()
        Catch
        End Try
    End Sub

    Public Sub ejecutarsql(sql As String)
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand(sql, con)
        Dim res As Integer
        Try
            con.Open()
            res = com.ExecuteNonQuery
            con.Close()
            If res > 0 Then
                MsgBox("Se afecto " & res & " registro(s)")
            Else
                MsgBox("No efectuó la operación", MsgBoxStyle.Critical)
            End If
        Catch
            Select Case Err.Number
                Case 5
                    MsgBox("No se puede agregar este registro porque ya existe otro similar", MsgBoxStyle.Critical)
                Case Else
                    MsgBox(Err.Number & ":" & Err.Description, MsgBoxStyle.Critical)
            End Select
        End Try

    End Sub

    Public Function agregar(tabla As String, campos As String) As Boolean
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand("INSERT INTO " & tabla & " VALUES(" & campos & ")", con)
        Dim res As Integer
        agregar = False
        Try
            con.Open()
            res = com.ExecuteNonQuery
            con.Close()
            If res > 0 Then
                agregar = True
            End If
        Catch
            'MsgBox(Err.Number & ":" & Err.Description, MsgBoxStyle.Critical)
        End Try
    End Function

    Public Function eliminar(tabla As String, condicion As String) As Boolean
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand("DELETE FROM " & tabla & " WHERE " & condicion, con)
        Dim res As Integer
        eliminar = False
        Try
            con.Open()
            res = com.ExecuteNonQuery
            con.Close()
            If res > 0 Then
                eliminar = True
            End If
        Catch
            MsgBox(Err.Number & ":" & Err.Description, MsgBoxStyle.Critical)
        End Try
    End Function

    Public Function modificar(tabla As String, campos As String, condicion As String) As Boolean
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand("UPDATE " & tabla & " SET " & campos & " WHERE " & condicion, con)
        Dim res As Integer
        modificar = False
        Try
            con.Open()
            res = com.ExecuteNonQuery
            con.Close()
            If res > 0 Then
                modificar = True
            End If
        Catch
            MsgBox(Err.Number & ":" & Err.Description, MsgBoxStyle.Critical)
        End Try
    End Function

    Public Function leerFila(sql As String, ByRef dr As DataRow) As Boolean
        Dim con As New MySqlConnection(G.servidor)
        Dim ada As New MySqlDataAdapter(sql, con)
        Dim dt As New DataTable
        leerFila = False
        Try
            dt.Clear()
            ada.Fill(dt)
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                leerFila = True
            Else
                dr = Nothing
            End If
        Catch
        End Try

    End Function

    Public Function leerTabla(sql As String, ByRef dt As DataTable) As Boolean
        Dim con As New MySqlConnection(G.servidor)
        Dim ada As New MySqlDataAdapter(sql, con)
        dt = New DataTable
        dt.Clear()
        ada.Fill(dt)
        If dt.Rows.Count > 0 Then
            leerTabla = True
        Else
            leerTabla = False
        End If
    End Function

    Public Function secuencia(tabla As String, campo As String) As Integer
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand("SELECT MAX(" & campo & ") FROM " & tabla, con)
        Dim dr As MySqlDataReader
        secuencia = 0
        con.Open()
        dr = com.ExecuteReader
        If dr.Read Then
            secuencia = Val(dr.Item(0).ToString) + 1
        End If
        con.Close()
    End Function

    Public Function leerCadena(tabla As String, campo As String, condicion As String) As String
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand("SELECT " & campo & " FROM " & tabla & " WHERE " & condicion, con)
        Dim dr As MySqlDataReader
        Dim cad As String = ""
        Try
            con.Open()
            dr = com.ExecuteReader
            If dr.Read Then
                cad = dr.Item(0).ToString
            End If
            con.Close()
        Catch
        End Try

        Return cad
    End Function

    Public Function guardaImagen(tabla As String, campoKey As String, valorKey As String, campoBlob As String, valorBlob As Image) As Boolean
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim sql As String
        guardaImagen = False
        Try

            Dim Imag As Byte()
            Imag = Imagen_Bytes(valorBlob)

            con.Open()
            com.Connection = con

            com.CommandText = "SELECT " & campoKey & " FROM " & tabla & " WHERE " & campoKey & "=" & valorKey
            dr = com.ExecuteReader
            If dr.Read Then
                sql = "UPDATE " & tabla & " SET " & campoBlob & "=?" & campoBlob & " WHERE " & campoKey & "=" & valorKey
            Else
                sql = "INSERT INTO " & tabla & "(" & campoKey & "," & campoBlob & ") VALUES(" & valorKey & ",?" & campoBlob & ")"
            End If
            dr.Close()
            com.CommandText = sql
            com.Parameters.AddWithValue("?" & campoBlob, Imag)
            com.ExecuteNonQuery()
            con.Close()
            guardaImagen = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function leerImagen(tabla As String, campoBlob As String, condicion As String) As Image
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand
        Dim dr As MySqlDataReader
        leerImagen = Nothing
        con.Open()
        com.Connection = con
        Try
            Dim Imag As Byte()
            com.CommandText = "SELECT " & campoBlob & " FROM " & tabla & " WHERE " & condicion
            dr = com.ExecuteReader
            If dr.Read() Then
                Imag = dr(campoBlob)
                leerImagen = Bytes_Imagen(Imag)
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            If Not Imagen Is Nothing Then
                Dim Bin As New MemoryStream(Imagen)
                Dim Resultado As Image = Image.FromStream(Bin)
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        If Not Imagen Is Nothing Then
            Dim Bin As New MemoryStream
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Public Function transaccion(operaciones() As String) As Boolean
        Dim con As New MySqlConnection(G.servidor)
        Dim com As New MySqlCommand
        Dim tr As MySqlTransaction
        transaccion = False

        con.Open()
        tr = con.BeginTransaction()
        com.Connection = con
        com.Transaction = tr
        Try
            For Each op As String In operaciones
                com.CommandText = op
                com.ExecuteNonQuery()
            Next
            tr.Commit()
            con.Close()
            transaccion = True
            MsgBox("Se realizó la operación correctamente")
        Catch ex As Exception
            Try
                tr.Rollback()
            Catch ex2 As Exception
                MsgBox(ex2.GetType.ToString & ":" & ex2.Message, MsgBoxStyle.Critical)
            End Try
            MsgBox(ex.GetType.ToString & ":" & ex.Message, MsgBoxStyle.Critical)
            MsgBox("No se efectuó la operación", MsgBoxStyle.Critical)
        End Try
    End Function


End Module
