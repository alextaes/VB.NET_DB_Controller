<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModCar))
        Me.ModCar = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarP = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonVol = New System.Windows.Forms.Button()
        Me.BotonReg = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ModCar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModCar
        '
        Me.ModCar.Controls.Add(Me.ComboBox1)
        Me.ModCar.Controls.Add(Me.BtnBuscarP)
        Me.ModCar.Controls.Add(Me.Button1)
        Me.ModCar.Controls.Add(Me.BotonVol)
        Me.ModCar.Controls.Add(Me.BotonReg)
        Me.ModCar.Controls.Add(Me.TextBox2)
        Me.ModCar.Controls.Add(Me.Label33)
        Me.ModCar.Controls.Add(Me.Label34)
        Me.ModCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModCar.Location = New System.Drawing.Point(25, 24)
        Me.ModCar.Name = "ModCar"
        Me.ModCar.Size = New System.Drawing.Size(628, 279)
        Me.ModCar.TabIndex = 18
        Me.ModCar.TabStop = False
        Me.ModCar.Text = "Modificar Caracteristica"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(191, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 26)
        Me.ComboBox1.TabIndex = 1
        '
        'BtnBuscarP
        '
        Me.BtnBuscarP.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnBuscarP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBuscarP.Location = New System.Drawing.Point(406, 63)
        Me.BtnBuscarP.Name = "BtnBuscarP"
        Me.BtnBuscarP.Size = New System.Drawing.Size(75, 35)
        Me.BtnBuscarP.TabIndex = 2
        Me.BtnBuscarP.Text = "Buscar"
        Me.BtnBuscarP.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(487, 63)
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
        Me.BotonVol.Location = New System.Drawing.Point(357, 204)
        Me.BotonVol.Name = "BotonVol"
        Me.BotonVol.Size = New System.Drawing.Size(159, 33)
        Me.BotonVol.TabIndex = 6
        Me.BotonVol.Text = "Cancelar"
        Me.BotonVol.UseVisualStyleBackColor = False
        '
        'BotonReg
        '
        Me.BotonReg.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BotonReg.Enabled = False
        Me.BotonReg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonReg.Location = New System.Drawing.Point(125, 204)
        Me.BotonReg.Name = "BotonReg"
        Me.BotonReg.Size = New System.Drawing.Size(159, 33)
        Me.BotonReg.TabIndex = 5
        Me.BotonReg.Text = "Guardar"
        Me.BotonReg.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(191, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(371, 24)
        Me.TextBox2.TabIndex = 4
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(36, 130)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(78, 18)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Nombre:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(36, 70)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(135, 18)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Característica:"
        '
        'FormModCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 329)
        Me.Controls.Add(Me.ModCar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(694, 368)
        Me.MinimumSize = New System.Drawing.Size(694, 368)
        Me.Name = "FormModCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "12251 - DM2E"
        Me.ModCar.ResumeLayout(False)
        Me.ModCar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ModCar As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents BotonReg As System.Windows.Forms.Button
    Friend WithEvents BotonVol As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarP As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
