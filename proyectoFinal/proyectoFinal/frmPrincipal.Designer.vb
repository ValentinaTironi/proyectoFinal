<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.mnuUsuario = New System.Windows.Forms.MenuStrip()
        Me.mnuItemUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemMiCuenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemDashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemServicios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemCasetas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemHistorial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemHistorialClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemHistorialCasetas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuUsuario
        '
        Me.mnuUsuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemUsuario, Me.mnuItemDashboard, Me.mnuItemServicios, Me.mnuItemEmpleados, Me.mnuItemClientes, Me.mnuItemCasetas, Me.mnuItemHistorial})
        Me.mnuUsuario.Location = New System.Drawing.Point(0, 0)
        Me.mnuUsuario.Name = "mnuUsuario"
        Me.mnuUsuario.Size = New System.Drawing.Size(763, 24)
        Me.mnuUsuario.TabIndex = 2
        Me.mnuUsuario.Text = "MenuStrip1"
        '
        'mnuItemUsuario
        '
        Me.mnuItemUsuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemMiCuenta, Me.mnuItemCerrarSesion})
        Me.mnuItemUsuario.Name = "mnuItemUsuario"
        Me.mnuItemUsuario.Size = New System.Drawing.Size(59, 20)
        Me.mnuItemUsuario.Text = "&Usuario"
        '
        'mnuItemMiCuenta
        '
        Me.mnuItemMiCuenta.Name = "mnuItemMiCuenta"
        Me.mnuItemMiCuenta.Size = New System.Drawing.Size(143, 22)
        Me.mnuItemMiCuenta.Text = "Mi cuenta"
        '
        'mnuItemCerrarSesion
        '
        Me.mnuItemCerrarSesion.Name = "mnuItemCerrarSesion"
        Me.mnuItemCerrarSesion.Size = New System.Drawing.Size(143, 22)
        Me.mnuItemCerrarSesion.Text = "Cerrar Sesión"
        '
        'mnuItemDashboard
        '
        Me.mnuItemDashboard.Name = "mnuItemDashboard"
        Me.mnuItemDashboard.Size = New System.Drawing.Size(76, 20)
        Me.mnuItemDashboard.Text = "Dashboard"
        '
        'mnuItemServicios
        '
        Me.mnuItemServicios.Name = "mnuItemServicios"
        Me.mnuItemServicios.Size = New System.Drawing.Size(65, 20)
        Me.mnuItemServicios.Text = "Servicios"
        '
        'mnuItemEmpleados
        '
        Me.mnuItemEmpleados.Name = "mnuItemEmpleados"
        Me.mnuItemEmpleados.Size = New System.Drawing.Size(77, 20)
        Me.mnuItemEmpleados.Text = "Empleados"
        '
        'mnuItemClientes
        '
        Me.mnuItemClientes.Name = "mnuItemClientes"
        Me.mnuItemClientes.Size = New System.Drawing.Size(61, 20)
        Me.mnuItemClientes.Text = "Clientes"
        '
        'mnuItemCasetas
        '
        Me.mnuItemCasetas.Name = "mnuItemCasetas"
        Me.mnuItemCasetas.Size = New System.Drawing.Size(59, 20)
        Me.mnuItemCasetas.Text = "Casetas"
        '
        'mnuItemHistorial
        '
        Me.mnuItemHistorial.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemHistorialClientes, Me.mnuItemHistorialCasetas})
        Me.mnuItemHistorial.Name = "mnuItemHistorial"
        Me.mnuItemHistorial.Size = New System.Drawing.Size(63, 20)
        Me.mnuItemHistorial.Text = "Historial"
        '
        'mnuItemHistorialClientes
        '
        Me.mnuItemHistorialClientes.Name = "mnuItemHistorialClientes"
        Me.mnuItemHistorialClientes.Size = New System.Drawing.Size(116, 22)
        Me.mnuItemHistorialClientes.Text = "Clientes"
        '
        'mnuItemHistorialCasetas
        '
        Me.mnuItemHistorialCasetas.Name = "mnuItemHistorialCasetas"
        Me.mnuItemHistorialCasetas.Size = New System.Drawing.Size(116, 22)
        Me.mnuItemHistorialCasetas.Text = "Casetas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(763, 365)
        Me.Controls.Add(Me.mnuUsuario)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuUsuario
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.Text = "Clifford"
        Me.mnuUsuario.ResumeLayout(False)
        Me.mnuUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuUsuario As MenuStrip
    Friend WithEvents mnuItemUsuario As ToolStripMenuItem
    Friend WithEvents mnuItemMiCuenta As ToolStripMenuItem
    Friend WithEvents mnuItemCerrarSesion As ToolStripMenuItem
    Friend WithEvents mnuItemDashboard As ToolStripMenuItem
    Friend WithEvents mnuItemEmpleados As ToolStripMenuItem
    Friend WithEvents mnuItemClientes As ToolStripMenuItem
    Friend WithEvents mnuItemHistorial As ToolStripMenuItem
    Friend WithEvents mnuItemHistorialClientes As ToolStripMenuItem
    Friend WithEvents mnuItemHistorialCasetas As ToolStripMenuItem
    Friend WithEvents mnuItemCasetas As ToolStripMenuItem
    Friend WithEvents mnuItemServicios As ToolStripMenuItem
End Class
