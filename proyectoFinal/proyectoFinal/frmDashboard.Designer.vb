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
        Me.columnId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.lvwUltimosClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnId, Me.columnName, Me.ColumnUsername, Me.columnFecha, Me.columnUsuario})
        Me.lvwUltimosClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwUltimosClientes.FullRowSelect = True
        Me.lvwUltimosClientes.Location = New System.Drawing.Point(12, 81)
        Me.lvwUltimosClientes.Name = "lvwUltimosClientes"
        Me.lvwUltimosClientes.Size = New System.Drawing.Size(743, 199)
        Me.lvwUltimosClientes.TabIndex = 8
        Me.lvwUltimosClientes.UseCompatibleStateImageBehavior = False
        Me.lvwUltimosClientes.View = System.Windows.Forms.View.Details
        '
        'columnId
        '
        Me.columnId.Text = "ID"
        Me.columnId.Width = 39
        '
        'columnName
        '
        Me.columnName.Text = "Nombre completo"
        Me.columnName.Width = 356
        '
        'ColumnUsername
        '
        Me.ColumnUsername.Text = "Nombre de Usuario"
        Me.ColumnUsername.Width = 131
        '
        'columnFecha
        '
        Me.columnFecha.Text = "Fecha"
        Me.columnFecha.Width = 111
        '
        'columnUsuario
        '
        Me.columnUsuario.Text = "Agregado por"
        Me.columnUsuario.Width = 145
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
    Friend WithEvents columnName As ColumnHeader
    Friend WithEvents columnFecha As ColumnHeader
    Friend WithEvents columnUsuario As ColumnHeader
    Friend WithEvents columnId As ColumnHeader
    Friend WithEvents ColumnUsername As ColumnHeader
End Class
