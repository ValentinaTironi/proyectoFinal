<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaseta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaseta))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblhora_diaria = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.lblnombre_completo = New System.Windows.Forms.Label()
        Me.lblautomatico = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDesinfectar = New System.Windows.Forms.Button()
        Me.btnServirAgua = New System.Windows.Forms.Button()
        Me.btnAlimentar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSuspender = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.pnlAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(337, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Caseta #"
        '
        'btnAtras
        '
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(13, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(47, 41)
        Me.btnAtras.TabIndex = 60
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(292, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "16:00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(292, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Servir agua"
        '
        'lblhora_diaria
        '
        Me.lblhora_diaria.AutoSize = True
        Me.lblhora_diaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora_diaria.Location = New System.Drawing.Point(292, 161)
        Me.lblhora_diaria.Name = "lblhora_diaria"
        Me.lblhora_diaria.Size = New System.Drawing.Size(88, 16)
        Me.lblhora_diaria.TabIndex = 55
        Me.lblhora_diaria.Text = "No tiene hora"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.Location = New System.Drawing.Point(292, 104)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(61, 16)
        Me.lblestado.TabIndex = 54
        Me.lblestado.Text = "Activado"
        '
        'lblnombre_completo
        '
        Me.lblnombre_completo.AutoSize = True
        Me.lblnombre_completo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre_completo.Location = New System.Drawing.Point(292, 76)
        Me.lblnombre_completo.Name = "lblnombre_completo"
        Me.lblnombre_completo.Size = New System.Drawing.Size(101, 16)
        Me.lblnombre_completo.TabIndex = 53
        Me.lblnombre_completo.Text = "Valentina Tironi"
        '
        'lblautomatico
        '
        Me.lblautomatico.AutoSize = True
        Me.lblautomatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblautomatico.Location = New System.Drawing.Point(292, 134)
        Me.lblautomatico.Name = "lblautomatico"
        Me.lblautomatico.Size = New System.Drawing.Size(75, 16)
        Me.lblautomatico.TabIndex = 52
        Me.lblautomatico.Text = "Automática"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Hora de última accion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Última acción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Hora de alimentación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Estado"
        '
        'pnlAcciones
        '
        Me.pnlAcciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAcciones.Controls.Add(Me.Label10)
        Me.pnlAcciones.Controls.Add(Me.btnDesinfectar)
        Me.pnlAcciones.Controls.Add(Me.btnServirAgua)
        Me.pnlAcciones.Controls.Add(Me.btnAlimentar)
        Me.pnlAcciones.Location = New System.Drawing.Point(525, 76)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(200, 216)
        Me.pnlAcciones.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Acciones"
        '
        'btnDesinfectar
        '
        Me.btnDesinfectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesinfectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesinfectar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnDesinfectar.Location = New System.Drawing.Point(36, 157)
        Me.btnDesinfectar.Name = "btnDesinfectar"
        Me.btnDesinfectar.Size = New System.Drawing.Size(131, 32)
        Me.btnDesinfectar.TabIndex = 65
        Me.btnDesinfectar.Text = "Desinfectar caseta"
        Me.btnDesinfectar.UseVisualStyleBackColor = True
        '
        'btnServirAgua
        '
        Me.btnServirAgua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServirAgua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServirAgua.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnServirAgua.Location = New System.Drawing.Point(35, 95)
        Me.btnServirAgua.Name = "btnServirAgua"
        Me.btnServirAgua.Size = New System.Drawing.Size(131, 34)
        Me.btnServirAgua.TabIndex = 64
        Me.btnServirAgua.Text = "Servir agua"
        Me.btnServirAgua.UseVisualStyleBackColor = True
        '
        'btnAlimentar
        '
        Me.btnAlimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlimentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlimentar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAlimentar.Location = New System.Drawing.Point(34, 39)
        Me.btnAlimentar.Name = "btnAlimentar"
        Me.btnAlimentar.Size = New System.Drawing.Size(131, 34)
        Me.btnAlimentar.TabIndex = 63
        Me.btnAlimentar.Text = "Alimentar perro"
        Me.btnAlimentar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Automático"
        '
        'btnSuspender
        '
        Me.btnSuspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuspender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuspender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSuspender.Location = New System.Drawing.Point(578, 332)
        Me.btnSuspender.Name = "btnSuspender"
        Me.btnSuspender.Size = New System.Drawing.Size(147, 37)
        Me.btnSuspender.TabIndex = 66
        Me.btnSuspender.Text = "Suspender servicio"
        Me.btnSuspender.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(714, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(47, 41)
        Me.btnEliminar.TabIndex = 79
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(403, 23)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(15, 16)
        Me.lblid.TabIndex = 85
        Me.lblid.Text = "1"
        '
        'frmCaseta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(773, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSuspender)
        Me.Controls.Add(Me.pnlAcciones)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblhora_diaria)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.lblnombre_completo)
        Me.Controls.Add(Me.lblautomatico)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCaseta"
        Me.Text = "frmCaseta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlAcciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblhora_diaria As Label
    Friend WithEvents lblestado As Label
    Friend WithEvents lblnombre_completo As Label
    Friend WithEvents lblautomatico As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlAcciones As Panel
    Friend WithEvents btnDesinfectar As Button
    Friend WithEvents btnServirAgua As Button
    Friend WithEvents btnAlimentar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSuspender As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblid As Label
End Class
