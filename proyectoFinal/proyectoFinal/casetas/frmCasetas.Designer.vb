<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCasetas
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "Valentina Tironi", "12348875", "Activada"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2", "Anthony Marcelli", "46744218", "Desactivada"}, -1)
        Me.lvwCasetas = New System.Windows.Forms.ListView()
        Me.columnId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnRasperry = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvwCasetas
        '
        Me.lvwCasetas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnId, Me.columnCliente, Me.columnRasperry, Me.columnEstado})
        Me.lvwCasetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCasetas.FullRowSelect = True
        Me.lvwCasetas.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lvwCasetas.Location = New System.Drawing.Point(12, 85)
        Me.lvwCasetas.Name = "lvwCasetas"
        Me.lvwCasetas.Size = New System.Drawing.Size(743, 199)
        Me.lvwCasetas.TabIndex = 9
        Me.lvwCasetas.UseCompatibleStateImageBehavior = False
        Me.lvwCasetas.View = System.Windows.Forms.View.Details
        '
        'columnId
        '
        Me.columnId.Text = "ID"
        Me.columnId.Width = 39
        '
        'columnCliente
        '
        Me.columnCliente.Text = "Cliente"
        Me.columnCliente.Width = 511
        '
        'columnRasperry
        '
        Me.columnRasperry.Text = "Raspberry"
        Me.columnRasperry.Width = 89
        '
        'columnEstado
        '
        Me.columnEstado.Text = "Estado"
        Me.columnEstado.Width = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Casetas asociadas a clientes"
        '
        'frmCasetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(770, 304)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwCasetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCasetas"
        Me.Text = "Casetas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwCasetas As ListView
    Friend WithEvents columnId As ColumnHeader
    Friend WithEvents columnCliente As ColumnHeader
    Friend WithEvents columnRasperry As ColumnHeader
    Friend WithEvents columnEstado As ColumnHeader
    Friend WithEvents Label3 As Label
End Class
