<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialClientes
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Cliente uno", "Se agregó un nuevo cliente", "Valentina", "2018-07-24"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Cliente dos", "Se editó un cliente", "Yonatan", "2018-07-24"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Cliente tres", "Se agregó un nuevo cliente", "Elián", "2018-07-24"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Cliente cuatro", "Se desactivó el servicio para un cliente", "Anthony", "2018-07-24"}, -1)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvwEmpleados = New System.Windows.Forms.ListView()
        Me.columnDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(307, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Historial en relación a clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lvwEmpleados
        '
        Me.lvwEmpleados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnCliente, Me.columnDescripcion, Me.columnUsuario, Me.columnFecha})
        Me.lvwEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwEmpleados.FullRowSelect = True
        Me.lvwEmpleados.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.lvwEmpleados.Location = New System.Drawing.Point(12, 86)
        Me.lvwEmpleados.Name = "lvwEmpleados"
        Me.lvwEmpleados.Size = New System.Drawing.Size(744, 199)
        Me.lvwEmpleados.TabIndex = 11
        Me.lvwEmpleados.UseCompatibleStateImageBehavior = False
        Me.lvwEmpleados.View = System.Windows.Forms.View.Details
        '
        'columnDescripcion
        '
        Me.columnDescripcion.Text = "Descripción"
        Me.columnDescripcion.Width = 455
        '
        'columnUsuario
        '
        Me.columnUsuario.Text = "Usuario"
        Me.columnUsuario.Width = 102
        '
        'columnFecha
        '
        Me.columnFecha.Text = "Fecha"
        Me.columnFecha.Width = 86
        '
        'ColumnCliente
        '
        Me.ColumnCliente.Text = "Cliente"
        Me.ColumnCliente.Width = 97
        '
        'frmHistorialEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(781, 311)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistorialEmpleados"
        Me.Text = "frmHistorial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents lvwEmpleados As ListView
    Friend WithEvents columnDescripcion As ColumnHeader
    Friend WithEvents columnUsuario As ColumnHeader
    Friend WithEvents columnFecha As ColumnHeader
    Friend WithEvents ColumnCliente As ColumnHeader
End Class
