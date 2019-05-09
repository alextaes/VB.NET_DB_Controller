Imports MySql.Data.MySqlClient


Public Class FormModCat
    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim nombre As String = ""
    Dim padre As Integer = 0

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

    Private Sub leerCategorias()
        Try
            conn.Open()
            dr = mysqlreader("SELECT * FROM categorias;")
            While dr.Read()
                Dim text = dr(0) & "-" & dr(1)
                ComboBox1.Items.Add(text)
                ComboBox2.Items.Add(text)
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

        id = ComboBox2.Text

        If id <> "" Then

            Try
                id = id.Substring(0, 2)
                Dim myChar1 As Char
                myChar1 = id(1)

                If myChar1 = "-" Then
                    id = id.Substring(0, 1)
                End If


                nombre = TextBox1Cat.Text
                Dim t = ComboBox1.Text

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

                    mysql("UPDATE categorias SET nombre='" & nombre & "', padre='" & padre & "' WHERE id='" & id & "';")
                    MessageBox.Show("Categoria actualizada correctamente!")
                    conn.Close()
                    
                    limpiar()

                Else
                    MessageBox.Show("Debe introducir un nombre para la categoría.")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            

        Else
            MessageBox.Show("Seleccione categoría")
        End If




    End Sub

    Private Sub BtnBuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarP.Click

        id = ComboBox2.Text

        If id Is "" Then
            MessageBox.Show("Seleccione una categoría.")
        Else
            Try

                id = id.Substring(0, 2)
                Dim myChar1 As Char
                myChar1 = id(1)

                If myChar1 = "-" Then
                    id = id.Substring(0, 1)
                End If

                TextBox1Cat.Enabled = True
                ComboBox2.Enabled = False
                ComboBox1.Enabled = True

                Dim superior As Integer
                Dim idcat As Integer
                conn.Open()
                dr = mysqlreader("SELECT * FROM categorias where id='" & id & "';")
                While dr.Read()
                    idcat = CInt(dr(0))
                    TextBox1Cat.Text = dr(1)
                    superior = CInt(dr(2))
                End While
                conn.Close()

                BotonReg.Enabled = True
                Button1.Enabled = True
                BtnBuscarP.Enabled = False

                For i = 0 To ComboBox1.Items.Count - 1
                    Dim t = ComboBox1.Items.Item(i)

                    ' MessageBox.Show("texto combo -> " & t)

                    t = t.Substring(0, 2)
                    Dim myChar As Char
                    myChar = t(1)

                    If myChar = "-" Then
                        t = t.Substring(0, 1)
                    End If

                    padre = CInt(t)

                    If padre = superior Then
                        ComboBox1.SelectedIndex = i
                    End If

                    If padre = idcat Then
                        ComboBox1.Items.RemoveAt(i)
                    End If

                Next
                

            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub limpiar()
        Try 
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox1.Items.Add("0-Ninguna")
            leerCategorias()
            ComboBox2.Text = ""
            ComboBox2.Enabled = True
            ComboBox1.SelectedIndex = 0
            ComboBox1.Enabled = False
            TextBox1Cat.Enabled = False
            TextBox1Cat.Text = ""
            id = ""
            nombre = ""
            padre = 0
            BotonReg.Enabled = False
            Button1.Enabled = False
            BtnBuscarP.Enabled = True
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar()
    End Sub
End Class