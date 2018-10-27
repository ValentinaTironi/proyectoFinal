<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMiCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMiCuenta))
        Me.picPerfil = New System.Windows.Forms.PictureBox()
        Me.lblrol = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblid = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblcedula = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblfecha_nacimiento = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblnombre_completo = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        CType(Me.picPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPerfil
        '
        Me.picPerfil.Image = CType(resources.GetObject("picPerfil.Image"), System.Drawing.Image)
        Me.picPerfil.Location = New System.Drawing.Point(28, 46)
        Me.picPerfil.Name = "picPerfil"
        Me.picPerfil.Size = New System.Drawing.Size(180, 204)
        Me.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPerfil.TabIndex = 0
        Me.picPerfil.TabStop = False
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(59, 262)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(0, 16)
        Me.lblrol.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre de usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(264, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Cédula"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblid)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblcedula)
        Me.Panel1.Controls.Add(Me.lbldireccion)
        Me.Panel1.Controls.Add(Me.lblfecha_nacimiento)
        Me.Panel1.Controls.Add(Me.lblemail)
        Me.Panel1.Controls.Add(Me.lblnombre_completo)
        Me.Panel1.Controls.Add(Me.lblusername)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblrol)
        Me.Panel1.Controls.Add(Me.picPerfil)
        Me.Panel1.Location = New System.Drawing.Point(12, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 331)
        Me.Panel1.TabIndex = 11
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(376, 10)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(18, 20)
        Me.lblid.TabIndex = 80
        Me.lblid.Text = "1"
        '
        'btnEditar
        '
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(675, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(47, 41)
        Me.btnEditar.TabIndex = 78
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(289, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Mi cuenta #"
        '
        'lblcedula
        '
        Me.lblcedula.AutoSize = True
        Me.lblcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedula.Location = New System.Drawing.Point(469, 217)
        Me.lblcedula.Name = "lblcedula"
        Me.lblcedula.Size = New System.Drawing.Size(0, 16)
        Me.lblcedula.TabIndex = 20
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.Location = New System.Drawing.Point(469, 189)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(0, 16)
        Me.lbldireccion.TabIndex = 18
        '
        'lblfecha_nacimiento
        '
        Me.lblfecha_nacimiento.AutoSize = True
        Me.lblfecha_nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha_nacimiento.Location = New System.Drawing.Point(469, 159)
        Me.lblfecha_nacimiento.Name = "lblfecha_nacimiento"
        Me.lblfecha_nacimiento.Size = New System.Drawing.Size(0, 16)
        Me.lblfecha_nacimiento.TabIndex = 17
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(469, 130)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(0, 16)
        Me.lblemail.TabIndex = 16
        '
        'lblnombre_completo
        '
        Me.lblnombre_completo.AutoSize = True
        Me.lblnombre_completo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre_completo.Location = New System.Drawing.Point(469, 102)
        Me.lblnombre_completo.Name = "lblnombre_completo"
        Me.lblnombre_completo.Size = New System.Drawing.Size(0, 16)
        Me.lblnombre_completo.TabIndex = 15
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(469, 74)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(0, 16)
        Me.lblusername.TabIndex = 14
        '
        'frmMiCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(758, 359)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMiCuenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Mi Cuenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPerfil As PictureBox
    Friend WithEvents lblrol As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblcedula As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblfecha_nacimiento As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblnombre_completo As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblid As Label
End Class
