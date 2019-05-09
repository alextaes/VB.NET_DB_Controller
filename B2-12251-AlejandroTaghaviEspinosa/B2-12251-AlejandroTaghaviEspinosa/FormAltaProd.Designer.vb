<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAltaProd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5P = New System.Windows.Forms.TextBox()
        Me.Pprecio = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BotonVol = New System.Windows.Forms.Button()
        Me.BotonReg = New System.Windows.Forms.Button()
        Me.TextBox4P = New System.Windows.Forms.TextBox()
        Me.TextBox2P = New System.Windows.Forms.TextBox()
        Me.TextBox1P = New System.Windows.Forms.TextBox()
        Me.PFoto = New System.Windows.Forms.Label()
        Me.PCategoria = New System.Windows.Forms.Label()
        Me.PMarca = New System.Windows.Forms.Label()
        Me.PNombre = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox5P)
        Me.GroupBox1.Controls.Add(Me.Pprecio)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.BotonVol)
        Me.GroupBox1.Controls.Add(Me.BotonReg)
        Me.GroupBox1.Controls.Add(Me.TextBox4P)
        Me.GroupBox1.Controls.Add(Me.TextBox2P)
        Me.GroupBox1.Controls.Add(Me.TextBox1P)
        Me.GroupBox1.Controls.Add(Me.PFoto)
        Me.GroupBox1.Controls.Add(Me.PCategoria)
        Me.GroupBox1.Controls.Add(Me.PMarca)
        Me.GroupBox1.Controls.Add(Me.PNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 554)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta Productos"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 396)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(309, 26)
        Me.ComboBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 396)
        Me.Label1.MaximumSize = New System.Drawing.Size(77, 18)
        Me.Label1.MinimumSize = New System.Drawing.Size(77, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tienda:"
        '
        'TextBox5P
        '
        Me.TextBox5P.Location = New System.Drawing.Point(147, 346)
        Me.TextBox5P.Name = "TextBox5P"
        Me.TextBox5P.Size = New System.Drawing.Size(309, 24)
        Me.TextBox5P.TabIndex = 5
        '
        'Pprecio
        '
        Me.Pprecio.AutoSize = True
        Me.Pprecio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pprecio.Location = New System.Drawing.Point(44, 347)
        Me.Pprecio.MaximumSize = New System.Drawing.Size(77, 18)
        Me.Pprecio.MinimumSize = New System.Drawing.Size(77, 18)
        Me.Pprecio.Name = "Pprecio"
        Me.Pprecio.Size = New System.Drawing.Size(77, 18)
        Me.Pprecio.TabIndex = 11
        Me.Pprecio.Text = "Precio:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(147, 154)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(309, 112)
        Me.ListBox1.TabIndex = 3
        '
        'BotonVol
        '
        Me.BotonVol.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BotonVol.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BotonVol.Location = New System.Drawing.Point(272, 472)
        Me.BotonVol.Name = "BotonVol"
        Me.BotonVol.Size = New System.Drawing.Size(159, 33)
        Me.BotonVol.TabIndex = 8
        Me.BotonVol.Text = "Cancelar"
        Me.BotonVol.UseVisualStyleBackColor = False
        '
        'BotonReg
        '
        Me.BotonReg.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BotonReg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonReg.Location = New System.Drawing.Point(88, 472)
        Me.BotonReg.Name = "BotonReg"
        Me.BotonReg.Size = New System.Drawing.Size(159, 33)
        Me.BotonReg.TabIndex = 7
        Me.BotonReg.Text = "Guardar"
        Me.BotonReg.UseVisualStyleBackColor = False
        '
        'TextBox4P
        '
        Me.TextBox4P.Location = New System.Drawing.Point(147, 299)
        Me.TextBox4P.Name = "TextBox4P"
        Me.TextBox4P.Size = New System.Drawing.Size(309, 24)
        Me.TextBox4P.TabIndex = 4
        '
        'TextBox2P
        '
        Me.TextBox2P.Location = New System.Drawing.Point(147, 105)
        Me.TextBox2P.Name = "TextBox2P"
        Me.TextBox2P.Size = New System.Drawing.Size(309, 24)
        Me.TextBox2P.TabIndex = 2
        '
        'TextBox1P
        '
        Me.TextBox1P.Location = New System.Drawing.Point(147, 59)
        Me.TextBox1P.Name = "TextBox1P"
        Me.TextBox1P.Size = New System.Drawing.Size(309, 24)
        Me.TextBox1P.TabIndex = 1
        '
        'PFoto
        '
        Me.PFoto.AutoSize = True
        Me.PFoto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFoto.Location = New System.Drawing.Point(45, 300)
        Me.PFoto.MaximumSize = New System.Drawing.Size(77, 18)
        Me.PFoto.MinimumSize = New System.Drawing.Size(77, 18)
        Me.PFoto.Name = "PFoto"
        Me.PFoto.Size = New System.Drawing.Size(77, 18)
        Me.PFoto.TabIndex = 3
        Me.PFoto.Text = "Imagen:"
        '
        'PCategoria
        '
        Me.PCategoria.AutoSize = True
        Me.PCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCategoria.Location = New System.Drawing.Point(44, 154)
        Me.PCategoria.Name = "PCategoria"
        Me.PCategoria.Size = New System.Drawing.Size(94, 18)
        Me.PCategoria.TabIndex = 2
        Me.PCategoria.Text = "Categoria:"
        '
        'PMarca
        '
        Me.PMarca.AutoSize = True
        Me.PMarca.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PMarca.Location = New System.Drawing.Point(45, 109)
        Me.PMarca.Name = "PMarca"
        Me.PMarca.Size = New System.Drawing.Size(62, 18)
        Me.PMarca.TabIndex = 1
        Me.PMarca.Text = "Marca:"
        '
        'PNombre
        '
        Me.PNombre.AutoSize = True
        Me.PNombre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNombre.Location = New System.Drawing.Point(44, 63)
        Me.PNombre.Name = "PNombre"
        Me.PNombre.Size = New System.Drawing.Size(78, 18)
        Me.PNombre.TabIndex = 0
        Me.PNombre.Text = "Nombre:"
        '
        'FormAltaProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 606)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(609, 645)
        Me.MinimumSize = New System.Drawing.Size(609, 645)
        Me.Name = "FormAltaProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "12251 - DM2E"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BotonReg As System.Windows.Forms.Button
    Friend WithEvents TextBox4P As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2P As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1P As System.Windows.Forms.TextBox
    Friend WithEvents PFoto As System.Windows.Forms.Label
    Friend WithEvents PCategoria As System.Windows.Forms.Label
    Friend WithEvents PMarca As System.Windows.Forms.Label
    Friend WithEvents PNombre As System.Windows.Forms.Label
    Friend WithEvents BotonVol As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox5P As System.Windows.Forms.TextBox
    Friend WithEvents Pprecio As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
