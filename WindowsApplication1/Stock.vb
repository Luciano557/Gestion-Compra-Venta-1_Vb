Public Class Stock
    Private Sub irVentas_Click(sender As Object, e As EventArgs) Handles irVentas.Click
        Dim formVentas As Form
        formVentas = Ventas
        formVentas.Visible = True
        Me.Visible = False

    End Sub
    Private Sub irCompras_Click(sender As Object, e As EventArgs) Handles irCompras.Click
        Dim formCompras As Form
        formCompras = Compras
        formCompras.Visible = True
        Me.Visible = False

    End Sub
    Private Sub añadir_Click(sender As Object, e As EventArgs) Handles añadir.Click
        Dim producto As String
        Dim cant As String
        Dim precio As String
        Dim precio2 As Integer
        Dim precio3 As String
        Dim ind As String
        'Limite de objetos
        ind = nombresStock.Items.Count()
        If ind = 10 Then
            MessageBox.Show("se llego al limite de objetos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'añadir producto
        producto = InputBox("Ingresar el nombre del objeto que desea añadir", "Ingresar producto", "Nombre", 400, 0)
        For i = 0 To (ind - 1) Step 1
            If (producto = nombresStock.Items.Item(i)) Then
                MessageBox.Show("Este elemento ya esta en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next
        If producto = "" Then
            MessageBox.Show("No se ingreso nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        precio = InputBox("Ingresar Precio de Compra", "Ingresar precio de compra", "300", 400, 100)
        If IsNumeric(precio) Then
            If precio >= 1 Then
                precio2 = precio
                precio3 = precio2 * 1.75
            Else
                MessageBox.Show("El precio no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            MessageBox.Show("El precio no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        cant = InputBox("Ingresar cantidad", "Ingresar cantidad", "50", 400, 200)
        If IsNumeric(cant) Then
            If cant >= 1 Then

            Else
                MessageBox.Show("La cantidad no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            MessageBox.Show("La cantidad no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        resulta2.r_nombres1.Items.Add(producto)
        resulta2.r_precioCompra.Items.Add(precio2)
        resulta2.r_precioVenta.Items.Add(precio3)
        resulta2.r_cantidad.Items.Add(cant)
        resulta2.añadirElemento()
    End Sub
    Private Sub cambiarNombre_Click(sender As Object, e As EventArgs) Handles cambiarNombre.Click
        Dim ind As String
        Dim Nnuevo As String
        Dim indtt As Integer
        indtt = nombresStock.Items.Count()
        ind = InputBox("ingrese la posicion del objeto", "indice", "1", 555, 150)
        If IsNumeric(ind) = False Then
            MessageBox.Show("El valor ingresado no era numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf ind > 10 Or ind < 1 Then
            MessageBox.Show("El valor ingresado esta fuera de los parametros establecidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf ind > indtt Then
            MessageBox.Show("El valor ingresado no contiene ningun objeto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Nnuevo = InputBox("Ingresar Nuevo Nombre" + ind, "Nuevo Nombre", "Nuevo Nombre", 555, 150)
        ind = ind - 1
        resulta2.r_nombres1.Items.Item(ind) = Nnuevo
        resulta2.actualizar(False)
    End Sub
    Private Sub estadisticas_Click(sender As Object, e As EventArgs) Handles estadisticas.Click
        Dim formFDS As Form
        formFDS = resulta2
        resulta2.Visible = True
        resulta2.actualizarResultados()
        Me.Visible = False

    End Sub

End Class