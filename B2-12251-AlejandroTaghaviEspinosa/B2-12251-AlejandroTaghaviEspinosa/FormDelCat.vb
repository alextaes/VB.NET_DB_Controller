Imports MySql.Data.MySqlClient

Public Class FormDelCat

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim id As String = ""
    Dim padre As Integer = 0

    'Query SQL para comandos sin retorno de informacion
    Private Sub mysql(ByVal sql As String)

        Dim result As Integer
        cm.Connection = conn
        cm.CommandText = sql
        Try
            result = cm.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    'Query SQL para leer una tabla usando un DataReader
    Function mysqlreader(ByVal sql) As MySqlDataReader

        cm.CommandText = sql ' comando sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Return cm.ExecuteReader()

    End Function

    Private Sub leerCategorias()
        Try
            conn.Open()
            dr = mysqlreader("SELECT * FROM categorias;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ComboBox1.Items.Add(text)
                ComboBox2.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorias. Imposible conectar con la base de datos. Compruebe la conexión.")
        End Try
        
    End Sub


    Private Sub FormDelCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub

    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        If id <> "" Then

            If RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MessageBox.Show("Tiene que elegir si desea eliminar los productos de la categoría o no.")

            Else
                Try

                    If RadioButton1.Checked = True Then


                        Dim producto As ArrayList = New ArrayList()

                        conn.Open()
                        dr = mysqlreader("SELECT producto FROM productocat where categoria='" & id & "';")
                        While dr.Read()
                            producto.Add(dr(0))

                        End While
                        conn.Close()



                        Dim unico As Boolean = True

                        For Each item In producto
                            conn.Open()
                            'MessageBox.Show("EL PRODUCTO - >" & item)
                            dr = mysqlreader("SELECT categoria FROM productocat where producto='" & item & "';")
                            While dr.Read()
                                ' MessageBox.Show(id & " -> las categorias - >" & dr(0))
                                If id <> dr(0) Then
                                    unico = False
                                End If
                            End While
                            conn.Close()

                            If unico = True Then
                                conn.Open()
                                mysql("DELETE FROM productos WHERE id IN (SELECT producto FROM productocat where categoria='" & id & "');")
                                MessageBox.Show("Productos pertenecientes a la categoria eliminados.")
                                conn.Close()
                            Else
                                conn.Open()
                                mysql("DELETE FROM productocat WHERE producto='" & item & "' AND categoria='" & id & "';")
                                MessageBox.Show("Productos de la categoria eliminados.")
                                conn.Close()
                            End If

                            unico = True
                        Next

                        


                    End If

                    conn.Open()
                    mysql("DELETE FROM categorias WHERE id='" & id & "';")
                    MessageBox.Show("Categoria eliminada.")
                    conn.Close()

                    limpiar()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try



            End If

        Else
            MessageBox.Show("Introduzca un Id para buscar la categoría")
        End If




    End Sub

    Private Sub BtnBuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarP.Click
        id = ComboBox2.Text

        If id Is "" Then
            MessageBox.Show("Seleccione categoría.")
        Else
            Try
                id = id.Substring(0, 2)
                Dim myChar1 As Char
                myChar1 = id(1)

                If myChar1 = "-" Then
                    id = id.Substring(0, 1)
                End If

                ComboBox2.Enabled = False
                Dim superior As Integer

                conn.Open()
                dr = mysqlreader("SELECT * FROM categorias where id='" & id & "';")
                While dr.Read()
                    TextBox1Cat.Text = dr(1)
                    superior = CInt(dr(2))
                End While
                conn.Close()

                For i = 0 To ComboBox1.Items.Count - 1
                    Dim t = ComboBox1.Items.Item(i)



                    t = t.Substring(0, 2)
                    Dim myChar As Char
                    myChar = t(1)

                    If myChar = "-" Then
                        t = t.Substring(0, 1)
                    End If

                    padre = CInt(t)

                    If padre = superior Then
                        ComboBox1.SelectedIndex = i
                    End If

                Next

                Button1.Enabled = True
                BotonReg.Enabled = True
                BtnBuscarP.Enabled = False

            Catch ex As Exception
                MessageBox.Show("No existe el ID")
            End Try
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar()
    End Sub

    Private Sub limpiar()

        id = ""
        ComboBox2.Enabled = True
        TextBox1Cat.Text = ""
        Button1.Enabled = False
        BotonReg.Enabled = False
        BtnBuscarP.Enabled = True
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Add("0-Ninguna")
        leerCategorias()
        RadioButton2.Checked = True
        ComboBox1.SelectedIndex = 0
        TextBox1Cat.Text = ""

    End Sub

End Class