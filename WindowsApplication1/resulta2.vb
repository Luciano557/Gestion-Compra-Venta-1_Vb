Public Class resulta2
    Public Sub actualizar(x)
        Dim pVenta As Integer
        Dim cant As Integer
        Dim ind As Integer
        Dim login As Boolean
        Dim nombre As String
        Dim pCompra As Integer

        login = x
        ind = r_nombres1.Items.Count()

        For i = 0 To (ind - 1) Step 1
            nombre = r_nombres1.Items.Item(i)
            pCompra = r_precioCompra.Items.Item(i)
            pVenta = r_precioVenta.Items.Item(i)
            cant = r_cantidad.Items.Item(i)
            If (login = True) Then
                Stock.nombresStock.Items.Add(nombre)
                Compras.nombresCompras.Items.Add(nombre)
                Compras.selectExistent.Items.Add(nombre)
                Ventas.nombresVentas.Items.Add(nombre)
                Ventas.elementoSeleccionado.Items.Add(nombre)
                r_nombre2.Items.Add(nombre)
                Compras.precioCompras.Items.Add("$" & pCompra)
                Ventas.preciosVentas.Items.Add("$" & pVenta)
                Stock.cantidadStock.Items.Add(cant)
                Compras.stockCompras.Items.Add(cant)
                Ventas.cantidadVentas.Items.Add(cant)
                r_vendido.Items.Add(0)
                r_recaudado.Items.Add(0)
                r_comprado.Items.Add(0)
                r_proveedor1.Items.Add(0)
                r_proveedor2.Items.Add(0)
                r_proveedor3.Items.Add(0)
            Else
                Stock.nombresStock.Items.Item(i) = nombre
                Compras.nombresCompras.Items.Item(i) = nombre
                Compras.selectExistent.Items.Item(i) = nombre
                Ventas.nombresVentas.Items.Item(i) = nombre
                Ventas.elementoSeleccionado.Items.Item(i) = nombre
                r_nombre2.Items.Item(i) = nombre
                Compras.precioCompras.Items.Item(i) = ("$" & pCompra)
                Ventas.preciosVentas.Items.Item(i) = ("$" & pVenta)
                Stock.cantidadStock.Items.Item(i) = (cant)
                Compras.stockCompras.Items.Item(i) = (cant)
                Ventas.cantidadVentas.Items.Item(i) = (cant)
            End If
        Next
    End Sub
    Public Sub añadirElemento()
        Dim pVenta As Integer
        Dim cant As Integer
        Dim ind As Integer
        Dim nombre As String
        Dim pCompra As Integer


        ind = r_nombres1.Items.Count() - 1
        nombre = r_nombres1.Items.Item(ind)
        pCompra = r_precioCompra.Items.Item(ind)
        pVenta = r_precioVenta.Items.Item(ind)
        cant = r_cantidad.Items.Item(ind)
        Stock.nombresStock.Items.Add(nombre)
        Compras.nombresCompras.Items.Add(nombre)
        Compras.selectExistent.Items.Add(nombre)
        Ventas.nombresVentas.Items.Add(nombre)
        Ventas.elementoSeleccionado.Items.Add(nombre)
        r_nombre2.Items.Add(nombre)
        Compras.precioCompras.Items.Add("$" & pCompra)
        Ventas.preciosVentas.Items.Add("$" & pVenta)
        Stock.cantidadStock.Items.Add(cant)
        Compras.stockCompras.Items.Add(cant)
        Ventas.cantidadVentas.Items.Add(cant)
        r_vendido.Items.Add(0)
        r_recaudado.Items.Add(0)
        r_comprado.Items.Add(0)
        r_proveedor1.Items.Add(0)
        r_proveedor2.Items.Add(0)
        r_proveedor3.Items.Add(0)

    End Sub
    Public Sub actualizarResultados()
        Dim recaudado As Integer
        Dim venta As Integer
        Dim comprado As Integer
        Dim pCompra As Integer
        Dim pVenta As Integer
        Dim cant As Integer
        Dim ind As Integer

        ind = r_nombres1.Items.Count()
        For i = 0 To (ind - 1) Step 1
            pCompra = r_precioCompra.Items.Item(i)
            pVenta = r_precioVenta.Items.Item(i)
            cant = r_cantidad.Items.Item(i)
            recaudado = r_recaudado.Items.Item(i)
            venta = r_vendido.Items.Item(i)
            comprado = r_comprado.Items.Item(i)

            r_precioCompra.Items.Item(i) = ("$" & pCompra)
            r_precioVenta.Items.Item(i) = ("$" & pVenta)
            r_cantidad.Items.Item(i) = (cant)
            r_recaudado.Items.Item(i) = ("$" & recaudado)
            r_vendido.Items.Item(i) = (venta)
            r_comprado.Items.Item(i) = (comprado)
        Next
        r_totalVendido.Text = Val(vendedor1Vendido.Text) + Val(vendedor2Vendido.Text) + Val(vendedor2Vendido.Text)
        r_totalRecaudado.Text = Val(vendedor1Recaudado.Text) + Val(vendedor2Recaudado.Text) + Val(vendedor2Recaudado.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Inicio.Close()
        Ventas.Close()
        Compras.Close()

    End Sub
End Class