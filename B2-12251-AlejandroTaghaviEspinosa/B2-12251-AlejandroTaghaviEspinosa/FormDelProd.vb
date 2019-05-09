Imports MySql.Data.MySqlClient


Public Class FormDelProd

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
    ' Click sobre el boton buscar, carga los datos del producto en el formulario
    Private Sub BtnBuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarP.Click

        id = ComboBox2.Text

        If id Is "" Then
            MessageBox.Show("Seleccione un producto.")
        Else
            Try

                id = id.Substring(0, 2)
                Dim myChar As Char
                myChar = id(1)

                If myChar = "-" Then
                    id = id.Substring(0, 1)
                End If


                conn.Open()
                dr = mysqlreader("SELECT * FROM productos where id='" & id & "';")
                While dr.Read()
                    TextBox6P.Text = dr(1)
                    TextBox7P.Text = dr(2)
                    TextBox9P.Text = dr(3)
                End While
                conn.Close()

                nombre = TextBox6P.Text
                marca = TextBox7P.Text
                Imagen = TextBox9P.Text

                leerCategorias()

                conn.Open()
                dr = mysqlreader("SELECT precio, id_tienda FROM precios WHERE id_producto='" & id & "';")

                While dr.Read()
                    TextBox10P.Text = dr(0)
                    Dim index = dr(1)
                    ComboBox1.SelectedIndex = index - 1
                End While

                conn.Close()

                ComboBox2.Enabled = False
                Button1.Enabled = True
                BotonDel.Enabled = True
                BtnBuscarP.Enabled = False

            Catch ex As Exception
                MessageBox.Show("No existe el ID")
            End Try
        End If

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
        End Try
        
    End Sub
    'leer categorias de el producto elegido
    Private Sub leerCategorias()
        Try
            ListBox1.Items.Clear()
            conn.Open()
            dr = mysqlreader("SELECT * FROM categorias WHERE id IN (SELECT categoria FROM productocat where producto='" & id & "');")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ListBox1.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Procedimiento para leer las tiendas
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
            MessageBox.Show("Error al cargar tiendas. Imposible conectar con la base de datos. Compruebe la conexión.")
        End Try

    End Sub
    ' Vaciar cajas de texto y variables
    Private Sub limpiar()
        Try
            id = ""
            nombre = ""
            marca = ""
            Imagen = ""
            precio = ""
            ComboBox2.SelectedIndex = 0
            ComboBox1.SelectedIndex = 0
            TextBox6P.Text = ""
            TextBox7P.Text = ""
            TextBox9P.Text = ""
            TextBox10P.Text = ""
            selected.Clear()
            ListBox1.Items.Clear()

        Catch ex As Exception

        End Try
      
    End Sub
    ' Boton cancelar del formulario
    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub
    ' Boton volver, vuelve a activar el modo seleccion producto y vacía los textbox
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        seleccion()
        limpiar()
    End Sub

    Private Sub seleccion()
        ComboBox2.Enabled = True
        TextBox6P.Enabled = False
        TextBox7P.Enabled = False
        TextBox9P.Enabled = False
        BtnBuscarP.Enabled = True
        Button1.Enabled = False
        BotonDel.Enabled = False
    End Sub


    'Carga del formulario
    Private Sub FormDelProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        leerProductos()
        leerTiendas()
        seleccion()
        limpiar()
        Try
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception
        End Try

    End Sub

    ' Elimina el producto seleccionado
    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonDel.Click
        If id <> "" Then
            If nombre <> "" And marca <> "" And Imagen <> "" Then
                conn.Open()

                mysql("DELETE FROM productos WHERE id='" & id & "';")
                MessageBox.Show("Se ha eliminado el producto correctamente.")

                conn.Close()
                limpiar()
                leerProductos()
                seleccion()
            Else
                MessageBox.Show("No existe el producto.")
            End If
        End If
    End Sub
End Class