<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAltaCar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BotonVol = New System.Windows.Forms.Button()
        Me.BotonReg = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CCategoria = New System.Windows.Forms.Label()
        Me.CNombre = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.BotonVol)
        Me.GroupBox1.Controls.Add(Me.BotonReg)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CCategoria)
        Me.GroupBox1.Controls.Add(Me.CNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 24)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(540, 385)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(540, 385)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 385)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta Caracteristicas"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(147, 127)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(309, 130)
        Me.ListBox1.TabIndex = 2
        '
        'BotonVol
        '
        Me.BotonVol.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BotonVol.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BotonVol.Location = New System.Drawing.Point(274, 300)
        Me.BotonVol.Name = "BotonVol"
        Me.BotonVol.Size = New System.Drawing.Size(159, 33)
        Me.BotonVol.TabIndex = 4
        Me.BotonVol.Text = "Cancelar"
        Me.BotonVol.UseVisualStyleBackColor = False
        '
        'BotonReg
        '
        Me.BotonReg.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BotonReg.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonReg.Location = New System.Drawing.Point(82, 300)
        Me.BotonReg.Name = "BotonReg"
        Me.BotonReg.Size = New System.Drawing.Size(159, 33)
        Me.BotonReg.TabIndex = 3
        Me.BotonReg.Text = "Guardar"
        Me.BotonReg.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(147, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(309, 24)
        Me.TextBox1.TabIndex = 1
        '
        'CCategoria
        '
        Me.CCategoria.AutoSize = True
        Me.CCategoria.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCategoria.Location = New System.Drawing.Point(44, 127)
        Me.CCategoria.Name = "CCategoria"
        Me.CCategoria.Size = New System.Drawing.Size(94, 18)
        Me.CCategoria.TabIndex = 2
        Me.CCategoria.Text = "Categoria:"
        '
        'CNombre
        '
        Me.CNombre.AutoSize = True
        Me.CNombre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNombre.Location = New System.Drawing.Point(44, 63)
        Me.CNombre.Name = "CNombre"
        Me.CNombre.Size = New System.Drawing.Size(78, 18)
        Me.CNombre.TabIndex = 0
        Me.CNombre.Text = "Nombre:"
        '
        'FormAltaCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(615, 477)
        Me.MinimumSize = New System.Drawing.Size(615, 477)
        Me.Name = "FormAltaCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "12251 - DM2E"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BotonVol As System.Windows.Forms.Button
    Friend WithEvents BotonReg As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CCategoria As System.Windows.Forms.Label
    Friend WithEvents CNombre As System.Windows.Forms.Label
End Class
