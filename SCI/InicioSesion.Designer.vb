<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(171, 135)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.TxtPass.Size = New System.Drawing.Size(156, 20)
        Me.TxtPass.TabIndex = 10
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Location = New System.Drawing.Point(171, 119)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(64, 13)
        Me.LblPass.TabIndex = 9
        Me.LblPass.Text = "&Contraseña:"
        Me.LblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Location = New System.Drawing.Point(171, 6)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(99, 13)
        Me.LblUser.TabIndex = 6
        Me.LblUser.Text = "&Nombre de usuario:"
        Me.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"admin", "user"})
        Me.ListBox1.Location = New System.Drawing.Point(171, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(156, 82)
        Me.ListBox1.TabIndex = 13
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Location = New System.Drawing.Point(171, 161)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEntrar.TabIndex = 14
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Location = New System.Drawing.Point(252, 161)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'InicioSesion
        '
        Me.AcceptButton = Me.BtnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(339, 193)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents LblPass As System.Windows.Forms.Label
    Friend WithEvents LblUser As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BtnEntrar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button

End Class
