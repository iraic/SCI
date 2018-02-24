<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextClave = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextUnidad = New System.Windows.Forms.TextBox()
        Me.TextFactor = New System.Windows.Forms.TextBox()
        Me.TextPrecio = New System.Windows.Forms.TextBox()
        Me.TextExistencia = New System.Windows.Forms.TextBox()
        Me.TextMin = New System.Windows.Forms.TextBox()
        Me.TextMax = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Factor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 201)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Existencia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 201)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mínimo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(228, 201)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Máximo:"
        '
        'TextClave
        '
        Me.TextClave.Location = New System.Drawing.Point(16, 34)
        Me.TextClave.Margin = New System.Windows.Forms.Padding(4)
        Me.TextClave.MaxLength = 15
        Me.TextClave.Name = "TextClave"
        Me.TextClave.Size = New System.Drawing.Size(132, 22)
        Me.TextClave.TabIndex = 8
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(16, 92)
        Me.TextNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextNombre.MaxLength = 50
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(315, 22)
        Me.TextNombre.TabIndex = 10
        '
        'TextUnidad
        '
        Me.TextUnidad.Location = New System.Drawing.Point(16, 154)
        Me.TextUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TextUnidad.Name = "TextUnidad"
        Me.TextUnidad.Size = New System.Drawing.Size(99, 22)
        Me.TextUnidad.TabIndex = 11
        '
        'TextFactor
        '
        Me.TextFactor.Location = New System.Drawing.Point(124, 154)
        Me.TextFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.TextFactor.Name = "TextFactor"
        Me.TextFactor.Size = New System.Drawing.Size(99, 22)
        Me.TextFactor.TabIndex = 12
        '
        'TextPrecio
        '
        Me.TextPrecio.Location = New System.Drawing.Point(232, 154)
        Me.TextPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPrecio.Name = "TextPrecio"
        Me.TextPrecio.Size = New System.Drawing.Size(99, 22)
        Me.TextPrecio.TabIndex = 13
        '
        'TextExistencia
        '
        Me.TextExistencia.Location = New System.Drawing.Point(16, 220)
        Me.TextExistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.TextExistencia.Name = "TextExistencia"
        Me.TextExistencia.Size = New System.Drawing.Size(99, 22)
        Me.TextExistencia.TabIndex = 14
        '
        'TextMin
        '
        Me.TextMin.Location = New System.Drawing.Point(124, 220)
        Me.TextMin.Margin = New System.Windows.Forms.Padding(4)
        Me.TextMin.Name = "TextMin"
        Me.TextMin.Size = New System.Drawing.Size(99, 22)
        Me.TextMin.TabIndex = 15
        '
        'TextMax
        '
        Me.TextMax.Location = New System.Drawing.Point(232, 220)
        Me.TextMax.Margin = New System.Windows.Forms.Padding(4)
        Me.TextMax.Name = "TextMax"
        Me.TextMax.Size = New System.Drawing.Size(99, 22)
        Me.TextMax.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 284)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 284)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(153, 15)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Código de barras:"
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(157, 34)
        Me.TextCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextCodigo.MaxLength = 15
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(173, 22)
        Me.TextCodigo.TabIndex = 9
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 331)
        Me.Controls.Add(Me.TextCodigo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextMax)
        Me.Controls.Add(Me.TextMin)
        Me.Controls.Add(Me.TextExistencia)
        Me.Controls.Add(Me.TextPrecio)
        Me.Controls.Add(Me.TextFactor)
        Me.Controls.Add(Me.TextUnidad)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.TextClave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Producto"
        Me.Text = "Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextClave As System.Windows.Forms.TextBox
    Friend WithEvents TextNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextUnidad As System.Windows.Forms.TextBox
    Friend WithEvents TextFactor As System.Windows.Forms.TextBox
    Friend WithEvents TextPrecio As System.Windows.Forms.TextBox
    Friend WithEvents TextExistencia As System.Windows.Forms.TextBox
    Friend WithEvents TextMin As System.Windows.Forms.TextBox
    Friend WithEvents TextMax As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextCodigo As System.Windows.Forms.TextBox
End Class
