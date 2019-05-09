Imports MySql.Data.MySqlClient

Public Class FormAltaProd


    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    'Variables para maenjar los datos
    Dim nombre As String
    Dim marca As String
    Dim Imagen As String
    Dim precio As String

    'Lista categorias seleccionadas
    Dim selected As New ArrayList

    Dim id As String = ""
    Dim idtienda As String = ""


    Private Sub BtnAltaProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        Try
            nombre = TextBox1P.Text
            marca = TextBox2P.Text
            Imagen = TextBox4P.Text
            precio = TextBox5P.Text



            If nombre <> "" And marca <> "" And Imagen <> "" And precio <> "" Then

                Imagen = "img/" & Imagen

                Try
                    Dim pre = CInt(precio)
                    conn.Open()

                    mysql("INSERT INTO productos(nombre, marca, foto) VALUES('" & nombre & "','" & marca & "','" & Imagen & "');")
                    MessageBox.Show("Se ha registrado el nuevo producto!")

                    getID(nombre)

                    ' Añadimos las categorias seleccionadas 
                    For Each item As Object In ListBox1.SelectedItems

                        Dim t = ListBox1.GetItemText(item)
                        selected.Add(t.Substring(0, 2))
                    Next
                    conn.Close()

                    selectTienda()

                    conn.Open()
                    mysql("INSERT INTO precios(id_producto, id_tienda, precio) VALUES('" & id & "','" & idtienda & "','" & precio & "');")
                    conn.Close()
                    'MessageBox.Show(id & "id->idtienda" & idtienda)
                    InsertarProCat()
                    limpiar()
                    ListBox1.ClearSelected()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                
            Else
                MessageBox.Show("Faltan datos necesarios. Inserte nombre, marca e imagen del producto.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    ' Cerramos la ventana
    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub

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

    ' seleccionamos el id de la tienda
    Private Sub selectTienda()
        Dim nom = ComboBox1.Text
        nom = nom.Substring(0, 1)
        'MessageBox.Show("el combo->" & nom)
        conn.Open()
        dr = mysqlreader("SELECT id FROM tiendas WHERE id='" & nom & "';")
        While dr.Read()
            Dim text = dr(0)
            idtienda = text
        End While
        conn.Close()
    End Sub

    'insertar datos en la tabla productcat

    Private Sub InsertarProCat()
        Try
            conn.Open()

            For Each item In selected

                Dim myChar As Char
                myChar = item(1)

                If myChar = "-" Then
                    item = item.Substring(0, 1)
                End If

                mysql("INSERT INTO productocat(producto, categoria) VALUES('" & id & "','" & item & "');")
                '  MessageBox.Show(id & "," & item)
            Next

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub limpiar()
        Try
            nombre = ""
            TextBox1P.Text = ""
            marca = ""
            TextBox2P.Text = ""
            Imagen = ""
            TextBox4P.Text = ""
            id = ""
            TextBox5P.Text = ""
            precio = ""
            ComboBox1.SelectedIndex = 0
            idtienda = ""
            selected.Clear()
        Catch ex As Exception

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
        ListBox1.Items.Clear()
        Try
            conn.Open()
            dr = mysqlreader("SELECT * FROM categorias;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ListBox1.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorias. Imposible conectar a la base de datos. Compruebe la conexión.")
            'Me.Dispose()
        End Try

    End Sub

    Private Sub leerTiendas()
        ComboBox1.Items.Clear()
        Try
            conn.Open()
            dr = mysqlreader("SELECT id, nombre FROM tiendas;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ComboBox1.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar tiendas. Imposible conectar a la base de datos. Compruebe la conexión.")
        End Try

    End Sub

    Private Sub getID(ByVal nombre As String)
        Try
            dr = mysqlreader("SELECT id FROM productos where nombre='" & nombre & "';")
            While dr.Read()
                id = dr(0)
            End While
        Catch ex As Exception
            MessageBox.Show("No existe el ID")
        End Try
        

    End Sub

    Private Sub FormAltaProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        leerCategorias()
        leerTiendas()
        Try
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
End Class

