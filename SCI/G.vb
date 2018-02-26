Imports MySql.Data
Imports MySql.Data.MySqlClient
Module G

    Public servidor As String = "DATABASE=sci;DATASOURCE=localhost;USERID=root;PWD="
    Public user As String
    Public rol As String
    Public permisos As String
    Public separador As String = "-"

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

    Public Function Letras(numero As Double) As String
        Dim cantidad As String = Format(numero, "0.00")
        Return Letras(cantidad)
    End Function

    Public Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String
        entero = ""
        dec = ""
        palabras = ""
        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & " pesos " & dec & "/100 M.N."
            Else
                Letras = palabras
            End If
        Else
            Letras = ""
        End If
    End Function

End Module
