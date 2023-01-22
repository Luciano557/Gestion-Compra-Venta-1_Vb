<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.cambiarStock = New System.Windows.Forms.Button()
        Me.cambiarCompras = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cantidadFallo = New System.Windows.Forms.Label()
        Me.elementoFallo = New System.Windows.Forms.Label()
        Me.vendedorFallo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.cantidadSeleccionada = New System.Windows.Forms.NumericUpDown()
        Me.vendedorSeleccionado = New System.Windows.Forms.ComboBox()
        Me.elementoSeleccionado = New System.Windows.Forms.ComboBox()
        Me.nombresVentas = New System.Windows.Forms.ListBox()
        Me.preciosVentas = New System.Windows.Forms.ListBox()
        Me.cantidadVentas = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.estadisticas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cantidadSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cambiarStock
        '
        Me.cambiarStock.BackColor = System.Drawing.Color.Bisque
        Me.cambiarStock.Location = New System.Drawing.Point(422, 89)
        Me.cambiarStock.Margin = New System.Windows.Forms.Padding(2)
        Me.cambiarStock.Name = "cambiarStock"
        Me.cambiarStock.Size = New System.Drawing.Size(101, 26)
        Me.cambiarStock.TabIndex = 6
        Me.cambiarStock.Text = "Stock"
        Me.cambiarStock.UseVisualStyleBackColor = False
        '
        'cambiarCompras
        '
        Me.cambiarCompras.BackColor = System.Drawing.Color.Bisque
        Me.cambiarCompras.Location = New System.Drawing.Point(422, 128)
        Me.cambiarCompras.Margin = New System.Windows.Forms.Padding(2)
        Me.cambiarCompras.Name = "cambiarCompras"
        Me.cambiarCompras.Size = New System.Drawing.Size(103, 26)
        Me.cambiarCompras.TabIndex = 7
        Me.cambiarCompras.Text = "Compras"
        Me.cambiarCompras.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cantidadFallo)
        Me.GroupBox1.Controls.Add(Me.elementoFallo)
        Me.GroupBox1.Controls.Add(Me.vendedorFallo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnVender)
        Me.GroupBox1.Controls.Add(Me.cantidadSeleccionada)
        Me.GroupBox1.Controls.Add(Me.vendedorSeleccionado)
        Me.GroupBox1.Controls.Add(Me.elementoSeleccionado)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 169)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(534, 158)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'cantidadFallo
        '
        Me.cantidadFallo.AutoSize = True
        Me.cantidadFallo.BackColor = System.Drawing.Color.Transparent
        Me.cantidadFallo.ForeColor = System.Drawing.Color.Red
        Me.cantidadFallo.Location = New System.Drawing.Point(338, 96)
        Me.cantidadFallo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cantidadFallo.Name = "cantidadFallo"
        Me.cantidadFallo.Size = New System.Drawing.Size(67, 13)
        Me.cantidadFallo.TabIndex = 20
        Me.cantidadFallo.Text = "*Seleccionar"
        Me.cantidadFallo.Visible = False
        '
        'elementoFallo
        '
        Me.elementoFallo.AutoSize = True
        Me.elementoFallo.BackColor = System.Drawing.Color.Transparent
        Me.elementoFallo.ForeColor = System.Drawing.Color.Red
        Me.elementoFallo.Location = New System.Drawing.Point(356, 61)
        Me.elementoFallo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.elementoFallo.Name = "elementoFallo"
        Me.elementoFallo.Size = New System.Drawing.Size(67, 13)
        Me.elementoFallo.TabIndex = 20
        Me.elementoFallo.Text = "*Seleccionar"
        Me.elementoFallo.Visible = False
        '
        'vendedorFallo
        '
        Me.vendedorFallo.AutoSize = True
        Me.vendedorFallo.BackColor = System.Drawing.Color.Transparent
        Me.vendedorFallo.ForeColor = System.Drawing.Color.Red
        Me.vendedorFallo.Location = New System.Drawing.Point(355, 25)
        Me.vendedorFallo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.vendedorFallo.Name = "vendedorFallo"
        Me.vendedorFallo.Size = New System.Drawing.Size(67, 13)
        Me.vendedorFallo.TabIndex = 20
        Me.vendedorFallo.Text = "*Seleccionar"
        Me.vendedorFallo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Elemento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Vendedor:"
        '
        'btnVender
        '
        Me.btnVender.BackColor = System.Drawing.Color.Bisque
        Me.btnVender.Location = New System.Drawing.Point(219, 125)
        Me.btnVender.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(80, 28)
        Me.btnVender.TabIndex = 16
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = False
        '
        'cantidadSeleccionada
        '
        Me.cantidadSeleccionada.Location = New System.Drawing.Point(262, 89)
        Me.cantidadSeleccionada.Margin = New System.Windows.Forms.Padding(2)
        Me.cantidadSeleccionada.Name = "cantidadSeleccionada"
        Me.cantidadSeleccionada.Size = New System.Drawing.Size(72, 20)
        Me.cantidadSeleccionada.TabIndex = 15
        '
        'vendedorSeleccionado
        '
        Me.vendedorSeleccionado.FormattingEnabled = True
        Me.vendedorSeleccionado.Items.AddRange(New Object() {"Vendedor 1", "Vendedor 2", "Vendedor 3"})
        Me.vendedorSeleccionado.Location = New System.Drawing.Point(248, 17)
        Me.vendedorSeleccionado.Margin = New System.Windows.Forms.Padding(2)
        Me.vendedorSeleccionado.Name = "vendedorSeleccionado"
        Me.vendedorSeleccionado.Size = New System.Drawing.Size(103, 21)
        Me.vendedorSeleccionado.TabIndex = 13
        '
        'elementoSeleccionado
        '
        Me.elementoSeleccionado.FormattingEnabled = True
        Me.elementoSeleccionado.Location = New System.Drawing.Point(248, 53)
        Me.elementoSeleccionado.Margin = New System.Windows.Forms.Padding(2)
        Me.elementoSeleccionado.Name = "elementoSeleccionado"
        Me.elementoSeleccionado.Size = New System.Drawing.Size(104, 21)
        Me.elementoSeleccionado.TabIndex = 14
        '
        'nombresVentas
        '
        Me.nombresVentas.FormattingEnabled = True
        Me.nombresVentas.Location = New System.Drawing.Point(94, 31)
        Me.nombresVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.nombresVentas.Name = "nombresVentas"
        Me.nombresVentas.Size = New System.Drawing.Size(102, 134)
        Me.nombresVentas.TabIndex = 18
        '
        'preciosVentas
        '
        Me.preciosVentas.FormattingEnabled = True
        Me.preciosVentas.Location = New System.Drawing.Point(200, 31)
        Me.preciosVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.preciosVentas.Name = "preciosVentas"
        Me.preciosVentas.Size = New System.Drawing.Size(61, 134)
        Me.preciosVentas.TabIndex = 20
        '
        'cantidadVentas
        '
        Me.cantidadVentas.FormattingEnabled = True
        Me.cantidadVentas.Location = New System.Drawing.Point(264, 31)
        Me.cantidadVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.cantidadVentas.Name = "cantidadVentas"
        Me.cantidadVentas.Size = New System.Drawing.Size(39, 134)
        Me.cantidadVentas.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Cantidad"
        '
        'estadisticas
        '
        Me.estadisticas.BackColor = System.Drawing.Color.Bisque
        Me.estadisticas.Location = New System.Drawing.Point(387, 31)
        Me.estadisticas.Margin = New System.Windows.Forms.Padding(2)
        Me.estadisticas.Name = "estadisticas"
        Me.estadisticas.Size = New System.Drawing.Size(163, 38)
        Me.estadisticas.TabIndex = 25
        Me.estadisticas.Text = "Cerrar aplicacion y obtener estadisticas"
        Me.estadisticas.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(561, 333)
        Me.Controls.Add(Me.estadisticas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cantidadVentas)
        Me.Controls.Add(Me.preciosVentas)
        Me.Controls.Add(Me.nombresVentas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cambiarCompras)
        Me.Controls.Add(Me.cambiarStock)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cantidadSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cambiarStock As System.Windows.Forms.Button
    Friend WithEvents cambiarCompras As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cantidadFallo As System.Windows.Forms.Label
    Friend WithEvents elementoFallo As System.Windows.Forms.Label
    Friend WithEvents vendedorFallo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVender As System.Windows.Forms.Button
    Friend WithEvents cantidadSeleccionada As System.Windows.Forms.NumericUpDown
    Friend WithEvents vendedorSeleccionado As System.Windows.Forms.ComboBox
    Friend WithEvents elementoSeleccionado As System.Windows.Forms.ComboBox
    Friend WithEvents nombresVentas As System.Windows.Forms.ListBox
    Friend WithEvents preciosVentas As System.Windows.Forms.ListBox
    Friend WithEvents cantidadVentas As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents estadisticas As System.Windows.Forms.Button
End Class
