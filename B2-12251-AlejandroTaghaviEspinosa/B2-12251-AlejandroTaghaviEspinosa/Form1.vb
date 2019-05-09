Imports MySql.Data.MySqlClient

Public Class Form1

    'Variables para manejar la conexión
    Dim conn = New MySqlConnection("Server='localhost';Database='12251-dm2e';Uid='dm2e';Pwd='dm2e';")
    Dim cm As New MySqlCommand
    Dim mb As New MySqlBackup(cm)

    'Procedimiento para exportar la base de datos en formato .txt
    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click

        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|sql files (*.sql)|*.sql"
        SaveFileDialog1.ShowDialog()

        Try
            Dim file As String = SaveFileDialog1.FileName
            If file <> "" Then
                cm.Connection = conn
                conn.Open()
                mb.ExportToFile(file)
                conn.Close()
                MessageBox.Show("exportado en " & file)
            Else
                MessageBox.Show("exportacion cancelada")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Procedimiento para importar la base de datos
    Private Sub ImportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()

        Try
            Dim file As String = OpenFileDialog1.FileName
            If file <> "" Then
                cm.Connection = conn
                conn.Open()
                mb.ImportFromFile(file)
                MessageBox.Show("Importado con éxito!!")
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Importación cancelada.")
        End Try
        
    End Sub
    ' Mostrar Formulario de alta de productos
    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        FormAltaProd.ShowDialog()
    End Sub
    ' Mostrar Formulario de modificación de productos
    Private Sub ModificaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificaciónToolStripMenuItem.Click
        FormModProd.ShowDialog()
    End Sub
    ' Mostrar Formulario de baja de productos
    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem.Click
        FormDelProd.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem1.Click
        FormAltaCat.ShowDialog()
    End Sub

    Private Sub ModificaciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificaciónToolStripMenuItem1.Click
        FormModCat.ShowDialog()
    End Sub

    Private Sub BajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem1.Click
        FormDelCat.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem2.Click
        FormAltaCar.ShowDialog()
    End Sub

    Private Sub ModificaciónToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificaciónToolStripMenuItem2.Click
        FormModCar.ShowDialog()
    End Sub

    Private Sub BajaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem2.Click
        FormDelCar.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem3.Click
        FormAltaTi.ShowDialog()
    End Sub

    Private Sub ModificaciónToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificaciónToolStripMenuItem3.Click
        FormModTi.ShowDialog()
    End Sub

    Private Sub BajaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem3.Click
        FormDelTi.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem1.Click
        FormFinderItem.ShowDialog()
    End Sub

    Private Sub TiendasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiendasToolStripMenuItem1.Click
        FormFinderTi.ShowDialog()
    End Sub

    Private Sub FiltroCategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltroCategoriasToolStripMenuItem.Click
        FormFiltroCat.ShowDialog()
    End Sub

    Private Sub MapaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapaToolStripMenuItem.Click
        FormMapa.ShowDialog()
    End Sub
End Class


