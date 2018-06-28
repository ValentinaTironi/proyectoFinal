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
        Me.mnuItemDashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMiCuenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtraOpciónDelMenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.mnuUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuUsuario
        '
        Me.mnuUsuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemDashboard, Me.mnuItemUsuario, Me.OtraOpciónDelMenúToolStripMenuItem})
        Me.mnuUsuario.Location = New System.Drawing.Point(0, 0)
        Me.mnuUsuario.Name = "mnuUsuario"
        Me.mnuUsuario.Size = New System.Drawing.Size(763, 24)
        Me.mnuUsuario.TabIndex = 2
        Me.mnuUsuario.Text = "MenuStrip1"
        '
        'mnuItemDashboard
        '
        Me.mnuItemDashboard.Name = "mnuItemDashboard"
        Me.mnuItemDashboard.Size = New System.Drawing.Size(76, 20)
        Me.mnuItemDashboard.Text = "Dashboard"
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
        Me.btnMiCuenta.Size = New System.Drawing.Size(180, 22)
        Me.btnMiCuenta.Text = "Mi cuenta"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'OtraOpciónDelMenúToolStripMenuItem
        '
        Me.OtraOpciónDelMenúToolStripMenuItem.Name = "OtraOpciónDelMenúToolStripMenuItem"
        Me.OtraOpciónDelMenúToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.OtraOpciónDelMenúToolStripMenuItem.Text = "Otra opción del menú"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(763, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 365)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.mnuUsuario)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuUsuario
        Me.Name = "frmPrincipal"
        Me.Text = "Clifford"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuUsuario.ResumeLayout(False)
        Me.mnuUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuUsuario As MenuStrip
    Friend WithEvents mnuItemUsuario As ToolStripMenuItem
    Friend WithEvents btnMiCuenta As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtraOpciónDelMenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents mnuItemDashboard As ToolStripMenuItem
End Class
