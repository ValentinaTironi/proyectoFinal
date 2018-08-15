<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarCliente))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbxServicio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuentaBancaria = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(407, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 32)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Caseta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "asociada*"
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(679, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(47, 41)
        Me.btnGuardar.TabIndex = 76
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(13, 11)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(47, 41)
        Me.btnAtras.TabIndex = 75
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Caseta 1", "Caseta 2", "Caseta 3"})
        Me.ComboBox1.Location = New System.Drawing.Point(495, 239)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 74
        '
        'cbxServicio
        '
        Me.cbxServicio.FormattingEnabled = True
        Me.cbxServicio.Items.AddRange(New Object() {"Número 1", "Número 2", "Número 3"})
        Me.cbxServicio.Location = New System.Drawing.Point(495, 177)
        Me.cbxServicio.Name = "cbxServicio"
        Me.cbxServicio.Size = New System.Drawing.Size(104, 21)
        Me.cbxServicio.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Editar cliente"
        '
        'txtCuentaBancaria
        '
        Me.txtCuentaBancaria.Location = New System.Drawing.Point(499, 117)
        Me.txtCuentaBancaria.Name = "txtCuentaBancaria"
        Me.txtCuentaBancaria.Size = New System.Drawing.Size(100, 20)
        Me.txtCuentaBancaria.TabIndex = 66
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(237, 170)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreUsuario.TabIndex = 67
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(237, 117)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 65
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(499, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 128)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Nombre*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Número de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cuenta bancaria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(407, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 144)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Apellido*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cédula*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio * " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Asociado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(237, 70)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 63
        '
        'frmEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(736, 395)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cbxServicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCuentaBancaria)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditarCliente"
        Me.Text = "frmEditarCliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cbxServicio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCuentaBancaria As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
End Class
