<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicios))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvwServicios = New System.Windows.Forms.ListView()
        Me.columnId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnCantCasetas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Todos los servicios"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lvwServicios
        '
        Me.lvwServicios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnId, Me.columnNombre, Me.columnCantCasetas, Me.columnPrecio})
        Me.lvwServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwServicios.FullRowSelect = True
        Me.lvwServicios.Location = New System.Drawing.Point(24, 82)
        Me.lvwServicios.Name = "lvwServicios"
        Me.lvwServicios.Size = New System.Drawing.Size(712, 199)
        Me.lvwServicios.TabIndex = 12
        Me.lvwServicios.UseCompatibleStateImageBehavior = False
        Me.lvwServicios.View = System.Windows.Forms.View.Details
        '
        'columnId
        '
        Me.columnId.Text = "ID"
        Me.columnId.Width = 39
        '
        'columnNombre
        '
        Me.columnNombre.Text = "Nombre"
        Me.columnNombre.Width = 366
        '
        'columnCantCasetas
        '
        Me.columnCantCasetas.Text = "Cantidad Casetas"
        Me.columnCantCasetas.Width = 205
        '
        'columnPrecio
        '
        Me.columnPrecio.Text = "Precio"
        Me.columnPrecio.Width = 96
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(686, 17)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(50, 41)
        Me.btnAgregar.TabIndex = 42
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(768, 335)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwServicios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmServicios"
        Me.Text = "frmServicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents lvwServicios As ListView
    Friend WithEvents columnId As ColumnHeader
    Friend WithEvents columnNombre As ColumnHeader
    Friend WithEvents columnCantCasetas As ColumnHeader
    Friend WithEvents columnPrecio As ColumnHeader
    Friend WithEvents btnAgregar As Button
End Class
