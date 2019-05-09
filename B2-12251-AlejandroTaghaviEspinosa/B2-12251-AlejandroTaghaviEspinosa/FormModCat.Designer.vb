<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModCat))
        Me.AltaCat = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBuscarP = New System.Windows.Forms.Button()
        Me.IdMod = New System.Windows.Forms.Label()
        Me.BotonVol = New System.Windows.Forms.Button()
        Me.BotonReg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1Cat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AltaCat.SuspendLayout()
        Me.SuspendLayout()
        '
        'AltaCat
        '
        Me.AltaCat.Controls.Add(Me.ComboBox2)
        Me.AltaCat.Controls.Add(Me.Button1)
        Me.AltaCat.Controls.Add(Me.BtnBuscarP)
        Me.AltaCat.Controls.Add(Me.IdMod)
        Me.AltaCat.Controls.Add(Me.BotonVol)
        Me.AltaCat.Controls.Add(Me.BotonReg)
        Me.AltaCat.Controls.Add(Me.Label1)
        Me.AltaCat.Controls.Add(Me.ComboBox1)
        Me.AltaCat.Controls.Add(Me.TextBox1Cat)
        Me.AltaCat.Controls.Add(Me.Label3)
        Me.AltaCat.Controls.Add(Me.Label4)
        Me.AltaCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaCat.Location = New System.Drawing.Point(30, 31)
        Me.AltaCat.Name = "AltaCat"
        Me.AltaCat.Size = New System.Drawing.Size(584, 343)
        Me.AltaCat.TabIndex = 6
        Me.AltaCat.TabStop = False
        Me.AltaCat.Text = "Modificar Categoria"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(204, 78)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(152, 26)
        Me.ComboBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(443, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnBuscarP
        '
        Me.BtnBuscarP.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnBuscarP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBuscarP.Location = New System.Drawing.Point(362, 74)
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
        Me.IdMod.Location = New System.Drawing.Point(66, 81)
        Me.IdMod.Name = "IdMod"
        Me.IdMod.Size = New System.Drawing.Size(100, 18)
        Me.IdMod.TabIndex = 13
        Me.IdMod.Text = "Categoria:"
        '
        'BotonVol
        '
        Me.BotonVol.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BotonVol.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BotonVol.Location = New System.Drawing.Point(323, 261)
        Me.BotonVol.Name = "BotonVol"
        Me.BotonVol.Size = New System.Drawing.Size(159, 33)
        Me.BotonVol.TabIndex = 7
        Me.BotonVol.Text = "Cancelar"
        Me.BotonVol.UseVisualStyleBackColor = False
        '
        'BotonReg
        '
        Me.BotonReg.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BotonReg.Enabled = False
        Me.BotonReg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonReg.Location = New System.Drawing.Point(117, 261)
        Me.BotonReg.Name = "BotonReg"
        Me.BotonReg.Size = New System.Drawing.Size(159, 33)
        Me.BotonReg.TabIndex = 6
        Me.BotonReg.Text = "Guardar"
        Me.BotonReg.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "superior:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(204, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(314, 26)
        Me.ComboBox1.TabIndex = 5
        '
        'TextBox1Cat
        '
        Me.TextBox1Cat.Enabled = False
        Me.TextBox1Cat.Location = New System.Drawing.Point(204, 131)
        Me.TextBox1Cat.Name = "TextBox1Cat"
        Me.TextBox1Cat.Size = New System.Drawing.Size(314, 24)
        Me.TextBox1Cat.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre:"
        '
        'FormModCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 402)
        Me.Controls.Add(Me.AltaCat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(663, 441)
        Me.MinimumSize = New System.Drawing.Size(663, 441)
        Me.Name = "FormModCat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "12251 - DM2E"
        Me.AltaCat.ResumeLayout(False)
        Me.AltaCat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AltaCat As System.Windows.Forms.GroupBox
    Friend WithEvents BotonVol As System.Windows.Forms.Button
    Friend WithEvents BotonReg As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1Cat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IdMod As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarP As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
