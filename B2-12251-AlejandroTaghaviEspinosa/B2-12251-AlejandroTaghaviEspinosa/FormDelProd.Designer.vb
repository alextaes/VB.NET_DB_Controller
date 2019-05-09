<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDelProd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDelProd))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox10P = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pprecio = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonVol = New System.Windows.Forms.Button()
        Me.BotonDel = New System.Windows.Forms.Button()
        Me.TextBox9P = New System.Windows.Forms.TextBox()
        Me.TextBox7P = New System.Windows.Forms.TextBox()
        Me.TextBox6P = New System.Windows.Forms.TextBox()
        Me.MPImagen = New System.Windows.Forms.Label()
        Me.MPCategoria = New System.Windows.Forms.Label()
        Me.MPMarca = New System.Windows.Forms.Label()
        Me.MPNombre = New System.Windows.Forms.Label()
        Me.BtnBuscarP = New System.Windows.Forms.Button()
        Me.IdMod = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox10P)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Pprecio)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BotonVol)
        Me.GroupBox2.Controls.Add(Me.BotonDel)
        Me.GroupBox2.Controls.Add(Me.TextBox9P)
        Me.GroupBox2.Controls.Add(Me.TextBox7P)
        Me.GroupBox2.Controls.Add(Me.TextBox6P)
        Me.GroupBox2.Controls.Add(Me.MPImagen)
        Me.GroupBox2.Controls.Add(Me.MPCategoria)
        Me.GroupBox2.Controls.Add(Me.MPMarca)
        Me.GroupBox2.Controls.Add(Me.MPNombre)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarP)
        Me.GroupBox2.Controls.Add(Me.IdMod)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 552)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eliminar Producto"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 396)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(344, 26)
        Me.ComboBox1.TabIndex = 9
        '
        'TextBox10P
        '
        Me.TextBox10P.Enabled = False
        Me.TextBox10P.Location = New System.Drawing.Point(147, 351)
        Me.TextBox10P.Name = "TextBox10P"
        Me.TextBox10P.Size = New System.Drawing.Size(344, 24)
        Me.TextBox10P.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 399)
        Me.Label1.MaximumSize = New System.Drawing.Size(77, 18)
        Me.Label1.MinimumSize = New System.Drawing.Size(77, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tienda:"
        '
        'Pprecio
        '
        Me.Pprecio.AutoSize = True
        Me.Pprecio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pprecio.Location = New System.Drawing.Point(30, 354)
        Me.Pprecio.MaximumSize = New System.Drawing.Size(77, 18)
        Me.Pprecio.MinimumSize = New System.Drawing.Size(77, 18)
        Me.Pprecio.Name = "Pprecio"
        Me.Pprecio.Size = New System.Drawing.Size(77, 18)
        Me.Pprecio.TabIndex = 21
        Me.Pprecio.Text = "Precio:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(147, 63)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(172, 26)
        Me.ComboBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(147, 194)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(344, 94)
        Me.ListBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(416, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BotonVol
        '
        Me.BotonVol.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BotonVol.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BotonVol.Location = New System.Drawing.Point(273, 465)
        Me.BotonVol.Name = "BotonVol"
        Me.BotonVol.Size = New System.Drawing.Size(159, 33)
        Me.BotonVol.TabIndex = 11
        Me.BotonVol.Text = "Cancelar"
        Me.BotonVol.UseVisualStyleBackColor = False
        '
        'BotonDel
        '
        Me.BotonDel.BackColor = System.Drawing.Color.Red
        Me.BotonDel.Enabled = False
        Me.BotonDel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonDel.Location = New System.Drawing.Point(78, 465)
        Me.BotonDel.Name = "BotonDel"
        Me.BotonDel.Size = New System.Drawing.Size(159, 33)
        Me.BotonDel.TabIndex = 10
        Me.BotonDel.Text = "Eliminar"
        Me.BotonDel.UseVisualStyleBackColor = False
        '
        'TextBox9P
        '
        Me.TextBox9P.Enabled = False
        Me.TextBox9P.Location = New System.Drawing.Point(147, 308)
        Me.TextBox9P.Name = "TextBox9P"
        Me.TextBox9P.Size = New System.Drawing.Size(344, 24)
        Me.TextBox9P.TabIndex = 7
        '
        'TextBox7P
        '
        Me.TextBox7P.Enabled = False
        Me.TextBox7P.Location = New System.Drawing.Point(147, 152)
        Me.TextBox7P.Name = "TextBox7P"
        Me.TextBox7P.Size = New System.Drawing.Size(344, 24)
        Me.TextBox7P.TabIndex = 5
        '
        'TextBox6P
        '
        Me.TextBox6P.Enabled = False
        Me.TextBox6P.Location = New System.Drawing.Point(147, 108)
        Me.TextBox6P.Name = "TextBox6P"
        Me.TextBox6P.Size = New System.Drawing.Size(344, 24)
        Me.TextBox6P.TabIndex = 4
        '
        'MPImagen
        '
        Me.MPImagen.AutoSize = True
        Me.MPImagen.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPImagen.Location = New System.Drawing.Point(30, 311)
        Me.MPImagen.Name = "MPImagen"
        Me.MPImagen.Size = New System.Drawing.Size(77, 18)
        Me.MPImagen.TabIndex = 11
        Me.MPImagen.Text = "Imagen:"
        '
        'MPCategoria
        '
        Me.MPCategoria.AutoSize = True
        Me.MPCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPCategoria.Location = New System.Drawing.Point(30, 194)
        Me.MPCategoria.Name = "MPCategoria"
        Me.MPCategoria.Size = New System.Drawing.Size(94, 18)
        Me.MPCategoria.TabIndex = 10
        Me.MPCategoria.Text = "Categoría:"
        '
        'MPMarca
        '
        Me.MPMarca.AutoSize = True
        Me.MPMarca.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPMarca.Location = New System.Drawing.Point(30, 155)
        Me.MPMarca.Name = "MPMarca"
        Me.MPMarca.Size = New System.Drawing.Size(62, 18)
        Me.MPMarca.TabIndex = 9
        Me.MPMarca.Text = "Marca:"
        '
        'MPNombre
        '
        Me.MPNombre.AutoSize = True
        Me.MPNombre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPNombre.Location = New System.Drawing.Point(29, 111)
        Me.MPNombre.Name = "MPNombre"
        Me.MPNombre.Size = New System.Drawing.Size(78, 18)
        Me.MPNombre.TabIndex = 3
        Me.MPNombre.Text = "Nombre:"
        '
        'BtnBuscarP
        '
        Me.BtnBuscarP.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnBuscarP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBuscarP.Location = New System.Drawing.Point(335, 59)
        Me.BtnBuscarP.Name = "BtnBuscarP"
        Me.BtnBuscarP.Size = New System.Drawing.Size(75, 35)
        Me.BtnBuscarP.TabIndex = 2
        Me.BtnBuscarP.Text = "Buscar"
        Me.BtnBuscarP.UseVisualStyleBackColor = False
        '
        'IdMod
        '
        Me.IdMod.AutoSize = True
        Me.IdMod.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdMod.Location = New System.Drawing.Point(30, 66)
        Me.IdMod.Name = "IdMod"
        Me.IdMod.Size = New System.Drawing.Size(94, 18)
        Me.IdMod.TabIndex = 0
        Me.IdMod.Text = "Producto:"
        '
        'FormDelProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 603)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(604, 642)
        Me.MinimumSize = New System.Drawing.Size(604, 642)
        Me.Name = "FormDelProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "12251 - DM2E"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BotonVol As System.Windows.Forms.Button
    Friend WithEvents BotonDel As System.Windows.Forms.Button
    Friend WithEvents TextBox9P As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7P As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6P As System.Windows.Forms.TextBox
    Friend WithEvents MPImagen As System.Windows.Forms.Label
    Friend WithEvents MPCategoria As System.Windows.Forms.Label
    Friend WithEvents MPMarca As System.Windows.Forms.Label
    Friend WithEvents MPNombre As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarP As System.Windows.Forms.Button
    Friend WithEvents IdMod As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Pprecio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox10P As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
