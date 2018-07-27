<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "Valentina Tironi", "valentina.tironi@anima.edu.uy", "valentinatironi", "52404551"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2", "Yonatan Morgades", "yonatan.morgades@anima.edu.uy", "yonatanmorgades", "12345678"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"3", "Elián Pintos", "elian.pintos@anima.edu.uy", "elianpintos", "7894561"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"4", "Anthony Marcelli", "anthony.marcelli@anima.edu.uy", "anthonymarcelli", "79846531"}, -1)
        Me.lvwEmpleados = New System.Windows.Forms.ListView()
        Me.columnId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombreCompleto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombreUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnCedula = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvwEmpleados
        '
        Me.lvwEmpleados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnId, Me.columnNombreCompleto, Me.columnEmail, Me.columnNombreUsuario, Me.ColumnCedula})
        Me.lvwEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwEmpleados.FullRowSelect = True
        Me.lvwEmpleados.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.lvwEmpleados.Location = New System.Drawing.Point(12, 84)
        Me.lvwEmpleados.Name = "lvwEmpleados"
        Me.lvwEmpleados.Size = New System.Drawing.Size(747, 199)
        Me.lvwEmpleados.TabIndex = 10
        Me.lvwEmpleados.UseCompatibleStateImageBehavior = False
        Me.lvwEmpleados.View = System.Windows.Forms.View.Details
        '
        'columnId
        '
        Me.columnId.Text = "ID"
        Me.columnId.Width = 39
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Todos los Clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(771, 313)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.Tag = ""
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwEmpleados As ListView
    Friend WithEvents columnId As ColumnHeader
    Friend WithEvents columnNombreCompleto As ColumnHeader
    Friend WithEvents columnEmail As ColumnHeader
    Friend WithEvents columnNombreUsuario As ColumnHeader
    Friend WithEvents ColumnCedula As ColumnHeader
    Friend WithEvents Label3 As Label
End Class
