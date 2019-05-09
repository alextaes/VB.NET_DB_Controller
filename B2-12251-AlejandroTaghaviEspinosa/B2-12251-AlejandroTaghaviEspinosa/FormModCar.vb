Imports MySql.Data.MySqlClient


Public Class FormModCar

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim nombre As String
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


    Private Sub BotonVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonVol.Click
        Me.Dispose()
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
            MessageBox.Show("Error al cargar caracteristicas. Imposible conectar a la base de datos. Compruebe la conexión.")
        End Try
        
    End Sub


    Private Sub BtnBuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarP.Click
        id = ComboBox1.Text

        If id Is "" Then
            MessageBox.Show("Seleccione la caracteristica que desea modificar.")
        Else
            Try
                id = id.Substring(0, 2)
                Dim myChar1 As Char
                myChar1 = id(1)

                If myChar1 = "-" Then
                    id = id.Substring(0, 1)
                End If

                TextBox2.Enabled = True
                ComboBox1.Enabled = False

                conn.Open()
                dr = mysqlreader("SELECT * FROM caracteristicas where id='" & id & "';")
                While dr.Read()
                    TextBox2.Text = dr(1)
                End While
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Button1.Enabled = True
            BotonReg.Enabled = True
            BtnBuscarP.Enabled = False

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        nombre = ""
        id = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Enabled = True
        TextBox2.Enabled = False
        ComboBox1.Items.Clear()
        leerCaracteristicas()
        Button1.Enabled = False
        BotonReg.Enabled = False
        BtnBuscarP.Enabled = True
    End Sub

    Private Sub BotonReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonReg.Click

        nombre = TextBox2.Text

        If id <> "" Then
            If nombre <> "" Then

                conn.Open()

                mysql("UPDATE caracteristicas SET nombre='" & nombre & "' WHERE id='" & id & "';")
                MessageBox.Show("Caracteristica actualizada correctamente!")

                conn.Close()
                limpiar()
            Else
                MessageBox.Show("Introduzca un nombre válido")
            End If
        Else
            MessageBox.Show("Seleccione la caracteristica que desea modificar.")
        End If

        

    End Sub

    Private Sub FormModCar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
End Class