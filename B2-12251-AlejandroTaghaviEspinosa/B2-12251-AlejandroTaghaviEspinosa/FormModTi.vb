Imports MySql.Data.MySqlClient


Public Class FormModTi

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    'Variables para campos tiendas
    Dim id As String
    Dim tipo As String

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

    Private Sub leerTiendas()
        Try
            conn.Open()
            dr = mysqlreader("SELECT id, nombre FROM tiendas;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ComboBox1.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorias. Imposible conectar a la base de datos. Compruebe la conexión.")
        End Try

    End Sub

    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub

    Private Sub FormModTi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        leerTiendas()
        comboTipo()
        limpiar()
    End Sub

    Private Sub BtnBuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarP.Click

        id = ComboBox1.Text

        If id Is "" Then
            MessageBox.Show("Seleccione tienda.")
            Exit Sub
        Else

            id = id.Substring(0, 2)
            Dim myChar As Char
            myChar = id(1)

            If myChar = "-" Then
                id = id.Substring(0, 1)
            End If

            Try

                conn.Open()
                dr = mysqlreader("SELECT * FROM tiendas where id='" & id & "';")
                While dr.Read()
                    TextBox1.Text = dr(1)
                    tipo = dr(3)
                    If tipo = "fisica" Then
                        ComboBox2.SelectedIndex = 0
                    Else
                        ComboBox2.SelectedIndex = 1
                        TextBox2.Text = dr(2)
                    End If
                    TextBox3.Text = dr(4)
                    TextBox4.Text = dr(5)

                End While
                conn.Close()

                ComboBox1.Enabled = False
                TextBox1.Enabled = True
                TextBox3.Enabled = True
                TextBox4.Enabled = True
                ComboBox2.Enabled = True
                BtnBuscarP.Enabled = False
                Button1.Enabled = True
                BotonReg.Enabled = True

            Catch ex As Exception
                MessageBox.Show("No existe el ID" & ex.Message)
            End Try
            BtnBuscarP.Enabled = False
            Button1.Enabled = True
            BotonReg.Enabled = True


        End If

    End Sub

    Private Sub limpiar()
        ComboBox1.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox2.Enabled = False
        BtnBuscarP.Enabled = True
        Button1.Enabled = False
        BotonReg.Enabled = False

        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox2.SelectedIndex = 0
        tipo = ""
        id = ""
    End Sub


    Private Sub comboTipo()
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("fisica")
        ComboBox2.Items.Add("online")
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "online" Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        If TextBox1.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And ComboBox1.Text <> "" Then

            Try
                conn.Open()
                If ComboBox2.Text = "online" Then
                    If TextBox2.Text = "" Then
                        MessageBox.Show("Falta introducir la URL de la tienda.")
                        conn.Close()
                        Exit Sub
                    Else
                        mysql("UPDATE tiendas SET nombre='" & TextBox1.Text & "', url='" & TextBox2.Text & "', tipo='" & ComboBox2.Text & "', latitud='" & TextBox3.Text & "', longitud='" & TextBox4.Text & "' WHERE id='" & id & "';")
                    End If

                Else
                    mysql("UPDATE tiendas SET nombre='" & TextBox1.Text & "', url='none', tipo='" & ComboBox2.Text & "', latitud='" & TextBox3.Text & "', longitud='" & TextBox4.Text & "' WHERE id='" & id & "';")
                End If
                conn.Close()
                limpiar()
                MessageBox.Show("Tienda actualizada correctamente.")
                limpiar()
                ComboBox1.Items.Clear()
                leerTiendas()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan datos necesarios. Rellene todos los campos.")
        End If
    End Sub
End Class