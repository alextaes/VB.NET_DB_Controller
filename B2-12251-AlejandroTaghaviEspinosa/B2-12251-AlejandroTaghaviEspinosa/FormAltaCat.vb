Imports MySql.Data.MySqlClient

Public Class FormAltaCat

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim nombre As String = ""
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
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorias. Imposible conectar con la base de datos. Compruebe la conexión.")
        End Try
       
    End Sub


    Private Sub FormAltaCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub

    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        nombre = TextBox1Cat.Text

        Try
            Dim t = ComboBox1.Text
            ' MessageBox.Show(t)

            If t <> Nothing Then
                t = t.Substring(0, 2)
                Dim myChar As Char
                myChar = t(1)

                If myChar = "-" Then
                    t = t.Substring(0, 1)
                End If

                padre = CInt(t)
                'MessageBox.Show(padre)
            Else
                padre = 0
            End If

            If nombre <> "" Then

                conn.Open()

                mysql("INSERT INTO categorias(nombre, padre) VALUES('" & nombre & "','" & padre & "');")
                MessageBox.Show("Categoria registrada correctamente!")
                conn.Close()

                limpiar()
                
            Else
                MessageBox.Show("Debe introducir un nombre para la categoría.")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        

    End Sub



    Private Sub limpiar()
        Try
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("0-Ninguna")
            leerCategorias()
            ComboBox1.SelectedIndex = 0
            nombre = ""
            TextBox1Cat.Text = ""
            padre = 0
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception

        End Try
       
    End Sub

End Class