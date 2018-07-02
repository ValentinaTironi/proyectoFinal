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
        Me.btnMiCuenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemDashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaspberrypiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuUsuario
        '
        Me.mnuUsuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemUsuario, Me.mnuItemDashboard, Me.EmpleadosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.RaspberrypiToolStripMenuItem, Me.HistorialToolStripMenuItem})
        Me.mnuUsuario.Location = New System.Drawing.Point(0, 0)
        Me.mnuUsuario.Name = "mnuUsuario"
        Me.mnuUsuario.Size = New System.Drawing.Size(763, 24)
        Me.mnuUsuario.TabIndex = 2
        Me.mnuUsuario.Text = "MenuStrip1"
        '
        'mnuItemUsuario
        '
        Me.mnuItemUsuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMiCuenta, Me.CerrarSesiónToolStripMenuItem})
        Me.mnuItemUsuario.Name = "mnuItemUsuario"
        Me.mnuItemUsuario.Size = New System.Drawing.Size(59, 20)
        Me.mnuItemUsuario.Text = "&Usuario"
        '
        'btnMiCuenta
        '
        Me.btnMiCuenta.Name = "btnMiCuenta"
        Me.btnMiCuenta.Size = New System.Drawing.Size(143, 22)
        Me.btnMiCuenta.Text = "Mi cuenta"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'mnuItemDashboard
        '
        Me.mnuItemDashboard.Name = "mnuItemDashboard"
        Me.mnuItemDashboard.Size = New System.Drawing.Size(76, 20)
        Me.mnuItemDashboard.Text = "Dashboard"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministradoresToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AdministradoresToolStripMenuItem
        '
        Me.AdministradoresToolStripMenuItem.Name = "AdministradoresToolStripMenuItem"
        Me.AdministradoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdministradoresToolStripMenuItem.Text = "Administradores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem1, Me.EquiposToolStripMenuItem1, Me.ClientesToolStripMenuItem1, Me.PorUsuariosToolStripMenuItem})
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'EquiposToolStripMenuItem1
        '
        Me.EquiposToolStripMenuItem1.Name = "EquiposToolStripMenuItem1"
        Me.EquiposToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EquiposToolStripMenuItem1.Text = "Equipos"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'PorUsuariosToolStripMenuItem
        '
        Me.PorUsuariosToolStripMenuItem.Name = "PorUsuariosToolStripMenuItem"
        Me.PorUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PorUsuariosToolStripMenuItem.Text = "Por Usuarios"
        '
        'RaspberrypiToolStripMenuItem
        '
        Me.RaspberrypiToolStripMenuItem.Name = "RaspberrypiToolStripMenuItem"
        Me.RaspberrypiToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.RaspberrypiToolStripMenuItem.Text = "Raspberry-pi's"
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
        Me.Name = "frmPrincipal"
        Me.Text = "Clifford"
        Me.mnuUsuario.ResumeLayout(False)
        Me.mnuUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuUsuario As MenuStrip
    Friend WithEvents mnuItemUsuario As ToolStripMenuItem
    Friend WithEvents btnMiCuenta As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuItemDashboard As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PorUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaspberrypiToolStripMenuItem As ToolStripMenuItem
End Class
