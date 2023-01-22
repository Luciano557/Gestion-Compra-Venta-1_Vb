Public Class Login
    Private Sub botonAcceder_Click(sender As Object, e As EventArgs) Handles botonAcceder.Click
        Dim contraseña As String
        Dim acceso As Boolean
        Dim intentos As Double
        Dim formCompras As Form
        Dim formresultado As Form
        Dim formStock As Form
        Dim formVentas As Form
        Dim usuario As String


        formresultado = resulta2
        usuario = (txtUser.Text)
        contraseña = (txtPassword.Text)
        formCompras = Compras
        formStock = Stock
        acceso = False
        intentos = Val(numero.Text)
        formVentas = Ventas

        'Inicio de sesion
        If acceso = False Then
            If (usuario = "Luciano" And contraseña = "Garcia") Then
                acceso = True
                formStock.Show()
                formVentas.Show()
                formCompras.Show()
                formresultado.Show()
                formVentas.Visible = False
                formStock.Visible = False
                formresultado.Visible = False
                resulta2.actualizar(True)
                Me.Visible = False
            Else
                intentos = intentos - 1
            End If
        End If
        'msg box fallo 
        If (intentos = 0) And (acceso = False) Then
            MessageBox.Show("Has ingresado la contraseña incorrectamente mas de 3 veces, la aplicacion se cerrara", "Inicio de Sesion Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        numero.Text = intentos

    End Sub

End Class