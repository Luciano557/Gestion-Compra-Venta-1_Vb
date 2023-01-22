Public Class Compras
    Private Sub estadisticas_Click(sender As Object, e As EventArgs) Handles estadisticas.Click
        Dim formularioresulta2 As Form
        formularioresulta2 = resulta2
        formularioresulta2.Visible = True
        resulta2.actualizarResultados()
        Me.Visible = False
    End Sub
    Private Sub irVentas_Click(sender As Object, e As EventArgs) Handles irVentas.Click
        Dim formularioVentas As Form
        formularioVentas = Ventas
        formularioVentas.Visible = True
        Me.Visible = False

    End Sub 
    Private Sub irStock_Click(sender As Object, e As EventArgs) Handles irStock.Click
        Dim formularioStock As Form
        formularioStock = Stock
        formularioStock.Visible = True
        Me.Visible = False

    End Sub
    Private Sub cambiarPrecio_Click(sender As Object, e As EventArgs) Handles cambiarPrecio.Click
        Dim indObj As String
        Dim pAnt As String
        Dim pNuevo As String
        Dim indTt As Integer
        indTt = precioCompras.Items.Count()
        indObj = InputBox("Ingrese el numero del objeto cuyo precio quiere cambiar. (Minimo 1, Maximo 15)", "indice", "1", 555, 150)

        '/////////////////If 1/////////////////
        If IsNumeric(indObj) = False Then
            MessageBox.Show("El valor ingresado no era numerico", "Error")
            Return
        ElseIf indObj > 15 Or indObj < 1 Then
            MessageBox.Show("El valor ingresado esta fuera de los parametros establecidos", "Error")
            Return
        ElseIf indObj > indTt Then
            MessageBox.Show("El valor ingresado no contiene ningun objeto", "Error")
            Return
        End If


        indObj = indObj - 1
        pAnt = resulta2.r_precioCompra.Items.Item(indObj)
        pNuevo = InputBox("Ingrese el nuevo precio del objeto " + indObj, "Nuevo Nombre", pAnt, 555, 150)

        '/////////////////If 2/////////////////
        If IsNumeric(pNuevo) Then
            If pNuevo >= 0 Then
                resulta2.r_precioCompra.Items.Item(indObj) = pNuevo
                pNuevo = pNuevo * 1.75
                resulta2.r_precioVenta.Items.Item(indObj) = pNuevo
                resulta2.actualizar(False)

            Else
                MessageBox.Show("El precio no puede ser un numero negativo", "Error")
            End If
        Else
            MessageBox.Show("El precio ingresado no es numerico", "Error")
        End If

    End Sub
    Private Sub comprarNuevo_Click(sender As Object, e As EventArgs) Handles comprarNuevo.Click
        Dim nombre As String
        Dim cant As String
        Dim precio1 As String
        Dim precio2 As Integer
        Dim proveedores As String
        Dim cantDiv As Integer
        Dim ind As Integer

        ind = resulta2.r_nombres1.Items.Count()
        '/////////////////If 1/////////////////
        If ind = 10 Then
            MessageBox.Show("se llego al limite de productos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        '/////////////////If 2/////////////////
        nombre = InputBox("Escribir el nombre del producto a comprar", "Ingresar producto", "Nombre", 100, 0)
        For i = 1 To (ind - 1) Step 1
            If (nombre = resulta2.r_nombres1.Items.Item(i)) Then
                MessageBox.Show("Este objeto ya esta en la lista", "Error")
                Return
            End If
        Next

        '/////////////////If 3/////////////////
        If nombre = "" Then
            MessageBox.Show("No se ingreso nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        '/////////////////If 4 /////////////////
        precio1 = InputBox("Ingresar precio de compra", "Ingresar precio de compra", "1000", 100, 0)
        If IsNumeric(precio1) Then
            If precio1 >= 0 Then
                precio2 = precio1
            Else
                MessageBox.Show("El precio es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            MessageBox.Show("El precio es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        '/////////////If 5/////////////////
        cant = InputBox("Ingresar la cantidad a comprar", "Ingresar cantidad", "50", 100, 0)
        If IsNumeric(cant) Then
            If cant >= 0 Then
            Else
                MessageBox.Show("La cantidad no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            MessageBox.Show("La cantidad no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        '/////////////////If 6/////////////////
        proveedores = InputBox("Ingrese la cantidad de proveedores (maximo 3)", "proveedores", "1", 100, 0)
        If IsNumeric(proveedores) = False Then
            MessageBox.Show("La cantidad de proveedores es invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf proveedores > 3 Or proveedores < 1 Then
            MessageBox.Show("La cantidad de proveedores es invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        resulta2.r_nombres1.Items.Add(nombre)
        resulta2.r_cantidad.Items.Add(cant)
        resulta2.r_precioCompra.Items.Add(precio2)
        precio2 = precio2 * 1.75
        resulta2.r_precioVenta.Items.Add(precio2)
        resulta2.añadirElemento()

        ind = ind - 1
        Select Case (proveedores)
            Case 1
                resulta2.r_proveedor1.Items.Item(ind) = +cant
            Case 2
                cantDiv = cant / 2
                resulta2.r_proveedor1.Items.Item(ind) = +cantDiv
                resulta2.r_proveedor2.Items.Item(ind) = +(cant - cantDiv)
            Case 3
                cantDiv = cant / 3
                resulta2.r_proveedor1.Items.Item(ind) = +cantDiv
                resulta2.r_proveedor2.Items.Item(ind) = +cantDiv
                resulta2.r_proveedor3.Items.Item(ind) = +(cant - (cantDiv * 2))
        End Select
    End Sub
    Public Sub buyExistent_Click(sender As Object, e As EventArgs) Handles comprarPrevio.Click
        Dim producto As Integer
        Dim cant As Integer
        Dim proveedor As Integer
        Dim fallavar As Boolean
        Dim cantDiv As Integer

        producto = Val(selectExistent.SelectedIndex)
        cant = Val(buyAmount.Value)
        proveedor = Val(providerAmount.SelectedIndex)

        '///////////////// Cadenas de If /////////////////
        If producto = -1 Then
            buyExistantA.Visible = True
            fallavar = True
        Else
            buyExistantA.Visible = False
        End If

        If cant = 0 Then
            buyExistantB.Visible = True
            fallavar = True
        Else
            buyExistantB.Visible = False
        End If
        If proveedor = -1 Then
            buyExistantC.Visible = True
            fallavar = True
        Else
            buyExistantC.Visible = False
        End If
        If (fallavar = True) Then
            Return
        End If

        If cant < (proveedor + 1) Then
            MessageBox.Show("No se puede comprar a mas proveedores que la cantidad de productos que se van a comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Select Case (proveedor + 1)
            Case 1
                resulta2.r_proveedor1.Items.Item(producto) = resulta2.r_proveedor1.Items.Item(producto) + cant
            Case 2
                cantDiv = cant / 2
                resulta2.r_proveedor1.Items.Item(producto) = resulta2.r_proveedor1.Items.Item(producto) + cantDiv
                resulta2.r_proveedor2.Items.Item(producto) = resulta2.r_proveedor2.Items.Item(producto) + (cant - cantDiv)
            Case 3
                cantDiv = cant / 3
                resulta2.r_proveedor1.Items.Item(producto) = resulta2.r_proveedor1.Items.Item(producto) + cantDiv
                resulta2.r_proveedor2.Items.Item(producto) = resulta2.r_proveedor2.Items.Item(producto) + cantDiv
                resulta2.r_proveedor3.Items.Item(producto) = resulta2.r_proveedor3.Items.Item(producto) + (cant - (cantDiv * 2))
        End Select

        resulta2.r_comprado.Items.Item(producto) = resulta2.r_comprado.Items.Item(producto) + cant
        resulta2.r_cantidad.Items.Item(producto) = resulta2.r_cantidad.Items.Item(producto) + cant
        resulta2.actualizar(False)






    End Sub
End Class
