Imports MySql.Data.MySqlClient


Public Class FormAltaCar

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim nombre As String
    Dim id As String = ""
    'Lista categorias seleccionadas
    Dim selected As New ArrayList


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
            ListBox1.Items.Clear()
            conn.Open()
            dr = mysqlreader("SELECT * FROM categorias;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ListBox1.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorias. Imposible conectar a la base de datos. Compruebe la conexión.")
        End Try

    End Sub

    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub

    Private Sub FormAltaCar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        leerCategorias()
        limpiar()
    End Sub

    Private Sub getID(ByVal nombre As String)
        Try
            dr = mysqlreader("SELECT id FROM caracteristicas where nombre='" & nombre & "';")
            While dr.Read()
                id = dr(0)
                ' MessageBox.Show("id -> " & id)
            End While

        Catch ex As Exception
            MessageBox.Show("No existe el ID")
        End Try


    End Sub


    'insertar datos en la tabla caractercat

    Private Sub caracterCat()
        Try
            conn.Open()

            For Each item In selected

                Dim myChar As Char
                myChar = item(1)

                If myChar = "-" Then
                    item = item.Substring(0, 1)
                End If

                mysql("INSERT INTO caractercat(caracteristica, categoria) VALUES('" & id & "','" & item & "');")
                'MessageBox.Show(id & "," & item)
            Next

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub limpiar()

        nombre = ""
        TextBox1.Text = ""
        id = ""
        selected.Clear()
        ListBox1.ClearSelected()

    End Sub

    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        nombre = TextBox1.Text

        Try
            If nombre <> "" Then

                ' Añadimos las categorias seleccionadas 
                For Each item As Object In ListBox1.SelectedItems
                    Dim t = ListBox1.GetItemText(item)
                    selected.Add(t.Substring(0, 2))
                Next

                If selected.Count() > 0 Then

                    conn.Open()
                    mysql("INSERT INTO caracteristicas(nombre) VALUES('" & nombre & "');")
                    MessageBox.Show("Se ha registrado la nueva característica!")

                    getID(nombre)
                    conn.Close()

                    caracterCat()
                    limpiar()

                Else
                    MessageBox.Show("Tiene que elegir al menos una categoría.")
                End If

            Else
                MessageBox.Show("Tiene que introducir un nombre para la nueva caracteristica.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




       

    End Sub
End Class