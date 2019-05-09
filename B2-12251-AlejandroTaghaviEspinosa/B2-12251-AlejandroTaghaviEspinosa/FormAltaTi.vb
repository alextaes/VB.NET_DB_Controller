Imports MySql.Data.MySqlClient

Public Class FormAltaTi

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim lat As String
    Dim lon As String


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

    Sub carga()
        'un metodo asincrono para cargar los mapas consecutivamente, se le llama cuando el evento de carga ha terminado
        Dim lat = TextBox3.Text
        Dim lon = TextBox4.Text
        mapa(lat, lon) 'dibujo del mapa

    End Sub

    Sub mapa(ByVal lat, ByVal lon)
        Dim url As String = "https://www.openstreetmap.org/?mlat=" & lat & "&mlon=" & lon & "#map=18/" & lat & "/" & lon
        WebBrowser1.Navigate(url) 'carga una pagina web, usa el motoro del IE

    End Sub

    Private Sub FormAltaTi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.openstreetmap.org")
        comboTipo()
        limpiar()
    End Sub


    Private Sub comboTipo()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("fisica")
        ComboBox1.Items.Add("online")
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "online" Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        If TextBox1.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And ComboBox1.Text <> "" Then

            Try
                conn.Open()
                If ComboBox1.Text = "online" Then
                    If TextBox2.Text = "" Then
                        MessageBox.Show("Falta introducir la URL de la tienda.")
                        conn.Close()
                        Exit Sub
                    Else
                        mysql("INSERT INTO tiendas(nombre, url, tipo, latitud, longitud) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "');")
                    End If

                Else
                    mysql("INSERT INTO tiendas(nombre, url, tipo, latitud, longitud) VALUES ('" & TextBox1.Text & "','none','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "');")
                End If
                conn.Close()
                mapa(TextBox3.Text, TextBox4.Text)
                limpiar()
                MessageBox.Show("Nueva tienda añadida correctamente.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan datos necesarios. Rellene todos los campos.")
        End If

    End Sub


    Private Sub limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
    End Sub
End Class