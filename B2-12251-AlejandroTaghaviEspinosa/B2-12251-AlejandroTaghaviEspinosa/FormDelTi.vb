Imports MySql.Data.MySqlClient

Public Class FormDelTi

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
            MessageBox.Show("Error al cargar tiendas. Imposible conectar a la base de datos. Compruebe la conexión.")
        End Try

    End Sub

    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub


    Private Sub limpiar()
        ComboBox1.Enabled = True
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
                BtnBuscarP.Enabled = False
                Button1.Enabled = True
                BotonReg.Enabled = True

            Catch ex As Exception
                MessageBox.Show("No existe la tienda" & ex.Message)
            End Try
            BtnBuscarP.Enabled = False
            Button1.Enabled = True
            BotonReg.Enabled = True


        End If
    End Sub

    Private Sub FormDelTi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        leerTiendas()
        comboTipo()
        limpiar()
    End Sub

    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        If id <> "" Then
            Try
                conn.Open()   
                mysql("DELETE FROM tiendas WHERE id='" & id & "';")
                conn.Close()
                limpiar()
                MessageBox.Show("Tienda eliminada correctamente.")
                limpiar()
                ComboBox1.Items.Clear()
                leerTiendas()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccione la tienda que desea eliminar.")
        End If
    End Sub
End Class