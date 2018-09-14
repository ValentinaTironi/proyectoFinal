<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHistorialCasetas
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
        Me.lvwHistorialCasetas = New System.Windows.Forms.ListView()
        Me.ColumnCaseta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Historial en relación a casetas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lvwHistorialCasetas
        '
        Me.lvwHistorialCasetas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnCaseta, Me.columnDescripcion, Me.columnUsuario, Me.columnFecha})
        Me.lvwHistorialCasetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHistorialCasetas.FullRowSelect = True
        Me.lvwHistorialCasetas.Location = New System.Drawing.Point(12, 98)
        Me.lvwHistorialCasetas.Name = "lvwHistorialCasetas"
        Me.lvwHistorialCasetas.Size = New System.Drawing.Size(744, 199)
        Me.lvwHistorialCasetas.TabIndex = 13
        Me.lvwHistorialCasetas.UseCompatibleStateImageBehavior = False
        Me.lvwHistorialCasetas.View = System.Windows.Forms.View.Details
        '
        'ColumnCaseta
        '
        Me.ColumnCaseta.Text = "Caseta"
        Me.ColumnCaseta.Width = 97
        '
        'columnDescripcion
        '
        Me.columnDescripcion.Text = "Descripción"
        Me.columnDescripcion.Width = 363
        '
        'columnUsuario
        '
        Me.columnUsuario.Text = "Usuario"
        Me.columnUsuario.Width = 156
        '
        'columnFecha
        '
        Me.columnFecha.Text = "Fecha"
        Me.columnFecha.Width = 121
        '
        'frmHistorialCasetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(777, 321)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwHistorialCasetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistorialCasetas"
        Me.Text = "frmHistorialCasetas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents lvwHistorialCasetas As ListView
    Friend WithEvents ColumnCaseta As ColumnHeader
    Friend WithEvents columnDescripcion As ColumnHeader
    Friend WithEvents columnUsuario As ColumnHeader
    Friend WithEvents columnFecha As ColumnHeader
End Class
