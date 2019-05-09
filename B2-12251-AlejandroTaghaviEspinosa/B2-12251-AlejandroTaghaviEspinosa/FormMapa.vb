Imports MySql.Data.MySqlClient

Public Class FormMapa

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim lat As String
    Dim lon As String

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

    Private Sub selectTienda()
        Dim nom = ComboBox1.Text
        nom = nom.Substring(0, 2)

        Dim myChar As Char
        myChar = nom(1)

        If myChar = "-" Then
            nom = nom.Substring(0, 1)
        End If

        Try
            conn.Open()
            dr = mysqlreader("SELECT latitud, longitud FROM tiendas WHERE id='" & nom & "';")
            While dr.Read()
                lat = dr(0)
                lon = dr(1)
            End While
            conn.Close()
            carga()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Sub carga() 
        mapa(lat, lon) 'dibujo del mapa
        'MessageBox.Show(lat & " " & lon)
    End Sub

    Sub mapa(ByVal lat, ByVal lon)
        Dim url As String = "https://www.openstreetmap.org/?mlat=" & lat & "&mlon=" & lon & "#map=18/" & lat & "/" & lon
        WebBrowser1.Navigate(url) 'carga una pagina web, usa el motoro del IE

    End Sub


    Private Sub FormMapa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.openstreetmap.org")
        ComboBox1.Items.Clear()
        leerTiendas()
        ComboBox1.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        selectTienda()
    End Sub
End Class