<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Roles))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Permisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnActualiza = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.cbxPermiso = New System.Windows.Forms.ComboBox()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbxPermisos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnDetener = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRol, Me.Nombre, Me.Permisos})
        Me.DataGridView1.Location = New System.Drawing.Point(321, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(483, 297)
        Me.DataGridView1.TabIndex = 80
        '
        'idRol
        '
        Me.idRol.DataPropertyName = "idRol"
        Me.idRol.HeaderText = "Rol"
        Me.idRol.Name = "idRol"
        Me.idRol.ReadOnly = True
        Me.idRol.Width = 30
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 80
        '
        'Permisos
        '
        Me.Permisos.DataPropertyName = "Permisos"
        Me.Permisos.HeaderText = "Permisos"
        Me.Permisos.Name = "Permisos"
        Me.Permisos.ReadOnly = True
        Me.Permisos.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.btnActualiza)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRol)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 297)
        Me.Panel1.TabIndex = 79
        '
        'btnActualiza
        '
        Me.btnActualiza.Image = Global.SCI.My.Resources.Resources.Refresh
        Me.btnActualiza.Location = New System.Drawing.Point(181, 12)
        Me.btnActualiza.Name = "btnActualiza"
        Me.btnActualiza.Size = New System.Drawing.Size(23, 23)
        Me.btnActualiza.TabIndex = 85
        Me.btnActualiza.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.btnMenos)
        Me.Panel3.Controls.Add(Me.cbxPermiso)
        Me.Panel3.Controls.Add(Me.btnMas)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lbxPermisos)
        Me.Panel3.Location = New System.Drawing.Point(14, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 225)
        Me.Panel3.TabIndex = 84
        '
        'btnMenos
        '
        Me.btnMenos.Image = Global.SCI.My.Resources.Resources.Minus
        Me.btnMenos.Location = New System.Drawing.Point(196, 199)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(23, 23)
        Me.btnMenos.TabIndex = 66
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'cbxPermiso
        '
        Me.cbxPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPermiso.FormattingEnabled = True
        Me.cbxPermiso.Location = New System.Drawing.Point(6, 199)
        Me.cbxPermiso.MaxDropDownItems = 20
        Me.cbxPermiso.Name = "cbxPermiso"
        Me.cbxPermiso.Size = New System.Drawing.Size(155, 21)
        Me.cbxPermiso.TabIndex = 65
        '
        'btnMas
        '
        Me.btnMas.Image = Global.SCI.My.Resources.Resources.Plus
        Me.btnMas.Location = New System.Drawing.Point(167, 199)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(23, 23)
        Me.btnMas.TabIndex = 64
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Permisos:"
        '
        'lbxPermisos
        '
        Me.lbxPermisos.FormattingEnabled = True
        Me.lbxPermisos.Location = New System.Drawing.Point(6, 20)
        Me.lbxPermisos.Name = "lbxPermisos"
        Me.lbxPermisos.Size = New System.Drawing.Size(213, 173)
        Me.lbxPermisos.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Rol:"
        '
        'txtRol
        '
        Me.txtRol.Location = New System.Drawing.Point(74, 12)
        Me.txtRol.MaxLength = 5
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(100, 20)
        Me.txtRol.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(74, 38)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Privilegio:"
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Image = Global.SCI.My.Resources.Resources.Write
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(271, 111)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(44, 44)
        Me.btnModificar.TabIndex = 83
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SCI.My.Resources.Resources.Trash
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(271, 61)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(44, 44)
        Me.btnEliminar.TabIndex = 82
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.SCI.My.Resources.Resources.Save
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(271, 11)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(44, 44)
        Me.btnAgregar.TabIndex = 81
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnDetener
        '
        Me.btnDetener.Enabled = False
        Me.btnDetener.Image = Global.SCI.My.Resources.Resources.Forbidden
        Me.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetener.Location = New System.Drawing.Point(271, 161)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(44, 44)
        Me.btnDetener.TabIndex = 84
        Me.btnDetener.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDetener.UseVisualStyleBackColor = True
        '
        'Roles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 323)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Roles"
        Me.Text = "Privilegios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cbxPermiso As System.Windows.Forms.ComboBox
    Friend WithEvents btnMas As System.Windows.Forms.Button
    Friend WithEvents lbxPermisos As System.Windows.Forms.ListBox
    Friend WithEvents btnMenos As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnActualiza As System.Windows.Forms.Button
    Friend WithEvents btnDetener As System.Windows.Forms.Button
    Friend WithEvents idRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Permisos As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
