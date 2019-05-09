Imports MySql.Data.MySqlClient

Public Class FormDelCar

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim nombre As String
    Dim id As String = ""
    'Lista categorias seleccionadas
    Dim selected As New ArrayList

    Dim cate As New ArrayList


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



    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar()
        Button1.Enabled = False
        BotonReg.Enabled = False
    End Sub

    Private Sub leerCaracteristicas()
        Try
            conn.Open()
            dr = mysqlreader("SELECT * FROM caracteristicas;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ComboBox1.Items.Add(text)

            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar características. Imposible conectar a la base de datos. Compruebe la conexión.")
        End Try
        
    End Sub

    Private Sub limpiar()
        nombre = ""
        id = ""
        cate.Clear()
        selected.Clear()
        ComboBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Enabled = True
        ListBox1.Enabled = False
        ListBox1.Items.Clear()
        BtnBuscarP.Enabled = True
        ComboBox1.Items.Clear()
        leerCaracteristicas()

    End Sub

    Private Sub BtnBuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarP.Click
        id = ComboBox1.Text
        If id Is "" Then
            MessageBox.Show("Seleccione caracteristica.")
        Else
            Try

                id = id.Substring(0, 2)
                Dim myChar1 As Char
                myChar1 = id(1)

                If myChar1 = "-" Then
                    id = id.Substring(0, 1)
                End If

                ComboBox1.Enabled = False
                ListBox1.Enabled = True

                conn.Open()
                dr = mysqlreader("SELECT * FROM caracteristicas where id='" & id & "';")
                While dr.Read()
                    TextBox2.Text = dr(1)
                End While
                conn.Close()

                leerCategorias()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            BtnBuscarP.Enabled = False
            Button1.Enabled = True
            BotonReg.Enabled = True
        End If

    End Sub


    'leer categorias de la caracteristica elegida
    Private Sub leerCategorias()
        Try
            conn.Open()
            dr = mysqlreader("SELECT * FROM categorias WHERE id IN (SELECT categoria FROM caractercat where caracteristica='" & id & "');")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ListBox1.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        If id <> "" Then

            nombre = TextBox2.Text
            If nombre <> "" Then

                ' Añadimos las categorias seleccionadas 
                For Each item As Object In ListBox1.SelectedItems
                    Dim t = ListBox1.GetItemText(item)
                    cate.Add(t.Substring(0, 2))
                Next

                If cate.Count < 1 Then
                    MessageBox.Show("Tiene que elegir las categorias en las que desea borrar la caracteristica seleccionada")

                ElseIf cate.Count = ListBox1.Items.Count Then

                    Try
                        conn.Open()
                        mysql("DELETE FROM caracteristicas WHERE id='" & id & "';")
                        conn.Close()
                        MessageBox.Show("Se eliminó la caracteristica.")
                        limpiar()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                Else

                    Try
                        conn.Open()

                        For Each item In cate

                            Dim myChar As Char
                            myChar = item(1)

                            If myChar = "-" Then
                                item = item.Substring(0, 1)
                            End If

                            mysql("DELETE FROM caractercat WHERE categoria='" & item & "';")

                        Next

                        conn.Close()
                        MessageBox.Show("Se eliminaron las caracteristicas de las categorias seleccionadas!")
                        limpiar()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If

            End If

        Else
            MessageBox.Show("Seleccione la caracteristica que desea borrar mediante su ID.")
        End If
    End Sub

    Private Sub FormDelCar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        leerCaracteristicas()
    End Sub
End Class