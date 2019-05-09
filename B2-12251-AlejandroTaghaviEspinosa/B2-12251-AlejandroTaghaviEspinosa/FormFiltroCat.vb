Imports MySql.Data.MySqlClient

Public Class FormFiltroCat


    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub FormFiltroCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        leerCategorias()
        ListBox1.ClearSelected()
        ListBox2.Items.Clear()
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        leerProductos()
    End Sub

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
            Me.Dispose()
        End Try

    End Sub


    'Procedimiento para leer los productos
    Private Sub leerProductos()
        Try

            Dim t As String = ""
            ListBox2.Items.Clear()
            For Each item As Object In ListBox1.SelectedItems

                t = ListBox1.GetItemText(item)
                'MessageBox.Show("-> " & t)
                t = t.Substring(0, 2)
                Dim myChar As Char
                myChar = item(1)

                If myChar = "-" Then
                    t = t.Substring(0, 1)
                End If

                Try
                    conn.Open()
                    If t = "1" Or t = "2" Or t = "4" Then
                        dr = mysqlreader("SELECT * FROM productos WHERE id IN " &
                                         "(SELECT producto FROM productocat WHERE categoria IN " &
                                         "(SELECT ca.id FROM categorias ca, categorias cu WHERE ca.padre=cu.id AND cu.id='" & t & "'));")
                        While dr.Read()
                            Dim text = dr(2) & " " & dr(1)
                            ListBox2.Items.Add(text)
                        End While

                    Else
                        dr = mysqlreader("SELECT * FROM productos WHERE id IN (SELECT producto FROM productocat where categoria='" & t & "');")
                        While dr.Read()
                            Dim text = dr(2) & " " & dr(1)
                            ListBox2.Items.Add(text)
                        End While
                    End If
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    conn.Close()
                End Try

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub


    'Query SQL para leer una tabla usando un DataReader
    Function mysqlreader(ByVal sql) As MySqlDataReader

        cm.CommandText = sql ' comando sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Return cm.ExecuteReader()

    End Function


End Class