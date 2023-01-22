<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.irVentas = New System.Windows.Forms.Button()
        Me.irStock = New System.Windows.Forms.Button()
        Me.numeros = New System.Windows.Forms.ListBox()
        Me.nombresCompras = New System.Windows.Forms.ListBox()
        Me.precioCompras = New System.Windows.Forms.ListBox()
        Me.stockCompras = New System.Windows.Forms.ListBox()
        Me.cambiarPrecio = New System.Windows.Forms.Button()
        Me.comprarNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.buyExistantC = New System.Windows.Forms.Label()
        Me.buyExistantB = New System.Windows.Forms.Label()
        Me.buyExistantA = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buyAmount = New System.Windows.Forms.NumericUpDown()
        Me.comprarPrevio = New System.Windows.Forms.Button()
        Me.providerAmount = New System.Windows.Forms.ComboBox()
        Me.selectExistent = New System.Windows.Forms.ComboBox()
        Me.estadisticas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.buyAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'irVentas
        '
        Me.irVentas.BackColor = System.Drawing.Color.Bisque
        Me.irVentas.Location = New System.Drawing.Point(393, 89)
        Me.irVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.irVentas.Name = "irVentas"
        Me.irVentas.Size = New System.Drawing.Size(132, 25)
        Me.irVentas.TabIndex = 8
        Me.irVentas.Text = "Ventas"
        Me.irVentas.UseVisualStyleBackColor = False
        '
        'irStock
        '
        Me.irStock.BackColor = System.Drawing.Color.Bisque
        Me.irStock.Location = New System.Drawing.Point(406, 136)
        Me.irStock.Margin = New System.Windows.Forms.Padding(2)
        Me.irStock.Name = "irStock"
        Me.irStock.Size = New System.Drawing.Size(104, 25)
        Me.irStock.TabIndex = 9
        Me.irStock.Text = "Stock"
        Me.irStock.UseVisualStyleBackColor = False
        '
        'numeros
        '
        Me.numeros.FormattingEnabled = True
        Me.numeros.Items.AddRange(New Object() {"  1.", "  2.", "  3.", "  4.", "  5.", "  6.", "  7.", "  8.", "  9.", "10."})
        Me.numeros.Location = New System.Drawing.Point(65, 27)
        Me.numeros.Margin = New System.Windows.Forms.Padding(2)
        Me.numeros.Name = "numeros"
        Me.numeros.Size = New System.Drawing.Size(25, 134)
        Me.numeros.TabIndex = 10
        '
        'nombresCompras
        '
        Me.nombresCompras.FormattingEnabled = True
        Me.nombresCompras.Location = New System.Drawing.Point(94, 27)
        Me.nombresCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.nombresCompras.Name = "nombresCompras"
        Me.nombresCompras.Size = New System.Drawing.Size(103, 134)
        Me.nombresCompras.TabIndex = 11
        '
        'precioCompras
        '
        Me.precioCompras.FormattingEnabled = True
        Me.precioCompras.Location = New System.Drawing.Point(201, 27)
        Me.precioCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.precioCompras.Name = "precioCompras"
        Me.precioCompras.Size = New System.Drawing.Size(61, 134)
        Me.precioCompras.TabIndex = 12
        '
        'stockCompras
        '
        Me.stockCompras.FormattingEnabled = True
        Me.stockCompras.Location = New System.Drawing.Point(266, 27)
        Me.stockCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.stockCompras.Name = "stockCompras"
        Me.stockCompras.Size = New System.Drawing.Size(40, 134)
        Me.stockCompras.TabIndex = 13
        '
        'cambiarPrecio
        '
        Me.cambiarPrecio.BackColor = System.Drawing.Color.Bisque
        Me.cambiarPrecio.Location = New System.Drawing.Point(65, 209)
        Me.cambiarPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.cambiarPrecio.Name = "cambiarPrecio"
        Me.cambiarPrecio.Size = New System.Drawing.Size(241, 25)
        Me.cambiarPrecio.TabIndex = 15
        Me.cambiarPrecio.Text = "Cambiar el precio de un producto"
        Me.cambiarPrecio.UseVisualStyleBackColor = False
        '
        'comprarNuevo
        '
        Me.comprarNuevo.BackColor = System.Drawing.Color.Bisque
        Me.comprarNuevo.Location = New System.Drawing.Point(65, 165)
        Me.comprarNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.comprarNuevo.Name = "comprarNuevo"
        Me.comprarNuevo.Size = New System.Drawing.Size(241, 25)
        Me.comprarNuevo.TabIndex = 16
        Me.comprarNuevo.Text = "Comprar un producto que no esta en el stock"
        Me.comprarNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.buyExistantC)
        Me.GroupBox1.Controls.Add(Me.buyExistantB)
        Me.GroupBox1.Controls.Add(Me.buyExistantA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.buyAmount)
        Me.GroupBox1.Controls.Add(Me.comprarPrevio)
        Me.GroupBox1.Controls.Add(Me.providerAmount)
        Me.GroupBox1.Controls.Add(Me.selectExistent)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 249)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(541, 173)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comprar stock de un producto ya existente"
        '
        'buyExistantC
        '
        Me.buyExistantC.AutoSize = True
        Me.buyExistantC.ForeColor = System.Drawing.Color.Red
        Me.buyExistantC.Location = New System.Drawing.Point(187, 128)
        Me.buyExistantC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.buyExistantC.Name = "buyExistantC"
        Me.buyExistantC.Size = New System.Drawing.Size(70, 13)
        Me.buyExistantC.TabIndex = 7
        Me.buyExistantC.Text = "* Seleccionar"
        Me.buyExistantC.Visible = False
        '
        'buyExistantB
        '
        Me.buyExistantB.AutoSize = True
        Me.buyExistantB.ForeColor = System.Drawing.Color.Red
        Me.buyExistantB.Location = New System.Drawing.Point(357, 128)
        Me.buyExistantB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.buyExistantB.Name = "buyExistantB"
        Me.buyExistantB.Size = New System.Drawing.Size(70, 13)
        Me.buyExistantB.TabIndex = 7
        Me.buyExistantB.Text = "* Seleccionar"
        Me.buyExistantB.Visible = False
        '
        'buyExistantA
        '
        Me.buyExistantA.AutoSize = True
        Me.buyExistantA.ForeColor = System.Drawing.Color.Red
        Me.buyExistantA.Location = New System.Drawing.Point(296, 44)
        Me.buyExistantA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.buyExistantA.Name = "buyExistantA"
        Me.buyExistantA.Size = New System.Drawing.Size(70, 13)
        Me.buyExistantA.TabIndex = 7
        Me.buyExistantA.Text = "* Seleccionar"
        Me.buyExistantA.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad a comprar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad de Proveedores"
        '
        'buyAmount
        '
        Me.buyAmount.Location = New System.Drawing.Point(278, 120)
        Me.buyAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.buyAmount.Name = "buyAmount"
        Me.buyAmount.Size = New System.Drawing.Size(73, 20)
        Me.buyAmount.TabIndex = 1
        '
        'comprarPrevio
        '
        Me.comprarPrevio.BackColor = System.Drawing.Color.Bisque
        Me.comprarPrevio.Location = New System.Drawing.Point(409, 69)
        Me.comprarPrevio.Margin = New System.Windows.Forms.Padding(2)
        Me.comprarPrevio.Name = "comprarPrevio"
        Me.comprarPrevio.Size = New System.Drawing.Size(105, 25)
        Me.comprarPrevio.TabIndex = 3
        Me.comprarPrevio.Text = "Comprar"
        Me.comprarPrevio.UseVisualStyleBackColor = False
        '
        'providerAmount
        '
        Me.providerAmount.FormattingEnabled = True
        Me.providerAmount.Items.AddRange(New Object() {"1", "2", "3"})
        Me.providerAmount.Location = New System.Drawing.Point(109, 120)
        Me.providerAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.providerAmount.Name = "providerAmount"
        Me.providerAmount.Size = New System.Drawing.Size(74, 21)
        Me.providerAmount.TabIndex = 2
        '
        'selectExistent
        '
        Me.selectExistent.FormattingEnabled = True
        Me.selectExistent.Location = New System.Drawing.Point(176, 36)
        Me.selectExistent.Margin = New System.Windows.Forms.Padding(2)
        Me.selectExistent.Name = "selectExistent"
        Me.selectExistent.Size = New System.Drawing.Size(116, 21)
        Me.selectExistent.TabIndex = 0
        '
        'estadisticas
        '
        Me.estadisticas.BackColor = System.Drawing.Color.Bisque
        Me.estadisticas.Location = New System.Drawing.Point(371, 31)
        Me.estadisticas.Margin = New System.Windows.Forms.Padding(2)
        Me.estadisticas.Name = "estadisticas"
        Me.estadisticas.Size = New System.Drawing.Size(181, 37)
        Me.estadisticas.TabIndex = 18
        Me.estadisticas.Text = "Cerrar aplicacion y obtener estadisticas"
        Me.estadisticas.UseVisualStyleBackColor = False
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(563, 433)
        Me.Controls.Add(Me.estadisticas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.comprarNuevo)
        Me.Controls.Add(Me.cambiarPrecio)
        Me.Controls.Add(Me.stockCompras)
        Me.Controls.Add(Me.precioCompras)
        Me.Controls.Add(Me.nombresCompras)
        Me.Controls.Add(Me.numeros)
        Me.Controls.Add(Me.irStock)
        Me.Controls.Add(Me.irVentas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.buyAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents irVentas As System.Windows.Forms.Button
    Friend WithEvents irStock As System.Windows.Forms.Button
    Friend WithEvents numeros As System.Windows.Forms.ListBox
    Friend WithEvents nombresCompras As System.Windows.Forms.ListBox
    Friend WithEvents precioCompras As System.Windows.Forms.ListBox
    Friend WithEvents stockCompras As System.Windows.Forms.ListBox
    Friend WithEvents cambiarPrecio As System.Windows.Forms.Button
    Friend WithEvents comprarNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents buyExistantC As System.Windows.Forms.Label
    Friend WithEvents buyExistantB As System.Windows.Forms.Label
    Friend WithEvents buyExistantA As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comprarPrevio As System.Windows.Forms.Button
    Friend WithEvents providerAmount As System.Windows.Forms.ComboBox
    Friend WithEvents buyAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents selectExistent As System.Windows.Forms.ComboBox
    Friend WithEvents estadisticas As System.Windows.Forms.Button

End Class
