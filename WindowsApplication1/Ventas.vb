Public Class Ventas
    Private Sub cambiarStock_Click(sender As Object, e As EventArgs) Handles cambiarStock.Click
        Stock.Visible = True
        Me.Visible = False

    End Sub
    Private Sub cambiarCompras_Click(sender As Object, e As EventArgs) Handles cambiarCompras.Click
        Compras.Visible = True
        Me.Visible = False

    End Sub
    Private Sub estadisticas_Click(sender As Object, e As EventArgs) Handles estadisticas.Click
        resulta2.Visible = True
        resulta2.actualizarResultados()
        Me.Visible = False
    End Sub
    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim vendedor As Integer
        Dim producto As Integer
        Dim cant As Integer
        Dim precioVenta As Integer
        Dim cantstk As Integer
        Dim Ncant As String
        Dim fallo As Boolean
        Dim ttrecaudado As Integer
        Dim vend1 As Integer
        Dim vend2 As Integer
        fallo = False
        vendedor = Val(vendedorSeleccionado.SelectedIndex)
        producto = Val(elementoSeleccionado.SelectedIndex)
        cant = (cantidadSeleccionada.Value)
        If producto = -1 Then
            elementoFallo.Visible = True
            fallo = True
        Else
            elementoFallo.Visible = False
        End If
        If vendedor = -1 Then
            vendedorFallo.Visible = True
            fallo = True
        Else
            vendedorFallo.Visible = False
        End If
        If (fallo = True) Then
            Return
        End If
        precioVenta = resulta2.r_precioVenta.Items.Item(producto)
        cantstk = resulta2.r_cantidad.Items.Item(producto)
        Ncant = cantstk - cant
        If (cant > 0) And (cantstk > 0) And (Ncant >= 0) Then
            resulta2.r_cantidad.Items.Item(producto) = (Ncant)
        ElseIf cant <= 0 Then
            MessageBox.Show("La Cantidad Ingresada tiene que ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cantidadFallo.Visible = False
            Return
        ElseIf cantstk < cant Then
            MessageBox.Show("La Cantidad Ingresada es mayor a el stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ttrecaudado = precioVenta * cant
        resulta2.r_vendido.Items.Item(producto) = resulta2.r_vendido.Items.Item(producto) + cant
        resulta2.r_recaudado.Items.Item(producto) = resulta2.r_recaudado.Items.Item(producto) + ttrecaudado
        resulta2.actualizar(False)
        Select Case (vendedor)
            Case 0
                vend1 = Val(resulta2.vendedor1Vendido.Text)
                resulta2.vendedor1Vendido.Text = vend1 + 1
                vend2 = Val(resulta2.vendedor1Recaudado.Text)
                resulta2.vendedor1Recaudado.Text = vend2 + ttrecaudado
            Case 1
                vend1 = Val(resulta2.vendedor2Vendido.Text)
                resulta2.vendedor2Vendido.Text = vend1 + 1
                vend2 = Val(resulta2.vendedor2Recaudado.Text)
                resulta2.vendedor2Recaudado.Text = vend2 + ttrecaudado
            Case 2
                vend1 = Val(resulta2.vendedor3Vendido.Text)
                resulta2.vendedor3Vendido.Text = vend1 + 1
                vend2 = Val(resulta2.vendedor3Recaudado.Text)
                resulta2.vendedor3Recaudado.Text = vend2 + ttrecaudado
        End Select




    End Sub


End Class