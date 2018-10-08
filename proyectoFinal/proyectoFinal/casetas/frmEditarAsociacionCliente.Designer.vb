<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarAsociacionCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarAsociacionCliente))
        Me.lblid_cliente = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxCasetas = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblid_perro = New System.Windows.Forms.Label()
        Me.lblcaseta_vieja = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblid_cliente.Location = New System.Drawing.Point(262, 27)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(15, 16)
        Me.lblid_cliente.TabIndex = 87
        Me.lblid_cliente.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(63, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 18)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Nueva caseta para el cliente #"
        '
        'cbxCasetas
        '
        Me.cbxCasetas.FormattingEnabled = True
        Me.cbxCasetas.Location = New System.Drawing.Point(78, 67)
        Me.cbxCasetas.Name = "cbxCasetas"
        Me.cbxCasetas.Size = New System.Drawing.Size(186, 21)
        Me.cbxCasetas.TabIndex = 88
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(332, 7)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(47, 41)
        Me.btnGuardar.TabIndex = 89
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblid_perro
        '
        Me.lblid_perro.AutoSize = True
        Me.lblid_perro.Location = New System.Drawing.Point(12, 130)
        Me.lblid_perro.Name = "lblid_perro"
        Me.lblid_perro.Size = New System.Drawing.Size(0, 13)
        Me.lblid_perro.TabIndex = 90
        '
        'lblcaseta_vieja
        '
        Me.lblcaseta_vieja.AutoSize = True
        Me.lblcaseta_vieja.Location = New System.Drawing.Point(115, 130)
        Me.lblcaseta_vieja.Name = "lblcaseta_vieja"
        Me.lblcaseta_vieja.Size = New System.Drawing.Size(0, 13)
        Me.lblcaseta_vieja.TabIndex = 91
        '
        'frmEditarAsociacionCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(391, 152)
        Me.Controls.Add(Me.lblcaseta_vieja)
        Me.Controls.Add(Me.lblid_perro)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cbxCasetas)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.Label9)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEditarAsociacionCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblid_cliente As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxCasetas As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblid_perro As Label
    Friend WithEvents lblcaseta_vieja As Label
End Class
