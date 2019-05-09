Imports MySql.Data.MySqlClient

Public Class FormFinderItem

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            ListBox1.Items.Clear()
        Else
            leerProductos()
        End If
    End Sub

    'Procedimiento para leer los productos
    Private Sub leerProductos()
        ListBox1.Items.Clear()

        Try
            conn.Open()
            Dim nombre = TextBox1.Text
            dr = mysqlreader("SELECT * FROM productos WHERE nombre LIKE '%" & nombre & "%';") ' OR marca LIKE '%" & nombre & "%'
            While dr.Read()
                Dim text = dr(2) & " " & dr(1)
                ListBox1.Items.Add(text)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos. Imposible conectar a la base de datos. Compruebe la conexión.")
            Me.Dispose()
        End Try
       
    End Sub


    'Query SQL para leer una tabla usando un DataReader
    Function mysqlreader(ByVal sql) As MySqlDataReader

        cm.CommandText = sql ' comando sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Return cm.ExecuteReader()

    End Function

    Private Sub FormFinderItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
    End Sub
End Class