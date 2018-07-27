<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministradores
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
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "Valentina Tironi", "valentina.tironi@anima.edu.uy", "valentinatironi", "Programadora", "Si"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2", "Yonatan Morgades", "yonatan.morgades@anima.edu.uy", "yonatanmorgades", "QA", "Si"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"3", "Elián Pintos", "elian.pintos@anima.edu.uy", "elianpintos", "Diseño", "No"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"4", "Anthony Marcelli", "anthony.marcelli@anima.edu.uy", "anthonymarcelli", "Redes", "Si"}, -1)
        Me.lvwAdministradores = New System.Windows.Forms.ListView()
        Me.columnId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombreCompleto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombreUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPuesto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvwAdministradores
        '
        Me.lvwAdministradores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnId, Me.columnNombreCompleto, Me.columnEmail, Me.columnNombreUsuario, Me.ColumnPuesto})
        Me.lvwAdministradores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwAdministradores.FullRowSelect = True
        Me.lvwAdministradores.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.lvwAdministradores.Location = New System.Drawing.Point(71, 81)
        Me.lvwAdministradores.Name = "lvwAdministradores"
        Me.lvwAdministradores.Size = New System.Drawing.Size(643, 199)
        Me.lvwAdministradores.TabIndex = 10
        Me.lvwAdministradores.UseCompatibleStateImageBehavior = False
        Me.lvwAdministradores.View = System.Windows.Forms.View.Details
        '
        'columnId
        '
        Me.columnId.Text = "ID"
        Me.columnId.Width = 39
        '
        'columnNombreCompleto
        '
        Me.columnNombreCompleto.Text = "Nombre Completo"
        Me.columnNombreCompleto.Width = 144
        '
        'columnEmail
        '
        Me.columnEmail.Text = "Email"
        Me.columnEmail.Width = 205
        '
        'columnNombreUsuario
        '
        Me.columnNombreUsuario.Text = "Nombre de Usuario"
        Me.columnNombreUsuario.Width = 131
        '
        'ColumnPuesto
        '
        Me.ColumnPuesto.Text = "Puesto de trabajo"
        Me.ColumnPuesto.Width = 116
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Todos los empleados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAdministradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(768, 303)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwAdministradores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdministradores"
        Me.Text = "frmAdministradores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwAdministradores As ListView
    Friend WithEvents columnId As ColumnHeader
    Friend WithEvents columnNombreCompleto As ColumnHeader
    Friend WithEvents columnEmail As ColumnHeader
    Friend WithEvents columnNombreUsuario As ColumnHeader
    Friend WithEvents ColumnPuesto As ColumnHeader
    Friend WithEvents Label3 As Label
End Class
