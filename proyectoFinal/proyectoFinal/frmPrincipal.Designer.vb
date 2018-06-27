<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.mnuUsuario = New System.Windows.Forms.MenuStrip()
        Me.mnuItemUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtraOpciónDelMenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMiCuenta = New System.Windows.Forms.ToolStripButton()
        Me.mnuUsuario.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuUsuario
        '
        Me.mnuUsuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemUsuario, Me.OtraOpciónDelMenúToolStripMenuItem})
        Me.mnuUsuario.Location = New System.Drawing.Point(0, 0)
        Me.mnuUsuario.Name = "mnuUsuario"
        Me.mnuUsuario.Size = New System.Drawing.Size(632, 24)
        Me.mnuUsuario.TabIndex = 2
        Me.mnuUsuario.Text = "MenuStrip1"
        '
        'mnuItemUsuario
        '
        Me.mnuItemUsuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiCuentaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.mnuItemUsuario.Name = "mnuItemUsuario"
        Me.mnuItemUsuario.Size = New System.Drawing.Size(59, 20)
        Me.mnuItemUsuario.Text = "&Usuario"
        '
        'MiCuentaToolStripMenuItem
        '
        Me.MiCuentaToolStripMenuItem.Name = "MiCuentaToolStripMenuItem"
        Me.MiCuentaToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.MiCuentaToolStripMenuItem.Text = "Mi cuenta"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMiCuenta})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMiCuenta
        '
        Me.btnMiCuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMiCuenta.Image = CType(resources.GetObject("btnMiCuenta.Image"), System.Drawing.Image)
        Me.btnMiCuenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMiCuenta.Name = "btnMiCuenta"
        Me.btnMiCuenta.Size = New System.Drawing.Size(23, 22)
        Me.btnMiCuenta.Text = "ToolStripButton1"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 365)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.mnuUsuario)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuUsuario
        Me.Name = "frmPrincipal"
        Me.Text = "Clifford"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuUsuario.ResumeLayout(False)
        Me.mnuUsuario.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuUsuario As MenuStrip
    Friend WithEvents mnuItemUsuario As ToolStripMenuItem
    Friend WithEvents MiCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtraOpciónDelMenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnMiCuenta As ToolStripButton
End Class
