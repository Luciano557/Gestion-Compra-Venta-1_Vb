<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Me.irCompras = New System.Windows.Forms.Button()
        Me.irVentas = New System.Windows.Forms.Button()
        Me.numeros = New System.Windows.Forms.ListBox()
        Me.nombresStock = New System.Windows.Forms.ListBox()
        Me.cantidadStock = New System.Windows.Forms.ListBox()
        Me.cambiarNombre = New System.Windows.Forms.Button()
        Me.añadir = New System.Windows.Forms.Button()
        Me.estadisticas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'irCompras
        '
        Me.irCompras.BackColor = System.Drawing.Color.Bisque
        Me.irCompras.Location = New System.Drawing.Point(306, 117)
        Me.irCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.irCompras.Name = "irCompras"
        Me.irCompras.Size = New System.Drawing.Size(96, 28)
        Me.irCompras.TabIndex = 6
        Me.irCompras.Text = "Compras"
        Me.irCompras.UseVisualStyleBackColor = False
        '
        'irVentas
        '
        Me.irVentas.BackColor = System.Drawing.Color.Bisque
        Me.irVentas.Location = New System.Drawing.Point(306, 170)
        Me.irVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.irVentas.Name = "irVentas"
        Me.irVentas.Size = New System.Drawing.Size(96, 28)
        Me.irVentas.TabIndex = 7
        Me.irVentas.Text = "Ventas"
        Me.irVentas.UseVisualStyleBackColor = False
        '
        'numeros
        '
        Me.numeros.FormattingEnabled = True
        Me.numeros.Items.AddRange(New Object() {"  1.", "  2.", "  3.", "  4.", "  5.", "  6.", "  7.", "  8.", "  9.", "10."})
        Me.numeros.Location = New System.Drawing.Point(24, 30)
        Me.numeros.Margin = New System.Windows.Forms.Padding(2)
        Me.numeros.Name = "numeros"
        Me.numeros.Size = New System.Drawing.Size(25, 134)
        Me.numeros.TabIndex = 8
        '
        'nombresStock
        '
        Me.nombresStock.FormattingEnabled = True
        Me.nombresStock.Location = New System.Drawing.Point(53, 30)
        Me.nombresStock.Margin = New System.Windows.Forms.Padding(2)
        Me.nombresStock.Name = "nombresStock"
        Me.nombresStock.Size = New System.Drawing.Size(106, 134)
        Me.nombresStock.TabIndex = 9
        '
        'cantidadStock
        '
        Me.cantidadStock.FormattingEnabled = True
        Me.cantidadStock.Location = New System.Drawing.Point(162, 30)
        Me.cantidadStock.Margin = New System.Windows.Forms.Padding(2)
        Me.cantidadStock.Name = "cantidadStock"
        Me.cantidadStock.Size = New System.Drawing.Size(48, 134)
        Me.cantidadStock.TabIndex = 10
        '
        'cambiarNombre
        '
        Me.cambiarNombre.BackColor = System.Drawing.Color.Bisque
        Me.cambiarNombre.Location = New System.Drawing.Point(24, 187)
        Me.cambiarNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.cambiarNombre.Name = "cambiarNombre"
        Me.cambiarNombre.Size = New System.Drawing.Size(186, 24)
        Me.cambiarNombre.TabIndex = 11
        Me.cambiarNombre.Text = "Cambiar el nombre de un producto"
        Me.cambiarNombre.UseVisualStyleBackColor = False
        '
        'añadir
        '
        Me.añadir.BackColor = System.Drawing.Color.Bisque
        Me.añadir.Location = New System.Drawing.Point(24, 234)
        Me.añadir.Margin = New System.Windows.Forms.Padding(2)
        Me.añadir.Name = "añadir"
        Me.añadir.Size = New System.Drawing.Size(186, 24)
        Me.añadir.TabIndex = 12
        Me.añadir.Text = "Añadir un producto a Stock"
        Me.añadir.UseVisualStyleBackColor = False
        '
        'estadisticas
        '
        Me.estadisticas.BackColor = System.Drawing.Color.Bisque
        Me.estadisticas.Location = New System.Drawing.Point(263, 53)
        Me.estadisticas.Margin = New System.Windows.Forms.Padding(2)
        Me.estadisticas.Name = "estadisticas"
        Me.estadisticas.Size = New System.Drawing.Size(186, 38)
        Me.estadisticas.TabIndex = 19
        Me.estadisticas.Text = "Cerrar aplicacion y obtener estadisticas"
        Me.estadisticas.UseVisualStyleBackColor = False
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(460, 290)
        Me.Controls.Add(Me.estadisticas)
        Me.Controls.Add(Me.añadir)
        Me.Controls.Add(Me.cambiarNombre)
        Me.Controls.Add(Me.cantidadStock)
        Me.Controls.Add(Me.nombresStock)
        Me.Controls.Add(Me.numeros)
        Me.Controls.Add(Me.irVentas)
        Me.Controls.Add(Me.irCompras)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Stock"
        Me.Text = "Stock"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents irCompras As System.Windows.Forms.Button
    Friend WithEvents irVentas As System.Windows.Forms.Button
    Friend WithEvents numeros As System.Windows.Forms.ListBox
    Friend WithEvents nombresStock As System.Windows.Forms.ListBox
    Friend WithEvents cantidadStock As System.Windows.Forms.ListBox
    Friend WithEvents cambiarNombre As System.Windows.Forms.Button
    Friend WithEvents añadir As System.Windows.Forms.Button
    Friend WithEvents estadisticas As System.Windows.Forms.Button
End Class
