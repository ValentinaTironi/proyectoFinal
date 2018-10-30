<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvwUltimosClientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombreCompleto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombreUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnCedula = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(310, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Últimos cinco nuevos clientes"
        '
        'lvwUltimosClientes
        '
        Me.lvwUltimosClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.columnNombreCompleto, Me.columnEmail, Me.columnNombreUsuario, Me.ColumnCedula})
        Me.lvwUltimosClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwUltimosClientes.FullRowSelect = True
        Me.lvwUltimosClientes.Location = New System.Drawing.Point(8, 68)
        Me.lvwUltimosClientes.Name = "lvwUltimosClientes"
        Me.lvwUltimosClientes.Size = New System.Drawing.Size(747, 199)
        Me.lvwUltimosClientes.TabIndex = 11
        Me.lvwUltimosClientes.UseCompatibleStateImageBehavior = False
        Me.lvwUltimosClientes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 39
        '
        'columnNombreCompleto
        '
        Me.columnNombreCompleto.Text = "Nombre Completo"
        Me.columnNombreCompleto.Width = 231
        '
        'columnEmail
        '
        Me.columnEmail.Text = "Email"
        Me.columnEmail.Width = 205
        '
        'columnNombreUsuario
        '
        Me.columnNombreUsuario.Text = "Nombre de Usuario"
        Me.columnNombreUsuario.Width = 149
        '
        'ColumnCedula
        '
        Me.ColumnCedula.Text = "Cédula"
        Me.ColumnCedula.Width = 116
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(767, 292)
        Me.Controls.Add(Me.lvwUltimosClientes)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDashboard"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents lvwUltimosClientes As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents columnNombreCompleto As ColumnHeader
    Friend WithEvents columnEmail As ColumnHeader
    Friend WithEvents columnNombreUsuario As ColumnHeader
    Friend WithEvents ColumnCedula As ColumnHeader
End Class
