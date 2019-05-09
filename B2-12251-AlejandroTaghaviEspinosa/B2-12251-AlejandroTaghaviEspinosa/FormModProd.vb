Imports MySql.Data.MySqlClient


Public Class FormModProd

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

    'Click sobre el boton buscar para cargar en las cajas de texto los datos
    ' del producto seleccionado
    Private Sub BtnBuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarP.Click

        id = ComboBox2.Text

        If id Is "" Then
            MessageBox.Show("Seleccione un producto.")
        Else

            id = id.Substring(0, 2)

            Dim myChar As Char
            myChar = id(1)

            If myChar = "-" Then
                id = id.Substring(0, 1)
            End If

            Try

                conn.Open()
                dr = mysqlreader("SELECT * FROM productos where id='" & id & "';")
                While dr.Read()
                    TextBox6P.Text = dr(1)
                    TextBox7P.Text = dr(2)
                    TextBox9P.Text = dr(3).Substring(4)
                End While
                conn.Close()

                catSelected()

                conn.Open()
                dr = mysqlreader("SELECT precio, id_tienda FROM precios WHERE id_producto='" & id & "';")

                While dr.Read()
                    TextBox10P.Text = dr(0)
                    Dim index = dr(1)
                    ComboBox1.SelectedIndex = index - 1
                End While

                conn.Close()

                ComboBox2.Enabled = False
                TextBox6P.Enabled = True
                TextBox7P.Enabled = True
                TextBox9P.Enabled = True
                TextBox10P.Enabled = True
                ComboBox1.Enabled = True
                ListBox1.Enabled = True

            Catch ex As Exception
                MessageBox.Show("No existe el ID" & ex.Message)
            End Try
            BtnBuscarP.Enabled = False
            Button1.Enabled = True
            BotonReg.Enabled = True
        End If

        
    End Sub
    ' Procedimiento para leer las categorias
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
            MessageBox.Show("Error al cargar categorias. Imposible conectar con la base de datos. Compruebe la conexión.")
        End Try

        
    End Sub
    'Procedimiento para leer los productos
    Private Sub leerProductos()
        ComboBox2.Items.Clear()
        Try
            conn.Open()
            dr = mysqlreader("SELECT * FROM productos;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ComboBox2.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos. Imposible conectar con la base de datos. Compruebe la conexión.")
            'Me.Dispose()
        End Try
        
    End Sub
    ' Procedimiento para leer las tiendas
    Private Sub leerTiendas()
        Try
            ComboBox1.Items.Clear()
            conn.Open()
            dr = mysqlreader("SELECT id, nombre FROM tiendas;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ComboBox1.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar tiendas. Imposible conectar con la base de datos. Compruebe la conexión.")
        End Try

    End Sub

    'Cargamos las categorias seleccionadas en el ListBox
    Private Sub catSelected()
        If id <> "" Then
            Try
                conn.Open()
                dr = mysqlreader("SELECT categoria FROM productocat WHERE producto ='" & id & "';")
                While dr.Read()
                    selected.Add(dr(0))
                    'MessageBox.Show(dr(0))
                End While
                conn.Close()

                For i = 0 To ListBox1.Items.Count - 1
                    Dim t = ListBox1.GetItemText(ListBox1.Items(i))
                    t = t.Substring(0, 2)
                    Dim myChar As Char
                    myChar = t(1)

                    If myChar = "-" Then
                        t = t.Substring(0, 1)
                    End If
                    
                    For Each item In selected
                        If CInt(item) = CInt(t) Then
                            ListBox1.SetSelected(i, True)
                        End If
                    Next
                Next

                selected.Clear()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("No existe el producto.")
        End If
        

    End Sub


    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub

 
   
    Private Sub FormModProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        leerProductos()
        leerCategorias()
        leerTiendas()
        seleccion()
        limpiar()
        Try
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception
        End Try

    End Sub

    Private Sub limpiar()
        Try
            nombre = ""
            marca = ""
            TextBox6P.Text = ""
            Imagen = ""
            TextBox7P.Text = ""
            id = ""
            idtienda = ""
            TextBox9P.Text = ""
            ComboBox2.SelectedIndex = 0
            precio = ""
            TextBox10P.Text = ""
            selected.Clear()
            ListBox1.ClearSelected()
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        seleccion()
        limpiar()
    End Sub

    Private Sub seleccion()
        ComboBox2.Enabled = True
        TextBox6P.Enabled = False
        TextBox7P.Enabled = False
        TextBox9P.Enabled = False
        ListBox1.Enabled = False
        TextBox10P.Enabled = False
        ComboBox1.Enabled = False
        BtnBuscarP.Enabled = True
        Button1.Enabled = False
        BotonReg.Enabled = False
    End Sub


    'insertar datos en la tabla productcat
    Private Sub InsertarProCat()

        conn.Open()
        For Each item In selected

            Dim myChar As Char
            myChar = item(1)

            If myChar = "-" Then
                item = item.Substring(0, 1)
            End If

            mysql("INSERT INTO productocat(producto, categoria) VALUES('" & id & "','" & item & "');")
            ' MessageBox.Show(id & "," & item)
        Next
        conn.Close()
    End Sub

    'borrar datos en la tabla productcat
    Private Sub borrarProCat()
        Try
            conn.Open()

            mysql("DELETE FROM productocat WHERE producto='" & id & "';")
            '  MessageBox.Show(id & "," & item)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
      
    End Sub

    ' seleccionamos el id de la tienda
    Private Sub selectTienda()
        Dim nom = ComboBox1.Text
        nom = nom.Substring(0, 1)
        'MessageBox.Show("el combo->" & nom)
        Try
            conn.Open()
            dr = mysqlreader("SELECT id FROM tiendas WHERE id='" & nom & "';")
            While dr.Read()
                Dim text = dr(0)
                idtienda = text
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Modificar producto
    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        nombre = TextBox6P.Text
        marca = TextBox7P.Text
        Imagen = TextBox9P.Text
        precio = TextBox10P.Text

        If id <> "" Then
            If nombre <> "" And marca <> "" And Imagen <> "" And precio <> "" Then
                Imagen = "img/" & Imagen

                Try

                    Dim pre = CInt(precio)
                    conn.Open()

                    mysql("UPDATE productos SET nombre='" & nombre & "', marca='" & marca & "', foto='" & Imagen & "' WHERE id='" & id & "';")
                    MessageBox.Show("Se han actualizado los datos de el producto!")

                    conn.Close()
                    borrarProCat()

                    ' Añadimos las categorias seleccionadas 
                    For Each item As Object In ListBox1.SelectedItems
                        Dim t = ListBox1.GetItemText(item)
                        selected.Add(t.Substring(0, 2))
                    Next

                    InsertarProCat()

                    selectTienda()
                    conn.Open()
                    mysql("INSERT INTO precios(id_producto, id_tienda, precio) VALUES('" & id & "','" & idtienda & "','" & precio & "') ON DUPLICATE KEY UPDATE precio='" & precio & "';")
                    conn.Close()

                    limpiar()
                    leerCategorias()
                    leerProductos()
                    seleccion()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


            Else
                MessageBox.Show("Faltan datos necesarios. Inserte nombre, marca, imagen y precio del producto.")
            End If
        End If

    End Sub


End Class